Imports System.Runtime.Remoting.Messaging
Imports System.Windows.Forms

Public Class MDIParent1
    Private Sub ShowForm(formType As Type)
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        Dim frm As Form = CType(Activator.CreateInstance(formType), Form)
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(0, 0)
        frm.Location = New Point(Me.ClientSize.Width - frm.Width, 12)
        frm.FormBorderStyle = FormBorderStyle.None ' Optional: hilangkan border agar tidak bisa digeser
        frm.Show()
    End Sub

    Private Sub btnProductsMDI_Click(sender As Object, e As EventArgs) Handles btnProductsMDI.Click
        ShowForm(GetType(Products))
    End Sub

    Private Sub btnRegisterMDI_Click(sender As Object, e As EventArgs) Handles btnRegisterMDI.Click
        ShowForm(GetType(RegisterPage))
    End Sub
End Class
