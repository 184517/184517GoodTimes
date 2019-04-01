/* Jordan Ross
* March 29, 2019
* Good Times Program
*/
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

namespace _184517GoodTimes
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

        private void btnTime_Click(object sender, RoutedEventArgs e)
        {
            string TempTime = txtTime.Text;
            int.TryParse(TempTime, out int OttawaTime);
            int StJohnTime = OttawaTime + 130;
            int HalifaxTime = OttawaTime + 100;
            int WinnipegTime = OttawaTime - 100;
            int EdmontonTime = OttawaTime - 200;
            int VictoriaTime = OttawaTime - 300;

            if (StJohnTime > 2359) StJohnTime = StJohnTime - 2400;
            if (StJohnTime % 100 > 59) StJohnTime = StJohnTime - 60 + 100;
            if (HalifaxTime > 2359) HalifaxTime = HalifaxTime - 2400;
            if (VictoriaTime > 2359) VictoriaTime = VictoriaTime - 2400;
            if (WinnipegTime < 0) WinnipegTime = WinnipegTime + 2400;
            if (EdmontonTime < 0) EdmontonTime = EdmontonTime + 2400;
            if (VictoriaTime < 0) VictoriaTime = VictoriaTime + 2400;
            if (OttawaTime % 100 > 59) OttawaTime = OttawaTime - 60 + 100;

            lblOutput.Content = "The time in Victoria, BC is " + VictoriaTime.ToString() + Environment.NewLine
                + "The time in Edmonton, AB is " + EdmontonTime.ToString() + Environment.NewLine
                + "The time in Winnipeg, MB is " + WinnipegTime.ToString() + Environment.NewLine
                + "The time in Toronto, ON is " + OttawaTime.ToString() + Environment.NewLine
                + "The time in Halifax, NS is " + HalifaxTime.ToString() + Environment.NewLine
                + "The time in St.John's, NL is " + StJohnTime.ToString() + Environment.NewLine;



        }
    }
}
