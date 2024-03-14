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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Paginators for the FraudDetector service
    ///</summary>
    public class FraudDetectorPaginatorFactory : IFraudDetectorPaginatorFactory
    {
        private readonly IAmazonFraudDetector client;

        internal FraudDetectorPaginatorFactory(IAmazonFraudDetector client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeModelVersions operation
        ///</summary>
        public IDescribeModelVersionsPaginator DescribeModelVersions(DescribeModelVersionsRequest request) 
        {
            return new DescribeModelVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetBatchImportJobs operation
        ///</summary>
        public IGetBatchImportJobsPaginator GetBatchImportJobs(GetBatchImportJobsRequest request) 
        {
            return new GetBatchImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetBatchPredictionJobs operation
        ///</summary>
        public IGetBatchPredictionJobsPaginator GetBatchPredictionJobs(GetBatchPredictionJobsRequest request) 
        {
            return new GetBatchPredictionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetDetectors operation
        ///</summary>
        public IGetDetectorsPaginator GetDetectors(GetDetectorsRequest request) 
        {
            return new GetDetectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetEntityTypes operation
        ///</summary>
        public IGetEntityTypesPaginator GetEntityTypes(GetEntityTypesRequest request) 
        {
            return new GetEntityTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetEventTypes operation
        ///</summary>
        public IGetEventTypesPaginator GetEventTypes(GetEventTypesRequest request) 
        {
            return new GetEventTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetExternalModels operation
        ///</summary>
        public IGetExternalModelsPaginator GetExternalModels(GetExternalModelsRequest request) 
        {
            return new GetExternalModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetLabels operation
        ///</summary>
        public IGetLabelsPaginator GetLabels(GetLabelsRequest request) 
        {
            return new GetLabelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetListElements operation
        ///</summary>
        public IGetListElementsPaginator GetListElements(GetListElementsRequest request) 
        {
            return new GetListElementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetListsMetadata operation
        ///</summary>
        public IGetListsMetadataPaginator GetListsMetadata(GetListsMetadataRequest request) 
        {
            return new GetListsMetadataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetModels operation
        ///</summary>
        public IGetModelsPaginator GetModels(GetModelsRequest request) 
        {
            return new GetModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetOutcomes operation
        ///</summary>
        public IGetOutcomesPaginator GetOutcomes(GetOutcomesRequest request) 
        {
            return new GetOutcomesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetRules operation
        ///</summary>
        public IGetRulesPaginator GetRules(GetRulesRequest request) 
        {
            return new GetRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetVariables operation
        ///</summary>
        public IGetVariablesPaginator GetVariables(GetVariablesRequest request) 
        {
            return new GetVariablesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventPredictions operation
        ///</summary>
        public IListEventPredictionsPaginator ListEventPredictions(ListEventPredictionsRequest request) 
        {
            return new ListEventPredictionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}