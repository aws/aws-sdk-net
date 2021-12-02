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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */

using Amazon.AmplifyUIBuilder;
using Amazon.AmplifyUIBuilder.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AmplifyUIBuilderPaginatorTests
    {
        private static Mock<AmazonAmplifyUIBuilderClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAmplifyUIBuilderClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AmplifyUIBuilder")]
        public void ListComponentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListComponentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListComponentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListComponents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListComponents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AmplifyUIBuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListComponentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListComponentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListComponents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListComponents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AmplifyUIBuilder")]
        public void ListThemesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThemesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThemesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThemesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThemes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThemes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AmplifyUIBuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThemesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThemesRequest>();

            var response = InstantiateClassGenerator.Execute<ListThemesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThemes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThemes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}