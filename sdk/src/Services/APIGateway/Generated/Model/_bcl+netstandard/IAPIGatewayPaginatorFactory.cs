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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Paginators for the APIGateway service
    ///</summary>
    public interface IAPIGatewayPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetApiKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetApiKeysPaginator GetApiKeys(GetApiKeysRequest request);

        /// <summary>
        /// Paginator for GetBasePathMappings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetBasePathMappingsPaginator GetBasePathMappings(GetBasePathMappingsRequest request);

        /// <summary>
        /// Paginator for GetClientCertificates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetClientCertificatesPaginator GetClientCertificates(GetClientCertificatesRequest request);

        /// <summary>
        /// Paginator for GetDeployments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetDeploymentsPaginator GetDeployments(GetDeploymentsRequest request);

        /// <summary>
        /// Paginator for GetDomainNames operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetDomainNamesPaginator GetDomainNames(GetDomainNamesRequest request);

        /// <summary>
        /// Paginator for GetModels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetModelsPaginator GetModels(GetModelsRequest request);

        /// <summary>
        /// Paginator for GetResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetResourcesPaginator GetResources(GetResourcesRequest request);

        /// <summary>
        /// Paginator for GetRestApis operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetRestApisPaginator GetRestApis(GetRestApisRequest request);

        /// <summary>
        /// Paginator for GetUsage operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetUsagePaginator GetUsage(GetUsageRequest request);

        /// <summary>
        /// Paginator for GetUsagePlanKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetUsagePlanKeysPaginator GetUsagePlanKeys(GetUsagePlanKeysRequest request);

        /// <summary>
        /// Paginator for GetUsagePlans operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetUsagePlansPaginator GetUsagePlans(GetUsagePlansRequest request);

        /// <summary>
        /// Paginator for GetVpcLinks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Position" },
            LimitKey = "Limit",
            OutputToken = new[] { "Position" }
        )]
        IGetVpcLinksPaginator GetVpcLinks(GetVpcLinksRequest request);
    }
}