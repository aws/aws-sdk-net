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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Paginators for the FraudDetector service
    ///</summary>
    public interface IFraudDetectorPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeModelVersions operation
        ///</summary>
        IDescribeModelVersionsPaginator DescribeModelVersions(DescribeModelVersionsRequest request);

        /// <summary>
        /// Paginator for GetBatchImportJobs operation
        ///</summary>
        IGetBatchImportJobsPaginator GetBatchImportJobs(GetBatchImportJobsRequest request);

        /// <summary>
        /// Paginator for GetBatchPredictionJobs operation
        ///</summary>
        IGetBatchPredictionJobsPaginator GetBatchPredictionJobs(GetBatchPredictionJobsRequest request);

        /// <summary>
        /// Paginator for GetDetectors operation
        ///</summary>
        IGetDetectorsPaginator GetDetectors(GetDetectorsRequest request);

        /// <summary>
        /// Paginator for GetEntityTypes operation
        ///</summary>
        IGetEntityTypesPaginator GetEntityTypes(GetEntityTypesRequest request);

        /// <summary>
        /// Paginator for GetEventTypes operation
        ///</summary>
        IGetEventTypesPaginator GetEventTypes(GetEventTypesRequest request);

        /// <summary>
        /// Paginator for GetExternalModels operation
        ///</summary>
        IGetExternalModelsPaginator GetExternalModels(GetExternalModelsRequest request);

        /// <summary>
        /// Paginator for GetLabels operation
        ///</summary>
        IGetLabelsPaginator GetLabels(GetLabelsRequest request);

        /// <summary>
        /// Paginator for GetListElements operation
        ///</summary>
        IGetListElementsPaginator GetListElements(GetListElementsRequest request);

        /// <summary>
        /// Paginator for GetListsMetadata operation
        ///</summary>
        IGetListsMetadataPaginator GetListsMetadata(GetListsMetadataRequest request);

        /// <summary>
        /// Paginator for GetModels operation
        ///</summary>
        IGetModelsPaginator GetModels(GetModelsRequest request);

        /// <summary>
        /// Paginator for GetOutcomes operation
        ///</summary>
        IGetOutcomesPaginator GetOutcomes(GetOutcomesRequest request);

        /// <summary>
        /// Paginator for GetRules operation
        ///</summary>
        IGetRulesPaginator GetRules(GetRulesRequest request);

        /// <summary>
        /// Paginator for GetVariables operation
        ///</summary>
        IGetVariablesPaginator GetVariables(GetVariablesRequest request);

        /// <summary>
        /// Paginator for ListEventPredictions operation
        ///</summary>
        IListEventPredictionsPaginator ListEventPredictions(ListEventPredictionsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);
    }
}