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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginPage.Views
{
    /// <summary>
    /// Logique d'interaction pour LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction qui va permettre d'appeller une storyboard que nous aurons réalisé
        /// </summary>
        /// <param name="nomStoryboard">Paramètre représentant le nom de la storyboard réalisé</param>
        public void PlayStoryboard(string nomStoryboard)
        {
            Storyboard Animation = this.FindResource(nomStoryboard) as Storyboard;

            Animation.Begin();
        }

        private void BtnCallLogin_Click(object sender, RoutedEventArgs e)
        {
            PlayStoryboard("ShowLogin");
        }


        private void BtnCallSignUp_Click(object sender, RoutedEventArgs e)
        {
            PlayStoryboard("ShowSignUp");
        }
    }
}
