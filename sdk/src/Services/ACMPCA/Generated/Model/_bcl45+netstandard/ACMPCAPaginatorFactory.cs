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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Paginators for the ACMPCA service
    ///</summary>
    public class ACMPCAPaginatorFactory : IACMPCAPaginatorFactory
    {
        private readonly IAmazonACMPCA client;

        internal ACMPCAPaginatorFactory(IAmazonACMPCA client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCertificateAuthorities operation
        ///</summary>
        public IListCertificateAuthoritiesPaginator ListCertificateAuthorities(ListCertificateAuthoritiesRequest request) 
        {
            return new ListCertificateAuthoritiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPermissions operation
        ///</summary>
        public IListPermissionsPaginator ListPermissions(ListPermissionsRequest request) 
        {
            return new ListPermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        public IListTagsPaginator ListTags(ListTagsRequest request) 
        {
            return new ListTagsPaginator(this.client, request);
        }
    }
}