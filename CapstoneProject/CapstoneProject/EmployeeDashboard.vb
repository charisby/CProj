Imports System.Data.SqlClient

Public Class EmployeeDashboard
    Shared Property EmpDashboard As String
    Private Sub EmployeeDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        Label2.Text = EmpDashboard

        Dim NAMEquery As String = "SELECT * FROM UserTable WHERE USERNAME='" & Label2.Text & "'"
        Using NAMEcon As SqlConnection = New SqlConnection("Data Source=CHARSI;Initial Catalog=RecordDB;Integrated Security=True;Pooling=False")
            Using NAMEcmd As SqlCommand = New SqlCommand(NAMEquery, NAMEcon)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = NAMEcmd
                    Using dt As New DataTable()
                        NAMEcon.Open()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Label6.Text = dt.Rows(0)(4).ToString & " " & dt.Rows(0)(6).ToString()
                        Else
                            Label6.Text = ""
                        End If
                    End Using
                    NAMEcon.Close()
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindData()
        Dim query As String = "SELECT * FROM UserTable WHERE USERNAME='" & Label2.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=CHARSI;Initial Catalog=RecordDB;Integrated Security=True;Pooling=False")
            Using resultcmd As SqlCommand = New SqlCommand(query, con)
                Using sda As SqlDataAdapter = New SqlDataAdapter()
                    sda.SelectCommand = resultcmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        '  DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeBtn.Text = DateAndTime.Now
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        Login.Show()
    End Sub
End Class