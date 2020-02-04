using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Xml.Serialization;


namespace DataManage_v1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ObservableCollection<Object> listData;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listData = new ObservableCollection<Object>();
            list.ItemsSource = listData;

            //var obj = new Object();
            //var writer = new System.Xml.Serialization.XmlSerializer(typeof(Object));
            //var wfile = new System.IO.StreamWriter(@"C:/Users/Stradvision/source/repos/DataManage_v1/DataManage_v1/test.xml");
            //writer.Serialize(wfile, obj);
            //wfile.Close();

            //// Now we can read the serialized book ...  
            ////System.Xml.Serialization.XmlSerializer reader =
            ////    new System.Xml.Serialization.XmlSerializer(typeof(Object));
            ////System.IO.StreamReader file = new System.IO.StreamReader(
            ////    @"C:/Users/Stradvision/source/repos/DataManage_v1/DataManage_v1/test.xml");
            ////Object overview = (Object)reader.Deserialize(file);
            ////file.Close();

            ////Console.WriteLine(overview.Type);


            XmlSerializer deserializer = new XmlSerializer(typeof(Object));
            TextReader reader = new StreamReader(@"C:/Users/Stradvision/source/repos/DataManage_v1/DataManage_v1/test.xml");

            //object obj = deserializer.Deserialize(reader);
            Object overview = (Object)deserializer.Deserialize(reader);
            listData.Add((Object)overview);
            reader.Close();

        }
    }


}
