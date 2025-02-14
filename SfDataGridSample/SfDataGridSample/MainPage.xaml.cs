using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public SfDataGrid sfGrid;

        public MainPage()
        {
            InitializeComponent();

            Title = "Employees List";
            EmployeeViewModel viewModel = new EmployeeViewModel();
            sfGrid = new SfDataGrid
            {
                GridLinesVisibility = GridLinesVisibility.Both,
                HeaderGridLinesVisibility = GridLinesVisibility.Both,
                ColumnWidthMode = ColumnWidthMode.Auto,
                AutoGenerateColumnsMode = AutoGenerateColumnsMode.None,
                ItemsSource = viewModel.Employees,
            };

            // Create a new style for the header
            var headerStyle = new Style(typeof(DataGridRowHeaderCell))
            {
                Setters =
                {
                    new Setter { Property = DataGridRowHeaderCell.TextColorProperty, Value = Colors.Yellow },
                    new Setter { Property = DataGridRowHeaderCell.FontAttributesProperty, Value = FontAttributes.Bold },
                    new Setter { Property = DataGridRowHeaderCell.FontSizeProperty, Value = 25.0 },
                }
            };

            sfGrid.Columns.Add(new DataGridNumericColumn
            {
                MappingName = "EmployeeID",
                Format = "#",
                HeaderText = "Employee ID",
                HeaderStyle = headerStyle,

            });

            sfGrid.Columns.Add(new DataGridTextColumn
            {
                MappingName = "Name",
                HeaderText = "Employee Name"
            });

            sfGrid.Columns.Add(new DataGridTextColumn
            {
                MappingName = "Title",
                HeaderText = "Designation"
            });

            sfGrid.Columns.Add(new DataGridDateColumn
            {
                MappingName = "HireDate",
                HeaderText = "Hire Date"
            });

            this.Content = sfGrid;
        }

    }

}
