using System.Windows;
namespace WpfMenuExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, Open_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, Save_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Close, Close_Executed));
        }
        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Открытие файла");
        }
        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Сохранение файла");
        }
        private void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        private void AutoRefresh_Click(object sender, RoutedEventArgs e)
        {
            var item = sender as MenuItem;
            if (item.IsChecked)
            {
                MessageBox.Show("Автообновление включено.");
            }
            else
            {
                MessageBox.Show("Автообновление отключено.");
            }
        }
    }
}
