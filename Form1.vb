Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        lbldisplay.Text = InputBox("Enter your name", "Input Box")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim intresult As Integer

        intresult = messagebox.Show("Are you sure", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If intresult = Windows.Forms.DialogResult.Yes Then
            End
        ElseIf intresult = Windows.Forms.DialogResult.No Then

            Me.Show()

        End If

    End Sub
End Class
