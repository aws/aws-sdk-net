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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeActivationsPaginator DescribeActivations(DescribeActivationsRequest request);

        /// <summary>
        /// Paginator for DescribeAssociationExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAssociationExecutionsPaginator DescribeAssociationExecutions(DescribeAssociationExecutionsRequest request);

        /// <summary>
        /// Paginator for DescribeAssociationExecutionTargets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAssociationExecutionTargetsPaginator DescribeAssociationExecutionTargets(DescribeAssociationExecutionTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeAutomationExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAutomationExecutionsPaginator DescribeAutomationExecutions(DescribeAutomationExecutionsRequest request);

        /// <summary>
        /// Paginator for DescribeAutomationStepExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAutomationStepExecutionsPaginator DescribeAutomationStepExecutions(DescribeAutomationStepExecutionsRequest request);

        /// <summary>
        /// Paginator for DescribeAvailablePatches operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAvailablePatchesPaginator DescribeAvailablePatches(DescribeAvailablePatchesRequest request);

        /// <summary>
        /// Paginator for DescribeEffectiveInstanceAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeEffectiveInstanceAssociationsPaginator DescribeEffectiveInstanceAssociations(DescribeEffectiveInstanceAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeEffectivePatchesForPatchBaseline operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeEffectivePatchesForPatchBaselinePaginator DescribeEffectivePatchesForPatchBaseline(DescribeEffectivePatchesForPatchBaselineRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceAssociationsStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstanceAssociationsStatusPaginator DescribeInstanceAssociationsStatus(DescribeInstanceAssociationsStatusRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceInformation operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstanceInformationPaginator DescribeInstanceInformation(DescribeInstanceInformationRequest request);

        /// <summary>
        /// Paginator for DescribeInstancePatches operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstancePatchesPaginator DescribeInstancePatches(DescribeInstancePatchesRequest request);

        /// <summary>
        /// Paginator for DescribeInstancePatchStates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstancePatchStatesPaginator DescribeInstancePatchStates(DescribeInstancePatchStatesRequest request);

        /// <summary>
        /// Paginator for DescribeInstancePatchStatesForPatchGroup operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstancePatchStatesForPatchGroupPaginator DescribeInstancePatchStatesForPatchGroup(DescribeInstancePatchStatesForPatchGroupRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceProperties operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstancePropertiesPaginator DescribeInstanceProperties(DescribeInstancePropertiesRequest request);

        /// <summary>
        /// Paginator for DescribeInventoryDeletions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInventoryDeletionsPaginator DescribeInventoryDeletions(DescribeInventoryDeletionsRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMaintenanceWindowExecutionsPaginator DescribeMaintenanceWindowExecutions(DescribeMaintenanceWindowExecutionsRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowExecutionTaskInvocations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMaintenanceWindowExecutionTaskInvocationsPaginator DescribeMaintenanceWindowExecutionTaskInvocations(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowExecutionTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMaintenanceWindowExecutionTasksPaginator DescribeMaintenanceWindowExecutionTasks(DescribeMaintenanceWindowExecutionTasksRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMaintenanceWindowsPaginator DescribeMaintenanceWindows(DescribeMaintenanceWindowsRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowSchedule operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMaintenanceWindowSchedulePaginator DescribeMaintenanceWindowSchedule(DescribeMaintenanceWindowScheduleRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowsForTarget operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMaintenanceWindowsForTargetPaginator DescribeMaintenanceWindowsForTarget(DescribeMaintenanceWindowsForTargetRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowTargets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMaintenanceWindowTargetsPaginator DescribeMaintenanceWindowTargets(DescribeMaintenanceWindowTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeMaintenanceWindowTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMaintenanceWindowTasksPaginator DescribeMaintenanceWindowTasks(DescribeMaintenanceWindowTasksRequest request);

        /// <summary>
        /// Paginator for DescribeOpsItems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeOpsItemsPaginator DescribeOpsItems(DescribeOpsItemsRequest request);

        /// <summary>
        /// Paginator for DescribeParameters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeParametersPaginator DescribeParameters(DescribeParametersRequest request);

        /// <summary>
        /// Paginator for DescribePatchBaselines operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribePatchBaselinesPaginator DescribePatchBaselines(DescribePatchBaselinesRequest request);

        /// <summary>
        /// Paginator for DescribePatchGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribePatchGroupsPaginator DescribePatchGroups(DescribePatchGroupsRequest request);

        /// <summary>
        /// Paginator for DescribePatchProperties operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribePatchPropertiesPaginator DescribePatchProperties(DescribePatchPropertiesRequest request);

        /// <summary>
        /// Paginator for DescribeSessions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSessionsPaginator DescribeSessions(DescribeSessionsRequest request);

        /// <summary>
        /// Paginator for GetInventory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetInventoryPaginator GetInventory(GetInventoryRequest request);

        /// <summary>
        /// Paginator for GetInventorySchema operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetInventorySchemaPaginator GetInventorySchema(GetInventorySchemaRequest request);

        /// <summary>
        /// Paginator for GetOpsSummary operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetOpsSummaryPaginator GetOpsSummary(GetOpsSummaryRequest request);

        /// <summary>
        /// Paginator for GetParameterHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetParameterHistoryPaginator GetParameterHistory(GetParameterHistoryRequest request);

        /// <summary>
        /// Paginator for GetParametersByPath operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetParametersByPathPaginator GetParametersByPath(GetParametersByPathRequest request);

        /// <summary>
        /// Paginator for GetResourcePolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetResourcePoliciesPaginator GetResourcePolicies(GetResourcePoliciesRequest request);

        /// <summary>
        /// Paginator for ListAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssociationsPaginator ListAssociations(ListAssociationsRequest request);

        /// <summary>
        /// Paginator for ListAssociationVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssociationVersionsPaginator ListAssociationVersions(ListAssociationVersionsRequest request);

        /// <summary>
        /// Paginator for ListCommandInvocations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCommandInvocationsPaginator ListCommandInvocations(ListCommandInvocationsRequest request);

        /// <summary>
        /// Paginator for ListCommands operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCommandsPaginator ListCommands(ListCommandsRequest request);

        /// <summary>
        /// Paginator for ListComplianceItems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListComplianceItemsPaginator ListComplianceItems(ListComplianceItemsRequest request);

        /// <summary>
        /// Paginator for ListComplianceSummaries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListComplianceSummariesPaginator ListComplianceSummaries(ListComplianceSummariesRequest request);

        /// <summary>
        /// Paginator for ListDocuments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDocumentsPaginator ListDocuments(ListDocumentsRequest request);

        /// <summary>
        /// Paginator for ListDocumentVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDocumentVersionsPaginator ListDocumentVersions(ListDocumentVersionsRequest request);

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNodesPaginator ListNodes(ListNodesRequest request);

        /// <summary>
        /// Paginator for ListNodesSummary operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNodesSummaryPaginator ListNodesSummary(ListNodesSummaryRequest request);

        /// <summary>
        /// Paginator for ListOpsItemEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOpsItemEventsPaginator ListOpsItemEvents(ListOpsItemEventsRequest request);

        /// <summary>
        /// Paginator for ListOpsItemRelatedItems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOpsItemRelatedItemsPaginator ListOpsItemRelatedItems(ListOpsItemRelatedItemsRequest request);

        /// <summary>
        /// Paginator for ListOpsMetadata operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOpsMetadataPaginator ListOpsMetadata(ListOpsMetadataRequest request);

        /// <summary>
        /// Paginator for ListResourceComplianceSummaries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourceComplianceSummariesPaginator ListResourceComplianceSummaries(ListResourceComplianceSummariesRequest request);

        /// <summary>
        /// Paginator for ListResourceDataSync operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourceDataSyncPaginator ListResourceDataSync(ListResourceDataSyncRequest request);
    }
}