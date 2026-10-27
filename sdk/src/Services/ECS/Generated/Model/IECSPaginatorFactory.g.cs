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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Paginators for the ECS service
    /// </summary>
    public interface IECSPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAccountSettings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountSettingsPaginator ListAccountSettings(ListAccountSettingsRequest request);

        /// <summary>
        /// Paginator for ListAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAttributesPaginator ListAttributes(ListAttributesRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListContainerInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContainerInstancesPaginator ListContainerInstances(ListContainerInstancesRequest request);

        /// <summary>
        /// Paginator for ListGatewayClusterAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGatewayClusterAssociationsPaginator ListGatewayClusterAssociations(ListGatewayClusterAssociationsRequest request);

        /// <summary>
        /// Paginator for ListGatewayRoutes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGatewayRoutesPaginator ListGatewayRoutes(ListGatewayRoutesRequest request);

        /// <summary>
        /// Paginator for ListGateways operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGatewaysPaginator ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListServicesByNamespace operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServicesByNamespacePaginator ListServicesByNamespace(ListServicesByNamespaceRequest request);

        /// <summary>
        /// Paginator for ListTaskDefinitionFamilies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTaskDefinitionFamiliesPaginator ListTaskDefinitionFamilies(ListTaskDefinitionFamiliesRequest request);

        /// <summary>
        /// Paginator for ListTaskDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTaskDefinitionsPaginator ListTaskDefinitions(ListTaskDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListTasks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTasksPaginator ListTasks(ListTasksRequest request);
    }
}
