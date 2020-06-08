using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRoslynAnalyzers.Test
{
    public partial class PreventRegionEndpointUseAnalyzerTests
    {
        private const string BasicFieldData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        public RegionEndpoint test4 = RegionEndpoint.USEast1;
        static void Main(string[] args)
        {
        }
    }
}";
        private const string BasicPropertyData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        public RegionEndpoint Test6
        {
            get { return RegionEndpoint.USEast1; }
            set { }
        }
    }
}";
        private const string BasicInsideMethodData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var test2 = RegionEndpoint.USEast1;
        }
    }
}";
        private const string BasicPassInParameterToMethodData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            test(RegionEndpoint.USEast1);
        }
        static void test(RegionEndpoint usEast1)
        {
        }
    }
}";
        private const string BasicLambdaData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        public Func<RegionEndpoint> test = () => RegionEndpoint.USEast1;
        static void Main(string[] args)
        {
        }
    }
}";
        private const string BasicDelegateData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    delegate RegionEndpoint RegionEndpointFunc();
    class Program
    {
        RegionEndpointFunc regionEndpointFunc = delegate () { return RegionEndpoint.USEast1; };
        static void Main(string[] args)
        {
        }
    }
}";
        private const string BasicWithoutUSEast1Data = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        public static readonly RegionEndpoint test4 = RegionEndpoint.USWest1;
        static void Main(string[] args)
        {
        }
    }
}";

        private const string FieldCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1004"")]
        public RegionEndpoint test4 = RegionEndpoint.USEast1;
        static void Main(string[] args)
        {
        }
    }
}";
        private const string PropertyCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1004"")]
        public RegionEndpoint Test6
        {
            get { return RegionEndpoint.USEast1; }
            set { }
        }
    }
}";
        private const string InsideMethodCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1004"")]
        static void Main(string[] args)
        {
            var test2 = RegionEndpoint.USEast1;
        }
    }
}";
        private const string PassInParameterToMethodCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1004"")]
        static void Main(string[] args)
        {
            test(RegionEndpoint.USEast1);
        }
        static void test(RegionEndpoint usEast1)
        {
        }
    }
}";
        private const string LambdaCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1004"")]
        public Func<RegionEndpoint> test = () => RegionEndpoint.USEast1;
        static void Main(string[] args)
        {
        }
    }
}";
        private const string DelegateCodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    delegate RegionEndpoint RegionEndpointFunc();
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1004"")]
        RegionEndpointFunc regionEndpointFunc = delegate () { return RegionEndpoint.USEast1; };
        static void Main(string[] args)
        {
        }
    }
}";
        private const string WithoutUSEast1CodeFixData = @"
using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace TestPreventRegionEndPointUseAnalyzer
{
    class Program
    {
        [SuppressMessage(""AWSSDKRules"", ""CR1004"")]
        public static readonly RegionEndpoint test4 = RegionEndpoint.USWest1;
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
                new object[] {BasicFieldData, 10, 39, FieldCodeFixData},
                // Data for the property test
                new object[] {BasicPropertyData, 12, 26, PropertyCodeFixData},
                // Data for the inside method test
                new object[] {BasicInsideMethodData, 12, 25, InsideMethodCodeFixData},
                // Data for the pass in parameter to method 
                new object[] { BasicPassInParameterToMethodData, 12, 18, PassInParameterToMethodCodeFixData},
                // Data for the Lambda Expression
                new object[] { BasicLambdaData, 10, 50, LambdaCodeFixData},
                // Data for the Delegate 
                new object[] {BasicDelegateData, 11, 70, DelegateCodeFixData},
                // Data for the use of USWest1 not USEast1
                new object[] {BasicWithoutUSEast1Data, 10, 55, WithoutUSEast1CodeFixData}
            };
        }
    }
}
