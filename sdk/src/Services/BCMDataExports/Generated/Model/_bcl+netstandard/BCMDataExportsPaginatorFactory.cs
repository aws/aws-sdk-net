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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BCMDataExports.Model
{
    /// <summary>
    /// Paginators for the BCMDataExports service
    ///</summary>
    public class BCMDataExportsPaginatorFactory : IBCMDataExportsPaginatorFactory
    {
        private readonly IAmazonBCMDataExports client;

        internal BCMDataExportsPaginatorFactory(IAmazonBCMDataExports client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListExecutions operation
        ///</summary>
        public IListExecutionsPaginator ListExecutions(ListExecutionsRequest request) 
        {
            return new ListExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExports operation
        ///</summary>
        public IListExportsPaginator ListExports(ListExportsRequest request) 
        {
            return new ListExportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTables operation
        ///</summary>
        public IListTablesPaginator ListTables(ListTablesRequest request) 
        {
            return new ListTablesPaginator(this.client, request);
        }
    }
}