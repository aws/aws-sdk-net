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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Paginators for the Bedrock service
    ///</summary>
    public class BedrockPaginatorFactory : IBedrockPaginatorFactory
    {
        private readonly IAmazonBedrock client;

        internal BedrockPaginatorFactory(IAmazonBedrock client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCustomModels operation
        ///</summary>
        public IListCustomModelsPaginator ListCustomModels(ListCustomModelsRequest request) 
        {
            return new ListCustomModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelCustomizationJobs operation
        ///</summary>
        public IListModelCustomizationJobsPaginator ListModelCustomizationJobs(ListModelCustomizationJobsRequest request) 
        {
            return new ListModelCustomizationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProvisionedModelThroughputs operation
        ///</summary>
        public IListProvisionedModelThroughputsPaginator ListProvisionedModelThroughputs(ListProvisionedModelThroughputsRequest request) 
        {
            return new ListProvisionedModelThroughputsPaginator(this.client, request);
        }
    }
}