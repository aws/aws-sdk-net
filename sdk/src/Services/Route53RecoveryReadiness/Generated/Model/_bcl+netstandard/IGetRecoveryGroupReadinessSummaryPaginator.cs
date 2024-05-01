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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// Paginator for the GetRecoveryGroupReadinessSummary operation
    ///</summary>
    public interface IGetRecoveryGroupReadinessSummaryPaginator
    {
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        IPaginatedEnumerable<GetRecoveryGroupReadinessSummaryResponse> Responses { get; }

        /// <summary>
        /// Enumerable containing all of the ReadinessChecks
        /// </summary>
        IPaginatedEnumerable<ReadinessCheckSummary> ReadinessChecks { get; }
    }
}