Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports Telerik.WinControls.UI

Public Class PrintingForm


    Private Sub PrintingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_printuser.Text = studno
        printreport()

        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub printreport()
        Dim signdate As New ReportParameter("SigningDate", print_date.Text)
        Dim hourscompleted As New ReportParameter("HoursComplete", print_hourscomplete.Text)
        Dim studname As New ReportParameter("Name", print_stud.Text)
        Dim totalhours As New ReportParameter("TotalHours", print_totalhours.Text)

        MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = connstring

        Dim SDA As New MySqlDataAdapter
        Dim ds As New DataSet1
        Dim home As New Home

        SDA.SelectCommand = New MySqlCommand("Select DATE_FORMAT(date,'%M %d %Y') as 'Date', activities,hours from ropa_records where studno='" & lbl_printuser.Text & "' ", MySQLConn)
        SDA.Fill(ds.Tables(0))

        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report2.rdlc"
        ReportViewer1.LocalReport.SetParameters(signdate)
        ReportViewer1.LocalReport.SetParameters(hourscompleted)
        ReportViewer1.LocalReport.SetParameters(studname)
        ReportViewer1.LocalReport.SetParameters(totalhours)
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub print_date_ValueChanged(sender As Object, e As EventArgs) Handles print_date.ValueChanged
        printreport()
    End Sub

    Private Sub print_hourscomplete_TextChanged(sender As Object, e As EventArgs) Handles print_hourscomplete.TextChanged
        printreport()
    End Sub

    Private Sub print_stud_TextChanged(sender As Object, e As EventArgs) Handles print_stud.TextChanged
        printreport()
    End Sub

    Private Sub print_totalhours_TextChanged(sender As Object, e As EventArgs) Handles print_totalhours.TextChanged
        printreport()
    End Sub
End Class
