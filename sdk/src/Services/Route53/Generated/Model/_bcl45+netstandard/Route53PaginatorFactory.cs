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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Paginators for the Route53 service
    ///</summary>
    public class Route53PaginatorFactory : IRoute53PaginatorFactory
    {
        private readonly IAmazonRoute53 client;

        internal Route53PaginatorFactory(IAmazonRoute53 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCidrBlocks operation
        ///</summary>
        public IListCidrBlocksPaginator ListCidrBlocks(ListCidrBlocksRequest request) 
        {
            return new ListCidrBlocksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCidrCollections operation
        ///</summary>
        public IListCidrCollectionsPaginator ListCidrCollections(ListCidrCollectionsRequest request) 
        {
            return new ListCidrCollectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCidrLocations operation
        ///</summary>
        public IListCidrLocationsPaginator ListCidrLocations(ListCidrLocationsRequest request) 
        {
            return new ListCidrLocationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHealthChecks operation
        ///</summary>
        public IListHealthChecksPaginator ListHealthChecks(ListHealthChecksRequest request) 
        {
            return new ListHealthChecksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHostedZones operation
        ///</summary>
        public IListHostedZonesPaginator ListHostedZones(ListHostedZonesRequest request) 
        {
            return new ListHostedZonesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueryLoggingConfigs operation
        ///</summary>
        public IListQueryLoggingConfigsPaginator ListQueryLoggingConfigs(ListQueryLoggingConfigsRequest request) 
        {
            return new ListQueryLoggingConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceRecordSets operation
        ///</summary>
        public IListResourceRecordSetsPaginator ListResourceRecordSets(ListResourceRecordSetsRequest request) 
        {
            return new ListResourceRecordSetsPaginator(this.client, request);
        }
    }
}