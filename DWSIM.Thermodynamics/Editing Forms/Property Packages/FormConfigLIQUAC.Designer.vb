<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConfigLIQUAC

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfigLIQUAC))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FaTabStrip1 = New FarsiLibrary.Win.FATabStrip()
        Me.FaTabStripItem3 = New FarsiLibrary.Win.FATabStripItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvu1 = New System.Windows.Forms.DataGridView()
        Me.LabelWithDivider3 = New System.Windows.Forms.Label()
        Me.FaTabStripItem2 = New FarsiLibrary.Win.FATabStripItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbMaxIts = New System.Windows.Forms.TextBox()
        Me.cbReacSets = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.FaTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FaTabStrip1.SuspendLayout()
        Me.FaTabStripItem3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FaTabStripItem2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FaTabStrip1
        '
        resources.ApplyResources(Me.FaTabStrip1, "FaTabStrip1")
        Me.FaTabStrip1.AlwaysShowClose = False
        Me.FaTabStrip1.AlwaysShowMenuGlyph = False
        Me.FaTabStrip1.Items.AddRange(New FarsiLibrary.Win.FATabStripItem() {Me.FaTabStripItem3, Me.FaTabStripItem2})
        Me.FaTabStrip1.Name = "FaTabStrip1"
        Me.FaTabStrip1.SelectedItem = Me.FaTabStripItem3
        '
        'FaTabStripItem3
        '
        resources.ApplyResources(Me.FaTabStripItem3, "FaTabStripItem3")
        Me.FaTabStripItem3.CanClose = False
        Me.FaTabStripItem3.Controls.Add(Me.GroupBox3)
        Me.FaTabStripItem3.IsDrawn = True
        Me.FaTabStripItem3.Name = "FaTabStripItem3"
        Me.FaTabStripItem3.Selected = True
        '
        'GroupBox3
        '
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Controls.Add(Me.dgvu1)
        Me.GroupBox3.Controls.Add(Me.LabelWithDivider3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'dgvu1
        '
        resources.ApplyResources(Me.dgvu1, "dgvu1")
        Me.dgvu1.AllowUserToAddRows = False
        Me.dgvu1.AllowUserToDeleteRows = False
        Me.dgvu1.AllowUserToResizeColumns = False
        Me.dgvu1.AllowUserToResizeRows = False
        Me.dgvu1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvu1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvu1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvu1.MultiSelect = False
        Me.dgvu1.Name = "dgvu1"
        Me.dgvu1.RowHeadersVisible = False
        Me.dgvu1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle7.Format = "N5"
        Me.dgvu1.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvu1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        '
        'LabelWithDivider3
        '
        resources.ApplyResources(Me.LabelWithDivider3, "LabelWithDivider3")
        Me.LabelWithDivider3.Name = "LabelWithDivider3"
        '
        'FaTabStripItem2
        '
        resources.ApplyResources(Me.FaTabStripItem2, "FaTabStripItem2")
        Me.FaTabStripItem2.CanClose = False
        Me.FaTabStripItem2.Controls.Add(Me.GroupBox2)
        Me.FaTabStripItem2.IsDrawn = True
        Me.FaTabStripItem2.Name = "FaTabStripItem2"
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tbTol)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbMaxIts)
        Me.GroupBox2.Controls.Add(Me.cbReacSets)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'tbTol
        '
        resources.ApplyResources(Me.tbTol, "tbTol")
        Me.tbTol.Name = "tbTol"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'tbMaxIts
        '
        resources.ApplyResources(Me.tbMaxIts, "tbMaxIts")
        Me.tbMaxIts.Name = "tbMaxIts"
        '
        'cbReacSets
        '
        resources.ApplyResources(Me.cbReacSets, "cbReacSets")
        Me.cbReacSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbReacSets.FormattingEnabled = True
        Me.cbReacSets.Name = "cbReacSets"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.FillWeight = 20.0!
        resources.ApplyResources(Me.Column3, "Column3")
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.FillWeight = 20.0!
        resources.ApplyResources(Me.Column4, "Column4")
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.FillWeight = 20.0!
        resources.ApplyResources(Me.Column5, "Column5")
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.FillWeight = 20.0!
        resources.ApplyResources(Me.Column6, "Column6")
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column7.FillWeight = 20.0!
        resources.ApplyResources(Me.Column7, "Column7")
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column8.FillWeight = 20.0!
        resources.ApplyResources(Me.Column8, "Column8")
        Me.Column8.Name = "Column8"
        '
        'FormConfigLIQUAC
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.FaTabStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormConfigLIQUAC"
        CType(Me.FaTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FaTabStrip1.ResumeLayout(False)
        Me.FaTabStripItem3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FaTabStripItem2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents FaTabStrip1 As FarsiLibrary.Win.FATabStrip
    Public WithEvents FaTabStripItem3 As FarsiLibrary.Win.FATabStripItem
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents dgvu1 As System.Windows.Forms.DataGridView
    Public WithEvents LabelWithDivider3 As System.Windows.Forms.Label
    Friend WithEvents FaTabStripItem2 As FarsiLibrary.Win.FATabStripItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbTol As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbMaxIts As System.Windows.Forms.TextBox
    Friend WithEvents cbReacSets As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
