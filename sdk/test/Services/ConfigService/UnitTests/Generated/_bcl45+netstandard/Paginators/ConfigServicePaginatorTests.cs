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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */

using Amazon.ConfigService;
using Amazon.ConfigService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ConfigServicePaginatorTests
    {
        private static Mock<AmazonConfigServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonConfigServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeAggregateComplianceByConfigRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAggregateComplianceByConfigRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAggregateComplianceByConfigRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAggregateComplianceByConfigRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAggregateComplianceByConfigRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAggregateComplianceByConfigRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAggregateComplianceByConfigRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAggregateComplianceByConfigRulesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAggregateComplianceByConfigRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAggregateComplianceByConfigRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAggregateComplianceByConfigRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeAggregateComplianceByConformancePacksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAggregateComplianceByConformancePacksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAggregateComplianceByConformancePacksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAggregateComplianceByConformancePacksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAggregateComplianceByConformancePacks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAggregateComplianceByConformancePacks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAggregateComplianceByConformancePacksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAggregateComplianceByConformancePacksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAggregateComplianceByConformancePacksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAggregateComplianceByConformancePacks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAggregateComplianceByConformancePacks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeAggregationAuthorizationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAggregationAuthorizationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAggregationAuthorizationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAggregationAuthorizationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAggregationAuthorizations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAggregationAuthorizations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAggregationAuthorizationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAggregationAuthorizationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAggregationAuthorizationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAggregationAuthorizations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAggregationAuthorizations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeComplianceByConfigRuleTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeComplianceByConfigRuleRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeComplianceByConfigRuleResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeComplianceByConfigRuleResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeComplianceByConfigRule(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeComplianceByConfigRule(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeComplianceByConfigRuleTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeComplianceByConfigRuleRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeComplianceByConfigRuleResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeComplianceByConfigRule(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeComplianceByConfigRule(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeComplianceByResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeComplianceByResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeComplianceByResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeComplianceByResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeComplianceByResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeComplianceByResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeComplianceByResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeComplianceByResourceRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeComplianceByResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeComplianceByResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeComplianceByResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeConfigRuleEvaluationStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConfigRuleEvaluationStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeConfigRuleEvaluationStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeConfigRuleEvaluationStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeConfigRuleEvaluationStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeConfigRuleEvaluationStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeConfigRuleEvaluationStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConfigRuleEvaluationStatusRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeConfigRuleEvaluationStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeConfigRuleEvaluationStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeConfigRuleEvaluationStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeConfigRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConfigRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeConfigRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeConfigRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeConfigRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeConfigRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeConfigRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConfigRulesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeConfigRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeConfigRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeConfigRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeConfigurationAggregatorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConfigurationAggregatorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeConfigurationAggregatorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeConfigurationAggregatorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeConfigurationAggregators(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeConfigurationAggregators(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeConfigurationAggregatorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConfigurationAggregatorsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeConfigurationAggregatorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeConfigurationAggregators(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeConfigurationAggregators(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeConfigurationAggregatorSourcesStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConfigurationAggregatorSourcesStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeConfigurationAggregatorSourcesStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeConfigurationAggregatorSourcesStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeConfigurationAggregatorSourcesStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeConfigurationAggregatorSourcesStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeConfigurationAggregatorSourcesStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConfigurationAggregatorSourcesStatusRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeConfigurationAggregatorSourcesStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeConfigurationAggregatorSourcesStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeConfigurationAggregatorSourcesStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeConformancePackComplianceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConformancePackComplianceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeConformancePackComplianceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeConformancePackComplianceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeConformancePackCompliance(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeConformancePackCompliance(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeConformancePackComplianceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConformancePackComplianceRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeConformancePackComplianceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeConformancePackCompliance(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeConformancePackCompliance(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeConformancePacksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConformancePacksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeConformancePacksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeConformancePacksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeConformancePacks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeConformancePacks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeConformancePacksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConformancePacksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeConformancePacksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeConformancePacks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeConformancePacks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeConformancePackStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConformancePackStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeConformancePackStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeConformancePackStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeConformancePackStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeConformancePackStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeConformancePackStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConformancePackStatusRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeConformancePackStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeConformancePackStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeConformancePackStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeOrganizationConfigRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrganizationConfigRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOrganizationConfigRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOrganizationConfigRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeOrganizationConfigRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOrganizationConfigRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOrganizationConfigRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrganizationConfigRulesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOrganizationConfigRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeOrganizationConfigRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOrganizationConfigRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeOrganizationConfigRuleStatusesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrganizationConfigRuleStatusesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOrganizationConfigRuleStatusesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOrganizationConfigRuleStatusesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeOrganizationConfigRuleStatuses(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOrganizationConfigRuleStatuses(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOrganizationConfigRuleStatusesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrganizationConfigRuleStatusesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOrganizationConfigRuleStatusesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeOrganizationConfigRuleStatuses(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOrganizationConfigRuleStatuses(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeOrganizationConformancePacksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrganizationConformancePacksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOrganizationConformancePacksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOrganizationConformancePacksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeOrganizationConformancePacks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOrganizationConformancePacks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOrganizationConformancePacksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrganizationConformancePacksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOrganizationConformancePacksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeOrganizationConformancePacks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOrganizationConformancePacks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeOrganizationConformancePackStatusesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrganizationConformancePackStatusesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOrganizationConformancePackStatusesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOrganizationConformancePackStatusesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeOrganizationConformancePackStatuses(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOrganizationConformancePackStatuses(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOrganizationConformancePackStatusesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrganizationConformancePackStatusesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOrganizationConformancePackStatusesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeOrganizationConformancePackStatuses(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOrganizationConformancePackStatuses(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribePendingAggregationRequestsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePendingAggregationRequestsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePendingAggregationRequestsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePendingAggregationRequestsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePendingAggregationRequests(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePendingAggregationRequests(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePendingAggregationRequestsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePendingAggregationRequestsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePendingAggregationRequestsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePendingAggregationRequests(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePendingAggregationRequests(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeRemediationExceptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRemediationExceptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRemediationExceptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRemediationExceptionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRemediationExceptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRemediationExceptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRemediationExceptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRemediationExceptionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRemediationExceptionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRemediationExceptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRemediationExceptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeRemediationExecutionStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRemediationExecutionStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRemediationExecutionStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRemediationExecutionStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRemediationExecutionStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRemediationExecutionStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRemediationExecutionStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRemediationExecutionStatusRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRemediationExecutionStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRemediationExecutionStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRemediationExecutionStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeRetentionConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRetentionConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRetentionConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRetentionConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRetentionConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRetentionConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRetentionConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRetentionConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRetentionConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRetentionConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRetentionConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetAggregateComplianceDetailsByConfigRuleTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetAggregateComplianceDetailsByConfigRuleRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetAggregateComplianceDetailsByConfigRuleResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetAggregateComplianceDetailsByConfigRuleResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetAggregateComplianceDetailsByConfigRule(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetAggregateComplianceDetailsByConfigRule(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetAggregateComplianceDetailsByConfigRuleTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetAggregateComplianceDetailsByConfigRuleRequest>();

            var response = InstantiateClassGenerator.Execute<GetAggregateComplianceDetailsByConfigRuleResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetAggregateComplianceDetailsByConfigRule(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetAggregateComplianceDetailsByConfigRule(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetAggregateConfigRuleComplianceSummaryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetAggregateConfigRuleComplianceSummaryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetAggregateConfigRuleComplianceSummaryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetAggregateConfigRuleComplianceSummaryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetAggregateConfigRuleComplianceSummary(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetAggregateConfigRuleComplianceSummary(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetAggregateConfigRuleComplianceSummaryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetAggregateConfigRuleComplianceSummaryRequest>();

            var response = InstantiateClassGenerator.Execute<GetAggregateConfigRuleComplianceSummaryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetAggregateConfigRuleComplianceSummary(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetAggregateConfigRuleComplianceSummary(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetAggregateConformancePackComplianceSummaryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetAggregateConformancePackComplianceSummaryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetAggregateConformancePackComplianceSummaryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetAggregateConformancePackComplianceSummaryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetAggregateConformancePackComplianceSummary(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetAggregateConformancePackComplianceSummary(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetAggregateConformancePackComplianceSummaryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetAggregateConformancePackComplianceSummaryRequest>();

            var response = InstantiateClassGenerator.Execute<GetAggregateConformancePackComplianceSummaryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetAggregateConformancePackComplianceSummary(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetAggregateConformancePackComplianceSummary(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetAggregateDiscoveredResourceCountsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetAggregateDiscoveredResourceCountsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetAggregateDiscoveredResourceCountsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetAggregateDiscoveredResourceCountsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetAggregateDiscoveredResourceCounts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetAggregateDiscoveredResourceCounts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetAggregateDiscoveredResourceCountsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetAggregateDiscoveredResourceCountsRequest>();

            var response = InstantiateClassGenerator.Execute<GetAggregateDiscoveredResourceCountsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetAggregateDiscoveredResourceCounts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetAggregateDiscoveredResourceCounts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetComplianceDetailsByConfigRuleTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetComplianceDetailsByConfigRuleRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetComplianceDetailsByConfigRuleResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetComplianceDetailsByConfigRuleResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetComplianceDetailsByConfigRule(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetComplianceDetailsByConfigRule(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetComplianceDetailsByConfigRuleTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetComplianceDetailsByConfigRuleRequest>();

            var response = InstantiateClassGenerator.Execute<GetComplianceDetailsByConfigRuleResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetComplianceDetailsByConfigRule(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetComplianceDetailsByConfigRule(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetComplianceDetailsByResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetComplianceDetailsByResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetComplianceDetailsByResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetComplianceDetailsByResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetComplianceDetailsByResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetComplianceDetailsByResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetComplianceDetailsByResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetComplianceDetailsByResourceRequest>();

            var response = InstantiateClassGenerator.Execute<GetComplianceDetailsByResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetComplianceDetailsByResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetComplianceDetailsByResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetConformancePackComplianceDetailsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetConformancePackComplianceDetailsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetConformancePackComplianceDetailsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetConformancePackComplianceDetailsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetConformancePackComplianceDetails(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetConformancePackComplianceDetails(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetConformancePackComplianceDetailsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetConformancePackComplianceDetailsRequest>();

            var response = InstantiateClassGenerator.Execute<GetConformancePackComplianceDetailsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetConformancePackComplianceDetails(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetConformancePackComplianceDetails(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetConformancePackComplianceSummaryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetConformancePackComplianceSummaryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetConformancePackComplianceSummaryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetConformancePackComplianceSummaryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetConformancePackComplianceSummary(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetConformancePackComplianceSummary(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetConformancePackComplianceSummaryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetConformancePackComplianceSummaryRequest>();

            var response = InstantiateClassGenerator.Execute<GetConformancePackComplianceSummaryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetConformancePackComplianceSummary(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetConformancePackComplianceSummary(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetDiscoveredResourceCountsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDiscoveredResourceCountsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDiscoveredResourceCountsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDiscoveredResourceCountsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetDiscoveredResourceCounts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDiscoveredResourceCounts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDiscoveredResourceCountsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDiscoveredResourceCountsRequest>();

            var response = InstantiateClassGenerator.Execute<GetDiscoveredResourceCountsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetDiscoveredResourceCounts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDiscoveredResourceCounts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetOrganizationConfigRuleDetailedStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetOrganizationConfigRuleDetailedStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetOrganizationConfigRuleDetailedStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetOrganizationConfigRuleDetailedStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetOrganizationConfigRuleDetailedStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetOrganizationConfigRuleDetailedStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetOrganizationConfigRuleDetailedStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetOrganizationConfigRuleDetailedStatusRequest>();

            var response = InstantiateClassGenerator.Execute<GetOrganizationConfigRuleDetailedStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetOrganizationConfigRuleDetailedStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetOrganizationConfigRuleDetailedStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetOrganizationConformancePackDetailedStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetOrganizationConformancePackDetailedStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetOrganizationConformancePackDetailedStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetOrganizationConformancePackDetailedStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetOrganizationConformancePackDetailedStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetOrganizationConformancePackDetailedStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetOrganizationConformancePackDetailedStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetOrganizationConformancePackDetailedStatusRequest>();

            var response = InstantiateClassGenerator.Execute<GetOrganizationConformancePackDetailedStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetOrganizationConformancePackDetailedStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetOrganizationConformancePackDetailedStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetResourceConfigHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceConfigHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourceConfigHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourceConfigHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetResourceConfigHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResourceConfigHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourceConfigHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceConfigHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourceConfigHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetResourceConfigHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResourceConfigHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void ListAggregateDiscoveredResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAggregateDiscoveredResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAggregateDiscoveredResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAggregateDiscoveredResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAggregateDiscoveredResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAggregateDiscoveredResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAggregateDiscoveredResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAggregateDiscoveredResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAggregateDiscoveredResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAggregateDiscoveredResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAggregateDiscoveredResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void ListDiscoveredResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDiscoveredResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDiscoveredResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDiscoveredResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDiscoveredResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDiscoveredResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDiscoveredResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDiscoveredResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDiscoveredResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDiscoveredResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDiscoveredResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void ListStoredQueriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStoredQueriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStoredQueriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStoredQueriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStoredQueries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStoredQueries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStoredQueriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStoredQueriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListStoredQueriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStoredQueries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStoredQueries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void SelectAggregateResourceConfigTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SelectAggregateResourceConfigRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SelectAggregateResourceConfigResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SelectAggregateResourceConfigResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SelectAggregateResourceConfig(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SelectAggregateResourceConfig(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SelectAggregateResourceConfigTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SelectAggregateResourceConfigRequest>();

            var response = InstantiateClassGenerator.Execute<SelectAggregateResourceConfigResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SelectAggregateResourceConfig(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SelectAggregateResourceConfig(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void SelectResourceConfigTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SelectResourceConfigRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SelectResourceConfigResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SelectResourceConfigResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SelectResourceConfig(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SelectResourceConfig(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SelectResourceConfigTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SelectResourceConfigRequest>();

            var response = InstantiateClassGenerator.Execute<SelectResourceConfigResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SelectResourceConfig(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SelectResourceConfig(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}