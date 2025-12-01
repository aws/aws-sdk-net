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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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


        #region  ActivateMessageTemplate

        /// <summary>
        /// Activates a specific version of the Amazon Q in Connect message template. After the
        /// version is activated, the previous active version will be deactivated automatically.
        /// You can use the <c>$ACTIVE_VERSION</c> qualifier later to reference the version that
        /// is in active status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateMessageTemplate service method.</param>
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
        public virtual ActivateMessageTemplateResponse ActivateMessageTemplate(ActivateMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<ActivateMessageTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ActivateMessageTemplate">REST API Reference for ActivateMessageTemplate Operation</seealso>
        public virtual IAsyncResult BeginActivateMessageTemplate(ActivateMessageTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateMessageTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateMessageTemplate.</param>
        /// 
        /// <returns>Returns a  ActivateMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ActivateMessageTemplate">REST API Reference for ActivateMessageTemplate Operation</seealso>
        public virtual ActivateMessageTemplateResponse EndActivateMessageTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<ActivateMessageTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAIAgent

        /// <summary>
        /// Creates an Amazon Q in Connect AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIAgent service method.</param>
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
        public virtual CreateAIAgentResponse CreateAIAgent(CreateAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIAgentResponseUnmarshaller.Instance;

            return Invoke<CreateAIAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgent">REST API Reference for CreateAIAgent Operation</seealso>
        public virtual IAsyncResult BeginCreateAIAgent(CreateAIAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIAgent.</param>
        /// 
        /// <returns>Returns a  CreateAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgent">REST API Reference for CreateAIAgent Operation</seealso>
        public virtual CreateAIAgentResponse EndCreateAIAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAIAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAIAgentVersion

        /// <summary>
        /// Creates and Amazon Q in Connect AI Agent version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIAgentVersion service method.</param>
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
        public virtual CreateAIAgentVersionResponse CreateAIAgentVersion(CreateAIAgentVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIAgentVersionResponseUnmarshaller.Instance;

            return Invoke<CreateAIAgentVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIAgentVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIAgentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgentVersion">REST API Reference for CreateAIAgentVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateAIAgentVersion(CreateAIAgentVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIAgentVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIAgentVersion.</param>
        /// 
        /// <returns>Returns a  CreateAIAgentVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIAgentVersion">REST API Reference for CreateAIAgentVersion Operation</seealso>
        public virtual CreateAIAgentVersionResponse EndCreateAIAgentVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAIAgentVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAIGuardrail

        /// <summary>
        /// Creates an Amazon Q in Connect AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIGuardrail service method.</param>
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
        public virtual CreateAIGuardrailResponse CreateAIGuardrail(CreateAIGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIGuardrailResponseUnmarshaller.Instance;

            return Invoke<CreateAIGuardrailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIGuardrail operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrail">REST API Reference for CreateAIGuardrail Operation</seealso>
        public virtual IAsyncResult BeginCreateAIGuardrail(CreateAIGuardrailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIGuardrailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIGuardrail.</param>
        /// 
        /// <returns>Returns a  CreateAIGuardrailResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrail">REST API Reference for CreateAIGuardrail Operation</seealso>
        public virtual CreateAIGuardrailResponse EndCreateAIGuardrail(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAIGuardrailResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAIGuardrailVersion

        /// <summary>
        /// Creates an Amazon Q in Connect AI Guardrail version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIGuardrailVersion service method.</param>
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
        public virtual CreateAIGuardrailVersionResponse CreateAIGuardrailVersion(CreateAIGuardrailVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIGuardrailVersionResponseUnmarshaller.Instance;

            return Invoke<CreateAIGuardrailVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIGuardrailVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIGuardrailVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIGuardrailVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrailVersion">REST API Reference for CreateAIGuardrailVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateAIGuardrailVersion(CreateAIGuardrailVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIGuardrailVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIGuardrailVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIGuardrailVersion.</param>
        /// 
        /// <returns>Returns a  CreateAIGuardrailVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIGuardrailVersion">REST API Reference for CreateAIGuardrailVersion Operation</seealso>
        public virtual CreateAIGuardrailVersionResponse EndCreateAIGuardrailVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAIGuardrailVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAIPrompt

        /// <summary>
        /// Creates an Amazon Q in Connect AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIPrompt service method.</param>
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
        public virtual CreateAIPromptResponse CreateAIPrompt(CreateAIPromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIPromptResponseUnmarshaller.Instance;

            return Invoke<CreateAIPromptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIPrompt operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIPrompt
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPrompt">REST API Reference for CreateAIPrompt Operation</seealso>
        public virtual IAsyncResult BeginCreateAIPrompt(CreateAIPromptRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIPromptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIPrompt.</param>
        /// 
        /// <returns>Returns a  CreateAIPromptResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPrompt">REST API Reference for CreateAIPrompt Operation</seealso>
        public virtual CreateAIPromptResponse EndCreateAIPrompt(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAIPromptResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAIPromptVersion

        /// <summary>
        /// Creates an Amazon Q in Connect AI Prompt version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAIPromptVersion service method.</param>
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
        public virtual CreateAIPromptVersionResponse CreateAIPromptVersion(CreateAIPromptVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIPromptVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIPromptVersionResponseUnmarshaller.Instance;

            return Invoke<CreateAIPromptVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAIPromptVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAIPromptVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAIPromptVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPromptVersion">REST API Reference for CreateAIPromptVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateAIPromptVersion(CreateAIPromptVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAIPromptVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAIPromptVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAIPromptVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAIPromptVersion.</param>
        /// 
        /// <returns>Returns a  CreateAIPromptVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAIPromptVersion">REST API Reference for CreateAIPromptVersion Operation</seealso>
        public virtual CreateAIPromptVersionResponse EndCreateAIPromptVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAIPromptVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssistant

        /// <summary>
        /// Creates an Amazon Q in Connect assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistant service method.</param>
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
        public virtual CreateAssistantResponse CreateAssistant(CreateAssistantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssistantResponseUnmarshaller.Instance;

            return Invoke<CreateAssistantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistant operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistant">REST API Reference for CreateAssistant Operation</seealso>
        public virtual IAsyncResult BeginCreateAssistant(CreateAssistantRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssistantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssistant.</param>
        /// 
        /// <returns>Returns a  CreateAssistantResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistant">REST API Reference for CreateAssistant Operation</seealso>
        public virtual CreateAssistantResponse EndCreateAssistant(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssistantResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssistantAssociation

        /// <summary>
        /// Creates an association between an Amazon Q in Connect assistant and another resource.
        /// Currently, the only supported association is with a knowledge base. An assistant can
        /// have only a single association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistantAssociation service method.</param>
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
        public virtual CreateAssistantAssociationResponse CreateAssistantAssociation(CreateAssistantAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssistantAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateAssistantAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssistantAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssistantAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistantAssociation">REST API Reference for CreateAssistantAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateAssistantAssociation(CreateAssistantAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssistantAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssistantAssociation.</param>
        /// 
        /// <returns>Returns a  CreateAssistantAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateAssistantAssociation">REST API Reference for CreateAssistantAssociation Operation</seealso>
        public virtual CreateAssistantAssociationResponse EndCreateAssistantAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssistantAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateContent

        /// <summary>
        /// Creates Amazon Q in Connect content. Before to calling this API, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>
        /// to upload an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContent service method.</param>
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
        public virtual CreateContentResponse CreateContent(CreateContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContentResponseUnmarshaller.Instance;

            return Invoke<CreateContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContent">REST API Reference for CreateContent Operation</seealso>
        public virtual IAsyncResult BeginCreateContent(CreateContentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContent.</param>
        /// 
        /// <returns>Returns a  CreateContentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContent">REST API Reference for CreateContent Operation</seealso>
        public virtual CreateContentResponse EndCreateContent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateContentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateContentAssociation

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
        public virtual CreateContentAssociationResponse CreateContentAssociation(CreateContentAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContentAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateContentAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContentAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContentAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContentAssociation">REST API Reference for CreateContentAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateContentAssociation(CreateContentAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContentAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContentAssociation.</param>
        /// 
        /// <returns>Returns a  CreateContentAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateContentAssociation">REST API Reference for CreateContentAssociation Operation</seealso>
        public virtual CreateContentAssociationResponse EndCreateContentAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateContentAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKnowledgeBase

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
        public virtual CreateKnowledgeBaseResponse CreateKnowledgeBase(CreateKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<CreateKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginCreateKnowledgeBase(CreateKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  CreateKnowledgeBaseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        public virtual CreateKnowledgeBaseResponse EndCreateKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKnowledgeBaseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMessageTemplate

        /// <summary>
        /// Creates an Amazon Q in Connect message template. The name of the message template
        /// has to be unique for each knowledge base. The channel subtype of the message template
        /// is immutable and cannot be modified after creation. After the message template is
        /// created, you can use the <c>$LATEST</c> qualifier to reference the created message
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplate service method.</param>
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
        public virtual CreateMessageTemplateResponse CreateMessageTemplate(CreateMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateMessageTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplate">REST API Reference for CreateMessageTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateMessageTemplate(CreateMessageTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMessageTemplate.</param>
        /// 
        /// <returns>Returns a  CreateMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplate">REST API Reference for CreateMessageTemplate Operation</seealso>
        public virtual CreateMessageTemplateResponse EndCreateMessageTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMessageTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMessageTemplateAttachment

        /// <summary>
        /// Uploads an attachment file to the specified Amazon Q in Connect message template.
        /// The name of the message template attachment has to be unique for each message template
        /// referenced by the <c>$LATEST</c> qualifier. The body of the attachment file should
        /// be encoded using base64 encoding. After the file is uploaded, you can use the pre-signed
        /// Amazon S3 URL returned in response to download the uploaded file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplateAttachment service method.</param>
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
        public virtual CreateMessageTemplateAttachmentResponse CreateMessageTemplateAttachment(CreateMessageTemplateAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateMessageTemplateAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMessageTemplateAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplateAttachment operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMessageTemplateAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateAttachment">REST API Reference for CreateMessageTemplateAttachment Operation</seealso>
        public virtual IAsyncResult BeginCreateMessageTemplateAttachment(CreateMessageTemplateAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMessageTemplateAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMessageTemplateAttachment.</param>
        /// 
        /// <returns>Returns a  CreateMessageTemplateAttachmentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateAttachment">REST API Reference for CreateMessageTemplateAttachment Operation</seealso>
        public virtual CreateMessageTemplateAttachmentResponse EndCreateMessageTemplateAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMessageTemplateAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMessageTemplateVersion

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
        public virtual CreateMessageTemplateVersionResponse CreateMessageTemplateVersion(CreateMessageTemplateVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<CreateMessageTemplateVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMessageTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMessageTemplateVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMessageTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateVersion">REST API Reference for CreateMessageTemplateVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateMessageTemplateVersion(CreateMessageTemplateVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMessageTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMessageTemplateVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMessageTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMessageTemplateVersion.</param>
        /// 
        /// <returns>Returns a  CreateMessageTemplateVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateMessageTemplateVersion">REST API Reference for CreateMessageTemplateVersion Operation</seealso>
        public virtual CreateMessageTemplateVersionResponse EndCreateMessageTemplateVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMessageTemplateVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateQuickResponse

        /// <summary>
        /// Creates an Amazon Q in Connect quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuickResponse service method.</param>
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
        public virtual CreateQuickResponseResponse CreateQuickResponse(CreateQuickResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuickResponseResponseUnmarshaller.Instance;

            return Invoke<CreateQuickResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQuickResponse operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQuickResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateQuickResponse">REST API Reference for CreateQuickResponse Operation</seealso>
        public virtual IAsyncResult BeginCreateQuickResponse(CreateQuickResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuickResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQuickResponse.</param>
        /// 
        /// <returns>Returns a  CreateQuickResponseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateQuickResponse">REST API Reference for CreateQuickResponse Operation</seealso>
        public virtual CreateQuickResponseResponse EndCreateQuickResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQuickResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSession

        /// <summary>
        /// Creates a session. A session is a contextual container used for generating recommendations.
        /// Amazon Connect creates a new Amazon Q in Connect session for each contact on which
        /// Amazon Q in Connect is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
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
        /// <exception cref="Amazon.QConnect.Model.DependencyFailedException">
        /// The request failed because it depends on another request that failed.
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
        public virtual CreateSessionResponse CreateSession(CreateSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return Invoke<CreateSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSession operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual IAsyncResult BeginCreateSession(CreateSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSession.</param>
        /// 
        /// <returns>Returns a  CreateSessionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual CreateSessionResponse EndCreateSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeactivateMessageTemplate

        /// <summary>
        /// Deactivates a specific version of the Amazon Q in Connect message template . After
        /// the version is deactivated, you can no longer use the <c>$ACTIVE_VERSION</c> qualifier
        /// to reference the version in active status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMessageTemplate service method.</param>
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
        public virtual DeactivateMessageTemplateResponse DeactivateMessageTemplate(DeactivateMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<DeactivateMessageTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeactivateMessageTemplate">REST API Reference for DeactivateMessageTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeactivateMessageTemplate(DeactivateMessageTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateMessageTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateMessageTemplate.</param>
        /// 
        /// <returns>Returns a  DeactivateMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeactivateMessageTemplate">REST API Reference for DeactivateMessageTemplate Operation</seealso>
        public virtual DeactivateMessageTemplateResponse EndDeactivateMessageTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeactivateMessageTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAIAgent

        /// <summary>
        /// Deletes an Amazon Q in Connect AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIAgent service method.</param>
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
        public virtual DeleteAIAgentResponse DeleteAIAgent(DeleteAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIAgentResponseUnmarshaller.Instance;

            return Invoke<DeleteAIAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgent">REST API Reference for DeleteAIAgent Operation</seealso>
        public virtual IAsyncResult BeginDeleteAIAgent(DeleteAIAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIAgent.</param>
        /// 
        /// <returns>Returns a  DeleteAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgent">REST API Reference for DeleteAIAgent Operation</seealso>
        public virtual DeleteAIAgentResponse EndDeleteAIAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAIAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAIAgentVersion

        /// <summary>
        /// Deletes an Amazon Q in Connect AI Agent Version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIAgentVersion service method.</param>
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
        public virtual DeleteAIAgentVersionResponse DeleteAIAgentVersion(DeleteAIAgentVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIAgentVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteAIAgentVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIAgentVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIAgentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgentVersion">REST API Reference for DeleteAIAgentVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteAIAgentVersion(DeleteAIAgentVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIAgentVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIAgentVersion.</param>
        /// 
        /// <returns>Returns a  DeleteAIAgentVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIAgentVersion">REST API Reference for DeleteAIAgentVersion Operation</seealso>
        public virtual DeleteAIAgentVersionResponse EndDeleteAIAgentVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAIAgentVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAIGuardrail

        /// <summary>
        /// Deletes an Amazon Q in Connect AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIGuardrail service method.</param>
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
        public virtual DeleteAIGuardrailResponse DeleteAIGuardrail(DeleteAIGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIGuardrailResponseUnmarshaller.Instance;

            return Invoke<DeleteAIGuardrailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIGuardrail operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrail">REST API Reference for DeleteAIGuardrail Operation</seealso>
        public virtual IAsyncResult BeginDeleteAIGuardrail(DeleteAIGuardrailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIGuardrailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIGuardrail.</param>
        /// 
        /// <returns>Returns a  DeleteAIGuardrailResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrail">REST API Reference for DeleteAIGuardrail Operation</seealso>
        public virtual DeleteAIGuardrailResponse EndDeleteAIGuardrail(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAIGuardrailResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAIGuardrailVersion

        /// <summary>
        /// Delete and Amazon Q in Connect AI Guardrail version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIGuardrailVersion service method.</param>
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
        public virtual DeleteAIGuardrailVersionResponse DeleteAIGuardrailVersion(DeleteAIGuardrailVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIGuardrailVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteAIGuardrailVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIGuardrailVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIGuardrailVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIGuardrailVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrailVersion">REST API Reference for DeleteAIGuardrailVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteAIGuardrailVersion(DeleteAIGuardrailVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIGuardrailVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIGuardrailVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIGuardrailVersion.</param>
        /// 
        /// <returns>Returns a  DeleteAIGuardrailVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIGuardrailVersion">REST API Reference for DeleteAIGuardrailVersion Operation</seealso>
        public virtual DeleteAIGuardrailVersionResponse EndDeleteAIGuardrailVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAIGuardrailVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAIPrompt

        /// <summary>
        /// Deletes an Amazon Q in Connect AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIPrompt service method.</param>
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
        public virtual DeleteAIPromptResponse DeleteAIPrompt(DeleteAIPromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIPromptResponseUnmarshaller.Instance;

            return Invoke<DeleteAIPromptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIPrompt operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIPrompt
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPrompt">REST API Reference for DeleteAIPrompt Operation</seealso>
        public virtual IAsyncResult BeginDeleteAIPrompt(DeleteAIPromptRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIPromptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIPrompt.</param>
        /// 
        /// <returns>Returns a  DeleteAIPromptResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPrompt">REST API Reference for DeleteAIPrompt Operation</seealso>
        public virtual DeleteAIPromptResponse EndDeleteAIPrompt(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAIPromptResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAIPromptVersion

        /// <summary>
        /// Delete and Amazon Q in Connect AI Prompt version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIPromptVersion service method.</param>
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
        public virtual DeleteAIPromptVersionResponse DeleteAIPromptVersion(DeleteAIPromptVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIPromptVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIPromptVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteAIPromptVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAIPromptVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAIPromptVersion operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAIPromptVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPromptVersion">REST API Reference for DeleteAIPromptVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteAIPromptVersion(DeleteAIPromptVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAIPromptVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAIPromptVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAIPromptVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAIPromptVersion.</param>
        /// 
        /// <returns>Returns a  DeleteAIPromptVersionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAIPromptVersion">REST API Reference for DeleteAIPromptVersion Operation</seealso>
        public virtual DeleteAIPromptVersionResponse EndDeleteAIPromptVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAIPromptVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssistant

        /// <summary>
        /// Deletes an assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistant service method.</param>
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
        public virtual DeleteAssistantResponse DeleteAssistant(DeleteAssistantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssistantResponseUnmarshaller.Instance;

            return Invoke<DeleteAssistantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistant operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistant">REST API Reference for DeleteAssistant Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssistant(DeleteAssistantRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssistantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssistant.</param>
        /// 
        /// <returns>Returns a  DeleteAssistantResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistant">REST API Reference for DeleteAssistant Operation</seealso>
        public virtual DeleteAssistantResponse EndDeleteAssistant(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssistantResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssistantAssociation

        /// <summary>
        /// Deletes an assistant association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistantAssociation service method.</param>
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
        public virtual DeleteAssistantAssociationResponse DeleteAssistantAssociation(DeleteAssistantAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssistantAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteAssistantAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssistantAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssistantAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistantAssociation">REST API Reference for DeleteAssistantAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssistantAssociation(DeleteAssistantAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssistantAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssistantAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteAssistantAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteAssistantAssociation">REST API Reference for DeleteAssistantAssociation Operation</seealso>
        public virtual DeleteAssistantAssociationResponse EndDeleteAssistantAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssistantAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteContent

        /// <summary>
        /// Deletes the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContent service method.</param>
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
        public virtual DeleteContentResponse DeleteContent(DeleteContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContentResponseUnmarshaller.Instance;

            return Invoke<DeleteContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContent">REST API Reference for DeleteContent Operation</seealso>
        public virtual IAsyncResult BeginDeleteContent(DeleteContentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContent.</param>
        /// 
        /// <returns>Returns a  DeleteContentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContent">REST API Reference for DeleteContent Operation</seealso>
        public virtual DeleteContentResponse EndDeleteContent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteContentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteContentAssociation

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
        public virtual DeleteContentAssociationResponse DeleteContentAssociation(DeleteContentAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContentAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteContentAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContentAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContentAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContentAssociation">REST API Reference for DeleteContentAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteContentAssociation(DeleteContentAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContentAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContentAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteContentAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteContentAssociation">REST API Reference for DeleteContentAssociation Operation</seealso>
        public virtual DeleteContentAssociationResponse EndDeleteContentAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteContentAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteImportJob

        /// <summary>
        /// Deletes the quick response import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportJob service method.</param>
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
        public virtual DeleteImportJobResponse DeleteImportJob(DeleteImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportJobResponseUnmarshaller.Instance;

            return Invoke<DeleteImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportJob operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteImportJob">REST API Reference for DeleteImportJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteImportJob(DeleteImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImportJob.</param>
        /// 
        /// <returns>Returns a  DeleteImportJobResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteImportJob">REST API Reference for DeleteImportJob Operation</seealso>
        public virtual DeleteImportJobResponse EndDeleteImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKnowledgeBase

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
        public virtual DeleteKnowledgeBaseResponse DeleteKnowledgeBase(DeleteKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<DeleteKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginDeleteKnowledgeBase(DeleteKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  DeleteKnowledgeBaseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        public virtual DeleteKnowledgeBaseResponse EndDeleteKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKnowledgeBaseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMessageTemplate

        /// <summary>
        /// Deletes an Amazon Q in Connect message template entirely or a specific version of
        /// the message template if version is supplied in the request. You can provide the message
        /// template identifier as <c>&lt;message-template-id&gt;:&lt;versionNumber&gt;</c> to
        /// delete a specific version of the message template. If it is not supplied, the message
        /// template and all available versions will be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageTemplate service method.</param>
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
        public virtual DeleteMessageTemplateResponse DeleteMessageTemplate(DeleteMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteMessageTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplate">REST API Reference for DeleteMessageTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteMessageTemplate(DeleteMessageTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMessageTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplate">REST API Reference for DeleteMessageTemplate Operation</seealso>
        public virtual DeleteMessageTemplateResponse EndDeleteMessageTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMessageTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMessageTemplateAttachment

        /// <summary>
        /// Deletes the attachment file from the Amazon Q in Connect message template that is
        /// referenced by <c>$LATEST</c> qualifier. Attachments on available message template
        /// versions will remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageTemplateAttachment service method.</param>
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
        public virtual DeleteMessageTemplateAttachmentResponse DeleteMessageTemplateAttachment(DeleteMessageTemplateAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMessageTemplateAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageTemplateAttachmentResponseUnmarshaller.Instance;

            return Invoke<DeleteMessageTemplateAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessageTemplateAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageTemplateAttachment operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMessageTemplateAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplateAttachment">REST API Reference for DeleteMessageTemplateAttachment Operation</seealso>
        public virtual IAsyncResult BeginDeleteMessageTemplateAttachment(DeleteMessageTemplateAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMessageTemplateAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageTemplateAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMessageTemplateAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMessageTemplateAttachment.</param>
        /// 
        /// <returns>Returns a  DeleteMessageTemplateAttachmentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteMessageTemplateAttachment">REST API Reference for DeleteMessageTemplateAttachment Operation</seealso>
        public virtual DeleteMessageTemplateAttachmentResponse EndDeleteMessageTemplateAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMessageTemplateAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteQuickResponse

        /// <summary>
        /// Deletes a quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuickResponse service method.</param>
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
        public virtual DeleteQuickResponseResponse DeleteQuickResponse(DeleteQuickResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQuickResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteQuickResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuickResponse operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQuickResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteQuickResponse">REST API Reference for DeleteQuickResponse Operation</seealso>
        public virtual IAsyncResult BeginDeleteQuickResponse(DeleteQuickResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQuickResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQuickResponse.</param>
        /// 
        /// <returns>Returns a  DeleteQuickResponseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/DeleteQuickResponse">REST API Reference for DeleteQuickResponse Operation</seealso>
        public virtual DeleteQuickResponseResponse EndDeleteQuickResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQuickResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAIAgent

        /// <summary>
        /// Gets an Amazon Q in Connect AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAIAgent service method.</param>
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
        public virtual GetAIAgentResponse GetAIAgent(GetAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIAgentResponseUnmarshaller.Instance;

            return Invoke<GetAIAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIAgent">REST API Reference for GetAIAgent Operation</seealso>
        public virtual IAsyncResult BeginGetAIAgent(GetAIAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAIAgent.</param>
        /// 
        /// <returns>Returns a  GetAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIAgent">REST API Reference for GetAIAgent Operation</seealso>
        public virtual GetAIAgentResponse EndGetAIAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAIAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAIGuardrail

        /// <summary>
        /// Gets the Amazon Q in Connect AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAIGuardrail service method.</param>
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
        public virtual GetAIGuardrailResponse GetAIGuardrail(GetAIGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIGuardrailResponseUnmarshaller.Instance;

            return Invoke<GetAIGuardrailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAIGuardrail operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAIGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIGuardrail">REST API Reference for GetAIGuardrail Operation</seealso>
        public virtual IAsyncResult BeginGetAIGuardrail(GetAIGuardrailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIGuardrailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAIGuardrail.</param>
        /// 
        /// <returns>Returns a  GetAIGuardrailResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIGuardrail">REST API Reference for GetAIGuardrail Operation</seealso>
        public virtual GetAIGuardrailResponse EndGetAIGuardrail(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAIGuardrailResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAIPrompt

        /// <summary>
        /// Gets and Amazon Q in Connect AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAIPrompt service method.</param>
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
        public virtual GetAIPromptResponse GetAIPrompt(GetAIPromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIPromptResponseUnmarshaller.Instance;

            return Invoke<GetAIPromptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAIPrompt operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAIPrompt
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIPrompt">REST API Reference for GetAIPrompt Operation</seealso>
        public virtual IAsyncResult BeginGetAIPrompt(GetAIPromptRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAIPromptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAIPrompt.</param>
        /// 
        /// <returns>Returns a  GetAIPromptResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAIPrompt">REST API Reference for GetAIPrompt Operation</seealso>
        public virtual GetAIPromptResponse EndGetAIPrompt(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAIPromptResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssistant

        /// <summary>
        /// Retrieves information about an assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssistant service method.</param>
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
        public virtual GetAssistantResponse GetAssistant(GetAssistantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssistantResponseUnmarshaller.Instance;

            return Invoke<GetAssistantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssistant operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistant">REST API Reference for GetAssistant Operation</seealso>
        public virtual IAsyncResult BeginGetAssistant(GetAssistantRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssistantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssistant.</param>
        /// 
        /// <returns>Returns a  GetAssistantResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistant">REST API Reference for GetAssistant Operation</seealso>
        public virtual GetAssistantResponse EndGetAssistant(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssistantResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssistantAssociation

        /// <summary>
        /// Retrieves information about an assistant association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssistantAssociation service method.</param>
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
        public virtual GetAssistantAssociationResponse GetAssistantAssociation(GetAssistantAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssistantAssociationResponseUnmarshaller.Instance;

            return Invoke<GetAssistantAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssistantAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssistantAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistantAssociation">REST API Reference for GetAssistantAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetAssistantAssociation(GetAssistantAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssistantAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssistantAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssistantAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssistantAssociation.</param>
        /// 
        /// <returns>Returns a  GetAssistantAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetAssistantAssociation">REST API Reference for GetAssistantAssociation Operation</seealso>
        public virtual GetAssistantAssociationResponse EndGetAssistantAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssistantAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContent

        /// <summary>
        /// Retrieves content, including a pre-signed URL to download the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContent service method.</param>
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
        public virtual GetContentResponse GetContent(GetContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentResponseUnmarshaller.Instance;

            return Invoke<GetContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContent">REST API Reference for GetContent Operation</seealso>
        public virtual IAsyncResult BeginGetContent(GetContentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContent.</param>
        /// 
        /// <returns>Returns a  GetContentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContent">REST API Reference for GetContent Operation</seealso>
        public virtual GetContentResponse EndGetContent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContentAssociation

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
        public virtual GetContentAssociationResponse GetContentAssociation(GetContentAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentAssociationResponseUnmarshaller.Instance;

            return Invoke<GetContentAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContentAssociation operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContentAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentAssociation">REST API Reference for GetContentAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetContentAssociation(GetContentAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContentAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContentAssociation.</param>
        /// 
        /// <returns>Returns a  GetContentAssociationResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentAssociation">REST API Reference for GetContentAssociation Operation</seealso>
        public virtual GetContentAssociationResponse EndGetContentAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContentAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContentSummary

        /// <summary>
        /// Retrieves summary information about the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContentSummary service method.</param>
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
        public virtual GetContentSummaryResponse GetContentSummary(GetContentSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentSummaryResponseUnmarshaller.Instance;

            return Invoke<GetContentSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContentSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContentSummary operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContentSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentSummary">REST API Reference for GetContentSummary Operation</seealso>
        public virtual IAsyncResult BeginGetContentSummary(GetContentSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContentSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContentSummary.</param>
        /// 
        /// <returns>Returns a  GetContentSummaryResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetContentSummary">REST API Reference for GetContentSummary Operation</seealso>
        public virtual GetContentSummaryResponse EndGetContentSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContentSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImportJob

        /// <summary>
        /// Retrieves the started import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
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
        public virtual GetImportJobResponse GetImportJob(GetImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return Invoke<GetImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        public virtual IAsyncResult BeginGetImportJob(GetImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJob.</param>
        /// 
        /// <returns>Returns a  GetImportJobResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        public virtual GetImportJobResponse EndGetImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKnowledgeBase

        /// <summary>
        /// Retrieves information about the knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase service method.</param>
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
        public virtual GetKnowledgeBaseResponse GetKnowledgeBase(GetKnowledgeBaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<GetKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginGetKnowledgeBase(GetKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  GetKnowledgeBaseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        public virtual GetKnowledgeBaseResponse EndGetKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKnowledgeBaseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMessageTemplate

        /// <summary>
        /// Retrieves the Amazon Q in Connect message template. The message template identifier
        /// can contain an optional qualifier, for example, <c>&lt;message-template-id&gt;:&lt;qualifier&gt;</c>,
        /// which is either an actual version number or an Amazon Q Connect managed qualifier
        /// <c>$ACTIVE_VERSION</c> | <c>$LATEST</c>. If it is not supplied, then <c>$LATEST</c>
        /// is assumed implicitly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMessageTemplate service method.</param>
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
        public virtual GetMessageTemplateResponse GetMessageTemplate(GetMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<GetMessageTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetMessageTemplate">REST API Reference for GetMessageTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetMessageTemplate(GetMessageTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessageTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMessageTemplate.</param>
        /// 
        /// <returns>Returns a  GetMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetMessageTemplate">REST API Reference for GetMessageTemplate Operation</seealso>
        public virtual GetMessageTemplateResponse EndGetMessageTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMessageTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNextMessage

        /// <summary>
        /// Retrieves next message on an Amazon Q in Connect session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNextMessage service method.</param>
        /// 
        /// <returns>The response from the GetNextMessage service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.UnprocessableContentException">
        /// The server has a failure of processing the message
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetNextMessage">REST API Reference for GetNextMessage Operation</seealso>
        public virtual GetNextMessageResponse GetNextMessage(GetNextMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNextMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNextMessageResponseUnmarshaller.Instance;

            return Invoke<GetNextMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNextMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNextMessage operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNextMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetNextMessage">REST API Reference for GetNextMessage Operation</seealso>
        public virtual IAsyncResult BeginGetNextMessage(GetNextMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNextMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNextMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNextMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNextMessage.</param>
        /// 
        /// <returns>Returns a  GetNextMessageResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetNextMessage">REST API Reference for GetNextMessage Operation</seealso>
        public virtual GetNextMessageResponse EndGetNextMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNextMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetQuickResponse

        /// <summary>
        /// Retrieves the quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuickResponse service method.</param>
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
        public virtual GetQuickResponseResponse GetQuickResponse(GetQuickResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQuickResponseResponseUnmarshaller.Instance;

            return Invoke<GetQuickResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQuickResponse operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQuickResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetQuickResponse">REST API Reference for GetQuickResponse Operation</seealso>
        public virtual IAsyncResult BeginGetQuickResponse(GetQuickResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQuickResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQuickResponse.</param>
        /// 
        /// <returns>Returns a  GetQuickResponseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetQuickResponse">REST API Reference for GetQuickResponse Operation</seealso>
        public virtual GetQuickResponseResponse EndGetQuickResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQuickResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecommendations

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
        public virtual GetRecommendationsResponse GetRecommendations(GetRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        [Obsolete("GetRecommendations API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        public virtual IAsyncResult BeginGetRecommendations(GetRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendations.</param>
        /// 
        /// <returns>Returns a  GetRecommendationsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        [Obsolete("GetRecommendations API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        public virtual GetRecommendationsResponse EndGetRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSession

        /// <summary>
        /// Retrieves information for a specified session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
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
        public virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return Invoke<GetSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual GetSessionResponse EndGetSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAIAgents

        /// <summary>
        /// Lists AI Agents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIAgents service method.</param>
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
        public virtual ListAIAgentsResponse ListAIAgents(ListAIAgentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAIAgentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIAgents operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIAgents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgents">REST API Reference for ListAIAgents Operation</seealso>
        public virtual IAsyncResult BeginListAIAgents(ListAIAgentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIAgentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIAgents.</param>
        /// 
        /// <returns>Returns a  ListAIAgentsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgents">REST API Reference for ListAIAgents Operation</seealso>
        public virtual ListAIAgentsResponse EndListAIAgents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAIAgentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAIAgentVersions

        /// <summary>
        /// List AI Agent versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIAgentVersions service method.</param>
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
        public virtual ListAIAgentVersionsResponse ListAIAgentVersions(ListAIAgentVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIAgentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIAgentVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAIAgentVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIAgentVersions operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIAgentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgentVersions">REST API Reference for ListAIAgentVersions Operation</seealso>
        public virtual IAsyncResult BeginListAIAgentVersions(ListAIAgentVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIAgentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIAgentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIAgentVersions.</param>
        /// 
        /// <returns>Returns a  ListAIAgentVersionsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIAgentVersions">REST API Reference for ListAIAgentVersions Operation</seealso>
        public virtual ListAIAgentVersionsResponse EndListAIAgentVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAIAgentVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAIGuardrails

        /// <summary>
        /// Lists the AI Guardrails available on the Amazon Q in Connect assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIGuardrails service method.</param>
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
        public virtual ListAIGuardrailsResponse ListAIGuardrails(ListAIGuardrailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIGuardrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIGuardrailsResponseUnmarshaller.Instance;

            return Invoke<ListAIGuardrailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIGuardrails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIGuardrails operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIGuardrails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrails">REST API Reference for ListAIGuardrails Operation</seealso>
        public virtual IAsyncResult BeginListAIGuardrails(ListAIGuardrailsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIGuardrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIGuardrailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIGuardrails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIGuardrails.</param>
        /// 
        /// <returns>Returns a  ListAIGuardrailsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrails">REST API Reference for ListAIGuardrails Operation</seealso>
        public virtual ListAIGuardrailsResponse EndListAIGuardrails(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAIGuardrailsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAIGuardrailVersions

        /// <summary>
        /// Lists AI Guardrail versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIGuardrailVersions service method.</param>
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
        public virtual ListAIGuardrailVersionsResponse ListAIGuardrailVersions(ListAIGuardrailVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIGuardrailVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIGuardrailVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAIGuardrailVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIGuardrailVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIGuardrailVersions operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIGuardrailVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrailVersions">REST API Reference for ListAIGuardrailVersions Operation</seealso>
        public virtual IAsyncResult BeginListAIGuardrailVersions(ListAIGuardrailVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIGuardrailVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIGuardrailVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIGuardrailVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIGuardrailVersions.</param>
        /// 
        /// <returns>Returns a  ListAIGuardrailVersionsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIGuardrailVersions">REST API Reference for ListAIGuardrailVersions Operation</seealso>
        public virtual ListAIGuardrailVersionsResponse EndListAIGuardrailVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAIGuardrailVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAIPrompts

        /// <summary>
        /// Lists the AI Prompts available on the Amazon Q in Connect assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIPrompts service method.</param>
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
        public virtual ListAIPromptsResponse ListAIPrompts(ListAIPromptsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIPromptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIPromptsResponseUnmarshaller.Instance;

            return Invoke<ListAIPromptsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIPrompts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIPrompts operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIPrompts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPrompts">REST API Reference for ListAIPrompts Operation</seealso>
        public virtual IAsyncResult BeginListAIPrompts(ListAIPromptsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIPromptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIPromptsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIPrompts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIPrompts.</param>
        /// 
        /// <returns>Returns a  ListAIPromptsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPrompts">REST API Reference for ListAIPrompts Operation</seealso>
        public virtual ListAIPromptsResponse EndListAIPrompts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAIPromptsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAIPromptVersions

        /// <summary>
        /// Lists AI Prompt versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAIPromptVersions service method.</param>
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
        public virtual ListAIPromptVersionsResponse ListAIPromptVersions(ListAIPromptVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIPromptVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIPromptVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAIPromptVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAIPromptVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAIPromptVersions operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAIPromptVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPromptVersions">REST API Reference for ListAIPromptVersions Operation</seealso>
        public virtual IAsyncResult BeginListAIPromptVersions(ListAIPromptVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAIPromptVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAIPromptVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAIPromptVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAIPromptVersions.</param>
        /// 
        /// <returns>Returns a  ListAIPromptVersionsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAIPromptVersions">REST API Reference for ListAIPromptVersions Operation</seealso>
        public virtual ListAIPromptVersionsResponse EndListAIPromptVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAIPromptVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssistantAssociations

        /// <summary>
        /// Lists information about assistant associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssistantAssociations service method.</param>
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
        public virtual ListAssistantAssociationsResponse ListAssistantAssociations(ListAssistantAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssistantAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssistantAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAssistantAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssistantAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssistantAssociations operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssistantAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistantAssociations">REST API Reference for ListAssistantAssociations Operation</seealso>
        public virtual IAsyncResult BeginListAssistantAssociations(ListAssistantAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssistantAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssistantAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssistantAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssistantAssociations.</param>
        /// 
        /// <returns>Returns a  ListAssistantAssociationsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistantAssociations">REST API Reference for ListAssistantAssociations Operation</seealso>
        public virtual ListAssistantAssociationsResponse EndListAssistantAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssistantAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssistants

        /// <summary>
        /// Lists information about assistants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssistants service method.</param>
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
        public virtual ListAssistantsResponse ListAssistants(ListAssistantsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssistantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssistantsResponseUnmarshaller.Instance;

            return Invoke<ListAssistantsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssistants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssistants operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssistants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        public virtual IAsyncResult BeginListAssistants(ListAssistantsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssistantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssistantsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssistants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssistants.</param>
        /// 
        /// <returns>Returns a  ListAssistantsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListAssistants">REST API Reference for ListAssistants Operation</seealso>
        public virtual ListAssistantsResponse EndListAssistants(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssistantsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContentAssociations

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
        public virtual ListContentAssociationsResponse ListContentAssociations(ListContentAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContentAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContentAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListContentAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContentAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContentAssociations operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContentAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContentAssociations">REST API Reference for ListContentAssociations Operation</seealso>
        public virtual IAsyncResult BeginListContentAssociations(ListContentAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContentAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContentAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContentAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContentAssociations.</param>
        /// 
        /// <returns>Returns a  ListContentAssociationsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContentAssociations">REST API Reference for ListContentAssociations Operation</seealso>
        public virtual ListContentAssociationsResponse EndListContentAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContentAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContents

        /// <summary>
        /// Lists the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContents service method.</param>
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
        public virtual ListContentsResponse ListContents(ListContentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContentsResponseUnmarshaller.Instance;

            return Invoke<ListContentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContents operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContents">REST API Reference for ListContents Operation</seealso>
        public virtual IAsyncResult BeginListContents(ListContentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContents.</param>
        /// 
        /// <returns>Returns a  ListContentsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListContents">REST API Reference for ListContents Operation</seealso>
        public virtual ListContentsResponse EndListContents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImportJobs

        /// <summary>
        /// Lists information about import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListImportJobs service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        public virtual ListImportJobsResponse ListImportJobs(ListImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImportJobs operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListImportJobs(ListImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImportJobs.</param>
        /// 
        /// <returns>Returns a  ListImportJobsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        public virtual ListImportJobsResponse EndListImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKnowledgeBases

        /// <summary>
        /// Lists the knowledge bases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases service method.</param>
        /// 
        /// <returns>The response from the ListKnowledgeBases service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        public virtual ListKnowledgeBasesResponse ListKnowledgeBases(ListKnowledgeBasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKnowledgeBasesResponseUnmarshaller.Instance;

            return Invoke<ListKnowledgeBasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKnowledgeBases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        public virtual IAsyncResult BeginListKnowledgeBases(ListKnowledgeBasesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKnowledgeBasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKnowledgeBases.</param>
        /// 
        /// <returns>Returns a  ListKnowledgeBasesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        public virtual ListKnowledgeBasesResponse EndListKnowledgeBases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKnowledgeBasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMessages

        /// <summary>
        /// Lists messages on an Amazon Q in Connect session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessages service method.</param>
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
        public virtual ListMessagesResponse ListMessages(ListMessagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessagesResponseUnmarshaller.Instance;

            return Invoke<ListMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMessages operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessages">REST API Reference for ListMessages Operation</seealso>
        public virtual IAsyncResult BeginListMessages(ListMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMessages.</param>
        /// 
        /// <returns>Returns a  ListMessagesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessages">REST API Reference for ListMessages Operation</seealso>
        public virtual ListMessagesResponse EndListMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMessageTemplates

        /// <summary>
        /// Lists all the available Amazon Q in Connect message templates for the specified knowledge
        /// base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessageTemplates service method.</param>
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
        public virtual ListMessageTemplatesResponse ListMessageTemplates(ListMessageTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessageTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessageTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListMessageTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMessageTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMessageTemplates operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMessageTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplates">REST API Reference for ListMessageTemplates Operation</seealso>
        public virtual IAsyncResult BeginListMessageTemplates(ListMessageTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessageTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessageTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMessageTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMessageTemplates.</param>
        /// 
        /// <returns>Returns a  ListMessageTemplatesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplates">REST API Reference for ListMessageTemplates Operation</seealso>
        public virtual ListMessageTemplatesResponse EndListMessageTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMessageTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMessageTemplateVersions

        /// <summary>
        /// Lists all the available versions for the specified Amazon Q in Connect message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessageTemplateVersions service method.</param>
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
        public virtual ListMessageTemplateVersionsResponse ListMessageTemplateVersions(ListMessageTemplateVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessageTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessageTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<ListMessageTemplateVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMessageTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMessageTemplateVersions operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMessageTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplateVersions">REST API Reference for ListMessageTemplateVersions Operation</seealso>
        public virtual IAsyncResult BeginListMessageTemplateVersions(ListMessageTemplateVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMessageTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessageTemplateVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMessageTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMessageTemplateVersions.</param>
        /// 
        /// <returns>Returns a  ListMessageTemplateVersionsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListMessageTemplateVersions">REST API Reference for ListMessageTemplateVersions Operation</seealso>
        public virtual ListMessageTemplateVersionsResponse EndListMessageTemplateVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMessageTemplateVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListQuickResponses

        /// <summary>
        /// Lists information about quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickResponses service method.</param>
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
        public virtual ListQuickResponsesResponse ListQuickResponses(ListQuickResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQuickResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickResponsesResponseUnmarshaller.Instance;

            return Invoke<ListQuickResponsesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQuickResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQuickResponses operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQuickResponses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListQuickResponses">REST API Reference for ListQuickResponses Operation</seealso>
        public virtual IAsyncResult BeginListQuickResponses(ListQuickResponsesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQuickResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickResponsesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQuickResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQuickResponses.</param>
        /// 
        /// <returns>Returns a  ListQuickResponsesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListQuickResponses">REST API Reference for ListQuickResponses Operation</seealso>
        public virtual ListQuickResponsesResponse EndListQuickResponses(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQuickResponsesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSpans

        /// <summary>
        /// Retrieves AI agent execution traces for a session, providing granular visibility into
        /// agent orchestration flows, LLM interactions, and tool invocations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpans service method.</param>
        /// 
        /// <returns>The response from the ListSpans service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListSpans">REST API Reference for ListSpans Operation</seealso>
        public virtual ListSpansResponse ListSpans(ListSpansRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpansResponseUnmarshaller.Instance;

            return Invoke<ListSpansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSpans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSpans operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSpans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListSpans">REST API Reference for ListSpans Operation</seealso>
        public virtual IAsyncResult BeginListSpans(ListSpansRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSpans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSpans.</param>
        /// 
        /// <returns>Returns a  ListSpansResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListSpans">REST API Reference for ListSpans Operation</seealso>
        public virtual ListSpansResponse EndListSpans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSpansResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  NotifyRecommendationsReceived

        /// <summary>
        /// Removes the specified recommendations from the specified assistant's queue of newly
        /// available recommendations. You can use this API in conjunction with <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>
        /// and a <c>waitTimeSeconds</c> input for long-polling behavior and avoiding duplicate
        /// recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyRecommendationsReceived service method.</param>
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
        public virtual NotifyRecommendationsReceivedResponse NotifyRecommendationsReceived(NotifyRecommendationsReceivedRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NotifyRecommendationsReceivedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyRecommendationsReceivedResponseUnmarshaller.Instance;

            return Invoke<NotifyRecommendationsReceivedResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NotifyRecommendationsReceived operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyRecommendationsReceived operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNotifyRecommendationsReceived
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/NotifyRecommendationsReceived">REST API Reference for NotifyRecommendationsReceived Operation</seealso>
        public virtual IAsyncResult BeginNotifyRecommendationsReceived(NotifyRecommendationsReceivedRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NotifyRecommendationsReceivedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyRecommendationsReceivedResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NotifyRecommendationsReceived operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNotifyRecommendationsReceived.</param>
        /// 
        /// <returns>Returns a  NotifyRecommendationsReceivedResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/NotifyRecommendationsReceived">REST API Reference for NotifyRecommendationsReceived Operation</seealso>
        public virtual NotifyRecommendationsReceivedResponse EndNotifyRecommendationsReceived(IAsyncResult asyncResult)
        {
            return EndInvoke<NotifyRecommendationsReceivedResponse>(asyncResult);
        }

        #endregion
        
        #region  PutFeedback

        /// <summary>
        /// Provides feedback against the specified assistant for the specified target. This API
        /// only supports generative targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
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
        public virtual PutFeedbackResponse PutFeedback(PutFeedbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual IAsyncResult BeginPutFeedback(PutFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFeedback.</param>
        /// 
        /// <returns>Returns a  PutFeedbackResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual PutFeedbackResponse EndPutFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<PutFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryAssistant

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
        public virtual QueryAssistantResponse QueryAssistant(QueryAssistantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryAssistantResponseUnmarshaller.Instance;

            return Invoke<QueryAssistantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryAssistant operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/QueryAssistant">REST API Reference for QueryAssistant Operation</seealso>
        [Obsolete("QueryAssistant API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        public virtual IAsyncResult BeginQueryAssistant(QueryAssistantRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryAssistantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryAssistant.</param>
        /// 
        /// <returns>Returns a  QueryAssistantResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/QueryAssistant">REST API Reference for QueryAssistant Operation</seealso>
        [Obsolete("QueryAssistant API will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.")]
        public virtual QueryAssistantResponse EndQueryAssistant(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryAssistantResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveAssistantAIAgent

        /// <summary>
        /// Removes the AI Agent that is set for use by default on an Amazon Q in Connect Assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAssistantAIAgent service method.</param>
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
        public virtual RemoveAssistantAIAgentResponse RemoveAssistantAIAgent(RemoveAssistantAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAssistantAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAssistantAIAgentResponseUnmarshaller.Instance;

            return Invoke<RemoveAssistantAIAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAssistantAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAssistantAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAssistantAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveAssistantAIAgent">REST API Reference for RemoveAssistantAIAgent Operation</seealso>
        public virtual IAsyncResult BeginRemoveAssistantAIAgent(RemoveAssistantAIAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAssistantAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAssistantAIAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAssistantAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAssistantAIAgent.</param>
        /// 
        /// <returns>Returns a  RemoveAssistantAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveAssistantAIAgent">REST API Reference for RemoveAssistantAIAgent Operation</seealso>
        public virtual RemoveAssistantAIAgentResponse EndRemoveAssistantAIAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveAssistantAIAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveKnowledgeBaseTemplateUri

        /// <summary>
        /// Removes a URI template from a knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveKnowledgeBaseTemplateUri service method.</param>
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
        public virtual RemoveKnowledgeBaseTemplateUriResponse RemoveKnowledgeBaseTemplateUri(RemoveKnowledgeBaseTemplateUriRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveKnowledgeBaseTemplateUriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveKnowledgeBaseTemplateUriResponseUnmarshaller.Instance;

            return Invoke<RemoveKnowledgeBaseTemplateUriResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveKnowledgeBaseTemplateUri operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveKnowledgeBaseTemplateUri
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveKnowledgeBaseTemplateUri">REST API Reference for RemoveKnowledgeBaseTemplateUri Operation</seealso>
        public virtual IAsyncResult BeginRemoveKnowledgeBaseTemplateUri(RemoveKnowledgeBaseTemplateUriRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveKnowledgeBaseTemplateUriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveKnowledgeBaseTemplateUriResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveKnowledgeBaseTemplateUri.</param>
        /// 
        /// <returns>Returns a  RemoveKnowledgeBaseTemplateUriResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RemoveKnowledgeBaseTemplateUri">REST API Reference for RemoveKnowledgeBaseTemplateUri Operation</seealso>
        public virtual RemoveKnowledgeBaseTemplateUriResponse EndRemoveKnowledgeBaseTemplateUri(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveKnowledgeBaseTemplateUriResponse>(asyncResult);
        }

        #endregion
        
        #region  RenderMessageTemplate

        /// <summary>
        /// Renders the Amazon Q in Connect message template based on the attribute values provided
        /// and generates the message content. For any variable present in the message template,
        /// if the attribute value is neither provided in the attribute request parameter nor
        /// the default attribute of the message template, the rendered message content will keep
        /// the variable placeholder as it is and return the attribute keys that are missing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenderMessageTemplate service method.</param>
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
        public virtual RenderMessageTemplateResponse RenderMessageTemplate(RenderMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenderMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenderMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<RenderMessageTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RenderMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenderMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenderMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RenderMessageTemplate">REST API Reference for RenderMessageTemplate Operation</seealso>
        public virtual IAsyncResult BeginRenderMessageTemplate(RenderMessageTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenderMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenderMessageTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RenderMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenderMessageTemplate.</param>
        /// 
        /// <returns>Returns a  RenderMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/RenderMessageTemplate">REST API Reference for RenderMessageTemplate Operation</seealso>
        public virtual RenderMessageTemplateResponse EndRenderMessageTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<RenderMessageTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  Retrieve

        /// <summary>
        /// Retrieves content from knowledge sources based on a query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Retrieve service method.</param>
        /// 
        /// <returns>The response from the Retrieve service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. For example, if you're using a <c>Create</c> API (such as <c>CreateAssistant</c>)
        /// that accepts name, a conflicting resource (usually with the same name) is being created
        /// or mutated.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.DependencyFailedException">
        /// The request failed because it depends on another request that failed.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.RequestTimeoutException">
        /// The request reached the service more than 15 minutes after the date stamp on the request
        /// or more than 15 minutes after the request expiration date (such as for pre-signed
        /// URLs), or the date stamp on the request is more than 15 minutes in the future.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/Retrieve">REST API Reference for Retrieve Operation</seealso>
        public virtual RetrieveResponse Retrieve(RetrieveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetrieveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveResponseUnmarshaller.Instance;

            return Invoke<RetrieveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Retrieve operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Retrieve operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieve
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/Retrieve">REST API Reference for Retrieve Operation</seealso>
        public virtual IAsyncResult BeginRetrieve(RetrieveRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetrieveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Retrieve operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieve.</param>
        /// 
        /// <returns>Returns a  RetrieveResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/Retrieve">REST API Reference for Retrieve Operation</seealso>
        public virtual RetrieveResponse EndRetrieve(IAsyncResult asyncResult)
        {
            return EndInvoke<RetrieveResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchContent

        /// <summary>
        /// Searches for content in a specified knowledge base. Can be used to get a specific
        /// content resource by its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchContent service method.</param>
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
        public virtual SearchContentResponse SearchContent(SearchContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchContentResponseUnmarshaller.Instance;

            return Invoke<SearchContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchContent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchContent">REST API Reference for SearchContent Operation</seealso>
        public virtual IAsyncResult BeginSearchContent(SearchContentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchContent.</param>
        /// 
        /// <returns>Returns a  SearchContentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchContent">REST API Reference for SearchContent Operation</seealso>
        public virtual SearchContentResponse EndSearchContent(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchContentResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchMessageTemplates

        /// <summary>
        /// Searches for Amazon Q in Connect message templates in the specified knowledge base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchMessageTemplates service method.</param>
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
        public virtual SearchMessageTemplatesResponse SearchMessageTemplates(SearchMessageTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchMessageTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchMessageTemplatesResponseUnmarshaller.Instance;

            return Invoke<SearchMessageTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchMessageTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchMessageTemplates operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchMessageTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchMessageTemplates">REST API Reference for SearchMessageTemplates Operation</seealso>
        public virtual IAsyncResult BeginSearchMessageTemplates(SearchMessageTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchMessageTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchMessageTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchMessageTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchMessageTemplates.</param>
        /// 
        /// <returns>Returns a  SearchMessageTemplatesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchMessageTemplates">REST API Reference for SearchMessageTemplates Operation</seealso>
        public virtual SearchMessageTemplatesResponse EndSearchMessageTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchMessageTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchQuickResponses

        /// <summary>
        /// Searches existing Amazon Q in Connect quick responses in an Amazon Q in Connect knowledge
        /// base.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchQuickResponses service method.</param>
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
        public virtual SearchQuickResponsesResponse SearchQuickResponses(SearchQuickResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchQuickResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchQuickResponsesResponseUnmarshaller.Instance;

            return Invoke<SearchQuickResponsesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchQuickResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchQuickResponses operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchQuickResponses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchQuickResponses">REST API Reference for SearchQuickResponses Operation</seealso>
        public virtual IAsyncResult BeginSearchQuickResponses(SearchQuickResponsesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchQuickResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchQuickResponsesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchQuickResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchQuickResponses.</param>
        /// 
        /// <returns>Returns a  SearchQuickResponsesResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchQuickResponses">REST API Reference for SearchQuickResponses Operation</seealso>
        public virtual SearchQuickResponsesResponse EndSearchQuickResponses(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchQuickResponsesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchSessions

        /// <summary>
        /// Searches for sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSessions service method.</param>
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
        public virtual SearchSessionsResponse SearchSessions(SearchSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSessionsResponseUnmarshaller.Instance;

            return Invoke<SearchSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSessions operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchSessions">REST API Reference for SearchSessions Operation</seealso>
        public virtual IAsyncResult BeginSearchSessions(SearchSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSessions.</param>
        /// 
        /// <returns>Returns a  SearchSessionsResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SearchSessions">REST API Reference for SearchSessions Operation</seealso>
        public virtual SearchSessionsResponse EndSearchSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  SendMessage

        /// <summary>
        /// Submits a message to the Amazon Q in Connect session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
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
        /// <exception cref="Amazon.QConnect.Model.DependencyFailedException">
        /// The request failed because it depends on another request that failed.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.RequestTimeoutException">
        /// The request reached the service more than 15 minutes after the date stamp on the request
        /// or more than 15 minutes after the request expiration date (such as for pre-signed
        /// URLs), or the date stamp on the request is more than 15 minutes in the future.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual SendMessageResponse SendMessage(SendMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return Invoke<SendMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessage operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual IAsyncResult BeginSendMessage(SendMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessage.</param>
        /// 
        /// <returns>Returns a  SendMessageResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual SendMessageResponse EndSendMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<SendMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  StartContentUpload

        /// <summary>
        /// Get a URL to upload content to a knowledge base. To upload content, first make a PUT
        /// request to the returned URL with your file, making sure to include the required headers.
        /// Then use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_CreateContent.html">CreateContent</a>
        /// to finalize the content creation process or <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_UpdateContent.html">UpdateContent</a>
        /// to modify an existing resource. You can only upload content to a knowledge base of
        /// type CUSTOM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContentUpload service method.</param>
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
        public virtual StartContentUploadResponse StartContentUpload(StartContentUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartContentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentUploadResponseUnmarshaller.Instance;

            return Invoke<StartContentUploadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartContentUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartContentUpload operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartContentUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartContentUpload">REST API Reference for StartContentUpload Operation</seealso>
        public virtual IAsyncResult BeginStartContentUpload(StartContentUploadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartContentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentUploadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartContentUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartContentUpload.</param>
        /// 
        /// <returns>Returns a  StartContentUploadResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartContentUpload">REST API Reference for StartContentUpload Operation</seealso>
        public virtual StartContentUploadResponse EndStartContentUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<StartContentUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  StartImportJob

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
        public virtual StartImportJobResponse StartImportJob(StartImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportJobResponseUnmarshaller.Instance;

            return Invoke<StartImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImportJob operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartImportJob">REST API Reference for StartImportJob Operation</seealso>
        public virtual IAsyncResult BeginStartImportJob(StartImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImportJob.</param>
        /// 
        /// <returns>Returns a  StartImportJobResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/StartImportJob">REST API Reference for StartImportJob Operation</seealso>
        public virtual StartImportJobResponse EndStartImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.QConnect.Model.TooManyTagsException">
        /// Amazon Q in Connect throws this exception if you have too many tags in your tag set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QConnect.</returns>
        /// <exception cref="Amazon.QConnect.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAIAgent

        /// <summary>
        /// Updates an AI Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIAgent service method.</param>
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
        public virtual UpdateAIAgentResponse UpdateAIAgent(UpdateAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAIAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIAgent">REST API Reference for UpdateAIAgent Operation</seealso>
        public virtual IAsyncResult BeginUpdateAIAgent(UpdateAIAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAIAgent.</param>
        /// 
        /// <returns>Returns a  UpdateAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIAgent">REST API Reference for UpdateAIAgent Operation</seealso>
        public virtual UpdateAIAgentResponse EndUpdateAIAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAIAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAIGuardrail

        /// <summary>
        /// Updates an AI Guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIGuardrail service method.</param>
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
        public virtual UpdateAIGuardrailResponse UpdateAIGuardrail(UpdateAIGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIGuardrailResponseUnmarshaller.Instance;

            return Invoke<UpdateAIGuardrailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIGuardrail operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAIGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIGuardrail">REST API Reference for UpdateAIGuardrail Operation</seealso>
        public virtual IAsyncResult BeginUpdateAIGuardrail(UpdateAIGuardrailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIGuardrailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAIGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAIGuardrail.</param>
        /// 
        /// <returns>Returns a  UpdateAIGuardrailResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIGuardrail">REST API Reference for UpdateAIGuardrail Operation</seealso>
        public virtual UpdateAIGuardrailResponse EndUpdateAIGuardrail(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAIGuardrailResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAIPrompt

        /// <summary>
        /// Updates an AI Prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIPrompt service method.</param>
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
        public virtual UpdateAIPromptResponse UpdateAIPrompt(UpdateAIPromptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIPromptResponseUnmarshaller.Instance;

            return Invoke<UpdateAIPromptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAIPrompt operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAIPrompt
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIPrompt">REST API Reference for UpdateAIPrompt Operation</seealso>
        public virtual IAsyncResult BeginUpdateAIPrompt(UpdateAIPromptRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAIPromptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAIPromptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAIPrompt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAIPrompt.</param>
        /// 
        /// <returns>Returns a  UpdateAIPromptResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAIPrompt">REST API Reference for UpdateAIPrompt Operation</seealso>
        public virtual UpdateAIPromptResponse EndUpdateAIPrompt(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAIPromptResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssistantAIAgent

        /// <summary>
        /// Updates the AI Agent that is set for use by default on an Amazon Q in Connect Assistant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssistantAIAgent service method.</param>
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
        public virtual UpdateAssistantAIAgentResponse UpdateAssistantAIAgent(UpdateAssistantAIAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssistantAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssistantAIAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAssistantAIAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssistantAIAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssistantAIAgent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssistantAIAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAssistantAIAgent">REST API Reference for UpdateAssistantAIAgent Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssistantAIAgent(UpdateAssistantAIAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssistantAIAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssistantAIAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssistantAIAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssistantAIAgent.</param>
        /// 
        /// <returns>Returns a  UpdateAssistantAIAgentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateAssistantAIAgent">REST API Reference for UpdateAssistantAIAgent Operation</seealso>
        public virtual UpdateAssistantAIAgentResponse EndUpdateAssistantAIAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssistantAIAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContent

        /// <summary>
        /// Updates information about the content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContent service method.</param>
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
        public virtual UpdateContentResponse UpdateContent(UpdateContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContentResponseUnmarshaller.Instance;

            return Invoke<UpdateContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContent operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        public virtual IAsyncResult BeginUpdateContent(UpdateContentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContent.</param>
        /// 
        /// <returns>Returns a  UpdateContentResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateContent">REST API Reference for UpdateContent Operation</seealso>
        public virtual UpdateContentResponse EndUpdateContent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKnowledgeBaseTemplateUri

        /// <summary>
        /// Updates the template URI of a knowledge base. This is only supported for knowledge
        /// bases of type EXTERNAL. Include a single variable in <c>${variable}</c> format; this
        /// interpolated by Amazon Q in Connect using ingested content. For example, if you ingest
        /// a Salesforce article, it has an <c>Id</c> value, and you can set the template URI
        /// to <c>https://myInstanceName.lightning.force.com/lightning/r/Knowledge__kav/*${Id}*/view</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBaseTemplateUri service method.</param>
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
        public virtual UpdateKnowledgeBaseTemplateUriResponse UpdateKnowledgeBaseTemplateUri(UpdateKnowledgeBaseTemplateUriRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKnowledgeBaseTemplateUriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKnowledgeBaseTemplateUriResponseUnmarshaller.Instance;

            return Invoke<UpdateKnowledgeBaseTemplateUriResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBaseTemplateUri operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKnowledgeBaseTemplateUri
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateKnowledgeBaseTemplateUri">REST API Reference for UpdateKnowledgeBaseTemplateUri Operation</seealso>
        public virtual IAsyncResult BeginUpdateKnowledgeBaseTemplateUri(UpdateKnowledgeBaseTemplateUriRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKnowledgeBaseTemplateUriRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKnowledgeBaseTemplateUriResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKnowledgeBaseTemplateUri operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKnowledgeBaseTemplateUri.</param>
        /// 
        /// <returns>Returns a  UpdateKnowledgeBaseTemplateUriResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateKnowledgeBaseTemplateUri">REST API Reference for UpdateKnowledgeBaseTemplateUri Operation</seealso>
        public virtual UpdateKnowledgeBaseTemplateUriResponse EndUpdateKnowledgeBaseTemplateUri(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKnowledgeBaseTemplateUriResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMessageTemplate

        /// <summary>
        /// Updates the Amazon Q in Connect message template. Partial update is supported. If
        /// any field is not supplied, it will remain unchanged for the message template that
        /// is referenced by the <c>$LATEST</c> qualifier. Any modification will only apply to
        /// the message template that is referenced by the <c>$LATEST</c> qualifier. The fields
        /// for all available versions will remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMessageTemplate service method.</param>
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
        public virtual UpdateMessageTemplateResponse UpdateMessageTemplate(UpdateMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateMessageTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMessageTemplate operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplate">REST API Reference for UpdateMessageTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateMessageTemplate(UpdateMessageTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMessageTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMessageTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateMessageTemplateResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplate">REST API Reference for UpdateMessageTemplate Operation</seealso>
        public virtual UpdateMessageTemplateResponse EndUpdateMessageTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMessageTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMessageTemplateMetadata

        /// <summary>
        /// Updates the Amazon Q in Connect message template metadata. Note that any modification
        /// to the message template’s name, description and grouping configuration will applied
        /// to the message template pointed by the <c>$LATEST</c> qualifier and all available
        /// versions. Partial update is supported. If any field is not supplied, it will remain
        /// unchanged for the message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMessageTemplateMetadata service method.</param>
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
        public virtual UpdateMessageTemplateMetadataResponse UpdateMessageTemplateMetadata(UpdateMessageTemplateMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMessageTemplateMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMessageTemplateMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateMessageTemplateMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMessageTemplateMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMessageTemplateMetadata operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMessageTemplateMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplateMetadata">REST API Reference for UpdateMessageTemplateMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateMessageTemplateMetadata(UpdateMessageTemplateMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMessageTemplateMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMessageTemplateMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMessageTemplateMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMessageTemplateMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateMessageTemplateMetadataResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateMessageTemplateMetadata">REST API Reference for UpdateMessageTemplateMetadata Operation</seealso>
        public virtual UpdateMessageTemplateMetadataResponse EndUpdateMessageTemplateMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMessageTemplateMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQuickResponse

        /// <summary>
        /// Updates an existing Amazon Q in Connect quick response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickResponse service method.</param>
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
        public virtual UpdateQuickResponseResponse UpdateQuickResponse(UpdateQuickResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateQuickResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickResponse operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQuickResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateQuickResponse">REST API Reference for UpdateQuickResponse Operation</seealso>
        public virtual IAsyncResult BeginUpdateQuickResponse(UpdateQuickResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQuickResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQuickResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQuickResponse.</param>
        /// 
        /// <returns>Returns a  UpdateQuickResponseResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateQuickResponse">REST API Reference for UpdateQuickResponse Operation</seealso>
        public virtual UpdateQuickResponseResponse EndUpdateQuickResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQuickResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSession

        /// <summary>
        /// Updates a session. A session is a contextual container used for generating recommendations.
        /// Amazon Connect updates the existing Amazon Q in Connect session for each contact on
        /// which Amazon Q in Connect is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession service method.</param>
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
        public virtual UpdateSessionResponse UpdateSession(UpdateSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        public virtual IAsyncResult BeginUpdateSession(UpdateSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSession.</param>
        /// 
        /// <returns>Returns a  UpdateSessionResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        public virtual UpdateSessionResponse EndUpdateSession(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSessionData

        /// <summary>
        /// Updates the data stored on an Amazon Q in Connect Session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSessionData service method.</param>
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
        public virtual UpdateSessionDataResponse UpdateSessionData(UpdateSessionDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionDataResponseUnmarshaller.Instance;

            return Invoke<UpdateSessionDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSessionData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSessionData operation on AmazonQConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSessionData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSessionData">REST API Reference for UpdateSessionData Operation</seealso>
        public virtual IAsyncResult BeginUpdateSessionData(UpdateSessionDataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSessionData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSessionData.</param>
        /// 
        /// <returns>Returns a  UpdateSessionDataResult from QConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qconnect-2020-10-19/UpdateSessionData">REST API Reference for UpdateSessionData Operation</seealso>
        public virtual UpdateSessionDataResponse EndUpdateSessionData(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSessionDataResponse>(asyncResult);
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
            var resolver = new AmazonQConnectEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}