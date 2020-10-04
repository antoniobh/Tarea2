MImports System.Drawing.Text
Imports System.IO
Module FUNCTIONS
    Sub BOLD()

    End Sub

    Sub ITALIC()

    End Sub

    Sub UNDERLINE()

    End Sub

    Sub SHADOW()
        NOTE.RICHTEXT_PAD.SelectionBackColor = Color.Yellow
    End Sub


    Sub ALIGN_LEFT()
        NOTE.RICHTEXT_PAD.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Sub ALIGN_CENTER()
        NOTE.RICHTEXT_PAD.SelectionAlignment = HorizontalAlignment.Center
    End Sub


    Sub ALIGN_RIGHT()
        NOTE.RICHTEXT_PAD.SelectionAlignment = HorizontalAlignment.Right
    End Sub



End Module