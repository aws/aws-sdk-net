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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Paginators for the TranscribeService service
    ///</summary>
    public class TranscribeServicePaginatorFactory : ITranscribeServicePaginatorFactory
    {
        private readonly IAmazonTranscribeService client;

        internal TranscribeServicePaginatorFactory(IAmazonTranscribeService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCallAnalyticsCategories operation
        ///</summary>
        public IListCallAnalyticsCategoriesPaginator ListCallAnalyticsCategories(ListCallAnalyticsCategoriesRequest request) 
        {
            return new ListCallAnalyticsCategoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCallAnalyticsJobs operation
        ///</summary>
        public IListCallAnalyticsJobsPaginator ListCallAnalyticsJobs(ListCallAnalyticsJobsRequest request) 
        {
            return new ListCallAnalyticsJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLanguageModels operation
        ///</summary>
        public IListLanguageModelsPaginator ListLanguageModels(ListLanguageModelsRequest request) 
        {
            return new ListLanguageModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMedicalScribeJobs operation
        ///</summary>
        public IListMedicalScribeJobsPaginator ListMedicalScribeJobs(ListMedicalScribeJobsRequest request) 
        {
            return new ListMedicalScribeJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMedicalTranscriptionJobs operation
        ///</summary>
        public IListMedicalTranscriptionJobsPaginator ListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request) 
        {
            return new ListMedicalTranscriptionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMedicalVocabularies operation
        ///</summary>
        public IListMedicalVocabulariesPaginator ListMedicalVocabularies(ListMedicalVocabulariesRequest request) 
        {
            return new ListMedicalVocabulariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTranscriptionJobs operation
        ///</summary>
        public IListTranscriptionJobsPaginator ListTranscriptionJobs(ListTranscriptionJobsRequest request) 
        {
            return new ListTranscriptionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVocabularies operation
        ///</summary>
        public IListVocabulariesPaginator ListVocabularies(ListVocabulariesRequest request) 
        {
            return new ListVocabulariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVocabularyFilters operation
        ///</summary>
        public IListVocabularyFiltersPaginator ListVocabularyFilters(ListVocabularyFiltersRequest request) 
        {
            return new ListVocabularyFiltersPaginator(this.client, request);
        }
    }
}