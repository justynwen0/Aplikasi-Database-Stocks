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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPRODUCTS = New System.Windows.Forms.DataGridView()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNAMABARANG = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHARGA = New System.Windows.Forms.TextBox()
        Me.txtMEREKBARANG = New System.Windows.Forms.TextBox()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnINSERT = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvPRODUCTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List Products :"
        '
        'dgvPRODUCTS
        '
        Me.dgvPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPRODUCTS.Location = New System.Drawing.Point(12, 75)
        Me.dgvPRODUCTS.Name = "dgvPRODUCTS"
        Me.dgvPRODUCTS.Size = New System.Drawing.Size(618, 257)
        Me.dgvPRODUCTS.TabIndex = 1
        '
        'btnUPDATE
        '
        Me.btnUPDATE.Location = New System.Drawing.Point(115, 462)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(65, 23)
        Me.btnUPDATE.TabIndex = 2
        Me.btnUPDATE.Text = "&UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Harga  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Barang :"
        '
        'txtNAMABARANG
        '
        Me.txtNAMABARANG.Location = New System.Drawing.Point(145, 347)
        Me.txtNAMABARANG.Name = "txtNAMABARANG"
        Me.txtNAMABARANG.Size = New System.Drawing.Size(167, 20)
        Me.txtNAMABARANG.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Merek Barang :"
        '
        'txtHARGA
        '
        Me.txtHARGA.Location = New System.Drawing.Point(145, 386)
        Me.txtHARGA.Name = "txtHARGA"
        Me.txtHARGA.Size = New System.Drawing.Size(167, 20)
        Me.txtHARGA.TabIndex = 7
        '
        'txtMEREKBARANG
        '
        Me.txtMEREKBARANG.Location = New System.Drawing.Point(145, 424)
        Me.txtMEREKBARANG.Name = "txtMEREKBARANG"
        Me.txtMEREKBARANG.Size = New System.Drawing.Size(167, 20)
        Me.txtMEREKBARANG.TabIndex = 8
        '
        'btnDELETE
        '
        Me.btnDELETE.Location = New System.Drawing.Point(196, 462)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(65, 23)
        Me.btnDELETE.TabIndex = 9
        Me.btnDELETE.Text = "&DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnCANCEL
        '
        Me.btnCANCEL.Location = New System.Drawing.Point(277, 462)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(65, 23)
        Me.btnCANCEL.TabIndex = 10
        Me.btnCANCEL.Text = "&CANCEL"
        Me.btnCANCEL.UseVisualStyleBackColor = True
        '
        'btnINSERT
        '
        Me.btnINSERT.Location = New System.Drawing.Point(34, 462)
        Me.btnINSERT.Name = "btnINSERT"
        Me.btnINSERT.Size = New System.Drawing.Size(65, 23)
        Me.btnINSERT.TabIndex = 12
        Me.btnINSERT.Text = "&INSERT"
        Me.btnINSERT.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(241, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 31)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Products"
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 495)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnINSERT)
        Me.Controls.Add(Me.btnCANCEL)
        Me.Controls.Add(Me.btnDELETE)
        Me.Controls.Add(Me.txtMEREKBARANG)
        Me.Controls.Add(Me.txtHARGA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNAMABARANG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.dgvPRODUCTS)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Products"
        Me.Text = "Info Tentang Products"
        CType(Me.dgvPRODUCTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPRODUCTS As DataGridView
    Friend WithEvents btnUPDATE As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNAMABARANG As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHARGA As TextBox
    Friend WithEvents txtMEREKBARANG As TextBox
    Friend WithEvents btnDELETE As Button
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents btnINSERT As Button
    Friend WithEvents Label5 As Label
End Class
