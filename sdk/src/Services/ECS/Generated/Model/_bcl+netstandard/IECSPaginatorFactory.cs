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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Paginators for the ECS service
    ///</summary>
    public interface IECSPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccountSettings operation
        ///</summary>
        IListAccountSettingsPaginator ListAccountSettings(ListAccountSettingsRequest request);

        /// <summary>
        /// Paginator for ListAttributes operation
        ///</summary>
        IListAttributesPaginator ListAttributes(ListAttributesRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListContainerInstances operation
        ///</summary>
        IListContainerInstancesPaginator ListContainerInstances(ListContainerInstancesRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListServicesByNamespace operation
        ///</summary>
        IListServicesByNamespacePaginator ListServicesByNamespace(ListServicesByNamespaceRequest request);

        /// <summary>
        /// Paginator for ListTaskDefinitionFamilies operation
        ///</summary>
        IListTaskDefinitionFamiliesPaginator ListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request);

        /// <summary>
        /// Paginator for ListTaskDefinitions operation
        ///</summary>
        IListTaskDefinitionsPaginator ListTaskDefinitions(ListTaskDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListTasks operation
        ///</summary>
        IListTasksPaginator ListTasks(ListTasksRequest request);
    }
}