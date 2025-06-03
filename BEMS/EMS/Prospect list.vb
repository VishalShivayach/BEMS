Imports System.Data.OleDb
Public Class Full_Prospect_list
    Dim con As OleDbConnection
    Dim ad As OleDbDataAdapter
    Dim ds As DataSet
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim S As String
        ds = New DataSet()

        S = "select * from prospect"
        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)


    End Sub

    Private Sub Full_Prospect_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\EMS\emsdb.accdb")
        con.Open()
        ds = New DataSet()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        TextBox17.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(0)
        TextBox8.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(1)
        TextBox2.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(2)
        TextBox9.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(3)
        TextBox6.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(4)
        TextBox3.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(5)
        TextBox4.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(6)
        TextBox16.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(7)
        TextBox7.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(8)
        TextBox10.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(9)
        ComboBox1.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(10)
        TextBox12.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(11)
        TextBox13.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(12)
        TextBox11.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(13)
        ComboBox5.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(14)
        TextBox5.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(15)

        TextBox17.Enabled = False
        TextBox16.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim S As String
        ds = New DataSet
        S = "select * from prospect where first_name like '" & TextBox1.Text & "%'"
        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim S As String
        ds = New DataSet

        S = "update prospect set first_name='" & TextBox8.Text & "', last_name='" & TextBox2.Text & "', gender='" & TextBox9.Text & "', address='" & TextBox6.Text & "', phone1='" & TextBox3.Text & "', phone2='" & TextBox4.Text & "', source= '" & TextBox7.Text & "', personality_type= Ucase('" & TextBox10.Text & "'), prospecting_type='" & ComboBox1.Text & "', city='" & TextBox12.Text & "', country='" & TextBox13.Text & "', meeting='" & TextBox11.Text & "', rating='" & ComboBox5.Text & "', response='" & TextBox5.Text & "' where s_no= '" & TextBox17.Text & "'"
        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)
        MsgBox(TextBox8.Text + "'s Data UPDATED successfully")

        TextBox17.Text = ""
        TextBox8.Text = ""
        TextBox2.Text = ""
        TextBox9.Text = ""
        TextBox6.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox16.Text = ""
        TextBox7.Text = ""
        TextBox10.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox11.Text = ""
        ComboBox5.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""

        S = "select * from prospect"
        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox8.Text = "" Then
        Else

            Dim S As String
            ds = New DataSet

            S = "delete * from prospect where s_no= '" & TextBox17.Text & "'"
            ad = New OleDbDataAdapter(S, con)
            ad.Fill(ds)
            MsgBox(TextBox8.Text + "'s Data DELETED successfully")

            TextBox17.Text = ""
            TextBox8.Text = ""
            TextBox2.Text = ""
            TextBox9.Text = ""
            TextBox6.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox16.Text = ""
            TextBox7.Text = ""
            TextBox10.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox11.Text = ""
            ComboBox5.Text = ""
            TextBox5.Text = ""
            ComboBox1.Text = ""

            S = "select * from prospect"
            ad = New OleDbDataAdapter(S, con)
            ad.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)
        End If

    End Sub

End Class