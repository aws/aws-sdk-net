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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Paginators for the ServiceQuotas service
    /// </summary>
    public interface IServiceQuotasPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAWSDefaultServiceQuotas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAWSDefaultServiceQuotasPaginator ListAWSDefaultServiceQuotas(ListAWSDefaultServiceQuotasRequest request);

        /// <summary>
        /// Paginator for ListRequestedServiceQuotaChangeHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRequestedServiceQuotaChangeHistoryPaginator ListRequestedServiceQuotaChangeHistory(ListRequestedServiceQuotaChangeHistoryRequest request);

        /// <summary>
        /// Paginator for ListRequestedServiceQuotaChangeHistoryByQuota operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRequestedServiceQuotaChangeHistoryByQuotaPaginator ListRequestedServiceQuotaChangeHistoryByQuota(ListRequestedServiceQuotaChangeHistoryByQuotaRequest request);

        /// <summary>
        /// Paginator for ListServiceQuotaIncreaseRequestsInTemplate operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceQuotaIncreaseRequestsInTemplatePaginator ListServiceQuotaIncreaseRequestsInTemplate(ListServiceQuotaIncreaseRequestsInTemplateRequest request);

        /// <summary>
        /// Paginator for ListServiceQuotas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceQuotasPaginator ListServiceQuotas(ListServiceQuotasRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServicesPaginator ListServices(ListServicesRequest request);
    }
}
