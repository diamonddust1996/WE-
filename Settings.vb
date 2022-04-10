Imports System.Windows.Forms
Imports System.Text
Imports Microsoft.Office.Interop

Public Class Settings
    Dim dmp2tmf_Path, Label2_Path, Label3_Path, Label4_Path As String
    Dim iniFolder As String = "..\..\ini"


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
                                    ByVal lpFileName As String) As Integer

    Private Sub Save_ini()
        Dim iniFileName As String = "..\..\ini\" & Gen_Select.Text & "_Settings.ini"
        Try
            If Not System.IO.Directory.Exists(iniFolder) Then _
            System.IO.Directory.CreateDirectory(iniFolder)
        Catch ex As Exception
            MsgBox("iniフォルダ作成で例外発生")
        End Try

        WritePrivateProfileString("Address", "dmp2tmf", TextBox1.Text, iniFileName)
        WritePrivateProfileString("Address", "Label2", TextBox2.Text, iniFileName)
        WritePrivateProfileString("Address", "Label3", TextBox3.Text, iniFileName)
        WritePrivateProfileString("Address", "Label4", TextBox4.Text, iniFileName)
        WritePrivateProfileString("Address", "Label4", TextBox4.Text, iniFileName)

    End Sub

    Private Sub Read_ini()
        Dim SB1_1 As StringBuilder = New StringBuilder(512)
        Dim SB1_2 As StringBuilder = New StringBuilder(512)
        Dim SB1_3 As StringBuilder = New StringBuilder(512)
        Dim SB1_4 As StringBuilder = New StringBuilder(512)
        Dim iniFileName As String = "..\..\ini\" & Gen_Select.Text & "_Settings.ini"

        GetPrivateProfileString("Address", "dmp2tmf", "", SB1_1, 512, iniFileName)
        GetPrivateProfileString("Address", "Label2", "", SB1_2, 512, iniFileName)
        GetPrivateProfileString("Address", "Label3", "", SB1_3, 512, iniFileName)
        GetPrivateProfileString("Address", "Label4", "", SB1_4, 512, iniFileName)

        TextBox1.Text = SB1_1.ToString
        TextBox2.Text = SB1_2.ToString
        TextBox3.Text = SB1_3.ToString
        TextBox4.Text = SB1_4.ToString
    End Sub

    Private Sub Text_Changing1()
        TextBox1.Text = dmp2tmf_Path
        TextBox2.Text = Label2_Path
        TextBox3.Text = Label3_Path
        TextBox4.Text = Label4_Path
    End Sub

    Private Sub Text_Changing2()
        Main.dmp2tmf_Address.Text = TextBox1.Text
        Main.Label2_Address.Text = TextBox2.Text
        Main.Label3_Address.Text = TextBox3.Text
        Main.Label4_Address.Text = TextBox4.Text
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Main.dmp2tmf_Address.Text
        TextBox2.Text = Main.Label2_Address.Text
        TextBox3.Text = Main.Label3_Address.Text
        TextBox4.Text = Main.Label4_Address.Text
    End Sub

    Private Sub TextBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragEnter
        'exeファイル形式の場合のみ、ドラッグを受け付ける
        Dim Drags() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        If System.IO.Path.GetExtension(Drags(0)) = ".exe" Then e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub TextBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragDrop
        'ドラッグされたファイル・フォルダのパスに変更する
        Dim Drags() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        TextBox1.Text = Drags(0)
    End Sub

    Private Sub TextBox2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox2.DragEnter
        'Excelファイル形式の場合のみ、ドラッグを受け付ける
        Dim Drags() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        If Mid(System.IO.Path.GetExtension(Drags(0)), 2, 3) = "xls" Then e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub TextBox2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox2.DragDrop
        'ドラッグされたファイル・フォルダのパスに変更する
        Dim Drags() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        TextBox2.Text = Drags(0)
    End Sub

    Private Sub TextBox3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox3.DragEnter
        'Excelファイル形式の場合のみ、ドラッグを受け付ける
        Dim Drags() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        If Mid(System.IO.Path.GetExtension(Drags(0)), 2, 3) = "xls" Then e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub TextBox3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox3.DragDrop
        'ドラッグされたファイル・フォルダのパスに変更する
        Dim Drags() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        TextBox3.Text = Drags(0)
    End Sub

    Private Sub TextBox4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox4.DragEnter
        'Excelファイル形式の場合のみ、ドラッグを受け付ける
        Dim Drags() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        If Mid(System.IO.Path.GetExtension(Drags(0)), 2, 3) = "xls" Then e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub TextBox4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox4.DragDrop
        'ドラッグされたファイル・フォルダのパスに変更する
        Dim Drags() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        TextBox4.Text = Drags(0)
    End Sub


    Private Sub dmp2tmf_SelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dmp2tmf_SelectBtn.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName()
            ' 不要になった時点で破棄する
            OpenFileDialog1.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = OpenFileDialog2.FileName
            ' 破棄する
            OpenFileDialog2.Dispose()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If OpenFileDialog3.ShowDialog() = DialogResult.OK Then
            TextBox3.Text = OpenFileDialog3.FileName
            Text_Changing2()
            ' 破棄する
            OpenFileDialog3.Dispose()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If OpenFileDialog4.ShowDialog() = DialogResult.OK Then
            TextBox4.Text = OpenFileDialog4.FileName
            Text_Changing2()
            ' 破棄する
            OpenFileDialog1.Dispose()
        End If
    End Sub

    Private Sub Save_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Btn.Click
        Me.DialogResult = DialogResult.OK
        Text_Changing2()
        Save_ini()

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Btn.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Excel(ByVal File As String, ByVal ComboBoxItems As ComboBox.ObjectCollection)
        Dim xlApp As Excel.Application = CType(CreateObject("Excel.Application.12"), Excel.Application)
        xlApp.Visible = False
        Dim xlWorkbooks As Excel.Workbooks = xlApp.Workbooks
        Try
            Dim xlWorkbook As Excel.Workbook = xlWorkbooks.Open(File, ReadOnly:=True)

            Dim xlProject As VBIDE.VBProject
            Dim xlComponent As VBIDE.VBComponent
            Dim xlCode As VBIDE.CodeModule

            Dim iLine As Integer
            Dim sProcName As String
            Dim pk As VBIDE.vbext_ProcKind

            xlProject = xlWorkbook.VBProject
            For Each xlComponent In xlProject.VBComponents
                xlCode = xlComponent.CodeModule

                iLine = 1
                Do While iLine < xlCode.CountOfLines
                    sProcName = xlCode.ProcOfLine(iLine, pk)
                    If sProcName <> "" Then
                        ComboBoxItems.Add(sProcName)
                        iLine = iLine + xlCode.ProcCountLines(sProcName, pk)
                    Else
                        iLine = iLine + 1
                    End If
                Loop
                xlCode = Nothing
                xlComponent = Nothing
            Next

            xlProject = Nothing
            xlWorkbook.Close(False)
            xlWorkbook = Nothing
            xlWorkbooks = Nothing

            xlApp.Quit()

            xlApp = Nothing
        Catch ex As Exception
            ComboBoxItems.Add("マクロ名取得エラー")
            Exit Sub
        End Try
    End Sub

    Private Sub ComboBox1_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.DropDown
        ComboBox1.Items.Clear()
        Excel(TextBox2.Text, ComboBox1.Items)
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gen_Select.SelectedIndexChanged

    End Sub
End Class
