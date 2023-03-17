using Almacen.Models;
using System;


AlmacenContext db = new AlmacenContext();

var buscar = db.Productos.FirstOrDefault(x => x.Id == 1);
Console.WriteLine(buscar);

{
    Producto producto = new Producto();
    Console.WriteLine("Ingresar el nombre del producto ->");
    producto.Nombre = Console.ReadLine();
    Console.WriteLine("Ingresar la descripcion ->");
    producto.Descripción = Console.ReadLine();
    Console.WriteLine("Ingresar el precio del producto -> ");
    producto.Precio = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Ingresar el Stock del producto -> ");
    producto.Stock = Convert.ToInt32(Console.ReadLine()); 

    db.Productos.Add(producto);
    db.SaveChanges();
}

var ListProductos = db.Productos.ToList();

foreach (var pro in ListProductos)
{
    Console.WriteLine("=============================================");
    Console.WriteLine($"Los produtos ingresados son:\n" +  
        $"Nombre: {pro.Nombre}\n" +
        $"Descripcion: {pro.Descripción}\n" +
        $"Precio: {pro.Precio}\n" +
        $"Stock: {pro.Stock}\n");
    Console.WriteLine("=============================================");
}
