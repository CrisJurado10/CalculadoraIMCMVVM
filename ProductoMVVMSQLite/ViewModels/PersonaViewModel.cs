using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoMVVMSQLite.ViewModels
{
    public partial class PersonaViewModel :ObservableObject
    {
        [ObservableProperty]
        public string _Nombre;

        [ICommand]
        public void Save()
        {

        }
    }
}
