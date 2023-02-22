<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim User_nameLabel As System.Windows.Forms.Label
        Dim User_typeLabel As System.Windows.Forms.Label
        Dim User_passwordLabel As System.Windows.Forms.Label
        Me.MydbDataSet = New VB_MSACCESS.mydbDataSet()
        Me.User_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_tblTableAdapter = New VB_MSACCESS.mydbDataSetTableAdapters.user_tblTableAdapter()
        Me.TableAdapterManager = New VB_MSACCESS.mydbDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.User_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.User_nameTextBox = New System.Windows.Forms.TextBox()
        Me.User_typeTextBox = New System.Windows.Forms.TextBox()
        Me.User_passwordTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        User_nameLabel = New System.Windows.Forms.Label()
        User_typeLabel = New System.Windows.Forms.Label()
        User_passwordLabel = New System.Windows.Forms.Label()
        CType(Me.MydbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(66, 59)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 15
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(66, 85)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(36, 13)
        NameLabel.TabIndex = 17
        NameLabel.Text = "name:"
        '
        'User_nameLabel
        '
        User_nameLabel.AutoSize = True
        User_nameLabel.Location = New System.Drawing.Point(66, 111)
        User_nameLabel.Name = "User_nameLabel"
        User_nameLabel.Size = New System.Drawing.Size(59, 13)
        User_nameLabel.TabIndex = 19
        User_nameLabel.Text = "user name:"
        '
        'User_typeLabel
        '
        User_typeLabel.AutoSize = True
        User_typeLabel.Location = New System.Drawing.Point(66, 163)
        User_typeLabel.Name = "User_typeLabel"
        User_typeLabel.Size = New System.Drawing.Size(53, 13)
        User_typeLabel.TabIndex = 21
        User_typeLabel.Text = "user type:"
        '
        'User_passwordLabel
        '
        User_passwordLabel.AutoSize = True
        User_passwordLabel.Location = New System.Drawing.Point(66, 137)
        User_passwordLabel.Name = "User_passwordLabel"
        User_passwordLabel.Size = New System.Drawing.Size(78, 13)
        User_passwordLabel.TabIndex = 23
        User_passwordLabel.Text = "user password:"
        '
        'MydbDataSet
        '
        Me.MydbDataSet.DataSetName = "mydbDataSet"
        Me.MydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'User_tblBindingSource
        '
        Me.User_tblBindingSource.DataMember = "user_tbl"
        Me.User_tblBindingSource.DataSource = Me.MydbDataSet
        '
        'User_tblTableAdapter
        '
        Me.User_tblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = VB_MSACCESS.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tblTableAdapter = Me.User_tblTableAdapter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(52, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(52, 227)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(133, 227)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'User_tblDataGridView
        '
        Me.User_tblDataGridView.AllowUserToAddRows = False
        Me.User_tblDataGridView.AllowUserToDeleteRows = False
        Me.User_tblDataGridView.AutoGenerateColumns = False
        Me.User_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.User_tblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.user_password, Me.DataGridViewTextBoxColumn5})
        Me.User_tblDataGridView.DataSource = Me.User_tblBindingSource
        Me.User_tblDataGridView.Location = New System.Drawing.Point(316, 45)
        Me.User_tblDataGridView.Name = "User_tblDataGridView"
        Me.User_tblDataGridView.ReadOnly = True
        Me.User_tblDataGridView.Size = New System.Drawing.Size(544, 220)
        Me.User_tblDataGridView.TabIndex = 15
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_tblBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(150, 56)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 16
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_tblBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(150, 82)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 18
        '
        'User_nameTextBox
        '
        Me.User_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_tblBindingSource, "user_name", True))
        Me.User_nameTextBox.Location = New System.Drawing.Point(150, 108)
        Me.User_nameTextBox.Name = "User_nameTextBox"
        Me.User_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.User_nameTextBox.TabIndex = 20
        '
        'User_typeTextBox
        '
        Me.User_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_tblBindingSource, "user_type", True))
        Me.User_typeTextBox.Location = New System.Drawing.Point(150, 160)
        Me.User_typeTextBox.Name = "User_typeTextBox"
        Me.User_typeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.User_typeTextBox.TabIndex = 22
        '
        'User_passwordTextBox
        '
        Me.User_passwordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_tblBindingSource, "user_password", True))
        Me.User_passwordTextBox.Location = New System.Drawing.Point(150, 134)
        Me.User_passwordTextBox.Name = "User_passwordTextBox"
        Me.User_passwordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.User_passwordTextBox.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "user_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "user_name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'user_password
        '
        Me.user_password.DataPropertyName = "user_password"
        Me.user_password.HeaderText = "user_password"
        Me.user_password.Name = "user_password"
        Me.user_password.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "user_type"
        Me.DataGridViewTextBoxColumn5.HeaderText = "user_type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 317)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(User_nameLabel)
        Me.Controls.Add(Me.User_nameTextBox)
        Me.Controls.Add(User_typeLabel)
        Me.Controls.Add(Me.User_typeTextBox)
        Me.Controls.Add(User_passwordLabel)
        Me.Controls.Add(Me.User_passwordTextBox)
        Me.Controls.Add(Me.User_tblDataGridView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MydbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MydbDataSet As mydbDataSet
    Friend WithEvents User_tblBindingSource As BindingSource
    Friend WithEvents User_tblTableAdapter As mydbDataSetTableAdapters.user_tblTableAdapter
    Friend WithEvents TableAdapterManager As mydbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents User_tblDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents User_nameTextBox As TextBox
    Friend WithEvents User_typeTextBox As TextBox
    Friend WithEvents User_passwordTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents user_password As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
