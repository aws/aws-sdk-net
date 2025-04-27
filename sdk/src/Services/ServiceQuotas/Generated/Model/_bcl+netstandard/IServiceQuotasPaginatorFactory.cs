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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Paginators for the ServiceQuotas service
    ///</summary>
    public interface IServiceQuotasPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAWSDefaultServiceQuotas operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAWSDefaultServiceQuotasPaginator ListAWSDefaultServiceQuotas(ListAWSDefaultServiceQuotasRequest request);

        /// <summary>
        /// Paginator for ListRequestedServiceQuotaChangeHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRequestedServiceQuotaChangeHistoryPaginator ListRequestedServiceQuotaChangeHistory(ListRequestedServiceQuotaChangeHistoryRequest request);

        /// <summary>
        /// Paginator for ListRequestedServiceQuotaChangeHistoryByQuota operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRequestedServiceQuotaChangeHistoryByQuotaPaginator ListRequestedServiceQuotaChangeHistoryByQuota(ListRequestedServiceQuotaChangeHistoryByQuotaRequest request);

        /// <summary>
        /// Paginator for ListServiceQuotaIncreaseRequestsInTemplate operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceQuotaIncreaseRequestsInTemplatePaginator ListServiceQuotaIncreaseRequestsInTemplate(ListServiceQuotaIncreaseRequestsInTemplateRequest request);

        /// <summary>
        /// Paginator for ListServiceQuotas operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceQuotasPaginator ListServiceQuotas(ListServiceQuotasRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServicesPaginator ListServices(ListServicesRequest request);
    }
}