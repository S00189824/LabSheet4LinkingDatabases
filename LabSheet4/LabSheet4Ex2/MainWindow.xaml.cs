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

namespace LabSheet4Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AdventureLiteEntities db = new AdventureLiteEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from o in db.SalesOrderHeaders
                        orderby o.Customer.CompanyName
                        select o.Customer.CompanyName;

            //var Result = query.ToList();

            lbxCustomers.ItemsSource = query.ToList().Distinct();
        }

        private void LbxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string customer = lbxCustomers.SelectedItem as string;

            if(customer != null)
            {
                //var query = from o in db.SalesOrderHeaders
                //            where o.Customer.CompanyName.Equals(customer)
                //            select new OrderSummary
                //            {
                //                salesOrderID = o.SalesOrderID,
                //                OrderDate = o.OrderDate,
                //                TotalDue = o.TotalDue
                //            };

                var query = from o in db.SalesOrderHeaders
                            where o.Customer.CompanyName.Equals(customer)
                            select o;

                lbxOrders.ItemsSource = query.ToList();
            }
        }

        private void LbxOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int orderID = Convert.ToInt32(lbxOrders.SelectedValue);

            if(orderID > 0)
            {
                var query = from od in db.SalesOrderDetails
                            where od.SalesOrderID == orderID
                            select new
                            {
                                ProductName = od.Product.Name,
                                od.UnitPrice,
                                od.UnitPriceDiscount,
                                od.OrderQty,
                                od.LineTotal

                            };

                dgOrderDetails.ItemsSource = query.ToList();
            }
        }

        //public partial class SalesOrderHeader
        //{
        //    public override string ToString()
        //    {
        //        return string.Format("{0}:{1} {2:C}",
        //            )
        //    }
        //}

        public class OrderSummary : SalesOrderHeader
        {
            public override string ToString()
            {
                return string.Format("{0}:{1} {2:C}",
                    OrderDate.ToShortDateString(), SalesOrderID, TotalDue);
            }
        }
    }
}
