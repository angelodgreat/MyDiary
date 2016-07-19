Imports Telerik.WinControls

Imports MySql.Data.MySqlClient
Public Class Home

    Dim ds As New DataSet
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim svYN As DialogResult
    Dim addYN As DialogResult
    Dim editYN As DialogResult
    Dim cancelYN As DialogResult
    Dim updateYN As DialogResult
    Dim deleteYN As DialogResult
    Dim doneYN As DialogResult


    Dim Dates As Date
    Dim activities As String
    Dim hours As String

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_usernaaaaa.Text = studno
        RadPageView1.SelectedPage = rpv_home
        account_grid()
        load_table_home()
        load_table_ROPA()
        load_table_accounts()
        rec_date.Value = DateTime.Now
    End Sub

    'subs for ROPA Grids


    Public Sub account_grid()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        Try
            MysqlConn.Open()
            Dim query As String
            query = "Select studno as 'Student Number',fname as 'First Name',lname as 'Last Name',email as 'Email',mobilenumber as 'Mobile Number',address as 'Address',username as 'Username' from accounts"

            COMMAND = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = COMMAND
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            rgv_accounts.DataSource = bsource
            rgv_accounts.ReadOnly = True
            sda.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Public Sub load_table_home()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If
        Try
            MysqlConn.Open()
            Dim query As String
            query = "Select DATE_FORMAT(date,'%M %d %Y') as 'Date', activities as 'Activities Conducted',hours as 'Number of Hours' from ropa_records where studno='" & lbl_usernaaaaa.Text & "'"

            COMMAND = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = COMMAND
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            rgv_home.DataSource = bsource
            rgv_home.ReadOnly = True
            sda.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Public Sub load_table_ROPA()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = "SELECT DATE_FORMAT(date,'%M %d %Y') as 'Date', activities as 'Activities Conducted',hours as 'Number of Hours' from ropa_records where studno='" & lbl_usernaaaaa.Text & "'"

            COMMAND = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = COMMAND
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            rgv_ropa.DataSource = bsource
            rgv_ropa.ReadOnly = True
            sda.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub




    Private Sub rgv_ropa_CellDoubleClick(sender As Object, e As UI.GridViewCellEventArgs) Handles rgv_ropa.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As Telerik.WinControls.UI.GridViewRowInfo

            row = Me.rgv_ropa.Rows(e.RowIndex)

            rec_date.Text = row.Cells("Date").Value.ToString
            rec_activities.Text = row.Cells("Activities Conducted").Value.ToString
            rec_hours.Text = row.Cells("Number of Hours").Value.ToString

        End If
    End Sub

    'ROPA Management
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        Dim READER As MySqlDataReader
        addYN = RadMessageBox.Show(Me, "Are you sure you want to save this record?", "ROPA Management", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        If addYN = MsgBoxResult.Yes Then
            If (rec_activities.Text = "") Or (rec_hours.Text = "") Then
                RadMessageBox.Show(Me, "Please complete the form", "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
            Else
                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "INSERT INTO ropa_records (date,activities,hours,studno) VALUES ('" & Format(CDate(rec_date.Value), "yyyy-MM-dd") & "','" & rec_activities.Text & "','" & rec_hours.Text & "','" & lbl_usernaaaaa.Text & "')  "
                    COMMAND = New MySqlCommand(query, MysqlConn)
                    READER = COMMAND.ExecuteReader

                    RadMessageBox.Show(Me, "ROPA Saved!", "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Info)
                    MysqlConn.Close()

                Catch ex As Exception
                    RadMessageBox.Show(Me, ex.Message, "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
                Finally
                    MysqlConn.Dispose()

                End Try
            End If

        End If

        load_table_ROPA()
        load_table_home()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        updateYN = RadMessageBox.Show(Me, "Do you want to update this selected ROPA?", "ROPA Management", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        If updateYN = MsgBoxResult.Yes Then
            If (rec_activities.Text = "") Or (rec_hours.Text = "") Then
                RadMessageBox.Show(Me, "Please complete the fields", "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
            Else
                Try
                    MysqlConn.Open()
                    Dim QUERY As String
                    QUERY = "UPDATE ropa_records SET date='" & Format(CDate(rec_date.Value), "yyyy-MM-dd") & "',activities='" & rec_activities.Text & "',hours='" & rec_hours.Text & "'"
                    COMMAND = New MySqlCommand(QUERY, MysqlConn)
                    reader = COMMAND.ExecuteReader
                    RadMessageBox.Show(Me, "ROPA Updated!", "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Info)
                    MysqlConn.Close()
                Catch ex As Exception
                    RadMessageBox.Show(Me, ex.Message, "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
                Finally
                    MysqlConn.Dispose()
                End Try
            End If
        End If
        load_table_home()
        load_table_ROPA()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        deleteYN = RadMessageBox.Show(Me, "Are you sure you want to delete?", "ROPA Management", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        If deleteYN = MsgBoxResult.Yes Then
            Try
                MysqlConn.Open()
                Dim QUERY As String
                QUERY = "DELETE from ropa_records WHERE date='" & Format(CDate(rec_date.Value), "yyyy-MM-dd") & "'"
                COMMAND = New MySqlCommand(QUERY, MysqlConn)
                reader = COMMAND.ExecuteReader

                rec_date.Text = ""
                rec_activities.Text = ""
                rec_hours.Text = ""

                RadMessageBox.Show(Me, "ROPA Deleted!", "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Info)

            Catch ex As Exception
                RadMessageBox.Show(Me, ex.Message, "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
            Finally
                MysqlConn.Dispose()
            End Try
        End If
        load_table_home()
        load_table_ROPA()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        rec_date.Value = DateTime.Now
        rec_activities.Text = ""
        rec_hours.Text = ""
    End Sub
    'Account Management
    Public Sub load_table_accounts()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = "SELECT studno as 'Student Number', fname as 'First Name', lname as 'Last Name',email as 'Email',mobilenumber as 'Mobile Number',address as 'Address',username as 'Username' from accounts "

            COMMAND = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = COMMAND
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            rgv_accounts.DataSource = bsource
            rgv_accounts.ReadOnly = True
            sda.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "ROPA Account Management", MessageBoxButtons.OK, RadMessageIcon.Error)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub



    Private Sub btn_accreg_Click(sender As Object, e As EventArgs) Handles btn_accreg.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        Dim READER As MySqlDataReader
        addYN = RadMessageBox.Show(Me, "Are you sure you want to add this user?", "ROPA Account Management", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        If addYN = MsgBoxResult.Yes Then

            If (reg_fname.Text = "") Or (reg_lname.Text = "") Or (reg_email.Text = "") Or (reg_address.Text = "") Or (reg_mobile.Text = "") Or (reg_sn.Text = "") Or (reg_password.Text = "") Or (reg_retypepassword.Text = "") Then
                RadMessageBox.Show(Me, "Please fill all fields", "ROPA Account Management", MessageBoxButtons.OK, RadMessageIcon.Error)
            ElseIf (reg_password.Text <> reg_retypepassword.Text) Then
                RadMessageBox.Show(Me, "Password doesn't match", "ROPA Account Management", MessageBoxButtons.OK, RadMessageIcon.Error)
            Else
                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "INSERT INTO accounts(studno,fname,lname,email,mobilenumber,address,username,password)VALUES('" & reg_sn.Text & "','" & reg_fname.Text & "','" & reg_lname.Text & "',
                        '" & reg_email.Text & "','" & reg_mobile.Text & "','" & reg_address.Text & "','" & reg_username.Text & "','" & reg_password.Text & "')"
                    COMMAND = New MySqlCommand(query, MysqlConn)
                    READER = COMMAND.ExecuteReader

                    RadMessageBox.Show(Me, "Account Saved!", "ROPA Account Management", MessageBoxButtons.OK, RadMessageIcon.Info)
                    MysqlConn.Close()

                Catch ex As Exception
                    RadMessageBox.Show(Me, ex.Message, "ROPA Account Management", MessageBoxButtons.OK, RadMessageIcon.Error)
                Finally
                    MysqlConn.Dispose()

                End Try

            End If

        End If
        account_grid()
        clearfieldaccounts()
    End Sub

    Private Sub btn_accupdate_Click(sender As Object, e As EventArgs) Handles btn_accupdate.Click
        account_grid()
    End Sub

    Private Sub btn_accdel_Click(sender As Object, e As EventArgs) Handles btn_accdel.Click
        account_grid()
        clearfieldaccounts()
    End Sub

    Private Sub btn_accclear_Click(sender As Object, e As EventArgs) Handles btn_accclear.Click
        clearfieldaccounts()

    End Sub

    Public Sub clearfieldaccounts()
        reg_address.Text = ""
        reg_email.Text = ""
        reg_fname.Text = ""
        reg_lname.Text = ""
        reg_mobile.Text = ""
        reg_password.Text = ""
        reg_retypepassword.Text = ""
        reg_sn.Text = ""
        reg_username.Text = ""
    End Sub
    Private Sub rgv_accounts_CellDoubleClick(sender As Object, e As UI.GridViewCellEventArgs) Handles rgv_accounts.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As Telerik.WinControls.UI.GridViewRowInfo

            row = Me.rgv_accounts.Rows(e.RowIndex)

            reg_address.Text = row.Cells("Address").Value.ToString
            reg_email.Text = row.Cells("Email").Value.ToString
            reg_fname.Text = row.Cells("First Name").Value.ToString
            reg_lname.Text = row.Cells("Last Name").Value.ToString
            reg_mobile.Text = row.Cells("Mobile Number").Value.ToString
            reg_sn.Text = row.Cells("Student Number").Value.ToString
            reg_username.Text = row.Cells("Username").Value.ToString


        End If
    End Sub

    Private Sub btn_home_print_Click(sender As Object, e As EventArgs) Handles btn_home_print.Click
        PrintingForm.Show()
    End Sub

    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub


End Class
