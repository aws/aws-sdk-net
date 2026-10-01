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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Paginators for the QuickSight service
    /// </summary>
    public interface IQuickSightPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeFolderPermissions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeFolderPermissionsPaginator DescribeFolderPermissions(DescribeFolderPermissionsRequest request);

        /// <summary>
        /// Paginator for DescribeFolderResolvedPermissions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeFolderResolvedPermissionsPaginator DescribeFolderResolvedPermissions(DescribeFolderResolvedPermissionsRequest request);

        /// <summary>
        /// Paginator for ListActionConnectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListActionConnectorsPaginator ListActionConnectors(ListActionConnectorsRequest request);

        /// <summary>
        /// Paginator for ListAnalyses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAnalysesPaginator ListAnalyses(ListAnalysesRequest request);

        /// <summary>
        /// Paginator for ListApprovalPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApprovalPoliciesPaginator ListApprovalPolicies(ListApprovalPoliciesRequest request);

        /// <summary>
        /// Paginator for ListApps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAppsPaginator ListApps(ListAppsRequest request);

        /// <summary>
        /// Paginator for ListAssetBundleExportJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetBundleExportJobsPaginator ListAssetBundleExportJobs(ListAssetBundleExportJobsRequest request);

        /// <summary>
        /// Paginator for ListAssetBundleImportJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetBundleImportJobsPaginator ListAssetBundleImportJobs(ListAssetBundleImportJobsRequest request);

        /// <summary>
        /// Paginator for ListBrands operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBrandsPaginator ListBrands(ListBrandsRequest request);

        /// <summary>
        /// Paginator for ListCustomPermissions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCustomPermissionsPaginator ListCustomPermissions(ListCustomPermissionsRequest request);

        /// <summary>
        /// Paginator for ListDashboardVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDashboardVersionsPaginator ListDashboardVersions(ListDashboardVersionsRequest request);

        /// <summary>
        /// Paginator for ListDashboards operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDashboardsPaginator ListDashboards(ListDashboardsRequest request);

        /// <summary>
        /// Paginator for ListDataSets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSetsPaginator ListDataSets(ListDataSetsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListDlpSettings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDlpSettingsPaginator ListDlpSettings(ListDlpSettingsRequest request);

        /// <summary>
        /// Paginator for ListFlows operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFlowsPaginator ListFlows(ListFlowsRequest request);

        /// <summary>
        /// Paginator for ListFolderMembers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFolderMembersPaginator ListFolderMembers(ListFolderMembersRequest request);

        /// <summary>
        /// Paginator for ListFolders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFoldersPaginator ListFolders(ListFoldersRequest request);

        /// <summary>
        /// Paginator for ListFoldersForResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFoldersForResourcePaginator ListFoldersForResource(ListFoldersForResourceRequest request);

        /// <summary>
        /// Paginator for ListGroupMemberships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGroupMembershipsPaginator ListGroupMemberships(ListGroupMembershipsRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListIAMPolicyAssignments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIAMPolicyAssignmentsPaginator ListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request);

        /// <summary>
        /// Paginator for ListIAMPolicyAssignmentsForUser operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIAMPolicyAssignmentsForUserPaginator ListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request);

        /// <summary>
        /// Paginator for ListIngestions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIngestionsPaginator ListIngestions(ListIngestionsRequest request);

        /// <summary>
        /// Paginator for ListKnowledgeBases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListKnowledgeBasesPaginator ListKnowledgeBases(ListKnowledgeBasesRequest request);

        /// <summary>
        /// Paginator for ListLimitsProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLimitsProfilesPaginator ListLimitsProfiles(ListLimitsProfilesRequest request);

        /// <summary>
        /// Paginator for ListNamespaces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNamespacesPaginator ListNamespaces(ListNamespacesRequest request);

        /// <summary>
        /// Paginator for ListOAuthClientApplications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOAuthClientApplicationsPaginator ListOAuthClientApplications(ListOAuthClientApplicationsRequest request);

        /// <summary>
        /// Paginator for ListRoleMemberships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRoleMembershipsPaginator ListRoleMemberships(ListRoleMembershipsRequest request);

        /// <summary>
        /// Paginator for ListTemplateAliases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTemplateAliasesPaginator ListTemplateAliases(ListTemplateAliasesRequest request);

        /// <summary>
        /// Paginator for ListTemplateVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTemplateVersionsPaginator ListTemplateVersions(ListTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTemplatesPaginator ListTemplates(ListTemplatesRequest request);

        /// <summary>
        /// Paginator for ListThemeVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListThemeVersionsPaginator ListThemeVersions(ListThemeVersionsRequest request);

        /// <summary>
        /// Paginator for ListThemes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListThemesPaginator ListThemes(ListThemesRequest request);

        /// <summary>
        /// Paginator for ListTopics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTopicsPaginator ListTopics(ListTopicsRequest request);

        /// <summary>
        /// Paginator for ListTopicsV2 operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTopicsV2Paginator ListTopicsV2(ListTopicsV2Request request);

        /// <summary>
        /// Paginator for ListUserGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUserGroupsPaginator ListUserGroups(ListUserGroupsRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListVPCConnections operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListVPCConnectionsPaginator ListVPCConnections(ListVPCConnectionsRequest request);

        /// <summary>
        /// Paginator for SearchActionConnectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchActionConnectorsPaginator SearchActionConnectors(SearchActionConnectorsRequest request);

        /// <summary>
        /// Paginator for SearchAnalyses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchAnalysesPaginator SearchAnalyses(SearchAnalysesRequest request);

        /// <summary>
        /// Paginator for SearchApps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchAppsPaginator SearchApps(SearchAppsRequest request);

        /// <summary>
        /// Paginator for SearchDashboards operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchDashboardsPaginator SearchDashboards(SearchDashboardsRequest request);

        /// <summary>
        /// Paginator for SearchDataSets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchDataSetsPaginator SearchDataSets(SearchDataSetsRequest request);

        /// <summary>
        /// Paginator for SearchDataSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchDataSourcesPaginator SearchDataSources(SearchDataSourcesRequest request);

        /// <summary>
        /// Paginator for SearchFlows operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchFlowsPaginator SearchFlows(SearchFlowsRequest request);

        /// <summary>
        /// Paginator for SearchFolders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchFoldersPaginator SearchFolders(SearchFoldersRequest request);

        /// <summary>
        /// Paginator for SearchGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchGroupsPaginator SearchGroups(SearchGroupsRequest request);

        /// <summary>
        /// Paginator for SearchKnowledgeBases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchKnowledgeBasesPaginator SearchKnowledgeBases(SearchKnowledgeBasesRequest request);

        /// <summary>
        /// Paginator for SearchTopics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchTopicsPaginator SearchTopics(SearchTopicsRequest request);

        /// <summary>
        /// Paginator for SearchTopicsV2 operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchTopicsV2Paginator SearchTopicsV2(SearchTopicsV2Request request);
    }
}
