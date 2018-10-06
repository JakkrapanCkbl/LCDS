Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x As Single
        Dim y As Single
        Dim z As Single
        x = GetWorkingTimeSpan("2561-06-21 09:00:00", "2561-06-25 09:00:00")
        y = Nearest(x / 3600, 0.5)
        MessageBox.Show("Result is " & CStr(y) & " ชม.")
        z = Nearest((x / 28800), 0.5)
        MessageBox.Show("Result is " & CStr(z) & " วัน")
    End Sub



End Class