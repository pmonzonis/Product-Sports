Imports System.Drawing.Design

Public Class Form3
    Public conn As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Paula\source\repos\Exercici3\Exercici3\BaseDatos.mdf;Integrated Security=True")
    Public comm As New SqlClient.SqlCommand
    Dim obtenerDatos As New DataSet
    Dim FormPosition As Point
    Dim mouseAction As Boolean
    Dim res As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conn.Open()
            comm.Connection = conn
            comm.CommandType = CommandType.Text
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("No se puede conectar con la base de datos")
                End
            Else
                MsgBox(Err.Description)
            End If
        End Try

        TextBox1.Text = Module1.resBuscar

        If TextBox1.Text = "Accesorios" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "accesorios" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "Calzado" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "calzado" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "Camisetas" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "camisetas" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "Chaquetas" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "chaquetas" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "Pantalones" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "pantalones" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "Sudaderas" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "sudaderas" Then
            ComboBoxCategoria.Enabled = False
        ElseIf TextBox1.Text = "Baloncesto" Then
            ComboBoxDeporte.Enabled = False
        ElseIf TextBox1.Text = "baloncesto" Then
            ComboBoxDeporte.Enabled = False
        ElseIf TextBox1.Text = "Ciclismo" Then
            ComboBoxDeporte.Enabled = False
        ElseIf TextBox1.Text = "ciclismo" Then
            ComboBoxDeporte.Enabled = False
        ElseIf TextBox1.Text = "Fútbol" Then
            ComboBoxDeporte.Enabled = False
        ElseIf TextBox1.Text = "fútbol" Then
            ComboBoxDeporte.Enabled = False
        ElseIf TextBox1.Text = "Running" Then
            ComboBoxDeporte.Enabled = False
        ElseIf TextBox1.Text = "running" Then
            ComboBoxDeporte.Enabled = False
        ElseIf TextBox1.Text = "Yoga" Then
            ComboBoxDeporte.Enabled = False
        ElseIf TextBox1.Text = "yoga" Then
            ComboBoxDeporte.Enabled = False
        End If

        res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock ,descripcion as Descripción from Productos 
        where deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "'"

        Dim adapt As New SqlClient.SqlDataAdapter(res, conn)
        Dim obtenerDatos As New DataSet
        adapt.Fill(obtenerDatos, "Productos")
        DataGridView1.DataSource = obtenerDatos
        DataGridView1.DataMember = "Productos"
    End Sub

    Private Sub Form3_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        FormPosition = New Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y)
        mouseAction = True
    End Sub

    Private Sub Form3_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If mouseAction = True Then
            Location = New Point(Cursor.Position.X - FormPosition.X, Cursor.Position.Y - FormPosition.Y)
        End If
    End Sub

    Private Sub Form3_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mouseAction = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Close()
        Form1.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, ComboBoxCategoria.SelectedIndexChanged
        If ComboBoxPrecio.Text = "" Then 'precio vacio
            If ComboBoxTalla.Text = "" Then 'precio vacio y talla vacia
                If ComboBoxCategoria.Text = "" Then 'precio vacio, talla vacia, categoria vacia
                    If ComboBoxDeporte.Text = "" Then ' precio vacio, talla vacia, categoria vacia y deporte vacio
                    Else 'precio vacio, talla vacia ,categoria vacia y deporte lleno
                        res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                    where deporte ='" & ComboBoxDeporte.Text & "'  and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    End If
                Else 'precio vacio, talla vacia, categoria llena
                    res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock ,descripcion as Descripción from Productos 
                            where categoria ='" & ComboBoxCategoria.Text & "'  and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    If ComboBoxDeporte.Text = "" Then 'precio vacio, talla vacia, categoria llena, deporte vacio
                    Else 'precio vacio, talla vacia, categoria llena, deporte lleno
                        res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                        where categoria ='" & ComboBoxCategoria.Text & "' and deporte= '" & ComboBoxDeporte.Text & "' and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    End If
                End If
            Else 'precio vacio y talla llena
                If ComboBoxCategoria.Text = "" Then 'precio vacio, talla llena y categoria vacia
                    res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                    where talla = " & ComboBoxTalla.Text & "  and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    If ComboBoxDeporte.Text = "" Then 'precio vacio, talla llena, categoria vacia y deporte vacio
                    Else ' precio vacio, talla llena, categoria vacia y deporte lleno
                        res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                        where talla = " & ComboBoxTalla.Text & " and deporte= '" & ComboBoxDeporte.Text & "'  and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    End If
                Else 'precio vacio, talla llena y categoria llena
                    res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                    where talla =  " & ComboBoxTalla.Text & " and categoria ='" & ComboBoxCategoria.Text & "' and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    If ComboBoxDeporte.Text = "" Then ' precio vacio, talla llena, categoria llena y deporte vacio
                    Else 'precio vacio, talla llena, categoria llena y deporte lleno
                        res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                        where talla =  " & ComboBoxTalla.Text & " and categoria ='" & ComboBoxCategoria.Text & "' deporte= '" & ComboBoxDeporte.Text & "' and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    End If
                End If
            End If
        Else 'precio lleno
            If ComboBoxTalla.Text = "" Then 'precio lleno, talla vacia
                If ComboBoxCategoria.Text = "" Then ' precio lleno, talla vacia y categoria vacio
                    res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                    where precio <= " & ComboBoxPrecio.Text & "  and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    If ComboBoxDeporte.Text = "" Then 'precio lleno, talla vacia, categoria vacia y deporte vacio
                    Else 'precio lleno, talla vacia,categoria vacia y deporte lleno
                        res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                    where precio <= " & ComboBoxPrecio.Text & "and  deporte= '" & ComboBoxDeporte.Text & "' and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    End If
                Else 'precio lleno, talla vacia y categoria llena
                    res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                    where precio <= " & ComboBoxPrecio.Text & " and categoria = '" & ComboBoxCategoria.Text & "' and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    If ComboBoxDeporte.Text = "" Then 'precio lleno, talla vacia, categoria llena, deporte vacio
                    Else ' precio lleno, talla vacia, categoria llena y deporte lleno
                        res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                        where precio <= " & ComboBoxPrecio.Text & " and categoria = '" & ComboBoxCategoria.Text & "' and  deporte= '" & ComboBoxDeporte.Text & "' and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    End If
                End If
            Else 'precio lleno, talla llena
                If ComboBoxCategoria.Text = "" Then '  precio lleno, talla llena y categoria vacia
                    res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                    where precio <= " & ComboBoxPrecio.Text & " and talla= " & ComboBoxTalla.Text & "  and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    If ComboBoxDeporte.Text = "" Then '  precio lleno, talla llena, categoria vacia y deporte vacio
                    Else ' precio lleno, talla llena, categoria vacia y deporte lleno
                        res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                        where precio <= " & ComboBoxPrecio.Text & " and talla= " & ComboBoxTalla.Text & " and  deporte= '" & ComboBoxDeporte.Text & "' and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    End If
                Else 'precio lleno, talla llena y categoria llena
                    res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                    where precio <= " & ComboBoxPrecio.Text & " and talla = " & ComboBoxTalla.Text & " and categoria ='" & ComboBoxCategoria.Text & "' and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    If ComboBoxDeporte.Text = "" Then ' precio lleno, talla llena, categoria llena y deporte vacio
                    Else ' precio lleno, talla llena, categoria llena y deporte lleno
                        res = " Select nombreProducto As Nombre ,categoria as Categoria, precio as Precio, talla as Talla, deporte as Deporte,unidades as Stock,descripcion as Descripción from Productos 
                        where precio <= " & ComboBoxPrecio.Text & " and talla = " & ComboBoxTalla.Text & " and categoria ='" & ComboBoxCategoria.Text & "'and  deporte= '" & ComboBoxDeporte.Text & "' and (deporte= '" & TextBox1.Text & "' or nombreProducto='" & TextBox1.Text & "' or categoria= '" & TextBox1.Text & "')"
                    End If
                End If
            End If
        End If

        Dim adapt As New SqlClient.SqlDataAdapter(res, conn)
        Dim obtenerDatos As New DataSet
        adapt.Fill(obtenerDatos, "Productos")
        DataGridView1.DataSource = obtenerDatos
        DataGridView1.DataMember = "Productos"

    End Sub

    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
        Close()
        Form1.TextBox1.Visible = True
        Form1.Label1.Visible = True
        Form1.Button2.Visible = True
        Form1.TextBox1.Text = ""
        Form1.Show()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
        Form1.Close()
    End Sub
End Class
