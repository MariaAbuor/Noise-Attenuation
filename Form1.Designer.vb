<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtLp1 = New System.Windows.Forms.TextBox()
        Me.TxtR1 = New System.Windows.Forms.TextBox()
        Me.TxtR2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PointSourceTxt = New System.Windows.Forms.TextBox()
        Me.LineSourceTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(76, 237)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(135, 30)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(410, 237)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lp1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "r1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "r2"
        '
        'TxtLp1
        '
        Me.TxtLp1.Location = New System.Drawing.Point(257, 37)
        Me.TxtLp1.Name = "TxtLp1"
        Me.TxtLp1.Size = New System.Drawing.Size(100, 26)
        Me.TxtLp1.TabIndex = 5
        '
        'TxtR1
        '
        Me.TxtR1.Location = New System.Drawing.Point(257, 88)
        Me.TxtR1.Name = "TxtR1"
        Me.TxtR1.Size = New System.Drawing.Size(100, 26)
        Me.TxtR1.TabIndex = 6
        '
        'TxtR2
        '
        Me.TxtR2.Location = New System.Drawing.Point(257, 138)
        Me.TxtR2.Name = "TxtR2"
        Me.TxtR2.Size = New System.Drawing.Size(100, 26)
        Me.TxtR2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Point Source"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Line Source"
        '
        'PointSourceTxt
        '
        Me.PointSourceTxt.Location = New System.Drawing.Point(257, 297)
        Me.PointSourceTxt.Name = "PointSourceTxt"
        Me.PointSourceTxt.Size = New System.Drawing.Size(100, 26)
        Me.PointSourceTxt.TabIndex = 10
        '
        'LineSourceTxt
        '
        Me.LineSourceTxt.Location = New System.Drawing.Point(257, 344)
        Me.LineSourceTxt.Name = "LineSourceTxt"
        Me.LineSourceTxt.Size = New System.Drawing.Size(100, 26)
        Me.LineSourceTxt.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LineSourceTxt)
        Me.Controls.Add(Me.PointSourceTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtR2)
        Me.Controls.Add(Me.TxtR1)
        Me.Controls.Add(Me.TxtLp1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Noise Attenuation by Distance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtLp1 As TextBox
    Friend WithEvents TxtR1 As TextBox
    Friend WithEvents TxtR2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PointSourceTxt As TextBox
    Friend WithEvents LineSourceTxt As TextBox
End Class
