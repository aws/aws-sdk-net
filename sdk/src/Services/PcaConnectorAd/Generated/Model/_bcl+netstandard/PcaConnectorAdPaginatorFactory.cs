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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Paginators for the PcaConnectorAd service
    ///</summary>
    public class PcaConnectorAdPaginatorFactory : IPcaConnectorAdPaginatorFactory
    {
        private readonly IAmazonPcaConnectorAd client;

        internal PcaConnectorAdPaginatorFactory(IAmazonPcaConnectorAd client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListConnectors operation
        ///</summary>
        public IListConnectorsPaginator ListConnectors(ListConnectorsRequest request) 
        {
            return new ListConnectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDirectoryRegistrations operation
        ///</summary>
        public IListDirectoryRegistrationsPaginator ListDirectoryRegistrations(ListDirectoryRegistrationsRequest request) 
        {
            return new ListDirectoryRegistrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServicePrincipalNames operation
        ///</summary>
        public IListServicePrincipalNamesPaginator ListServicePrincipalNames(ListServicePrincipalNamesRequest request) 
        {
            return new ListServicePrincipalNamesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplateGroupAccessControlEntries operation
        ///</summary>
        public IListTemplateGroupAccessControlEntriesPaginator ListTemplateGroupAccessControlEntries(ListTemplateGroupAccessControlEntriesRequest request) 
        {
            return new ListTemplateGroupAccessControlEntriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplates operation
        ///</summary>
        public IListTemplatesPaginator ListTemplates(ListTemplatesRequest request) 
        {
            return new ListTemplatesPaginator(this.client, request);
        }
    }
}