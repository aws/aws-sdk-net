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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Paginators for the SsmSap service
    ///</summary>
    public class SsmSapPaginatorFactory : ISsmSapPaginatorFactory
    {
        private readonly IAmazonSsmSap client;

        internal SsmSapPaginatorFactory(IAmazonSsmSap client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        public IListComponentsPaginator ListComponents(ListComponentsRequest request) 
        {
            return new ListComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatabases operation
        ///</summary>
        public IListDatabasesPaginator ListDatabases(ListDatabasesRequest request) 
        {
            return new ListDatabasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOperations operation
        ///</summary>
        public IListOperationsPaginator ListOperations(ListOperationsRequest request) 
        {
            return new ListOperationsPaginator(this.client, request);
        }
    }
}