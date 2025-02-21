# How to set the HeaderStyle in code-behind in .NET MAUI DataGrid (SfDataGrid) ?
In this article, we will show you how to set the HeaderStyle in code-behind in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## Xaml.cs
The code below demonstrates how to set the HeaderStyle in code-behind in SfDataGrid.
```
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
```

<img src="https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1ODY0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.RU5BPTIg-hzUMRLA0z8E-RzWyG_6HFxfpM_eiVwU4Uk" width=700/>

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-set-the-HeaderStyle-in-code-behind-in-.NET-MAUI-DataGrid-SfDataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to set the HeaderStyle in code-behind in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!