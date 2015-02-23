<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMetroMessageBox
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.LblTitle, 3)
        Me.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(33, 20)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(434, 40)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.Location = New System.Drawing.Point(53, 80)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(394, 124)
        Me.LblMessage.TabIndex = 1
        Me.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblMessage.UseMnemonic = False
        '
        'Btn1
        '
        Me.Btn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(53, 3)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(114, 39)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "OK"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(193, 3)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(114, 39)
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "Cancel"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Btn3, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn2, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 224)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(500, 58)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Btn3
        '
        Me.Btn3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(333, 3)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(114, 39)
        Me.Btn3.TabIndex = 2
        Me.Btn3.Text = "Cancel"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = True
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LblMessage, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LblTitle, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(500, 224)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'FrmMetroMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(500, 282)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMetroMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmFlyOutMessageBox"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
End Class
