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
        Me.A = New System.Windows.Forms.Button()
        Me.G = New System.Windows.Forms.Button()
        Me.D = New System.Windows.Forms.Button()
        Me.B = New System.Windows.Forms.Button()
        Me.C = New System.Windows.Forms.Button()
        Me.E = New System.Windows.Forms.Button()
        Me.F = New System.Windows.Forms.Button()
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
        'E
        '
        Me.E.Location = New System.Drawing.Point(101, 127)
        Me.E.Name = "E"
        Me.E.Size = New System.Drawing.Size(23, 55)
        Me.E.TabIndex = 6
        Me.E.UseVisualStyleBackColor = True
        '
        'F
        '
        Me.F.Location = New System.Drawing.Point(101, 41)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(23, 55)
        Me.F.TabIndex = 5
        Me.F.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 450)
        Me.Controls.Add(Me.E)
        Me.Controls.Add(Me.F)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.A)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents A As Button
    Friend WithEvents G As Button
    Friend WithEvents D As Button
    Friend WithEvents B As Button
    Friend WithEvents C As Button
    Friend WithEvents E As Button
    Friend WithEvents F As Button
End Class
