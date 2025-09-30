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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QConnect.Model;
using Amazon.QConnect.Model.Internal.MarshallTransformations;
using Amazon.QConnect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.QConnect
{
    /// <summary>
    /// <para>Implementation for accessing QConnect</para>
    ///
    /// <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Operations_Amazon_Q_Connect.html">Amazon
    /// Q actions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Types_Amazon_Q_Connect.html">Amazon
    /// Q data types</a> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    ///  <b>Powered by Amazon Bedrock</b>: Amazon Web Services implements <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/abuse-detection.html">automated
    /// abuse detection</a>. Because Amazon Q in Connect is built on Amazon Bedrock, users
    /// can take full advantage of the controls implemented in Amazon Bedrock to enforce safety,
    /// security, and the responsible use of artificial intelligence (AI).
    /// </para>
    ///  </note> 
    /// <para>
    /// Amazon Q in Connect is a generative AI customer service assistant. It is an LLM-enhanced
    /// evolution of Amazon Connect Wisdom that delivers real-time recommendations to help
    /// contact center agents resolve customer issues quickly and accurately.
    /// </para>
    ///  
    /// <para>
    /// Amazon Q in Connect automatically detects customer intent during calls and chats using
    /// conversational analytics and natural language understanding (NLU). It then provides
    /// agents with immediate, real-time generative responses and suggested actions, and links
    /// to relevant documents and articles. Agents can also query Amazon Q in Connect directly
    /// using natural language or keywords to answer customer requests.
    /// </para>
    ///  
    /// <para>
    /// Use the Amazon Q in Connect APIs to create an assistant and a knowledge base, for
    /// example, or manage content by uploading custom files.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-q-connect.html">Use
    /// Amazon Q in Connect for generative AI powered agent assistance in real-time</a> in
    /// the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonQConnectClient : AmazonServiceClient, IAmazonQConnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonQConnectMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonQConnectClient with the credentials loaded from the application's
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
        public AmazonQConnectClient()
            : base(new AmazonQConnectConfig()) { }

        /// <summary>
        /// Constructs AmazonQConnectClient with the credentials loaded from the application's
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
        public AmazonQConnectClient(RegionEndpoint region)
            : base(new AmazonQConnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQConnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQConnectClient Configuration Object</param>
        public AmazonQConnectClient(AmazonQConnectConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonQConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonQConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQConnectClient with AWS Credentials and an
        /// AmazonQConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQConnectClient Configuration Object</param>
        public AmazonQConnectClient(AWSCredentials credentials, AmazonQConnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQConnectClient Configuration Object</param>
        public AmazonQConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQConnectClient Configuration Object</param>
        public AmazonQConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IQConnectPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IQConnectPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new QConnectPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQConnectEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQConnectAuthSchemeHandler());
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


        #region  ActivateMessageTemplate

        internal virtual ActivateMessageTemplateResponse ActivateMessageTemplate(ActivateMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<ActivateMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Activates a specific version of the Amazon Q in Connect message template. After the
        /// version is activated, the previous active version will be deactivated automatically.
        /// You can use the <c>$ACTIVE_VERSION</c> qualifier later to reference the version that
        /// is in active status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ActivateMessageTemplate">REST API Reference for ActivateMessageTemplate Operation</seealso>
        public virtual Task<ActivateMessageTemplateResponse> ActivateMessageTemplateAsync(ActivateMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<ActivateMessageTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAIAgent

        internal virtual CreateAIAgentResponse CreateAIAgent(CreateAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIAgentResponseUnmarshaller.Instance;

            return Invoke<CreateAIAgentResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q in Connect AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgent">REST API Reference for CreateAIAgent Operation</seealso>
        public virtual Task<CreateAIAgentResponse> CreateAIAgentAsync(CreateAIAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIAgentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAIAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAIAgentVersion

        internal virtual CreateAIAgentVersionResponse CreateAIAgentVersion(CreateAIAgentVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIAgentVersionResponseUnmarshaller.Instance;

            return Invoke<CreateAIAgentVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates and Amazon Q in Connect AI Agent version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIAgentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAIAgentVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgentVersion">REST API Reference for CreateAIAgentVersion Operation</seealso>
        public virtual Task<CreateAIAgentVersionResponse> CreateAIAgentVersionAsync(CreateAIAgentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIAgentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAIAgentVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAIGuardrail

        internal virtual CreateAIGuardrailResponse CreateAIGuardrail(CreateAIGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIGuardrailResponseUnmarshaller.Instance;

            return Invoke<CreateAIGuardrailResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q in Connect AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIGuardrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAIGuardrail service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrail">REST API Reference for CreateAIGuardrail Operation</seealso>
        public virtual Task<CreateAIGuardrailResponse> CreateAIGuardrailAsync(CreateAIGuardrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIGuardrailResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAIGuardrailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAIGuardrailVersion

        internal virtual CreateAIGuardrailVersionResponse CreateAIGuardrailVersion(CreateAIGuardrailVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIGuardrailVersionResponseUnmarshaller.Instance;

            return Invoke<CreateAIGuardrailVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q in Connect AI Guardrail version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIGuardrailVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAIGuardrailVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrailVersion">REST API Reference for CreateAIGuardrailVersion Operation</seealso>
        public virtual Task<CreateAIGuardrailVersionResponse> CreateAIGuardrailVersionAsync(CreateAIGuardrailVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIGuardrailVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAIGuardrailVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAIPrompt

        internal virtual CreateAIPromptResponse CreateAIPrompt(CreateAIPromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIPromptResponseUnmarshaller.Instance;

            return Invoke<CreateAIPromptResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q in Connect AI Prompt.
        /// 
        ///  <note> 
        /// <para>
        /// For more information on supported models, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/create-ai-prompts.html#cli-create-aiprompt">Supported
        /// models for system and custom prompts</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIPrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAIPrompt service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPrompt">REST API Reference for CreateAIPrompt Operation</seealso>
        public virtual Task<CreateAIPromptResponse> CreateAIPromptAsync(CreateAIPromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIPromptResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAIPromptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAIPromptVersion

        internal virtual CreateAIPromptVersionResponse CreateAIPromptVersion(CreateAIPromptVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIPromptVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIPromptVersionResponseUnmarshaller.Instance;

            return Invoke<CreateAIPromptVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q in Connect AI Prompt version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIPromptVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAIPromptVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPromptVersion">REST API Reference for CreateAIPromptVersion Operation</seealso>
        public virtual Task<CreateAIPromptVersionResponse> CreateAIPromptVersionAsync(CreateAIPromptVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIPromptVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIPromptVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAIPromptVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAssistant

        internal virtual CreateAssistantResponse CreateAssistant(CreateAssistantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssistantResponseUnmarshaller.Instance;

            return Invoke<CreateAssistantResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q in Connect assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssistant service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistant">REST API Reference for CreateAssistant Operation</seealso>
        public virtual Task<CreateAssistantResponse> CreateAssistantAsync(CreateAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssistantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssistantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAssistantAssociation

        internal virtual CreateAssistantAssociationResponse CreateAssistantAssociation(CreateAssistantAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssistantAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateAssistantAssociationResponse>(request, options);
        }



        /// <summary>
        /// Creates an association between an Amazon Q in Connect assistant and another resource.
        /// Currently, the only supported association is with a knowledge base. An assistant can
        /// have only a single association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistantAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssistantAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistantAssociation">REST API Reference for CreateAssistantAssociation Operation</seealso>
        public virtual Task<CreateAssistantAssociationResponse> CreateAssistantAssociationAsync(CreateAssistantAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssistantAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssistantAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateContent

        internal virtual CreateContentResponse CreateContent(CreateContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContentResponseUnmarshaller.Instance;

            return Invoke<CreateContentResponse>(request, options);
        }



        /// <summary>
        /// Creates Amazon Q in Connect content. Before to calling this API, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>
        /// to upload an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContent">REST API Reference for CreateContent Operation</seealso>
        public virtual Task<CreateContentResponse> CreateContentAsync(CreateContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateContentAssociation

        internal virtual CreateContentAssociationResponse CreateContentAssociation(CreateContentAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContentAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateContentAssociationResponse>(request, options);
        }



        /// <summary>
        /// Creates an association between a content resource in a knowledge base and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/step-by-step-guided-experiences.html">step-by-step
        /// guides</a>. Step-by-step guides offer instructions to agents for resolving common
        /// customer issues. You create a content association to integrate Amazon Q in Connect
        /// and step-by-step guides. 
        /// 
        ///  
        /// <para>
        /// After you integrate Amazon Q and step-by-step guides, when Amazon Q provides a recommendation
        /// to an agent based on the intent that it's detected, it also provides them with the
        /// option to start the step-by-step guide that you have associated with the content.
        /// </para>
        ///  
        /// <para>
        /// Note the following limitations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can create only one content association for each content resource in a knowledge
        /// base.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can associate a step-by-step guide with multiple content resources.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/integrate-q-with-guides.html">Integrate
        /// Amazon Q in Connect with step-by-step guides</a> in the <i>Amazon Connect Administrator
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContentAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContentAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContentAssociation">REST API Reference for CreateContentAssociation Operation</seealso>
        public virtual Task<CreateContentAssociationResponse> CreateContentAssociationAsync(CreateContentAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContentAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContentAssociationResponse>(request, options, cancellationToken);
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
        /// Creates a knowledge base.
        /// 
        ///  <note> 
        /// <para>
        /// When using this API, you cannot reuse <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/Welcome.html">Amazon
        /// AppIntegrations</a> DataIntegrations with external knowledge bases such as Salesforce
        /// and ServiceNow. If you do, you'll get an <c>InvalidRequestException</c> error. 
        /// </para>
        ///  
        /// <para>
        /// For example, you're programmatically managing your external knowledge base, and you
        /// want to add or remove one of the fields that is being ingested from Salesforce. Do
        /// the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Call <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_DeleteKnowledgeBase.html">DeleteKnowledgeBase</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_DeleteDataIntegration.html">DeleteDataIntegration</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// to recreate the DataIntegration or a create different one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call CreateKnowledgeBase.
        /// </para>
        ///  </li> </ol> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKnowledgeBase service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        public virtual Task<CreateKnowledgeBaseResponse> CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMessageTemplate

        internal virtual CreateMessageTemplateResponse CreateMessageTemplate(CreateMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q in Connect message template. The name of the message template
        /// has to be unique for each knowledge base. The channel subtype of the message template
        /// is immutable and cannot be modified after creation. After the message template is
        /// created, you can use the <c>$LATEST</c> qualifier to reference the created message
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplate">REST API Reference for CreateMessageTemplate Operation</seealso>
        public virtual Task<CreateMessageTemplateResponse> CreateMessageTemplateAsync(CreateMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMessageTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMessageTemplateAttachment

        internal virtual CreateMessageTemplateAttachmentResponse CreateMessageTemplateAttachment(CreateMessageTemplateAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateMessageTemplateAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Uploads an attachment file to the specified Amazon Q in Connect message template.
        /// The name of the message template attachment has to be unique for each message template
        /// referenced by the <c>$LATEST</c> qualifier. The body of the attachment file should
        /// be encoded using base64 encoding. After the file is uploaded, you can use the pre-signed
        /// Amazon S3 URL returned in response to download the uploaded file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplateAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMessageTemplateAttachment service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateAttachment">REST API Reference for CreateMessageTemplateAttachment Operation</seealso>
        public virtual Task<CreateMessageTemplateAttachmentResponse> CreateMessageTemplateAttachmentAsync(CreateMessageTemplateAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMessageTemplateAttachmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMessageTemplateVersion

        internal virtual CreateMessageTemplateVersionResponse CreateMessageTemplateVersion(CreateMessageTemplateVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<CreateMessageTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon Q in Connect message template version from the current content
        /// and configuration of a message template. Versions are immutable and monotonically
        /// increasing. Once a version is created, you can reference a specific version of the
        /// message template by passing in <c>&lt;message-template-id&gt;:&lt;versionNumber&gt;</c>
        /// as the message template identifier. An error is displayed if the supplied <c>messageTemplateContentSha256</c>
        /// is different from the <c>messageTemplateContentSha256</c> of the message template
        /// with <c>$LATEST</c> qualifier. If multiple <c>CreateMessageTemplateVersion</c> requests
        /// are made while the message template remains the same, only the first invocation creates
        /// a new version and the succeeding requests will return the same response as the first
        /// invocation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMessageTemplateVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateVersion">REST API Reference for CreateMessageTemplateVersion Operation</seealso>
        public virtual Task<CreateMessageTemplateVersionResponse> CreateMessageTemplateVersionAsync(CreateMessageTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMessageTemplateVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateQuickResponse

        internal virtual CreateQuickResponseResponse CreateQuickResponse(CreateQuickResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuickResponseResponseUnmarshaller.Instance;

            return Invoke<CreateQuickResponseResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q in Connect quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuickResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQuickResponse service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateQuickResponse">REST API Reference for CreateQuickResponse Operation</seealso>
        public virtual Task<CreateQuickResponseResponse> CreateQuickResponseAsync(CreateQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuickResponseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateQuickResponseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSession

        internal virtual CreateSessionResponse CreateSession(CreateSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return Invoke<CreateSessionResponse>(request, options);
        }



        /// <summary>
        /// Creates a session. A session is a contextual container used for generating recommendations.
        /// Amazon Connect creates a new Amazon Q in Connect session for each contact on which
        /// Amazon Q in Connect is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSession service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual Task<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeactivateMessageTemplate

        internal virtual DeactivateMessageTemplateResponse DeactivateMessageTemplate(DeactivateMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<DeactivateMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deactivates a specific version of the Amazon Q in Connect message template . After
        /// the version is deactivated, you can no longer use the <c>$ACTIVE_VERSION</c> qualifier
        /// to reference the version in active status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeactivateMessageTemplate">REST API Reference for DeactivateMessageTemplate Operation</seealso>
        public virtual Task<DeactivateMessageTemplateResponse> DeactivateMessageTemplateAsync(DeactivateMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivateMessageTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAIAgent

        internal virtual DeleteAIAgentResponse DeleteAIAgent(DeleteAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIAgentResponseUnmarshaller.Instance;

            return Invoke<DeleteAIAgentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q in Connect AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgent">REST API Reference for DeleteAIAgent Operation</seealso>
        public virtual Task<DeleteAIAgentResponse> DeleteAIAgentAsync(DeleteAIAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIAgentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAIAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAIAgentVersion

        internal virtual DeleteAIAgentVersionResponse DeleteAIAgentVersion(DeleteAIAgentVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIAgentVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteAIAgentVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q in Connect AI Agent Version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIAgentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAIAgentVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgentVersion">REST API Reference for DeleteAIAgentVersion Operation</seealso>
        public virtual Task<DeleteAIAgentVersionResponse> DeleteAIAgentVersionAsync(DeleteAIAgentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIAgentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAIAgentVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAIGuardrail

        internal virtual DeleteAIGuardrailResponse DeleteAIGuardrail(DeleteAIGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIGuardrailResponseUnmarshaller.Instance;

            return Invoke<DeleteAIGuardrailResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q in Connect AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIGuardrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAIGuardrail service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrail">REST API Reference for DeleteAIGuardrail Operation</seealso>
        public virtual Task<DeleteAIGuardrailResponse> DeleteAIGuardrailAsync(DeleteAIGuardrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIGuardrailResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAIGuardrailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAIGuardrailVersion

        internal virtual DeleteAIGuardrailVersionResponse DeleteAIGuardrailVersion(DeleteAIGuardrailVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIGuardrailVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteAIGuardrailVersionResponse>(request, options);
        }



        /// <summary>
        /// Delete and Amazon Q in Connect AI Guardrail version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIGuardrailVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAIGuardrailVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrailVersion">REST API Reference for DeleteAIGuardrailVersion Operation</seealso>
        public virtual Task<DeleteAIGuardrailVersionResponse> DeleteAIGuardrailVersionAsync(DeleteAIGuardrailVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIGuardrailVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAIGuardrailVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAIPrompt

        internal virtual DeleteAIPromptResponse DeleteAIPrompt(DeleteAIPromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIPromptResponseUnmarshaller.Instance;

            return Invoke<DeleteAIPromptResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q in Connect AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIPrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAIPrompt service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPrompt">REST API Reference for DeleteAIPrompt Operation</seealso>
        public virtual Task<DeleteAIPromptResponse> DeleteAIPromptAsync(DeleteAIPromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIPromptResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAIPromptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAIPromptVersion

        internal virtual DeleteAIPromptVersionResponse DeleteAIPromptVersion(DeleteAIPromptVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIPromptVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIPromptVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteAIPromptVersionResponse>(request, options);
        }



        /// <summary>
        /// Delete and Amazon Q in Connect AI Prompt version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIPromptVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAIPromptVersion service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPromptVersion">REST API Reference for DeleteAIPromptVersion Operation</seealso>
        public virtual Task<DeleteAIPromptVersionResponse> DeleteAIPromptVersionAsync(DeleteAIPromptVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIPromptVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIPromptVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAIPromptVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAssistant

        internal virtual DeleteAssistantResponse DeleteAssistant(DeleteAssistantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssistantResponseUnmarshaller.Instance;

            return Invoke<DeleteAssistantResponse>(request, options);
        }



        /// <summary>
        /// Deletes an assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssistant service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistant">REST API Reference for DeleteAssistant Operation</seealso>
        public virtual Task<DeleteAssistantResponse> DeleteAssistantAsync(DeleteAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssistantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssistantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAssistantAssociation

        internal virtual DeleteAssistantAssociationResponse DeleteAssistantAssociation(DeleteAssistantAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssistantAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteAssistantAssociationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an assistant association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistantAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssistantAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistantAssociation">REST API Reference for DeleteAssistantAssociation Operation</seealso>
        public virtual Task<DeleteAssistantAssociationResponse> DeleteAssistantAssociationAsync(DeleteAssistantAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssistantAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssistantAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteContent

        internal virtual DeleteContentResponse DeleteContent(DeleteContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContentResponseUnmarshaller.Instance;

            return Invoke<DeleteContentResponse>(request, options);
        }



        /// <summary>
        /// Deletes the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContent">REST API Reference for DeleteContent Operation</seealso>
        public virtual Task<DeleteContentResponse> DeleteContentAsync(DeleteContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteContentAssociation

        internal virtual DeleteContentAssociationResponse DeleteContentAssociation(DeleteContentAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContentAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteContentAssociationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the content association. 
        /// 
        ///  
        /// <para>
        /// For more information about content associations--what they are and when they are used--see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/integrate-q-with-guides.html">Integrate
        /// Amazon Q in Connect with step-by-step guides</a> in the <i>Amazon Connect Administrator
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContentAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContentAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContentAssociation">REST API Reference for DeleteContentAssociation Operation</seealso>
        public virtual Task<DeleteContentAssociationResponse> DeleteContentAssociationAsync(DeleteContentAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContentAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContentAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteImportJob

        internal virtual DeleteImportJobResponse DeleteImportJob(DeleteImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportJobResponseUnmarshaller.Instance;

            return Invoke<DeleteImportJobResponse>(request, options);
        }



        /// <summary>
        /// Deletes the quick response import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImportJob service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteImportJob">REST API Reference for DeleteImportJob Operation</seealso>
        public virtual Task<DeleteImportJobResponse> DeleteImportJobAsync(DeleteImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImportJobResponse>(request, options, cancellationToken);
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
        /// Deletes the knowledge base.
        /// 
        ///  <note> 
        /// <para>
        /// When you use this API to delete an external knowledge base such as Salesforce or ServiceNow,
        /// you must also delete the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/Welcome.html">Amazon
        /// AppIntegrations</a> DataIntegration. This is because you can't reuse the DataIntegration
        /// after it's been associated with an external knowledge base. However, you can delete
        /// and recreate it. See <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_DeleteDataIntegration.html">DeleteDataIntegration</a>
        /// and <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// in the <i>Amazon AppIntegrations API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKnowledgeBase service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        public virtual Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMessageTemplate

        internal virtual DeleteMessageTemplateResponse DeleteMessageTemplate(DeleteMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q in Connect message template entirely or a specific version of
        /// the message template if version is supplied in the request. You can provide the message
        /// template identifier as <c>&lt;message-template-id&gt;:&lt;versionNumber&gt;</c> to
        /// delete a specific version of the message template. If it is not supplied, the message
        /// template and all available versions will be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplate">REST API Reference for DeleteMessageTemplate Operation</seealso>
        public virtual Task<DeleteMessageTemplateResponse> DeleteMessageTemplateAsync(DeleteMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMessageTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMessageTemplateAttachment

        internal virtual DeleteMessageTemplateAttachmentResponse DeleteMessageTemplateAttachment(DeleteMessageTemplateAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMessageTemplateAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageTemplateAttachmentResponseUnmarshaller.Instance;

            return Invoke<DeleteMessageTemplateAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes the attachment file from the Amazon Q in Connect message template that is
        /// referenced by <c>$LATEST</c> qualifier. Attachments on available message template
        /// versions will remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageTemplateAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessageTemplateAttachment service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplateAttachment">REST API Reference for DeleteMessageTemplateAttachment Operation</seealso>
        public virtual Task<DeleteMessageTemplateAttachmentResponse> DeleteMessageTemplateAttachmentAsync(DeleteMessageTemplateAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMessageTemplateAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageTemplateAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMessageTemplateAttachmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteQuickResponse

        internal virtual DeleteQuickResponseResponse DeleteQuickResponse(DeleteQuickResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQuickResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteQuickResponseResponse>(request, options);
        }



        /// <summary>
        /// Deletes a quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuickResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQuickResponse service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteQuickResponse">REST API Reference for DeleteQuickResponse Operation</seealso>
        public virtual Task<DeleteQuickResponseResponse> DeleteQuickResponseAsync(DeleteQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQuickResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteQuickResponseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAIAgent

        internal virtual GetAIAgentResponse GetAIAgent(GetAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIAgentResponseUnmarshaller.Instance;

            return Invoke<GetAIAgentResponse>(request, options);
        }



        /// <summary>
        /// Gets an Amazon Q in Connect AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAIAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIAgent">REST API Reference for GetAIAgent Operation</seealso>
        public virtual Task<GetAIAgentResponse> GetAIAgentAsync(GetAIAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIAgentResponseUnmarshaller.Instance;

            return InvokeAsync<GetAIAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAIGuardrail

        internal virtual GetAIGuardrailResponse GetAIGuardrail(GetAIGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIGuardrailResponseUnmarshaller.Instance;

            return Invoke<GetAIGuardrailResponse>(request, options);
        }



        /// <summary>
        /// Gets the Amazon Q in Connect AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAIGuardrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAIGuardrail service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIGuardrail">REST API Reference for GetAIGuardrail Operation</seealso>
        public virtual Task<GetAIGuardrailResponse> GetAIGuardrailAsync(GetAIGuardrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIGuardrailResponseUnmarshaller.Instance;

            return InvokeAsync<GetAIGuardrailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAIPrompt

        internal virtual GetAIPromptResponse GetAIPrompt(GetAIPromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIPromptResponseUnmarshaller.Instance;

            return Invoke<GetAIPromptResponse>(request, options);
        }



        /// <summary>
        /// Gets and Amazon Q in Connect AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAIPrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAIPrompt service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIPrompt">REST API Reference for GetAIPrompt Operation</seealso>
        public virtual Task<GetAIPromptResponse> GetAIPromptAsync(GetAIPromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIPromptResponseUnmarshaller.Instance;

            return InvokeAsync<GetAIPromptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAssistant

        internal virtual GetAssistantResponse GetAssistant(GetAssistantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssistantResponseUnmarshaller.Instance;

            return Invoke<GetAssistantResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssistant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssistant service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistant">REST API Reference for GetAssistant Operation</seealso>
        public virtual Task<GetAssistantResponse> GetAssistantAsync(GetAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssistantResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssistantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAssistantAssociation

        internal virtual GetAssistantAssociationResponse GetAssistantAssociation(GetAssistantAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssistantAssociationResponseUnmarshaller.Instance;

            return Invoke<GetAssistantAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an assistant association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssistantAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssistantAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistantAssociation">REST API Reference for GetAssistantAssociation Operation</seealso>
        public virtual Task<GetAssistantAssociationResponse> GetAssistantAssociationAsync(GetAssistantAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssistantAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssistantAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetContent

        internal virtual GetContentResponse GetContent(GetContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentResponseUnmarshaller.Instance;

            return Invoke<GetContentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves content, including a pre-signed URL to download the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContent">REST API Reference for GetContent Operation</seealso>
        public virtual Task<GetContentResponse> GetContentAsync(GetContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentResponseUnmarshaller.Instance;

            return InvokeAsync<GetContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetContentAssociation

        internal virtual GetContentAssociationResponse GetContentAssociation(GetContentAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentAssociationResponseUnmarshaller.Instance;

            return Invoke<GetContentAssociationResponse>(request, options);
        }



        /// <summary>
        /// Returns the content association.
        /// 
        ///  
        /// <para>
        /// For more information about content associations--what they are and when they are used--see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/integrate-q-with-guides.html">Integrate
        /// Amazon Q in Connect with step-by-step guides</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContentAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContentAssociation service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentAssociation">REST API Reference for GetContentAssociation Operation</seealso>
        public virtual Task<GetContentAssociationResponse> GetContentAssociationAsync(GetContentAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetContentAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetContentSummary

        internal virtual GetContentSummaryResponse GetContentSummary(GetContentSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentSummaryResponseUnmarshaller.Instance;

            return Invoke<GetContentSummaryResponse>(request, options);
        }



        /// <summary>
        /// Retrieves summary information about the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContentSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContentSummary service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentSummary">REST API Reference for GetContentSummary Operation</seealso>
        public virtual Task<GetContentSummaryResponse> GetContentSummaryAsync(GetContentSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetContentSummaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetImportJob

        internal virtual GetImportJobResponse GetImportJob(GetImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return Invoke<GetImportJobResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the started import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImportJob service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        public virtual Task<GetImportJobResponse> GetImportJobAsync(GetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportJobResponse>(request, options, cancellationToken);
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
        /// Retrieves information about the knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKnowledgeBase service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        public virtual Task<GetKnowledgeBaseResponse> GetKnowledgeBaseAsync(GetKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetKnowledgeBaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMessageTemplate

        internal virtual GetMessageTemplateResponse GetMessageTemplate(GetMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<GetMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the Amazon Q in Connect message template. The message template identifier
        /// can contain an optional qualifier, for example, <c>&lt;message-template-id&gt;:&lt;qualifier&gt;</c>,
        /// which is either an actual version number or an Amazon Q Connect managed qualifier
        /// <c>$ACTIVE_VERSION</c> | <c>$LATEST</c>. If it is not supplied, then <c>$LATEST</c>
        /// is assumed implicitly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetMessageTemplate">REST API Reference for GetMessageTemplate Operation</seealso>
        public virtual Task<GetMessageTemplateResponse> GetMessageTemplateAsync(GetMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetMessageTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetNextMessage

        internal virtual GetNextMessageResponse GetNextMessage(GetNextMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNextMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNextMessageResponseUnmarshaller.Instance;

            return Invoke<GetNextMessageResponse>(request, options);
        }



        /// <summary>
        /// Retrieves next message on an Amazon Q in Connect session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNextMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNextMessage service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetNextMessage">REST API Reference for GetNextMessage Operation</seealso>
        public virtual Task<GetNextMessageResponse> GetNextMessageAsync(GetNextMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNextMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNextMessageResponseUnmarshaller.Instance;

            return InvokeAsync<GetNextMessageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetQuickResponse

        internal virtual GetQuickResponseResponse GetQuickResponse(GetQuickResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQuickResponseResponseUnmarshaller.Instance;

            return Invoke<GetQuickResponseResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuickResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQuickResponse service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetQuickResponse">REST API Reference for GetQuickResponse Operation</seealso>
        public virtual Task<GetQuickResponseResponse> GetQuickResponseAsync(GetQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQuickResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetQuickResponseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRecommendations

        [Obsolete("GetRecommendations API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        internal virtual GetRecommendationsResponse GetRecommendations(GetRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// This API will be discontinued starting June 1, 2024. To receive generative responses
        /// after March 1, 2024, you will need to create a new Assistant in the Amazon Connect
        /// console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs)
        /// into your applications.
        /// 
        ///  </important> 
        /// <para>
        /// Retrieves recommendations for the specified session. To avoid retrieving the same
        /// recommendations in subsequent calls, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_NotifyRecommendationsReceived.html">NotifyRecommendationsReceived</a>.
        /// This API supports long-polling behavior with the <c>waitTimeSeconds</c> parameter.
        /// Short poll is the default behavior and only returns recommendations already available.
        /// To perform a manual query against an assistant, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_QueryAssistant.html">QueryAssistant</a>.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendations service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        [Obsolete("GetRecommendations API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        public virtual Task<GetRecommendationsResponse> GetRecommendationsAsync(GetRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSession

        internal virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return Invoke<GetSessionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information for a specified session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAIAgents

        internal virtual ListAIAgentsResponse ListAIAgents(ListAIAgentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAIAgentsResponse>(request, options);
        }



        /// <summary>
        /// Lists AI Agents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAIAgents service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgents">REST API Reference for ListAIAgents Operation</seealso>
        public virtual Task<ListAIAgentsResponse> ListAIAgentsAsync(ListAIAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAIAgentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAIAgentVersions

        internal virtual ListAIAgentVersionsResponse ListAIAgentVersions(ListAIAgentVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIAgentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIAgentVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAIAgentVersionsResponse>(request, options);
        }



        /// <summary>
        /// List AI Agent versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIAgentVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAIAgentVersions service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgentVersions">REST API Reference for ListAIAgentVersions Operation</seealso>
        public virtual Task<ListAIAgentVersionsResponse> ListAIAgentVersionsAsync(ListAIAgentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIAgentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIAgentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAIAgentVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAIGuardrails

        internal virtual ListAIGuardrailsResponse ListAIGuardrails(ListAIGuardrailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIGuardrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIGuardrailsResponseUnmarshaller.Instance;

            return Invoke<ListAIGuardrailsResponse>(request, options);
        }



        /// <summary>
        /// Lists the AI Guardrails available on the Amazon Q in Connect assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIGuardrails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAIGuardrails service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrails">REST API Reference for ListAIGuardrails Operation</seealso>
        public virtual Task<ListAIGuardrailsResponse> ListAIGuardrailsAsync(ListAIGuardrailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIGuardrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIGuardrailsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAIGuardrailsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAIGuardrailVersions

        internal virtual ListAIGuardrailVersionsResponse ListAIGuardrailVersions(ListAIGuardrailVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIGuardrailVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIGuardrailVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAIGuardrailVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists AI Guardrail versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIGuardrailVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAIGuardrailVersions service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrailVersions">REST API Reference for ListAIGuardrailVersions Operation</seealso>
        public virtual Task<ListAIGuardrailVersionsResponse> ListAIGuardrailVersionsAsync(ListAIGuardrailVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIGuardrailVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIGuardrailVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAIGuardrailVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAIPrompts

        internal virtual ListAIPromptsResponse ListAIPrompts(ListAIPromptsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIPromptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIPromptsResponseUnmarshaller.Instance;

            return Invoke<ListAIPromptsResponse>(request, options);
        }



        /// <summary>
        /// Lists the AI Prompts available on the Amazon Q in Connect assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIPrompts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAIPrompts service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPrompts">REST API Reference for ListAIPrompts Operation</seealso>
        public virtual Task<ListAIPromptsResponse> ListAIPromptsAsync(ListAIPromptsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIPromptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIPromptsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAIPromptsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAIPromptVersions

        internal virtual ListAIPromptVersionsResponse ListAIPromptVersions(ListAIPromptVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIPromptVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIPromptVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAIPromptVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists AI Prompt versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIPromptVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAIPromptVersions service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPromptVersions">REST API Reference for ListAIPromptVersions Operation</seealso>
        public virtual Task<ListAIPromptVersionsResponse> ListAIPromptVersionsAsync(ListAIPromptVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIPromptVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIPromptVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAIPromptVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssistantAssociations

        internal virtual ListAssistantAssociationsResponse ListAssistantAssociations(ListAssistantAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssistantAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssistantAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAssistantAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists information about assistant associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssistantAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssistantAssociations service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistantAssociations">REST API Reference for ListAssistantAssociations Operation</seealso>
        public virtual Task<ListAssistantAssociationsResponse> ListAssistantAssociationsAsync(ListAssistantAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssistantAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssistantAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssistantAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssistants

        internal virtual ListAssistantsResponse ListAssistants(ListAssistantsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssistantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssistantsResponseUnmarshaller.Instance;

            return Invoke<ListAssistantsResponse>(request, options);
        }



        /// <summary>
        /// Lists information about assistants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssistants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssistants service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        public virtual Task<ListAssistantsResponse> ListAssistantsAsync(ListAssistantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssistantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssistantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssistantsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListContentAssociations

        internal virtual ListContentAssociationsResponse ListContentAssociations(ListContentAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContentAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContentAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListContentAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the content associations.
        /// 
        ///  
        /// <para>
        /// For more information about content associations--what they are and when they are used--see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/integrate-q-with-guides.html">Integrate
        /// Amazon Q in Connect with step-by-step guides</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContentAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContentAssociations service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContentAssociations">REST API Reference for ListContentAssociations Operation</seealso>
        public virtual Task<ListContentAssociationsResponse> ListContentAssociationsAsync(ListContentAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContentAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContentAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListContentAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListContents

        internal virtual ListContentsResponse ListContents(ListContentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContentsResponseUnmarshaller.Instance;

            return Invoke<ListContentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContents service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContents">REST API Reference for ListContents Operation</seealso>
        public virtual Task<ListContentsResponse> ListContentsAsync(ListContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListContentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListImportJobs

        internal virtual ListImportJobsResponse ListImportJobs(ListImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists information about import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportJobs service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        public virtual Task<ListImportJobsResponse> ListImportJobsAsync(ListImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportJobsResponse>(request, options, cancellationToken);
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
        /// Lists the knowledge bases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKnowledgeBases service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        public virtual Task<ListKnowledgeBasesResponse> ListKnowledgeBasesAsync(ListKnowledgeBasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKnowledgeBasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKnowledgeBasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMessages

        internal virtual ListMessagesResponse ListMessages(ListMessagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessagesResponseUnmarshaller.Instance;

            return Invoke<ListMessagesResponse>(request, options);
        }



        /// <summary>
        /// Lists messages on an Amazon Q in Connect session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMessages service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessages">REST API Reference for ListMessages Operation</seealso>
        public virtual Task<ListMessagesResponse> ListMessagesAsync(ListMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListMessagesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMessageTemplates

        internal virtual ListMessageTemplatesResponse ListMessageTemplates(ListMessageTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessageTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessageTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListMessageTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the available Amazon Q in Connect message templates for the specified knowledge
        /// base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessageTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMessageTemplates service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplates">REST API Reference for ListMessageTemplates Operation</seealso>
        public virtual Task<ListMessageTemplatesResponse> ListMessageTemplatesAsync(ListMessageTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessageTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessageTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListMessageTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMessageTemplateVersions

        internal virtual ListMessageTemplateVersionsResponse ListMessageTemplateVersions(ListMessageTemplateVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessageTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessageTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<ListMessageTemplateVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the available versions for the specified Amazon Q in Connect message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessageTemplateVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMessageTemplateVersions service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplateVersions">REST API Reference for ListMessageTemplateVersions Operation</seealso>
        public virtual Task<ListMessageTemplateVersionsResponse> ListMessageTemplateVersionsAsync(ListMessageTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessageTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessageTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMessageTemplateVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListQuickResponses

        internal virtual ListQuickResponsesResponse ListQuickResponses(ListQuickResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQuickResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickResponsesResponseUnmarshaller.Instance;

            return Invoke<ListQuickResponsesResponse>(request, options);
        }



        /// <summary>
        /// Lists information about quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickResponses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQuickResponses service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListQuickResponses">REST API Reference for ListQuickResponses Operation</seealso>
        public virtual Task<ListQuickResponsesResponse> ListQuickResponsesAsync(ListQuickResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQuickResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickResponsesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQuickResponsesResponse>(request, options, cancellationToken);
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
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NotifyRecommendationsReceived

        internal virtual NotifyRecommendationsReceivedResponse NotifyRecommendationsReceived(NotifyRecommendationsReceivedRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NotifyRecommendationsReceivedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyRecommendationsReceivedResponseUnmarshaller.Instance;

            return Invoke<NotifyRecommendationsReceivedResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified recommendations from the specified assistant's queue of newly
        /// available recommendations. You can use this API in conjunction with <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>
        /// and a <c>waitTimeSeconds</c> input for long-polling behavior and avoiding duplicate
        /// recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyRecommendationsReceived service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NotifyRecommendationsReceived service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/NotifyRecommendationsReceived">REST API Reference for NotifyRecommendationsReceived Operation</seealso>
        public virtual Task<NotifyRecommendationsReceivedResponse> NotifyRecommendationsReceivedAsync(NotifyRecommendationsReceivedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NotifyRecommendationsReceivedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyRecommendationsReceivedResponseUnmarshaller.Instance;

            return InvokeAsync<NotifyRecommendationsReceivedResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutFeedback

        internal virtual PutFeedbackResponse PutFeedback(PutFeedbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Provides feedback against the specified assistant for the specified target. This API
        /// only supports generative targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFeedback service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual Task<PutFeedbackResponse> PutFeedbackAsync(PutFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<PutFeedbackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryAssistant

        [Obsolete("QueryAssistant API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        internal virtual QueryAssistantResponse QueryAssistant(QueryAssistantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryAssistantResponseUnmarshaller.Instance;

            return Invoke<QueryAssistantResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// This API will be discontinued starting June 1, 2024. To receive generative responses
        /// after March 1, 2024, you will need to create a new Assistant in the Amazon Connect
        /// console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs)
        /// into your applications.
        /// 
        ///  </important> 
        /// <para>
        /// Performs a manual search against the specified assistant. To retrieve recommendations
        /// for an assistant, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>.
        /// 
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryAssistant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryAssistant service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.RequestTimeoutException">
        /// The request reached the service more than 15 minutes after the date stamp on the request
        /// or more than 15 minutes after the request expiration date (such as for pre-signed
        /// URLs), or the date stamp on the request is more than 15 minutes in the future.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/QueryAssistant">REST API Reference for QueryAssistant Operation</seealso>
        [Obsolete("QueryAssistant API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        public virtual Task<QueryAssistantResponse> QueryAssistantAsync(QueryAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryAssistantResponseUnmarshaller.Instance;

            return InvokeAsync<QueryAssistantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveAssistantAIAgent

        internal virtual RemoveAssistantAIAgentResponse RemoveAssistantAIAgent(RemoveAssistantAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAssistantAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAssistantAIAgentResponseUnmarshaller.Instance;

            return Invoke<RemoveAssistantAIAgentResponse>(request, options);
        }



        /// <summary>
        /// Removes the AI Agent that is set for use by default on an Amazon Q in Connect Assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAssistantAIAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveAssistantAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveAssistantAIAgent">REST API Reference for RemoveAssistantAIAgent Operation</seealso>
        public virtual Task<RemoveAssistantAIAgentResponse> RemoveAssistantAIAgentAsync(RemoveAssistantAIAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAssistantAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAssistantAIAgentResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAssistantAIAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveKnowledgeBaseTemplateUri

        internal virtual RemoveKnowledgeBaseTemplateUriResponse RemoveKnowledgeBaseTemplateUri(RemoveKnowledgeBaseTemplateUriRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveKnowledgeBaseTemplateUriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveKnowledgeBaseTemplateUriResponseUnmarshaller.Instance;

            return Invoke<RemoveKnowledgeBaseTemplateUriResponse>(request, options);
        }



        /// <summary>
        /// Removes a URI template from a knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveKnowledgeBaseTemplateUri service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveKnowledgeBaseTemplateUri service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveKnowledgeBaseTemplateUri">REST API Reference for RemoveKnowledgeBaseTemplateUri Operation</seealso>
        public virtual Task<RemoveKnowledgeBaseTemplateUriResponse> RemoveKnowledgeBaseTemplateUriAsync(RemoveKnowledgeBaseTemplateUriRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveKnowledgeBaseTemplateUriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveKnowledgeBaseTemplateUriResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveKnowledgeBaseTemplateUriResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RenderMessageTemplate

        internal virtual RenderMessageTemplateResponse RenderMessageTemplate(RenderMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenderMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenderMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<RenderMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Renders the Amazon Q in Connect message template based on the attribute values provided
        /// and generates the message content. For any variable present in the message template,
        /// if the attribute value is neither provided in the attribute request parameter nor
        /// the default attribute of the message template, the rendered message content will keep
        /// the variable placeholder as it is and return the attribute keys that are missing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenderMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RenderMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RenderMessageTemplate">REST API Reference for RenderMessageTemplate Operation</seealso>
        public virtual Task<RenderMessageTemplateResponse> RenderMessageTemplateAsync(RenderMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenderMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenderMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<RenderMessageTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchContent

        internal virtual SearchContentResponse SearchContent(SearchContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchContentResponseUnmarshaller.Instance;

            return Invoke<SearchContentResponse>(request, options);
        }



        /// <summary>
        /// Searches for content in a specified knowledge base. Can be used to get a specific
        /// content resource by its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchContent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchContent">REST API Reference for SearchContent Operation</seealso>
        public virtual Task<SearchContentResponse> SearchContentAsync(SearchContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchContentResponseUnmarshaller.Instance;

            return InvokeAsync<SearchContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchMessageTemplates

        internal virtual SearchMessageTemplatesResponse SearchMessageTemplates(SearchMessageTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchMessageTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchMessageTemplatesResponseUnmarshaller.Instance;

            return Invoke<SearchMessageTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Searches for Amazon Q in Connect message templates in the specified knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchMessageTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchMessageTemplates service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchMessageTemplates">REST API Reference for SearchMessageTemplates Operation</seealso>
        public virtual Task<SearchMessageTemplatesResponse> SearchMessageTemplatesAsync(SearchMessageTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchMessageTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchMessageTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchMessageTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchQuickResponses

        internal virtual SearchQuickResponsesResponse SearchQuickResponses(SearchQuickResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchQuickResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchQuickResponsesResponseUnmarshaller.Instance;

            return Invoke<SearchQuickResponsesResponse>(request, options);
        }



        /// <summary>
        /// Searches existing Amazon Q in Connect quick responses in an Amazon Q in Connect knowledge
        /// base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchQuickResponses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchQuickResponses service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.RequestTimeoutException">
        /// The request reached the service more than 15 minutes after the date stamp on the request
        /// or more than 15 minutes after the request expiration date (such as for pre-signed
        /// URLs), or the date stamp on the request is more than 15 minutes in the future.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchQuickResponses">REST API Reference for SearchQuickResponses Operation</seealso>
        public virtual Task<SearchQuickResponsesResponse> SearchQuickResponsesAsync(SearchQuickResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchQuickResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchQuickResponsesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchQuickResponsesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchSessions

        internal virtual SearchSessionsResponse SearchSessions(SearchSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSessionsResponseUnmarshaller.Instance;

            return Invoke<SearchSessionsResponse>(request, options);
        }



        /// <summary>
        /// Searches for sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSessions service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchSessions">REST API Reference for SearchSessions Operation</seealso>
        public virtual Task<SearchSessionsResponse> SearchSessionsAsync(SearchSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchSessionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendMessage

        internal virtual SendMessageResponse SendMessage(SendMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return Invoke<SendMessageResponse>(request, options);
        }



        /// <summary>
        /// Submits a message to the Amazon Q in Connect session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.RequestTimeoutException">
        /// The request reached the service more than 15 minutes after the date stamp on the request
        /// or more than 15 minutes after the request expiration date (such as for pre-signed
        /// URLs), or the date stamp on the request is more than 15 minutes in the future.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendMessageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartContentUpload

        internal virtual StartContentUploadResponse StartContentUpload(StartContentUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartContentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentUploadResponseUnmarshaller.Instance;

            return Invoke<StartContentUploadResponse>(request, options);
        }



        /// <summary>
        /// Get a URL to upload content to a knowledge base. To upload content, first make a PUT
        /// request to the returned URL with your file, making sure to include the required headers.
        /// Then use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_CreateContent.html">CreateContent</a>
        /// to finalize the content creation process or <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_UpdateContent.html">UpdateContent</a>
        /// to modify an existing resource. You can only upload content to a knowledge base of
        /// type CUSTOM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContentUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartContentUpload service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartContentUpload">REST API Reference for StartContentUpload Operation</seealso>
        public virtual Task<StartContentUploadResponse> StartContentUploadAsync(StartContentUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartContentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentUploadResponseUnmarshaller.Instance;

            return InvokeAsync<StartContentUploadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartImportJob

        internal virtual StartImportJobResponse StartImportJob(StartImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportJobResponseUnmarshaller.Instance;

            return Invoke<StartImportJobResponse>(request, options);
        }



        /// <summary>
        /// Start an asynchronous job to import Amazon Q in Connect resources from an uploaded
        /// source file. Before calling this API, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>
        /// to upload an asset that contains the resource data.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For importing Amazon Q in Connect quick responses, you need to upload a csv file including
        /// the quick responses. For information about how to format the csv file for importing
        /// quick responses, see <a href="https://docs.aws.amazon.com/console/connect/quick-responses/add-data">Import
        /// quick responses</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImportJob service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ServiceQuotaExceededException">
        /// You've exceeded your service quota. To perform the requested action, remove some of
        /// the relevant resources, or use service quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartImportJob">REST API Reference for StartImportJob Operation</seealso>
        public virtual Task<StartImportJobResponse> StartImportJobAsync(StartImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartImportJobResponse>(request, options, cancellationToken);
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
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.TooManyTagsException">
        /// Amazon Q in Connect throws this exception if you have too many tags in your tag set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAIAgent

        internal virtual UpdateAIAgentResponse UpdateAIAgent(UpdateAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAIAgentResponse>(request, options);
        }



        /// <summary>
        /// Updates an AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIAgent">REST API Reference for UpdateAIAgent Operation</seealso>
        public virtual Task<UpdateAIAgentResponse> UpdateAIAgentAsync(UpdateAIAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIAgentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAIAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAIGuardrail

        internal virtual UpdateAIGuardrailResponse UpdateAIGuardrail(UpdateAIGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIGuardrailResponseUnmarshaller.Instance;

            return Invoke<UpdateAIGuardrailResponse>(request, options);
        }



        /// <summary>
        /// Updates an AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIGuardrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAIGuardrail service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIGuardrail">REST API Reference for UpdateAIGuardrail Operation</seealso>
        public virtual Task<UpdateAIGuardrailResponse> UpdateAIGuardrailAsync(UpdateAIGuardrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIGuardrailResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAIGuardrailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAIPrompt

        internal virtual UpdateAIPromptResponse UpdateAIPrompt(UpdateAIPromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIPromptResponseUnmarshaller.Instance;

            return Invoke<UpdateAIPromptResponse>(request, options);
        }



        /// <summary>
        /// Updates an AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIPrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAIPrompt service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIPrompt">REST API Reference for UpdateAIPrompt Operation</seealso>
        public virtual Task<UpdateAIPromptResponse> UpdateAIPromptAsync(UpdateAIPromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIPromptResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAIPromptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAssistantAIAgent

        internal virtual UpdateAssistantAIAgentResponse UpdateAssistantAIAgent(UpdateAssistantAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssistantAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssistantAIAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAssistantAIAgentResponse>(request, options);
        }



        /// <summary>
        /// Updates the AI Agent that is set for use by default on an Amazon Q in Connect Assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssistantAIAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssistantAIAgent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAssistantAIAgent">REST API Reference for UpdateAssistantAIAgent Operation</seealso>
        public virtual Task<UpdateAssistantAIAgentResponse> UpdateAssistantAIAgentAsync(UpdateAssistantAIAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssistantAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssistantAIAgentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssistantAIAgentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateContent

        internal virtual UpdateContentResponse UpdateContent(UpdateContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContentResponseUnmarshaller.Instance;

            return Invoke<UpdateContentResponse>(request, options);
        }



        /// <summary>
        /// Updates information about the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContent service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.PreconditionFailedException">
        /// The provided <c>revisionId</c> does not match, indicating the content has been modified
        /// since it was last read.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        public virtual Task<UpdateContentResponse> UpdateContentAsync(UpdateContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKnowledgeBaseTemplateUri

        internal virtual UpdateKnowledgeBaseTemplateUriResponse UpdateKnowledgeBaseTemplateUri(UpdateKnowledgeBaseTemplateUriRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKnowledgeBaseTemplateUriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKnowledgeBaseTemplateUriResponseUnmarshaller.Instance;

            return Invoke<UpdateKnowledgeBaseTemplateUriResponse>(request, options);
        }



        /// <summary>
        /// Updates the template URI of a knowledge base. This is only supported for knowledge
        /// bases of type EXTERNAL. Include a single variable in <c>${variable}</c> format; this
        /// interpolated by Amazon Q in Connect using ingested content. For example, if you ingest
        /// a Salesforce article, it has an <c>Id</c> value, and you can set the template URI
        /// to <c>https://myInstanceName.lightning.force.com/lightning/r/Knowledge__kav/*${Id}*/view</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBaseTemplateUri service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKnowledgeBaseTemplateUri service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateKnowledgeBaseTemplateUri">REST API Reference for UpdateKnowledgeBaseTemplateUri Operation</seealso>
        public virtual Task<UpdateKnowledgeBaseTemplateUriResponse> UpdateKnowledgeBaseTemplateUriAsync(UpdateKnowledgeBaseTemplateUriRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKnowledgeBaseTemplateUriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKnowledgeBaseTemplateUriResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKnowledgeBaseTemplateUriResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMessageTemplate

        internal virtual UpdateMessageTemplateResponse UpdateMessageTemplate(UpdateMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates the Amazon Q in Connect message template. Partial update is supported. If
        /// any field is not supplied, it will remain unchanged for the message template that
        /// is referenced by the <c>$LATEST</c> qualifier. Any modification will only apply to
        /// the message template that is referenced by the <c>$LATEST</c> qualifier. The fields
        /// for all available versions will remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMessageTemplate service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplate">REST API Reference for UpdateMessageTemplate Operation</seealso>
        public virtual Task<UpdateMessageTemplateResponse> UpdateMessageTemplateAsync(UpdateMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMessageTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMessageTemplateMetadata

        internal virtual UpdateMessageTemplateMetadataResponse UpdateMessageTemplateMetadata(UpdateMessageTemplateMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMessageTemplateMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMessageTemplateMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateMessageTemplateMetadataResponse>(request, options);
        }



        /// <summary>
        /// Updates the Amazon Q in Connect message template metadata. Note that any modification
        /// to the message template’s name, description and grouping configuration will applied
        /// to the message template pointed by the <c>$LATEST</c> qualifier and all available
        /// versions. Partial update is supported. If any field is not supplied, it will remain
        /// unchanged for the message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMessageTemplateMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMessageTemplateMetadata service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplateMetadata">REST API Reference for UpdateMessageTemplateMetadata Operation</seealso>
        public virtual Task<UpdateMessageTemplateMetadataResponse> UpdateMessageTemplateMetadataAsync(UpdateMessageTemplateMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMessageTemplateMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMessageTemplateMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMessageTemplateMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateQuickResponse

        internal virtual UpdateQuickResponseResponse UpdateQuickResponse(UpdateQuickResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateQuickResponseResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing Amazon Q in Connect quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQuickResponse service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.PreconditionFailedException">
        /// The provided <c>revisionId</c> does not match, indicating the content has been modified
        /// since it was last read.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateQuickResponse">REST API Reference for UpdateQuickResponse Operation</seealso>
        public virtual Task<UpdateQuickResponseResponse> UpdateQuickResponseAsync(UpdateQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQuickResponseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSession

        internal virtual UpdateSessionResponse UpdateSession(UpdateSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateSessionResponse>(request, options);
        }



        /// <summary>
        /// Updates a session. A session is a contextual container used for generating recommendations.
        /// Amazon Connect updates the existing Amazon Q in Connect session for each contact on
        /// which Amazon Q in Connect is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSession service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        public virtual Task<UpdateSessionResponse> UpdateSessionAsync(UpdateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSessionData

        internal virtual UpdateSessionDataResponse UpdateSessionData(UpdateSessionDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionDataResponseUnmarshaller.Instance;

            return Invoke<UpdateSessionDataResponse>(request, options);
        }



        /// <summary>
        /// Updates the data stored on an Amazon Q in Connect Session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSessionData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSessionData service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSessionData">REST API Reference for UpdateSessionData Operation</seealso>
        public virtual Task<UpdateSessionDataResponse> UpdateSessionDataAsync(UpdateSessionDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionDataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSessionDataResponse>(request, options, cancellationToken);
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