Namespace PasteData
    Partial Public Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim windowsUIButtonImageOptions1 As New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Main))
            Dim windowsUIButtonImageOptions2 As New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Me.windowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' windowsUIButtonPanel1
            ' 
            windowsUIButtonImageOptions1.Image = (CType(resources.GetObject("windowsUIButtonImageOptions1.Image"), System.Drawing.Image))
            windowsUIButtonImageOptions2.Image = (CType(resources.GetObject("windowsUIButtonImageOptions2.Image"), System.Drawing.Image))
            Me.windowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() { _
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("Copy", True, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), _
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("Paste", True, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False) _
            })
            Me.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.windowsUIButtonPanel1.Location = New System.Drawing.Point(0, 408)
            Me.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1"
            Me.windowsUIButtonPanel1.Size = New System.Drawing.Size(689, 75)
            Me.windowsUIButtonPanel1.TabIndex = 0
            Me.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(689, 408)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(689, 483)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.windowsUIButtonPanel1)
            Me.Name = "Main"
            Me.Text = "Main"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents windowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace