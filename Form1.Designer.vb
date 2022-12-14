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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.postfixInputBox = New System.Windows.Forms.TextBox()
        Me.infixEquivalentBox = New System.Windows.Forms.TextBox()
        Me.postfixOutputBox = New System.Windows.Forms.TextBox()
        Me.infixOutputBox = New System.Windows.Forms.TextBox()
        Me.postfixEquivalentBox = New System.Windows.Forms.TextBox()
        Me.infixInputBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Postfix Expression Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Infix Equivalent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Output"
        '
        'postfixInputBox
        '
        Me.postfixInputBox.Location = New System.Drawing.Point(189, 154)
        Me.postfixInputBox.Name = "postfixInputBox"
        Me.postfixInputBox.Size = New System.Drawing.Size(100, 20)
        Me.postfixInputBox.TabIndex = 3
        '
        'infixEquivalentBox
        '
        Me.infixEquivalentBox.Location = New System.Drawing.Point(189, 227)
        Me.infixEquivalentBox.Name = "infixEquivalentBox"
        Me.infixEquivalentBox.Size = New System.Drawing.Size(100, 20)
        Me.infixEquivalentBox.TabIndex = 4
        '
        'postfixOutputBox
        '
        Me.postfixOutputBox.Location = New System.Drawing.Point(189, 296)
        Me.postfixOutputBox.Name = "postfixOutputBox"
        Me.postfixOutputBox.Size = New System.Drawing.Size(100, 20)
        Me.postfixOutputBox.TabIndex = 5
        '
        'infixOutputBox
        '
        Me.infixOutputBox.Location = New System.Drawing.Point(500, 296)
        Me.infixOutputBox.Name = "infixOutputBox"
        Me.infixOutputBox.Size = New System.Drawing.Size(100, 20)
        Me.infixOutputBox.TabIndex = 11
        '
        'postfixEquivalentBox
        '
        Me.postfixEquivalentBox.Location = New System.Drawing.Point(500, 227)
        Me.postfixEquivalentBox.Name = "postfixEquivalentBox"
        Me.postfixEquivalentBox.Size = New System.Drawing.Size(100, 20)
        Me.postfixEquivalentBox.TabIndex = 10
        '
        'infixInputBox
        '
        Me.infixInputBox.Location = New System.Drawing.Point(500, 154)
        Me.infixInputBox.Name = "infixInputBox"
        Me.infixInputBox.Size = New System.Drawing.Size(100, 20)
        Me.infixInputBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(531, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Output"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(504, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Postfix Equivalent"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(497, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Infix Expression Input"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(513, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label7.Location = New System.Drawing.Point(305, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 26)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Postfix Calculator"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Available characters: 1-9, + - * / and ( )"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.infixOutputBox)
        Me.Controls.Add(Me.postfixEquivalentBox)
        Me.Controls.Add(Me.infixInputBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.postfixOutputBox)
        Me.Controls.Add(Me.infixEquivalentBox)
        Me.Controls.Add(Me.postfixInputBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents postfixInputBox As TextBox
    Friend WithEvents infixEquivalentBox As TextBox
    Friend WithEvents postfixOutputBox As TextBox
    Friend WithEvents infixOutputBox As TextBox
    Friend WithEvents postfixEquivalentBox As TextBox
    Friend WithEvents infixInputBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
