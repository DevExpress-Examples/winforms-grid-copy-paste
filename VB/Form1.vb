Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace PasteData
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
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
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(4, 4)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(535, 293)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = False
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(139, 6)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(123, 29)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Paste"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton2)
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(4, 297)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(535, 41)
			Me.panelControl1.TabIndex = 2
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(6, 6)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(127, 29)
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "Copy"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
			Me.ClientSize = New System.Drawing.Size(543, 342)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(4)
			Me.Text = "How to implement the Copy/Paste feature"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Property ClipboardData() As String
			Get
				Dim iData As IDataObject = Clipboard.GetDataObject()
				If iData Is Nothing Then
					Return ""
				End If

				If iData.GetDataPresent(DataFormats.Text) Then
					Return CStr(iData.GetData(DataFormats.Text))
				End If
				Return ""
			End Get
			Set(ByVal value As String)
				Clipboard.SetDataObject(value)
			End Set
		End Property

		Private tbl As DataTable
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			tbl = New DataTable()
			For i As Integer = 0 To 2
				tbl.Columns.Add("Column" & i.ToString())
			Next i
			For i As Integer = 0 To 3
				tbl.Rows.Add(New Object() { "Item" & i.ToString(), i, 3 - i })
			Next i
			gridControl1.DataSource = tbl
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			Dim data() As String = ClipboardData.Split(ControlChars.Lf)
			If data.Length < 1 Then
				Return
			End If
			For Each row As String In data
				AddRow(row)
			Next row
		End Sub

		Private Sub AddRow(ByVal data As String)
			If data = String.Empty Then
				Return
			End If
			Dim rowData() As String = data.Split(New Char() { ControlChars.Cr, ChrW(&H09) })
			Dim newRow As DataRow = tbl.NewRow()
			For i As Integer = 0 To rowData.Length - 1
				If i >= tbl.Columns.Count Then
					Exit For
				End If
				newRow(i) = rowData(i)
			Next i
			tbl.Rows.Add(newRow)
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			gridView1.CopyToClipboard()
		End Sub
	End Class
End Namespace
