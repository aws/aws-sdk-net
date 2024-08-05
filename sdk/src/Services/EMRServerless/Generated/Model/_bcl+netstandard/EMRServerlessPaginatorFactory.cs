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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Paginators for the EMRServerless service
    ///</summary>
    public class EMRServerlessPaginatorFactory : IEMRServerlessPaginatorFactory
    {
        private readonly IAmazonEMRServerless client;

        internal EMRServerlessPaginatorFactory(IAmazonEMRServerless client) 
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
        /// Paginator for ListJobRunAttempts operation
        ///</summary>
        public IListJobRunAttemptsPaginator ListJobRunAttempts(ListJobRunAttemptsRequest request) 
        {
            return new ListJobRunAttemptsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobRuns operation
        ///</summary>
        public IListJobRunsPaginator ListJobRuns(ListJobRunsRequest request) 
        {
            return new ListJobRunsPaginator(this.client, request);
        }
    }
}