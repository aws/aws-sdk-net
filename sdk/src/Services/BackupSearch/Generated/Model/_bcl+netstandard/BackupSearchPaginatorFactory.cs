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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// Paginators for the BackupSearch service
    ///</summary>
    public partial class BackupSearchPaginatorFactory : IBackupSearchPaginatorFactory
    {
        private readonly IAmazonBackupSearch client;

        internal BackupSearchPaginatorFactory(IAmazonBackupSearch client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListSearchJobBackups operation
        ///</summary>
        public IListSearchJobBackupsPaginator ListSearchJobBackups(ListSearchJobBackupsRequest request) 
        {
            return new ListSearchJobBackupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSearchJobResults operation
        ///</summary>
        public IListSearchJobResultsPaginator ListSearchJobResults(ListSearchJobResultsRequest request) 
        {
            return new ListSearchJobResultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSearchJobs operation
        ///</summary>
        public IListSearchJobsPaginator ListSearchJobs(ListSearchJobsRequest request) 
        {
            return new ListSearchJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSearchResultExportJobs operation
        ///</summary>
        public IListSearchResultExportJobsPaginator ListSearchResultExportJobs(ListSearchResultExportJobsRequest request) 
        {
            return new ListSearchResultExportJobsPaginator(this.client, request);
        }
    }
}