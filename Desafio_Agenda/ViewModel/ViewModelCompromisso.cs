using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Agenda.ViewModel
{
    class ViewModelCompromisso
    {
        public ModelAgenda context { get; set; }
        public ObservableCollection<Compromisso> Compromissos { get; set; }
        public Compromisso compromissoSelecionado { get; set; }
    }
}
