# simplegx
use C# on GX Simulator2 without MX Component

# 用途
趣味。業務用利用はどうかお控えください。利用によって損害は負いません。




## 内容物
- SimpleGXSimu.dll (要 .NET4.5互換 Runtime.  .NET DLL)
本体
- KumaNetCLI_x86.dll (要 VCpp2013 互換 Runtime.  C++/CLI DLL)
下記DLLの .NETラッパ
- KumaNet_x86.dll (要 VCpp2013 互換Runtime.  C++ DLL)
プロセス関係

これら 3つの DLL すべて必要です。


### CSharp
```cs
//using SimpleGXSimu でDLLを読み込んでください

            GXSim ins = new GXSim();
            ins.CPU =(int)enumCPU._Non;

            ReturnUS rtn = ins.ReadDeviceBlock2("D0",10);
            MessageBox.Show(ins.UShortDis(rtn.dat,"/"));

           ushort[] dat = new ushort[960];
           ushort i;
           for (i = 0; i < 959; i++) { dat[i] =(ushort)(i+1) ; }

           ins.WriteDeviceBlock2("D0",960,dat);
```

### VB.NET
```vb
'Imports SimpleGXSimu でDLLを読み込んでください

        Dim ins As New GXSim
        ins.CPU = enumCPU._Non  'CPUの型番. 列挙体がある(e.g. Q00なら _Non, Q00U なら U )

        Dim rtn As ReturnUS = ins.ReadDeviceBlock2("D0", 10)
        MsgBox(ins.UShortDis(rtn.dat, "/"))
        Dim dat(960) As UShort : For i = 0 To 959 : dat(i) = i + 1 : Next
        ins.WriteDeviceBlock2("D0", 960, dat)

```
