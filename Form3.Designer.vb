<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        pizzamen = New Label()
        standard = New Label()
        meataholic = New Label()
        sea = New Label()
        autumn = New Label()
        middlepizza = New Label()
        honolulu = New Label()
        chocolate = New Label()
        classic = New Label()
        lahmacun = New Label()
        vegan = New Label()
        rich = New Label()
        meatcombobox = New ComboBox()
        seacombobox = New ComboBox()
        autumncombobox = New ComboBox()
        middlecombobox = New ComboBox()
        honolulucombobox = New ComboBox()
        chocolatecombobox = New ComboBox()
        classiccombobox = New ComboBox()
        lahmacuncmbox = New ComboBox()
        vegancmbox = New ComboBox()
        hootiecmbox = New ComboBox()
        trufflecmbox = New ComboBox()
        algeriacmbox = New ComboBox()
        tropicalcmbox = New ComboBox()
        zaatarcmbox = New ComboBox()
        truffle = New Label()
        tropical = New Label()
        algeria = New Label()
        zaatar = New Label()
        gourmet = New Label()
        pricetext = New Label()
        totaltext = New Label()
        menbutton = New Button()
        complete = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        ToolTip = New ToolTip(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pizzamen
        ' 
        pizzamen.AutoSize = True
        pizzamen.Font = New Font("Times New Roman", 30F, FontStyle.Bold)
        pizzamen.Location = New Point(12, 19)
        pizzamen.Name = "pizzamen"
        pizzamen.Size = New Size(218, 45)
        pizzamen.TabIndex = 0
        pizzamen.Text = "Pizza Menu"
        ' 
        ' standard
        ' 
        standard.AutoSize = True
        standard.Font = New Font("Times New Roman", 20F, FontStyle.Bold)
        standard.Location = New Point(15, 108)
        standard.Name = "standard"
        standard.Size = New Size(226, 31)
        standard.TabIndex = 1
        standard.Text = "Standard $8.50 ea"
        ' 
        ' meataholic
        ' 
        meataholic.AutoSize = True
        meataholic.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        meataholic.Location = New Point(15, 162)
        meataholic.Name = "meataholic"
        meataholic.Size = New Size(111, 23)
        meataholic.TabIndex = 2
        meataholic.Text = "Meat-aholic"
        ' 
        ' sea
        ' 
        sea.AutoSize = True
        sea.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sea.Location = New Point(15, 202)
        sea.Name = "sea"
        sea.Size = New Size(191, 23)
        sea.TabIndex = 3
        sea.Text = "Straight from the Sea"
        ' 
        ' autumn
        ' 
        autumn.AutoSize = True
        autumn.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        autumn.Location = New Point(15, 242)
        autumn.Name = "autumn"
        autumn.Size = New Size(211, 23)
        autumn.TabIndex = 4
        autumn.Text = "Autumn Mush of Rooms"
        ' 
        ' middlepizza
        ' 
        middlepizza.AutoSize = True
        middlepizza.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        middlepizza.Location = New Point(15, 287)
        middlepizza.Name = "middlepizza"
        middlepizza.Size = New Size(191, 23)
        middlepizza.TabIndex = 5
        middlepizza.Text = "Middle Eastern Pizza"
        ' 
        ' honolulu
        ' 
        honolulu.AutoSize = True
        honolulu.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        honolulu.Location = New Point(15, 334)
        honolulu.Name = "honolulu"
        honolulu.Size = New Size(156, 23)
        honolulu.TabIndex = 6
        honolulu.Text = "Honolulu Retreat"
        ' 
        ' chocolate
        ' 
        chocolate.AutoSize = True
        chocolate.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chocolate.Location = New Point(15, 379)
        chocolate.Name = "chocolate"
        chocolate.Size = New Size(162, 23)
        chocolate.TabIndex = 7
        chocolate.Text = "Chocolate Suprise"
        ' 
        ' classic
        ' 
        classic.AutoSize = True
        classic.Font = New Font("Times New Roman", 15F, FontStyle.Bold)
        classic.Location = New Point(15, 424)
        classic.Name = "classic"
        classic.Size = New Size(69, 23)
        classic.TabIndex = 8
        classic.Text = "Classic"
        ' 
        ' lahmacun
        ' 
        lahmacun.AutoSize = True
        lahmacun.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lahmacun.Location = New Point(383, 162)
        lahmacun.Name = "lahmacun"
        lahmacun.Size = New Size(97, 23)
        lahmacun.TabIndex = 9
        lahmacun.Text = "Lahmacun"
        ' 
        ' vegan
        ' 
        vegan.AutoSize = True
        vegan.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        vegan.Location = New Point(383, 202)
        vegan.Name = "vegan"
        vegan.Size = New Size(60, 23)
        vegan.TabIndex = 10
        vegan.Text = "Grass"
        ' 
        ' rich
        ' 
        rich.AutoSize = True
        rich.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rich.Location = New Point(383, 242)
        rich.Name = "rich"
        rich.Size = New Size(127, 23)
        rich.TabIndex = 11
        rich.Text = "Hootie-Tootie"
        ' 
        ' meatcombobox
        ' 
        meatcombobox.FormattingEnabled = True
        meatcombobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        meatcombobox.Location = New Point(228, 162)
        meatcombobox.Name = "meatcombobox"
        meatcombobox.Size = New Size(121, 23)
        meatcombobox.TabIndex = 12
        ' 
        ' seacombobox
        ' 
        seacombobox.FormattingEnabled = True
        seacombobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        seacombobox.Location = New Point(228, 202)
        seacombobox.Name = "seacombobox"
        seacombobox.Size = New Size(121, 23)
        seacombobox.TabIndex = 13
        ' 
        ' autumncombobox
        ' 
        autumncombobox.FormattingEnabled = True
        autumncombobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        autumncombobox.Location = New Point(228, 242)
        autumncombobox.Name = "autumncombobox"
        autumncombobox.Size = New Size(121, 23)
        autumncombobox.TabIndex = 14
        ' 
        ' middlecombobox
        ' 
        middlecombobox.FormattingEnabled = True
        middlecombobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        middlecombobox.Location = New Point(228, 290)
        middlecombobox.Name = "middlecombobox"
        middlecombobox.Size = New Size(121, 23)
        middlecombobox.TabIndex = 15
        ' 
        ' honolulucombobox
        ' 
        honolulucombobox.FormattingEnabled = True
        honolulucombobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        honolulucombobox.Location = New Point(228, 337)
        honolulucombobox.Name = "honolulucombobox"
        honolulucombobox.Size = New Size(121, 23)
        honolulucombobox.TabIndex = 16
        ' 
        ' chocolatecombobox
        ' 
        chocolatecombobox.FormattingEnabled = True
        chocolatecombobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        chocolatecombobox.Location = New Point(228, 379)
        chocolatecombobox.Name = "chocolatecombobox"
        chocolatecombobox.Size = New Size(121, 23)
        chocolatecombobox.TabIndex = 17
        ' 
        ' classiccombobox
        ' 
        classiccombobox.FormattingEnabled = True
        classiccombobox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        classiccombobox.Location = New Point(228, 424)
        classiccombobox.Name = "classiccombobox"
        classiccombobox.Size = New Size(121, 23)
        classiccombobox.TabIndex = 18
        ' 
        ' lahmacuncmbox
        ' 
        lahmacuncmbox.FormattingEnabled = True
        lahmacuncmbox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        lahmacuncmbox.Location = New Point(535, 162)
        lahmacuncmbox.Name = "lahmacuncmbox"
        lahmacuncmbox.Size = New Size(121, 23)
        lahmacuncmbox.TabIndex = 19
        ' 
        ' vegancmbox
        ' 
        vegancmbox.FormattingEnabled = True
        vegancmbox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        vegancmbox.Location = New Point(535, 202)
        vegancmbox.Name = "vegancmbox"
        vegancmbox.Size = New Size(121, 23)
        vegancmbox.TabIndex = 20
        ' 
        ' hootiecmbox
        ' 
        hootiecmbox.FormattingEnabled = True
        hootiecmbox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        hootiecmbox.Location = New Point(535, 245)
        hootiecmbox.Name = "hootiecmbox"
        hootiecmbox.Size = New Size(121, 23)
        hootiecmbox.TabIndex = 21
        ' 
        ' trufflecmbox
        ' 
        trufflecmbox.FormattingEnabled = True
        trufflecmbox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        trufflecmbox.Location = New Point(535, 290)
        trufflecmbox.Name = "trufflecmbox"
        trufflecmbox.Size = New Size(121, 23)
        trufflecmbox.TabIndex = 22
        ' 
        ' algeriacmbox
        ' 
        algeriacmbox.FormattingEnabled = True
        algeriacmbox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        algeriacmbox.Location = New Point(535, 379)
        algeriacmbox.Name = "algeriacmbox"
        algeriacmbox.Size = New Size(121, 23)
        algeriacmbox.TabIndex = 23
        ' 
        ' tropicalcmbox
        ' 
        tropicalcmbox.FormattingEnabled = True
        tropicalcmbox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        tropicalcmbox.Location = New Point(535, 334)
        tropicalcmbox.Name = "tropicalcmbox"
        tropicalcmbox.Size = New Size(121, 23)
        tropicalcmbox.TabIndex = 24
        ' 
        ' zaatarcmbox
        ' 
        zaatarcmbox.FormattingEnabled = True
        zaatarcmbox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        zaatarcmbox.Location = New Point(535, 424)
        zaatarcmbox.Name = "zaatarcmbox"
        zaatarcmbox.Size = New Size(121, 23)
        zaatarcmbox.TabIndex = 25
        ' 
        ' truffle
        ' 
        truffle.AutoSize = True
        truffle.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        truffle.Location = New Point(383, 290)
        truffle.Name = "truffle"
        truffle.Size = New Size(140, 23)
        truffle.TabIndex = 26
        truffle.Text = "Lot's of Truffle"
        ' 
        ' tropical
        ' 
        tropical.AutoSize = True
        tropical.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tropical.Location = New Point(383, 337)
        tropical.Name = "tropical"
        tropical.Size = New Size(146, 23)
        tropical.TabIndex = 27
        tropical.Text = "Tropical Sunrise"
        ' 
        ' algeria
        ' 
        algeria.AutoSize = True
        algeria.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        algeria.Location = New Point(383, 382)
        algeria.Name = "algeria"
        algeria.Size = New Size(134, 23)
        algeria.TabIndex = 28
        algeria.Text = "Algerian Pizza"
        ' 
        ' zaatar
        ' 
        zaatar.AutoSize = True
        zaatar.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        zaatar.Location = New Point(383, 427)
        zaatar.Name = "zaatar"
        zaatar.Size = New Size(73, 23)
        zaatar.TabIndex = 29
        zaatar.Text = "Za'atar"
        ' 
        ' gourmet
        ' 
        gourmet.AutoSize = True
        gourmet.Font = New Font("Times New Roman", 20F, FontStyle.Bold)
        gourmet.Location = New Point(383, 108)
        gourmet.Name = "gourmet"
        gourmet.Size = New Size(236, 31)
        gourmet.TabIndex = 30
        gourmet.Text = "Gourmet $13.50 ea"
        ' 
        ' pricetext
        ' 
        pricetext.AutoEllipsis = True
        pricetext.AutoSize = True
        pricetext.Font = New Font("Times New Roman", 20F, FontStyle.Bold)
        pricetext.Location = New Point(28, 492)
        pricetext.Name = "pricetext"
        pricetext.Size = New Size(143, 31)
        pricetext.TabIndex = 31
        pricetext.Text = "Total Price"
        ' 
        ' totaltext
        ' 
        totaltext.AutoSize = True
        totaltext.Font = New Font("Times New Roman", 20F, FontStyle.Bold)
        totaltext.Location = New Point(48, 532)
        totaltext.Name = "totaltext"
        totaltext.Size = New Size(93, 31)
        totaltext.TabIndex = 32
        totaltext.Text = "[Price]"
        ' 
        ' menbutton
        ' 
        menbutton.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menbutton.Location = New Point(476, 500)
        menbutton.Name = "menbutton"
        menbutton.Size = New Size(267, 63)
        menbutton.TabIndex = 35
        menbutton.Text = "Back to Main Menu"
        menbutton.UseVisualStyleBackColor = True
        ' 
        ' complete
        ' 
        complete.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        complete.Location = New Point(228, 500)
        complete.Name = "complete"
        complete.Size = New Size(228, 63)
        complete.TabIndex = 37
        complete.Text = "Complete Order"
        complete.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ToolTip
        ' 
        ToolTip.Tag = "Don't click unless everything is complete"
        ToolTip.ToolTipTitle = "Warning"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Menu
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(755, 663)
        Controls.Add(complete)
        Controls.Add(menbutton)
        Controls.Add(totaltext)
        Controls.Add(pricetext)
        Controls.Add(gourmet)
        Controls.Add(zaatar)
        Controls.Add(algeria)
        Controls.Add(tropical)
        Controls.Add(truffle)
        Controls.Add(zaatarcmbox)
        Controls.Add(tropicalcmbox)
        Controls.Add(algeriacmbox)
        Controls.Add(trufflecmbox)
        Controls.Add(hootiecmbox)
        Controls.Add(vegancmbox)
        Controls.Add(lahmacuncmbox)
        Controls.Add(classiccombobox)
        Controls.Add(chocolatecombobox)
        Controls.Add(honolulucombobox)
        Controls.Add(middlecombobox)
        Controls.Add(autumncombobox)
        Controls.Add(seacombobox)
        Controls.Add(meatcombobox)
        Controls.Add(rich)
        Controls.Add(vegan)
        Controls.Add(lahmacun)
        Controls.Add(classic)
        Controls.Add(chocolate)
        Controls.Add(honolulu)
        Controls.Add(middlepizza)
        Controls.Add(autumn)
        Controls.Add(sea)
        Controls.Add(meataholic)
        Controls.Add(standard)
        Controls.Add(pizzamen)
        Name = "Form3"
        Text = "Form3"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pizzamen As Label
    Friend WithEvents standard As Label
    Friend WithEvents meataholic As Label
    Friend WithEvents sea As Label
    Friend WithEvents autumn As Label
    Friend WithEvents middlepizza As Label
    Friend WithEvents honolulu As Label
    Friend WithEvents chocolate As Label
    Friend WithEvents classic As Label
    Friend WithEvents lahmacun As Label
    Friend WithEvents vegan As Label
    Friend WithEvents rich As Label
    Friend WithEvents meatcombobox As ComboBox
    Friend WithEvents seacombobox As ComboBox
    Friend WithEvents autumncombobox As ComboBox
    Friend WithEvents middlecombobox As ComboBox
    Friend WithEvents honolulucombobox As ComboBox
    Friend WithEvents chocolatecombobox As ComboBox
    Friend WithEvents classiccombobox As ComboBox
    Friend WithEvents lahmacuncmbox As ComboBox
    Friend WithEvents vegancmbox As ComboBox
    Friend WithEvents hootiecmbox As ComboBox
    Friend WithEvents trufflecmbox As ComboBox
    Friend WithEvents algeriacmbox As ComboBox
    Friend WithEvents tropicalcmbox As ComboBox
    Friend WithEvents zaatarcmbox As ComboBox
    Friend WithEvents truffle As Label
    Friend WithEvents tropical As Label
    Friend WithEvents algeria As Label
    Friend WithEvents zaatar As Label
    Friend WithEvents gourmet As Label
    Friend WithEvents pricetext As Label
    Friend WithEvents totaltext As Label
    Friend WithEvents menbutton As Button
    Friend WithEvents complete As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
