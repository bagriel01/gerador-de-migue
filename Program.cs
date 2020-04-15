using System;
using System.Collections.Generic;

namespace gerador_de_migue
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nr = new Random();
            int gerrandom1 = nr.Next(0, 20);
            int gerrandom2 = nr.Next(0, 20);
            string[] librarymigue;
            librarymigue = new string[21];
            librarymigue[0] = "Monstro";
            librarymigue[1] = "Gnomos";
            librarymigue[2] = "Deus";
            librarymigue[3] = "Dieta";
            librarymigue[4] = "Start Up";
            librarymigue[5] = "E-Girl";
            librarymigue[6] = "Sua mãe";
            librarymigue[7] = "Greve";
            librarymigue[8] = "Rinha";
            librarymigue[9] = "Bruxas";
            librarymigue[10] = "Onibus";
            librarymigue[11] = "Criança";
            librarymigue[12] = "Otakus";
            librarymigue[13] = "Lampada";
            librarymigue[14] = "Safado";
            librarymigue[15] = "Pescador";
            librarymigue[16] = "Pirata";
            librarymigue[17] = "Grávida de Taubaté";
            librarymigue[18] = "Exorcista";
            librarymigue[19] = "Chuva de Granito";
            librarymigue[20] = "Feitiçaria Sinistra";
            string nome;
            string nomedest;
            string role;
            
            Console.WriteLine("Boas vindas ao Gerador de Migué para furar rolê 2020");
            Console.WriteLine("Como alguém que detesta sair de casa, meu propósito com esse código é facilitar suas furadas de rolê.");
            Console.WriteLine("Primeiro, Qual é seu nome?");
            nome = (Console.ReadLine());
            Console.WriteLine("Perfeito, " + nome+ ", seu nome está registrado.");
            Console.WriteLine(nome+ ", Qual o rolê que você está querendo furar?");
            role = (Console.ReadLine());
            Console.WriteLine(nome+ ", Qual o nome da pessoa que você está enviando mensagem?");
            nomedest = (Console.ReadLine());
            Console.WriteLine("Certo. Você quer furar o rolê: " + role);
            Console.WriteLine("Perfeito. O Algorítmo vai gerar um Migué. Aguarde. . . ");
            
            Console.WriteLine("O Seu migué é:");
            Console.WriteLine("Foi mal, " + nomedest + " , Não posso ir no " + role + " Por que " + librarymigue[gerrandom1] + " e " + librarymigue[gerrandom2] + " impediram minha presença e por isso não vou poder ir. Desculpa!");
        }
    }
}
