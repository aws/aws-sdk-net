using Amazon.Util.Internal;
using NUnit.Common;
using NUnit.Framework.Api;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace AWSSDK.Tests.Framework
{
    public class UnityTestAssemblyBuilder : ITestAssemblyBuilder
    {
        ISuiteBuilder _unitySuiteBuilder;

        public UnityTestAssemblyBuilder()
        {
            _unitySuiteBuilder = new DefaultSuiteBuilder();
        }

        #region ITestAssemblyBuilder

        public ITest Build(string assemblyName, IDictionary options)
        {
            TestSuite testAssembly = null;

            try
            {
                var assembly = AssemblyHelper.Load(assemblyName);
                testAssembly = Build(assembly, assemblyName, options);
            }
            catch (Exception ex)
            {
                testAssembly = new TestAssembly(assemblyName);
                testAssembly.RunState = RunState.NotRunnable;
                testAssembly.Properties.Set(PropertyNames.SkipReason, ex.Message);
            }

            return testAssembly;
        }

        public ITest Build(Assembly assembly, IDictionary options)
        {
            //we maynot get the correct assembly path on ios so we will spoof it.
            string assemblyPath = string.Format(@"{0}{1}{2}.dll", AmazonHookedPlatformInfo.Instance.PersistentDataPath, Path.DirectorySeparatorChar, assembly.CodeBase);
            return Build(assembly, assemblyPath, options);
        }

        private TestSuite Build(Assembly assembly, string assemblyPath, IDictionary options)
        {
            TestSuite testAssembly = null;
            try
            {
                IList fixtureNames = options[PackageSettings.LOAD] as IList;
                var fixtures = GetFixtures(assembly, fixtureNames);
                testAssembly = BuildTestAssembly(assembly, assemblyPath, fixtures);
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
                testAssembly = new TestAssembly(assemblyPath);
                testAssembly.RunState = RunState.NotRunnable;
                testAssembly.Properties.Set(PropertyNames.SkipReason, ex.Message);
            }

            return testAssembly;
        }

        #endregion

        #region Helper Methods

        private IList<Test> GetFixtures(Assembly assembly, IList names)
        {
            var fixtures = new List<Test>();
            var testTypes = GetCandidateFixtureTypes(assembly, names);
            int testcases = 0;
            foreach (Type testType in testTypes)
            {
                var typeInfo = new TypeWrapper(testType);

                try
                {
                    if (_unitySuiteBuilder.CanBuildFrom(typeInfo))
                    {
                        Test fixture = _unitySuiteBuilder.BuildFrom(typeInfo);
                        fixtures.Add(fixture);
                        testcases += fixture.TestCaseCount;
                    }
                }
                catch (Exception ex)
                {
                    Debug.LogException(ex);
                }
            }


            return fixtures;
        }

        private IList<Type> GetCandidateFixtureTypes(Assembly assembly, IList names)
        {
            var types = assembly.GetTypes();

            if (names == null || names.Count == 0)
                return types;

            var result = new List<Type>();

            foreach (string name in names)
            {
                Type fixtureType = assembly.GetType(name);
                if (fixtureType != null)
                    result.Add(fixtureType);
                else
                {
                    string prefix = name + ".";

                    foreach (Type type in types)
                        if (type.FullName.StartsWith(prefix))
                            result.Add(type);
                }
            }

            return result;
        }

        private TestSuite BuildTestAssembly(Assembly assembly, string assemblyName, IList<Test> fixtures)
        {
            TestSuite testAssembly = new TestAssembly(assembly, assemblyName);
            if (fixtures.Count == 0)
            {
                testAssembly.RunState = RunState.NotRunnable;
                testAssembly.Properties.Set(PropertyNames.SkipReason, "Has no TestFixtures");
            }
            else
            {
                NamespaceTreeBuilder treeBuilder =
                    new NamespaceTreeBuilder(testAssembly);
                treeBuilder.Add(fixtures);
                testAssembly = treeBuilder.RootSuite;
            }

            testAssembly.ApplyAttributesToTest(assembly);

            testAssembly.Properties.Set(PropertyNames.ProcessID, System.Diagnostics.Process.GetCurrentProcess().Id);
            testAssembly.Properties.Set(PropertyNames.AppDomain, AppDomain.CurrentDomain.FriendlyName);

            // TODO: Make this an option? Add Option to sort assemblies as well?
            testAssembly.Sort();
            return testAssembly;
        }

        #endregion
    }
}
