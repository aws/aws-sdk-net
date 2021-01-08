#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Paginators for the CodeGuruReviewer service
    ///</summary>
    public class CodeGuruReviewerPaginatorFactory : ICodeGuruReviewerPaginatorFactory
    {
        private readonly IAmazonCodeGuruReviewer client;

        internal CodeGuruReviewerPaginatorFactory(IAmazonCodeGuruReviewer client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCodeReviews operation
        ///</summary>
        public IListCodeReviewsPaginator ListCodeReviews(ListCodeReviewsRequest request) 
        {
            return new ListCodeReviewsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendationFeedback operation
        ///</summary>
        public IListRecommendationFeedbackPaginator ListRecommendationFeedback(ListRecommendationFeedbackRequest request) 
        {
            return new ListRecommendationFeedbackPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        public IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request) 
        {
            return new ListRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRepositoryAssociations operation
        ///</summary>
        public IListRepositoryAssociationsPaginator ListRepositoryAssociations(ListRepositoryAssociationsRequest request) 
        {
            return new ListRepositoryAssociationsPaginator(this.client, request);
        }
    }
}
#endif