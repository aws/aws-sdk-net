#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Paginators for the Synthetics service
    ///</summary>
    public interface ISyntheticsPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeCanaries operation
        ///</summary>
        IDescribeCanariesPaginator DescribeCanaries(DescribeCanariesRequest request);

        /// <summary>
        /// Paginator for DescribeCanariesLastRun operation
        ///</summary>
        IDescribeCanariesLastRunPaginator DescribeCanariesLastRun(DescribeCanariesLastRunRequest request);

        /// <summary>
        /// Paginator for DescribeRuntimeVersions operation
        ///</summary>
        IDescribeRuntimeVersionsPaginator DescribeRuntimeVersions(DescribeRuntimeVersionsRequest request);

        /// <summary>
        /// Paginator for GetCanaryRuns operation
        ///</summary>
        IGetCanaryRunsPaginator GetCanaryRuns(GetCanaryRunsRequest request);
    }
}
#endif