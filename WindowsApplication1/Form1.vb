Imports System.IO.StreamReader
Imports System.IO
Imports System.Net

Public Class Form1
    Private Property pageready As Boolean = False
    Private Sub WaitForPageLoad()
        AddHandler website.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not pageready
            Application.DoEvents()
        End While
        pageready = False
    End Sub
    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If website.ReadyState = WebBrowserReadyState.Complete Then
            pageready = True
            RemoveHandler website.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub
    Sub Delay(ByVal dblSecs As Double)
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles fetchimage.Click
        Dim howmuch As Integer = piece.Text
        website.Navigate("https://www.google.com.tr/search?hl=tr&site=imghp&tbm=isch&source=hp&q=" & searchkeyword.Text & "#hl=tr&q=" & searchkeyword.Text & "&tbas=0&tbm=isch&tbs=isz:l,itp:photo") '& "&start=" & TextBox1.Text)
        WaitForPageLoad()
        For Each link As HtmlElement In website.Document.Links
            If InStr(link.GetAttribute("href"), "") > 0 And InStr(link.GetAttribute("href"), "imgres?imgurl=") > 0 And InStr(link.GetAttribute("href"), "wikipedia") = 0 And InStr(link.GetAttribute("href"), "youtube") = 0 And InStr(link.GetAttribute("href"), "javascript") = 0 And InStr(link.GetAttribute("href"), "advanced") = 0 Then
                If howmuch <= 0 Then
                    Exit For
                Else
                    howmuch = howmuch - 1
                End If

                Dim whereis As Integer
                Dim validchar As String = "1234567890abcdefghkjleilkm"
                Dim ran As New Random()
                Dim whereis2 As Integer
                Dim idx As Integer = ran.Next(3, validchar.Length)
                Dim randomChar As Char = validchar(idx)
                whereis = InStr(link.GetAttribute("href"), "imgurl=") + 6
                whereis2 = InStr(link.GetAttribute("href"), "&imgrefurl") - 1
                Dim myRandom As New Random
                Dim k As Integer = kelimelerlist.Items.Count
                Dim _Image As Image = Nothing
                Dim extrakeyword As String = kelimelerlist.Items.Item(myRandom.Next(k)).ToString()
checkagain:
                Dim addlast As String = randomChar
                extrakeyword = extrakeyword.Trim()
                _Image = DownloadImage(WebUtility.UrlDecode(link.GetAttribute("href").ToString.Substring(whereis, whereis2 - whereis)))
                links.Items.Add(WebUtility.UrlDecode(link.GetAttribute("href").ToString.Substring(whereis, whereis2 - whereis)))

                If _Image IsNot Nothing Then
                    If System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory() & "/images/" & searchkeyword.Text & " " & extrakeyword & ".jpg") = True Then
                        If System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory() & "/images/" & searchkeyword.Text & " " & extrakeyword & " " & addlast & ".jpg") = True Then
                            GoTo checkagain
                        Else
                            _Image.Save(System.AppDomain.CurrentDomain.BaseDirectory() & "/images/" & searchkeyword.Text & " " & extrakeyword & " " & addlast & ".jpg")
                        End If

                    Else
                        _Image.Save(System.AppDomain.CurrentDomain.BaseDirectory() & "/images/" & searchkeyword.Text & " " & extrakeyword & ".jpg")
                    End If
                End If
            Else
            End If
        Next
continueagain:
        Delay(2)
        MsgBox("Finished")
    End Sub


    ''' <summary>
    ''' Function to download Image from website
    ''' </summary>
    ''' <param name="_URL">URL address to download image</param>
    ''' <returns>Image</returns>
    Public Function DownloadImage(ByVal _URL As String) As Image
        Dim _tmpImage As Image = Nothing
        Try
            ' Open a connection
            Dim _HttpWebRequest As System.Net.HttpWebRequest = CType(System.Net.HttpWebRequest.Create(_URL), System.Net.HttpWebRequest)
            _HttpWebRequest.AllowWriteStreamBuffering = True
            ' You can also specify additional header values like the user agent or the referer: (Optional)
            _HttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)"
            _HttpWebRequest.Referer = "http://www.google.com/"

            ' set timeout for 20 seconds (Optional)
            _HttpWebRequest.Timeout = 20000

            ' Request response:
            Dim _WebResponse As System.Net.WebResponse = _HttpWebRequest.GetResponse()

            ' Open data stream:
            Dim _WebStream As System.IO.Stream = _WebResponse.GetResponseStream()

            ' convert webstream to image
            _tmpImage = Image.FromStream(_WebStream)

            ' Cleanup
            _WebResponse.Close()
            _WebResponse.Close()
        Catch _Exception As Exception
            ' Error
            Console.WriteLine("Exception caught in process: {0}", _Exception.ToString())
            Return Nothing
        End Try

        Return _tmpImage
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles createtag.Click
        txttags.Text = ""
        For Each strLine As String In kelimeler.Text.Split(vbNewLine)
            If txttags.Text.Count >= 90 Then
                Exit For
            End If
            txttags.Text = txttags.Text & searchkeyword.Text & " " & strLine & ","
        Next
        Dim objWriter As New System.IO.StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory() & "/tags.txt", False)
        objWriter.WriteLine(txttags.Text)
        objWriter.Close()
    End Sub

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each strLine As String In kelimeler.Text.Split(vbNewLine)
            kelimelerlist.Items.Add(strLine.Replace("  ", ""))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
