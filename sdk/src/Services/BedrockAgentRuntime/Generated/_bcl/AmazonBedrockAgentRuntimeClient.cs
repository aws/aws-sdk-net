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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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


        #region  InvokeAgent


        /// <summary>
        /// Sends a prompt for the agent to process and respond to.
        /// 
        ///  <note> 
        /// <para>
        /// The CLI doesn't support <c>InvokeAgent</c>.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// End a conversation by setting <c>endSession</c> to <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Include attributes for the session or prompt in the <c>sessionState</c> object.
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
        /// Errors are also surfaced in the response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAgent service method.</param>
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
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        public virtual InvokeAgentResponse InvokeAgent(InvokeAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAgentResponseUnmarshaller.Instance;

            return Invoke<InvokeAgentResponse>(request, options);
        }


        /// <summary>
        /// Sends a prompt for the agent to process and respond to.
        /// 
        ///  <note> 
        /// <para>
        /// The CLI doesn't support <c>InvokeAgent</c>.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// End a conversation by setting <c>endSession</c> to <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Include attributes for the session or prompt in the <c>sessionState</c> object.
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
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        
        #region  Retrieve


        /// <summary>
        /// Queries a knowledge base and retrieves information from it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Retrieve service method.</param>
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
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        public virtual RetrieveResponse Retrieve(RetrieveRequest request)
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
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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


        /// <summary>
        /// Queries a knowledge base and generates responses based on the retrieved results. The
        /// response cites up to five sources but only selects the ones that are relevant to the
        /// query.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>numberOfResults</c> field is currently unsupported for <c>RetrieveAndGenerate</c>.
        /// Don't include it in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_KnowledgeBaseVectorSearchConfiguration.html">vectorSearchConfiguration</a>
        /// object.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveAndGenerate service method.</param>
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
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        public virtual RetrieveAndGenerateResponse RetrieveAndGenerate(RetrieveAndGenerateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveAndGenerateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveAndGenerateResponseUnmarshaller.Instance;

            return Invoke<RetrieveAndGenerateResponse>(request, options);
        }


        /// <summary>
        /// Queries a knowledge base and generates responses based on the retrieved results. The
        /// response cites up to five sources but only selects the ones that are relevant to the
        /// query.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>numberOfResults</c> field is currently unsupported for <c>RetrieveAndGenerate</c>.
        /// Don't include it in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_KnowledgeBaseVectorSearchConfiguration.html">vectorSearchConfiguration</a>
        /// object.
        /// </para>
        ///  </note>
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
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonBedrockAgentRuntimeEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}