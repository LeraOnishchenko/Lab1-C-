using System.Windows.Controls;
using KMA.ProgrammingInCSharp2023.Lab01.DateApp.ViewModels;

namespace KMA.ProgrammingInCSharp2023.Lab01.DateApp
{
    public partial class InputControl:UserControl
    {
        public InputControl()
        {
            InitializeComponent();
            DataContext = new InputDateViewModel();
        }
    }
}
