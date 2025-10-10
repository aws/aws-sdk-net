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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations;
using Amazon.BedrockAgentCoreControl.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.BedrockAgentCoreControl
{
    /// <summary>
    /// <para>Implementation for accessing BedrockAgentCoreControl</para>
    ///
    /// <note> 
    /// <para>
    ///  is in preview release and is subject to change.
    /// 
    ///  </note> 
    /// <para>
    /// Welcome to the Amazon Bedrock AgentCore Control plane API reference. Control plane
    /// actions configure, create, modify, and monitor Amazon Web Services resources.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonBedrockAgentCoreControlClient : AmazonServiceClient, IAmazonBedrockAgentCoreControl
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockAgentCoreControlMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IBedrockAgentCoreControlPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBedrockAgentCoreControlPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BedrockAgentCoreControlPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with the credentials loaded from the application's
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
        public AmazonBedrockAgentCoreControlClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockAgentCoreControlConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with the credentials loaded from the application's
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
        public AmazonBedrockAgentCoreControlClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockAgentCoreControlConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockAgentCoreControlClient Configuration Object</param>
        public AmazonBedrockAgentCoreControlClient(AmazonBedrockAgentCoreControlConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockAgentCoreControlClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockAgentCoreControlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentCoreControlClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockAgentCoreControlConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with AWS Credentials and an
        /// AmazonBedrockAgentCoreControlClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockAgentCoreControlClient Configuration Object</param>
        public AmazonBedrockAgentCoreControlClient(AWSCredentials credentials, AmazonBedrockAgentCoreControlConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockAgentCoreControlClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockAgentCoreControlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentCoreControlClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockAgentCoreControlConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockAgentCoreControlClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockAgentCoreControlClient Configuration Object</param>
        public AmazonBedrockAgentCoreControlClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockAgentCoreControlConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockAgentCoreControlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockAgentCoreControlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentCoreControlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockAgentCoreControlConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreControlClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockAgentCoreControlClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockAgentCoreControlClient Configuration Object</param>
        public AmazonBedrockAgentCoreControlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockAgentCoreControlConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockAgentCoreControlEndpointResolver());
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


        #region  CreateAgentRuntime

        /// <summary>
        /// Creates an Amazon Bedrock AgentCore Runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentRuntime service method.</param>
        /// 
        /// <returns>The response from the CreateAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntime">REST API Reference for CreateAgentRuntime Operation</seealso>
        public virtual CreateAgentRuntimeResponse CreateAgentRuntime(CreateAgentRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentRuntimeResponseUnmarshaller.Instance;

            return Invoke<CreateAgentRuntimeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentRuntime operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgentRuntime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntime">REST API Reference for CreateAgentRuntime Operation</seealso>
        public virtual IAsyncResult BeginCreateAgentRuntime(CreateAgentRuntimeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentRuntimeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgentRuntime.</param>
        /// 
        /// <returns>Returns a  CreateAgentRuntimeResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntime">REST API Reference for CreateAgentRuntime Operation</seealso>
        public virtual CreateAgentRuntimeResponse EndCreateAgentRuntime(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAgentRuntimeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAgentRuntimeEndpoint

        /// <summary>
        /// Creates an AgentCore Runtime endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentRuntimeEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntimeEndpoint">REST API Reference for CreateAgentRuntimeEndpoint Operation</seealso>
        public virtual CreateAgentRuntimeEndpointResponse CreateAgentRuntimeEndpoint(CreateAgentRuntimeEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentRuntimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentRuntimeEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateAgentRuntimeEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentRuntimeEndpoint operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgentRuntimeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntimeEndpoint">REST API Reference for CreateAgentRuntimeEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateAgentRuntimeEndpoint(CreateAgentRuntimeEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentRuntimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentRuntimeEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgentRuntimeEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateAgentRuntimeEndpointResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateAgentRuntimeEndpoint">REST API Reference for CreateAgentRuntimeEndpoint Operation</seealso>
        public virtual CreateAgentRuntimeEndpointResponse EndCreateAgentRuntimeEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAgentRuntimeEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApiKeyCredentialProvider

        /// <summary>
        /// Creates a new API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKeyCredentialProvider service method.</param>
        /// 
        /// <returns>The response from the CreateApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceLimitExceededException">
        /// Exception thrown when a resource limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateApiKeyCredentialProvider">REST API Reference for CreateApiKeyCredentialProvider Operation</seealso>
        public virtual CreateApiKeyCredentialProviderResponse CreateApiKeyCredentialProvider(CreateApiKeyCredentialProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiKeyCredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiKeyCredentialProviderResponseUnmarshaller.Instance;

            return Invoke<CreateApiKeyCredentialProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKeyCredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApiKeyCredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateApiKeyCredentialProvider">REST API Reference for CreateApiKeyCredentialProvider Operation</seealso>
        public virtual IAsyncResult BeginCreateApiKeyCredentialProvider(CreateApiKeyCredentialProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiKeyCredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiKeyCredentialProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiKeyCredentialProvider.</param>
        /// 
        /// <returns>Returns a  CreateApiKeyCredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateApiKeyCredentialProvider">REST API Reference for CreateApiKeyCredentialProvider Operation</seealso>
        public virtual CreateApiKeyCredentialProviderResponse EndCreateApiKeyCredentialProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApiKeyCredentialProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBrowser

        /// <summary>
        /// Creates a custom browser.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowser service method.</param>
        /// 
        /// <returns>The response from the CreateBrowser service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateBrowser">REST API Reference for CreateBrowser Operation</seealso>
        public virtual CreateBrowserResponse CreateBrowser(CreateBrowserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBrowserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrowserResponseUnmarshaller.Instance;

            return Invoke<CreateBrowserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBrowser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowser operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBrowser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateBrowser">REST API Reference for CreateBrowser Operation</seealso>
        public virtual IAsyncResult BeginCreateBrowser(CreateBrowserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBrowserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrowserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBrowser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBrowser.</param>
        /// 
        /// <returns>Returns a  CreateBrowserResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateBrowser">REST API Reference for CreateBrowser Operation</seealso>
        public virtual CreateBrowserResponse EndCreateBrowser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBrowserResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCodeInterpreter

        /// <summary>
        /// Creates a custom code interpreter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeInterpreter service method.</param>
        /// 
        /// <returns>The response from the CreateCodeInterpreter service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateCodeInterpreter">REST API Reference for CreateCodeInterpreter Operation</seealso>
        public virtual CreateCodeInterpreterResponse CreateCodeInterpreter(CreateCodeInterpreterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeInterpreterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeInterpreterResponseUnmarshaller.Instance;

            return Invoke<CreateCodeInterpreterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeInterpreter operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCodeInterpreter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateCodeInterpreter">REST API Reference for CreateCodeInterpreter Operation</seealso>
        public virtual IAsyncResult BeginCreateCodeInterpreter(CreateCodeInterpreterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeInterpreterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeInterpreterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCodeInterpreter.</param>
        /// 
        /// <returns>Returns a  CreateCodeInterpreterResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateCodeInterpreter">REST API Reference for CreateCodeInterpreter Operation</seealso>
        public virtual CreateCodeInterpreterResponse EndCreateCodeInterpreter(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCodeInterpreterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGateway

        /// <summary>
        /// Creates a gateway for Amazon Bedrock Agent. A gateway serves as an integration point
        /// between your agent and external services.
        /// 
        ///  
        /// <para>
        /// If you specify <c>CUSTOM_JWT</c> as the <c>authorizerType</c>, you must provide an
        /// <c>authorizerConfiguration</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// 
        /// <returns>The response from the CreateGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual CreateGatewayResponse CreateGateway(CreateGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual IAsyncResult BeginCreateGateway(CreateGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGateway.</param>
        /// 
        /// <returns>Returns a  CreateGatewayResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual CreateGatewayResponse EndCreateGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGatewayTarget

        /// <summary>
        /// Creates a target for a gateway. A target defines an endpoint that the gateway can
        /// connect to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGatewayTarget service method.</param>
        /// 
        /// <returns>The response from the CreateGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGatewayTarget">REST API Reference for CreateGatewayTarget Operation</seealso>
        public virtual CreateGatewayTargetResponse CreateGatewayTarget(CreateGatewayTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayTargetResponseUnmarshaller.Instance;

            return Invoke<CreateGatewayTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGatewayTarget operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGatewayTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGatewayTarget">REST API Reference for CreateGatewayTarget Operation</seealso>
        public virtual IAsyncResult BeginCreateGatewayTarget(CreateGatewayTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGatewayTarget.</param>
        /// 
        /// <returns>Returns a  CreateGatewayTargetResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateGatewayTarget">REST API Reference for CreateGatewayTarget Operation</seealso>
        public virtual CreateGatewayTargetResponse EndCreateGatewayTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGatewayTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMemory

        /// <summary>
        /// Creates a new Amazon Bedrock AgentCore Memory resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMemory service method.</param>
        /// 
        /// <returns>The response from the CreateMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateMemory">REST API Reference for CreateMemory Operation</seealso>
        public virtual CreateMemoryResponse CreateMemory(CreateMemoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMemoryResponseUnmarshaller.Instance;

            return Invoke<CreateMemoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMemory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMemory operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMemory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateMemory">REST API Reference for CreateMemory Operation</seealso>
        public virtual IAsyncResult BeginCreateMemory(CreateMemoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMemoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMemory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMemory.</param>
        /// 
        /// <returns>Returns a  CreateMemoryResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateMemory">REST API Reference for CreateMemory Operation</seealso>
        public virtual CreateMemoryResponse EndCreateMemory(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMemoryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOauth2CredentialProvider

        /// <summary>
        /// Creates a new OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOauth2CredentialProvider service method.</param>
        /// 
        /// <returns>The response from the CreateOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceLimitExceededException">
        /// Exception thrown when a resource limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateOauth2CredentialProvider">REST API Reference for CreateOauth2CredentialProvider Operation</seealso>
        public virtual CreateOauth2CredentialProviderResponse CreateOauth2CredentialProvider(CreateOauth2CredentialProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOauth2CredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOauth2CredentialProviderResponseUnmarshaller.Instance;

            return Invoke<CreateOauth2CredentialProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOauth2CredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOauth2CredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateOauth2CredentialProvider">REST API Reference for CreateOauth2CredentialProvider Operation</seealso>
        public virtual IAsyncResult BeginCreateOauth2CredentialProvider(CreateOauth2CredentialProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOauth2CredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOauth2CredentialProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOauth2CredentialProvider.</param>
        /// 
        /// <returns>Returns a  CreateOauth2CredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateOauth2CredentialProvider">REST API Reference for CreateOauth2CredentialProvider Operation</seealso>
        public virtual CreateOauth2CredentialProviderResponse EndCreateOauth2CredentialProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOauth2CredentialProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkloadIdentity

        /// <summary>
        /// Creates a new workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateWorkloadIdentity">REST API Reference for CreateWorkloadIdentity Operation</seealso>
        public virtual CreateWorkloadIdentityResponse CreateWorkloadIdentity(CreateWorkloadIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkloadIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkloadIdentityResponseUnmarshaller.Instance;

            return Invoke<CreateWorkloadIdentityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadIdentity operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkloadIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateWorkloadIdentity">REST API Reference for CreateWorkloadIdentity Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkloadIdentity(CreateWorkloadIdentityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkloadIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkloadIdentityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkloadIdentity.</param>
        /// 
        /// <returns>Returns a  CreateWorkloadIdentityResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/CreateWorkloadIdentity">REST API Reference for CreateWorkloadIdentity Operation</seealso>
        public virtual CreateWorkloadIdentityResponse EndCreateWorkloadIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkloadIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAgentRuntime

        /// <summary>
        /// Deletes an Amazon Bedrock AgentCore Runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRuntime service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntime">REST API Reference for DeleteAgentRuntime Operation</seealso>
        public virtual DeleteAgentRuntimeResponse DeleteAgentRuntime(DeleteAgentRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentRuntimeResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentRuntimeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRuntime operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentRuntime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntime">REST API Reference for DeleteAgentRuntime Operation</seealso>
        public virtual IAsyncResult BeginDeleteAgentRuntime(DeleteAgentRuntimeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentRuntimeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentRuntime.</param>
        /// 
        /// <returns>Returns a  DeleteAgentRuntimeResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntime">REST API Reference for DeleteAgentRuntime Operation</seealso>
        public virtual DeleteAgentRuntimeResponse EndDeleteAgentRuntime(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAgentRuntimeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAgentRuntimeEndpoint

        /// <summary>
        /// Deletes an AAgentCore Runtime endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRuntimeEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntimeEndpoint">REST API Reference for DeleteAgentRuntimeEndpoint Operation</seealso>
        public virtual DeleteAgentRuntimeEndpointResponse DeleteAgentRuntimeEndpoint(DeleteAgentRuntimeEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentRuntimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentRuntimeEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentRuntimeEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRuntimeEndpoint operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentRuntimeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntimeEndpoint">REST API Reference for DeleteAgentRuntimeEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteAgentRuntimeEndpoint(DeleteAgentRuntimeEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentRuntimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentRuntimeEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentRuntimeEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteAgentRuntimeEndpointResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteAgentRuntimeEndpoint">REST API Reference for DeleteAgentRuntimeEndpoint Operation</seealso>
        public virtual DeleteAgentRuntimeEndpointResponse EndDeleteAgentRuntimeEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAgentRuntimeEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApiKeyCredentialProvider

        /// <summary>
        /// Deletes an API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKeyCredentialProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteApiKeyCredentialProvider">REST API Reference for DeleteApiKeyCredentialProvider Operation</seealso>
        public virtual DeleteApiKeyCredentialProviderResponse DeleteApiKeyCredentialProvider(DeleteApiKeyCredentialProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiKeyCredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiKeyCredentialProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteApiKeyCredentialProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKeyCredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApiKeyCredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteApiKeyCredentialProvider">REST API Reference for DeleteApiKeyCredentialProvider Operation</seealso>
        public virtual IAsyncResult BeginDeleteApiKeyCredentialProvider(DeleteApiKeyCredentialProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiKeyCredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiKeyCredentialProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiKeyCredentialProvider.</param>
        /// 
        /// <returns>Returns a  DeleteApiKeyCredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteApiKeyCredentialProvider">REST API Reference for DeleteApiKeyCredentialProvider Operation</seealso>
        public virtual DeleteApiKeyCredentialProviderResponse EndDeleteApiKeyCredentialProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApiKeyCredentialProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBrowser

        /// <summary>
        /// Deletes a custom browser.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowser service method.</param>
        /// 
        /// <returns>The response from the DeleteBrowser service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteBrowser">REST API Reference for DeleteBrowser Operation</seealso>
        public virtual DeleteBrowserResponse DeleteBrowser(DeleteBrowserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBrowserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrowserResponseUnmarshaller.Instance;

            return Invoke<DeleteBrowserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBrowser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowser operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBrowser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteBrowser">REST API Reference for DeleteBrowser Operation</seealso>
        public virtual IAsyncResult BeginDeleteBrowser(DeleteBrowserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBrowserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrowserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBrowser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBrowser.</param>
        /// 
        /// <returns>Returns a  DeleteBrowserResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteBrowser">REST API Reference for DeleteBrowser Operation</seealso>
        public virtual DeleteBrowserResponse EndDeleteBrowser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBrowserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCodeInterpreter

        /// <summary>
        /// Deletes a custom code interpreter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeInterpreter service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeInterpreter service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteCodeInterpreter">REST API Reference for DeleteCodeInterpreter Operation</seealso>
        public virtual DeleteCodeInterpreterResponse DeleteCodeInterpreter(DeleteCodeInterpreterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCodeInterpreterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeInterpreterResponseUnmarshaller.Instance;

            return Invoke<DeleteCodeInterpreterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeInterpreter operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCodeInterpreter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteCodeInterpreter">REST API Reference for DeleteCodeInterpreter Operation</seealso>
        public virtual IAsyncResult BeginDeleteCodeInterpreter(DeleteCodeInterpreterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCodeInterpreterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeInterpreterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCodeInterpreter.</param>
        /// 
        /// <returns>Returns a  DeleteCodeInterpreterResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteCodeInterpreter">REST API Reference for DeleteCodeInterpreter Operation</seealso>
        public virtual DeleteCodeInterpreterResponse EndDeleteCodeInterpreter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCodeInterpreterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGateway

        /// <summary>
        /// Deletes a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual IAsyncResult BeginDeleteGateway(DeleteGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGateway.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual DeleteGatewayResponse EndDeleteGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGatewayTarget

        /// <summary>
        /// Deletes a gateway target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGatewayTarget">REST API Reference for DeleteGatewayTarget Operation</seealso>
        public virtual DeleteGatewayTargetResponse DeleteGatewayTarget(DeleteGatewayTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayTarget operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGatewayTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGatewayTarget">REST API Reference for DeleteGatewayTarget Operation</seealso>
        public virtual IAsyncResult BeginDeleteGatewayTarget(DeleteGatewayTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGatewayTarget.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayTargetResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteGatewayTarget">REST API Reference for DeleteGatewayTarget Operation</seealso>
        public virtual DeleteGatewayTargetResponse EndDeleteGatewayTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGatewayTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMemory

        /// <summary>
        /// Deletes an Amazon Bedrock AgentCore Memory resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemory service method.</param>
        /// 
        /// <returns>The response from the DeleteMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteMemory">REST API Reference for DeleteMemory Operation</seealso>
        public virtual DeleteMemoryResponse DeleteMemory(DeleteMemoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemoryResponseUnmarshaller.Instance;

            return Invoke<DeleteMemoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMemory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemory operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMemory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteMemory">REST API Reference for DeleteMemory Operation</seealso>
        public virtual IAsyncResult BeginDeleteMemory(DeleteMemoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMemory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMemory.</param>
        /// 
        /// <returns>Returns a  DeleteMemoryResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteMemory">REST API Reference for DeleteMemory Operation</seealso>
        public virtual DeleteMemoryResponse EndDeleteMemory(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMemoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOauth2CredentialProvider

        /// <summary>
        /// Deletes an OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOauth2CredentialProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteOauth2CredentialProvider">REST API Reference for DeleteOauth2CredentialProvider Operation</seealso>
        public virtual DeleteOauth2CredentialProviderResponse DeleteOauth2CredentialProvider(DeleteOauth2CredentialProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOauth2CredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOauth2CredentialProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteOauth2CredentialProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOauth2CredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOauth2CredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteOauth2CredentialProvider">REST API Reference for DeleteOauth2CredentialProvider Operation</seealso>
        public virtual IAsyncResult BeginDeleteOauth2CredentialProvider(DeleteOauth2CredentialProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOauth2CredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOauth2CredentialProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOauth2CredentialProvider.</param>
        /// 
        /// <returns>Returns a  DeleteOauth2CredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteOauth2CredentialProvider">REST API Reference for DeleteOauth2CredentialProvider Operation</seealso>
        public virtual DeleteOauth2CredentialProviderResponse EndDeleteOauth2CredentialProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOauth2CredentialProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkloadIdentity

        /// <summary>
        /// Deletes a workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteWorkloadIdentity">REST API Reference for DeleteWorkloadIdentity Operation</seealso>
        public virtual DeleteWorkloadIdentityResponse DeleteWorkloadIdentity(DeleteWorkloadIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkloadIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkloadIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkloadIdentityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadIdentity operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkloadIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteWorkloadIdentity">REST API Reference for DeleteWorkloadIdentity Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkloadIdentity(DeleteWorkloadIdentityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkloadIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkloadIdentityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkloadIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteWorkloadIdentityResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/DeleteWorkloadIdentity">REST API Reference for DeleteWorkloadIdentity Operation</seealso>
        public virtual DeleteWorkloadIdentityResponse EndDeleteWorkloadIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkloadIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAgentRuntime

        /// <summary>
        /// Gets an Amazon Bedrock AgentCore Runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRuntime service method.</param>
        /// 
        /// <returns>The response from the GetAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntime">REST API Reference for GetAgentRuntime Operation</seealso>
        public virtual GetAgentRuntimeResponse GetAgentRuntime(GetAgentRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentRuntimeResponseUnmarshaller.Instance;

            return Invoke<GetAgentRuntimeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRuntime operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentRuntime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntime">REST API Reference for GetAgentRuntime Operation</seealso>
        public virtual IAsyncResult BeginGetAgentRuntime(GetAgentRuntimeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentRuntimeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentRuntime.</param>
        /// 
        /// <returns>Returns a  GetAgentRuntimeResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntime">REST API Reference for GetAgentRuntime Operation</seealso>
        public virtual GetAgentRuntimeResponse EndGetAgentRuntime(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAgentRuntimeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAgentRuntimeEndpoint

        /// <summary>
        /// Gets information about an Amazon Secure AgentEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRuntimeEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntimeEndpoint">REST API Reference for GetAgentRuntimeEndpoint Operation</seealso>
        public virtual GetAgentRuntimeEndpointResponse GetAgentRuntimeEndpoint(GetAgentRuntimeEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentRuntimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentRuntimeEndpointResponseUnmarshaller.Instance;

            return Invoke<GetAgentRuntimeEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRuntimeEndpoint operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentRuntimeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntimeEndpoint">REST API Reference for GetAgentRuntimeEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetAgentRuntimeEndpoint(GetAgentRuntimeEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgentRuntimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentRuntimeEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentRuntimeEndpoint.</param>
        /// 
        /// <returns>Returns a  GetAgentRuntimeEndpointResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetAgentRuntimeEndpoint">REST API Reference for GetAgentRuntimeEndpoint Operation</seealso>
        public virtual GetAgentRuntimeEndpointResponse EndGetAgentRuntimeEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAgentRuntimeEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiKeyCredentialProvider

        /// <summary>
        /// Retrieves information about an API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeyCredentialProvider service method.</param>
        /// 
        /// <returns>The response from the GetApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetApiKeyCredentialProvider">REST API Reference for GetApiKeyCredentialProvider Operation</seealso>
        public virtual GetApiKeyCredentialProviderResponse GetApiKeyCredentialProvider(GetApiKeyCredentialProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiKeyCredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiKeyCredentialProviderResponseUnmarshaller.Instance;

            return Invoke<GetApiKeyCredentialProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeyCredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiKeyCredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetApiKeyCredentialProvider">REST API Reference for GetApiKeyCredentialProvider Operation</seealso>
        public virtual IAsyncResult BeginGetApiKeyCredentialProvider(GetApiKeyCredentialProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiKeyCredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiKeyCredentialProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiKeyCredentialProvider.</param>
        /// 
        /// <returns>Returns a  GetApiKeyCredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetApiKeyCredentialProvider">REST API Reference for GetApiKeyCredentialProvider Operation</seealso>
        public virtual GetApiKeyCredentialProviderResponse EndGetApiKeyCredentialProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiKeyCredentialProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBrowser

        /// <summary>
        /// Gets information about a custom browser.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowser service method.</param>
        /// 
        /// <returns>The response from the GetBrowser service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetBrowser">REST API Reference for GetBrowser Operation</seealso>
        public virtual GetBrowserResponse GetBrowser(GetBrowserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBrowserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrowserResponseUnmarshaller.Instance;

            return Invoke<GetBrowserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBrowser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBrowser operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBrowser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetBrowser">REST API Reference for GetBrowser Operation</seealso>
        public virtual IAsyncResult BeginGetBrowser(GetBrowserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBrowserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrowserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBrowser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBrowser.</param>
        /// 
        /// <returns>Returns a  GetBrowserResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetBrowser">REST API Reference for GetBrowser Operation</seealso>
        public virtual GetBrowserResponse EndGetBrowser(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBrowserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCodeInterpreter

        /// <summary>
        /// Gets information about a custom code interpreter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeInterpreter service method.</param>
        /// 
        /// <returns>The response from the GetCodeInterpreter service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetCodeInterpreter">REST API Reference for GetCodeInterpreter Operation</seealso>
        public virtual GetCodeInterpreterResponse GetCodeInterpreter(GetCodeInterpreterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeInterpreterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeInterpreterResponseUnmarshaller.Instance;

            return Invoke<GetCodeInterpreterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCodeInterpreter operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCodeInterpreter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetCodeInterpreter">REST API Reference for GetCodeInterpreter Operation</seealso>
        public virtual IAsyncResult BeginGetCodeInterpreter(GetCodeInterpreterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeInterpreterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeInterpreterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCodeInterpreter.</param>
        /// 
        /// <returns>Returns a  GetCodeInterpreterResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetCodeInterpreter">REST API Reference for GetCodeInterpreter Operation</seealso>
        public virtual GetCodeInterpreterResponse EndGetCodeInterpreter(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCodeInterpreterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGateway

        /// <summary>
        /// Retrieves information about a specific Gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGateway service method.</param>
        /// 
        /// <returns>The response from the GetGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGateway">REST API Reference for GetGateway Operation</seealso>
        public virtual GetGatewayResponse GetGateway(GetGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayResponseUnmarshaller.Instance;

            return Invoke<GetGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGateway operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGateway">REST API Reference for GetGateway Operation</seealso>
        public virtual IAsyncResult BeginGetGateway(GetGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGateway.</param>
        /// 
        /// <returns>Returns a  GetGatewayResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGateway">REST API Reference for GetGateway Operation</seealso>
        public virtual GetGatewayResponse EndGetGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGatewayTarget

        /// <summary>
        /// Retrieves information about a specific gateway target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayTarget service method.</param>
        /// 
        /// <returns>The response from the GetGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGatewayTarget">REST API Reference for GetGatewayTarget Operation</seealso>
        public virtual GetGatewayTargetResponse GetGatewayTarget(GetGatewayTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGatewayTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayTargetResponseUnmarshaller.Instance;

            return Invoke<GetGatewayTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayTarget operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGatewayTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGatewayTarget">REST API Reference for GetGatewayTarget Operation</seealso>
        public virtual IAsyncResult BeginGetGatewayTarget(GetGatewayTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGatewayTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGatewayTarget.</param>
        /// 
        /// <returns>Returns a  GetGatewayTargetResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetGatewayTarget">REST API Reference for GetGatewayTarget Operation</seealso>
        public virtual GetGatewayTargetResponse EndGetGatewayTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGatewayTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMemory

        /// <summary>
        /// Retrieve an existing Amazon Bedrock AgentCore Memory resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemory service method.</param>
        /// 
        /// <returns>The response from the GetMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetMemory">REST API Reference for GetMemory Operation</seealso>
        public virtual GetMemoryResponse GetMemory(GetMemoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemoryResponseUnmarshaller.Instance;

            return Invoke<GetMemoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMemory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMemory operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMemory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetMemory">REST API Reference for GetMemory Operation</seealso>
        public virtual IAsyncResult BeginGetMemory(GetMemoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMemory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMemory.</param>
        /// 
        /// <returns>Returns a  GetMemoryResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetMemory">REST API Reference for GetMemory Operation</seealso>
        public virtual GetMemoryResponse EndGetMemory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMemoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOauth2CredentialProvider

        /// <summary>
        /// Retrieves information about an OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOauth2CredentialProvider service method.</param>
        /// 
        /// <returns>The response from the GetOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetOauth2CredentialProvider">REST API Reference for GetOauth2CredentialProvider Operation</seealso>
        public virtual GetOauth2CredentialProviderResponse GetOauth2CredentialProvider(GetOauth2CredentialProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOauth2CredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOauth2CredentialProviderResponseUnmarshaller.Instance;

            return Invoke<GetOauth2CredentialProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOauth2CredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOauth2CredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetOauth2CredentialProvider">REST API Reference for GetOauth2CredentialProvider Operation</seealso>
        public virtual IAsyncResult BeginGetOauth2CredentialProvider(GetOauth2CredentialProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOauth2CredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOauth2CredentialProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOauth2CredentialProvider.</param>
        /// 
        /// <returns>Returns a  GetOauth2CredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetOauth2CredentialProvider">REST API Reference for GetOauth2CredentialProvider Operation</seealso>
        public virtual GetOauth2CredentialProviderResponse EndGetOauth2CredentialProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOauth2CredentialProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTokenVault

        /// <summary>
        /// Retrieves information about a token vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTokenVault service method.</param>
        /// 
        /// <returns>The response from the GetTokenVault service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetTokenVault">REST API Reference for GetTokenVault Operation</seealso>
        public virtual GetTokenVaultResponse GetTokenVault(GetTokenVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTokenVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTokenVaultResponseUnmarshaller.Instance;

            return Invoke<GetTokenVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTokenVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTokenVault operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTokenVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetTokenVault">REST API Reference for GetTokenVault Operation</seealso>
        public virtual IAsyncResult BeginGetTokenVault(GetTokenVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTokenVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTokenVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTokenVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTokenVault.</param>
        /// 
        /// <returns>Returns a  GetTokenVaultResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetTokenVault">REST API Reference for GetTokenVault Operation</seealso>
        public virtual GetTokenVaultResponse EndGetTokenVault(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTokenVaultResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkloadIdentity

        /// <summary>
        /// Retrieves information about a workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadIdentity service method.</param>
        /// 
        /// <returns>The response from the GetWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetWorkloadIdentity">REST API Reference for GetWorkloadIdentity Operation</seealso>
        public virtual GetWorkloadIdentityResponse GetWorkloadIdentity(GetWorkloadIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadIdentityResponseUnmarshaller.Instance;

            return Invoke<GetWorkloadIdentityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadIdentity operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkloadIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetWorkloadIdentity">REST API Reference for GetWorkloadIdentity Operation</seealso>
        public virtual IAsyncResult BeginGetWorkloadIdentity(GetWorkloadIdentityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadIdentityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkloadIdentity.</param>
        /// 
        /// <returns>Returns a  GetWorkloadIdentityResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/GetWorkloadIdentity">REST API Reference for GetWorkloadIdentity Operation</seealso>
        public virtual GetWorkloadIdentityResponse EndGetWorkloadIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkloadIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgentRuntimeEndpoints

        /// <summary>
        /// Lists all endpoints for a specific Amazon Secure Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimeEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListAgentRuntimeEndpoints service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeEndpoints">REST API Reference for ListAgentRuntimeEndpoints Operation</seealso>
        public virtual ListAgentRuntimeEndpointsResponse ListAgentRuntimeEndpoints(ListAgentRuntimeEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentRuntimeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentRuntimeEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListAgentRuntimeEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgentRuntimeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimeEndpoints operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentRuntimeEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeEndpoints">REST API Reference for ListAgentRuntimeEndpoints Operation</seealso>
        public virtual IAsyncResult BeginListAgentRuntimeEndpoints(ListAgentRuntimeEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentRuntimeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentRuntimeEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentRuntimeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentRuntimeEndpoints.</param>
        /// 
        /// <returns>Returns a  ListAgentRuntimeEndpointsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeEndpoints">REST API Reference for ListAgentRuntimeEndpoints Operation</seealso>
        public virtual ListAgentRuntimeEndpointsResponse EndListAgentRuntimeEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgentRuntimeEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgentRuntimes

        /// <summary>
        /// Lists all Amazon Secure Agents in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimes service method.</param>
        /// 
        /// <returns>The response from the ListAgentRuntimes service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimes">REST API Reference for ListAgentRuntimes Operation</seealso>
        public virtual ListAgentRuntimesResponse ListAgentRuntimes(ListAgentRuntimesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentRuntimesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentRuntimesResponseUnmarshaller.Instance;

            return Invoke<ListAgentRuntimesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgentRuntimes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimes operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentRuntimes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimes">REST API Reference for ListAgentRuntimes Operation</seealso>
        public virtual IAsyncResult BeginListAgentRuntimes(ListAgentRuntimesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentRuntimesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentRuntimesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentRuntimes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentRuntimes.</param>
        /// 
        /// <returns>Returns a  ListAgentRuntimesResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimes">REST API Reference for ListAgentRuntimes Operation</seealso>
        public virtual ListAgentRuntimesResponse EndListAgentRuntimes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgentRuntimesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgentRuntimeVersions

        /// <summary>
        /// Lists all versions of a specific Amazon Secure Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimeVersions service method.</param>
        /// 
        /// <returns>The response from the ListAgentRuntimeVersions service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeVersions">REST API Reference for ListAgentRuntimeVersions Operation</seealso>
        public virtual ListAgentRuntimeVersionsResponse ListAgentRuntimeVersions(ListAgentRuntimeVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentRuntimeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentRuntimeVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAgentRuntimeVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgentRuntimeVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRuntimeVersions operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentRuntimeVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeVersions">REST API Reference for ListAgentRuntimeVersions Operation</seealso>
        public virtual IAsyncResult BeginListAgentRuntimeVersions(ListAgentRuntimeVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentRuntimeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentRuntimeVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentRuntimeVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentRuntimeVersions.</param>
        /// 
        /// <returns>Returns a  ListAgentRuntimeVersionsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListAgentRuntimeVersions">REST API Reference for ListAgentRuntimeVersions Operation</seealso>
        public virtual ListAgentRuntimeVersionsResponse EndListAgentRuntimeVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgentRuntimeVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApiKeyCredentialProviders

        /// <summary>
        /// Lists all API key credential providers in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiKeyCredentialProviders service method.</param>
        /// 
        /// <returns>The response from the ListApiKeyCredentialProviders service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListApiKeyCredentialProviders">REST API Reference for ListApiKeyCredentialProviders Operation</seealso>
        public virtual ListApiKeyCredentialProvidersResponse ListApiKeyCredentialProviders(ListApiKeyCredentialProvidersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApiKeyCredentialProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiKeyCredentialProvidersResponseUnmarshaller.Instance;

            return Invoke<ListApiKeyCredentialProvidersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApiKeyCredentialProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApiKeyCredentialProviders operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApiKeyCredentialProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListApiKeyCredentialProviders">REST API Reference for ListApiKeyCredentialProviders Operation</seealso>
        public virtual IAsyncResult BeginListApiKeyCredentialProviders(ListApiKeyCredentialProvidersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApiKeyCredentialProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiKeyCredentialProvidersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApiKeyCredentialProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApiKeyCredentialProviders.</param>
        /// 
        /// <returns>Returns a  ListApiKeyCredentialProvidersResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListApiKeyCredentialProviders">REST API Reference for ListApiKeyCredentialProviders Operation</seealso>
        public virtual ListApiKeyCredentialProvidersResponse EndListApiKeyCredentialProviders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApiKeyCredentialProvidersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBrowsers

        /// <summary>
        /// Lists all custom browsers in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowsers service method.</param>
        /// 
        /// <returns>The response from the ListBrowsers service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListBrowsers">REST API Reference for ListBrowsers Operation</seealso>
        public virtual ListBrowsersResponse ListBrowsers(ListBrowsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBrowsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrowsersResponseUnmarshaller.Instance;

            return Invoke<ListBrowsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBrowsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBrowsers operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBrowsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListBrowsers">REST API Reference for ListBrowsers Operation</seealso>
        public virtual IAsyncResult BeginListBrowsers(ListBrowsersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBrowsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrowsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBrowsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBrowsers.</param>
        /// 
        /// <returns>Returns a  ListBrowsersResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListBrowsers">REST API Reference for ListBrowsers Operation</seealso>
        public virtual ListBrowsersResponse EndListBrowsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBrowsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCodeInterpreters

        /// <summary>
        /// Lists all custom code interpreters in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeInterpreters service method.</param>
        /// 
        /// <returns>The response from the ListCodeInterpreters service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListCodeInterpreters">REST API Reference for ListCodeInterpreters Operation</seealso>
        public virtual ListCodeInterpretersResponse ListCodeInterpreters(ListCodeInterpretersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeInterpretersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeInterpretersResponseUnmarshaller.Instance;

            return Invoke<ListCodeInterpretersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeInterpreters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeInterpreters operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeInterpreters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListCodeInterpreters">REST API Reference for ListCodeInterpreters Operation</seealso>
        public virtual IAsyncResult BeginListCodeInterpreters(ListCodeInterpretersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeInterpretersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeInterpretersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeInterpreters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeInterpreters.</param>
        /// 
        /// <returns>Returns a  ListCodeInterpretersResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListCodeInterpreters">REST API Reference for ListCodeInterpreters Operation</seealso>
        public virtual ListCodeInterpretersResponse EndListCodeInterpreters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCodeInterpretersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGateways

        /// <summary>
        /// Lists all gateways in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual IAsyncResult BeginListGateways(ListGatewaysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGateways.</param>
        /// 
        /// <returns>Returns a  ListGatewaysResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual ListGatewaysResponse EndListGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGatewayTargets

        /// <summary>
        /// Lists all targets for a specific gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayTargets service method.</param>
        /// 
        /// <returns>The response from the ListGatewayTargets service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGatewayTargets">REST API Reference for ListGatewayTargets Operation</seealso>
        public virtual ListGatewayTargetsResponse ListGatewayTargets(ListGatewayTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewayTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewayTargetsResponseUnmarshaller.Instance;

            return Invoke<ListGatewayTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGatewayTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayTargets operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGatewayTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGatewayTargets">REST API Reference for ListGatewayTargets Operation</seealso>
        public virtual IAsyncResult BeginListGatewayTargets(ListGatewayTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewayTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewayTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGatewayTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGatewayTargets.</param>
        /// 
        /// <returns>Returns a  ListGatewayTargetsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListGatewayTargets">REST API Reference for ListGatewayTargets Operation</seealso>
        public virtual ListGatewayTargetsResponse EndListGatewayTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGatewayTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMemories

        /// <summary>
        /// Lists the available Amazon Bedrock AgentCore Memory resources in the current Amazon
        /// Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemories service method.</param>
        /// 
        /// <returns>The response from the ListMemories service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListMemories">REST API Reference for ListMemories Operation</seealso>
        public virtual ListMemoriesResponse ListMemories(ListMemoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMemoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemoriesResponseUnmarshaller.Instance;

            return Invoke<ListMemoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMemories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemories operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListMemories">REST API Reference for ListMemories Operation</seealso>
        public virtual IAsyncResult BeginListMemories(ListMemoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMemoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemories.</param>
        /// 
        /// <returns>Returns a  ListMemoriesResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListMemories">REST API Reference for ListMemories Operation</seealso>
        public virtual ListMemoriesResponse EndListMemories(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMemoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOauth2CredentialProviders

        /// <summary>
        /// Lists all OAuth2 credential providers in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOauth2CredentialProviders service method.</param>
        /// 
        /// <returns>The response from the ListOauth2CredentialProviders service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListOauth2CredentialProviders">REST API Reference for ListOauth2CredentialProviders Operation</seealso>
        public virtual ListOauth2CredentialProvidersResponse ListOauth2CredentialProviders(ListOauth2CredentialProvidersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOauth2CredentialProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOauth2CredentialProvidersResponseUnmarshaller.Instance;

            return Invoke<ListOauth2CredentialProvidersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOauth2CredentialProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOauth2CredentialProviders operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOauth2CredentialProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListOauth2CredentialProviders">REST API Reference for ListOauth2CredentialProviders Operation</seealso>
        public virtual IAsyncResult BeginListOauth2CredentialProviders(ListOauth2CredentialProvidersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOauth2CredentialProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOauth2CredentialProvidersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOauth2CredentialProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOauth2CredentialProviders.</param>
        /// 
        /// <returns>Returns a  ListOauth2CredentialProvidersResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListOauth2CredentialProviders">REST API Reference for ListOauth2CredentialProviders Operation</seealso>
        public virtual ListOauth2CredentialProvidersResponse EndListOauth2CredentialProviders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOauth2CredentialProvidersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags associated with the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime, Browser, Code Interpreter
        /// tool, and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkloadIdentities

        /// <summary>
        /// Lists all workload identities in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadIdentities service method.</param>
        /// 
        /// <returns>The response from the ListWorkloadIdentities service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListWorkloadIdentities">REST API Reference for ListWorkloadIdentities Operation</seealso>
        public virtual ListWorkloadIdentitiesResponse ListWorkloadIdentities(ListWorkloadIdentitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadIdentitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkloadIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadIdentities operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloadIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListWorkloadIdentities">REST API Reference for ListWorkloadIdentities Operation</seealso>
        public virtual IAsyncResult BeginListWorkloadIdentities(ListWorkloadIdentitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadIdentitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloadIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloadIdentities.</param>
        /// 
        /// <returns>Returns a  ListWorkloadIdentitiesResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/ListWorkloadIdentities">REST API Reference for ListWorkloadIdentities Operation</seealso>
        public virtual ListWorkloadIdentitiesResponse EndListWorkloadIdentities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkloadIdentitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  SetTokenVaultCMK

        /// <summary>
        /// Sets the customer master key (CMK) for a token vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTokenVaultCMK service method.</param>
        /// 
        /// <returns>The response from the SetTokenVaultCMK service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConcurrentModificationException">
        /// Exception thrown when a resource is modified concurrently by multiple requests.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SetTokenVaultCMK">REST API Reference for SetTokenVaultCMK Operation</seealso>
        public virtual SetTokenVaultCMKResponse SetTokenVaultCMK(SetTokenVaultCMKRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTokenVaultCMKRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTokenVaultCMKResponseUnmarshaller.Instance;

            return Invoke<SetTokenVaultCMKResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetTokenVaultCMK operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTokenVaultCMK operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTokenVaultCMK
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SetTokenVaultCMK">REST API Reference for SetTokenVaultCMK Operation</seealso>
        public virtual IAsyncResult BeginSetTokenVaultCMK(SetTokenVaultCMKRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTokenVaultCMKRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTokenVaultCMKResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetTokenVaultCMK operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTokenVaultCMK.</param>
        /// 
        /// <returns>Returns a  SetTokenVaultCMKResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SetTokenVaultCMK">REST API Reference for SetTokenVaultCMK Operation</seealso>
        public virtual SetTokenVaultCMKResponse EndSetTokenVaultCMK(IAsyncResult asyncResult)
        {
            return EndInvoke<SetTokenVaultCMKResponse>(asyncResult);
        }

        #endregion
        
        #region  SynchronizeGatewayTargets

        /// <summary>
        /// The gateway targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SynchronizeGatewayTargets service method.</param>
        /// 
        /// <returns>The response from the SynchronizeGatewayTargets service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SynchronizeGatewayTargets">REST API Reference for SynchronizeGatewayTargets Operation</seealso>
        public virtual SynchronizeGatewayTargetsResponse SynchronizeGatewayTargets(SynchronizeGatewayTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SynchronizeGatewayTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SynchronizeGatewayTargetsResponseUnmarshaller.Instance;

            return Invoke<SynchronizeGatewayTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SynchronizeGatewayTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SynchronizeGatewayTargets operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSynchronizeGatewayTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SynchronizeGatewayTargets">REST API Reference for SynchronizeGatewayTargets Operation</seealso>
        public virtual IAsyncResult BeginSynchronizeGatewayTargets(SynchronizeGatewayTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SynchronizeGatewayTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SynchronizeGatewayTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SynchronizeGatewayTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSynchronizeGatewayTargets.</param>
        /// 
        /// <returns>Returns a  SynchronizeGatewayTargetsResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/SynchronizeGatewayTargets">REST API Reference for SynchronizeGatewayTargets Operation</seealso>
        public virtual SynchronizeGatewayTargetsResponse EndSynchronizeGatewayTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<SynchronizeGatewayTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to a resource with the specified resourceArn. If existing
        /// tags on a resource are not specified in the request parameters, they are not changed.
        /// When a resource is deleted, the tags associated with that resource are also deleted.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime, Browser, Code Interpreter
        /// tool, and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// This feature is currently available only for AgentCore Runtime, Browser, Code Interpreter
        /// tool, and Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAgentRuntime

        /// <summary>
        /// Updates an existing Amazon Secure Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRuntime service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentRuntime service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntime">REST API Reference for UpdateAgentRuntime Operation</seealso>
        public virtual UpdateAgentRuntimeResponse UpdateAgentRuntime(UpdateAgentRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentRuntimeResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentRuntimeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRuntime operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentRuntime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntime">REST API Reference for UpdateAgentRuntime Operation</seealso>
        public virtual IAsyncResult BeginUpdateAgentRuntime(UpdateAgentRuntimeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentRuntimeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentRuntime.</param>
        /// 
        /// <returns>Returns a  UpdateAgentRuntimeResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntime">REST API Reference for UpdateAgentRuntime Operation</seealso>
        public virtual UpdateAgentRuntimeResponse EndUpdateAgentRuntime(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAgentRuntimeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAgentRuntimeEndpoint

        /// <summary>
        /// Updates an existing Amazon Bedrock AgentCore Runtime endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRuntimeEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentRuntimeEndpoint service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntimeEndpoint">REST API Reference for UpdateAgentRuntimeEndpoint Operation</seealso>
        public virtual UpdateAgentRuntimeEndpointResponse UpdateAgentRuntimeEndpoint(UpdateAgentRuntimeEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentRuntimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentRuntimeEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentRuntimeEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRuntimeEndpoint operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentRuntimeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntimeEndpoint">REST API Reference for UpdateAgentRuntimeEndpoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateAgentRuntimeEndpoint(UpdateAgentRuntimeEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentRuntimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentRuntimeEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentRuntimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentRuntimeEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateAgentRuntimeEndpointResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateAgentRuntimeEndpoint">REST API Reference for UpdateAgentRuntimeEndpoint Operation</seealso>
        public virtual UpdateAgentRuntimeEndpointResponse EndUpdateAgentRuntimeEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAgentRuntimeEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApiKeyCredentialProvider

        /// <summary>
        /// Updates an existing API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKeyCredentialProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateApiKeyCredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateApiKeyCredentialProvider">REST API Reference for UpdateApiKeyCredentialProvider Operation</seealso>
        public virtual UpdateApiKeyCredentialProviderResponse UpdateApiKeyCredentialProvider(UpdateApiKeyCredentialProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiKeyCredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiKeyCredentialProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateApiKeyCredentialProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKeyCredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApiKeyCredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateApiKeyCredentialProvider">REST API Reference for UpdateApiKeyCredentialProvider Operation</seealso>
        public virtual IAsyncResult BeginUpdateApiKeyCredentialProvider(UpdateApiKeyCredentialProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiKeyCredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiKeyCredentialProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiKeyCredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiKeyCredentialProvider.</param>
        /// 
        /// <returns>Returns a  UpdateApiKeyCredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateApiKeyCredentialProvider">REST API Reference for UpdateApiKeyCredentialProvider Operation</seealso>
        public virtual UpdateApiKeyCredentialProviderResponse EndUpdateApiKeyCredentialProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApiKeyCredentialProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGateway

        /// <summary>
        /// Updates an existing gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateGateway service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        public virtual UpdateGatewayResponse UpdateGateway(UpdateGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGateway operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        public virtual IAsyncResult BeginUpdateGateway(UpdateGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGateway.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        public virtual UpdateGatewayResponse EndUpdateGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGatewayTarget

        /// <summary>
        /// Updates an existing gateway target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayTarget service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayTarget service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGatewayTarget">REST API Reference for UpdateGatewayTarget Operation</seealso>
        public virtual UpdateGatewayTargetResponse UpdateGatewayTarget(UpdateGatewayTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayTarget operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewayTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGatewayTarget">REST API Reference for UpdateGatewayTarget Operation</seealso>
        public virtual IAsyncResult BeginUpdateGatewayTarget(UpdateGatewayTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayTarget.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayTargetResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateGatewayTarget">REST API Reference for UpdateGatewayTarget Operation</seealso>
        public virtual UpdateGatewayTargetResponse EndUpdateGatewayTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGatewayTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMemory

        /// <summary>
        /// Update an Amazon Bedrock AgentCore Memory resource memory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemory service method.</param>
        /// 
        /// <returns>The response from the UpdateMemory service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottledException">
        /// API rate limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateMemory">REST API Reference for UpdateMemory Operation</seealso>
        public virtual UpdateMemoryResponse UpdateMemory(UpdateMemoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMemoryResponseUnmarshaller.Instance;

            return Invoke<UpdateMemoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMemory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemory operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMemory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateMemory">REST API Reference for UpdateMemory Operation</seealso>
        public virtual IAsyncResult BeginUpdateMemory(UpdateMemoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMemoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMemoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMemory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMemory.</param>
        /// 
        /// <returns>Returns a  UpdateMemoryResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateMemory">REST API Reference for UpdateMemory Operation</seealso>
        public virtual UpdateMemoryResponse EndUpdateMemory(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMemoryResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateOauth2CredentialProvider

        /// <summary>
        /// Updates an existing OAuth2 credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOauth2CredentialProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateOauth2CredentialProvider service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.DecryptionFailureException">
        /// Exception thrown when decryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.EncryptionFailureException">
        /// Exception thrown when encryption of a secret fails.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateOauth2CredentialProvider">REST API Reference for UpdateOauth2CredentialProvider Operation</seealso>
        public virtual UpdateOauth2CredentialProviderResponse UpdateOauth2CredentialProvider(UpdateOauth2CredentialProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOauth2CredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOauth2CredentialProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateOauth2CredentialProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOauth2CredentialProvider operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOauth2CredentialProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateOauth2CredentialProvider">REST API Reference for UpdateOauth2CredentialProvider Operation</seealso>
        public virtual IAsyncResult BeginUpdateOauth2CredentialProvider(UpdateOauth2CredentialProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOauth2CredentialProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOauth2CredentialProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOauth2CredentialProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOauth2CredentialProvider.</param>
        /// 
        /// <returns>Returns a  UpdateOauth2CredentialProviderResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateOauth2CredentialProvider">REST API Reference for UpdateOauth2CredentialProvider Operation</seealso>
        public virtual UpdateOauth2CredentialProviderResponse EndUpdateOauth2CredentialProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOauth2CredentialProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkloadIdentity

        /// <summary>
        /// Updates an existing workload identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadIdentity service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkloadIdentity service method, as returned by BedrockAgentCoreControl.</returns>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCoreControl.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateWorkloadIdentity">REST API Reference for UpdateWorkloadIdentity Operation</seealso>
        public virtual UpdateWorkloadIdentityResponse UpdateWorkloadIdentity(UpdateWorkloadIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadIdentityResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkloadIdentityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadIdentity operation on AmazonBedrockAgentCoreControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkloadIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateWorkloadIdentity">REST API Reference for UpdateWorkloadIdentity Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkloadIdentity(UpdateWorkloadIdentityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadIdentityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkloadIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkloadIdentity.</param>
        /// 
        /// <returns>Returns a  UpdateWorkloadIdentityResult from BedrockAgentCoreControl.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-control-2023-06-05/UpdateWorkloadIdentity">REST API Reference for UpdateWorkloadIdentity Operation</seealso>
        public virtual UpdateWorkloadIdentityResponse EndUpdateWorkloadIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkloadIdentityResponse>(asyncResult);
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
            var resolver = new AmazonBedrockAgentCoreControlEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}