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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// Paginators for the ControlCatalog service
    ///</summary>
    public class ControlCatalogPaginatorFactory : IControlCatalogPaginatorFactory
    {
        private readonly IAmazonControlCatalog client;

        internal ControlCatalogPaginatorFactory(IAmazonControlCatalog client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCommonControls operation
        ///</summary>
        public IListCommonControlsPaginator ListCommonControls(ListCommonControlsRequest request) 
        {
            return new ListCommonControlsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListControlMappings operation
        ///</summary>
        public IListControlMappingsPaginator ListControlMappings(ListControlMappingsRequest request) 
        {
            return new ListControlMappingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListControls operation
        ///</summary>
        public IListControlsPaginator ListControls(ListControlsRequest request) 
        {
            return new ListControlsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListObjectives operation
        ///</summary>
        public IListObjectivesPaginator ListObjectives(ListObjectivesRequest request) 
        {
            return new ListObjectivesPaginator(this.client, request);
        }
    }
}