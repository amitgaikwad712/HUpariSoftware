Imports System.Data.OleDb

Public Class NewUser

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\SutMashineProduct.mdb"
        Dim uname, password, confirmpassword, userId As String
        Dim dateAndTime As Date
        dateAndTime = Now
        userId = Format(dateAndTime, "yyyyMMddHHmmss").ToString
        uname = txtuname.Text
        password = txtpassword.Text
        confirmpassword = txtconfirmpass.Text
        If password.Equals(confirmpassword) Then
            Using con1 As New OleDbConnection(connect)
                con1.Open()
                Using cmd2 As New OleDbCommand("INSERT INTO [login-table] VALUES(?,?,?)", con1)
                    cmd2.Parameters.AddWithValue("", userId)
                    cmd2.Parameters.AddWithValue("", txtuname.Text)
                    cmd2.Parameters.AddWithValue("", txtpassword.Text)
                    cmd2.ExecuteNonQuery()
                    MsgBox("Added Successfully....")
                End Using
                con1.Close()
            End Using
        Else
            MsgBox("password and Confirm Password has not same...")
        End If
 
    End Sub
End Class