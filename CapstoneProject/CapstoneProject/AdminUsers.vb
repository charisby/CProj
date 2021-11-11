Imports System.Data.SqlClient

Public Class AdminUsers
    Private Sub AdminUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecordDBDataSet1.UserTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.RecordDBDataSet1.UserTable)

        Dim query As String = "SELECT * FROM UserTable"
        Using con As SqlConnection = New SqlConnection("Data Source=CHARSI;Initial Catalog=RecordDB;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using sda As New SqlDataAdapter()
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        con.Open()
                        sda.Fill(dt)
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Public Sub BindData()
        Dim query As String = "SELECT * FROM UserTable"
        Using conn As SqlConnection = New SqlConnection("Data Source=CHARSI;Initial Catalog=RecordDB;Integrated Security=True;")
            Using resultcmd As SqlCommand = New SqlCommand(query, conn)
                Using sda As SqlDataAdapter = New SqlDataAdapter()
                    sda.SelectCommand = resultcmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Dim USERNAME As String = TBusername.Text
        Dim PASSWORD As String = TBpassword.Text
        Dim USERTYPE As String = cmbusertype.Text
        Dim USTATUS As String = cmbstat.Text
        Dim FIRSTNAME As String = TBfn.Text
        Dim MIDDLENAME As String = TBmiddle.Text
        Dim LASTNAME As String = TBln.Text
        Dim CONTACTNUM As String = TBcontact.Text
        Dim EMAIL As String = TBemail.Text
        Dim BIRTHDAY As String = TBbirthday.Text
        Dim ADDRESS As String = TBadd.Text
        Dim SEX As String = cmbSex.Text
        Dim CIVILSTATUS As String = cmbCstatus.Text

        If TBusername.Text = "" Or TBpassword.Text = "" Or cmbusertype.Text = "" Then
            MessageBox.Show("Please enter the missing field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim query As String = "SELECT * FROM UserTable WHERE [USERNAME]=@USERNAME OR [PASSWORD]=@PASSWORD"
                Using con As SqlConnection = New SqlConnection("Data Source=CHARSI;Initial Catalog=RecordDB;Integrated Security=True;Pooling=False")

                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@USERNAME", USERNAME)
                        cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD)
                        cmd.Parameters.AddWithValue("@USERTYPE", USERTYPE)
                        cmd.Parameters.AddWithValue("@USTATUS", USTATUS)
                        cmd.Parameters.AddWithValue("@FIRSTNAME", FIRSTNAME)
                        cmd.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME)
                        cmd.Parameters.AddWithValue("@LASTNAME", LASTNAME)
                        cmd.Parameters.AddWithValue("@CONTACTNUM", CONTACTNUM)
                        cmd.Parameters.AddWithValue("@EMAIL", EMAIL)
                        cmd.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAY)
                        cmd.Parameters.AddWithValue("@ADDRESS", ADDRESS)
                        cmd.Parameters.AddWithValue("@SEX", SEX)
                        cmd.Parameters.AddWithValue("@CIVILSTATUS", CIVILSTATUS)

                        Using da As New SqlDataAdapter(cmd)
                            Using dt As New DataTable()
                                da.Fill(dt)
                                If dt.Rows.Count > 0 Then
                                    MessageBox.Show("Username or password is already in use. Please try again", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                                Else

                                    Dim addquery As String = "INSERT INTO UserTable([USERNAME],[PASSWORD],[USERTYPE],[USTATUS],[FIRSTNAME],[MIDDLENAME],[LASTNAME],[CONTACTNUM],[EMAIL],[BIRTHDAY],[ADDRESS],[SEX],[CIVILSTATUS])VALUES(@USERNAME,@PASSWORD,@USERTYPE,@USTATUS,@FIRSTNAME, @MIDDLENAME, @LASTNAME, @CONTACTNUM,  @EMAIL, @BIRTHDAY, @ADDRESS, @SEX, @CIVILSTATUS)"
                                    Dim com = New SqlCommand(addquery, con)

                                    com.Parameters.AddWithValue("@USERNAME", USERNAME)
                                    com.Parameters.AddWithValue("@PASSWORD", PASSWORD)
                                    com.Parameters.AddWithValue("@USERTYPE", USERTYPE)
                                    com.Parameters.AddWithValue("@USTATUS", USTATUS)
                                    com.Parameters.AddWithValue("@FIRSTNAME", FIRSTNAME)
                                    com.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME)
                                    com.Parameters.AddWithValue("@LASTNAME", LASTNAME)
                                    com.Parameters.AddWithValue("@CONTACTNUM", CONTACTNUM)
                                    com.Parameters.AddWithValue("@EMAIL", EMAIL)
                                    com.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAY)
                                    com.Parameters.AddWithValue("@ADDRESS", ADDRESS)
                                    com.Parameters.AddWithValue("@SEX", SEX)
                                    com.Parameters.AddWithValue("@CIVILSTATUS", CIVILSTATUS)

                                    Dim x As Integer = 0
                                    Try
                                        con.Open()
                                        x = com.ExecuteNonQuery()
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message)
                                    Finally
                                        con.Close()
                                        cmd.Parameters.Clear()
                                    End Try
                                    Select Case x
                                        Case 1
                                            MessageBox.Show("Data saved Successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            BindData()
                                        Case 0
                                            MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Select
                                End If
                            End Using
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PBsearch_Click(sender As Object, e As EventArgs) Handles PBsearch.Click
        Dim query As String = "SELECT * FROM UserTable WHERE USERNAME ='" & TextBox3.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=CHARSI;Initial Catalog=RecordDB;Integrated Security=True;Pooling=False")
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            TBusername.Text = dt.Rows(0)(0).ToString()
                            TBpassword.Text = dt.Rows(0)(1).ToString()
                            cmbusertype.Text = dt.Rows(0)(2).ToString()
                            cmbstat.Text = dt.Rows(0)(3).ToString()
                            TBfn.Text = dt.Rows(0)(4).ToString()
                            TBmiddle.Text = dt.Rows(0)(5).ToString()
                            TBln.Text = dt.Rows(0)(6).ToString()
                            TBcontact.Text = dt.Rows(0)(7).ToString()
                            TBemail.Text = dt.Rows(0)(8).ToString()
                            TBbirthday.Text = dt.Rows(0)(9).ToString()
                            TBadd.Text = dt.Rows(0)(10).ToString()
                            cmbSex.Text = dt.Rows(0)(11).ToString()
                            cmbCstatus.Text = dt.Rows(0)(12).ToString()

                            con.Close()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub LblUpdate_Click(sender As Object, e As EventArgs) Handles LblUpdate.Click
        Dim USERNAME As String = TBusername.Text
        Dim PASSWORD As String = TBpassword.Text
        Dim USERTYPE As String = cmbusertype.Text
        Dim USTATUS As String = cmbstat.Text
        Dim FIRSTNAME As String = TBfn.Text
        Dim MIDDLENAME As String = TBmiddle.Text
        Dim LASTNAME As String = TBln.Text
        Dim CONTACTNUM As String = TBcontact.Text
        Dim EMAIL As String = TBemail.Text
        Dim BIRTHDAY As String = TBbirthday.Text
        Dim ADDRESS As String = TBadd.Text
        Dim SEX As String = cmbSex.Text
        Dim CIVILSTATUS As String = cmbCstatus.Text

        If TBusername.Text = Nothing Or TBpassword.Text = Nothing Then
            MessageBox.Show("Please enter the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using updatecon As SqlConnection = New SqlConnection("Data Source=CHARSI;Initial Catalog=RecordDB;Integrated Security=True;Pooling=False")
                    Dim updatequery As String = "UPDATE UserTable SET PASSWORD=@PASSWORD, USERTYPE=@USERTYPE, USTATUS=@USTATUS, FIRSTNAME=@FIRSTNAME, MIDDLENAME=@MIDDLENAME,LASTNAME=@LASTNAME,CONTACTNUM=@CONTACTNUM,EMAIL=@EMAIL,BIRTHDAY=@BIRTHDAY,ADDRESS=@ADDRESS, SEX=@SEX, CIVILSTATUS=@CIVILSTATUS WHERE USERNAME=@USERNAME"
                    Using cmdupdate As New SqlCommand(updatequery, updatecon)
                        cmdupdate.Parameters.AddWithValue("@USERNAME", USERNAME)
                        cmdupdate.Parameters.AddWithValue("@PASSWORD", PASSWORD)
                        cmdupdate.Parameters.AddWithValue("@USERTYPE", USERTYPE)
                        cmdupdate.Parameters.AddWithValue("@USTATUS", USTATUS)
                        cmdupdate.Parameters.AddWithValue("@FIRSTNAME", FIRSTNAME)
                        cmdupdate.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME)
                        cmdupdate.Parameters.AddWithValue("@LASTNAME", LASTNAME)
                        cmdupdate.Parameters.AddWithValue("@CONTACTNUM", CONTACTNUM)
                        cmdupdate.Parameters.AddWithValue("@EMAIL", EMAIL)
                        cmdupdate.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAY)
                        cmdupdate.Parameters.AddWithValue("@ADDRESS", ADDRESS)
                        cmdupdate.Parameters.AddWithValue("@SEX", SEX)
                        cmdupdate.Parameters.AddWithValue("@CIVILSTATUS", CIVILSTATUS)

                        updatecon.Open()
                        cmdupdate.ExecuteNonQuery()
                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        updatecon.Close()
                        BindData()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LblDelete_Click(sender As Object, e As EventArgs) Handles LblDelete.Click
        If TextBox3.Text = "" Then
            MessageBox.Show("Please select Username to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim USERNAME As String = TextBox3.Text
                Dim query As String = "DELETE FROM UserTable WHERE USERNAME=@USERNAME"
                Using con As SqlConnection = New SqlConnection("Data Source=CHARSI;Initial Catalog=RecordDB;Integrated Security=True;Pooling=False")
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@USERNAME", USERNAME)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Are you sure you want to delete this User?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        TBusername.Text = ""
                        TBpassword.Text = ""
                        TextBox3.Text = ""
                        con.Close()
                        BindData()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        TBusername.Clear()
        TBpassword.Clear()
        cmbusertype.Text = ""
        cmbstat.Text = ""
        TBfn.Clear()
        TBmiddle.Clear()
        TBln.Clear()
        TBcontact.Clear()
        TBemail.Clear()
        TBbirthday.Clear()
        TBadd.Clear()
        cmbSex.Text = ""
        cmbCstatus.Text = ""
    End Sub
End Class