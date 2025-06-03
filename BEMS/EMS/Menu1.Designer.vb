<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteListTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProspectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProspectEntryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamEntryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompleteProspectListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompleteTeamListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasedOnProspectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizableListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasedOnTeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizationTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NeToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteListTableToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DeleteListTableToolStripMenuItem
        '
        Me.DeleteListTableToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.DeleteListTableToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProspectToolStripMenuItem, Me.TeamToolStripMenuItem})
        Me.DeleteListTableToolStripMenuItem.Name = "DeleteListTableToolStripMenuItem"
        Me.DeleteListTableToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.DeleteListTableToolStripMenuItem.Text = "Empty list"
        '
        'ProspectToolStripMenuItem
        '
        Me.ProspectToolStripMenuItem.Name = "ProspectToolStripMenuItem"
        Me.ProspectToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ProspectToolStripMenuItem.Text = "prospect"
        '
        'TeamToolStripMenuItem
        '
        Me.TeamToolStripMenuItem.Name = "TeamToolStripMenuItem"
        Me.TeamToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.TeamToolStripMenuItem.Text = "team"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NeToolStripMenuItem
        '
        Me.NeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProspectEntryFormToolStripMenuItem, Me.TeamEntryFormToolStripMenuItem})
        Me.NeToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NeToolStripMenuItem.Name = "NeToolStripMenuItem"
        Me.NeToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.NeToolStripMenuItem.Text = "New Entry"
        '
        'ProspectEntryFormToolStripMenuItem
        '
        Me.ProspectEntryFormToolStripMenuItem.Name = "ProspectEntryFormToolStripMenuItem"
        Me.ProspectEntryFormToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.ProspectEntryFormToolStripMenuItem.Text = "Prospect Entry form"
        '
        'TeamEntryFormToolStripMenuItem
        '
        Me.TeamEntryFormToolStripMenuItem.Name = "TeamEntryFormToolStripMenuItem"
        Me.TeamEntryFormToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.TeamEntryFormToolStripMenuItem.Text = "Team Entry Form"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompleteProspectListToolStripMenuItem, Me.CompleteTeamListToolStripMenuItem})
        Me.ViewToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(113, 24)
        Me.ViewToolStripMenuItem.Text = "View/Update"
        '
        'CompleteProspectListToolStripMenuItem
        '
        Me.CompleteProspectListToolStripMenuItem.Name = "CompleteProspectListToolStripMenuItem"
        Me.CompleteProspectListToolStripMenuItem.Size = New System.Drawing.Size(169, 24)
        Me.CompleteProspectListToolStripMenuItem.Text = "Prospect List"
        '
        'CompleteTeamListToolStripMenuItem
        '
        Me.CompleteTeamListToolStripMenuItem.Name = "CompleteTeamListToolStripMenuItem"
        Me.CompleteTeamListToolStripMenuItem.Size = New System.Drawing.Size(169, 24)
        Me.CompleteTeamListToolStripMenuItem.Text = "Team list"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasedOnProspectsToolStripMenuItem, Me.BasedOnTeamToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ReportToolStripMenuItem.Text = "Sort/View Reports"
        '
        'BasedOnProspectsToolStripMenuItem
        '
        Me.BasedOnProspectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizableListToolStripMenuItem})
        Me.BasedOnProspectsToolStripMenuItem.Name = "BasedOnProspectsToolStripMenuItem"
        Me.BasedOnProspectsToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.BasedOnProspectsToolStripMenuItem.Text = "Prospects"
        '
        'CustomizableListToolStripMenuItem
        '
        Me.CustomizableListToolStripMenuItem.Name = "CustomizableListToolStripMenuItem"
        Me.CustomizableListToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.CustomizableListToolStripMenuItem.Text = "Customizable list"
        '
        'BasedOnTeamToolStripMenuItem
        '
        Me.BasedOnTeamToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizationTableToolStripMenuItem})
        Me.BasedOnTeamToolStripMenuItem.Name = "BasedOnTeamToolStripMenuItem"
        Me.BasedOnTeamToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.BasedOnTeamToolStripMenuItem.Text = "Team"
        '
        'CustomizationTableToolStripMenuItem
        '
        Me.CustomizationTableToolStripMenuItem.Name = "CustomizationTableToolStripMenuItem"
        Me.CustomizationTableToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.CustomizationTableToolStripMenuItem.Text = "Customizable list"
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(914, 464)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu1"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteListTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProspectEntryFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeamEntryFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompleteProspectListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompleteTeamListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasedOnProspectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasedOnTeamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizableListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizationTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProspectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
