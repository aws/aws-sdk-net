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
 * Do not modify this file. This file is generated from the route53profiles-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53Profiles.Model
{
    /// <summary>
    /// Paginators for the Route53Profiles service
    ///</summary>
    public class Route53ProfilesPaginatorFactory : IRoute53ProfilesPaginatorFactory
    {
        private readonly IAmazonRoute53Profiles client;

        internal Route53ProfilesPaginatorFactory(IAmazonRoute53Profiles client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListProfileAssociations operation
        ///</summary>
        public IListProfileAssociationsPaginator ListProfileAssociations(ListProfileAssociationsRequest request) 
        {
            return new ListProfileAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProfileResourceAssociations operation
        ///</summary>
        public IListProfileResourceAssociationsPaginator ListProfileResourceAssociations(ListProfileResourceAssociationsRequest request) 
        {
            return new ListProfileResourceAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProfiles operation
        ///</summary>
        public IListProfilesPaginator ListProfiles(ListProfilesRequest request) 
        {
            return new ListProfilesPaginator(this.client, request);
        }
    }
}