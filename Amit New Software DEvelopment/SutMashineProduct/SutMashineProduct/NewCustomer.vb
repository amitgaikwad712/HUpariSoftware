Imports System.Data.OleDb

Public Class NewCustomer

    Private Sub NewCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SutMashineProductDataSet1._customer_table' table. You can move, or remove it, as needed.
        Me.Customer_tableTableAdapter.Fill(Me.SutMashineProductDataSet1._customer_table)


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\SutMashineProduct.mdb"
        Dim custname, address, phoneNumber, custId As String
        Dim dateAndTime As Date
        dateAndTime = Now
        custId = Format(dateAndTime, "yyyyMMddHHmmss").ToString
        custname = txtcustName.Text
        address = txtAddress.Text
        phoneNumber = txtMobile.Text
        If TextBox1.Text.Equals("") Then
            Using con1 As New OleDbConnection(connect)
                con1.Open()
                Using cmd2 As New OleDbCommand("INSERT INTO [customer-table] VALUES(?,?,?,?)", con1)
                    cmd2.Parameters.AddWithValue("", custId)
                    cmd2.Parameters.AddWithValue("", custname)
                    cmd2.Parameters.AddWithValue("", address)
                    cmd2.Parameters.AddWithValue("", phoneNumber)
                    cmd2.ExecuteNonQuery()
                    MsgBox("Added Successfully....")
                    txtAddress.Text = ""
                    txtcustName.Text = ""
                    txtMobile.Text = ""
                    Me.Customer_tableTableAdapter.Fill(Me.SutMashineProductDataSet1._customer_table)
                End Using
                con1.Close()
            End Using
        Else
            MsgBox("Fileds are mandatory....")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtAddress.Text = ""
        txtcustName.Text = ""
        txtMobile.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\SutMashineProduct.mdb"
        Dim custId As String
        Dim dateAndTime As Date
        dateAndTime = Now
        custId = TextBox1.Text
        If custId.Equals("") Then
            MsgBox("कृपया खातेदार सिलेक्ट करा...")
        Else
            Using con1 As New OleDbConnection(connect)
                con1.Open()
                Using cmd2 As New OleDbCommand("DELETE FROM [customer-table] WHERE customer_id=?", con1)
                    cmd2.Parameters.AddWithValue("", custId)
                    Dim result As Integer = MessageBox.Show("मिटवून टाकायचा आहे का ?", "पर्याय निवडा", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then

                    ElseIf result = DialogResult.Yes Then
                        cmd2.ExecuteNonQuery()
                        Me.DataGridView1.Update()
                    End If
                End Using
                con1.Close()
            End Using
        End If




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim query3 As String = "UPDATE [customer-table] SET customer_name=?,address=?,phone_number=? WHERE customer_id=?"
        Dim connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\SutMashineProduct.mdb"
        Using conn As New OleDbConnection(connect)
            Using cmd As New OleDbCommand(query3, conn)
                cmd.Parameters.AddWithValue("", txtcustName.Text)
                cmd.Parameters.AddWithValue("", txtAddress.Text)
                cmd.Parameters.AddWithValue("", txtMobile.Text)
                cmd.Parameters.AddWithValue("", TextBox1.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("माहिती बदलली..")
            End Using
        End Using
        DataGridView1.Refresh()
        TextBox1.Text = ""
        txtAddress.Text = ""
        txtcustName.Text = ""
        txtMobile.Text = ""
        Me.Customer_tableTableAdapter.Fill(Me.SutMashineProductDataSet1._customer_table)
    End Sub
End Class