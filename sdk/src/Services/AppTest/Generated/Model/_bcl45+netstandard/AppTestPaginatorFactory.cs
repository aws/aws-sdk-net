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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Paginators for the AppTest service
    ///</summary>
    public class AppTestPaginatorFactory : IAppTestPaginatorFactory
    {
        private readonly IAmazonAppTest client;

        internal AppTestPaginatorFactory(IAmazonAppTest client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListTestCases operation
        ///</summary>
        public IListTestCasesPaginator ListTestCases(ListTestCasesRequest request) 
        {
            return new ListTestCasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestConfigurations operation
        ///</summary>
        public IListTestConfigurationsPaginator ListTestConfigurations(ListTestConfigurationsRequest request) 
        {
            return new ListTestConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestRuns operation
        ///</summary>
        public IListTestRunsPaginator ListTestRuns(ListTestRunsRequest request) 
        {
            return new ListTestRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestRunSteps operation
        ///</summary>
        public IListTestRunStepsPaginator ListTestRunSteps(ListTestRunStepsRequest request) 
        {
            return new ListTestRunStepsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestRunTestCases operation
        ///</summary>
        public IListTestRunTestCasesPaginator ListTestRunTestCases(ListTestRunTestCasesRequest request) 
        {
            return new ListTestRunTestCasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestSuites operation
        ///</summary>
        public IListTestSuitesPaginator ListTestSuites(ListTestSuitesRequest request) 
        {
            return new ListTestSuitesPaginator(this.client, request);
        }
    }
}