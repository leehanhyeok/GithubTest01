using System.Net.Sockets;
using System.Net;
using System.Text;

namespace TestClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread clientThread = new Thread(clientFunc);
            clientThread.Start();
            clientThread.IsBackground = true;
            clientThread.Join();

            Console.WriteLine("클라이언트가 종료 되었습니다.");
        }
        static void clientFunc(object obj)
        {
            try
            {
                //1.소켓만들기
                Socket socket = new Socket(AddressFamily.InterNetwork,
                                        SocketType.Stream,
                                        ProtocolType.Tcp);
                //2.연결
                //EndPoint serverEP = new IPEndPoint(IPAddress.Loopback, 10000);
                EndPoint serverEP = new IPEndPoint(IPAddress.Parse("192.168.81.71"), 13000);
                socket.Connect(serverEP);
                //3.Read, Write
                //write
                //byte[] buffer = Encoding.UTF8.GetBytes(DateTime.Now.ToString());
                byte[] buffer = Encoding.UTF8.GetBytes("잘해봅시다.");
                socket.Send(buffer);

                //read
                byte[] recvBytes = new byte[1024];
                int nRecv = socket.Receive(recvBytes);

                string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
                Console.WriteLine(txt);
                //4.종료
                socket.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
