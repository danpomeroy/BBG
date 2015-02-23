Imports MetroFramework.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPawnMain
    Inherits MetroForm

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPawnMain))
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim Transition1 As DevExpress.Utils.Animation.Transition = New DevExpress.Utils.Animation.Transition()
        Dim PushTransition1 As DevExpress.Utils.Animation.PushTransition = New DevExpress.Utils.Animation.PushTransition()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.TileNavPane1 = New DevExpress.XtraBars.Navigation.TileNavPane()
        Me.NavButton2 = New DevExpress.XtraBars.Navigation.NavButton()
        Me.BtnSettings = New DevExpress.XtraBars.Navigation.NavButton()
        Me.TileNavPane2 = New DevExpress.XtraBars.Navigation.TileNavPane()
        Me.NavButton3 = New DevExpress.XtraBars.Navigation.NavButton()
        Me.BtnAbout = New DevExpress.XtraBars.Navigation.NavButton()
        Me.TileBar1 = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TbiPawn = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TbiSell = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem3 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarGroup5 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TbiInventory = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TbiReports = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TransitionManager1 = New DevExpress.Utils.Animation.TransitionManager()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(20, 214)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(1240, 446)
        Me.PnlMain.TabIndex = 3
        '
        'TileNavPane1
        '
        Me.TileNavPane1.ButtonPadding = New System.Windows.Forms.Padding(12)
        Me.TileNavPane1.Buttons.Add(Me.NavButton2)
        Me.TileNavPane1.Buttons.Add(Me.BtnSettings)
        '
        'TileNavCategory1
        '
        Me.TileNavPane1.DefaultCategory.Name = "TileNavCategory1"
        Me.TileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.DefaultCategory.OwnerCollection = Nothing
        '
        '
        '
        Me.TileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.TileNavPane1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TileNavPane1.Location = New System.Drawing.Point(20, 60)
        Me.TileNavPane1.Name = "TileNavPane1"
        Me.TileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.Size = New System.Drawing.Size(1240, 40)
        Me.TileNavPane1.TabIndex = 0
        Me.TileNavPane1.Text = "TileNavPane1"
        '
        'NavButton2
        '
        Me.NavButton2.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left
        Me.NavButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavButton2.Appearance.Options.UseFont = True
        Me.NavButton2.Caption = "NavButton2"
        Me.NavButton2.Enabled = False
        Me.NavButton2.Name = "NavButton2"
        '
        'BtnSettings
        '
        Me.BtnSettings.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.BtnSettings.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.BtnSettings.Caption = ""
        Me.BtnSettings.Glyph = CType(resources.GetObject("BtnSettings.Glyph"), System.Drawing.Image)
        Me.BtnSettings.Name = "BtnSettings"
        '
        'TileNavPane2
        '
        Me.TileNavPane2.ButtonPadding = New System.Windows.Forms.Padding(12)
        Me.TileNavPane2.Buttons.Add(Me.NavButton3)
        Me.TileNavPane2.Buttons.Add(Me.BtnAbout)
        '
        'TileNavCategory2
        '
        Me.TileNavPane2.DefaultCategory.Name = "TileNavCategory2"
        Me.TileNavPane2.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane2.DefaultCategory.OwnerCollection = Nothing
        '
        '
        '
        Me.TileNavPane2.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileNavPane2.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.TileNavPane2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TileNavPane2.Location = New System.Drawing.Point(20, 660)
        Me.TileNavPane2.Name = "TileNavPane2"
        Me.TileNavPane2.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane2.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane2.Size = New System.Drawing.Size(1240, 40)
        Me.TileNavPane2.TabIndex = 1
        '
        'NavButton3
        '
        Me.NavButton3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.NavButton3.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavButton3.Appearance.Options.UseFont = True
        Me.NavButton3.Caption = "PawnShop Manager"
        Me.NavButton3.Enabled = False
        Me.NavButton3.Glyph = Global.PSManager.My.Resources.Resources.hands_grey_48
        Me.NavButton3.Name = "NavButton3"
        '
        'BtnAbout
        '
        Me.BtnAbout.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.BtnAbout.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.BtnAbout.Caption = ""
        Me.BtnAbout.Glyph = CType(resources.GetObject("BtnAbout.Glyph"), System.Drawing.Image)
        Me.BtnAbout.Name = "BtnAbout"
        '
        'TileBar1
        '
        Me.TileBar1.AllowDrag = False
        Me.TileBar1.AllowGroupHighlighting = True
        Me.TileBar1.AllowSelectedItem = True
        Me.TileBar1.AppearanceGroupText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileBar1.AppearanceGroupText.Options.UseFont = True
        Me.TileBar1.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileBar1.AppearanceItem.Normal.Options.UseFont = True
        Me.TileBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileBar1.Groups.Add(Me.TileBarGroup2)
        Me.TileBar1.Groups.Add(Me.TileBarGroup5)
        Me.TileBar1.IndentBetweenGroups = 26
        Me.TileBar1.Location = New System.Drawing.Point(20, 100)
        Me.TileBar1.MaxId = 6
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.Padding = New System.Windows.Forms.Padding(22, 8, 22, 0)
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.SelectedItem = Me.TbiPawn
        Me.TileBar1.SelectionBorderWidth = 2
        Me.TileBar1.Size = New System.Drawing.Size(1240, 114)
        Me.TileBar1.TabIndex = 2
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.TbiPawn)
        Me.TileBarGroup2.Items.Add(Me.TbiSell)
        Me.TileBarGroup2.Items.Add(Me.TileBarItem3)
        Me.TileBarGroup2.Name = "TileBarGroup2"
        Me.TileBarGroup2.Text = "PROCESS"
        '
        'TbiPawn
        '
        Me.TbiPawn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.TbiPawn.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.TbiPawn.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbiPawn.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TbiPawn.AppearanceItem.Normal.Options.UseFont = True
        Me.TbiPawn.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Image = Global.PSManager.My.Resources.Resources.hands_grey_48
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement1.Text = "Pawn"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.TbiPawn.Elements.Add(TileItemElement1)
        Me.TbiPawn.Id = 1
        Me.TbiPawn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TbiPawn.Name = "TbiPawn"
        '
        'TbiSell
        '
        Me.TbiSell.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.TbiSell.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TbiSell.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbiSell.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TbiSell.AppearanceItem.Normal.Options.UseFont = True
        Me.TbiSell.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Image = Global.PSManager.My.Resources.Resources.money_48
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement2.Text = "Sell"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.TbiSell.Elements.Add(TileItemElement2)
        Me.TbiSell.Id = 2
        Me.TbiSell.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TbiSell.Name = "TbiSell"
        '
        'TileBarItem3
        '
        Me.TileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Text = "TileBarItem3"
        Me.TileBarItem3.Elements.Add(TileItemElement3)
        Me.TileBarItem3.Id = 3
        Me.TileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem3.Name = "TileBarItem3"
        Me.TileBarItem3.Visible = False
        '
        'TileBarGroup5
        '
        Me.TileBarGroup5.Items.Add(Me.TbiInventory)
        Me.TileBarGroup5.Items.Add(Me.TbiReports)
        Me.TileBarGroup5.Name = "TileBarGroup5"
        Me.TileBarGroup5.Text = "OPERATIONS"
        '
        'TbiInventory
        '
        Me.TbiInventory.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.TbiInventory.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TbiInventory.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TbiInventory.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TbiInventory.AppearanceItem.Normal.Options.UseFont = True
        Me.TbiInventory.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement4.Image = Global.PSManager.My.Resources.Resources.inventory_48
        TileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileItemElement4.ImageSize = New System.Drawing.Size(36, 36)
        TileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement4.Text = "Inventory"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.TbiInventory.Elements.Add(TileItemElement4)
        Me.TbiInventory.Id = 4
        Me.TbiInventory.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TbiInventory.Name = "TbiInventory"
        '
        'TbiReports
        '
        Me.TbiReports.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.TbiReports.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TbiReports.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TbiReports.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TbiReports.AppearanceItem.Normal.Options.UseFont = True
        Me.TbiReports.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement5.Image = Global.PSManager.My.Resources.Resources.graph__48
        TileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileItemElement5.ImageSize = New System.Drawing.Size(36, 36)
        TileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement5.Text = "Reports"
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.TbiReports.Elements.Add(TileItemElement5)
        Me.TbiReports.Id = 5
        Me.TbiReports.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TbiReports.Name = "TbiReports"
        '
        'TransitionManager1
        '
        Transition1.Control = Me.PnlMain
        Transition1.TransitionType = PushTransition1
        Me.TransitionManager1.Transitions.Add(Transition1)
        '
        'FrmPawnMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.TileBar1)
        Me.Controls.Add(Me.TileNavPane2)
        Me.Controls.Add(Me.TileNavPane1)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "FrmPawnMain"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TileNavPane1 As DevExpress.XtraBars.Navigation.TileNavPane
    Friend WithEvents TileNavPane2 As DevExpress.XtraBars.Navigation.TileNavPane
    Friend WithEvents NavButton3 As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents TileBar1 As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TbiPawn As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TbiSell As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarItem3 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarGroup5 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TbiInventory As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TbiReports As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents BtnSettings As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents BtnAbout As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents NavButton2 As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents TransitionManager1 As DevExpress.Utils.Animation.TransitionManager
End Class
