using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStreamTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] shortBytes = BitConverter.GetBytes((short)32000); //내가 보내고 싶은 shortbyte type
            byte[] intBytes = BitConverter.GetBytes(1652300);

            MemoryStream ms = new MemoryStream(); //파일의 읽는 시작점을 포인터로 설정 

            ms.Write(shortBytes, 0, shortBytes.Length);
            ms.Write(intBytes, 0, intBytes.Length);

            ms.Position = 0;

            //MemoryStream으로부터 short를 역직렬화
            byte[] outBytes = new byte[2];
            ms.Read(outBytes, 0, 2); //0~2 byte까지 read 
            int shortResult = BitConverter.ToInt16(outBytes, 0); 
            Console.WriteLine(shortResult);

            //Int 역직렬화
            outBytes = new byte[4]; // 포인트가 증가된 상태 
            ms.Read(outBytes, 0, 4);
            int intResult = BitConverter.ToInt32(outBytes, 0);
            Console.WriteLine(intResult);

        }
    }
}
