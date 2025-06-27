<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Me.cmbCUSTOMERS = New System.Windows.Forms.ComboBox()
        Me.dtpORDERS = New System.Windows.Forms.DateTimePicker()
        Me.txtQUANTITY = New System.Windows.Forms.TextBox()
        Me.btnINSERTORDERS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPRODUCTS = New System.Windows.Forms.ComboBox()
        Me.txtHARGASATUAN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHARGA = New System.Windows.Forms.TextBox()
        Me.btnUPDATEORDERS = New System.Windows.Forms.Button()
        Me.btnDELETEORDERS = New System.Windows.Forms.Button()
        Me.btnCANCELORDERS = New System.Windows.Forms.Button()
        Me.dgvORDERS = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMerekBarangOrders = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvORDERS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orders"
        '
        'cmbCUSTOMERS
        '
        Me.cmbCUSTOMERS.FormattingEnabled = True
        Me.cmbCUSTOMERS.Location = New System.Drawing.Point(152, 351)
        Me.cmbCUSTOMERS.Name = "cmbCUSTOMERS"
        Me.cmbCUSTOMERS.Size = New System.Drawing.Size(200, 21)
        Me.cmbCUSTOMERS.TabIndex = 1
        '
        'dtpORDERS
        '
        Me.dtpORDERS.Location = New System.Drawing.Point(152, 456)
        Me.dtpORDERS.Name = "dtpORDERS"
        Me.dtpORDERS.Size = New System.Drawing.Size(200, 20)
        Me.dtpORDERS.TabIndex = 2
        '
        'txtQUANTITY
        '
        Me.txtQUANTITY.Location = New System.Drawing.Point(152, 492)
        Me.txtQUANTITY.Name = "txtQUANTITY"
        Me.txtQUANTITY.Size = New System.Drawing.Size(200, 20)
        Me.txtQUANTITY.TabIndex = 3
        '
        'btnINSERTORDERS
        '
        Me.btnINSERTORDERS.Location = New System.Drawing.Point(75, 595)
        Me.btnINSERTORDERS.Name = "btnINSERTORDERS"
        Me.btnINSERTORDERS.Size = New System.Drawing.Size(65, 23)
        Me.btnINSERTORDERS.TabIndex = 4
        Me.btnINSERTORDERS.Text = "&Insert"
        Me.btnINSERTORDERS.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Customer :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Product :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 456)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tanggal Order : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 559)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Harga :"
        '
        'cmbPRODUCTS
        '
        Me.cmbPRODUCTS.FormattingEnabled = True
        Me.cmbPRODUCTS.Location = New System.Drawing.Point(152, 385)
        Me.cmbPRODUCTS.Name = "cmbPRODUCTS"
        Me.cmbPRODUCTS.Size = New System.Drawing.Size(200, 21)
        Me.cmbPRODUCTS.TabIndex = 11
        '
        'txtHARGASATUAN
        '
        Me.txtHARGASATUAN.Location = New System.Drawing.Point(152, 527)
        Me.txtHARGASATUAN.Name = "txtHARGASATUAN"
        Me.txtHARGASATUAN.Size = New System.Drawing.Size(200, 20)
        Me.txtHARGASATUAN.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 527)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Harga Satuan :"
        '
        'txtHARGA
        '
        Me.txtHARGA.Location = New System.Drawing.Point(152, 559)
        Me.txtHARGA.Name = "txtHARGA"
        Me.txtHARGA.Size = New System.Drawing.Size(200, 20)
        Me.txtHARGA.TabIndex = 15
        '
        'btnUPDATEORDERS
        '
        Me.btnUPDATEORDERS.Location = New System.Drawing.Point(146, 595)
        Me.btnUPDATEORDERS.Name = "btnUPDATEORDERS"
        Me.btnUPDATEORDERS.Size = New System.Drawing.Size(65, 23)
        Me.btnUPDATEORDERS.TabIndex = 16
        Me.btnUPDATEORDERS.Text = "&Update"
        Me.btnUPDATEORDERS.UseVisualStyleBackColor = True
        '
        'btnDELETEORDERS
        '
        Me.btnDELETEORDERS.Location = New System.Drawing.Point(217, 595)
        Me.btnDELETEORDERS.Name = "btnDELETEORDERS"
        Me.btnDELETEORDERS.Size = New System.Drawing.Size(65, 23)
        Me.btnDELETEORDERS.TabIndex = 17
        Me.btnDELETEORDERS.Text = "&Delete"
        Me.btnDELETEORDERS.UseVisualStyleBackColor = True
        '
        'btnCANCELORDERS
        '
        Me.btnCANCELORDERS.Location = New System.Drawing.Point(288, 595)
        Me.btnCANCELORDERS.Name = "btnCANCELORDERS"
        Me.btnCANCELORDERS.Size = New System.Drawing.Size(65, 23)
        Me.btnCANCELORDERS.TabIndex = 18
        Me.btnCANCELORDERS.Text = "&Cancel"
        Me.btnCANCELORDERS.UseVisualStyleBackColor = True
        '
        'dgvORDERS
        '
        Me.dgvORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvORDERS.Location = New System.Drawing.Point(12, 75)
        Me.dgvORDERS.Name = "dgvORDERS"
        Me.dgvORDERS.Size = New System.Drawing.Size(618, 257)
        Me.dgvORDERS.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 421)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Brand :"
        '
        'txtMerekBarangOrders
        '
        Me.txtMerekBarangOrders.Location = New System.Drawing.Point(152, 421)
        Me.txtMerekBarangOrders.Name = "txtMerekBarangOrders"
        Me.txtMerekBarangOrders.Size = New System.Drawing.Size(200, 20)
        Me.txtMerekBarangOrders.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 492)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Quantity :"
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 630)
        Me.Controls.Add(Me.txtMerekBarangOrders)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvORDERS)
        Me.Controls.Add(Me.btnCANCELORDERS)
        Me.Controls.Add(Me.btnDELETEORDERS)
        Me.Controls.Add(Me.btnUPDATEORDERS)
        Me.Controls.Add(Me.txtHARGA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtHARGASATUAN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbPRODUCTS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnINSERTORDERS)
        Me.Controls.Add(Me.txtQUANTITY)
        Me.Controls.Add(Me.dtpORDERS)
        Me.Controls.Add(Me.cmbCUSTOMERS)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Orders"
        CType(Me.dgvORDERS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCUSTOMERS As ComboBox
    Friend WithEvents dtpORDERS As DateTimePicker
    Friend WithEvents txtQUANTITY As TextBox
    Friend WithEvents btnINSERTORDERS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbPRODUCTS As ComboBox
    Friend WithEvents txtHARGASATUAN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHARGA As TextBox
    Friend WithEvents btnUPDATEORDERS As Button
    Friend WithEvents btnDELETEORDERS As Button
    Friend WithEvents btnCANCELORDERS As Button
    Friend WithEvents dgvORDERS As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMerekBarangOrders As TextBox
    Friend WithEvents Label7 As Label
End Class
