Public Class parsing


    Dim user As String
    Dim password As String
    Dim XYZ As Single
    Public Sub New(ByVal us As String, ByVal passwd As String, ByVal loc As Single)

        loc = XYZ
        passwd = password
        us = user


    End Sub
    Property checkLogin() As String


        Get
            Return user
        End Get
        Set(value As String)
            Return False
        End Set
    End Property





End Class
