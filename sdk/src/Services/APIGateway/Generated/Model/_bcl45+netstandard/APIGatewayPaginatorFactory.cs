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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Paginators for the APIGateway service
    ///</summary>
    public class APIGatewayPaginatorFactory : IAPIGatewayPaginatorFactory
    {
        private readonly IAmazonAPIGateway client;

        internal APIGatewayPaginatorFactory(IAmazonAPIGateway client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetApiKeys operation
        ///</summary>
        public IGetApiKeysPaginator GetApiKeys(GetApiKeysRequest request) 
        {
            return new GetApiKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetBasePathMappings operation
        ///</summary>
        public IGetBasePathMappingsPaginator GetBasePathMappings(GetBasePathMappingsRequest request) 
        {
            return new GetBasePathMappingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetClientCertificates operation
        ///</summary>
        public IGetClientCertificatesPaginator GetClientCertificates(GetClientCertificatesRequest request) 
        {
            return new GetClientCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetDeployments operation
        ///</summary>
        public IGetDeploymentsPaginator GetDeployments(GetDeploymentsRequest request) 
        {
            return new GetDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetDomainNames operation
        ///</summary>
        public IGetDomainNamesPaginator GetDomainNames(GetDomainNamesRequest request) 
        {
            return new GetDomainNamesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetModels operation
        ///</summary>
        public IGetModelsPaginator GetModels(GetModelsRequest request) 
        {
            return new GetModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResources operation
        ///</summary>
        public IGetResourcesPaginator GetResources(GetResourcesRequest request) 
        {
            return new GetResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetRestApis operation
        ///</summary>
        public IGetRestApisPaginator GetRestApis(GetRestApisRequest request) 
        {
            return new GetRestApisPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetUsage operation
        ///</summary>
        public IGetUsagePaginator GetUsage(GetUsageRequest request) 
        {
            return new GetUsagePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetUsagePlanKeys operation
        ///</summary>
        public IGetUsagePlanKeysPaginator GetUsagePlanKeys(GetUsagePlanKeysRequest request) 
        {
            return new GetUsagePlanKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetUsagePlans operation
        ///</summary>
        public IGetUsagePlansPaginator GetUsagePlans(GetUsagePlansRequest request) 
        {
            return new GetUsagePlansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetVpcLinks operation
        ///</summary>
        public IGetVpcLinksPaginator GetVpcLinks(GetVpcLinksRequest request) 
        {
            return new GetVpcLinksPaginator(this.client, request);
        }
    }
}