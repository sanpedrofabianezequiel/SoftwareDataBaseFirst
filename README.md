# SoftwareDataBaseFirst



#Aclaracion para los metodos que solo traern Algunos CAMPOS
en la Instruccion LINQ
 var libros = (from x in _context.Libros
                          select new
                          {
                              x.ISBN,
                              x.Titulo,
                              x.Edicion
                          }).ToList() ;
            return libros;
------------------------------------------
Con ADO.NET 
Creamos en el Proyecto, los Modelos en base a las TABLAS
luego debemos configurar Las Capaz de Datos y LogicaBI

Utilizamos el Patron ADO.NET => DataBaseCodeFirst

Recordemos que cuando Elegimos las tablas para crear nuestros
Modelos, Debemos tildar la ocpion para Nombre Singulares o Plurales
En este Proyecto Trabajamos con ASP NET en el FrontEnd
Realizamos 3 Bibliotecas de para las CAPAS
Biblioteca BI
Biblioteca Datos
Biblioteca Entidades (ADO.NET)=> DataBaseCodeFirst



///La Cadena de conexion que crea el ADO.NET en el APP.Config
hay que llevarla al FrontEnd es decir el Web.Confing