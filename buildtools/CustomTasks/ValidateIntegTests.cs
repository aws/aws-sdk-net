using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Newtonsoft.Json;

namespace CustomTasks
{
    public class ValidateIntegTests : BuildTaskBase
    {
        private const string SdkVersionsFile = @"..\generator\ServiceModels\_sdk-versions.json";
        private static readonly string TestClassAttributeTypeName = typeof(TestClassAttribute).FullName;
        private static readonly string TestMethodAttributeTypeName = typeof(TestMethodAttribute).FullName;
        private static readonly string TestCategoryAttributeTypeName = typeof(TestCategoryAttribute).FullName;

        private static readonly BindingFlags MethodBindingFlags =
            BindingFlags.FlattenHierarchy |
            BindingFlags.Instance |
            BindingFlags.Public |
            BindingFlags.NonPublic;
        private static readonly List<string> SupportedNonServiceCategories = new List<string>
        {
            "General"
        };

        [Required]
        public string TestAssembly { get; set; }

        public override bool Execute()
        {
            CheckWaitForDebugger();

            List<string> errors = CheckAssembly(TestAssembly, SdkVersionsFile);

            if (errors.Count > 0)
            {
                Log.LogError("Encountered errors: {0}", string.Join("\n", errors));
                return false;
            }
            else
                return true;
        }

        public static List<string> CheckAssembly(string testAssembly, string sdkVersionsFile)
        {
            var errors = new List<string>();

            var validCategories = new HashSet<string>(GetServiceNames(sdkVersionsFile), StringComparer.OrdinalIgnoreCase);
            foreach (var extraCategory in SupportedNonServiceCategories)
                validCategories.Add(extraCategory);

            var assembly = Assembly.LoadFrom(testAssembly);
            var testClassTypes = GetTypes(assembly)
                .Where(TestClassPredicate)
                .ToList();

            if (testClassTypes.Count == 0)
                errors.Add("Unable to find any types with TestClass attribute");

            foreach (var testClassType in testClassTypes)
            {
                var testMethods = testClassType
                    .GetMethods(MethodBindingFlags)
                    .Where(TestMethodPredicate)
                    .ToList();
                foreach (var testMethod in testMethods)
                {
                    var categoryAttributes = testMethod
                        .GetCustomAttributes()
                        .Where(TestCategoriesPredicate)
                        .ToList();

                    var methodContext = string.Format("Class: {0}, Method: {1}",
                        testClassType.FullName, testMethod.Name);
                    foreach (var categoryAttribute in categoryAttributes)
                    {
                        var categories = GetTestCategories(categoryAttribute);
                        if (categories.Count == 0)
                        {
                            errors.Add(methodContext + " - no categories configured");
                        }
                        foreach (var category in categories)
                        {
                            if (!validCategories.Contains(category))
                            {
                                errors.Add(methodContext + " - unsupported category " + category);
                            }
                        }
                    }
                }
            }

            return errors;
        }

        // Reflection code to test for various attribute types

        private static bool TestClassPredicate(Type type)
        {
            var attributes = type.GetCustomAttributes().ToList();
            return attributes.Any(TestAttribute(TestClassAttributeTypeName));
        }
        private static bool TestMethodPredicate(MethodInfo methodInfo)
        {
            var attributes = methodInfo.GetCustomAttributes().ToList();
            return attributes.Any(TestAttribute(TestMethodAttributeTypeName));
        }
        private static bool TestCategoriesPredicate(Attribute attribute)
        {
            return TestAttribute(TestCategoryAttributeTypeName)(attribute);
        }
        private static IList<string> GetTestCategories(Attribute attribute)
        {
            var type = attribute.GetType();
            var testCategoriesProperty = type.GetProperty("TestCategories");
            if (testCategoriesProperty == null)
                throw new Exception("Attribute " + attribute + " is missing TestCategories property");
            var categories = testCategoriesProperty.GetValue(attribute) as IList<string>;
            return categories;
        }
        private static Func<Attribute, bool> TestAttribute(string targetAttributeType)
        {
            return attribute =>
            {
                var attributeName = attribute.GetType().FullName;
                return string.Equals(attributeName, targetAttributeType, StringComparison.Ordinal);
            };
        }

        // Gets types from assembly, swallowing ReflectionTypeLoadException
        private static IEnumerable<Type> GetTypes(Assembly assembly)
        {
            IEnumerable<Type> types;
            try
            {
                types = assembly.GetTypes();
            }
            catch(ReflectionTypeLoadException e)
            {
                types = e.Types.Where(t => t != null).ToList();
            }
            return types;
        }

        // Retrieves list of service names from _sdk-versions.json
        private static IEnumerable<string> GetServiceNames(string sdkVersionsFile)
        {
            var json = File.ReadAllText(sdkVersionsFile);
            var sdkVersions = JsonConvert.DeserializeObject<SdkVersions>(json);
            foreach (var kvp in sdkVersions.ServiceVersions)
                yield return kvp.Key;
        }
        private class SdkVersions
        {
            public Dictionary<string, object> ServiceVersions { get; set; }
        }
    }
}
