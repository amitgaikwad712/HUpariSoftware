Imports System.Data.OleDb

Public Class Rate

    Private Sub Rate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SutMashineProductDataSet2._rate_table' table. You can move, or remove it, as needed.
        Me.Rate_tableTableAdapter.Fill(Me.SutMashineProductDataSet2._rate_table)
        'TODO: This line of code loads data into the 'SutMashineProductDataSet1._customer_table' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim query3 As String = "UPDATE [rate-table] SET price=? WHERE rateId=?"
        Dim connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\SutMashineProduct.mdb"
        Using conn As New OleDbConnection(connect)
            Using cmd As New OleDbCommand(query3, conn)
                cmd.Parameters.AddWithValue("", txtPrice.Text)
                cmd.Parameters.AddWithValue("", txtrateId.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("दर बदलला..")
            End Using
        End Using
        txtname.Text = ""
        txtPrice.Text = ""
        txtrateId.Text = ""
        Me.Rate_tableTableAdapter.Fill(Me.SutMashineProductDataSet2._rate_table)
    End Sub
End Class