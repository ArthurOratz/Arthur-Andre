using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Agenda.ViewModel
{
    public class ModelContatos
    {
        public ModelAgenda context { get; set; }
        public ObservableCollection<Contato> contatos { get; set; }
        public Contato contatoSelecionado { get; set; }

        public ModelContatos()
        {
            context = new ModelAgenda();
            this.contatos = new ObservableCollection<Contato>(context.Contatos.ToList());
            this.contatoSelecionado = context.Contatos.FirstOrDefault();

        }
        public void adicionar()
        {
            Contato c = new Contato();
            this.contatos.Add(c);
            this.context.Contatos.Add(c);
            this.contatoSelecionado = c;
        }
        public void Salvar()
        {
            this.context.SaveChanges();
        }
    }
    
}
