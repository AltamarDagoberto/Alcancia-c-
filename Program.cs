using CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void Main(String[] args)
    {
        int TOTAL = 5;
        int MENU;
        int MENU1;
        int MENUEST;
        int MENUPROF;
        int ID;
        int CANTEST = 0;
        bool VALIDACION;

        estudiante EST = new estudiante();
        List<estudiante> LISTAEST = new List<estudiante>(TOTAL);

        do
        {
            Console.WriteLine("\n 1. Guardar monedas \n 2. Cantidad de monedas \n 3. Cantidad de dinero \n 4. Cantidad de moneda por denominacion \n 5. Cantidad de dinero  por denominacion \n 6. Salir");

            MENU = System.Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (MENU >= 1 || MENU <= 6)
            {
                Console.WriteLine("ERROR");
            }

            Console.Clear();

            switch (MENU)
            {

                case 1:

                    Console.WriteLine("Inserte su moneda");
                    EST.MONEDA = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("\n 1. Insertar moneda \n 2. Devolverse al menu anterior");
                    MENU1 = System.Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (MENU1 >= 1 || MENU1 <= 2)
                    {
                        Console.WriteLine("ERROR");
                    }
                    for (int index1 = 0; index1 < 100; index1++)
                    {
                        switch (MENU1)
                        {
                            case 1:

                                if (EST.MONEDA == 50 || EST.MONEDA == 100 || EST.MONEDA == 200 || EST.MONEDA == 500 || EST.MONEDA == 1000)
                                {
                                    Console.WriteLine("Inserte su moneda");
                                    EST.MONEDA = int.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una moneda valida");
                                }
                        }

                    }





                    break;


                    //case 1:
                    //    Console.WriteLine("MENU ESTUDIANTE: \n 1. INSERTAR \n 2. ELIMINAR \n 3. MODIFICAR \n 4. LISTAR \n 5. REGRESAR");
                    //    MENUEST = System.Convert.ToInt32(Console.ReadLine());
                    //    Console.Clear();
                    //    switch (MENUEST)
                    //    {
                    //        case 1:
                    //            Console.WriteLine("NOMBRE:");
                    //            EST.NOMBRE = Console.ReadLine();
                    //            Console.Clear();

                    //            Console.WriteLine("APELLIDO:");
                    //            EST.APELLIDO = Console.ReadLine();
                    //            Console.Clear();

                    //            Console.WriteLine("IDENTIFICACION:");
                    //            EST.IDENTIFICACION = int.Parse(Console.ReadLine());
                    //            Console.Clear();

                    //            Console.WriteLine("SEXO \n 1.HOMBRE \n 2.MUJER  ");
                    //            EST.SEXO = int.Parse(Console.ReadLine());
                    //            Console.Clear();
                    //            Console.Clear();

                    //            Console.WriteLine("EDAD:");
                    //            EST.Edad = int.Parse(Console.ReadLine());
                    //            Console.Clear();

                    //            Console.WriteLine("ESCUELA:");
                    //            EST.ESCUELA = Console.ReadLine();
                    //            Console.Clear();

                    //            LISTAEST.Add(new estudiante(EST.Edad, EST.ESCUELA, EST.IDENTIFICACION, EST.NOMBRE, EST.APELLIDO, EST.SEXO));
                    //            CANTEST = 0;
                    //            CANTEST++;

                    //            break;
                    //        case 2:

                    //            if (LISTAEST.Count == 0)
                    //            {
                    //                Console.WriteLine("NO HAY REGISTRO");
                    //            }
                    //            else
                    //            {
                    //                Console.WriteLine($"ESTUDIANTES:  " + LISTAEST.Count);
                    //            }

                    //            Console.WriteLine("IDENTIFICACION DEL ESTUDIANTE A ELIMINAR");
                    //            ID = System.Convert.ToInt32(Console.ReadLine());
                    //            Console.Clear();
                    //            VALIDACION = false;

                    //            Console.WriteLine("LISTAR ESTUDIANTE " + LISTAEST.Count);
                    //            Console.Clear();

                    //            foreach (var item in LISTAEST)
                    //            {
                    //                if (ID == item.IDENTIFICACION)
                    //                {
                    //                    VALIDACION = true;
                    //                    LISTAEST.Remove(item);

                    //                    Console.WriteLine($"ELIMINADO");
                    //                    break;
                    //                }
                    //            }
                    //            if (!VALIDACION)
                    //            {

                    //                Console.WriteLine($"NO EXISTE");

                    //            }
                    //            Console.WriteLine("LISTA ESTUDIANTE" + LISTAEST.Count);
                    //            break;
                    //        case 3:
                    //            Console.WriteLine("IDENTIFICACION DEL ESTUDIANTE A MODIFICAR");
                    //            ID = System.Convert.ToInt32(Console.ReadLine());

                    //            foreach (estudiante item in LISTAEST)
                    //            {
                    //                if (ID == item.IDENTIFICACION)
                    //                {

                    //                    Console.WriteLine($"NOMBRE : {item.NOMBRE} | APELLIDO : {item.APELLIDO} | IDENTIFICACION : {item.IDENTIFICACION} | EDAD : {item.Edad} | SEXO : {item.SEXO} | ESCUELA : {item.ESCUELA} |");

                    //                    Console.WriteLine("NOMBRE :");
                    //                    EST.NOMBRE = Console.ReadLine();
                    //                    EST.NOMBRE = EST.NOMBRE;
                    //                    Console.WriteLine("APELLIDO :");
                    //                    EST.APELLIDO = Console.ReadLine();
                    //                    EST.APELLIDO = EST.APELLIDO;
                    //                    Console.WriteLine("IDENTIFICACION :");
                    //                    EST.IDENTIFICACION = Convert.ToInt32(Console.ReadLine());
                    //                    EST.IDENTIFICACION = EST.IDENTIFICACION;
                    //                    Console.WriteLine("EDAD :");
                    //                    EST.Edad = Convert.ToInt32(Console.ReadLine());
                    //                    EST.Edad = EST.Edad;
                    //                    Console.WriteLine("SEXO \n 1.HOMBRE \n 2.MUJER  :");
                    //                    EST.SEXO = Convert.ToInt32(Console.ReadLine());
                    //                    EST.SEXO = EST.SEXO;
                    //                    Console.WriteLine("ESCUELA :");
                    //                    EST.ESCUELA = Console.ReadLine();
                    //                    EST.ESCUELA = EST.ESCUELA;
                    //                    Console.WriteLine("\n");
                    //                    Console.WriteLine("MODIFICACION EXITOSA ");
                    //                    break;
                    //                }
                    //                else
                    //                {
                    //                    Console.WriteLine($"NO EXISTE");
                    //                }
                    //            }

                    //            break;
                    //        case 4:

                    //            String Masculino = "HOMBRE";
                    //            String Femenino = "MUJER";
                    //            foreach (estudiante item in LISTAEST)
                    //            {
                    //                Console.WriteLine($"NOMBRE : {item.NOMBRE} ");
                    //                Console.WriteLine($"APELLIDO: {item.APELLIDO} ");
                    //                Console.WriteLine($"IDENTIFICACION: {item.IDENTIFICACION} ");
                    //                if (item.SEXO == 1)
                    //                {
                    //                    Console.WriteLine($"SEXO: {Masculino} ");
                    //                }
                    //                else if (item.SEXO == 2)
                    //                {
                    //                    Console.WriteLine($"SEXO: {Femenino} ");
                    //                }
                    //                else
                    //                {
                    //                    Console.WriteLine("DIGITO NO VALIDO");
                    //                }
                    //                Console.WriteLine($"EDAD: {item.Edad} ");
                    //                Console.WriteLine($"ESCUELA: {item.ESCUELA} \n ");

                    //            }
                    //            break;
                    //        case 5:
                    //            break;
                    //    }
                    //    break;

                    //case 2:
                    //    Console.WriteLine("PROFESOR \n 1. INSERTAR \n 2. ELIMINAR \n 3. EDITAR \n 4. LISTAR  \n 5. REGRESAR");
                    //    MENUPROF = System.Convert.ToInt32(Console.ReadLine());
                    //    Console.Clear();

                    //    switch (MENUPROF)
                    //    {

                    //        case 1:
                    //            Console.WriteLine("NOMBRE");
                    //            PROF.NOMBRE = Console.ReadLine();
                    //            Console.Clear();

                    //            Console.WriteLine("APELLIDO");
                    //            PROF.APELLIDO = Console.ReadLine();
                    //            Console.Clear();

                    //            Console.WriteLine("IDENTIFICACION");
                    //            PROF.IDENTIFICACION = int.Parse(Console.ReadLine());
                    //            Console.Clear();

                    //            Console.WriteLine("SEXO \n 1.HOMBRE \n 2.MUJER  :");
                    //            PROF.SEXO = int.Parse(Console.ReadLine());
                    //            Console.Clear();

                    //            Console.WriteLine("PROFESION");
                    //            PROF.PROFESION = Console.ReadLine();
                    //            Console.Clear();

                    //            Console.WriteLine("UNIVERSIDAD");
                    //            PROF.UNIVERSIDAD = Console.ReadLine();
                    //            Console.Clear();

                    //            Console.WriteLine("FECHA DE INGRESO");
                    //            PROF.FECHAINGRESO = Console.ReadLine();
                    //            Console.Clear();

                    //            Console.WriteLine("AÑO DE CULMINACION");
                    //            PROF.AÑOFINALIZACION = Console.ReadLine();
                    //            Console.Clear();


                    //            LISTAP.Add(new Profesor(
                    //                PROF.NOMBRE, PROF.APELLIDO, PROF.IDENTIFICACION, PROF.SEXO, PROF.PROFESION, PROF.UNIVERSIDAD,PROF.FECHAINGRESO, PROF.AÑOFINALIZACION, PROF.NIVEL_ACADEMICO));



                    //            break;
                    //        case 2:

                    //            if (LISTAP.Count == 0)
                    //            {
                    //                Console.WriteLine("No hay datos, La Lista Esta Vacia");
                    //            }
                    //            else
                    //            {
                    //                Console.WriteLine($"Profesores Registrados :  " + LISTAP.Count);
                    //            }
                    //            Console.WriteLine("Ingrese la IDENTIFICACION para eliminar al Profesor .");
                    //            ID = System.Convert.ToInt32(Console.ReadLine());
                    //            Console.Clear();
                    //            VALIDACION = false;
                    //            Console.WriteLine("Profesores Registrados " + LISTAP.Count);
                    //            Console.Clear();

                    //            foreach (var item in LISTAP)
                    //            {
                    //                if (ID == item.IDENTIFICACION)
                    //                {
                    //                    VALIDACION = true;
                    //                    LISTAP.Remove(item);

                    //                    Console.WriteLine($"El Profesor con  -> ( IDENTIFICACION = {item.IDENTIFICACION}) Eliminado ");
                    //                    Console.WriteLine($"Datos del Profesor :  \n IDENTIFICACION : {item.IDENTIFICACION} | NOMBRE : {item.NOMBRE} | APELLIDO : {item.APELLIDO} | Fecha De Ingreso : {item.FECHAINGRESO} | PROFESION : {item.PROFESION} | UNIVERSIDAD : {item.UNIVERSIDAD} | SEXO : {item.SEXO} | Año de Culminacion : {item.AÑOFINALIZACION} |");

                    //                    break;
                    //                }
                    //            }
                    //            if (!VALIDACION)
                    //            {
                    //                Console.WriteLine($"El Profesor con IDENTIFICACION ( {ID} ) no existe");
                    //            }
                    //            Console.WriteLine("Profesores disponibles Disponibles " + LISTAP.Count);
                    //            break;
                    //        case 3:

                    //            if (LISTAP.Count == 0)
                    //            {
                    //                Console.WriteLine("NO HAY REGISROS");
                    //            }
                    //            else
                    //            {
                    //                Console.WriteLine($"PROFESORES EN LISTA:  " + LISTAP.Count);

                    //            }

                    //            Console.WriteLine("IDENTIFICACION DEL PROFESOR A MODIFICAR");
                    //            ID = System.Convert.ToInt32(Console.ReadLine());
                    //            Console.Clear();
                    //            VALIDACION = false;

                    //            Console.WriteLine("PROFESORES REGISTRADOS" + LISTAP.Count);
                    //            Console.Clear();
                    //            int i = 0;
                    //            foreach (var item in LISTAP)
                    //            {
                    //                i++;
                    //                if (ID == item.IDENTIFICACION)
                    //                {
                    //                    VALIDACION = true;
                    //                    Console.WriteLine($"NOMBRE: {item.NOMBRE} | APELLIDO : {item.APELLIDO} |  IDENTIFICACION : {item.IDENTIFICACION} | SEXO : {item.SEXO} |");

                    //                    Console.WriteLine("NOMBRE");
                    //                    PROF.NOMBRE = Console.ReadLine();
                    //                    Console.Clear();

                    //                    Console.WriteLine("APELLIDO");
                    //                    PROF.APELLIDO = Console.ReadLine();
                    //                    Console.Clear();

                    //                    Console.WriteLine("IDENTIFICACION");
                    //                    PROF.IDENTIFICACION = int.Parse(Console.ReadLine());
                    //                    Console.Clear();

                    //                    Console.WriteLine("EDAD");
                    //                    PROF.SEXO = int.Parse(Console.ReadLine());
                    //                    Console.Clear();

                    //                    Console.WriteLine("PROFESION");
                    //                    PROF.PROFESION = Console.ReadLine();
                    //                    Console.Clear();

                    //                    Console.WriteLine("NIVEL ACADEMICO");
                    //                    PROF.NIVEL_ACADEMICO = Console.ReadLine();
                    //                    Console.Clear();

                    //                    Console.WriteLine("AÑO DE CULMINACION");
                    //                    PROF.AÑOFINALIZACION = Console.ReadLine();
                    //                    Console.Clear();

                    //                    Console.WriteLine("UNIVERSIDAD");
                    //                    PROF.UNIVERSIDAD = Console.ReadLine();

                    //                    LISTAP[i] = PROF;

                    //                    break;
                    //                }
                    //            }
                    //            if (!VALIDACION)
                    //            {
                    //                Console.WriteLine($"NO EXISTE");
                    //            }
                    //            else
                    //            {
                    //                Console.WriteLine("SUCCESFULL");
                    //            }
                    //            break;
                    //        case 4:
                    //            foreach (Profesor item in LISTAP)
                    //            {
                    //                Console.WriteLine($"NOMBRE: {item.NOMBRE}");
                    //                Console.WriteLine($"APELLIDO: {item.APELLIDO}");
                    //                Console.WriteLine($"IDENTIFICACION: {item.IDENTIFICACION}");
                    //                Console.WriteLine($"PROFESION: {item.PROFESION}");
                    //                Console.WriteLine($"UNIVERSIDAD: {item.UNIVERSIDAD}");
                    //                Console.WriteLine($"AÑO DE CULMINACION: {item.AÑOFINALIZACION}");
                    //                Console.WriteLine($"FECHA DE INGRESO: {item.FECHAINGRESO}");
                    //            }
                    //            break;
                    //        case 5:
                    //            break;
                    //    }
                    //    break;
                    //case 3:
                    //    Console.WriteLine("...");
                    //    break;
            }
        }
        while (MENU != 3);
        Console.Clear();
    }
}