using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRoslynAnalyzers.Test
{
    public partial class PreventMD5AnalyzerTests
    {
        private const string BasicFieldData = @"
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        public MD5 test;
        static void Main(string[] args)
        {
        }
    }
}";
        private const string BasicPropertyData = @"
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        public MD5 test2 { get; set; }
        static void Main(string[] args)
        {
        }
    }
}";
        private const string BasicInsideMethodData = @"
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = MD5.Create();
        }
    }
}";
        private const string BasicDeclareMethodParameterData = @"
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void test3(MD5 m)
        {
        }
    }
}";
        private const string BasicPassInParameterToMethodData = @"
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            test3(MD5.Create());
        }
        public static void test3(object m)
        {
        }
    }
}";
        private const string BasicLamdaExpressionData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        Func<object> testFunc = () => MD5.Create();
        static void Main(string[] args)
        {
        }
    }
}";
        private const string BasicDelegateData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    public delegate MD5 MD5Func();
    class Program
    {
        MD5Func md5Func = delegate () { return MD5.Create(); };
        static void Main(string[] args)
        {
        }
    }
}";

        private const string FieldCodeFixData = @"
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1000"")]
        public MD5 test;
        static void Main(string[] args)
        {
        }
    }
}";
        private const string PropertyCodeFixData = @"
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1000"")]
        public MD5 test2 { get; set; }
        static void Main(string[] args)
        {
        }
    }
}";
        private const string InsideMethodCodeFixData = @"
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1000"")]
        static void Main(string[] args)
        {
            var test = MD5.Create();
        }
    }
}";
        private const string DeclareMethodParameterCodeFixData = @"
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SuppressMessage(""AWSSDKRules"", ""CR1000"")]
        public void test3(MD5 m)
        {
        }
    }
}";
        private const string PassInParameterToMethodCodeFixData = @"
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1000"")]
        static void Main(string[] args)
        {
            test3(MD5.Create());
        }
        public static void test3(object m)
        {
        }
    }
}";
        private const string LambdaExpressionCodeFixData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1000"")]
        Func<object> testFunc = () => MD5.Create();
        static void Main(string[] args)
        {
        }
    }
}";
        private const string DelegateCodeFixData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventMD5UseAnalyzer
{
    public delegate MD5 MD5Func();
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1000"")]
        MD5Func md5Func = delegate () { return MD5.Create(); };
        static void Main(string[] args)
        {
        }
    }
}";

        public static IEnumerable<object[]> TestInsideMethodData => CreateSeperateData();

        private static List<object[]> CreateSeperateData()
        {
            return new List<object[]>
            {
                // Data for the field test
                new object[] {BasicFieldData, "System.Security.Cryptography.MD5", "Program", 9, 9, FieldCodeFixData},
                // Data for the property test
                new object[] {BasicPropertyData, "System.Security.Cryptography.MD5", "Program", 9, 16, PropertyCodeFixData},
                // Data for the inside method test
                new object[] {BasicInsideMethodData, "System.Security.Cryptography.MD5", "Main", 11, 24, InsideMethodCodeFixData},
                // Data for the declare method parameter
                new object[] { BasicDeclareMethodParameterData, "System.Security.Cryptography.MD5", "test3", 12, 27, DeclareMethodParameterCodeFixData},
                // Data for the pass in parameter to method 
                new object[] { BasicPassInParameterToMethodData, "System.Security.Cryptography.MD5", "Main", 11, 19, PassInParameterToMethodCodeFixData},
                // Data for the Lambda Expression 
                new object[] { BasicLamdaExpressionData, "System.Security.Cryptography.MD5", "Program", 10, 39, LambdaExpressionCodeFixData},
                // Data for the Delegate 
                new object[] { BasicDelegateData, "System.Security.Cryptography.MD5", "Program", 11, 48, DelegateCodeFixData}
            };
        }
    }
}
