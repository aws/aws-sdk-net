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
        /// Paginator for ListAnalyses operation
        ///</summary>
        public IListAnalysesPaginator ListAnalyses(ListAnalysesRequest request) 
        {
            return new ListAnalysesPaginator(this.client, request);
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
    }
}