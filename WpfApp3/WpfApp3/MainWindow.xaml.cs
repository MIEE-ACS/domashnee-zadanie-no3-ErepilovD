using System.Linq;
using System.Windows;

namespace Home_3
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

        void func_1(bool check)
        {
            string text = tb_1.Text;
            text = text.ToLower();
            var text_start = text.ToArray();

            var fine_text = "";
            var mas_text = fine_text.ToArray();

            char[] new_text = new char[text_start.Length];

            int value = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (check == true)
                {
                    string glass = "аеёиоуыэюя";
                    var check_mass = glass.ToArray();

                    fine_text = glass;
                    mas_text = check_mass;
                }
                else
                {
                    string soglass = "бвгджзйклмнпрстфхцчшщъь";
                    var check_mass = soglass.ToArray();

                    fine_text = soglass;
                    mas_text = check_mass;
                }

                for (int j = 0; j < fine_text.Length; j++)
                {

                    if (text_start[i] == mas_text[j])
                    {
                        value += 1;
                    }
                }
            }

            if (check == true)
            {
                tb_2.Text = "Количество гласных в данном тексте: " + value;
            }
            else
            {
                tb_2.Text = "Количество согласных в данном тексте: " + value;
            }

        }

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {
            if (tb_1.Text == "")
            {
                MessageBox.Show("Введите текст для поиска гласных!");
            }
            else
            {
                bool check = true;
                tb_2.Text = "";
                func_1(check);
            }
        }
        private void bt_2_Click(object sender, RoutedEventArgs e)
        {
            if (tb_1.Text == "")
            {
                MessageBox.Show("Введите текст для поиска согласных!");
            }
            else
            {
                bool check = false;
                tb_2.Text = "";
                func_1(check);
            }
        }

    }
}