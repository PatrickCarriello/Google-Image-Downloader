<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.fetchimage = New System.Windows.Forms.Button()
        Me.website = New System.Windows.Forms.WebBrowser()
        Me.links = New System.Windows.Forms.ListBox()
        Me.searchkeyword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttags = New System.Windows.Forms.TextBox()
        Me.createtag = New System.Windows.Forms.Button()
        Me.log = New System.Windows.Forms.ListBox()
        Me.kelimeler = New System.Windows.Forms.TextBox()
        Me.kelimelerlist = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.piece = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'fetchimage
        '
        Me.fetchimage.Location = New System.Drawing.Point(605, 49)
        Me.fetchimage.Name = "fetchimage"
        Me.fetchimage.Size = New System.Drawing.Size(157, 35)
        Me.fetchimage.TabIndex = 0
        Me.fetchimage.Text = "Fetch Images"
        Me.fetchimage.UseVisualStyleBackColor = True
        '
        'website
        '
        Me.website.Location = New System.Drawing.Point(12, 12)
        Me.website.MinimumSize = New System.Drawing.Size(20, 20)
        Me.website.Name = "website"
        Me.website.ScriptErrorsSuppressed = True
        Me.website.Size = New System.Drawing.Size(584, 405)
        Me.website.TabIndex = 1
        Me.website.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'links
        '
        Me.links.FormattingEnabled = True
        Me.links.Location = New System.Drawing.Point(6, 425)
        Me.links.Name = "links"
        Me.links.Size = New System.Drawing.Size(590, 43)
        Me.links.TabIndex = 2
        '
        'searchkeyword
        '
        Me.searchkeyword.Location = New System.Drawing.Point(608, 23)
        Me.searchkeyword.Name = "searchkeyword"
        Me.searchkeyword.Size = New System.Drawing.Size(100, 20)
        Me.searchkeyword.TabIndex = 3
        Me.searchkeyword.Text = "lamborghini"
        Me.searchkeyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(605, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tags"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(637, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Keyword"
        '
        'txttags
        '
        Me.txttags.Location = New System.Drawing.Point(608, 396)
        Me.txttags.Name = "txttags"
        Me.txttags.Size = New System.Drawing.Size(147, 20)
        Me.txttags.TabIndex = 9
        '
        'createtag
        '
        Me.createtag.Location = New System.Drawing.Point(605, 352)
        Me.createtag.Name = "createtag"
        Me.createtag.Size = New System.Drawing.Size(151, 38)
        Me.createtag.TabIndex = 10
        Me.createtag.Text = "Create Tags"
        Me.createtag.UseVisualStyleBackColor = True
        '
        'log
        '
        Me.log.FormattingEnabled = True
        Me.log.Location = New System.Drawing.Point(597, 425)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(159, 43)
        Me.log.TabIndex = 15
        '
        'kelimeler
        '
        Me.kelimeler.Location = New System.Drawing.Point(608, 103)
        Me.kelimeler.Multiline = True
        Me.kelimeler.Name = "kelimeler"
        Me.kelimeler.Size = New System.Drawing.Size(148, 243)
        Me.kelimeler.TabIndex = 16
        Me.kelimeler.Text = "images" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2017 images" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "last images" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "recent images" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hd images" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "image" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "photo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "full hd" & _
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "best pictures"
        '
        'kelimelerlist
        '
        Me.kelimelerlist.FormattingEnabled = True
        Me.kelimelerlist.Location = New System.Drawing.Point(951, 186)
        Me.kelimelerlist.Name = "kelimelerlist"
        Me.kelimelerlist.Size = New System.Drawing.Size(10, 160)
        Me.kelimelerlist.TabIndex = 17
        Me.kelimelerlist.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(718, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Piece"
        '
        'piece
        '
        Me.piece.Location = New System.Drawing.Point(714, 23)
        Me.piece.Name = "piece"
        Me.piece.Size = New System.Drawing.Size(42, 20)
        Me.piece.TabIndex = 19
        Me.piece.Text = "1"
        Me.piece.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 476)
        Me.Controls.Add(Me.piece)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.links)
        Me.Controls.Add(Me.kelimelerlist)
        Me.Controls.Add(Me.kelimeler)
        Me.Controls.Add(Me.log)
        Me.Controls.Add(Me.createtag)
        Me.Controls.Add(Me.txttags)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchkeyword)
        Me.Controls.Add(Me.website)
        Me.Controls.Add(Me.fetchimage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[ Google Image Downloader | ODL ]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fetchimage As System.Windows.Forms.Button
    Friend WithEvents website As System.Windows.Forms.WebBrowser
    Friend WithEvents links As System.Windows.Forms.ListBox
    Friend WithEvents searchkeyword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttags As System.Windows.Forms.TextBox
    Friend WithEvents createtag As System.Windows.Forms.Button
    Friend WithEvents log As System.Windows.Forms.ListBox
    Friend WithEvents kelimeler As System.Windows.Forms.TextBox
    Friend WithEvents kelimelerlist As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents piece As System.Windows.Forms.TextBox

End Class
