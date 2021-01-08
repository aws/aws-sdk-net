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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Paginators for the IoT service
    ///</summary>
    public interface IIoTPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetBehaviorModelTrainingSummaries operation
        ///</summary>
        IGetBehaviorModelTrainingSummariesPaginator GetBehaviorModelTrainingSummaries(GetBehaviorModelTrainingSummariesRequest request);

        /// <summary>
        /// Paginator for ListActiveViolations operation
        ///</summary>
        IListActiveViolationsPaginator ListActiveViolations(ListActiveViolationsRequest request);

        /// <summary>
        /// Paginator for ListAttachedPolicies operation
        ///</summary>
        IListAttachedPoliciesPaginator ListAttachedPolicies(ListAttachedPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAuditFindings operation
        ///</summary>
        IListAuditFindingsPaginator ListAuditFindings(ListAuditFindingsRequest request);

        /// <summary>
        /// Paginator for ListAuditMitigationActionsExecutions operation
        ///</summary>
        IListAuditMitigationActionsExecutionsPaginator ListAuditMitigationActionsExecutions(ListAuditMitigationActionsExecutionsRequest request);

        /// <summary>
        /// Paginator for ListAuditMitigationActionsTasks operation
        ///</summary>
        IListAuditMitigationActionsTasksPaginator ListAuditMitigationActionsTasks(ListAuditMitigationActionsTasksRequest request);

        /// <summary>
        /// Paginator for ListAuditSuppressions operation
        ///</summary>
        IListAuditSuppressionsPaginator ListAuditSuppressions(ListAuditSuppressionsRequest request);

        /// <summary>
        /// Paginator for ListAuditTasks operation
        ///</summary>
        IListAuditTasksPaginator ListAuditTasks(ListAuditTasksRequest request);

        /// <summary>
        /// Paginator for ListAuthorizers operation
        ///</summary>
        IListAuthorizersPaginator ListAuthorizers(ListAuthorizersRequest request);

        /// <summary>
        /// Paginator for ListBillingGroups operation
        ///</summary>
        IListBillingGroupsPaginator ListBillingGroups(ListBillingGroupsRequest request);

        /// <summary>
        /// Paginator for ListCACertificates operation
        ///</summary>
        IListCACertificatesPaginator ListCACertificates(ListCACertificatesRequest request);

        /// <summary>
        /// Paginator for ListCertificates operation
        ///</summary>
        IListCertificatesPaginator ListCertificates(ListCertificatesRequest request);

        /// <summary>
        /// Paginator for ListCertificatesByCA operation
        ///</summary>
        IListCertificatesByCAPaginator ListCertificatesByCA(ListCertificatesByCARequest request);

        /// <summary>
        /// Paginator for ListCustomMetrics operation
        ///</summary>
        IListCustomMetricsPaginator ListCustomMetrics(ListCustomMetricsRequest request);

        /// <summary>
        /// Paginator for ListDetectMitigationActionsExecutions operation
        ///</summary>
        IListDetectMitigationActionsExecutionsPaginator ListDetectMitigationActionsExecutions(ListDetectMitigationActionsExecutionsRequest request);

        /// <summary>
        /// Paginator for ListDetectMitigationActionsTasks operation
        ///</summary>
        IListDetectMitigationActionsTasksPaginator ListDetectMitigationActionsTasks(ListDetectMitigationActionsTasksRequest request);

        /// <summary>
        /// Paginator for ListDimensions operation
        ///</summary>
        IListDimensionsPaginator ListDimensions(ListDimensionsRequest request);

        /// <summary>
        /// Paginator for ListDomainConfigurations operation
        ///</summary>
        IListDomainConfigurationsPaginator ListDomainConfigurations(ListDomainConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListIndices operation
        ///</summary>
        IListIndicesPaginator ListIndices(ListIndicesRequest request);

        /// <summary>
        /// Paginator for ListJobExecutionsForJob operation
        ///</summary>
        IListJobExecutionsForJobPaginator ListJobExecutionsForJob(ListJobExecutionsForJobRequest request);

        /// <summary>
        /// Paginator for ListJobExecutionsForThing operation
        ///</summary>
        IListJobExecutionsForThingPaginator ListJobExecutionsForThing(ListJobExecutionsForThingRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListMitigationActions operation
        ///</summary>
        IListMitigationActionsPaginator ListMitigationActions(ListMitigationActionsRequest request);

        /// <summary>
        /// Paginator for ListOTAUpdates operation
        ///</summary>
        IListOTAUpdatesPaginator ListOTAUpdates(ListOTAUpdatesRequest request);

        /// <summary>
        /// Paginator for ListOutgoingCertificates operation
        ///</summary>
        IListOutgoingCertificatesPaginator ListOutgoingCertificates(ListOutgoingCertificatesRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPolicyPrincipals operation
        ///</summary>
        IListPolicyPrincipalsPaginator ListPolicyPrincipals(ListPolicyPrincipalsRequest request);

        /// <summary>
        /// Paginator for ListPrincipalPolicies operation
        ///</summary>
        IListPrincipalPoliciesPaginator ListPrincipalPolicies(ListPrincipalPoliciesRequest request);

        /// <summary>
        /// Paginator for ListProvisioningTemplates operation
        ///</summary>
        IListProvisioningTemplatesPaginator ListProvisioningTemplates(ListProvisioningTemplatesRequest request);

        /// <summary>
        /// Paginator for ListProvisioningTemplateVersions operation
        ///</summary>
        IListProvisioningTemplateVersionsPaginator ListProvisioningTemplateVersions(ListProvisioningTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListRoleAliases operation
        ///</summary>
        IListRoleAliasesPaginator ListRoleAliases(ListRoleAliasesRequest request);

        /// <summary>
        /// Paginator for ListScheduledAudits operation
        ///</summary>
        IListScheduledAuditsPaginator ListScheduledAudits(ListScheduledAuditsRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfiles operation
        ///</summary>
        IListSecurityProfilesPaginator ListSecurityProfiles(ListSecurityProfilesRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfilesForTarget operation
        ///</summary>
        IListSecurityProfilesForTargetPaginator ListSecurityProfilesForTarget(ListSecurityProfilesForTargetRequest request);

        /// <summary>
        /// Paginator for ListStreams operation
        ///</summary>
        IListStreamsPaginator ListStreams(ListStreamsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTargetsForPolicy operation
        ///</summary>
        IListTargetsForPolicyPaginator ListTargetsForPolicy(ListTargetsForPolicyRequest request);

        /// <summary>
        /// Paginator for ListTargetsForSecurityProfile operation
        ///</summary>
        IListTargetsForSecurityProfilePaginator ListTargetsForSecurityProfile(ListTargetsForSecurityProfileRequest request);

        /// <summary>
        /// Paginator for ListThingGroups operation
        ///</summary>
        IListThingGroupsPaginator ListThingGroups(ListThingGroupsRequest request);

        /// <summary>
        /// Paginator for ListThingGroupsForThing operation
        ///</summary>
        IListThingGroupsForThingPaginator ListThingGroupsForThing(ListThingGroupsForThingRequest request);

        /// <summary>
        /// Paginator for ListThingPrincipals operation
        ///</summary>
        IListThingPrincipalsPaginator ListThingPrincipals(ListThingPrincipalsRequest request);

        /// <summary>
        /// Paginator for ListThingRegistrationTaskReports operation
        ///</summary>
        IListThingRegistrationTaskReportsPaginator ListThingRegistrationTaskReports(ListThingRegistrationTaskReportsRequest request);

        /// <summary>
        /// Paginator for ListThingRegistrationTasks operation
        ///</summary>
        IListThingRegistrationTasksPaginator ListThingRegistrationTasks(ListThingRegistrationTasksRequest request);

        /// <summary>
        /// Paginator for ListThingsInBillingGroup operation
        ///</summary>
        IListThingsInBillingGroupPaginator ListThingsInBillingGroup(ListThingsInBillingGroupRequest request);

        /// <summary>
        /// Paginator for ListThingsInThingGroup operation
        ///</summary>
        IListThingsInThingGroupPaginator ListThingsInThingGroup(ListThingsInThingGroupRequest request);

        /// <summary>
        /// Paginator for ListThingTypes operation
        ///</summary>
        IListThingTypesPaginator ListThingTypes(ListThingTypesRequest request);

        /// <summary>
        /// Paginator for ListTopicRuleDestinations operation
        ///</summary>
        IListTopicRuleDestinationsPaginator ListTopicRuleDestinations(ListTopicRuleDestinationsRequest request);

        /// <summary>
        /// Paginator for ListV2LoggingLevels operation
        ///</summary>
        IListV2LoggingLevelsPaginator ListV2LoggingLevels(ListV2LoggingLevelsRequest request);

        /// <summary>
        /// Paginator for ListViolationEvents operation
        ///</summary>
        IListViolationEventsPaginator ListViolationEvents(ListViolationEventsRequest request);
    }
}
#endif