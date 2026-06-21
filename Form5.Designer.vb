<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Label1 = New Label()
        Customerdetailstitle = New Label()
        pizzatitle = New Label()
        quanitiestitle = New Label()
        costtitle = New Label()
        totalcosttitle = New Label()
        Reset1 = New Button()
        Backtomenu = New Button()
        Totalcost = New Label()
        Costseachpizza = New Label()
        Quanities = New Label()
        Pizzas = New Label()
        Deliverydetail = New Label()
        Print = New Button()
        PrintDocument = New Printing.PrintDocument()
        PrintPreviewDialog = New PrintPreviewDialog()
        Printpreview = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 45)
        Label1.TabIndex = 0
        Label1.Text = "Order Summary"
        ' 
        ' Customerdetailstitle
        ' 
        Customerdetailstitle.AutoSize = True
        Customerdetailstitle.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Customerdetailstitle.LiveSetting = Automation.AutomationLiveSetting.Polite
        Customerdetailstitle.Location = New Point(26, 109)
        Customerdetailstitle.Name = "Customerdetailstitle"
        Customerdetailstitle.Size = New Size(214, 35)
        Customerdetailstitle.TabIndex = 1
        Customerdetailstitle.Text = "Delivery Details"
        ' 
        ' pizzatitle
        ' 
        pizzatitle.AutoSize = True
        pizzatitle.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pizzatitle.Location = New Point(319, 109)
        pizzatitle.Name = "pizzatitle"
        pizzatitle.Size = New Size(92, 35)
        pizzatitle.TabIndex = 2
        pizzatitle.Text = "Pizzas"
        ' 
        ' quanitiestitle
        ' 
        quanitiestitle.AutoSize = True
        quanitiestitle.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        quanitiestitle.Location = New Point(676, 109)
        quanitiestitle.Name = "quanitiestitle"
        quanitiestitle.Size = New Size(135, 35)
        quanitiestitle.TabIndex = 3
        quanitiestitle.Text = "Quanities"
        ' 
        ' costtitle
        ' 
        costtitle.AutoSize = True
        costtitle.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        costtitle.Location = New Point(1001, 109)
        costtitle.Name = "costtitle"
        costtitle.Size = New Size(74, 35)
        costtitle.TabIndex = 4
        costtitle.Text = "Cost"
        ' 
        ' totalcosttitle
        ' 
        totalcosttitle.AutoSize = True
        totalcosttitle.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalcosttitle.Location = New Point(26, 560)
        totalcosttitle.Name = "totalcosttitle"
        totalcosttitle.Size = New Size(146, 35)
        totalcosttitle.TabIndex = 5
        totalcosttitle.Text = "Total Cost"
        ' 
        ' Reset1
        ' 
        Reset1.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Reset1.Location = New Point(948, 12)
        Reset1.Name = "Reset1"
        Reset1.Size = New Size(194, 85)
        Reset1.TabIndex = 6
        Reset1.Text = "Reset"
        Reset1.UseVisualStyleBackColor = True
        ' 
        ' Backtomenu
        ' 
        Backtomenu.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Backtomenu.Location = New Point(720, 12)
        Backtomenu.Name = "Backtomenu"
        Backtomenu.Size = New Size(210, 85)
        Backtomenu.TabIndex = 7
        Backtomenu.Text = "Back to Menu"
        Backtomenu.UseVisualStyleBackColor = True
        ' 
        ' Totalcost
        ' 
        Totalcost.AutoSize = True
        Totalcost.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Totalcost.Location = New Point(37, 612)
        Totalcost.Name = "Totalcost"
        Totalcost.Size = New Size(42, 26)
        Totalcost.TabIndex = 8
        Totalcost.Text = "....."
        ' 
        ' Costseachpizza
        ' 
        Costseachpizza.AutoSize = True
        Costseachpizza.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        Costseachpizza.Location = New Point(1001, 177)
        Costseachpizza.Name = "Costseachpizza"
        Costseachpizza.Size = New Size(35, 23)
        Costseachpizza.TabIndex = 9
        Costseachpizza.Text = "....."
        ' 
        ' Quanities
        ' 
        Quanities.AutoSize = True
        Quanities.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        Quanities.Location = New Point(676, 177)
        Quanities.Name = "Quanities"
        Quanities.Size = New Size(35, 23)
        Quanities.TabIndex = 10
        Quanities.Text = "....."
        ' 
        ' Pizzas
        ' 
        Pizzas.AutoSize = True
        Pizzas.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        Pizzas.Location = New Point(319, 177)
        Pizzas.Name = "Pizzas"
        Pizzas.Size = New Size(35, 23)
        Pizzas.TabIndex = 11
        Pizzas.Text = "....."
        ' 
        ' Deliverydetail
        ' 
        Deliverydetail.AutoSize = True
        Deliverydetail.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        Deliverydetail.Location = New Point(26, 168)
        Deliverydetail.Name = "Deliverydetail"
        Deliverydetail.Size = New Size(35, 23)
        Deliverydetail.TabIndex = 12
        Deliverydetail.Text = "....."
        ' 
        ' Print
        ' 
        Print.Font = New Font("Times New Roman", 15F, FontStyle.Bold)
        Print.Location = New Point(948, 560)
        Print.Name = "Print"
        Print.Size = New Size(202, 102)
        Print.TabIndex = 13
        Print.Text = "Print Receipt"
        Print.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument
        ' 
        ' 
        ' PrintPreviewDialog
        ' 
        PrintPreviewDialog.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog.ClientSize = New Size(400, 300)
        PrintPreviewDialog.Enabled = True
        PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), Icon)
        PrintPreviewDialog.Name = "PrintPreviewDialog"
        PrintPreviewDialog.Visible = False
        ' 
        ' Printpreview
        ' 
        Printpreview.Font = New Font("Times New Roman", 15F, FontStyle.Bold)
        Printpreview.Location = New Point(720, 560)
        Printpreview.Name = "Printpreview"
        Printpreview.Size = New Size(202, 102)
        Printpreview.TabIndex = 14
        Printpreview.Text = "Print Preview"
        Printpreview.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1154, 674)
        Controls.Add(Printpreview)
        Controls.Add(Print)
        Controls.Add(Deliverydetail)
        Controls.Add(Pizzas)
        Controls.Add(Quanities)
        Controls.Add(Costseachpizza)
        Controls.Add(Totalcost)
        Controls.Add(Backtomenu)
        Controls.Add(Reset1)
        Controls.Add(totalcosttitle)
        Controls.Add(costtitle)
        Controls.Add(quanitiestitle)
        Controls.Add(pizzatitle)
        Controls.Add(Customerdetailstitle)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Customerdetailstitle As Label
    Friend WithEvents pizzatitle As Label
    Friend WithEvents quanitiestitle As Label
    Friend WithEvents costtitle As Label
    Friend WithEvents totalcosttitle As Label
    Friend WithEvents Reset1 As Button
    Friend WithEvents Backtomenu As Button
    Friend WithEvents Totalcost As Label
    Friend WithEvents Costseachpizza As Label
    Friend WithEvents Quanities As Label
    Friend WithEvents Pizzas As Label
    Friend WithEvents Deliverydetail As Label
    Friend WithEvents Print As Button
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents Printpreview As Button
End Class
