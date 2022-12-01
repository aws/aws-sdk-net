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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Paginators for the Comprehend service
    ///</summary>
    public interface IComprehendPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDocumentClassificationJobs operation
        ///</summary>
        IListDocumentClassificationJobsPaginator ListDocumentClassificationJobs(ListDocumentClassificationJobsRequest request);

        /// <summary>
        /// Paginator for ListDocumentClassifiers operation
        ///</summary>
        IListDocumentClassifiersPaginator ListDocumentClassifiers(ListDocumentClassifiersRequest request);

        /// <summary>
        /// Paginator for ListDocumentClassifierSummaries operation
        ///</summary>
        IListDocumentClassifierSummariesPaginator ListDocumentClassifierSummaries(ListDocumentClassifierSummariesRequest request);

        /// <summary>
        /// Paginator for ListDominantLanguageDetectionJobs operation
        ///</summary>
        IListDominantLanguageDetectionJobsPaginator ListDominantLanguageDetectionJobs(ListDominantLanguageDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListEndpoints operation
        ///</summary>
        IListEndpointsPaginator ListEndpoints(ListEndpointsRequest request);

        /// <summary>
        /// Paginator for ListEntitiesDetectionJobs operation
        ///</summary>
        IListEntitiesDetectionJobsPaginator ListEntitiesDetectionJobs(ListEntitiesDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListEntityRecognizers operation
        ///</summary>
        IListEntityRecognizersPaginator ListEntityRecognizers(ListEntityRecognizersRequest request);

        /// <summary>
        /// Paginator for ListEntityRecognizerSummaries operation
        ///</summary>
        IListEntityRecognizerSummariesPaginator ListEntityRecognizerSummaries(ListEntityRecognizerSummariesRequest request);

        /// <summary>
        /// Paginator for ListEventsDetectionJobs operation
        ///</summary>
        IListEventsDetectionJobsPaginator ListEventsDetectionJobs(ListEventsDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListKeyPhrasesDetectionJobs operation
        ///</summary>
        IListKeyPhrasesDetectionJobsPaginator ListKeyPhrasesDetectionJobs(ListKeyPhrasesDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListPiiEntitiesDetectionJobs operation
        ///</summary>
        IListPiiEntitiesDetectionJobsPaginator ListPiiEntitiesDetectionJobs(ListPiiEntitiesDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListSentimentDetectionJobs operation
        ///</summary>
        IListSentimentDetectionJobsPaginator ListSentimentDetectionJobs(ListSentimentDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListTargetedSentimentDetectionJobs operation
        ///</summary>
        IListTargetedSentimentDetectionJobsPaginator ListTargetedSentimentDetectionJobs(ListTargetedSentimentDetectionJobsRequest request);

        /// <summary>
        /// Paginator for ListTopicsDetectionJobs operation
        ///</summary>
        IListTopicsDetectionJobsPaginator ListTopicsDetectionJobs(ListTopicsDetectionJobsRequest request);
    }
}