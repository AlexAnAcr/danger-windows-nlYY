Public Class Main
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("RunDLL32.exe shell32.dll,ShellExec_RunDLL " & My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/conf_1.txt"))
        Me.Close()
    End Sub
End Class
