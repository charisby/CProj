Imports System.Data.SqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim USERNAME As String = TextBox1.Text
        Dim PASSWORD As String = TextBox2.Text

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please enter the required fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USERTYPE FROM UserTable WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD"
            Using con As SqlConnection = New SqlConnection("Data Source=CHARSI;Initial Catalog=RecordDB;Integrated Security=True;Pooling=False")
                Using cmd As SqlCommand = New SqlCommand(LogQuery, con)

                    cmd.Parameters.AddWithValue("@USERNAME", USERNAME)
                    cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD)

                    Dim da As New SqlDataAdapter(cmd)
                    Dim myTable As New DataTable

                    con.Open()
                    da.Fill(myTable)
                    If myTable.Rows.Count > 0 Then
                        Dim message As String = "Access Granted"
                        Dim caption As String = "Success"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        If myTable.Rows(0)("USERTYPE") = "Admin" Then
                            Dim AdminDboard As New AdminDashboard
                            AdminDashboard.AdminDboard = TextBox1.Text
                            Me.Hide()
                            AdminDashboard.Show()

                        ElseIf myTable.Rows(0)("USERTYPE") = "Employee" Then
                            Dim EmpDashboard As New EmployeeDashboard
                            EmployeeDashboard.EmpDashboard = TextBox1.Text
                            Me.Hide()
                            EmployeeDashboard.Show()

                        ElseIf myTable.Rows(0)("USERTYPE") = "Intern" Then
                            Dim IntDashboard As New InternDashboard
                            InternDashboard.IntDashboard = TextBox1.Text
                            Me.Hide()
                            InternDashboard.Show()
                        End If
                        TextBox1.Clear()
                        TextBox2.Clear()
                    Else
                        MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    con.Close()
                End Using
            End Using
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim message As String = "Are you sure you want to exit?"
        Dim caption As String = "EXIT"
        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        ElseIf (result = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
