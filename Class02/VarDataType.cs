using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024CSStudyKDH._2024CSStudy
{
    namespace KDHWorkSpace
    {
        internal class VarDataType
        {
            void Test()
            {             
                var a = 3;
                var b = "한글";
                var c = 'd';
                var d = 0.1f;

                object aa = 3;
                object bb = "영어";
                object cc = 'f';
                object dd = 0.2f;

                Console.WriteLine($"a의 값 : {a} ");
                Console.WriteLine($"aa의 값 : {aa}");
            }
        } 
    }
}
