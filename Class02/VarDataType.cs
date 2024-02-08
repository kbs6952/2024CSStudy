using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024CSStudyKDH._2024CSStudy
{
    namespace KDHWorkSpace
    {
        // int, float, string... 데이터 형식을 선언해주고. 선언부에 이름을 작성을 해서 데이터를 사용을 하자나요.
        // C#은 데이터 타입과 참조 타입이 고정되어서 정해져 있기 때문에.. 

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
