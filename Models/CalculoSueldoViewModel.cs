using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4955511Sueldo.Models
{
    partial class CalculoSueldoViewModel : ObservableObject
    {
        [ObservableProperty]
        public string sueldo;

        [ObservableProperty]
        public string sueldoaumentado;

        [RelayCommand]
        private void AumentarSueldo()
        {
            if (double.TryParse(Sueldo, out double s))
            {
                double sa;

                if (s <= 1000)
                {


                    sa = ((s * 0.15) + s);
                    Sueldoaumentado = sa.ToString("$0.00");

                }
                else
                {
                    sa = ((s * 0.12) + s);
                    Sueldoaumentado = sa.ToString("$0.00");
                }
            }
            else
            {
                Sueldoaumentado = "Ingrese números válidos";
            }
        }
    }
}
