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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Paginators for the LambdaMicrovms service
    ///</summary>
    public class LambdaMicrovmsPaginatorFactory : ILambdaMicrovmsPaginatorFactory
    {
        private readonly IAmazonLambdaMicrovms client;

        internal LambdaMicrovmsPaginatorFactory(IAmazonLambdaMicrovms client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListManagedMicrovmImages operation
        ///</summary>
        public IListManagedMicrovmImagesPaginator ListManagedMicrovmImages(ListManagedMicrovmImagesRequest request) 
        {
            return new ListManagedMicrovmImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedMicrovmImageVersions operation
        ///</summary>
        public IListManagedMicrovmImageVersionsPaginator ListManagedMicrovmImageVersions(ListManagedMicrovmImageVersionsRequest request) 
        {
            return new ListManagedMicrovmImageVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMicrovmImageBuilds operation
        ///</summary>
        public IListMicrovmImageBuildsPaginator ListMicrovmImageBuilds(ListMicrovmImageBuildsRequest request) 
        {
            return new ListMicrovmImageBuildsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMicrovmImages operation
        ///</summary>
        public IListMicrovmImagesPaginator ListMicrovmImages(ListMicrovmImagesRequest request) 
        {
            return new ListMicrovmImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMicrovmImageVersions operation
        ///</summary>
        public IListMicrovmImageVersionsPaginator ListMicrovmImageVersions(ListMicrovmImageVersionsRequest request) 
        {
            return new ListMicrovmImageVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMicrovms operation
        ///</summary>
        public IListMicrovmsPaginator ListMicrovms(ListMicrovmsRequest request) 
        {
            return new ListMicrovmsPaginator(this.client, request);
        }
    }
}