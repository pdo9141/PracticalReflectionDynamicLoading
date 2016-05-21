using System;
using System.Windows;
using Factory.RepositoryFactory;
using PersonRepository.Interface;

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IPersonRepository repository;

        public MainWindow()
        {
            InitializeComponent();
            //repository = RepositoryFactory.GetPersonRepository();
            repository = GenericFactory.Get<IPersonRepository>();
        }

        private void FetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            var people = repository.GetPeople();
            foreach (var person in people)
                PersonListBox.Items.Add(person);

            ShowRepositoryType(repository);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            RepositoryTypeLabel.Content = String.Empty;
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            RepositoryTypeLabel.Content = repository.GetType().FullName;
        }
        
        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
        }
    }
}
