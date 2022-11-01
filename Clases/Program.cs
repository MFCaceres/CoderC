using Clases;

Console.ReadLine(); 
Producto producto = new Producto();

producto.codigo = 1;
producto.descripcion = "Esta es mi descripcion";

Console.WriteLine(producto.codigo);

Console.WriteLine(producto.ToString());

Console.ReadLine();

Usuario usuario = new Usuario();

usuario.nombre = "Martin";
usuario.email = "licaceresmartin@gmail.com";
usuario.apellido = "Caceres";

Console.WriteLine(usuario.nombre);
Console.WriteLine(usuario.email);
Console.WriteLine(usuario.apellido);

Console.ReadLine();

//Persona persona = new Persona();
