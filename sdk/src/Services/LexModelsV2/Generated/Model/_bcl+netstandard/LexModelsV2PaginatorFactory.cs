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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Paginators for the LexModelsV2 service
    ///</summary>
    public class LexModelsV2PaginatorFactory : ILexModelsV2PaginatorFactory
    {
        private readonly IAmazonLexModelsV2 client;

        internal LexModelsV2PaginatorFactory(IAmazonLexModelsV2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAggregatedUtterances operation
        ///</summary>
        public IListAggregatedUtterancesPaginator ListAggregatedUtterances(ListAggregatedUtterancesRequest request) 
        {
            return new ListAggregatedUtterancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBotAliases operation
        ///</summary>
        public IListBotAliasesPaginator ListBotAliases(ListBotAliasesRequest request) 
        {
            return new ListBotAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBotAliasReplicas operation
        ///</summary>
        public IListBotAliasReplicasPaginator ListBotAliasReplicas(ListBotAliasReplicasRequest request) 
        {
            return new ListBotAliasReplicasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBotLocales operation
        ///</summary>
        public IListBotLocalesPaginator ListBotLocales(ListBotLocalesRequest request) 
        {
            return new ListBotLocalesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBotRecommendations operation
        ///</summary>
        public IListBotRecommendationsPaginator ListBotRecommendations(ListBotRecommendationsRequest request) 
        {
            return new ListBotRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBotResourceGenerations operation
        ///</summary>
        public IListBotResourceGenerationsPaginator ListBotResourceGenerations(ListBotResourceGenerationsRequest request) 
        {
            return new ListBotResourceGenerationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBots operation
        ///</summary>
        public IListBotsPaginator ListBots(ListBotsRequest request) 
        {
            return new ListBotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBotVersionReplicas operation
        ///</summary>
        public IListBotVersionReplicasPaginator ListBotVersionReplicas(ListBotVersionReplicasRequest request) 
        {
            return new ListBotVersionReplicasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBotVersions operation
        ///</summary>
        public IListBotVersionsPaginator ListBotVersions(ListBotVersionsRequest request) 
        {
            return new ListBotVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBuiltInIntents operation
        ///</summary>
        public IListBuiltInIntentsPaginator ListBuiltInIntents(ListBuiltInIntentsRequest request) 
        {
            return new ListBuiltInIntentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBuiltInSlotTypes operation
        ///</summary>
        public IListBuiltInSlotTypesPaginator ListBuiltInSlotTypes(ListBuiltInSlotTypesRequest request) 
        {
            return new ListBuiltInSlotTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomVocabularyItems operation
        ///</summary>
        public IListCustomVocabularyItemsPaginator ListCustomVocabularyItems(ListCustomVocabularyItemsRequest request) 
        {
            return new ListCustomVocabularyItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExports operation
        ///</summary>
        public IListExportsPaginator ListExports(ListExportsRequest request) 
        {
            return new ListExportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImports operation
        ///</summary>
        public IListImportsPaginator ListImports(ListImportsRequest request) 
        {
            return new ListImportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIntentMetrics operation
        ///</summary>
        public IListIntentMetricsPaginator ListIntentMetrics(ListIntentMetricsRequest request) 
        {
            return new ListIntentMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIntents operation
        ///</summary>
        public IListIntentsPaginator ListIntents(ListIntentsRequest request) 
        {
            return new ListIntentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIntentStageMetrics operation
        ///</summary>
        public IListIntentStageMetricsPaginator ListIntentStageMetrics(ListIntentStageMetricsRequest request) 
        {
            return new ListIntentStageMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendedIntents operation
        ///</summary>
        public IListRecommendedIntentsPaginator ListRecommendedIntents(ListRecommendedIntentsRequest request) 
        {
            return new ListRecommendedIntentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessionAnalyticsData operation
        ///</summary>
        public IListSessionAnalyticsDataPaginator ListSessionAnalyticsData(ListSessionAnalyticsDataRequest request) 
        {
            return new ListSessionAnalyticsDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessionMetrics operation
        ///</summary>
        public IListSessionMetricsPaginator ListSessionMetrics(ListSessionMetricsRequest request) 
        {
            return new ListSessionMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSlots operation
        ///</summary>
        public IListSlotsPaginator ListSlots(ListSlotsRequest request) 
        {
            return new ListSlotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSlotTypes operation
        ///</summary>
        public IListSlotTypesPaginator ListSlotTypes(ListSlotTypesRequest request) 
        {
            return new ListSlotTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestExecutionResultItems operation
        ///</summary>
        public IListTestExecutionResultItemsPaginator ListTestExecutionResultItems(ListTestExecutionResultItemsRequest request) 
        {
            return new ListTestExecutionResultItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestExecutions operation
        ///</summary>
        public IListTestExecutionsPaginator ListTestExecutions(ListTestExecutionsRequest request) 
        {
            return new ListTestExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestSetRecords operation
        ///</summary>
        public IListTestSetRecordsPaginator ListTestSetRecords(ListTestSetRecordsRequest request) 
        {
            return new ListTestSetRecordsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestSets operation
        ///</summary>
        public IListTestSetsPaginator ListTestSets(ListTestSetsRequest request) 
        {
            return new ListTestSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUtteranceAnalyticsData operation
        ///</summary>
        public IListUtteranceAnalyticsDataPaginator ListUtteranceAnalyticsData(ListUtteranceAnalyticsDataRequest request) 
        {
            return new ListUtteranceAnalyticsDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUtteranceMetrics operation
        ///</summary>
        public IListUtteranceMetricsPaginator ListUtteranceMetrics(ListUtteranceMetricsRequest request) 
        {
            return new ListUtteranceMetricsPaginator(this.client, request);
        }
    }
}