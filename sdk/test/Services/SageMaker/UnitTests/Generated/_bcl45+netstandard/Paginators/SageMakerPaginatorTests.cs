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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */

using Amazon.SageMaker;
using Amazon.SageMaker.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SageMakerPaginatorTests
    {
        private static Mock<AmazonSageMakerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSageMakerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListAlgorithmsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAlgorithmsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAlgorithmsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAlgorithmsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAlgorithms(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAlgorithms(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAlgorithmsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAlgorithmsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAlgorithmsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAlgorithms(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAlgorithms(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListAppsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApps(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApps(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApps(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApps(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListAutoMLJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAutoMLJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAutoMLJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAutoMLJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAutoMLJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAutoMLJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAutoMLJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAutoMLJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAutoMLJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAutoMLJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAutoMLJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListCandidatesForAutoMLJobTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCandidatesForAutoMLJobRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCandidatesForAutoMLJobResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCandidatesForAutoMLJobResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCandidatesForAutoMLJob(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCandidatesForAutoMLJob(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCandidatesForAutoMLJobTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCandidatesForAutoMLJobRequest>();

            var response = InstantiateClassGenerator.Execute<ListCandidatesForAutoMLJobResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCandidatesForAutoMLJob(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCandidatesForAutoMLJob(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListCodeRepositoriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCodeRepositoriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCodeRepositoriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCodeRepositoriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCodeRepositories(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCodeRepositories(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCodeRepositoriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCodeRepositoriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListCodeRepositoriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCodeRepositories(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCodeRepositories(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListCompilationJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCompilationJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCompilationJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCompilationJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCompilationJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCompilationJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCompilationJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCompilationJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCompilationJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCompilationJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCompilationJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListDomainsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDomains(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDomains(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDomainsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDomains(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDomains(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListEndpointConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEndpointConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEndpointConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEndpointConfigsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEndpointConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEndpointConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEndpointConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEndpointConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEndpointConfigsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEndpointConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEndpointConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEndpointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEndpointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
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
        [TestCategory("SageMaker")]
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
        [TestCategory("SageMaker")]
        public void ListFlowDefinitionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFlowDefinitionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFlowDefinitionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFlowDefinitionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFlowDefinitions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFlowDefinitions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFlowDefinitionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFlowDefinitionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFlowDefinitionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFlowDefinitions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFlowDefinitions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListHumanTaskUisTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHumanTaskUisRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHumanTaskUisResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHumanTaskUisResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHumanTaskUis(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHumanTaskUis(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHumanTaskUisTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHumanTaskUisRequest>();

            var response = InstantiateClassGenerator.Execute<ListHumanTaskUisResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHumanTaskUis(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHumanTaskUis(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListHyperParameterTuningJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHyperParameterTuningJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHyperParameterTuningJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHyperParameterTuningJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHyperParameterTuningJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHyperParameterTuningJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHyperParameterTuningJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHyperParameterTuningJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListHyperParameterTuningJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHyperParameterTuningJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHyperParameterTuningJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListLabelingJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLabelingJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLabelingJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLabelingJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLabelingJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLabelingJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLabelingJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLabelingJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLabelingJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLabelingJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLabelingJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListLabelingJobsForWorkteamTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLabelingJobsForWorkteamRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLabelingJobsForWorkteamResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLabelingJobsForWorkteamResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLabelingJobsForWorkteam(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLabelingJobsForWorkteam(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLabelingJobsForWorkteamTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLabelingJobsForWorkteamRequest>();

            var response = InstantiateClassGenerator.Execute<ListLabelingJobsForWorkteamResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLabelingJobsForWorkteam(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLabelingJobsForWorkteam(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListModelPackagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListModelPackagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListModelPackagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListModelPackagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListModelPackages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListModelPackages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListModelPackagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListModelPackagesRequest>();

            var response = InstantiateClassGenerator.Execute<ListModelPackagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListModelPackages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListModelPackages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListModelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListModelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListModelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListMonitoringExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMonitoringExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMonitoringExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMonitoringExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMonitoringExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMonitoringExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMonitoringExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMonitoringExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMonitoringExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMonitoringExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMonitoringExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListMonitoringSchedulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMonitoringSchedulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMonitoringSchedulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMonitoringSchedulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMonitoringSchedules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMonitoringSchedules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMonitoringSchedulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMonitoringSchedulesRequest>();

            var response = InstantiateClassGenerator.Execute<ListMonitoringSchedulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMonitoringSchedules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMonitoringSchedules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListNotebookInstanceLifecycleConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNotebookInstanceLifecycleConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNotebookInstanceLifecycleConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNotebookInstanceLifecycleConfigsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNotebookInstanceLifecycleConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNotebookInstanceLifecycleConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNotebookInstanceLifecycleConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNotebookInstanceLifecycleConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListNotebookInstanceLifecycleConfigsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNotebookInstanceLifecycleConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNotebookInstanceLifecycleConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListNotebookInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNotebookInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNotebookInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNotebookInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNotebookInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNotebookInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNotebookInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNotebookInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListNotebookInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNotebookInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNotebookInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListProcessingJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProcessingJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProcessingJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProcessingJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProcessingJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProcessingJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProcessingJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProcessingJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProcessingJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProcessingJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProcessingJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListSubscribedWorkteamsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSubscribedWorkteamsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSubscribedWorkteamsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSubscribedWorkteamsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSubscribedWorkteams(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSubscribedWorkteams(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSubscribedWorkteamsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSubscribedWorkteamsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSubscribedWorkteamsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSubscribedWorkteams(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSubscribedWorkteams(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListTrainingJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTrainingJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTrainingJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTrainingJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTrainingJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTrainingJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTrainingJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTrainingJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTrainingJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTrainingJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTrainingJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListTrainingJobsForHyperParameterTuningJobTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTrainingJobsForHyperParameterTuningJobRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTrainingJobsForHyperParameterTuningJobResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTrainingJobsForHyperParameterTuningJobResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTrainingJobsForHyperParameterTuningJob(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTrainingJobsForHyperParameterTuningJob(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTrainingJobsForHyperParameterTuningJobTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTrainingJobsForHyperParameterTuningJobRequest>();

            var response = InstantiateClassGenerator.Execute<ListTrainingJobsForHyperParameterTuningJobResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTrainingJobsForHyperParameterTuningJob(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTrainingJobsForHyperParameterTuningJob(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListTransformJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTransformJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTransformJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTransformJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTransformJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTransformJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTransformJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTransformJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTransformJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTransformJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTransformJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListTrialComponentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTrialComponentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTrialComponentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTrialComponentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTrialComponents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTrialComponents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTrialComponentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTrialComponentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTrialComponentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTrialComponents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTrialComponents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListTrialsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTrialsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTrialsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTrialsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTrials(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTrials(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTrialsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTrialsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTrialsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTrials(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTrials(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListUserProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUserProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUserProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUserProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUserProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUserProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUserProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUserProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListUserProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUserProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUserProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListWorkforcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkforcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkforcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkforcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkforces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkforces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkforcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkforcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkforcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkforces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkforces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void ListWorkteamsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkteamsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkteamsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkteamsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkteams(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkteams(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkteamsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkteamsRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkteamsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkteams(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkteams(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        public void SearchTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.Search(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.Search(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SageMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchRequest>();

            var response = InstantiateClassGenerator.Execute<SearchResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.Search(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.Search(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif