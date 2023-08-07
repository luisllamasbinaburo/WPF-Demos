using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class MainViewModel : ReactiveObject
    {
        public MainViewModel()
        {
        }

        public void LoadData()
        {
            Personas.Add(new PersonaVM()
            {
                Nombre = "A",
                Apellido = "1",
            });

            Personas.Add(new PersonaVM()
            {
                Nombre = "B",
                Apellido = "2",
            });

            Personas.Add(new PersonaVM()
            {
                Nombre = "C",
                Apellido = "3",
            });
        }

        public string NewNombre { get; set; }

        public ObservableCollection<PersonaVM> Personas { get; set; } = new ObservableCollection<PersonaVM>();

        public void AddPersona()
        {
            if (String.IsNullOrEmpty(NewNombre)) return;

            Personas.Add(new PersonaVM()
            {
                Nombre = NewNombre,
            });

            NewNombre = "";
        }

        public void RemovePersona(PersonaVM vm)
        {
            if (vm == null) return;
            Personas.Remove(vm);
        }
    }
}
