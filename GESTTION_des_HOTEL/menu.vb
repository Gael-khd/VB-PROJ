Public Class menu
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.BackColor = Color.FromArgb(195, 23, 11, 62)
    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        Panel2.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub
    Private Sub Panel3_MouseHover(sender As Object, e As EventArgs) Handles Panel3.MouseHover
        Panel3.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        Panel3.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub
    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles Panel4.MouseHover
        Panel4.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave
        Panel4.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub




    Private Sub Panel5_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        Panel5.BackColor = Color.FromArgb(150, 40, 39, 53)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Do While Panel1.Width < 386
            Panel1.Width = 386

        Loop

        Panel5.Visible = True


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Do While Panel1.Width > 117
            Panel1.Width = 117


        Loop
        Panel5.Visible = False

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint
        Panel8.BackColor = Color.FromArgb(130, 34, 36, 57)
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Panel2.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Panel2.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Panel3.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Panel3.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        Panel4.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Panel4.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        End

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        With Client
            .TopLevel = False
            Panel8.Controls.Add(Client)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        With Chambre
            .TopLevel = False
            Panel8.Controls.Add(Chambre)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        With Reservation
            .TopLevel = False
            Panel8.Controls.Add(Reservation)
            .BringToFront()
            .Show()
        End With
    End Sub







    Private Sub Label7_Click_2(sender As Object, e As EventArgs) Handles Label7.Click
        End
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Label7_MouseHover(sender As Object, e As EventArgs) Handles Label7.MouseHover
        Label7.BackColor = System.Drawing.Color.FromArgb(235, 0, 12)
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub
    Private Sub Label8_MouseHover(sender As Object, e As EventArgs) Handles Label8.MouseHover
        Label8.BackColor = System.Drawing.Color.FromArgb(103, 173, 169)
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Label8.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub
End Class
