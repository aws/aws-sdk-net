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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Paginators for the BedrockDataAutomation service
    ///</summary>
    public class BedrockDataAutomationPaginatorFactory : IBedrockDataAutomationPaginatorFactory
    {
        private readonly IAmazonBedrockDataAutomation client;

        internal BedrockDataAutomationPaginatorFactory(IAmazonBedrockDataAutomation client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBlueprints operation
        ///</summary>
        public IListBlueprintsPaginator ListBlueprints(ListBlueprintsRequest request) 
        {
            return new ListBlueprintsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataAutomationProjects operation
        ///</summary>
        public IListDataAutomationProjectsPaginator ListDataAutomationProjects(ListDataAutomationProjectsRequest request) 
        {
            return new ListDataAutomationProjectsPaginator(this.client, request);
        }
    }
}