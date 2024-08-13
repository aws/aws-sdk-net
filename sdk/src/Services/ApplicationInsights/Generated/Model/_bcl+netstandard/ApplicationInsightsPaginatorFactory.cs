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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Paginators for the ApplicationInsights service
    ///</summary>
    public class ApplicationInsightsPaginatorFactory : IApplicationInsightsPaginatorFactory
    {
        private readonly IAmazonApplicationInsights client;

        internal ApplicationInsightsPaginatorFactory(IAmazonApplicationInsights client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        public IListComponentsPaginator ListComponents(ListComponentsRequest request) 
        {
            return new ListComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfigurationHistory operation
        ///</summary>
        public IListConfigurationHistoryPaginator ListConfigurationHistory(ListConfigurationHistoryRequest request) 
        {
            return new ListConfigurationHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLogPatterns operation
        ///</summary>
        public IListLogPatternsPaginator ListLogPatterns(ListLogPatternsRequest request) 
        {
            return new ListLogPatternsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLogPatternSets operation
        ///</summary>
        public IListLogPatternSetsPaginator ListLogPatternSets(ListLogPatternSetsRequest request) 
        {
            return new ListLogPatternSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProblems operation
        ///</summary>
        public IListProblemsPaginator ListProblems(ListProblemsRequest request) 
        {
            return new ListProblemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkloads operation
        ///</summary>
        public IListWorkloadsPaginator ListWorkloads(ListWorkloadsRequest request) 
        {
            return new ListWorkloadsPaginator(this.client, request);
        }
    }
}