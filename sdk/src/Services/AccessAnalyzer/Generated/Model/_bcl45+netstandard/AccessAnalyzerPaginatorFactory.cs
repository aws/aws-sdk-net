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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Paginators for the AccessAnalyzer service
    ///</summary>
    public class AccessAnalyzerPaginatorFactory : IAccessAnalyzerPaginatorFactory
    {
        private readonly IAmazonAccessAnalyzer client;

        internal AccessAnalyzerPaginatorFactory(IAmazonAccessAnalyzer client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAnalyzedResources operation
        ///</summary>
        public IListAnalyzedResourcesPaginator ListAnalyzedResources(ListAnalyzedResourcesRequest request) 
        {
            return new ListAnalyzedResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnalyzers operation
        ///</summary>
        public IListAnalyzersPaginator ListAnalyzers(ListAnalyzersRequest request) 
        {
            return new ListAnalyzersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListArchiveRules operation
        ///</summary>
        public IListArchiveRulesPaginator ListArchiveRules(ListArchiveRulesRequest request) 
        {
            return new ListArchiveRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        public IListFindingsPaginator ListFindings(ListFindingsRequest request) 
        {
            return new ListFindingsPaginator(this.client, request);
        }
    }
}
#endif