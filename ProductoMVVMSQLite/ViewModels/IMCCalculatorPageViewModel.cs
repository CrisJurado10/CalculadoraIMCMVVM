using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoMVVMSQLite.ViewModels
{
    public partial class IMCCalculatorPageViewModel : ObservableObject
    {
        //height es altura

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IMCScore))]
        [AlsoNotifyChangeFor(nameof(IMCResultado))]
        public double _altura;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IMCScore))]
        [AlsoNotifyChangeFor(nameof(IMCResultado))]
        public double _peso;

        public double IMCScore
            => Math.Round(Peso / Math.Pow(Altura / 100, 2), 2);

        public string IMCResultado
        {
            get
            {
                if (IMCScore < 18.5)
                    return "Tienes un peso muy bajo";
                else if (IMCScore < 25)
                    return "Estas en el peso adecuado";
                else if (IMCScore < 30)
                    return "Estas un poco pasado de peso";
                else
                    return "Estas muy obeso";
            }
        }
    }
}
