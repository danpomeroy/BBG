<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcPawn
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileBar1 = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TileBarItem1 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem2 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TbiSearch = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.SuspendLayout()
        '
        'TileBar1
        '
        Me.TileBar1.AllowDrag = False
        Me.TileBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileBar1.Groups.Add(Me.TileBarGroup2)
        Me.TileBar1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileBar1.Location = New System.Drawing.Point(0, 377)
        Me.TileBar1.MaxId = 3
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.Size = New System.Drawing.Size(1264, 103)
        Me.TileBar1.TabIndex = 0
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.TileBarItem1)
        Me.TileBarGroup2.Items.Add(Me.TbiSearch)
        Me.TileBarGroup2.Items.Add(Me.TileBarItem2)
        Me.TileBarGroup2.Name = "TileBarGroup2"
        '
        'TileBarItem1
        '
        Me.TileBarItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.TileBarItem1.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TileBarItem1.AppearanceItem.Normal.Options.UseFont = True
        Me.TileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement4.Text = "TileBarItem1"
        Me.TileBarItem1.Elements.Add(TileItemElement4)
        Me.TileBarItem1.Id = 0
        Me.TileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem1.Name = "TileBarItem1"
        '
        'TileBarItem2
        '
        Me.TileBarItem2.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.TileBarItem2.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TileBarItem2.AppearanceItem.Normal.Options.UseFont = True
        Me.TileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement5.Text = "TileBarItem2"
        Me.TileBarItem2.Elements.Add(TileItemElement5)
        Me.TileBarItem2.Id = 1
        Me.TileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem2.Name = "TileBarItem2"
        '
        'TbiSearch
        '
        Me.TbiSearch.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.TbiSearch.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TbiSearch.AppearanceItem.Normal.Options.UseFont = True
        Me.TbiSearch.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement6.Image = Global.PSManager.My.Resources.Resources.search_32
        TileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement6.ImageSize = New System.Drawing.Size(28, 28)
        TileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement6.Text = "Search"
        Me.TbiSearch.Elements.Add(TileItemElement6)
        Me.TbiSearch.Id = 2
        Me.TbiSearch.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TbiSearch.Name = "TbiSearch"
        '
        'UcPawn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TileBar1)
        Me.Name = "UcPawn"
        Me.Size = New System.Drawing.Size(1264, 480)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TileBar1 As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TileBarItem1 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarItem2 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TbiSearch As DevExpress.XtraBars.Navigation.TileBarItem

End Class
