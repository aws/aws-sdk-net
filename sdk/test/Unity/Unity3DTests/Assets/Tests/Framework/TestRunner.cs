using Amazon;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using ThirdParty.Json.LitJson;
using NUnit.Framework.Api;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using System.IO;

namespace AWSSDK.Tests.Framework
{
    public class TestRunner
    {
        public static AWSCredentials Credentials { get; private set; }

        public static RegionEndpoint RegionEndpoint { get; private set; }

        public static string TestAccountId { get; private set; }

        private static bool Loaded = false;
        private TextWriter LogWriter { get; set; }

        public AWSConfigs.HttpClientOption HttpClient { get; set; }

        public TestRunner()
        {
            if (!Loaded)
            {
                var resource = Resources.Load(@"settings") as TextAsset;
                var settings = JsonMapper.ToObject(resource.text);

                TestAccountId = settings["AccountId"] == null ? null : settings["AccountId"].ToString();
                Credentials = new BasicAWSCredentials(settings["AccessKeyId"].ToString(), settings["SecretAccessKey"].ToString());
                RegionEndpoint = RegionEndpoint.GetBySystemName(settings["RegionEndpoint"].ToString());
                Loaded = true;
                LogWriter = new StringWriter();
            }
        }

        public void RunTests()
        {
            RunTests(TestFilter.Empty);
        }

        public void RunTestsWithName(HashSet<string> testCases)
        {
            RunTests(new TestCaseFilter(testCases));
        }

        public void RunTests(HashSet<string> fixtureNames, HashSet<string> testCases)
        {
            RunTests(new FixtureAndCaseFilter(fixtureNames, testCases));
        }

        public void RunTestsWithCategory(string category)
        {
            RunTests(new CategoryFilter(category));
        }

        public void RunTestsWithCategory(string category, HashSet<string> testNames)
        {
            RunTests(new CategoryAndNameFilter(category, testNames));
        }

        public void RunTestsWithCategoryAndFixtureName(string category, HashSet<string> fixtureName)
        {
            RunTests(new CategoryAndFixtureFilter(category, fixtureName));
        }


        private void RunTests(ITestFilter testFilter)
        {
            MissingAPILambdaFunctions.Initialize();
            ITestAssemblyRunner runner = null;
            if (Utils.IsIL2CPP)
                runner = new NUnitTestAssemblyRunner(new UnityTestAssemblyBuilder());
            else
                runner = new NUnitTestAssemblyRunner(new DefaultTestAssemblyBuilder());
            var currentAssembly = this.GetType().Assembly;
            var options = new Dictionary<string, string>();
            var tests = runner.Load(currentAssembly, options);
            var testListener = new TestListener();
            var result = runner.Run(testListener, testFilter);
            TestDriver.Instance.OnTestFinished(this.HttpClient, testListener.FailedTestsCases);
        }

        #region testfilters

        internal class CategoryAndFixtureFilter : ITestFilter
        {
            private string CategoryName;
            private HashSet<string> FixtureNames;
            private bool InvertMatch = false;

            private const string CategoryKey = "Category";

            public CategoryAndFixtureFilter(string categoryName, HashSet<string> fixtureNames)
            {
                this.CategoryName = categoryName;
                this.FixtureNames = fixtureNames;
            }



            bool ITestFilter.IsExplicitMatch(ITest test)
            {
                return false;
            }

            bool ITestFilter.Pass(ITest test)
            {
                if (FixtureNames.Count == 0)
                {
                    // match
                    return !InvertMatch;
                }
                if (test.IsSuite)
                {
                    // continue to deeper matching level
                    return true;
                }
                if (FixtureNames.Contains(test.TypeInfo.Name))
                {
                    var categories = (test.Properties.ContainsKey(CategoryKey)) ?
                    test.Properties[CategoryKey] : new List<string>();

                    var stringCategories = categories.Cast<string>().ToList();

                    return stringCategories.Contains<string>(CategoryName);
                }
                else
                {
                    // no match
                    return InvertMatch;
                }
            }

            public TNode ToXml(bool b)
            {
                return null;
            }

            public TNode AddToXml(TNode n, bool b)
            {
                return null;
            }
        }



        internal class CategoryAndNameFilter : ITestFilter
        {
            private string CategoryName;
            private HashSet<string> TestNames;
            private const string CategoryKey = "Category";

            public CategoryAndNameFilter(string categoryName, HashSet<string> testNames)
            {
                this.CategoryName = categoryName;
                this.TestNames = testNames;
            }

            bool ITestFilter.IsExplicitMatch(ITest test)
            {
                return false;
            }

            bool ITestFilter.Pass(ITest test)
            {
                if (test.Method == null)
                    return true;

                if (string.IsNullOrEmpty(CategoryName))
                    return true;

                var testName = test.Name;
                var categories = (test.Properties.ContainsKey(CategoryKey)) ?
                    test.Properties[CategoryKey] : new List<string>();

                var stringCategories = categories.Cast<string>().ToList();

                if (!stringCategories.Contains(CategoryName))
                {
                    return false;
                }

                return this.TestNames.Contains(testName);

            }

            public TNode ToXml(bool b)
            {
                return null;
            }

            public TNode AddToXml(TNode n, bool b)
            {
                return null;
            }
        }


        internal class CategoryFilter : ITestFilter
        {
            private string CategoryName;
            private const string CategoryKey = "Category";

            public CategoryFilter(string categoryName)
            {
                this.CategoryName = categoryName;
            }

            bool ITestFilter.IsExplicitMatch(ITest test)
            {
                return false;
            }

            bool ITestFilter.Pass(ITest test)
            {
                if (test.Method == null)
                    return true;

                if (string.IsNullOrEmpty(CategoryName))
                    return true;

                var testName = test.Name;
                var categories = (test.Properties.ContainsKey(CategoryKey)) ?
                    test.Properties[CategoryKey] : new List<string>();

                var stringCategories = categories.Cast<string>().ToList();

                return stringCategories.Contains(CategoryName);
            }

            public TNode ToXml(bool b)
            {
                return null;
            }

            public TNode AddToXml(TNode n, bool b)
            {
                return null;
            }
        }

        internal class TestCaseFilter : ITestFilter
        {
            private HashSet<string> TestCaseNames;

            public TestCaseFilter(HashSet<string> testCaseNames)
            {
                TestCaseNames = testCaseNames;
            }

            public TestCaseFilter(string testCaseName)
            {
                TestCaseNames = new HashSet<string> { testCaseName };
            }

            public TNode AddToXml(TNode parentNode, bool recursive)
            {
                return null;
            }

            public bool IsExplicitMatch(ITest test)
            {
                return false;
            }

            public bool Pass(ITest test)
            {
                if (test.Method == null)
                    return true;

                var testName = test.Name;
                return TestCaseNames.Contains(testName);
            }

            public TNode ToXml(bool recursive)
            {
                return null;
            }
        }

        internal class FixtureAndCaseFilter : ITestFilter
        {
            private HashSet<String> FixtureNames;
            private HashSet<String> TestCaseNames;
            public bool InvertMatch = false;

            public FixtureAndCaseFilter(HashSet<string> fixtureNames, HashSet<string> testCaseNames)
            {
                FixtureNames = fixtureNames;
                TestCaseNames = testCaseNames;
            }
            public FixtureAndCaseFilter(string fixtureName, HashSet<string> testCaseNames)
            {
                FixtureNames = new HashSet<string> { fixtureName };
                TestCaseNames = testCaseNames;
            }

            public FixtureAndCaseFilter(HashSet<string> fixtureNames)
            {
                FixtureNames = fixtureNames;
                TestCaseNames = new HashSet<string>();
            }

            public FixtureAndCaseFilter(string fixtureName, string testCaseName)
            {
                FixtureNames = new HashSet<string> { fixtureName };
                TestCaseNames = new HashSet<string> { testCaseName };
            }

            public FixtureAndCaseFilter(string fixtureName)
            {
                FixtureNames = new HashSet<string> { fixtureName };
                TestCaseNames = new HashSet<string>();
            }

            bool ITestFilter.IsExplicitMatch(ITest test)
            {
                return false;
            }

            bool ITestFilter.Pass(ITest test)
            {
                if (FixtureNames.Count == 0)
                {
                    // match
                    return !InvertMatch;
                }
                if (test.IsSuite)
                {
                    // continue to deeper matching level
                    return true;
                }
                if (FixtureNames.Contains(test.TypeInfo.Name))
                {
                    if (TestCaseNames.Count == 0)
                    {
                        // match
                        return !InvertMatch;
                    }
                    else
                    {
                        // match is test name is in set of matching names
                        return InvertMatch != TestCaseNames.Contains(test.Name);
                    }
                }
                else
                {
                    // no match
                    return InvertMatch;
                }
            }
            public TNode ToXml(bool b)
            {
                return null;
            }

            public TNode AddToXml(TNode n, bool b)
            {
                return null;
            }
        }
        #endregion

        #region ITestListener

        private class TestListener : ITestListener
        {
            public TestListener()
            {
                failedTestCases = new HashSet<string>();
            }

            private HashSet<string> failedTestCases;

            public void TestFinished(ITestResult result)
            {
                var testAssembly = result.Test as TestAssembly;
                if (testAssembly != null)
                {
                    Debug.Log(string.Format("=== Executed {0} tests in assembly {1} ===",
                        testAssembly.TestCaseCount,
                        testAssembly.Assembly.FullName));

                    Debug.Log(string.Format("\nPassed : {0}\tFailed : {1}",
                        result.PassCount, result.FailCount));
                }

                var testFixture = result.Test as TestFixture;
                if (testFixture != null)
                {
                    if (result.FailCount > 0)
                    {
                        Debug.Log(string.Format("Test Fixture {0} ({1}) has {2} failures.",
                            testFixture.Name, testFixture.FullName, result.FailCount));

                        if (result.HasChildren)
                        {
                            foreach (var childResult in result.Children)
                            {
                                if (childResult.ResultState.Site != FailureSite.Test)
                                    TestFinished(childResult);
                            }
                        }

                        Debug.Log(string.Format("\tMessage : {0}", result.Message));
                        Debug.Log(string.Format("\tStack trace : {0}", result.StackTrace));

                    }
                    Debug.Log(string.Format("  --- Executed tests in class {0}   ---\n", testFixture.FullName));
                }

                var testMethod = result.Test as TestMethod;
                if (testMethod != null)
                {
                    if (result.FailCount > 0)
                    {
                        Debug.Log(string.Format("FAIL {0} ({1})", testMethod.MethodName, testMethod.FullName));
                        Debug.Log(string.Format("\tMessage : {0}", result.Message));
                        Debug.Log(string.Format("\tStack trace : {0}", result.StackTrace));
                    }

                    if (result.InconclusiveCount > 0)
                    {
                        Debug.Log(string.Format("INCONCLUSIVE {0}", testMethod.MethodName));
                    }

                    if (result.PassCount > 0)
                    {
                        Debug.Log(string.Format("PASS {0}", testMethod.MethodName));
                    }

                    var testSucceeded =
                        result.FailCount == 0 &&
                        result.InconclusiveCount == 0 &&
                        result.SkipCount == 0;

                    TestCompleted(testMethod.Name, testSucceeded);
                }
            }

            public void TestStarted(ITest test)
            {
                var testAssembly = test as TestAssembly;
                if (testAssembly != null)
                {
                    Debug.Log(string.Format("=== Executing tests in assembly {0} ===\n",
                        testAssembly.Assembly.FullName));
                }

                var testFixture = test as TestFixture;
                if (testFixture != null)
                {
                    Debug.Log(string.Format("  --- Executing tests in class {0} ---",
                        testFixture.FullName));
                }

                var testMethod = test as TestMethod;
                if (testMethod != null)
                {
                    Debug.Log(string.Format("\tTest {0}.{1} started", testMethod.ClassName, testMethod.MethodName));
                }
            }

            protected virtual void TestCompleted(string testMethodName, bool succeeded)
            {
                var res = string.Format(@"Test '{0}'  {1}", testMethodName, succeeded ? @"PASSED" : @"FAILED");
                if (!succeeded)
                    failedTestCases.Add(testMethodName);

                TestDriver.Results.Enqueue(res);
            }

            internal HashSet<string> FailedTestsCases
            {
                get
                {
                    return failedTestCases;
                }
            }

        }
        #endregion
    }
}
