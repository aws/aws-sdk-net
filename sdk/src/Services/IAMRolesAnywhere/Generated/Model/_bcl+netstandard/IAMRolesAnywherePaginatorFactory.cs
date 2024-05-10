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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Paginators for the IAMRolesAnywhere service
    ///</summary>
    public class IAMRolesAnywherePaginatorFactory : IIAMRolesAnywherePaginatorFactory
    {
        private readonly IAmazonIAMRolesAnywhere client;

        internal IAMRolesAnywherePaginatorFactory(IAmazonIAMRolesAnywhere client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCrls operation
        ///</summary>
        public IListCrlsPaginator ListCrls(ListCrlsRequest request) 
        {
            return new ListCrlsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProfiles operation
        ///</summary>
        public IListProfilesPaginator ListProfiles(ListProfilesRequest request) 
        {
            return new ListProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubjects operation
        ///</summary>
        public IListSubjectsPaginator ListSubjects(ListSubjectsRequest request) 
        {
            return new ListSubjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrustAnchors operation
        ///</summary>
        public IListTrustAnchorsPaginator ListTrustAnchors(ListTrustAnchorsRequest request) 
        {
            return new ListTrustAnchorsPaginator(this.client, request);
        }
    }
}