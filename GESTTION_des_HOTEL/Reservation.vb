Public Class Reservation
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

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Panel6.BackColor = System.Drawing.Color.FromArgb(40, 39, 53)
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Panel6.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
    End Sub
    '==================================================================================================================
    '==================================================================================================================


    Sub afficher()
        TextBox_num_client_res.Text = res.num_client_res
        TextBox_num_cham.Text = res.num_chambre_res
    End Sub
    Sub afficher_client()
        TextBox_nom_client_res.Text = cl.Nom
        TextBox_prn_res.Text = cl.Prenom
        TextBox_tel_res.Text = cl.Tel
        TextBox_adrs_res.Text = cl.Adresse
    End Sub
    Sub afficher_chambre()
        TextBox_etag_res.Text = chm.etage
        TextBox_nbr_lie_cham.Text = chm.nbr_lie
        TextBox_diss_res.Text = chm.dissponible
        TextBox_prix_res.Text = chm.prix
    End Sub
    Sub rechercher_client()
        trv = False
        nf = FreeFile()
        FileOpen(nf, "d:\client.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(cl))
        For i As Short = 1 To nm
            FileGet(nf, cl, i)
            l = Loc(nf)
            If Trim(cl.num) = Trim(TextBox_num_client_res.Text) Then
                trv = True
                afficher_client()

                Exit For
            End If
        Next i
        FileClose(nf)
        If trv = False Then
            MessageBox.Show("code introuvablr!", "Rchercher")
            TextBox_num_client_res.Focus()
        End If
    End Sub
    Sub rechercher_chambre()
        Dim g As Boolean = False
        trv = False
        nf = FreeFile()
        FileOpen(nf, "d:\chambre.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(chm))
        nm = LOF(nf) / Len(chm)
        For i As Short = 1 To nm
            FileGet(nf, chm, i)
            r = Loc(nf)
            If Trim(chm.num).CompareTo(Trim(TextBox_num_cham.Text)) = 0 Then
                If Trim(chm.dissponible).CompareTo("oui") = 0 Then
                    afficher_chambre()
                    g = True
                Else MessageBox.Show("Cette chambre est reservée selectionner une autre chambre")
                    TextBox_diss_res.Text = chm.dissponible
                    r = 0
                End If
                trv = True
                Exit For
            End If
        Next i
        FileClose(nf)

        If g = True Then
            chm.dissponible = "non"
            nf = FreeFile()
            FileOpen(nf, "d:\chambre.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(chm))
            FilePut(nf, chm, r)
            FileClose(nf)
        End If
        If trv = False Then
            MessageBox.Show("code introuvablr!", "Rchercher")
            TextBox_num_cham.Focus()
        End If
    End Sub



    Private Sub TextBox_num_client_res_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_num_client_res.KeyPress
        If Asc(e.KeyChar) = 13 Then
            rechercher_client()
        End If
    End Sub

    Private Sub TextBox_num_cham_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_num_cham.KeyPress
        If Asc(e.KeyChar) = 13 Then
            rechercher_chambre()
        End If
    End Sub
    Sub Enregistrer_reservation()
        res.num_client_res = TextBox_num_client_res.Text
        res.num_chambre_res = TextBox_num_cham.Text
        res.etage_chambre_res = TextBox_etag_res.Text
        res.nbr_lie_chambre_res = TextBox_nbr_lie_cham.Text
        res.dissponible_chambre_res = TextBox_diss_res.Text
        res.prix_chambre_res = TextBox_prix_res.Text
        res.Nom_client_res = TextBox_nom_client_res.Text
        res.Prenom_client_res = TextBox_prn_res.Text
        res.Adresse_client_res = TextBox_adrs_res.Text
        res.Tel_client_res = TextBox_tel_res.Text
        res.nbr_joure_res = TextBox_nrb_jour_res.Text
        res.prix_total_chambre_res = Prix_totale.Text
        nf = FreeFile()
        FileOpen(nf, "d:\reservation.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(res))
        nm = LOF(nf) / Len(res) + 1
        FilePut(nf, res, nm)

        TextBox_num_client_res.Focus()
        FileClose(nf)



    End Sub
    Sub lister()
        Dim i As Integer
        nf = FreeFile()
        FileOpen(nf, "d:\reservation.don", OpenMode.Random, OpenAccess.ReadWrite, , Len(res))
        nm = LOF(nf) / Len(res)
        dgv_res.Rows.Clear()
        If nm = 0 Then
            MessageBox.Show("fichier Vide:Rien à Lister", "Liste des enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For i = 1 To nm
                FileGet(nf, res, i)
                dgv_res.Rows.Add(res.num_client_res, res.Nom_client_res, res.Prenom_client_res, res.num_chambre_res, res.nbr_joure_res, res.prix_total_chambre_res)

            Next i
            FileClose(nf)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Enregistrer_reservation()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        lister()

    End Sub


    Private Sub TextBox_nrb_jour_res_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nrb_jour_res.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Prix_totale.Text = TextBox_prix_res.Text * TextBox_nrb_jour_res.Text
        End If
    End Sub
End Class