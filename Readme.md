# How to implement the Copy/Paste feature


<p><strong>Starting with version 17.2</strong>, pasting data from the Clipboard is supported out of the box. To enable this feature, set the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Export.ClipboardOptions.PasteMode.property">GridView.OptionsClipboard.PasteMode</a> property to <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Export.PasteMode.enum">Update or Append</a>. In this case, you can paste data by pressing CTRL+V or using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.PasteFromClipboard.method">GridView.PasteFromClipboard</a> method. <br><br>If you are using <strong>an older version</strong>, you can paste data manually using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.SetRowCellValue.overloads">GridView.SetRowCellValue</a> method. To download the example for old versions, select a required version range in the combo box.</p>
<p><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-implement-the-copy-paste-feature-e831/17.2.3+/media/f35b66a8-ef6d-4d7a-9ee5-25d0a7baa1b1.png"><br><br></p>
<p><strong>See Also:</strong></p>
<p><a href="https://www.devexpress.com/Support/Center/p/E5201">How to implement the paste from clipboard feature</a></p>


<h3>Description</h3>

<p>Starting with version 17.2, pasting data from the Clipboard is supported out of the box. To enable this feature, set the&nbsp;<strong>GridView.OptionsClipboard.PasteMode</strong>&nbsp;property to Update or Append. It should be possible to paste data by pressing CTRL+V or using the&nbsp;<strong>GridView.PasteFromClipboard</strong>&nbsp;method.&nbsp;</p>

<br/>


