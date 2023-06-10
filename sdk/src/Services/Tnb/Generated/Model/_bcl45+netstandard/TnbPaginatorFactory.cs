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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Paginators for the Tnb service
    ///</summary>
    public class TnbPaginatorFactory : ITnbPaginatorFactory
    {
        private readonly IAmazonTnb client;

        internal TnbPaginatorFactory(IAmazonTnb client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListSolFunctionInstances operation
        ///</summary>
        public IListSolFunctionInstancesPaginator ListSolFunctionInstances(ListSolFunctionInstancesRequest request) 
        {
            return new ListSolFunctionInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSolFunctionPackages operation
        ///</summary>
        public IListSolFunctionPackagesPaginator ListSolFunctionPackages(ListSolFunctionPackagesRequest request) 
        {
            return new ListSolFunctionPackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSolNetworkInstances operation
        ///</summary>
        public IListSolNetworkInstancesPaginator ListSolNetworkInstances(ListSolNetworkInstancesRequest request) 
        {
            return new ListSolNetworkInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSolNetworkOperations operation
        ///</summary>
        public IListSolNetworkOperationsPaginator ListSolNetworkOperations(ListSolNetworkOperationsRequest request) 
        {
            return new ListSolNetworkOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSolNetworkPackages operation
        ///</summary>
        public IListSolNetworkPackagesPaginator ListSolNetworkPackages(ListSolNetworkPackagesRequest request) 
        {
            return new ListSolNetworkPackagesPaginator(this.client, request);
        }
    }
}