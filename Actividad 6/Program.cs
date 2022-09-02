using Actividad_6.Educativos;
using Actividad_6.Entities;

Console.WriteLine("Hola mundo");

//Agregar Producto a Bodega

IBodega<Producto> bodega = new Bodega<Producto>();
bodega.Registrar (new Producto());