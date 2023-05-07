using Gauss_POO.Moden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro();
            carro.marca = "Fiat";
            carro.modelo = "Palio Fire";
            carro.cor = "Prata";
            carro.ano = 2008;
            carro.km = 50f;
            carro.motor = new Motor();
            carro.motor.cilindro = "40";
            carro.motor.bobina = new Bobina();
            carro.motor.bobina.bobinaList = new List<string>();
            carro.motor.bobina.bobinaList.Add("Bobinha 1");
            carro.motor.bobina.bobinaList.Add("Bobinha 2");
            carro.motor.bobina.bobinaList.Add("Bobinha 3");

            Console.WriteLine("CARRO");
            Console.WriteLine($"Marca do carro: {carro.marca}\nModelo do carro: {carro.modelo}\nCor do carro: {carro.cor}\nAno do carro: {carro.ano}\nKm: {carro.km}");
            Console.WriteLine();
            Console.WriteLine("MOTOR");
            Console.WriteLine($"Cilindrada do carro {carro.motor.cilindro}");
            foreach(string i in carro.motor.bobina.bobinaList)
            {
                Console.WriteLine($"Número de bobinha: {i}");
            }
            Console.ReadKey();










        }
    }
}
