using Aprendices.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aprendices.Model
{
    public class Aprendiz : Notificable
    {
        private String nombre;
        private String apellido;
        private String programa;
        private double ficha;
        private double promedio;
    

    public double Promedio
        {
            get
            {
                return promedio;
            }
            set {
            if(promedio == value)
                {
                    return;
                }
                promedio = value;
                OnPropertyChanged();
            }
        }

    public double Ficha
        {
            get
            {
                return ficha;
            }
            set
            {
                if (ficha == value)
                {
                    return;
                }
                ficha = value;
                OnPropertyChanged();
            }
        }

        public String Programa
        {
            get
            {
                return programa;
            }
            set{
                if(programa == value)
                {
                    return;
                }
                programa = value;
                OnPropertyChanged();
            }
        }

        public String Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                if(apellido == value)
                {
                    return;
                }
                apellido = value;
                OnPropertyChanged();
            }
        }

        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged();
            }
        }
    }

}
