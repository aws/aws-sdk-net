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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Paginators for the Amplify service
    ///</summary>
    public class AmplifyPaginatorFactory : IAmplifyPaginatorFactory
    {
        private readonly IAmazonAmplify client;

        internal AmplifyPaginatorFactory(IAmazonAmplify client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApps operation
        ///</summary>
        public IListAppsPaginator ListApps(ListAppsRequest request) 
        {
            return new ListAppsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBranches operation
        ///</summary>
        public IListBranchesPaginator ListBranches(ListBranchesRequest request) 
        {
            return new ListBranchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomainAssociations operation
        ///</summary>
        public IListDomainAssociationsPaginator ListDomainAssociations(ListDomainAssociationsRequest request) 
        {
            return new ListDomainAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }
    }
}