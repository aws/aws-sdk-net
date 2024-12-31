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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Paginators for the IoT service
    ///</summary>
    public class IoTPaginatorFactory : IIoTPaginatorFactory
    {
        private readonly IAmazonIoT client;

        internal IoTPaginatorFactory(IAmazonIoT client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetBehaviorModelTrainingSummaries operation
        ///</summary>
        public IGetBehaviorModelTrainingSummariesPaginator GetBehaviorModelTrainingSummaries(GetBehaviorModelTrainingSummariesRequest request) 
        {
            return new GetBehaviorModelTrainingSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListActiveViolations operation
        ///</summary>
        public IListActiveViolationsPaginator ListActiveViolations(ListActiveViolationsRequest request) 
        {
            return new ListActiveViolationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAttachedPolicies operation
        ///</summary>
        public IListAttachedPoliciesPaginator ListAttachedPolicies(ListAttachedPoliciesRequest request) 
        {
            return new ListAttachedPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAuditFindings operation
        ///</summary>
        public IListAuditFindingsPaginator ListAuditFindings(ListAuditFindingsRequest request) 
        {
            return new ListAuditFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAuditMitigationActionsExecutions operation
        ///</summary>
        public IListAuditMitigationActionsExecutionsPaginator ListAuditMitigationActionsExecutions(ListAuditMitigationActionsExecutionsRequest request) 
        {
            return new ListAuditMitigationActionsExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAuditMitigationActionsTasks operation
        ///</summary>
        public IListAuditMitigationActionsTasksPaginator ListAuditMitigationActionsTasks(ListAuditMitigationActionsTasksRequest request) 
        {
            return new ListAuditMitigationActionsTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAuditSuppressions operation
        ///</summary>
        public IListAuditSuppressionsPaginator ListAuditSuppressions(ListAuditSuppressionsRequest request) 
        {
            return new ListAuditSuppressionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAuditTasks operation
        ///</summary>
        public IListAuditTasksPaginator ListAuditTasks(ListAuditTasksRequest request) 
        {
            return new ListAuditTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAuthorizers operation
        ///</summary>
        public IListAuthorizersPaginator ListAuthorizers(ListAuthorizersRequest request) 
        {
            return new ListAuthorizersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBillingGroups operation
        ///</summary>
        public IListBillingGroupsPaginator ListBillingGroups(ListBillingGroupsRequest request) 
        {
            return new ListBillingGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCACertificates operation
        ///</summary>
        public IListCACertificatesPaginator ListCACertificates(ListCACertificatesRequest request) 
        {
            return new ListCACertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCertificates operation
        ///</summary>
        public IListCertificatesPaginator ListCertificates(ListCertificatesRequest request) 
        {
            return new ListCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCertificatesByCA operation
        ///</summary>
        public IListCertificatesByCAPaginator ListCertificatesByCA(ListCertificatesByCARequest request) 
        {
            return new ListCertificatesByCAPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCommandExecutions operation
        ///</summary>
        public IListCommandExecutionsPaginator ListCommandExecutions(ListCommandExecutionsRequest request) 
        {
            return new ListCommandExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCommands operation
        ///</summary>
        public IListCommandsPaginator ListCommands(ListCommandsRequest request) 
        {
            return new ListCommandsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomMetrics operation
        ///</summary>
        public IListCustomMetricsPaginator ListCustomMetrics(ListCustomMetricsRequest request) 
        {
            return new ListCustomMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDetectMitigationActionsExecutions operation
        ///</summary>
        public IListDetectMitigationActionsExecutionsPaginator ListDetectMitigationActionsExecutions(ListDetectMitigationActionsExecutionsRequest request) 
        {
            return new ListDetectMitigationActionsExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDetectMitigationActionsTasks operation
        ///</summary>
        public IListDetectMitigationActionsTasksPaginator ListDetectMitigationActionsTasks(ListDetectMitigationActionsTasksRequest request) 
        {
            return new ListDetectMitigationActionsTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDimensions operation
        ///</summary>
        public IListDimensionsPaginator ListDimensions(ListDimensionsRequest request) 
        {
            return new ListDimensionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomainConfigurations operation
        ///</summary>
        public IListDomainConfigurationsPaginator ListDomainConfigurations(ListDomainConfigurationsRequest request) 
        {
            return new ListDomainConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFleetMetrics operation
        ///</summary>
        public IListFleetMetricsPaginator ListFleetMetrics(ListFleetMetricsRequest request) 
        {
            return new ListFleetMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIndices operation
        ///</summary>
        public IListIndicesPaginator ListIndices(ListIndicesRequest request) 
        {
            return new ListIndicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobExecutionsForJob operation
        ///</summary>
        public IListJobExecutionsForJobPaginator ListJobExecutionsForJob(ListJobExecutionsForJobRequest request) 
        {
            return new ListJobExecutionsForJobPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobExecutionsForThing operation
        ///</summary>
        public IListJobExecutionsForThingPaginator ListJobExecutionsForThing(ListJobExecutionsForThingRequest request) 
        {
            return new ListJobExecutionsForThingPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobTemplates operation
        ///</summary>
        public IListJobTemplatesPaginator ListJobTemplates(ListJobTemplatesRequest request) 
        {
            return new ListJobTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedJobTemplates operation
        ///</summary>
        public IListManagedJobTemplatesPaginator ListManagedJobTemplates(ListManagedJobTemplatesRequest request) 
        {
            return new ListManagedJobTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMetricValues operation
        ///</summary>
        public IListMetricValuesPaginator ListMetricValues(ListMetricValuesRequest request) 
        {
            return new ListMetricValuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMitigationActions operation
        ///</summary>
        public IListMitigationActionsPaginator ListMitigationActions(ListMitigationActionsRequest request) 
        {
            return new ListMitigationActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOTAUpdates operation
        ///</summary>
        public IListOTAUpdatesPaginator ListOTAUpdates(ListOTAUpdatesRequest request) 
        {
            return new ListOTAUpdatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOutgoingCertificates operation
        ///</summary>
        public IListOutgoingCertificatesPaginator ListOutgoingCertificates(ListOutgoingCertificatesRequest request) 
        {
            return new ListOutgoingCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackages operation
        ///</summary>
        public IListPackagesPaginator ListPackages(ListPackagesRequest request) 
        {
            return new ListPackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackageVersions operation
        ///</summary>
        public IListPackageVersionsPaginator ListPackageVersions(ListPackageVersionsRequest request) 
        {
            return new ListPackageVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        public IListPoliciesPaginator ListPolicies(ListPoliciesRequest request) 
        {
            return new ListPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicyPrincipals operation
        ///</summary>
        public IListPolicyPrincipalsPaginator ListPolicyPrincipals(ListPolicyPrincipalsRequest request) 
        {
            return new ListPolicyPrincipalsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPrincipalPolicies operation
        ///</summary>
        public IListPrincipalPoliciesPaginator ListPrincipalPolicies(ListPrincipalPoliciesRequest request) 
        {
            return new ListPrincipalPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPrincipalThingsV2 operation
        ///</summary>
        public IListPrincipalThingsV2Paginator ListPrincipalThingsV2(ListPrincipalThingsV2Request request) 
        {
            return new ListPrincipalThingsV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProvisioningTemplates operation
        ///</summary>
        public IListProvisioningTemplatesPaginator ListProvisioningTemplates(ListProvisioningTemplatesRequest request) 
        {
            return new ListProvisioningTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProvisioningTemplateVersions operation
        ///</summary>
        public IListProvisioningTemplateVersionsPaginator ListProvisioningTemplateVersions(ListProvisioningTemplateVersionsRequest request) 
        {
            return new ListProvisioningTemplateVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRelatedResourcesForAuditFinding operation
        ///</summary>
        public IListRelatedResourcesForAuditFindingPaginator ListRelatedResourcesForAuditFinding(ListRelatedResourcesForAuditFindingRequest request) 
        {
            return new ListRelatedResourcesForAuditFindingPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoleAliases operation
        ///</summary>
        public IListRoleAliasesPaginator ListRoleAliases(ListRoleAliasesRequest request) 
        {
            return new ListRoleAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSbomValidationResults operation
        ///</summary>
        public IListSbomValidationResultsPaginator ListSbomValidationResults(ListSbomValidationResultsRequest request) 
        {
            return new ListSbomValidationResultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListScheduledAudits operation
        ///</summary>
        public IListScheduledAuditsPaginator ListScheduledAudits(ListScheduledAuditsRequest request) 
        {
            return new ListScheduledAuditsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityProfiles operation
        ///</summary>
        public IListSecurityProfilesPaginator ListSecurityProfiles(ListSecurityProfilesRequest request) 
        {
            return new ListSecurityProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityProfilesForTarget operation
        ///</summary>
        public IListSecurityProfilesForTargetPaginator ListSecurityProfilesForTarget(ListSecurityProfilesForTargetRequest request) 
        {
            return new ListSecurityProfilesForTargetPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreams operation
        ///</summary>
        public IListStreamsPaginator ListStreams(ListStreamsRequest request) 
        {
            return new ListStreamsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTargetsForPolicy operation
        ///</summary>
        public IListTargetsForPolicyPaginator ListTargetsForPolicy(ListTargetsForPolicyRequest request) 
        {
            return new ListTargetsForPolicyPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTargetsForSecurityProfile operation
        ///</summary>
        public IListTargetsForSecurityProfilePaginator ListTargetsForSecurityProfile(ListTargetsForSecurityProfileRequest request) 
        {
            return new ListTargetsForSecurityProfilePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThingGroups operation
        ///</summary>
        public IListThingGroupsPaginator ListThingGroups(ListThingGroupsRequest request) 
        {
            return new ListThingGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThingGroupsForThing operation
        ///</summary>
        public IListThingGroupsForThingPaginator ListThingGroupsForThing(ListThingGroupsForThingRequest request) 
        {
            return new ListThingGroupsForThingPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThingPrincipals operation
        ///</summary>
        public IListThingPrincipalsPaginator ListThingPrincipals(ListThingPrincipalsRequest request) 
        {
            return new ListThingPrincipalsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThingPrincipalsV2 operation
        ///</summary>
        public IListThingPrincipalsV2Paginator ListThingPrincipalsV2(ListThingPrincipalsV2Request request) 
        {
            return new ListThingPrincipalsV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThingRegistrationTaskReports operation
        ///</summary>
        public IListThingRegistrationTaskReportsPaginator ListThingRegistrationTaskReports(ListThingRegistrationTaskReportsRequest request) 
        {
            return new ListThingRegistrationTaskReportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThingRegistrationTasks operation
        ///</summary>
        public IListThingRegistrationTasksPaginator ListThingRegistrationTasks(ListThingRegistrationTasksRequest request) 
        {
            return new ListThingRegistrationTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThingsInBillingGroup operation
        ///</summary>
        public IListThingsInBillingGroupPaginator ListThingsInBillingGroup(ListThingsInBillingGroupRequest request) 
        {
            return new ListThingsInBillingGroupPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThingsInThingGroup operation
        ///</summary>
        public IListThingsInThingGroupPaginator ListThingsInThingGroup(ListThingsInThingGroupRequest request) 
        {
            return new ListThingsInThingGroupPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThingTypes operation
        ///</summary>
        public IListThingTypesPaginator ListThingTypes(ListThingTypesRequest request) 
        {
            return new ListThingTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTopicRuleDestinations operation
        ///</summary>
        public IListTopicRuleDestinationsPaginator ListTopicRuleDestinations(ListTopicRuleDestinationsRequest request) 
        {
            return new ListTopicRuleDestinationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListV2LoggingLevels operation
        ///</summary>
        public IListV2LoggingLevelsPaginator ListV2LoggingLevels(ListV2LoggingLevelsRequest request) 
        {
            return new ListV2LoggingLevelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListViolationEvents operation
        ///</summary>
        public IListViolationEventsPaginator ListViolationEvents(ListViolationEventsRequest request) 
        {
            return new ListViolationEventsPaginator(this.client, request);
        }
    }
}