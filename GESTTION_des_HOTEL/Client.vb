Public Class Client
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

        Panel7.BackColor = Color.FromArgb(50, 237, 250, 255)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        Panel5.BackColor = Color.FromArgb(65, 37, 5, 87)
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint
        Panel8.BackColor = Color.FromArgb(150, 40, 39, 53)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseHover(sender As Object, e As EventArgs) Handles Panel1.MouseHover
        Panel1.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Panel1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
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
    Private Sub Panel6_MouseHover(sender As Object, e As EventArgs) Handles Panel6.MouseHover
        Panel6.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Panel6_MouseLeave(sender As Object, e As EventArgs) Handles Panel6.MouseLeave
        Panel6.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Panel1.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Panel1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub
    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        Panel2.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Panel2.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub
    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Panel6.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Panel6.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub
    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles Label5.MouseHover
        Panel3.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Panel3.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub
    Private Sub Label6_MouseHover(sender As Object, e As EventArgs) Handles Label6.MouseHover
        Panel4.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Panel4.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub

    '======================================================================================================================
    '======================================================================================================================
    '======================================================================================================================


    Sub afficher()
        TextBox_num_client.Text = cl.num
        TextBox_nom_client.Text = cl.Nom
        TextBox_prn_client.Text = cl.Prenom
        TextBox_adress_client.Text = cl.Adresse
        TextBox_tele_client.Text = cl.Tel


    End Sub
    Sub effacer()
        TextBox_num_client.Text = ""
        TextBox_nom_client.Text = ""
        TextBox_prn_client.Text = ""
        TextBox_adress_client.Text = ""
        TextBox_tele_client.Text = ""

        TextBox_num_client.Focus()

    End Sub
    Sub Enregistrer()
        cl.num = TextBox_num_client.Text
        cl.Nom = TextBox_nom_client.Text
        cl.Prenom = TextBox_prn_client.Text
        cl.Tel = TextBox_tele_client.Text
        cl.Adresse = TextBox_adress_client.Text
        nf = FreeFile()
        FileOpen(nf, "d:\client.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(cl))
        nm = LOF(nf) / Len(cl) + 1
        FilePut(nf, cl, nm)
        effacer()
        TextBox_num_client.Focus()
        FileClose(nf)


    End Sub

    Sub rechercher()
        trv = False
        nf = FreeFile()
        FileOpen(nf, "d:\client.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(cl))
        For i As Short = 1 To nm
            FileGet(nf, cl, i)
            l = Loc(nf)
            If Trim(cl.num) = Trim(TextBox_num_client.Text) Then
                trv = True
                afficher()

                Exit For
            End If
        Next i
        FileClose(nf)
        If trv = False Then
            MessageBox.Show("code introuvablr!", "Rchercher")
            TextBox_num_client.Focus()
        End If
    End Sub
    Sub lister()
        Dim i As Integer
        nf = FreeFile()
        FileOpen(nf, "d:\client.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(cl))
        nm = LOF(nf) / Len(cl)
        dgv_client.Rows.Clear()
        If nm = 0 Then
            MessageBox.Show("fichier Vide:Rien à Lister", "Liste des enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For i = 1 To nm
                FileGet(nf, cl, i)
                dgv_client.Rows.Add(cl.num, cl.Nom, cl.Prenom, cl.Adresse, cl.Tel)
            Next i
            FileClose(nf)
        End If
    End Sub
    Sub modifier()
        cl.num = TextBox_num_client.Text
        cl.Nom = TextBox_nom_client.Text
        cl.Prenom = TextBox_prn_client.Text
        cl.Adresse = TextBox_adress_client.Text
        cl.Tel = TextBox_tele_client.Text
        nf = FreeFile()
        FileOpen(nf, "d:\client.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(cl))
        FilePut(nf, cl, l)
        FileClose(nf)
        effacer()
    End Sub
    Sub supprimer()
        Dim rep As MsgBoxResult
        Dim i As Short
        Dim j As Short
        nf1 = FreeFile()
        FileOpen(nf1, "d:\newclient.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(cl))
        trv = False
        j = 1
        nf = FreeFile()
        FileOpen(nf, "d:\client.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(cl))

        nm = LOF(nf) / Len(cl)
        For i = 1 To nm
            FileGet(nf, cl, i)
            If Trim(cl.num) = Trim(TextBox_num_client.Text) Then
                afficher()

                trv = True
            Else
                FilePut(nf, cl, j)
                j = j + 1
            End If
        Next i
        If trv = False Then
            MessageBox.Show("code introuvable!")
            TextBox_num_client.Text = ""
            TextBox_num_client.Focus()
            FileClose(nf, nf)
        Else
            rep = MessageBox.Show("Etes vous sur de supprimer cet enregistrements", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rep = MsgBoxResult.Yes Then
                FileClose(nf, nf1)

                Kill("d:\client.don")
                Rename("d:\newclient.don", "d:\client.don")
                nf = FreeFile()
                FileOpen(nf, "d:\client.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(cl))
                nm = LOF(nf) / Len(cl)
                FileClose(nf)
            Else
                FileClose(nf, nf1)
                Kill("d:\newfichier.don")
            End If
            effacer()
            TextBox_num_client.Focus()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Enregistrer()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        rechercher()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        supprimer()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        modifier()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TextBox_num_client.Clear()
        TextBox_nom_client.Clear()
        TextBox_prn_client.Clear()
        TextBox_adress_client.Clear()
        TextBox_tele_client.Clear()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        lister()

    End Sub
End Class