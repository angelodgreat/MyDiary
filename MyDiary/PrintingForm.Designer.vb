<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintingForm
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.components = New System.ComponentModel.Container()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.ropa_recordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.print_stud = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.print_date = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.print_hourscomplete = New Telerik.WinControls.UI.RadTextBox()
        Me.print_totalhours = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.ropa_recordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.print_stud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.print_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.print_hourscomplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.print_totalhours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ropa_recordsBindingSource
        '
        Me.ropa_recordsBindingSource.DataMember = "ropa_records"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.print_totalhours)
        Me.RadPanel1.Controls.Add(Me.print_hourscomplete)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.print_stud)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.print_date)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1121, 42)
        Me.RadPanel1.TabIndex = 1
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(803, 11)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(66, 18)
        Me.RadLabel4.TabIndex = 9
        Me.RadLabel4.Text = "Total Hours:"
        Me.RadLabel4.ThemeName = "VisualStudio2012Dark"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(631, 12)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel3.TabIndex = 7
        Me.RadLabel3.Text = "Hours Completed:"
        Me.RadLabel3.ThemeName = "VisualStudio2012Dark"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(281, 13)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(94, 18)
        Me.RadLabel2.TabIndex = 5
        Me.RadLabel2.Text = "Name of Student:"
        Me.RadLabel2.ThemeName = "VisualStudio2012Dark"
        '
        'print_stud
        '
        RadListDataItem1.Text = "Umali, Christian Angelo R."
        Me.print_stud.Items.Add(RadListDataItem1)
        Me.print_stud.Location = New System.Drawing.Point(381, 11)
        Me.print_stud.Name = "print_stud"
        Me.print_stud.Size = New System.Drawing.Size(240, 24)
        Me.print_stud.TabIndex = 4
        Me.print_stud.Text = "Student Name"
        Me.print_stud.ThemeName = "VisualStudio2012Dark"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(11, 13)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(73, 18)
        Me.RadLabel1.TabIndex = 3
        Me.RadLabel1.Text = "Signing Date:"
        Me.RadLabel1.ThemeName = "VisualStudio2012Dark"
        '
        'print_date
        '
        Me.print_date.CustomFormat = "MMMM d, yyyy"
        Me.print_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.print_date.Location = New System.Drawing.Point(90, 11)
        Me.print_date.MinimumSize = New System.Drawing.Size(0, 24)
        Me.print_date.Name = "print_date"
        '
        '
        '
        Me.print_date.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.print_date.Size = New System.Drawing.Size(179, 24)
        Me.print_date.TabIndex = 2
        Me.print_date.TabStop = False
        Me.print_date.Text = "July 14, 2016"
        Me.print_date.ThemeName = "VisualStudio2012Dark"
        Me.print_date.Value = New Date(2016, 7, 14, 0, 0, 0, 0)
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.ReportViewer1)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(1097, 535)
        Me.RadGroupBox1.TabIndex = 2
        Me.RadGroupBox1.ThemeName = "VisualStudio2012Dark"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 18)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1093, 515)
        Me.ReportViewer1.TabIndex = 0
        '
        'print_hourscomplete
        '
        Me.print_hourscomplete.Location = New System.Drawing.Point(734, 10)
        Me.print_hourscomplete.MinimumSize = New System.Drawing.Size(0, 24)
        Me.print_hourscomplete.Name = "print_hourscomplete"
        Me.print_hourscomplete.Size = New System.Drawing.Size(63, 24)
        Me.print_hourscomplete.TabIndex = 10
        Me.print_hourscomplete.Text = "450"
        Me.print_hourscomplete.ThemeName = "VisualStudio2012Dark"
        '
        'print_totalhours
        '
        Me.print_totalhours.Location = New System.Drawing.Point(875, 12)
        Me.print_totalhours.MinimumSize = New System.Drawing.Size(0, 24)
        Me.print_totalhours.Name = "print_totalhours"
        Me.print_totalhours.Size = New System.Drawing.Size(63, 24)
        Me.print_totalhours.TabIndex = 11
        Me.print_totalhours.Text = "450"
        Me.print_totalhours.ThemeName = "VisualStudio2012Dark"
        '
        'PrintingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 595)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.Name = "PrintingForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintingForm"
        Me.ThemeName = "VisualStudio2012Dark"
        CType(Me.ropa_recordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.print_stud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.print_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.print_hourscomplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.print_totalhours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ropa_recordsBindingSource As BindingSource
    Friend WithEvents ROPARecxsd As MyDiary.DataSet1
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents print_date As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents print_stud As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents print_totalhours As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents print_hourscomplete As Telerik.WinControls.UI.RadTextBox
End Class

