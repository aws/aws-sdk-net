#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */

using Amazon.Snowball;
using Amazon.Snowball.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SnowballPaginatorTests
    {
        private static Mock<AmazonSnowballClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSnowballClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Snowball")]
        public void DescribeAddressesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAddressesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAddressesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAddressesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAddresses(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAddresses(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Snowball")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAddressesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAddressesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAddressesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAddresses(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAddresses(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Snowball")]
        public void ListJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Snowball")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif