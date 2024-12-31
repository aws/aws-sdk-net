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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Paginators for the QuickSight service
    ///</summary>
    public class QuickSightPaginatorFactory : IQuickSightPaginatorFactory
    {
        private readonly IAmazonQuickSight client;

        internal QuickSightPaginatorFactory(IAmazonQuickSight client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeFolderPermissions operation
        ///</summary>
        public IDescribeFolderPermissionsPaginator DescribeFolderPermissions(DescribeFolderPermissionsRequest request) 
        {
            return new DescribeFolderPermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFolderResolvedPermissions operation
        ///</summary>
        public IDescribeFolderResolvedPermissionsPaginator DescribeFolderResolvedPermissions(DescribeFolderResolvedPermissionsRequest request) 
        {
            return new DescribeFolderResolvedPermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnalyses operation
        ///</summary>
        public IListAnalysesPaginator ListAnalyses(ListAnalysesRequest request) 
        {
            return new ListAnalysesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssetBundleExportJobs operation
        ///</summary>
        public IListAssetBundleExportJobsPaginator ListAssetBundleExportJobs(ListAssetBundleExportJobsRequest request) 
        {
            return new ListAssetBundleExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssetBundleImportJobs operation
        ///</summary>
        public IListAssetBundleImportJobsPaginator ListAssetBundleImportJobs(ListAssetBundleImportJobsRequest request) 
        {
            return new ListAssetBundleImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBrands operation
        ///</summary>
        public IListBrandsPaginator ListBrands(ListBrandsRequest request) 
        {
            return new ListBrandsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomPermissions operation
        ///</summary>
        public IListCustomPermissionsPaginator ListCustomPermissions(ListCustomPermissionsRequest request) 
        {
            return new ListCustomPermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDashboards operation
        ///</summary>
        public IListDashboardsPaginator ListDashboards(ListDashboardsRequest request) 
        {
            return new ListDashboardsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDashboardVersions operation
        ///</summary>
        public IListDashboardVersionsPaginator ListDashboardVersions(ListDashboardVersionsRequest request) 
        {
            return new ListDashboardVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSets operation
        ///</summary>
        public IListDataSetsPaginator ListDataSets(ListDataSetsRequest request) 
        {
            return new ListDataSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        public IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request) 
        {
            return new ListDataSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFolderMembers operation
        ///</summary>
        public IListFolderMembersPaginator ListFolderMembers(ListFolderMembersRequest request) 
        {
            return new ListFolderMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFolders operation
        ///</summary>
        public IListFoldersPaginator ListFolders(ListFoldersRequest request) 
        {
            return new ListFoldersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFoldersForResource operation
        ///</summary>
        public IListFoldersForResourcePaginator ListFoldersForResource(ListFoldersForResourceRequest request) 
        {
            return new ListFoldersForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroupMemberships operation
        ///</summary>
        public IListGroupMembershipsPaginator ListGroupMemberships(ListGroupMembershipsRequest request) 
        {
            return new ListGroupMembershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        public IListGroupsPaginator ListGroups(ListGroupsRequest request) 
        {
            return new ListGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIAMPolicyAssignments operation
        ///</summary>
        public IListIAMPolicyAssignmentsPaginator ListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request) 
        {
            return new ListIAMPolicyAssignmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIAMPolicyAssignmentsForUser operation
        ///</summary>
        public IListIAMPolicyAssignmentsForUserPaginator ListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request) 
        {
            return new ListIAMPolicyAssignmentsForUserPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIngestions operation
        ///</summary>
        public IListIngestionsPaginator ListIngestions(ListIngestionsRequest request) 
        {
            return new ListIngestionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNamespaces operation
        ///</summary>
        public IListNamespacesPaginator ListNamespaces(ListNamespacesRequest request) 
        {
            return new ListNamespacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoleMemberships operation
        ///</summary>
        public IListRoleMembershipsPaginator ListRoleMemberships(ListRoleMembershipsRequest request) 
        {
            return new ListRoleMembershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplateAliases operation
        ///</summary>
        public IListTemplateAliasesPaginator ListTemplateAliases(ListTemplateAliasesRequest request) 
        {
            return new ListTemplateAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplates operation
        ///</summary>
        public IListTemplatesPaginator ListTemplates(ListTemplatesRequest request) 
        {
            return new ListTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplateVersions operation
        ///</summary>
        public IListTemplateVersionsPaginator ListTemplateVersions(ListTemplateVersionsRequest request) 
        {
            return new ListTemplateVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThemes operation
        ///</summary>
        public IListThemesPaginator ListThemes(ListThemesRequest request) 
        {
            return new ListThemesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThemeVersions operation
        ///</summary>
        public IListThemeVersionsPaginator ListThemeVersions(ListThemeVersionsRequest request) 
        {
            return new ListThemeVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTopics operation
        ///</summary>
        public IListTopicsPaginator ListTopics(ListTopicsRequest request) 
        {
            return new ListTopicsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserGroups operation
        ///</summary>
        public IListUserGroupsPaginator ListUserGroups(ListUserGroupsRequest request) 
        {
            return new ListUserGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVPCConnections operation
        ///</summary>
        public IListVPCConnectionsPaginator ListVPCConnections(ListVPCConnectionsRequest request) 
        {
            return new ListVPCConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchAnalyses operation
        ///</summary>
        public ISearchAnalysesPaginator SearchAnalyses(SearchAnalysesRequest request) 
        {
            return new SearchAnalysesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchDashboards operation
        ///</summary>
        public ISearchDashboardsPaginator SearchDashboards(SearchDashboardsRequest request) 
        {
            return new SearchDashboardsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchDataSets operation
        ///</summary>
        public ISearchDataSetsPaginator SearchDataSets(SearchDataSetsRequest request) 
        {
            return new SearchDataSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchDataSources operation
        ///</summary>
        public ISearchDataSourcesPaginator SearchDataSources(SearchDataSourcesRequest request) 
        {
            return new SearchDataSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchFolders operation
        ///</summary>
        public ISearchFoldersPaginator SearchFolders(SearchFoldersRequest request) 
        {
            return new SearchFoldersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchGroups operation
        ///</summary>
        public ISearchGroupsPaginator SearchGroups(SearchGroupsRequest request) 
        {
            return new SearchGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchTopics operation
        ///</summary>
        public ISearchTopicsPaginator SearchTopics(SearchTopicsRequest request) 
        {
            return new SearchTopicsPaginator(this.client, request);
        }
    }
}