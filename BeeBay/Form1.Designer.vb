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
        Me.tb_FirstName = New System.Windows.Forms.TextBox()
        Me.tb_LastName = New System.Windows.Forms.TextBox()
        Me.tb_Address = New System.Windows.Forms.TextBox()
        Me.tb_PostCode = New System.Windows.Forms.TextBox()
        Me.num_WBee = New System.Windows.Forms.NumericUpDown()
        Me.num_QBee = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_WBeeInc = New System.Windows.Forms.TextBox()
        Me.tb_QBeeInc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Surcharge = New System.Windows.Forms.TextBox()
        Me.tb_Total = New System.Windows.Forms.TextBox()
        Me.tb_Freight = New System.Windows.Forms.TextBox()
        Me.tb_CustomerID = New System.Windows.Forms.TextBox()
        CType(Me.num_WBee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_QBee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_FirstName
        '
        Me.tb_FirstName.Location = New System.Drawing.Point(121, 26)
        Me.tb_FirstName.Name = "tb_FirstName"
        Me.tb_FirstName.Size = New System.Drawing.Size(185, 20)
        Me.tb_FirstName.TabIndex = 0
        '
        'tb_LastName
        '
        Me.tb_LastName.Location = New System.Drawing.Point(121, 67)
        Me.tb_LastName.Name = "tb_LastName"
        Me.tb_LastName.Size = New System.Drawing.Size(185, 20)
        Me.tb_LastName.TabIndex = 1
        '
        'tb_Address
        '
        Me.tb_Address.Location = New System.Drawing.Point(121, 109)
        Me.tb_Address.Name = "tb_Address"
        Me.tb_Address.Size = New System.Drawing.Size(276, 20)
        Me.tb_Address.TabIndex = 2
        '
        'tb_PostCode
        '
        Me.tb_PostCode.Location = New System.Drawing.Point(121, 150)
        Me.tb_PostCode.Name = "tb_PostCode"
        Me.tb_PostCode.Size = New System.Drawing.Size(134, 20)
        Me.tb_PostCode.TabIndex = 3
        '
        'num_WBee
        '
        Me.num_WBee.Location = New System.Drawing.Point(121, 212)
        Me.num_WBee.Name = "num_WBee"
        Me.num_WBee.Size = New System.Drawing.Size(120, 20)
        Me.num_WBee.TabIndex = 4
        '
        'num_QBee
        '
        Me.num_QBee.Location = New System.Drawing.Point(121, 261)
        Me.num_QBee.Name = "num_QBee"
        Me.num_QBee.Size = New System.Drawing.Size(120, 20)
        Me.num_QBee.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 51)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_WBeeInc
        '
        Me.tb_WBeeInc.Location = New System.Drawing.Point(307, 211)
        Me.tb_WBeeInc.Name = "tb_WBeeInc"
        Me.tb_WBeeInc.ReadOnly = True
        Me.tb_WBeeInc.Size = New System.Drawing.Size(100, 20)
        Me.tb_WBeeInc.TabIndex = 7
        '
        'tb_QBeeInc
        '
        Me.tb_QBeeInc.Location = New System.Drawing.Point(307, 260)
        Me.tb_QBeeInc.Name = "tb_QBeeInc"
        Me.tb_QBeeInc.ReadOnly = True
        Me.tb_QBeeInc.Size = New System.Drawing.Size(100, 20)
        Me.tb_QBeeInc.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Surcharge"
        '
        'tb_Surcharge
        '
        Me.tb_Surcharge.Location = New System.Drawing.Point(307, 311)
        Me.tb_Surcharge.Name = "tb_Surcharge"
        Me.tb_Surcharge.ReadOnly = True
        Me.tb_Surcharge.Size = New System.Drawing.Size(100, 20)
        Me.tb_Surcharge.TabIndex = 10
        '
        'tb_Total
        '
        Me.tb_Total.Location = New System.Drawing.Point(307, 388)
        Me.tb_Total.Name = "tb_Total"
        Me.tb_Total.ReadOnly = True
        Me.tb_Total.Size = New System.Drawing.Size(213, 20)
        Me.tb_Total.TabIndex = 11
        '
        'tb_Freight
        '
        Me.tb_Freight.Location = New System.Drawing.Point(307, 350)
        Me.tb_Freight.Name = "tb_Freight"
        Me.tb_Freight.ReadOnly = True
        Me.tb_Freight.Size = New System.Drawing.Size(100, 20)
        Me.tb_Freight.TabIndex = 12
        '
        'tb_CustomerID
        '
        Me.tb_CustomerID.Location = New System.Drawing.Point(307, 418)
        Me.tb_CustomerID.Name = "tb_CustomerID"
        Me.tb_CustomerID.ReadOnly = True
        Me.tb_CustomerID.Size = New System.Drawing.Size(213, 20)
        Me.tb_CustomerID.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 458)
        Me.Controls.Add(Me.tb_CustomerID)
        Me.Controls.Add(Me.tb_Freight)
        Me.Controls.Add(Me.tb_Total)
        Me.Controls.Add(Me.tb_Surcharge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_QBeeInc)
        Me.Controls.Add(Me.tb_WBeeInc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.num_QBee)
        Me.Controls.Add(Me.num_WBee)
        Me.Controls.Add(Me.tb_PostCode)
        Me.Controls.Add(Me.tb_Address)
        Me.Controls.Add(Me.tb_LastName)
        Me.Controls.Add(Me.tb_FirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.num_WBee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_QBee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_FirstName As TextBox
    Friend WithEvents tb_LastName As TextBox
    Friend WithEvents tb_Address As TextBox
    Friend WithEvents tb_PostCode As TextBox
    Friend WithEvents num_WBee As NumericUpDown
    Friend WithEvents num_QBee As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents tb_WBeeInc As TextBox
    Friend WithEvents tb_QBeeInc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Surcharge As TextBox
    Friend WithEvents tb_Total As TextBox
    Friend WithEvents tb_Freight As TextBox
    Friend WithEvents tb_CustomerID As TextBox
End Class
