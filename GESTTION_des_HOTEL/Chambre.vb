Public Class Chambre
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        Panel5.BackColor = Color.FromArgb(65, 37, 5, 87)

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint
        Panel7.BackColor = Color.FromArgb(50, 237, 250, 255)
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

    '===========================================================================================================
    '===========================================================================================================



    Sub afficher_chambre()
        TextBox_etag_chambre.Text = chm.etage
        TextBox_prix_chambre.Text = chm.prix
        TextBox_nbr_lie.Text = chm.nbr_lie
        TextBox_num_chambre.Text = chm.num
        TextBox_disp_chambre.Text = chm.dissponible




    End Sub
    Sub effacer_chambre()
        TextBox_etag_chambre.Text = ""
        TextBox_prix_chambre.Text = ""
        TextBox_nbr_lie.Text = ""
        TextBox_num_chambre.Text = ""
        TextBox_disp_chambre.Text = ""
        TextBox_etag_chambre.Focus()



    End Sub
    Sub Enregistrer_chambre()
        chm.num = TextBox_num_chambre.Text
        chm.etage = TextBox_etag_chambre.Text
        chm.nbr_lie = TextBox_nbr_lie.Text
        chm.dissponible = TextBox_disp_chambre.Text
        chm.prix = TextBox_prix_chambre.Text
        nf = FreeFile()
        FileOpen(nf, "d:\chambre.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(chm))
        nm = LOF(nf) / Len(chm) + 1
        FilePut(nf, chm, nm)
        effacer_chambre()
        TextBox_num_chambre.Focus()
        FileClose(nf)



    End Sub
    Sub rechercher()
        trv = False
        nf = FreeFile()
        FileOpen(nf, "d:\chambre.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(chm))
        For i As Short = 1 To nm
            FileGet(nf, chm, i)
            l = Loc(nf)
            If Trim(chm.num) = Trim(TextBox_num_chambre.Text) Then
                trv = True
                afficher_chambre()

                Exit For
            End If
        Next i
        FileClose(nf)
        If trv = False Then
            MessageBox.Show("code introuvablr!", "Rchercher")
            TextBox_num_chambre.Focus()
        End If
    End Sub
    Sub lister()
        Dim i As Integer
        nf = FreeFile()
        FileOpen(nf, "d:\chambre.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(chm))
        nm = LOF(nf) / Len(chm)
        dgv_chambre.Rows.Clear()
        If nm = 0 Then
            MessageBox.Show("fichier Vide:Rien à Lister", "Liste des enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For i = 1 To nm
                FileGet(nf, chm, i)
                dgv_chambre.Rows.Add(chm.num, chm.etage, chm.nbr_lie, chm.dissponible, chm.prix)
            Next i
            FileClose(nf)
        End If
    End Sub
    Sub modifier()
        TextBox_etag_chambre.Text = chm.etage
        TextBox_prix_chambre.Text = chm.prix
        TextBox_nbr_lie.Text = chm.nbr_lie
        TextBox_num_chambre.Text = chm.num
        TextBox_disp_chambre.Text = chm.dissponible
        nf = FreeFile()
        FileOpen(nf, "d:\chambre.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(chm))
        FilePut(nf, chm, l)
        FileClose(nf)
        effacer_chambre()
    End Sub
    Sub supprimer_chambre()
        Dim rep As MsgBoxResult
        Dim i As Short
        Dim j As Short
        nf1 = FreeFile()
        FileOpen(nf, "d:\newchambre.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(chm))
        trv = False
        j = 1
        nf = FreeFile()
        FileOpen(nf, "d:\chambre.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(chm))
        nm = LOF(nf) / Len(chm)
        For i = 1 To nm
            FileGet(nf, chm, i)
            If Trim(chm.num) = Trim(TextBox_num_chambre.Text) Then
                afficher_chambre()

                trv = True
            Else
                FilePut(nf, chm, j)
                j = j + 1
            End If
        Next i
        If trv = False Then
            MessageBox.Show("code introuvable!")
            TextBox_num_chambre.Text = ""
            TextBox_num_chambre.Focus()
            FileClose(nf, nf)
        Else
            rep = MessageBox.Show("Etes vous sur de supprimer cet enregistrements", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rep = MsgBoxResult.Yes Then
                FileClose(nf, nf1)
                Kill("d:\chambre.don")
                Rename("d:\newchambre.don", "d:\chambre.don")
                nf = FreeFile()
                FileOpen(nf, "d:\chambre.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(chm))
                nm = LOF(nf) / Len(chm)
                FileClose(nf)
            Else
                FileClose(nf, nf1)
                Kill("d:\newchambre.don")
            End If
            effacer_chambre()
            TextBox_num_chambre.Focus()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Enregistrer_chambre()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        modifier()

    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        supprimer_chambre()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        rechercher()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TextBox_etag_chambre.Clear()
        TextBox_prix_chambre.Clear()
        TextBox_nbr_lie.Clear()
        TextBox_num_chambre.Clear()
        TextBox_disp_chambre.Clear()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        lister()
    End Sub

    Private Sub TextBox_nbr_lie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nbr_lie.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBox_prix_chambre.Text = (TextBox_nbr_lie.Text * 100) + 2000
            TextBox_disp_chambre.Text = "oui"
        End If

    End Sub
End Class