<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Me.txtNAMACUSTOMERS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNOMORTELEPONCUSTOMERS = New System.Windows.Forms.TextBox()
        Me.txtEMAILCUSTOMERS = New System.Windows.Forms.TextBox()
        Me.dgvCUSTOMERS = New System.Windows.Forms.DataGridView()
        Me.btnINSERTCUSTOMERS = New System.Windows.Forms.Button()
        Me.btnUPDATECUSTOMERS = New System.Windows.Forms.Button()
        Me.btnDELETECUSTOMERS = New System.Windows.Forms.Button()
        Me.btnCANCELCUSTOMERS = New System.Windows.Forms.Button()
        CType(Me.dgvCUSTOMERS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customers"
        '
        'txtNAMACUSTOMERS
        '
        Me.txtNAMACUSTOMERS.Location = New System.Drawing.Point(145, 347)
        Me.txtNAMACUSTOMERS.Name = "txtNAMACUSTOMERS"
        Me.txtNAMACUSTOMERS.Size = New System.Drawing.Size(167, 20)
        Me.txtNAMACUSTOMERS.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No. Telp :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Email :"
        '
        'txtNOMORTELEPONCUSTOMERS
        '
        Me.txtNOMORTELEPONCUSTOMERS.Location = New System.Drawing.Point(145, 386)
        Me.txtNOMORTELEPONCUSTOMERS.Name = "txtNOMORTELEPONCUSTOMERS"
        Me.txtNOMORTELEPONCUSTOMERS.Size = New System.Drawing.Size(167, 20)
        Me.txtNOMORTELEPONCUSTOMERS.TabIndex = 11
        '
        'txtEMAILCUSTOMERS
        '
        Me.txtEMAILCUSTOMERS.Location = New System.Drawing.Point(145, 424)
        Me.txtEMAILCUSTOMERS.Name = "txtEMAILCUSTOMERS"
        Me.txtEMAILCUSTOMERS.Size = New System.Drawing.Size(167, 20)
        Me.txtEMAILCUSTOMERS.TabIndex = 12
        '
        'dgvCUSTOMERS
        '
        Me.dgvCUSTOMERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCUSTOMERS.Location = New System.Drawing.Point(12, 75)
        Me.dgvCUSTOMERS.Name = "dgvCUSTOMERS"
        Me.dgvCUSTOMERS.Size = New System.Drawing.Size(618, 257)
        Me.dgvCUSTOMERS.TabIndex = 13
        '
        'btnINSERTCUSTOMERS
        '
        Me.btnINSERTCUSTOMERS.Location = New System.Drawing.Point(144, 460)
        Me.btnINSERTCUSTOMERS.Name = "btnINSERTCUSTOMERS"
        Me.btnINSERTCUSTOMERS.Size = New System.Drawing.Size(65, 23)
        Me.btnINSERTCUSTOMERS.TabIndex = 14
        Me.btnINSERTCUSTOMERS.Text = "&Insert"
        Me.btnINSERTCUSTOMERS.UseVisualStyleBackColor = True
        '
        'btnUPDATECUSTOMERS
        '
        Me.btnUPDATECUSTOMERS.Location = New System.Drawing.Point(215, 460)
        Me.btnUPDATECUSTOMERS.Name = "btnUPDATECUSTOMERS"
        Me.btnUPDATECUSTOMERS.Size = New System.Drawing.Size(65, 23)
        Me.btnUPDATECUSTOMERS.TabIndex = 15
        Me.btnUPDATECUSTOMERS.Text = "&Update"
        Me.btnUPDATECUSTOMERS.UseVisualStyleBackColor = True
        '
        'btnDELETECUSTOMERS
        '
        Me.btnDELETECUSTOMERS.Location = New System.Drawing.Point(286, 460)
        Me.btnDELETECUSTOMERS.Name = "btnDELETECUSTOMERS"
        Me.btnDELETECUSTOMERS.Size = New System.Drawing.Size(65, 23)
        Me.btnDELETECUSTOMERS.TabIndex = 16
        Me.btnDELETECUSTOMERS.Text = "&Delete"
        Me.btnDELETECUSTOMERS.UseVisualStyleBackColor = True
        '
        'btnCANCELCUSTOMERS
        '
        Me.btnCANCELCUSTOMERS.Location = New System.Drawing.Point(357, 460)
        Me.btnCANCELCUSTOMERS.Name = "btnCANCELCUSTOMERS"
        Me.btnCANCELCUSTOMERS.Size = New System.Drawing.Size(65, 23)
        Me.btnCANCELCUSTOMERS.TabIndex = 17
        Me.btnCANCELCUSTOMERS.Text = "&Cancel"
        Me.btnCANCELCUSTOMERS.UseVisualStyleBackColor = True
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 495)
        Me.Controls.Add(Me.btnCANCELCUSTOMERS)
        Me.Controls.Add(Me.btnDELETECUSTOMERS)
        Me.Controls.Add(Me.btnUPDATECUSTOMERS)
        Me.Controls.Add(Me.btnINSERTCUSTOMERS)
        Me.Controls.Add(Me.dgvCUSTOMERS)
        Me.Controls.Add(Me.txtEMAILCUSTOMERS)
        Me.Controls.Add(Me.txtNOMORTELEPONCUSTOMERS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNAMACUSTOMERS)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customers"
        CType(Me.dgvCUSTOMERS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNAMACUSTOMERS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNOMORTELEPONCUSTOMERS As TextBox
    Friend WithEvents txtEMAILCUSTOMERS As TextBox
    Friend WithEvents dgvCUSTOMERS As DataGridView
    Friend WithEvents btnINSERTCUSTOMERS As Button
    Friend WithEvents btnUPDATECUSTOMERS As Button
    Friend WithEvents btnDELETECUSTOMERS As Button
    Friend WithEvents btnCANCELCUSTOMERS As Button
End Class
