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
        [ExpectedException(typeof(ArgumentException), "template is missing closing }")]
        public void InterpolateTestTemplateMissingClosingBracket()
        {
            Fn.Interpolate("{Region", refs);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void InterpolateTestTemplateMissingKey()
        {
            Fn.Interpolate("{BadKey}", refs);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [TestCategory("StandardLibrary")]
        [ExpectedException(typeof(ArgumentException), "template has non-matching closing bracket, use }} to output }")]
        public void InterpolateTestTemplateLoneClosingBracket()
        {
            Fn.Interpolate("{Region}}", refs);
        }
    }
}