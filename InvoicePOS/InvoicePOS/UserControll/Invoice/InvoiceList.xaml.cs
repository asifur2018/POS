using InvoicePOS.Models;
using InvoicePOS.ViewModels;
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

namespace InvoicePOS.UserControll.Invoice
{
    /// <summary>
    /// Interaction logic for Invoice.xaml
    /// </summary>
    public partial class Invoice : UserControl
    {
        InvoiceViewModel _InvoiceViewModel;
        public Invoice()
        {
            InitializeComponent();
            _InvoiceViewModel = new InvoiceViewModel();
            this.DataContext = _InvoiceViewModel;
        }

        private void grdInvoice_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var str = (GetInvoiceModel)dataGrid1.SelectedItem;
            _InvoiceViewModel.View_INvoice();
        }

    }

}
