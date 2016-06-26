Imports System.Data.OleDb
Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim query As String = "select * from login-table"
        Dim connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\SutMashineProduct.mdb"
        Dim uname, password, passwordCheck As String
        Dim isLogged As Boolean = False
        uname = txtUserName.Text
        password = txtPassword.Text
        Using con1 As New OleDbConnection(connect)
            con1.Open()
            Using cmd2 As New OleDbCommand("SELECT * FROM [login-table] WHERE user_name=?", con1)
                cmd2.Parameters.AddWithValue("", uname)
                Using reader1 As OleDbDataReader = cmd2.ExecuteReader
                    While reader1.Read
                        passwordCheck = reader1("password")
                        If password.Equals(passwordCheck) Then
                            isLogged = True
                        End If
                    End While
                End Using
            End Using
            con1.Close()
        End Using
        If isLogged Then
            MsgBox("Login Successful..")
        Else
            MsgBox("Login Failed....")
        End If


    End Sub
End Class
