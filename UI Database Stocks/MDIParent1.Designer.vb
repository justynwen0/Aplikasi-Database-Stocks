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
        Me.SuspendLayout()
        '
        'btnProductsMDI
        '
        Me.btnProductsMDI.Location = New System.Drawing.Point(64, 51)
        Me.btnProductsMDI.Name = "btnProductsMDI"
        Me.btnProductsMDI.Size = New System.Drawing.Size(75, 23)
        Me.btnProductsMDI.TabIndex = 9
        Me.btnProductsMDI.Text = "Products"
        Me.btnProductsMDI.UseVisualStyleBackColor = True
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 445)
        Me.Controls.Add(Me.btnProductsMDI)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents btnProductsMDI As Button
End Class
