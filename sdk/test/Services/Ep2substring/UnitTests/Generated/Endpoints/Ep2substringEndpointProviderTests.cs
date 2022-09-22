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
using Amazon.Runtime;
using Amazon.Ep2substring.Endpoints;
using Amazon.Ep2substring.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class Ep2substringEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is long enough")]
        [ExpectedException(typeof(AmazonClientException), "The value is: `abcd`")]
        public void Substring_when_string_is_long_enough_d585d6e7e6404c0595d57019e71d07ed_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abcdefg";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is exactly the right length")]
        [ExpectedException(typeof(AmazonClientException), "The value is: `abcd`")]
        public void Substring_when_string_is_exactly_the_right_length_a504223189e74f66a46c49e734a0d8c5_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abcd";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Substring_when_string_is_too_short_6e67090b4ee44c9e8dec384daae270f4_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abc";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Substring_when_string_is_too_short_179c50a92bdf4834b480728651b1f2af_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring on wide characters (ensure that unicode code points are properly counted)")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Substring_on_wide_characters_ensure_that_unicode_code_points_are_properly_counted_f86f6a30c0b04ebfb8242128933aaad3_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "﷽";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("unicode characters always return `None`")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Unicode_characters_always_return_None_f72d7756273c4cdf8063a91d030687b9_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abcdef🐱";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("non-ascii cause substring to always return `None`")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Nonascii_cause_substring_to_always_return_None_9d3ab5b1416c42b1aa85dd6804c37c68_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abcdef";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("the full set of ascii is supported, including non-printable characters")]
        [ExpectedException(typeof(AmazonClientException), "The value is: `abc`")]
        public void The_full_set_of_ascii_is_supported_including_nonprintable_characters_6d79eec27a4f49258d403240afb32b7b_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "1";
            parameters["Input"] = "abcdef";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is long enough")]
        [ExpectedException(typeof(AmazonClientException), "The value is: `defg`")]
        public void Substring_when_string_is_long_enough_8fb3a13b71bf418e93d898aea3d82fae_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "2";
            parameters["Input"] = "abcdefg";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is exactly the right length")]
        [ExpectedException(typeof(AmazonClientException), "The value is: `defg`")]
        public void Substring_when_string_is_exactly_the_right_length_a3339f4cd2e24f3ca23d409f8bfc5804_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "2";
            parameters["Input"] = "defg";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Substring_when_string_is_too_short_6042b36ef1f544f1a68b2cf9e939f0e9_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "2";
            parameters["Input"] = "abc";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Substring_when_string_is_too_short_177736eb745f4df881746451d554d699_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "2";
            parameters["Input"] = "";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring on wide characters (ensure that unicode code points are properly counted)")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Substring_on_wide_characters_ensure_that_unicode_code_points_are_properly_counted_a95c309bf7284bc0995d18dfdb131fae_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "2";
            parameters["Input"] = "﷽";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is longer")]
        [ExpectedException(typeof(AmazonClientException), "The value is: `ef`")]
        public void Substring_when_string_is_longer_d0b07e63351f4c8c9e0cfe096fa47a8c_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "3";
            parameters["Input"] = "defg";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is exact length")]
        [ExpectedException(typeof(AmazonClientException), "The value is: `ef`")]
        public void Substring_when_string_is_exact_length_34d0708bb8094548a27031e042d05716_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "3";
            parameters["Input"] = "def";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Substring_when_string_is_too_short_b4ec6f76d0314e2cac0edb5ce3aaac15_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "3";
            parameters["Input"] = "ab";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring when string is too short")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Substring_when_string_is_too_short_760b803748934215ab46049de5999a84_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "3";
            parameters["Input"] = "";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2substring")]
        [Description("substring on wide characters (ensure that unicode code points are properly counted)")]
        [ExpectedException(typeof(AmazonClientException), "No tests matched")]
        public void Substring_on_wide_characters_ensure_that_unicode_code_points_are_properly_counted_dd394e5f48e5455db15bc9833fe74f57_Test()
        {
            var parameters = new Ep2substringEndpointParameters();
            parameters["TestCaseId"] = "3";
            parameters["Input"] = "﷽";
            var endpoint = new AmazonEp2substringEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}