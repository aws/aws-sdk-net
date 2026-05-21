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

/*
 * Do not modify this file. This file is generated from the ep2-substring-2022-08-24.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Ep2substring.Endpoints;
using Amazon.Ep2substring.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class Ep2substringEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is long enough")]
        public void Substring_when_string_is_long_enough_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abcdefg";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"The value is: `abcd`", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is exactly the right length")]
        public void Substring_when_string_is_exactly_the_right_length_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abcd";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"The value is: `abcd`", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        public void Substring_when_string_is_too_short_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abc";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        public void Substring_when_string_is_too_short_1_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring on wide characters (ensure that unicode code points are properly counted)")]
        public void Substring_on_wide_characters_ensure_that_unicode_code_points_are_properly_counted_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "﷽";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("unicode characters always return `None`")]
        public void Unicode_characters_always_return_None_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abcdef🐱";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("non-ascii cause substring to always return `None`")]
        public void Nonascii_cause_substring_to_always_return_None_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abcdef";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("the full set of ascii is supported, including non-printable characters")]
        public void The_full_set_of_ascii_is_supported_including_nonprintable_characters_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abcdef";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"The value is: `abc`", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is long enough")]
        public void Substring_when_string_is_long_enough_1_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "2";
            parameters["Input"] = "abcdefg";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"The value is: `defg`", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is exactly the right length")]
        public void Substring_when_string_is_exactly_the_right_length_1_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "2";
            parameters["Input"] = "defg";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"The value is: `defg`", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        public void Substring_when_string_is_too_short_2_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "2";
            parameters["Input"] = "abc";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        public void Substring_when_string_is_too_short_3_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "2";
            parameters["Input"] = "";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring on wide characters (ensure that unicode code points are properly counted)")]
        public void Substring_on_wide_characters_ensure_that_unicode_code_points_are_properly_counted_1_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "2";
            parameters["Input"] = "﷽";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is longer")]
        public void Substring_when_string_is_longer_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "3";
            parameters["Input"] = "defg";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"The value is: `ef`", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is exact length")]
        public void Substring_when_string_is_exact_length_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "3";
            parameters["Input"] = "def";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"The value is: `ef`", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        public void Substring_when_string_is_too_short_4_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "3";
            parameters["Input"] = "ab";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        public void Substring_when_string_is_too_short_5_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "3";
            parameters["Input"] = "";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring on wide characters (ensure that unicode code points are properly counted)")]
        public void Substring_on_wide_characters_ensure_that_unicode_code_points_are_properly_counted_2_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "3";
            parameters["Input"] = "﷽";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No tests matched", exception.Message);
        }

    }
}