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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Paginators for the Bedrock service
    ///</summary>
    public interface IBedrockPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListCustomModels operation
        ///</summary>
        IListCustomModelsPaginator ListCustomModels(ListCustomModelsRequest request);

        /// <summary>
        /// Paginator for ListModelCustomizationJobs operation
        ///</summary>
        IListModelCustomizationJobsPaginator ListModelCustomizationJobs(ListModelCustomizationJobsRequest request);

        /// <summary>
        /// Paginator for ListProvisionedModelThroughputs operation
        ///</summary>
        IListProvisionedModelThroughputsPaginator ListProvisionedModelThroughputs(ListProvisionedModelThroughputsRequest request);
    }
}