
Imports System.Data.OleDb

Public Class Description
    Dim w1, w2, w3, w4, w5, w6, w7, w8, w9, w10, w11, w12, w13 As Integer
    Dim s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13 As String
    Dim totalweight, remaining As Integer

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Me.Hide()
        'frmHome.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Application.Exit()
    End Sub

    Private Sub Description_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SutMashineProductDataSet3._customer_table' table. You can move, or remove it, as needed.
        Me.Customer_tableTableAdapter.Fill(Me.SutMashineProductDataSet3._customer_table)
        '  DateTimePicker1.Format = DateTimePickerFormat.Custom
        ' DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        'TODO: This line of code loads data into the 'SutMDataBDataSet7.tbl_custbill' table. You can move, or remove it, as needed.
        '        Me.Customer_tableTableAdapter.Fill(Me.SutMashineProductDataSet3._customer_table)

        'Me.Tbl_custbillTableAdapter1.Fill(Me.SutMDataBDataSet7.tbl_custbill)

        'TODO: This line of code lads data into the 'SutMDataBDataSet1.tbl_custbill' table. You can move, or remove it, as needed.
        '       Me.Tbl_custbillTableAdapter.Fill(Me.SutMDataBDataSet1.tbl_custbill)
        p2.Visible = False
        p3.Visible = False
        p5.Visible = False
        p4.Visible = False
        p6.Visible = False
        p11.Visible = False
        p10.Visible = False
        p8.Visible = False
        p7.Visible = False
        p12.Visible = False
        p9.Visible = False
        p13.Visible = False

    End Sub


    Private Sub combo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo1.SelectedIndexChanged
        Dim a As Integer
        a = totalweight - w1

        totalweight = Integer.Parse(txttotalweight.Text)
        w1 = Integer.Parse(tw1.Text)
        If (totalweight < w1) Then
            MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
            p2.Visible = False
        ElseIf totalweight > w1 Then

            p2.Visible = True
        Else
            p2.Visible = False

        End If

        c1.Items.Clear()

        If combo1.SelectedIndex = 0 Then
            txtgej1.Visible = False
            c1.Items.Add("१५ ओढणी")
            c1.Items.Add("१५|| ओढणी")
            c1.Items.Add("१६ ओढणी")
            c1.Items.Add("१६||ओढणी")
            c1.Items.Add("१७ ओढणी")
            c1.Items.Add("१७| ओढणी")
            c1.Items.Add("१७|| ओढणी")
            c1.Items.Add("१८ ओढणी")
            c1.Items.Add("१८|ओढणी")
            c1.Items.Add("१८||ओढणी")
            c1.Items.Add("१९ओढणी")
            c1.Items.Add("१९|ओढणी")
            c1.Items.Add("१९||ओढणी")
            c1.Items.Add("२०ओढणी")
            c1.Items.Add("२०|ओढणी")
            c1.Items.Add("२०||ओढणी")
            c1.Items.Add("२१ओढणी")
            c1.Items.Add("२१|ओढणी")
            c1.Items.Add("२१||ओढणी")
            c1.Items.Add("२२ ओढणी")
            c1.Items.Add("२२|ओढणी")
            c1.Items.Add("२२||ओढणी")
            c1.Items.Add("२३ ओढणी")
            c1.Items.Add("२४ ओढणी")
            c1.Items.Add("२५ ओढणी")
        End If
        If combo1.SelectedIndex = 1 Then
            txtgej1.Visible = True

            c1.Items.Add("कडचे फासे")
            c1.Items.Add("ळ कडी")
            c1.Items.Add("ळ सुत")
            c1.Items.Add("रु नाका कडी")
            c1.Items.Add("मधले फासे")

        End If
        If combo1.SelectedIndex = 2 Then
            txtgej1.Visible = True

            c1.Items.Add("कडचे फासे")
            c1.Items.Add("ळ कडी")
            c1.Items.Add("ळ सुत")
            c1.Items.Add("रु नाका कडी")
            c1.Items.Add("मधले फासे")

        End If
        If combo1.SelectedIndex = 3 Then
            txtgej1.Visible = False
            c1.Items.Add("साधा निमगोल ")
            c1.Items.Add("सेलम निमगोल")
            c1.Items.Add("चपटे निमगोल")
            c1.Items.Add("Jad निमगोल")

        End If

        If combo1.SelectedIndex = 4 Then
            txtgej1.Visible = False
            c1.Items.Add("३०० घागरी माटी")
            c1.Items.Add("३५० घागरी माटी")
        End If
        If combo1.SelectedIndex = 5 Then
            txtgej1.Visible = True
            c1.Items.Add("१६ ravakadi")
            c1.Items.Add("१७ ravakadi")
        End If
        If combo1.SelectedIndex = 6 Then
            txtgej1.Visible = True
            c1.Text = combo1.Text


        End If
        If combo1.SelectedIndex = 7 Then
            c1.Items.Add("२१ रुपाली पांचाली 3 लाईन")
            c1.Items.Add("२१ रुपाली panchali 4 line")
            c1.Items.Add("२१ रुपाली panchali 5 line")
            c1.Items.Add("२२ रुपाली panchali 3 line")
            c1.Items.Add("२२ रुपाली panchali 4 line")
            c1.Items.Add("२२ रुपाली panchali 5 line")
            c1.Items.Add("२३ रुपाली panchali 3 line")
            c1.Items.Add("२३ रुपाली panchali 4 line")
            c1.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo1.SelectedIndex = 8 Then
            txtgej1.Visible = False
            c1.Text = combo1.Text

        End If

        If combo1.SelectedIndex = 9 Then
            c1.Items.Add("२१ गजश्री panchali 3 line")
            c1.Items.Add("२१ गजश्री panchali 4 line")
            c1.Items.Add("२१ गजश्री panchali 5 line")
            c1.Items.Add("२२ गजश्री panchali 3 line")
            c1.Items.Add("२२ गजश्री panchali 4 line")
            c1.Items.Add("२२ गजश्री panchali 5 line")
            c1.Items.Add("२३ गजश्री panchali 3 line")
            c1.Items.Add("२३ गजश्री panchali 4 line")
            c1.Items.Add("२३ गजश्री panchali 5 line")

        End If


    End Sub

    Private Sub combo2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo2.SelectedIndexChanged


        If tw2.Text.ToString.Equals("b") Or tw2.Text.ToString.Equals("B") Then
            p3.Visible = False
            w2 = totalweight - w1

        Else
            w2 = Integer.Parse(tw2.Text)

            If totalweight > (w1 + w2) Then

                p3.Visible = True
            ElseIf (totalweight < (w1 + w2)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
                p3.Visible = False


            End If

        End If

        c2.Items.Clear()

        If combo2.SelectedIndex = 0 Then
            txtgej2.Visible = False
            c2.Items.Add("१५ ओढणी")
            c2.Items.Add("१५|| ओढणी")
            c2.Items.Add("१६ ओढणी")
            c2.Items.Add("१६||ओढणी")
            c2.Items.Add("१७ ओढणी")
            c2.Items.Add("१७| ओढणी")
            c2.Items.Add("१७|| ओढणी")
            c2.Items.Add("१८ ओढणी")
            c2.Items.Add("१८|ओढणी")
            c2.Items.Add("१८||ओढणी")
            c2.Items.Add("१९ओढणी")
            c2.Items.Add("१९|ओढणी")
            c2.Items.Add("१९||ओढणी")
            c2.Items.Add("२०ओढणी")
            c2.Items.Add("२०|ओढणी")
            c2.Items.Add("२०||ओढणी")
            c2.Items.Add("२१ओढणी")
            c2.Items.Add("२१|ओढणी")
            c2.Items.Add("२१||ओढणी")
            c2.Items.Add("२२ ओढणी")
            c2.Items.Add("२२|ओढणी")
            c2.Items.Add("२२||ओढणी")
            c2.Items.Add("२३ ओढणी")
            c2.Items.Add("२४ ओढणी")
            c2.Items.Add("२५ ओढणी")
        End If
        If combo2.SelectedIndex = 1 Then
            txtgej2.Visible = True

            c2.Items.Add("कडचे फासे")
            c2.Items.Add("ळ कडी")
            c2.Items.Add("ळ सुत")
            c2.Items.Add("रु नाका कडी")
            c2.Items.Add("मधले फासे")

        End If
        If combo2.SelectedIndex = 2 Then
            txtgej2.Visible = True

            c2.Items.Add("कडचे फासे")
            c2.Items.Add("ळ कडी")
            c2.Items.Add("ळ सुत")
            c2.Items.Add("रु नाका कडी")
            c2.Items.Add("मधले फासे")

        End If
        If combo2.SelectedIndex = 3 Then
            txtgej2.Visible = False
            c2.Items.Add("साधा निमगोल ")
            c2.Items.Add("सेलम निमगोल")
            c2.Items.Add("चपटे निमगोल")
            c2.Items.Add("Jad निमगोल")

        End If

        If combo2.SelectedIndex = 4 Then
            txtgej2.Visible = False
            c2.Items.Add("३०० घागरी माटी")
            c2.Items.Add("३५० घागरी माटी")
        End If
        If combo2.SelectedIndex = 5 Then
            txtgej2.Visible = True
            c2.Items.Add("१६ ravakadi")
            c2.Items.Add("१७ ravakadi")
        End If
        If combo2.SelectedIndex = 6 Then
            txtgej2.Visible = True
            c2.Text = combo2.Text


        End If
        If combo2.SelectedIndex = 7 Then
            c2.Items.Add("२१ रुपाली panchali 3 line")
            c2.Items.Add("२१ रुपाली panchali 4 line")
            c2.Items.Add("२१ रुपाली panchali 5 line")
            c2.Items.Add("२२ रुपाली panchali 3 line")
            c2.Items.Add("२२ रुपाली panchali 4 line")
            c2.Items.Add("२२ रुपाली panchali 5 line")
            c2.Items.Add("२३ रुपाली panchali 3 line")
            c2.Items.Add("२३ रुपाली panchali 4 line")
            c2.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo2.SelectedIndex = 8 Then
            txtgej2.Visible = False
            c2.Text = combo2.Text

        End If

        If combo2.SelectedIndex = 9 Then
            c2.Items.Add("२१ गजश्री panchali 3 line")
            c2.Items.Add("२१ गजश्री panchali 4 line")
            c2.Items.Add("२१ गजश्री panchali 5 line")
            c2.Items.Add("२२ गजश्री panchali 3 line")
            c2.Items.Add("२२ गजश्री panchali 4 line")
            c2.Items.Add("२२ गजश्री panchali 5 line")
            c2.Items.Add("२३ गजश्री panchali 3 line")
            c2.Items.Add("२३ गजश्री panchali 4 line")
            c2.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo3.SelectedIndexChanged
        If tw3.Text.ToString.Equals("b") Or tw3.Text.ToString.Equals("B") Then
            p4.Visible = False
            w3 = totalweight - w1 - w2

        Else
            w3 = Integer.Parse(tw3.Text)

            If totalweight > (w1 + w2 + w3) Then

                p4.Visible = True
            ElseIf (totalweight < (w1 + w2 + w3)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
                p4.Visible = False


            End If

        End If

        c3.Items.Clear()

        If combo3.SelectedIndex = 0 Then
            txtgej3.Visible = False

            c3.Items.Add("१५ ओढणी")
            c3.Items.Add("१५|| ओढणी")
            c3.Items.Add("१६ ओढणी")
            c3.Items.Add("१६||ओढणी")
            c3.Items.Add("१७ ओढणी")
            c3.Items.Add("१७| ओढणी")
            c3.Items.Add("१७|| ओढणी")
            c3.Items.Add("१८ ओढणी")
            c3.Items.Add("१८|ओढणी")
            c3.Items.Add("१८||ओढणी")
            c3.Items.Add("१९ओढणी")
            c3.Items.Add("१९|ओढणी")
            c3.Items.Add("१९||ओढणी")
            c3.Items.Add("२०ओढणी")
            c3.Items.Add("२०|ओढणी")
            c3.Items.Add("२०||ओढणी")
            c3.Items.Add("२१ओढणी")
            c3.Items.Add("२१|ओढणी")
            c3.Items.Add("२१||ओढणी")
            c3.Items.Add("२२ ओढणी")
            c3.Items.Add("२२|ओढणी")
            c3.Items.Add("२२||ओढणी")
            c3.Items.Add("२३ ओढणी")
            c3.Items.Add("२४ ओढणी")
            c3.Items.Add("२५ ओढणी")
        End If
        If combo3.SelectedIndex = 1 Then
            txtgej3.Visible = True

            c3.Items.Add("कडचे फासे")
            c3.Items.Add("ळ कडी")
            c3.Items.Add("ळ सुत")
            c3.Items.Add("रु नाका कडी")
            c3.Items.Add("मधले फासे")

        End If
        If combo3.SelectedIndex = 2 Then
            txtgej3.Visible = True

            c3.Items.Add("कडचे फासे")
            c3.Items.Add("ळ कडी")
            c3.Items.Add("ळ सुत")
            c3.Items.Add("रु नाका कडी")
            c3.Items.Add("मधले फासे")

        End If
        If combo3.SelectedIndex = 3 Then
            txtgej3.Visible = False
            c3.Items.Add("साधा निमगोल ")
            c3.Items.Add("सेलम निमगोल")
            c3.Items.Add("चपटे निमगोल")
            c3.Items.Add("Jad निमगोल")

        End If

        If combo3.SelectedIndex = 4 Then
            txtgej3.Visible = False
            c3.Items.Add("३०० घागरी माटी")
            c3.Items.Add("३५० घागरी माटी")
        End If
        If combo3.SelectedIndex = 5 Then
            txtgej3.Visible = True
            c3.Items.Add("१६ ravakadi")
            c3.Items.Add("१७ ravakadi")
        End If
        If combo3.SelectedIndex = 6 Then
            txtgej3.Visible = True
            c3.Text = combo3.Text


        End If
        If combo3.SelectedIndex = 7 Then
            c3.Items.Add("२१ रुपाली panchali 3 line")
            c3.Items.Add("२१ रुपाली panchali 4 line")
            c3.Items.Add("२१ रुपाली panchali 5 line")
            c3.Items.Add("२२ रुपाली panchali 3 line")
            c3.Items.Add("२२ रुपाली panchali 4 line")
            c3.Items.Add("२२ रुपाली panchali 5 line")
            c3.Items.Add("२३ रुपाली panchali 3 line")
            c3.Items.Add("२३ रुपाली panchali 4 line")
            c3.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo3.SelectedIndex = 8 Then
            txtgej3.Visible = False
            c3.Text = combo3.Text

        End If

        If combo3.SelectedIndex = 9 Then
            c3.Items.Add("२१ गजश्री panchali 3 line")
            c3.Items.Add("२१ गजश्री panchali 4 line")
            c3.Items.Add("२१ गजश्री panchali 5 line")
            c3.Items.Add("२२ गजश्री panchali 3 line")
            c3.Items.Add("२२ गजश्री panchali 4 line")
            c3.Items.Add("२२ गजश्री panchali 5 line")
            c3.Items.Add("२३ गजश्री panchali 3 line")
            c3.Items.Add("२३ गजश्री panchali 4 line")
            c3.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo6.SelectedIndexChanged
        If tw6.Text.ToString.Equals("b") Or tw6.Text.ToString.Equals("B") Then
            p7.Visible = False
            w6 = totalweight - w1 - w2 - w3 - w4 - w5


        Else
            w6 = Integer.Parse(tw6.Text)

            If totalweight > (w1 + w2 + w3 + w4 + w5 + w6) Then

                p7.Visible = True
            ElseIf (totalweight < (w1 + w2 + w3 + w4 + w5 + w6)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
                p7.Visible = False


            End If

        End If

        c6.Items.Clear()

        If combo6.SelectedIndex = 0 Then
            txtgej6.Visible = False

            c6.Items.Add("१५ ओढणी")
            c6.Items.Add("१५|| ओढणी")
            c6.Items.Add("१६ ओढणी")
            c6.Items.Add("१६||ओढणी")
            c6.Items.Add("१७ ओढणी")
            c6.Items.Add("१७| ओढणी")
            c6.Items.Add("१७|| ओढणी")
            c6.Items.Add("१८ ओढणी")
            c6.Items.Add("१८|ओढणी")
            c6.Items.Add("१८||ओढणी")
            c6.Items.Add("१९ओढणी")
            c6.Items.Add("१९|ओढणी")
            c6.Items.Add("१९||ओढणी")
            c6.Items.Add("२०ओढणी")
            c6.Items.Add("२०|ओढणी")
            c6.Items.Add("२०||ओढणी")
            c6.Items.Add("२१ओढणी")
            c6.Items.Add("२१|ओढणी")
            c6.Items.Add("२१||ओढणी")
            c6.Items.Add("२२ ओढणी")
            c6.Items.Add("२२|ओढणी")
            c6.Items.Add("२२||ओढणी")
            c6.Items.Add("२३ ओढणी")
            c6.Items.Add("२४ ओढणी")
            c6.Items.Add("२५ ओढणी")
        End If
        If combo6.SelectedIndex = 1 Then
            txtgej6.Visible = True

            c6.Items.Add("कडचे फासे")
            c6.Items.Add("ळ कडी")
            c6.Items.Add("ळ सुत")
            c6.Items.Add("रु नाका कडी")
            c6.Items.Add("मधले फासे")

        End If
        If combo6.SelectedIndex = 2 Then
            txtgej6.Visible = True

            c6.Items.Add("कडचे फासे")
            c6.Items.Add("ळ कडी")
            c6.Items.Add("ळ सुत")
            c6.Items.Add("रु नाका कडी")
            c6.Items.Add("मधले फासे")

        End If
        If combo6.SelectedIndex = 3 Then
            txtgej6.Visible = False
            c6.Items.Add("साधा निमगोल ")
            c6.Items.Add("सेलम निमगोल")
            c6.Items.Add("चपटे निमगोल")
            c6.Items.Add("Jad निमगोल")

        End If

        If combo6.SelectedIndex = 4 Then
            txtgej6.Visible = False
            c6.Items.Add("३०० घागरी माटी")
            c6.Items.Add("३५० घागरी माटी")
        End If
        If combo6.SelectedIndex = 5 Then
            txtgej6.Visible = True
            c6.Items.Add("१६ ravakadi")
            c6.Items.Add("१७ ravakadi")
        End If
        If combo6.SelectedIndex = 6 Then
            txtgej6.Visible = True
            c6.Text = combo6.Text


        End If
        If combo6.SelectedIndex = 7 Then
            c6.Items.Add("२१ रुपाली panchali 3 line")
            c6.Items.Add("२१ रुपाली panchali 4 line")
            c6.Items.Add("२१ रुपाली panchali 5 line")
            c6.Items.Add("२२ रुपाली panchali 3 line")
            c6.Items.Add("२२ रुपाली panchali 4 line")
            c6.Items.Add("२२ रुपाली panchali 5 line")
            c6.Items.Add("२३ रुपाली panchali 3 line")
            c6.Items.Add("२३ रुपाली panchali 4 line")
            c6.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo6.SelectedIndex = 8 Then
            txtgej6.Visible = False
            c6.Text = combo6.Text

        End If

        If combo6.SelectedIndex = 9 Then
            c6.Items.Add("२१ गजश्री panchali 3 line")
            c6.Items.Add("२१ गजश्री panchali 4 line")
            c6.Items.Add("२१ गजश्री panchali 5 line")
            c6.Items.Add("२२ गजश्री panchali 3 line")
            c6.Items.Add("२२ गजश्री panchali 4 line")
            c6.Items.Add("२२ गजश्री panchali 5 line")
            c6.Items.Add("२३ गजश्री panchali 3 line")
            c6.Items.Add("२३ गजश्री panchali 4 line")
            c6.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo5.SelectedIndexChanged
        If tw5.Text.ToString.Equals("b") Or tw5.Text.ToString.Equals("B") Then
            p6.Visible = False
            w5 = totalweight - w1 - w2 - w3 - w4

        Else
            w5 = Integer.Parse(tw5.Text)

            If totalweight > (w1 + w2 + w3 + w4 + w5) Then

                p6.Visible = True
            ElseIf (totalweight < (w1 + w2 + w3 + w4 + w5)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
                p6.Visible = False


            End If

        End If

        c5.Items.Clear()

        If combo5.SelectedIndex = 0 Then
            txtgej5.Visible = False

            c5.Items.Add("१५ ओढणी")
            c5.Items.Add("१५|| ओढणी")
            c5.Items.Add("१६ ओढणी")
            c5.Items.Add("१६||ओढणी")
            c5.Items.Add("१७ ओढणी")
            c5.Items.Add("१७| ओढणी")
            c5.Items.Add("१७|| ओढणी")
            c5.Items.Add("१८ ओढणी")
            c5.Items.Add("१८|ओढणी")
            c5.Items.Add("१८||ओढणी")
            c5.Items.Add("१९ओढणी")
            c5.Items.Add("१९|ओढणी")
            c5.Items.Add("१९||ओढणी")
            c5.Items.Add("२०ओढणी")
            c5.Items.Add("२०|ओढणी")
            c5.Items.Add("२०||ओढणी")
            c5.Items.Add("२१ओढणी")
            c5.Items.Add("२१|ओढणी")
            c5.Items.Add("२१||ओढणी")
            c5.Items.Add("२२ ओढणी")
            c5.Items.Add("२२|ओढणी")
            c5.Items.Add("२२||ओढणी")
            c5.Items.Add("२३ ओढणी")
            c5.Items.Add("२४ ओढणी")
            c5.Items.Add("२५ ओढणी")
        End If
        If combo5.SelectedIndex = 1 Then
            txtgej5.Visible = True

            c5.Items.Add("कडचे फासे")
            c5.Items.Add("ळ कडी")
            c5.Items.Add("ळ सुत")
            c5.Items.Add("रु नाका कडी")
            c5.Items.Add("मधले फासे")

        End If
        If combo5.SelectedIndex = 2 Then
            txtgej5.Visible = True

            c5.Items.Add("कडचे फासे")
            c5.Items.Add("ळ कडी")
            c5.Items.Add("ळ सुत")
            c5.Items.Add("रु नाका कडी")
            c5.Items.Add("मधले फासे")

        End If
        If combo5.SelectedIndex = 3 Then
            txtgej5.Visible = False
            c5.Items.Add("साधा निमगोल ")
            c5.Items.Add("सेलम निमगोल")
            c5.Items.Add("चपटे निमगोल")
            c5.Items.Add("Jad निमगोल")

        End If

        If combo5.SelectedIndex = 4 Then
            txtgej5.Visible = False
            c5.Items.Add("३०० घागरी माटी")
            c5.Items.Add("३५० घागरी माटी")
        End If
        If combo5.SelectedIndex = 5 Then
            txtgej5.Visible = True
            c5.Items.Add("१६ ravakadi")
            c5.Items.Add("१७ ravakadi")
        End If
        If combo5.SelectedIndex = 6 Then
            txtgej5.Visible = True
            c5.Text = combo5.Text


        End If
        If combo5.SelectedIndex = 7 Then
            c5.Items.Add("२१ रुपाली panchali 3 line")
            c5.Items.Add("२१ रुपाली panchali 4 line")
            c5.Items.Add("२१ रुपाली panchali 5 line")
            c5.Items.Add("२२ रुपाली panchali 3 line")
            c5.Items.Add("२२ रुपाली panchali 4 line")
            c5.Items.Add("२२ रुपाली panchali 5 line")
            c5.Items.Add("२३ रुपाली panchali 3 line")
            c5.Items.Add("२३ रुपाली panchali 4 line")
            c5.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo5.SelectedIndex = 8 Then
            txtgej5.Visible = False
            c5.Text = combo5.Text

        End If

        If combo5.SelectedIndex = 9 Then
            c5.Items.Add("२१ गजश्री panchali 3 line")
            c5.Items.Add("२१ गजश्री panchali 4 line")
            c5.Items.Add("२१ गजश्री panchali 5 line")
            c5.Items.Add("२२ गजश्री panchali 3 line")
            c5.Items.Add("२२ गजश्री panchali 4 line")
            c5.Items.Add("२२ गजश्री panchali 5 line")
            c5.Items.Add("२३ गजश्री panchali 3 line")
            c5.Items.Add("२३ गजश्री panchali 4 line")
            c5.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo4.SelectedIndexChanged
        If tw4.Text.ToString.Equals("b") Or tw4.Text.ToString.Equals("B") Then
            p5.Visible = False
            w4 = totalweight - w1 - w2 - w3

        Else
            w4 = Integer.Parse(tw4.Text)

            If totalweight > (w1 + w2 + w3 + w4) Then

                p5.Visible = True
            ElseIf (totalweight < (w1 + w2 + w3 + w4)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
                p5.Visible = False


            End If

        End If

        c4.Items.Clear()

        If combo4.SelectedIndex = 0 Then
            txtgej4.Visible = False

            c4.Items.Add("१५ ओढणी")
            c4.Items.Add("१५|| ओढणी")
            c4.Items.Add("१६ ओढणी")
            c4.Items.Add("१६||ओढणी")
            c4.Items.Add("१७ ओढणी")
            c4.Items.Add("१७| ओढणी")
            c4.Items.Add("१७|| ओढणी")
            c4.Items.Add("१८ ओढणी")
            c4.Items.Add("१८|ओढणी")
            c4.Items.Add("१८||ओढणी")
            c4.Items.Add("१९ओढणी")
            c4.Items.Add("१९|ओढणी")
            c4.Items.Add("१९||ओढणी")
            c4.Items.Add("२०ओढणी")
            c4.Items.Add("२०|ओढणी")
            c4.Items.Add("२०||ओढणी")
            c4.Items.Add("२१ओढणी")
            c4.Items.Add("२१|ओढणी")
            c4.Items.Add("२१||ओढणी")
            c4.Items.Add("२२ ओढणी")
            c4.Items.Add("२२|ओढणी")
            c4.Items.Add("२२||ओढणी")
            c4.Items.Add("२३ ओढणी")
            c4.Items.Add("२४ ओढणी")
            c4.Items.Add("२५ ओढणी")
        End If
        If combo4.SelectedIndex = 1 Then
            txtgej4.Visible = True

            c4.Items.Add("कडचे फासे")
            c4.Items.Add("ळ कडी")
            c4.Items.Add("ळ सुत")
            c4.Items.Add("रु नाका कडी")
            c4.Items.Add("मधले फासे")

        End If
        If combo4.SelectedIndex = 2 Then
            txtgej4.Visible = True

            c4.Items.Add("कडचे फासे")
            c4.Items.Add("ळ कडी")
            c4.Items.Add("ळ सुत")
            c4.Items.Add("रु नाका कडी")
            c4.Items.Add("मधले फासे")

        End If
        If combo4.SelectedIndex = 3 Then
            txtgej4.Visible = False
            c4.Items.Add("साधा निमगोल ")
            c4.Items.Add("सेलम निमगोल")
            c4.Items.Add("चपटे निमगोल")
            c4.Items.Add("Jad निमगोल")

        End If

        If combo4.SelectedIndex = 4 Then
            txtgej4.Visible = False
            c4.Items.Add("३०० घागरी माटी")
            c4.Items.Add("३५० घागरी माटी")
        End If
        If combo4.SelectedIndex = 5 Then
            txtgej4.Visible = True
            c4.Items.Add("१६ ravakadi")
            c4.Items.Add("१७ ravakadi")
        End If
        If combo4.SelectedIndex = 6 Then
            txtgej4.Visible = True
            c4.Text = combo4.Text


        End If
        If combo4.SelectedIndex = 7 Then
            c4.Items.Add("२१ रुपाली panchali 3 line")
            c4.Items.Add("२१ रुपाली panchali 4 line")
            c4.Items.Add("२१ रुपाली panchali 5 line")
            c4.Items.Add("२२ रुपाली panchali 3 line")
            c4.Items.Add("२२ रुपाली panchali 4 line")
            c4.Items.Add("२२ रुपाली panchali 5 line")
            c4.Items.Add("२३ रुपाली panchali 3 line")
            c4.Items.Add("२३ रुपाली panchali 4 line")
            c4.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo4.SelectedIndex = 8 Then
            txtgej4.Visible = False
            c4.Text = combo4.Text

        End If

        If combo4.SelectedIndex = 9 Then
            c4.Items.Add("२१ गजश्री panchali 3 line")
            c4.Items.Add("२१ गजश्री panchali 4 line")
            c4.Items.Add("२१ गजश्री panchali 5 line")
            c4.Items.Add("२२ गजश्री panchali 3 line")
            c4.Items.Add("२२ गजश्री panchali 4 line")
            c4.Items.Add("२२ गजश्री panchali 5 line")
            c4.Items.Add("२३ गजश्री panchali 3 line")
            c4.Items.Add("२३ गजश्री panchali 4 line")
            c4.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo7.SelectedIndexChanged
        If tw7.Text.ToString.Equals("b") Or tw7.Text.ToString.Equals("B") Then
            p8.Visible = False
            w7 = totalweight - w1 - w2 - w3 - w4 - w5 - w6

        Else
            w7 = Integer.Parse(tw2.Text)

            If totalweight > (w1 + w2 + w3 + w4 + w5 + w6 + w7) Then

                p8.Visible = True
            ElseIf (totalweight < (w1 + w2 + w3 + w4 + w5 + w6 + w7)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
                p8.Visible = False


            End If

        End If

        c7.Items.Clear()

        If combo7.SelectedIndex = 0 Then
            txtgej7.Visible = False

            c7.Items.Add("१५ ओढणी")
            c7.Items.Add("१५|| ओढणी")
            c7.Items.Add("१६ ओढणी")
            c7.Items.Add("१६||ओढणी")
            c7.Items.Add("१७ ओढणी")
            c7.Items.Add("१७| ओढणी")
            c7.Items.Add("१७|| ओढणी")
            c7.Items.Add("१८ ओढणी")
            c7.Items.Add("१८|ओढणी")
            c7.Items.Add("१८||ओढणी")
            c7.Items.Add("१९ओढणी")
            c7.Items.Add("१९|ओढणी")
            c7.Items.Add("१९||ओढणी")
            c7.Items.Add("२०ओढणी")
            c7.Items.Add("२०|ओढणी")
            c7.Items.Add("२०||ओढणी")
            c7.Items.Add("२१ओढणी")
            c7.Items.Add("२१|ओढणी")
            c7.Items.Add("२१||ओढणी")
            c7.Items.Add("२२ ओढणी")
            c7.Items.Add("२२|ओढणी")
            c7.Items.Add("२२||ओढणी")
            c7.Items.Add("२३ ओढणी")
            c7.Items.Add("२४ ओढणी")
            c7.Items.Add("२५ ओढणी")
        End If
        If combo7.SelectedIndex = 1 Then
            txtgej7.Visible = True

            c7.Items.Add("कडचे फासे")
            c7.Items.Add("ळ कडी")
            c7.Items.Add("ळ सुत")
            c7.Items.Add("रु नाका कडी")
            c7.Items.Add("मधले फासे")

        End If
        If combo7.SelectedIndex = 2 Then
            txtgej7.Visible = True

            c7.Items.Add("कडचे फासे")
            c7.Items.Add("ळ कडी")
            c7.Items.Add("ळ सुत")
            c7.Items.Add("रु नाका कडी")
            c7.Items.Add("मधले फासे")

        End If
        If combo7.SelectedIndex = 3 Then
            txtgej7.Visible = False
            c7.Items.Add("साधा निमगोल ")
            c7.Items.Add("सेलम निमगोल")
            c7.Items.Add("चपटे निमगोल")
            c7.Items.Add("Jad निमगोल")

        End If

        If combo7.SelectedIndex = 4 Then
            txtgej7.Visible = False
            c7.Items.Add("३०० घागरी माटी")
            c7.Items.Add("३५० घागरी माटी")
        End If
        If combo7.SelectedIndex = 5 Then
            txtgej7.Visible = True
            c7.Items.Add("१६ ravakadi")
            c7.Items.Add("१७ ravakadi")
        End If
        If combo7.SelectedIndex = 6 Then
            txtgej7.Visible = True
            c7.Text = combo7.Text


        End If
        If combo7.SelectedIndex = 7 Then
            c7.Items.Add("२१ रुपाली panchali 3 line")
            c7.Items.Add("२१ रुपाली panchali 4 line")
            c7.Items.Add("२१ रुपाली panchali 5 line")
            c7.Items.Add("२२ रुपाली panchali 3 line")
            c7.Items.Add("२२ रुपाली panchali 4 line")
            c7.Items.Add("२२ रुपाली panchali 5 line")
            c7.Items.Add("२३ रुपाली panchali 3 line")
            c7.Items.Add("२३ रुपाली panchali 4 line")
            c7.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo7.SelectedIndex = 8 Then
            txtgej7.Visible = False
            c7.Text = combo7.Text

        End If

        If combo7.SelectedIndex = 9 Then
            c7.Items.Add("२१ गजश्री panchali 3 line")
            c7.Items.Add("२१ गजश्री panchali 4 line")
            c7.Items.Add("२१ गजश्री panchali 5 line")
            c7.Items.Add("२२ गजश्री panchali 3 line")
            c7.Items.Add("२२ गजश्री panchali 4 line")
            c7.Items.Add("२२ गजश्री panchali 5 line")
            c7.Items.Add("२३ गजश्री panchali 3 line")
            c7.Items.Add("२३ गजश्री panchali 4 line")
            c7.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo8.SelectedIndexChanged
        If tw8.Text.ToString.Equals("b") Or tw8.Text.ToString.Equals("B") Then
            p9.Visible = False
            w8 = totalweight - w1 - w2 - w3 - w4 - w5 - w6 - w7

        Else
            w8 = Integer.Parse(tw8.Text)

            If totalweight > (w1 + w2 + w3 + w4 + w5 + w5 + w6 + w7 + w8) Then

                p9.Visible = True
            ElseIf (totalweight < (w1 + w2 + w3 + w4 + w5 + w5 + w6 + w7 + w8)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या.जास्त आहे")
                p9.Visible = False


            End If

        End If

        c8.Items.Clear()

        If combo8.SelectedIndex = 0 Then
            txtgej8.Visible = False

            c8.Items.Add("१५ ओढणी")
            c8.Items.Add("१५|| ओढणी")
            c8.Items.Add("१६ ओढणी")
            c8.Items.Add("१६||ओढणी")
            c8.Items.Add("१७ ओढणी")
            c8.Items.Add("१७| ओढणी")
            c8.Items.Add("१७|| ओढणी")
            c8.Items.Add("१८ ओढणी")
            c8.Items.Add("१८|ओढणी")
            c8.Items.Add("१८||ओढणी")
            c8.Items.Add("१९ओढणी")
            c8.Items.Add("१९|ओढणी")
            c8.Items.Add("१९||ओढणी")
            c8.Items.Add("२०ओढणी")
            c8.Items.Add("२०|ओढणी")
            c8.Items.Add("२०||ओढणी")
            c8.Items.Add("२१ओढणी")
            c8.Items.Add("२१|ओढणी")
            c8.Items.Add("२१||ओढणी")
            c8.Items.Add("२२ ओढणी")
            c8.Items.Add("२२|ओढणी")
            c8.Items.Add("२२||ओढणी")
            c8.Items.Add("२३ ओढणी")
            c8.Items.Add("२४ ओढणी")
            c8.Items.Add("२५ ओढणी")
        End If
        If combo8.SelectedIndex = 1 Then
            txtgej8.Visible = True

            c8.Items.Add("कडचे फासे")
            c8.Items.Add("ळ कडी")
            c8.Items.Add("ळ सुत")
            c8.Items.Add("रु नाका कडी")
            c8.Items.Add("मधले फासे")

        End If
        If combo8.SelectedIndex = 2 Then
            txtgej8.Visible = True

            c8.Items.Add("कडचे फासे")
            c8.Items.Add("ळ कडी")
            c8.Items.Add("ळ सुत")
            c8.Items.Add("रु नाका कडी")
            c8.Items.Add("मधले फासे")

        End If
        If combo8.SelectedIndex = 3 Then
            txtgej8.Visible = False
            c8.Items.Add("साधा निमगोल ")
            c8.Items.Add("सेलम निमगोल")
            c8.Items.Add("चपटे निमगोल")
            c8.Items.Add("Jad निमगोल")

        End If

        If combo8.SelectedIndex = 4 Then
            txtgej8.Visible = False
            c8.Items.Add("३०० घागरी माटी")
            c8.Items.Add("३५० घागरी माटी")
        End If
        If combo8.SelectedIndex = 5 Then
            txtgej8.Visible = True
            c8.Items.Add("१६ ravakadi")
            c8.Items.Add("१७ ravakadi")
        End If
        If combo8.SelectedIndex = 6 Then
            txtgej8.Visible = True
            c8.Text = combo8.Text


        End If
        If combo8.SelectedIndex = 7 Then
            c8.Items.Add("२१ रुपाली panchali 3 line")
            c8.Items.Add("२१ रुपाली panchali 4 line")
            c8.Items.Add("२१ रुपाली panchali 5 line")
            c8.Items.Add("२२ रुपाली panchali 3 line")
            c8.Items.Add("२२ रुपाली panchali 4 line")
            c8.Items.Add("२२ रुपाली panchali 5 line")
            c8.Items.Add("२३ रुपाली panchali 3 line")
            c8.Items.Add("२३ रुपाली panchali 4 line")
            c8.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo8.SelectedIndex = 8 Then
            txtgej8.Visible = False
            c8.Text = combo8.Text

        End If

        If combo8.SelectedIndex = 9 Then
            c8.Items.Add("२१ गजश्री panchali 3 line")
            c8.Items.Add("२१ गजश्री panchali 4 line")
            c8.Items.Add("२१ गजश्री panchali 5 line")
            c8.Items.Add("२२ गजश्री panchali 3 line")
            c8.Items.Add("२२ गजश्री panchali 4 line")
            c8.Items.Add("२२ गजश्री panchali 5 line")
            c8.Items.Add("२३ गजश्री panchali 3 line")
            c8.Items.Add("२३ गजश्री panchali 4 line")
            c8.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo9.SelectedIndexChanged
        If tw9.Text.ToString.Equals("b") Or tw9.Text.ToString.Equals("B") Then
            p10.Visible = False
            w9 = totalweight - w1 - w2 - w3 - w4 - w5 - w6 - w7 - w8

        Else
            w9 = Integer.Parse(tw9.Text)

            If totalweight > (w1 + w2 + w3 + w4 + w5 + w5 + w6 + w7 + w8 + w9) Then

                p10.Visible = True
            ElseIf (totalweight < (w1 + w2 + w3 + w4 + w5 + w5 + w6 + w7 + w8 + w9)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
                p10.Visible = False


            End If

        End If

        c9.Items.Clear()

        If combo9.SelectedIndex = 0 Then
            txtgej9.Visible = False

            c9.Items.Add("१५ ओढणी")
            c9.Items.Add("१५|| ओढणी")
            c9.Items.Add("१६ ओढणी")
            c9.Items.Add("१६||ओढणी")
            c9.Items.Add("१७ ओढणी")
            c9.Items.Add("१७| ओढणी")
            c9.Items.Add("१७|| ओढणी")
            c9.Items.Add("१८ ओढणी")
            c9.Items.Add("१८|ओढणी")
            c9.Items.Add("१८||ओढणी")
            c9.Items.Add("१९ओढणी")
            c9.Items.Add("१९|ओढणी")
            c9.Items.Add("१९||ओढणी")
            c9.Items.Add("२०ओढणी")
            c9.Items.Add("२०|ओढणी")
            c9.Items.Add("२०||ओढणी")
            c9.Items.Add("२१ओढणी")
            c9.Items.Add("२१|ओढणी")
            c9.Items.Add("२१||ओढणी")
            c9.Items.Add("२२ ओढणी")
            c9.Items.Add("२२|ओढणी")
            c9.Items.Add("२२||ओढणी")
            c9.Items.Add("२३ ओढणी")
            c9.Items.Add("२४ ओढणी")
            c9.Items.Add("२५ ओढणी")
        End If
        If combo9.SelectedIndex = 1 Then
            txtgej9.Visible = True

            c9.Items.Add("कडचे फासे")
            c9.Items.Add("ळ कडी")
            c9.Items.Add("ळ सुत")
            c9.Items.Add("रु नाका कडी")
            c9.Items.Add("मधले फासे")

        End If
        If combo9.SelectedIndex = 2 Then
            txtgej9.Visible = True

            c9.Items.Add("कडचे फासे")
            c9.Items.Add("ळ कडी")
            c9.Items.Add("ळ सुत")
            c9.Items.Add("रु नाका कडी")
            c9.Items.Add("मधले फासे")

        End If
        If combo9.SelectedIndex = 3 Then
            txtgej9.Visible = False
            c9.Items.Add("साधा निमगोल ")
            c9.Items.Add("सेलम निमगोल")
            c9.Items.Add("चपटे निमगोल")
            c9.Items.Add("Jad निमगोल")

        End If

        If combo9.SelectedIndex = 4 Then
            txtgej9.Visible = False
            c9.Items.Add("३०० घागरी माटी")
            c9.Items.Add("३५० घागरी माटी")
        End If
        If combo9.SelectedIndex = 5 Then
            txtgej9.Visible = True
            c9.Items.Add("१६ ravakadi")
            c9.Items.Add("१७ ravakadi")
        End If
        If combo9.SelectedIndex = 6 Then
            txtgej9.Visible = True
            c9.Text = combo9.Text


        End If
        If combo9.SelectedIndex = 7 Then
            c9.Items.Add("२१ रुपाली panchali 3 line")
            c9.Items.Add("२१ रुपाली panchali 4 line")
            c9.Items.Add("२१ रुपाली panchali 5 line")
            c9.Items.Add("२२ रुपाली panchali 3 line")
            c9.Items.Add("२२ रुपाली panchali 4 line")
            c9.Items.Add("२२ रुपाली panchali 5 line")
            c9.Items.Add("२३ रुपाली panchali 3 line")
            c9.Items.Add("२३ रुपाली panchali 4 line")
            c9.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo9.SelectedIndex = 8 Then
            txtgej9.Visible = False
            c9.Text = combo9.Text

        End If

        If combo9.SelectedIndex = 9 Then
            c9.Items.Add("२१ गजश्री panchali 3 line")
            c9.Items.Add("२१ गजश्री panchali 4 line")
            c9.Items.Add("२१ गजश्री panchali 5 line")
            c9.Items.Add("२२ गजश्री panchali 3 line")
            c9.Items.Add("२२ गजश्री panchali 4 line")
            c9.Items.Add("२२ गजश्री panchali 5 line")
            c9.Items.Add("२३ गजश्री panchali 3 line")
            c9.Items.Add("२३ गजश्री panchali 4 line")
            c9.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo12.SelectedIndexChanged
        If tw12.Text.ToString.Equals("b") Or tw12.Text.ToString.Equals("B") Then
            p13.Visible = False
            w12 = totalweight - w1 - w2 - w3 - w4 - w5 - w6 - w7 - w8 - w9 - w10 - w11

        Else
            w2 = Integer.Parse(tw2.Text)

            If totalweight > (w1 + w2 + w3 + w4 + w5 + w5 + w6 + w7 + w8 + w9 + w10 + w11 + w12) Then

                p13.Visible = True
            ElseIf (totalweight < (w1 + w2 + w3 + w4 + w5 + w5 + w6 + w7 + w8 + w9 + w10 + w11 + w12)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
                p13.Visible = False


            End If

        End If

        c12.Items.Clear()

        If combo12.SelectedIndex = 0 Then
            txtgej12.Visible = False

            c12.Items.Add("१५ ओढणी")
            c12.Items.Add("१५|| ओढणी")
            c12.Items.Add("१६ ओढणी")
            c12.Items.Add("१६||ओढणी")
            c12.Items.Add("१७ ओढणी")
            c12.Items.Add("१७| ओढणी")
            c12.Items.Add("१७|| ओढणी")
            c12.Items.Add("१८ ओढणी")
            c12.Items.Add("१८|ओढणी")
            c12.Items.Add("१८||ओढणी")
            c12.Items.Add("१९ओढणी")
            c12.Items.Add("१९|ओढणी")
            c12.Items.Add("१९||ओढणी")
            c12.Items.Add("२०ओढणी")
            c12.Items.Add("२०|ओढणी")
            c12.Items.Add("२०||ओढणी")
            c12.Items.Add("२१ओढणी")
            c12.Items.Add("२१|ओढणी")
            c12.Items.Add("२१||ओढणी")
            c12.Items.Add("२२ ओढणी")
            c12.Items.Add("२२|ओढणी")
            c12.Items.Add("२२||ओढणी")
            c12.Items.Add("२३ ओढणी")
            c12.Items.Add("२४ ओढणी")
            c12.Items.Add("२५ ओढणी")
        End If
        If combo12.SelectedIndex = 1 Then
            txtgej12.Visible = True

            c12.Items.Add("कडचे फासे")
            c12.Items.Add("ळ कडी")
            c12.Items.Add("ळ सुत")
            c12.Items.Add("रु नाका कडी")
            c12.Items.Add("मधले फासे")

        End If
        If combo12.SelectedIndex = 2 Then
            txtgej12.Visible = True

            c12.Items.Add("कडचे फासे")
            c12.Items.Add("ळ कडी")
            c12.Items.Add("ळ सुत")
            c12.Items.Add("रु नाका कडी")
            c12.Items.Add("मधले फासे")

        End If
        If combo12.SelectedIndex = 3 Then
            txtgej12.Visible = False
            c12.Items.Add("साधा निमगोल ")
            c12.Items.Add("सेलम निमगोल")
            c12.Items.Add("चपटे निमगोल")
            c12.Items.Add("Jad निमगोल")

        End If

        If combo12.SelectedIndex = 4 Then
            txtgej12.Visible = False
            c12.Items.Add("३०० घागरी माटी")
            c12.Items.Add("३५० घागरी माटी")
        End If
        If combo12.SelectedIndex = 5 Then
            txtgej12.Visible = True
            c12.Items.Add("१६ ravakadi")
            c12.Items.Add("१७ ravakadi")
        End If
        If combo12.SelectedIndex = 6 Then
            txtgej12.Visible = True
            c12.Text = combo12.Text


        End If
        If combo12.SelectedIndex = 7 Then
            c12.Items.Add("२१ रुपाली panchali 3 line")
            c12.Items.Add("२१ रुपाली panchali 4 line")
            c12.Items.Add("२१ रुपाली panchali 5 line")
            c12.Items.Add("२२ रुपाली panchali 3 line")
            c12.Items.Add("२२ रुपाली panchali 4 line")
            c12.Items.Add("२२ रुपाली panchali 5 line")
            c12.Items.Add("२३ रुपाली panchali 3 line")
            c12.Items.Add("२३ रुपाली panchali 4 line")
            c12.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo12.SelectedIndex = 8 Then
            txtgej12.Visible = False
            c12.Text = combo12.Text

        End If

        If combo12.SelectedIndex = 9 Then
            c12.Items.Add("२१ गजश्री panchali 3 line")
            c12.Items.Add("२१ गजश्री panchali 4 line")
            c12.Items.Add("२१ गजश्री panchali 5 line")
            c12.Items.Add("२२ गजश्री panchali 3 line")
            c12.Items.Add("२२ गजश्री panchali 4 line")
            c12.Items.Add("२२ गजश्री panchali 5 line")
            c12.Items.Add("२३ गजश्री panchali 3 line")
            c12.Items.Add("२३ गजश्री panchali 4 line")
            c12.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo11.SelectedIndexChanged
        If tw11.Text.ToString.Equals("b") Or tw11.Text.ToString.Equals("B") Then
            p12.Visible = False
            w11 = totalweight - w1 - w2 - w3 - w4 - w5 - w6 - w7 - w8 - w9 - 10

        Else
            w11 = Integer.Parse(tw11.Text)

            If totalweight > (w1 + w2 + w3 + w4 + w5 + w5 + w6 + w7 + w8 + w9 + w10 + w11) Then

                p12.Visible = True
            ElseIf (totalweight < (w1 + w2)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
                p12.Visible = False


            End If

        End If

        c11.Items.Clear()

        If combo11.SelectedIndex = 0 Then
            txtgej11.Visible = False

            c11.Items.Add("१५ ओढणी")
            c11.Items.Add("१५|| ओढणी")
            c11.Items.Add("१६ ओढणी")
            c11.Items.Add("१६||ओढणी")
            c11.Items.Add("१७ ओढणी")
            c11.Items.Add("१७| ओढणी")
            c11.Items.Add("१७|| ओढणी")
            c11.Items.Add("१८ ओढणी")
            c11.Items.Add("१८|ओढणी")
            c11.Items.Add("१८||ओढणी")
            c11.Items.Add("१९ओढणी")
            c11.Items.Add("१९|ओढणी")
            c11.Items.Add("१९||ओढणी")
            c11.Items.Add("२०ओढणी")
            c11.Items.Add("२०|ओढणी")
            c11.Items.Add("२०||ओढणी")
            c11.Items.Add("२१ओढणी")
            c11.Items.Add("२१|ओढणी")
            c11.Items.Add("२१||ओढणी")
            c11.Items.Add("२२ ओढणी")
            c11.Items.Add("२२|ओढणी")
            c11.Items.Add("२२||ओढणी")
            c11.Items.Add("२३ ओढणी")
            c11.Items.Add("२४ ओढणी")
            c11.Items.Add("२५ ओढणी")
        End If
        If combo11.SelectedIndex = 1 Then
            txtgej11.Visible = True

            c11.Items.Add("कडचे फासे")
            c11.Items.Add("ळ कडी")
            c11.Items.Add("ळ सुत")
            c11.Items.Add("रु नाका कडी")
            c11.Items.Add("मधले फासे")

        End If
        If combo11.SelectedIndex = 2 Then
            txtgej11.Visible = True

            c11.Items.Add("कडचे फासे")
            c11.Items.Add("ळ कडी")
            c11.Items.Add("ळ सुत")
            c11.Items.Add("रु नाका कडी")
            c11.Items.Add("मधले फासे")

        End If
        If combo11.SelectedIndex = 3 Then
            txtgej11.Visible = False
            c11.Items.Add("साधा निमगोल ")
            c11.Items.Add("सेलम निमगोल")
            c11.Items.Add("चपटे निमगोल")
            c11.Items.Add("Jad निमगोल")

        End If

        If combo11.SelectedIndex = 4 Then
            txtgej11.Visible = False
            c11.Items.Add("३०० घागरी माटी")
            c11.Items.Add("३५० घागरी माटी")
        End If
        If combo11.SelectedIndex = 5 Then
            txtgej11.Visible = True
            c11.Items.Add("१६ ravakadi")
            c11.Items.Add("१७ ravakadi")
        End If
        If combo11.SelectedIndex = 6 Then
            txtgej11.Visible = True
            c11.Text = combo11.Text


        End If
        If combo11.SelectedIndex = 7 Then
            c11.Items.Add("२१ रुपाली panchali 3 line")
            c11.Items.Add("२१ रुपाली panchali 4 line")
            c11.Items.Add("२१ रुपाली panchali 5 line")
            c11.Items.Add("२२ रुपाली panchali 3 line")
            c11.Items.Add("२२ रुपाली panchali 4 line")
            c11.Items.Add("२२ रुपाली panchali 5 line")
            c11.Items.Add("२३ रुपाली panchali 3 line")
            c11.Items.Add("२३ रुपाली panchali 4 line")
            c11.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo11.SelectedIndex = 8 Then
            txtgej11.Visible = False
            c11.Text = combo11.Text

        End If

        If combo11.SelectedIndex = 9 Then
            c11.Items.Add("२१ गजश्री panchali 3 line")
            c11.Items.Add("२१ गजश्री panchali 4 line")
            c11.Items.Add("२१ गजश्री panchali 5 line")
            c11.Items.Add("२२ गजश्री panchali 3 line")
            c11.Items.Add("२२ गजश्री panchali 4 line")
            c11.Items.Add("२२ गजश्री panchali 5 line")
            c11.Items.Add("२३ गजश्री panchali 3 line")
            c11.Items.Add("२३ गजश्री panchali 4 line")
            c11.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo10.SelectedIndexChanged
        If tw10.Text.ToString.Equals("b") Or tw10.Text.ToString.Equals("B") Then
            p11.Visible = False
            w10 = totalweight - w1 - w2 - w3 - w4 - w5 - w6 - w7 - w8 - w9

        Else
            w10 = Integer.Parse(tw10.Text)

            If totalweight > (w1 + w2 + w3 + w4 + w5 + w5 + w6 + w7 + w8 + w9 + w10) Then

                p11.Visible = True
            ElseIf (totalweight < (w1 + w2 + w3 + w4 + w5 + w5 + w6 + w7 + w8 + w9 + w10)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")
                p11.Visible = False


            End If

        End If

        c10.Items.Clear()

        If combo10.SelectedIndex = 0 Then
            txtgej10.Visible = False

            c10.Items.Add("१५ ओढणी")
            c10.Items.Add("१५|| ओढणी")
            c10.Items.Add("१६ ओढणी")
            c10.Items.Add("१६||ओढणी")
            c10.Items.Add("१७ ओढणी")
            c10.Items.Add("१७| ओढणी")
            c10.Items.Add("१७|| ओढणी")
            c10.Items.Add("१८ ओढणी")
            c10.Items.Add("१८|ओढणी")
            c10.Items.Add("१८||ओढणी")
            c10.Items.Add("१९ ओढणी")
            c10.Items.Add("१९|ओढणी")
            c10.Items.Add("१९||ओढणी")
            c10.Items.Add("२०ओढणी")
            c10.Items.Add("२०|ओढणी")
            c10.Items.Add("२०||ओढणी")
            c10.Items.Add("२१ ओढणी")
            c10.Items.Add("२१|ओढणी")
            c10.Items.Add("२१||ओढणी")
            c10.Items.Add("२२ ओढणी")
            c10.Items.Add("२२|ओढणी")
            c10.Items.Add("२२||ओढणी")
            c10.Items.Add("२३ ओढणी")
            c10.Items.Add("२४ ओढणी")
            c10.Items.Add("२५ ओढणी")
        End If
        If combo10.SelectedIndex = 1 Then
            txtgej10.Visible = True

            c10.Items.Add("कडचे फासे")
            c10.Items.Add("ळ कडी")
            c10.Items.Add("ळ सुत")
            c10.Items.Add("रु नाका कडी")
            c10.Items.Add("मधले फासे")

        End If
        If combo10.SelectedIndex = 2 Then
            txtgej10.Visible = True

            c10.Items.Add("कडचे फासे")
            c10.Items.Add("ळ कडी")
            c10.Items.Add("ळ सुत")
            c10.Items.Add("रु नाका कडी")
            c10.Items.Add("मधले फासे")

        End If
        If combo10.SelectedIndex = 3 Then
            txtgej10.Visible = False
            c10.Items.Add("साधा निमगोल ")
            c10.Items.Add("सेलम निमगोल")
            c10.Items.Add("चपटे निमगोल")
            c10.Items.Add("Jad निमगोल")

        End If

        If combo10.SelectedIndex = 4 Then
            txtgej10.Visible = False
            c10.Items.Add("३०० घागरी माटी")
            c10.Items.Add("३५० घागरी माटी")
        End If
        If combo10.SelectedIndex = 5 Then
            txtgej10.Visible = True
            c10.Items.Add("१६ ravakadi")
            c10.Items.Add("१७ ravakadi")
        End If
        If combo10.SelectedIndex = 6 Then
            txtgej10.Visible = True
            c10.Text = combo10.Text


        End If
        If combo10.SelectedIndex = 7 Then
            c10.Items.Add("२१ रुपाली panchali 3 line")
            c10.Items.Add("२१ रुपाली panchali 4 line")
            c10.Items.Add("२१ रुपाली panchali 5 line")
            c10.Items.Add("२२ रुपाली panchali 3 line")
            c10.Items.Add("२२ रुपाली panchali 4 line")
            c10.Items.Add("२२ रुपाली panchali 5 line")
            c10.Items.Add("२३ रुपाली panchali 3 line")
            c10.Items.Add("२३ रुपाली panchali 4 line")
            c10.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo10.SelectedIndex = 8 Then
            txtgej10.Visible = False
            c10.Text = combo10.Text

        End If

        If combo10.SelectedIndex = 9 Then
            c10.Items.Add("२१ गजश्री panchali 3 line")
            c10.Items.Add("२१ गजश्री panchali 4 line")
            c10.Items.Add("२१ गजश्री panchali 5 line")
            c10.Items.Add("२२ गजश्री panchali 3 line")
            c10.Items.Add("२२ गजश्री panchali 4 line")
            c10.Items.Add("२२ गजश्री panchali 5 line")
            c10.Items.Add("२३ गजश्री panchali 3 line")
            c10.Items.Add("२३ गजश्री panchali 4 line")
            c10.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub combo13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo13.SelectedIndexChanged
        If tw13.Text.ToString.Equals("b") Or tw13.Text.ToString.Equals("B") Then
            w13 = totalweight - w1 - w2 - w3 - w4 - w5 - w6 - w7 - w8 - w9 - w10 - w11 - w12

        Else
            w13 = Integer.Parse(tw13.Text)

            If totalweight > (w1 + w2 + +w3 + w4 + w5 + w5 + w6 + w7 + w8 + w9 + w10 + w11 + w12 + w13) Then

            ElseIf (totalweight < (w1 + w2)) Then
                MsgBox("तपशील वजन एकूण वजना पेकश्या जास्त आहे")


            End If

        End If

        c13.Items.Clear()

        If combo13.SelectedIndex = 0 Then
            txtgej13.Visible = False

            c13.Items.Add("१५ ओढणी")
            c13.Items.Add("१५|| ओढणी")
            c13.Items.Add("१६ ओढणी")
            c13.Items.Add("१६||ओढणी")
            c13.Items.Add("१७ ओढणी")
            c13.Items.Add("१७| ओढणी")
            c13.Items.Add("१७|| ओढणी")
            c13.Items.Add("१८ ओढणी")
            c13.Items.Add("१८|ओढणी")
            c13.Items.Add("१८||ओढणी")
            c13.Items.Add("१९ओढणी")
            c13.Items.Add("१९|ओढणी")
            c13.Items.Add("१९||ओढणी")
            c13.Items.Add("२०ओढणी")
            c13.Items.Add("२०|ओढणी")
            c13.Items.Add("२०||ओढणी")
            c13.Items.Add("२१ओढणी")
            c13.Items.Add("२१|ओढणी")
            c13.Items.Add("२१||ओढणी")
            c13.Items.Add("२२ ओढणी")
            c13.Items.Add("२२|ओढणी")
            c13.Items.Add("२२||ओढणी")
            c13.Items.Add("२३ ओढणी")
            c13.Items.Add("२४ ओढणी")
            c13.Items.Add("२५ ओढणी")
        End If
        If combo13.SelectedIndex = 1 Then
            txtgej13.Visible = True
            c13.Items.Add("कडचे फासे")
            c13.Items.Add("ळ कडी")
            c13.Items.Add("ळ सुत")
            c13.Items.Add("रु नाका कडी")
            c13.Items.Add("मधले फासे")

        End If
        If combo13.SelectedIndex = 2 Then
            txtgej13.Visible = True
            c13.Items.Add("कडचे फासे")
            c13.Items.Add("ळ कडी")
            c13.Items.Add("ळ सुत")
            c13.Items.Add("रु नाका कडी")
            c13.Items.Add("मधले फासे")

        End If
        If combo13.SelectedIndex = 3 Then
            txtgej13.Visible = False
            c13.Items.Add("साधा निमगोल ")
            c13.Items.Add("सेलम निमगोल")
            c13.Items.Add("चपटे निमगोल")
            c13.Items.Add("Jad निमगोल")

        End If

        If combo13.SelectedIndex = 4 Then
            txtgej13.Visible = False
            c13.Items.Add("३०० घागरी माटी")
            c13.Items.Add("३५० घागरी माटी")
        End If
        If combo13.SelectedIndex = 5 Then
            txtgej13.Visible = True
            c13.Items.Add("१६ ravakadi")
            c13.Items.Add("१७ ravakadi")
        End If
        If combo13.SelectedIndex = 6 Then
            txtgej13.Visible = True
            c13.Text = combo13.Text


        End If
        If combo13.SelectedIndex = 7 Then
            c13.Items.Add("२१ रुपाली panchali 3 line")
            c13.Items.Add("२१ रुपाली panchali 4 line")
            c13.Items.Add("२१ रुपाली panchali 5 line")
            c13.Items.Add("२२ रुपाली panchali 3 line")
            c13.Items.Add("२२ रुपाली panchali 4 line")
            c13.Items.Add("२२ रुपाली panchali 5 line")
            c13.Items.Add("२३ रुपाली panchali 3 line")
            c13.Items.Add("२३ रुपाली panchali 4 line")
            c13.Items.Add("२३ रुपाली panchali 5 line")
        End If
        If combo13.SelectedIndex = 8 Then
            txtgej13.Visible = False
            c13.Text = combo13.Text

        End If

        If combo13.SelectedIndex = 9 Then
            c13.Items.Add("२१ गजश्री panchali 3 line")
            c13.Items.Add("२१ गजश्री panchali 4 line")
            c13.Items.Add("२१ गजश्री panchali 5 line")
            c13.Items.Add("२२ गजश्री panchali 3 line")
            c13.Items.Add("२२ गजश्री panchali 4 line")
            c13.Items.Add("२२ गजश्री panchali 5 line")
            c13.Items.Add("२३ गजश्री panchali 3 line")
            c13.Items.Add("२३ गजश्री panchali 4 line")
            c13.Items.Add("२३ गजश्री panchali 5 line")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'        Dim connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\SutMDataB.mdb"
        Dim connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\SutMashineProduct.mdb"
        Dim odh1, chaluyene, odh2, odh3, odhgund, nimravselrupgaj, rupgaj22, rupgaj23, ghamati, katrani As Integer
        Dim d As Date
        s1 = c1.Text + txtgej1.Text
        s2 = c2.Text + txtgej2.Text
        s3 = c3.Text + txtgej3.Text
        s4 = c4.Text + txtgej4.Text
        s5 = c5.Text + txtgej5.Text
        s6 = c6.Text + txtgej6.Text
        s7 = c7.Text + txtgej7.Text
        s8 = c8.Text + txtgej8.Text
        s9 = c9.Text + txtgej9.Text
        s10 = c10.Text + txtgej10.Text
        s11 = c11.Text + txtgej11.Text
        s12 = c12.Text + txtgej12.Text
        s13 = c13.Text + txtgej13.Text
        If IsDate(MonthCalendar1.SelectionRange.Start) Then
            d = MonthCalendar1.SelectionRange.Start
        End If

        Dim index As Integer
        index = comboCustname.SelectedIndex + 1
        Dim queryStringInsert As String = "INSERT INTO tbl_tapshil ([custname],[date],[totvajan],[vajan1],[tap1],[vajan2],[tap2],[vajan3],[tap3],[vajan4],[tap4],[vajan5],[tap5],[vajan6],[tap6],[vajan7],[tap7],[vajan8],[tap8],[vajan9],[tap9],[vajan10],[tap10],[vajan11],[tap11],[vajan12],[tap12],[vajan13],[tap13]) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
        Using conn As New OleDbConnection(connect)

            Using cmd As New OleDbCommand(queryStringInsert, conn)
                conn.Open()
                cmd.Parameters.Add("@custname", OleDbType.VarChar).Value = comboCustname.Text
                cmd.Parameters.Add("@date", OleDbType.Date).Value = d
                cmd.Parameters.Add("@totvajan", OleDbType.Numeric).Value = totalweight
                cmd.Parameters.Add("@vajan1", OleDbType.Numeric).Value = w1
                cmd.Parameters.Add("@tap1", OleDbType.VarChar).Value = s1.ToString
                cmd.Parameters.Add("@vajan2", OleDbType.Numeric).Value = w2
                cmd.Parameters.Add("@tap2", OleDbType.VarChar).Value = s2.ToString
                cmd.Parameters.Add("@vajan3", OleDbType.Numeric).Value = w3
                cmd.Parameters.Add("@tap3", OleDbType.VarChar).Value = s3.ToString
                cmd.Parameters.Add("@vajan4", OleDbType.Numeric).Value = w4
                cmd.Parameters.Add("@tap4", OleDbType.VarChar).Value = s4.ToString
                cmd.Parameters.Add("@vajan5", OleDbType.Numeric).Value = w5
                cmd.Parameters.Add("@tap5", OleDbType.VarChar).Value = s5.ToString
                cmd.Parameters.Add("@vajan6", OleDbType.Numeric).Value = w6
                cmd.Parameters.Add("@tap6", OleDbType.VarChar).Value = s6.ToString
                cmd.Parameters.Add("@vajan7", OleDbType.Numeric).Value = w7
                cmd.Parameters.Add("@tap7", OleDbType.VarChar).Value = s7.ToString
                cmd.Parameters.Add("@vajan8", OleDbType.Numeric).Value = w8
                cmd.Parameters.Add("@tap8", OleDbType.VarChar).Value = s8.ToString
                cmd.Parameters.Add("@vajan9", OleDbType.Numeric).Value = w9
                cmd.Parameters.Add("@tap9", OleDbType.VarChar).Value = s9.ToString
                cmd.Parameters.Add("@vajan10", OleDbType.Numeric).Value = w10
                cmd.Parameters.Add("@tap10", OleDbType.VarChar).Value = s10.ToString
                cmd.Parameters.Add("@vajan11", OleDbType.Numeric).Value = w11
                cmd.Parameters.Add("@tap11", OleDbType.VarChar).Value = s11.ToString
                cmd.Parameters.Add("@vajan12", OleDbType.Numeric).Value = w12
                cmd.Parameters.Add("@tap12", OleDbType.VarChar).Value = s12.ToString
                cmd.Parameters.Add("@vajan13", OleDbType.Numeric).Value = w13
                cmd.Parameters.Add("@tap13", OleDbType.VarChar).Value = s13.ToString
                cmd.ExecuteNonQuery()
                MsgBox("नवीन तपशील सेव केला")
            End Using
        End Using

        Using con1 As New OleDbConnection(connect)
            con1.Open()
            Using cmd2 As New OleDbCommand("select * from tbl_custbill where id=?", con1)
                cmd2.Parameters.AddWithValue("", index)
                Using reader1 As OleDbDataReader = cmd2.ExecuteReader
                    While reader1.Read
                        odh1 = Integer.Parse(reader1("odh1"))
                        odh2 = Integer.Parse(reader1("odh2"))
                        odh3 = Integer.Parse(reader1("odh3"))
                        odhgund = Integer.Parse(reader1("odhgund"))
                        nimravselrupgaj = Integer.Parse(reader1("nimravselrupgaj"))
                        rupgaj22 = Integer.Parse(reader1("rupgaj22"))
                        rupgaj23 = Integer.Parse(reader1("rupgaj23"))
                        ghamati = Integer.Parse(reader1("ghamati"))
                        katrani = Integer.Parse(reader1("katrani"))
                        chaluyene = Integer.Parse(reader1("chaluyene"))
                    End While
                End Using
            End Using
        End Using

        If combo1.SelectedIndex = 0 Then
            If c1.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c1.SelectedIndex > 18 And c1.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c1.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo1.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo1.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo1.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo1.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo1.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo1.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo1.SelectedIndex = 7 Then
            If (c1.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c1.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c1.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo1.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo1.SelectedIndex = 9 Then

            If (c1.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c1.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c1.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If

        If combo2.SelectedIndex = 0 Then
            If c2.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c2.SelectedIndex > 18 And c2.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c2.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo2.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo2.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo2.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo2.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo2.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo2.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo2.SelectedIndex = 7 Then
            If (c2.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c2.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c2.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo2.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo2.SelectedIndex = 9 Then

            If (c2.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c2.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c2.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If


        If combo3.SelectedIndex = 0 Then
            If c3.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c3.SelectedIndex > 18 And c3.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c3.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo3.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo3.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo3.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo3.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo3.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo3.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo3.SelectedIndex = 7 Then
            If (c3.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c3.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c3.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo3.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo3.SelectedIndex = 9 Then

            If (c3.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c3.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c3.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If

        If combo4.SelectedIndex = 0 Then
            If c4.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c4.SelectedIndex > 18 And c4.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c4.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo4.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo4.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo4.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo4.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo4.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo4.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo4.SelectedIndex = 7 Then
            If (c4.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c4.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c4.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo4.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo4.SelectedIndex = 9 Then

            If (c4.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c4.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c4.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If


        If combo5.SelectedIndex = 0 Then
            If c5.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c5.SelectedIndex > 18 And c5.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c5.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo5.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo5.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo5.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo5.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo5.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo5.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo5.SelectedIndex = 7 Then
            If (c5.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c5.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c5.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo5.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo5.SelectedIndex = 9 Then

            If (c5.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c5.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c5.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If

        If combo6.SelectedIndex = 0 Then
            If c6.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c6.SelectedIndex > 18 And c6.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c6.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo6.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo6.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo6.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo6.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo6.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo6.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo6.SelectedIndex = 7 Then
            If (c6.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c6.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c6.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo6.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo6.SelectedIndex = 9 Then

            If (c6.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c6.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c6.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If

        If combo7.SelectedIndex = 0 Then
            If c7.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c7.SelectedIndex > 18 And c7.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c7.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo7.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo7.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo7.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo7.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo7.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo7.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo7.SelectedIndex = 7 Then
            If (c7.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c7.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c7.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo7.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo7.SelectedIndex = 9 Then

            If (c7.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c7.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c7.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If

        If combo8.SelectedIndex = 0 Then
            If c8.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c8.SelectedIndex > 18 And c8.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c8.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo8.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo8.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo8.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo8.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo8.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo8.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo8.SelectedIndex = 7 Then
            If (c8.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c8.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c8.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo8.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo8.SelectedIndex = 9 Then

            If (c8.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c8.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c8.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If

        If combo9.SelectedIndex = 0 Then
            If c9.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c9.SelectedIndex > 18 And c9.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c9.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo9.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo9.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo9.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo9.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo9.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo9.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo9.SelectedIndex = 7 Then
            If (c9.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c9.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c9.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo9.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo9.SelectedIndex = 9 Then

            If (c9.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c9.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c9.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If


        If combo10.SelectedIndex = 0 Then
            If c10.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c10.SelectedIndex > 18 And c10.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c10.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo10.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo10.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo10.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo10.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo10.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo10.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo10.SelectedIndex = 7 Then
            If (c10.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c10.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c10.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo10.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo10.SelectedIndex = 9 Then

            If (c10.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c10.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c10.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If

        If combo11.SelectedIndex = 0 Then
            If c11.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c11.SelectedIndex > 18 And c11.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c11.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo11.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo11.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo11.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo11.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo11.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo11.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo11.SelectedIndex = 7 Then
            If (c11.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c11.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c11.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo11.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo11.SelectedIndex = 9 Then

            If (c11.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c11.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c11.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If

        If combo12.SelectedIndex = 0 Then
            If c12.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c12.SelectedIndex > 18 And c12.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c12.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo12.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo12.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo12.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo12.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo12.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo12.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo12.SelectedIndex = 7 Then
            If (c12.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c12.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c12.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo12.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo12.SelectedIndex = 9 Then

            If (c12.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c12.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c12.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If

        If combo13.SelectedIndex = 0 Then
            If c13.SelectedIndex <= 18 Then
                odh1 = odh1 + w1
            End If
            If c13.SelectedIndex > 18 And c13.SelectedIndex < 22 Then
                odh2 = odh2 + w1
            End If
            If c13.SelectedIndex > 22 Then
                odh3 = odh3 + w1
            End If
        End If
        If combo13.SelectedIndex = 1 Then
            odhgund = odhgund + w1
        End If

        If combo13.SelectedIndex = 2 Then
            odhgund = odhgund + w1
        End If
        If combo13.SelectedIndex = 3 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If

        If combo13.SelectedIndex = 4 Then
            ghamati = ghamati + w1
        End If

        If combo13.SelectedIndex = 5 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo13.SelectedIndex = 6 Then
            nimravselrupgaj = nimravselrupgaj + w1
        End If
        If combo13.SelectedIndex = 7 Then
            If (c13.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c13.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c13.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        If combo13.SelectedIndex = 8 Then
            katrani = katrani + w1
        End If
        If combo13.SelectedIndex = 9 Then

            If (c13.SelectedIndex = 0) Then
                nimravselrupgaj = nimravselrupgaj + w1
            End If
            If (c13.SelectedIndex = 1) Then
                rupgaj22 = rupgaj22 + w1
            End If
            If (c13.SelectedIndex = 2) Then
                rupgaj23 = rupgaj23 + w1
            End If

        End If
        Dim d1, d2, d3, d4, d5, d6, d7, d8, d9 As Integer
        Using con1 As New OleDbConnection(connect)
            con1.Open()
            Using cmd2 As New OleDbCommand("select * from dar", con1)


                Using reader1 As OleDbDataReader = cmd2.ExecuteReader

                    While reader1.Read


                        d1 = Integer.Parse(reader1("odh1"))
                        d2 = Integer.Parse(reader1("odh2"))
                        d3 = Integer.Parse(reader1("odh3"))
                        d4 = Integer.Parse(reader1("odhgund"))
                        d5 = Integer.Parse(reader1("nimravselrupgaj"))
                        d6 = Integer.Parse(reader1("rupgaj22"))
                        d7 = Integer.Parse(reader1("rupgaj23"))
                        d8 = Integer.Parse(reader1("ghamati"))
                        d9 = Integer.Parse(reader1("katrani"))

                    End While
                End Using
            End Using
        End Using
        lbltest1.Text = d1.ToString + " " + d2.ToString + " " + d3.ToString + " "
        Using con2 As New OleDbConnection(connect)
            con2.Open()
            Dim yene As Integer = 0
            yene = (odh1 * d1) / 1000 + (odh2 * d2) / 1000 + (odh3 * d3) / 1000 + (odhgund * d4) / 1000 + (nimravselrupgaj * d5) / 1000 + (rupgaj22 * d6) / 1000 + (rupgaj23 * d7) / 1000 + (ghamati * d8) / 1000 + (katrani * 25) / 1000
            Button1.Text = d1.ToString
            Using cmd3 As New OleDbCommand("update tbl_custbill set odh1=?,odh2=?,odh3=?,odhgund=?,nimravselrupgaj=?,rupgaj22=?,rupgaj23=?,ghamati=?,katrani=?,chaluyene=? where id=?", con2)
                Dim i As Integer
                i = comboCustname.SelectedIndex + 1
                cmd3.Parameters.AddWithValue("", odh1)
                cmd3.Parameters.AddWithValue("", odh2)
                cmd3.Parameters.AddWithValue("", odh3)
                cmd3.Parameters.AddWithValue("", odhgund)
                cmd3.Parameters.AddWithValue("", nimravselrupgaj)
                cmd3.Parameters.AddWithValue("", rupgaj22)
                cmd3.Parameters.AddWithValue("", rupgaj23)
                cmd3.Parameters.AddWithValue("", ghamati)
                cmd3.Parameters.AddWithValue("", katrani)
                cmd3.Parameters.AddWithValue("", yene)
                cmd3.Parameters.AddWithValue("", i)
                cmd3.ExecuteNonQuery()
            End Using
        End Using
        p2.Visible = False
        p3.Visible = False
        p5.Visible = False
        p4.Visible = False
        p6.Visible = False
        p11.Visible = False
        p10.Visible = False
        p8.Visible = False
        p7.Visible = False
        p12.Visible = False
        p9.Visible = False
        p13.Visible = False
        txttotalweight.Text = ""
        txtgej1.Text = ""
        tw1.Text = ""

    End Sub

    Private Sub p1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles p1.Paint

    End Sub


End Class