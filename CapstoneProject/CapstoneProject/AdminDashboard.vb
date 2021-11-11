Imports System.Data.SqlClient
Public Class AdminDashboard
    Shared Property AdminDboard As String
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label1.Text = AdminDboard

        Dim NAMEquery As String = "SELECT * FROM UserTable"
        Using NAMEcon As SqlConnection = New SqlConnection("Data Source= CHARSI;Initial Catalog=RecordDB;Integrated Security=True;Pooling=False")
            Using NAMEcmd As SqlCommand = New SqlCommand(NAMEquery, NAMEcon)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = NAMEcmd
                    Using dt As New DataTable()
                        NAMEcon.Open()
                        da.Fill(dt)
                    End Using
                    NAMEcon.Close()
                End Using
            End Using
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeBtn.Text = DateAndTime.Now
    End Sub

    Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles BtnUsers.Click
        AdminUsers.Show()
    End Sub

    Private Sub BtnEmployee_Click(sender As Object, e As EventArgs) Handles BtnEmployee.Click
        'EmployeeForm.Show()
    End Sub

    Private Sub BtnOut_Click(sender As Object, e As EventArgs) Handles BtnOut.Click
        Me.Close()
        Login.Show()
    End Sub
End Class