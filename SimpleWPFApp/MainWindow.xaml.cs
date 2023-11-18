using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement e1 in MainRoot.Children)
            {
                if (e1 is Button)
                {
                    ((Button) e1).Click += Button_Click;
                }
            }

            foreach (UIElement e1 in MainRoot.Children)
            {
                
                if (e1 is Button)
                {
                    Button butt = (Button)e1;
                    if (butt.Name != "buttonequal" || butt.Name != "buttonclear")
                    {
                        butt.Width = 80;
                        butt.Height = 45;
                    }
                    buttonequal.Width = 160;
                    buttonclear.Width = 160;
                }
            }

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            answer.Text += str;
        }
    }
}