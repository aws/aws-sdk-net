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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Paginators for the ECS service
    ///</summary>
    public class ECSPaginatorFactory : IECSPaginatorFactory
    {
        private readonly IAmazonECS client;

        internal ECSPaginatorFactory(IAmazonECS client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccountSettings operation
        ///</summary>
        public IListAccountSettingsPaginator ListAccountSettings(ListAccountSettingsRequest request) 
        {
            return new ListAccountSettingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAttributes operation
        ///</summary>
        public IListAttributesPaginator ListAttributes(ListAttributesRequest request) 
        {
            return new ListAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        public IListClustersPaginator ListClusters(ListClustersRequest request) 
        {
            return new ListClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContainerInstances operation
        ///</summary>
        public IListContainerInstancesPaginator ListContainerInstances(ListContainerInstancesRequest request) 
        {
            return new ListContainerInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServicesByNamespace operation
        ///</summary>
        public IListServicesByNamespacePaginator ListServicesByNamespace(ListServicesByNamespaceRequest request) 
        {
            return new ListServicesByNamespacePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTaskDefinitionFamilies operation
        ///</summary>
        public IListTaskDefinitionFamiliesPaginator ListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request) 
        {
            return new ListTaskDefinitionFamiliesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTaskDefinitions operation
        ///</summary>
        public IListTaskDefinitionsPaginator ListTaskDefinitions(ListTaskDefinitionsRequest request) 
        {
            return new ListTaskDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTasks operation
        ///</summary>
        public IListTasksPaginator ListTasks(ListTasksRequest request) 
        {
            return new ListTasksPaginator(this.client, request);
        }
    }
}