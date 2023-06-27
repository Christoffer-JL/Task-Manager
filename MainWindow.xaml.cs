using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Task_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyTasksLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(Menuframe_My_tasks.IsVisible)
            Menuframe_My_tasks.Visibility = Visibility.Collapsed;

            else
                Menuframe_My_tasks.Visibility = Visibility.Visible;
        }

    }

  
}
