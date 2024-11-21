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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Paginators for the SimpleSystemsManagement service
    ///</summary>
    public class SimpleSystemsManagementPaginatorFactory : ISimpleSystemsManagementPaginatorFactory
    {
        private readonly IAmazonSimpleSystemsManagement client;

        internal SimpleSystemsManagementPaginatorFactory(IAmazonSimpleSystemsManagement client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeActivations operation
        ///</summary>
        public IDescribeActivationsPaginator DescribeActivations(DescribeActivationsRequest request) 
        {
            return new DescribeActivationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAssociationExecutions operation
        ///</summary>
        public IDescribeAssociationExecutionsPaginator DescribeAssociationExecutions(DescribeAssociationExecutionsRequest request) 
        {
            return new DescribeAssociationExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAssociationExecutionTargets operation
        ///</summary>
        public IDescribeAssociationExecutionTargetsPaginator DescribeAssociationExecutionTargets(DescribeAssociationExecutionTargetsRequest request) 
        {
            return new DescribeAssociationExecutionTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAutomationExecutions operation
        ///</summary>
        public IDescribeAutomationExecutionsPaginator DescribeAutomationExecutions(DescribeAutomationExecutionsRequest request) 
        {
            return new DescribeAutomationExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAutomationStepExecutions operation
        ///</summary>
        public IDescribeAutomationStepExecutionsPaginator DescribeAutomationStepExecutions(DescribeAutomationStepExecutionsRequest request) 
        {
            return new DescribeAutomationStepExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAvailablePatches operation
        ///</summary>
        public IDescribeAvailablePatchesPaginator DescribeAvailablePatches(DescribeAvailablePatchesRequest request) 
        {
            return new DescribeAvailablePatchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEffectiveInstanceAssociations operation
        ///</summary>
        public IDescribeEffectiveInstanceAssociationsPaginator DescribeEffectiveInstanceAssociations(DescribeEffectiveInstanceAssociationsRequest request) 
        {
            return new DescribeEffectiveInstanceAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEffectivePatchesForPatchBaseline operation
        ///</summary>
        public IDescribeEffectivePatchesForPatchBaselinePaginator DescribeEffectivePatchesForPatchBaseline(DescribeEffectivePatchesForPatchBaselineRequest request) 
        {
            return new DescribeEffectivePatchesForPatchBaselinePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstanceAssociationsStatus operation
        ///</summary>
        public IDescribeInstanceAssociationsStatusPaginator DescribeInstanceAssociationsStatus(DescribeInstanceAssociationsStatusRequest request) 
        {
            return new DescribeInstanceAssociationsStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstanceInformation operation
        ///</summary>
        public IDescribeInstanceInformationPaginator DescribeInstanceInformation(DescribeInstanceInformationRequest request) 
        {
            return new DescribeInstanceInformationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstancePatches operation
        ///</summary>
        public IDescribeInstancePatchesPaginator DescribeInstancePatches(DescribeInstancePatchesRequest request) 
        {
            return new DescribeInstancePatchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstancePatchStates operation
        ///</summary>
        public IDescribeInstancePatchStatesPaginator DescribeInstancePatchStates(DescribeInstancePatchStatesRequest request) 
        {
            return new DescribeInstancePatchStatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstancePatchStatesForPatchGroup operation
        ///</summary>
        public IDescribeInstancePatchStatesForPatchGroupPaginator DescribeInstancePatchStatesForPatchGroup(DescribeInstancePatchStatesForPatchGroupRequest request) 
        {
            return new DescribeInstancePatchStatesForPatchGroupPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstanceProperties operation
        ///</summary>
        public IDescribeInstancePropertiesPaginator DescribeInstanceProperties(DescribeInstancePropertiesRequest request) 
        {
            return new DescribeInstancePropertiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInventoryDeletions operation
        ///</summary>
        public IDescribeInventoryDeletionsPaginator DescribeInventoryDeletions(DescribeInventoryDeletionsRequest request) 
        {
            return new DescribeInventoryDeletionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowExecutions operation
        ///</summary>
        public IDescribeMaintenanceWindowExecutionsPaginator DescribeMaintenanceWindowExecutions(DescribeMaintenanceWindowExecutionsRequest request) 
        {
            return new DescribeMaintenanceWindowExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowExecutionTaskInvocations operation
        ///</summary>
        public IDescribeMaintenanceWindowExecutionTaskInvocationsPaginator DescribeMaintenanceWindowExecutionTaskInvocations(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request) 
        {
            return new DescribeMaintenanceWindowExecutionTaskInvocationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowExecutionTasks operation
        ///</summary>
        public IDescribeMaintenanceWindowExecutionTasksPaginator DescribeMaintenanceWindowExecutionTasks(DescribeMaintenanceWindowExecutionTasksRequest request) 
        {
            return new DescribeMaintenanceWindowExecutionTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMaintenanceWindows operation
        ///</summary>
        public IDescribeMaintenanceWindowsPaginator DescribeMaintenanceWindows(DescribeMaintenanceWindowsRequest request) 
        {
            return new DescribeMaintenanceWindowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowSchedule operation
        ///</summary>
        public IDescribeMaintenanceWindowSchedulePaginator DescribeMaintenanceWindowSchedule(DescribeMaintenanceWindowScheduleRequest request) 
        {
            return new DescribeMaintenanceWindowSchedulePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowsForTarget operation
        ///</summary>
        public IDescribeMaintenanceWindowsForTargetPaginator DescribeMaintenanceWindowsForTarget(DescribeMaintenanceWindowsForTargetRequest request) 
        {
            return new DescribeMaintenanceWindowsForTargetPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowTargets operation
        ///</summary>
        public IDescribeMaintenanceWindowTargetsPaginator DescribeMaintenanceWindowTargets(DescribeMaintenanceWindowTargetsRequest request) 
        {
            return new DescribeMaintenanceWindowTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowTasks operation
        ///</summary>
        public IDescribeMaintenanceWindowTasksPaginator DescribeMaintenanceWindowTasks(DescribeMaintenanceWindowTasksRequest request) 
        {
            return new DescribeMaintenanceWindowTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOpsItems operation
        ///</summary>
        public IDescribeOpsItemsPaginator DescribeOpsItems(DescribeOpsItemsRequest request) 
        {
            return new DescribeOpsItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeParameters operation
        ///</summary>
        public IDescribeParametersPaginator DescribeParameters(DescribeParametersRequest request) 
        {
            return new DescribeParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePatchBaselines operation
        ///</summary>
        public IDescribePatchBaselinesPaginator DescribePatchBaselines(DescribePatchBaselinesRequest request) 
        {
            return new DescribePatchBaselinesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePatchGroups operation
        ///</summary>
        public IDescribePatchGroupsPaginator DescribePatchGroups(DescribePatchGroupsRequest request) 
        {
            return new DescribePatchGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePatchProperties operation
        ///</summary>
        public IDescribePatchPropertiesPaginator DescribePatchProperties(DescribePatchPropertiesRequest request) 
        {
            return new DescribePatchPropertiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSessions operation
        ///</summary>
        public IDescribeSessionsPaginator DescribeSessions(DescribeSessionsRequest request) 
        {
            return new DescribeSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetInventory operation
        ///</summary>
        public IGetInventoryPaginator GetInventory(GetInventoryRequest request) 
        {
            return new GetInventoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetInventorySchema operation
        ///</summary>
        public IGetInventorySchemaPaginator GetInventorySchema(GetInventorySchemaRequest request) 
        {
            return new GetInventorySchemaPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetOpsSummary operation
        ///</summary>
        public IGetOpsSummaryPaginator GetOpsSummary(GetOpsSummaryRequest request) 
        {
            return new GetOpsSummaryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetParameterHistory operation
        ///</summary>
        public IGetParameterHistoryPaginator GetParameterHistory(GetParameterHistoryRequest request) 
        {
            return new GetParameterHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetParametersByPath operation
        ///</summary>
        public IGetParametersByPathPaginator GetParametersByPath(GetParametersByPathRequest request) 
        {
            return new GetParametersByPathPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResourcePolicies operation
        ///</summary>
        public IGetResourcePoliciesPaginator GetResourcePolicies(GetResourcePoliciesRequest request) 
        {
            return new GetResourcePoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociations operation
        ///</summary>
        public IListAssociationsPaginator ListAssociations(ListAssociationsRequest request) 
        {
            return new ListAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociationVersions operation
        ///</summary>
        public IListAssociationVersionsPaginator ListAssociationVersions(ListAssociationVersionsRequest request) 
        {
            return new ListAssociationVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCommandInvocations operation
        ///</summary>
        public IListCommandInvocationsPaginator ListCommandInvocations(ListCommandInvocationsRequest request) 
        {
            return new ListCommandInvocationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCommands operation
        ///</summary>
        public IListCommandsPaginator ListCommands(ListCommandsRequest request) 
        {
            return new ListCommandsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComplianceItems operation
        ///</summary>
        public IListComplianceItemsPaginator ListComplianceItems(ListComplianceItemsRequest request) 
        {
            return new ListComplianceItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComplianceSummaries operation
        ///</summary>
        public IListComplianceSummariesPaginator ListComplianceSummaries(ListComplianceSummariesRequest request) 
        {
            return new ListComplianceSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDocuments operation
        ///</summary>
        public IListDocumentsPaginator ListDocuments(ListDocumentsRequest request) 
        {
            return new ListDocumentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDocumentVersions operation
        ///</summary>
        public IListDocumentVersionsPaginator ListDocumentVersions(ListDocumentVersionsRequest request) 
        {
            return new ListDocumentVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        public IListNodesPaginator ListNodes(ListNodesRequest request) 
        {
            return new ListNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNodesSummary operation
        ///</summary>
        public IListNodesSummaryPaginator ListNodesSummary(ListNodesSummaryRequest request) 
        {
            return new ListNodesSummaryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOpsItemEvents operation
        ///</summary>
        public IListOpsItemEventsPaginator ListOpsItemEvents(ListOpsItemEventsRequest request) 
        {
            return new ListOpsItemEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOpsItemRelatedItems operation
        ///</summary>
        public IListOpsItemRelatedItemsPaginator ListOpsItemRelatedItems(ListOpsItemRelatedItemsRequest request) 
        {
            return new ListOpsItemRelatedItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOpsMetadata operation
        ///</summary>
        public IListOpsMetadataPaginator ListOpsMetadata(ListOpsMetadataRequest request) 
        {
            return new ListOpsMetadataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceComplianceSummaries operation
        ///</summary>
        public IListResourceComplianceSummariesPaginator ListResourceComplianceSummaries(ListResourceComplianceSummariesRequest request) 
        {
            return new ListResourceComplianceSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceDataSync operation
        ///</summary>
        public IListResourceDataSyncPaginator ListResourceDataSync(ListResourceDataSyncRequest request) 
        {
            return new ListResourceDataSyncPaginator(this.client, request);
        }
    }
}