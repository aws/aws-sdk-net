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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */

using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SimpleSystemsManagementPaginatorTests
    {
        private static Mock<AmazonSimpleSystemsManagementClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSimpleSystemsManagementClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeActivationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeActivationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeActivationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeActivationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeActivations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeActivations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeActivationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeActivationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeActivationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeActivations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeActivations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeAssociationExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAssociationExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAssociationExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAssociationExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAssociationExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAssociationExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAssociationExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAssociationExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAssociationExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAssociationExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAssociationExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeAssociationExecutionTargetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAssociationExecutionTargetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAssociationExecutionTargetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAssociationExecutionTargetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAssociationExecutionTargets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAssociationExecutionTargets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAssociationExecutionTargetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAssociationExecutionTargetsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAssociationExecutionTargetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAssociationExecutionTargets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAssociationExecutionTargets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeAutomationExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAutomationExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAutomationExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAutomationExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAutomationExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAutomationExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAutomationExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAutomationExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAutomationExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAutomationExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAutomationExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeAutomationStepExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAutomationStepExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAutomationStepExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAutomationStepExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAutomationStepExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAutomationStepExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAutomationStepExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAutomationStepExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAutomationStepExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAutomationStepExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAutomationStepExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeAvailablePatchesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAvailablePatchesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAvailablePatchesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAvailablePatchesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAvailablePatches(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAvailablePatches(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAvailablePatchesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAvailablePatchesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAvailablePatchesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAvailablePatches(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAvailablePatches(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeEffectiveInstanceAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEffectiveInstanceAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEffectiveInstanceAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEffectiveInstanceAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEffectiveInstanceAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEffectiveInstanceAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEffectiveInstanceAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEffectiveInstanceAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEffectiveInstanceAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEffectiveInstanceAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEffectiveInstanceAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeEffectivePatchesForPatchBaselineTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEffectivePatchesForPatchBaselineRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEffectivePatchesForPatchBaselineResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEffectivePatchesForPatchBaselineResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEffectivePatchesForPatchBaseline(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEffectivePatchesForPatchBaseline(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEffectivePatchesForPatchBaselineTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEffectivePatchesForPatchBaselineRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEffectivePatchesForPatchBaselineResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEffectivePatchesForPatchBaseline(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEffectivePatchesForPatchBaseline(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeInstanceAssociationsStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceAssociationsStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstanceAssociationsStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstanceAssociationsStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstanceAssociationsStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceAssociationsStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstanceAssociationsStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceAssociationsStatusRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstanceAssociationsStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstanceAssociationsStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceAssociationsStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeInstanceInformationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceInformationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstanceInformationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstanceInformationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstanceInformation(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceInformation(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstanceInformationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceInformationRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstanceInformationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstanceInformation(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceInformation(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeInstancePatchesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstancePatchesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstancePatchesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstancePatchesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstancePatches(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstancePatches(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstancePatchesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstancePatchesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstancePatchesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstancePatches(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstancePatches(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeInstancePatchStatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstancePatchStatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstancePatchStatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstancePatchStatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstancePatchStates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstancePatchStates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstancePatchStatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstancePatchStatesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstancePatchStatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstancePatchStates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstancePatchStates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeInstancePatchStatesForPatchGroupTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstancePatchStatesForPatchGroupRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstancePatchStatesForPatchGroupResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstancePatchStatesForPatchGroupResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstancePatchStatesForPatchGroup(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstancePatchStatesForPatchGroup(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstancePatchStatesForPatchGroupTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstancePatchStatesForPatchGroupRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstancePatchStatesForPatchGroupResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstancePatchStatesForPatchGroup(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstancePatchStatesForPatchGroup(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeInventoryDeletionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInventoryDeletionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInventoryDeletionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInventoryDeletionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInventoryDeletions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInventoryDeletions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInventoryDeletionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInventoryDeletionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInventoryDeletionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInventoryDeletions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInventoryDeletions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeMaintenanceWindowExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMaintenanceWindowExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMaintenanceWindowExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMaintenanceWindowExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeMaintenanceWindowExecutionTaskInvocationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionTaskInvocationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionTaskInvocationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionTaskInvocationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMaintenanceWindowExecutionTaskInvocations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowExecutionTaskInvocations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMaintenanceWindowExecutionTaskInvocationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionTaskInvocationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionTaskInvocationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMaintenanceWindowExecutionTaskInvocations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowExecutionTaskInvocations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeMaintenanceWindowExecutionTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMaintenanceWindowExecutionTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowExecutionTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMaintenanceWindowExecutionTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionTasksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowExecutionTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMaintenanceWindowExecutionTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowExecutionTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeMaintenanceWindowsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMaintenanceWindows(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindows(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMaintenanceWindowsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMaintenanceWindows(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindows(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeMaintenanceWindowScheduleTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowScheduleRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowScheduleResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowScheduleResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMaintenanceWindowSchedule(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowSchedule(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMaintenanceWindowScheduleTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowScheduleRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowScheduleResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMaintenanceWindowSchedule(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowSchedule(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeMaintenanceWindowsForTargetTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowsForTargetRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowsForTargetResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowsForTargetResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMaintenanceWindowsForTarget(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowsForTarget(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMaintenanceWindowsForTargetTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowsForTargetRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowsForTargetResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMaintenanceWindowsForTarget(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowsForTarget(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeMaintenanceWindowTargetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowTargetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowTargetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowTargetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMaintenanceWindowTargets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowTargets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMaintenanceWindowTargetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowTargetsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowTargetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMaintenanceWindowTargets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowTargets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeMaintenanceWindowTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMaintenanceWindowTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMaintenanceWindowTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowTasksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMaintenanceWindowTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMaintenanceWindowTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMaintenanceWindowTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeOpsItemsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOpsItemsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOpsItemsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOpsItemsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeOpsItems(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOpsItems(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOpsItemsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOpsItemsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOpsItemsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeOpsItems(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOpsItems(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeParametersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeParametersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeParametersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeParametersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeParameters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeParameters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeParametersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeParametersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeParametersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeParameters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeParameters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribePatchBaselinesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePatchBaselinesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePatchBaselinesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePatchBaselinesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePatchBaselines(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePatchBaselines(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePatchBaselinesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePatchBaselinesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePatchBaselinesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePatchBaselines(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePatchBaselines(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribePatchGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePatchGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePatchGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePatchGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePatchGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePatchGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePatchGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePatchGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePatchGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePatchGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePatchGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribePatchPropertiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePatchPropertiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePatchPropertiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePatchPropertiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePatchProperties(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePatchProperties(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePatchPropertiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePatchPropertiesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePatchPropertiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePatchProperties(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePatchProperties(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeSessionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSessionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSessionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSessionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSessions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSessions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSessionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSessionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSessionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSessions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSessions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void GetInventoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetInventoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetInventoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetInventoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetInventory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetInventory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetInventoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetInventoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetInventoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetInventory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetInventory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void GetInventorySchemaTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetInventorySchemaRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetInventorySchemaResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetInventorySchemaResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetInventorySchema(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetInventorySchema(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetInventorySchemaTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetInventorySchemaRequest>();

            var response = InstantiateClassGenerator.Execute<GetInventorySchemaResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetInventorySchema(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetInventorySchema(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void GetOpsSummaryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetOpsSummaryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetOpsSummaryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetOpsSummaryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetOpsSummary(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetOpsSummary(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetOpsSummaryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetOpsSummaryRequest>();

            var response = InstantiateClassGenerator.Execute<GetOpsSummaryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetOpsSummary(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetOpsSummary(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void GetParameterHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetParameterHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetParameterHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetParameterHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetParameterHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetParameterHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetParameterHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetParameterHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetParameterHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetParameterHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetParameterHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void GetParametersByPathTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetParametersByPathRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetParametersByPathResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetParametersByPathResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetParametersByPath(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetParametersByPath(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetParametersByPathTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetParametersByPathRequest>();

            var response = InstantiateClassGenerator.Execute<GetParametersByPathResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetParametersByPath(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetParametersByPath(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListAssociationVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociationVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssociationVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssociationVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssociationVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssociationVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssociationVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociationVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssociationVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssociationVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssociationVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListCommandInvocationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCommandInvocationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCommandInvocationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCommandInvocationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCommandInvocations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCommandInvocations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCommandInvocationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCommandInvocationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCommandInvocationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCommandInvocations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCommandInvocations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListCommandsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCommandsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCommandsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCommandsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCommands(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCommands(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCommandsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCommandsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCommandsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCommands(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCommands(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListComplianceItemsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListComplianceItemsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListComplianceItemsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListComplianceItemsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListComplianceItems(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListComplianceItems(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListComplianceItemsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListComplianceItemsRequest>();

            var response = InstantiateClassGenerator.Execute<ListComplianceItemsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListComplianceItems(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListComplianceItems(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListComplianceSummariesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListComplianceSummariesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListComplianceSummariesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListComplianceSummariesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListComplianceSummaries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListComplianceSummaries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListComplianceSummariesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListComplianceSummariesRequest>();

            var response = InstantiateClassGenerator.Execute<ListComplianceSummariesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListComplianceSummaries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListComplianceSummaries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListDocumentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDocumentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDocumentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDocumentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDocuments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDocuments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDocumentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDocumentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDocumentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDocuments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDocuments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListDocumentVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDocumentVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDocumentVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDocumentVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDocumentVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDocumentVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDocumentVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDocumentVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDocumentVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDocumentVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDocumentVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListOpsItemEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOpsItemEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOpsItemEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOpsItemEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOpsItemEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOpsItemEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOpsItemEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOpsItemEventsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOpsItemEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOpsItemEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOpsItemEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListOpsMetadataTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOpsMetadataRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOpsMetadataResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOpsMetadataResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOpsMetadata(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOpsMetadata(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOpsMetadataTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOpsMetadataRequest>();

            var response = InstantiateClassGenerator.Execute<ListOpsMetadataResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOpsMetadata(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOpsMetadata(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListResourceComplianceSummariesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceComplianceSummariesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourceComplianceSummariesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourceComplianceSummariesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResourceComplianceSummaries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResourceComplianceSummaries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourceComplianceSummariesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceComplianceSummariesRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourceComplianceSummariesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResourceComplianceSummaries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResourceComplianceSummaries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListResourceDataSyncTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceDataSyncRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourceDataSyncResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourceDataSyncResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResourceDataSync(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResourceDataSync(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourceDataSyncTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceDataSyncRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourceDataSyncResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResourceDataSync(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResourceDataSync(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif