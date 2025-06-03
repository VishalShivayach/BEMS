Imports System.Data.OleDb

Public Class Prospect_Entry_form
    Dim con As OleDbConnection
    Dim ad As OleDbDataAdapter
    Dim ds As DataSet
    
    Private Sub Prospect_Entry_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\EMS\emsdb.accdb")
        con.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("PLEASE FILL NAME")
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(TextBox3.Text, "[^0-9]") Or TextBox3.Text.Length >= 13 Then
            MsgBox("PLEASE FILL valid Number")
        Else

            ds = New DataSet()
            Dim gender As String
            Dim S As String
            Dim a As String = ""
            Dim n As Integer


            S = "select max(s_no) from prospect"
            ad = New OleDbDataAdapter(S, con)
            ad.Fill(ds)
            Try
                n = Val(ds.Tables(0).Rows(0).Item(0).ToString)
                n = n + 1
            Catch e1 As Exception
                n = 1
            End Try


            If CheckBox2.Checked = True Then
                a += CheckBox2.Text + " "
            End If
            If CheckBox3.Checked = True Then
                a += CheckBox3.Text + " "
            End If
            If CheckBox4.Checked = True Then
                a += CheckBox4.Text + " "
            End If
            If CheckBox5.Checked = True Then
                a += CheckBox5.Text + " "
            End If


            If RadioButton4.Checked = True Then
                gender = "MALE"
            Else
                gender = "FEMALE"
            End If
            Dim meeting As String
            If RadioButton1.Checked = True Then
                meeting = "done"
            Else
                meeting = "not done"
            End If

            S = "insert into prospect(s_no,first_name,last_name,gender,address,phone1,phone2,date1,source,city,country,prospecting_type,meeting,rating,response,personality_type) values(" & n & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & gender & "','" & TextBox6.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "',#" & DateTimePicker1.Value & "#,'" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & ComboBox1.Text & "','" & meeting & "','" & ComboBox5.Text & "','" & TextBox5.Text & "','" & a & "')"


            ad = New OleDbDataAdapter(S, con)
            ad.Fill(ds)
            MsgBox(TextBox1.Text + "'s Data inserted")

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox6.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox5.Text = ""
            ComboBox1.Text = ""
            ComboBox5.Text = ""

            If RadioButton4.Checked = True Then
                RadioButton4.Checked = False
            ElseIf RadioButton3.Checked = True Then
                RadioButton3.Checked = False
            Else
                RadioButton3.Checked = False
                RadioButton4.Checked = False
            End If


            If RadioButton1.Checked = True Then
                RadioButton1.Checked = False
            ElseIf RadioButton2.Checked = True Then
                RadioButton2.Checked = False
            Else
                RadioButton1.Checked = False
                RadioButton2.Checked = False
            End If

            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False

        End If
        

    End Sub

    Private Sub empty_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empty_btn.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox6.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        ComboBox5.Text = ""

        If RadioButton4.Checked = True Then
            RadioButton4.Checked = False
        ElseIf RadioButton3.Checked = True Then
            RadioButton3.Checked = False
        Else
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        End If


        If RadioButton1.Checked = True Then
            RadioButton1.Checked = False
        ElseIf RadioButton2.Checked = True Then
            RadioButton2.Checked = False
        Else
            RadioButton1.Checked = False
            RadioButton2.Checked = False
        End If

        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False


    End Sub

    
End Class