Imports System.Text
Imports Microsoft.Office.Interop

Public Class Main
    Private Delegate Sub ButtonOnDelegate()

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonOff()
        'DoSomethingメソッドを別のスレッドで実行する
        'Threadオブジェクトを作成する
        Dim t As New System.Threading.Thread(New System.Threading.ThreadStart( _
        AddressOf DoSomething))
        t.IsBackground = True
        'スレッドを開始する
        t.Start()
    End Sub

    '別スレッドで実行するメソッド
    Private Sub DoSomething()
        Dim ButtonOnDlg As New ButtonOnDelegate(AddressOf ButtonOn)
        Me.Invoke(ButtonOnDlg)
    End Sub

    Private Sub ButtonOn()
        dmp2tmf_btn.Enabled = True
    End Sub

    Private Sub ButtonOff()
        dmp2tmf_btn.Enabled = False
    End Sub

    Private Declare Function GetPrivateProfileString Lib "kernel32" _
 Alias "GetPrivateProfileStringA" ( _
                              ByVal lpAppName As String, _
                              ByVal lpKeyName As String, _
                              ByVal lpDefault As String, _
                              ByVal lpReturnedString As StringBuilder, _
                              ByVal nSize As Integer, _
                              ByVal lpFileName As String) As Integer

    Private Declare Function WritePrivateProfileString Lib "kernel32" _
Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, _
                                    ByVal lpKeyName As String, _
                                    ByVal lpString As String, _
                                    ByVal lpFileName As StringBuilder) As Integer
    Private Sub test()

    End Sub

    Dim iniFolder As String = "..\..\ini"
    Dim iniFileName As String = "..\..\ini\Settings.ini"


    Private Sub Read_ini()
        Dim SB1_1 As StringBuilder = New StringBuilder(512)
        Dim SB1_2 As StringBuilder = New StringBuilder(512)
        Dim SB1_3 As StringBuilder = New StringBuilder(512)
        Dim SB1_4 As StringBuilder = New StringBuilder(512)

        GetPrivateProfileString("Address", "dmp2tmf", "", SB1_1, 512, iniFileName)
        GetPrivateProfileString("Address", "Label2", "", SB1_2, 512, iniFileName)
        GetPrivateProfileString("Address", "Label3", "", SB1_3, 512, iniFileName)
        GetPrivateProfileString("Address", "Label4", "", SB1_4, 512, iniFileName)

        dmp2tmf_Address.Text = SB1_1.ToString
        Label2_Address.Text = SB1_2.ToString
        Label3_Address.Text = SB1_3.ToString
        Label4_Address.Text = SB1_4.ToString
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CheckMsg As Object
        If Not System.IO.File.Exists(iniFileName) Then
            CheckMsg = MsgBox("Settings.iniが見つかりません。" + vbCrLf + "デフォルトの値を読み込みますか？", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.AbortRetryIgnore, MsgBoxStyle))
            'If CheckMsg Is vbAbort Then
            'End If
        End If
        Read_ini()
    End Sub

    Private Sub Settings_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Settings_btn.Click
        Dim f As New Settings()
        f.StartPosition = FormStartPosition.CenterParent
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
    'objWShell.AppActivate "ファイルを開く"
    'objWShell.SendKeys "%{N}"
    'WScript.Sleep 50
    'objWShell.SendKeys strText
End Class
