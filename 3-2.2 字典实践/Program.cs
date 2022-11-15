using System;
using System.Collections.Generic;

namespace _3_2._2_字典实践
{
    class Program
    {
        class Student
        {
            public string name;
            public int score;

            public Student(string n ,int s)
            {
                name = n;
                score = s;
            }

            public override string ToString()
            {
                return $"学生 {name}: {score}";
            }
        }

        static void PrintDict(Dictionary<string, int> dict)
        {
            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
        }
        static void PrintDict(Dictionary<char, int> dict)
        {
            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
        }
        static void Stat()
        {
            string s = "adsfgdsfgsdgdsfagfdsgsdf,,gsdgfdgyil";

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0;i<s.Length;i++)
            {
                //char c = s[i];
                //if(!dict.ContainsKey(c))
                //{ dict[c] = 0; }
                //dict[c] += 1;
                char temp = s[i];
                if(!dict.ContainsKey(temp))
                { dict[temp] = 1; }
                else
                { dict[temp] += 1; }
            }

            PrintDict(dict);

        }
        static void Main(string[] args)
        {
            //Stat();

            Student s1 = new Student("小明", 70);
            Student s2 = new Student("小红", 80);
            Student s3 = new Student("小军", 80);
            //Student s4 = new Student("小明", 75);


            List<Student> list = new List<Student> { s1,s2,s3 };

            Dictionary<string, Student> dict = new Dictionary<string, Student>();

            foreach (Student s in list)
            {
                dict[s.name] = s;
                //dict.Add(s.name, s);
            }

            Console.WriteLine(dict["小明"]);

            Console.ReadKey();

        }
    }
}
