using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Database2AdministratorWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Repository repository;
        private string selectedOlympicName;
        private string selectedAthleteId;
        private string selectedResidencyId;

        public MainWindow()
        {
            InitializeComponent();
            this.repository = new Repository();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }


        private void ReloadOlympics()
        {
            var dv = repository.ReadOlympics();
            grdOlympic.ItemsSource = dv;
        }

        private void ReloadAthletes()
        {
            var dv = repository.ReadAthletes();
            grdAthletes.ItemsSource = dv;
        }

        private void ReloadResidencies()
        {
            var dv = repository.ReadResidencies();
            grdResidency.ItemsSource = dv;
        }


        private void btnAddRow_Click(object sender, RoutedEventArgs e)
        {
            var tabItem = tabController.SelectedItem as TabItem;
            switch (tabItem.Header.ToString())
            {
                case "Olympics":
                    {
                        var addOlympicWin = new AddOlympicWindow();
                        addOlympicWin.ShowDialog();
                        ReloadOlympics();
                        break;
                    }
                case "Athletes":
                    {
                        var addAthleteWin = new AddAthlete();
                        addAthleteWin.ShowDialog();
                        ReloadAthletes();
                        break;
                    }
                case "Residencies":
                    {
                        NotImplemented();
                        break;
                    }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var tabItem = tabController.SelectedItem as TabItem;
            switch (tabItem.Header.ToString())
            {
                case "Olympics":
                    {
                        repository.RemoveOlympic(selectedOlympicName);
                        selectedOlympicName = null;
                        ReloadOlympics();
                        break;
                    }
                case "Athletes":
                    {

                        repository.RemoveAthlete(selectedAthleteId);
                        selectedAthleteId = null;
                        ReloadAthletes();
                        break;
                    }
                case "Residencies":
                    {
                        NotImplemented();
                        break;
                    }
            }
        }


        private void btnReload_Click(object sender, RoutedEventArgs e)
        {
            var tabItem = tabController.SelectedItem as TabItem;

            switch(tabItem.Header.ToString())
            {
                case "Olympics":
                    {
                        ReloadOlympics();
                        break;
                    }
                case "Athletes":
                    {
                        ReloadAthletes();
                        break;
                    }
                case "Residencies":
                    {
                        ReloadResidencies();
                        break;
                    }
            }
        }







        private void grdOlympic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedOlympicName = null;
            var rowView = grdOlympic.SelectedItem as DataRowView;
            if (rowView == null)
                return;

            var val = (string)rowView.Row.ItemArray[0];

            selectedOlympicName = val;
        }

        private void grdAthletes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedAthleteId = null;
            var rowView = grdAthletes.SelectedItem as DataRowView;
            if (rowView == null)
                return;

            var val = (Guid)rowView.Row.ItemArray[0];

            selectedAthleteId = val.ToString();
        }

        private void grdResidency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedResidencyId = null;
            var rowView = grdResidency.SelectedItem as DataRowView;
            if (rowView == null)
                return;

            var val = (Guid)rowView.Row.ItemArray[0];

            selectedResidencyId = val.ToString();
        }

        private void NotImplemented()
        {

            MessageBox.Show("Not yet :)");
        }

        private void grdResidency_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var resDetailsWin = new ResidencyDetails(selectedResidencyId);
            resDetailsWin.ShowDialog();
        }
    }
}
