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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Paginators for the VerifiedPermissions service
    ///</summary>
    public class VerifiedPermissionsPaginatorFactory : IVerifiedPermissionsPaginatorFactory
    {
        private readonly IAmazonVerifiedPermissions client;

        internal VerifiedPermissionsPaginatorFactory(IAmazonVerifiedPermissions client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListIdentitySources operation
        ///</summary>
        public IListIdentitySourcesPaginator ListIdentitySources(ListIdentitySourcesRequest request) 
        {
            return new ListIdentitySourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        public IListPoliciesPaginator ListPolicies(ListPoliciesRequest request) 
        {
            return new ListPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicyStores operation
        ///</summary>
        public IListPolicyStoresPaginator ListPolicyStores(ListPolicyStoresRequest request) 
        {
            return new ListPolicyStoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicyTemplates operation
        ///</summary>
        public IListPolicyTemplatesPaginator ListPolicyTemplates(ListPolicyTemplatesRequest request) 
        {
            return new ListPolicyTemplatesPaginator(this.client, request);
        }
    }
}