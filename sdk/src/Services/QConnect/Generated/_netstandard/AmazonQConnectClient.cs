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

#pragma warning disable CS1570
namespace Amazon.QConnect
{
    /// <summary>
    /// <para>Implementation for accessing QConnect</para>
    ///
    /// <note> 
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQConnectConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQConnectConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQConnectEndpointResolver());
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


        #region  CreateAssistant

        internal virtual CreateAssistantResponse CreateAssistant(CreateAssistantRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistant">REST API Reference for CreateAssistant Operation</seealso>
        public virtual Task<CreateAssistantResponse> CreateAssistantAsync(CreateAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssistantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssistantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAssistantAssociation

        internal virtual CreateAssistantAssociationResponse CreateAssistantAssociation(CreateAssistantAssociationRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssistantAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssistantAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateContent

        internal virtual CreateContentResponse CreateContent(CreateContentRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContent">REST API Reference for CreateContent Operation</seealso>
        public virtual Task<CreateContentResponse> CreateContentAsync(CreateContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateKnowledgeBase

        internal virtual CreateKnowledgeBaseResponse CreateKnowledgeBase(CreateKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        public virtual Task<CreateKnowledgeBaseResponse> CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKnowledgeBaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateQuickResponse

        internal virtual CreateQuickResponseResponse CreateQuickResponse(CreateQuickResponseRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateQuickResponse">REST API Reference for CreateQuickResponse Operation</seealso>
        public virtual Task<CreateQuickResponseResponse> CreateQuickResponseAsync(CreateQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuickResponseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateQuickResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSession

        internal virtual CreateSessionResponse CreateSession(CreateSessionRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual Task<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssistant

        internal virtual DeleteAssistantResponse DeleteAssistant(DeleteAssistantRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistant">REST API Reference for DeleteAssistant Operation</seealso>
        public virtual Task<DeleteAssistantResponse> DeleteAssistantAsync(DeleteAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssistantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssistantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssistantAssociation

        internal virtual DeleteAssistantAssociationResponse DeleteAssistantAssociation(DeleteAssistantAssociationRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistantAssociation">REST API Reference for DeleteAssistantAssociation Operation</seealso>
        public virtual Task<DeleteAssistantAssociationResponse> DeleteAssistantAssociationAsync(DeleteAssistantAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssistantAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssistantAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteContent

        internal virtual DeleteContentResponse DeleteContent(DeleteContentRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContent">REST API Reference for DeleteContent Operation</seealso>
        public virtual Task<DeleteContentResponse> DeleteContentAsync(DeleteContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteImportJob

        internal virtual DeleteImportJobResponse DeleteImportJob(DeleteImportJobRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteImportJob">REST API Reference for DeleteImportJob Operation</seealso>
        public virtual Task<DeleteImportJobResponse> DeleteImportJobAsync(DeleteImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteKnowledgeBase

        internal virtual DeleteKnowledgeBaseResponse DeleteKnowledgeBase(DeleteKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        public virtual Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKnowledgeBaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQuickResponse

        internal virtual DeleteQuickResponseResponse DeleteQuickResponse(DeleteQuickResponseRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteQuickResponse">REST API Reference for DeleteQuickResponse Operation</seealso>
        public virtual Task<DeleteQuickResponseResponse> DeleteQuickResponseAsync(DeleteQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQuickResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteQuickResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssistant

        internal virtual GetAssistantResponse GetAssistant(GetAssistantRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistant">REST API Reference for GetAssistant Operation</seealso>
        public virtual Task<GetAssistantResponse> GetAssistantAsync(GetAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssistantResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssistantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssistantAssociation

        internal virtual GetAssistantAssociationResponse GetAssistantAssociation(GetAssistantAssociationRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistantAssociation">REST API Reference for GetAssistantAssociation Operation</seealso>
        public virtual Task<GetAssistantAssociationResponse> GetAssistantAssociationAsync(GetAssistantAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssistantAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssistantAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContent

        internal virtual GetContentResponse GetContent(GetContentRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContent">REST API Reference for GetContent Operation</seealso>
        public virtual Task<GetContentResponse> GetContentAsync(GetContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentResponseUnmarshaller.Instance;

            return InvokeAsync<GetContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContentSummary

        internal virtual GetContentSummaryResponse GetContentSummary(GetContentSummaryRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentSummary">REST API Reference for GetContentSummary Operation</seealso>
        public virtual Task<GetContentSummaryResponse> GetContentSummaryAsync(GetContentSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContentSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetContentSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetImportJob

        internal virtual GetImportJobResponse GetImportJob(GetImportJobRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKnowledgeBase

        internal virtual GetKnowledgeBaseResponse GetKnowledgeBase(GetKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        public virtual Task<GetKnowledgeBaseResponse> GetKnowledgeBaseAsync(GetKnowledgeBaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKnowledgeBaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetKnowledgeBaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQuickResponse

        internal virtual GetQuickResponseResponse GetQuickResponse(GetQuickResponseRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetQuickResponse">REST API Reference for GetQuickResponse Operation</seealso>
        public virtual Task<GetQuickResponseResponse> GetQuickResponseAsync(GetQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQuickResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetQuickResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRecommendations

        [Obsolete("GetRecommendations API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        internal virtual GetRecommendationsResponse GetRecommendations(GetRecommendationsRequest request)
        {
            var options = new InvokeOptions();
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
        /// </para>
        ///  </important> 
        /// <para>
        /// Retrieves recommendations for the specified session. To avoid retrieving the same
        /// recommendations in subsequent calls, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_NotifyRecommendationsReceived.html">NotifyRecommendationsReceived</a>.
        /// This API supports long-polling behavior with the <c>waitTimeSeconds</c> parameter.
        /// Short poll is the default behavior and only returns recommendations already available.
        /// To perform a manual query against an assistant, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_QueryAssistant.html">QueryAssistant</a>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSession

        internal virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssistantAssociations

        internal virtual ListAssistantAssociationsResponse ListAssistantAssociations(ListAssistantAssociationsRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssistantAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssistantAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssistantAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssistants

        internal virtual ListAssistantsResponse ListAssistants(ListAssistantsRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        public virtual Task<ListAssistantsResponse> ListAssistantsAsync(ListAssistantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssistantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssistantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssistantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListContents

        internal virtual ListContentsResponse ListContents(ListContentsRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListContentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImportJobs

        internal virtual ListImportJobsResponse ListImportJobs(ListImportJobsRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKnowledgeBases

        internal virtual ListKnowledgeBasesResponse ListKnowledgeBases(ListKnowledgeBasesRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKnowledgeBasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKnowledgeBasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQuickResponses

        internal virtual ListQuickResponsesResponse ListQuickResponses(ListQuickResponsesRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQuickResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickResponsesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQuickResponsesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NotifyRecommendationsReceived

        internal virtual NotifyRecommendationsReceivedResponse NotifyRecommendationsReceived(NotifyRecommendationsReceivedRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyRecommendationsReceivedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyRecommendationsReceivedResponseUnmarshaller.Instance;

            return InvokeAsync<NotifyRecommendationsReceivedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutFeedback

        internal virtual PutFeedbackResponse PutFeedback(PutFeedbackRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<PutFeedbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryAssistant

        [Obsolete("QueryAssistant API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        internal virtual QueryAssistantResponse QueryAssistant(QueryAssistantRequest request)
        {
            var options = new InvokeOptions();
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
        /// </para>
        ///  </important> 
        /// <para>
        /// Performs a manual search against the specified assistant. To retrieve recommendations
        /// for an assistant, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryAssistantResponseUnmarshaller.Instance;

            return InvokeAsync<QueryAssistantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveKnowledgeBaseTemplateUri

        internal virtual RemoveKnowledgeBaseTemplateUriResponse RemoveKnowledgeBaseTemplateUri(RemoveKnowledgeBaseTemplateUriRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveKnowledgeBaseTemplateUriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveKnowledgeBaseTemplateUriResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveKnowledgeBaseTemplateUriResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchContent

        internal virtual SearchContentResponse SearchContent(SearchContentRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchContent">REST API Reference for SearchContent Operation</seealso>
        public virtual Task<SearchContentResponse> SearchContentAsync(SearchContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchContentResponseUnmarshaller.Instance;

            return InvokeAsync<SearchContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchQuickResponses

        internal virtual SearchQuickResponsesResponse SearchQuickResponses(SearchQuickResponsesRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchQuickResponses">REST API Reference for SearchQuickResponses Operation</seealso>
        public virtual Task<SearchQuickResponsesResponse> SearchQuickResponsesAsync(SearchQuickResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchQuickResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchQuickResponsesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchQuickResponsesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchSessions

        internal virtual SearchSessionsResponse SearchSessions(SearchSessionsRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchSessions">REST API Reference for SearchSessions Operation</seealso>
        public virtual Task<SearchSessionsResponse> SearchSessionsAsync(SearchSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartContentUpload

        internal virtual StartContentUploadResponse StartContentUpload(StartContentUploadRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartContentUpload">REST API Reference for StartContentUpload Operation</seealso>
        public virtual Task<StartContentUploadResponse> StartContentUploadAsync(StartContentUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartContentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentUploadResponseUnmarshaller.Instance;

            return InvokeAsync<StartContentUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartImportJob

        internal virtual StartImportJobResponse StartImportJob(StartImportJobRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartImportJob">REST API Reference for StartImportJob Operation</seealso>
        public virtual Task<StartImportJobResponse> StartImportJobAsync(StartImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateContent

        internal virtual UpdateContentResponse UpdateContent(UpdateContentRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        public virtual Task<UpdateContentResponse> UpdateContentAsync(UpdateContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateKnowledgeBaseTemplateUri

        internal virtual UpdateKnowledgeBaseTemplateUriResponse UpdateKnowledgeBaseTemplateUri(UpdateKnowledgeBaseTemplateUriRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKnowledgeBaseTemplateUriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKnowledgeBaseTemplateUriResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKnowledgeBaseTemplateUriResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateQuickResponse

        internal virtual UpdateQuickResponseResponse UpdateQuickResponse(UpdateQuickResponseRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateQuickResponse">REST API Reference for UpdateQuickResponse Operation</seealso>
        public virtual Task<UpdateQuickResponseResponse> UpdateQuickResponseAsync(UpdateQuickResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQuickResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSession

        internal virtual UpdateSessionResponse UpdateSession(UpdateSessionRequest request)
        {
            var options = new InvokeOptions();
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
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        public virtual Task<UpdateSessionResponse> UpdateSessionAsync(UpdateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSessionResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonQConnectEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}