using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRoslynAnalyzers.Test
{
    public partial class PreventHashAlgorithmCreateAnalyzerTests
    {
        private const string BasicCorrectData = @"
using System;
using System.Security.Cryptography;

namespace TestPreventTimeNowUseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = 1;
        }
    }
}";
        private const string BasicMethodData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        static void Main(string[] args)
        {{
            var test = {0};
        }}
    }}
}}";
        private const string BasicFieldData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        public HashAlgorithm test = {0};
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string BasicPropertyData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        public HashAlgorithm test4
        {{
            get
            {{
                return {0};
            }}
        }}
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string BasicPassInParameterData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventHashAlgorithmCreateAnalyzer
{{
    class Program
    {{
        static void Main(string[] args)
        {{
            TestMethod({0});
        }}

        public static void TestMethod(HashAlgorithm h)
        {{
        }}
    }}
}}";
        private const string BasicLambdaData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        Func<int, int, HashAlgorithm> testForEquality = (x, y) => {0};
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string BasicDelegateData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    public delegate HashAlgorithm HashAlgorithmFunc();
    class Program
    {{
        HashAlgorithmFunc dateFunc = delegate () {{ return {0}; }};
        static void Main(string[] args)
        {{
        }}
    }}
}}";

        private const string MethodCodeFixData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1001"")]
        static void Main(string[] args)
        {{
            var test = {0};
        }}
    }}
}}";
        private const string FieldCodeFixData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1001"")]
        public HashAlgorithm test = {0};
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string PassInParameterCodeFixData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventHashAlgorithmCreateAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1001"")]
        static void Main(string[] args)
        {{
            TestMethod({0});
        }}

        public static void TestMethod(HashAlgorithm h)
        {{
        }}
    }}
}}";
        private const string PropertyCodeFixData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1001"")]
        public HashAlgorithm test4
        {{
            get
            {{
                return {0};
            }}
        }}
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string LambdaCodeFixData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1001"")]
        Func<int, int, HashAlgorithm> testForEquality = (x, y) => {0};
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string DelegateCodeFixData = @"
using System;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    public delegate HashAlgorithm HashAlgorithmFunc();
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1001"")]
        HashAlgorithmFunc dateFunc = delegate () {{ return {0}; }};
        static void Main(string[] args)
        {{
        }}
    }}
}}";

        public static IEnumerable<object[]> TestCorrectData => new List<string[]> { new string[] { BasicCorrectData } };
        private static List<string[]> MethodData => CreateSeperateData(BasicMethodData, MethodCodeFixData);
        private static List<string[]> FieldData => CreateSeperateData(BasicFieldData, FieldCodeFixData);
        private static List<string[]> PassInParameterData => CreateSeperateData(BasicPassInParameterData, PassInParameterCodeFixData);
        private static List<string[]> PropertyData => CreateSeperateData(BasicPropertyData, PropertyCodeFixData);
        private static List<string[]> LambdaData => CreateSeperateData(BasicLambdaData, LambdaCodeFixData);
        private static List<string[]> DelegateData => CreateSeperateData(BasicDelegateData, DelegateCodeFixData);

        public static IEnumerable<object[]> TestMethodData => MethodData;
        public static IEnumerable<object[]> TestFieldData => FieldData;
        public static IEnumerable<object[]> TestPropertyData => PropertyData;
        public static IEnumerable<object[]> TestPassInParameterData => PassInParameterData;
        public static IEnumerable<object[]> TestLambdaData => LambdaData;
        public static IEnumerable<object[]> TestDelegateData => DelegateData;

        private static List<string[]> CreateSeperateData(string basicData, string codeFixData)
        {
            return new List<string[]>
            {
                new string[] { basicData, "HashAlgorithm.Create()", codeFixData},
                new string[] { basicData, "HashAlgorithm.Create(\"test\")", codeFixData},
            };
        }
    }
}
