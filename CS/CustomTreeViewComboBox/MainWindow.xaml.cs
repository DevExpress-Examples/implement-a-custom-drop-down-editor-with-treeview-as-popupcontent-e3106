﻿using System;
using System.Collections.Generic;
using System.Linq;
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
using DevExpress.Xpf.Grid;
using System.Collections;
using System.Collections.ObjectModel;

namespace CustomTreeViewComboBox
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;
            lookUpEdit.ItemsSource = Stuff.GetStuff();
        }
    }
    
    public class Employee
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }

    public static class Stuff
    {
        public static List<Employee> GetStuff()
        {
            List<Employee> stuff = new List<Employee>();
            stuff.Add(new Employee() { ID = 1, ParentID = 0, Name = "Gregory S. Price", Department = "", Position = "President" });
            stuff.Add(new Employee() { ID = 2, ParentID = 1, Name = "Irma R. Marshall", Department = "Marketing", Position = "Vice President" });
            stuff.Add(new Employee() { ID = 3, ParentID = 1, Name = "John C. Powell", Department = "Operations", Position = "Vice President" });
            stuff.Add(new Employee() { ID = 4, ParentID = 1, Name = "Christian P. Laclair", Department = "Production", Position = "Vice President" });
            stuff.Add(new Employee() { ID = 5, ParentID = 1, Name = "Karen J. Kelly", Department = "Finance", Position = "Vice President" });

            stuff.Add(new Employee() { ID = 6, ParentID = 2, Name = "Brian C. Cowling", Department = "Marketing", Position = "Manager" });
            stuff.Add(new Employee() { ID = 7, ParentID = 2, Name = "Thomas C. Dawson", Department = "Marketing", Position = "Manager" });
            stuff.Add(new Employee() { ID = 8, ParentID = 2, Name = "Angel M. Wilson", Department = "Marketing", Position = "Manager" });
            stuff.Add(new Employee() { ID = 9, ParentID = 2, Name = "Bryan R. Henderson", Department = "Marketing", Position = "Manager" });

            stuff.Add(new Employee() { ID = 10, ParentID = 3, Name = "Harold S. Brandes", Department = "Operations", Position = "Manager" });
            stuff.Add(new Employee() { ID = 11, ParentID = 3, Name = "Michael S. Blevins", Department = "Operations", Position = "Manager" });
            stuff.Add(new Employee() { ID = 12, ParentID = 3, Name = "Jan K. Sisk", Department = "Operations", Position = "Manager" });
            stuff.Add(new Employee() { ID = 13, ParentID = 3, Name = "Sidney L. Holder", Department = "Operations", Position = "Manager" });

            stuff.Add(new Employee() { ID = 14, ParentID = 4, Name = "James L. Kelsey", Department = "Production", Position = "Manager" });
            stuff.Add(new Employee() { ID = 15, ParentID = 4, Name = "Howard M. Carpenter", Department = "Production", Position = "Manager" });
            stuff.Add(new Employee() { ID = 16, ParentID = 4, Name = "Jennifer T. Tapia", Department = "Production", Position = "Manager" });

            stuff.Add(new Employee() { ID = 17, ParentID = 5, Name = "Judith P. Underhill", Department = "Finance", Position = "Manager" });
            stuff.Add(new Employee() { ID = 18, ParentID = 5, Name = "Russell E. Belton", Department = "Finance", Position = "Manager" });
            return stuff;
        }
    }
}
