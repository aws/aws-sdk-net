/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.UnitTests;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ParametersTest
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ParametersFacadeTests()
        {
            var testRequest = new Amazon.DynamoDBv2.Model.ListTablesRequest();
            var testServiceName = "DDB";

            var irequest = new DefaultRequest(testRequest, testServiceName);

            irequest.Parameters.Add("param1", "paramValue1");
            irequest.ParameterCollection.Add("param2", "paramValue2");
            irequest.ParameterCollection.Add("param3", new List<string> { "listValue1", "listValue2" });
            irequest.ParameterCollection.Add("param4", new List<string> { "listValue4", "listValue3" });

            var collection = irequest.ParameterCollection;
            var dictionary = irequest.Parameters as ParametersDictionaryFacade;
            Assert.IsNotNull(dictionary);

            // Add (string, string)
            dictionary.Add("newParam1", "newParamValue1");
            TestParamValue(collection, "newParam1", expectString: true, expectedValue: "newParamValue1");

            // Count
            Assert.AreEqual(5, collection.Count);
            Assert.AreEqual(collection.Count, dictionary.Count);

            // ContainsKey
            Assert.IsTrue(dictionary.ContainsKey("newParam1"));
            Assert.IsFalse(dictionary.ContainsKey("newParam2"));

            // Remove (key)
            Assert.IsTrue(dictionary.Remove("newParam1"));
            Assert.IsFalse(dictionary.Remove("newParam2"));

            // index accessor
            Assert.AreEqual("paramValue2", dictionary["param2"]);
            Utils.AssertExceptionExpected(() =>
            {
                var tempValue = dictionary["param99"];
            });
            Assert.AreEqual("[\"listValue1\",\"listValue2\"]", dictionary["param3"]);
            Assert.AreEqual("[\"listValue4\",\"listValue3\"]", dictionary["param4"]);

            // Keys
            CollectionAssert.AreEqual(new List<string> { "param1", "param2", "param3", "param4" }, dictionary.Keys.ToList());

            // TryGetValue
            string stringValue;
            Assert.IsTrue(dictionary.TryGetValue("param1", out stringValue));
            Assert.AreEqual("paramValue1", stringValue);
            Assert.IsFalse(dictionary.TryGetValue("param99", out stringValue));

            // Remove (KeyValuePair)
            Assert.IsFalse(dictionary.Remove(new KeyValuePair<string, string>("param4", "[\"listValue4\", \"listValue3\"]")));
            Assert.IsTrue(dictionary.Remove(new KeyValuePair<string, string>("param4", "[\"listValue4\",\"listValue3\"]")));

            // Values
            CollectionAssert.AreEqual(new List<string> { "paramValue1", "paramValue2", "[\"listValue1\",\"listValue2\"]" }, dictionary.Values.ToList());

            // Add (KeyValuePair)
            dictionary.Add(new KeyValuePair<string,string>("newParam3", "newParamValue3"));
            TestParamValue(collection, "newParam3", expectString: true, expectedValue: "newParamValue3");

            // Contains
            Assert.IsTrue(dictionary.Contains(new KeyValuePair<string,string>("param1", "paramValue1")));
            Assert.IsTrue(dictionary.Contains(new KeyValuePair<string,string>("param3", "[\"listValue1\",\"listValue2\"]")));

            // IsReadOnly
            Assert.IsFalse(dictionary.IsReadOnly);

            var currentKeyValuePairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string,string>("newParam3", "newParamValue3"),
                new KeyValuePair<string,string>("param1", "paramValue1"),
                new KeyValuePair<string,string>("param2", "paramValue2"),
                new KeyValuePair<string,string>("param3", "[\"listValue1\",\"listValue2\"]"),
            };

            // GetEnumerator
            var genericEnumerator = dictionary.GetEnumerator();
            var parameterList = ToIEnumerable<KeyValuePair<string,string>>(genericEnumerator).ToList();
            CollectionAssert.AreEqual(currentKeyValuePairs, parameterList);

            // System.Collections.IEnumerable.GetEnumerator
            var enumerator = (dictionary as IEnumerable).GetEnumerator();
            parameterList = ToIEnumerable<KeyValuePair<string,string>>(enumerator).ToList();
            CollectionAssert.AreEqual(currentKeyValuePairs, parameterList);

            // CopyTo
            var tooSmallArray = new KeyValuePair<string,string>[1];
            Utils.AssertExceptionExpected(() => dictionary.CopyTo(tooSmallArray, 0));

            var largeArray = new KeyValuePair<string, string>[10];
            dictionary.CopyTo(largeArray, 0);
            CollectionAssert.AreEqual(currentKeyValuePairs, largeArray.Take(4).ToList());

            largeArray = new KeyValuePair<string, string>[10];
            dictionary.CopyTo(largeArray, 3);
            CollectionAssert.AreEqual(currentKeyValuePairs, largeArray.Skip(3).Take(4).ToList());

            // Clear
            dictionary.Clear();
            Assert.AreEqual(0, dictionary.Count);
            Assert.AreEqual(0, collection.Count);
        }

        private void TestParamValue(ParameterCollection collection, string key, bool expectString, object expectedValue)
        {
            ParameterValue pv;
            Assert.IsTrue(collection.TryGetValue(key, out pv));
            Assert.IsNotNull(pv);
            TestParamValue(pv, expectString, expectedValue);
        }
        private static void TestParamValue(ParameterValue pv, bool expectString, object expectedValue)
        {
            var spv = pv as StringParameterValue;
            var slpv = pv as StringListParameterValue;

            if (expectString)
                Assert.IsNotNull(spv);
            else
                Assert.IsNotNull(slpv);

            if (spv != null)
            {
                var stringValue = expectedValue as string;
                Assert.IsNotNull(stringValue);
                Assert.IsTrue(string.Equals(stringValue, spv.Value, System.StringComparison.Ordinal));
            }
            else if (slpv != null)
            {
                var stringListValue = expectedValue as List<string>;
                Assert.IsNotNull(stringListValue);
                CollectionAssert.AreEqual(stringListValue, slpv.Value);
            }
            else
            {
                Assert.Fail("Unrecognized value " + pv.GetType().FullName);
            }
        }
        private static IEnumerable<T> ToIEnumerable<T>(IEnumerator enumerator)
        {
            while(enumerator.MoveNext())
            {
                yield return (T)enumerator.Current;
            }
        }
    }
}
