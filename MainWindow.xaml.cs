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

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// list<Third>Third=new List<Third>();
    public partial class MainWindow : Window
       
    {
        public MainWindow()
        {
            InitializeComponent();
            Third breshna = new Third();
            breshna.nickname = "waheed";
            MessageBox.Show(breshna.Lastname);
            Third.add(breshna);
            breshna.lastname = "naimmm";





















            //first waheed = new first();

            //second breshna = new second("breshna");
           // MessageBox.Show(breshna);
            //instance
           // first whatismoviename = new first();
           // whatismoviename.moviesname = "asmawaheed";
           // MessageBox.Show(whatismoviename.moviesname);
           // whatismoviename.year = 22000;
            //MessageBox.Show(whatismoviename.year.ToString());

            //second class2 = new second();
           // class2.firstnam = "breshna";
            //class2.lastname = "naim";
           // class2.sicgrade = 120;
            //string information = class2.firstnam + "\n" +
               // class2.lastname + "" +
               // class2.sicgrade;
           // MessageBox.Show]);

               
    }
}
