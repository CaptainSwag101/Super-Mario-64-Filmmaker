Imports System.Web
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports Ionic.Zip

Public Class MainMenu
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Process.Start(Application.StartupPath & "\Engine\Fraps.exe")
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub btnGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Process.Start(Application.StartupPath & "\Engine\PJ64.exe")
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        glitchyessentials.Show()
        Me.Hide()
    End Sub

    Private Sub btnCHT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCHT.Click
        cheatModeSel.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Process.Start(Application.StartupPath & "\Engine\CCGEN.exe")
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub btnSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSC.Click
        'Do nothing.
    End Sub

    Private Sub btnEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        extractSel.Show()
    End Sub

    Private Sub btnWorkshop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWorkshop.Click
        Dim OpenFileDlg As New OpenFileDialog
        Dim sb = New StringBuilder(500)

        OpenFileDlg.FileName = "Project64" ' Default file name
        OpenFileDlg.DefaultExt = ".cht" ' Default file extension
        OpenFileDlg.Filter = "Super Mario 64 Filmmaker Addon File|*.sm64fma"
        OpenFileDlg.Multiselect = False
        OpenFileDlg.RestoreDirectory = True
        ' Show open file dialog box
        Dim result? As Boolean = OpenFileDlg.ShowDialog()

        ' Process open file dialog box results
        For Each path In OpenFileDlg.FileNames
            Try
                Dim objReader As New System.IO.StreamReader(path)

                objReader.ToString()
                objReader.Close()

            Catch ex As Exception
                MsgBox("Unable to load the file. Maybe it was deleted?")
            End Try
            If result = True Then
                Try
                    MsgBox(path)
                    My.Computer.FileSystem.CreateDirectory("C:/SM64FMTEMP")
                    Dim ZipToUnpack As String = path
                    Dim UnpackDirectory As String = "C:/SM64FMTEMP"
                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim ze As ZipEntry
                        ' here, we extract every entry, but we could extract conditionally,
                        ' based on entry name, size, date, checkbox status, etc.   
                        For Each ze In zip1
                            ze.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/Addons/" + "addon")
                    My.Computer.FileSystem.CopyDirectory("C:/SM64FMTEMP", (Application.StartupPath + "/Addons/" + "addon"))
                    System.IO.Directory.Delete("C:/SM64FMTEMP", True)
                Catch ex As Exception
                    MsgBox("Couldn't load the Addon Extractor. Is SM64FM correctly installed?")
                End Try

            ElseIf result = False Then
                MsgBox("paini")
                'Nein
                Exit Sub
            End If
        Next
    End Sub
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppVer.Text = ("Super Mario 64 Filmmaker Version " + Application.ProductVersion)
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripStatusLabel1.Click
        Process.Start("http://sm64fm.pe.hu/donatenow.html")
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        extractSel.Show()
    End Sub
End Class