Imports Telerik.WinControls
Imports MySql.Data.MySqlClient
Public Class Login

    Dim a As Boolean
    Dim mysqlconn As MySqlConnection
    Dim Command As MySqlCommand
    Dim home2 As New Home
    Dim printform As New PrintingForm

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = New Boolean
        a = False
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = connstring

        Try
            If mysqlconn.State = ConnectionState.Open Then
                mysqlconn.Close()
            End If
            mysqlconn.Open()
            a = True
            mysqlconn.Close()

        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "Ropa Management", MessageBoxButtons.OK, RadMessageIcon.Info)
        Finally
            mysqlconn.Dispose()
            If a = True Then
                lbl_status.Text = "Online"
                lbl_status.ForeColor = Color.Green
            Else
                lbl_status.Text = "Offline"
                lbl_status.ForeColor = Color.Red
            End If
        End Try

        ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark"
    End Sub

    Private Sub btn_login_Click_1(sender As Object, e As EventArgs) Handles btn_login.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = connstring



        Try
            If mysqlconn.State = ConnectionState.Open Then
                mysqlconn.Close()
            End If

            Command = New MySqlCommand
            Dim reader As MySqlDataReader
            Dim attempt As Integer

            If attempt < 3 Then
                Try
                    mysqlconn.Open()
                    Dim query As String
                    query = "SELECT * FROM accounts where username='" & tb_username.Text & "'and password='" & tb_password.Text & "'or studno='" & tb_username.Text & "'"
                    Command = New MySqlCommand(query, mysqlconn)
                    reader = Command.ExecuteReader

                    Dim count As Integer
                    count = 0
                    While reader.Read
                        count = count + 1
                        activeuserfname = reader.GetString("fname")
                        activeuserlname = reader.GetString("lname")
                        studno = reader.GetString("studno")
                    End While

                    If count >= 1 Then
                        RadMessageBox.Show(Me, "Welcome " & activeuserfname & " " & activeuserlname & "!", "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Info)

                        home2.lbl_accountmodifier.Text = "Welcome " & reader.GetString("fname") + " " + reader.GetString("lname")

                        home2.Show()
                        Me.Hide()



                    Else
                        RadMessageBox.Show(Me, "Invalid Username/Password", "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
                        tb_username.Text = ""
                        tb_password.Text = ""


                    End If



                Catch ex As Exception
                    RadMessageBox.Show(Me, ex.Message, "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
                Finally
                    mysqlconn.Dispose()
                End Try
            End If
        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
        Finally
            mysqlconn.Dispose()
        End Try

    End Sub


End Class
