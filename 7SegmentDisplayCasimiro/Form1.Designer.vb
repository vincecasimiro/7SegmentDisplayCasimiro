<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.A = New System.Windows.Forms.Button()
        Me.G = New System.Windows.Forms.Button()
        Me.D = New System.Windows.Forms.Button()
        Me.B = New System.Windows.Forms.Button()
        Me.C = New System.Windows.Forms.Button()
        Me.EDisplay = New System.Windows.Forms.Button()
        Me.F = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(122, 12)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(75, 23)
        Me.A.TabIndex = 0
        Me.A.UseVisualStyleBackColor = True
        '
        'G
        '
        Me.G.Location = New System.Drawing.Point(122, 100)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(75, 23)
        Me.G.TabIndex = 1
        Me.G.UseVisualStyleBackColor = True
        '
        'D
        '
        Me.D.Location = New System.Drawing.Point(122, 184)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(75, 23)
        Me.D.TabIndex = 2
        Me.D.UseVisualStyleBackColor = True
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(194, 41)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(23, 55)
        Me.B.TabIndex = 3
        Me.B.UseVisualStyleBackColor = True
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(194, 127)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(23, 55)
        Me.C.TabIndex = 4
        Me.C.UseVisualStyleBackColor = True
        '
        'EDisplay
        '
        Me.EDisplay.Location = New System.Drawing.Point(101, 127)
        Me.EDisplay.Name = "EDisplay"
        Me.EDisplay.Size = New System.Drawing.Size(23, 55)
        Me.EDisplay.TabIndex = 6
        Me.EDisplay.UseVisualStyleBackColor = True
        '
        'F
        '
        Me.F.Location = New System.Drawing.Point(101, 41)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(23, 55)
        Me.F.TabIndex = 5
        Me.F.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Casimiro, Vince R."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "BSCpE 5-3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(319, 286)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EDisplay)
        Me.Controls.Add(Me.F)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.A)
        Me.Name = "Form1"
        Me.Text = "7 Segment Display"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents A As Button
    Friend WithEvents G As Button
    Friend WithEvents D As Button
    Friend WithEvents B As Button
    Friend WithEvents C As Button
    Friend WithEvents EDisplay As Button
    Friend WithEvents F As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
