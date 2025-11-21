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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Finspace.Model;
using Amazon.Finspace.Model.Internal.MarshallTransformations;
using Amazon.Finspace.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

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
            : base(new AmazonFinspaceConfig()) { }

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
            : base(new AmazonFinspaceConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonFinspaceEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonFinspaceAuthSchemeHandler());
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

        [Obsolete("This method will be discontinued.")]
        internal virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Create a new FinSpace environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKxChangeset

        internal virtual CreateKxChangesetResponse CreateKxChangeset(CreateKxChangesetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxChangesetResponseUnmarshaller.Instance;

            return Invoke<CreateKxChangesetResponse>(request, options);
        }



        /// <summary>
        /// Creates a changeset for a kdb database. A changeset allows you to add and delete
        /// existing files by using an ordered list of change requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxChangeset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateKxChangesetResponse> CreateKxChangesetAsync(CreateKxChangesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxChangesetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKxChangesetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKxCluster

        internal virtual CreateKxClusterResponse CreateKxCluster(CreateKxClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxClusterResponseUnmarshaller.Instance;

            return Invoke<CreateKxClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a new kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateKxClusterResponse> CreateKxClusterAsync(CreateKxClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKxClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKxDatabase

        internal virtual CreateKxDatabaseResponse CreateKxDatabase(CreateKxDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateKxDatabaseResponse>(request, options);
        }



        /// <summary>
        /// Creates a new kdb database in the environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateKxDatabaseResponse> CreateKxDatabaseAsync(CreateKxDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKxDatabaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKxDataview

        internal virtual CreateKxDataviewResponse CreateKxDataview(CreateKxDataviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxDataviewResponseUnmarshaller.Instance;

            return Invoke<CreateKxDataviewResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of kdb database with tiered storage capabilities and a pre-warmed
        /// cache, ready for mounting on kdb clusters. Dataviews are only available for clusters
        /// running on a scaling group. They are not supported on dedicated clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxDataview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateKxDataviewResponse> CreateKxDataviewAsync(CreateKxDataviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxDataviewResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKxDataviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKxEnvironment

        internal virtual CreateKxEnvironmentResponse CreateKxEnvironment(CreateKxEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateKxEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Creates a managed kdb environment for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateKxEnvironmentResponse> CreateKxEnvironmentAsync(CreateKxEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKxEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKxScalingGroup

        internal virtual CreateKxScalingGroupResponse CreateKxScalingGroup(CreateKxScalingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxScalingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateKxScalingGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateKxScalingGroupResponse> CreateKxScalingGroupAsync(CreateKxScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKxScalingGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKxUser

        internal virtual CreateKxUserResponse CreateKxUser(CreateKxUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxUserResponseUnmarshaller.Instance;

            return Invoke<CreateKxUserResponse>(request, options);
        }



        /// <summary>
        /// Creates a user in FinSpace kdb environment with an associated IAM role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateKxUserResponse> CreateKxUserAsync(CreateKxUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKxUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKxVolume

        internal virtual CreateKxVolumeResponse CreateKxVolume(CreateKxVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateKxVolumeResponse>(request, options);
        }



        /// <summary>
        /// Creates a new volume with a specific amount of throughput and storage capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateKxVolumeResponse> CreateKxVolumeAsync(CreateKxVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKxVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKxVolumeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEnvironment

        [Obsolete("This method will be discontinued.")]
        internal virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Delete an FinSpace environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKxCluster

        internal virtual DeleteKxClusterResponse DeleteKxCluster(DeleteKxClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteKxClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteKxClusterResponse> DeleteKxClusterAsync(DeleteKxClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKxClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKxClusterNode

        internal virtual DeleteKxClusterNodeResponse DeleteKxClusterNode(DeleteKxClusterNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxClusterNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxClusterNodeResponseUnmarshaller.Instance;

            return Invoke<DeleteKxClusterNodeResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified nodes from a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxClusterNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteKxClusterNodeResponse> DeleteKxClusterNodeAsync(DeleteKxClusterNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxClusterNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxClusterNodeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKxClusterNodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKxDatabase

        internal virtual DeleteKxDatabaseResponse DeleteKxDatabase(DeleteKxDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteKxDatabaseResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified database and all of its associated data. This action is irreversible.
        /// You must copy any data out of the database before deleting it if the data is to be
        /// retained.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteKxDatabaseResponse> DeleteKxDatabaseAsync(DeleteKxDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKxDatabaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKxDataview

        internal virtual DeleteKxDataviewResponse DeleteKxDataview(DeleteKxDataviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxDataviewResponseUnmarshaller.Instance;

            return Invoke<DeleteKxDataviewResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified dataview. Before deleting a dataview, make sure that it is
        /// not in use by any cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxDataview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteKxDataviewResponse> DeleteKxDataviewAsync(DeleteKxDataviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxDataviewResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKxDataviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKxEnvironment

        internal virtual DeleteKxEnvironmentResponse DeleteKxEnvironment(DeleteKxEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteKxEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes the kdb environment. This action is irreversible. Deleting a kdb environment
        /// will remove all the associated data and any services running in it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteKxEnvironmentResponse> DeleteKxEnvironmentAsync(DeleteKxEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKxEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKxScalingGroup

        internal virtual DeleteKxScalingGroupResponse DeleteKxScalingGroup(DeleteKxScalingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxScalingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteKxScalingGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified scaling group. This action is irreversible. You cannot delete
        /// a scaling group until all the clusters running on it have been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteKxScalingGroupResponse> DeleteKxScalingGroupAsync(DeleteKxScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKxScalingGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKxUser

        internal virtual DeleteKxUserResponse DeleteKxUser(DeleteKxUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxUserResponseUnmarshaller.Instance;

            return Invoke<DeleteKxUserResponse>(request, options);
        }



        /// <summary>
        /// Deletes a user in the specified kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteKxUserResponse> DeleteKxUserAsync(DeleteKxUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKxUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKxVolume

        internal virtual DeleteKxVolumeResponse DeleteKxVolume(DeleteKxVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteKxVolumeResponse>(request, options);
        }



        /// <summary>
        /// Deletes a volume. You can only delete a volume if it's not attached to a cluster
        /// or a dataview. When a volume is deleted, any data on the volume is lost. This action
        /// is irreversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteKxVolumeResponse> DeleteKxVolumeAsync(DeleteKxVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKxVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKxVolumeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnvironment

        [Obsolete("This method will be discontinued.")]
        internal virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Returns the FinSpace environment object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKxChangeset

        internal virtual GetKxChangesetResponse GetKxChangeset(GetKxChangesetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxChangesetResponseUnmarshaller.Instance;

            return Invoke<GetKxChangesetResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a kdb changeset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxChangeset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetKxChangesetResponse> GetKxChangesetAsync(GetKxChangesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxChangesetResponseUnmarshaller.Instance;

            return InvokeAsync<GetKxChangesetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKxCluster

        internal virtual GetKxClusterResponse GetKxCluster(GetKxClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxClusterResponseUnmarshaller.Instance;

            return Invoke<GetKxClusterResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetKxClusterResponse> GetKxClusterAsync(GetKxClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxClusterResponseUnmarshaller.Instance;

            return InvokeAsync<GetKxClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKxConnectionString

        internal virtual GetKxConnectionStringResponse GetKxConnectionString(GetKxConnectionStringRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxConnectionStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxConnectionStringResponseUnmarshaller.Instance;

            return Invoke<GetKxConnectionStringResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a connection string for a user to connect to a kdb cluster. You must call
        /// this API using the same role that you have defined while creating a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxConnectionString service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetKxConnectionStringResponse> GetKxConnectionStringAsync(GetKxConnectionStringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxConnectionStringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxConnectionStringResponseUnmarshaller.Instance;

            return InvokeAsync<GetKxConnectionStringResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKxDatabase

        internal virtual GetKxDatabaseResponse GetKxDatabase(GetKxDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetKxDatabaseResponse>(request, options);
        }



        /// <summary>
        /// Returns database information for the specified environment ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetKxDatabaseResponse> GetKxDatabaseAsync(GetKxDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetKxDatabaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKxDataview

        internal virtual GetKxDataviewResponse GetKxDataview(GetKxDataviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxDataviewResponseUnmarshaller.Instance;

            return Invoke<GetKxDataviewResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details of the dataview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxDataview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetKxDataviewResponse> GetKxDataviewAsync(GetKxDataviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxDataviewResponseUnmarshaller.Instance;

            return InvokeAsync<GetKxDataviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKxEnvironment

        internal virtual GetKxEnvironmentResponse GetKxEnvironment(GetKxEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetKxEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all the information for the specified kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetKxEnvironmentResponse> GetKxEnvironmentAsync(GetKxEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetKxEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKxScalingGroup

        internal virtual GetKxScalingGroupResponse GetKxScalingGroup(GetKxScalingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxScalingGroupResponseUnmarshaller.Instance;

            return Invoke<GetKxScalingGroupResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details of a scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetKxScalingGroupResponse> GetKxScalingGroupAsync(GetKxScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetKxScalingGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKxUser

        internal virtual GetKxUserResponse GetKxUser(GetKxUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxUserResponseUnmarshaller.Instance;

            return Invoke<GetKxUserResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the specified kdb user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetKxUserResponse> GetKxUserAsync(GetKxUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxUserResponseUnmarshaller.Instance;

            return InvokeAsync<GetKxUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKxVolume

        internal virtual GetKxVolumeResponse GetKxVolume(GetKxVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxVolumeResponseUnmarshaller.Instance;

            return Invoke<GetKxVolumeResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the information about the volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetKxVolumeResponse> GetKxVolumeAsync(GetKxVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKxVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<GetKxVolumeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEnvironments

        [Obsolete("This method will be discontinued.")]
        internal virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }



        /// <summary>
        /// A list of all of your FinSpace environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKxChangesets

        internal virtual ListKxChangesetsResponse ListKxChangesets(ListKxChangesetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxChangesetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxChangesetsResponseUnmarshaller.Instance;

            return Invoke<ListKxChangesetsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the changesets for a database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxChangesets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListKxChangesetsResponse> ListKxChangesetsAsync(ListKxChangesetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxChangesetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxChangesetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListKxChangesetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKxClusterNodes

        internal virtual ListKxClusterNodesResponse ListKxClusterNodes(ListKxClusterNodesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxClusterNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxClusterNodesResponseUnmarshaller.Instance;

            return Invoke<ListKxClusterNodesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the nodes in a kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxClusterNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListKxClusterNodesResponse> ListKxClusterNodesAsync(ListKxClusterNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxClusterNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxClusterNodesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKxClusterNodesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKxClusters

        internal virtual ListKxClustersResponse ListKxClusters(ListKxClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxClustersResponseUnmarshaller.Instance;

            return Invoke<ListKxClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListKxClustersResponse> ListKxClustersAsync(ListKxClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListKxClustersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKxDatabases

        internal virtual ListKxDatabasesResponse ListKxDatabases(ListKxDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxDatabasesResponseUnmarshaller.Instance;

            return Invoke<ListKxDatabasesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the databases in the kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListKxDatabasesResponse> ListKxDatabasesAsync(ListKxDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxDatabasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKxDatabasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKxDataviews

        internal virtual ListKxDataviewsResponse ListKxDataviews(ListKxDataviewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxDataviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxDataviewsResponseUnmarshaller.Instance;

            return Invoke<ListKxDataviewsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the dataviews in the database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxDataviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListKxDataviewsResponse> ListKxDataviewsAsync(ListKxDataviewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxDataviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxDataviewsResponseUnmarshaller.Instance;

            return InvokeAsync<ListKxDataviewsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKxEnvironments

        internal virtual ListKxEnvironmentsResponse ListKxEnvironments(ListKxEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListKxEnvironmentsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of kdb environments created in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListKxEnvironmentsResponse> ListKxEnvironmentsAsync(ListKxEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListKxEnvironmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKxScalingGroups

        internal virtual ListKxScalingGroupsResponse ListKxScalingGroups(ListKxScalingGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxScalingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxScalingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListKxScalingGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of scaling groups in a kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxScalingGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListKxScalingGroupsResponse> ListKxScalingGroupsAsync(ListKxScalingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxScalingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxScalingGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListKxScalingGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKxUsers

        internal virtual ListKxUsersResponse ListKxUsers(ListKxUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxUsersResponseUnmarshaller.Instance;

            return Invoke<ListKxUsersResponse>(request, options);
        }



        /// <summary>
        /// Lists all the users in a kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListKxUsersResponse> ListKxUsersAsync(ListKxUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListKxUsersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKxVolumes

        internal virtual ListKxVolumesResponse ListKxVolumes(ListKxVolumesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxVolumesResponseUnmarshaller.Instance;

            return Invoke<ListKxVolumesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the volumes in a kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxVolumes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListKxVolumesResponse> ListKxVolumesAsync(ListKxVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKxVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKxVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKxVolumesResponse>(request, options, cancellationToken);
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
        /// A list of all tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Adds metadata tags to a FinSpace resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Removes metadata tags from a FinSpace resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEnvironment

        [Obsolete("This method will be discontinued.")]
        internal virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Update your FinSpace environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKxClusterCodeConfiguration

        internal virtual UpdateKxClusterCodeConfigurationResponse UpdateKxClusterCodeConfiguration(UpdateKxClusterCodeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxClusterCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxClusterCodeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateKxClusterCodeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Allows you to update code configuration on a running cluster. By using this API you
        /// can update the code, the initialization script path, and the command line arguments
        /// for a specific cluster. The configuration that you want to update will override any
        /// existing configurations on the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxClusterCodeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateKxClusterCodeConfigurationResponse> UpdateKxClusterCodeConfigurationAsync(UpdateKxClusterCodeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxClusterCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxClusterCodeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKxClusterCodeConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKxClusterDatabases

        internal virtual UpdateKxClusterDatabasesResponse UpdateKxClusterDatabases(UpdateKxClusterDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxClusterDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxClusterDatabasesResponseUnmarshaller.Instance;

            return Invoke<UpdateKxClusterDatabasesResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateKxClusterDatabasesResponse> UpdateKxClusterDatabasesAsync(UpdateKxClusterDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxClusterDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxClusterDatabasesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKxClusterDatabasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKxDatabase

        internal virtual UpdateKxDatabaseResponse UpdateKxDatabase(UpdateKxDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxDatabaseResponseUnmarshaller.Instance;

            return Invoke<UpdateKxDatabaseResponse>(request, options);
        }



        /// <summary>
        /// Updates information for the given kdb database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateKxDatabaseResponse> UpdateKxDatabaseAsync(UpdateKxDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKxDatabaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKxDataview

        internal virtual UpdateKxDataviewResponse UpdateKxDataview(UpdateKxDataviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxDataviewResponseUnmarshaller.Instance;

            return Invoke<UpdateKxDataviewResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified dataview. The dataviews get automatically updated when any
        /// new changesets are ingested. Each update of the dataview creates a new version, including
        /// changeset details and cache configurations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxDataview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateKxDataviewResponse> UpdateKxDataviewAsync(UpdateKxDataviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxDataviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxDataviewResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKxDataviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKxEnvironment

        internal virtual UpdateKxEnvironmentResponse UpdateKxEnvironment(UpdateKxEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateKxEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Updates information for the given kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateKxEnvironmentResponse> UpdateKxEnvironmentAsync(UpdateKxEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKxEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKxEnvironmentNetwork

        internal virtual UpdateKxEnvironmentNetworkResponse UpdateKxEnvironmentNetwork(UpdateKxEnvironmentNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxEnvironmentNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxEnvironmentNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateKxEnvironmentNetworkResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateKxEnvironmentNetworkResponse> UpdateKxEnvironmentNetworkAsync(UpdateKxEnvironmentNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxEnvironmentNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxEnvironmentNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKxEnvironmentNetworkResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKxUser

        internal virtual UpdateKxUserResponse UpdateKxUser(UpdateKxUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxUserResponseUnmarshaller.Instance;

            return Invoke<UpdateKxUserResponse>(request, options);
        }



        /// <summary>
        /// Updates the user details. You can only update the IAM role associated with a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateKxUserResponse> UpdateKxUserAsync(UpdateKxUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKxUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKxVolume

        internal virtual UpdateKxVolumeResponse UpdateKxVolume(UpdateKxVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxVolumeResponseUnmarshaller.Instance;

            return Invoke<UpdateKxVolumeResponse>(request, options);
        }



        /// <summary>
        /// Updates the throughput or capacity of a volume. During the update process, the filesystem
        /// might be unavailable for a few minutes. You can retry any operations after the update
        /// is complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateKxVolumeResponse> UpdateKxVolumeAsync(UpdateKxVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKxVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKxVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKxVolumeResponse>(request, options, cancellationToken);
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