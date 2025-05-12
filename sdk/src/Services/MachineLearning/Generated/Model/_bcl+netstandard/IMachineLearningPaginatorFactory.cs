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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Paginators for the MachineLearning service
    ///</summary>
    public interface IMachineLearningPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeBatchPredictions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeBatchPredictionsPaginator DescribeBatchPredictions(DescribeBatchPredictionsRequest request);

        /// <summary>
        /// Paginator for DescribeDataSources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDataSourcesPaginator DescribeDataSources(DescribeDataSourcesRequest request);

        /// <summary>
        /// Paginator for DescribeEvaluations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeEvaluationsPaginator DescribeEvaluations(DescribeEvaluationsRequest request);

        /// <summary>
        /// Paginator for DescribeMLModels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMLModelsPaginator DescribeMLModels(DescribeMLModelsRequest request);
    }
}