using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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


namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region MainW
        public MainWindow()
        {
            InitializeComponent();
            mainButtons.Visibility = Visibility.Visible;
            newShoppingList.Visibility = Visibility.Hidden;
            NewBucketBox.Visibility = Visibility.Hidden;
            ReturnButton.Visibility = Visibility.Hidden;
            updateGoodGrid.Visibility = Visibility.Hidden;
            PreviousShoppingGrid.Visibility = Visibility.Hidden;
        }

        private void newShopping(object sender, RoutedEventArgs e)
        {
            mainButtons.Visibility = Visibility.Hidden;
            newShoppingList.Visibility = Visibility.Visible;
            NewBucketBox.Visibility = Visibility.Visible;
            ReturnButton.Visibility = Visibility.Visible;
            PreviousShoppingGrid.Visibility = Visibility.Hidden;

        }

        private void previousLists(object sender, RoutedEventArgs e)
        {
            mainButtons.Visibility = Visibility.Hidden;
            newShoppingList.Visibility = Visibility.Hidden;
            NewBucketBox.Visibility = Visibility.Hidden;
            ReturnButton.Visibility = Visibility.Visible;
            updateGoodGrid.Visibility = Visibility.Hidden;
            PreviousShoppingGrid.Visibility = Visibility.Visible;
        }

        private void updateGood(object sender, RoutedEventArgs e)
        {
            updateGoodGrid.Visibility = Visibility.Visible;
            mainButtons.Visibility = Visibility.Hidden;
            ReturnButton.Visibility = Visibility.Visible;
            PreviousShoppingGrid.Visibility = Visibility.Hidden;
        }
        #endregion
        #region NewShList

        private void ScanQR(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void deleteGood(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void FinishShopping(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region updateG

        #endregion
        #region PreviousShopping
        /*https://stackoverflow.com/questions/49672241/how-to-display-a-list-of-list-in-datagrid-wpf-using-c-sharp*/
        #endregion
        #region Statistics
        private void saveBarsToPdf(object sender, RoutedEventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            PrintDialog dia = new PrintDialog();
           // dia.PrintDocument = doc;
        }
        #endregion
        #region Global
        private void ret(object sender, RoutedEventArgs e)
        {
            mainButtons.Visibility = Visibility.Visible;
            newShoppingList.Visibility = Visibility.Hidden;
            NewBucketBox.Visibility = Visibility.Hidden;
            ReturnButton.Visibility = Visibility.Hidden;
            updateGoodGrid.Visibility = Visibility.Hidden;
            PreviousShoppingGrid.Visibility = Visibility.Hidden;
        }
        #endregion
    }
}
