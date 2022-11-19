Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Imports Microsoft
Imports System
Imports System.Diagnostics
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Threading

' GameTCP for Microsoft Windows 10 - A simple program to make changes to Microsoft Windows 10 systems to increase performance, 
' and to improve performance for gaming and other applications. Visual Basic (Visual Studio .NET 2019 Community Edition) was
' used to compile this source code. Visual Studio .NET 2019 Community Edition is available free of charge from Microsoft. The
' compiled code must be executed as an Administrator, otherwise it will fail and cause several errors.
' 
' 1.) Intel(R) Xeon(R) CPU E5-2670 0 @ 2.60GHz (8 Cores; 16 Threads)
' 2.) AMD RADEON RX 470 4GB GDDR5 RAM
' 3.) 16.0 GB DDR3
' 4.) 64-bit OS, x64-based CPU
' 5.) Windows 10 Professional
' 6.) T-Mobile Home Internet (5G/LTE)
' 
' SOFTWARE LICENSE AGREEMENT
' 
' This computer program, documentation and accompanying files (the "Software") is provided "AS-IS" without guarantee or warranty 
' whether express or implied, including but not limited to merchantability or fitness for a particular purpose. By downloading, 
' installing or otherwise using this Software, you automatically show your acceptance to the terms and conditions as described 
' in this agreement.
' 
'  1. Charles McDonald (nor anyone else,) is responsible or liable for any damages, interruptions, or for the loss otherwise 
'     from your ability or inability to use this Software.
' 
'  2. This Software may be used for commercial and personal purposes, with or without modifications as long as credit is 
'     given and optionally, produced.
' 
'  3. If you wish to assume full credit for this Software, please contact me at: support@chware.net for information.
' 
' Copyright © 2021 Charles McDonald. All rights reserved.
' 
' Release: 12/02/2021
'     Added three new items, bringing the total to 17 from 14. They are GlobalMaxTcpWindowSize, MacFreeTcbs, MaxUserPort.
' Release: 10/18/2021
'     Moved code into it's own subs; instead of laying out in the open per-se. Added highlighted areas for important 
'     notices and errors.
' Release: 10/17/2021
'     Three new items added. Each area has been modified heavily, making this a huge update or an upgrade if you may. A 
'     software license section added where a user must accepted to continue. Notices that administrator is required.

Module GameTCP

    Dim Process As System.Diagnostics.Process = Nothing
    Dim ProcessStartInfo As System.Diagnostics.ProcessStartInfo
    Dim Start = New System.Diagnostics.ProcessStartInfo()

    Dim CurrentDate = DateTime.Now
    Dim Copyright = "Copyright © 2021 Charles McDonald. All rights reserved."

    Dim psi As New ProcessStartInfo()

    Public Sub Main()
    
    psi.Verb = "runas" ' aka run as administrator
    psi.FileName = "cmd.exe"
    psi.Arguments = "/c " & Application.ProductName ' <- pass arguments for the command you want to run
    
    Try
    Process.Start(psi) ' <- run the process (user will be prompted to run with administrator access)
    Catch
    ' exception raised if user declines the admin prompt
    End Try

       If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
            Start.Verb = "runas"
        Else
            ' No need to prompt to run as admin
        End If

        Console.Clear()

        Console.WriteLine("", Copyright & VbCrLf & VbCrLf)

        'AgreeSLA()

        Console.Clear()

        Console.WriteLine("", Copyright & VbCrLf)

        Affinity()                      ' 1
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        ClockRate()                     ' 2
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        GPUPriority()                   ' 3
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        Priority()                      ' 4
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        Scheduling()                    ' 5
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        SFIOPriority()                  ' 6
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        BackgroundOnly()                ' 7
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        NetworkThrottlingIndex()        ' 8
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        SystemResponsiveness()          ' 9
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        TCPNoDelay()                    ' 10
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        LargeSystemCache()              ' 11
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        SizReqBuf()                     ' 12
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        DefaultTTL()                    ' 13
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        IRPStackSize()                  ' 14
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        GlobalMaxTcpWindowSize()        ' 15
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        MaxFreeTcbs()                   ' 16
        Thread.Sleep(500)               ' Wait (500 = 8 seconds)

        MaxUserPort()                   ' 17
        Thread.Sleep(1800)               ' Wait (800 = 8 seconds)

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.BackgroundColor = ConsoleColor.Red
        Console.WriteLine("NOTE: A reboot is required in order for some of the applied settings to become active.")
        Console.ResetColor()

    End Sub

    ''' <summary>
    ''' This will prompt the end-user to accept the Software License Agreement (the "SLA") each time the software is executed. 
    ''' They must accept in order to use the software, otherwise it assumes they've said no and won't continue. This can be 
    ''' enabled or disabled, depending if there's a "'" without quotes in AgreeSLA() in the Main Sub. By default, this is 
    ''' enabled.
    ''' </summary>
    Public Sub AgreeSLA() ' Software License Agreement (Y/N)

        Console.ForegroundColor = ConsoleColor.White
        Console.ResetColor()

        Console.WriteLine("SOFTWARE LICENSE AGREEMENT")
        Console.ResetColor()
        Console.WriteLine("")
        Console.WriteLine("This computer program, documentation and accompanying files (the ""Software"") is ")
        Console.WriteLine("provided ""AS-IS"" without guarantee or warranty whether express or implied, including ")
        Console.WriteLine("but not limited to merchantability or fitness for a particular purpose. By downloading, ")
        Console.WriteLine("installing or otherwise using this Software, you automatically show your acceptance to ")
        Console.WriteLine("the terms and conditions as described in this agreement.")
        Console.WriteLine("")
        Console.WriteLine(" 1. Charles McDonald (nor anyone else,) is responsible or liable for any damages, ")
        Console.WriteLine("    interruptions, or for the loss otherwise from your ability or inability to use this ")
        Console.WriteLine("    Software.")
        Console.WriteLine("")
        Console.WriteLine(" 2. This Software may be used for commercial and personal purposes, with or without ")
        Console.WriteLine("    modifications as long as credit is given and optionally, produced.")
        Console.WriteLine("")
        Console.WriteLine(" 3. If you wish to assume full credit for this Software, please contact me at: ")
        Console.WriteLine("    support@chware.net for information.")
        Console.WriteLine("")
        Console.WriteLine("IMPORTANT NOTICE: This must be executed as an Administrator, otherwise it will fail and ")
        Console.WriteLine("and cause several errors." & vbCrLf)

        Console.Write("Do you accept this agreement? ")

        Dim line As String = Console.ReadLine()

        If line = "Yes" Or line = "yes" Or line = "Y" Or line = "y" Then
        Else
            End
        End If

    End Sub ' Software License Agreement (Y/N)

    ''' <summary>
    ''' If you are using Windows 10 or any other Windows version, then you should know about the Process affinity as it will help 
    ''' you better optimize the Processor based on your requirements. If you run a program in Windows, it tends to utilize all the 
    ''' available CPU cores. This is done so that the performance of the program is top-notch.
    ''' </summary>
    Public Sub Affinity()

        Try

            ' DWORD (32-bit) - Affinity (Stage 1)

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Affinity", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 1: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Affinity")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The Affinity value does not exist or is not supported on this platform." & vbCrLf)
            Else

                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ", ReadValue)
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()

                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Affinity", 0, Microsoft.Win32.RegistryValueKind.DWord)

                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ", ReadValue)
                Console.ResetColor()
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()

            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' Affinity (Stage 1)

    End Sub

    ''' <summary>
    ''' In computing, the clock rate or clock speed typically refers to the frequency at which the clock generator of a Processor 
    ''' can generate pulses, which are used to synchronize the operations of its components, and is used as an indicator of the 
    ''' Processor's speed. It is measured in clock cycles per second or its equivalent, the SI unit hertz (Hz).
    ''' </summary>
    Public Sub ClockRate()

        Try
            ' DWORD (32-bit) - Clock Rate (Stage 2)
            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Clock Rate", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 2: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Clock Rate")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The Clock Rate value does not exist or is not supported on this platform." & vbCrLf)
            Else

                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Clock Rate", 2710, Microsoft.Win32.RegistryValueKind.DWord)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ResetColor()
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()

            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' Clock Rate (Stage 2)

    End Sub

    ''' <summary>
    ''' With Windows 10 May 2020 update, we are introducing a new GPU scheduler as a user opt-in, but off by default option. With 
    ''' the right hardware and drivers, Windows can now offload most of GPU scheduling to a dedicated GPU-based scheduling 
    ''' Processor. Windows continues to control prioritization and decide which applications have priority among contexts.
    ''' </summary>
    Public Sub GPUPriority()
        Try
            ' DWORD (32-bit) - GPU Priority (Stage 3)

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "GPU Priority", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 3: ")
            Console.ResetColor()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("GPU Priority")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The GPU Priority value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "GPU Priority", 8, Microsoft.Win32.RegistryValueKind.DWord)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' GPU Priority (Stage 3)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub Priority()

        Try
            ' DWORD (32-bit) - Priority (Stage 4)

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Priority", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 4: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Priority")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The Priority value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Priority", 6, Microsoft.Win32.RegistryValueKind.DWord)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' Priority (Stage 4)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub Scheduling()

        Try
            ' DWORD (32-bit) - Scheduling Category (Stage 5)

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Scheduling Category", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 5: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Scheduling Category")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The Scheduling Category value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Scheduling Category", "High")
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' Scheduling Category (Stage 5)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub SFIOPriority()

        Try
            ' DWORD (32-bit) - SFIO Priority (Stage 5)

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "SFIO Priority", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 6: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("SFIO Priority")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The SFIO Priority value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "SFIO Priority", "High")
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' SFIO Priority (Stage 6)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub BackgroundOnly()

        Try
            ' DWORD (32-bit) - Background Only (Stage 7)

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Background Only", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 7: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Background Only")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The Background Only value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Background Only", "False")
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' Background Only (Stage 7)

    End Sub

    ''' <summary>
    ''' Network Throttling Index Windows implements a network throttling mechanism, the idea behind such throttling is that 
    ''' Processing of network packets can be a resource-intensive task. It is beneficial to turn off such throttling for 
    ''' achieving maximum throughput.
    ''' </summary>
    Public Sub NetworkThrottlingIndex()

        Try
            ' DWORD (32-bit) - NetworkThrottlingIndex (Stage 8)

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "NetworkThrottlingIndex", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 8: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("NetworkThrottlingIndex")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The NetworkThrottlingIndex value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "NetworkThrottlingIndex", 18309, Microsoft.Win32.RegistryValueKind.DWord)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' NetworkThrottlingIndex (Stage 8)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub SystemResponsiveness()

        Try
            ' DWORD (32-bit) - SystemResponsiveness (Stage 9)

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "SystemResponsiveness", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 9: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("SystemResponsiveness")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The SystemResponsiveness value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "SystemResponsiveness", 0, Microsoft.Win32.RegistryValueKind.DWord)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' SystemResponsiveness (Stage 9)

    End Sub

    ''' <summary>
    ''' The TCP_NODELAY socket option allows your network to bypass Nagle Delays by disabling Nagle's algorithm, and sending 
    ''' the data as soon as it's available. Enabling TCP_NODELAY forces a socket to send the data in its buffer, whatever the 
    ''' packet size. To disable Nagle's buffering algorithm, use the TCP_NODELAY socket option.
    ''' </summary>
    Public Sub TCPNoDelay()

        Try
            ' DWORD (32-bit) - TCPNoDelay (Stage 10)

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "LargeSystemCache", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 10: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("TCPNoDelay")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The TCPNoDelay value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "LargeSystemCache", 0, Microsoft.Win32.RegistryValueKind.DWord)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' TCPNoDelay (Stage 10)

    End Sub

    ''' <summary>
    ''' Large System Cache allows windows to use more RAM for cache thus needing to page to the SSD less often. For older 
    ''' machines this caused issues when RAM was at a premium but for machines with 4GB+ RAM you will only notice performance 
    ''' improvements.
    ''' </summary>
    Public Sub LargeSystemCache()

        Try
            ' DWORD (32-bit) - LargeSystemCache (Stage 10)

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "LargeSystemCache", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 11: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("LargeSystemCache")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The LargeSystemCache value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "LargeSystemCache", 0, Microsoft.Win32.RegistryValueKind.DWord)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' LargeSystemCache (Stage 11)

    End Sub

    ''' <summary>
    ''' SizReqBuf One of the changes that we can make from the Windows registry to improve Internet speed is through SizReqBuf. 
    ''' Represents the size of the raw receive buffers within a server environment. This means that it can affect when storing 
    ''' something in a high latency environment.
    ''' </summary>
    Public Sub SizReqBuf()

        Try
            ' DWORD (32-bit) - SizReqBuf (Stage 12) \ Added: 10/17/2021

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters", "SizReqBuf", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 12: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("SizReqBuf")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The SizReqBuf value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters", "SizReqBuf", 17424, Microsoft.Win32.RegistryValueKind.DWord)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' SizReqBuf (Stage 12) \ Added: 10/17/2021

    End Sub

    ''' <summary>
    ''' Time to live (TTL) or hop limit is a mechanism which limits the lifespan or lifetime of data in a computer or network. 
    ''' TTL may be implemented as a counter or timestamp attached to or embedded in the data. Once the prescribed event count 
    ''' or timespan has elapsed, data is discarded or revalidated. In computer networking, TTL prevents a data packet from 
    ''' circulating indefinitely. In computing applications, TTL is commonly used to improve the performance and manage the 
    ''' caching of data.
    ''' </summary>
    Public Sub DefaultTTL()

        Try
            ' DWORD (32-bit) - DefaultTTL (Stage 13) \ Added: 10/17/2021

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "DefaultTTL", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 13: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("DefaultTTL")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The DefaultTTL value does not exist or is not supported on this platform." & vbCrLf)
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "DefaultTTL", 64, Microsoft.Win32.RegistryValueKind.DWord)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' DefaultTTL (Stage 13) \ Added: 10/17/2021

    End Sub

    ''' <summary>
    ''' In Microsoft operating systems including Windows NT, Windows 2000 Server, Windows XP and Windows Server 2003, the 
    ''' IRPStackSize is a parameter that specifies the number of stack locations in I/O request packets (IRPs) that are 
    ''' used by the operating system.
    ''' </summary>
    Public Sub IRPStackSize()

        Try
            ' DWORD (32-bit) - IRPStackSize (Stage 14) \ Added: 10/17/2021

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters", "IRPStackSize", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 14: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("IRPStackSize")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The IRPStackSize value does not exist or is not supported on this platform." & vbCrLf)
            Else
                My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters", "IRPStackSize", String.Empty)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters", "IRPStackSize", 32, Microsoft.Win32.RegistryValueKind.DWord)
                My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters", "IRPStackSize", ReadValue)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' IRPStackSize (Stage 14) \ Added: 10/17/2021

    End Sub

    Public Sub GlobalMaxTcpWindowSize()

        Try
            ' DWORD (32-bit) - GlobalMaxTcpWindowSize (Stage 15) \ Added: 12/02/2021

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "GlobalMaxTcpWindowSize", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 15: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("GlobalMaxTcpWindowSize")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The GlobalMaxTcpWindowSize value does not exist or is not supported on this platform." & vbCrLf)
            Else
                My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "GlobalMaxTcpWindowSize", String.Empty)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "GlobalMaxTcpWindowSize", 65536, Microsoft.Win32.RegistryValueKind.DWord)
                My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "GlobalMaxTcpWindowSize", ReadValue)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' GlobalMaxTcpWindowSize (Stage 15) \ Added: 12/02/2021

    End Sub

    Public Sub MaxFreeTcbs()

        Try
            ' DWORD (32-bit) - MaxFreeTcbs (Stage 16) \ Added: 12/02/2021

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxFreeTcbs", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 16: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("MaxFreeTcbs")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The MaxFreeTcbs value does not exist or is not supported on this platform." & vbCrLf)
            Else
                My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxFreeTcbs", String.Empty)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxFreeTcbs", 65535, Microsoft.Win32.RegistryValueKind.DWord)
                My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxFreeTcbs", ReadValue)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' MaxFreeTcbs (Stage 16) \ Added: 12/02/2021

    End Sub

    Public Sub MaxUserPort()

        Try
            ' DWORD (32-bit) - MaxFreeTcbs (Stage 17) \ Added: 12/02/2021

            Dim ReadValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxUserPort", Nothing)

            Console.ForegroundColor = ConsoleColor.White
            Console.Write($"{CurrentDate:t} - Stage 17: ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("MaxUserPort")
            Console.ResetColor()

            If ReadValue Is Nothing Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("    The MaxUserPort value does not exist or is not supported on this platform." & vbCrLf)
            Else
                My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxUserPort", String.Empty)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    OldVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("" & ReadValue)
                Console.ResetColor()
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxUserPort", 65534, Microsoft.Win32.RegistryValueKind.DWord)
                My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxUserPort", ReadValue)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("    NewVal: ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("" & ReadValue & vbCrLf)
                Console.ResetColor()
            End If
        Catch err As Exception
            Console.WriteLine(err.Message & err.StackTrace)
        End Try ' MaxFreeTcbs (Stage 17) \ Added: 12/02/2021

    End Sub

End Module
