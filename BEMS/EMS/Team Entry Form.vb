Imports System.Data.OleDb

Public Class Team_Entry_Form
    Dim con As OleDbConnection
    Dim ad As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub Team_Entry_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\EMS\emsdb.accdb")
        con.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
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

                S = "select max(s_no) from team"
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


                Dim leadership As String
                If RadioButton1.Checked = True Then
                    leadership = "yes"
                Else
                    leadership = "no"
                End If

                S = "insert into team(s_no,level1,first_name,last_name,id1,gender,address,phone1,phone2,personality_type,city,country,leadership,email_id1,sponsor_name) values(" & n & ",'" & ComboBox5.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox7.Text & "','" & gender & "','" & TextBox6.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & a & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & leadership & "','" & TextBox8.Text & "','" & TextBox5.Text & "')"


                ad = New OleDbDataAdapter(S, con)
                ad.Fill(ds)
                MsgBox(TextBox1.Text + "'s Data inserted")

                TextBox1.Text = ""
                TextBox2.Text = ""
                ComboBox5.Text = ""
                TextBox7.Text = ""
                TextBox6.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox5.Text = ""
                TextBox8.Text = ""
                If RadioButton4.Checked = True Then
                    RadioButton4.Checked = False
                ElseIf RadioButton3.Checked = True Then
                    RadioButton3.Checked = False
                Else
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False
                End If
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False

            End If
        Catch e2 As Exception
            MsgBox("error")
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim S As String
        ds = New DataSet
        S = "select * from prospect where first_name like '" & TextBox1.Text & "%'"
        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(1)
        TextBox2.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(2)
        TextBox6.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(4)
        TextBox3.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(5)
        TextBox4.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(6)
        TextBox9.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(11)
        TextBox10.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(12)

        If ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(3) = "MALE" Then
            RadioButton4.Checked = True
        Else
            RadioButton3.Checked = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empty_btn.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox5.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox5.Text = ""
        TextBox8.Text = ""
        If RadioButton4.Checked = True Then
            RadioButton4.Checked = False
        ElseIf RadioButton3.Checked = True Then
            RadioButton3.Checked = False
        Else
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        End If
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False


    End Sub
End Class