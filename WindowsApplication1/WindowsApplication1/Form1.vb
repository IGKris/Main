Option Explicit On
Option Infer Off

Imports System.IO

Public Class Form1
    Public records As Integer = 23

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim reader As StreamReader
        Dim line As String
        Dim count As Integer

        reader = New StreamReader("c:\a\test.txt")

        Do
            count += 1
            line = reader.ReadLine
        Loop Until line = String.Empty
        reader.Close()

        Label3.Text = count.ToString()


        Dim studentNum As String
        Dim validation As String

        'first get 2 numbers from date
        Dim curDate As String = Date.Today.Year.ToString()
        curDate = curDate(2) & curDate(3)

        'number of students
        Dim numberOfStudents As String = records.ToString()
        numberOfStudents = numberOfStudents.PadLeft(4, "0")

        'add together
        studentNum = curDate & numberOfStudents
        Dim x As Integer = 0
        Dim sumOfDigits As Integer = 0
        For x = 0 To 5
            sumOfDigits = sumOfDigits + Integer.Parse(studentNum(x))
            sumOfDigits = sumOfDigits Mod 10
        Next
        sumOfDigits = 10 - sumOfDigits

        studentNum = curDate & numberOfStudents & sumOfDigits.ToString()
        Dim checkValidation As Integer = 0
        For x = 0 To 6
            checkValidation = checkValidation + Integer.Parse(studentNum(x))
        Next

        If Not checkValidation = 10 Then
            Label2.Text = "Is Valid"
        Else
            Label2.Text = "Is Not Valid"
        End If



        Label1.Text = studentNum

    End Sub
End Class
