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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// Paginators for the BackupSearch service
    ///</summary>
    public partial interface IBackupSearchPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListSearchJobBackups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSearchJobBackupsPaginator ListSearchJobBackups(ListSearchJobBackupsRequest request);

        /// <summary>
        /// Paginator for ListSearchJobResults operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSearchJobResultsPaginator ListSearchJobResults(ListSearchJobResultsRequest request);

        /// <summary>
        /// Paginator for ListSearchJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSearchJobsPaginator ListSearchJobs(ListSearchJobsRequest request);

        /// <summary>
        /// Paginator for ListSearchResultExportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSearchResultExportJobsPaginator ListSearchResultExportJobs(ListSearchResultExportJobsRequest request);
    }
}