Module Modul

    Structure CLIENT
            <VBFixedString(20)> Public num As String
            <VBFixedString(20)> Public Nom As String
            <VBFixedString(20)> Public Prenom As String
            <VBFixedString(20)> Public Adresse As String
            <VBFixedString(20)> Public Tel As String
        End Structure
        Public cl As CLIENT
        Structure CHAMBRE
            <VBFixedString(20)> Public num As String
            <VBFixedString(20)> Public etage As String
            <VBFixedString(20)> Public nbr_lie As String
            <VBFixedString(20)> Public dissponible As String
            <VBFixedString(20)> Public prix As String
        End Structure
        Public chm As CHAMBRE
        Structure RESERVATION
            <VBFixedString(20)> Public num_client_res As String
            <VBFixedString(20)> Public num_chambre_res As String
            <VBFixedString(20)> Public etage_chambre_res As String
            <VBFixedString(20)> Public nbr_lie_chambre_res As String
        <VBFixedString(20)> Public dissponible_chambre_res As String
        <VBFixedString(20)> Public prix_total_chambre_res As String
        <VBFixedString(20)> Public prix_chambre_res As String
        <VBFixedString(20)> Public nbr_joure_res As String
        <VBFixedString(20)> Public Nom_client_res As String
        <VBFixedString(20)> Public Prenom_client_res As String
        <VBFixedString(20)> Public Adresse_client_res As String
        <VBFixedString(20)> Public Tel_client_res As String


    End Structure
        Public res As RESERVATION
        Public nf1 As Short
        Public nf As Short
        Public nm As Short
        Public trv As Short
    Public l As Short
    Public r As Short









End Module
