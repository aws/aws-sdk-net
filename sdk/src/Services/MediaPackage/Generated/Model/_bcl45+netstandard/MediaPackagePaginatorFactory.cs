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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// Paginators for the MediaPackage service
    ///</summary>
    public class MediaPackagePaginatorFactory : IMediaPackagePaginatorFactory
    {
        private readonly IAmazonMediaPackage client;

        internal MediaPackagePaginatorFactory(IAmazonMediaPackage client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        public IListChannelsPaginator ListChannels(ListChannelsRequest request) 
        {
            return new ListChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHarvestJobs operation
        ///</summary>
        public IListHarvestJobsPaginator ListHarvestJobs(ListHarvestJobsRequest request) 
        {
            return new ListHarvestJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOriginEndpoints operation
        ///</summary>
        public IListOriginEndpointsPaginator ListOriginEndpoints(ListOriginEndpointsRequest request) 
        {
            return new ListOriginEndpointsPaginator(this.client, request);
        }
    }
}
#endif