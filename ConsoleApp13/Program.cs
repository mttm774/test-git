using System.Collections;


//ArrayList arraylist = new ArrayList();

//Console.WriteLine(arraylist.Capacity);

//arraylist.Add(5);
//arraylist.AddRange(new int[] { 6, -7, 8 });
//arraylist.AddRange(new object[] { "marcin", "mary" });
//arraylist.Insert(5, "el valor");

//Console.WriteLine(arraylist);
//Console.WriteLine(arraylist.Capacity);

//int[] numeros=new int[10];

//numeros[0] = 800;
//numeros[1] = 900;

//for(int i=0; i<numeros.Length; i++)
//{
//    Console.WriteLine(numeros[i]);
//}

//int [,] tabla= new int[10,10];
//for(int fila=1; fila<=10; fila++)
//{
//    for(int columna=1; columna <= 10; columna++)
//    {
//        tabla[fila-1,columna-1] = fila*columna;
//    }
//}

//for (int fila = 1; fila <= 10; fila++)
//{
//    for (int columna = 1; columna <= 10; columna++)
//    {
//        Console.Write(Convert.ToString(tabla[fila - 1, columna - 1]).PadLeft(4,' '));
//    }
//    Console.WriteLine();
////}

//namespace miejercicio
//{


//    public enum TerrenoEnum
//    {
//        HIERBA,
//        ARENA,
//        LADRILLO,
//        AGUA
//    }

//    public static class TerrenoEnumExtensions
//    {
//        public static ConsoleColor GetColor(this TerrenoEnum terreno)
//        {
//            switch (terreno)
//            {
//                case TerrenoEnum.HIERBA: return ConsoleColor.Green;
//                case TerrenoEnum.ARENA: return ConsoleColor.Yellow;
//                case TerrenoEnum.LADRILLO: return ConsoleColor.DarkGray;
//                default: return ConsoleColor.Blue;
//            }
//        }

//        public static char GetChar(this TerrenoEnum terreno)
//        {
//            switch (terreno)
//            {
//                case TerrenoEnum.HIERBA: return '\u201c';
//                case TerrenoEnum.ARENA: return '\u25cb';
//                case TerrenoEnum.LADRILLO: return '\u2248';
//                default: return '\u25cf';
//            }
//        }
//    }

//    public class mip
//    {


//        public static void Main()
//        {
//            TerrenoEnum[,] mapa =
//            {
//                {TerrenoEnum.ARENA, TerrenoEnum.ARENA, TerrenoEnum.ARENA,
//                  TerrenoEnum.ARENA, TerrenoEnum.LADRILLO, TerrenoEnum.LADRILLO,
//                  TerrenoEnum.LADRILLO, TerrenoEnum.LADRILLO, TerrenoEnum.LADRILLO,
//                  TerrenoEnum.LADRILLO},
//                {TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.AGUA,
//                  TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.AGUA,
//                  TerrenoEnum.AGUA, TerrenoEnum.HIERBA, TerrenoEnum.AGUA,
//                  TerrenoEnum.AGUA},
//            };

//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            for (int fila = 0; fila < mapa.GetLength(0); fila++)
//            {
//                for (int columna = 0; columna < mapa.GetLength(1); columna++)
//                {
//                    Console.ForegroundColor = mapa[fila, columna].GetColor();
//                    Console.Write(mapa[fila, columna].GetChar() + " ");
//                }
//                Console.WriteLine();
//            }
//            Console.ForegroundColor = ConsoleColor.Gray;
//        }
//    }

//}


namespace transporte
{


    public enum TipoTransporte
    {
        U,
        B,
        C,
        S,
        W,
        Enero,
        Febrero,
        Marzo,
        Abril
    }

    public static class TipoTransporteExtensions
    {
        public static ConsoleColor GetColor(this TipoTransporte transporte)
        {
            switch (transporte)
            {
                case TipoTransporte.U: return ConsoleColor.Green;
                case TipoTransporte.B: return ConsoleColor.Blue;
                case TipoTransporte.C: return ConsoleColor.Red;
                case TipoTransporte.S: return ConsoleColor.Magenta;
                case TipoTransporte.W: return ConsoleColor.DarkYellow;
                default: return ConsoleColor.Black;
            }
        }

        
    }

    public class mip
    {


        public static void Main()
        {

            TipoTransporte[] enero = 
            {
                TipoTransporte.Enero,
                TipoTransporte.U,TipoTransporte.B,TipoTransporte.B,TipoTransporte.W,TipoTransporte.C,
                TipoTransporte.S,TipoTransporte.S, TipoTransporte.U, TipoTransporte.C,
                TipoTransporte.S, TipoTransporte.B,TipoTransporte.B,TipoTransporte.B,
                TipoTransporte.C, TipoTransporte.B,TipoTransporte.U,TipoTransporte.B,
                TipoTransporte.C,TipoTransporte.B,TipoTransporte.S,TipoTransporte.C,TipoTransporte.U,
                TipoTransporte.W,TipoTransporte.C,TipoTransporte.S,TipoTransporte.B,
                TipoTransporte.U,TipoTransporte.W
            };

            TipoTransporte[] febrero =
            {
                TipoTransporte.Febrero,
                TipoTransporte.U,TipoTransporte.B,TipoTransporte.B,TipoTransporte.W,TipoTransporte.C,
                TipoTransporte.B,TipoTransporte.S, TipoTransporte.U, TipoTransporte.C,
                TipoTransporte.S, TipoTransporte.B,TipoTransporte.B,TipoTransporte.B,
                TipoTransporte.C, TipoTransporte.W,TipoTransporte.U,TipoTransporte.C,
                TipoTransporte.C,TipoTransporte.B,TipoTransporte.C,TipoTransporte.C,TipoTransporte.U,
                TipoTransporte.W,TipoTransporte.C,TipoTransporte.S,TipoTransporte.B,
                TipoTransporte.U,TipoTransporte.W
            };


            TipoTransporte[][] transportes =
            {
                enero,
                febrero
            };




            
            //for (int fila = 0; fila < transportes.GetLength(0); fila++)
            //{
            //    for (int columna = 0; columna < mapa.GetLength(1); columna++)
            //    {
            //        Console.ForegroundColor = mapa[fila, columna].GetColor();
            //        Console.Write(mapa[fila, columna].GetChar() + " ");
            //    }
            //    Console.WriteLine();
            //}

            for(int i=0; i<=transportes.Length-1; i++)
            {
                for (int j = 0; j <= transportes[i].Length - 1; j++)
                {
                    Console.BackgroundColor = transportes[i][j].GetColor();
                    Console.Write(transportes[i][j].ToString()+" ");
                }
                Console.WriteLine();
            }

        }
    }

}