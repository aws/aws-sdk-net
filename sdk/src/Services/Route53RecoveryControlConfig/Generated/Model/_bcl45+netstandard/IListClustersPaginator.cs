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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using Amazon.Runtime;

namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// Paginator for the ListClusters operation
    ///</summary>
    public interface IListClustersPaginator
    {
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        IPaginatedEnumerable<ListClustersResponse> Responses { get; }

        /// <summary>
        /// Enumerable containing all of the Clusters
        /// </summary>
        IPaginatedEnumerable<Cluster> Clusters { get; }
    }
}