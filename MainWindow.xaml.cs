using System.Windows;

namespace TodoApp {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void AddTask(object sender, RoutedEventArgs e) {
            string task = taskInput.Text;
            if (!string.IsNullOrWhiteSpace(task)) {
                taskList.Items.Add(task);
                taskInput.Clear();
            }
        }
    }
}
