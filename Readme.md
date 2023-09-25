<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128629823/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E831)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - How to paste data from the Clipboard

The [Grid Control](https://docs.devexpress.com/WindowsForms/3455/controls-and-libraries/data-grid) supports row copy and paste operations out-of-the-box. Set the [GridView.OptionsClipboard.PasteMode](https://docs.devexpress.com/CoreLibraries/DevExpress.Export.ClipboardOptions.PasteMode) property to `Update` or `Append` to enable the **Paste from Clipboard** functionality.

Users can copy/paste rows to/from the Clipboard using the `CTRL`+`C` and `CTRL`+`V` (or `Shift`+`Insert`) shortcuts, respectively.

Use the [GridView.CopyToClipboard](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.CopyToClipboard) and [GridView.PasteFromClipboard](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.PasteFromClipboard) methods to copy/paste rows in code.

<!-- default file list -->
## Files to Review
* [Main.cs](./CS/Main.cs) (VB: [Main.vb](./VB/Main.vb))

<!-- default file list end -->

## Documentation
- [Clipboard](https://docs.devexpress.com/WindowsForms/114874/common-features/clipboard)
- [ClipboardOptions.PasteMode](https://docs.devexpress.com/CoreLibraries/DevExpress.Export.ClipboardOptions.PasteMode)
- [GridOptionsClipboard.AllowCopy](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsClipboard.AllowCopy)
