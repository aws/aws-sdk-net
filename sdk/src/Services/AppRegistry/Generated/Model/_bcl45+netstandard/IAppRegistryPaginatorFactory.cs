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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */

namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// Paginators for the AppRegistry service
    ///</summary>
    public interface IAppRegistryPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListAssociatedAttributeGroups operation
        ///</summary>
        IListAssociatedAttributeGroupsPaginator ListAssociatedAttributeGroups(ListAssociatedAttributeGroupsRequest request);

        /// <summary>
        /// Paginator for ListAssociatedResources operation
        ///</summary>
        IListAssociatedResourcesPaginator ListAssociatedResources(ListAssociatedResourcesRequest request);

        /// <summary>
        /// Paginator for ListAttributeGroups operation
        ///</summary>
        IListAttributeGroupsPaginator ListAttributeGroups(ListAttributeGroupsRequest request);
    }
}
#endif