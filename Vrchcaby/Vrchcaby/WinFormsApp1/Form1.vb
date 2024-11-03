Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        Label1.Text = Int(Rnd() * 6) + 1
        Label2.Text = Int(Rnd() * 6) + 1
        Label3.Text = Int(Rnd() * 6) + 1
        Label7.Text = Val(Label1.Text) + Val(Label2.Text) + Val(Label3.Text)
        Button1.Enabled = False
        CheckButton3Availability()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Randomize()
        Label4.Text = Int(Rnd() * 6) + 1
        Label5.Text = Int(Rnd() * 6) + 1
        Label6.Text = Int(Rnd() * 6) + 1
        Label8.Text = Val(Label4.Text) + Val(Label5.Text) + Val(Label6.Text)
        Button2.Enabled = False
        CheckButton3Availability()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Val(Label7.Text) > Val(Label8.Text) Then
            Dim result1 As DialogResult = MessageBox.Show("Player 1 won!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If result1 = DialogResult.OK Then
                Result()
                CheckButton3Availability()
            End If
        ElseIf Val(Label8.Text) > Val(Label7.Text) Then
            Dim result2 As DialogResult = MessageBox.Show("Player 2 won!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If result2 = DialogResult.OK Then
                Result()
                CheckButton3Availability()
            End If
        ElseIf Val(Label7.Text) = Val(Label8.Text) And Val(Label7.Text) <> 0 And Val(Label7.Text) <> 0 Then
            Dim draw As DialogResult = MessageBox.Show("Draw!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If draw = DialogResult.OK Then
                Result()
                CheckButton3Availability()
            End If
        End If

        Button1.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label7.Text = "0" AndAlso Label8.Text = "0" Then
            MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Result()
        CheckButton3Availability()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Enabled = False
    End Sub
    Private Sub Result()
        Label1.Text = "0"
        Label2.Text = "0"
        Label3.Text = "0"
        Label4.Text = "0"
        Label5.Text = "0"
        Label6.Text = "0"
        Label7.Text = "0"
        Label8.Text = "0"
        Button1.Enabled = True
        Button2.Enabled = True

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub CheckButton3Availability()
        If Val(Label7.Text) <> 0 And Val(Label8.Text) <> 0 Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
    End Sub
End Class
