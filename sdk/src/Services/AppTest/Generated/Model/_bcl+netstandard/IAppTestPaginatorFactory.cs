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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Paginators for the AppTest service
    ///</summary>
    public interface IAppTestPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListTestCases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestCasesPaginator ListTestCases(ListTestCasesRequest request);

        /// <summary>
        /// Paginator for ListTestConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestConfigurationsPaginator ListTestConfigurations(ListTestConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListTestRuns operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestRunsPaginator ListTestRuns(ListTestRunsRequest request);

        /// <summary>
        /// Paginator for ListTestRunSteps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestRunStepsPaginator ListTestRunSteps(ListTestRunStepsRequest request);

        /// <summary>
        /// Paginator for ListTestRunTestCases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestRunTestCasesPaginator ListTestRunTestCases(ListTestRunTestCasesRequest request);

        /// <summary>
        /// Paginator for ListTestSuites operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTestSuitesPaginator ListTestSuites(ListTestSuitesRequest request);
    }
}