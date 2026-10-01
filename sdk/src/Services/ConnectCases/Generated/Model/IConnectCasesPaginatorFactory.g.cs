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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Paginators for the ConnectCases service
    /// </summary>
    public interface IConnectCasesPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetCase operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IGetCasePaginator GetCase(GetCaseRequest request);

        /// <summary>
        /// Paginator for GetCaseAuditEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetCaseAuditEventsPaginator GetCaseAuditEvents(GetCaseAuditEventsRequest request);

        /// <summary>
        /// Paginator for ListCaseRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCaseRulesPaginator ListCaseRules(ListCaseRulesRequest request);

        /// <summary>
        /// Paginator for ListCasesForContact operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCasesForContactPaginator ListCasesForContact(ListCasesForContactRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListFieldOptions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFieldOptionsPaginator ListFieldOptions(ListFieldOptionsRequest request);

        /// <summary>
        /// Paginator for ListFields operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFieldsPaginator ListFields(ListFieldsRequest request);

        /// <summary>
        /// Paginator for ListLayouts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLayoutsPaginator ListLayouts(ListLayoutsRequest request);

        /// <summary>
        /// Paginator for ListTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTemplatesPaginator ListTemplates(ListTemplatesRequest request);

        /// <summary>
        /// Paginator for SearchAllRelatedItems operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchAllRelatedItemsPaginator SearchAllRelatedItems(SearchAllRelatedItemsRequest request);

        /// <summary>
        /// Paginator for SearchCases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchCasesPaginator SearchCases(SearchCasesRequest request);

        /// <summary>
        /// Paginator for SearchRelatedItems operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchRelatedItemsPaginator SearchRelatedItems(SearchRelatedItemsRequest request);
    }
}
