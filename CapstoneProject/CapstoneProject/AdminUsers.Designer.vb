<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminUsers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TBpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordDBDataSet1 = New CapstoneProject.RecordDBDataSet1()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbstat = New System.Windows.Forms.ComboBox()
        Me.cmbCstatus = New System.Windows.Forms.ComboBox()
        Me.TBemail = New System.Windows.Forms.TextBox()
        Me.TBusername = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.cmbusertype = New System.Windows.Forms.ComboBox()
        Me.TBcontact = New System.Windows.Forms.TextBox()
        Me.TBfn = New System.Windows.Forms.TextBox()
        Me.TBadd = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TBmiddle = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBbirthday = New System.Windows.Forms.TextBox()
        Me.TBln = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblDelete = New System.Windows.Forms.Label()
        Me.BtnInsert = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PBsearch = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblUpdate = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserTableTableAdapter = New CapstoneProject.RecordDBDataSet1TableAdapters.UserTableTableAdapter()
        Me.BtnClear = New System.Windows.Forms.Label()
        Me.USERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIRTHDAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIVILSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PBsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBpassword
        '
        Me.TBpassword.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBpassword.Location = New System.Drawing.Point(23, 127)
        Me.TBpassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBpassword.MaxLength = 20
        Me.TBpassword.Multiline = True
        Me.TBpassword.Name = "TBpassword"
        Me.TBpassword.Size = New System.Drawing.Size(224, 30)
        Me.TBpassword.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "USERNAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "PASSWORD:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USERNAMEDataGridViewTextBoxColumn, Me.PASSWORDDataGridViewTextBoxColumn, Me.USERTYPEDataGridViewTextBoxColumn, Me.USTATUSDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.MIDDLENAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.CONTACTNUMDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.BIRTHDAYDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.SEXDataGridViewTextBoxColumn, Me.CIVILSTATUSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UserTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(872, 154)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(512, 522)
        Me.DataGridView1.TabIndex = 289
        '
        'UserTableBindingSource
        '
        Me.UserTableBindingSource.DataMember = "UserTable"
        Me.UserTableBindingSource.DataSource = Me.RecordDBDataSet1
        '
        'RecordDBDataSet1
        '
        Me.RecordDBDataSet1.DataSetName = "RecordDBDataSet1"
        Me.RecordDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbstat)
        Me.GroupBox1.Controls.Add(Me.cmbCstatus)
        Me.GroupBox1.Controls.Add(Me.TBpassword)
        Me.GroupBox1.Controls.Add(Me.TBemail)
        Me.GroupBox1.Controls.Add(Me.TBusername)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbSex)
        Me.GroupBox1.Controls.Add(Me.cmbusertype)
        Me.GroupBox1.Controls.Add(Me.TBcontact)
        Me.GroupBox1.Controls.Add(Me.TBfn)
        Me.GroupBox1.Controls.Add(Me.TBadd)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.TBmiddle)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TBbirthday)
        Me.GroupBox1.Controls.Add(Me.TBln)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 527)
        Me.GroupBox1.TabIndex = 284
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add User"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 239)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 21)
        Me.Label10.TabIndex = 216
        Me.Label10.Text = "STATUS:"
        '
        'cmbstat
        '
        Me.cmbstat.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstat.FormattingEnabled = True
        Me.cmbstat.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbstat.Location = New System.Drawing.Point(23, 264)
        Me.cmbstat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbstat.Name = "cmbstat"
        Me.cmbstat.Size = New System.Drawing.Size(222, 32)
        Me.cmbstat.TabIndex = 217
        '
        'cmbCstatus
        '
        Me.cmbCstatus.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCstatus.FormattingEnabled = True
        Me.cmbCstatus.Items.AddRange(New Object() {"Single", "Married"})
        Me.cmbCstatus.Location = New System.Drawing.Point(311, 403)
        Me.cmbCstatus.Name = "cmbCstatus"
        Me.cmbCstatus.Size = New System.Drawing.Size(217, 32)
        Me.cmbCstatus.TabIndex = 225
        '
        'TBemail
        '
        Me.TBemail.BackColor = System.Drawing.Color.White
        Me.TBemail.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBemail.Location = New System.Drawing.Point(312, 126)
        Me.TBemail.MaxLength = 40
        Me.TBemail.Name = "TBemail"
        Me.TBemail.Size = New System.Drawing.Size(230, 31)
        Me.TBemail.TabIndex = 223
        '
        'TBusername
        '
        Me.TBusername.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBusername.Location = New System.Drawing.Point(24, 63)
        Me.TBusername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBusername.MaxLength = 20
        Me.TBusername.Multiline = True
        Me.TBusername.Name = "TBusername"
        Me.TBusername.Size = New System.Drawing.Size(223, 30)
        Me.TBusername.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(308, 380)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 21)
        Me.Label22.TabIndex = 216
        Me.Label22.Text = "CIVIL STATUS:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(308, 101)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(140, 21)
        Me.Label26.TabIndex = 218
        Me.Label26.Text = "EMAIL ADDRESS:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(307, 171)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 21)
        Me.Label8.TabIndex = 204
        Me.Label8.Text = "BIRTH DATE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 170)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "USER TYPE:"
        '
        'cmbSex
        '
        Me.cmbSex.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbSex.Location = New System.Drawing.Point(311, 333)
        Me.cmbSex.MaxLength = 10
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(211, 32)
        Me.cmbSex.TabIndex = 212
        '
        'cmbusertype
        '
        Me.cmbusertype.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbusertype.FormattingEnabled = True
        Me.cmbusertype.Items.AddRange(New Object() {"Admin", "Employee", "Intern"})
        Me.cmbusertype.Location = New System.Drawing.Point(23, 196)
        Me.cmbusertype.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbusertype.Name = "cmbusertype"
        Me.cmbusertype.Size = New System.Drawing.Size(224, 32)
        Me.cmbusertype.TabIndex = 26
        '
        'TBcontact
        '
        Me.TBcontact.BackColor = System.Drawing.Color.White
        Me.TBcontact.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBcontact.Location = New System.Drawing.Point(312, 62)
        Me.TBcontact.MaxLength = 20
        Me.TBcontact.Name = "TBcontact"
        Me.TBcontact.Size = New System.Drawing.Size(231, 31)
        Me.TBcontact.TabIndex = 209
        '
        'TBfn
        '
        Me.TBfn.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBfn.Location = New System.Drawing.Point(23, 335)
        Me.TBfn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBfn.MaxLength = 20
        Me.TBfn.Multiline = True
        Me.TBfn.Name = "TBfn"
        Me.TBfn.Size = New System.Drawing.Size(224, 30)
        Me.TBfn.TabIndex = 198
        '
        'TBadd
        '
        Me.TBadd.BackColor = System.Drawing.Color.White
        Me.TBadd.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBadd.Location = New System.Drawing.Point(311, 264)
        Me.TBadd.MaxLength = 60
        Me.TBadd.Name = "TBadd"
        Me.TBadd.Size = New System.Drawing.Size(478, 31)
        Me.TBadd.TabIndex = 210
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(308, 308)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 21)
        Me.Label23.TabIndex = 205
        Me.Label23.Text = "SEX:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 311)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 21)
        Me.Label7.TabIndex = 200
        Me.Label7.Text = "FIRST NAME"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(310, 38)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(166, 21)
        Me.Label27.TabIndex = 206
        Me.Label27.Text = "CONTACT NUMBER:"
        '
        'TBmiddle
        '
        Me.TBmiddle.BackColor = System.Drawing.Color.White
        Me.TBmiddle.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBmiddle.Location = New System.Drawing.Point(24, 404)
        Me.TBmiddle.MaxLength = 20
        Me.TBmiddle.Name = "TBmiddle"
        Me.TBmiddle.Size = New System.Drawing.Size(223, 31)
        Me.TBmiddle.TabIndex = 211
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(307, 238)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(86, 21)
        Me.Label28.TabIndex = 207
        Me.Label28.Text = "ADDRESS:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(19, 379)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 21)
        Me.Label13.TabIndex = 215
        Me.Label13.Text = "MIDDLE NAME:"
        '
        'TBbirthday
        '
        Me.TBbirthday.BackColor = System.Drawing.Color.White
        Me.TBbirthday.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBbirthday.Location = New System.Drawing.Point(311, 197)
        Me.TBbirthday.MaxLength = 20
        Me.TBbirthday.Name = "TBbirthday"
        Me.TBbirthday.Size = New System.Drawing.Size(229, 31)
        Me.TBbirthday.TabIndex = 208
        '
        'TBln
        '
        Me.TBln.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBln.Location = New System.Drawing.Point(23, 474)
        Me.TBln.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBln.MaxLength = 20
        Me.TBln.Multiline = True
        Me.TBln.Name = "TBln"
        Me.TBln.Size = New System.Drawing.Size(224, 30)
        Me.TBln.TabIndex = 199
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 448)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 21)
        Me.Label6.TabIndex = 201
        Me.Label6.Text = "LAST NAME"
        '
        'LblDelete
        '
        Me.LblDelete.BackColor = System.Drawing.Color.LightGray
        Me.LblDelete.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDelete.ForeColor = System.Drawing.Color.Black
        Me.LblDelete.Location = New System.Drawing.Point(1023, 64)
        Me.LblDelete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDelete.Name = "LblDelete"
        Me.LblDelete.Size = New System.Drawing.Size(170, 43)
        Me.LblDelete.TabIndex = 288
        Me.LblDelete.Text = "DELETE"
        Me.LblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnInsert
        '
        Me.BtnInsert.BackColor = System.Drawing.Color.LightGray
        Me.BtnInsert.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsert.ForeColor = System.Drawing.Color.Black
        Me.BtnInsert.Location = New System.Drawing.Point(642, 64)
        Me.BtnInsert.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(170, 43)
        Me.BtnInsert.TabIndex = 283
        Me.BtnInsert.Text = "INSERT"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.PBsearch)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(28, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(593, 43)
        Me.Panel2.TabIndex = 286
        '
        'PBsearch
        '
        Me.PBsearch.BackColor = System.Drawing.Color.Transparent
        Me.PBsearch.Image = CType(resources.GetObject("PBsearch.Image"), System.Drawing.Image)
        Me.PBsearch.Location = New System.Drawing.Point(484, 8)
        Me.PBsearch.Name = "PBsearch"
        Me.PBsearch.Size = New System.Drawing.Size(38, 32)
        Me.PBsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBsearch.TabIndex = 263
        Me.PBsearch.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(257, 8)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.MaxLength = 20
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 30)
        Me.TextBox3.TabIndex = 258
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(153, 11)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 24)
        Me.Label11.TabIndex = 264
        Me.Label11.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 24)
        Me.Label5.TabIndex = 259
        Me.Label5.Text = "SEARCH: "
        '
        'LblUpdate
        '
        Me.LblUpdate.BackColor = System.Drawing.Color.LightGray
        Me.LblUpdate.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUpdate.ForeColor = System.Drawing.Color.Black
        Me.LblUpdate.Location = New System.Drawing.Point(833, 64)
        Me.LblUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUpdate.Name = "LblUpdate"
        Me.LblUpdate.Size = New System.Drawing.Size(170, 43)
        Me.LblUpdate.TabIndex = 287
        Me.LblUpdate.Text = "UPDATE"
        Me.LblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1407, 57)
        Me.Panel1.TabIndex = 282
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(577, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "MANAGE USERS "
        '
        'UserTableTableAdapter
        '
        Me.UserTableTableAdapter.ClearBeforeFill = True
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.LightGray
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Black
        Me.BtnClear.Location = New System.Drawing.Point(1214, 64)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(170, 43)
        Me.BtnClear.TabIndex = 290
        Me.BtnClear.Text = "CLEAR"
        Me.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'USERNAMEDataGridViewTextBoxColumn
        '
        Me.USERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.USERNAMEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.USERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.Name = "USERNAMEDataGridViewTextBoxColumn"
        Me.USERNAMEDataGridViewTextBoxColumn.Width = 70
        '
        'PASSWORDDataGridViewTextBoxColumn
        '
        Me.PASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.Name = "PASSWORDDataGridViewTextBoxColumn"
        Me.PASSWORDDataGridViewTextBoxColumn.Visible = False
        '
        'USERTYPEDataGridViewTextBoxColumn
        '
        Me.USERTYPEDataGridViewTextBoxColumn.DataPropertyName = "USERTYPE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.USERTYPEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.USERTYPEDataGridViewTextBoxColumn.HeaderText = "USERTYPE"
        Me.USERTYPEDataGridViewTextBoxColumn.Name = "USERTYPEDataGridViewTextBoxColumn"
        Me.USERTYPEDataGridViewTextBoxColumn.Visible = False
        '
        'USTATUSDataGridViewTextBoxColumn
        '
        Me.USTATUSDataGridViewTextBoxColumn.DataPropertyName = "USTATUS"
        Me.USTATUSDataGridViewTextBoxColumn.HeaderText = "USTATUS"
        Me.USTATUSDataGridViewTextBoxColumn.Name = "USTATUSDataGridViewTextBoxColumn"
        Me.USTATUSDataGridViewTextBoxColumn.Width = 60
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Width = 80
        '
        'MIDDLENAMEDataGridViewTextBoxColumn
        '
        Me.MIDDLENAMEDataGridViewTextBoxColumn.DataPropertyName = "MIDDLENAME"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.HeaderText = "MIDDLENAME"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.Name = "MIDDLENAMEDataGridViewTextBoxColumn"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.Visible = False
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.LASTNAMEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        Me.LASTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.LASTNAMEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LASTNAMEDataGridViewTextBoxColumn.Width = 80
        '
        'CONTACTNUMDataGridViewTextBoxColumn
        '
        Me.CONTACTNUMDataGridViewTextBoxColumn.DataPropertyName = "CONTACTNUM"
        Me.CONTACTNUMDataGridViewTextBoxColumn.HeaderText = "CONTACTNUM"
        Me.CONTACTNUMDataGridViewTextBoxColumn.Name = "CONTACTNUMDataGridViewTextBoxColumn"
        Me.CONTACTNUMDataGridViewTextBoxColumn.Visible = False
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.Visible = False
        '
        'BIRTHDAYDataGridViewTextBoxColumn
        '
        Me.BIRTHDAYDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDAY"
        Me.BIRTHDAYDataGridViewTextBoxColumn.HeaderText = "BIRTHDAY"
        Me.BIRTHDAYDataGridViewTextBoxColumn.Name = "BIRTHDAYDataGridViewTextBoxColumn"
        Me.BIRTHDAYDataGridViewTextBoxColumn.Visible = False
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        Me.ADDRESSDataGridViewTextBoxColumn.Visible = False
        '
        'SEXDataGridViewTextBoxColumn
        '
        Me.SEXDataGridViewTextBoxColumn.DataPropertyName = "SEX"
        Me.SEXDataGridViewTextBoxColumn.HeaderText = "SEX"
        Me.SEXDataGridViewTextBoxColumn.Name = "SEXDataGridViewTextBoxColumn"
        Me.SEXDataGridViewTextBoxColumn.Visible = False
        '
        'CIVILSTATUSDataGridViewTextBoxColumn
        '
        Me.CIVILSTATUSDataGridViewTextBoxColumn.DataPropertyName = "CIVILSTATUS"
        Me.CIVILSTATUSDataGridViewTextBoxColumn.HeaderText = "CIVILSTATUS"
        Me.CIVILSTATUSDataGridViewTextBoxColumn.Name = "CIVILSTATUSDataGridViewTextBoxColumn"
        Me.CIVILSTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'AdminUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1407, 713)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblDelete)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LblUpdate)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1429, 769)
        Me.MinimizeBox = False
        Me.Name = "AdminUsers"
        Me.Text = "AdminUsers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PBsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBusername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbusertype As ComboBox
    Friend WithEvents TBfn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBmiddle As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBln As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents cmbCstatus As ComboBox
    Friend WithEvents TBemail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents TBcontact As TextBox
    Friend WithEvents TBadd As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TBbirthday As TextBox
    Friend WithEvents LblDelete As Label
    Friend WithEvents BtnInsert As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PBsearch As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblUpdate As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbstat As ComboBox
    Friend WithEvents RecordDBDataSet1 As RecordDBDataSet1
    Friend WithEvents UserTableBindingSource As BindingSource
    Friend WithEvents UserTableTableAdapter As RecordDBDataSet1TableAdapters.UserTableTableAdapter
    Friend WithEvents BtnClear As Label
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERTYPEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTNUMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BIRTHDAYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SEXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CIVILSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
