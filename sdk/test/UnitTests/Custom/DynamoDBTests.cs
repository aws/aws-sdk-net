using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.DataModel;

namespace AWSSDK_DotNet35.UnitTests
{
    [TestClass]
    public class DynamoDBEntryTests
    {
        [TestMethod]
        public void TestDynamoDBEqualsOverrides()
        {
            var ddbeType = typeof(DynamoDBEntry);
            var ddbeSubTypes = GetSubTypes(ddbeType);
            foreach(var subType in ddbeSubTypes)
            {
                var equalsMethod = subType.GetMethod("Equals", new Type[] { typeof(object) });
                Assert.IsTrue(equalsMethod.DeclaringType == subType, "Testing that type {0} implements Equals", subType.FullName);
            }

            Console.WriteLine(ddbeSubTypes.Count);
        }

        [TestMethod]
        public void TestContextConfig()
        {
            // Test in response to GitHub issue
            // https://github.com/aws/aws-sdk-net/issues/209
            var config = new DynamoDBContextConfig()
            {
                TableNamePrefix = "Test"
            };

            Assert.AreEqual("Test", config.TableNamePrefix);
        }

        private static List<Type> GetSubTypes(Type baseType)
        {
            var assembly = baseType.Assembly;
            var allTypes = assembly.GetTypes();

            var subTypes = new List<Type>();
            foreach (var type in allTypes)
            {
                if (baseType.IsAssignableFrom(type) &&
                    baseType != type)
                    subTypes.Add(type);
            }
            return subTypes;
        }
    }
}
