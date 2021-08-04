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
        IListCallAnalyticsCategoriesPaginator ListCallAnalyticsCategories(ListCallAnalyticsCategoriesRequest request);

        /// <summary>
        /// Paginator for ListCallAnalyticsJobs operation
        ///</summary>
        IListCallAnalyticsJobsPaginator ListCallAnalyticsJobs(ListCallAnalyticsJobsRequest request);

        /// <summary>
        /// Paginator for ListLanguageModels operation
        ///</summary>
        IListLanguageModelsPaginator ListLanguageModels(ListLanguageModelsRequest request);

        /// <summary>
        /// Paginator for ListMedicalTranscriptionJobs operation
        ///</summary>
        IListMedicalTranscriptionJobsPaginator ListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request);

        /// <summary>
        /// Paginator for ListMedicalVocabularies operation
        ///</summary>
        IListMedicalVocabulariesPaginator ListMedicalVocabularies(ListMedicalVocabulariesRequest request);

        /// <summary>
        /// Paginator for ListTranscriptionJobs operation
        ///</summary>
        IListTranscriptionJobsPaginator ListTranscriptionJobs(ListTranscriptionJobsRequest request);

        /// <summary>
        /// Paginator for ListVocabularies operation
        ///</summary>
        IListVocabulariesPaginator ListVocabularies(ListVocabulariesRequest request);

        /// <summary>
        /// Paginator for ListVocabularyFilters operation
        ///</summary>
        IListVocabularyFiltersPaginator ListVocabularyFilters(ListVocabularyFiltersRequest request);
    }
}