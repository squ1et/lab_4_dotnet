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

namespace lab_4
{
    public partial class MainWindow : Window
    {
        private const double SeniorProgrammerSalary = 120000.00;
        private const double JuniorProgrammerSalary = 60000.00;
        private const double DesignerSalary = 90000.00;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProgrammerCalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string level = ((ComboBoxItem)ProgrammerLevelComboBox.SelectedItem).Content.ToString();
            double annualSalary = level == "Senior" ? SeniorProgrammerSalary : JuniorProgrammerSalary;

            Programmer programmer = new Programmer("Software Developer", 5, annualSalary, level);

            double monthlySalary = programmer.CalcMonthSalary();
            ProgrammerSalaryResult.Text = $"${monthlySalary:N2}";

            ProgrammerProjectsList.ItemsSource = programmer.GetProjectsList();
        }

        private void DesignerCalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(DesignerHoursTextBox.Text, out int hoursWorked) || hoursWorked < 0)
            {
                MessageBox.Show("Please enter a valid positive number for project hours.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Designer designer = new Designer("UI/UX Designer", 3, DesignerSalary, DesignerSpecializationText.Text);

            designer.ProjectHoursWorked = hoursWorked;
            double monthlySalary = designer.CalcMonthSalary();

            DesignerSalaryResult.Text = $"${monthlySalary:N2}";

            DesignerProjectsList.ItemsSource = designer.GetProjectsList();
        }
    }
}
