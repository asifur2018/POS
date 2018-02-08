﻿using System;
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
using InvoicePOS.ViewModels.Customer;
using InvoicePOS.ViewModels;
using System.Printing;

namespace InvoicePOS.UserControll.Customer
{
    /// <summary>
    /// Interaction logic for ViewLedger.xaml
    /// </summary>
    public partial class ViewLedger : Window
    {
        CustomerViewModel _CustomerViewModel = new CustomerViewModel();
       
        public static TextBox FAccount;
        public static TextBlock CBalance;
        public static TextBlock OBalance;
        public static TextBlock CreditLmt;
        public static TextBlock DebitLmt;
        public static TextBox CompanyList;
        public static TextBox BusinessList;
        public ViewLedger()
        {
            InitializeComponent();
            _CustomerViewModel = new CustomerViewModel();
            this.DataContext = _CustomerViewModel;

            textbox.Text = "";
            FAccount = textbox;

            textblock1.Text = "";
            CBalance = textblock1;

            textblock2.Text = "";
            OBalance = textblock2;

            textblock3.Text = "";
            CreditLmt = textblock3;

            textblock4.Text = "";
            DebitLmt = textblock4;

            textbox4.Text = "";
            BusinessList = textbox4;

            textbox5.Text = "";
            CompanyList = textbox5;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PrintCharts(this.ViewLedgercust);
        }
        private void PrintCharts(Grid grid)
        {
            PrintDialog print = new PrintDialog();
            if (print.ShowDialog() == true)
            {
                PrintCapabilities capabilities = print.PrintQueue.GetPrintCapabilities(print.PrintTicket);

                double scale = Math.Min(capabilities.PageImageableArea.ExtentWidth / grid.ActualWidth,
                                        capabilities.PageImageableArea.ExtentHeight / grid.ActualHeight);

                Transform oldTransform = grid.LayoutTransform;

                grid.LayoutTransform = new ScaleTransform(scale, scale);

                Size oldSize = new Size(grid.ActualWidth, grid.ActualHeight);
                Size sz = new Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);
                grid.Measure(sz);
                ((UIElement)grid).Arrange(new Rect(new Point(capabilities.PageImageableArea.OriginWidth, capabilities.PageImageableArea.OriginHeight),
                    sz));

                print.PrintVisual(grid, "Print Results");
                grid.LayoutTransform = oldTransform;
                grid.Measure(oldSize);

                ((UIElement)grid).Arrange(new Rect(new Point(0, 0),
                    oldSize));
            }
        }
    }
}