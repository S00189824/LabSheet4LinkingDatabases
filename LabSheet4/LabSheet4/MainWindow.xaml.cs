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

namespace LabSheet4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

        public enum Stocklevel { Low, Normal, Overstocked}

    public partial class MainWindow : Window
    {

        public NORTHWNDEntities NW;

        public MainWindow()
        {
            InitializeComponent();
            NW = new NORTHWNDEntities();
        }

        private void lbxSuppliers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int supplierID = Convert.ToInt32(lbxSuppliers.SelectedValue);

            var query = from p in NW.Products
                        where p.SupplierID == supplierID
                        orderby p.ProductName
                        select p.ProductName;


            lbxProducts.ItemsSource = query.ToList();
        }

        private void lbxStock_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //What was selected =- Low, Normal, Overstocked

            string stocklevel = lbxStock.SelectedItem as string; //Eg - Low

                var query = from p in NW.Products
                            where p.UnitsInStock < 50
                            select p.ProductName;

                lbxProducts.ItemsSource = query.ToList();



            string selected = lbxStock.SelectedItem as string;

            switch(selected)
            {
                case "Low":
                    break;
                case "Normal":
                        query = from p in NW.Products
                                where p.UnitsInStock >= 50 && p.UnitsInStock <= 100
                                orderby p.ProductName
                                select p.ProductName;

                    break;

                case "Overstocked":
                    query = from p in NW.Products
                            where p.UnitsInStock > 100
                            orderby p.ProductName
                            select p.ProductName;


                    break;
            }

            lbxProducts.ItemsSource = query.ToList();
        }

        private void lbxCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string country = (string)(lbxCountries.SelectedValue);


            var query = from p in NW.Products
                        where p.Supplier.Country == country
                        orderby p.ProductName
                        select p.ProductName;


            lbxProducts.ItemsSource = query.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbxStock.ItemsSource = Enum.GetNames(typeof(Stocklevel));

            var query1 = from s in NW.Suppliers
                         orderby s.CompanyName
                         select new
                         {
                             SupplierName = s.CompanyName,
                             SupplierId = s.SupplierID,
                             country = s.Country
                         };


            lbxSuppliers.ItemsSource = query1.ToList();

            var query2 = query1
                .OrderBy(s => s.country)
                .Select(s => s.country);

            var countries = query2.ToList();
            lbxCountries.ItemsSource = countries.Distinct();
        }
    }
}
