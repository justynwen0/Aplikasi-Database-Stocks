﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterPage
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
        Dim LabelNameRegister As System.Windows.Forms.Label
        Me.LabelRegisterHeader = New System.Windows.Forms.Label()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.txtPasswordRegister = New System.Windows.Forms.TextBox()
        Me.txtUsernameRegister = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.txtEmailRegister = New System.Windows.Forms.TextBox()
        Me.LabelEmailRegister = New System.Windows.Forms.Label()
        Me.dgvRegister = New System.Windows.Forms.DataGridView()
        Me.btnDeleteRegister = New System.Windows.Forms.Button()
        Me.btnCancelRegister = New System.Windows.Forms.Button()
        LabelNameRegister = New System.Windows.Forms.Label()
        CType(Me.dgvRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNameRegister
        '
        LabelNameRegister.AutoSize = True
        LabelNameRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelNameRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        LabelNameRegister.Location = New System.Drawing.Point(30, 324)
        LabelNameRegister.Name = "LabelNameRegister"
        LabelNameRegister.Size = New System.Drawing.Size(59, 20)
        LabelNameRegister.TabIndex = 6
        LabelNameRegister.Text = "Name :"
        '
        'LabelRegisterHeader
        '
        Me.LabelRegisterHeader.AutoSize = True
        Me.LabelRegisterHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegisterHeader.ForeColor = System.Drawing.Color.Black
        Me.LabelRegisterHeader.Location = New System.Drawing.Point(261, 9)
        Me.LabelRegisterHeader.Name = "LabelRegisterHeader"
        Me.LabelRegisterHeader.Size = New System.Drawing.Size(124, 31)
        Me.LabelRegisterHeader.TabIndex = 11
        Me.LabelRegisterHeader.Text = "Register"
        '
        'BtnRegister
        '
        Me.BtnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.Location = New System.Drawing.Point(122, 460)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegister.TabIndex = 10
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'txtPasswordRegister
        '
        Me.txtPasswordRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordRegister.Location = New System.Drawing.Point(122, 421)
        Me.txtPasswordRegister.Name = "txtPasswordRegister"
        Me.txtPasswordRegister.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordRegister.Size = New System.Drawing.Size(199, 20)
        Me.txtPasswordRegister.TabIndex = 9
        '
        'txtUsernameRegister
        '
        Me.txtUsernameRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameRegister.Location = New System.Drawing.Point(122, 326)
        Me.txtUsernameRegister.Name = "txtUsernameRegister"
        Me.txtUsernameRegister.Size = New System.Drawing.Size(199, 20)
        Me.txtUsernameRegister.TabIndex = 8
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelPassword.Location = New System.Drawing.Point(30, 419)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(86, 20)
        Me.LabelPassword.TabIndex = 7
        Me.LabelPassword.Text = "Password :"
        '
        'txtEmailRegister
        '
        Me.txtEmailRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailRegister.Location = New System.Drawing.Point(122, 372)
        Me.txtEmailRegister.Name = "txtEmailRegister"
        Me.txtEmailRegister.Size = New System.Drawing.Size(199, 20)
        Me.txtEmailRegister.TabIndex = 13
        '
        'LabelEmailRegister
        '
        Me.LabelEmailRegister.AutoSize = True
        Me.LabelEmailRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmailRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelEmailRegister.Location = New System.Drawing.Point(30, 370)
        Me.LabelEmailRegister.Name = "LabelEmailRegister"
        Me.LabelEmailRegister.Size = New System.Drawing.Size(56, 20)
        Me.LabelEmailRegister.TabIndex = 12
        Me.LabelEmailRegister.Text = "Email :"
        '
        'dgvRegister
        '
        Me.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegister.Location = New System.Drawing.Point(12, 56)
        Me.dgvRegister.Name = "dgvRegister"
        Me.dgvRegister.Size = New System.Drawing.Size(625, 252)
        Me.dgvRegister.TabIndex = 14
        '
        'btnDeleteRegister
        '
        Me.btnDeleteRegister.Location = New System.Drawing.Point(212, 460)
        Me.btnDeleteRegister.Name = "btnDeleteRegister"
        Me.btnDeleteRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteRegister.TabIndex = 16
        Me.btnDeleteRegister.Text = "Delete"
        Me.btnDeleteRegister.UseVisualStyleBackColor = True
        '
        'btnCancelRegister
        '
        Me.btnCancelRegister.Location = New System.Drawing.Point(302, 460)
        Me.btnCancelRegister.Name = "btnCancelRegister"
        Me.btnCancelRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelRegister.TabIndex = 17
        Me.btnCancelRegister.Text = "Cancel"
        Me.btnCancelRegister.UseVisualStyleBackColor = True
        '
        'RegisterPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 495)
        Me.Controls.Add(Me.btnCancelRegister)
        Me.Controls.Add(Me.btnDeleteRegister)
        Me.Controls.Add(Me.dgvRegister)
        Me.Controls.Add(Me.txtEmailRegister)
        Me.Controls.Add(Me.LabelEmailRegister)
        Me.Controls.Add(Me.LabelRegisterHeader)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.txtPasswordRegister)
        Me.Controls.Add(Me.txtUsernameRegister)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(LabelNameRegister)
        Me.Name = "RegisterPage"
        Me.Text = "RegisterPage"
        CType(Me.dgvRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelRegisterHeader As Label
    Friend WithEvents BtnRegister As Button
    Friend WithEvents txtPasswordRegister As TextBox
    Friend WithEvents txtUsernameRegister As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents txtEmailRegister As TextBox
    Friend WithEvents LabelEmailRegister As Label
    Friend WithEvents dgvRegister As DataGridView
    Friend WithEvents btnDeleteRegister As Button
    Friend WithEvents btnCancelRegister As Button
End Class
