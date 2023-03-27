using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Algorythm
{
    class Actions
    {
        private int[] A;
        private int[] B;
        private int[] C;
        private Random rand = new Random();
       
        public void Vectors (string str)
        {
            int leng = str.Length;
            A = new int[leng];
            B = new int[leng];
            C = new int[leng];
            for (int x = 0; x < leng; x++)
            {
                A[x] = rand.Next(leng);
                B[x] = rand.Next(leng);
                C[x] = rand.Next(leng);
            }
            
        }
       
        public string EncodeLinear(string str)
        {
            StringBuilder first = new StringBuilder();
            int leng = str.Length;
           
            int key;
            for (int i = 0; i < leng; i++)
            {
                key = A[i] * i + B[i];              
                int intRes = (str[i] + key) % 65536;
                char charRes = (char)intRes;
                first.Append(charRes);
            }

            return first.ToString();
        }
        public string DecodeLinear(string str)
        {
            StringBuilder first = new StringBuilder();
            int leng = str.Length;

            int key;
            for (int i = 0; i < leng; i++)
            {
                key = A[i] * i + B[i];
                int intRes = (str[i] - key) % 65536;
                char charRes = (char)intRes;
                first.Append(charRes);
            }

            return first.ToString();
        }

        public string EncodeNonLinear(string str)
        {
            StringBuilder first = new StringBuilder();
            int leng = str.Length;

            int key;
            for (int i = 0; i < leng; i++)
            {
                key = A[i] * i * i + B[i] * i + C[i];
                int intRes = (str[i] + key) % 65536;
                char charRes = (char)intRes;
                first.Append(charRes);
            }

            return first.ToString();
            
        }

        public string DecodeNonLinear(string str)
        {
            StringBuilder first = new StringBuilder();
            int leng = str.Length;

            int key;
            for (int i = 0; i < leng; i++)
            {
                key = A[i] * i * i + B[i] * i + C[i];
                int intRes = (str[i] - key) % 65536;
                char charRes = (char)intRes;
                first.Append(charRes);
            }

            return first.ToString();
        }

        public string GasloEncode(string str, string gaslo)
        {
            int leng = str.Length;
            int l = gaslo.Length;
            string charRes = "";
            
            for (int i = 0; i < leng; i++)
            {
                charRes += Char.ConvertFromUtf32((str[i] + (gaslo[i % l] % l)) % 65536);
            }
            return charRes;
        }
        public string GasloDecode(string str, string gaslo)
        {
            int leng = str.Length;
            int l = gaslo.Length;
            string charRes = "";

            for (int i = 0; i < leng; i++)
            {
                charRes += Char.ConvertFromUtf32((str[i] - (gaslo[i % l] % l)) % 65536);
            }
            return charRes;
        }
    }
}
