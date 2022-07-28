namespace NumberPerfect
{
    internal class Documentation
    {
        /// <summary>
        /// Se ccrea estatico para que me tome todos los valores 
        /// string[] - me convierte los valores en booleano.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /// Se crean la variables que sean de tipo entero 
            
            int b; int num; int j;

            /// Se cre la varible tipo Strin para que me tome el acomulador de los datos y los convierta
            string divider = "";

            /* Pregunta por consale y toma lo digitado por el suario
             * Se pone num = int, para que el usuario solo pueda digitar número.
             */
            Console.Write("Determine hasta que numero desea realizar la busqueda de numeros perfectos: ");
            num = int.Parse(Console.ReadLine());

            ///ponemos el primer ciclo para que me rrecorra los valores númericos donde 
            /// int inicializa en 1, donde i me toma el valor hasta donde quiero llegar, el i ++ me aumenta el valor
            /// el cual me indica hasta donde quiero llegar
            for (int i = 1; i <= num; i++)
            {
                /// B incializa en cero
                b = 0;

                //ponemos el primer ciclo para que me rrecorra los valores númericos donde 
                /// j inicializa en 1, donde j me toma el valor hasta donde quiero llegar,
                /// En este caso se divide la variable 
                /// el j ++ me aumenta el valor
                /// el cual me indica hasta donde quiero llegar
                for (j = 1; j <= (i / 2); j++)
                {
                    /// Si el valor de i el cual es 1 por el cliclo me indica que el valor de 0 es el residuo que
                    /// es multiplicable por J
                    if (i % j == 0)
                    {
                        /// me indica que b y j son operadores aritmeticos
                        b += j;
                        /// me indica que el divider es el acomulador de los operadores b y j, los cuales me arrojan 
                        /// y se muestran en la variable J dejando el texto en los lados o espacio vacio 
                        /// ´para que se muestre el texto
                        divider += " " + j + " ";

                    }

                }
                /// me indica que si b es igual i me muestre los valores tomados en el recorrido for
                if (b == i)
                    //concatemos el I para que me muestre el valor y divider para que me muestre los divisores acomulados
                    Console.WriteLine("El numero " + i + " es perfecto y su divisores son: " + divider);
                ///me permite vizualizar un espacio en la línea.
                divider = "";
            }
            	
            ///Obtiene el siguiente carácter o tecla de función presionada por el usuario. 
            ///La tecla presionada se muestra en la ventana de la consola.
             Console.ReadKey();
        }

        ///podemos crear un metodo con una clase boleen o en este casi i
        /// cuyo X seria la variable a almacenar la informació o ayudante
        Boolean x = false;


        /// <summary>
        /// Se crea Par de tipo boleano para que me tome los valores que sean número pares
        
        public Boolean Par(int j)
            {
            /// se crea un for para que me recorra los valores 
            for (int i = 0; i < j; i++)
            {
                /// /// si donde J su residuo es 0 entonces su multiplo es 2 en este caso par
                if (j % 2 ==0)
                {
                    /// me lo almacena en la variable x y verifica su es verdadero
                    return x = true;

                }
                else/// de lo contrario me debe de arrojar falso
                {
                    /// <returns>de retornar el valor si el numero no es par</returns>
                    return false;
                }
                /// </summary>
                /// <param name="j"></param>
            }
            /// <returns>me retorna el valor par</returns>
            return x;


        }


    }


}

