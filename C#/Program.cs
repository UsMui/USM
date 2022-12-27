using ConsoleApp1.session1;
using ConsoleApp1.session2;
using ConsoleApp1.session3;

public class Program
{
    static void Main3(string[] args)
    {

    }
   
    static void Main(string[] args)
    {
        try
        {
            int x = 0;
            int y = 0;
            float z = x / y;
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
        finally { 
        }
        Human h = new Human();
        h.Run();
        h.Age = 19;
        h.Email = "abc@gmail.com";
        Console.WriteLine(h.Age);
        Student s = new Student();
        s[0] = "099999999";
        s[1] = "088888888";
        List<string> ls = new List<string>();
        ls.Add("hello");
        ls.Add("world");
        ls.Add("moring");
        for(int i = 0; i < ls.Count; i++)
        {
            Console.WriteLine(ls[i]);
        }
        foreach(string l in ls)
        {
            Console.WriteLine(l);
        }
        PhanSo a = new PhanSo(1,2);
        a.InPhanSo();
        a.NgichDao();
        a.InPhanSo();
        


        
    }
}
