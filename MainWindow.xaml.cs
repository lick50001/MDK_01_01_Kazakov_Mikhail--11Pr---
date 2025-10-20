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

namespace _11Pr_Kazakov
{
    public partial class MainWindow : Window
    {
        private List<string> students = new List<string>
        {
            "Казаков Михаил Андреевич",
            "Петров Евгений Сергеевич",
            "Иванов Иван Иванович",
            "Смирнов Владислав Олегович",
            "Кузнецов Степан Дмитриевич",
            "Рамазанов Назир Магомедович",
            "Соколов Максим Алексеевич",
            "Волков Николай Павлович"
        };

        public MainWindow()
        {
            InitializeComponent();
            DisplayNames();
        }

        public void DisplayNames()
        {
            DisplayNames(", ");
        }

        public void DisplayNames(string znak)
        {
            string result = string.Join(znak, students);
            ResultOutput.Content = result;
        }

        private void ShowInfo(object sender, RoutedEventArgs e)
        {
            string znak = SeparatorInput.Text;
            DisplayNames(znak);
        }
    }
}
