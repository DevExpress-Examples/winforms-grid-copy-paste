
<!-- default file list -->
*Files to look at*:

* [DataHelper.cs](./CS/DataHelper.cs) (VB: [DataHelper.vb](./VB/DataHelper.vb))
* [Main.cs](./CS/Main.cs) (VB: [Main.vb](./VB/Main.vb))
* [Programcs.cs](./CS/Programcs.cs) (VB: [Programcs.vb](./VB/Programcs.vb))
<!-- default file list end -->
# How to implement the Copy/Paste feature

## <strong>Starting with version 17.2</strong>, pasting data from the Clipboard is supported out of the box.
<p>To enable this feature, set the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Export.ClipboardOptions.PasteMode.property">GridView.OptionsClipboard.PasteMode</a> property to <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Export.PasteMode.enum">Update or Append</a>. In this case, you can paste data by pressing CTRL+V or using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.PasteFromClipboard.method">GridView.PasteFromClipboard</a> method. <br>

## ***If the built-in functionality does not suit you, we will be happy to find the most appropriate solution for you if you describe your real-life scenario. Just click <a href="https://www.devexpress.com/Support/Center/Question/Create">here</a> to submit a ticket to our Support Center.***

If you are using <strong>an older version</strong>, you can paste data manually using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.SetRowCellValue.overloads">GridView.SetRowCellValue</a> method. To download the example for old versions, select a required version in the Branch combo box.</p>
<p><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-implement-the-copy-paste-feature-e831/13.1.4%2B/media/2019-04-04_20-04-18.gif"><br><br></p>
<p><strong>See Also:</strong></p>
<p><a href="https://www.devexpress.com/Support/Center/p/E5201">How to implement the paste from clipboard feature</a></p>
