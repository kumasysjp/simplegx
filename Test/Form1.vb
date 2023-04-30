Imports SimpleGXSimu


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ins As New GXSim
        ins.CPU = enumCPU._Non

        Dim rtn As ReturnUS = ins.ReadDeviceBlock2("D0", 10)

        MsgBox(ins.UShortDis(rtn.dat, "/"))


        Dim dat(960) As UShort : For i = 0 To 959 : dat(i) = i + 1 : Next

        ins.WriteDeviceBlock2("D0", 960, dat)








    End Sub
End Class
