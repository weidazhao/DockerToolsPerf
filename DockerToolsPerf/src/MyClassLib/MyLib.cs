using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MyClassLib
{
    public static class MyLib
    {
        public static string FrameworkDescription => RuntimeInformation.FrameworkDescription;

        public static string OSDescription => RuntimeInformation.OSDescription;
    }
}
