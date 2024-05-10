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

#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Paginators for the Transfer service
    ///</summary>
    public interface ITransferPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccesses operation
        ///</summary>
        IListAccessesPaginator ListAccesses(ListAccessesRequest request);

        /// <summary>
        /// Paginator for ListAgreements operation
        ///</summary>
        IListAgreementsPaginator ListAgreements(ListAgreementsRequest request);

        /// <summary>
        /// Paginator for ListCertificates operation
        ///</summary>
        IListCertificatesPaginator ListCertificates(ListCertificatesRequest request);

        /// <summary>
        /// Paginator for ListConnectors operation
        ///</summary>
        IListConnectorsPaginator ListConnectors(ListConnectorsRequest request);

        /// <summary>
        /// Paginator for ListExecutions operation
        ///</summary>
        IListExecutionsPaginator ListExecutions(ListExecutionsRequest request);

        /// <summary>
        /// Paginator for ListProfiles operation
        ///</summary>
        IListProfilesPaginator ListProfiles(ListProfilesRequest request);

        /// <summary>
        /// Paginator for ListSecurityPolicies operation
        ///</summary>
        IListSecurityPoliciesPaginator ListSecurityPolicies(ListSecurityPoliciesRequest request);

        /// <summary>
        /// Paginator for ListServers operation
        ///</summary>
        IListServersPaginator ListServers(ListServersRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request);
    }
}