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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Paginators for the HealthLake service
    ///</summary>
    public class HealthLakePaginatorFactory : IHealthLakePaginatorFactory
    {
        private readonly IAmazonHealthLake client;

        internal HealthLakePaginatorFactory(IAmazonHealthLake client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListFHIRDatastores operation
        ///</summary>
        public IListFHIRDatastoresPaginator ListFHIRDatastores(ListFHIRDatastoresRequest request) 
        {
            return new ListFHIRDatastoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFHIRExportJobs operation
        ///</summary>
        public IListFHIRExportJobsPaginator ListFHIRExportJobs(ListFHIRExportJobsRequest request) 
        {
            return new ListFHIRExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFHIRImportJobs operation
        ///</summary>
        public IListFHIRImportJobsPaginator ListFHIRImportJobs(ListFHIRImportJobsRequest request) 
        {
            return new ListFHIRImportJobsPaginator(this.client, request);
        }
    }
}