using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creche_Maravilha
{
    class Globais
    {
        public static int nivel = 0;
        public static string nome = "";

        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "maravilha_bd.db";
        public static string caminhoBanco = caminho + @"\DataBase\";

        public static string caminhoFotos = caminho + @"\imgs\";
        public static string FotosFuncionarios = @"professores\";
    }
}
