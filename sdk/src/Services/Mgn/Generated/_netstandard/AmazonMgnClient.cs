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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Mgn.Model;
using Amazon.Mgn.Model.Internal.MarshallTransformations;
using Amazon.Mgn.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Mgn
{
    /// <summary>
    /// Implementation for accessing Mgn
    ///
    /// The Application Migration Service service.
    /// </summary>
    public partial class AmazonMgnClient : AmazonServiceClient, IAmazonMgn
    {
        private static IServiceMetadata serviceMetadata = new AmazonMgnMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMgnClient with the credentials loaded from the application's
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
        public AmazonMgnClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMgnConfig()) { }

        /// <summary>
        /// Constructs AmazonMgnClient with the credentials loaded from the application's
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
        public AmazonMgnClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMgnConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMgnClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMgnClient Configuration Object</param>
        public AmazonMgnClient(AmazonMgnConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonMgnClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMgnClient(AWSCredentials credentials)
            : this(credentials, new AmazonMgnConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMgnClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMgnConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Credentials and an
        /// AmazonMgnClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMgnClient Configuration Object</param>
        public AmazonMgnClient(AWSCredentials credentials, AmazonMgnConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMgnConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMgnConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMgnClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMgnClient Configuration Object</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMgnConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMgnConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMgnConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMgnClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMgnClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMgnClient Configuration Object</param>
        public AmazonMgnClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMgnConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMgnPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMgnPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MgnPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMgnEndpointResolver());
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


        #region  ArchiveApplication

        internal virtual ArchiveApplicationResponse ArchiveApplication(ArchiveApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ArchiveApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ArchiveApplicationResponseUnmarshaller.Instance;

            return Invoke<ArchiveApplicationResponse>(request, options);
        }



        /// <summary>
        /// Archive application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ArchiveApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveApplication">REST API Reference for ArchiveApplication Operation</seealso>
        public virtual Task<ArchiveApplicationResponse> ArchiveApplicationAsync(ArchiveApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ArchiveApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ArchiveApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<ArchiveApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ArchiveWave

        internal virtual ArchiveWaveResponse ArchiveWave(ArchiveWaveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ArchiveWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ArchiveWaveResponseUnmarshaller.Instance;

            return Invoke<ArchiveWaveResponse>(request, options);
        }



        /// <summary>
        /// Archive wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveWave service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ArchiveWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveWave">REST API Reference for ArchiveWave Operation</seealso>
        public virtual Task<ArchiveWaveResponse> ArchiveWaveAsync(ArchiveWaveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ArchiveWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ArchiveWaveResponseUnmarshaller.Instance;

            return InvokeAsync<ArchiveWaveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateApplications

        internal virtual AssociateApplicationsResponse AssociateApplications(AssociateApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApplicationsResponseUnmarshaller.Instance;

            return Invoke<AssociateApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Associate applications to wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        public virtual Task<AssociateApplicationsResponse> AssociateApplicationsAsync(AssociateApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateSourceServers

        internal virtual AssociateSourceServersResponse AssociateSourceServers(AssociateSourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSourceServersResponseUnmarshaller.Instance;

            return Invoke<AssociateSourceServersResponse>(request, options);
        }



        /// <summary>
        /// Associate source servers to application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateSourceServers">REST API Reference for AssociateSourceServers Operation</seealso>
        public virtual Task<AssociateSourceServersResponse> AssociateSourceServersAsync(AssociateSourceServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSourceServersResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSourceServersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ChangeServerLifeCycleState

        internal virtual ChangeServerLifeCycleStateResponse ChangeServerLifeCycleState(ChangeServerLifeCycleStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeServerLifeCycleStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeServerLifeCycleStateResponseUnmarshaller.Instance;

            return Invoke<ChangeServerLifeCycleStateResponse>(request, options);
        }



        /// <summary>
        /// Allows the user to set the SourceServer.LifeCycle.state property for specific Source
        /// Server IDs to one of the following: READY_FOR_TEST or READY_FOR_CUTOVER. This command
        /// only works if the Source Server is already launchable (dataReplicationInfo.lagDuration
        /// is not null.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeServerLifeCycleState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeServerLifeCycleState service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ChangeServerLifeCycleState">REST API Reference for ChangeServerLifeCycleState Operation</seealso>
        public virtual Task<ChangeServerLifeCycleStateResponse> ChangeServerLifeCycleStateAsync(ChangeServerLifeCycleStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeServerLifeCycleStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeServerLifeCycleStateResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeServerLifeCycleStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Create application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchConfigurationTemplate

        internal virtual CreateLaunchConfigurationTemplateResponse CreateLaunchConfigurationTemplate(CreateLaunchConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchConfigurationTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Launch Configuration Template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        public virtual Task<CreateLaunchConfigurationTemplateResponse> CreateLaunchConfigurationTemplateAsync(CreateLaunchConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLaunchConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationConfigurationTemplate

        internal virtual CreateReplicationConfigurationTemplateResponse CreateReplicationConfigurationTemplate(CreateReplicationConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationConfigurationTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a new ReplicationConfigurationTemplate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        public virtual Task<CreateReplicationConfigurationTemplateResponse> CreateReplicationConfigurationTemplateAsync(CreateReplicationConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReplicationConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWave

        internal virtual CreateWaveResponse CreateWave(CreateWaveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWaveResponseUnmarshaller.Instance;

            return Invoke<CreateWaveResponse>(request, options);
        }



        /// <summary>
        /// Create wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWave service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateWave">REST API Reference for CreateWave Operation</seealso>
        public virtual Task<CreateWaveResponse> CreateWaveAsync(CreateWaveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWaveResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWaveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }



        /// <summary>
        /// Delete application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJob

        internal virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }



        /// <summary>
        /// Deletes a single Job by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLaunchConfigurationTemplate

        internal virtual DeleteLaunchConfigurationTemplateResponse DeleteLaunchConfigurationTemplate(DeleteLaunchConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchConfigurationTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a single Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        public virtual Task<DeleteLaunchConfigurationTemplateResponse> DeleteLaunchConfigurationTemplateAsync(DeleteLaunchConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLaunchConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationConfigurationTemplate

        internal virtual DeleteReplicationConfigurationTemplateResponse DeleteReplicationConfigurationTemplate(DeleteReplicationConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationConfigurationTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a single Replication Configuration Template by ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        public virtual Task<DeleteReplicationConfigurationTemplateResponse> DeleteReplicationConfigurationTemplateAsync(DeleteReplicationConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReplicationConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSourceServer

        internal virtual DeleteSourceServerResponse DeleteSourceServer(DeleteSourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceServerResponseUnmarshaller.Instance;

            return Invoke<DeleteSourceServerResponse>(request, options);
        }



        /// <summary>
        /// Deletes a single source server by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSourceServer service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        public virtual Task<DeleteSourceServerResponse> DeleteSourceServerAsync(DeleteSourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceServerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSourceServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVcenterClient

        internal virtual DeleteVcenterClientResponse DeleteVcenterClient(DeleteVcenterClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVcenterClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVcenterClientResponseUnmarshaller.Instance;

            return Invoke<DeleteVcenterClientResponse>(request, options);
        }



        /// <summary>
        /// Deletes a given vCenter client by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVcenterClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVcenterClient service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteVcenterClient">REST API Reference for DeleteVcenterClient Operation</seealso>
        public virtual Task<DeleteVcenterClientResponse> DeleteVcenterClientAsync(DeleteVcenterClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVcenterClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVcenterClientResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVcenterClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWave

        internal virtual DeleteWaveResponse DeleteWave(DeleteWaveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWaveResponseUnmarshaller.Instance;

            return Invoke<DeleteWaveResponse>(request, options);
        }



        /// <summary>
        /// Delete wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWave service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteWave">REST API Reference for DeleteWave Operation</seealso>
        public virtual Task<DeleteWaveResponse> DeleteWaveAsync(DeleteWaveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWaveResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWaveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobLogItems

        internal virtual DescribeJobLogItemsResponse DescribeJobLogItems(DescribeJobLogItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobLogItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobLogItemsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobLogItemsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed job log items with paging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobLogItems service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        public virtual Task<DescribeJobLogItemsResponse> DescribeJobLogItemsAsync(DescribeJobLogItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobLogItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobLogItemsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobLogItemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobs

        internal virtual DescribeJobsResponse DescribeJobs(DescribeJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of Jobs. Use the JobsID and fromDate and toData filters to limit which
        /// jobs are returned. The response is sorted by creationDataTime - latest date first.
        /// Jobs are normally created by the StartTest, StartCutover, and TerminateTargetInstances
        /// APIs. Jobs are also created by DiagnosticLaunch and TerminateDiagnosticInstances,
        /// which are APIs available only to *Support* and only used in response to relevant support
        /// tickets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual Task<DescribeJobsResponse> DescribeJobsAsync(DescribeJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchConfigurationTemplates

        internal virtual DescribeLaunchConfigurationTemplatesResponse DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchConfigurationTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchConfigurationTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists all Launch Configuration Templates, filtered by Launch Configuration Template
        /// IDs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurationTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurationTemplates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        public virtual Task<DescribeLaunchConfigurationTemplatesResponse> DescribeLaunchConfigurationTemplatesAsync(DescribeLaunchConfigurationTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchConfigurationTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLaunchConfigurationTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationConfigurationTemplates

        internal virtual DescribeReplicationConfigurationTemplatesResponse DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigurationTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationConfigurationTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists all ReplicationConfigurationTemplates, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationConfigurationTemplates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        public virtual Task<DescribeReplicationConfigurationTemplatesResponse> DescribeReplicationConfigurationTemplatesAsync(DescribeReplicationConfigurationTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigurationTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReplicationConfigurationTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSourceServers

        internal virtual DescribeSourceServersResponse DescribeSourceServers(DescribeSourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceServersResponseUnmarshaller.Instance;

            return Invoke<DescribeSourceServersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all SourceServers or multiple SourceServers by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        public virtual Task<DescribeSourceServersResponse> DescribeSourceServersAsync(DescribeSourceServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceServersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSourceServersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVcenterClients

        internal virtual DescribeVcenterClientsResponse DescribeVcenterClients(DescribeVcenterClientsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVcenterClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVcenterClientsResponseUnmarshaller.Instance;

            return Invoke<DescribeVcenterClientsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the installed vCenter clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVcenterClients service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVcenterClients service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeVcenterClients">REST API Reference for DescribeVcenterClients Operation</seealso>
        public virtual Task<DescribeVcenterClientsResponse> DescribeVcenterClientsAsync(DescribeVcenterClientsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVcenterClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVcenterClientsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVcenterClientsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateApplications

        internal virtual DisassociateApplicationsResponse DisassociateApplications(DisassociateApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApplicationsResponseUnmarshaller.Instance;

            return Invoke<DisassociateApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Disassociate applications from wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        public virtual Task<DisassociateApplicationsResponse> DisassociateApplicationsAsync(DisassociateApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateSourceServers

        internal virtual DisassociateSourceServersResponse DisassociateSourceServers(DisassociateSourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSourceServersResponseUnmarshaller.Instance;

            return Invoke<DisassociateSourceServersResponse>(request, options);
        }



        /// <summary>
        /// Disassociate source servers from application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateSourceServers">REST API Reference for DisassociateSourceServers Operation</seealso>
        public virtual Task<DisassociateSourceServersResponse> DisassociateSourceServersAsync(DisassociateSourceServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSourceServersResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSourceServersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisconnectFromService

        internal virtual DisconnectFromServiceResponse DisconnectFromService(DisconnectFromServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectFromServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectFromServiceResponseUnmarshaller.Instance;

            return Invoke<DisconnectFromServiceResponse>(request, options);
        }



        /// <summary>
        /// Disconnects specific Source Servers from Application Migration Service. Data replication
        /// is stopped immediately. All AWS resources created by Application Migration Service
        /// for enabling the replication of these source servers will be terminated / deleted
        /// within 90 minutes. Launched Test or Cutover instances will NOT be terminated. If the
        /// agent on the source server has not been prevented from communicating with the Application
        /// Migration Service service, then it will receive a command to uninstall itself (within
        /// approximately 10 minutes). The following properties of the SourceServer will be changed
        /// immediately: dataReplicationInfo.dataReplicationState will be set to DISCONNECTED;
        /// The totalStorageBytes property for each of dataReplicationInfo.replicatedDisks will
        /// be set to zero; dataReplicationInfo.lagDuration and dataReplicationInfo.lagDuration
        /// will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectFromService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectFromService service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisconnectFromService">REST API Reference for DisconnectFromService Operation</seealso>
        public virtual Task<DisconnectFromServiceResponse> DisconnectFromServiceAsync(DisconnectFromServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectFromServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectFromServiceResponseUnmarshaller.Instance;

            return InvokeAsync<DisconnectFromServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FinalizeCutover

        internal virtual FinalizeCutoverResponse FinalizeCutover(FinalizeCutoverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FinalizeCutoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FinalizeCutoverResponseUnmarshaller.Instance;

            return Invoke<FinalizeCutoverResponse>(request, options);
        }



        /// <summary>
        /// Finalizes the cutover immediately for specific Source Servers. All AWS resources created
        /// by Application Migration Service for enabling the replication of these source servers
        /// will be terminated / deleted within 90 minutes. Launched Test or Cutover instances
        /// will NOT be terminated. The AWS Replication Agent will receive a command to uninstall
        /// itself (within 10 minutes). The following properties of the SourceServer will be changed
        /// immediately: dataReplicationInfo.dataReplicationState will be changed to DISCONNECTED;
        /// The SourceServer.lifeCycle.state will be changed to CUTOVER; The totalStorageBytes
        /// property fo each of dataReplicationInfo.replicatedDisks will be set to zero; dataReplicationInfo.lagDuration
        /// and dataReplicationInfo.lagDuration will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FinalizeCutover service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FinalizeCutover service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/FinalizeCutover">REST API Reference for FinalizeCutover Operation</seealso>
        public virtual Task<FinalizeCutoverResponse> FinalizeCutoverAsync(FinalizeCutoverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FinalizeCutoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FinalizeCutoverResponseUnmarshaller.Instance;

            return InvokeAsync<FinalizeCutoverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLaunchConfiguration

        internal virtual GetLaunchConfigurationResponse GetLaunchConfiguration(GetLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLaunchConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Lists all LaunchConfigurations available, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLaunchConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        public virtual Task<GetLaunchConfigurationResponse> GetLaunchConfigurationAsync(GetLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLaunchConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetReplicationConfiguration

        internal virtual GetReplicationConfigurationResponse GetReplicationConfiguration(GetReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetReplicationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Lists all ReplicationConfigurations, filtered by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReplicationConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        public virtual Task<GetReplicationConfigurationResponse> GetReplicationConfigurationAsync(GetReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetReplicationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitializeService

        internal virtual InitializeServiceResponse InitializeService(InitializeServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return Invoke<InitializeServiceResponse>(request, options);
        }



        /// <summary>
        /// Initialize Application Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitializeService service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual Task<InitializeServiceResponse> InitializeServiceAsync(InitializeServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return InvokeAsync<InitializeServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplications

        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all applications or multiple applications by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExportErrors

        internal virtual ListExportErrorsResponse ListExportErrors(ListExportErrorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExportErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportErrorsResponseUnmarshaller.Instance;

            return Invoke<ListExportErrorsResponse>(request, options);
        }



        /// <summary>
        /// List export errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExportErrors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExportErrors service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExportErrors">REST API Reference for ListExportErrors Operation</seealso>
        public virtual Task<ListExportErrorsResponse> ListExportErrorsAsync(ListExportErrorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExportErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportErrorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExportErrorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExports

        internal virtual ListExportsResponse ListExports(ListExportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;

            return Invoke<ListExportsResponse>(request, options);
        }



        /// <summary>
        /// List exports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExports">REST API Reference for ListExports Operation</seealso>
        public virtual Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImportErrors

        internal virtual ListImportErrorsResponse ListImportErrors(ListImportErrorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportErrorsResponseUnmarshaller.Instance;

            return Invoke<ListImportErrorsResponse>(request, options);
        }



        /// <summary>
        /// List import errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportErrors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportErrors service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImportErrors">REST API Reference for ListImportErrors Operation</seealso>
        public virtual Task<ListImportErrorsResponse> ListImportErrorsAsync(ListImportErrorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportErrorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportErrorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImports

        internal virtual ListImportsResponse ListImports(ListImportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;

            return Invoke<ListImportsResponse>(request, options);
        }



        /// <summary>
        /// List imports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImports">REST API Reference for ListImports Operation</seealso>
        public virtual Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSourceServerActions

        internal virtual ListSourceServerActionsResponse ListSourceServerActions(ListSourceServerActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceServerActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceServerActionsResponseUnmarshaller.Instance;

            return Invoke<ListSourceServerActionsResponse>(request, options);
        }



        /// <summary>
        /// List source server post migration custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceServerActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSourceServerActions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListSourceServerActions">REST API Reference for ListSourceServerActions Operation</seealso>
        public virtual Task<ListSourceServerActionsResponse> ListSourceServerActionsAsync(ListSourceServerActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceServerActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceServerActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSourceServerActionsResponse>(request, options, cancellationToken);
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
        /// List all tags for your Application Migration Service resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTemplateActions

        internal virtual ListTemplateActionsResponse ListTemplateActions(ListTemplateActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateActionsResponseUnmarshaller.Instance;

            return Invoke<ListTemplateActionsResponse>(request, options);
        }



        /// <summary>
        /// List template post migration custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateActions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTemplateActions">REST API Reference for ListTemplateActions Operation</seealso>
        public virtual Task<ListTemplateActionsResponse> ListTemplateActionsAsync(ListTemplateActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplateActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWaves

        internal virtual ListWavesResponse ListWaves(ListWavesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWavesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWavesResponseUnmarshaller.Instance;

            return Invoke<ListWavesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all waves or multiple waves by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWaves service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWaves service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListWaves">REST API Reference for ListWaves Operation</seealso>
        public virtual Task<ListWavesResponse> ListWavesAsync(ListWavesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWavesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWavesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWavesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MarkAsArchived

        internal virtual MarkAsArchivedResponse MarkAsArchived(MarkAsArchivedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MarkAsArchivedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MarkAsArchivedResponseUnmarshaller.Instance;

            return Invoke<MarkAsArchivedResponse>(request, options);
        }



        /// <summary>
        /// Archives specific Source Servers by setting the SourceServer.isArchived property to
        /// true for specified SourceServers by ID. This command only works for SourceServers
        /// with a lifecycle. state which equals DISCONNECTED or CUTOVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MarkAsArchived service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MarkAsArchived service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/MarkAsArchived">REST API Reference for MarkAsArchived Operation</seealso>
        public virtual Task<MarkAsArchivedResponse> MarkAsArchivedAsync(MarkAsArchivedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MarkAsArchivedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MarkAsArchivedResponseUnmarshaller.Instance;

            return InvokeAsync<MarkAsArchivedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSourceServerAction

        internal virtual PutSourceServerActionResponse PutSourceServerAction(PutSourceServerActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSourceServerActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSourceServerActionResponseUnmarshaller.Instance;

            return Invoke<PutSourceServerActionResponse>(request, options);
        }



        /// <summary>
        /// Put source server post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSourceServerAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSourceServerAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutSourceServerAction">REST API Reference for PutSourceServerAction Operation</seealso>
        public virtual Task<PutSourceServerActionResponse> PutSourceServerActionAsync(PutSourceServerActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSourceServerActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSourceServerActionResponseUnmarshaller.Instance;

            return InvokeAsync<PutSourceServerActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutTemplateAction

        internal virtual PutTemplateActionResponse PutTemplateAction(PutTemplateActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTemplateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTemplateActionResponseUnmarshaller.Instance;

            return Invoke<PutTemplateActionResponse>(request, options);
        }



        /// <summary>
        /// Put template post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTemplateAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTemplateAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutTemplateAction">REST API Reference for PutTemplateAction Operation</seealso>
        public virtual Task<PutTemplateActionResponse> PutTemplateActionAsync(PutTemplateActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTemplateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTemplateActionResponseUnmarshaller.Instance;

            return InvokeAsync<PutTemplateActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveSourceServerAction

        internal virtual RemoveSourceServerActionResponse RemoveSourceServerAction(RemoveSourceServerActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSourceServerActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceServerActionResponseUnmarshaller.Instance;

            return Invoke<RemoveSourceServerActionResponse>(request, options);
        }



        /// <summary>
        /// Remove source server post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceServerAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveSourceServerAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveSourceServerAction">REST API Reference for RemoveSourceServerAction Operation</seealso>
        public virtual Task<RemoveSourceServerActionResponse> RemoveSourceServerActionAsync(RemoveSourceServerActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSourceServerActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceServerActionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveSourceServerActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTemplateAction

        internal virtual RemoveTemplateActionResponse RemoveTemplateAction(RemoveTemplateActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTemplateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTemplateActionResponseUnmarshaller.Instance;

            return Invoke<RemoveTemplateActionResponse>(request, options);
        }



        /// <summary>
        /// Remove template post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTemplateAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTemplateAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveTemplateAction">REST API Reference for RemoveTemplateAction Operation</seealso>
        public virtual Task<RemoveTemplateActionResponse> RemoveTemplateActionAsync(RemoveTemplateActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTemplateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTemplateActionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTemplateActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetryDataReplication

        internal virtual RetryDataReplicationResponse RetryDataReplication(RetryDataReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryDataReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryDataReplicationResponseUnmarshaller.Instance;

            return Invoke<RetryDataReplicationResponse>(request, options);
        }



        /// <summary>
        /// Causes the data replication initiation sequence to begin immediately upon next Handshake
        /// for specified SourceServer IDs, regardless of when the previous initiation started.
        /// This command will not work if the SourceServer is not stalled or is in a DISCONNECTED
        /// or STOPPED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryDataReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        public virtual Task<RetryDataReplicationResponse> RetryDataReplicationAsync(RetryDataReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryDataReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryDataReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<RetryDataReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCutover

        internal virtual StartCutoverResponse StartCutover(StartCutoverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCutoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCutoverResponseUnmarshaller.Instance;

            return Invoke<StartCutoverResponse>(request, options);
        }



        /// <summary>
        /// Launches a Cutover Instance for specific Source Servers. This command starts a LAUNCH
        /// job whose initiatedBy property is StartCutover and changes the SourceServer.lifeCycle.state
        /// property to CUTTING_OVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCutover service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCutover service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartCutover">REST API Reference for StartCutover Operation</seealso>
        public virtual Task<StartCutoverResponse> StartCutoverAsync(StartCutoverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCutoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCutoverResponseUnmarshaller.Instance;

            return InvokeAsync<StartCutoverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartExport

        internal virtual StartExportResponse StartExport(StartExportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportResponseUnmarshaller.Instance;

            return Invoke<StartExportResponse>(request, options);
        }



        /// <summary>
        /// Start export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExport service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartExport">REST API Reference for StartExport Operation</seealso>
        public virtual Task<StartExportResponse> StartExportAsync(StartExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportResponseUnmarshaller.Instance;

            return InvokeAsync<StartExportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartImport

        internal virtual StartImportResponse StartImport(StartImportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportResponseUnmarshaller.Instance;

            return Invoke<StartImportResponse>(request, options);
        }



        /// <summary>
        /// Start import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImport service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartImport">REST API Reference for StartImport Operation</seealso>
        public virtual Task<StartImportResponse> StartImportAsync(StartImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportResponseUnmarshaller.Instance;

            return InvokeAsync<StartImportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartReplication

        internal virtual StartReplicationResponse StartReplication(StartReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;

            return Invoke<StartReplicationResponse>(request, options);
        }



        /// <summary>
        /// Starts replication for SNAPSHOT_SHIPPING agents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        public virtual Task<StartReplicationResponse> StartReplicationAsync(StartReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StartReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTest

        internal virtual StartTestResponse StartTest(StartTestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTestResponseUnmarshaller.Instance;

            return Invoke<StartTestResponse>(request, options);
        }



        /// <summary>
        /// Launches a Test Instance for specific Source Servers. This command starts a LAUNCH
        /// job whose initiatedBy property is StartTest and changes the SourceServer.lifeCycle.state
        /// property to TESTING.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTest service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartTest">REST API Reference for StartTest Operation</seealso>
        public virtual Task<StartTestResponse> StartTestAsync(StartTestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTestResponseUnmarshaller.Instance;

            return InvokeAsync<StartTestResponse>(request, options, cancellationToken);
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
        /// Adds or overwrites only the specified tags for the specified Application Migration
        /// Service resource or resources. When you specify an existing tag key, the value is
        /// overwritten with the new value. Each resource can have a maximum of 50 tags. Each
        /// tag consists of a key and optional value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateTargetInstances

        internal virtual TerminateTargetInstancesResponse TerminateTargetInstances(TerminateTargetInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateTargetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateTargetInstancesResponseUnmarshaller.Instance;

            return Invoke<TerminateTargetInstancesResponse>(request, options);
        }



        /// <summary>
        /// Starts a job that terminates specific launched EC2 Test and Cutover instances. This
        /// command will not work for any Source Server with a lifecycle.state of TESTING, CUTTING_OVER,
        /// or CUTOVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateTargetInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateTargetInstances service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TerminateTargetInstances">REST API Reference for TerminateTargetInstances Operation</seealso>
        public virtual Task<TerminateTargetInstancesResponse> TerminateTargetInstancesAsync(TerminateTargetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateTargetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateTargetInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateTargetInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnarchiveApplication

        internal virtual UnarchiveApplicationResponse UnarchiveApplication(UnarchiveApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnarchiveApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnarchiveApplicationResponseUnmarshaller.Instance;

            return Invoke<UnarchiveApplicationResponse>(request, options);
        }



        /// <summary>
        /// Unarchive application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnarchiveApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveApplication">REST API Reference for UnarchiveApplication Operation</seealso>
        public virtual Task<UnarchiveApplicationResponse> UnarchiveApplicationAsync(UnarchiveApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnarchiveApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnarchiveApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UnarchiveApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnarchiveWave

        internal virtual UnarchiveWaveResponse UnarchiveWave(UnarchiveWaveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnarchiveWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnarchiveWaveResponseUnmarshaller.Instance;

            return Invoke<UnarchiveWaveResponse>(request, options);
        }



        /// <summary>
        /// Unarchive wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveWave service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnarchiveWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveWave">REST API Reference for UnarchiveWave Operation</seealso>
        public virtual Task<UnarchiveWaveResponse> UnarchiveWaveAsync(UnarchiveWaveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnarchiveWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnarchiveWaveResponseUnmarshaller.Instance;

            return InvokeAsync<UnarchiveWaveResponse>(request, options, cancellationToken);
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
        /// Deletes the specified set of tags from the specified set of Application Migration
        /// Service resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Update application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLaunchConfiguration

        internal virtual UpdateLaunchConfigurationResponse UpdateLaunchConfiguration(UpdateLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLaunchConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates multiple LaunchConfigurations by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLaunchConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        public virtual Task<UpdateLaunchConfigurationResponse> UpdateLaunchConfigurationAsync(UpdateLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLaunchConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLaunchConfigurationTemplate

        internal virtual UpdateLaunchConfigurationTemplateResponse UpdateLaunchConfigurationTemplate(UpdateLaunchConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateLaunchConfigurationTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        public virtual Task<UpdateLaunchConfigurationTemplateResponse> UpdateLaunchConfigurationTemplateAsync(UpdateLaunchConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLaunchConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateReplicationConfiguration

        internal virtual UpdateReplicationConfigurationResponse UpdateReplicationConfiguration(UpdateReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Allows you to update multiple ReplicationConfigurations by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReplicationConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        public virtual Task<UpdateReplicationConfigurationResponse> UpdateReplicationConfigurationAsync(UpdateReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateReplicationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateReplicationConfigurationTemplate

        internal virtual UpdateReplicationConfigurationTemplateResponse UpdateReplicationConfigurationTemplate(UpdateReplicationConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationConfigurationTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates multiple ReplicationConfigurationTemplates by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        public virtual Task<UpdateReplicationConfigurationTemplateResponse> UpdateReplicationConfigurationTemplateAsync(UpdateReplicationConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateReplicationConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSourceServerReplicationType

        internal virtual UpdateSourceServerReplicationTypeResponse UpdateSourceServerReplicationType(UpdateSourceServerReplicationTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSourceServerReplicationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceServerReplicationTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateSourceServerReplicationTypeResponse>(request, options);
        }



        /// <summary>
        /// Allows you to change between the AGENT_BASED replication type and the SNAPSHOT_SHIPPING
        /// replication type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceServerReplicationType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSourceServerReplicationType service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServerReplicationType">REST API Reference for UpdateSourceServerReplicationType Operation</seealso>
        public virtual Task<UpdateSourceServerReplicationTypeResponse> UpdateSourceServerReplicationTypeAsync(UpdateSourceServerReplicationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSourceServerReplicationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceServerReplicationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSourceServerReplicationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWave

        internal virtual UpdateWaveResponse UpdateWave(UpdateWaveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWaveResponseUnmarshaller.Instance;

            return Invoke<UpdateWaveResponse>(request, options);
        }



        /// <summary>
        /// Update wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWave service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateWave">REST API Reference for UpdateWave Operation</seealso>
        public virtual Task<UpdateWaveResponse> UpdateWaveAsync(UpdateWaveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWaveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWaveResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWaveResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}