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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Paginators for the MediaPackageV2 service
    ///</summary>
    public class MediaPackageV2PaginatorFactory : IMediaPackageV2PaginatorFactory
    {
        private readonly IAmazonMediaPackageV2 client;

        internal MediaPackageV2PaginatorFactory(IAmazonMediaPackageV2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListChannelGroups operation
        ///</summary>
        public IListChannelGroupsPaginator ListChannelGroups(ListChannelGroupsRequest request) 
        {
            return new ListChannelGroupsPaginator(this.client, request);
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