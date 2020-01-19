Public Class Form1
    Dim second As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        second = second + 1

        ' This will display 0 in the layout
        If second = 1 Then
            A.BackColor = Color.Red
            B.BackColor = Color.Red
            C.BackColor = Color.Red
            D.BackColor = Color.Red
            EDisplay.BackColor = Color.Red
            F.BackColor = Color.Red
            G.BackColor = SystemColors.Control

            ' This will display 1 in the layout
        ElseIf second = 2 Then
            A.BackColor = SystemColors.Control
            B.BackColor = Color.Red
            C.BackColor = Color.Red
            D.BackColor = SystemColors.Control
            EDisplay.BackColor = SystemColors.Control
            F.BackColor = SystemColors.Control
            G.BackColor = SystemColors.Control

            ' This will display 2 in the layout
        ElseIf second = 3 Then
            A.BackColor = Color.Red
            B.BackColor = Color.Red
            C.BackColor = SystemColors.Control
            D.BackColor = Color.Red
            EDisplay.BackColor = Color.Red
            F.BackColor = SystemColors.Control
            G.BackColor = Color.Red

            ' This will display 3 in the layout
        ElseIf second = 4 Then
            A.BackColor = Color.Red
            B.BackColor = Color.Red
            C.BackColor = Color.Red
            D.BackColor = Color.Red
            EDisplay.BackColor = SystemColors.Control
            F.BackColor = SystemColors.Control
            G.BackColor = Color.Red

            ' This will display 4 in the layout
        ElseIf second = 5 Then
            A.BackColor = SystemColors.Control
            B.BackColor = Color.Red
            C.BackColor = Color.Red
            D.BackColor = SystemColors.Control
            EDisplay.BackColor = SystemColors.Control
            F.BackColor = Color.Red
            G.BackColor = Color.Red

            ' This will display 5 in the layout
        ElseIf second = 6 Then
            A.BackColor = Color.Red
            B.BackColor = SystemColors.Control
            C.BackColor = Color.Red
            D.BackColor = Color.Red
            EDisplay.BackColor = SystemColors.Control
            F.BackColor = Color.Red
            G.BackColor = Color.Red

            ' This will display 6 in the layout
        ElseIf second = 7 Then
            A.BackColor = Color.Red
            B.BackColor = SystemColors.Control
            C.BackColor = Color.Red
            D.BackColor = Color.Red
            EDisplay.BackColor = Color.Red
            F.BackColor = Color.Red
            G.BackColor = Color.Red

            ' This will display 7 in the layout
        ElseIf second = 8 Then
            A.BackColor = Color.Red
            B.BackColor = Color.Red
            C.BackColor = Color.Red
            D.BackColor = SystemColors.Control
            EDisplay.BackColor = SystemColors.Control
            F.BackColor = SystemColors.Control
            G.BackColor = SystemColors.Control

            ' This will display 8 in the layout
        ElseIf second = 9 Then
            A.BackColor = Color.Red
            B.BackColor = Color.Red
            C.BackColor = Color.Red
            D.BackColor = Color.Red
            EDisplay.BackColor = Color.Red
            F.BackColor = Color.Red
            G.BackColor = Color.Red

            ' This will display 9 in the layout
        ElseIf second = 10 Then
            A.BackColor = Color.Red
            B.BackColor = Color.Red
            C.BackColor = Color.Red
            D.BackColor = Color.Red
            EDisplay.BackColor = SystemColors.Control
            F.BackColor = Color.Red
            G.BackColor = Color.Red

            ' This will display 0 in the layout
        ElseIf second = 11 Then
            A.BackColor = Color.Red
            B.BackColor = Color.Red
            C.BackColor = Color.Red
            D.BackColor = Color.Red
            EDisplay.BackColor = Color.Red
            F.BackColor = Color.Red
            G.BackColor = SystemColors.Control
        End If
    End Sub
End Class
