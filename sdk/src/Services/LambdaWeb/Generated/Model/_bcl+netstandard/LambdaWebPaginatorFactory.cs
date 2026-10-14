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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// Paginators for the LambdaWeb service
    ///</summary>
    public class LambdaWebPaginatorFactory : ILambdaWebPaginatorFactory
    {
        private readonly IAmazonLambdaWeb client;

        internal LambdaWebPaginatorFactory(IAmazonLambdaWeb client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListWebFunctionEndpoints operation
        ///</summary>
        public IListWebFunctionEndpointsPaginator ListWebFunctionEndpoints(ListWebFunctionEndpointsRequest request) 
        {
            return new ListWebFunctionEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWebFunctionRevisions operation
        ///</summary>
        public IListWebFunctionRevisionsPaginator ListWebFunctionRevisions(ListWebFunctionRevisionsRequest request) 
        {
            return new ListWebFunctionRevisionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWebFunctions operation
        ///</summary>
        public IListWebFunctionsPaginator ListWebFunctions(ListWebFunctionsRequest request) 
        {
            return new ListWebFunctionsPaginator(this.client, request);
        }
    }
}