#if !NETSTANDARD13
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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Paginators for the Shield service
    ///</summary>
    public interface IShieldPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAttacks operation
        ///</summary>
        IListAttacksPaginator ListAttacks(ListAttacksRequest request);

        /// <summary>
        /// Paginator for ListProtectionGroups operation
        ///</summary>
        IListProtectionGroupsPaginator ListProtectionGroups(ListProtectionGroupsRequest request);

        /// <summary>
        /// Paginator for ListProtections operation
        ///</summary>
        IListProtectionsPaginator ListProtections(ListProtectionsRequest request);

        /// <summary>
        /// Paginator for ListResourcesInProtectionGroup operation
        ///</summary>
        IListResourcesInProtectionGroupPaginator ListResourcesInProtectionGroup(ListResourcesInProtectionGroupRequest request);
    }
}
#endif