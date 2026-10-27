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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Paginators for the Comprehend service
    /// </summary>
    public interface IComprehendPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListDatasets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDatasetsPaginator ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Paginator for ListDocumentClassificationJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDocumentClassificationJobsPaginator ListDocumentClassificationJobs(ListDocumentClassificationJobsRequest request);

        /// <summary>
        /// Paginator for ListDocumentClassifierSummaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDocumentClassifierSummariesPaginator ListDocumentClassifierSummaries(ListDocumentClassifierSummariesRequest request);

        /// <summary>
        /// Paginator for ListDocumentClassifiers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDocumentClassifiersPaginator ListDocumentClassifiers(ListDocumentClassifiersRequest request);

        /// <summary>
        /// Paginator for ListDominantLanguageDetectionJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDominantLanguageDetectionJobsPaginator ListDominantLanguageDetectionJobs(ListDominantLanguageDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEndpointsPaginator ListEndpoints(ListEndpointsRequest request);

        /// <summary>
        /// Paginator for ListEntitiesDetectionJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEntitiesDetectionJobsPaginator ListEntitiesDetectionJobs(ListEntitiesDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListEntityRecognizerSummaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEntityRecognizerSummariesPaginator ListEntityRecognizerSummaries(ListEntityRecognizerSummariesRequest request);

        /// <summary>
        /// Paginator for ListEntityRecognizers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEntityRecognizersPaginator ListEntityRecognizers(ListEntityRecognizersRequest request);

        /// <summary>
        /// Paginator for ListEventsDetectionJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEventsDetectionJobsPaginator ListEventsDetectionJobs(ListEventsDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListFlywheelIterationHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFlywheelIterationHistoryPaginator ListFlywheelIterationHistory(ListFlywheelIterationHistoryRequest request);

        /// <summary>
        /// Paginator for ListFlywheels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFlywheelsPaginator ListFlywheels(ListFlywheelsRequest request);

        /// <summary>
        /// Paginator for ListKeyPhrasesDetectionJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListKeyPhrasesDetectionJobsPaginator ListKeyPhrasesDetectionJobs(ListKeyPhrasesDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListPiiEntitiesDetectionJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPiiEntitiesDetectionJobsPaginator ListPiiEntitiesDetectionJobs(ListPiiEntitiesDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListSentimentDetectionJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSentimentDetectionJobsPaginator ListSentimentDetectionJobs(ListSentimentDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListTargetedSentimentDetectionJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTargetedSentimentDetectionJobsPaginator ListTargetedSentimentDetectionJobs(ListTargetedSentimentDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListTopicsDetectionJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTopicsDetectionJobsPaginator ListTopicsDetectionJobs(ListTopicsDetectionJobsRequest request);
    }
}
