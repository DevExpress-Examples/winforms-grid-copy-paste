Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace PasteData

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
            gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = False
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            gridControl1 = New DevExpress.XtraGrid.GridControl()
            gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            panelControl1 = New DevExpress.XtraEditors.PanelControl()
            simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            gridControl1.Dock = DockStyle.Fill
            gridControl1.Location = New System.Drawing.Point(4, 4)
            gridControl1.MainView = gridView1
            gridControl1.Name = "gridControl1"
            gridControl1.Size = New System.Drawing.Size(535, 293)
            gridControl1.TabIndex = 0
            gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {gridView1})
            ' 
            ' gridView1
            ' 
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = False
            ' 
            ' simpleButton1
            ' 
            simpleButton1.Location = New System.Drawing.Point(139, 6)
            simpleButton1.Name = "simpleButton1"
            simpleButton1.Size = New System.Drawing.Size(123, 29)
            simpleButton1.TabIndex = 1
            simpleButton1.Text = "Paste"
            AddHandler simpleButton1.Click, New EventHandler(AddressOf simpleButton1_Click)
            ' 
            ' panelControl1
            ' 
            panelControl1.Controls.Add(simpleButton2)
            panelControl1.Controls.Add(simpleButton1)
            panelControl1.Dock = DockStyle.Bottom
            panelControl1.Location = New System.Drawing.Point(4, 297)
            panelControl1.Name = "panelControl1"
            panelControl1.Size = New System.Drawing.Size(535, 41)
            panelControl1.TabIndex = 2
            ' 
            ' simpleButton2
            ' 
            simpleButton2.Location = New System.Drawing.Point(6, 6)
            simpleButton2.Name = "simpleButton2"
            simpleButton2.Size = New System.Drawing.Size(127, 29)
            simpleButton2.TabIndex = 2
            simpleButton2.Text = "Copy"
            AddHandler simpleButton2.Click, New EventHandler(AddressOf simpleButton2_Click)
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(6, 15)
            ClientSize = New System.Drawing.Size(543, 342)
            Me.Controls.Add(gridControl1)
            Me.Controls.Add(panelControl1)
            Name = "Form1"
            Padding = New Padding(4)
            Text = "How to implement the Copy/Paste feature"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub

        Private Property ClipboardData As String
            Get
                Dim iData As IDataObject = Clipboard.GetDataObject()
                If iData Is Nothing Then Return ""
                If iData.GetDataPresent(DataFormats.Text) Then Return CStr(iData.GetData(DataFormats.Text))
                Return ""
            End Get

            Set(ByVal value As String)
                Clipboard.SetDataObject(value)
            End Set
        End Property

        Private tbl As DataTable

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            tbl = New DataTable()
            For i As Integer = 0 To 3 - 1
                tbl.Columns.Add("Column" & i.ToString())
            Next

            For i As Integer = 0 To 4 - 1
                tbl.Rows.Add(New Object() {"Item" & i.ToString(), i, 3 - i})
            Next

            gridControl1.DataSource = tbl
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim data As String() = ClipboardData.Split(Microsoft.VisualBasic.Strings.ChrW(10))
            If data.Length < 1 Then Return
            For Each row As String In data
                AddRow(row)
            Next
        End Sub

        Private Sub AddRow(ByVal data As String)
            If Equals(data, String.Empty) Then Return
            Dim rowData As String() = data.Split(New Char() {Microsoft.VisualBasic.Strings.ChrW(13), Microsoft.VisualBasic.Strings.ChrW(9)})
            Dim newRow As DataRow = tbl.NewRow()
            For i As Integer = 0 To rowData.Length - 1
                If i >= tbl.Columns.Count Then Exit For
                newRow(i) = rowData(i)
            Next

            tbl.Rows.Add(newRow)
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.CopyToClipboard()
        End Sub
    End Class
End Namespace
