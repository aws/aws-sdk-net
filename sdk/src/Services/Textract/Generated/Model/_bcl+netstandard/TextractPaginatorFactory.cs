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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Paginators for the Textract service
    ///</summary>
    public class TextractPaginatorFactory : ITextractPaginatorFactory
    {
        private readonly IAmazonTextract client;

        internal TextractPaginatorFactory(IAmazonTextract client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAdapters operation
        ///</summary>
        public IListAdaptersPaginator ListAdapters(ListAdaptersRequest request) 
        {
            return new ListAdaptersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAdapterVersions operation
        ///</summary>
        public IListAdapterVersionsPaginator ListAdapterVersions(ListAdapterVersionsRequest request) 
        {
            return new ListAdapterVersionsPaginator(this.client, request);
        }
    }
}