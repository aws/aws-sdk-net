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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Paginators for the LexModelsV2 service
    /// </summary>
    public interface ILexModelsV2PaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeBotAnalyzerRecommendation operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeBotAnalyzerRecommendationPaginator DescribeBotAnalyzerRecommendation(DescribeBotAnalyzerRecommendationRequest request);

        /// <summary>
        /// Paginator for ListAggregatedUtterances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAggregatedUtterancesPaginator ListAggregatedUtterances(ListAggregatedUtterancesRequest request);

        /// <summary>
        /// Paginator for ListBotAliasReplicas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotAliasReplicasPaginator ListBotAliasReplicas(ListBotAliasReplicasRequest request);

        /// <summary>
        /// Paginator for ListBotAliases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotAliasesPaginator ListBotAliases(ListBotAliasesRequest request);

        /// <summary>
        /// Paginator for ListBotAnalyzerHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotAnalyzerHistoryPaginator ListBotAnalyzerHistory(ListBotAnalyzerHistoryRequest request);

        /// <summary>
        /// Paginator for ListBotLocales operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotLocalesPaginator ListBotLocales(ListBotLocalesRequest request);

        /// <summary>
        /// Paginator for ListBotRecommendations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotRecommendationsPaginator ListBotRecommendations(ListBotRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListBotResourceGenerations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotResourceGenerationsPaginator ListBotResourceGenerations(ListBotResourceGenerationsRequest request);

        /// <summary>
        /// Paginator for ListBotVersionReplicas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotVersionReplicasPaginator ListBotVersionReplicas(ListBotVersionReplicasRequest request);

        /// <summary>
        /// Paginator for ListBotVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotVersionsPaginator ListBotVersions(ListBotVersionsRequest request);

        /// <summary>
        /// Paginator for ListBots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotsPaginator ListBots(ListBotsRequest request);

        /// <summary>
        /// Paginator for ListBuiltInIntents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBuiltInIntentsPaginator ListBuiltInIntents(ListBuiltInIntentsRequest request);

        /// <summary>
        /// Paginator for ListBuiltInSlotTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBuiltInSlotTypesPaginator ListBuiltInSlotTypes(ListBuiltInSlotTypesRequest request);

        /// <summary>
        /// Paginator for ListCustomVocabularyItems operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCustomVocabularyItemsPaginator ListCustomVocabularyItems(ListCustomVocabularyItemsRequest request);

        /// <summary>
        /// Paginator for ListExports operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExportsPaginator ListExports(ListExportsRequest request);

        /// <summary>
        /// Paginator for ListImports operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListImportsPaginator ListImports(ListImportsRequest request);

        /// <summary>
        /// Paginator for ListIntentMetrics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIntentMetricsPaginator ListIntentMetrics(ListIntentMetricsRequest request);

        /// <summary>
        /// Paginator for ListIntentStageMetrics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIntentStageMetricsPaginator ListIntentStageMetrics(ListIntentStageMetricsRequest request);

        /// <summary>
        /// Paginator for ListIntents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIntentsPaginator ListIntents(ListIntentsRequest request);

        /// <summary>
        /// Paginator for ListRecommendedIntents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecommendedIntentsPaginator ListRecommendedIntents(ListRecommendedIntentsRequest request);

        /// <summary>
        /// Paginator for ListSessionAnalyticsData operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSessionAnalyticsDataPaginator ListSessionAnalyticsData(ListSessionAnalyticsDataRequest request);

        /// <summary>
        /// Paginator for ListSessionMetrics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSessionMetricsPaginator ListSessionMetrics(ListSessionMetricsRequest request);

        /// <summary>
        /// Paginator for ListSlotTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSlotTypesPaginator ListSlotTypes(ListSlotTypesRequest request);

        /// <summary>
        /// Paginator for ListSlots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSlotsPaginator ListSlots(ListSlotsRequest request);

        /// <summary>
        /// Paginator for ListTestExecutionResultItems operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestExecutionResultItemsPaginator ListTestExecutionResultItems(ListTestExecutionResultItemsRequest request);

        /// <summary>
        /// Paginator for ListTestExecutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestExecutionsPaginator ListTestExecutions(ListTestExecutionsRequest request);

        /// <summary>
        /// Paginator for ListTestSetRecords operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestSetRecordsPaginator ListTestSetRecords(ListTestSetRecordsRequest request);

        /// <summary>
        /// Paginator for ListTestSets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestSetsPaginator ListTestSets(ListTestSetsRequest request);

        /// <summary>
        /// Paginator for ListUtteranceAnalyticsData operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUtteranceAnalyticsDataPaginator ListUtteranceAnalyticsData(ListUtteranceAnalyticsDataRequest request);

        /// <summary>
        /// Paginator for ListUtteranceMetrics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUtteranceMetricsPaginator ListUtteranceMetrics(ListUtteranceMetricsRequest request);
    }
}
