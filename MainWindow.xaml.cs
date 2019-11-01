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
using MySql.Data.MySqlClient;
using System.Data;


namespace WpfNC1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        
              MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=bimhdb; password=Romanoleg1");
              con.Open();
              MySqlDataAdapter adp = new MySqlDataAdapter("select * from bimhdb.goods", con);
              DataTable dt = new DataTable();
              adp.Fill(dt);
              DataGrid1.DataContext = dt;
            
        }


    }
}

