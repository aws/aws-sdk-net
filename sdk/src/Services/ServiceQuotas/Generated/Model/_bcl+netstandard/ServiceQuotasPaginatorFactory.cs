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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Paginators for the ServiceQuotas service
    ///</summary>
    public class ServiceQuotasPaginatorFactory : IServiceQuotasPaginatorFactory
    {
        private readonly IAmazonServiceQuotas client;

        internal ServiceQuotasPaginatorFactory(IAmazonServiceQuotas client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAWSDefaultServiceQuotas operation
        ///</summary>
        public IListAWSDefaultServiceQuotasPaginator ListAWSDefaultServiceQuotas(ListAWSDefaultServiceQuotasRequest request) 
        {
            return new ListAWSDefaultServiceQuotasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRequestedServiceQuotaChangeHistory operation
        ///</summary>
        public IListRequestedServiceQuotaChangeHistoryPaginator ListRequestedServiceQuotaChangeHistory(ListRequestedServiceQuotaChangeHistoryRequest request) 
        {
            return new ListRequestedServiceQuotaChangeHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRequestedServiceQuotaChangeHistoryByQuota operation
        ///</summary>
        public IListRequestedServiceQuotaChangeHistoryByQuotaPaginator ListRequestedServiceQuotaChangeHistoryByQuota(ListRequestedServiceQuotaChangeHistoryByQuotaRequest request) 
        {
            return new ListRequestedServiceQuotaChangeHistoryByQuotaPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceQuotaIncreaseRequestsInTemplate operation
        ///</summary>
        public IListServiceQuotaIncreaseRequestsInTemplatePaginator ListServiceQuotaIncreaseRequestsInTemplate(ListServiceQuotaIncreaseRequestsInTemplateRequest request) 
        {
            return new ListServiceQuotaIncreaseRequestsInTemplatePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceQuotas operation
        ///</summary>
        public IListServiceQuotasPaginator ListServiceQuotas(ListServiceQuotasRequest request) 
        {
            return new ListServiceQuotasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }
    }
}