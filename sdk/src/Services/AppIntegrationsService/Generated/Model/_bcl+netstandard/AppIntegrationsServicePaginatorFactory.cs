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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Paginators for the AppIntegrationsService service
    ///</summary>
    public class AppIntegrationsServicePaginatorFactory : IAppIntegrationsServicePaginatorFactory
    {
        private readonly IAmazonAppIntegrationsService client;

        internal AppIntegrationsServicePaginatorFactory(IAmazonAppIntegrationsService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplicationAssociations operation
        ///</summary>
        public IListApplicationAssociationsPaginator ListApplicationAssociations(ListApplicationAssociationsRequest request) 
        {
            return new ListApplicationAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataIntegrationAssociations operation
        ///</summary>
        public IListDataIntegrationAssociationsPaginator ListDataIntegrationAssociations(ListDataIntegrationAssociationsRequest request) 
        {
            return new ListDataIntegrationAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataIntegrations operation
        ///</summary>
        public IListDataIntegrationsPaginator ListDataIntegrations(ListDataIntegrationsRequest request) 
        {
            return new ListDataIntegrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventIntegrationAssociations operation
        ///</summary>
        public IListEventIntegrationAssociationsPaginator ListEventIntegrationAssociations(ListEventIntegrationAssociationsRequest request) 
        {
            return new ListEventIntegrationAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventIntegrations operation
        ///</summary>
        public IListEventIntegrationsPaginator ListEventIntegrations(ListEventIntegrationsRequest request) 
        {
            return new ListEventIntegrationsPaginator(this.client, request);
        }
    }
}