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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */
using Amazon.Runtime;

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Paginator for the ListAWSDefaultServiceQuotas operation
    ///</summary>
    public interface IListAWSDefaultServiceQuotasPaginator
    {
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        IPaginatedEnumerable<ListAWSDefaultServiceQuotasResponse> Responses { get; }

        /// <summary>
        /// Enumerable containing all of the Quotas
        /// </summary>
        IPaginatedEnumerable<ServiceQuota> Quotas { get; }
    }
}
#endif