Imports System.Data.OleDb
Public Class Team_Report_form
    Dim con As OleDbConnection
    Dim ad As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub Team_Report_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\EMS\emsdb.accdb")
        con.Open()
        ds = New DataSet()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim S As String
        Dim col(6) As String
        Dim value1(6) As String
        Dim i As Integer = 0
        If CheckBox2.Checked = True Then
            col(i) = "level1"
            value1(i) = ComboBox6.Text
            i = i + 1
        End If
        If CheckBox1.Checked = True Then
            col(i) = "city"
            value1(i) = TextBox1.Text
            i = i + 1
        End If
        If CheckBox3.Checked = True Then
            col(i) = "country"
            value1(i) = TextBox2.Text
            i = i + 1
        End If
        If CheckBox4.Checked = True Then
            col(i) = "leadership"
            value1(i) = ComboBox3.Text
            i = i + 1
        End If
        If CheckBox5.Checked = True Then
            col(i) = "state_of_work"
            value1(i) = ComboBox1.Text
            i = i + 1
        End If
        If CheckBox6.Checked = True Then
            col(i) = "having_course"
            value1(i) = ComboBox5.Text
            i = i + 1
        End If
       




        If i = 1 Then
            S = "select * from team where " & col(0) & " like '" & value1(0) & "'"
        ElseIf i = 2 Then
            S = "select * from team where " & col(0) & " like '" & value1(0) & "' and " & col(1) & " like '" & value1(1) & "'"
        ElseIf i = 3 Then
            S = "select * from team where " & col(0) & " like '" & value1(0) & "' and " & col(1) & " like '" & value1(1) & "' and " & col(2) & " like '" & value1(2) & "'"
        ElseIf i = 4 Then
            S = "select * from team where " & col(0) & " like '" & value1(0) & "' and " & col(1) & " like '" & value1(1) & "' and " & col(2) & " like '" & value1(2) & "' and " & col(3) & " like '" & value1(3) & "'"
        ElseIf i = 5 Then
            S = "select * from team where " & col(0) & " like '" & value1(0) & "' and " & col(1) & " like '" & value1(1) & "' and " & col(2) & " like '" & value1(2) & "' and " & col(3) & " like '" & value1(3) & "' and " & col(4) & " like '" & value1(4) & "'"
        Else
            S = "select * from team where " & col(0) & " like '" & value1(0) & "' and " & col(1) & " like '" & value1(1) & "' and " & col(2) & " like '" & value1(2) & "' and " & col(3) & " like '" & value1(3) & "' and " & col(4) & " like '" & value1(4) & "' and " & col(5) & " like '" & value1(5) & "'"

        End If

        ds = New DataSet()

        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            ComboBox6.Enabled = True
        Else
            ComboBox6.Enabled = False
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            ComboBox3.Enabled = True
        Else
            ComboBox3.Enabled = False
        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            ComboBox5.Enabled = True
        Else
            ComboBox5.Enabled = False
        End If

    End Sub
End Class