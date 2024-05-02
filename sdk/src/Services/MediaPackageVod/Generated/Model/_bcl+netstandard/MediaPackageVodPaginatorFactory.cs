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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// Paginators for the MediaPackageVod service
    ///</summary>
    public class MediaPackageVodPaginatorFactory : IMediaPackageVodPaginatorFactory
    {
        private readonly IAmazonMediaPackageVod client;

        internal MediaPackageVodPaginatorFactory(IAmazonMediaPackageVod client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAssets operation
        ///</summary>
        public IListAssetsPaginator ListAssets(ListAssetsRequest request) 
        {
            return new ListAssetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackagingConfigurations operation
        ///</summary>
        public IListPackagingConfigurationsPaginator ListPackagingConfigurations(ListPackagingConfigurationsRequest request) 
        {
            return new ListPackagingConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackagingGroups operation
        ///</summary>
        public IListPackagingGroupsPaginator ListPackagingGroups(ListPackagingGroupsRequest request) 
        {
            return new ListPackagingGroupsPaginator(this.client, request);
        }
    }
}