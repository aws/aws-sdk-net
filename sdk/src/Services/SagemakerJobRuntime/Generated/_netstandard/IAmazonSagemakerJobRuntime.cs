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
 * Do not modify this file. This file is generated from the sagemakerjobruntime-2026-02-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SagemakerJobRuntime.Model;

#pragma warning disable CS1570
namespace Amazon.SagemakerJobRuntime
{
    /// <summary>
    /// <para>Interface for accessing SagemakerJobRuntime</para>
    ///
    /// Agentic RFT Runtime Service - manages trajectory and transition data for reinforcement
    /// fine-tuning jobs.
    /// </summary>
    public partial interface IAmazonSagemakerJobRuntime : IAmazonService, IDisposable
    {
                
        #region  CompleteRollout



        /// <summary>
        /// Marks a rollout as complete, indicating that no further turns will be appended to
        /// the trajectory. After calling this operation, the trajectory is sealed and eligible
        /// for reward submission via the UpdateReward operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteRollout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompleteRollout service method, as returned by SagemakerJobRuntime.</returns>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.InternalServiceErrorException">
        /// An internal service error occurred. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakerjobruntime-2026-02-01/CompleteRollout">REST API Reference for CompleteRollout Operation</seealso>
        Task<CompleteRolloutResponse> CompleteRolloutAsync(CompleteRolloutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Sample



        /// <summary>
        /// Sends an inference request to the model during a job execution. The request and response
        /// bodies are forwarded to and from the model without modification. Each turn (prompt
        /// and response) is captured for later use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Sample service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Sample service method, as returned by SagemakerJobRuntime.</returns>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.InternalServiceErrorException">
        /// An internal service error occurred. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakerjobruntime-2026-02-01/Sample">REST API Reference for Sample Operation</seealso>
        Task<SampleResponse> SampleAsync(SampleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SampleWithResponseStream



        /// <summary>
        /// Sends a streaming inference request to the model during a job execution. Returns the
        /// response as a stream of payload chunks. Each turn is captured for later use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SampleWithResponseStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SampleWithResponseStream service method, as returned by SagemakerJobRuntime.</returns>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.InternalServiceErrorException">
        /// An internal service error occurred. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakerjobruntime-2026-02-01/SampleWithResponseStream">REST API Reference for SampleWithResponseStream Operation</seealso>
        Task<SampleWithResponseStreamResponse> SampleWithResponseStreamAsync(SampleWithResponseStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateReward



        /// <summary>
        /// Updates the reward values for a trajectory and transitions it to reward-received status,
        /// signaling that it is eligible for processing. Call this operation after CompleteRollout
        /// to provide the computed reward scores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReward service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReward service method, as returned by SagemakerJobRuntime.</returns>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.InternalServiceErrorException">
        /// An internal service error occurred. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.SagemakerJobRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakerjobruntime-2026-02-01/UpdateReward">REST API Reference for UpdateReward Operation</seealso>
        Task<UpdateRewardResponse> UpdateRewardAsync(UpdateRewardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSagemakerJobRuntimeConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSagemakerJobRuntimeConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSagemakerJobRuntimeConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSagemakerJobRuntimeConfig to create AmazonSagemakerJobRuntimeClient");
            }

            return awsCredentials == null ? 
                    new AmazonSagemakerJobRuntimeClient(serviceClientConfig) :
                    new AmazonSagemakerJobRuntimeClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}