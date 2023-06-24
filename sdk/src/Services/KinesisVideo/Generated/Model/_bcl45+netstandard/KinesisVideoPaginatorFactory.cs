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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Paginators for the KinesisVideo service
    ///</summary>
    public class KinesisVideoPaginatorFactory : IKinesisVideoPaginatorFactory
    {
        private readonly IAmazonKinesisVideo client;

        internal KinesisVideoPaginatorFactory(IAmazonKinesisVideo client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeMappedResourceConfiguration operation
        ///</summary>
        public IDescribeMappedResourceConfigurationPaginator DescribeMappedResourceConfiguration(DescribeMappedResourceConfigurationRequest request) 
        {
            return new DescribeMappedResourceConfigurationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSignalingChannels operation
        ///</summary>
        public IListSignalingChannelsPaginator ListSignalingChannels(ListSignalingChannelsRequest request) 
        {
            return new ListSignalingChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreams operation
        ///</summary>
        public IListStreamsPaginator ListStreams(ListStreamsRequest request) 
        {
            return new ListStreamsPaginator(this.client, request);
        }
    }
}