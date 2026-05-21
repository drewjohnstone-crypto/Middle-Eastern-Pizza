<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Thanks = New Label()
        Arabictext = New Label()
        Label4 = New Label()
        receipt = New Button()
        backmenu = New Button()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(628, 291)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(640, 388)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(91, 61)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(552, 388)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(91, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(468, 388)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(91, 61)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(384, 388)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(91, 61)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(297, 388)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(91, 61)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' Thanks
        ' 
        Thanks.AutoSize = True
        Thanks.Font = New Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Thanks.Location = New Point(242, 63)
        Thanks.Name = "Thanks"
        Thanks.Size = New Size(411, 45)
        Thanks.TabIndex = 11
        Thanks.Text = "Thanks for your Order"
        ' 
        ' Arabictext
        ' 
        Arabictext.AutoSize = True
        Arabictext.Font = New Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Arabictext.Location = New Point(338, 121)
        Arabictext.Name = "Arabictext"
        Arabictext.Size = New Size(166, 45)
        Arabictext.TabIndex = 12
        Arabictext.Text = "شكراً لطلبك"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(297, 328)
        Label4.Name = "Label4"
        Label4.Size = New Size(420, 47)
        Label4.TabIndex = 13
        Label4.Text = "Geraldine Dream Pizza"
        ' 
        ' receipt
        ' 
        receipt.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        receipt.Location = New Point(45, 197)
        receipt.Name = "receipt"
        receipt.Size = New Size(133, 65)
        receipt.TabIndex = 14
        receipt.Text = "View Order Receipt"
        receipt.UseVisualStyleBackColor = True
        ' 
        ' backmenu
        ' 
        backmenu.Font = New Font("Times New Roman", 15F, FontStyle.Bold)
        backmenu.Location = New Point(45, 291)
        backmenu.Name = "backmenu"
        backmenu.Size = New Size(133, 64)
        backmenu.TabIndex = 15
        backmenu.Text = "Back to Menu"
        backmenu.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(backmenu)
        Controls.Add(receipt)
        Controls.Add(Label4)
        Controls.Add(Arabictext)
        Controls.Add(Thanks)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Controls.Add(Label3)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Thanks As Label
    Friend WithEvents Arabictext As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents receipt As Button
    Friend WithEvents backmenu As Button
End Class
