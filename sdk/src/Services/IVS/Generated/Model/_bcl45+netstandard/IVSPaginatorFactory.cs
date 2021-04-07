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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Paginators for the IVS service
    ///</summary>
    public class IVSPaginatorFactory : IIVSPaginatorFactory
    {
        private readonly IAmazonIVS client;

        internal IVSPaginatorFactory(IAmazonIVS client) 
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
        /// Paginator for ListPlaybackKeyPairs operation
        ///</summary>
        public IListPlaybackKeyPairsPaginator ListPlaybackKeyPairs(ListPlaybackKeyPairsRequest request) 
        {
            return new ListPlaybackKeyPairsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecordingConfigurations operation
        ///</summary>
        public IListRecordingConfigurationsPaginator ListRecordingConfigurations(ListRecordingConfigurationsRequest request) 
        {
            return new ListRecordingConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreamKeys operation
        ///</summary>
        public IListStreamKeysPaginator ListStreamKeys(ListStreamKeysRequest request) 
        {
            return new ListStreamKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreams operation
        ///</summary>
        public IListStreamsPaginator ListStreams(ListStreamsRequest request) 
        {
            return new ListStreamsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}