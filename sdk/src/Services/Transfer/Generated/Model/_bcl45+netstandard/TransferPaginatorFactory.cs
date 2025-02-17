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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Paginators for the Transfer service
    ///</summary>
    public class TransferPaginatorFactory : ITransferPaginatorFactory
    {
        private readonly IAmazonTransfer client;

        internal TransferPaginatorFactory(IAmazonTransfer client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccesses operation
        ///</summary>
        public IListAccessesPaginator ListAccesses(ListAccessesRequest request) 
        {
            return new ListAccessesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAgreements operation
        ///</summary>
        public IListAgreementsPaginator ListAgreements(ListAgreementsRequest request) 
        {
            return new ListAgreementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCertificates operation
        ///</summary>
        public IListCertificatesPaginator ListCertificates(ListCertificatesRequest request) 
        {
            return new ListCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConnectors operation
        ///</summary>
        public IListConnectorsPaginator ListConnectors(ListConnectorsRequest request) 
        {
            return new ListConnectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExecutions operation
        ///</summary>
        public IListExecutionsPaginator ListExecutions(ListExecutionsRequest request) 
        {
            return new ListExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFileTransferResults operation
        ///</summary>
        public IListFileTransferResultsPaginator ListFileTransferResults(ListFileTransferResultsRequest request) 
        {
            return new ListFileTransferResultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProfiles operation
        ///</summary>
        public IListProfilesPaginator ListProfiles(ListProfilesRequest request) 
        {
            return new ListProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityPolicies operation
        ///</summary>
        public IListSecurityPoliciesPaginator ListSecurityPolicies(ListSecurityPoliciesRequest request) 
        {
            return new ListSecurityPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServers operation
        ///</summary>
        public IListServersPaginator ListServers(ListServersRequest request) 
        {
            return new ListServersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWebApps operation
        ///</summary>
        public IListWebAppsPaginator ListWebApps(ListWebAppsRequest request) 
        {
            return new ListWebAppsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        public IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request) 
        {
            return new ListWorkflowsPaginator(this.client, request);
        }
    }
}