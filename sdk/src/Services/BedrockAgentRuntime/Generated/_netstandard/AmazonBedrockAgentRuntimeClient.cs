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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BedrockAgentRuntime.Model;
using Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations;
using Amazon.BedrockAgentRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.BedrockAgentRuntime
{
    /// <summary>
    /// <para>Implementation for accessing BedrockAgentRuntime</para>
    ///
    /// Contains APIs related to model invocation and querying of knowledge bases.
    /// </summary>
    public partial class AmazonBedrockAgentRuntimeClient : AmazonServiceClient, IAmazonBedrockAgentRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockAgentRuntimeMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with the credentials loaded from the application's
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
        public AmazonBedrockAgentRuntimeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockAgentRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with the credentials loaded from the application's
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
        public AmazonBedrockAgentRuntimeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockAgentRuntimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockAgentRuntimeClient Configuration Object</param>
        public AmazonBedrockAgentRuntimeClient(AmazonBedrockAgentRuntimeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockAgentRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockAgentRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockAgentRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with AWS Credentials and an
        /// AmazonBedrockAgentRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockAgentRuntimeClient Configuration Object</param>
        public AmazonBedrockAgentRuntimeClient(AWSCredentials credentials, AmazonBedrockAgentRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockAgentRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockAgentRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockAgentRuntimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockAgentRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockAgentRuntimeClient Configuration Object</param>
        public AmazonBedrockAgentRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockAgentRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockAgentRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockAgentRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockAgentRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockAgentRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockAgentRuntimeClient Configuration Object</param>
        public AmazonBedrockAgentRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockAgentRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IBedrockAgentRuntimePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBedrockAgentRuntimePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BedrockAgentRuntimePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockAgentRuntimeEndpointResolver());
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


        #region  DeleteAgentMemory

        internal virtual DeleteAgentMemoryResponse DeleteAgentMemory(DeleteAgentMemoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentMemoryResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentMemoryResponse>(request, options);
        }



        /// <summary>
        /// Deletes memory from the specified memory identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentMemory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentMemory service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/DeleteAgentMemory">REST API Reference for DeleteAgentMemory Operation</seealso>
        public virtual Task<DeleteAgentMemoryResponse> DeleteAgentMemoryAsync(DeleteAgentMemoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentMemoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentMemoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateQuery

        internal virtual GenerateQueryResponse GenerateQuery(GenerateQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateQueryResponseUnmarshaller.Instance;

            return Invoke<GenerateQueryResponse>(request, options);
        }



        /// <summary>
        /// Generates an SQL query from a natural language query. For more information, see <a
        /// href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-generate-query.html">Generate
        /// a query for structured data</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateQuery service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GenerateQuery">REST API Reference for GenerateQuery Operation</seealso>
        public virtual Task<GenerateQueryResponse> GenerateQueryAsync(GenerateQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateQueryResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAgentMemory

        internal virtual GetAgentMemoryResponse GetAgentMemory(GetAgentMemoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentMemoryResponseUnmarshaller.Instance;

            return Invoke<GetAgentMemoryResponse>(request, options);
        }



        /// <summary>
        /// Gets the sessions stored in the memory of the agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentMemory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentMemory service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GetAgentMemory">REST API Reference for GetAgentMemory Operation</seealso>
        public virtual Task<GetAgentMemoryResponse> GetAgentMemoryAsync(GetAgentMemoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentMemoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgentMemoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeAgent

        internal virtual InvokeAgentResponse InvokeAgent(InvokeAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAgentResponseUnmarshaller.Instance;

            return Invoke<InvokeAgentResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeAgent</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sends a prompt for the agent to process and respond to. Note the following fields
        /// for the request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To continue the same conversation with an agent, use the same <c>sessionId</c> value
        /// in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To activate trace enablement, turn <c>enableTrace</c> to <c>true</c>. Trace enablement
        /// helps you follow the agent's reasoning process that led it to the information it processed,
        /// the actions it took, and the final result it yielded. For more information, see <a
        /// href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-test.html#trace-events">Trace
        /// enablement</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To stream agent responses, make sure that only orchestration prompt is enabled. Agent
        /// streaming is not supported for the following steps: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Pre-processing</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Post-processing</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Agent with 1 Knowledge base and <c>User Input</c> not enabled
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// End a conversation by setting <c>endSession</c> to <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the <c>sessionState</c> object, you can include attributes for the session or prompt
        /// or, if you configured an action group to return control, results from invocation of
        /// the action group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The response is returned in the <c>bytes</c> field of the <c>chunk</c> object.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>attribution</c> object contains citations for parts of the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set <c>enableTrace</c> to <c>true</c> in the request, you can trace the agent's
        /// steps and reasoning process that led it to the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the action predicted was configured to return control, the response returns parameters
        /// for the action, elicited from the user, in the <c>returnControl</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Errors are also surfaced in the response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeAgent service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The
        /// AWS SDK will automatically retry the operation up to 5 times. For information about
        /// configuring automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeAgent">REST API Reference for InvokeAgent Operation</seealso>
        public virtual Task<InvokeAgentResponse> InvokeAgentAsync(InvokeAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAgentResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeFlow

        internal virtual InvokeFlowResponse InvokeFlow(InvokeFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeFlowResponseUnmarshaller.Instance;

            return Invoke<InvokeFlowResponse>(request, options);
        }



        /// <summary>
        /// Invokes an alias of a flow to run the inputs that you specify and return the output
        /// of each node as a stream. If there's an error, the error is returned. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-test.html">Test
        /// a flow in Amazon Bedrock</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// 
        ///  <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeFlow</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeFlow service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeFlow">REST API Reference for InvokeFlow Operation</seealso>
        public virtual Task<InvokeFlowResponse> InvokeFlowAsync(InvokeFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeFlowResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeInlineAgent

        internal virtual InvokeInlineAgentResponse InvokeInlineAgent(InvokeInlineAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeInlineAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeInlineAgentResponseUnmarshaller.Instance;

            return Invoke<InvokeInlineAgentResponse>(request, options);
        }



        /// <summary>
        /// Invokes an inline Amazon Bedrock agent using the configurations you provide with
        /// the request. 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Specify the following fields for security purposes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// (Optional) <c>customerEncryptionKeyArn</c> – The Amazon Resource Name (ARN) of a KMS
        /// key to encrypt the creation of the agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) <c>idleSessionTTLinSeconds</c> – Specify the number of seconds for which
        /// the agent should maintain session information. After this time expires, the subsequent
        /// <c>InvokeInlineAgent</c> request begins a new session.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// To override the default prompt behavior for agent orchestration and to use advanced
        /// prompts, include a <c>promptOverrideConfiguration</c> object. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
        /// prompts</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The agent instructions will not be honored if your agent has only one knowledge base,
        /// uses default prompts, has no action group, and user input is disabled.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeInlineAgent</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeInlineAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeInlineAgent service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeInlineAgent">REST API Reference for InvokeInlineAgent Operation</seealso>
        public virtual Task<InvokeInlineAgentResponse> InvokeInlineAgentAsync(InvokeInlineAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeInlineAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeInlineAgentResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeInlineAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  OptimizePrompt

        internal virtual OptimizePromptResponse OptimizePrompt(OptimizePromptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OptimizePromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OptimizePromptResponseUnmarshaller.Instance;

            return Invoke<OptimizePromptResponse>(request, options);
        }



        /// <summary>
        /// Optimizes a prompt for the task that you specify. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-optimize.html">Optimize
        /// a prompt</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptimizePrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OptimizePrompt service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/OptimizePrompt">REST API Reference for OptimizePrompt Operation</seealso>
        public virtual Task<OptimizePromptResponse> OptimizePromptAsync(OptimizePromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OptimizePromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OptimizePromptResponseUnmarshaller.Instance;

            return InvokeAsync<OptimizePromptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Rerank

        internal virtual RerankResponse Rerank(RerankRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RerankRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RerankResponseUnmarshaller.Instance;

            return Invoke<RerankResponse>(request, options);
        }



        /// <summary>
        /// Reranks the relevance of sources based on queries. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/rerank.html">Improve
        /// the relevance of query responses with a reranker model</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Rerank service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Rerank service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/Rerank">REST API Reference for Rerank Operation</seealso>
        public virtual Task<RerankResponse> RerankAsync(RerankRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RerankRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RerankResponseUnmarshaller.Instance;

            return InvokeAsync<RerankResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Retrieve

        internal virtual RetrieveResponse Retrieve(RetrieveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveResponseUnmarshaller.Instance;

            return Invoke<RetrieveResponse>(request, options);
        }



        /// <summary>
        /// Queries a knowledge base and retrieves information from it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Retrieve service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Retrieve service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/Retrieve">REST API Reference for Retrieve Operation</seealso>
        public virtual Task<RetrieveResponse> RetrieveAsync(RetrieveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetrieveAndGenerate

        internal virtual RetrieveAndGenerateResponse RetrieveAndGenerate(RetrieveAndGenerateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveAndGenerateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveAndGenerateResponseUnmarshaller.Instance;

            return Invoke<RetrieveAndGenerateResponse>(request, options);
        }



        /// <summary>
        /// Queries a knowledge base and generates responses based on the retrieved results and
        /// using the specified foundation model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
        /// profile</a>. The response only cites sources that are relevant to the query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveAndGenerate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetrieveAndGenerate service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/RetrieveAndGenerate">REST API Reference for RetrieveAndGenerate Operation</seealso>
        public virtual Task<RetrieveAndGenerateResponse> RetrieveAndGenerateAsync(RetrieveAndGenerateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveAndGenerateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveAndGenerateResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveAndGenerateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetrieveAndGenerateStream

        internal virtual RetrieveAndGenerateStreamResponse RetrieveAndGenerateStream(RetrieveAndGenerateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveAndGenerateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveAndGenerateStreamResponseUnmarshaller.Instance;

            return Invoke<RetrieveAndGenerateStreamResponse>(request, options);
        }



        /// <summary>
        /// Queries a knowledge base and generates responses based on the retrieved results, with
        /// output in streaming format.
        /// 
        ///  <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeModelWithResponseStream</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveAndGenerateStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetrieveAndGenerateStream service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/RetrieveAndGenerateStream">REST API Reference for RetrieveAndGenerateStream Operation</seealso>
        public virtual Task<RetrieveAndGenerateStreamResponse> RetrieveAndGenerateStreamAsync(RetrieveAndGenerateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveAndGenerateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveAndGenerateStreamResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveAndGenerateStreamResponse>(request, options, cancellationToken);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonBedrockAgentRuntimeEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}