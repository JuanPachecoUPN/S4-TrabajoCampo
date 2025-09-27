using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4TrabajoCampo
{
    internal class Program
    {
        static double saldo = 1000;
        static double monto;
        static int errores = 0;

        static void Main(string[] args)
        {
            mostrarMenu();

        }

        static void mostrarMenu()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Consultar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Depositar");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        consultarSaldo();
                        mostrarMenu();
                        break;
                    case 2:
                        verificarIntentosFallidos();
                        solicitarMonto("R");
                        validarMonto("R");
                        actualizarSaldo("R", monto);
                        mensajeExito();
                        mostrarMenu();
                        break;
                    case 3:
                        solicitarMonto("D");
                        validarMonto("D");
                        actualizarSaldo("D", monto);
                        mensajeExito();
                        mostrarMenu();
                        break;
                }
            }
            while (opcion != 4);

            Console.WriteLine("Programa Finalizado");
            Console.ReadKey();
        }

        static void consultarSaldo()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("Su saldo actual es: {0}", saldo);
            Console.WriteLine("===================================");
            Console.WriteLine("Presione cualquier tecla para volver al menú");
            Console.ReadKey();
        }

        static void verificarIntentosFallidos()
        {
            if (errores == 3)
            {
                Console.WriteLine("============================================================");
                Console.WriteLine("Retiros Bloqueados por exceso de errores. Contacte al Banco.");
                Console.WriteLine("============================================================");
                Console.WriteLine("Presione cualquier tecla para volver al menú");
                Console.ReadKey();
                mostrarMenu();
            }
        }

        static void solicitarMonto(string tipoOperacion)
        {
            Console.Clear();
            if (tipoOperacion == "R")
            {
                Console.WriteLine("Ingrese el monto que desea retirar");
            }
            else if (tipoOperacion == "D")
            {
                Console.WriteLine("Ingrese el monto que desea depositar");
            }
            monto = double.Parse(Console.ReadLine());
        }

        static void validarMonto(string tipoOperacion)
        {
            if (tipoOperacion == "R")
            {
                if (monto > 0 && monto <= 500)
                {
                    if (monto <= saldo)
                    {
                        Console.WriteLine("Procesando...");
                    }
                    else
                    {
                        mensajeSaldoInsuficiente();
                        mostrarMenu();
                    }
                }
                else
                {
                    mensajeMontoLimite();
                    mostrarMenu();
                }
            }
            else if (tipoOperacion == "D")
            {
                if (monto <= 0)
                {
                    Console.WriteLine("Monto no válido");
                    mostrarMenu();
                }
                else
                {
                    Console.WriteLine("Procesando...");
                }

            }
        }

        public static double actualizarSaldo(string tipoOperacion, double monto)
        {
            if (tipoOperacion == "R")
            {
                saldo = saldo - monto;
            }
            else if (tipoOperacion == "D")
            {
                saldo = saldo + monto;
            }
            return saldo;
        }

        public static void mensajeExito()
        {
            Console.WriteLine("Operación exitosa. Su saldo ha sido actualizado.");
            Console.ReadKey();
        }

        public static void mensajeSaldoInsuficiente()
        {
            errores++;
            Console.WriteLine("No cuenta con saldo suficiente.");
            Console.WriteLine("Intentos fallidos: {0} (Si llega a 3 se bloquearán los retiros).", errores);
            Console.ReadKey();
        }

        public static void mensajeMontoLimite()
        {
            errores++;
            Console.WriteLine("Límite de 500 por operación.");
            Console.WriteLine("Intentos fallidos: {0} (Si llega a 3 se bloquearán los retiros).", errores);
            Console.ReadKey();
        }

    }
}
