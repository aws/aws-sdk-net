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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Paginators for the Bedrock service
    ///</summary>
    public interface IBedrockPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAutomatedReasoningPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAutomatedReasoningPoliciesPaginator ListAutomatedReasoningPolicies(ListAutomatedReasoningPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAutomatedReasoningPolicyBuildWorkflows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAutomatedReasoningPolicyBuildWorkflowsPaginator ListAutomatedReasoningPolicyBuildWorkflows(ListAutomatedReasoningPolicyBuildWorkflowsRequest request);

        /// <summary>
        /// Paginator for ListAutomatedReasoningPolicyTestCases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAutomatedReasoningPolicyTestCasesPaginator ListAutomatedReasoningPolicyTestCases(ListAutomatedReasoningPolicyTestCasesRequest request);

        /// <summary>
        /// Paginator for ListAutomatedReasoningPolicyTestResults operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAutomatedReasoningPolicyTestResultsPaginator ListAutomatedReasoningPolicyTestResults(ListAutomatedReasoningPolicyTestResultsRequest request);

        /// <summary>
        /// Paginator for ListCustomModelDeployments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomModelDeploymentsPaginator ListCustomModelDeployments(ListCustomModelDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListCustomModels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomModelsPaginator ListCustomModels(ListCustomModelsRequest request);

        /// <summary>
        /// Paginator for ListEvaluationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEvaluationJobsPaginator ListEvaluationJobs(ListEvaluationJobsRequest request);

        /// <summary>
        /// Paginator for ListGuardrails operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGuardrailsPaginator ListGuardrails(ListGuardrailsRequest request);

        /// <summary>
        /// Paginator for ListImportedModels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImportedModelsPaginator ListImportedModels(ListImportedModelsRequest request);

        /// <summary>
        /// Paginator for ListInferenceProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInferenceProfilesPaginator ListInferenceProfiles(ListInferenceProfilesRequest request);

        /// <summary>
        /// Paginator for ListMarketplaceModelEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMarketplaceModelEndpointsPaginator ListMarketplaceModelEndpoints(ListMarketplaceModelEndpointsRequest request);

        /// <summary>
        /// Paginator for ListModelCopyJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelCopyJobsPaginator ListModelCopyJobs(ListModelCopyJobsRequest request);

        /// <summary>
        /// Paginator for ListModelCustomizationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelCustomizationJobsPaginator ListModelCustomizationJobs(ListModelCustomizationJobsRequest request);

        /// <summary>
        /// Paginator for ListModelImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelImportJobsPaginator ListModelImportJobs(ListModelImportJobsRequest request);

        /// <summary>
        /// Paginator for ListModelInvocationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelInvocationJobsPaginator ListModelInvocationJobs(ListModelInvocationJobsRequest request);

        /// <summary>
        /// Paginator for ListPromptRouters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPromptRoutersPaginator ListPromptRouters(ListPromptRoutersRequest request);

        /// <summary>
        /// Paginator for ListProvisionedModelThroughputs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProvisionedModelThroughputsPaginator ListProvisionedModelThroughputs(ListProvisionedModelThroughputsRequest request);
    }
}