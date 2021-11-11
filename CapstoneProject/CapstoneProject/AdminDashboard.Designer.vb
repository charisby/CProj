<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnUsers = New System.Windows.Forms.Button()
        Me.BtnInterns = New System.Windows.Forms.Button()
        Me.BtnEmployee = New System.Windows.Forms.Button()
        Me.BtnOut = New System.Windows.Forms.Button()
        Me.TimeBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlPager = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlPager.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(567, 682)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 20)
        Me.Label6.TabIndex = 301
        Me.Label6.Text = "citytourismoffice.csrl@gmail.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(586, 662)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 20)
        Me.Label5.TabIndex = 300
        Me.Label5.Text = "(049) 530-0015 local 5308"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(413, 642)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(567, 20)
        Me.Label4.TabIndex = 299
        Me.Label4.Text = "GF Gusaling Museo, F. Gomez St. Brgy. Kanluran, City of Santa Rosa, Laguna "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.BtnUsers)
        Me.Panel2.Controls.Add(Me.BtnInterns)
        Me.Panel2.Controls.Add(Me.BtnEmployee)
        Me.Panel2.Controls.Add(Me.BtnOut)
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(212, 692)
        Me.Panel2.TabIndex = 298
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CapstoneProject.My.Resources.Resources.CITY_LOGO_VECTOR
        Me.PictureBox1.Location = New System.Drawing.Point(23, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 287
        Me.PictureBox1.TabStop = False
        '
        'BtnUsers
        '
        Me.BtnUsers.BackColor = System.Drawing.Color.Silver
        Me.BtnUsers.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsers.Location = New System.Drawing.Point(0, 224)
        Me.BtnUsers.Name = "BtnUsers"
        Me.BtnUsers.Size = New System.Drawing.Size(213, 44)
        Me.BtnUsers.TabIndex = 287
        Me.BtnUsers.Text = "USERS"
        Me.BtnUsers.UseVisualStyleBackColor = False
        '
        'BtnInterns
        '
        Me.BtnInterns.BackColor = System.Drawing.Color.Silver
        Me.BtnInterns.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInterns.Location = New System.Drawing.Point(0, 366)
        Me.BtnInterns.Name = "BtnInterns"
        Me.BtnInterns.Size = New System.Drawing.Size(212, 44)
        Me.BtnInterns.TabIndex = 285
        Me.BtnInterns.Text = "INTERNS"
        Me.BtnInterns.UseVisualStyleBackColor = False
        '
        'BtnEmployee
        '
        Me.BtnEmployee.BackColor = System.Drawing.Color.Silver
        Me.BtnEmployee.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmployee.Location = New System.Drawing.Point(0, 294)
        Me.BtnEmployee.Name = "BtnEmployee"
        Me.BtnEmployee.Size = New System.Drawing.Size(213, 44)
        Me.BtnEmployee.TabIndex = 284
        Me.BtnEmployee.Text = "EMPLOYEES"
        Me.BtnEmployee.UseVisualStyleBackColor = False
        '
        'BtnOut
        '
        Me.BtnOut.BackColor = System.Drawing.Color.Silver
        Me.BtnOut.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOut.Location = New System.Drawing.Point(0, 434)
        Me.BtnOut.Name = "BtnOut"
        Me.BtnOut.Size = New System.Drawing.Size(213, 44)
        Me.BtnOut.TabIndex = 286
        Me.BtnOut.Text = "LOGOUT"
        Me.BtnOut.UseVisualStyleBackColor = False
        '
        'TimeBtn
        '
        Me.TimeBtn.BackColor = System.Drawing.Color.HotPink
        Me.TimeBtn.FlatAppearance.BorderSize = 0
        Me.TimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimeBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeBtn.ForeColor = System.Drawing.Color.Black
        Me.TimeBtn.Location = New System.Drawing.Point(880, 2)
        Me.TimeBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TimeBtn.Name = "TimeBtn"
        Me.TimeBtn.Size = New System.Drawing.Size(295, 46)
        Me.TimeBtn.TabIndex = 279
        Me.TimeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TimeBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(533, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 31)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "ADMIN DASHBOARD"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1175, 62)
        Me.Panel1.TabIndex = 296
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(106, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Logged: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlPager
        '
        Me.pnlPager.BackColor = System.Drawing.Color.HotPink
        Me.pnlPager.Controls.Add(Me.Label1)
        Me.pnlPager.Controls.Add(Me.Label2)
        Me.pnlPager.Controls.Add(Me.TimeBtn)
        Me.pnlPager.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPager.Location = New System.Drawing.Point(0, 707)
        Me.pnlPager.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlPager.Name = "pnlPager"
        Me.pnlPager.Size = New System.Drawing.Size(1175, 48)
        Me.pnlPager.TabIndex = 297
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CapstoneProject.My.Resources.Resources.City_Tourism_logo_COLORED
        Me.PictureBox3.Location = New System.Drawing.Point(520, 202)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(319, 308)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 302
        Me.PictureBox3.TabStop = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1175, 755)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlPager)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1197, 811)
        Me.MinimizeBox = False
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlPager.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnUsers As Button
    Friend WithEvents BtnInterns As Button
    Friend WithEvents BtnEmployee As Button
    Friend WithEvents BtnOut As Button
    Friend WithEvents TimeBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlPager As Panel
    Friend WithEvents Timer1 As Timer
End Class
