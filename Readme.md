<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/198051624/23.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T802173)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Grid for Blazor - How to edit a row on a separate page

The DevExpress Blazor Grid offers multiple data editing options (including inline data editing within row cells). In this example, a separate edit form is used to modify row data.

![Edit form on a separate page](images/datagrid-with-external-edit-form.gif)

This example demonstrates how you can:

* Add a Blazor Grid to a project
* Add a command column template with a hyperlink to the edit form (the hyperlink is used to navigate to the edit form. It also passes the key field value to the edit form).
* Edit row data in a separate page and apply changes to the data source.
* Navigate back to the original page.

## Files to Review

* [Index.razor](./CS/DataGridSeparateEditForm/Pages/Index.razor)
* [SeparateEditForm.razor](./CS/DataGridSeparateEditForm/Pages/SeparateEditForm.razor)

## Documentation

[CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.CellDisplayTemplate)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-DxGrid-Separate-Edit-Form&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-DxGrid-Separate-Edit-Form&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
