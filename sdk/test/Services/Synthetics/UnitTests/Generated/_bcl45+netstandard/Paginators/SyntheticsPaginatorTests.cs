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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */

using Amazon.Synthetics;
using Amazon.Synthetics.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SyntheticsPaginatorTests
    {
        private static Mock<AmazonSyntheticsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSyntheticsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Synthetics")]
        public void DescribeCanariesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCanariesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCanariesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCanariesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeCanaries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCanaries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Synthetics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCanariesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCanariesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCanariesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeCanaries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCanaries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Synthetics")]
        public void DescribeCanariesLastRunTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCanariesLastRunRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCanariesLastRunResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCanariesLastRunResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeCanariesLastRun(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCanariesLastRun(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Synthetics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCanariesLastRunTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCanariesLastRunRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCanariesLastRunResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeCanariesLastRun(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCanariesLastRun(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Synthetics")]
        public void DescribeRuntimeVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRuntimeVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRuntimeVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRuntimeVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRuntimeVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRuntimeVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Synthetics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRuntimeVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRuntimeVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRuntimeVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRuntimeVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRuntimeVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Synthetics")]
        public void GetCanaryRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCanaryRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCanaryRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCanaryRunsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCanaryRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCanaryRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Synthetics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCanaryRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCanaryRunsRequest>();

            var response = InstantiateClassGenerator.Execute<GetCanaryRunsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCanaryRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCanaryRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif