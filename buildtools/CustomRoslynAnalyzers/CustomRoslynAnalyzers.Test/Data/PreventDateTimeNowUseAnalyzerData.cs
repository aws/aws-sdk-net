using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRoslynAnalyzers.Test
{
    public partial class PreventDateTimeNowUseAnalyzerTests
    {
        private const string BasicCorrectData = @"
using System;
using System.Diagnostics.CodeAnalysis;

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
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        public DateTime test = {0};
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string BasicPassInParameterData = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        static void Main(string[] args)
        {{
            TestMethod({0});
        }}

        public static void TestMethod(DateTime d)
        {{
        }}
    }}
}}";
        private const string BasicPropertyData = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        public DateTime test3
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
        private const string BasicLambdaData = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        Func<DateTime, int, DateTime> testForEquality = (x, y) => {0};
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string BasicDelegateData = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    public delegate DateTime DateFunc();
    class Program
    {{
        DateFunc dateFunc = delegate () {{ return {0}; }};
        static void Main(string[] args)
        {{
        }}
    }}
}}";

        private const string MethodCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1003"")]
        static void Main(string[] args)
        {{
            var test = {0};
        }}
    }}
}}";
        private const string FieldCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1003"")]
        public DateTime test = {0};
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string PassInParameterCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1003"")]
        static void Main(string[] args)
        {{
            TestMethod({0});
        }}

        public static void TestMethod(DateTime d)
        {{
        }}
    }}
}}";
        private const string PropertyCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1003"")]
        public DateTime test3
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
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1003"")]
        Func<DateTime, int, DateTime> testForEquality = (x, y) => {0};
        static void Main(string[] args)
        {{
        }}
    }}
}}";
        private const string DelegateCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestPreventTimeNowUseAnalyzer
{{
    public delegate DateTime DateFunc();
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1003"")]
        DateFunc dateFunc = delegate () {{ return {0}; }};
        static void Main(string[] args)
        {{
        }}
    }}
}}";

        private static List<string[]> MethodData => CreateSeperateData(BasicMethodData, MethodCodeFixData);
        private static List<string[]> FieldData => CreateSeperateData(BasicFieldData, FieldCodeFixData);
        private static List<string[]> PassInParameterData => CreateSeperateData(BasicPassInParameterData, PassInParameterCodeFixData);
        private static List<string[]> PropertyData => CreateSeperateData(BasicPropertyData, PropertyCodeFixData);
        private static List<string[]> LambdaData => CreateSeperateData(BasicLambdaData, LambdaCodeFixData);
        private static List<string[]> DelegateData => CreateSeperateData(BasicDelegateData, DelegateCodeFixData);

        public static IEnumerable<object[]> TestCorrectData => new List<string[]> { new string[] { BasicCorrectData } };
        public static IEnumerable<object[]> TestMethodData => MethodData;
        public static IEnumerable<object[]> TestFieldData => FieldData;
        public static IEnumerable<object[]> TestPassInParameterData => PassInParameterData;
        public static IEnumerable<object[]> TestPropertyData => PropertyData;
        public static IEnumerable<object[]> TestLambdaData => LambdaData;
        public static IEnumerable<object[]> TestDelegateData => DelegateData;

        private static List<string[]> CreateSeperateData(string basicData, string codeFixData)
        {
            return new List<string[]>
            {
                new string[] { basicData, "DateTime.Now", codeFixData},
                new string[] { basicData, "DateTime.Today", codeFixData},
                new string[] { basicData, "DateTime.UtcNow", codeFixData}
            };
        }
    }
}
