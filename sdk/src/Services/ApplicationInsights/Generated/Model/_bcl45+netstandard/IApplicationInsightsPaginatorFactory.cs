#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Paginators for the ApplicationInsights service
    ///</summary>
    public interface IApplicationInsightsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        IListComponentsPaginator ListComponents(ListComponentsRequest request);

        /// <summary>
        /// Paginator for ListConfigurationHistory operation
        ///</summary>
        IListConfigurationHistoryPaginator ListConfigurationHistory(ListConfigurationHistoryRequest request);

        /// <summary>
        /// Paginator for ListLogPatterns operation
        ///</summary>
        IListLogPatternsPaginator ListLogPatterns(ListLogPatternsRequest request);

        /// <summary>
        /// Paginator for ListLogPatternSets operation
        ///</summary>
        IListLogPatternSetsPaginator ListLogPatternSets(ListLogPatternSetsRequest request);

        /// <summary>
        /// Paginator for ListProblems operation
        ///</summary>
        IListProblemsPaginator ListProblems(ListProblemsRequest request);
    }
}
#endif