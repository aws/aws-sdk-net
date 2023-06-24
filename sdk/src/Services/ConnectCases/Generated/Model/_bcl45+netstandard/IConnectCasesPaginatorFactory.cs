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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Paginators for the ConnectCases service
    ///</summary>
    public interface IConnectCasesPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetCase operation
        ///</summary>
        IGetCasePaginator GetCase(GetCaseRequest request);

        /// <summary>
        /// Paginator for ListCasesForContact operation
        ///</summary>
        IListCasesForContactPaginator ListCasesForContact(ListCasesForContactRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListFieldOptions operation
        ///</summary>
        IListFieldOptionsPaginator ListFieldOptions(ListFieldOptionsRequest request);

        /// <summary>
        /// Paginator for ListFields operation
        ///</summary>
        IListFieldsPaginator ListFields(ListFieldsRequest request);

        /// <summary>
        /// Paginator for ListLayouts operation
        ///</summary>
        IListLayoutsPaginator ListLayouts(ListLayoutsRequest request);

        /// <summary>
        /// Paginator for ListTemplates operation
        ///</summary>
        IListTemplatesPaginator ListTemplates(ListTemplatesRequest request);

        /// <summary>
        /// Paginator for SearchCases operation
        ///</summary>
        ISearchCasesPaginator SearchCases(SearchCasesRequest request);

        /// <summary>
        /// Paginator for SearchRelatedItems operation
        ///</summary>
        ISearchRelatedItemsPaginator SearchRelatedItems(SearchRelatedItemsRequest request);
    }
}