Public Class Form1
    Public conn As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Paula\source\repos\Exercici3\Exercici3\BaseDatos.mdf;Integrated Security=True")
    Public comm As New SqlClient.SqlCommand
    Dim FormPosition As Point
    Dim mouseAction As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.resBuscar = TextBox1.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Indica el producto  o deporte a buscar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Label1.Visible = False Then
                Module1.resBuscar = TextBox1.Text
                Form3.Show()
            Else
                Module1.resBuscar = TextBox1.Text
                Form2.Show()
            End If
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If mouseAction = True Then
            Location = New Point(Cursor.Position.X - FormPosition.X, Cursor.Position.Y - FormPosition.Y)
            mouseAction=True
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        FormPosition = New Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y)
        mouseAction = True
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mouseAction = False
    End Sub

    Private Sub BotonBuscar_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        Button2.Size = New Size(80, 30)
    End Sub

    Private Sub BotonBuscar_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Button2.Size = New Size(77, 27)
    End Sub

    Private Sub AccesoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoriosToolStripMenuItem.Click
        TextBox1.Text = "Accesorios"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub

    Private Sub CalzadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalzadoToolStripMenuItem.Click
        TextBox1.Text = "Calzado"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub

    Private Sub CamisetasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CamisetasToolStripMenuItem.Click
        TextBox1.Text = "Camisetas"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub

    Private Sub ChaquetasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChaquetasToolStripMenuItem.Click
        TextBox1.Text = "Chaquetas"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub

    Private Sub PantalonesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PantalonesToolStripMenuItem.Click
        TextBox1.Text = "Pantalones"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub

    Private Sub SudaderasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SudaderasToolStripMenuItem.Click
        TextBox1.Text = "Sudaderas"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub

    Private Sub BaloncestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaloncestoToolStripMenuItem.Click
        TextBox1.Text = "Baloncesto"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub

    Private Sub CiclismoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiclismoToolStripMenuItem.Click
        TextBox1.Text = "Ciclismo"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub

    Private Sub FútbolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FútbolToolStripMenuItem.Click
        TextBox1.Text = "Fútbol"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub


    Private Sub YogaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YogaToolStripMenuItem.Click
        TextBox1.Text = "Yoga"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub

    Private Sub RunningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunningToolStripMenuItem.Click
        TextBox1.Text = "Running"
        TextBox1.Visible = False
        Label1.Visible = False
        Button2.PerformClick()
        Button2.Visible = False
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Close()
    End Sub


End Class