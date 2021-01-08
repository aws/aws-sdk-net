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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Paginators for the ResourceGroups service
    ///</summary>
    public interface IResourceGroupsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListGroupResources operation
        ///</summary>
        IListGroupResourcesPaginator ListGroupResources(ListGroupResourcesRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for SearchResources operation
        ///</summary>
        ISearchResourcesPaginator SearchResources(SearchResourcesRequest request);
    }
}
#endif