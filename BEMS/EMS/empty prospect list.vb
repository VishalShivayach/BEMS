Imports System.Data.OleDb
Public Class empty_prospect_list
    Dim con As OleDbConnection
    Dim ad As OleDbDataAdapter
    Dim ds As DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ds = New DataSet()
        Dim S As String
        S = "delete * from prospect"
        ad = New OleDbDataAdapter(S, con)
        ad.Fill(ds)
        MsgBox("All entries are deleted")
        Me.Close()
    End Sub

    Private Sub empty_prospect_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\EMS\emsdb.accdb")
        con.Open()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class