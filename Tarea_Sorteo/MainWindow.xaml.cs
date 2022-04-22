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
using System.Threading;
using System.Data;  

namespace Tarea_Sorteo
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
        public string[] personas = { "Pedro #001", "Roudy #002", "Angel #003", "Sebastian #004", "Brandon #005", "Enma #006", "Arturo #007", "Dinora #008", "Camila #009", "Pabalo #010", "Nicolas #011", "Cheny #012" };
        public void Rifa()
        {
            int rr = 0;
            int Winner = 0;
            int Winner1 = 0;
            int Winner2 = 0;
            int Winner3 = 0;
            if (rr == Winner)
            {
                Random r = new Random();
                rr = Convert.ToInt32(r.Next(0, 3));
                Winner1 = rr;
                ganador1.Text = personas[rr];
            }
            if (rr == Winner1 && rr !=Winner)
            {
                Random r1 = new Random();
                rr = Convert.ToInt32(r1.Next(4, 6));
                Winner2 = rr;
                ganador2.Text = personas[rr];
            if (rr == Winner2 && rr != Winner && rr !=Winner1)
                {
                    Random r2 = new Random();
                    rr = Convert.ToInt32(r2.Next(7, 9));
                    Winner3 = rr;
                    ganador3.Text = personas[rr];
            if (rr == Winner3 && rr != Winner && rr != Winner1 && rr !=Winner2)
                    {
                        Random r3 = new Random();
                        rr = Convert.ToInt32(r3.Next(10, 12));

                        ganador4.Text = personas[rr];
                    }
                }
            }

        }
        private void SorteoN_Click(object sender, RoutedEventArgs e)
        {
            Rifa();
        }
    }

    }

    

