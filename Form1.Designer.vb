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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boxOrganisms = New System.Windows.Forms.ComboBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.boxDays = New System.Windows.Forms.ComboBox()
        Me.listPopulation = New System.Windows.Forms.ListBox()
        Me.butCalculate = New System.Windows.Forms.Button()
        Me.butReset = New System.Windows.Forms.Button()
        Me.butExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Starting Number of Organisms : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Average Daily Increase :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Days of Multiply :"
        '
        'boxOrganisms
        '
        Me.boxOrganisms.FormattingEnabled = True
        Me.boxOrganisms.Location = New System.Drawing.Point(236, 117)
        Me.boxOrganisms.Name = "boxOrganisms"
        Me.boxOrganisms.Size = New System.Drawing.Size(121, 21)
        Me.boxOrganisms.TabIndex = 3
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(236, 152)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(121, 20)
        Me.txtAverage.TabIndex = 4
        '
        'boxDays
        '
        Me.boxDays.FormattingEnabled = True
        Me.boxDays.Location = New System.Drawing.Point(236, 185)
        Me.boxDays.Name = "boxDays"
        Me.boxDays.Size = New System.Drawing.Size(121, 21)
        Me.boxDays.TabIndex = 5
        '
        'listPopulation
        '
        Me.listPopulation.FormattingEnabled = True
        Me.listPopulation.Location = New System.Drawing.Point(454, 100)
        Me.listPopulation.Name = "listPopulation"
        Me.listPopulation.Size = New System.Drawing.Size(159, 147)
        Me.listPopulation.TabIndex = 6
        '
        'butCalculate
        '
        Me.butCalculate.Location = New System.Drawing.Point(122, 285)
        Me.butCalculate.Name = "butCalculate"
        Me.butCalculate.Size = New System.Drawing.Size(75, 23)
        Me.butCalculate.TabIndex = 7
        Me.butCalculate.Text = "Calculate"
        Me.butCalculate.UseVisualStyleBackColor = True
        '
        'butReset
        '
        Me.butReset.Location = New System.Drawing.Point(261, 285)
        Me.butReset.Name = "butReset"
        Me.butReset.Size = New System.Drawing.Size(75, 23)
        Me.butReset.TabIndex = 8
        Me.butReset.Text = "Reset"
        Me.butReset.UseVisualStyleBackColor = True
        '
        'butExit
        '
        Me.butExit.Location = New System.Drawing.Point(429, 285)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(75, 23)
        Me.butExit.TabIndex = 9
        Me.butExit.Text = "Exit"
        Me.butExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.butExit)
        Me.Controls.Add(Me.butReset)
        Me.Controls.Add(Me.butCalculate)
        Me.Controls.Add(Me.listPopulation)
        Me.Controls.Add(Me.boxDays)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.boxOrganisms)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents boxOrganisms As ComboBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents boxDays As ComboBox
    Friend WithEvents listPopulation As ListBox
    Friend WithEvents butCalculate As Button
    Friend WithEvents butReset As Button
    Friend WithEvents butExit As Button
End Class
