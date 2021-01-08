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
 * Do not modify this file. This file is generated from the migrationhub-config-2019-06-30.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.MigrationHubConfig.Model
{
    /// <summary>
    /// Paginators for the MigrationHubConfig service
    ///</summary>
    public class MigrationHubConfigPaginatorFactory : IMigrationHubConfigPaginatorFactory
    {
        private readonly IAmazonMigrationHubConfig client;

        internal MigrationHubConfigPaginatorFactory(IAmazonMigrationHubConfig client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeHomeRegionControls operation
        ///</summary>
        public IDescribeHomeRegionControlsPaginator DescribeHomeRegionControls(DescribeHomeRegionControlsRequest request) 
        {
            return new DescribeHomeRegionControlsPaginator(this.client, request);
        }
    }
}
#endif