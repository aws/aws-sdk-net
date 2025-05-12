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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCustomDomainsPaginator DescribeCustomDomains(DescribeCustomDomainsRequest request);

        /// <summary>
        /// Paginator for ListAutoScalingConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAutoScalingConfigurationsPaginator ListAutoScalingConfigurations(ListAutoScalingConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConnectionsPaginator ListConnections(ListConnectionsRequest request);

        /// <summary>
        /// Paginator for ListObservabilityConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListObservabilityConfigurationsPaginator ListObservabilityConfigurations(ListObservabilityConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListOperations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOperationsPaginator ListOperations(ListOperationsRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListServicesForAutoScalingConfiguration operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServicesForAutoScalingConfigurationPaginator ListServicesForAutoScalingConfiguration(ListServicesForAutoScalingConfigurationRequest request);

        /// <summary>
        /// Paginator for ListVpcConnectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVpcConnectorsPaginator ListVpcConnectors(ListVpcConnectorsRequest request);

        /// <summary>
        /// Paginator for ListVpcIngressConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVpcIngressConnectionsPaginator ListVpcIngressConnections(ListVpcIngressConnectionsRequest request);
    }
}