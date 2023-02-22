
Imports System.Data.SqlClient


Public Class Form1

    Dim connection_string As String = My.Settings.mydbConnectionString
    'Dim connection As String = "provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\mydb.accdb"

    Dim con As New OleDb.OleDbConnection(connection_string)
    Public Sub refresh1()
        Dim query As String = "SELECT * FROM user_tbl"
        CommonQuery(query, User_tblDataGridView)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh1()
    End Sub
    Public Sub CommonQuery(query, DataGridView)
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = query
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim i As Int32
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = "INSERT INTO user_tbl VALUES ('" + IDTextBox.Text + "','" + NameTextBox.Text + "' ,'" + User_nameTextBox.Text + "','" + User_passwordTextBox.Text + "','" + User_typeTextBox.Text + "')"
            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New record has been inserted successfully!")

            Else
                MsgBox("No record has been inserted successfully!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
        refresh1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim i As Int32
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = "UPDATE user_tbl SET name ='" + NameTextBox.Text + "',user_name='" + User_nameTextBox.Text + "',user_password='" + User_passwordTextBox.Text + "',user_type='" + User_typeTextBox.Text + "' WHERE ID = " + IDTextBox.Text.ToString().Trim() + ""
            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been updated successfully!")
            Else
                MsgBox("Record has been updated successfully!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        refresh1()
    End Sub

    Private Sub User_tblDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles User_tblDataGridView.CellClick
        IDTextBox.Text = User_tblDataGridView.CurrentRow.Cells(0).Value
        NameTextBox.Text = User_tblDataGridView.CurrentRow.Cells(1).Value
        User_nameTextBox.Text = User_tblDataGridView.CurrentRow.Cells(2).Value
        User_passwordTextBox.Text = User_tblDataGridView.CurrentRow.Cells(3).Value
        User_typeTextBox.Text = User_tblDataGridView.CurrentRow.Cells(4).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim i As Int32
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = "DELETE FROM user_tbl WHERE ID = " + IDTextBox.Text.ToString().Trim() + ""
            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been deleted successfully!")
            Else
                MsgBox("Record has been deleted successfully!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        refresh1()
    End Sub
End Class
