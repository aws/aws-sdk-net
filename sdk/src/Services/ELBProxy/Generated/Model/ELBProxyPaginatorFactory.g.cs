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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
#pragma warning disable CS0612,CS0618

namespace Amazon.ELBProxy.Model
{
    /// <summary>
    /// Paginators for the ELBProxy service
    /// </summary>
    public class ELBProxyPaginatorFactory : IELBProxyPaginatorFactory
    {
        private readonly IAmazonELBProxy client;

        internal ELBProxyPaginatorFactory(IAmazonELBProxy client)
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCertificateAssociations operation
        /// </summary>
        public IListCertificateAssociationsPaginator ListCertificateAssociations(ListCertificateAssociationsRequest request)
        {
            return new ListCertificateAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProxies operation
        /// </summary>
        public IListProxiesPaginator ListProxies(ListProxiesRequest request)
        {
            return new ListProxiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProxyUpdates operation
        /// </summary>
        public IListProxyUpdatesPaginator ListProxyUpdates(ListProxyUpdatesRequest request)
        {
            return new ListProxyUpdatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProxyVersions operation
        /// </summary>
        public IListProxyVersionsPaginator ListProxyVersions(ListProxyVersionsRequest request)
        {
            return new ListProxyVersionsPaginator(this.client, request);
        }
    }
}
