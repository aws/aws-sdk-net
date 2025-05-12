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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Paginators for the HealthLake service
    ///</summary>
    public interface IHealthLakePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListFHIRDatastores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFHIRDatastoresPaginator ListFHIRDatastores(ListFHIRDatastoresRequest request);

        /// <summary>
        /// Paginator for ListFHIRExportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFHIRExportJobsPaginator ListFHIRExportJobs(ListFHIRExportJobsRequest request);

        /// <summary>
        /// Paginator for ListFHIRImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFHIRImportJobsPaginator ListFHIRImportJobs(ListFHIRImportJobsRequest request);
    }
}