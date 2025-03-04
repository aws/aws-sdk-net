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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Paginators for the ConnectCases service
    ///</summary>
    public class ConnectCasesPaginatorFactory : IConnectCasesPaginatorFactory
    {
        private readonly IAmazonConnectCases client;

        internal ConnectCasesPaginatorFactory(IAmazonConnectCases client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetCase operation
        ///</summary>
        public IGetCasePaginator GetCase(GetCaseRequest request) 
        {
            return new GetCasePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCaseAuditEvents operation
        ///</summary>
        public IGetCaseAuditEventsPaginator GetCaseAuditEvents(GetCaseAuditEventsRequest request) 
        {
            return new GetCaseAuditEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCaseRules operation
        ///</summary>
        public IListCaseRulesPaginator ListCaseRules(ListCaseRulesRequest request) 
        {
            return new ListCaseRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCasesForContact operation
        ///</summary>
        public IListCasesForContactPaginator ListCasesForContact(ListCasesForContactRequest request) 
        {
            return new ListCasesForContactPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFieldOptions operation
        ///</summary>
        public IListFieldOptionsPaginator ListFieldOptions(ListFieldOptionsRequest request) 
        {
            return new ListFieldOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFields operation
        ///</summary>
        public IListFieldsPaginator ListFields(ListFieldsRequest request) 
        {
            return new ListFieldsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLayouts operation
        ///</summary>
        public IListLayoutsPaginator ListLayouts(ListLayoutsRequest request) 
        {
            return new ListLayoutsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplates operation
        ///</summary>
        public IListTemplatesPaginator ListTemplates(ListTemplatesRequest request) 
        {
            return new ListTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchCases operation
        ///</summary>
        public ISearchCasesPaginator SearchCases(SearchCasesRequest request) 
        {
            return new SearchCasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchRelatedItems operation
        ///</summary>
        public ISearchRelatedItemsPaginator SearchRelatedItems(SearchRelatedItemsRequest request) 
        {
            return new SearchRelatedItemsPaginator(this.client, request);
        }
    }
}