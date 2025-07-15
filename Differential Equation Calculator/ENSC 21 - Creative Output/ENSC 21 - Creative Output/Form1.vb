Imports System.Drawing.Drawing2D
Imports System.Numerics
Imports excel = Microsoft.Office.Interop.Excel
Public Class Form1

    Dim Matrix(,) As Double = {{5, -4, 1}, {4, 5, 0}}
    Dim intn, Coef() As Double
    Dim ratio As Double
    Dim spacing As Integer = 1
    Dim m, n, l As Double
    Private Sub pnlinput_Paint(sender As Object, e As PaintEventArgs) Handles pnlinput.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlinput.BackColor = Color.White
        RoundPanelCorners(pnlinput, 20)
        pnlsoln.BackColor = Color.White
        RoundPanelCorners(pnlsoln, 20)
        btnCalculate.ForeColor = Color.White
        btnCalculate.BackColor = Color.ForestGreen
        btnReset.ForeColor = Color.White
        btnReset.BackColor = Color.ForestGreen
        btnReset.Enabled = False

    End Sub

    Sub RoundPanelCorners(ByVal panel As Panel, ByVal radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New System.Drawing.Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New System.Drawing.Rectangle(panel.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New System.Drawing.Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90)
        path.AddArc(New System.Drawing.Rectangle(0, panel.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub

    Private Sub pnlinput_MouseEnter(sender As Object, e As EventArgs) Handles Label.MouseEnter, pnlinput.MouseEnter, txta.MouseEnter, txtb.MouseEnter, txtc.MouseEnter, Label1.MouseEnter, Label4.MouseEnter, Label2.MouseEnter, Label3.MouseEnter, Label.MouseEnter, txtrhs.MouseEnter, Label5.MouseEnter
        pnlinput.BackColor = Color.ForestGreen
        Label1.ForeColor = Color.White
        Label.ForeColor = Color.White
        Label4.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
        Label5.ForeColor = Color.White
    End Sub

    Private Sub pnlinput_MouseLeave(sender As Object, e As EventArgs) Handles pnlinput.MouseLeave
        pnlinput.BackColor = Color.White
        Label1.ForeColor = Color.Black
        Label.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
    End Sub

    Private Sub pnlsoln_MouseEnter(sender As Object, e As EventArgs) Handles pnlsoln.MouseEnter, txtsoln.MouseEnter, Label11.MouseEnter
        pnlsoln.BackColor = Color.ForestGreen
        Label11.ForeColor = Color.White
    End Sub

    Private Sub pnlsoln_MouseLeave(sender As Object, e As EventArgs) Handles pnlsoln.MouseLeave
        pnlsoln.BackColor = Color.White
        Label11.ForeColor = Color.Black

    End Sub

    Private Sub btnCalculate_MouseEnter(sender As Object, e As EventArgs) Handles btnCalculate.MouseEnter
        btnCalculate.BackColor = Color.LimeGreen
        btnCalculate.ForeColor = Color.Black
    End Sub

    Private Sub btnCalculate_MouseLeave(sender As Object, e As EventArgs) Handles btnCalculate.MouseLeave
        btnCalculate.BackColor = Color.ForestGreen
        btnCalculate.ForeColor = Color.White
    End Sub

    Private Sub btnReset_MouseEnter(sender As Object, e As EventArgs) Handles btnReset.MouseEnter
        btnReset.BackColor = Color.LimeGreen
        btnReset.ForeColor = Color.Black
    End Sub

    Private Sub btnReset_MouseLeave(sender As Object, e As EventArgs) Handles btnReset.MouseLeave
        btnReset.BackColor = Color.ForestGreen
        btnReset.ForeColor = Color.White
    End Sub

    Private Sub txta_MouseEnter(sender As Object, e As EventArgs) Handles txta.MouseEnter
        txta.BackColor = Color.Gainsboro
    End Sub

    Private Sub txta_MouseLeave(sender As Object, e As EventArgs) Handles txta.MouseLeave
        txta.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtb_MouseEnter(sender As Object, e As EventArgs) Handles txtb.MouseEnter
        txtb.BackColor = Color.Gainsboro
    End Sub

    Private Sub txtb_MouseLeave(sender As Object, e As EventArgs) Handles txtb.MouseLeave
        txtb.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtc_MouseEnter(sender As Object, e As EventArgs) Handles txtc.MouseEnter
        txtc.BackColor = Color.Gainsboro
    End Sub

    Private Sub txtc_MouseLeave(sender As Object, e As EventArgs) Handles txtc.MouseLeave
        txtc.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub txtrhs_MouseEnter(sender As Object, e As EventArgs) Handles txtrhs.MouseEnter
        txtrhs.BackColor = Color.Gainsboro
    End Sub

    Private Sub txtrhs_MouseLeave(sender As Object, e As EventArgs) Handles txtrhs.MouseLeave
        txtrhs.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txta.Clear()
        txtb.Clear()
        txtc.Clear()
        txtrhs.Clear()
        txtsoln.Clear()
        btnReset.Enabled = False

    End Sub

    Private Sub txtsoln_MouseEnter(sender As Object, e As EventArgs) Handles txtsoln.MouseEnter
        txtsoln.BackColor = Color.Gainsboro
    End Sub

    Private Sub txtsoln_MouseLeave(sender As Object, e As EventArgs) Handles txtsoln.MouseLeave
        txtsoln.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        btnReset.Enabled = True
        Dim first As Integer = txta.Text
        Dim b As Integer = txtb.Text
        Dim c As Integer = txtc.Text
        Dim rhsStr As String = txtrhs.Text.Trim().ToLower()
        Dim strsoln As String

        Select Case rhsStr
            Case "0"
                Dim D As Double = b * b - 4 * first * c
                Dim r1, r2 As String

                If D >= 0 Then
                    r1 = (-b + Math.Sqrt(D)) / (2 * first)
                    r2 = (-b - Math.Sqrt(D)) / (2 * first)
                    strsoln = "y(x) = Ce^" & r1 + "x + Ce^" & r2 & "x"
                    txtsoln.Text = strsoln
                Else
                    ' Use Complex.Sqrt for imaginary roots
                    Dim r3, r4 As String

                    r4 = Math.Sqrt(Math.Abs((b ^ 2) - 4 * first * c)) / (2 * first)
                    r3 = -b / (2 * first)
                    strsoln = "y(x) = e^" & r3 & "x [C1 cos (" & r4 + ")x + C2 sin (" & r4 & ")x]"
                    txtsoln.Text = strsoln
                End If


            Case Else
                Dim D As Double = b * b - 4 * first * c
                Dim r1, r2 As String
                Dim r3, r4 As String
                Dim ypForm As String = ""
                Dim ypprimeForm As String = ""
                Dim ypdblprimeForm As String = ""

                If D >= 0 Then
                    r1 = (-b + Math.Sqrt(D)) / (2 * first)
                    r2 = (-b - Math.Sqrt(D)) / (2 * first)
                    strsoln = "y(x) = Ce^" & r1 + "x + Ce^" & r2 & "x"


                Else
                    ' Use Complex.Sqrt for imaginary roots
                    r4 = Math.Sqrt(Math.Abs((b ^ 2) - 4 * first * c)) / (2 * first)
                    r3 = -b / (2 * first)
                    strsoln = "y(x) = e^" & r3 & "x [C1 cos (" & r4 + ")x + C2 sin (" & r4 & ")x]"

                    ypForm = "Ae^(2x) + Bcos(x) + Csin(x)"
                    ypprimeForm = "2Ae^(2x) - Bsin(x) + Ccos(x)"
                    ypdblprimeForm = "(4Ae^(2x) - Bcos(x) - Csin(x)"
                    Dim LHS As String = "(" & ypdblprimeForm & ") - 4 * (" & ypprimeForm & ") + 6 * (" & ypForm & ")"
                    Dim LHSGrouped As String = "(2A) * e^(2x) + (5B - 4C) * cos(x) + (5B + 4B) * sin(x)"
                    Dim RHS As String = "RHS = e^(2x) + cos(x)"
                    RHS = LHSGrouped
                    Dim eqnofe = "2A = 1"
                    Dim eqnofcos = "5B - 4C = 1"
                    Dim eqnofsin = "4B + 5C = 0"


                    m = 1 / 2
                    intn = 2

                    ReDim Coef(intn - 1)

                    Dim oxl As New excel.Application
                    oxl.Visible = True
                    Dim owb As excel.Workbook = oxl.Workbooks.Add
                    Dim osheet As excel.Worksheet = owb.Sheets("Sheet1")
                    With osheet
                        For M11 As Integer = 1 To intn
                            For M12 As Integer = 1 To intn + 1
                                .Cells(M11, M12).Value = Matrix(M11 - 1, M12 - 1)
                            Next
                        Next
                        spacing += intn + 1
                        For Elim1 As Integer = 0 To intn - 2
                            For Elim11 As Integer = Elim1 + 1 To intn - 1
                                ratio = Matrix(Elim11, Elim1) / Matrix(Elim1, Elim1)

                                For Elim2 As Integer = Elim1 To intn
                                    Matrix(Elim11, Elim2) = Matrix(Elim11, Elim2) - ratio * Matrix(Elim1, Elim2)
                                Next

                                ' Log matrix after this row operation
                                For W11 As Integer = 0 To intn - 1
                                    For W12 As Integer = 0 To intn
                                        .Cells(spacing + W11, W12 + 1).Value = Matrix(W11, W12)
                                    Next
                                Next

                                spacing += intn + 1 ' Leave space between steps
                            Next
                        Next

                        ' Back substitution
                        Coef(intn - 1) = Matrix(intn - 1, intn) / Matrix(intn - 1, intn - 1)
                        For Sub1 = intn - 2 To 0 Step -1
                            Coef(Sub1) = Matrix(Sub1, intn)
                            For Sub12 = Sub1 + 1 To intn - 1
                                Coef(Sub1) = Coef(Sub1) - Matrix(Sub1, Sub12) * Coef(Sub12)
                            Next
                            Coef(Sub1) = Coef(Sub1) / Matrix(Sub1, Sub1)
                        Next

                        ' Write solution below final matrix
                        Dim outputRow As Integer = spacing + intn + 1
                        For Out As Integer = 0 To intn - 1
                            .Cells(outputRow + Out, 1).Value = "x" & (Out + 1) & " = " & Coef(Out)

                        Next
                        n = Coef(0)
                        l = Coef(1)
                    End With
                    Me.Show()
                    txtsoln.Text = strsoln & "+" & m & "e^(2x)" & "+" & n & "cos(x)" & "+" & l & "sin(x)"

                End If


        End Select


    End Sub


End Class
