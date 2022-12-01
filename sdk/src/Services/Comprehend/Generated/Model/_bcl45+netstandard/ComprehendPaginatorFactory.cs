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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Paginators for the Comprehend service
    ///</summary>
    public class ComprehendPaginatorFactory : IComprehendPaginatorFactory
    {
        private readonly IAmazonComprehend client;

        internal ComprehendPaginatorFactory(IAmazonComprehend client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDocumentClassificationJobs operation
        ///</summary>
        public IListDocumentClassificationJobsPaginator ListDocumentClassificationJobs(ListDocumentClassificationJobsRequest request) 
        {
            return new ListDocumentClassificationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDocumentClassifiers operation
        ///</summary>
        public IListDocumentClassifiersPaginator ListDocumentClassifiers(ListDocumentClassifiersRequest request) 
        {
            return new ListDocumentClassifiersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDocumentClassifierSummaries operation
        ///</summary>
        public IListDocumentClassifierSummariesPaginator ListDocumentClassifierSummaries(ListDocumentClassifierSummariesRequest request) 
        {
            return new ListDocumentClassifierSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDominantLanguageDetectionJobs operation
        ///</summary>
        public IListDominantLanguageDetectionJobsPaginator ListDominantLanguageDetectionJobs(ListDominantLanguageDetectionJobsRequest request) 
        {
            return new ListDominantLanguageDetectionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEndpoints operation
        ///</summary>
        public IListEndpointsPaginator ListEndpoints(ListEndpointsRequest request) 
        {
            return new ListEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEntitiesDetectionJobs operation
        ///</summary>
        public IListEntitiesDetectionJobsPaginator ListEntitiesDetectionJobs(ListEntitiesDetectionJobsRequest request) 
        {
            return new ListEntitiesDetectionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEntityRecognizers operation
        ///</summary>
        public IListEntityRecognizersPaginator ListEntityRecognizers(ListEntityRecognizersRequest request) 
        {
            return new ListEntityRecognizersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEntityRecognizerSummaries operation
        ///</summary>
        public IListEntityRecognizerSummariesPaginator ListEntityRecognizerSummaries(ListEntityRecognizerSummariesRequest request) 
        {
            return new ListEntityRecognizerSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventsDetectionJobs operation
        ///</summary>
        public IListEventsDetectionJobsPaginator ListEventsDetectionJobs(ListEventsDetectionJobsRequest request) 
        {
            return new ListEventsDetectionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKeyPhrasesDetectionJobs operation
        ///</summary>
        public IListKeyPhrasesDetectionJobsPaginator ListKeyPhrasesDetectionJobs(ListKeyPhrasesDetectionJobsRequest request) 
        {
            return new ListKeyPhrasesDetectionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPiiEntitiesDetectionJobs operation
        ///</summary>
        public IListPiiEntitiesDetectionJobsPaginator ListPiiEntitiesDetectionJobs(ListPiiEntitiesDetectionJobsRequest request) 
        {
            return new ListPiiEntitiesDetectionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSentimentDetectionJobs operation
        ///</summary>
        public IListSentimentDetectionJobsPaginator ListSentimentDetectionJobs(ListSentimentDetectionJobsRequest request) 
        {
            return new ListSentimentDetectionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTargetedSentimentDetectionJobs operation
        ///</summary>
        public IListTargetedSentimentDetectionJobsPaginator ListTargetedSentimentDetectionJobs(ListTargetedSentimentDetectionJobsRequest request) 
        {
            return new ListTargetedSentimentDetectionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTopicsDetectionJobs operation
        ///</summary>
        public IListTopicsDetectionJobsPaginator ListTopicsDetectionJobs(ListTopicsDetectionJobsRequest request) 
        {
            return new ListTopicsDetectionJobsPaginator(this.client, request);
        }
    }
}