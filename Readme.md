<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/198051624/20.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T802173)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Data Grid for Blazor - How to edit a row on a separate page

The Data Grid was moved to maintenance support mode. No new features/capabilities will be added to this component. We recommend that you [migrate](https://docs.devexpress.com/Blazor/403162/grid/migrate-from-data-grid-to-grid) to the [Grid](https://docs.devexpress.com/Blazor/403143/grid) component. 

This example creates an edit form on a separate page.

![Edit form on a separate page](images/datagrid-with-external-edit-form.gif)

The example shows how to do the following:

* Create a Data Grid.
* Add a template column with a hyperlink.
* Use the hyperlink to navigate to a separate page and pass the key field value a parameter. 
* Edit the record on the separate page.
* Navigate back to the page with the Data Grid.

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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-DxGrid-Separate-Edit-Form&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-DxGrid-Separate-Edit-Form&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
