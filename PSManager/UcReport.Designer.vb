<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcReport
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
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim LineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ChartControl1)
        Me.LayoutControl1.Controls.Add(Me.ChartControl2)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(680, 217, 250, 350)
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
        Me.LayoutControl1.Size = New System.Drawing.Size(1240, 446)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1240, 446)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'ChartControl2
        '
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl2.Diagram = XyDiagram2
        Me.ChartControl2.Location = New System.Drawing.Point(627, 12)
        Me.ChartControl2.Name = "ChartControl2"
        Series3.Name = "Series 1"
        Series4.Name = "Series 2"
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3, Series4}
        Me.ChartControl2.Size = New System.Drawing.Size(601, 422)
        Me.ChartControl2.TabIndex = 4
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ChartControl2
        Me.LayoutControlItem1.Location = New System.Drawing.Point(615, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(605, 426)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'ChartControl1
        '
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Location = New System.Drawing.Point(12, 12)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.Name = "Series 1"
        Series1.View = LineSeriesView1
        Series2.Name = "Series 2"
        Series2.View = LineSeriesView2
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        Me.ChartControl1.SeriesTemplate.View = LineSeriesView3
        Me.ChartControl1.Size = New System.Drawing.Size(611, 422)
        Me.ChartControl1.TabIndex = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ChartControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(615, 426)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'UcReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "UcReport"
        Me.Size = New System.Drawing.Size(1240, 446)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

End Class
