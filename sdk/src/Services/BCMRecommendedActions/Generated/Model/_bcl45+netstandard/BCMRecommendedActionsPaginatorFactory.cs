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
 * Do not modify this file. This file is generated from the bcm-recommended-actions-2024-11-14.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BCMRecommendedActions.Model
{
    /// <summary>
    /// Paginators for the BCMRecommendedActions service
    ///</summary>
    public class BCMRecommendedActionsPaginatorFactory : IBCMRecommendedActionsPaginatorFactory
    {
        private readonly IAmazonBCMRecommendedActions client;

        internal BCMRecommendedActionsPaginatorFactory(IAmazonBCMRecommendedActions client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListRecommendedActions operation
        ///</summary>
        public IListRecommendedActionsPaginator ListRecommendedActions(ListRecommendedActionsRequest request) 
        {
            return new ListRecommendedActionsPaginator(this.client, request);
        }
    }
}