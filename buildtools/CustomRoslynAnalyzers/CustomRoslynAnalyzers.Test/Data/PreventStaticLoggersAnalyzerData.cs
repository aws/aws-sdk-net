using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRoslynAnalyzers.Test
{
    public partial class PreventStaticLoggersAnalyzerTests
    {
        private const string BasicDataForImplementILogger = @"
    public class Logger : ILogger
    {
        public void Debug(Exception exception, string messageFormat, params object[] args)
        {
            return;
        }

        public void DebugFormat(string messageFormat, params object[] args)
        {
            return;
        }

        public void Error(Exception exception, string messageFormat, params object[] args)
        {
            return;
        }

        public void Flush()
        {
            return;
        }

        public void InfoFormat(string messageFormat, params object[] args)
        {
            return;
        }
    }";

        private const string BasicFieldDataWithoutLogger = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon.Runtime.Internal.Util;

namespace TestPreventStaticLoggersAnalyzer
{{
    class Program
    {{
        public static Logger B;  
        static void Main(string[] args)
        {{
        }}
    }}
    {0}
}}";
        private const string BasicPropertyDataWithoutLogger = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon.Runtime.Internal.Util;

namespace TestPreventStaticLoggersAnalyzer
{{
    class Program
    {{
        public static Logger A {{ set; get; }}
        static void Main(string[] args)
        {{
        }}
    }}
    {0}
}}";

        private const string FieldCodeFixDataWithoutLogger = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon.Runtime.Internal.Util;

namespace TestPreventStaticLoggersAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1002"")]
        public static Logger B;  
        static void Main(string[] args)
        {{
        }}
    }}
    {0}
}}";
        private const string PropertyCodeFixDataWithoutLogger = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon.Runtime.Internal.Util;

namespace TestPreventStaticLoggersAnalyzer
{{
    class Program
    {{
        [SuppressMessage(""AWSSDKRules"", ""CR1002"")]
        public static Logger A {{ set; get; }}
        static void Main(string[] args)
        {{
        }}
    }}
    {0}
}}";

        public static IEnumerable<object[]> AllTestData => CreateSeperateData();

        private static List<object[]> CreateSeperateData()
        {
            return new List<object[]>
            {
                // Data for the field test
                new object[] { BasicFieldDataWithoutLogger, "Program", "TestPreventStaticLoggersAnalyzer.Logger", "ILogger", 10, 9, FieldCodeFixDataWithoutLogger, BasicDataForImplementILogger},
                // Data for the property test
                new object[] { BasicPropertyDataWithoutLogger, "Program", "TestPreventStaticLoggersAnalyzer.Logger", "ILogger", 10, 9, PropertyCodeFixDataWithoutLogger, BasicDataForImplementILogger},
            };
        }
    }
}
