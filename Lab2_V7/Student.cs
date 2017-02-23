using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_V7
{
    class Student
    {
        public string name;
        public int v { get; set; }
        public int o { get; set; }
        public int p1 { get; }
        public double p2 { get; }
        public Student(string _name, int _v, int _o)
        {
            name = _name;
            v = _v;
            o = _o;
            p1 = v - o;
            p2 = (double)p1 * (100 / (double)v);
        }
    }
}
