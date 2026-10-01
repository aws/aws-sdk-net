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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Paginators for the BedrockAgentCore service
    /// </summary>
    public interface IBedrockAgentCorePaginatorFactory
    {
        /// <summary>
        /// Paginator for ListABTests operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListABTestsPaginator ListABTests(ListABTestsRequest request);

        /// <summary>
        /// Paginator for ListActors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListActorsPaginator ListActors(ListActorsRequest request);

        /// <summary>
        /// Paginator for ListBatchEvaluations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBatchEvaluationsPaginator ListBatchEvaluations(ListBatchEvaluationsRequest request);

        /// <summary>
        /// Paginator for ListEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEventsPaginator ListEvents(ListEventsRequest request);

        /// <summary>
        /// Paginator for ListMemoryExtractionJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMemoryExtractionJobsPaginator ListMemoryExtractionJobs(ListMemoryExtractionJobsRequest request);

        /// <summary>
        /// Paginator for ListMemoryRecords operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMemoryRecordsPaginator ListMemoryRecords(ListMemoryRecordsRequest request);

        /// <summary>
        /// Paginator for ListPaymentInstruments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPaymentInstrumentsPaginator ListPaymentInstruments(ListPaymentInstrumentsRequest request);

        /// <summary>
        /// Paginator for ListPaymentSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPaymentSessionsPaginator ListPaymentSessions(ListPaymentSessionsRequest request);

        /// <summary>
        /// Paginator for ListRecommendations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSessionsPaginator ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Paginator for RetrieveMemoryRecords operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IRetrieveMemoryRecordsPaginator RetrieveMemoryRecords(RetrieveMemoryRecordsRequest request);
    }
}
