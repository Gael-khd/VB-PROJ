<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv_res = New System.Windows.Forms.DataGridView()
        Me.num_client_res = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_client_res = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenom_client_res = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_chambre_res = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nbr_jour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prix_chambre_res = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix_totale = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_nrb_jour_res = New System.Windows.Forms.TextBox()
        Me.TextBox_prix_res = New System.Windows.Forms.TextBox()
        Me.TextBox_diss_res = New System.Windows.Forms.TextBox()
        Me.TextBox_nbr_lie_cham = New System.Windows.Forms.TextBox()
        Me.TextBox_etag_res = New System.Windows.Forms.TextBox()
        Me.TextBox_num_cham = New System.Windows.Forms.TextBox()
        Me.TextBox_adrs_res = New System.Windows.Forms.TextBox()
        Me.TextBox_tel_res = New System.Windows.Forms.TextBox()
        Me.TextBox_prn_res = New System.Windows.Forms.TextBox()
        Me.TextBox_nom_client_res = New System.Windows.Forms.TextBox()
        Me.TextBox_num_client_res = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_res, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.PictureBox4)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel6.Location = New System.Drawing.Point(29, 265)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(296, 48)
        Me.Panel6.TabIndex = 5
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.GESTTION_des_HOTEL.My.Resources.Resources.load_bottom_left_5121
        Me.PictureBox4.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 44)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(45, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Confirmer la reservation"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(331, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 48)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GESTTION_des_HOTEL.My.Resources.Resources._1149031
        Me.PictureBox1.Location = New System.Drawing.Point(2, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(42, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Lister le reservation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(592, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 33)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "- Numero de la chambre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(592, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 33)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "- Etage"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(592, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 33)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "- Nombre de lie"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(594, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 33)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "- Avec une tele"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(594, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 33)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "- Prix"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel5.Controls.Add(Me.dgv_res)
        Me.Panel5.Controls.Add(Me.Prix_totale)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.TextBox_nrb_jour_res)
        Me.Panel5.Controls.Add(Me.TextBox_prix_res)
        Me.Panel5.Controls.Add(Me.TextBox_diss_res)
        Me.Panel5.Controls.Add(Me.TextBox_nbr_lie_cham)
        Me.Panel5.Controls.Add(Me.TextBox_etag_res)
        Me.Panel5.Controls.Add(Me.TextBox_num_cham)
        Me.Panel5.Controls.Add(Me.TextBox_adrs_res)
        Me.Panel5.Controls.Add(Me.TextBox_tel_res)
        Me.Panel5.Controls.Add(Me.TextBox_prn_res)
        Me.Panel5.Controls.Add(Me.TextBox_nom_client_res)
        Me.Panel5.Controls.Add(Me.TextBox_num_client_res)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 41)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1159, 624)
        Me.Panel5.TabIndex = 14
        '
        'dgv_res
        '
        Me.dgv_res.AllowUserToAddRows = False
        Me.dgv_res.AllowUserToDeleteRows = False
        Me.dgv_res.AllowUserToResizeColumns = False
        Me.dgv_res.AllowUserToResizeRows = False
        Me.dgv_res.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_res.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_res.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_res.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_client_res, Me.Nom_client_res, Me.Prenom_client_res, Me.num_chambre_res, Me.nbr_jour, Me.prix_chambre_res})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_res.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_res.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_res.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv_res.Location = New System.Drawing.Point(0, 363)
        Me.dgv_res.Name = "dgv_res"
        Me.dgv_res.RowTemplate.Height = 30
        Me.dgv_res.Size = New System.Drawing.Size(1159, 261)
        Me.dgv_res.TabIndex = 92
        '
        'num_client_res
        '
        Me.num_client_res.HeaderText = "numero"
        Me.num_client_res.Name = "num_client_res"
        '
        'Nom_client_res
        '
        Me.Nom_client_res.HeaderText = "nom"
        Me.Nom_client_res.Name = "Nom_client_res"
        '
        'Prenom_client_res
        '
        Me.Prenom_client_res.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Prenom_client_res.HeaderText = "prenom"
        Me.Prenom_client_res.Name = "Prenom_client_res"
        '
        'num_chambre_res
        '
        Me.num_chambre_res.HeaderText = "numero de la chambre"
        Me.num_chambre_res.Name = "num_chambre_res"
        Me.num_chambre_res.Width = 350
        '
        'nbr_jour
        '
        Me.nbr_jour.HeaderText = "Nombre de joure"
        Me.nbr_jour.Name = "nbr_jour"
        Me.nbr_jour.Width = 250
        '
        'prix_chambre_res
        '
        Me.prix_chambre_res.HeaderText = "Prix totale"
        Me.prix_chambre_res.Name = "prix_chambre_res"
        Me.prix_chambre_res.Width = 200
        '
        'Prix_totale
        '
        Me.Prix_totale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Prix_totale.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.Prix_totale.Location = New System.Drawing.Point(850, 250)
        Me.Prix_totale.Name = "Prix_totale"
        Me.Prix_totale.Size = New System.Drawing.Size(260, 33)
        Me.Prix_totale.TabIndex = 91
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(594, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 33)
        Me.Label16.TabIndex = 90
        Me.Label16.Text = "- Prix totale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(594, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 33)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "- Nombre de joure"
        '
        'TextBox_nrb_jour_res
        '
        Me.TextBox_nrb_jour_res.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_nrb_jour_res.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_nrb_jour_res.Location = New System.Drawing.Point(850, 208)
        Me.TextBox_nrb_jour_res.Name = "TextBox_nrb_jour_res"
        Me.TextBox_nrb_jour_res.Size = New System.Drawing.Size(260, 33)
        Me.TextBox_nrb_jour_res.TabIndex = 87
        '
        'TextBox_prix_res
        '
        Me.TextBox_prix_res.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_prix_res.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_prix_res.Location = New System.Drawing.Point(850, 169)
        Me.TextBox_prix_res.Name = "TextBox_prix_res"
        Me.TextBox_prix_res.Size = New System.Drawing.Size(260, 33)
        Me.TextBox_prix_res.TabIndex = 86
        '
        'TextBox_diss_res
        '
        Me.TextBox_diss_res.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_diss_res.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_diss_res.Location = New System.Drawing.Point(850, 130)
        Me.TextBox_diss_res.Name = "TextBox_diss_res"
        Me.TextBox_diss_res.Size = New System.Drawing.Size(260, 33)
        Me.TextBox_diss_res.TabIndex = 83
        '
        'TextBox_nbr_lie_cham
        '
        Me.TextBox_nbr_lie_cham.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_nbr_lie_cham.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_nbr_lie_cham.Location = New System.Drawing.Point(850, 91)
        Me.TextBox_nbr_lie_cham.Name = "TextBox_nbr_lie_cham"
        Me.TextBox_nbr_lie_cham.Size = New System.Drawing.Size(260, 33)
        Me.TextBox_nbr_lie_cham.TabIndex = 84
        '
        'TextBox_etag_res
        '
        Me.TextBox_etag_res.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_etag_res.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_etag_res.Location = New System.Drawing.Point(850, 52)
        Me.TextBox_etag_res.Name = "TextBox_etag_res"
        Me.TextBox_etag_res.Size = New System.Drawing.Size(260, 33)
        Me.TextBox_etag_res.TabIndex = 85
        '
        'TextBox_num_cham
        '
        Me.TextBox_num_cham.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_num_cham.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_num_cham.Location = New System.Drawing.Point(850, 13)
        Me.TextBox_num_cham.Name = "TextBox_num_cham"
        Me.TextBox_num_cham.Size = New System.Drawing.Size(260, 33)
        Me.TextBox_num_cham.TabIndex = 82
        '
        'TextBox_adrs_res
        '
        Me.TextBox_adrs_res.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_adrs_res.Location = New System.Drawing.Point(257, 194)
        Me.TextBox_adrs_res.Name = "TextBox_adrs_res"
        Me.TextBox_adrs_res.Size = New System.Drawing.Size(263, 40)
        Me.TextBox_adrs_res.TabIndex = 67
        '
        'TextBox_tel_res
        '
        Me.TextBox_tel_res.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_tel_res.Location = New System.Drawing.Point(257, 148)
        Me.TextBox_tel_res.Name = "TextBox_tel_res"
        Me.TextBox_tel_res.Size = New System.Drawing.Size(263, 40)
        Me.TextBox_tel_res.TabIndex = 68
        '
        'TextBox_prn_res
        '
        Me.TextBox_prn_res.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_prn_res.Location = New System.Drawing.Point(257, 102)
        Me.TextBox_prn_res.Name = "TextBox_prn_res"
        Me.TextBox_prn_res.Size = New System.Drawing.Size(263, 40)
        Me.TextBox_prn_res.TabIndex = 69
        '
        'TextBox_nom_client_res
        '
        Me.TextBox_nom_client_res.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_nom_client_res.Location = New System.Drawing.Point(257, 56)
        Me.TextBox_nom_client_res.Name = "TextBox_nom_client_res"
        Me.TextBox_nom_client_res.Size = New System.Drawing.Size(263, 40)
        Me.TextBox_nom_client_res.TabIndex = 66
        '
        'TextBox_num_client_res
        '
        Me.TextBox_num_client_res.Font = New System.Drawing.Font("Bahnschrift", 20.25!)
        Me.TextBox_num_client_res.Location = New System.Drawing.Point(257, 10)
        Me.TextBox_num_client_res.Name = "TextBox_num_client_res"
        Me.TextBox_num_client_res.Size = New System.Drawing.Size(263, 40)
        Me.TextBox_num_client_res.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(29, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 33)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "- Adress"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(29, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 33)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "- Telephone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(23, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 33)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "- Prenom"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(29, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 33)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "- Nom"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(29, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(178, 33)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "- Numero du client"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(1112, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 49)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "X"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1159, 41)
        Me.Panel7.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(385, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(253, 35)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Interface reservation"
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GESTTION_des_HOTEL.My.Resources.Resources.Capture_backroud2
        Me.ClientSize = New System.Drawing.Size(1159, 665)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reservation"
        Me.Text = "Form2"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgv_res, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox_adrs_res As TextBox
    Friend WithEvents TextBox_tel_res As TextBox
    Friend WithEvents TextBox_prn_res As TextBox
    Friend WithEvents TextBox_nom_client_res As TextBox
    Friend WithEvents TextBox_num_client_res As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_nrb_jour_res As TextBox
    Friend WithEvents TextBox_prix_res As TextBox
    Friend WithEvents TextBox_diss_res As TextBox
    Friend WithEvents TextBox_nbr_lie_cham As TextBox
    Friend WithEvents TextBox_etag_res As TextBox
    Friend WithEvents TextBox_num_cham As TextBox
    Friend WithEvents Prix_totale As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dgv_res As DataGridView
    Friend WithEvents num_client_res As DataGridViewTextBoxColumn
    Friend WithEvents Nom_client_res As DataGridViewTextBoxColumn
    Friend WithEvents Prenom_client_res As DataGridViewTextBoxColumn
    Friend WithEvents num_chambre_res As DataGridViewTextBoxColumn
    Friend WithEvents nbr_jour As DataGridViewTextBoxColumn
    Friend WithEvents prix_chambre_res As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
