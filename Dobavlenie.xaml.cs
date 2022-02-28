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
    /// Логика взаимодействия для Dobavlenie.xaml
    /// </summary>
    public partial class Dobavlenie : Window
    {
        
        public Dobavlenie()
        {
            InitializeComponent();
            ComboBox1.ItemsSource = LearnDBEntites.GetContext().Postavka.ToList();         
            ComboBox2.ItemsSource = LearnDBEntites.GetContext().Kategorii_tovarov.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (tovarComboBox.SelectedText == null)
                errors.AppendLine("Укажите название товара!");
            if (dataP.SelectedDate == null)
                errors.AppendLine("Укажите окончание срока годности товара!");
            if (textBox.SelectedText == null)
                errors.AppendLine("Укажите количество товара!");
            if (textBox1.SelectedText == null)
                errors.AppendLine("Укажите цену товара!");
            if (ComboBox1.SelectedItem == null)
                errors.AppendLine("Укажите ID поставки товара!");
            if (ComboBox2.SelectedItem == null)
                errors.AppendLine("Укажите ID категории товара!");
            if(errors.Length >0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            LearnDBEntites.GetContext().Tovari.Add(new Tovari()
            {
                Наименование_товара = tovarComboBox.SelectedText,
                Дата_окончания_сг = dataP.SelectedDate.Value,
                Количество = Convert.ToInt32(textBox.SelectedText),
                Цена = Convert.ToInt32(textBox1.SelectedText),
                ID_поставки = Convert.ToInt32(ComboBox1.SelectedItem),
                ID_категории = Convert.ToInt32(ComboBox2.SelectedItem),
            });
            LearnDBEntites.GetContext().SaveChanges();
            ((Avtorizacia)this.Owner).UpdateData();
            MessageBox.Show("Данные успешно добавлены!");
            this.Close();


            

        }
    }
}
