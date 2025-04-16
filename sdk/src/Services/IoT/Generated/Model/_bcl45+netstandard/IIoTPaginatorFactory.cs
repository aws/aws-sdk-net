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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetBehaviorModelTrainingSummariesPaginator GetBehaviorModelTrainingSummaries(GetBehaviorModelTrainingSummariesRequest request);

        /// <summary>
        /// Paginator for ListActiveViolations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListActiveViolationsPaginator ListActiveViolations(ListActiveViolationsRequest request);

        /// <summary>
        /// Paginator for ListAttachedPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListAttachedPoliciesPaginator ListAttachedPolicies(ListAttachedPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAuditFindings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAuditFindingsPaginator ListAuditFindings(ListAuditFindingsRequest request);

        /// <summary>
        /// Paginator for ListAuditMitigationActionsExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAuditMitigationActionsExecutionsPaginator ListAuditMitigationActionsExecutions(ListAuditMitigationActionsExecutionsRequest request);

        /// <summary>
        /// Paginator for ListAuditMitigationActionsTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAuditMitigationActionsTasksPaginator ListAuditMitigationActionsTasks(ListAuditMitigationActionsTasksRequest request);

        /// <summary>
        /// Paginator for ListAuditSuppressions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAuditSuppressionsPaginator ListAuditSuppressions(ListAuditSuppressionsRequest request);

        /// <summary>
        /// Paginator for ListAuditTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAuditTasksPaginator ListAuditTasks(ListAuditTasksRequest request);

        /// <summary>
        /// Paginator for ListAuthorizers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListAuthorizersPaginator ListAuthorizers(ListAuthorizersRequest request);

        /// <summary>
        /// Paginator for ListBillingGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillingGroupsPaginator ListBillingGroups(ListBillingGroupsRequest request);

        /// <summary>
        /// Paginator for ListCACertificates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListCACertificatesPaginator ListCACertificates(ListCACertificatesRequest request);

        /// <summary>
        /// Paginator for ListCertificates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListCertificatesPaginator ListCertificates(ListCertificatesRequest request);

        /// <summary>
        /// Paginator for ListCertificatesByCA operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListCertificatesByCAPaginator ListCertificatesByCA(ListCertificatesByCARequest request);

        /// <summary>
        /// Paginator for ListCommandExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCommandExecutionsPaginator ListCommandExecutions(ListCommandExecutionsRequest request);

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
        /// Paginator for ListCustomMetrics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomMetricsPaginator ListCustomMetrics(ListCustomMetricsRequest request);

        /// <summary>
        /// Paginator for ListDetectMitigationActionsExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDetectMitigationActionsExecutionsPaginator ListDetectMitigationActionsExecutions(ListDetectMitigationActionsExecutionsRequest request);

        /// <summary>
        /// Paginator for ListDetectMitigationActionsTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDetectMitigationActionsTasksPaginator ListDetectMitigationActionsTasks(ListDetectMitigationActionsTasksRequest request);

        /// <summary>
        /// Paginator for ListDimensions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDimensionsPaginator ListDimensions(ListDimensionsRequest request);

        /// <summary>
        /// Paginator for ListDomainConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListDomainConfigurationsPaginator ListDomainConfigurations(ListDomainConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListFleetMetrics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFleetMetricsPaginator ListFleetMetrics(ListFleetMetricsRequest request);

        /// <summary>
        /// Paginator for ListIndices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIndicesPaginator ListIndices(ListIndicesRequest request);

        /// <summary>
        /// Paginator for ListJobExecutionsForJob operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJobExecutionsForJobPaginator ListJobExecutionsForJob(ListJobExecutionsForJobRequest request);

        /// <summary>
        /// Paginator for ListJobExecutionsForThing operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJobExecutionsForThingPaginator ListJobExecutionsForThing(ListJobExecutionsForThingRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListJobTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJobTemplatesPaginator ListJobTemplates(ListJobTemplatesRequest request);

        /// <summary>
        /// Paginator for ListManagedJobTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListManagedJobTemplatesPaginator ListManagedJobTemplates(ListManagedJobTemplatesRequest request);

        /// <summary>
        /// Paginator for ListMetricValues operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMetricValuesPaginator ListMetricValues(ListMetricValuesRequest request);

        /// <summary>
        /// Paginator for ListMitigationActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMitigationActionsPaginator ListMitigationActions(ListMitigationActionsRequest request);

        /// <summary>
        /// Paginator for ListOTAUpdates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOTAUpdatesPaginator ListOTAUpdates(ListOTAUpdatesRequest request);

        /// <summary>
        /// Paginator for ListOutgoingCertificates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListOutgoingCertificatesPaginator ListOutgoingCertificates(ListOutgoingCertificatesRequest request);

        /// <summary>
        /// Paginator for ListPackages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPackagesPaginator ListPackages(ListPackagesRequest request);

        /// <summary>
        /// Paginator for ListPackageVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPackageVersionsPaginator ListPackageVersions(ListPackageVersionsRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPolicyPrincipals operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListPolicyPrincipalsPaginator ListPolicyPrincipals(ListPolicyPrincipalsRequest request);

        /// <summary>
        /// Paginator for ListPrincipalPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListPrincipalPoliciesPaginator ListPrincipalPolicies(ListPrincipalPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPrincipalThingsV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPrincipalThingsV2Paginator ListPrincipalThingsV2(ListPrincipalThingsV2Request request);

        /// <summary>
        /// Paginator for ListProvisioningTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProvisioningTemplatesPaginator ListProvisioningTemplates(ListProvisioningTemplatesRequest request);

        /// <summary>
        /// Paginator for ListProvisioningTemplateVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProvisioningTemplateVersionsPaginator ListProvisioningTemplateVersions(ListProvisioningTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListRelatedResourcesForAuditFinding operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRelatedResourcesForAuditFindingPaginator ListRelatedResourcesForAuditFinding(ListRelatedResourcesForAuditFindingRequest request);

        /// <summary>
        /// Paginator for ListRoleAliases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListRoleAliasesPaginator ListRoleAliases(ListRoleAliasesRequest request);

        /// <summary>
        /// Paginator for ListSbomValidationResults operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSbomValidationResultsPaginator ListSbomValidationResults(ListSbomValidationResultsRequest request);

        /// <summary>
        /// Paginator for ListScheduledAudits operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListScheduledAuditsPaginator ListScheduledAudits(ListScheduledAuditsRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSecurityProfilesPaginator ListSecurityProfiles(ListSecurityProfilesRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfilesForTarget operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSecurityProfilesForTargetPaginator ListSecurityProfilesForTarget(ListSecurityProfilesForTargetRequest request);

        /// <summary>
        /// Paginator for ListStreams operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStreamsPaginator ListStreams(ListStreamsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTargetsForPolicy operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IListTargetsForPolicyPaginator ListTargetsForPolicy(ListTargetsForPolicyRequest request);

        /// <summary>
        /// Paginator for ListTargetsForSecurityProfile operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTargetsForSecurityProfilePaginator ListTargetsForSecurityProfile(ListTargetsForSecurityProfileRequest request);

        /// <summary>
        /// Paginator for ListThingGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThingGroupsPaginator ListThingGroups(ListThingGroupsRequest request);

        /// <summary>
        /// Paginator for ListThingGroupsForThing operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThingGroupsForThingPaginator ListThingGroupsForThing(ListThingGroupsForThingRequest request);

        /// <summary>
        /// Paginator for ListThingPrincipals operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThingPrincipalsPaginator ListThingPrincipals(ListThingPrincipalsRequest request);

        /// <summary>
        /// Paginator for ListThingPrincipalsV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThingPrincipalsV2Paginator ListThingPrincipalsV2(ListThingPrincipalsV2Request request);

        /// <summary>
        /// Paginator for ListThingRegistrationTaskReports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThingRegistrationTaskReportsPaginator ListThingRegistrationTaskReports(ListThingRegistrationTaskReportsRequest request);

        /// <summary>
        /// Paginator for ListThingRegistrationTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThingRegistrationTasksPaginator ListThingRegistrationTasks(ListThingRegistrationTasksRequest request);

        /// <summary>
        /// Paginator for ListThingsInBillingGroup operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThingsInBillingGroupPaginator ListThingsInBillingGroup(ListThingsInBillingGroupRequest request);

        /// <summary>
        /// Paginator for ListThingsInThingGroup operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThingsInThingGroupPaginator ListThingsInThingGroup(ListThingsInThingGroupRequest request);

        /// <summary>
        /// Paginator for ListThingTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThingTypesPaginator ListThingTypes(ListThingTypesRequest request);

        /// <summary>
        /// Paginator for ListTopicRuleDestinations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTopicRuleDestinationsPaginator ListTopicRuleDestinations(ListTopicRuleDestinationsRequest request);

        /// <summary>
        /// Paginator for ListV2LoggingLevels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListV2LoggingLevelsPaginator ListV2LoggingLevels(ListV2LoggingLevelsRequest request);

        /// <summary>
        /// Paginator for ListViolationEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListViolationEventsPaginator ListViolationEvents(ListViolationEventsRequest request);
    }
}