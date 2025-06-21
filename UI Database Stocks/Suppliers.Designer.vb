<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppliers
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNAMA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNOTELP = New System.Windows.Forms.TextBox()
        Me.txtEMAIL = New System.Windows.Forms.TextBox()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvSUPPLIERS = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSUPPLIERS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnINSERT
        '
        Me.btnINSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnINSERT.Location = New System.Drawing.Point(147, 460)
        Me.btnINSERT.Name = "btnINSERT"
        Me.btnINSERT.Size = New System.Drawing.Size(65, 23)
        Me.btnINSERT.TabIndex = 0
        Me.btnINSERT.Text = "&Insert"
        Me.btnINSERT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama :"
        '
        'txtNAMA
        '
        Me.txtNAMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNAMA.Location = New System.Drawing.Point(145, 347)
        Me.txtNAMA.Name = "txtNAMA"
        Me.txtNAMA.Size = New System.Drawing.Size(167, 22)
        Me.txtNAMA.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No. Telp :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email :"
        '
        'txtNOTELP
        '
        Me.txtNOTELP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOTELP.Location = New System.Drawing.Point(145, 384)
        Me.txtNOTELP.Name = "txtNOTELP"
        Me.txtNOTELP.Size = New System.Drawing.Size(167, 22)
        Me.txtNOTELP.TabIndex = 5
        '
        'txtEMAIL
        '
        Me.txtEMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEMAIL.Location = New System.Drawing.Point(145, 424)
        Me.txtEMAIL.Name = "txtEMAIL"
        Me.txtEMAIL.Size = New System.Drawing.Size(167, 22)
        Me.txtEMAIL.TabIndex = 6
        '
        'btnUPDATE
        '
        Me.btnUPDATE.Location = New System.Drawing.Point(218, 460)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(65, 23)
        Me.btnUPDATE.TabIndex = 7
        Me.btnUPDATE.Text = "&Update"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.Location = New System.Drawing.Point(289, 460)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(65, 23)
        Me.btnDELETE.TabIndex = 8
        Me.btnDELETE.Text = "&Delete"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnCANCEL
        '
        Me.btnCANCEL.Location = New System.Drawing.Point(360, 460)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(65, 23)
        Me.btnCANCEL.TabIndex = 9
        Me.btnCANCEL.Text = "&Cancel"
        Me.btnCANCEL.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(258, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 31)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Suppliers"
        '
        'dgvSUPPLIERS
        '
        Me.dgvSUPPLIERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSUPPLIERS.Location = New System.Drawing.Point(12, 75)
        Me.dgvSUPPLIERS.Name = "dgvSUPPLIERS"
        Me.dgvSUPPLIERS.Size = New System.Drawing.Size(618, 257)
        Me.dgvSUPPLIERS.TabIndex = 12
        '
        'Suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 495)
        Me.Controls.Add(Me.dgvSUPPLIERS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCANCEL)
        Me.Controls.Add(Me.btnDELETE)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.txtEMAIL)
        Me.Controls.Add(Me.txtNOTELP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNAMA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnINSERT)
        Me.Name = "Suppliers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InfoSuppliers"
        CType(Me.dgvSUPPLIERS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnINSERT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNAMA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNOTELP As TextBox
    Friend WithEvents txtEMAIL As TextBox
    Friend WithEvents btnUPDATE As Button
    Friend WithEvents btnDELETE As Button
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvSUPPLIERS As DataGridView
End Class
