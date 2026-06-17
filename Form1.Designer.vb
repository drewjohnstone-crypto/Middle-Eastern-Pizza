<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        title = New Label()
        flag = New PictureBox()
        Flag2 = New PictureBox()
        Iran = New PictureBox()
        pciture4 = New PictureBox()
        FlLAG3 = New PictureBox()
        PictureBox1 = New PictureBox()
        pickup = New Button()
        delivery = New Button()
        subtitle = New Label()
        CType(flag, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flag2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Iran, ComponentModel.ISupportInitialize).BeginInit()
        CType(pciture4, ComponentModel.ISupportInitialize).BeginInit()
        CType(FlLAG3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.BackColor = SystemColors.Control
        title.BorderStyle = BorderStyle.Fixed3D
        title.Location = New Point(21, 46)
        title.Name = "title"
        title.Size = New Size(631, 70)
        title.TabIndex = 1
        title.Text = "Geraldine Dream Pizza"
        ' 
        ' flag
        ' 
        flag.Image = CType(resources.GetObject("flag.Image"), Image)
        flag.Location = New Point(766, 113)
        flag.Name = "flag"
        flag.Size = New Size(91, 61)
        flag.SizeMode = PictureBoxSizeMode.Zoom
        flag.TabIndex = 11
        flag.TabStop = False
        ' 
        ' Flag2
        ' 
        Flag2.Image = CType(resources.GetObject("Flag2.Image"), Image)
        Flag2.Location = New Point(669, 113)
        Flag2.Name = "Flag2"
        Flag2.Size = New Size(91, 61)
        Flag2.SizeMode = PictureBoxSizeMode.Zoom
        Flag2.TabIndex = 12
        Flag2.TabStop = False
        ' 
        ' Iran
        ' 
        Iran.Image = CType(resources.GetObject("Iran.Image"), Image)
        Iran.Location = New Point(863, 46)
        Iran.Name = "Iran"
        Iran.Size = New Size(91, 61)
        Iran.SizeMode = PictureBoxSizeMode.Zoom
        Iran.TabIndex = 13
        Iran.TabStop = False
        ' 
        ' pciture4
        ' 
        pciture4.Image = CType(resources.GetObject("pciture4.Image"), Image)
        pciture4.Location = New Point(766, 46)
        pciture4.Name = "pciture4"
        pciture4.Size = New Size(91, 61)
        pciture4.SizeMode = PictureBoxSizeMode.Zoom
        pciture4.TabIndex = 14
        pciture4.TabStop = False
        ' 
        ' FlLAG3
        ' 
        FlLAG3.Image = CType(resources.GetObject("FlLAG3.Image"), Image)
        FlLAG3.Location = New Point(669, 46)
        FlLAG3.Name = "FlLAG3"
        FlLAG3.Size = New Size(91, 61)
        FlLAG3.SizeMode = PictureBoxSizeMode.Zoom
        FlLAG3.TabIndex = 15
        FlLAG3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(863, 113)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(91, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' pickup
        ' 
        pickup.Location = New Point(58, 254)
        pickup.Name = "pickup"
        pickup.Size = New Size(325, 106)
        pickup.TabIndex = 17
        pickup.Text = "Pick up?"
        pickup.UseVisualStyleBackColor = True
        ' 
        ' delivery
        ' 
        delivery.Location = New Point(458, 254)
        delivery.Name = "delivery"
        delivery.Size = New Size(302, 106)
        delivery.TabIndex = 18
        delivery.Text = "Delivery?"
        delivery.UseVisualStyleBackColor = True
        ' 
        ' subtitle
        ' 
        subtitle.AutoSize = True
        subtitle.BackColor = SystemColors.Control
        subtitle.Font = New Font("Times New Roman", 20F, FontStyle.Bold)
        subtitle.Location = New Point(21, 129)
        subtitle.Name = "subtitle"
        subtitle.Size = New Size(378, 45)
        subtitle.TabIndex = 19
        subtitle.Text = "Middle Eastern Style"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(36F, 68F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(966, 450)
        Controls.Add(subtitle)
        Controls.Add(delivery)
        Controls.Add(pickup)
        Controls.Add(PictureBox1)
        Controls.Add(FlLAG3)
        Controls.Add(pciture4)
        Controls.Add(Iran)
        Controls.Add(Flag2)
        Controls.Add(flag)
        Controls.Add(title)
        Font = New Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(10, 9, 10, 9)
        Name = "Form1"
        Text = "Form1"
        TopMost = True
        CType(flag, ComponentModel.ISupportInitialize).EndInit()
        CType(Flag2, ComponentModel.ISupportInitialize).EndInit()
        CType(Iran, ComponentModel.ISupportInitialize).EndInit()
        CType(pciture4, ComponentModel.ISupportInitialize).EndInit()
        CType(FlLAG3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents title As Label
    Friend WithEvents flag As PictureBox
    Friend WithEvents Flag2 As PictureBox
    Friend WithEvents Iran As PictureBox
    Friend WithEvents pciture4 As PictureBox
    Friend WithEvents FlLAG3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pickup As Button
    Friend WithEvents delivery As Button
    Friend WithEvents subtitle As Label

End Class
