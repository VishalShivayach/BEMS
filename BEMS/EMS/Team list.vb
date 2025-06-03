Imports System.Data.OleDb
Public Class Team_list
    Dim con As OleDbConnection
    Dim ad As OleDbDataAdapter
    Dim ds As DataSet
    Private Sub Team_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\EMS\emsdb.accdb")
        con.Open()
        ds = New DataSet()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim S As String
        ds = New DataSet()

        S = "select * from team"
        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim S As String
        ds = New DataSet
        S = "select * from team where first_name like '" & TextBox5.Text & "%'"
        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox12.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(0)
        ComboBox5.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(1)
        TextBox1.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(2)
        TextBox2.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(3)
        TextBox7.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(4)
        TextBox13.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(5)
        TextBox6.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(6)
        TextBox3.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(7)
        TextBox4.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(8)
        TextBox10.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(9)
        TextBox9.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(10)
        TextBox11.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(11)
        ComboBox1.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(12)
        TextBox8.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(13)
        ComboBox2.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(15)
        ComboBox4.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(16)
        TextBox14.Text = ds.Tables(0).Rows(DataGridView1.CurrentRow.Index)(14)

        TextBox12.Enabled = False

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim S As String
        ds = New DataSet

        S = "update team set level1='" & ComboBox5.Text & "', first_name='" & TextBox1.Text & "', last_name='" & TextBox2.Text & "',id1='" & TextBox7.Text & "', gender='" & TextBox13.Text & "',address='" & TextBox6.Text & "',phone1='" & TextBox3.Text & "',phone2='" & TextBox4.Text & "', personality_type = Ucase('" & TextBox10.Text & "'), city='" & TextBox9.Text & "', country='" & TextBox11.Text & "', leadership='" & ComboBox1.Text & "', email_id1='" & TextBox8.Text & "', state_of_work ='" & ComboBox2.Text & "', having_course='" & ComboBox4.Text & "', sponsor_name='" & TextBox14.Text & "' where s_no= '" & TextBox12.Text & "'"
        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)
        MsgBox(TextBox1.Text + "'s Data UPDATED successfully")
        TextBox12.Text = ""
        ComboBox5.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox13.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox10.Text = ""
        TextBox9.Text = ""
        TextBox11.Text = ""
        ComboBox1.Text = ""
        TextBox8.Text = ""
        ComboBox2.Text = ""
        ComboBox4.Text = ""
        TextBox14.Text = ""

        S = "select * from team"
        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If TextBox8.Text = "" Then
        Else

            Dim S As String
            ds = New DataSet

            S = "delete * from team where s_no= '" & TextBox12.Text & "'"
            ad = New OleDbDataAdapter(S, con)
            ad.Fill(ds)
            MsgBox(TextBox1.Text + "'s Data DELETED successfully")

            TextBox12.Text = ""
            ComboBox5.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox13.Text = ""
            TextBox7.Text = ""
            TextBox6.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox10.Text = ""
            TextBox9.Text = ""
            TextBox11.Text = ""
            ComboBox1.Text = ""
            TextBox8.Text = ""
            ComboBox2.Text = ""
            ComboBox4.Text = ""
            TextBox14.Text = ""

            S = "select * from team"
            ad = New OleDbDataAdapter(S, con)
            ad.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)
        End If
    End Sub

End Class