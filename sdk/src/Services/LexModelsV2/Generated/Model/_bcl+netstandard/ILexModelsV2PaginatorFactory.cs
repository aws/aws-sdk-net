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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAggregatedUtterancesPaginator ListAggregatedUtterances(ListAggregatedUtterancesRequest request);

        /// <summary>
        /// Paginator for ListBotAliases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBotAliasesPaginator ListBotAliases(ListBotAliasesRequest request);

        /// <summary>
        /// Paginator for ListBotAliasReplicas operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBotAliasReplicasPaginator ListBotAliasReplicas(ListBotAliasReplicasRequest request);

        /// <summary>
        /// Paginator for ListBotLocales operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBotLocalesPaginator ListBotLocales(ListBotLocalesRequest request);

        /// <summary>
        /// Paginator for ListBotRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBotRecommendationsPaginator ListBotRecommendations(ListBotRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListBotResourceGenerations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBotResourceGenerationsPaginator ListBotResourceGenerations(ListBotResourceGenerationsRequest request);

        /// <summary>
        /// Paginator for ListBots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBotsPaginator ListBots(ListBotsRequest request);

        /// <summary>
        /// Paginator for ListBotVersionReplicas operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBotVersionReplicasPaginator ListBotVersionReplicas(ListBotVersionReplicasRequest request);

        /// <summary>
        /// Paginator for ListBotVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBotVersionsPaginator ListBotVersions(ListBotVersionsRequest request);

        /// <summary>
        /// Paginator for ListBuiltInIntents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBuiltInIntentsPaginator ListBuiltInIntents(ListBuiltInIntentsRequest request);

        /// <summary>
        /// Paginator for ListBuiltInSlotTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBuiltInSlotTypesPaginator ListBuiltInSlotTypes(ListBuiltInSlotTypesRequest request);

        /// <summary>
        /// Paginator for ListCustomVocabularyItems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomVocabularyItemsPaginator ListCustomVocabularyItems(ListCustomVocabularyItemsRequest request);

        /// <summary>
        /// Paginator for ListExports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExportsPaginator ListExports(ListExportsRequest request);

        /// <summary>
        /// Paginator for ListImports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImportsPaginator ListImports(ListImportsRequest request);

        /// <summary>
        /// Paginator for ListIntentMetrics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIntentMetricsPaginator ListIntentMetrics(ListIntentMetricsRequest request);

        /// <summary>
        /// Paginator for ListIntents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIntentsPaginator ListIntents(ListIntentsRequest request);

        /// <summary>
        /// Paginator for ListIntentStageMetrics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIntentStageMetricsPaginator ListIntentStageMetrics(ListIntentStageMetricsRequest request);

        /// <summary>
        /// Paginator for ListRecommendedIntents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecommendedIntentsPaginator ListRecommendedIntents(ListRecommendedIntentsRequest request);

        /// <summary>
        /// Paginator for ListSessionAnalyticsData operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSessionAnalyticsDataPaginator ListSessionAnalyticsData(ListSessionAnalyticsDataRequest request);

        /// <summary>
        /// Paginator for ListSessionMetrics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSessionMetricsPaginator ListSessionMetrics(ListSessionMetricsRequest request);

        /// <summary>
        /// Paginator for ListSlots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSlotsPaginator ListSlots(ListSlotsRequest request);

        /// <summary>
        /// Paginator for ListSlotTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSlotTypesPaginator ListSlotTypes(ListSlotTypesRequest request);

        /// <summary>
        /// Paginator for ListTestExecutionResultItems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestExecutionResultItemsPaginator ListTestExecutionResultItems(ListTestExecutionResultItemsRequest request);

        /// <summary>
        /// Paginator for ListTestExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestExecutionsPaginator ListTestExecutions(ListTestExecutionsRequest request);

        /// <summary>
        /// Paginator for ListTestSetRecords operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestSetRecordsPaginator ListTestSetRecords(ListTestSetRecordsRequest request);

        /// <summary>
        /// Paginator for ListTestSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestSetsPaginator ListTestSets(ListTestSetsRequest request);

        /// <summary>
        /// Paginator for ListUtteranceAnalyticsData operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUtteranceAnalyticsDataPaginator ListUtteranceAnalyticsData(ListUtteranceAnalyticsDataRequest request);

        /// <summary>
        /// Paginator for ListUtteranceMetrics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUtteranceMetricsPaginator ListUtteranceMetrics(ListUtteranceMetricsRequest request);
    }
}