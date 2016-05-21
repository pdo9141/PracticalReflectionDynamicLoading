using System;
using System.Windows;
using Factory.RepositoryFactory;
using GenericRepository.Interface;
using PeopleViewer.SharedObjects;

namespace PeopleViewer.GenericInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IRepository<Person, string> repository;

        public MainWindow()
        {
            InitializeComponent();
            repository = GenericFactory.Get<IRepository<Person, string>>();
        }

        private void FetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            var people = repository.GetItems();
            foreach (var person in people)
                PersonListBox.Items.Add(person);

            ShowRepositoryType(repository);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            RepositoryTypeLabel.Content = String.Empty;
        }

        private void ShowRepositoryType(IRepository<Person, string> repository)
        {
            RepositoryTypeLabel.Content = repository.GetType().FullName;
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
        }
    }
}
