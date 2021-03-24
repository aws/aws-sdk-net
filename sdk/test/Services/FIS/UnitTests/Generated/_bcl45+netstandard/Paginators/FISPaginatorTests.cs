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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */

using Amazon.FIS;
using Amazon.FIS.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class FISPaginatorTests
    {
        private static Mock<AmazonFISClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonFISClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FIS")]
        public void ListActionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListActionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListActionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListActionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListActions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListActions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FIS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListActionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListActionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListActionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListActions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListActions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FIS")]
        public void ListExperimentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListExperimentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListExperimentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListExperimentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListExperiments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListExperiments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FIS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListExperimentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListExperimentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListExperimentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListExperiments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListExperiments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FIS")]
        public void ListExperimentTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListExperimentTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListExperimentTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListExperimentTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListExperimentTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListExperimentTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FIS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListExperimentTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListExperimentTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListExperimentTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListExperimentTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListExperimentTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}