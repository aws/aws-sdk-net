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

#pragma warning disable CS0612,CS0618
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
        /// Paginator for ListAutomatedReasoningPolicies operation
        ///</summary>
        public IListAutomatedReasoningPoliciesPaginator ListAutomatedReasoningPolicies(ListAutomatedReasoningPoliciesRequest request) 
        {
            return new ListAutomatedReasoningPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutomatedReasoningPolicyBuildWorkflows operation
        ///</summary>
        public IListAutomatedReasoningPolicyBuildWorkflowsPaginator ListAutomatedReasoningPolicyBuildWorkflows(ListAutomatedReasoningPolicyBuildWorkflowsRequest request) 
        {
            return new ListAutomatedReasoningPolicyBuildWorkflowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutomatedReasoningPolicyTestCases operation
        ///</summary>
        public IListAutomatedReasoningPolicyTestCasesPaginator ListAutomatedReasoningPolicyTestCases(ListAutomatedReasoningPolicyTestCasesRequest request) 
        {
            return new ListAutomatedReasoningPolicyTestCasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutomatedReasoningPolicyTestResults operation
        ///</summary>
        public IListAutomatedReasoningPolicyTestResultsPaginator ListAutomatedReasoningPolicyTestResults(ListAutomatedReasoningPolicyTestResultsRequest request) 
        {
            return new ListAutomatedReasoningPolicyTestResultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomModelDeployments operation
        ///</summary>
        public IListCustomModelDeploymentsPaginator ListCustomModelDeployments(ListCustomModelDeploymentsRequest request) 
        {
            return new ListCustomModelDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomModels operation
        ///</summary>
        public IListCustomModelsPaginator ListCustomModels(ListCustomModelsRequest request) 
        {
            return new ListCustomModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEvaluationJobs operation
        ///</summary>
        public IListEvaluationJobsPaginator ListEvaluationJobs(ListEvaluationJobsRequest request) 
        {
            return new ListEvaluationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGuardrails operation
        ///</summary>
        public IListGuardrailsPaginator ListGuardrails(ListGuardrailsRequest request) 
        {
            return new ListGuardrailsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImportedModels operation
        ///</summary>
        public IListImportedModelsPaginator ListImportedModels(ListImportedModelsRequest request) 
        {
            return new ListImportedModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInferenceProfiles operation
        ///</summary>
        public IListInferenceProfilesPaginator ListInferenceProfiles(ListInferenceProfilesRequest request) 
        {
            return new ListInferenceProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMarketplaceModelEndpoints operation
        ///</summary>
        public IListMarketplaceModelEndpointsPaginator ListMarketplaceModelEndpoints(ListMarketplaceModelEndpointsRequest request) 
        {
            return new ListMarketplaceModelEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelCopyJobs operation
        ///</summary>
        public IListModelCopyJobsPaginator ListModelCopyJobs(ListModelCopyJobsRequest request) 
        {
            return new ListModelCopyJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelCustomizationJobs operation
        ///</summary>
        public IListModelCustomizationJobsPaginator ListModelCustomizationJobs(ListModelCustomizationJobsRequest request) 
        {
            return new ListModelCustomizationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelImportJobs operation
        ///</summary>
        public IListModelImportJobsPaginator ListModelImportJobs(ListModelImportJobsRequest request) 
        {
            return new ListModelImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelInvocationJobs operation
        ///</summary>
        public IListModelInvocationJobsPaginator ListModelInvocationJobs(ListModelInvocationJobsRequest request) 
        {
            return new ListModelInvocationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPromptRouters operation
        ///</summary>
        public IListPromptRoutersPaginator ListPromptRouters(ListPromptRoutersRequest request) 
        {
            return new ListPromptRoutersPaginator(this.client, request);
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