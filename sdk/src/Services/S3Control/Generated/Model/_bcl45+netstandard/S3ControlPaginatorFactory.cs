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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Paginators for the S3Control service
    ///</summary>
    public class S3ControlPaginatorFactory : IS3ControlPaginatorFactory
    {
        private readonly IAmazonS3Control client;

        internal S3ControlPaginatorFactory(IAmazonS3Control client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccessPoints operation
        ///</summary>
        public IListAccessPointsPaginator ListAccessPoints(ListAccessPointsRequest request) 
        {
            return new ListAccessPointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRegionalBuckets operation
        ///</summary>
        public IListRegionalBucketsPaginator ListRegionalBuckets(ListRegionalBucketsRequest request) 
        {
            return new ListRegionalBucketsPaginator(this.client, request);
        }
    }
}
#endif