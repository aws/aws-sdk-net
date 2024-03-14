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
 * Do not modify this file. This file is generated from the s3outposts-2017-07-25.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3Outposts.Model
{
    /// <summary>
    /// Paginators for the S3Outposts service
    ///</summary>
    public class S3OutpostsPaginatorFactory : IS3OutpostsPaginatorFactory
    {
        private readonly IAmazonS3Outposts client;

        internal S3OutpostsPaginatorFactory(IAmazonS3Outposts client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListEndpoints operation
        ///</summary>
        public IListEndpointsPaginator ListEndpoints(ListEndpointsRequest request) 
        {
            return new ListEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOutpostsWithS3 operation
        ///</summary>
        public IListOutpostsWithS3Paginator ListOutpostsWithS3(ListOutpostsWithS3Request request) 
        {
            return new ListOutpostsWithS3Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSharedEndpoints operation
        ///</summary>
        public IListSharedEndpointsPaginator ListSharedEndpoints(ListSharedEndpointsRequest request) 
        {
            return new ListSharedEndpointsPaginator(this.client, request);
        }
    }
}