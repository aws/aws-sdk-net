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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Paginators for the LakeFormation service
    ///</summary>
    public class LakeFormationPaginatorFactory : ILakeFormationPaginatorFactory
    {
        private readonly IAmazonLakeFormation client;

        internal LakeFormationPaginatorFactory(IAmazonLakeFormation client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetEffectivePermissionsForPath operation
        ///</summary>
        public IGetEffectivePermissionsForPathPaginator GetEffectivePermissionsForPath(GetEffectivePermissionsForPathRequest request) 
        {
            return new GetEffectivePermissionsForPathPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPermissions operation
        ///</summary>
        public IListPermissionsPaginator ListPermissions(ListPermissionsRequest request) 
        {
            return new ListPermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        public IListResourcesPaginator ListResources(ListResourcesRequest request) 
        {
            return new ListResourcesPaginator(this.client, request);
        }
    }
}