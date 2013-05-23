Imports System.IO

Public Class Form1


    Dim arrUsers(10) As claUser
    Dim count As Integer
    Dim selected As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'when button 1 is clicked, the sub routine 'run' is called
        run()


    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' sets the interger selected to the number which is selected in the listbox
        selected = ListBox1.SelectedIndex
        'calls the change sub routine
        change()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'sets arrUsers with the number which is held in the selected integer with the value held in showNName to textbox1
        arrUsers(selected).showName = TextBox1.Text
        ' declares objWrite to as a inbuilt class for writing data, with the file in question as a relative path 'users.txt'
        Dim objWrite As New System.IO.StreamWriter("users.txt")
        'sets the count to one below what is selected so that the correct one is selected as deafult is 0 not 1
        For x = 0 To count - 1
            'sets the objWrite to write the data held in each object in the array
            With arrUsers(x)
                objWrite.WriteLine(.showNo & "," & .showName & "," & .showX & "," & .showY & "," & .showZ)
            End With

        Next
        'calls the Write function to close, then calls the run sub routine and change sub routine to automatically update the list
        objWrite.Close()
        run()
        change()
    End Sub
    Private Sub run()
        'sets count to 0
        count = 0
        'clears out the listbox to stop it from continuly adding more values
        ListBox1.Items.Clear()
        'sets strLine as a string
        Dim strLine As String
        'reads all the lines and loads them one one by one into each part of the array
        For Each strLine In File.ReadAllLines("users.txt")
            Dim arrParts As String() = strLine.Split(New Char() {","c})
            arrUsers(count) = New claUser(CSng(arrParts(0)), arrParts(1), CSng(arrParts(2)), CSng(arrParts(3)), CSng(arrParts(4)))
            ListBox1.Items.Add(arrParts(1))
            count += 1
        Next

    End Sub
    Private Sub change()
        'using the selected number of the list box, sets the labels to the correct values
        With arrUsers(selected)
            Label1.Text = "Number:" & .showNo
            Label2.Text = "Name: " & .showName
            Label3.Text = "X:" & .showX
            Label4.Text = "Y:" & .showY
            Label5.Text = "Z:" & .showZ
        End With

    End Sub

End Class
