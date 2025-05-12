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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Paginators for the ResourceGroupsTaggingAPI service
    ///</summary>
    public interface IResourceGroupsTaggingAPIPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetComplianceSummary operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PaginationToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "PaginationToken" }
        )]
        IGetComplianceSummaryPaginator GetComplianceSummary(GetComplianceSummaryRequest request);

        /// <summary>
        /// Paginator for GetResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PaginationToken" },
            LimitKey = "ResourcesPerPage",
            OutputToken = new[] { "PaginationToken" }
        )]
        IGetResourcesPaginator GetResources(GetResourcesRequest request);

        /// <summary>
        /// Paginator for GetTagKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PaginationToken" },
            
            OutputToken = new[] { "PaginationToken" }
        )]
        IGetTagKeysPaginator GetTagKeys(GetTagKeysRequest request);

        /// <summary>
        /// Paginator for GetTagValues operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PaginationToken" },
            
            OutputToken = new[] { "PaginationToken" }
        )]
        IGetTagValuesPaginator GetTagValues(GetTagValuesRequest request);
    }
}