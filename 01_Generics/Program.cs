﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Generics.Modelo;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "Fiat", Modelo = "Uno"};
            Casa casa = new Casa() { Cidade = "Brasília", Endereco = "Rua 1, n 10"};
            Usuario usuario = new Usuario() { Nome = "Heber", Email = "heber@teste.com", Senha = "123456"};

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro2: " + carro2.Marca + " - " + carro2.Modelo);
            Console.WriteLine("Casa2: " + casa2.Cidade + " - " + casa2.Endereco);
            Console.WriteLine("Usuario2: " + usuario2.Nome + " - " + usuario2.Email + " - " + usuario2.Senha);
            Console.ReadKey();
        }
    }
}
