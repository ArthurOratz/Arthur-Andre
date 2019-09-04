using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Agenda.ViewModel
{
    public class ViewModelCompromisso
    {
        public ModelAgenda context { get; set; }
        public ObservableCollection<Compromisso> compromissos { get; set; }
        public Compromisso compromissoSelecionado { get; set; }

        public ViewModelCompromisso()
        {
            context = new ModelAgenda();
            this.compromissos = new ObservableCollection<Compromisso>(context.Compromissos.ToList());
            this.compromissoSelecionado = context.Compromissos.FirstOrDefault();
        }

        public void AdicionarCompromisso()
        {
            Compromisso c = new Compromisso();
            this.compromissos.Add(c);
            this.context.Compromissos.Add(c);
            this.compromissoSelecionado = c;
        }
        public void Salvar()
        {
            context.SaveChanges();
        }
    }
}
