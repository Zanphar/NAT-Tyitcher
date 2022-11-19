Imports System.Windows

Public Class frmMain

    Dim p As New Process

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Try
            If drpSetting.SelectedItem = "Enterprise #: 1" Then
                Try
                    Dim p As New Process
                    p.StartInfo.FileName = "netsh.exe"
                    p.StartInfo.Arguments = "int teredo set state type=Enterprise servername=win1910.ipv6.microsoft.com clientport=34567 refreshinterval=60"
                    p.StartInfo.UseShellExecute = False
                    p.StartInfo.RedirectStandardOutput = True
                    p.StartInfo.CreateNoWindow = True
                    AddHandler p.OutputDataReceived, AddressOf HelloMum
                    p.Start()
                    p.BeginOutputReadLine()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf drpSetting.SelectedItem = "Enterprise #: 2" Then
                Try
                    Dim p As New Process
                    p.StartInfo.FileName = "netsh.exe"
                    p.StartInfo.Arguments = "int teredo set state type=Enterprise servername=teredo.ipv6.microsoft.com clientport=34567 refreshinterval=60"
                    p.StartInfo.UseShellExecute = False
                    p.StartInfo.RedirectStandardOutput = True
                    p.StartInfo.CreateNoWindow = True
                    AddHandler p.OutputDataReceived, AddressOf HelloMum
                    p.Start()
                    p.BeginOutputReadLine()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf drpSetting.SelectedItem = "Enterprise #: 3" Then
                Try
                    Dim p As New Process
                    p.StartInfo.FileName = "netsh.exe"
                    p.StartInfo.Arguments = "int teredo set state type=Enterprise servername=win1711.ipv6.microsoft.com clientport=34567 refreshinterval=60"
                    p.StartInfo.UseShellExecute = False
                    p.StartInfo.RedirectStandardOutput = True
                    p.StartInfo.CreateNoWindow = True
                    AddHandler p.OutputDataReceived, AddressOf HelloMum
                    p.Start()
                    p.BeginOutputReadLine()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf drpSetting.SelectedItem = "Enterprise #: 4" Then
                Try
                    Dim p As New Process
                    p.StartInfo.FileName = "netsh.exe"
                    p.StartInfo.Arguments = "int teredo set state type=Enterprise servername=win10.ipv6.microsoft.com clientport=34567 refreshinterval=60"
                    p.StartInfo.UseShellExecute = False
                    p.StartInfo.RedirectStandardOutput = True
                    p.StartInfo.CreateNoWindow = True
                    AddHandler p.OutputDataReceived, AddressOf HelloMum
                    p.Start()
                    p.BeginOutputReadLine()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf drpSetting.SelectedItem = "EnterpriseClient #: 1" Then
                Try
                    Dim p As New Process
                    p.StartInfo.FileName = "netsh.exe"
                    p.StartInfo.Arguments = "int teredo set state type=EnterpriseClient servername=teredo.remlab.net clientport=34567 refreshinterval=60"
                    p.StartInfo.UseShellExecute = False
                    p.StartInfo.RedirectStandardOutput = True
                    p.StartInfo.CreateNoWindow = True
                    AddHandler p.OutputDataReceived, AddressOf HelloMum
                    p.Start()
                    p.BeginOutputReadLine()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ' netsh int ipv6 set teredo client teredo.trex.fi

            ElseIf drpSetting.SelectedItem = "Client #: 1" Then
                Try
                    Dim p As New Process
                    p.StartInfo.FileName = "netsh.exe"
                    p.StartInfo.Arguments = "int teredo set state type=Client servername=teredo.trex.fi clientport=34567 refreshinterval=60"
                    p.StartInfo.UseShellExecute = False
                    p.StartInfo.RedirectStandardOutput = True
                    p.StartInfo.CreateNoWindow = True
                    AddHandler p.OutputDataReceived, AddressOf HelloMum
                    p.Start()
                    p.BeginOutputReadLine()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("An option must be selected in order to continue.", vbInformation)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub TeredoShowState()
        Textbox.Clear()
        Dim p As New Process
        p.StartInfo.FileName = "netsh.exe"
        p.StartInfo.Arguments = "Int Teredo show state"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.CreateNoWindow = True
        AddHandler p.OutputDataReceived, AddressOf HelloMum
        p.Start()
        p.BeginOutputReadLine()
    End Sub

    Sub pingRoutine()
        Dim p As New Process
        p.StartInfo.FileName = "ping.exe"
        p.StartInfo.Arguments = "www.google.com -t"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.CreateNoWindow = True
        AddHandler p.OutputDataReceived, AddressOf HelloMum
        p.Start()
        p.BeginOutputReadLine()
    End Sub

    Sub HelloMum(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        UpdateTextBox(e.Data)
    End Sub

    Private Delegate Sub UpdateTextBoxDelegate(ByVal Text As String)

    Private Sub UpdateTextBox(ByVal Tex As String)
        If Me.InvokeRequired Then
            Dim del As New UpdateTextBoxDelegate(AddressOf UpdateTextBox)
            Dim args As Object() = {Tex}
            Me.Invoke(del, args)
        Else
            Me.Textbox.Text &= Tex & Environment.NewLine
        End If
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        Try
            TeredoShowState()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Try
            If chkReset.Checked = True Then
                WinSockReset()
                IPReset()
                IPv4Reset()
                IPv6Reset()
                FlushDNS()
            Else
                MsgBox("We cannot do anything as you have not selected the option to reset.", vbInformation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub WinSockReset()
        Dim p As New Process
        p.StartInfo.FileName = "netsh.exe"
        p.StartInfo.Arguments = "WinSock Reset"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.CreateNoWindow = True
        AddHandler p.OutputDataReceived, AddressOf HelloMum
        p.Start()
        p.BeginOutputReadLine()
    End Sub

    Private Sub FlushDNS()
        Dim p As New Process
        p.StartInfo.FileName = "ipconfig.exe"
        p.StartInfo.Arguments = "/flushdns"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.CreateNoWindow = True
        AddHandler p.OutputDataReceived, AddressOf HelloMum
        p.Start()
        p.BeginOutputReadLine()
    End Sub

    Private Sub IPReset()
        Dim p As New Process
        p.StartInfo.FileName = "netsh.exe"
        p.StartInfo.Arguments = "int ip reset"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.CreateNoWindow = True
        AddHandler p.OutputDataReceived, AddressOf HelloMum
        p.Start()
        p.BeginOutputReadLine()
    End Sub

    Private Sub IPv4Reset()
        Dim p As New Process
        p.StartInfo.FileName = "netsh.exe"
        p.StartInfo.Arguments = "int ipv4 reset"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.CreateNoWindow = True
        AddHandler p.OutputDataReceived, AddressOf HelloMum
        p.Start()
        p.BeginOutputReadLine()
    End Sub

    Private Sub IPv6Reset()
        Dim p As New Process
        p.StartInfo.FileName = "netsh.exe"
        p.StartInfo.Arguments = "int ipv6 reset"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.CreateNoWindow = True
        AddHandler p.OutputDataReceived, AddressOf HelloMum
        p.Start()
        p.BeginOutputReadLine()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    Private Sub TheEmpireButton1_Click(sender As Object, e As EventArgs) Handles TheEmpireButton1.Click

        Try

            Affinity()                      ' 1

            ClockRate()                     ' 2

            GPUPriority()                   ' 3

            Priority()                      ' 4

            Scheduling()                    ' 5

            SFIOPriority()                  ' 6

            BackgroundOnly()                ' 7

            NetworkThrottlingIndex()        ' 8

            SystemResponsiveness()          ' 9

            TCPNoDelay()                    ' 10

            LargeSystemCache()              ' 11

            SizReqBuf()                     ' 12

            DefaultTTL()                    ' 13

            IRPStackSize()                  ' 14

            GlobalMaxTcpWindowSize()        ' 15

            MaxFreeTcbs()                   ' 16

            MaxUserPort()                   ' 17

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class

