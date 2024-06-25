<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E831)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to implement the Copy/Paste feature

<p><strong>Important note.</strong></p>
Starting with version 17.2</strong>, pasting data from the Clipboard is supported out of the box.
<p>To enable this feature, set the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Export.ClipboardOptions.PasteMode.property">GridView.OptionsClipboard.PasteMode</a> property to <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Export.PasteMode.enum">Update or Append</a>. In this case, you can paste data by pressing CTRL+V or using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.PasteFromClipboard.method">GridView.PasteFromClipboard</a> method. <br>

## ***If the built-in functionality does not suit you, we will be happy to find the most appropriate solution for you if you describe your real-life scenario. Just click <a href="https://www.devexpress.com/Support/Center/Question/Create">here</a> to submit a ticket to our Support Center.***

If you are using <strong>an older version</strong>, you can paste data manually using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.SetRowCellValue.overloads">GridView.SetRowCellValue</a> method. To download the example for old versions, select a required version in the Branch combo box.</p>
<p><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-implement-the-copy-paste-feature-e831/13.1.4%2B/media/2019-04-04_20-04-18.gif"><br><br></p>
<p><strong>See Also:</strong></p>
<p><a href="https://www.devexpress.com/Support/Center/p/E5201">How to implement the paste from clipboard feature</a></p>
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-copy-paste&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-copy-paste&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
