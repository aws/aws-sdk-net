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

using System.Collections.Generic;
using System.Linq;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RegionFinderTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("us-east-1", "https://s3.us-east-1.amazonaws.com")]
        [DataRow("us-east-2", "https://s3.us-east-2.amazonaws.com/")]
        [DataRow("us-west-1", "https://s3.us-west-1.amazonaws.com/")]
        [DataRow("us-west-2", "https://s3.us-west-2.amazonaws.com/(")]
        [DataRow("ap-east-1", "https://s3.ap-east-1.amazonaws.com/")]
        [DataRow("ap-south-1", "https://s3.ap-south-1.amazonaws.com/")]
        [DataRow("ap-northeast-3", "https://s3.ap-northeast-3.amazonaws.com/")]
        [DataRow("ap-northeast-2", "https://s3.ap-northeast-2.amazonaws.com/")]
        [DataRow("ap-southeast-1", "https://s3.ap-southeast-1.amazonaws.com/")]
        [DataRow("ap-southeast-2", "https://s3.ap-southeast-2.amazonaws.com/")]
        [DataRow("ap-northeast-1", "https://s3.ap-northeast-1.amazonaws.com/")]
        [DataRow("ca-central-1", "https://s3.ca-central-1.amazonaws.com/")]
        [DataRow("eu-central-1", "https://s3.eu-central-1.amazonaws.com/")]
        [DataRow("eu-west-1", "https://s3.eu-west-1.amazonaws.com/")]
        [DataRow("eu-west-2", "https://s3.eu-west-2.amazonaws.com/")]
        [DataRow("eu-west-3", "https://s3.eu-west-3.amazonaws.com/")]
        [DataRow("eu-north-1", "https://s3.eu-north-1.amazonaws.com/")]
        [DataRow("me-south-1", "https://s3.me-south-1.amazonaws.com/")]
        [DataRow("sa-east-1", "https://s3.sa-east-1.amazonaws.com/")]
        [DataRow("us-iso-east-1", "https://s3.us-iso-east-1.amazonaws.com/")]
        [DataRow("us-gov-west-1", "https://s3.us-gov-west-1.amazonaws.com")]
        [DataRow("us-gov-east-1", "https://s3.us-gov-east-1.amazonaws.com")]
        [DataRow("us-gov-east-1", "https://s3.us-gov-east-1.amazonaws.com")]
        [DataRow("us-isob-east-1", "https://s3.us-isob-east-1.amazonaws.com/")]
        [DataRow("us-west-2", ("https://vpce-example.elasticloadbalancing.us-west-2.vpce.amazonaws.com"))]
        public void FindRegion_Endpoint_ReturnsRegion(string expectedRegion, string url)
        {
            Assert.AreEqual(expectedRegion, RegionFinder.Instance.FindRegion(url).SystemName);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("us-east-1", "https://s3.us-east-1.amazonaws.com/us-west-2")]
        [DataRow("us-east-1", "https://s3.us-west-2.us-east-1.amazonaws.com/")]
        public void FindRegion_EndpointContainingMultipleRegions_ReturnsFirstRegionFromRight(string expectedRegion, string url)
        {
            Assert.AreEqual(expectedRegion, RegionFinder.Instance.FindRegion(url).SystemName);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("us-east-1", "https://s3.US-EAST-1.amazonaws.com/")]
        [DataRow("us-east-1", "https://s3.US-east-1.amazonaws.com/")]
        [DataRow("us-east-1", "https://s3.us-east-1.amazonaws.com/")]
        public void FindRegion_MixedCaseEndpoint_ReturnsLowerCaseRegion(string expectedRegion, string url)
        {
            Assert.AreEqual(expectedRegion, RegionFinder.Instance.FindRegion(url).SystemName);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("us-gov-west-1", "https://iam.us-gov.c2s.ic.gov/")]
        public void FindRegion_EndpointContainingUSGov_ReturnsDefaultGovRegion(string expectedRegion, string url)
        {
            Assert.AreEqual(expectedRegion, RegionFinder.Instance.FindRegion(url).SystemName);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("us-east-1", "https://route53.amazonaws.com/")]
        [DataRow("us-east-1", "https://s3.amazonaws.com/")]
        [DataRow("us-east-1", "https://service.chime.aws.amazon.com/")]
        [DataRow("us-east-1", "https://s3-external-1.amazonaws.com/")]
        public void FindRegion_EndpointNotContainingRegion_ReturnsDefaultRegion(string expectedRegion, string url)
        {
            Assert.AreEqual(expectedRegion, RegionFinder.Instance.FindRegion(url).SystemName);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("https://bucket-name.s3-accelerate.amazonaws.com/")]
        public void FindRegion_EndpointNotContainingRegion_ReturnsNullRegion(string url)
        {
            Assert.IsNull(RegionFinder.Instance.FindRegion(url));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void FindFuzzyRegion_CombinationOfAllPossibleRegions()
        {
            var areas = new List<string>() { "us", "eu", "ap", "sa", "ca", "me", "af", "cn" };
            var directions = new List<string>() { "east", "west", "north", "south", "northeast", "southeast", "northwest", "southwest", "central" };
            var numbers = Enumerable.Range(1, 5).ToList();
            var usOptionals = new List<string> { "gov", "iso", "isob" };

            foreach (var area in areas)
            {
                foreach (var direction in directions)
                {
                    foreach (var number in numbers)
                    {
                        var expectedRegion = $"{area}-{direction}-{number}";
                        var endpoint = $"https://s3.{expectedRegion}.amazonaws.com";
                        var actualRegion = RegionFinder.FindFuzzyRegion(endpoint).SystemName;
                        Assert.AreEqual(expectedRegion, actualRegion);
                    }
                }
            }

            foreach (var optional in usOptionals)
            {
                foreach (var direction in directions)
                {
                    foreach (var number in numbers)
                    {
                        var expectedRegion = $"us-{optional}-{direction}-{number}";
                        var endpoint = $"https://s3.{expectedRegion}.amazonaws.com";
                        var actualRegion = RegionFinder.FindFuzzyRegion(endpoint).SystemName;
                        Assert.AreEqual(expectedRegion, actualRegion);
                    }
                }
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Unit")]
        [DataRow("s3-external-1.amazonaws.com", "https://s3-external-1.amazonaws.com/foo/bar")]
        [DataRow("s3-external-1.amazonaws.com", "s3-external-1.amazonaws.com/foo/bar")]
        [DataRow(null, null)]
        public void GetAuthority(string expectedAuthority, string url)
        {
            Assert.AreEqual(expectedAuthority, RegionFinder.GetAuthority(url));
        }
    }
}