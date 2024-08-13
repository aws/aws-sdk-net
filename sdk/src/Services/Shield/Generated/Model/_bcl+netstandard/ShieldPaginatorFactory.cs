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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Paginators for the Shield service
    ///</summary>
    public class ShieldPaginatorFactory : IShieldPaginatorFactory
    {
        private readonly IAmazonShield client;

        internal ShieldPaginatorFactory(IAmazonShield client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAttacks operation
        ///</summary>
        public IListAttacksPaginator ListAttacks(ListAttacksRequest request) 
        {
            return new ListAttacksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProtectionGroups operation
        ///</summary>
        public IListProtectionGroupsPaginator ListProtectionGroups(ListProtectionGroupsRequest request) 
        {
            return new ListProtectionGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProtections operation
        ///</summary>
        public IListProtectionsPaginator ListProtections(ListProtectionsRequest request) 
        {
            return new ListProtectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourcesInProtectionGroup operation
        ///</summary>
        public IListResourcesInProtectionGroupPaginator ListResourcesInProtectionGroup(ListResourcesInProtectionGroupRequest request) 
        {
            return new ListResourcesInProtectionGroupPaginator(this.client, request);
        }
    }
}