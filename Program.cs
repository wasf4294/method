using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10번째 강의 메소드, For문
            string tenth_str()
            {
                return "홍길동";
            }
            //tenth_str() 함수를 호출하여 출력할 수 있다.
            Console.WriteLine(tenth_str());
            
            //함수의 재사용성을 위해 변수로 함수를 호출한다.
            string name = tenth_str();
            Console.WriteLine(name);

            //대신 함수의 반환자료형에 따라 변수의 자료형도 맞춰줘야한다.
            //에러 !!!  int number = tenth_str();


            #endregion
        }
    }
}
