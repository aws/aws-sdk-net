#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */

using Amazon.Lambda;
using Amazon.Lambda.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class LambdaPaginatorTests
    {
        private static Mock<AmazonLambdaClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonLambdaClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        public void ListAliasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAliasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListAliases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAliases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAliasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAliasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListAliases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAliases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        public void ListCodeSigningConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCodeSigningConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCodeSigningConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCodeSigningConfigsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListCodeSigningConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCodeSigningConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCodeSigningConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCodeSigningConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCodeSigningConfigsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListCodeSigningConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCodeSigningConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        public void ListEventSourceMappingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEventSourceMappingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEventSourceMappingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEventSourceMappingsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListEventSourceMappings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEventSourceMappings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEventSourceMappingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEventSourceMappingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEventSourceMappingsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListEventSourceMappings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEventSourceMappings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        public void ListFunctionEventInvokeConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFunctionEventInvokeConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFunctionEventInvokeConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFunctionEventInvokeConfigsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListFunctionEventInvokeConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFunctionEventInvokeConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFunctionEventInvokeConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFunctionEventInvokeConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFunctionEventInvokeConfigsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListFunctionEventInvokeConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFunctionEventInvokeConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        public void ListFunctionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFunctionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFunctionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFunctionsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListFunctions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFunctions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFunctionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFunctionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFunctionsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListFunctions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFunctions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        public void ListFunctionsByCodeSigningConfigTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFunctionsByCodeSigningConfigRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFunctionsByCodeSigningConfigResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFunctionsByCodeSigningConfigResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListFunctionsByCodeSigningConfig(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFunctionsByCodeSigningConfig(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFunctionsByCodeSigningConfigTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFunctionsByCodeSigningConfigRequest>();

            var response = InstantiateClassGenerator.Execute<ListFunctionsByCodeSigningConfigResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListFunctionsByCodeSigningConfig(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFunctionsByCodeSigningConfig(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        public void ListLayersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLayersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLayersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLayersResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListLayers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLayers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLayersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLayersRequest>();

            var response = InstantiateClassGenerator.Execute<ListLayersResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListLayers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLayers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        public void ListLayerVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLayerVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLayerVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLayerVersionsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListLayerVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLayerVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLayerVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLayerVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLayerVersionsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListLayerVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLayerVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        public void ListProvisionedConcurrencyConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProvisionedConcurrencyConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProvisionedConcurrencyConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProvisionedConcurrencyConfigsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListProvisionedConcurrencyConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProvisionedConcurrencyConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProvisionedConcurrencyConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProvisionedConcurrencyConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProvisionedConcurrencyConfigsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListProvisionedConcurrencyConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProvisionedConcurrencyConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        public void ListVersionsByFunctionTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVersionsByFunctionRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVersionsByFunctionResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVersionsByFunctionResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListVersionsByFunction(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVersionsByFunction(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Lambda")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVersionsByFunctionTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVersionsByFunctionRequest>();

            var response = InstantiateClassGenerator.Execute<ListVersionsByFunctionResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListVersionsByFunction(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVersionsByFunction(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif