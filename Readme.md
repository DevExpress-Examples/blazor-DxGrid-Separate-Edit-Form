<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/198051624/20.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T802173)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Data Grid for Blazor - How to edit a row on a separate page

This example shows how to create an edit form on a separate page.

![Edit form on a separate page](images/datagrid-with-external-edit-form.gif)

The example implements the following steps:
* Creates a Data Grid.
* Adds a template column with a hyperlink.
* Uses the hyperlink to navigate to a separate page and passes the key field value a parameter. 
* Edits the record on the separate page.
* Navigates back to the page with the Data Grid.

<!-- default file list -->
## Files to look at

* [Index.razor](./CS/DataGridSeparateEditForm/Pages/Index.razor)
* [SeparateEditForm.razor](./CS/DataGridSeparateEditForm/Pages/AdditionalPages/SeparateEditForm.razor)
<!-- default file list end -->

## Documentation

* [DisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.DisplayTemplate)
* [EditTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.EditTemplate)

## More Examples

* [Data Grid - Inline Editing](https://github.com/DevExpress-Examples/Blazor-dxdatagrid-inline-editing)