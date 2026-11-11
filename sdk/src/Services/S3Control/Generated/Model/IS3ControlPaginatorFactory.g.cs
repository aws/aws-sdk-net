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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Paginators for the S3Control service
    /// </summary>
    public interface IS3ControlPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAccessGrants operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessGrantsPaginator ListAccessGrants(ListAccessGrantsRequest request);

        /// <summary>
        /// Paginator for ListAccessGrantsInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessGrantsInstancesPaginator ListAccessGrantsInstances(ListAccessGrantsInstancesRequest request);

        /// <summary>
        /// Paginator for ListAccessGrantsLocations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessGrantsLocationsPaginator ListAccessGrantsLocations(ListAccessGrantsLocationsRequest request);

        /// <summary>
        /// Paginator for ListAccessPoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessPointsPaginator ListAccessPoints(ListAccessPointsRequest request);

        /// <summary>
        /// Paginator for ListAccessPointsForDirectoryBuckets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessPointsForDirectoryBucketsPaginator ListAccessPointsForDirectoryBuckets(ListAccessPointsForDirectoryBucketsRequest request);

        /// <summary>
        /// Paginator for ListAccessPointsForObjectLambda operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessPointsForObjectLambdaPaginator ListAccessPointsForObjectLambda(ListAccessPointsForObjectLambdaRequest request);

        /// <summary>
        /// Paginator for ListCallerAccessGrants operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCallerAccessGrantsPaginator ListCallerAccessGrants(ListCallerAccessGrantsRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListMultiRegionAccessPoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMultiRegionAccessPointsPaginator ListMultiRegionAccessPoints(ListMultiRegionAccessPointsRequest request);

        /// <summary>
        /// Paginator for ListRegionalBuckets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRegionalBucketsPaginator ListRegionalBuckets(ListRegionalBucketsRequest request);

        /// <summary>
        /// Paginator for ListStorageLensConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListStorageLensConfigurationsPaginator ListStorageLensConfigurations(ListStorageLensConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListStorageLensGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListStorageLensGroupsPaginator ListStorageLensGroups(ListStorageLensGroupsRequest request);
    }
}
