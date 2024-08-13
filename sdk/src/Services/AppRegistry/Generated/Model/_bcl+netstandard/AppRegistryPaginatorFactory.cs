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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// Paginators for the AppRegistry service
    ///</summary>
    public class AppRegistryPaginatorFactory : IAppRegistryPaginatorFactory
    {
        private readonly IAmazonAppRegistry client;

        internal AppRegistryPaginatorFactory(IAmazonAppRegistry client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociatedAttributeGroups operation
        ///</summary>
        public IListAssociatedAttributeGroupsPaginator ListAssociatedAttributeGroups(ListAssociatedAttributeGroupsRequest request) 
        {
            return new ListAssociatedAttributeGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociatedResources operation
        ///</summary>
        public IListAssociatedResourcesPaginator ListAssociatedResources(ListAssociatedResourcesRequest request) 
        {
            return new ListAssociatedResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAttributeGroups operation
        ///</summary>
        public IListAttributeGroupsPaginator ListAttributeGroups(ListAttributeGroupsRequest request) 
        {
            return new ListAttributeGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAttributeGroupsForApplication operation
        ///</summary>
        public IListAttributeGroupsForApplicationPaginator ListAttributeGroupsForApplication(ListAttributeGroupsForApplicationRequest request) 
        {
            return new ListAttributeGroupsForApplicationPaginator(this.client, request);
        }
    }
}