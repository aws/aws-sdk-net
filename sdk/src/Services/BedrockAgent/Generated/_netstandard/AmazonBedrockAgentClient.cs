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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BedrockAgent.Model;
using Amazon.BedrockAgent.Model.Internal.MarshallTransformations;
using Amazon.BedrockAgent.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.BedrockAgent
{
    /// <summary>
    /// <para>Implementation for accessing BedrockAgent</para>
    ///
    /// Describes the API operations for creating and managing Amazon Bedrock agents.
    /// </summary>
    public partial class AmazonBedrockAgentClient : AmazonServiceClient, IAmazonBedrockAgent
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockAgentMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with the credentials loaded from the application's
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
        public AmazonBedrockAgentClient()
            : base(new AmazonBedrockAgentConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with the credentials loaded from the application's
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
        public AmazonBedrockAgentClient(RegionEndpoint region)
            : base(new AmazonBedrockAgentConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockAgentClient Configuration Object</param>
        public AmazonBedrockAgentClient(AmazonBedrockAgentConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockAgentClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockAgentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Credentials and an
        /// AmazonBedrockAgentClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockAgentClient Configuration Object</param>
        public AmazonBedrockAgentClient(AWSCredentials credentials, AmazonBedrockAgentConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockAgentConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockAgentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockAgentClient Configuration Object</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockAgentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockAgentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockAgentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockAgentClient Configuration Object</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockAgentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IBedrockAgentPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBedrockAgentPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BedrockAgentPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockAgentEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockAgentAuthSchemeHandler());
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


        #region  AssociateAgentCollaborator

        internal virtual AssociateAgentCollaboratorResponse AssociateAgentCollaborator(AssociateAgentCollaboratorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAgentCollaboratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAgentCollaboratorResponseUnmarshaller.Instance;

            return Invoke<AssociateAgentCollaboratorResponse>(request, options);
        }



        /// <summary>
        /// Makes an agent a collaborator for another agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAgentCollaborator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAgentCollaborator service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/AssociateAgentCollaborator">REST API Reference for AssociateAgentCollaborator Operation</seealso>
        public virtual Task<AssociateAgentCollaboratorResponse> AssociateAgentCollaboratorAsync(AssociateAgentCollaboratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAgentCollaboratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAgentCollaboratorResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAgentCollaboratorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateAgentKnowledgeBase

        internal virtual AssociateAgentKnowledgeBaseResponse AssociateAgentKnowledgeBase(AssociateAgentKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<AssociateAgentKnowledgeBaseResponse>(request, options);
        }



        /// <summary>
        /// Associates a knowledge base with an agent. If a knowledge base is associated and its
        /// <c>indexState</c> is set to <c>Enabled</c>, the agent queries the knowledge base for
        /// information to augment its response to the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAgentKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/AssociateAgentKnowledgeBase">REST API Reference for AssociateAgentKnowledgeBase Operation</seealso>
        public virtual Task<AssociateAgentKnowledgeBaseResponse> AssociateAgentKnowledgeBaseAsync(AssociateAgentKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAgentKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAgent

        internal virtual CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return Invoke<CreateAgentResponse>(request, options);
        }



        /// <summary>
        /// Creates an agent that orchestrates interactions between foundation models, data sources,
        /// software applications, user conversations, and APIs to carry out tasks to help customers.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Specify the following fields for security purposes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>agentResourceRoleArn</c> – The Amazon Resource Name (ARN) of the role with permissions
        /// to invoke API operations on an agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) <c>customerEncryptionKeyArn</c> – The Amazon Resource Name (ARN) of a KMS
        /// key to encrypt the creation of the agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) <c>idleSessionTTLinSeconds</c> – Specify the number of seconds for which
        /// the agent should maintain session information. After this time expires, the subsequent
        /// <c>InvokeAgent</c> request begins a new session.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// To enable your agent to retain conversational context across multiple sessions, include
        /// a <c>memoryConfiguration</c> object. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-configure-memory.html">Configure
        /// memory</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To override the default prompt behavior for agent orchestration and to use advanced
        /// prompts, include a <c>promptOverrideConfiguration</c> object. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
        /// prompts</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your agent fails to be created, the response returns a list of <c>failureReasons</c>
        /// alongside a list of <c>recommendedActions</c> for you to troubleshoot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The agent instructions will not be honored if your agent has only one knowledge base,
        /// uses default prompts, has no action group, and user input is disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        public virtual Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAgentActionGroup

        internal virtual CreateAgentActionGroupResponse CreateAgentActionGroup(CreateAgentActionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentActionGroupResponseUnmarshaller.Instance;

            return Invoke<CreateAgentActionGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates an action group for an agent. An action group represents the actions that
        /// an agent can carry out for the customer by defining the APIs that an agent can call
        /// and the logic for calling them.
        /// 
        ///  
        /// <para>
        /// To allow your agent to request the user for additional information when trying to
        /// complete a task, add an action group with the <c>parentActionGroupSignature</c> field
        /// set to <c>AMAZON.UserInput</c>. 
        /// </para>
        ///  
        /// <para>
        /// To allow your agent to generate, run, and troubleshoot code when trying to complete
        /// a task, add an action group with the <c>parentActionGroupSignature</c> field set to
        /// <c>AMAZON.CodeInterpreter</c>. 
        /// </para>
        ///  
        /// <para>
        /// You must leave the <c>description</c>, <c>apiSchema</c>, and <c>actionGroupExecutor</c>
        /// fields blank for this action group. During orchestration, if your agent determines
        /// that it needs to invoke an API in an action group, but doesn't have enough information
        /// to complete the API request, it will invoke this action group instead and return an
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Observation.html">Observation</a>
        /// reprompting the user for more information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentActionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentActionGroup">REST API Reference for CreateAgentActionGroup Operation</seealso>
        public virtual Task<CreateAgentActionGroupResponse> CreateAgentActionGroupAsync(CreateAgentActionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentActionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAgentActionGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAgentAlias

        internal virtual CreateAgentAliasResponse CreateAgentAlias(CreateAgentAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAgentAliasResponse>(request, options);
        }



        /// <summary>
        /// Creates an alias of an agent that can be used to deploy the agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentAlias">REST API Reference for CreateAgentAlias Operation</seealso>
        public virtual Task<CreateAgentAliasResponse> CreateAgentAliasAsync(CreateAgentAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAgentAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataSource

        internal virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Connects a knowledge base to a data source. You specify the configuration for the
        /// specific data source service in the <c>dataSourceConfiguration</c> field.
        /// 
        ///  <important> 
        /// <para>
        /// You can't change the <c>chunkingConfiguration</c> after you create the data source
        /// connector.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFlow

        internal virtual CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;

            return Invoke<CreateFlowResponse>(request, options);
        }



        /// <summary>
        /// Creates a prompt flow that you can use to send an input through various steps to yield
        /// an output. Configure nodes, each of which corresponds to a step of the flow, and create
        /// connections between the nodes to create paths to different outputs. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-how-it-works.html">How
        /// it works</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-create.html">Create
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlow service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFlowAlias

        internal virtual CreateFlowAliasResponse CreateFlowAlias(CreateFlowAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowAliasResponseUnmarshaller.Instance;

            return Invoke<CreateFlowAliasResponse>(request, options);
        }



        /// <summary>
        /// Creates an alias of a flow for deployment. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-deploy.html">Deploy
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlowAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateFlowAlias">REST API Reference for CreateFlowAlias Operation</seealso>
        public virtual Task<CreateFlowAliasResponse> CreateFlowAliasAsync(CreateFlowAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFlowVersion

        internal virtual CreateFlowVersionResponse CreateFlowVersion(CreateFlowVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowVersionResponseUnmarshaller.Instance;

            return Invoke<CreateFlowVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a version of the flow that you can deploy. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-deploy.html">Deploy
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlowVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateFlowVersion">REST API Reference for CreateFlowVersion Operation</seealso>
        public virtual Task<CreateFlowVersionResponse> CreateFlowVersionAsync(CreateFlowVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKnowledgeBase

        internal virtual CreateKnowledgeBaseResponse CreateKnowledgeBase(CreateKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<CreateKnowledgeBaseResponse>(request, options);
        }



        /// <summary>
        /// Creates a knowledge base. A knowledge base contains your data sources so that Large
        /// Language Models (LLMs) can use your data. To create a knowledge base, you must first
        /// set up your data sources and configure a supported vector store. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowlege-base-prereq.html">Set
        /// up a knowledge base</a>.
        /// 
        ///  <note> 
        /// <para>
        /// If you prefer to let Amazon Bedrock create and manage a vector store for you in Amazon
        /// OpenSearch Service, use the console. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-create">Create
        /// a knowledge base</a>.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// Provide the <c>name</c> and an optional <c>description</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the Amazon Resource Name (ARN) with permissions to create a knowledge base
        /// in the <c>roleArn</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the embedding model to use in the <c>embeddingModelArn</c> field in the <c>knowledgeBaseConfiguration</c>
        /// object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the configuration for your vector store in the <c>storageConfiguration</c>
        /// object.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For an Amazon OpenSearch Service database, use the <c>opensearchServerlessConfiguration</c>
        /// object. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-oss.html">Create
        /// a vector store in Amazon OpenSearch Service</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amazon Aurora database, use the <c>RdsConfiguration</c> object. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-rds.html">Create
        /// a vector store in Amazon Aurora</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a Pinecone database, use the <c>pineconeConfiguration</c> object. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-pinecone.html">Create
        /// a vector store in Pinecone</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a Redis Enterprise Cloud database, use the <c>redisEnterpriseCloudConfiguration</c>
        /// object. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-redis.html">Create
        /// a vector store in Redis Enterprise Cloud</a>.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        public virtual Task<CreateKnowledgeBaseResponse> CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePrompt

        internal virtual CreatePromptResponse CreatePrompt(CreatePromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePromptResponseUnmarshaller.Instance;

            return Invoke<CreatePromptResponse>(request, options);
        }



        /// <summary>
        /// Creates a prompt in your prompt library that you can add to a flow. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management.html">Prompt
        /// management in Amazon Bedrock</a>, <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-create.html">Create
        /// a prompt using Prompt management</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows.html">Prompt
        /// flows in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrompt service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreatePrompt">REST API Reference for CreatePrompt Operation</seealso>
        public virtual Task<CreatePromptResponse> CreatePromptAsync(CreatePromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePromptResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePromptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePromptVersion

        internal virtual CreatePromptVersionResponse CreatePromptVersion(CreatePromptVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePromptVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePromptVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePromptVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a static snapshot of your prompt that can be deployed to production. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-deploy.html">Deploy
        /// prompts using Prompt management by creating versions</a> in the Amazon Bedrock User
        /// Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePromptVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePromptVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreatePromptVersion">REST API Reference for CreatePromptVersion Operation</seealso>
        public virtual Task<CreatePromptVersionResponse> CreatePromptVersionAsync(CreatePromptVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePromptVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePromptVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePromptVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAgent

        internal virtual DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        public virtual Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAgentActionGroup

        internal virtual DeleteAgentActionGroupResponse DeleteAgentActionGroup(DeleteAgentActionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentActionGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentActionGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes an action group in an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentActionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentActionGroup">REST API Reference for DeleteAgentActionGroup Operation</seealso>
        public virtual Task<DeleteAgentActionGroupResponse> DeleteAgentActionGroupAsync(DeleteAgentActionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentActionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentActionGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAgentAlias

        internal virtual DeleteAgentAliasResponse DeleteAgentAlias(DeleteAgentAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentAliasResponse>(request, options);
        }



        /// <summary>
        /// Deletes an alias of an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentAlias">REST API Reference for DeleteAgentAlias Operation</seealso>
        public virtual Task<DeleteAgentAliasResponse> DeleteAgentAliasAsync(DeleteAgentAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAgentVersion

        internal virtual DeleteAgentVersionResponse DeleteAgentVersion(DeleteAgentVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a version of an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentVersion">REST API Reference for DeleteAgentVersion Operation</seealso>
        public virtual Task<DeleteAgentVersionResponse> DeleteAgentVersionAsync(DeleteAgentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataSource

        internal virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a data source from a knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFlow

        internal virtual DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowResponse>(request, options);
        }



        /// <summary>
        /// Deletes a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlow service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFlowAlias

        internal virtual DeleteFlowAliasResponse DeleteFlowAlias(DeleteFlowAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowAliasResponse>(request, options);
        }



        /// <summary>
        /// Deletes an alias of a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlowAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteFlowAlias">REST API Reference for DeleteFlowAlias Operation</seealso>
        public virtual Task<DeleteFlowAliasResponse> DeleteFlowAliasAsync(DeleteFlowAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFlowVersion

        internal virtual DeleteFlowVersionResponse DeleteFlowVersion(DeleteFlowVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a version of a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlowVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteFlowVersion">REST API Reference for DeleteFlowVersion Operation</seealso>
        public virtual Task<DeleteFlowVersionResponse> DeleteFlowVersionAsync(DeleteFlowVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKnowledgeBase

        internal virtual DeleteKnowledgeBaseResponse DeleteKnowledgeBase(DeleteKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<DeleteKnowledgeBaseResponse>(request, options);
        }



        /// <summary>
        /// Deletes a knowledge base. Before deleting a knowledge base, you should disassociate
        /// the knowledge base from any agents that it is associated with by making a <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_DisassociateAgentKnowledgeBase.html">DisassociateAgentKnowledgeBase</a>
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        public virtual Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKnowledgeBaseDocuments

        internal virtual DeleteKnowledgeBaseDocumentsResponse DeleteKnowledgeBaseDocuments(DeleteKnowledgeBaseDocumentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKnowledgeBaseDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnowledgeBaseDocumentsResponseUnmarshaller.Instance;

            return Invoke<DeleteKnowledgeBaseDocumentsResponse>(request, options);
        }



        /// <summary>
        /// Deletes documents from a data source and syncs the changes to the knowledge base that
        /// is connected to it. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-direct-ingestion.html">Ingest
        /// changes directly into a knowledge base</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBaseDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKnowledgeBaseDocuments service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteKnowledgeBaseDocuments">REST API Reference for DeleteKnowledgeBaseDocuments Operation</seealso>
        public virtual Task<DeleteKnowledgeBaseDocumentsResponse> DeleteKnowledgeBaseDocumentsAsync(DeleteKnowledgeBaseDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKnowledgeBaseDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnowledgeBaseDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKnowledgeBaseDocumentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePrompt

        internal virtual DeletePromptResponse DeletePrompt(DeletePromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePromptResponseUnmarshaller.Instance;

            return Invoke<DeletePromptResponse>(request, options);
        }



        /// <summary>
        /// Deletes a prompt or a version of it, depending on whether you include the <c>promptVersion</c>
        /// field or not. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-manage.html#prompt-management-delete.html">Delete
        /// prompts from the Prompt management tool</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-deploy.html#prompt-management-versions-delete.html">Delete
        /// a version of a prompt from the Prompt management tool</a> in the Amazon Bedrock User
        /// Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrompt service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeletePrompt">REST API Reference for DeletePrompt Operation</seealso>
        public virtual Task<DeletePromptResponse> DeletePromptAsync(DeletePromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePromptResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePromptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateAgentCollaborator

        internal virtual DisassociateAgentCollaboratorResponse DisassociateAgentCollaborator(DisassociateAgentCollaboratorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAgentCollaboratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAgentCollaboratorResponseUnmarshaller.Instance;

            return Invoke<DisassociateAgentCollaboratorResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an agent collaborator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAgentCollaborator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAgentCollaborator service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DisassociateAgentCollaborator">REST API Reference for DisassociateAgentCollaborator Operation</seealso>
        public virtual Task<DisassociateAgentCollaboratorResponse> DisassociateAgentCollaboratorAsync(DisassociateAgentCollaboratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAgentCollaboratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAgentCollaboratorResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAgentCollaboratorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateAgentKnowledgeBase

        internal virtual DisassociateAgentKnowledgeBaseResponse DisassociateAgentKnowledgeBase(DisassociateAgentKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<DisassociateAgentKnowledgeBaseResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a knowledge base from an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAgentKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DisassociateAgentKnowledgeBase">REST API Reference for DisassociateAgentKnowledgeBase Operation</seealso>
        public virtual Task<DisassociateAgentKnowledgeBaseResponse> DisassociateAgentKnowledgeBaseAsync(DisassociateAgentKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAgentKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgent

        internal virtual GetAgentResponse GetAgent(GetAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentResponseUnmarshaller.Instance;

            return Invoke<GetAgentResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgent">REST API Reference for GetAgent Operation</seealso>
        public virtual Task<GetAgentResponse> GetAgentAsync(GetAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgentActionGroup

        internal virtual GetAgentActionGroupResponse GetAgentActionGroup(GetAgentActionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentActionGroupResponseUnmarshaller.Instance;

            return Invoke<GetAgentActionGroupResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an action group for an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentActionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentActionGroup">REST API Reference for GetAgentActionGroup Operation</seealso>
        public virtual Task<GetAgentActionGroupResponse> GetAgentActionGroupAsync(GetAgentActionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentActionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgentActionGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgentAlias

        internal virtual GetAgentAliasResponse GetAgentAlias(GetAgentAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentAliasResponseUnmarshaller.Instance;

            return Invoke<GetAgentAliasResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an alias of an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentAlias">REST API Reference for GetAgentAlias Operation</seealso>
        public virtual Task<GetAgentAliasResponse> GetAgentAliasAsync(GetAgentAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentAliasResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgentAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgentCollaborator

        internal virtual GetAgentCollaboratorResponse GetAgentCollaborator(GetAgentCollaboratorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentCollaboratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentCollaboratorResponseUnmarshaller.Instance;

            return Invoke<GetAgentCollaboratorResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an agent's collaborator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentCollaborator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentCollaborator service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentCollaborator">REST API Reference for GetAgentCollaborator Operation</seealso>
        public virtual Task<GetAgentCollaboratorResponse> GetAgentCollaboratorAsync(GetAgentCollaboratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentCollaboratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentCollaboratorResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgentCollaboratorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgentKnowledgeBase

        internal virtual GetAgentKnowledgeBaseResponse GetAgentKnowledgeBase(GetAgentKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<GetAgentKnowledgeBaseResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a knowledge base associated with an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentKnowledgeBase">REST API Reference for GetAgentKnowledgeBase Operation</seealso>
        public virtual Task<GetAgentKnowledgeBaseResponse> GetAgentKnowledgeBaseAsync(GetAgentKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgentKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgentVersion

        internal virtual GetAgentVersionResponse GetAgentVersion(GetAgentVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentVersionResponseUnmarshaller.Instance;

            return Invoke<GetAgentVersionResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a version of an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentVersion">REST API Reference for GetAgentVersion Operation</seealso>
        public virtual Task<GetAgentVersionResponse> GetAgentVersionAsync(GetAgentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgentVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataSource

        internal virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFlow

        internal virtual GetFlowResponse GetFlow(GetFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowResponseUnmarshaller.Instance;

            return Invoke<GetFlowResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a flow. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-manage.html">Manage
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFlow service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetFlow">REST API Reference for GetFlow Operation</seealso>
        public virtual Task<GetFlowResponse> GetFlowAsync(GetFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowResponseUnmarshaller.Instance;

            return InvokeAsync<GetFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFlowAlias

        internal virtual GetFlowAliasResponse GetFlowAlias(GetFlowAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowAliasResponseUnmarshaller.Instance;

            return Invoke<GetFlowAliasResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a flow. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-deploy.html">Deploy
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFlowAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetFlowAlias">REST API Reference for GetFlowAlias Operation</seealso>
        public virtual Task<GetFlowAliasResponse> GetFlowAliasAsync(GetFlowAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowAliasResponseUnmarshaller.Instance;

            return InvokeAsync<GetFlowAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFlowVersion

        internal virtual GetFlowVersionResponse GetFlowVersion(GetFlowVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowVersionResponseUnmarshaller.Instance;

            return Invoke<GetFlowVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a version of a flow. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-deploy.html">Deploy
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFlowVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetFlowVersion">REST API Reference for GetFlowVersion Operation</seealso>
        public virtual Task<GetFlowVersionResponse> GetFlowVersionAsync(GetFlowVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFlowVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIngestionJob

        internal virtual GetIngestionJobResponse GetIngestionJob(GetIngestionJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngestionJobResponseUnmarshaller.Instance;

            return Invoke<GetIngestionJobResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a data ingestion job. Data sources are ingested into your knowledge
        /// base so that Large Language Models (LLMs) can use your data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIngestionJob service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetIngestionJob">REST API Reference for GetIngestionJob Operation</seealso>
        public virtual Task<GetIngestionJobResponse> GetIngestionJobAsync(GetIngestionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngestionJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetIngestionJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKnowledgeBase

        internal virtual GetKnowledgeBaseResponse GetKnowledgeBase(GetKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<GetKnowledgeBaseResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a knoweldge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        public virtual Task<GetKnowledgeBaseResponse> GetKnowledgeBaseAsync(GetKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKnowledgeBaseDocuments

        internal virtual GetKnowledgeBaseDocumentsResponse GetKnowledgeBaseDocuments(GetKnowledgeBaseDocumentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKnowledgeBaseDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKnowledgeBaseDocumentsResponseUnmarshaller.Instance;

            return Invoke<GetKnowledgeBaseDocumentsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves specific documents from a data source that is connected to a knowledge base.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-direct-ingestion.html">Ingest
        /// changes directly into a knowledge base</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBaseDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKnowledgeBaseDocuments service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetKnowledgeBaseDocuments">REST API Reference for GetKnowledgeBaseDocuments Operation</seealso>
        public virtual Task<GetKnowledgeBaseDocumentsResponse> GetKnowledgeBaseDocumentsAsync(GetKnowledgeBaseDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKnowledgeBaseDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKnowledgeBaseDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetKnowledgeBaseDocumentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPrompt

        internal virtual GetPromptResponse GetPrompt(GetPromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPromptResponseUnmarshaller.Instance;

            return Invoke<GetPromptResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the working draft (<c>DRAFT</c> version) of a prompt or
        /// a version of it, depending on whether you include the <c>promptVersion</c> field or
        /// not. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-manage.html#prompt-management-view.html">View
        /// information about prompts using Prompt management</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-deploy.html#prompt-management-versions-view.html">View
        /// information about a version of your prompt</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPrompt service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetPrompt">REST API Reference for GetPrompt Operation</seealso>
        public virtual Task<GetPromptResponse> GetPromptAsync(GetPromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPromptResponseUnmarshaller.Instance;

            return InvokeAsync<GetPromptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  IngestKnowledgeBaseDocuments

        internal virtual IngestKnowledgeBaseDocumentsResponse IngestKnowledgeBaseDocuments(IngestKnowledgeBaseDocumentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IngestKnowledgeBaseDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IngestKnowledgeBaseDocumentsResponseUnmarshaller.Instance;

            return Invoke<IngestKnowledgeBaseDocumentsResponse>(request, options);
        }



        /// <summary>
        /// Ingests documents directly into the knowledge base that is connected to the data source.
        /// The <c>dataSourceType</c> specified in the content for each document must match the
        /// type of the data source that you specify in the header. For more information, see
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-direct-ingestion.html">Ingest
        /// changes directly into a knowledge base</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IngestKnowledgeBaseDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IngestKnowledgeBaseDocuments service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/IngestKnowledgeBaseDocuments">REST API Reference for IngestKnowledgeBaseDocuments Operation</seealso>
        public virtual Task<IngestKnowledgeBaseDocumentsResponse> IngestKnowledgeBaseDocumentsAsync(IngestKnowledgeBaseDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IngestKnowledgeBaseDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IngestKnowledgeBaseDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<IngestKnowledgeBaseDocumentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgentActionGroups

        internal virtual ListAgentActionGroupsResponse ListAgentActionGroups(ListAgentActionGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentActionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentActionGroupsResponseUnmarshaller.Instance;

            return Invoke<ListAgentActionGroupsResponse>(request, options);
        }



        /// <summary>
        /// Lists the action groups for an agent and information about each one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentActionGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentActionGroups service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentActionGroups">REST API Reference for ListAgentActionGroups Operation</seealso>
        public virtual Task<ListAgentActionGroupsResponse> ListAgentActionGroupsAsync(ListAgentActionGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentActionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentActionGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentActionGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgentAliases

        internal virtual ListAgentAliasesResponse ListAgentAliases(ListAgentAliasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAgentAliasesResponse>(request, options);
        }



        /// <summary>
        /// Lists the aliases of an agent and information about each one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentAliases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentAliases">REST API Reference for ListAgentAliases Operation</seealso>
        public virtual Task<ListAgentAliasesResponse> ListAgentAliasesAsync(ListAgentAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentAliasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgentCollaborators

        internal virtual ListAgentCollaboratorsResponse ListAgentCollaborators(ListAgentCollaboratorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentCollaboratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentCollaboratorsResponseUnmarshaller.Instance;

            return Invoke<ListAgentCollaboratorsResponse>(request, options);
        }



        /// <summary>
        /// Retrieve a list of an agent's collaborators.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentCollaborators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentCollaborators service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentCollaborators">REST API Reference for ListAgentCollaborators Operation</seealso>
        public virtual Task<ListAgentCollaboratorsResponse> ListAgentCollaboratorsAsync(ListAgentCollaboratorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentCollaboratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentCollaboratorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentCollaboratorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgentKnowledgeBases

        internal virtual ListAgentKnowledgeBasesResponse ListAgentKnowledgeBases(ListAgentKnowledgeBasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentKnowledgeBasesResponseUnmarshaller.Instance;

            return Invoke<ListAgentKnowledgeBasesResponse>(request, options);
        }



        /// <summary>
        /// Lists knowledge bases associated with an agent and information about each one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentKnowledgeBases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentKnowledgeBases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentKnowledgeBases">REST API Reference for ListAgentKnowledgeBases Operation</seealso>
        public virtual Task<ListAgentKnowledgeBasesResponse> ListAgentKnowledgeBasesAsync(ListAgentKnowledgeBasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentKnowledgeBasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentKnowledgeBasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgents

        internal virtual ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAgentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the agents belonging to an account and information about each agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgents service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgents">REST API Reference for ListAgents Operation</seealso>
        public virtual Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgentVersions

        internal virtual ListAgentVersionsResponse ListAgentVersions(ListAgentVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAgentVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of an agent and information about each version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentVersions service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentVersions">REST API Reference for ListAgentVersions Operation</seealso>
        public virtual Task<ListAgentVersionsResponse> ListAgentVersionsAsync(ListAgentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataSources

        internal virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the data sources in a knowledge base and information about each one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFlowAliases

        internal virtual ListFlowAliasesResponse ListFlowAliases(ListFlowAliasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowAliasesResponseUnmarshaller.Instance;

            return Invoke<ListFlowAliasesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of aliases for a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlowAliases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListFlowAliases">REST API Reference for ListFlowAliases Operation</seealso>
        public virtual Task<ListFlowAliasesResponse> ListFlowAliasesAsync(ListFlowAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlowAliasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFlows

        internal virtual ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;

            return Invoke<ListFlowsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of flows and information about each flow. For more information, see
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-manage.html">Manage
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlows service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlowsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFlowVersions

        internal virtual ListFlowVersionsResponse ListFlowVersions(ListFlowVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowVersionsResponseUnmarshaller.Instance;

            return Invoke<ListFlowVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of information about each flow. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-deploy.html">Deploy
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlowVersions service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListFlowVersions">REST API Reference for ListFlowVersions Operation</seealso>
        public virtual Task<ListFlowVersionsResponse> ListFlowVersionsAsync(ListFlowVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlowVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIngestionJobs

        internal virtual ListIngestionJobsResponse ListIngestionJobs(ListIngestionJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIngestionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionJobsResponseUnmarshaller.Instance;

            return Invoke<ListIngestionJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists the data ingestion jobs for a data source. The list also includes information
        /// about each job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIngestionJobs service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListIngestionJobs">REST API Reference for ListIngestionJobs Operation</seealso>
        public virtual Task<ListIngestionJobsResponse> ListIngestionJobsAsync(ListIngestionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIngestionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIngestionJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKnowledgeBaseDocuments

        internal virtual ListKnowledgeBaseDocumentsResponse ListKnowledgeBaseDocuments(ListKnowledgeBaseDocumentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKnowledgeBaseDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKnowledgeBaseDocumentsResponseUnmarshaller.Instance;

            return Invoke<ListKnowledgeBaseDocumentsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all the documents contained in a data source that is connected to a knowledge
        /// base. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-direct-ingestion.html">Ingest
        /// changes directly into a knowledge base</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBaseDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKnowledgeBaseDocuments service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListKnowledgeBaseDocuments">REST API Reference for ListKnowledgeBaseDocuments Operation</seealso>
        public virtual Task<ListKnowledgeBaseDocumentsResponse> ListKnowledgeBaseDocumentsAsync(ListKnowledgeBaseDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKnowledgeBaseDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKnowledgeBaseDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListKnowledgeBaseDocumentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKnowledgeBases

        internal virtual ListKnowledgeBasesResponse ListKnowledgeBases(ListKnowledgeBasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKnowledgeBasesResponseUnmarshaller.Instance;

            return Invoke<ListKnowledgeBasesResponse>(request, options);
        }



        /// <summary>
        /// Lists the knowledge bases in an account. The list also includesinformation about each
        /// knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKnowledgeBases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        public virtual Task<ListKnowledgeBasesResponse> ListKnowledgeBasesAsync(ListKnowledgeBasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKnowledgeBasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKnowledgeBasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPrompts

        internal virtual ListPromptsResponse ListPrompts(ListPromptsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPromptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPromptsResponseUnmarshaller.Instance;

            return Invoke<ListPromptsResponse>(request, options);
        }



        /// <summary>
        /// Returns either information about the working draft (<c>DRAFT</c> version) of each
        /// prompt in an account, or information about of all versions of a prompt, depending
        /// on whether you include the <c>promptIdentifier</c> field or not. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-manage.html#prompt-management-view.html">View
        /// information about prompts using Prompt management</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrompts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrompts service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListPrompts">REST API Reference for ListPrompts Operation</seealso>
        public virtual Task<ListPromptsResponse> ListPromptsAsync(ListPromptsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPromptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPromptsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPromptsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// List all the tags for the resource you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PrepareAgent

        internal virtual PrepareAgentResponse PrepareAgent(PrepareAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PrepareAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PrepareAgentResponseUnmarshaller.Instance;

            return Invoke<PrepareAgentResponse>(request, options);
        }



        /// <summary>
        /// Creates a <c>DRAFT</c> version of the agent that can be used for internal testing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PrepareAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PrepareAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/PrepareAgent">REST API Reference for PrepareAgent Operation</seealso>
        public virtual Task<PrepareAgentResponse> PrepareAgentAsync(PrepareAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PrepareAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PrepareAgentResponseUnmarshaller.Instance;

            return InvokeAsync<PrepareAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PrepareFlow

        internal virtual PrepareFlowResponse PrepareFlow(PrepareFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PrepareFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PrepareFlowResponseUnmarshaller.Instance;

            return Invoke<PrepareFlowResponse>(request, options);
        }



        /// <summary>
        /// Prepares the <c>DRAFT</c> version of a flow so that it can be invoked. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-test.html">Test
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PrepareFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PrepareFlow service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/PrepareFlow">REST API Reference for PrepareFlow Operation</seealso>
        public virtual Task<PrepareFlowResponse> PrepareFlowAsync(PrepareFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PrepareFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PrepareFlowResponseUnmarshaller.Instance;

            return InvokeAsync<PrepareFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartIngestionJob

        internal virtual StartIngestionJobResponse StartIngestionJob(StartIngestionJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIngestionJobResponseUnmarshaller.Instance;

            return Invoke<StartIngestionJobResponse>(request, options);
        }



        /// <summary>
        /// Begins a data ingestion job. Data sources are ingested into your knowledge base so
        /// that Large Language Models (LLMs) can use your data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIngestionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartIngestionJob service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/StartIngestionJob">REST API Reference for StartIngestionJob Operation</seealso>
        public virtual Task<StartIngestionJobResponse> StartIngestionJobAsync(StartIngestionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIngestionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartIngestionJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopIngestionJob

        internal virtual StopIngestionJobResponse StopIngestionJob(StopIngestionJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopIngestionJobResponseUnmarshaller.Instance;

            return Invoke<StopIngestionJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a currently running data ingestion job. You can send a <c>StartIngestionJob</c>
        /// request again to ingest the rest of your data when you are ready.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopIngestionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopIngestionJob service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/StopIngestionJob">REST API Reference for StopIngestionJob Operation</seealso>
        public virtual Task<StopIngestionJobResponse> StopIngestionJobAsync(StopIngestionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopIngestionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopIngestionJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associate tags with a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Remove tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAgent

        internal virtual UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        public virtual Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAgentActionGroup

        internal virtual UpdateAgentActionGroupResponse UpdateAgentActionGroup(UpdateAgentActionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentActionGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentActionGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration for an action group for an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentActionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentActionGroup">REST API Reference for UpdateAgentActionGroup Operation</seealso>
        public virtual Task<UpdateAgentActionGroupResponse> UpdateAgentActionGroupAsync(UpdateAgentActionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentActionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentActionGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAgentAlias

        internal virtual UpdateAgentAliasResponse UpdateAgentAlias(UpdateAgentAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentAliasResponse>(request, options);
        }



        /// <summary>
        /// Updates configurations for an alias of an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentAlias">REST API Reference for UpdateAgentAlias Operation</seealso>
        public virtual Task<UpdateAgentAliasResponse> UpdateAgentAliasAsync(UpdateAgentAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAgentCollaborator

        internal virtual UpdateAgentCollaboratorResponse UpdateAgentCollaborator(UpdateAgentCollaboratorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentCollaboratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentCollaboratorResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentCollaboratorResponse>(request, options);
        }



        /// <summary>
        /// Updates an agent's collaborator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentCollaborator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentCollaborator service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentCollaborator">REST API Reference for UpdateAgentCollaborator Operation</seealso>
        public virtual Task<UpdateAgentCollaboratorResponse> UpdateAgentCollaboratorAsync(UpdateAgentCollaboratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentCollaboratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentCollaboratorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentCollaboratorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAgentKnowledgeBase

        internal virtual UpdateAgentKnowledgeBaseResponse UpdateAgentKnowledgeBase(UpdateAgentKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentKnowledgeBaseResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration for a knowledge base that has been associated with an agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentKnowledgeBase">REST API Reference for UpdateAgentKnowledgeBase Operation</seealso>
        public virtual Task<UpdateAgentKnowledgeBaseResponse> UpdateAgentKnowledgeBaseAsync(UpdateAgentKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataSource

        internal virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates the configurations for a data source connector.
        /// 
        ///  <important> 
        /// <para>
        /// You can't change the <c>chunkingConfiguration</c> after you create the data source
        /// connector. Specify the existing <c>chunkingConfiguration</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFlow

        internal virtual UpdateFlowResponse UpdateFlow(UpdateFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowResponse>(request, options);
        }



        /// <summary>
        /// Modifies a flow. Include both fields that you want to keep and fields that you want
        /// to change. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-how-it-works.html">How
        /// it works</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-create.html">Create
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlow service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        public virtual Task<UpdateFlowResponse> UpdateFlowAsync(UpdateFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFlowAlias

        internal virtual UpdateFlowAliasResponse UpdateFlowAlias(UpdateFlowAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowAliasResponse>(request, options);
        }



        /// <summary>
        /// Modifies the alias of a flow. Include both fields that you want to keep and ones that
        /// you want to change. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-deploy.html">Deploy
        /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlowAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateFlowAlias">REST API Reference for UpdateFlowAlias Operation</seealso>
        public virtual Task<UpdateFlowAliasResponse> UpdateFlowAliasAsync(UpdateFlowAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFlowAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKnowledgeBase

        internal virtual UpdateKnowledgeBaseResponse UpdateKnowledgeBase(UpdateKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<UpdateKnowledgeBaseResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of a knowledge base with the fields that you specify. Because
        /// all fields will be overwritten, you must include the same values for fields that you
        /// want to keep the same.
        /// 
        ///  
        /// <para>
        /// You can change the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>description</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>roleArn</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't change the <c>knowledgeBaseConfiguration</c> or <c>storageConfiguration</c>
        /// fields, so you must specify the same configurations as when you created the knowledge
        /// base. You can send a <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_GetKnowledgeBase.html">GetKnowledgeBase</a>
        /// request and copy the same configurations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateKnowledgeBase">REST API Reference for UpdateKnowledgeBase Operation</seealso>
        public virtual Task<UpdateKnowledgeBaseResponse> UpdateKnowledgeBaseAsync(UpdateKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePrompt

        internal virtual UpdatePromptResponse UpdatePrompt(UpdatePromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePromptResponseUnmarshaller.Instance;

            return Invoke<UpdatePromptResponse>(request, options);
        }



        /// <summary>
        /// Modifies a prompt in your prompt library. Include both fields that you want to keep
        /// and fields that you want to replace. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management.html">Prompt
        /// management in Amazon Bedrock</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-manage.html#prompt-management-edit">Edit
        /// prompts in your prompt library</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrompt service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// There was a conflict performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdatePrompt">REST API Reference for UpdatePrompt Operation</seealso>
        public virtual Task<UpdatePromptResponse> UpdatePromptAsync(UpdatePromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePromptResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePromptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ValidateFlowDefinition

        internal virtual ValidateFlowDefinitionResponse ValidateFlowDefinition(ValidateFlowDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateFlowDefinitionResponseUnmarshaller.Instance;

            return Invoke<ValidateFlowDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Validates the definition of a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateFlowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateFlowDefinition service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ValidateFlowDefinition">REST API Reference for ValidateFlowDefinition Operation</seealso>
        public virtual Task<ValidateFlowDefinitionResponse> ValidateFlowDefinitionAsync(ValidateFlowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateFlowDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateFlowDefinitionResponse>(request, options, cancellationToken);
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