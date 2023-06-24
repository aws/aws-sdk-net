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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Paginators for the SimpleSystemsManagement service
    ///</summary>
    public interface ISimpleSystemsManagementPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeActivations operation
        ///</summary>
        IDescribeActivationsPaginator DescribeActivations(DescribeActivationsRequest request);

        /// <summary>
        /// Paginator for DescribeAssociationExecutions operation
        ///</summary>
        IDescribeAssociationExecutionsPaginator DescribeAssociationExecutions(DescribeAssociationExecutionsRequest request);

        /// <summary>
        /// Paginator for DescribeAssociationExecutionTargets operation
        ///</summary>
        IDescribeAssociationExecutionTargetsPaginator DescribeAssociationExecutionTargets(DescribeAssociationExecutionTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeAutomationExecutions operation
        ///</summary>
        IDescribeAutomationExecutionsPaginator DescribeAutomationExecutions(DescribeAutomationExecutionsRequest request);

        /// <summary>
        /// Paginator for DescribeAutomationStepExecutions operation
        ///</summary>
        IDescribeAutomationStepExecutionsPaginator DescribeAutomationStepExecutions(DescribeAutomationStepExecutionsRequest request);

        /// <summary>
        /// Paginator for DescribeAvailablePatches operation
        ///</summary>
        IDescribeAvailablePatchesPaginator DescribeAvailablePatches(DescribeAvailablePatchesRequest request);

        /// <summary>
        /// Paginator for DescribeEffectiveInstanceAssociations operation
        ///</summary>
        IDescribeEffectiveInstanceAssociationsPaginator DescribeEffectiveInstanceAssociations(DescribeEffectiveInstanceAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeEffectivePatchesForPatchBaseline operation
        ///</summary>
        IDescribeEffectivePatchesForPatchBaselinePaginator DescribeEffectivePatchesForPatchBaseline(DescribeEffectivePatchesForPatchBaselineRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceAssociationsStatus operation
        ///</summary>
        IDescribeInstanceAssociationsStatusPaginator DescribeInstanceAssociationsStatus(DescribeInstanceAssociationsStatusRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceInformation operation
        ///</summary>
        IDescribeInstanceInformationPaginator DescribeInstanceInformation(DescribeInstanceInformationRequest request);

        /// <summary>
        /// Paginator for DescribeInstancePatches operation
        ///</summary>
        IDescribeInstancePatchesPaginator DescribeInstancePatches(DescribeInstancePatchesRequest request);

        /// <summary>
        /// Paginator for DescribeInstancePatchStates operation
        ///</summary>
        IDescribeInstancePatchStatesPaginator DescribeInstancePatchStates(DescribeInstancePatchStatesRequest request);

        /// <summary>
        /// Paginator for DescribeInstancePatchStatesForPatchGroup operation
        ///</summary>
        IDescribeInstancePatchStatesForPatchGroupPaginator DescribeInstancePatchStatesForPatchGroup(DescribeInstancePatchStatesForPatchGroupRequest request);

        /// <summary>
        /// Paginator for DescribeInventoryDeletions operation
        ///</summary>
        IDescribeInventoryDeletionsPaginator DescribeInventoryDeletions(DescribeInventoryDeletionsRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowExecutions operation
        ///</summary>
        IDescribeMaintenanceWindowExecutionsPaginator DescribeMaintenanceWindowExecutions(DescribeMaintenanceWindowExecutionsRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowExecutionTaskInvocations operation
        ///</summary>
        IDescribeMaintenanceWindowExecutionTaskInvocationsPaginator DescribeMaintenanceWindowExecutionTaskInvocations(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowExecutionTasks operation
        ///</summary>
        IDescribeMaintenanceWindowExecutionTasksPaginator DescribeMaintenanceWindowExecutionTasks(DescribeMaintenanceWindowExecutionTasksRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindows operation
        ///</summary>
        IDescribeMaintenanceWindowsPaginator DescribeMaintenanceWindows(DescribeMaintenanceWindowsRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowSchedule operation
        ///</summary>
        IDescribeMaintenanceWindowSchedulePaginator DescribeMaintenanceWindowSchedule(DescribeMaintenanceWindowScheduleRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowsForTarget operation
        ///</summary>
        IDescribeMaintenanceWindowsForTargetPaginator DescribeMaintenanceWindowsForTarget(DescribeMaintenanceWindowsForTargetRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowTargets operation
        ///</summary>
        IDescribeMaintenanceWindowTargetsPaginator DescribeMaintenanceWindowTargets(DescribeMaintenanceWindowTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowTasks operation
        ///</summary>
        IDescribeMaintenanceWindowTasksPaginator DescribeMaintenanceWindowTasks(DescribeMaintenanceWindowTasksRequest request);

        /// <summary>
        /// Paginator for DescribeOpsItems operation
        ///</summary>
        IDescribeOpsItemsPaginator DescribeOpsItems(DescribeOpsItemsRequest request);

        /// <summary>
        /// Paginator for DescribeParameters operation
        ///</summary>
        IDescribeParametersPaginator DescribeParameters(DescribeParametersRequest request);

        /// <summary>
        /// Paginator for DescribePatchBaselines operation
        ///</summary>
        IDescribePatchBaselinesPaginator DescribePatchBaselines(DescribePatchBaselinesRequest request);

        /// <summary>
        /// Paginator for DescribePatchGroups operation
        ///</summary>
        IDescribePatchGroupsPaginator DescribePatchGroups(DescribePatchGroupsRequest request);

        /// <summary>
        /// Paginator for DescribePatchProperties operation
        ///</summary>
        IDescribePatchPropertiesPaginator DescribePatchProperties(DescribePatchPropertiesRequest request);

        /// <summary>
        /// Paginator for DescribeSessions operation
        ///</summary>
        IDescribeSessionsPaginator DescribeSessions(DescribeSessionsRequest request);

        /// <summary>
        /// Paginator for GetInventory operation
        ///</summary>
        IGetInventoryPaginator GetInventory(GetInventoryRequest request);

        /// <summary>
        /// Paginator for GetInventorySchema operation
        ///</summary>
        IGetInventorySchemaPaginator GetInventorySchema(GetInventorySchemaRequest request);

        /// <summary>
        /// Paginator for GetOpsSummary operation
        ///</summary>
        IGetOpsSummaryPaginator GetOpsSummary(GetOpsSummaryRequest request);

        /// <summary>
        /// Paginator for GetParameterHistory operation
        ///</summary>
        IGetParameterHistoryPaginator GetParameterHistory(GetParameterHistoryRequest request);

        /// <summary>
        /// Paginator for GetParametersByPath operation
        ///</summary>
        IGetParametersByPathPaginator GetParametersByPath(GetParametersByPathRequest request);

        /// <summary>
        /// Paginator for GetResourcePolicies operation
        ///</summary>
        IGetResourcePoliciesPaginator GetResourcePolicies(GetResourcePoliciesRequest request);

        /// <summary>
        /// Paginator for ListAssociations operation
        ///</summary>
        IListAssociationsPaginator ListAssociations(ListAssociationsRequest request);

        /// <summary>
        /// Paginator for ListAssociationVersions operation
        ///</summary>
        IListAssociationVersionsPaginator ListAssociationVersions(ListAssociationVersionsRequest request);

        /// <summary>
        /// Paginator for ListCommandInvocations operation
        ///</summary>
        IListCommandInvocationsPaginator ListCommandInvocations(ListCommandInvocationsRequest request);

        /// <summary>
        /// Paginator for ListCommands operation
        ///</summary>
        IListCommandsPaginator ListCommands(ListCommandsRequest request);

        /// <summary>
        /// Paginator for ListComplianceItems operation
        ///</summary>
        IListComplianceItemsPaginator ListComplianceItems(ListComplianceItemsRequest request);

        /// <summary>
        /// Paginator for ListComplianceSummaries operation
        ///</summary>
        IListComplianceSummariesPaginator ListComplianceSummaries(ListComplianceSummariesRequest request);

        /// <summary>
        /// Paginator for ListDocuments operation
        ///</summary>
        IListDocumentsPaginator ListDocuments(ListDocumentsRequest request);

        /// <summary>
        /// Paginator for ListDocumentVersions operation
        ///</summary>
        IListDocumentVersionsPaginator ListDocumentVersions(ListDocumentVersionsRequest request);

        /// <summary>
        /// Paginator for ListOpsItemEvents operation
        ///</summary>
        IListOpsItemEventsPaginator ListOpsItemEvents(ListOpsItemEventsRequest request);

        /// <summary>
        /// Paginator for ListOpsItemRelatedItems operation
        ///</summary>
        IListOpsItemRelatedItemsPaginator ListOpsItemRelatedItems(ListOpsItemRelatedItemsRequest request);

        /// <summary>
        /// Paginator for ListOpsMetadata operation
        ///</summary>
        IListOpsMetadataPaginator ListOpsMetadata(ListOpsMetadataRequest request);

        /// <summary>
        /// Paginator for ListResourceComplianceSummaries operation
        ///</summary>
        IListResourceComplianceSummariesPaginator ListResourceComplianceSummaries(ListResourceComplianceSummariesRequest request);

        /// <summary>
        /// Paginator for ListResourceDataSync operation
        ///</summary>
        IListResourceDataSyncPaginator ListResourceDataSync(ListResourceDataSyncRequest request);
    }
}