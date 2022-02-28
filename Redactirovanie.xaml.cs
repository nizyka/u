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
using System.Windows.Shapes;

namespace StorIS
{
    /// <summary>
    /// Логика взаимодействия для Redactirovanie.xaml
    /// </summary>
    public partial class Redactirovanie : Window
    {
        public Redactirovanie(Tovari tovari)
        {
            InitializeComponent();

            DataContext = tovari;
            tovarComboBox.ItemsSource = LearnDBEntites.GetContext().Tovari.ToList();

            tovarComboBox.Text = tovari.Наименование_товара;
            textBox.Text = tovari.Количество.ToString();
            textBox1.Text = tovari.Цена.ToString();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LearnDBEntites.GetContext().SaveChanges();
            ((Avtorizacia)this.Owner).UpdateData();
            this.Close();
            MessageBox.Show("");
        }
    }
}
