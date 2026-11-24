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
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EndpointsStandardLibraryTests
    {
        /// <summary>
        /// Complex entity with property Prop1 and reference entity Test2
        /// </summary>
        public class Test1 : PropertyBag
        {
            public string Prop1
            {
                get { return (string)this["Prop1"]; }
                set { this["Prop1"] = value; }
            }

            public Test2 Test2
            {
                get { return (Test2)this["Test2"]; }
                set { this["Test2"] = value; }
            }
        }

        /// <summary>
        /// Complex entity with property Prop2 and a list List
        /// </summary>
        public class Test2 : PropertyBag
        {
            public string Prop2
            {
                get { return (string)this["Prop2"]; }
                set { this["Prop2"] = value; }
            }

            public List<string> List
            {
                get { return (List<string>)this["List"]; }
                set { this["List"] = value; }
            }
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttrTests()
        {
            var test = new Test1
            {
                Prop1 = "Prop1_value",
                Test2 = new Test2()
                {
                    Prop2 = "Prop2_value",
                    List = new List<string>() { "element1", "element2" }
                }
            };

            Assert.AreEqual("Prop1_value", Fn.GetAttr(test, "Prop1")); // extract simple property from "the root" test object
            Assert.AreEqual("Prop2_value", Fn.GetAttr(test, "Test2.Prop2")); // extract simple property from reference object
            Assert.AreEqual("element2", Fn.GetAttr(test, "Test2.List[1]")); // extract array element from reference object
            Assert.AreEqual("element1", Fn.GetAttr(test.Test2.List, "[0]")); // extract array element from "the root" object
        }

        /// <summary>
        /// Global references.
        /// </summary>
        private static Dictionary<string, object> refs = new Dictionary<string, object>
        {
            { "Region", "us-east-1" },
            { "UseFIPS", true },
            { "Arn", new Arn { region = "us-east-1", partition = "aws", service = "s3" } },
            { "Non standard key", "Yes, we support that too!" }
        };

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void InterpolateTestsHappyPath()
        {
            Assert.AreEqual("The region is us-east-1", Fn.Interpolate("The region is {Region}", refs));
            Assert.AreEqual("UseFIPS = True", Fn.Interpolate("UseFIPS = {UseFIPS}", refs));
            Assert.AreEqual("The service is s3 with partition aws", Fn.Interpolate("The service is {Arn#service} with partition {Arn#partition}", refs));
            Assert.AreEqual("={us-east-1}=", Fn.Interpolate("={{{Region}}}=", refs));
            Assert.AreEqual("={{us-east-1}}=", Fn.Interpolate("={{{{{Region}}}}}=", refs));
            Assert.AreEqual("{}", Fn.Interpolate("{{}}", refs));
            Assert.AreEqual("={}=", Fn.Interpolate("={{}}=", refs));
            Assert.AreEqual("Non standard keys? Yes, we support that too!", Fn.Interpolate("Non standard keys? {Non standard key}", refs));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void InterpolateTestTemplateMissingClosingBracket()
        {
            Assert.ThrowsExactly<ArgumentException>(() => Fn.Interpolate("{Region", refs));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void InterpolateTestTemplateMissingKey()
        {
            Assert.ThrowsExactly<KeyNotFoundException>(() => Fn.Interpolate("{BadKey}", refs));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void InterpolateTestTemplateLoneClosingBracket()
        {
            Assert.ThrowsExactly<ArgumentException>(() => Fn.Interpolate("{Region}}", refs));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void Interpolate_MultipleHash_KeepsOnlyFirstPathSegment()
        {
            var localRefs = new Dictionary<string, object>
            {
                { "obj", new Test2 { Prop2 = "value" } }
            };
            Assert.AreEqual("value", Fn.Interpolate("{obj#Prop2#extra}", localRefs));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_NestedIndexer_UsesLastBracket()
        {
            var bag = new PropertyBag();
            bag["List[0]"] = new List<string> { "a", "b" };
            Assert.AreEqual("b", Fn.GetAttr(bag, "List[0][1]"));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_IndexerOnNonBag_ThrowsInvalidCast()
        {
            Assert.ThrowsExactly<InvalidCastException>(() => Fn.GetAttr("not-a-bag", "Foo[0]"));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_BadIndexOnNonBag_ThrowsFormat()
        {
            Assert.ThrowsExactly<FormatException>(() => Fn.GetAttr("not-a-bag", "Foo[x]"));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_PathNullOrEmpty_ThrowsArgumentNullException()
        {
            Assert.ThrowsExactly<ArgumentNullException>(() => Fn.GetAttr("not-a-bag", null));
            Assert.ThrowsExactly<ArgumentNullException>(() => Fn.GetAttr("not-a-bag", ""));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_PropertyValueIsNotEnumerable_ThrowsArgumentException()
        {
            var bag = new PropertyBag();
            bag["NotEnumerable"] = 42; // int is not enumerable
            Assert.ThrowsExactly<ArgumentException>(() => Fn.GetAttr(bag, "NotEnumerable[0]"));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_PropertyValueIsNotListWhenInRange_ReturnsValue()
        {
            var bag = new PropertyBag();
            bag["NotList"] = new Queue<string>(new[] { "a", "b" });
            Assert.AreEqual("a", Fn.GetAttr(bag, "NotList[0]"));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_PropertyValueIsNotListWhenNotInRange_ReturnsNull()
        {
            var bag = new PropertyBag();
            bag["NotList"] = new HashSet<string> { "a", "b" }; // not IList, but is IEnumerable
            Assert.AreEqual(null, Fn.GetAttr(bag, "NotList[2]"));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_PropertyValueIsListWhenInRange_ReturnsValue()
        {
            var bag = new PropertyBag();
            bag["List"] = new List<string> { "a", "b" };
            Assert.AreEqual("a", Fn.GetAttr(bag, "List[0]"));
        }


        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_PropertyValueIsListWhenNotInRange_ReturnsNull()
        {
            var bag = new PropertyBag();
            bag["List"] = new List<string> { "a", "b" };
            Assert.AreEqual(null, Fn.GetAttr(bag, "List[2]"));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_NestedPropertyValueIsNotBag_ThrowsArgumentException()
        {
            var bag = new PropertyBag();
            bag["property"] = 42; // int is not a PropertyBag
            Assert.ThrowsExactly<ArgumentException>(() => Fn.GetAttr(bag, "property.subproperty"));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void GetAttr_NegativeIndex_ReturnsValueFromEnd()
        {
            var bag = new PropertyBag();
            bag["List"] = new List<string> { "a", "b", "c" };
            Assert.AreEqual("c", Fn.GetAttr(bag, "List[-1]"));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void BooleanEquals_ComparesNullableBools_ReturnsBool()
        {
            Assert.IsTrue(Fn.BooleanEquals(true, true));
            Assert.IsFalse(Fn.BooleanEquals(true, false));
            Assert.IsFalse(Fn.BooleanEquals(null, true));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void StringEquals_ComparesOrdinally_ReturnsBool()
        {
            Assert.IsTrue(Fn.StringEquals("aws", "aws"));
            Assert.IsFalse(Fn.StringEquals("aws", "AWS"));
            Assert.IsFalse(Fn.StringEquals(null, "aws"));
            Assert.IsTrue(Fn.StringEquals(null, null));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        [DataRow(2, "|x-s3--azid--suffix")]
        [DataRow(0, "|x-s3|azid|suffix")]
        public void Split_SplitsOnTheSeparatorUpToTheLimit(int limit, string expected)
        {
            Assert.AreEqual(expected, string.Join("|", Fn.Split("--x-s3--azid--suffix", "--", limit)));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        [DataRow(1, "usw2-az1")]
        [DataRow(-1, "x-s3")]
        [DataRow(4, null)]
        public void ListItemOrNull_ReturnsTheItemOrNull(int index, string expected)
        {
            var list = new List<string> { "mybucket", "usw2-az1", "x-s3" };
            Assert.AreEqual(expected, Fn.ListItemOrNull(list, index));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void NullInput_ReturnsNullOrFalse()
        {
            Assert.IsNull(Fn.GetAttr(null, "anything"));
            Assert.IsNull(Fn.Partition(null));
            Assert.IsNull(Fn.Substring(null, 0, 1, false));
            Assert.IsNull(Fn.UriEncode(null));
            Assert.IsNull(Fn.Split(null, "--", 2));
            Assert.IsNull(Fn.ListItemOrNull((IList<string>)null, 0));
            Assert.IsFalse(Fn.IsValidHostLabel(null, false));
            Assert.IsFalse(Fn.IsVirtualHostableS3Bucket(null, false));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void Partition_TypedPropertiesAndIndexerStayInSync()
        {
            var partition = new Partition();
            Assert.IsFalse(partition.supportsFIPS);
            Assert.IsFalse(partition.supportsDualStack);
            Assert.AreEqual(false, partition["supportsFIPS"]);
            Assert.IsNull(partition["notARealProperty"]);

            partition.supportsFIPS = true;
            partition.dnsSuffix = "amazonaws.com";
            Assert.AreEqual(true, partition["supportsFIPS"]);
            Assert.AreEqual("amazonaws.com", partition["dnsSuffix"]);

            partition["dualStackDnsSuffix"] = "api.aws";
            partition["supportsDualStack"] = true;
            Assert.AreEqual("api.aws", partition.dualStackDnsSuffix);
            Assert.IsTrue(partition.supportsDualStack);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void URL_TypedPropertiesAndIndexerStayInSync()
        {
            var url = new URL();
            Assert.IsFalse(url.isIp);
            Assert.AreEqual(false, url["isIp"]);

            url.isIp = true;
            url.scheme = "https";
            Assert.AreEqual(true, url["isIp"]);
            Assert.AreEqual("https", url["scheme"]);

            url["authority"] = "example.com";
            Assert.AreEqual("example.com", url.authority);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void SubstringEquals_MatchesSubstringThenStringEquals()
        {
            Assert.IsTrue(Fn.SubstringEquals("mybucket--x-s3", 0, 6, true, "--x-s3"));
            Assert.IsFalse(Fn.SubstringEquals("mybucket--x-s3", 0, 6, true, "--xa-s3"));
            Assert.IsTrue(Fn.SubstringEquals("abc", 0, 4, false, ""));
            Assert.IsFalse(Fn.SubstringEquals("bücket--x-s3", 0, 6, true, "--x-s3"));

            var inputs = new[] { null, "", "a", "abc", "mybucket--x-s3", "mybucket--xa-s3", "bücket--x-s3" };
            var ranges = new[] { (0, 1), (0, 3), (1, 3), (2, 2), (3, 2), (0, 6), (0, 7), (8, 12) };
            foreach (var input in inputs)
            {
                foreach (var (start, stop) in ranges)
                {
                    foreach (var reverse in new[] { false, true })
                    {
                        var substring = Fn.Substring(input, start, stop, reverse);
                        foreach (var expected in new[] { substring, "", "--x-s3", "x", null })
                        {
                            Assert.AreEqual(
                                Fn.StringEquals(substring ?? "", expected),
                                Fn.SubstringEquals(input, start, stop, reverse, expected),
                                $"input={input}, start={start}, stop={stop}, reverse={reverse}, expected={expected}");
                        }
                    }
                }
            }
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        public void SplitItemOrNull_MatchesSplitThenListItemOrNull()
        {
            Assert.AreEqual("usw2-az1", Fn.SplitItemOrNull("mybucket--usw2-az1--x-s3", "--", 0, -2));
            Assert.IsNull(Fn.SplitItemOrNull("mybucket--usw2-az1--x-s3", "--", 0, 5));
            Assert.AreEqual("usw2-az1--x-s3", Fn.SplitItemOrNull("mybucket--usw2-az1--x-s3", "--", 2, 1));

            var inputs = new[] { null, "", "-", "--", "---", "a", "a--b", "a--b--c", "--a--", "a-b-c", "x--x--x--x" };
            foreach (var input in inputs)
            {
                foreach (var separator in new[] { "--", "-", "x", "" })
                {
                    foreach (var limit in new[] { 0, 1, 2 })
                    {
                        for (var index = -5; index <= 5; index++)
                        {
                            Assert.AreEqual(
                                Fn.ListItemOrNull(Fn.Split(input, separator, limit), index),
                                Fn.SplitItemOrNull(input, separator, limit, index),
                                $"input={input}, separator={separator}, limit={limit}, index={index}");
                        }
                    }
                }
            }
        }
    }
}