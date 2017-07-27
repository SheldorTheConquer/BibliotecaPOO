using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Persistencia
{
    public static class Crip
    {
        public static string criptografarSenha(string entrada)
        {
            MD5 criptografarSenha = new MD5CryptoServiceProvider();

            criptografarSenha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(entrada));

            byte[] resultado = criptografarSenha.Hash;

            StringBuilder construtor = new StringBuilder();
            for (int i = 0; i < resultado.Length; i++)
            {
                construtor.Append(resultado[i].ToString("x2"));
            }

            return construtor.ToString();
        }
    }
}
