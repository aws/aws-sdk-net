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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostAndUsageReport.Model
{
    /// <summary>
    /// Paginators for the CostAndUsageReport service
    ///</summary>
    public class CostAndUsageReportPaginatorFactory : ICostAndUsageReportPaginatorFactory
    {
        private readonly IAmazonCostAndUsageReport client;

        internal CostAndUsageReportPaginatorFactory(IAmazonCostAndUsageReport client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeReportDefinitions operation
        ///</summary>
        public IDescribeReportDefinitionsPaginator DescribeReportDefinitions(DescribeReportDefinitionsRequest request) 
        {
            return new DescribeReportDefinitionsPaginator(this.client, request);
        }
    }
}