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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Finspace.Model;
using Amazon.Finspace.Model.Internal.MarshallTransformations;
using Amazon.Finspace.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Finspace
{
    /// <summary>
    /// <para>Implementation for accessing Finspace</para>
    ///
    /// The FinSpace management service provides the APIs for managing FinSpace environments.
    /// </summary>
    public partial class AmazonFinspaceClient : AmazonServiceClient, IAmazonFinspace
    {
        private static IServiceMetadata serviceMetadata = new AmazonFinspaceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IFinspacePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IFinspacePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new FinspacePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonFinspaceClient with the credentials loaded from the application's
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
        public AmazonFinspaceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFinspaceConfig()) { }

        /// <summary>
        /// Constructs AmazonFinspaceClient with the credentials loaded from the application's
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
        public AmazonFinspaceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFinspaceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonFinspaceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonFinspaceClient Configuration Object</param>
        public AmazonFinspaceClient(AmazonFinspaceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonFinspaceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonFinspaceClient(AWSCredentials credentials)
            : this(credentials, new AmazonFinspaceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFinspaceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFinspaceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonFinspaceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFinspaceClient with AWS Credentials and an
        /// AmazonFinspaceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonFinspaceClient Configuration Object</param>
        public AmazonFinspaceClient(AWSCredentials credentials, AmazonFinspaceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFinspaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFinspaceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFinspaceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFinspaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFinspaceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFinspaceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonFinspaceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFinspaceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonFinspaceClient Configuration Object</param>
        public AmazonFinspaceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonFinspaceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFinspaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonFinspaceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFinspaceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFinspaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFinspaceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFinspaceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFinspaceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFinspaceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonFinspaceClient Configuration Object</param>
        public AmazonFinspaceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonFinspaceConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonFinspaceEndpointResolver());
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


        #region  CreateEnvironment

        /// <summary>
        /// Create a new FinSpace environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKxChangeset

        /// <summary>
        /// Creates a changeset for a kdb database. A changeset allows you to add and delete
        /// existing files by using an ordered list of change requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxChangeset service method.</param>
        /// 
        /// <returns>The response from the CreateKxChangeset service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxChangeset">REST API Reference for CreateKxChangeset Operation</seealso>
        public virtual CreateKxChangesetResponse CreateKxChangeset(CreateKxChangesetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxChangesetResponseUnmarshaller.Instance;

            return Invoke<CreateKxChangesetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxChangeset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxChangeset operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxChangeset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxChangeset">REST API Reference for CreateKxChangeset Operation</seealso>
        public virtual IAsyncResult BeginCreateKxChangeset(CreateKxChangesetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxChangesetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxChangeset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxChangeset.</param>
        /// 
        /// <returns>Returns a  CreateKxChangesetResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxChangeset">REST API Reference for CreateKxChangeset Operation</seealso>
        public virtual CreateKxChangesetResponse EndCreateKxChangeset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKxChangesetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKxCluster

        /// <summary>
        /// Creates a new kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxCluster service method.</param>
        /// 
        /// <returns>The response from the CreateKxCluster service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxCluster">REST API Reference for CreateKxCluster Operation</seealso>
        public virtual CreateKxClusterResponse CreateKxCluster(CreateKxClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxClusterResponseUnmarshaller.Instance;

            return Invoke<CreateKxClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxCluster operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxCluster">REST API Reference for CreateKxCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateKxCluster(CreateKxClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxCluster.</param>
        /// 
        /// <returns>Returns a  CreateKxClusterResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxCluster">REST API Reference for CreateKxCluster Operation</seealso>
        public virtual CreateKxClusterResponse EndCreateKxCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKxClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKxDatabase

        /// <summary>
        /// Creates a new kdb database in the environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxDatabase service method.</param>
        /// 
        /// <returns>The response from the CreateKxDatabase service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceAlreadyExistsException">
        /// The specified resource group already exists.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDatabase">REST API Reference for CreateKxDatabase Operation</seealso>
        public virtual CreateKxDatabaseResponse CreateKxDatabase(CreateKxDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateKxDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxDatabase operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDatabase">REST API Reference for CreateKxDatabase Operation</seealso>
        public virtual IAsyncResult BeginCreateKxDatabase(CreateKxDatabaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxDatabase.</param>
        /// 
        /// <returns>Returns a  CreateKxDatabaseResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDatabase">REST API Reference for CreateKxDatabase Operation</seealso>
        public virtual CreateKxDatabaseResponse EndCreateKxDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKxDatabaseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKxDataview

        /// <summary>
        /// Creates a snapshot of kdb database with tiered storage capabilities and a pre-warmed
        /// cache, ready for mounting on kdb clusters. Dataviews are only available for clusters
        /// running on a scaling group. They are not supported on dedicated clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxDataview service method.</param>
        /// 
        /// <returns>The response from the CreateKxDataview service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceAlreadyExistsException">
        /// The specified resource group already exists.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDataview">REST API Reference for CreateKxDataview Operation</seealso>
        public virtual CreateKxDataviewResponse CreateKxDataview(CreateKxDataviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxDataviewResponseUnmarshaller.Instance;

            return Invoke<CreateKxDataviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxDataview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxDataview operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxDataview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDataview">REST API Reference for CreateKxDataview Operation</seealso>
        public virtual IAsyncResult BeginCreateKxDataview(CreateKxDataviewRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxDataviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxDataview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxDataview.</param>
        /// 
        /// <returns>Returns a  CreateKxDataviewResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDataview">REST API Reference for CreateKxDataview Operation</seealso>
        public virtual CreateKxDataviewResponse EndCreateKxDataview(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKxDataviewResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKxEnvironment

        /// <summary>
        /// Creates a managed kdb environment for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateKxEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxEnvironment">REST API Reference for CreateKxEnvironment Operation</seealso>
        public virtual CreateKxEnvironmentResponse CreateKxEnvironment(CreateKxEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateKxEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxEnvironment">REST API Reference for CreateKxEnvironment Operation</seealso>
        public virtual IAsyncResult BeginCreateKxEnvironment(CreateKxEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateKxEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxEnvironment">REST API Reference for CreateKxEnvironment Operation</seealso>
        public virtual CreateKxEnvironmentResponse EndCreateKxEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKxEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKxScalingGroup

        /// <summary>
        /// Creates a new scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxScalingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateKxScalingGroup service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxScalingGroup">REST API Reference for CreateKxScalingGroup Operation</seealso>
        public virtual CreateKxScalingGroupResponse CreateKxScalingGroup(CreateKxScalingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxScalingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateKxScalingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxScalingGroup operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxScalingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxScalingGroup">REST API Reference for CreateKxScalingGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateKxScalingGroup(CreateKxScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxScalingGroup.</param>
        /// 
        /// <returns>Returns a  CreateKxScalingGroupResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxScalingGroup">REST API Reference for CreateKxScalingGroup Operation</seealso>
        public virtual CreateKxScalingGroupResponse EndCreateKxScalingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKxScalingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKxUser

        /// <summary>
        /// Creates a user in FinSpace kdb environment with an associated IAM role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxUser service method.</param>
        /// 
        /// <returns>The response from the CreateKxUser service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceAlreadyExistsException">
        /// The specified resource group already exists.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxUser">REST API Reference for CreateKxUser Operation</seealso>
        public virtual CreateKxUserResponse CreateKxUser(CreateKxUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxUserResponseUnmarshaller.Instance;

            return Invoke<CreateKxUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxUser operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxUser">REST API Reference for CreateKxUser Operation</seealso>
        public virtual IAsyncResult BeginCreateKxUser(CreateKxUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxUser.</param>
        /// 
        /// <returns>Returns a  CreateKxUserResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxUser">REST API Reference for CreateKxUser Operation</seealso>
        public virtual CreateKxUserResponse EndCreateKxUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKxUserResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKxVolume

        /// <summary>
        /// Creates a new volume with a specific amount of throughput and storage capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxVolume service method.</param>
        /// 
        /// <returns>The response from the CreateKxVolume service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceAlreadyExistsException">
        /// The specified resource group already exists.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxVolume">REST API Reference for CreateKxVolume Operation</seealso>
        public virtual CreateKxVolumeResponse CreateKxVolume(CreateKxVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateKxVolumeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxVolume operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxVolume">REST API Reference for CreateKxVolume Operation</seealso>
        public virtual IAsyncResult BeginCreateKxVolume(CreateKxVolumeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxVolumeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxVolume.</param>
        /// 
        /// <returns>Returns a  CreateKxVolumeResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxVolume">REST API Reference for CreateKxVolume Operation</seealso>
        public virtual CreateKxVolumeResponse EndCreateKxVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKxVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironment

        /// <summary>
        /// Delete an FinSpace environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual IAsyncResult BeginDeleteEnvironment(DeleteEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual DeleteEnvironmentResponse EndDeleteEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKxCluster

        /// <summary>
        /// Deletes a kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteKxCluster service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxCluster">REST API Reference for DeleteKxCluster Operation</seealso>
        public virtual DeleteKxClusterResponse DeleteKxCluster(DeleteKxClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteKxClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxCluster operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxCluster">REST API Reference for DeleteKxCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteKxCluster(DeleteKxClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxCluster.</param>
        /// 
        /// <returns>Returns a  DeleteKxClusterResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxCluster">REST API Reference for DeleteKxCluster Operation</seealso>
        public virtual DeleteKxClusterResponse EndDeleteKxCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKxClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKxClusterNode

        /// <summary>
        /// Deletes the specified nodes from a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxClusterNode service method.</param>
        /// 
        /// <returns>The response from the DeleteKxClusterNode service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxClusterNode">REST API Reference for DeleteKxClusterNode Operation</seealso>
        public virtual DeleteKxClusterNodeResponse DeleteKxClusterNode(DeleteKxClusterNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxClusterNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxClusterNodeResponseUnmarshaller.Instance;

            return Invoke<DeleteKxClusterNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxClusterNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxClusterNode operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxClusterNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxClusterNode">REST API Reference for DeleteKxClusterNode Operation</seealso>
        public virtual IAsyncResult BeginDeleteKxClusterNode(DeleteKxClusterNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxClusterNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxClusterNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxClusterNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxClusterNode.</param>
        /// 
        /// <returns>Returns a  DeleteKxClusterNodeResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxClusterNode">REST API Reference for DeleteKxClusterNode Operation</seealso>
        public virtual DeleteKxClusterNodeResponse EndDeleteKxClusterNode(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKxClusterNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKxDatabase

        /// <summary>
        /// Deletes the specified database and all of its associated data. This action is irreversible.
        /// You must copy any data out of the database before deleting it if the data is to be
        /// retained.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxDatabase service method.</param>
        /// 
        /// <returns>The response from the DeleteKxDatabase service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDatabase">REST API Reference for DeleteKxDatabase Operation</seealso>
        public virtual DeleteKxDatabaseResponse DeleteKxDatabase(DeleteKxDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteKxDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxDatabase operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDatabase">REST API Reference for DeleteKxDatabase Operation</seealso>
        public virtual IAsyncResult BeginDeleteKxDatabase(DeleteKxDatabaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxDatabase.</param>
        /// 
        /// <returns>Returns a  DeleteKxDatabaseResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDatabase">REST API Reference for DeleteKxDatabase Operation</seealso>
        public virtual DeleteKxDatabaseResponse EndDeleteKxDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKxDatabaseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKxDataview

        /// <summary>
        /// Deletes the specified dataview. Before deleting a dataview, make sure that it is
        /// not in use by any cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxDataview service method.</param>
        /// 
        /// <returns>The response from the DeleteKxDataview service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDataview">REST API Reference for DeleteKxDataview Operation</seealso>
        public virtual DeleteKxDataviewResponse DeleteKxDataview(DeleteKxDataviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxDataviewResponseUnmarshaller.Instance;

            return Invoke<DeleteKxDataviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxDataview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxDataview operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxDataview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDataview">REST API Reference for DeleteKxDataview Operation</seealso>
        public virtual IAsyncResult BeginDeleteKxDataview(DeleteKxDataviewRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxDataviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxDataview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxDataview.</param>
        /// 
        /// <returns>Returns a  DeleteKxDataviewResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDataview">REST API Reference for DeleteKxDataview Operation</seealso>
        public virtual DeleteKxDataviewResponse EndDeleteKxDataview(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKxDataviewResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKxEnvironment

        /// <summary>
        /// Deletes the kdb environment. This action is irreversible. Deleting a kdb environment
        /// will remove all the associated data and any services running in it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteKxEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxEnvironment">REST API Reference for DeleteKxEnvironment Operation</seealso>
        public virtual DeleteKxEnvironmentResponse DeleteKxEnvironment(DeleteKxEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteKxEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxEnvironment">REST API Reference for DeleteKxEnvironment Operation</seealso>
        public virtual IAsyncResult BeginDeleteKxEnvironment(DeleteKxEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteKxEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxEnvironment">REST API Reference for DeleteKxEnvironment Operation</seealso>
        public virtual DeleteKxEnvironmentResponse EndDeleteKxEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKxEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKxScalingGroup

        /// <summary>
        /// Deletes the specified scaling group. This action is irreversible. You cannot delete
        /// a scaling group until all the clusters running on it have been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxScalingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteKxScalingGroup service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxScalingGroup">REST API Reference for DeleteKxScalingGroup Operation</seealso>
        public virtual DeleteKxScalingGroupResponse DeleteKxScalingGroup(DeleteKxScalingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxScalingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteKxScalingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxScalingGroup operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxScalingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxScalingGroup">REST API Reference for DeleteKxScalingGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteKxScalingGroup(DeleteKxScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxScalingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteKxScalingGroupResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxScalingGroup">REST API Reference for DeleteKxScalingGroup Operation</seealso>
        public virtual DeleteKxScalingGroupResponse EndDeleteKxScalingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKxScalingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKxUser

        /// <summary>
        /// Deletes a user in the specified kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxUser service method.</param>
        /// 
        /// <returns>The response from the DeleteKxUser service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxUser">REST API Reference for DeleteKxUser Operation</seealso>
        public virtual DeleteKxUserResponse DeleteKxUser(DeleteKxUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxUserResponseUnmarshaller.Instance;

            return Invoke<DeleteKxUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxUser operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxUser">REST API Reference for DeleteKxUser Operation</seealso>
        public virtual IAsyncResult BeginDeleteKxUser(DeleteKxUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxUser.</param>
        /// 
        /// <returns>Returns a  DeleteKxUserResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxUser">REST API Reference for DeleteKxUser Operation</seealso>
        public virtual DeleteKxUserResponse EndDeleteKxUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKxUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKxVolume

        /// <summary>
        /// Deletes a volume. You can only delete a volume if it's not attached to a cluster
        /// or a dataview. When a volume is deleted, any data on the volume is lost. This action
        /// is irreversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteKxVolume service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxVolume">REST API Reference for DeleteKxVolume Operation</seealso>
        public virtual DeleteKxVolumeResponse DeleteKxVolume(DeleteKxVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteKxVolumeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxVolume operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxVolume">REST API Reference for DeleteKxVolume Operation</seealso>
        public virtual IAsyncResult BeginDeleteKxVolume(DeleteKxVolumeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxVolumeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxVolume.</param>
        /// 
        /// <returns>Returns a  DeleteKxVolumeResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxVolume">REST API Reference for DeleteKxVolume Operation</seealso>
        public virtual DeleteKxVolumeResponse EndDeleteKxVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKxVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironment

        /// <summary>
        /// Returns the FinSpace environment object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual IAsyncResult BeginGetEnvironment(GetEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironment.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual GetEnvironmentResponse EndGetEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKxChangeset

        /// <summary>
        /// Returns information about a kdb changeset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxChangeset service method.</param>
        /// 
        /// <returns>The response from the GetKxChangeset service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxChangeset">REST API Reference for GetKxChangeset Operation</seealso>
        public virtual GetKxChangesetResponse GetKxChangeset(GetKxChangesetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxChangesetResponseUnmarshaller.Instance;

            return Invoke<GetKxChangesetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxChangeset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxChangeset operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxChangeset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxChangeset">REST API Reference for GetKxChangeset Operation</seealso>
        public virtual IAsyncResult BeginGetKxChangeset(GetKxChangesetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxChangesetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxChangeset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxChangeset.</param>
        /// 
        /// <returns>Returns a  GetKxChangesetResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxChangeset">REST API Reference for GetKxChangeset Operation</seealso>
        public virtual GetKxChangesetResponse EndGetKxChangeset(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKxChangesetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKxCluster

        /// <summary>
        /// Retrieves information about a kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxCluster service method.</param>
        /// 
        /// <returns>The response from the GetKxCluster service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxCluster">REST API Reference for GetKxCluster Operation</seealso>
        public virtual GetKxClusterResponse GetKxCluster(GetKxClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxClusterResponseUnmarshaller.Instance;

            return Invoke<GetKxClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxCluster operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxCluster">REST API Reference for GetKxCluster Operation</seealso>
        public virtual IAsyncResult BeginGetKxCluster(GetKxClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxCluster.</param>
        /// 
        /// <returns>Returns a  GetKxClusterResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxCluster">REST API Reference for GetKxCluster Operation</seealso>
        public virtual GetKxClusterResponse EndGetKxCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKxClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKxConnectionString

        /// <summary>
        /// Retrieves a connection string for a user to connect to a kdb cluster. You must call
        /// this API using the same role that you have defined while creating a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxConnectionString service method.</param>
        /// 
        /// <returns>The response from the GetKxConnectionString service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxConnectionString">REST API Reference for GetKxConnectionString Operation</seealso>
        public virtual GetKxConnectionStringResponse GetKxConnectionString(GetKxConnectionStringRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxConnectionStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxConnectionStringResponseUnmarshaller.Instance;

            return Invoke<GetKxConnectionStringResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxConnectionString operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxConnectionString operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxConnectionString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxConnectionString">REST API Reference for GetKxConnectionString Operation</seealso>
        public virtual IAsyncResult BeginGetKxConnectionString(GetKxConnectionStringRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxConnectionStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxConnectionStringResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxConnectionString operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxConnectionString.</param>
        /// 
        /// <returns>Returns a  GetKxConnectionStringResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxConnectionString">REST API Reference for GetKxConnectionString Operation</seealso>
        public virtual GetKxConnectionStringResponse EndGetKxConnectionString(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKxConnectionStringResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKxDatabase

        /// <summary>
        /// Returns database information for the specified environment ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxDatabase service method.</param>
        /// 
        /// <returns>The response from the GetKxDatabase service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDatabase">REST API Reference for GetKxDatabase Operation</seealso>
        public virtual GetKxDatabaseResponse GetKxDatabase(GetKxDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetKxDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxDatabase operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDatabase">REST API Reference for GetKxDatabase Operation</seealso>
        public virtual IAsyncResult BeginGetKxDatabase(GetKxDatabaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxDatabase.</param>
        /// 
        /// <returns>Returns a  GetKxDatabaseResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDatabase">REST API Reference for GetKxDatabase Operation</seealso>
        public virtual GetKxDatabaseResponse EndGetKxDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKxDatabaseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKxDataview

        /// <summary>
        /// Retrieves details of the dataview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxDataview service method.</param>
        /// 
        /// <returns>The response from the GetKxDataview service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDataview">REST API Reference for GetKxDataview Operation</seealso>
        public virtual GetKxDataviewResponse GetKxDataview(GetKxDataviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxDataviewResponseUnmarshaller.Instance;

            return Invoke<GetKxDataviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxDataview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxDataview operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxDataview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDataview">REST API Reference for GetKxDataview Operation</seealso>
        public virtual IAsyncResult BeginGetKxDataview(GetKxDataviewRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxDataviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxDataview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxDataview.</param>
        /// 
        /// <returns>Returns a  GetKxDataviewResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDataview">REST API Reference for GetKxDataview Operation</seealso>
        public virtual GetKxDataviewResponse EndGetKxDataview(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKxDataviewResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKxEnvironment

        /// <summary>
        /// Retrieves all the information for the specified kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetKxEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxEnvironment">REST API Reference for GetKxEnvironment Operation</seealso>
        public virtual GetKxEnvironmentResponse GetKxEnvironment(GetKxEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetKxEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxEnvironment">REST API Reference for GetKxEnvironment Operation</seealso>
        public virtual IAsyncResult BeginGetKxEnvironment(GetKxEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxEnvironment.</param>
        /// 
        /// <returns>Returns a  GetKxEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxEnvironment">REST API Reference for GetKxEnvironment Operation</seealso>
        public virtual GetKxEnvironmentResponse EndGetKxEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKxEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKxScalingGroup

        /// <summary>
        /// Retrieves details of a scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxScalingGroup service method.</param>
        /// 
        /// <returns>The response from the GetKxScalingGroup service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxScalingGroup">REST API Reference for GetKxScalingGroup Operation</seealso>
        public virtual GetKxScalingGroupResponse GetKxScalingGroup(GetKxScalingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxScalingGroupResponseUnmarshaller.Instance;

            return Invoke<GetKxScalingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxScalingGroup operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxScalingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxScalingGroup">REST API Reference for GetKxScalingGroup Operation</seealso>
        public virtual IAsyncResult BeginGetKxScalingGroup(GetKxScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxScalingGroup.</param>
        /// 
        /// <returns>Returns a  GetKxScalingGroupResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxScalingGroup">REST API Reference for GetKxScalingGroup Operation</seealso>
        public virtual GetKxScalingGroupResponse EndGetKxScalingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKxScalingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKxUser

        /// <summary>
        /// Retrieves information about the specified kdb user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxUser service method.</param>
        /// 
        /// <returns>The response from the GetKxUser service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxUser">REST API Reference for GetKxUser Operation</seealso>
        public virtual GetKxUserResponse GetKxUser(GetKxUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxUserResponseUnmarshaller.Instance;

            return Invoke<GetKxUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxUser operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxUser">REST API Reference for GetKxUser Operation</seealso>
        public virtual IAsyncResult BeginGetKxUser(GetKxUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxUser.</param>
        /// 
        /// <returns>Returns a  GetKxUserResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxUser">REST API Reference for GetKxUser Operation</seealso>
        public virtual GetKxUserResponse EndGetKxUser(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKxUserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKxVolume

        /// <summary>
        /// Retrieves the information about the volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxVolume service method.</param>
        /// 
        /// <returns>The response from the GetKxVolume service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxVolume">REST API Reference for GetKxVolume Operation</seealso>
        public virtual GetKxVolumeResponse GetKxVolume(GetKxVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxVolumeResponseUnmarshaller.Instance;

            return Invoke<GetKxVolumeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxVolume operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxVolume">REST API Reference for GetKxVolume Operation</seealso>
        public virtual IAsyncResult BeginGetKxVolume(GetKxVolumeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxVolumeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxVolume.</param>
        /// 
        /// <returns>Returns a  GetKxVolumeResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxVolume">REST API Reference for GetKxVolume Operation</seealso>
        public virtual GetKxVolumeResponse EndGetKxVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKxVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironments

        /// <summary>
        /// A list of all of your FinSpace environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual IAsyncResult BeginListEnvironments(ListEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironments.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentsResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual ListEnvironmentsResponse EndListEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKxChangesets

        /// <summary>
        /// Returns a list of all the changesets for a database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxChangesets service method.</param>
        /// 
        /// <returns>The response from the ListKxChangesets service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxChangesets">REST API Reference for ListKxChangesets Operation</seealso>
        public virtual ListKxChangesetsResponse ListKxChangesets(ListKxChangesetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxChangesetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxChangesetsResponseUnmarshaller.Instance;

            return Invoke<ListKxChangesetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxChangesets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxChangesets operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxChangesets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxChangesets">REST API Reference for ListKxChangesets Operation</seealso>
        public virtual IAsyncResult BeginListKxChangesets(ListKxChangesetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxChangesetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxChangesetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxChangesets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxChangesets.</param>
        /// 
        /// <returns>Returns a  ListKxChangesetsResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxChangesets">REST API Reference for ListKxChangesets Operation</seealso>
        public virtual ListKxChangesetsResponse EndListKxChangesets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKxChangesetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKxClusterNodes

        /// <summary>
        /// Lists all the nodes in a kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxClusterNodes service method.</param>
        /// 
        /// <returns>The response from the ListKxClusterNodes service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusterNodes">REST API Reference for ListKxClusterNodes Operation</seealso>
        public virtual ListKxClusterNodesResponse ListKxClusterNodes(ListKxClusterNodesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxClusterNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxClusterNodesResponseUnmarshaller.Instance;

            return Invoke<ListKxClusterNodesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxClusterNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxClusterNodes operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxClusterNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusterNodes">REST API Reference for ListKxClusterNodes Operation</seealso>
        public virtual IAsyncResult BeginListKxClusterNodes(ListKxClusterNodesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxClusterNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxClusterNodesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxClusterNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxClusterNodes.</param>
        /// 
        /// <returns>Returns a  ListKxClusterNodesResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusterNodes">REST API Reference for ListKxClusterNodes Operation</seealso>
        public virtual ListKxClusterNodesResponse EndListKxClusterNodes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKxClusterNodesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKxClusters

        /// <summary>
        /// Returns a list of clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxClusters service method.</param>
        /// 
        /// <returns>The response from the ListKxClusters service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusters">REST API Reference for ListKxClusters Operation</seealso>
        public virtual ListKxClustersResponse ListKxClusters(ListKxClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxClustersResponseUnmarshaller.Instance;

            return Invoke<ListKxClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxClusters operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusters">REST API Reference for ListKxClusters Operation</seealso>
        public virtual IAsyncResult BeginListKxClusters(ListKxClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxClusters.</param>
        /// 
        /// <returns>Returns a  ListKxClustersResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusters">REST API Reference for ListKxClusters Operation</seealso>
        public virtual ListKxClustersResponse EndListKxClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKxClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKxDatabases

        /// <summary>
        /// Returns a list of all the databases in the kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxDatabases service method.</param>
        /// 
        /// <returns>The response from the ListKxDatabases service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDatabases">REST API Reference for ListKxDatabases Operation</seealso>
        public virtual ListKxDatabasesResponse ListKxDatabases(ListKxDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxDatabasesResponseUnmarshaller.Instance;

            return Invoke<ListKxDatabasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxDatabases operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDatabases">REST API Reference for ListKxDatabases Operation</seealso>
        public virtual IAsyncResult BeginListKxDatabases(ListKxDatabasesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxDatabasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxDatabases.</param>
        /// 
        /// <returns>Returns a  ListKxDatabasesResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDatabases">REST API Reference for ListKxDatabases Operation</seealso>
        public virtual ListKxDatabasesResponse EndListKxDatabases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKxDatabasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKxDataviews

        /// <summary>
        /// Returns a list of all the dataviews in the database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxDataviews service method.</param>
        /// 
        /// <returns>The response from the ListKxDataviews service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDataviews">REST API Reference for ListKxDataviews Operation</seealso>
        public virtual ListKxDataviewsResponse ListKxDataviews(ListKxDataviewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxDataviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxDataviewsResponseUnmarshaller.Instance;

            return Invoke<ListKxDataviewsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxDataviews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxDataviews operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxDataviews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDataviews">REST API Reference for ListKxDataviews Operation</seealso>
        public virtual IAsyncResult BeginListKxDataviews(ListKxDataviewsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxDataviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxDataviewsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxDataviews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxDataviews.</param>
        /// 
        /// <returns>Returns a  ListKxDataviewsResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDataviews">REST API Reference for ListKxDataviews Operation</seealso>
        public virtual ListKxDataviewsResponse EndListKxDataviews(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKxDataviewsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKxEnvironments

        /// <summary>
        /// Returns a list of kdb environments created in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListKxEnvironments service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxEnvironments">REST API Reference for ListKxEnvironments Operation</seealso>
        public virtual ListKxEnvironmentsResponse ListKxEnvironments(ListKxEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListKxEnvironmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxEnvironments operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxEnvironments">REST API Reference for ListKxEnvironments Operation</seealso>
        public virtual IAsyncResult BeginListKxEnvironments(ListKxEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxEnvironments.</param>
        /// 
        /// <returns>Returns a  ListKxEnvironmentsResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxEnvironments">REST API Reference for ListKxEnvironments Operation</seealso>
        public virtual ListKxEnvironmentsResponse EndListKxEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKxEnvironmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKxScalingGroups

        /// <summary>
        /// Returns a list of scaling groups in a kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxScalingGroups service method.</param>
        /// 
        /// <returns>The response from the ListKxScalingGroups service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxScalingGroups">REST API Reference for ListKxScalingGroups Operation</seealso>
        public virtual ListKxScalingGroupsResponse ListKxScalingGroups(ListKxScalingGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxScalingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxScalingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListKxScalingGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxScalingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxScalingGroups operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxScalingGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxScalingGroups">REST API Reference for ListKxScalingGroups Operation</seealso>
        public virtual IAsyncResult BeginListKxScalingGroups(ListKxScalingGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxScalingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxScalingGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxScalingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxScalingGroups.</param>
        /// 
        /// <returns>Returns a  ListKxScalingGroupsResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxScalingGroups">REST API Reference for ListKxScalingGroups Operation</seealso>
        public virtual ListKxScalingGroupsResponse EndListKxScalingGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKxScalingGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKxUsers

        /// <summary>
        /// Lists all the users in a kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxUsers service method.</param>
        /// 
        /// <returns>The response from the ListKxUsers service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxUsers">REST API Reference for ListKxUsers Operation</seealso>
        public virtual ListKxUsersResponse ListKxUsers(ListKxUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxUsersResponseUnmarshaller.Instance;

            return Invoke<ListKxUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxUsers operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxUsers">REST API Reference for ListKxUsers Operation</seealso>
        public virtual IAsyncResult BeginListKxUsers(ListKxUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxUsers.</param>
        /// 
        /// <returns>Returns a  ListKxUsersResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxUsers">REST API Reference for ListKxUsers Operation</seealso>
        public virtual ListKxUsersResponse EndListKxUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKxUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKxVolumes

        /// <summary>
        /// Lists all the volumes in a kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxVolumes service method.</param>
        /// 
        /// <returns>The response from the ListKxVolumes service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxVolumes">REST API Reference for ListKxVolumes Operation</seealso>
        public virtual ListKxVolumesResponse ListKxVolumes(ListKxVolumesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxVolumesResponseUnmarshaller.Instance;

            return Invoke<ListKxVolumesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxVolumes operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxVolumes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxVolumes">REST API Reference for ListKxVolumes Operation</seealso>
        public virtual IAsyncResult BeginListKxVolumes(ListKxVolumesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxVolumesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxVolumes.</param>
        /// 
        /// <returns>Returns a  ListKxVolumesResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxVolumes">REST API Reference for ListKxVolumes Operation</seealso>
        public virtual ListKxVolumesResponse EndListKxVolumes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKxVolumesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// A list of all tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InvalidRequestException">
        /// The request is invalid. Something is wrong with the input to the request.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds metadata tags to a FinSpace resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InvalidRequestException">
        /// The request is invalid. Something is wrong with the input to the request.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes metadata tags from a FinSpace resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InvalidRequestException">
        /// The request is invalid. Something is wrong with the input to the request.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnvironment

        /// <summary>
        /// Update your FinSpace environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        public virtual UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKxClusterCodeConfiguration

        /// <summary>
        /// Allows you to update code configuration on a running cluster. By using this API you
        /// can update the code, the initialization script path, and the command line arguments
        /// for a specific cluster. The configuration that you want to update will override any
        /// existing configurations on the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxClusterCodeConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateKxClusterCodeConfiguration service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterCodeConfiguration">REST API Reference for UpdateKxClusterCodeConfiguration Operation</seealso>
        public virtual UpdateKxClusterCodeConfigurationResponse UpdateKxClusterCodeConfiguration(UpdateKxClusterCodeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxClusterCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxClusterCodeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateKxClusterCodeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxClusterCodeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxClusterCodeConfiguration operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxClusterCodeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterCodeConfiguration">REST API Reference for UpdateKxClusterCodeConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateKxClusterCodeConfiguration(UpdateKxClusterCodeConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxClusterCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxClusterCodeConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxClusterCodeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxClusterCodeConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateKxClusterCodeConfigurationResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterCodeConfiguration">REST API Reference for UpdateKxClusterCodeConfiguration Operation</seealso>
        public virtual UpdateKxClusterCodeConfigurationResponse EndUpdateKxClusterCodeConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKxClusterCodeConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKxClusterDatabases

        /// <summary>
        /// Updates the databases mounted on a kdb cluster, which includes the <c>changesetId</c>
        /// and all the dbPaths to be cached. This API does not allow you to change a database
        /// name or add a database if you created a cluster without one. 
        /// 
        ///  
        /// <para>
        /// Using this API you can point a cluster to a different changeset and modify a list
        /// of partitions being cached.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxClusterDatabases service method.</param>
        /// 
        /// <returns>The response from the UpdateKxClusterDatabases service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterDatabases">REST API Reference for UpdateKxClusterDatabases Operation</seealso>
        public virtual UpdateKxClusterDatabasesResponse UpdateKxClusterDatabases(UpdateKxClusterDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxClusterDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxClusterDatabasesResponseUnmarshaller.Instance;

            return Invoke<UpdateKxClusterDatabasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxClusterDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxClusterDatabases operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxClusterDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterDatabases">REST API Reference for UpdateKxClusterDatabases Operation</seealso>
        public virtual IAsyncResult BeginUpdateKxClusterDatabases(UpdateKxClusterDatabasesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxClusterDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxClusterDatabasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxClusterDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxClusterDatabases.</param>
        /// 
        /// <returns>Returns a  UpdateKxClusterDatabasesResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterDatabases">REST API Reference for UpdateKxClusterDatabases Operation</seealso>
        public virtual UpdateKxClusterDatabasesResponse EndUpdateKxClusterDatabases(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKxClusterDatabasesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKxDatabase

        /// <summary>
        /// Updates information for the given kdb database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxDatabase service method.</param>
        /// 
        /// <returns>The response from the UpdateKxDatabase service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDatabase">REST API Reference for UpdateKxDatabase Operation</seealso>
        public virtual UpdateKxDatabaseResponse UpdateKxDatabase(UpdateKxDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxDatabaseResponseUnmarshaller.Instance;

            return Invoke<UpdateKxDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxDatabase operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDatabase">REST API Reference for UpdateKxDatabase Operation</seealso>
        public virtual IAsyncResult BeginUpdateKxDatabase(UpdateKxDatabaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxDatabase.</param>
        /// 
        /// <returns>Returns a  UpdateKxDatabaseResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDatabase">REST API Reference for UpdateKxDatabase Operation</seealso>
        public virtual UpdateKxDatabaseResponse EndUpdateKxDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKxDatabaseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKxDataview

        /// <summary>
        /// Updates the specified dataview. The dataviews get automatically updated when any
        /// new changesets are ingested. Each update of the dataview creates a new version, including
        /// changeset details and cache configurations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxDataview service method.</param>
        /// 
        /// <returns>The response from the UpdateKxDataview service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceAlreadyExistsException">
        /// The specified resource group already exists.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDataview">REST API Reference for UpdateKxDataview Operation</seealso>
        public virtual UpdateKxDataviewResponse UpdateKxDataview(UpdateKxDataviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxDataviewResponseUnmarshaller.Instance;

            return Invoke<UpdateKxDataviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxDataview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxDataview operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxDataview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDataview">REST API Reference for UpdateKxDataview Operation</seealso>
        public virtual IAsyncResult BeginUpdateKxDataview(UpdateKxDataviewRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxDataviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxDataview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxDataview.</param>
        /// 
        /// <returns>Returns a  UpdateKxDataviewResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDataview">REST API Reference for UpdateKxDataview Operation</seealso>
        public virtual UpdateKxDataviewResponse EndUpdateKxDataview(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKxDataviewResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKxEnvironment

        /// <summary>
        /// Updates information for the given kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateKxEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironment">REST API Reference for UpdateKxEnvironment Operation</seealso>
        public virtual UpdateKxEnvironmentResponse UpdateKxEnvironment(UpdateKxEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateKxEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironment">REST API Reference for UpdateKxEnvironment Operation</seealso>
        public virtual IAsyncResult BeginUpdateKxEnvironment(UpdateKxEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateKxEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironment">REST API Reference for UpdateKxEnvironment Operation</seealso>
        public virtual UpdateKxEnvironmentResponse EndUpdateKxEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKxEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKxEnvironmentNetwork

        /// <summary>
        /// Updates environment network to connect to your internal network by using a transit
        /// gateway. This API supports request to create a transit gateway attachment from FinSpace
        /// VPC to your transit gateway ID and create a custom Route-53 outbound resolvers.
        /// 
        ///  
        /// <para>
        /// Once you send a request to update a network, you cannot change it again. Network update
        /// might require termination of any clusters that are running in the existing network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxEnvironmentNetwork service method.</param>
        /// 
        /// <returns>The response from the UpdateKxEnvironmentNetwork service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironmentNetwork">REST API Reference for UpdateKxEnvironmentNetwork Operation</seealso>
        public virtual UpdateKxEnvironmentNetworkResponse UpdateKxEnvironmentNetwork(UpdateKxEnvironmentNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxEnvironmentNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxEnvironmentNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateKxEnvironmentNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxEnvironmentNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxEnvironmentNetwork operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxEnvironmentNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironmentNetwork">REST API Reference for UpdateKxEnvironmentNetwork Operation</seealso>
        public virtual IAsyncResult BeginUpdateKxEnvironmentNetwork(UpdateKxEnvironmentNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxEnvironmentNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxEnvironmentNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxEnvironmentNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxEnvironmentNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateKxEnvironmentNetworkResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironmentNetwork">REST API Reference for UpdateKxEnvironmentNetwork Operation</seealso>
        public virtual UpdateKxEnvironmentNetworkResponse EndUpdateKxEnvironmentNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKxEnvironmentNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKxUser

        /// <summary>
        /// Updates the user details. You can only update the IAM role associated with a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxUser service method.</param>
        /// 
        /// <returns>The response from the UpdateKxUser service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxUser">REST API Reference for UpdateKxUser Operation</seealso>
        public virtual UpdateKxUserResponse UpdateKxUser(UpdateKxUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxUserResponseUnmarshaller.Instance;

            return Invoke<UpdateKxUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxUser operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxUser">REST API Reference for UpdateKxUser Operation</seealso>
        public virtual IAsyncResult BeginUpdateKxUser(UpdateKxUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxUser.</param>
        /// 
        /// <returns>Returns a  UpdateKxUserResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxUser">REST API Reference for UpdateKxUser Operation</seealso>
        public virtual UpdateKxUserResponse EndUpdateKxUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKxUserResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKxVolume

        /// <summary>
        /// Updates the throughput or capacity of a volume. During the update process, the filesystem
        /// might be unavailable for a few minutes. You can retry any operations after the update
        /// is complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxVolume service method.</param>
        /// 
        /// <returns>The response from the UpdateKxVolume service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxVolume">REST API Reference for UpdateKxVolume Operation</seealso>
        public virtual UpdateKxVolumeResponse UpdateKxVolume(UpdateKxVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxVolumeResponseUnmarshaller.Instance;

            return Invoke<UpdateKxVolumeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxVolume operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxVolume">REST API Reference for UpdateKxVolume Operation</seealso>
        public virtual IAsyncResult BeginUpdateKxVolume(UpdateKxVolumeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxVolumeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxVolume.</param>
        /// 
        /// <returns>Returns a  UpdateKxVolumeResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxVolume">REST API Reference for UpdateKxVolume Operation</seealso>
        public virtual UpdateKxVolumeResponse EndUpdateKxVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKxVolumeResponse>(asyncResult);
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
            var resolver = new AmazonFinspaceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}