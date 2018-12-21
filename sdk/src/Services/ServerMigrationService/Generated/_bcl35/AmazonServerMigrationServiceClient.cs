/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ServerMigrationService.Model;
using Amazon.ServerMigrationService.Model.Internal.MarshallTransformations;
using Amazon.ServerMigrationService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ServerMigrationService
{
    /// <summary>
    /// Implementation for accessing ServerMigrationService
    ///
    /// AAWS Sever Migration Service 
    /// <para>
    /// This is the <i>AWS Sever Migration Service API Reference</i>. It provides descriptions,
    /// syntax, and usage examples for each of the actions and data types for the AWS Sever
    /// Migration Service (AWS SMS). The topic for each action shows the Query API request
    /// parameters and the XML response. You can also view the XML request elements in the
    /// WSDL.
    /// </para>
    ///  
    /// <para>
    /// Alternatively, you can use one of the AWS SDKs to access an API that's tailored to
    /// the programming language or platform that you're using. For more information, see
    /// <a href="http://aws.amazon.com/tools/#SDKs">AWS SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// To learn more about the Server Migration Service, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://aws.amazon.com/server-migration-service/">AWS Sever Migration Service
    /// product page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/server-migration-service/latest/userguide/server-migration.html">AWS
    /// Sever Migration Service User Guide</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonServerMigrationServiceClient : AmazonServiceClient, IAmazonServerMigrationService
    {
        private static IServiceMetadata serviceMetadata = new AmazonServerMigrationServiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with the credentials loaded from the application's
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
        public AmazonServerMigrationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServerMigrationServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with the credentials loaded from the application's
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
        public AmazonServerMigrationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServerMigrationServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(AmazonServerMigrationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonServerMigrationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonServerMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerMigrationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonServerMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Credentials and an
        /// AmazonServerMigrationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(AWSCredentials credentials, AmazonServerMigrationServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServerMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServerMigrationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServerMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonServerMigrationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServerMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServerMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServerMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonServerMigrationServiceConfig clientConfig)
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


        #region  CreateApp

        /// <summary>
        /// Creates an application. An application consists of one or more server groups. Each
        /// server group contain one or more servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual CreateAppResponse EndCreateApp(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReplicationJob

        /// <summary>
        /// Creates a replication job. The replication job schedules periodic replication runs
        /// to replicate your server to AWS. Each replication run creates an Amazon Machine Image
        /// (AMI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationJob service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.NoConnectorsAvailableException">
        /// There are no connectors available.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobAlreadyExistsException">
        /// The specified replication job already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ServerCannotBeReplicatedException">
        /// The specified server cannot be replicated.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.TemporarilyUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateReplicationJob">REST API Reference for CreateReplicationJob Operation</seealso>
        public virtual CreateReplicationJobResponse CreateReplicationJob(CreateReplicationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationJobResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationJob operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateReplicationJob">REST API Reference for CreateReplicationJob Operation</seealso>
        public virtual IAsyncResult BeginCreateReplicationJob(CreateReplicationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationJob.</param>
        /// 
        /// <returns>Returns a  CreateReplicationJobResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateReplicationJob">REST API Reference for CreateReplicationJob Operation</seealso>
        public virtual CreateReplicationJobResponse EndCreateReplicationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReplicationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApp

        /// <summary>
        /// Deletes an existing application. Optionally deletes the launched stack associated
        /// with the application and all AWS SMS replication jobs for servers in the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppLaunchConfiguration

        /// <summary>
        /// Deletes existing launch configuration for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAppLaunchConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppLaunchConfiguration">REST API Reference for DeleteAppLaunchConfiguration Operation</seealso>
        public virtual DeleteAppLaunchConfigurationResponse DeleteAppLaunchConfiguration(DeleteAppLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteAppLaunchConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppLaunchConfiguration operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppLaunchConfiguration">REST API Reference for DeleteAppLaunchConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppLaunchConfiguration(DeleteAppLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteAppLaunchConfigurationResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppLaunchConfiguration">REST API Reference for DeleteAppLaunchConfiguration Operation</seealso>
        public virtual DeleteAppLaunchConfigurationResponse EndDeleteAppLaunchConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppLaunchConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppReplicationConfiguration

        /// <summary>
        /// Deletes existing replication configuration for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAppReplicationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppReplicationConfiguration">REST API Reference for DeleteAppReplicationConfiguration Operation</seealso>
        public virtual DeleteAppReplicationConfigurationResponse DeleteAppReplicationConfiguration(DeleteAppReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteAppReplicationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppReplicationConfiguration operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppReplicationConfiguration">REST API Reference for DeleteAppReplicationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppReplicationConfiguration(DeleteAppReplicationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppReplicationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteAppReplicationConfigurationResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppReplicationConfiguration">REST API Reference for DeleteAppReplicationConfiguration Operation</seealso>
        public virtual DeleteAppReplicationConfigurationResponse EndDeleteAppReplicationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppReplicationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReplicationJob

        /// <summary>
        /// Deletes the specified replication job.
        /// 
        ///  
        /// <para>
        /// After you delete a replication job, there are no further replication runs. AWS deletes
        /// the contents of the Amazon S3 bucket used to store AWS SMS artifacts. The AMIs created
        /// by the replication runs are not deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationJob service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobNotFoundException">
        /// The specified replication job does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteReplicationJob">REST API Reference for DeleteReplicationJob Operation</seealso>
        public virtual DeleteReplicationJobResponse DeleteReplicationJob(DeleteReplicationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationJobResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationJob operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteReplicationJob">REST API Reference for DeleteReplicationJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteReplicationJob(DeleteReplicationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationJob.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationJobResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteReplicationJob">REST API Reference for DeleteReplicationJob Operation</seealso>
        public virtual DeleteReplicationJobResponse EndDeleteReplicationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReplicationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServerCatalog

        /// <summary>
        /// Deletes all servers from your server catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCatalog service method.</param>
        /// 
        /// <returns>The response from the DeleteServerCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteServerCatalog">REST API Reference for DeleteServerCatalog Operation</seealso>
        public virtual DeleteServerCatalogResponse DeleteServerCatalog(DeleteServerCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServerCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerCatalogResponseUnmarshaller.Instance;

            return Invoke<DeleteServerCatalogResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCatalog operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServerCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteServerCatalog">REST API Reference for DeleteServerCatalog Operation</seealso>
        public virtual IAsyncResult BeginDeleteServerCatalog(DeleteServerCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServerCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServerCatalog.</param>
        /// 
        /// <returns>Returns a  DeleteServerCatalogResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteServerCatalog">REST API Reference for DeleteServerCatalog Operation</seealso>
        public virtual DeleteServerCatalogResponse EndDeleteServerCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServerCatalogResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateConnector

        /// <summary>
        /// Disassociates the specified connector from AWS SMS.
        /// 
        ///  
        /// <para>
        /// After you disassociate a connector, it is no longer available to support replication
        /// jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnector service method.</param>
        /// 
        /// <returns>The response from the DisassociateConnector service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DisassociateConnector">REST API Reference for DisassociateConnector Operation</seealso>
        public virtual DisassociateConnectorResponse DisassociateConnector(DisassociateConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectorResponseUnmarshaller.Instance;

            return Invoke<DisassociateConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnector operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DisassociateConnector">REST API Reference for DisassociateConnector Operation</seealso>
        public virtual IAsyncResult BeginDisassociateConnector(DisassociateConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateConnector.</param>
        /// 
        /// <returns>Returns a  DisassociateConnectorResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DisassociateConnector">REST API Reference for DisassociateConnector Operation</seealso>
        public virtual DisassociateConnectorResponse EndDisassociateConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  GenerateChangeSet

        /// <summary>
        /// Generates a target change set for a currently launched stack and writes it to an Amazon
        /// S3 object in the customer’s Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateChangeSet service method.</param>
        /// 
        /// <returns>The response from the GenerateChangeSet service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateChangeSet">REST API Reference for GenerateChangeSet Operation</seealso>
        public virtual GenerateChangeSetResponse GenerateChangeSet(GenerateChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateChangeSetResponseUnmarshaller.Instance;

            return Invoke<GenerateChangeSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateChangeSet operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateChangeSet">REST API Reference for GenerateChangeSet Operation</seealso>
        public virtual IAsyncResult BeginGenerateChangeSet(GenerateChangeSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateChangeSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateChangeSet.</param>
        /// 
        /// <returns>Returns a  GenerateChangeSetResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateChangeSet">REST API Reference for GenerateChangeSet Operation</seealso>
        public virtual GenerateChangeSetResponse EndGenerateChangeSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateChangeSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GenerateTemplate

        /// <summary>
        /// Generates an Amazon CloudFormation template based on the current launch configuration
        /// and writes it to an Amazon S3 object in the customer’s Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateTemplate service method.</param>
        /// 
        /// <returns>The response from the GenerateTemplate service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateTemplate">REST API Reference for GenerateTemplate Operation</seealso>
        public virtual GenerateTemplateResponse GenerateTemplate(GenerateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateTemplateResponseUnmarshaller.Instance;

            return Invoke<GenerateTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateTemplate operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateTemplate">REST API Reference for GenerateTemplate Operation</seealso>
        public virtual IAsyncResult BeginGenerateTemplate(GenerateTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateTemplate.</param>
        /// 
        /// <returns>Returns a  GenerateTemplateResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateTemplate">REST API Reference for GenerateTemplate Operation</seealso>
        public virtual GenerateTemplateResponse EndGenerateTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApp

        /// <summary>
        /// Retrieve information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual GetAppResponse GetApp(GetAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return Invoke<GetAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApp operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual IAsyncResult BeginGetApp(GetAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApp.</param>
        /// 
        /// <returns>Returns a  GetAppResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual GetAppResponse EndGetApp(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAppLaunchConfiguration

        /// <summary>
        /// Retrieves the application launch configuration associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAppLaunchConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppLaunchConfiguration">REST API Reference for GetAppLaunchConfiguration Operation</seealso>
        public virtual GetAppLaunchConfigurationResponse GetAppLaunchConfiguration(GetAppLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetAppLaunchConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAppLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppLaunchConfiguration operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppLaunchConfiguration">REST API Reference for GetAppLaunchConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetAppLaunchConfiguration(GetAppLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  GetAppLaunchConfigurationResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppLaunchConfiguration">REST API Reference for GetAppLaunchConfiguration Operation</seealso>
        public virtual GetAppLaunchConfigurationResponse EndGetAppLaunchConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppLaunchConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAppReplicationConfiguration

        /// <summary>
        /// Retrieves an application replication configuration associatd with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAppReplicationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppReplicationConfiguration">REST API Reference for GetAppReplicationConfiguration Operation</seealso>
        public virtual GetAppReplicationConfigurationResponse GetAppReplicationConfiguration(GetAppReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetAppReplicationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAppReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppReplicationConfiguration operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppReplicationConfiguration">REST API Reference for GetAppReplicationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetAppReplicationConfiguration(GetAppReplicationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppReplicationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetAppReplicationConfigurationResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppReplicationConfiguration">REST API Reference for GetAppReplicationConfiguration Operation</seealso>
        public virtual GetAppReplicationConfigurationResponse EndGetAppReplicationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppReplicationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectors

        /// <summary>
        /// Describes the connectors registered with the AWS SMS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectors service method.</param>
        /// 
        /// <returns>The response from the GetConnectors service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetConnectors">REST API Reference for GetConnectors Operation</seealso>
        public virtual GetConnectorsResponse GetConnectors(GetConnectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorsResponseUnmarshaller.Instance;

            return Invoke<GetConnectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectors operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetConnectors">REST API Reference for GetConnectors Operation</seealso>
        public virtual IAsyncResult BeginGetConnectors(GetConnectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectors.</param>
        /// 
        /// <returns>Returns a  GetConnectorsResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetConnectors">REST API Reference for GetConnectors Operation</seealso>
        public virtual GetConnectorsResponse EndGetConnectors(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReplicationJobs

        /// <summary>
        /// Describes the specified replication job or all of your replication jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationJobs service method.</param>
        /// 
        /// <returns>The response from the GetReplicationJobs service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationJobs">REST API Reference for GetReplicationJobs Operation</seealso>
        public virtual GetReplicationJobsResponse GetReplicationJobs(GetReplicationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationJobsResponseUnmarshaller.Instance;

            return Invoke<GetReplicationJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationJobs operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReplicationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationJobs">REST API Reference for GetReplicationJobs Operation</seealso>
        public virtual IAsyncResult BeginGetReplicationJobs(GetReplicationJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReplicationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReplicationJobs.</param>
        /// 
        /// <returns>Returns a  GetReplicationJobsResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationJobs">REST API Reference for GetReplicationJobs Operation</seealso>
        public virtual GetReplicationJobsResponse EndGetReplicationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReplicationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReplicationRuns

        /// <summary>
        /// Describes the replication runs for the specified replication job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationRuns service method.</param>
        /// 
        /// <returns>The response from the GetReplicationRuns service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationRuns">REST API Reference for GetReplicationRuns Operation</seealso>
        public virtual GetReplicationRunsResponse GetReplicationRuns(GetReplicationRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationRunsResponseUnmarshaller.Instance;

            return Invoke<GetReplicationRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationRuns operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReplicationRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationRuns">REST API Reference for GetReplicationRuns Operation</seealso>
        public virtual IAsyncResult BeginGetReplicationRuns(GetReplicationRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReplicationRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReplicationRuns.</param>
        /// 
        /// <returns>Returns a  GetReplicationRunsResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationRuns">REST API Reference for GetReplicationRuns Operation</seealso>
        public virtual GetReplicationRunsResponse EndGetReplicationRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReplicationRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServers

        /// <summary>
        /// Describes the servers in your server catalog.
        /// 
        ///  
        /// <para>
        /// Before you can describe your servers, you must import them using <a>ImportServerCatalog</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServers service method.</param>
        /// 
        /// <returns>The response from the GetServers service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetServers">REST API Reference for GetServers Operation</seealso>
        public virtual GetServersResponse GetServers(GetServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServersResponseUnmarshaller.Instance;

            return Invoke<GetServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServers operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetServers">REST API Reference for GetServers Operation</seealso>
        public virtual IAsyncResult BeginGetServers(GetServersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServers.</param>
        /// 
        /// <returns>Returns a  GetServersResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetServers">REST API Reference for GetServers Operation</seealso>
        public virtual GetServersResponse EndGetServers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServersResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportServerCatalog

        /// <summary>
        /// Gathers a complete list of on-premises servers. Connectors must be installed and monitoring
        /// all servers that you want to import.
        /// 
        ///  
        /// <para>
        /// This call returns immediately, but might take additional time to retrieve all the
        /// servers.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportServerCatalog service method.</param>
        /// 
        /// <returns>The response from the ImportServerCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.NoConnectorsAvailableException">
        /// There are no connectors available.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportServerCatalog">REST API Reference for ImportServerCatalog Operation</seealso>
        public virtual ImportServerCatalogResponse ImportServerCatalog(ImportServerCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportServerCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportServerCatalogResponseUnmarshaller.Instance;

            return Invoke<ImportServerCatalogResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportServerCatalog operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportServerCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportServerCatalog">REST API Reference for ImportServerCatalog Operation</seealso>
        public virtual IAsyncResult BeginImportServerCatalog(ImportServerCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportServerCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportServerCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportServerCatalog.</param>
        /// 
        /// <returns>Returns a  ImportServerCatalogResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportServerCatalog">REST API Reference for ImportServerCatalog Operation</seealso>
        public virtual ImportServerCatalogResponse EndImportServerCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportServerCatalogResponse>(asyncResult);
        }

        #endregion
        
        #region  LaunchApp

        /// <summary>
        /// Launches an application stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LaunchApp service method.</param>
        /// 
        /// <returns>The response from the LaunchApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/LaunchApp">REST API Reference for LaunchApp Operation</seealso>
        public virtual LaunchAppResponse LaunchApp(LaunchAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LaunchAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LaunchAppResponseUnmarshaller.Instance;

            return Invoke<LaunchAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the LaunchApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LaunchApp operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLaunchApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/LaunchApp">REST API Reference for LaunchApp Operation</seealso>
        public virtual IAsyncResult BeginLaunchApp(LaunchAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LaunchAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LaunchAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  LaunchApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLaunchApp.</param>
        /// 
        /// <returns>Returns a  LaunchAppResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/LaunchApp">REST API Reference for LaunchApp Operation</seealso>
        public virtual LaunchAppResponse EndLaunchApp(IAsyncResult asyncResult)
        {
            return EndInvoke<LaunchAppResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApps

        /// <summary>
        /// Returns a list of summaries for all applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse ListApps(ListAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return Invoke<ListAppsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApps operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual IAsyncResult BeginListApps(ListAppsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApps.</param>
        /// 
        /// <returns>Returns a  ListAppsResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse EndListApps(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAppLaunchConfiguration

        /// <summary>
        /// Creates a launch configuration for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutAppLaunchConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppLaunchConfiguration">REST API Reference for PutAppLaunchConfiguration Operation</seealso>
        public virtual PutAppLaunchConfigurationResponse PutAppLaunchConfiguration(PutAppLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutAppLaunchConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAppLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppLaunchConfiguration operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAppLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppLaunchConfiguration">REST API Reference for PutAppLaunchConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutAppLaunchConfiguration(PutAppLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAppLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAppLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  PutAppLaunchConfigurationResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppLaunchConfiguration">REST API Reference for PutAppLaunchConfiguration Operation</seealso>
        public virtual PutAppLaunchConfigurationResponse EndPutAppLaunchConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAppLaunchConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAppReplicationConfiguration

        /// <summary>
        /// Creates or updates a replication configuration for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutAppReplicationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppReplicationConfiguration">REST API Reference for PutAppReplicationConfiguration Operation</seealso>
        public virtual PutAppReplicationConfigurationResponse PutAppReplicationConfiguration(PutAppReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutAppReplicationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAppReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppReplicationConfiguration operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAppReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppReplicationConfiguration">REST API Reference for PutAppReplicationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutAppReplicationConfiguration(PutAppReplicationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppReplicationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAppReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAppReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  PutAppReplicationConfigurationResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppReplicationConfiguration">REST API Reference for PutAppReplicationConfiguration Operation</seealso>
        public virtual PutAppReplicationConfigurationResponse EndPutAppReplicationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAppReplicationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAppReplication

        /// <summary>
        /// Starts replicating an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAppReplication service method.</param>
        /// 
        /// <returns>The response from the StartAppReplication service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartAppReplication">REST API Reference for StartAppReplication Operation</seealso>
        public virtual StartAppReplicationResponse StartAppReplication(StartAppReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAppReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppReplicationResponseUnmarshaller.Instance;

            return Invoke<StartAppReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAppReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAppReplication operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAppReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartAppReplication">REST API Reference for StartAppReplication Operation</seealso>
        public virtual IAsyncResult BeginStartAppReplication(StartAppReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAppReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAppReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAppReplication.</param>
        /// 
        /// <returns>Returns a  StartAppReplicationResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartAppReplication">REST API Reference for StartAppReplication Operation</seealso>
        public virtual StartAppReplicationResponse EndStartAppReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAppReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartOnDemandReplicationRun

        /// <summary>
        /// Starts an on-demand replication run for the specified replication job. This replication
        /// run starts immediately. This replication run is in addition to the ones already scheduled.
        /// 
        ///  
        /// <para>
        /// There is a limit on the number of on-demand replications runs you can request in a
        /// 24-hour period.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandReplicationRun service method.</param>
        /// 
        /// <returns>The response from the StartOnDemandReplicationRun service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationRunLimitExceededException">
        /// You have exceeded the number of on-demand replication runs you can request in a 24-hour
        /// period.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandReplicationRun">REST API Reference for StartOnDemandReplicationRun Operation</seealso>
        public virtual StartOnDemandReplicationRunResponse StartOnDemandReplicationRun(StartOnDemandReplicationRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOnDemandReplicationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOnDemandReplicationRunResponseUnmarshaller.Instance;

            return Invoke<StartOnDemandReplicationRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartOnDemandReplicationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandReplicationRun operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartOnDemandReplicationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandReplicationRun">REST API Reference for StartOnDemandReplicationRun Operation</seealso>
        public virtual IAsyncResult BeginStartOnDemandReplicationRun(StartOnDemandReplicationRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOnDemandReplicationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOnDemandReplicationRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartOnDemandReplicationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartOnDemandReplicationRun.</param>
        /// 
        /// <returns>Returns a  StartOnDemandReplicationRunResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandReplicationRun">REST API Reference for StartOnDemandReplicationRun Operation</seealso>
        public virtual StartOnDemandReplicationRunResponse EndStartOnDemandReplicationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartOnDemandReplicationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StopAppReplication

        /// <summary>
        /// Stops replicating an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAppReplication service method.</param>
        /// 
        /// <returns>The response from the StopAppReplication service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StopAppReplication">REST API Reference for StopAppReplication Operation</seealso>
        public virtual StopAppReplicationResponse StopAppReplication(StopAppReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAppReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAppReplicationResponseUnmarshaller.Instance;

            return Invoke<StopAppReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopAppReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAppReplication operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopAppReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StopAppReplication">REST API Reference for StopAppReplication Operation</seealso>
        public virtual IAsyncResult BeginStopAppReplication(StopAppReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAppReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAppReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopAppReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopAppReplication.</param>
        /// 
        /// <returns>Returns a  StopAppReplicationResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StopAppReplication">REST API Reference for StopAppReplication Operation</seealso>
        public virtual StopAppReplicationResponse EndStopAppReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StopAppReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateApp

        /// <summary>
        /// Terminates the stack for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateApp service method.</param>
        /// 
        /// <returns>The response from the TerminateApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/TerminateApp">REST API Reference for TerminateApp Operation</seealso>
        public virtual TerminateAppResponse TerminateApp(TerminateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateAppResponseUnmarshaller.Instance;

            return Invoke<TerminateAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateApp operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/TerminateApp">REST API Reference for TerminateApp Operation</seealso>
        public virtual IAsyncResult BeginTerminateApp(TerminateAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateApp.</param>
        /// 
        /// <returns>Returns a  TerminateAppResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/TerminateApp">REST API Reference for TerminateApp Operation</seealso>
        public virtual TerminateAppResponse EndTerminateApp(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateAppResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApp

        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return Invoke<UpdateAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual IAsyncResult BeginUpdateApp(UpdateAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApp.</param>
        /// 
        /// <returns>Returns a  UpdateAppResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual UpdateAppResponse EndUpdateApp(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAppResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReplicationJob

        /// <summary>
        /// Updates the specified settings for the specified replication job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationJob service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobNotFoundException">
        /// The specified replication job does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ServerCannotBeReplicatedException">
        /// The specified server cannot be replicated.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.TemporarilyUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateReplicationJob">REST API Reference for UpdateReplicationJob Operation</seealso>
        public virtual UpdateReplicationJobResponse UpdateReplicationJob(UpdateReplicationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationJobResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationJob operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateReplicationJob">REST API Reference for UpdateReplicationJob Operation</seealso>
        public virtual IAsyncResult BeginUpdateReplicationJob(UpdateReplicationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationJob.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationJobResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateReplicationJob">REST API Reference for UpdateReplicationJob Operation</seealso>
        public virtual UpdateReplicationJobResponse EndUpdateReplicationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReplicationJobResponse>(asyncResult);
        }

        #endregion
        
    }
}