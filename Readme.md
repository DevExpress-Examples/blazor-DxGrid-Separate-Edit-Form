<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/198051624/22.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T802173)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Grid for Blazor - How to edit a row on a separate page

This example creates an edit form on a separate page.

![Edit form on a separate page](images/datagrid-with-external-edit-form.gif)

The example shows how to do the following:

* Create a Grid.
* Add a command column template with a hyperlink to the edit form.
* Use the hyperlink to navigate to a separate page and pass the key field value. 
* Edit the record on the separate page and apply changes to the data source.
* Navigate back to the page with the Grid.

<!-- default file list -->
## Files to look at

* [Index.razor](./CS/DataGridSeparateEditForm/Pages/Index.razor)
* [SeparateEditForm.razor](./CS/DataGridSeparateEditForm/Pages/SeparateEditForm.razor)
<!-- default file list end -->

## Documentation

[CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.CellDisplayTemplate)
