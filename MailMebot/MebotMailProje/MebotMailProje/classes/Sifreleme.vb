Imports System.Security.Cryptography

Public NotInheritable Class Simple3Des
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private Function TruncateHash(
           ByVal key As String,
           ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function
    Sub New(ByVal key As String)
        ' Initialize the crypto provider.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub
    Public Function EncryptData(
            ByVal plaintext As String) As String

        ' Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string.
        Return Convert.ToBase64String(ms.ToArray)
    End Function
    Public Function DecryptData(
           ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array.
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream.
        Dim decStream As New CryptoStream(ms,
            TripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string.
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Class

Public Class Sifreleme
    Public sayac As Integer
    Shared plainText As String
    Shared password As String
    Shared cipherText As String
    Shared wrapper As Simple3Des()
    Shared SifreDizisi() As String
    Public ciphertxt As String = cipherText
    Dim karakterC As Char = Chr(226)
    Dim karakterS As String = karakterC + karakterC + karakterC + karakterC + karakterC
    Function TestEncoding(ByVal icerik As String, ByVal sifre As String) As String
        plainText = icerik
        password = sifre
        sayac += 1
        Dim wrapper As New Simple3Des(password)
        cipherText = wrapper.EncryptData(plainText) & karakterS
        'MsgBox("Verinin Şifrelenmiş Hali: " & cipherText)
        MsgBox("Veriniz Şifrelendi.")
        My.Computer.FileSystem.WriteAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
            "\cipherText.txt", cipherText, False)
        Return cipherText
    End Function

    Function TestDecoding(ByVal sifre As String) As String
        cipherText = My.Computer.FileSystem.ReadAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
                "\cipherText.txt")
        password = sifre
        Dim wrapper As New Simple3Des(password)
        plainText = ""
        SifreDizisi = cipherText.Split(Chr(226).ToString())


        Try
            plainText = wrapper.DecryptData(SifreDizisi(0))
            'MsgBox(plainText)

        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("Verilerin Şifresini Çözme Yetkiniz Yok!")
        End Try
        Return plainText
    End Function

End Class



