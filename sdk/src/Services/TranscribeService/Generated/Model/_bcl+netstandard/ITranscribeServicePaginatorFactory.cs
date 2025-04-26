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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Paginators for the TranscribeService service
    ///</summary>
    public interface ITranscribeServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListCallAnalyticsCategories operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCallAnalyticsCategoriesPaginator ListCallAnalyticsCategories(ListCallAnalyticsCategoriesRequest request);

        /// <summary>
        /// Paginator for ListCallAnalyticsJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCallAnalyticsJobsPaginator ListCallAnalyticsJobs(ListCallAnalyticsJobsRequest request);

        /// <summary>
        /// Paginator for ListLanguageModels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLanguageModelsPaginator ListLanguageModels(ListLanguageModelsRequest request);

        /// <summary>
        /// Paginator for ListMedicalScribeJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMedicalScribeJobsPaginator ListMedicalScribeJobs(ListMedicalScribeJobsRequest request);

        /// <summary>
        /// Paginator for ListMedicalTranscriptionJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMedicalTranscriptionJobsPaginator ListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request);

        /// <summary>
        /// Paginator for ListMedicalVocabularies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMedicalVocabulariesPaginator ListMedicalVocabularies(ListMedicalVocabulariesRequest request);

        /// <summary>
        /// Paginator for ListTranscriptionJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTranscriptionJobsPaginator ListTranscriptionJobs(ListTranscriptionJobsRequest request);

        /// <summary>
        /// Paginator for ListVocabularies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVocabulariesPaginator ListVocabularies(ListVocabulariesRequest request);

        /// <summary>
        /// Paginator for ListVocabularyFilters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVocabularyFiltersPaginator ListVocabularyFilters(ListVocabularyFiltersRequest request);
    }
}