Public Class Menu1

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeToolStripMenuItem.Click

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub DeleteListTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteListTableToolStripMenuItem.Click

    End Sub

    Private Sub CreateNewListTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EnterNewCityInListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CompleteProspectListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteProspectListToolStripMenuItem.Click
        Full_Prospect_list.Show()
    End Sub

    Private Sub CustomizeAccToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click

    End Sub

    Private Sub ProspectEntryFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProspectEntryFormToolStripMenuItem.Click
        Prospect_Entry_form.Show()
    End Sub

    Private Sub TeamEntryFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeamEntryFormToolStripMenuItem.Click
        Team_Entry_Form.Show()
    End Sub

    Private Sub CompleteTeamListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteTeamListToolStripMenuItem.Click
        Team_list.Show()
    End Sub

    Private Sub CustomizableListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizableListToolStripMenuItem.Click
        Prospect_report_form.Show()
    End Sub

    Private Sub BasedOnTeamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasedOnTeamToolStripMenuItem.Click

    End Sub

    Private Sub CustomizationTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizationTableToolStripMenuItem.Click
        Team_Report_form.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ProspectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProspectToolStripMenuItem.Click
        empty_prospect_list.Show()
    End Sub

    Private Sub TeamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeamToolStripMenuItem.Click
        empty_team_list.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class