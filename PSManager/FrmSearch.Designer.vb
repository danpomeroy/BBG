<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
    Inherits System.Windows.Forms.Form

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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileBar1 = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TbiCancel = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TbiOk = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TbiClear = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TileBar1
        '
        Me.TileBar1.AllowDrag = False
        Me.TableLayoutPanel1.SetColumnSpan(Me.TileBar1, 3)
        Me.TileBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileBar1.Groups.Add(Me.TileBarGroup2)
        Me.TileBar1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileBar1.Location = New System.Drawing.Point(3, 403)
        Me.TileBar1.MaxId = 5
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.Size = New System.Drawing.Size(751, 100)
        Me.TileBar1.TabIndex = 0
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.TbiCancel)
        Me.TileBarGroup2.Items.Add(Me.TbiClear)
        Me.TileBarGroup2.Items.Add(Me.TbiOk)
        Me.TileBarGroup2.Name = "TileBarGroup2"
        '
        'TbiCancel
        '
        Me.TbiCancel.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.TbiCancel.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.TbiCancel.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TbiCancel.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TbiCancel.AppearanceItem.Normal.Options.UseFont = True
        Me.TbiCancel.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Image = Global.PSManager.My.Resources.Resources.cancel_32
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileItemElement1.ImageSize = New System.Drawing.Size(28, 28)
        TileItemElement1.Text = "Cancel"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.TbiCancel.Elements.Add(TileItemElement1)
        Me.TbiCancel.Id = 3
        Me.TbiCancel.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TbiCancel.Name = "TbiCancel"
        '
        'TbiOk
        '
        Me.TbiOk.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.TbiOk.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TbiOk.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbiOk.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TbiOk.AppearanceItem.Normal.Options.UseFont = True
        Me.TbiOk.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Image = Global.PSManager.My.Resources.Resources.checkmark_32
        TileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileItemElement3.ImageSize = New System.Drawing.Size(28, 28)
        TileItemElement3.Text = "OK"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.TbiOk.Elements.Add(TileItemElement3)
        Me.TbiOk.Id = 2
        Me.TbiOk.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TbiOk.Name = "TbiOk"
        '
        'TbiClear
        '
        Me.TbiClear.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.TbiClear.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TbiClear.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TbiClear.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TbiClear.AppearanceItem.Normal.Options.UseFont = True
        Me.TbiClear.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Image = Global.PSManager.My.Resources.Resources.clear_32
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileItemElement2.ImageSize = New System.Drawing.Size(28, 28)
        TileItemElement2.Text = "Clear"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.TbiClear.Elements.Add(TileItemElement2)
        Me.TbiClear.Id = 4
        Me.TbiClear.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TbiClear.Name = "TbiClear"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TextEdit9)
        Me.LayoutControl1.Controls.Add(Me.TextEdit8)
        Me.LayoutControl1.Controls.Add(Me.TextEdit7)
        Me.LayoutControl1.Controls.Add(Me.TextEdit6)
        Me.LayoutControl1.Controls.Add(Me.TextEdit5)
        Me.LayoutControl1.Controls.Add(Me.TextEdit4)
        Me.LayoutControl1.Controls.Add(Me.TextEdit3)
        Me.LayoutControl1.Controls.Add(Me.TextEdit2)
        Me.LayoutControl1.Controls.Add(Me.TextEdit1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(112, 53)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(697, 226, 250, 350)
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LayoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(533, 344)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TextEdit9
        '
        Me.TextEdit9.Location = New System.Drawing.Point(185, 264)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.TextEdit9.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TextEdit9.Properties.Appearance.Options.UseBorderColor = True
        Me.TextEdit9.Properties.Appearance.Options.UseFont = True
        Me.TextEdit9.Size = New System.Drawing.Size(336, 32)
        Me.TextEdit9.StyleController = Me.LayoutControl1
        Me.TextEdit9.TabIndex = 7
        '
        'TextEdit8
        '
        Me.TextEdit8.Location = New System.Drawing.Point(185, 228)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.TextEdit8.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TextEdit8.Properties.Appearance.Options.UseBorderColor = True
        Me.TextEdit8.Properties.Appearance.Options.UseFont = True
        Me.TextEdit8.Size = New System.Drawing.Size(336, 32)
        Me.TextEdit8.StyleController = Me.LayoutControl1
        Me.TextEdit8.TabIndex = 6
        '
        'TextEdit7
        '
        Me.TextEdit7.Location = New System.Drawing.Point(185, 192)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.TextEdit7.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TextEdit7.Properties.Appearance.Options.UseBorderColor = True
        Me.TextEdit7.Properties.Appearance.Options.UseFont = True
        Me.TextEdit7.Size = New System.Drawing.Size(336, 32)
        Me.TextEdit7.StyleController = Me.LayoutControl1
        Me.TextEdit7.TabIndex = 5
        '
        'TextEdit6
        '
        Me.TextEdit6.Location = New System.Drawing.Point(185, 156)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.TextEdit6.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TextEdit6.Properties.Appearance.Options.UseBorderColor = True
        Me.TextEdit6.Properties.Appearance.Options.UseFont = True
        Me.TextEdit6.Size = New System.Drawing.Size(336, 32)
        Me.TextEdit6.StyleController = Me.LayoutControl1
        Me.TextEdit6.TabIndex = 4
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(185, 120)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.TextEdit5.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TextEdit5.Properties.Appearance.Options.UseBorderColor = True
        Me.TextEdit5.Properties.Appearance.Options.UseFont = True
        Me.TextEdit5.Size = New System.Drawing.Size(336, 32)
        Me.TextEdit5.StyleController = Me.LayoutControl1
        Me.TextEdit5.TabIndex = 3
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(185, 84)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TextEdit4.Properties.Appearance.Options.UseBorderColor = True
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Size = New System.Drawing.Size(336, 32)
        Me.TextEdit4.StyleController = Me.LayoutControl1
        Me.TextEdit4.TabIndex = 2
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(185, 48)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TextEdit3.Properties.Appearance.Options.UseBorderColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Size = New System.Drawing.Size(336, 32)
        Me.TextEdit3.StyleController = Me.LayoutControl1
        Me.TextEdit3.TabIndex = 1
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(185, 12)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TextEdit2.Properties.Appearance.Options.UseBorderColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Size = New System.Drawing.Size(336, 32)
        Me.TextEdit2.StyleController = Me.LayoutControl1
        Me.TextEdit2.TabIndex = 0
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(185, 300)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TextEdit1.Properties.Appearance.Options.UseBorderColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(336, 32)
        Me.TextEdit1.StyleController = Me.LayoutControl1
        Me.TextEdit1.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(533, 344)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.TextEdit2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(513, 36)
        Me.LayoutControlItem2.Text = "Ticket Number:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(170, 21)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem3.Control = Me.TextEdit3
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(513, 36)
        Me.LayoutControlItem3.Text = "Drivers License Number:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(170, 21)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem4.Control = Me.TextEdit4
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(513, 36)
        Me.LayoutControlItem4.Text = "First Name:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(170, 21)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem5.Control = Me.TextEdit5
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 108)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(513, 36)
        Me.LayoutControlItem5.Text = "Last Name:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(170, 21)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem6.Control = Me.TextEdit6
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(513, 36)
        Me.LayoutControlItem6.Text = "Phone Number:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(170, 21)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem7.Control = Me.TextEdit7
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 180)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(513, 36)
        Me.LayoutControlItem7.Text = "Street Address:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(170, 21)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem8.Control = Me.TextEdit8
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(513, 36)
        Me.LayoutControlItem8.Text = "City:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(170, 21)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem9.Control = Me.TextEdit9
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(513, 36)
        Me.LayoutControlItem9.Text = "State:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(170, 21)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem1.Control = Me.TextEdit1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 288)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(513, 36)
        Me.LayoutControlItem1.Text = "Zip:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(170, 21)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 539.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TileBar1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 526)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(757, 526)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmSearch"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TileBar1 As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TbiOk As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TbiCancel As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TbiClear As DevExpress.XtraBars.Navigation.TileBarItem
End Class
