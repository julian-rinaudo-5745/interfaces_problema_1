// See https://aka.ms/new-console-template for more information
using interfaces_problema_1;




Pila pila = new Pila(3);

pila.Añadir("sdsd");
pila.Añadir(2);
pila.Añadir(3);



object res = pila.Extraer();



Console.WriteLine(res);

//Cola cola = new Cola();

//cola.Añadir("sdsd");
//cola.Añadir(2);
//cola.Añadir(3);
//cola.Añadir(4);
//cola.Añadir(5);


//object res = cola.Extraer();

//Console.WriteLine(res);