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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Paginators for the LexModelsV2 service
    ///</summary>
    public interface ILexModelsV2PaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAggregatedUtterances operation
        ///</summary>
        IListAggregatedUtterancesPaginator ListAggregatedUtterances(ListAggregatedUtterancesRequest request);

        /// <summary>
        /// Paginator for ListBotAliases operation
        ///</summary>
        IListBotAliasesPaginator ListBotAliases(ListBotAliasesRequest request);

        /// <summary>
        /// Paginator for ListBotLocales operation
        ///</summary>
        IListBotLocalesPaginator ListBotLocales(ListBotLocalesRequest request);

        /// <summary>
        /// Paginator for ListBotRecommendations operation
        ///</summary>
        IListBotRecommendationsPaginator ListBotRecommendations(ListBotRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListBots operation
        ///</summary>
        IListBotsPaginator ListBots(ListBotsRequest request);

        /// <summary>
        /// Paginator for ListBotVersions operation
        ///</summary>
        IListBotVersionsPaginator ListBotVersions(ListBotVersionsRequest request);

        /// <summary>
        /// Paginator for ListBuiltInIntents operation
        ///</summary>
        IListBuiltInIntentsPaginator ListBuiltInIntents(ListBuiltInIntentsRequest request);

        /// <summary>
        /// Paginator for ListBuiltInSlotTypes operation
        ///</summary>
        IListBuiltInSlotTypesPaginator ListBuiltInSlotTypes(ListBuiltInSlotTypesRequest request);

        /// <summary>
        /// Paginator for ListCustomVocabularyItems operation
        ///</summary>
        IListCustomVocabularyItemsPaginator ListCustomVocabularyItems(ListCustomVocabularyItemsRequest request);

        /// <summary>
        /// Paginator for ListExports operation
        ///</summary>
        IListExportsPaginator ListExports(ListExportsRequest request);

        /// <summary>
        /// Paginator for ListImports operation
        ///</summary>
        IListImportsPaginator ListImports(ListImportsRequest request);

        /// <summary>
        /// Paginator for ListIntentMetrics operation
        ///</summary>
        IListIntentMetricsPaginator ListIntentMetrics(ListIntentMetricsRequest request);

        /// <summary>
        /// Paginator for ListIntents operation
        ///</summary>
        IListIntentsPaginator ListIntents(ListIntentsRequest request);

        /// <summary>
        /// Paginator for ListIntentStageMetrics operation
        ///</summary>
        IListIntentStageMetricsPaginator ListIntentStageMetrics(ListIntentStageMetricsRequest request);

        /// <summary>
        /// Paginator for ListRecommendedIntents operation
        ///</summary>
        IListRecommendedIntentsPaginator ListRecommendedIntents(ListRecommendedIntentsRequest request);

        /// <summary>
        /// Paginator for ListSessionAnalyticsData operation
        ///</summary>
        IListSessionAnalyticsDataPaginator ListSessionAnalyticsData(ListSessionAnalyticsDataRequest request);

        /// <summary>
        /// Paginator for ListSessionMetrics operation
        ///</summary>
        IListSessionMetricsPaginator ListSessionMetrics(ListSessionMetricsRequest request);

        /// <summary>
        /// Paginator for ListSlots operation
        ///</summary>
        IListSlotsPaginator ListSlots(ListSlotsRequest request);

        /// <summary>
        /// Paginator for ListSlotTypes operation
        ///</summary>
        IListSlotTypesPaginator ListSlotTypes(ListSlotTypesRequest request);

        /// <summary>
        /// Paginator for ListTestExecutionResultItems operation
        ///</summary>
        IListTestExecutionResultItemsPaginator ListTestExecutionResultItems(ListTestExecutionResultItemsRequest request);

        /// <summary>
        /// Paginator for ListTestExecutions operation
        ///</summary>
        IListTestExecutionsPaginator ListTestExecutions(ListTestExecutionsRequest request);

        /// <summary>
        /// Paginator for ListTestSetRecords operation
        ///</summary>
        IListTestSetRecordsPaginator ListTestSetRecords(ListTestSetRecordsRequest request);

        /// <summary>
        /// Paginator for ListTestSets operation
        ///</summary>
        IListTestSetsPaginator ListTestSets(ListTestSetsRequest request);

        /// <summary>
        /// Paginator for ListUtteranceAnalyticsData operation
        ///</summary>
        IListUtteranceAnalyticsDataPaginator ListUtteranceAnalyticsData(ListUtteranceAnalyticsDataRequest request);

        /// <summary>
        /// Paginator for ListUtteranceMetrics operation
        ///</summary>
        IListUtteranceMetricsPaginator ListUtteranceMetrics(ListUtteranceMetricsRequest request);
    }
}