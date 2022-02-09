<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128629823/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E831)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Data Grid for Windows Forms - How to paste data from the Clipboard

The [Grid Control](https://docs.devexpress.com/WindowsForms/3455/controls-and-libraries/data-grid) supports row copy and paste operations out-of-the-box. 
This example demonstrates this functionality.

To enable row paste operations in your application, set the [GridView.OptionsClipboard.PasteMode](https://docs.devexpress.com/CoreLibraries/DevExpress.Export.ClipboardOptions.PasteMode) property to `Update` or `Append`. You can paste rows as follows:
- Press the CTRL+V shortcut.
- Call the [GridView.PasteFromClipboard](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.PasteFromClipboard) method.


<!-- default file list -->
## Files to Look At

* [DataHelper.cs](./CS/DataHelper.cs) (VB: [DataHelper.vb](./VB/DataHelper.vb))
* [Main.cs](./CS/Main.cs) (VB: [Main.vb](./VB/Main.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->

