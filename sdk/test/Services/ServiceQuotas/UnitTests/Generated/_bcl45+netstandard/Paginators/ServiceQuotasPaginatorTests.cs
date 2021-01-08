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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */

using Amazon.ServiceQuotas;
using Amazon.ServiceQuotas.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ServiceQuotasPaginatorTests
    {
        private static Mock<AmazonServiceQuotasClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonServiceQuotasClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        public void ListAWSDefaultServiceQuotasTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAWSDefaultServiceQuotasRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAWSDefaultServiceQuotasResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAWSDefaultServiceQuotasResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAWSDefaultServiceQuotas(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAWSDefaultServiceQuotas(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAWSDefaultServiceQuotasTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAWSDefaultServiceQuotasRequest>();

            var response = InstantiateClassGenerator.Execute<ListAWSDefaultServiceQuotasResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAWSDefaultServiceQuotas(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAWSDefaultServiceQuotas(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        public void ListRequestedServiceQuotaChangeHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRequestedServiceQuotaChangeHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRequestedServiceQuotaChangeHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRequestedServiceQuotaChangeHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRequestedServiceQuotaChangeHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRequestedServiceQuotaChangeHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRequestedServiceQuotaChangeHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRequestedServiceQuotaChangeHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<ListRequestedServiceQuotaChangeHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRequestedServiceQuotaChangeHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRequestedServiceQuotaChangeHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        public void ListRequestedServiceQuotaChangeHistoryByQuotaTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRequestedServiceQuotaChangeHistoryByQuotaRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRequestedServiceQuotaChangeHistoryByQuotaResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRequestedServiceQuotaChangeHistoryByQuotaResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRequestedServiceQuotaChangeHistoryByQuota(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRequestedServiceQuotaChangeHistoryByQuota(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRequestedServiceQuotaChangeHistoryByQuotaTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRequestedServiceQuotaChangeHistoryByQuotaRequest>();

            var response = InstantiateClassGenerator.Execute<ListRequestedServiceQuotaChangeHistoryByQuotaResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRequestedServiceQuotaChangeHistoryByQuota(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRequestedServiceQuotaChangeHistoryByQuota(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        public void ListServiceQuotaIncreaseRequestsInTemplateTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceQuotaIncreaseRequestsInTemplateRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServiceQuotaIncreaseRequestsInTemplateResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServiceQuotaIncreaseRequestsInTemplateResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServiceQuotaIncreaseRequestsInTemplate(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServiceQuotaIncreaseRequestsInTemplate(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServiceQuotaIncreaseRequestsInTemplateTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceQuotaIncreaseRequestsInTemplateRequest>();

            var response = InstantiateClassGenerator.Execute<ListServiceQuotaIncreaseRequestsInTemplateResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServiceQuotaIncreaseRequestsInTemplate(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServiceQuotaIncreaseRequestsInTemplate(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        public void ListServiceQuotasTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceQuotasRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServiceQuotasResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServiceQuotasResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServiceQuotas(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServiceQuotas(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServiceQuotasTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceQuotasRequest>();

            var response = InstantiateClassGenerator.Execute<ListServiceQuotasResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServiceQuotas(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServiceQuotas(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        public void ListServicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceQuotas")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif