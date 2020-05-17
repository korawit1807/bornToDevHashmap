using System;
using System.Collections;
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

namespace Hashmap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(txt_key.Text, txt_value.Text);
            MessageBox.Show("Add data Success!");
            txt_key.Text = " ";
            txt_value.Text = " ";
            
        }
        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection collection = hashtable.Keys;
            foreach(string dataSH in collection)
            {
                MessageBox.Show(hashtable[dataSH].ToString());
            }
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            
           
            hashtable.Remove(txt_key.Text);
            MessageBox.Show("Remove data Success!");
            txt_key.Text= " " ;
            txt_value.Text = " ";
        }
    }
}
