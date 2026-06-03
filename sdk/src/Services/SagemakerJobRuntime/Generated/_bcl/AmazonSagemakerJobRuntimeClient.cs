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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SagemakerJobRuntime.Model;
using Amazon.SagemakerJobRuntime.Model.Internal.MarshallTransformations;
using Amazon.SagemakerJobRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SagemakerJobRuntime
{
    /// <summary>
    /// <para>Implementation for accessing SagemakerJobRuntime</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Agentic RFT Runtime Service - manages trajectory and transition data for reinforcement
    /// fine-tuning jobs.
    /// </summary>
    public partial class AmazonSagemakerJobRuntimeClient : AmazonServiceClient, IAmazonSagemakerJobRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonSagemakerJobRuntimeMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSagemakerJobRuntimeClient()
            : base(new AmazonSagemakerJobRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSagemakerJobRuntimeClient(RegionEndpoint region)
            : base(new AmazonSagemakerJobRuntimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSagemakerJobRuntimeClient Configuration Object</param>
        public AmazonSagemakerJobRuntimeClient(AmazonSagemakerJobRuntimeConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSagemakerJobRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonSagemakerJobRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSagemakerJobRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSagemakerJobRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with AWS Credentials and an
        /// AmazonSagemakerJobRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSagemakerJobRuntimeClient Configuration Object</param>
        public AmazonSagemakerJobRuntimeClient(AWSCredentials credentials, AmazonSagemakerJobRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSagemakerJobRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSagemakerJobRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSagemakerJobRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSagemakerJobRuntimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSagemakerJobRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSagemakerJobRuntimeClient Configuration Object</param>
        public AmazonSagemakerJobRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSagemakerJobRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSagemakerJobRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSagemakerJobRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSagemakerJobRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSagemakerJobRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerJobRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSagemakerJobRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSagemakerJobRuntimeClient Configuration Object</param>
        public AmazonSagemakerJobRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSagemakerJobRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSagemakerJobRuntimeEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSagemakerJobRuntimeAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CompleteRollout


        /// <summary>
        /// Marks a rollout as complete, indicating that no further turns will be appended to
        /// the trajectory. After calling this operation, the trajectory is sealed and eligible
        /// for reward submission via the UpdateReward operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteRollout service method.</param>
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
        public virtual CompleteRolloutResponse CompleteRollout(CompleteRolloutRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteRolloutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteRolloutResponseUnmarshaller.Instance;

            return Invoke<CompleteRolloutResponse>(request, options);
        }


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
        public virtual Task<CompleteRolloutResponse> CompleteRolloutAsync(CompleteRolloutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteRolloutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteRolloutResponseUnmarshaller.Instance;
            
            return InvokeAsync<CompleteRolloutResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Sample


        /// <summary>
        /// Sends an inference request to the model during a job execution. The request and response
        /// bodies are forwarded to and from the model without modification. Each turn (prompt
        /// and response) is captured for later use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Sample service method.</param>
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
        public virtual SampleResponse Sample(SampleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleResponseUnmarshaller.Instance;

            return Invoke<SampleResponse>(request, options);
        }


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
        public virtual Task<SampleResponse> SampleAsync(SampleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleResponseUnmarshaller.Instance;
            
            return InvokeAsync<SampleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SampleWithResponseStream


        /// <summary>
        /// Sends a streaming inference request to the model during a job execution. Returns the
        /// response as a stream of payload chunks. Each turn is captured for later use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SampleWithResponseStream service method.</param>
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
        public virtual SampleWithResponseStreamResponse SampleWithResponseStream(SampleWithResponseStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleWithResponseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleWithResponseStreamResponseUnmarshaller.Instance;

            return Invoke<SampleWithResponseStreamResponse>(request, options);
        }


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
        public virtual Task<SampleWithResponseStreamResponse> SampleWithResponseStreamAsync(SampleWithResponseStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleWithResponseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleWithResponseStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<SampleWithResponseStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateReward


        /// <summary>
        /// Updates the reward values for a trajectory and transitions it to reward-received status,
        /// signaling that it is eligible for processing. Call this operation after CompleteRollout
        /// to provide the computed reward scores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReward service method.</param>
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
        public virtual UpdateRewardResponse UpdateReward(UpdateRewardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRewardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRewardResponseUnmarshaller.Instance;

            return Invoke<UpdateRewardResponse>(request, options);
        }


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
        public virtual Task<UpdateRewardResponse> UpdateRewardAsync(UpdateRewardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRewardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRewardResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRewardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}