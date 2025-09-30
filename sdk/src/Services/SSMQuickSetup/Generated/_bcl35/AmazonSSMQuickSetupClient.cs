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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SSMQuickSetup.Model;
using Amazon.SSMQuickSetup.Model.Internal.MarshallTransformations;
using Amazon.SSMQuickSetup.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.SSMQuickSetup
{
    /// <summary>
    /// <para>Implementation for accessing SSMQuickSetup</para>
    ///
    /// Quick Setup helps you quickly configure frequently used services and features with
    /// recommended best practices. Quick Setup simplifies setting up services, including
    /// Systems Manager, by automating common or recommended tasks.
    /// </summary>
    public partial class AmazonSSMQuickSetupClient : AmazonServiceClient, IAmazonSSMQuickSetup
    {
        private static IServiceMetadata serviceMetadata = new AmazonSSMQuickSetupMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ISSMQuickSetupPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISSMQuickSetupPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SSMQuickSetupPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with the credentials loaded from the application's
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
        public AmazonSSMQuickSetupClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSSMQuickSetupConfig()) { }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with the credentials loaded from the application's
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
        public AmazonSSMQuickSetupClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSSMQuickSetupConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSSMQuickSetupClient Configuration Object</param>
        public AmazonSSMQuickSetupClient(AmazonSSMQuickSetupConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSSMQuickSetupClient(AWSCredentials credentials)
            : this(credentials, new AmazonSSMQuickSetupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMQuickSetupClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSSMQuickSetupConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Credentials and an
        /// AmazonSSMQuickSetupClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSSMQuickSetupClient Configuration Object</param>
        public AmazonSSMQuickSetupClient(AWSCredentials credentials, AmazonSSMQuickSetupConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSMQuickSetupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSMQuickSetupConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSMQuickSetupClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSSMQuickSetupClient Configuration Object</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSSMQuickSetupConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSMQuickSetupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSMQuickSetupConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSMQuickSetupClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSSMQuickSetupClient Configuration Object</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSSMQuickSetupConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSMQuickSetupEndpointResolver());
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


        #region  CreateConfigurationManager

        /// <summary>
        /// Creates a Quick Setup configuration manager resource. This object is a collection
        /// of desired state configurations for multiple configuration definitions and summaries
        /// describing the deployments of those definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/CreateConfigurationManager">REST API Reference for CreateConfigurationManager Operation</seealso>
        public virtual CreateConfigurationManagerResponse CreateConfigurationManager(CreateConfigurationManagerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationManagerResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationManagerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationManager operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationManager
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/CreateConfigurationManager">REST API Reference for CreateConfigurationManager Operation</seealso>
        public virtual IAsyncResult BeginCreateConfigurationManager(CreateConfigurationManagerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationManagerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationManager.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationManagerResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/CreateConfigurationManager">REST API Reference for CreateConfigurationManager Operation</seealso>
        public virtual CreateConfigurationManagerResponse EndCreateConfigurationManager(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfigurationManagerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfigurationManager

        /// <summary>
        /// Deletes a configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/DeleteConfigurationManager">REST API Reference for DeleteConfigurationManager Operation</seealso>
        public virtual DeleteConfigurationManagerResponse DeleteConfigurationManager(DeleteConfigurationManagerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationManagerResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationManagerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationManager operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationManager
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/DeleteConfigurationManager">REST API Reference for DeleteConfigurationManager Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfigurationManager(DeleteConfigurationManagerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationManagerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationManager.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationManagerResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/DeleteConfigurationManager">REST API Reference for DeleteConfigurationManager Operation</seealso>
        public virtual DeleteConfigurationManagerResponse EndDeleteConfigurationManager(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigurationManagerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguration

        /// <summary>
        /// Returns details about the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        public virtual GetConfigurationResponse GetConfiguration(GetConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguration(GetConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguration.</param>
        /// 
        /// <returns>Returns a  GetConfigurationResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        public virtual GetConfigurationResponse EndGetConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfigurationManager

        /// <summary>
        /// Returns a configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfigurationManager">REST API Reference for GetConfigurationManager Operation</seealso>
        public virtual GetConfigurationManagerResponse GetConfigurationManager(GetConfigurationManagerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationManagerResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationManagerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationManager operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationManager
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfigurationManager">REST API Reference for GetConfigurationManager Operation</seealso>
        public virtual IAsyncResult BeginGetConfigurationManager(GetConfigurationManagerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationManagerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationManager.</param>
        /// 
        /// <returns>Returns a  GetConfigurationManagerResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfigurationManager">REST API Reference for GetConfigurationManager Operation</seealso>
        public virtual GetConfigurationManagerResponse EndGetConfigurationManager(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfigurationManagerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceSettings

        /// <summary>
        /// Returns settings configured for Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        public virtual GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<GetServiceSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        public virtual IAsyncResult BeginGetServiceSettings(GetServiceSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceSettings.</param>
        /// 
        /// <returns>Returns a  GetServiceSettingsResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        public virtual GetServiceSettingsResponse EndGetServiceSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurationManagers

        /// <summary>
        /// Returns Quick Setup configuration managers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationManagers service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationManagers service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurationManagers">REST API Reference for ListConfigurationManagers Operation</seealso>
        public virtual ListConfigurationManagersResponse ListConfigurationManagers(ListConfigurationManagersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationManagersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationManagersResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationManagersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationManagers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationManagers operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationManagers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurationManagers">REST API Reference for ListConfigurationManagers Operation</seealso>
        public virtual IAsyncResult BeginListConfigurationManagers(ListConfigurationManagersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationManagersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationManagersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationManagers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationManagers.</param>
        /// 
        /// <returns>Returns a  ListConfigurationManagersResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurationManagers">REST API Reference for ListConfigurationManagers Operation</seealso>
        public virtual ListConfigurationManagersResponse EndListConfigurationManagers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationManagersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurations

        /// <summary>
        /// Returns configurations deployed by Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListConfigurations(ListConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurations.</param>
        /// 
        /// <returns>Returns a  ListConfigurationsResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual ListConfigurationsResponse EndListConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListQuickSetupTypes

        /// <summary>
        /// Returns the available Quick Setup types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickSetupTypes service method.</param>
        /// 
        /// <returns>The response from the ListQuickSetupTypes service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListQuickSetupTypes">REST API Reference for ListQuickSetupTypes Operation</seealso>
        public virtual ListQuickSetupTypesResponse ListQuickSetupTypes(ListQuickSetupTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQuickSetupTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickSetupTypesResponseUnmarshaller.Instance;

            return Invoke<ListQuickSetupTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQuickSetupTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQuickSetupTypes operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQuickSetupTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListQuickSetupTypes">REST API Reference for ListQuickSetupTypes Operation</seealso>
        public virtual IAsyncResult BeginListQuickSetupTypes(ListQuickSetupTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQuickSetupTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickSetupTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQuickSetupTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQuickSetupTypes.</param>
        /// 
        /// <returns>Returns a  ListQuickSetupTypesResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListQuickSetupTypes">REST API Reference for ListQuickSetupTypes Operation</seealso>
        public virtual ListQuickSetupTypesResponse EndListQuickSetupTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQuickSetupTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns tags assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns key-value pairs of metadata to Amazon Web Services resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfigurationDefinition

        /// <summary>
        /// Updates a Quick Setup configuration definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationDefinition service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationDefinition">REST API Reference for UpdateConfigurationDefinition Operation</seealso>
        public virtual UpdateConfigurationDefinitionResponse UpdateConfigurationDefinition(UpdateConfigurationDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationDefinition operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationDefinition">REST API Reference for UpdateConfigurationDefinition Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfigurationDefinition(UpdateConfigurationDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationDefinitionResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationDefinition">REST API Reference for UpdateConfigurationDefinition Operation</seealso>
        public virtual UpdateConfigurationDefinitionResponse EndUpdateConfigurationDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfigurationDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfigurationManager

        /// <summary>
        /// Updates a Quick Setup configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationManager">REST API Reference for UpdateConfigurationManager Operation</seealso>
        public virtual UpdateConfigurationManagerResponse UpdateConfigurationManager(UpdateConfigurationManagerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationManagerResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationManagerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationManager operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationManager
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationManager">REST API Reference for UpdateConfigurationManager Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfigurationManager(UpdateConfigurationManagerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationManagerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationManager.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationManagerResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationManager">REST API Reference for UpdateConfigurationManager Operation</seealso>
        public virtual UpdateConfigurationManagerResponse EndUpdateConfigurationManager(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfigurationManagerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServiceSettings

        /// <summary>
        /// Updates settings configured for Quick Setup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        public virtual UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateServiceSettings(UpdateServiceSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceSettings.</param>
        /// 
        /// <returns>Returns a  UpdateServiceSettingsResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        public virtual UpdateServiceSettingsResponse EndUpdateServiceSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceSettingsResponse>(asyncResult);
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
            var resolver = new AmazonSSMQuickSetupEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}