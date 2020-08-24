#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Paginators for the Route53 service
    ///</summary>
    public interface IRoute53PaginatorFactory
    {

        /// <summary>
        /// Paginator for ListHealthChecks operation
        ///</summary>
        IListHealthChecksPaginator ListHealthChecks(ListHealthChecksRequest request);

        /// <summary>
        /// Paginator for ListHostedZones operation
        ///</summary>
        IListHostedZonesPaginator ListHostedZones(ListHostedZonesRequest request);

        /// <summary>
        /// Paginator for ListQueryLoggingConfigs operation
        ///</summary>
        IListQueryLoggingConfigsPaginator ListQueryLoggingConfigs(ListQueryLoggingConfigsRequest request);

        /// <summary>
        /// Paginator for ListResourceRecordSets operation
        ///</summary>
        IListResourceRecordSetsPaginator ListResourceRecordSets(ListResourceRecordSetsRequest request);
    }
}
#endif