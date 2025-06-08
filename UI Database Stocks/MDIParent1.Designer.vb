<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
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
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnProductsMDI = New System.Windows.Forms.Button()
        Me.btnRegisterMDI = New System.Windows.Forms.Button()
        Me.btnCustomersMDI = New System.Windows.Forms.Button()
        Me.btnSuppliersMDI = New System.Windows.Forms.Button()
        Me.btnOrdersMDI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProductsMDI
        '
        Me.btnProductsMDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductsMDI.Location = New System.Drawing.Point(12, 126)
        Me.btnProductsMDI.Name = "btnProductsMDI"
        Me.btnProductsMDI.Size = New System.Drawing.Size(102, 57)
        Me.btnProductsMDI.TabIndex = 9
        Me.btnProductsMDI.Text = "Products"
        Me.btnProductsMDI.UseVisualStyleBackColor = True
        '
        'btnRegisterMDI
        '
        Me.btnRegisterMDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterMDI.Location = New System.Drawing.Point(12, 49)
        Me.btnRegisterMDI.Name = "btnRegisterMDI"
        Me.btnRegisterMDI.Size = New System.Drawing.Size(102, 57)
        Me.btnRegisterMDI.TabIndex = 11
        Me.btnRegisterMDI.Text = "Register"
        Me.btnRegisterMDI.UseVisualStyleBackColor = True
        '
        'btnCustomersMDI
        '
        Me.btnCustomersMDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomersMDI.Location = New System.Drawing.Point(12, 280)
        Me.btnCustomersMDI.Name = "btnCustomersMDI"
        Me.btnCustomersMDI.Size = New System.Drawing.Size(102, 52)
        Me.btnCustomersMDI.TabIndex = 13
        Me.btnCustomersMDI.Text = "Customers"
        Me.btnCustomersMDI.UseVisualStyleBackColor = True
        '
        'btnSuppliersMDI
        '
        Me.btnSuppliersMDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppliersMDI.Location = New System.Drawing.Point(12, 202)
        Me.btnSuppliersMDI.Name = "btnSuppliersMDI"
        Me.btnSuppliersMDI.Size = New System.Drawing.Size(102, 54)
        Me.btnSuppliersMDI.TabIndex = 14
        Me.btnSuppliersMDI.Text = "Suppliers"
        Me.btnSuppliersMDI.UseVisualStyleBackColor = True
        '
        'btnOrdersMDI
        '
        Me.btnOrdersMDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdersMDI.Location = New System.Drawing.Point(12, 353)
        Me.btnOrdersMDI.Name = "btnOrdersMDI"
        Me.btnOrdersMDI.Size = New System.Drawing.Size(102, 57)
        Me.btnOrdersMDI.TabIndex = 16
        Me.btnOrdersMDI.Text = "Orders"
        Me.btnOrdersMDI.UseVisualStyleBackColor = True
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 568)
        Me.Controls.Add(Me.btnOrdersMDI)
        Me.Controls.Add(Me.btnSuppliersMDI)
        Me.Controls.Add(Me.btnCustomersMDI)
        Me.Controls.Add(Me.btnRegisterMDI)
        Me.Controls.Add(Me.btnProductsMDI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Manajemen Stock"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents btnProductsMDI As Button
    Friend WithEvents btnRegisterMDI As Button
    Friend WithEvents btnCustomersMDI As Button
    Friend WithEvents btnSuppliersMDI As Button
    Friend WithEvents btnOrdersMDI As Button
End Class
