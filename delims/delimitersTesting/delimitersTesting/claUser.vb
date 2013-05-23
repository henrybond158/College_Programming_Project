Public Class claUser
    Dim intNo, intX, intY, intZ As Single
    Dim strName As String

    Public Sub New(ByVal No As Single, ByVal Name As String, ByVal X As Single, ByVal Y As Single, ByVal Z As Single)
        intNo = No
        intX = X
        intY = Y
        intZ = Z
        strName = Name


    End Sub
    Property showName() As String
        Get

            Return strName
        End Get
        Set(ByVal strValue As String)
            strName = strValue
        End Set
    End Property

    ReadOnly Property showNo()
        Get

            Return intNo
        End Get
    End Property

    ReadOnly Property showX()
        Get

            Return intX

        End Get
    End Property

    ReadOnly Property showY()
        Get

            Return intY
        End Get
    End Property

    ReadOnly Property showZ()
        Get

            Return intZ
        End Get
    End Property



End Class
