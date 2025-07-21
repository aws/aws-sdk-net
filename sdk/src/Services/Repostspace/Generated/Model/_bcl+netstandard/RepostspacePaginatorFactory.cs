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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// Paginators for the Repostspace service
    ///</summary>
    public class RepostspacePaginatorFactory : IRepostspacePaginatorFactory
    {
        private readonly IAmazonRepostspace client;

        internal RepostspacePaginatorFactory(IAmazonRepostspace client) 
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
        /// Paginator for ListSpaces operation
        ///</summary>
        public IListSpacesPaginator ListSpaces(ListSpacesRequest request) 
        {
            return new ListSpacesPaginator(this.client, request);
        }
    }
}