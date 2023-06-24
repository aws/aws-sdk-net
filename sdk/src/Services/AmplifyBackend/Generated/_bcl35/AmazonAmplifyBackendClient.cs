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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.AmplifyBackend.Model;
using Amazon.AmplifyBackend.Model.Internal.MarshallTransformations;
using Amazon.AmplifyBackend.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AmplifyBackend
{
    /// <summary>
    /// Implementation for accessing AmplifyBackend
    ///
    /// AWS Amplify Admin API
    /// </summary>
    public partial class AmazonAmplifyBackendClient : AmazonServiceClient, IAmazonAmplifyBackend
    {
        private static IServiceMetadata serviceMetadata = new AmazonAmplifyBackendMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IAmplifyBackendPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAmplifyBackendPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AmplifyBackendPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with the credentials loaded from the application's
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
        public AmazonAmplifyBackendClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyBackendConfig()) { }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with the credentials loaded from the application's
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
        public AmazonAmplifyBackendClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyBackendConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAmplifyBackendClient Configuration Object</param>
        public AmazonAmplifyBackendClient(AmazonAmplifyBackendConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAmplifyBackendClient(AWSCredentials credentials)
            : this(credentials, new AmazonAmplifyBackendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyBackendClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAmplifyBackendConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Credentials and an
        /// AmazonAmplifyBackendClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAmplifyBackendClient Configuration Object</param>
        public AmazonAmplifyBackendClient(AWSCredentials credentials, AmazonAmplifyBackendConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyBackendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyBackendConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyBackendClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAmplifyBackendClient Configuration Object</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAmplifyBackendConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyBackendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyBackendConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyBackendClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAmplifyBackendClient Configuration Object</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAmplifyBackendConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAmplifyBackendEndpointResolver());
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


        #region  CloneBackend

        /// <summary>
        /// This operation clones an existing backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloneBackend service method.</param>
        /// 
        /// <returns>The response from the CloneBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CloneBackend">REST API Reference for CloneBackend Operation</seealso>
        public virtual CloneBackendResponse CloneBackend(CloneBackendRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloneBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloneBackendResponseUnmarshaller.Instance;

            return Invoke<CloneBackendResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CloneBackend operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneBackend operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloneBackend
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CloneBackend">REST API Reference for CloneBackend Operation</seealso>
        public virtual IAsyncResult BeginCloneBackend(CloneBackendRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloneBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloneBackendResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CloneBackend operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloneBackend.</param>
        /// 
        /// <returns>Returns a  CloneBackendResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CloneBackend">REST API Reference for CloneBackend Operation</seealso>
        public virtual CloneBackendResponse EndCloneBackend(IAsyncResult asyncResult)
        {
            return EndInvoke<CloneBackendResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBackend

        /// <summary>
        /// This operation creates a backend for an Amplify app. Backends are automatically created
        /// at the time of app creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackend service method.</param>
        /// 
        /// <returns>The response from the CreateBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackend">REST API Reference for CreateBackend Operation</seealso>
        public virtual CreateBackendResponse CreateBackend(CreateBackendRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendResponseUnmarshaller.Instance;

            return Invoke<CreateBackendResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackend operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackend operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackend
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackend">REST API Reference for CreateBackend Operation</seealso>
        public virtual IAsyncResult BeginCreateBackend(CreateBackendRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackend operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackend.</param>
        /// 
        /// <returns>Returns a  CreateBackendResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackend">REST API Reference for CreateBackend Operation</seealso>
        public virtual CreateBackendResponse EndCreateBackend(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackendResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBackendAPI

        /// <summary>
        /// Creates a new backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAPI service method.</param>
        /// 
        /// <returns>The response from the CreateBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAPI">REST API Reference for CreateBackendAPI Operation</seealso>
        public virtual CreateBackendAPIResponse CreateBackendAPI(CreateBackendAPIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendAPIResponseUnmarshaller.Instance;

            return Invoke<CreateBackendAPIResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAPI operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackendAPI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAPI">REST API Reference for CreateBackendAPI Operation</seealso>
        public virtual IAsyncResult BeginCreateBackendAPI(CreateBackendAPIRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendAPIResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackendAPI.</param>
        /// 
        /// <returns>Returns a  CreateBackendAPIResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAPI">REST API Reference for CreateBackendAPI Operation</seealso>
        public virtual CreateBackendAPIResponse EndCreateBackendAPI(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackendAPIResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBackendAuth

        /// <summary>
        /// Creates a new backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAuth service method.</param>
        /// 
        /// <returns>The response from the CreateBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAuth">REST API Reference for CreateBackendAuth Operation</seealso>
        public virtual CreateBackendAuthResponse CreateBackendAuth(CreateBackendAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendAuthResponseUnmarshaller.Instance;

            return Invoke<CreateBackendAuthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAuth operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackendAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAuth">REST API Reference for CreateBackendAuth Operation</seealso>
        public virtual IAsyncResult BeginCreateBackendAuth(CreateBackendAuthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendAuthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackendAuth.</param>
        /// 
        /// <returns>Returns a  CreateBackendAuthResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAuth">REST API Reference for CreateBackendAuth Operation</seealso>
        public virtual CreateBackendAuthResponse EndCreateBackendAuth(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackendAuthResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBackendConfig

        /// <summary>
        /// Creates a config object for a backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendConfig service method.</param>
        /// 
        /// <returns>The response from the CreateBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendConfig">REST API Reference for CreateBackendConfig Operation</seealso>
        public virtual CreateBackendConfigResponse CreateBackendConfig(CreateBackendConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendConfigResponseUnmarshaller.Instance;

            return Invoke<CreateBackendConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendConfig operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackendConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendConfig">REST API Reference for CreateBackendConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateBackendConfig(CreateBackendConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackendConfig.</param>
        /// 
        /// <returns>Returns a  CreateBackendConfigResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendConfig">REST API Reference for CreateBackendConfig Operation</seealso>
        public virtual CreateBackendConfigResponse EndCreateBackendConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackendConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBackendStorage

        /// <summary>
        /// Creates a backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendStorage service method.</param>
        /// 
        /// <returns>The response from the CreateBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendStorage">REST API Reference for CreateBackendStorage Operation</seealso>
        public virtual CreateBackendStorageResponse CreateBackendStorage(CreateBackendStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendStorageResponseUnmarshaller.Instance;

            return Invoke<CreateBackendStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendStorage operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackendStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendStorage">REST API Reference for CreateBackendStorage Operation</seealso>
        public virtual IAsyncResult BeginCreateBackendStorage(CreateBackendStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackendStorage.</param>
        /// 
        /// <returns>Returns a  CreateBackendStorageResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendStorage">REST API Reference for CreateBackendStorage Operation</seealso>
        public virtual CreateBackendStorageResponse EndCreateBackendStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackendStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateToken

        /// <summary>
        /// Generates a one-time challenge code to authenticate a user into your Amplify Admin
        /// UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// 
        /// <returns>The response from the CreateToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateToken">REST API Reference for CreateToken Operation</seealso>
        public virtual CreateTokenResponse CreateToken(CreateTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTokenResponseUnmarshaller.Instance;

            return Invoke<CreateTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateToken operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateToken">REST API Reference for CreateToken Operation</seealso>
        public virtual IAsyncResult BeginCreateToken(CreateTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateToken.</param>
        /// 
        /// <returns>Returns a  CreateTokenResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateToken">REST API Reference for CreateToken Operation</seealso>
        public virtual CreateTokenResponse EndCreateToken(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBackend

        /// <summary>
        /// Removes an existing environment from your Amplify project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackend service method.</param>
        /// 
        /// <returns>The response from the DeleteBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackend">REST API Reference for DeleteBackend Operation</seealso>
        public virtual DeleteBackendResponse DeleteBackend(DeleteBackendRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendResponseUnmarshaller.Instance;

            return Invoke<DeleteBackendResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackend operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackend operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackend
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackend">REST API Reference for DeleteBackend Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackend(DeleteBackendRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackend operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackend.</param>
        /// 
        /// <returns>Returns a  DeleteBackendResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackend">REST API Reference for DeleteBackend Operation</seealso>
        public virtual DeleteBackendResponse EndDeleteBackend(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackendResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBackendAPI

        /// <summary>
        /// Deletes an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAPI service method.</param>
        /// 
        /// <returns>The response from the DeleteBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAPI">REST API Reference for DeleteBackendAPI Operation</seealso>
        public virtual DeleteBackendAPIResponse DeleteBackendAPI(DeleteBackendAPIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendAPIResponseUnmarshaller.Instance;

            return Invoke<DeleteBackendAPIResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAPI operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackendAPI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAPI">REST API Reference for DeleteBackendAPI Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackendAPI(DeleteBackendAPIRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendAPIResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackendAPI.</param>
        /// 
        /// <returns>Returns a  DeleteBackendAPIResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAPI">REST API Reference for DeleteBackendAPI Operation</seealso>
        public virtual DeleteBackendAPIResponse EndDeleteBackendAPI(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackendAPIResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBackendAuth

        /// <summary>
        /// Deletes an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAuth service method.</param>
        /// 
        /// <returns>The response from the DeleteBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAuth">REST API Reference for DeleteBackendAuth Operation</seealso>
        public virtual DeleteBackendAuthResponse DeleteBackendAuth(DeleteBackendAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendAuthResponseUnmarshaller.Instance;

            return Invoke<DeleteBackendAuthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAuth operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackendAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAuth">REST API Reference for DeleteBackendAuth Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackendAuth(DeleteBackendAuthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendAuthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackendAuth.</param>
        /// 
        /// <returns>Returns a  DeleteBackendAuthResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAuth">REST API Reference for DeleteBackendAuth Operation</seealso>
        public virtual DeleteBackendAuthResponse EndDeleteBackendAuth(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackendAuthResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBackendStorage

        /// <summary>
        /// Removes the specified backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendStorage service method.</param>
        /// 
        /// <returns>The response from the DeleteBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendStorage">REST API Reference for DeleteBackendStorage Operation</seealso>
        public virtual DeleteBackendStorageResponse DeleteBackendStorage(DeleteBackendStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendStorageResponseUnmarshaller.Instance;

            return Invoke<DeleteBackendStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendStorage operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackendStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendStorage">REST API Reference for DeleteBackendStorage Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackendStorage(DeleteBackendStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackendStorage.</param>
        /// 
        /// <returns>Returns a  DeleteBackendStorageResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendStorage">REST API Reference for DeleteBackendStorage Operation</seealso>
        public virtual DeleteBackendStorageResponse EndDeleteBackendStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackendStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteToken

        /// <summary>
        /// Deletes the challenge token based on the given appId and sessionId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken service method.</param>
        /// 
        /// <returns>The response from the DeleteToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        public virtual DeleteTokenResponse DeleteToken(DeleteTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTokenResponseUnmarshaller.Instance;

            return Invoke<DeleteTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        public virtual IAsyncResult BeginDeleteToken(DeleteTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteToken.</param>
        /// 
        /// <returns>Returns a  DeleteTokenResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        public virtual DeleteTokenResponse EndDeleteToken(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  GenerateBackendAPIModels

        /// <summary>
        /// Generates a model schema for an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateBackendAPIModels service method.</param>
        /// 
        /// <returns>The response from the GenerateBackendAPIModels service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GenerateBackendAPIModels">REST API Reference for GenerateBackendAPIModels Operation</seealso>
        public virtual GenerateBackendAPIModelsResponse GenerateBackendAPIModels(GenerateBackendAPIModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateBackendAPIModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateBackendAPIModelsResponseUnmarshaller.Instance;

            return Invoke<GenerateBackendAPIModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateBackendAPIModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateBackendAPIModels operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateBackendAPIModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GenerateBackendAPIModels">REST API Reference for GenerateBackendAPIModels Operation</seealso>
        public virtual IAsyncResult BeginGenerateBackendAPIModels(GenerateBackendAPIModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateBackendAPIModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateBackendAPIModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateBackendAPIModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateBackendAPIModels.</param>
        /// 
        /// <returns>Returns a  GenerateBackendAPIModelsResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GenerateBackendAPIModels">REST API Reference for GenerateBackendAPIModels Operation</seealso>
        public virtual GenerateBackendAPIModelsResponse EndGenerateBackendAPIModels(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateBackendAPIModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackend

        /// <summary>
        /// Provides project-level details for your Amplify UI project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackend service method.</param>
        /// 
        /// <returns>The response from the GetBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackend">REST API Reference for GetBackend Operation</seealso>
        public virtual GetBackendResponse GetBackend(GetBackendRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendResponseUnmarshaller.Instance;

            return Invoke<GetBackendResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackend operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackend operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackend
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackend">REST API Reference for GetBackend Operation</seealso>
        public virtual IAsyncResult BeginGetBackend(GetBackendRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackend operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackend.</param>
        /// 
        /// <returns>Returns a  GetBackendResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackend">REST API Reference for GetBackend Operation</seealso>
        public virtual GetBackendResponse EndGetBackend(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackendResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackendAPI

        /// <summary>
        /// Gets the details for a backend API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPI service method.</param>
        /// 
        /// <returns>The response from the GetBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPI">REST API Reference for GetBackendAPI Operation</seealso>
        public virtual GetBackendAPIResponse GetBackendAPI(GetBackendAPIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAPIResponseUnmarshaller.Instance;

            return Invoke<GetBackendAPIResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPI operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackendAPI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPI">REST API Reference for GetBackendAPI Operation</seealso>
        public virtual IAsyncResult BeginGetBackendAPI(GetBackendAPIRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAPIResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackendAPI.</param>
        /// 
        /// <returns>Returns a  GetBackendAPIResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPI">REST API Reference for GetBackendAPI Operation</seealso>
        public virtual GetBackendAPIResponse EndGetBackendAPI(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackendAPIResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackendAPIModels

        /// <summary>
        /// Gets a model introspection schema for an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPIModels service method.</param>
        /// 
        /// <returns>The response from the GetBackendAPIModels service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPIModels">REST API Reference for GetBackendAPIModels Operation</seealso>
        public virtual GetBackendAPIModelsResponse GetBackendAPIModels(GetBackendAPIModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAPIModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAPIModelsResponseUnmarshaller.Instance;

            return Invoke<GetBackendAPIModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackendAPIModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPIModels operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackendAPIModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPIModels">REST API Reference for GetBackendAPIModels Operation</seealso>
        public virtual IAsyncResult BeginGetBackendAPIModels(GetBackendAPIModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAPIModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAPIModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackendAPIModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackendAPIModels.</param>
        /// 
        /// <returns>Returns a  GetBackendAPIModelsResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPIModels">REST API Reference for GetBackendAPIModels Operation</seealso>
        public virtual GetBackendAPIModelsResponse EndGetBackendAPIModels(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackendAPIModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackendAuth

        /// <summary>
        /// Gets a backend auth details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAuth service method.</param>
        /// 
        /// <returns>The response from the GetBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAuth">REST API Reference for GetBackendAuth Operation</seealso>
        public virtual GetBackendAuthResponse GetBackendAuth(GetBackendAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAuthResponseUnmarshaller.Instance;

            return Invoke<GetBackendAuthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAuth operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackendAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAuth">REST API Reference for GetBackendAuth Operation</seealso>
        public virtual IAsyncResult BeginGetBackendAuth(GetBackendAuthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAuthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackendAuth.</param>
        /// 
        /// <returns>Returns a  GetBackendAuthResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAuth">REST API Reference for GetBackendAuth Operation</seealso>
        public virtual GetBackendAuthResponse EndGetBackendAuth(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackendAuthResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackendJob

        /// <summary>
        /// Returns information about a specific job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendJob service method.</param>
        /// 
        /// <returns>The response from the GetBackendJob service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendJob">REST API Reference for GetBackendJob Operation</seealso>
        public virtual GetBackendJobResponse GetBackendJob(GetBackendJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendJobResponseUnmarshaller.Instance;

            return Invoke<GetBackendJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackendJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackendJob operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackendJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendJob">REST API Reference for GetBackendJob Operation</seealso>
        public virtual IAsyncResult BeginGetBackendJob(GetBackendJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackendJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackendJob.</param>
        /// 
        /// <returns>Returns a  GetBackendJobResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendJob">REST API Reference for GetBackendJob Operation</seealso>
        public virtual GetBackendJobResponse EndGetBackendJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackendJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackendStorage

        /// <summary>
        /// Gets details for a backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendStorage service method.</param>
        /// 
        /// <returns>The response from the GetBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendStorage">REST API Reference for GetBackendStorage Operation</seealso>
        public virtual GetBackendStorageResponse GetBackendStorage(GetBackendStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendStorageResponseUnmarshaller.Instance;

            return Invoke<GetBackendStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackendStorage operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackendStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendStorage">REST API Reference for GetBackendStorage Operation</seealso>
        public virtual IAsyncResult BeginGetBackendStorage(GetBackendStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackendStorage.</param>
        /// 
        /// <returns>Returns a  GetBackendStorageResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendStorage">REST API Reference for GetBackendStorage Operation</seealso>
        public virtual GetBackendStorageResponse EndGetBackendStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackendStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetToken

        /// <summary>
        /// Gets the challenge token based on the given appId and sessionId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetToken service method.</param>
        /// 
        /// <returns>The response from the GetToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetToken">REST API Reference for GetToken Operation</seealso>
        public virtual GetTokenResponse GetToken(GetTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTokenResponseUnmarshaller.Instance;

            return Invoke<GetTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetToken operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetToken">REST API Reference for GetToken Operation</seealso>
        public virtual IAsyncResult BeginGetToken(GetTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetToken.</param>
        /// 
        /// <returns>Returns a  GetTokenResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetToken">REST API Reference for GetToken Operation</seealso>
        public virtual GetTokenResponse EndGetToken(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportBackendAuth

        /// <summary>
        /// Imports an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendAuth service method.</param>
        /// 
        /// <returns>The response from the ImportBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendAuth">REST API Reference for ImportBackendAuth Operation</seealso>
        public virtual ImportBackendAuthResponse ImportBackendAuth(ImportBackendAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportBackendAuthResponseUnmarshaller.Instance;

            return Invoke<ImportBackendAuthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendAuth operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportBackendAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendAuth">REST API Reference for ImportBackendAuth Operation</seealso>
        public virtual IAsyncResult BeginImportBackendAuth(ImportBackendAuthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportBackendAuthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportBackendAuth.</param>
        /// 
        /// <returns>Returns a  ImportBackendAuthResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendAuth">REST API Reference for ImportBackendAuth Operation</seealso>
        public virtual ImportBackendAuthResponse EndImportBackendAuth(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportBackendAuthResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportBackendStorage

        /// <summary>
        /// Imports an existing backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendStorage service method.</param>
        /// 
        /// <returns>The response from the ImportBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendStorage">REST API Reference for ImportBackendStorage Operation</seealso>
        public virtual ImportBackendStorageResponse ImportBackendStorage(ImportBackendStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportBackendStorageResponseUnmarshaller.Instance;

            return Invoke<ImportBackendStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendStorage operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportBackendStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendStorage">REST API Reference for ImportBackendStorage Operation</seealso>
        public virtual IAsyncResult BeginImportBackendStorage(ImportBackendStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportBackendStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportBackendStorage.</param>
        /// 
        /// <returns>Returns a  ImportBackendStorageResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendStorage">REST API Reference for ImportBackendStorage Operation</seealso>
        public virtual ImportBackendStorageResponse EndImportBackendStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportBackendStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBackendJobs

        /// <summary>
        /// Lists the jobs for the backend of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackendJobs service method.</param>
        /// 
        /// <returns>The response from the ListBackendJobs service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListBackendJobs">REST API Reference for ListBackendJobs Operation</seealso>
        public virtual ListBackendJobsResponse ListBackendJobs(ListBackendJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackendJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackendJobsResponseUnmarshaller.Instance;

            return Invoke<ListBackendJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackendJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackendJobs operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackendJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListBackendJobs">REST API Reference for ListBackendJobs Operation</seealso>
        public virtual IAsyncResult BeginListBackendJobs(ListBackendJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackendJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackendJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackendJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackendJobs.</param>
        /// 
        /// <returns>Returns a  ListBackendJobsResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListBackendJobs">REST API Reference for ListBackendJobs Operation</seealso>
        public virtual ListBackendJobsResponse EndListBackendJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackendJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListS3Buckets

        /// <summary>
        /// The list of S3 buckets in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3Buckets service method.</param>
        /// 
        /// <returns>The response from the ListS3Buckets service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListS3Buckets">REST API Reference for ListS3Buckets Operation</seealso>
        public virtual ListS3BucketsResponse ListS3Buckets(ListS3BucketsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListS3BucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListS3BucketsResponseUnmarshaller.Instance;

            return Invoke<ListS3BucketsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListS3Buckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListS3Buckets operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListS3Buckets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListS3Buckets">REST API Reference for ListS3Buckets Operation</seealso>
        public virtual IAsyncResult BeginListS3Buckets(ListS3BucketsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListS3BucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListS3BucketsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListS3Buckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListS3Buckets.</param>
        /// 
        /// <returns>Returns a  ListS3BucketsResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListS3Buckets">REST API Reference for ListS3Buckets Operation</seealso>
        public virtual ListS3BucketsResponse EndListS3Buckets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListS3BucketsResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveAllBackends

        /// <summary>
        /// Removes all backend environments from your Amplify project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllBackends service method.</param>
        /// 
        /// <returns>The response from the RemoveAllBackends service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveAllBackends">REST API Reference for RemoveAllBackends Operation</seealso>
        public virtual RemoveAllBackendsResponse RemoveAllBackends(RemoveAllBackendsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAllBackendsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAllBackendsResponseUnmarshaller.Instance;

            return Invoke<RemoveAllBackendsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAllBackends operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllBackends operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAllBackends
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveAllBackends">REST API Reference for RemoveAllBackends Operation</seealso>
        public virtual IAsyncResult BeginRemoveAllBackends(RemoveAllBackendsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAllBackendsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAllBackendsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAllBackends operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAllBackends.</param>
        /// 
        /// <returns>Returns a  RemoveAllBackendsResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveAllBackends">REST API Reference for RemoveAllBackends Operation</seealso>
        public virtual RemoveAllBackendsResponse EndRemoveAllBackends(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveAllBackendsResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveBackendConfig

        /// <summary>
        /// Removes the AWS resources required to access the Amplify Admin UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveBackendConfig service method.</param>
        /// 
        /// <returns>The response from the RemoveBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveBackendConfig">REST API Reference for RemoveBackendConfig Operation</seealso>
        public virtual RemoveBackendConfigResponse RemoveBackendConfig(RemoveBackendConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBackendConfigResponseUnmarshaller.Instance;

            return Invoke<RemoveBackendConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveBackendConfig operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveBackendConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveBackendConfig">REST API Reference for RemoveBackendConfig Operation</seealso>
        public virtual IAsyncResult BeginRemoveBackendConfig(RemoveBackendConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBackendConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveBackendConfig.</param>
        /// 
        /// <returns>Returns a  RemoveBackendConfigResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveBackendConfig">REST API Reference for RemoveBackendConfig Operation</seealso>
        public virtual RemoveBackendConfigResponse EndRemoveBackendConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveBackendConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBackendAPI

        /// <summary>
        /// Updates an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAPI service method.</param>
        /// 
        /// <returns>The response from the UpdateBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAPI">REST API Reference for UpdateBackendAPI Operation</seealso>
        public virtual UpdateBackendAPIResponse UpdateBackendAPI(UpdateBackendAPIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendAPIResponseUnmarshaller.Instance;

            return Invoke<UpdateBackendAPIResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAPI operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackendAPI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAPI">REST API Reference for UpdateBackendAPI Operation</seealso>
        public virtual IAsyncResult BeginUpdateBackendAPI(UpdateBackendAPIRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendAPIResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackendAPI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackendAPI.</param>
        /// 
        /// <returns>Returns a  UpdateBackendAPIResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAPI">REST API Reference for UpdateBackendAPI Operation</seealso>
        public virtual UpdateBackendAPIResponse EndUpdateBackendAPI(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBackendAPIResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBackendAuth

        /// <summary>
        /// Updates an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAuth service method.</param>
        /// 
        /// <returns>The response from the UpdateBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAuth">REST API Reference for UpdateBackendAuth Operation</seealso>
        public virtual UpdateBackendAuthResponse UpdateBackendAuth(UpdateBackendAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendAuthResponseUnmarshaller.Instance;

            return Invoke<UpdateBackendAuthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAuth operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackendAuth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAuth">REST API Reference for UpdateBackendAuth Operation</seealso>
        public virtual IAsyncResult BeginUpdateBackendAuth(UpdateBackendAuthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendAuthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackendAuth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackendAuth.</param>
        /// 
        /// <returns>Returns a  UpdateBackendAuthResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAuth">REST API Reference for UpdateBackendAuth Operation</seealso>
        public virtual UpdateBackendAuthResponse EndUpdateBackendAuth(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBackendAuthResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBackendConfig

        /// <summary>
        /// Updates the AWS resources required to access the Amplify Admin UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendConfig">REST API Reference for UpdateBackendConfig Operation</seealso>
        public virtual UpdateBackendConfigResponse UpdateBackendConfig(UpdateBackendConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateBackendConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendConfig operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackendConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendConfig">REST API Reference for UpdateBackendConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateBackendConfig(UpdateBackendConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackendConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackendConfig.</param>
        /// 
        /// <returns>Returns a  UpdateBackendConfigResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendConfig">REST API Reference for UpdateBackendConfig Operation</seealso>
        public virtual UpdateBackendConfigResponse EndUpdateBackendConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBackendConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBackendJob

        /// <summary>
        /// Updates a specific job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendJob service method.</param>
        /// 
        /// <returns>The response from the UpdateBackendJob service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendJob">REST API Reference for UpdateBackendJob Operation</seealso>
        public virtual UpdateBackendJobResponse UpdateBackendJob(UpdateBackendJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendJobResponseUnmarshaller.Instance;

            return Invoke<UpdateBackendJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackendJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendJob operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackendJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendJob">REST API Reference for UpdateBackendJob Operation</seealso>
        public virtual IAsyncResult BeginUpdateBackendJob(UpdateBackendJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackendJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackendJob.</param>
        /// 
        /// <returns>Returns a  UpdateBackendJobResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendJob">REST API Reference for UpdateBackendJob Operation</seealso>
        public virtual UpdateBackendJobResponse EndUpdateBackendJob(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBackendJobResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBackendStorage

        /// <summary>
        /// Updates an existing backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendStorage service method.</param>
        /// 
        /// <returns>The response from the UpdateBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendStorage">REST API Reference for UpdateBackendStorage Operation</seealso>
        public virtual UpdateBackendStorageResponse UpdateBackendStorage(UpdateBackendStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendStorageResponseUnmarshaller.Instance;

            return Invoke<UpdateBackendStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendStorage operation on AmazonAmplifyBackendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackendStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendStorage">REST API Reference for UpdateBackendStorage Operation</seealso>
        public virtual IAsyncResult BeginUpdateBackendStorage(UpdateBackendStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackendStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackendStorage.</param>
        /// 
        /// <returns>Returns a  UpdateBackendStorageResult from AmplifyBackend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendStorage">REST API Reference for UpdateBackendStorage Operation</seealso>
        public virtual UpdateBackendStorageResponse EndUpdateBackendStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBackendStorageResponse>(asyncResult);
        }

        #endregion
        
    }
}