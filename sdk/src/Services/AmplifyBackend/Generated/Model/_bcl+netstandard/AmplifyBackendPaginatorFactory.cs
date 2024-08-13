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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Paginators for the AmplifyBackend service
    ///</summary>
    public class AmplifyBackendPaginatorFactory : IAmplifyBackendPaginatorFactory
    {
        private readonly IAmazonAmplifyBackend client;

        internal AmplifyBackendPaginatorFactory(IAmazonAmplifyBackend client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBackendJobs operation
        ///</summary>
        public IListBackendJobsPaginator ListBackendJobs(ListBackendJobsRequest request) 
        {
            return new ListBackendJobsPaginator(this.client, request);
        }
    }
}