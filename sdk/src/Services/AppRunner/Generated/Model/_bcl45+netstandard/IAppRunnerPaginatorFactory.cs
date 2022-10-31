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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Paginators for the AppRunner service
    ///</summary>
    public interface IAppRunnerPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeCustomDomains operation
        ///</summary>
        IDescribeCustomDomainsPaginator DescribeCustomDomains(DescribeCustomDomainsRequest request);

        /// <summary>
        /// Paginator for ListAutoScalingConfigurations operation
        ///</summary>
        IListAutoScalingConfigurationsPaginator ListAutoScalingConfigurations(ListAutoScalingConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListConnections operation
        ///</summary>
        IListConnectionsPaginator ListConnections(ListConnectionsRequest request);

        /// <summary>
        /// Paginator for ListObservabilityConfigurations operation
        ///</summary>
        IListObservabilityConfigurationsPaginator ListObservabilityConfigurations(ListObservabilityConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListOperations operation
        ///</summary>
        IListOperationsPaginator ListOperations(ListOperationsRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListVpcConnectors operation
        ///</summary>
        IListVpcConnectorsPaginator ListVpcConnectors(ListVpcConnectorsRequest request);

        /// <summary>
        /// Paginator for ListVpcIngressConnections operation
        ///</summary>
        IListVpcIngressConnectionsPaginator ListVpcIngressConnections(ListVpcIngressConnectionsRequest request);
    }
}