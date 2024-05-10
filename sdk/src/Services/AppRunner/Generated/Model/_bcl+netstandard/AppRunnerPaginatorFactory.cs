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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Paginators for the AppRunner service
    ///</summary>
    public class AppRunnerPaginatorFactory : IAppRunnerPaginatorFactory
    {
        private readonly IAmazonAppRunner client;

        internal AppRunnerPaginatorFactory(IAmazonAppRunner client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeCustomDomains operation
        ///</summary>
        public IDescribeCustomDomainsPaginator DescribeCustomDomains(DescribeCustomDomainsRequest request) 
        {
            return new DescribeCustomDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutoScalingConfigurations operation
        ///</summary>
        public IListAutoScalingConfigurationsPaginator ListAutoScalingConfigurations(ListAutoScalingConfigurationsRequest request) 
        {
            return new ListAutoScalingConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConnections operation
        ///</summary>
        public IListConnectionsPaginator ListConnections(ListConnectionsRequest request) 
        {
            return new ListConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListObservabilityConfigurations operation
        ///</summary>
        public IListObservabilityConfigurationsPaginator ListObservabilityConfigurations(ListObservabilityConfigurationsRequest request) 
        {
            return new ListObservabilityConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOperations operation
        ///</summary>
        public IListOperationsPaginator ListOperations(ListOperationsRequest request) 
        {
            return new ListOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServicesForAutoScalingConfiguration operation
        ///</summary>
        public IListServicesForAutoScalingConfigurationPaginator ListServicesForAutoScalingConfiguration(ListServicesForAutoScalingConfigurationRequest request) 
        {
            return new ListServicesForAutoScalingConfigurationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVpcConnectors operation
        ///</summary>
        public IListVpcConnectorsPaginator ListVpcConnectors(ListVpcConnectorsRequest request) 
        {
            return new ListVpcConnectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVpcIngressConnections operation
        ///</summary>
        public IListVpcIngressConnectionsPaginator ListVpcIngressConnections(ListVpcIngressConnectionsRequest request) 
        {
            return new ListVpcIngressConnectionsPaginator(this.client, request);
        }
    }
}