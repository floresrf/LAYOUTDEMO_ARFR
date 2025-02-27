using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using CRITICOGRAFO_MVVM.Models;

namespace CRITICOGRAFO_MVVM.ViewModels
{
    internal class UserViewModel : INotifyPropertyChanged
    {
        private string name;
        private string gender;
        private bool alto;
        private bool feo;
        private bool listo;
        private bool extravagante;
        private bool raro;
        private bool grande;
        private string mensaje;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Gender
        {
            get => gender; 
            set
            {
                if (gender != value)
                {
                    gender = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Alto
        {
            get => alto;
            set
            {
                if (alto != value)
                {
                    alto = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Feo
        {
            get => feo;
            set
            {
                if (feo != value)
                {
                    feo = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Listo
        {
            get => listo;
            set
            {
                if (listo != value)
                {
                    listo = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Extravagante
        {
            get => extravagante;
            set
            {
                if (extravagante != value)
                {
                    extravagante = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Raro
        {
            get => raro;
            set
            {
                if (raro != value)
                {
                    raro = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Grande
        {
            get => grande;
            set
            {
                if (grande != value)
                {
                    grande = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Mensaje
        {
            get => mensaje;
            set
            {
                if (mensaje != value)
                {
                    mensaje = value;
                    OnPropertyChanged();
                }
            }
        }

        //LOGICA

        public ICommand generarMensageCommand { get; }

        public UserViewModel()
        {
            generarMensageCommand = new Command(ctriticarMSG);
        }

        private void ctriticarMSG()
        {
            var attributes = new List<string>();

            string genderMsg = Gender == "Hombre" ? "un hombre," : "una mujer,";

            if (Alto) attributes.Add("Alto");
            if (Feo) attributes.Add("Feo");
            if (Listo) attributes.Add("Listo");
            if (Extravagante) attributes.Add("Extravagante");
            if (Raro) attributes.Add("Raro");
            if (Grande) attributes.Add("Grande");

            if (attributes.Count == 0)
            {
                attributes.Add("sin atributos");
            }

            Mensaje = $"{Name} es {genderMsg} {string.Join(", ", attributes)}.";

            OnPropertyChanged(nameof(Mensaje));
        }

        

        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
