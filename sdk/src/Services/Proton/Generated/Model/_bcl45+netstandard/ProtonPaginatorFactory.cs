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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Paginators for the Proton service
    ///</summary>
    public class ProtonPaginatorFactory : IProtonPaginatorFactory
    {
        private readonly IAmazonProton client;

        internal ProtonPaginatorFactory(IAmazonProton client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListEnvironmentAccountConnections operation
        ///</summary>
        public IListEnvironmentAccountConnectionsPaginator ListEnvironmentAccountConnections(ListEnvironmentAccountConnectionsRequest request) 
        {
            return new ListEnvironmentAccountConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        public IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request) 
        {
            return new ListEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentTemplates operation
        ///</summary>
        public IListEnvironmentTemplatesPaginator ListEnvironmentTemplates(ListEnvironmentTemplatesRequest request) 
        {
            return new ListEnvironmentTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentTemplateVersions operation
        ///</summary>
        public IListEnvironmentTemplateVersionsPaginator ListEnvironmentTemplateVersions(ListEnvironmentTemplateVersionsRequest request) 
        {
            return new ListEnvironmentTemplateVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceInstances operation
        ///</summary>
        public IListServiceInstancesPaginator ListServiceInstances(ListServiceInstancesRequest request) 
        {
            return new ListServiceInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceTemplates operation
        ///</summary>
        public IListServiceTemplatesPaginator ListServiceTemplates(ListServiceTemplatesRequest request) 
        {
            return new ListServiceTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceTemplateVersions operation
        ///</summary>
        public IListServiceTemplateVersionsPaginator ListServiceTemplateVersions(ListServiceTemplateVersionsRequest request) 
        {
            return new ListServiceTemplateVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}