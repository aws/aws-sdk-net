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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Paginators for the ResourceGroupsTaggingAPI service
    ///</summary>
    public class ResourceGroupsTaggingAPIPaginatorFactory : IResourceGroupsTaggingAPIPaginatorFactory
    {
        private readonly IAmazonResourceGroupsTaggingAPI client;

        internal ResourceGroupsTaggingAPIPaginatorFactory(IAmazonResourceGroupsTaggingAPI client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetComplianceSummary operation
        ///</summary>
        public IGetComplianceSummaryPaginator GetComplianceSummary(GetComplianceSummaryRequest request) 
        {
            return new GetComplianceSummaryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResources operation
        ///</summary>
        public IGetResourcesPaginator GetResources(GetResourcesRequest request) 
        {
            return new GetResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTagKeys operation
        ///</summary>
        public IGetTagKeysPaginator GetTagKeys(GetTagKeysRequest request) 
        {
            return new GetTagKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTagValues operation
        ///</summary>
        public IGetTagValuesPaginator GetTagValues(GetTagValuesRequest request) 
        {
            return new GetTagValuesPaginator(this.client, request);
        }
    }
}