﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Me.cmbSUPPLIERS = New System.Windows.Forms.ComboBox()
        Me.txtQUANTITYPURCHASE = New System.Windows.Forms.TextBox()
        Me.cmbPRODUCTPURCHASE = New System.Windows.Forms.ComboBox()
        Me.txtHARGAPURCHASE = New System.Windows.Forms.TextBox()
        Me.txtHARGASATUANPURCHASE = New System.Windows.Forms.TextBox()
        Me.dtpPURCHASE = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnINSERTPURCHASE = New System.Windows.Forms.Button()
        Me.btnCANCELPURCHASE = New System.Windows.Forms.Button()
        Me.btnUPDATEPURCHASE = New System.Windows.Forms.Button()
        Me.btnDELETEPURCHASE = New System.Windows.Forms.Button()
        Me.dgvPURCHASES = New System.Windows.Forms.DataGridView()
        Me.txtMerekBarangPurchase = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvPURCHASES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase "
        '
        'cmbSUPPLIERS
        '
        Me.cmbSUPPLIERS.FormattingEnabled = True
        Me.cmbSUPPLIERS.Location = New System.Drawing.Point(185, 354)
        Me.cmbSUPPLIERS.Name = "cmbSUPPLIERS"
        Me.cmbSUPPLIERS.Size = New System.Drawing.Size(200, 21)
        Me.cmbSUPPLIERS.TabIndex = 1
        '
        'txtQUANTITYPURCHASE
        '
        Me.txtQUANTITYPURCHASE.Location = New System.Drawing.Point(185, 494)
        Me.txtQUANTITYPURCHASE.Name = "txtQUANTITYPURCHASE"
        Me.txtQUANTITYPURCHASE.Size = New System.Drawing.Size(200, 20)
        Me.txtQUANTITYPURCHASE.TabIndex = 2
        '
        'cmbPRODUCTPURCHASE
        '
        Me.cmbPRODUCTPURCHASE.FormattingEnabled = True
        Me.cmbPRODUCTPURCHASE.Location = New System.Drawing.Point(185, 391)
        Me.cmbPRODUCTPURCHASE.Name = "cmbPRODUCTPURCHASE"
        Me.cmbPRODUCTPURCHASE.Size = New System.Drawing.Size(200, 21)
        Me.cmbPRODUCTPURCHASE.TabIndex = 3
        '
        'txtHARGAPURCHASE
        '
        Me.txtHARGAPURCHASE.Location = New System.Drawing.Point(185, 565)
        Me.txtHARGAPURCHASE.Name = "txtHARGAPURCHASE"
        Me.txtHARGAPURCHASE.Size = New System.Drawing.Size(200, 20)
        Me.txtHARGAPURCHASE.TabIndex = 4
        '
        'txtHARGASATUANPURCHASE
        '
        Me.txtHARGASATUANPURCHASE.Location = New System.Drawing.Point(185, 529)
        Me.txtHARGASATUANPURCHASE.Name = "txtHARGASATUANPURCHASE"
        Me.txtHARGASATUANPURCHASE.Size = New System.Drawing.Size(200, 20)
        Me.txtHARGASATUANPURCHASE.TabIndex = 5
        '
        'dtpPURCHASE
        '
        Me.dtpPURCHASE.Location = New System.Drawing.Point(185, 424)
        Me.dtpPURCHASE.Name = "dtpPURCHASE"
        Me.dtpPURCHASE.Size = New System.Drawing.Size(200, 20)
        Me.dtpPURCHASE.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Suppliers :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Product :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tanggal Pembelian :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 529)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Harga Satuan :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 494)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Quantity :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 565)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Harga :"
        '
        'btnINSERTPURCHASE
        '
        Me.btnINSERTPURCHASE.Location = New System.Drawing.Point(123, 596)
        Me.btnINSERTPURCHASE.Name = "btnINSERTPURCHASE"
        Me.btnINSERTPURCHASE.Size = New System.Drawing.Size(65, 23)
        Me.btnINSERTPURCHASE.TabIndex = 13
        Me.btnINSERTPURCHASE.Text = "&Insert"
        Me.btnINSERTPURCHASE.UseVisualStyleBackColor = True
        '
        'btnCANCELPURCHASE
        '
        Me.btnCANCELPURCHASE.Location = New System.Drawing.Point(338, 596)
        Me.btnCANCELPURCHASE.Name = "btnCANCELPURCHASE"
        Me.btnCANCELPURCHASE.Size = New System.Drawing.Size(65, 23)
        Me.btnCANCELPURCHASE.TabIndex = 14
        Me.btnCANCELPURCHASE.Text = "&Cancel"
        Me.btnCANCELPURCHASE.UseVisualStyleBackColor = True
        '
        'btnUPDATEPURCHASE
        '
        Me.btnUPDATEPURCHASE.Location = New System.Drawing.Point(194, 596)
        Me.btnUPDATEPURCHASE.Name = "btnUPDATEPURCHASE"
        Me.btnUPDATEPURCHASE.Size = New System.Drawing.Size(65, 23)
        Me.btnUPDATEPURCHASE.TabIndex = 15
        Me.btnUPDATEPURCHASE.Text = "&Update"
        Me.btnUPDATEPURCHASE.UseVisualStyleBackColor = True
        '
        'btnDELETEPURCHASE
        '
        Me.btnDELETEPURCHASE.Location = New System.Drawing.Point(265, 596)
        Me.btnDELETEPURCHASE.Name = "btnDELETEPURCHASE"
        Me.btnDELETEPURCHASE.Size = New System.Drawing.Size(65, 23)
        Me.btnDELETEPURCHASE.TabIndex = 16
        Me.btnDELETEPURCHASE.Text = "&Delete"
        Me.btnDELETEPURCHASE.UseVisualStyleBackColor = True
        '
        'dgvPURCHASES
        '
        Me.dgvPURCHASES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPURCHASES.Location = New System.Drawing.Point(12, 75)
        Me.dgvPURCHASES.Name = "dgvPURCHASES"
        Me.dgvPURCHASES.Size = New System.Drawing.Size(618, 257)
        Me.dgvPURCHASES.TabIndex = 18
        '
        'txtMerekBarangPurchase
        '
        Me.txtMerekBarangPurchase.Location = New System.Drawing.Point(185, 459)
        Me.txtMerekBarangPurchase.Name = "txtMerekBarangPurchase"
        Me.txtMerekBarangPurchase.ReadOnly = True
        Me.txtMerekBarangPurchase.Size = New System.Drawing.Size(200, 20)
        Me.txtMerekBarangPurchase.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 459)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Brand :"
        '
        'Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 631)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMerekBarangPurchase)
        Me.Controls.Add(Me.dgvPURCHASES)
        Me.Controls.Add(Me.btnDELETEPURCHASE)
        Me.Controls.Add(Me.btnUPDATEPURCHASE)
        Me.Controls.Add(Me.btnCANCELPURCHASE)
        Me.Controls.Add(Me.btnINSERTPURCHASE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpPURCHASE)
        Me.Controls.Add(Me.txtHARGASATUANPURCHASE)
        Me.Controls.Add(Me.txtHARGAPURCHASE)
        Me.Controls.Add(Me.cmbPRODUCTPURCHASE)
        Me.Controls.Add(Me.txtQUANTITYPURCHASE)
        Me.Controls.Add(Me.cmbSUPPLIERS)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Purchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase"
        CType(Me.dgvPURCHASES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSUPPLIERS As ComboBox
    Friend WithEvents txtQUANTITYPURCHASE As TextBox
    Friend WithEvents cmbPRODUCTPURCHASE As ComboBox
    Friend WithEvents txtHARGAPURCHASE As TextBox
    Friend WithEvents txtHARGASATUANPURCHASE As TextBox
    Friend WithEvents dtpPURCHASE As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnINSERTPURCHASE As Button
    Friend WithEvents btnCANCELPURCHASE As Button
    Friend WithEvents btnUPDATEPURCHASE As Button
    Friend WithEvents btnDELETEPURCHASE As Button
    Friend WithEvents dgvPURCHASES As DataGridView
    Friend WithEvents txtMerekBarangPurchase As TextBox
    Friend WithEvents Label8 As Label
End Class
