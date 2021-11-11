<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDashboard
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnTimeOut = New System.Windows.Forms.Button()
        Me.BtnSetting = New System.Windows.Forms.Button()
        Me.INbtnPM = New System.Windows.Forms.Button()
        Me.BtnAttendance = New System.Windows.Forms.Button()
        Me.BtnProfile = New System.Windows.Forms.Button()
        Me.INbtnAM = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimeBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlPager = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.pnlPager.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(595, 715)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 20)
        Me.Label1.TabIndex = 296
        Me.Label1.Text = "citytourismoffice.csrl@gmail.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(614, 695)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 20)
        Me.Label5.TabIndex = 295
        Me.Label5.Text = "(049) 530-0015 local 5308"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.BtnTimeOut)
        Me.Panel1.Controls.Add(Me.BtnSetting)
        Me.Panel1.Controls.Add(Me.INbtnPM)
        Me.Panel1.Controls.Add(Me.BtnAttendance)
        Me.Panel1.Controls.Add(Me.BtnProfile)
        Me.Panel1.Controls.Add(Me.INbtnAM)
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 692)
        Me.Panel1.TabIndex = 293
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Silver
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(0, 546)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(212, 44)
        Me.BtnLogout.TabIndex = 273
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnTimeOut
        '
        Me.BtnTimeOut.BackColor = System.Drawing.Color.Silver
        Me.BtnTimeOut.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTimeOut.Location = New System.Drawing.Point(0, 233)
        Me.BtnTimeOut.Name = "BtnTimeOut"
        Me.BtnTimeOut.Size = New System.Drawing.Size(212, 44)
        Me.BtnTimeOut.TabIndex = 281
        Me.BtnTimeOut.Text = "TIME OUT"
        Me.BtnTimeOut.UseVisualStyleBackColor = False
        '
        'BtnSetting
        '
        Me.BtnSetting.BackColor = System.Drawing.Color.Silver
        Me.BtnSetting.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetting.Location = New System.Drawing.Point(0, 482)
        Me.BtnSetting.Name = "BtnSetting"
        Me.BtnSetting.Size = New System.Drawing.Size(212, 44)
        Me.BtnSetting.TabIndex = 272
        Me.BtnSetting.Text = "SETTING"
        Me.BtnSetting.UseVisualStyleBackColor = False
        '
        'INbtnPM
        '
        Me.INbtnPM.BackColor = System.Drawing.Color.Silver
        Me.INbtnPM.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INbtnPM.Location = New System.Drawing.Point(0, 170)
        Me.INbtnPM.Name = "INbtnPM"
        Me.INbtnPM.Size = New System.Drawing.Size(212, 44)
        Me.INbtnPM.TabIndex = 280
        Me.INbtnPM.Text = "TIME IN (PM)"
        Me.INbtnPM.UseVisualStyleBackColor = False
        '
        'BtnAttendance
        '
        Me.BtnAttendance.BackColor = System.Drawing.Color.Silver
        Me.BtnAttendance.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAttendance.Location = New System.Drawing.Point(0, 360)
        Me.BtnAttendance.Name = "BtnAttendance"
        Me.BtnAttendance.Size = New System.Drawing.Size(212, 44)
        Me.BtnAttendance.TabIndex = 274
        Me.BtnAttendance.Text = "ATTENDANCE"
        Me.BtnAttendance.UseVisualStyleBackColor = False
        '
        'BtnProfile
        '
        Me.BtnProfile.BackColor = System.Drawing.Color.Silver
        Me.BtnProfile.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProfile.Location = New System.Drawing.Point(0, 420)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.Size = New System.Drawing.Size(212, 44)
        Me.BtnProfile.TabIndex = 271
        Me.BtnProfile.Text = "PROFILE"
        Me.BtnProfile.UseVisualStyleBackColor = False
        '
        'INbtnAM
        '
        Me.INbtnAM.BackColor = System.Drawing.Color.Silver
        Me.INbtnAM.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INbtnAM.Location = New System.Drawing.Point(0, 105)
        Me.INbtnAM.Name = "INbtnAM"
        Me.INbtnAM.Size = New System.Drawing.Size(212, 44)
        Me.INbtnAM.TabIndex = 279
        Me.INbtnAM.Text = "TIME IN (AM)"
        Me.INbtnAM.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(408, 673)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(567, 20)
        Me.Label4.TabIndex = 294
        Me.Label4.Text = "GF Gusaling Museo, F. Gomez St. Brgy. Kanluran, City of Santa Rosa, Laguna "
        '
        'TimeBtn
        '
        Me.TimeBtn.BackColor = System.Drawing.Color.HotPink
        Me.TimeBtn.FlatAppearance.BorderSize = 0
        Me.TimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimeBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeBtn.ForeColor = System.Drawing.Color.Black
        Me.TimeBtn.Location = New System.Drawing.Point(917, 0)
        Me.TimeBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TimeBtn.Name = "TimeBtn"
        Me.TimeBtn.Size = New System.Drawing.Size(258, 48)
        Me.TimeBtn.TabIndex = 279
        Me.TimeBtn.Text = "DateAndTime"
        Me.TimeBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(94, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 35)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPager
        '
        Me.pnlPager.BackColor = System.Drawing.Color.HotPink
        Me.pnlPager.Controls.Add(Me.TimeBtn)
        Me.pnlPager.Controls.Add(Me.Label6)
        Me.pnlPager.Controls.Add(Me.Label7)
        Me.pnlPager.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPager.Location = New System.Drawing.Point(0, 735)
        Me.pnlPager.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlPager.Name = "pnlPager"
        Me.pnlPager.Size = New System.Drawing.Size(1175, 48)
        Me.pnlPager.TabIndex = 291
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 48)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Logged: "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(476, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 31)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Employee Dashboard"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 31)
        Me.Label2.TabIndex = 270
        Me.Label2.Text = "USERNAME"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1175, 62)
        Me.Panel3.TabIndex = 290
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CapstoneProject.My.Resources.Resources.City_Tourism_logo_COLORED
        Me.PictureBox3.Location = New System.Drawing.Point(527, 230)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(319, 308)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 292
        Me.PictureBox3.TabStop = False
        '
        'EmployeeDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1175, 783)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlPager)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1197, 839)
        Me.MinimizeBox = False
        Me.Name = "EmployeeDashboard"
        Me.Text = "EmployeeDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.pnlPager.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnTimeOut As Button
    Friend WithEvents BtnSetting As Button
    Friend WithEvents INbtnPM As Button
    Friend WithEvents BtnAttendance As Button
    Friend WithEvents BtnProfile As Button
    Friend WithEvents INbtnAM As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TimeBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlPager As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
End Class
