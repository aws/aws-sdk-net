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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */

using Amazon.Glacier;
using Amazon.Glacier.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class GlacierPaginatorTests
    {
        private static Mock<AmazonGlacierClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonGlacierClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glacier")]
        public void ListJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glacier")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glacier")]
        public void ListPartsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPartsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPartsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPartsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListParts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListParts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glacier")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPartsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPartsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPartsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListParts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListParts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glacier")]
        public void ListVaultsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVaultsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVaultsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVaultsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListVaults(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVaults(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glacier")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVaultsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVaultsRequest>();

            var response = InstantiateClassGenerator.Execute<ListVaultsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListVaults(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVaults(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif