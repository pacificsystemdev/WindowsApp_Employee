<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblstID = New System.Windows.Forms.Label()
        Me.lblstName = New System.Windows.Forms.Label()
        Me.lblGen = New System.Windows.Forms.Label()
        Me.lblcont = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.dtpDob = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.rdoMen = New System.Windows.Forms.RadioButton()
        Me.rdoWomen = New System.Windows.Forms.RadioButton()
        Me.txtSa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Menagement"
        '
        'lblstID
        '
        Me.lblstID.AutoSize = True
        Me.lblstID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstID.Location = New System.Drawing.Point(62, 67)
        Me.lblstID.Name = "lblstID"
        Me.lblstID.Size = New System.Drawing.Size(49, 16)
        Me.lblstID.TabIndex = 1
        Me.lblstID.Text = "Staff ID"
        '
        'lblstName
        '
        Me.lblstName.AutoSize = True
        Me.lblstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstName.Location = New System.Drawing.Point(17, 105)
        Me.lblstName.Name = "lblstName"
        Me.lblstName.Size = New System.Drawing.Size(94, 16)
        Me.lblstName.TabIndex = 2
        Me.lblstName.Text = "Staff FullName"
        '
        'lblGen
        '
        Me.lblGen.AutoSize = True
        Me.lblGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGen.Location = New System.Drawing.Point(457, 146)
        Me.lblGen.Name = "lblGen"
        Me.lblGen.Size = New System.Drawing.Size(52, 16)
        Me.lblGen.TabIndex = 3
        Me.lblGen.Text = "Gender"
        '
        'lblcont
        '
        Me.lblcont.AutoSize = True
        Me.lblcont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcont.Location = New System.Drawing.Point(59, 146)
        Me.lblcont.Name = "lblcont"
        Me.lblcont.Size = New System.Drawing.Size(52, 16)
        Me.lblcont.TabIndex = 4
        Me.lblcont.Text = "Contact"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(427, 108)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(82, 16)
        Me.lbldob.TabIndex = 5
        Me.lbldob.Text = "Birth of Date "
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(127, 67)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(250, 20)
        Me.txtID.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(127, 105)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(250, 20)
        Me.txtName.TabIndex = 7
        '
        'txtCont
        '
        Me.txtCont.Location = New System.Drawing.Point(127, 146)
        Me.txtCont.Name = "txtCont"
        Me.txtCont.Size = New System.Drawing.Size(250, 20)
        Me.txtCont.TabIndex = 8
        '
        'dtpDob
        '
        Me.dtpDob.Location = New System.Drawing.Point(515, 108)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(233, 20)
        Me.dtpDob.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 44)
        Me.Panel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(761, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "X"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(20, 211)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 33)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(369, 211)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 33)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(515, 211)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(91, 33)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(657, 211)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 33)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'rdoMen
        '
        Me.rdoMen.AutoSize = True
        Me.rdoMen.Location = New System.Drawing.Point(546, 149)
        Me.rdoMen.Name = "rdoMen"
        Me.rdoMen.Size = New System.Drawing.Size(46, 17)
        Me.rdoMen.TabIndex = 17
        Me.rdoMen.TabStop = True
        Me.rdoMen.Text = "Men"
        Me.rdoMen.UseVisualStyleBackColor = True
        '
        'rdoWomen
        '
        Me.rdoWomen.AutoSize = True
        Me.rdoWomen.Location = New System.Drawing.Point(625, 149)
        Me.rdoWomen.Name = "rdoWomen"
        Me.rdoWomen.Size = New System.Drawing.Size(62, 17)
        Me.rdoWomen.TabIndex = 18
        Me.rdoWomen.TabStop = True
        Me.rdoWomen.Text = "Women"
        Me.rdoWomen.UseVisualStyleBackColor = True
        '
        'txtSa
        '
        Me.txtSa.Location = New System.Drawing.Point(515, 67)
        Me.txtSa.Name = "txtSa"
        Me.txtSa.Size = New System.Drawing.Size(233, 20)
        Me.txtSa.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(463, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Salary"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(800, 264)
        Me.DataGridView1.TabIndex = 21
        '
        'empForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdoWomen)
        Me.Controls.Add(Me.rdoMen)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpDob)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lblcont)
        Me.Controls.Add(Me.lblGen)
        Me.Controls.Add(Me.lblstName)
        Me.Controls.Add(Me.lblstID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "empForm"
        Me.Text = "Employee Menagement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblstID As Label
    Friend WithEvents lblstName As Label
    Friend WithEvents lblGen As Label
    Friend WithEvents lblcont As Label
    Friend WithEvents lbldob As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCont As TextBox
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents rdoMen As RadioButton
    Friend WithEvents rdoWomen As RadioButton
    Friend WithEvents txtSa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
