Imports System.Data.OleDb
Module Conn
    Public cnn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Plane.mdb")
    Public Sub copen()
        If cnn.State <> ConnectionState.Open Then
            cnn.Open()
        End If
    End Sub
    Public Sub cclose()
        cnn.Close()
    End Sub

End Module
