Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors

Namespace PasteData
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()

            gridControl1.DataSource = DataHelper.GetData(10)
            gridView1.OptionsSelection.MultiSelect = True
            gridView1.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Append
        End Sub
        Private Sub OnButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanel1.ButtonClick
            If e.Button.Properties.Caption = "Copy" Then
                gridView1.CopyToClipboard()
            End If
            If e.Button.Properties.Caption = "Paste" Then
                gridView1.PasteFromClipboard()
            End If
        End Sub
    End Class
End Namespace
