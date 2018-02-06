using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace FlatUi
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var gridItems = new ObservableCollection<Student>();
            var rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                gridItems.Add(new Student(i, "Student"+i, rand.Next(99999999).ToString()));
            }

            DataGrid.ItemsSource = gridItems;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool Married { get; set; }

        public Student(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Married = false;
        }
    }
}
