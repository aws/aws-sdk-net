#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Macie.Model
{
    /// <summary>
    /// Paginators for the Macie service
    ///</summary>
    public class MaciePaginatorFactory : IMaciePaginatorFactory
    {
        private readonly IAmazonMacie client;

        internal MaciePaginatorFactory(IAmazonMacie client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListMemberAccounts operation
        ///</summary>
        public IListMemberAccountsPaginator ListMemberAccounts(ListMemberAccountsRequest request) 
        {
            return new ListMemberAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListS3Resources operation
        ///</summary>
        public IListS3ResourcesPaginator ListS3Resources(ListS3ResourcesRequest request) 
        {
            return new ListS3ResourcesPaginator(this.client, request);
        }
    }
}
#endif