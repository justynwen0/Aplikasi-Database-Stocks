<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.btnINSERT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.txtNAMABARANG = New System.Windows.Forms.TextBox()
        Me.txtHARGA = New System.Windows.Forms.TextBox()
        Me.txtMEREKBARANG = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnINSERT
        '
        Me.btnINSERT.Location = New System.Drawing.Point(43, 140)
        Me.btnINSERT.Name = "btnINSERT"
        Me.btnINSERT.Size = New System.Drawing.Size(75, 23)
        Me.btnINSERT.TabIndex = 1
        Me.btnINSERT.Text = "&INSERT"
        Me.btnINSERT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NamaBarang :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MerekBarang :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Harga :"
        '
        'btnUPDATE
        '
        Me.btnUPDATE.Location = New System.Drawing.Point(124, 140)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(75, 23)
        Me.btnUPDATE.TabIndex = 9
        Me.btnUPDATE.Text = "&UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.Location = New System.Drawing.Point(205, 140)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(75, 23)
        Me.btnDELETE.TabIndex = 10
        Me.btnDELETE.Text = "&DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnCANCEL
        '
        Me.btnCANCEL.Location = New System.Drawing.Point(286, 140)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(75, 23)
        Me.btnCANCEL.TabIndex = 11
        Me.btnCANCEL.Text = "&CANCEL"
        Me.btnCANCEL.UseVisualStyleBackColor = True
        '
        'txtNAMABARANG
        '
        Me.txtNAMABARANG.Location = New System.Drawing.Point(141, 33)
        Me.txtNAMABARANG.Name = "txtNAMABARANG"
        Me.txtNAMABARANG.Size = New System.Drawing.Size(220, 20)
        Me.txtNAMABARANG.TabIndex = 19
        '
        'txtHARGA
        '
        Me.txtHARGA.Location = New System.Drawing.Point(141, 69)
        Me.txtHARGA.Name = "txtHARGA"
        Me.txtHARGA.Size = New System.Drawing.Size(220, 20)
        Me.txtHARGA.TabIndex = 20
        '
        'txtMEREKBARANG
        '
        Me.txtMEREKBARANG.Location = New System.Drawing.Point(144, 104)
        Me.txtMEREKBARANG.Name = "txtMEREKBARANG"
        Me.txtMEREKBARANG.Size = New System.Drawing.Size(220, 20)
        Me.txtMEREKBARANG.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 182)
        Me.Controls.Add(Me.txtMEREKBARANG)
        Me.Controls.Add(Me.txtHARGA)
        Me.Controls.Add(Me.txtNAMABARANG)
        Me.Controls.Add(Me.btnCANCEL)
        Me.Controls.Add(Me.btnDELETE)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnINSERT)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InventoryStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnINSERT As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUPDATE As Button
    Friend WithEvents btnDELETE As Button
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents txtNAMABARANG As TextBox
    Friend WithEvents txtHARGA As TextBox
    Friend WithEvents txtMEREKBARANG As TextBox
End Class
