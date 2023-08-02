Imports System.Runtime.Intrinsics.X86

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ranNum1, ranNum2, ranNum3, ranNum4 As Double
        Dim AP As Single
        Dim SQ As Integer
        Dim BD As Single
        Dim BQ As Integer
        Dim OQ As Long
        Dim OP As Single
        Dim LP As Single
        Dim LVOL As Integer
        Dim AVP As Single
        Dim TQ As Long
        Dim BV As Single
        Dim MV As Single
        Dim PL As Single

        Randomize()
        ranNum1 = Rnd() * 2 + 3
        ranNum2 = Rnd() * 2 + 3
        ranNum3 = Rnd() * 2 + 3
        ranNum4 = Rnd() * 2 + 3
        AVP = Round(ranNum1, 3) * 5 ' Average Price
        TQ = Int(Round(Rnd(), 2) * 10000) + 1000 'Total Shares at Hand
        BV = AVP * TQ 'Buy Value
        AP = Round(ranNum2, 3) * 5 'Asking Price
        SQ = Int(Round(Rnd(), 2) * 10000) + 1000
        BD = Round(ranNum2, 3) * 5 'Bidding Price
        BQ = Int(Round(Rnd(), 2) * 10000) + 1000
        LP = Round(ranNum2, 3) * 5 'Last Done Price
        MV = LP * TQ
        PL = MV - BV
        LVOL = Int(Round(Rnd(), 2) * 10000) + 1000 'Last Done Volume
        Lbl_AP_Caption = AP
        Lbl_SQ_Caption = SQ
        Lbl_BD_Caption = BD
        Lbl_BQ_Caption = BQ
        Lbl_LP_Caption = OP
        Lbl_AVP_Caption = AVP
        Lbl_TQ_Caption = TQ
        Lbl_MV_Caption = Format(MV, "#,##.00")
        Lbl_PL_Caption = Format(PL, "#,##.00")
        Lbl_LP_Caption = Format(LP, "#,##.00")
        Lbl_BV_Caption = Format(BV, "#,##.00")
        Lbl_Vol_Caption = LVOL
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles Lbl_TQ_Caption.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles Lbl_AVP_Caption.TextChanged

    End Sub


    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Cmd_Submit_Click_Click(sender As Object, e As EventArgs) Handles Cmd_Submit_Click.Click
        Dim ranNum1, ranNum2, randNum3, ranNum4 As Double
        Dim AP As Single
        Dim SQ As Integer
        Dim BD As Single
        Dim BQ As Integer
        Dim OQ As Long
        Dim OP As Single
        Dim LP As Single
        Dim LVOL As Integer
        Dim AVP As Single
        Dim TQ As Long
        Dim BV As Single
        Dim MV As Single
        Dim PL As Single

        OQ = Val(Txt_Quantity_Text.Text)
        OP = Val(Txt_Price_Text.Text)
        LP = Val(Lbl_LP_Caption.Text)
        If Opt_Buy.Checked = True And BV >= 1000 Then
            AVP = (AVP * TQ + OP * OQ) / (TQ + OQ)
            TQ = TQ + OQ
            Lbl_TQ_Caption.Text = TQ.ToString()
            MV = LP * TQ
            BV = TQ * AVP
            PL = MV - BV
            Lbl_MV_Caption.Text = Format(MV, "#,##.00")
            Lbl_BV_Caption.Text = Format(BV, "#,##.00")
            Lbl_PL_Caption.Text = Format(PL, "#,##.00")
            Lbl_AVP_Caption.Text = Format(AVP, "#,##.00")
        ElseIf Opt_Buy.Checked = True And BV < 1000 Then
            MsgBox("You don't have enough funds to buy, reduce order")
        ElseIf Opt_Sell.Checked = True And TQ >= OQ Then
            AVP = (AVP * TQ + OP * OQ) / (TQ + OQ)
            TQ = TQ - OQ
            Lbl_TQ_Caption.Text = TQ.ToString()
            MV = LP * TQ
            BV = TQ * AVP
            PL = MV - BV
            Lbl_MV_Caption.Text = Format(MV, "#,##.00")
            Lbl_BV_Caption.Text = Format(BV, "#,##.00")
            Lbl_PL_Caption.Text = Format(PL, "#,##.00")
            Lbl_AVP_Caption.Text = Format(AVP, "#,##.00")
        ElseIf Opt_Sell.Checked = True And TQ < OQ Then
            MsgBox("Not enough shares, reduce order")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim ranNum1, ranNum2, ranNum3, ranNum4 As Double
        Dim AP As Single
        Dim SQ As Integer
        Dim BD As Single
        Dim BQ As Integer
        Dim OQ As Long
        Dim OP As Single
        Dim LP As Single
        Dim LVOL As Integer
        Dim AVP As Single
        Dim TQ As Long
        Dim BV As Single
        Dim MV As Single
        Dim PL As Single


        ranNum2 = Rnd() * 2 + 3
        ranNum3 = Rnd() * 2 + 3
        Lbl_AP_Caption.Text = Round(ranNum1, 3) * 5
        SQ = Int(Round(Rnd(), 2) * 10000) + 1000
        BD = Round(ranNum2, 3) * 5
        BQ = Int(Round(Rnd(), 2) * 10000) + 1000
        LP = Round(ranNum3, 3) * 5 'Last Done Price
        LVOL = Int(Round(Rnd(), 2) * 10000) + 1000 'Last Done Volume

    End Sub

    Private Sub Lbl_LP_Caption_TextChanged(sender As Object, e As EventArgs) Handles Lbl_LP_Caption.TextChanged

    End Sub
End Class
