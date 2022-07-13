using System;

namespace Object_overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLIst<string> studentList = new MyLIst<string>();

            studentList.Add("Seadet");

            studentList.Clear("Emil");

            studentList.Find("Seid");

            studentList.GetAll();
        }
    }
}
