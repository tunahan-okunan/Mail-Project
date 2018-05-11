Imports System.Data.SqlClient
Imports System.Configuration
Public MustInherit Class SqlDB
    Implements ISqlDB
    Protected komut As SqlCommand
    Protected bilgi As SqlDataReader
    Private baglan As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("baglanti").ConnectionString)
    Protected adapter As SqlDataAdapter
    Protected table As DataTable

    'appconfigde tanımladıgımız baglanti yi buraya aldık buradada adı baglanti oldu.
    Protected Sub Connect() Implements ISqlDB.Connect
        If baglan.State = ConnectionState.Closed Then
            baglan.Open()
        End If
        komut = New SqlCommand()
        komut.Connection = baglan
    End Sub

    Protected Sub DisConnect() Implements ISqlDB.DisConnect
        If baglan.State = ConnectionState.Open Then
            baglan.Close()
        End If
    End Sub
End Class
