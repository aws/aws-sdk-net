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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Paginators for the Braket service
    ///</summary>
    public class BraketPaginatorFactory : IBraketPaginatorFactory
    {
        private readonly IAmazonBraket client;

        internal BraketPaginatorFactory(IAmazonBraket client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for SearchDevices operation
        ///</summary>
        public ISearchDevicesPaginator SearchDevices(SearchDevicesRequest request) 
        {
            return new SearchDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchJobs operation
        ///</summary>
        public ISearchJobsPaginator SearchJobs(SearchJobsRequest request) 
        {
            return new SearchJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchQuantumTasks operation
        ///</summary>
        public ISearchQuantumTasksPaginator SearchQuantumTasks(SearchQuantumTasksRequest request) 
        {
            return new SearchQuantumTasksPaginator(this.client, request);
        }
    }
}