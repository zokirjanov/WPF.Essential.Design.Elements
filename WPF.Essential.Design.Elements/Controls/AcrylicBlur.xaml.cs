using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.Essential.Design.Elements.Controls
{
    /// <summary>
    /// Логика взаимодействия для AcrylicBlur.xaml
    /// </summary>
    public partial class AcrylicBlur : UserControl
    {
        public AcrylicBlur()
        {
            InitializeComponent();
        }

        public void SwitchBlur(bool option)
        {
            if(option == false)
            {
                this.Visibility = Visibility.Collapsed;
            }
            else
            {
                this.Visibility = Visibility.Visible;
            }
        }
    }
}
