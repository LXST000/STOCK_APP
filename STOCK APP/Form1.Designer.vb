<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Lbl_AP_Caption = New TextBox()
        Lbl_SQ_Caption = New TextBox()
        Lbl_BD_Caption = New TextBox()
        Lbl_BQ_Caption = New TextBox()
        Lbl_LP_Caption = New TextBox()
        Lbl_Vol_Caption = New TextBox()
        Txt_Quantity_Text = New TextBox()
        Lbl_MV_Caption = New TextBox()
        Lbl_AVP_Caption = New TextBox()
        Lbl_TQ_Caption = New TextBox()
        Lbl_BV_Caption = New TextBox()
        Lbl_PL_Caption = New TextBox()
        Txt_Price_Text = New TextBox()
        Label14 = New Label()
        PictureBox1 = New PictureBox()
        Label15 = New Label()
        PictureBox2 = New PictureBox()
        Cmd_Submit_Click = New Button()
        Opt_Sell = New RadioButton()
        Opt_Buy = New RadioButton()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 0
        Label1.Text = "Ask Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(179, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 1
        Label2.Text = "Sell Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(303, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 2
        Label3.Text = "Bid Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(425, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 3
        Label4.Text = "Buy Quantity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(548, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 4
        Label5.Text = "Last Price"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(675, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 15)
        Label6.TabIndex = 5
        Label6.Text = "L/Volume"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(314, 163)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 15)
        Label7.TabIndex = 6
        Label7.Text = "Quantity"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(334, 199)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 15)
        Label8.TabIndex = 7
        Label8.Text = "Price"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(101, 313)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 15)
        Label9.TabIndex = 8
        Label9.Text = "Averidge Price"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(225, 313)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 15)
        Label10.TabIndex = 9
        Label10.Text = "Total Quantity"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(362, 313)
        Label11.Name = "Label11"
        Label11.Size = New Size(58, 15)
        Label11.TabIndex = 10
        Label11.Text = "Buy Value"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(458, 313)
        Label12.Name = "Label12"
        Label12.Size = New Size(107, 15)
        Label12.TabIndex = 11
        Label12.Text = "Gross Market Value"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(608, 313)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 15)
        Label13.TabIndex = 12
        Label13.Text = "Profit/Loss"
        ' 
        ' Lbl_AP_Caption
        ' 
        Lbl_AP_Caption.Location = New Point(27, 60)
        Lbl_AP_Caption.Name = "Lbl_AP_Caption"
        Lbl_AP_Caption.Size = New Size(100, 23)
        Lbl_AP_Caption.TabIndex = 13
        ' 
        ' Lbl_SQ_Caption
        ' 
        Lbl_SQ_Caption.Location = New Point(154, 60)
        Lbl_SQ_Caption.Name = "Lbl_SQ_Caption"
        Lbl_SQ_Caption.Size = New Size(100, 23)
        Lbl_SQ_Caption.TabIndex = 14
        ' 
        ' Lbl_BD_Caption
        ' 
        Lbl_BD_Caption.Location = New Point(275, 60)
        Lbl_BD_Caption.Name = "Lbl_BD_Caption"
        Lbl_BD_Caption.Size = New Size(100, 23)
        Lbl_BD_Caption.TabIndex = 15
        ' 
        ' Lbl_BQ_Caption
        ' 
        Lbl_BQ_Caption.Location = New Point(401, 60)
        Lbl_BQ_Caption.Name = "Lbl_BQ_Caption"
        Lbl_BQ_Caption.Size = New Size(100, 23)
        Lbl_BQ_Caption.TabIndex = 16
        ' 
        ' Lbl_LP_Caption
        ' 
        Lbl_LP_Caption.Location = New Point(523, 60)
        Lbl_LP_Caption.Name = "Lbl_LP_Caption"
        Lbl_LP_Caption.Size = New Size(100, 23)
        Lbl_LP_Caption.TabIndex = 17
        ' 
        ' Lbl_Vol_Caption
        ' 
        Lbl_Vol_Caption.Location = New Point(651, 60)
        Lbl_Vol_Caption.Name = "Lbl_Vol_Caption"
        Lbl_Vol_Caption.Size = New Size(100, 23)
        Lbl_Vol_Caption.TabIndex = 18
        ' 
        ' Txt_Quantity_Text
        ' 
        Txt_Quantity_Text.Location = New Point(391, 163)
        Txt_Quantity_Text.Name = "Txt_Quantity_Text"
        Txt_Quantity_Text.Size = New Size(100, 23)
        Txt_Quantity_Text.TabIndex = 19
        ' 
        ' Lbl_MV_Caption
        ' 
        Lbl_MV_Caption.Location = New Point(458, 349)
        Lbl_MV_Caption.Name = "Lbl_MV_Caption"
        Lbl_MV_Caption.Size = New Size(100, 23)
        Lbl_MV_Caption.TabIndex = 20
        ' 
        ' Lbl_AVP_Caption
        ' 
        Lbl_AVP_Caption.Location = New Point(91, 349)
        Lbl_AVP_Caption.Name = "Lbl_AVP_Caption"
        Lbl_AVP_Caption.Size = New Size(100, 23)
        Lbl_AVP_Caption.TabIndex = 21
        ' 
        ' Lbl_TQ_Caption
        ' 
        Lbl_TQ_Caption.Location = New Point(216, 349)
        Lbl_TQ_Caption.Name = "Lbl_TQ_Caption"
        Lbl_TQ_Caption.Size = New Size(100, 23)
        Lbl_TQ_Caption.TabIndex = 22
        ' 
        ' Lbl_BV_Caption
        ' 
        Lbl_BV_Caption.Location = New Point(338, 349)
        Lbl_BV_Caption.Name = "Lbl_BV_Caption"
        Lbl_BV_Caption.Size = New Size(100, 23)
        Lbl_BV_Caption.TabIndex = 23
        ' 
        ' Lbl_PL_Caption
        ' 
        Lbl_PL_Caption.Location = New Point(582, 349)
        Lbl_PL_Caption.Name = "Lbl_PL_Caption"
        Lbl_PL_Caption.Size = New Size(100, 23)
        Lbl_PL_Caption.TabIndex = 24
        ' 
        ' Txt_Price_Text
        ' 
        Txt_Price_Text.Location = New Point(391, 196)
        Txt_Price_Text.Name = "Txt_Price_Text"
        Txt_Price_Text.Size = New Size(100, 23)
        Txt_Price_Text.TabIndex = 25
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Black
        Label14.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = Color.White
        Label14.Location = New Point(325, 261)
        Label14.Name = "Label14"
        Label14.Size = New Size(141, 25)
        Label14.TabIndex = 26
        Label14.Text = "Shares At Hand"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-28, 255)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(808, 37)
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = SystemColors.ActiveCaptionText
        Label15.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.ForeColor = Color.White
        Label15.Location = New Point(342, 106)
        Label15.Name = "Label15"
        Label15.Size = New Size(112, 25)
        Label15.TabIndex = 27
        Label15.Text = "Order Panel"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-13, 98)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(808, 40)
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' Cmd_Submit_Click
        ' 
        Cmd_Submit_Click.Location = New Point(564, 179)
        Cmd_Submit_Click.Name = "Cmd_Submit_Click"
        Cmd_Submit_Click.Size = New Size(118, 40)
        Cmd_Submit_Click.TabIndex = 30
        Cmd_Submit_Click.Text = "Submit"
        Cmd_Submit_Click.TextImageRelation = TextImageRelation.ImageAboveText
        Cmd_Submit_Click.UseVisualStyleBackColor = True
        ' 
        ' Opt_Sell
        ' 
        Opt_Sell.AutoSize = True
        Opt_Sell.Location = New Point(71, 207)
        Opt_Sell.Name = "Opt_Sell"
        Opt_Sell.Size = New Size(43, 19)
        Opt_Sell.TabIndex = 31
        Opt_Sell.TabStop = True
        Opt_Sell.Text = "Sell"
        Opt_Sell.UseVisualStyleBackColor = True
        ' 
        ' Opt_Buy
        ' 
        Opt_Buy.AutoSize = True
        Opt_Buy.Location = New Point(71, 167)
        Opt_Buy.Name = "Opt_Buy"
        Opt_Buy.Size = New Size(45, 19)
        Opt_Buy.TabIndex = 32
        Opt_Buy.TabStop = True
        Opt_Buy.Text = "Buy"
        Opt_Buy.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(762, 392)
        Controls.Add(Opt_Buy)
        Controls.Add(Opt_Sell)
        Controls.Add(Cmd_Submit_Click)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Txt_Price_Text)
        Controls.Add(Lbl_PL_Caption)
        Controls.Add(Lbl_BV_Caption)
        Controls.Add(Lbl_TQ_Caption)
        Controls.Add(Lbl_AVP_Caption)
        Controls.Add(Lbl_MV_Caption)
        Controls.Add(Txt_Quantity_Text)
        Controls.Add(Lbl_Vol_Caption)
        Controls.Add(Lbl_LP_Caption)
        Controls.Add(Lbl_BQ_Caption)
        Controls.Add(Lbl_BD_Caption)
        Controls.Add(Lbl_SQ_Caption)
        Controls.Add(Lbl_AP_Caption)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Lbl_AP_Caption As TextBox
    Friend WithEvents Lbl_SQ_Caption As TextBox
    Friend WithEvents Lbl_BD_Caption As TextBox
    Friend WithEvents Lbl_BQ_Caption As TextBox
    Friend WithEvents Lbl_LP_Caption As TextBox
    Friend WithEvents Lbl_Vol_Caption As TextBox
    Friend WithEvents Txt_Quantity_Text As TextBox
    Friend WithEvents Lbl_MV_Caption As TextBox
    Friend WithEvents Lbl_AVP_Caption As TextBox
    Friend WithEvents Lbl_TQ_Caption As TextBox
    Friend WithEvents Lbl_BV_Caption As TextBox
    Friend WithEvents Lbl_PL_Caption As TextBox
    Friend WithEvents Txt_Price_Text As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Cmd_Submit_Click As Button
    Friend WithEvents Opt_Sell As RadioButton
    Friend WithEvents Opt_Buy As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
