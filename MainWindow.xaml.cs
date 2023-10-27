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

namespace _27._09._2023_Команды
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isChanged = false;

        public MainWindow() {
            InitializeComponent();

            CommandBinding binding;
            binding = new CommandBinding(ApplicationCommands.New);
            binding.Executed += NewCommand;
            CommandBindings.Add(binding);

            binding = new CommandBinding(ApplicationCommands.Open);
            binding.Executed += OpenCommand;
            CommandBindings.Add(binding);

            binding = new CommandBinding (ApplicationCommands.Close);
            binding.Executed += CloseCommand;
            CommandBindings.Add(binding);
        }

        private void NewCommand(object sender, ExecutedRoutedEventArgs e) { 
            textBox.Clear();
            isChanged = false;
        }

        private void OpenCommand(object sender, ExecutedRoutedEventArgs e) {
            
            isChanged = false;
        }

        private void CloseCommand(object sender, ExecutedRoutedEventArgs e) { 
            this.Close();
        }


    }
}
