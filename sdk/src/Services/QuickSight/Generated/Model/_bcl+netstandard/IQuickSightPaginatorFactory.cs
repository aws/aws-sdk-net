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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Paginators for the QuickSight service
    ///</summary>
    public interface IQuickSightPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeFolderPermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFolderPermissionsPaginator DescribeFolderPermissions(DescribeFolderPermissionsRequest request);

        /// <summary>
        /// Paginator for DescribeFolderResolvedPermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFolderResolvedPermissionsPaginator DescribeFolderResolvedPermissions(DescribeFolderResolvedPermissionsRequest request);

        /// <summary>
        /// Paginator for ListAnalyses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnalysesPaginator ListAnalyses(ListAnalysesRequest request);

        /// <summary>
        /// Paginator for ListAssetBundleExportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetBundleExportJobsPaginator ListAssetBundleExportJobs(ListAssetBundleExportJobsRequest request);

        /// <summary>
        /// Paginator for ListAssetBundleImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetBundleImportJobsPaginator ListAssetBundleImportJobs(ListAssetBundleImportJobsRequest request);

        /// <summary>
        /// Paginator for ListBrands operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBrandsPaginator ListBrands(ListBrandsRequest request);

        /// <summary>
        /// Paginator for ListCustomPermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomPermissionsPaginator ListCustomPermissions(ListCustomPermissionsRequest request);

        /// <summary>
        /// Paginator for ListDashboards operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDashboardsPaginator ListDashboards(ListDashboardsRequest request);

        /// <summary>
        /// Paginator for ListDashboardVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDashboardVersionsPaginator ListDashboardVersions(ListDashboardVersionsRequest request);

        /// <summary>
        /// Paginator for ListDataSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataSetsPaginator ListDataSets(ListDataSetsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListFolderMembers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFolderMembersPaginator ListFolderMembers(ListFolderMembersRequest request);

        /// <summary>
        /// Paginator for ListFolders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFoldersPaginator ListFolders(ListFoldersRequest request);

        /// <summary>
        /// Paginator for ListFoldersForResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFoldersForResourcePaginator ListFoldersForResource(ListFoldersForResourceRequest request);

        /// <summary>
        /// Paginator for ListGroupMemberships operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGroupMembershipsPaginator ListGroupMemberships(ListGroupMembershipsRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListIAMPolicyAssignments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIAMPolicyAssignmentsPaginator ListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request);

        /// <summary>
        /// Paginator for ListIAMPolicyAssignmentsForUser operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIAMPolicyAssignmentsForUserPaginator ListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request);

        /// <summary>
        /// Paginator for ListIngestions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIngestionsPaginator ListIngestions(ListIngestionsRequest request);

        /// <summary>
        /// Paginator for ListNamespaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNamespacesPaginator ListNamespaces(ListNamespacesRequest request);

        /// <summary>
        /// Paginator for ListRoleMemberships operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRoleMembershipsPaginator ListRoleMemberships(ListRoleMembershipsRequest request);

        /// <summary>
        /// Paginator for ListTemplateAliases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTemplateAliasesPaginator ListTemplateAliases(ListTemplateAliasesRequest request);

        /// <summary>
        /// Paginator for ListTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTemplatesPaginator ListTemplates(ListTemplatesRequest request);

        /// <summary>
        /// Paginator for ListTemplateVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTemplateVersionsPaginator ListTemplateVersions(ListTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListThemes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThemesPaginator ListThemes(ListThemesRequest request);

        /// <summary>
        /// Paginator for ListThemeVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThemeVersionsPaginator ListThemeVersions(ListThemeVersionsRequest request);

        /// <summary>
        /// Paginator for ListTopics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTopicsPaginator ListTopics(ListTopicsRequest request);

        /// <summary>
        /// Paginator for ListUserGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUserGroupsPaginator ListUserGroups(ListUserGroupsRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListVPCConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVPCConnectionsPaginator ListVPCConnections(ListVPCConnectionsRequest request);

        /// <summary>
        /// Paginator for SearchAnalyses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchAnalysesPaginator SearchAnalyses(SearchAnalysesRequest request);

        /// <summary>
        /// Paginator for SearchDashboards operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchDashboardsPaginator SearchDashboards(SearchDashboardsRequest request);

        /// <summary>
        /// Paginator for SearchDataSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchDataSetsPaginator SearchDataSets(SearchDataSetsRequest request);

        /// <summary>
        /// Paginator for SearchDataSources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchDataSourcesPaginator SearchDataSources(SearchDataSourcesRequest request);

        /// <summary>
        /// Paginator for SearchFolders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchFoldersPaginator SearchFolders(SearchFoldersRequest request);

        /// <summary>
        /// Paginator for SearchGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchGroupsPaginator SearchGroups(SearchGroupsRequest request);

        /// <summary>
        /// Paginator for SearchTopics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchTopicsPaginator SearchTopics(SearchTopicsRequest request);
    }
}