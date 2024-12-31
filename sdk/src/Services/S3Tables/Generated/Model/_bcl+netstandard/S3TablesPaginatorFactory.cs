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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Paginators for the S3Tables service
    ///</summary>
    public class S3TablesPaginatorFactory : IS3TablesPaginatorFactory
    {
        private readonly IAmazonS3Tables client;

        internal S3TablesPaginatorFactory(IAmazonS3Tables client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListNamespaces operation
        ///</summary>
        public IListNamespacesPaginator ListNamespaces(ListNamespacesRequest request) 
        {
            return new ListNamespacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTableBuckets operation
        ///</summary>
        public IListTableBucketsPaginator ListTableBuckets(ListTableBucketsRequest request) 
        {
            return new ListTableBucketsPaginator(this.client, request);
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