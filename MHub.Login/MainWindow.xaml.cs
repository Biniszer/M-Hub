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

namespace MHub.Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
 public partial class MainWindow : Window
    {
    public MainWindow()
        {
            InitializeUI();
        }

    private void LoginButton_Click() => InitializeUI();

    private void InitializeUI()
        {
            InitializeComponent();
            // Add any additional UI initialization logic here
        }
    }
}
