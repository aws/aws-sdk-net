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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudWatchOmni.Model;
using Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations;
using Amazon.CloudWatchOmni.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CloudWatchOmni
{
    /// <summary>
    /// <para>Implementation for accessing CloudWatchOmni</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// CloudWatch Omni is a unified observability experience built on Amazon CloudWatch.
    /// You work in a space, an isolated environment that holds your telemetry and controls
    /// who can access it, and your data is stored in the CloudWatch Dataset for correlated
    /// analysis of logs, metrics, and traces.
    /// </summary>
    public partial class AmazonCloudWatchOmniClient : AmazonServiceClient, IAmazonCloudWatchOmni
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudWatchOmniMetadata();
        private ICloudWatchOmniPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudWatchOmniPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudWatchOmniPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with the credentials loaded from the application's
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
        public AmazonCloudWatchOmniClient()
            : base(new AmazonCloudWatchOmniConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with the credentials loaded from the application's
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
        public AmazonCloudWatchOmniClient(RegionEndpoint region)
            : base(new AmazonCloudWatchOmniConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudWatchOmniClient Configuration Object</param>
        public AmazonCloudWatchOmniClient(AmazonCloudWatchOmniConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudWatchOmniClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudWatchOmniConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchOmniClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudWatchOmniConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with AWS Credentials and an
        /// AmazonCloudWatchOmniClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchOmniClient Configuration Object</param>
        public AmazonCloudWatchOmniClient(AWSCredentials credentials, AmazonCloudWatchOmniConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudWatchOmniClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchOmniConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchOmniClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchOmniConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchOmniClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchOmniClient Configuration Object</param>
        public AmazonCloudWatchOmniClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchOmniConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudWatchOmniClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchOmniConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchOmniClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchOmniConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchOmniClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchOmniClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchOmniClient Configuration Object</param>
        public AmazonCloudWatchOmniClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchOmniConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudWatchOmniEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudWatchOmniAuthSchemeHandler());
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


        #region  CreateAccessGrant


        /// <summary>
        /// Creates an AccessGrant that authorizes a principal to perform a set of actions on
        /// resources in a space.
        /// 
        ///  
        /// <para>
        /// Optionally narrow the grant with scoped actions that limit it to specific resources
        /// and fields. Use ListAccessGrants and GetAccessGrant to retrieve grants, and DeleteAccessGrant
        /// to remove them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessGrant service method.</param>
        /// 
        /// <returns>The response from the CreateAccessGrant service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateAccessGrant">REST API Reference for CreateAccessGrant Operation</seealso>
        public virtual CreateAccessGrantResponse CreateAccessGrant(CreateAccessGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessGrantResponseUnmarshaller.Instance;

            return Invoke<CreateAccessGrantResponse>(request, options);
        }


        /// <summary>
        /// Creates an AccessGrant that authorizes a principal to perform a set of actions on
        /// resources in a space.
        /// 
        ///  
        /// <para>
        /// Optionally narrow the grant with scoped actions that limit it to specific resources
        /// and fields. Use ListAccessGrants and GetAccessGrant to retrieve grants, and DeleteAccessGrant
        /// to remove them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessGrant service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateAccessGrant">REST API Reference for CreateAccessGrant Operation</seealso>
        public virtual Task<CreateAccessGrantResponse> CreateAccessGrantAsync(CreateAccessGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessGrantResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAccessGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccessProfile


        /// <summary>
        /// Creates an access profile in a space.
        /// 
        ///  
        /// <para>
        /// Use GetAccessProfile and ListAccessProfiles to retrieve profiles, and UpdateAccessProfile
        /// to modify one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessProfile service method.</param>
        /// 
        /// <returns>The response from the CreateAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateAccessProfile">REST API Reference for CreateAccessProfile Operation</seealso>
        public virtual CreateAccessProfileResponse CreateAccessProfile(CreateAccessProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessProfileResponseUnmarshaller.Instance;

            return Invoke<CreateAccessProfileResponse>(request, options);
        }


        /// <summary>
        /// Creates an access profile in a space.
        /// 
        ///  
        /// <para>
        /// Use GetAccessProfile and ListAccessProfiles to retrieve profiles, and UpdateAccessProfile
        /// to modify one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateAccessProfile">REST API Reference for CreateAccessProfile Operation</seealso>
        public virtual Task<CreateAccessProfileResponse> CreateAccessProfileAsync(CreateAccessProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAccessProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlert


        /// <summary>
        /// Creates a new alert within a space.
        /// 
        ///  
        /// <para>
        /// Use GetAlert and ListAlerts to retrieve alerts, UpdateAlert to modify one, and DeleteAlert
        /// to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlert service method.</param>
        /// 
        /// <returns>The response from the CreateAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateAlert">REST API Reference for CreateAlert Operation</seealso>
        public virtual CreateAlertResponse CreateAlert(CreateAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlertResponseUnmarshaller.Instance;

            return Invoke<CreateAlertResponse>(request, options);
        }


        /// <summary>
        /// Creates a new alert within a space.
        /// 
        ///  
        /// <para>
        /// Use GetAlert and ListAlerts to retrieve alerts, UpdateAlert to modify one, and DeleteAlert
        /// to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateAlert">REST API Reference for CreateAlert Operation</seealso>
        public virtual Task<CreateAlertResponse> CreateAlertAsync(CreateAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlertResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAlertResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a domain with identity provider configuration.
        /// 
        ///  
        /// <para>
        /// Use GetDomain to retrieve the domain, UpdateDomain to change its configuration, and
        /// CreateSpace to add spaces within it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }


        /// <summary>
        /// Creates a domain with identity provider configuration.
        /// 
        ///  
        /// <para>
        /// Use GetDomain to retrieve the domain, UpdateDomain to change its configuration, and
        /// CreateSpace to add spaces within it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainAccessGrantForOrganization


        /// <summary>
        /// Creates an AccessGrant that authorizes a principal to administer an organization domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainAccessGrantForOrganization service method.</param>
        /// 
        /// <returns>The response from the CreateDomainAccessGrantForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateDomainAccessGrantForOrganization">REST API Reference for CreateDomainAccessGrantForOrganization Operation</seealso>
        public virtual CreateDomainAccessGrantForOrganizationResponse CreateDomainAccessGrantForOrganization(CreateDomainAccessGrantForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainAccessGrantForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainAccessGrantForOrganizationResponseUnmarshaller.Instance;

            return Invoke<CreateDomainAccessGrantForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Creates an AccessGrant that authorizes a principal to administer an organization domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainAccessGrantForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainAccessGrantForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateDomainAccessGrantForOrganization">REST API Reference for CreateDomainAccessGrantForOrganization Operation</seealso>
        public virtual Task<CreateDomainAccessGrantForOrganizationResponse> CreateDomainAccessGrantForOrganizationAsync(CreateDomainAccessGrantForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainAccessGrantForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainAccessGrantForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDomainAccessGrantForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainForOrganization


        /// <summary>
        /// Creates an organization-scoped domain for the caller's AWS Organization. Only the
        /// organization's management account can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainForOrganization service method.</param>
        /// 
        /// <returns>The response from the CreateDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateDomainForOrganization">REST API Reference for CreateDomainForOrganization Operation</seealso>
        public virtual CreateDomainForOrganizationResponse CreateDomainForOrganization(CreateDomainForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainForOrganizationResponseUnmarshaller.Instance;

            return Invoke<CreateDomainForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Creates an organization-scoped domain for the caller's AWS Organization. Only the
        /// organization's management account can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateDomainForOrganization">REST API Reference for CreateDomainForOrganization Operation</seealso>
        public virtual Task<CreateDomainForOrganizationResponse> CreateDomainForOrganizationAsync(CreateDomainForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDomainForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIntegration


        /// <summary>
        /// Creates an integration with a third-party provider. Returns the integration identifier
        /// and its initial status; when the provider requires interactive consent, an authorization
        /// URL is returned for the user to complete setup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Creates an integration with a third-party provider. Returns the integration identifier
        /// and its initial status; when the provider requires interactive consent, an authorization
        /// URL is returned for the user to complete setup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOmniDashboard


        /// <summary>
        /// Creates a new dashboard within a space.
        /// 
        ///  
        /// <para>
        /// Use GetOmniDashboard and ListOmniDashboards to retrieve dashboards, UpdateOmniDashboard
        /// to modify one, and DeleteOmniDashboard to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOmniDashboard service method.</param>
        /// 
        /// <returns>The response from the CreateOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateOmniDashboard">REST API Reference for CreateOmniDashboard Operation</seealso>
        public virtual CreateOmniDashboardResponse CreateOmniDashboard(CreateOmniDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOmniDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOmniDashboardResponseUnmarshaller.Instance;

            return Invoke<CreateOmniDashboardResponse>(request, options);
        }


        /// <summary>
        /// Creates a new dashboard within a space.
        /// 
        ///  
        /// <para>
        /// Use GetOmniDashboard and ListOmniDashboards to retrieve dashboards, UpdateOmniDashboard
        /// to modify one, and DeleteOmniDashboard to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOmniDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateOmniDashboard">REST API Reference for CreateOmniDashboard Operation</seealso>
        public virtual Task<CreateOmniDashboardResponse> CreateOmniDashboardAsync(CreateOmniDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOmniDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOmniDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOmniDashboardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOneTimeDeepLinkCode


        /// <summary>
        /// Generates a one-time code for deep-link authentication.
        /// 
        ///  
        /// <para>
        /// Direct the user's browser to the returned deepLinkUrl before it expires. The code
        /// is exchanged for an authenticated, domain-scoped session and can be used only once.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOneTimeDeepLinkCode service method.</param>
        /// 
        /// <returns>The response from the CreateOneTimeDeepLinkCode service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateOneTimeDeepLinkCode">REST API Reference for CreateOneTimeDeepLinkCode Operation</seealso>
        public virtual CreateOneTimeDeepLinkCodeResponse CreateOneTimeDeepLinkCode(CreateOneTimeDeepLinkCodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOneTimeDeepLinkCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOneTimeDeepLinkCodeResponseUnmarshaller.Instance;

            return Invoke<CreateOneTimeDeepLinkCodeResponse>(request, options);
        }


        /// <summary>
        /// Generates a one-time code for deep-link authentication.
        /// 
        ///  
        /// <para>
        /// Direct the user's browser to the returned deepLinkUrl before it expires. The code
        /// is exchanged for an authenticated, domain-scoped session and can be used only once.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOneTimeDeepLinkCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOneTimeDeepLinkCode service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateOneTimeDeepLinkCode">REST API Reference for CreateOneTimeDeepLinkCode Operation</seealso>
        public virtual Task<CreateOneTimeDeepLinkCodeResponse> CreateOneTimeDeepLinkCodeAsync(CreateOneTimeDeepLinkCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOneTimeDeepLinkCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOneTimeDeepLinkCodeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOneTimeDeepLinkCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSpace


        /// <summary>
        /// Creates a space in a domain.
        /// 
        ///  
        /// <para>
        /// Use GetSpace to retrieve the space, ListSpaces to enumerate spaces, UpdateSpace to
        /// modify it, and DeleteSpace to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace service method.</param>
        /// 
        /// <returns>The response from the CreateSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        public virtual CreateSpaceResponse CreateSpace(CreateSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpaceResponseUnmarshaller.Instance;

            return Invoke<CreateSpaceResponse>(request, options);
        }


        /// <summary>
        /// Creates a space in a domain.
        /// 
        ///  
        /// <para>
        /// Use GetSpace to retrieve the space, ListSpaces to enumerate spaces, UpdateSpace to
        /// modify it, and DeleteSpace to remove it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        public virtual Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateView


        /// <summary>
        /// Creates a new SQL view.
        /// 
        ///  
        /// <para>
        /// A view is a named, reusable SQL query that can be referenced from telemetry queries.
        /// View names must be unique within the account and region. Only USER views can be created
        /// — MANAGED views are provisioned by AWS.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateView service method.</param>
        /// 
        /// <returns>The response from the CreateView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateView">REST API Reference for CreateView Operation</seealso>
        public virtual CreateViewResponse CreateView(CreateViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateViewResponseUnmarshaller.Instance;

            return Invoke<CreateViewResponse>(request, options);
        }


        /// <summary>
        /// Creates a new SQL view.
        /// 
        ///  
        /// <para>
        /// A view is a named, reusable SQL query that can be referenced from telemetry queries.
        /// View names must be unique within the account and region. Only USER views can be created
        /// — MANAGED views are provisioned by AWS.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/CreateView">REST API Reference for CreateView Operation</seealso>
        public virtual Task<CreateViewResponse> CreateViewAsync(CreateViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateViewResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessGrant


        /// <summary>
        /// Removes an existing AccessGrant, revoking the access it granted.
        /// 
        ///  
        /// <para>
        /// A service-managed grant cannot be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessGrant service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteAccessGrant">REST API Reference for DeleteAccessGrant Operation</seealso>
        public virtual DeleteAccessGrantResponse DeleteAccessGrant(DeleteAccessGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessGrantResponse>(request, options);
        }


        /// <summary>
        /// Removes an existing AccessGrant, revoking the access it granted.
        /// 
        ///  
        /// <para>
        /// A service-managed grant cannot be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessGrant service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteAccessGrant">REST API Reference for DeleteAccessGrant Operation</seealso>
        public virtual Task<DeleteAccessGrantResponse> DeleteAccessGrantAsync(DeleteAccessGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessGrantResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessProfile


        /// <summary>
        /// Removes an access profile.
        /// 
        ///  
        /// <para>
        /// An access profile cannot be deleted while access grants reference it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteAccessProfile">REST API Reference for DeleteAccessProfile Operation</seealso>
        public virtual DeleteAccessProfileResponse DeleteAccessProfile(DeleteAccessProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessProfileResponse>(request, options);
        }


        /// <summary>
        /// Removes an access profile.
        /// 
        ///  
        /// <para>
        /// An access profile cannot be deleted while access grants reference it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteAccessProfile">REST API Reference for DeleteAccessProfile Operation</seealso>
        public virtual Task<DeleteAccessProfileResponse> DeleteAccessProfileAsync(DeleteAccessProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlert


        /// <summary>
        /// Deletes an alert by its identifier.
        /// 
        ///  
        /// <para>
        /// Idempotent: deleting an alert that has already been removed succeeds without error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlert service method.</param>
        /// 
        /// <returns>The response from the DeleteAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteAlert">REST API Reference for DeleteAlert Operation</seealso>
        public virtual DeleteAlertResponse DeleteAlert(DeleteAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlertResponseUnmarshaller.Instance;

            return Invoke<DeleteAlertResponse>(request, options);
        }


        /// <summary>
        /// Deletes an alert by its identifier.
        /// 
        ///  
        /// <para>
        /// Idempotent: deleting an alert that has already been removed succeeds without error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteAlert">REST API Reference for DeleteAlert Operation</seealso>
        public virtual Task<DeleteAlertResponse> DeleteAlertAsync(DeleteAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlertResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAlertResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Removes a domain and all of its resources. Call this operation in the Region where
        /// the domain was created.
        /// 
        ///  
        /// <para>
        /// A domain cannot be deleted while it contains spaces.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }


        /// <summary>
        /// Removes a domain and all of its resources. Call this operation in the Region where
        /// the domain was created.
        /// 
        ///  
        /// <para>
        /// A domain cannot be deleted while it contains spaces.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainAccessGrantForOrganization


        /// <summary>
        /// Removes an existing organization access grant, revoking the access it granted.
        /// 
        ///  
        /// <para>
        /// A service-managed grant cannot be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainAccessGrantForOrganization service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainAccessGrantForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteDomainAccessGrantForOrganization">REST API Reference for DeleteDomainAccessGrantForOrganization Operation</seealso>
        public virtual DeleteDomainAccessGrantForOrganizationResponse DeleteDomainAccessGrantForOrganization(DeleteDomainAccessGrantForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainAccessGrantForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainAccessGrantForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainAccessGrantForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Removes an existing organization access grant, revoking the access it granted.
        /// 
        ///  
        /// <para>
        /// A service-managed grant cannot be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainAccessGrantForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainAccessGrantForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteDomainAccessGrantForOrganization">REST API Reference for DeleteDomainAccessGrantForOrganization Operation</seealso>
        public virtual Task<DeleteDomainAccessGrantForOrganizationResponse> DeleteDomainAccessGrantForOrganizationAsync(DeleteDomainAccessGrantForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainAccessGrantForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainAccessGrantForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDomainAccessGrantForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainForOrganization


        /// <summary>
        /// Removes an organization domain and all of its resources. Call this operation in the
        /// Region where the domain was created.
        /// 
        ///  
        /// <para>
        /// A domain cannot be deleted while it contains spaces.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainForOrganization service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteDomainForOrganization">REST API Reference for DeleteDomainForOrganization Operation</seealso>
        public virtual DeleteDomainForOrganizationResponse DeleteDomainForOrganization(DeleteDomainForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Removes an organization domain and all of its resources. Call this operation in the
        /// Region where the domain was created.
        /// 
        ///  
        /// <para>
        /// A domain cannot be deleted while it contains spaces.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteDomainForOrganization">REST API Reference for DeleteDomainForOrganization Operation</seealso>
        public virtual Task<DeleteDomainForOrganizationResponse> DeleteDomainForOrganizationAsync(DeleteDomainForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDomainForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntegration


        /// <summary>
        /// Deletes an integration. Returns the resulting status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Deletes an integration. Returns the resulting status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOmniDashboard


        /// <summary>
        /// Removes a dashboard from a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOmniDashboard service method.</param>
        /// 
        /// <returns>The response from the DeleteOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteOmniDashboard">REST API Reference for DeleteOmniDashboard Operation</seealso>
        public virtual DeleteOmniDashboardResponse DeleteOmniDashboard(DeleteOmniDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOmniDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOmniDashboardResponseUnmarshaller.Instance;

            return Invoke<DeleteOmniDashboardResponse>(request, options);
        }


        /// <summary>
        /// Removes a dashboard from a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOmniDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteOmniDashboard">REST API Reference for DeleteOmniDashboard Operation</seealso>
        public virtual Task<DeleteOmniDashboardResponse> DeleteOmniDashboardAsync(DeleteOmniDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOmniDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOmniDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOmniDashboardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSpace


        /// <summary>
        /// Removes a space and all of its resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// 
        /// <returns>The response from the DeleteSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        public virtual DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpaceResponseUnmarshaller.Instance;

            return Invoke<DeleteSpaceResponse>(request, options);
        }


        /// <summary>
        /// Removes a space and all of its resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        public virtual Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteView


        /// <summary>
        /// Deletes the specified view.
        /// 
        ///  
        /// <para>
        /// Queries that reference the view fail after it is deleted. Managed views cannot be
        /// deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteView service method.</param>
        /// 
        /// <returns>The response from the DeleteView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteView">REST API Reference for DeleteView Operation</seealso>
        public virtual DeleteViewResponse DeleteView(DeleteViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteViewResponseUnmarshaller.Instance;

            return Invoke<DeleteViewResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified view.
        /// 
        ///  
        /// <para>
        /// Queries that reference the view fail after it is deleted. Managed views cannot be
        /// deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/DeleteView">REST API Reference for DeleteView Operation</seealso>
        public virtual Task<DeleteViewResponse> DeleteViewAsync(DeleteViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteViewResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessGrant


        /// <summary>
        /// Retrieves the full detail of a single AccessGrant by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrant service method.</param>
        /// 
        /// <returns>The response from the GetAccessGrant service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetAccessGrant">REST API Reference for GetAccessGrant Operation</seealso>
        public virtual GetAccessGrantResponse GetAccessGrant(GetAccessGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessGrantResponseUnmarshaller.Instance;

            return Invoke<GetAccessGrantResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the full detail of a single AccessGrant by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessGrant service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetAccessGrant">REST API Reference for GetAccessGrant Operation</seealso>
        public virtual Task<GetAccessGrantResponse> GetAccessGrantAsync(GetAccessGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessGrantResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessProfile


        /// <summary>
        /// Retrieves an access profile by ID.
        /// 
        ///  
        /// <para>
        /// The response indicates whether the calling principal is currently allowed to assume
        /// the profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessProfile service method.</param>
        /// 
        /// <returns>The response from the GetAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetAccessProfile">REST API Reference for GetAccessProfile Operation</seealso>
        public virtual GetAccessProfileResponse GetAccessProfile(GetAccessProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessProfileResponseUnmarshaller.Instance;

            return Invoke<GetAccessProfileResponse>(request, options);
        }


        /// <summary>
        /// Retrieves an access profile by ID.
        /// 
        ///  
        /// <para>
        /// The response indicates whether the calling principal is currently allowed to assume
        /// the profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetAccessProfile">REST API Reference for GetAccessProfile Operation</seealso>
        public virtual Task<GetAccessProfileResponse> GetAccessProfileAsync(GetAccessProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAlert


        /// <summary>
        /// Retrieves a single alert by its identifier.
        /// 
        ///  
        /// <para>
        /// Use ListAlerts to enumerate alerts in the space.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlert service method.</param>
        /// 
        /// <returns>The response from the GetAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetAlert">REST API Reference for GetAlert Operation</seealso>
        public virtual GetAlertResponse GetAlert(GetAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAlertResponseUnmarshaller.Instance;

            return Invoke<GetAlertResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a single alert by its identifier.
        /// 
        ///  
        /// <para>
        /// Use ListAlerts to enumerate alerts in the space.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetAlert">REST API Reference for GetAlert Operation</seealso>
        public virtual Task<GetAlertResponse> GetAlertAsync(GetAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAlertResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAlertResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContextGraph


        /// <summary>
        /// Queries the context graph with filtering, traversal, and pagination support.
        /// 
        ///  
        /// <para>
        /// Pagination note: nodes and edges are returned together as a coherent subgraph. Pagination
        /// cursors advance over nodes (the primary collection); each page includes all edges
        /// connecting nodes within that page. Callers should treat nodes as the paginated collection
        /// and edges as supplementary relationship data attached to those nodes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContextGraph service method.</param>
        /// 
        /// <returns>The response from the GetContextGraph service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetContextGraph">REST API Reference for GetContextGraph Operation</seealso>
        public virtual GetContextGraphResponse GetContextGraph(GetContextGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContextGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContextGraphResponseUnmarshaller.Instance;

            return Invoke<GetContextGraphResponse>(request, options);
        }


        /// <summary>
        /// Queries the context graph with filtering, traversal, and pagination support.
        /// 
        ///  
        /// <para>
        /// Pagination note: nodes and edges are returned together as a coherent subgraph. Pagination
        /// cursors advance over nodes (the primary collection); each page includes all edges
        /// connecting nodes within that page. Callers should treat nodes as the paginated collection
        /// and edges as supplementary relationship data attached to those nodes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContextGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContextGraph service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetContextGraph">REST API Reference for GetContextGraph Operation</seealso>
        public virtual Task<GetContextGraphResponse> GetContextGraphAsync(GetContextGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContextGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContextGraphResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetContextGraphResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomain


        /// <summary>
        /// Retrieves the details of a domain by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual GetDomainResponse GetDomain(GetDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return Invoke<GetDomainResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the details of a domain by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainAccessGrantForOrganization


        /// <summary>
        /// Retrieves the full detail of a single organization access grant by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainAccessGrantForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetDomainAccessGrantForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetDomainAccessGrantForOrganization">REST API Reference for GetDomainAccessGrantForOrganization Operation</seealso>
        public virtual GetDomainAccessGrantForOrganizationResponse GetDomainAccessGrantForOrganization(GetDomainAccessGrantForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainAccessGrantForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainAccessGrantForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetDomainAccessGrantForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the full detail of a single organization access grant by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainAccessGrantForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainAccessGrantForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetDomainAccessGrantForOrganization">REST API Reference for GetDomainAccessGrantForOrganization Operation</seealso>
        public virtual Task<GetDomainAccessGrantForOrganizationResponse> GetDomainAccessGrantForOrganizationAsync(GetDomainAccessGrantForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainAccessGrantForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainAccessGrantForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainAccessGrantForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainForOrganization


        /// <summary>
        /// Retrieves the details of an organization domain by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetDomainForOrganization">REST API Reference for GetDomainForOrganization Operation</seealso>
        public virtual GetDomainForOrganizationResponse GetDomainForOrganization(GetDomainForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetDomainForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the details of an organization domain by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetDomainForOrganization">REST API Reference for GetDomainForOrganization Operation</seealso>
        public virtual Task<GetDomainForOrganizationResponse> GetDomainForOrganizationAsync(GetDomainForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntegration


        /// <summary>
        /// Returns the details of a single integration, identified by its identifier, Amazon
        /// Resource Name, or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Returns the details of a single integration, identified by its identifier, Amazon
        /// Resource Name, or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntelligenceConfiguration


        /// <summary>
        /// Retrieves the intelligence configuration for the calling account. Account is identified
        /// via FAS (caller identity). Returns the default configuration if none exists yet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntelligenceConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetIntelligenceConfiguration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetIntelligenceConfiguration">REST API Reference for GetIntelligenceConfiguration Operation</seealso>
        public virtual GetIntelligenceConfigurationResponse GetIntelligenceConfiguration(GetIntelligenceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntelligenceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntelligenceConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetIntelligenceConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the intelligence configuration for the calling account. Account is identified
        /// via FAS (caller identity). Returns the default configuration if none exists yet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntelligenceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntelligenceConfiguration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetIntelligenceConfiguration">REST API Reference for GetIntelligenceConfiguration Operation</seealso>
        public virtual Task<GetIntelligenceConfigurationResponse> GetIntelligenceConfigurationAsync(GetIntelligenceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntelligenceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntelligenceConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIntelligenceConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOmniDashboard


        /// <summary>
        /// Retrieves a dashboard by ID within a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOmniDashboard service method.</param>
        /// 
        /// <returns>The response from the GetOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetOmniDashboard">REST API Reference for GetOmniDashboard Operation</seealso>
        public virtual GetOmniDashboardResponse GetOmniDashboard(GetOmniDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOmniDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOmniDashboardResponseUnmarshaller.Instance;

            return Invoke<GetOmniDashboardResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a dashboard by ID within a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOmniDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetOmniDashboard">REST API Reference for GetOmniDashboard Operation</seealso>
        public virtual Task<GetOmniDashboardResponse> GetOmniDashboardAsync(GetOmniDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOmniDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOmniDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOmniDashboardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSpace


        /// <summary>
        /// Retrieves the details of a space by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// 
        /// <returns>The response from the GetSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetSpace">REST API Reference for GetSpace Operation</seealso>
        public virtual GetSpaceResponse GetSpace(GetSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceResponseUnmarshaller.Instance;

            return Invoke<GetSpaceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the details of a space by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetSpace">REST API Reference for GetSpace Operation</seealso>
        public virtual Task<GetSpaceResponse> GetSpaceAsync(GetSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSpaceCredentialsForOrganization


        /// <summary>
        /// Returns temporary credentials for a space in an organization member account. The credentials
        /// are valid for one hour.
        /// 
        ///  
        /// <para>
        /// The caller must be the organization's management account or a delegated administrator
        /// with access to the target space. The target account must be an active member of the
        /// same organization as the domain, and the space must already exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpaceCredentialsForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetSpaceCredentialsForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetSpaceCredentialsForOrganization">REST API Reference for GetSpaceCredentialsForOrganization Operation</seealso>
        public virtual GetSpaceCredentialsForOrganizationResponse GetSpaceCredentialsForOrganization(GetSpaceCredentialsForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpaceCredentialsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceCredentialsForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetSpaceCredentialsForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Returns temporary credentials for a space in an organization member account. The credentials
        /// are valid for one hour.
        /// 
        ///  
        /// <para>
        /// The caller must be the organization's management account or a delegated administrator
        /// with access to the target space. The target account must be an active member of the
        /// same organization as the domain, and the space must already exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpaceCredentialsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSpaceCredentialsForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetSpaceCredentialsForOrganization">REST API Reference for GetSpaceCredentialsForOrganization Operation</seealso>
        public virtual Task<GetSpaceCredentialsForOrganizationResponse> GetSpaceCredentialsForOrganizationAsync(GetSpaceCredentialsForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpaceCredentialsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceCredentialsForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSpaceCredentialsForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTelemetryQueryResults


        /// <summary>
        /// Returns the results for the specified query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryQueryResults service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryQueryResults service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetTelemetryQueryResults">REST API Reference for GetTelemetryQueryResults Operation</seealso>
        public virtual GetTelemetryQueryResultsResponse GetTelemetryQueryResults(GetTelemetryQueryResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryQueryResultsResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryQueryResultsResponse>(request, options);
        }


        /// <summary>
        /// Returns the results for the specified query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryQueryResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTelemetryQueryResults service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetTelemetryQueryResults">REST API Reference for GetTelemetryQueryResults Operation</seealso>
        public virtual Task<GetTelemetryQueryResultsResponse> GetTelemetryQueryResultsAsync(GetTelemetryQueryResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryQueryResultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTelemetryQueryResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetView


        /// <summary>
        /// Returns the definition and metadata of the specified view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetView service method.</param>
        /// 
        /// <returns>The response from the GetView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetView">REST API Reference for GetView Operation</seealso>
        public virtual GetViewResponse GetView(GetViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetViewResponseUnmarshaller.Instance;

            return Invoke<GetViewResponse>(request, options);
        }


        /// <summary>
        /// Returns the definition and metadata of the specified view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/GetView">REST API Reference for GetView Operation</seealso>
        public virtual Task<GetViewResponse> GetViewAsync(GetViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetViewResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessGrants


        /// <summary>
        /// Returns AccessGrants, with optional filtering by domain, space, principal, or permission.
        /// A grant is returned only when it matches every filter supplied. With no filters, returns
        /// the grants for the current account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessGrants service method.</param>
        /// 
        /// <returns>The response from the ListAccessGrants service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListAccessGrants">REST API Reference for ListAccessGrants Operation</seealso>
        public virtual ListAccessGrantsResponse ListAccessGrants(ListAccessGrantsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessGrantsResponseUnmarshaller.Instance;

            return Invoke<ListAccessGrantsResponse>(request, options);
        }


        /// <summary>
        /// Returns AccessGrants, with optional filtering by domain, space, principal, or permission.
        /// A grant is returned only when it matches every filter supplied. With no filters, returns
        /// the grants for the current account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessGrants service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListAccessGrants">REST API Reference for ListAccessGrants Operation</seealso>
        public virtual Task<ListAccessGrantsResponse> ListAccessGrantsAsync(ListAccessGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessGrantsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessProfiles


        /// <summary>
        /// Returns the access profiles in a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessProfiles service method.</param>
        /// 
        /// <returns>The response from the ListAccessProfiles service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListAccessProfiles">REST API Reference for ListAccessProfiles Operation</seealso>
        public virtual ListAccessProfilesResponse ListAccessProfiles(ListAccessProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessProfilesResponseUnmarshaller.Instance;

            return Invoke<ListAccessProfilesResponse>(request, options);
        }


        /// <summary>
        /// Returns the access profiles in a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessProfiles service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListAccessProfiles">REST API Reference for ListAccessProfiles Operation</seealso>
        public virtual Task<ListAccessProfilesResponse> ListAccessProfilesAsync(ListAccessProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessProfilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAlerts


        /// <summary>
        /// Lists alerts within a space, optionally filtered by exact name(s), a single name prefix,
        /// or exact alertId(s), with pagination.
        /// 
        ///  
        /// <para>
        /// Use GetAlert to retrieve a single alert's full detail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// 
        /// <returns>The response from the ListAlerts service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        public virtual ListAlertsResponse ListAlerts(ListAlertsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlertsResponseUnmarshaller.Instance;

            return Invoke<ListAlertsResponse>(request, options);
        }


        /// <summary>
        /// Lists alerts within a space, optionally filtered by exact name(s), a single name prefix,
        /// or exact alertId(s), with pagination.
        /// 
        ///  
        /// <para>
        /// Use GetAlert to retrieve a single alert's full detail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlerts service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        public virtual Task<ListAlertsResponse> ListAlertsAsync(ListAlertsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlertsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAlertsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomainAccessGrantsForOrganization


        /// <summary>
        /// Returns organization-level domain access grants, with optional filtering by domain,
        /// principal, or permission. A grant is returned only when it matches every filter supplied.
        /// With no filters, returns the grants for the caller's organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainAccessGrantsForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListDomainAccessGrantsForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListDomainAccessGrantsForOrganization">REST API Reference for ListDomainAccessGrantsForOrganization Operation</seealso>
        public virtual ListDomainAccessGrantsForOrganizationResponse ListDomainAccessGrantsForOrganization(ListDomainAccessGrantsForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainAccessGrantsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainAccessGrantsForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListDomainAccessGrantsForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Returns organization-level domain access grants, with optional filtering by domain,
        /// principal, or permission. A grant is returned only when it matches every filter supplied.
        /// With no filters, returns the grants for the caller's organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainAccessGrantsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainAccessGrantsForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListDomainAccessGrantsForOrganization">REST API Reference for ListDomainAccessGrantsForOrganization Operation</seealso>
        public virtual Task<ListDomainAccessGrantsForOrganizationResponse> ListDomainAccessGrantsForOrganizationAsync(ListDomainAccessGrantsForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainAccessGrantsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainAccessGrantsForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDomainAccessGrantsForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Returns the caller's domains: the account-scoped domain and the organization-scoped
        /// domain, if either exists. At most two domains are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }


        /// <summary>
        /// Returns the caller's domains: the account-scoped domain and the organization-scoped
        /// domain, if either exists. At most two domains are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIntegrations


        /// <summary>
        /// Lists the integrations in the account, optionally filtered by type, status, or name.
        /// Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        public virtual ListIntegrationsResponse ListIntegrations(ListIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListIntegrationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the integrations in the account, optionally filtered by type, status, or name.
        /// Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        public virtual Task<ListIntegrationsResponse> ListIntegrationsAsync(ListIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListIntegrationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOmniDashboards


        /// <summary>
        /// Returns the dashboards in a space, optionally filtered by name prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOmniDashboards service method.</param>
        /// 
        /// <returns>The response from the ListOmniDashboards service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListOmniDashboards">REST API Reference for ListOmniDashboards Operation</seealso>
        public virtual ListOmniDashboardsResponse ListOmniDashboards(ListOmniDashboardsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOmniDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOmniDashboardsResponseUnmarshaller.Instance;

            return Invoke<ListOmniDashboardsResponse>(request, options);
        }


        /// <summary>
        /// Returns the dashboards in a space, optionally filtered by name prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOmniDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOmniDashboards service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListOmniDashboards">REST API Reference for ListOmniDashboards Operation</seealso>
        public virtual Task<ListOmniDashboardsResponse> ListOmniDashboardsAsync(ListOmniDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOmniDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOmniDashboardsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOmniDashboardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSpaces


        /// <summary>
        /// Returns the spaces in the account, optionally filtered by domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// 
        /// <returns>The response from the ListSpaces service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        public virtual ListSpacesResponse ListSpaces(ListSpacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;

            return Invoke<ListSpacesResponse>(request, options);
        }


        /// <summary>
        /// Returns the spaces in the account, optionally filtered by domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSpaces service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        public virtual Task<ListSpacesResponse> ListSpacesAsync(ListSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSpacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSpacesForOrganization


        /// <summary>
        /// Returns the spaces across all member accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpacesForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListSpacesForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListSpacesForOrganization">REST API Reference for ListSpacesForOrganization Operation</seealso>
        public virtual ListSpacesForOrganizationResponse ListSpacesForOrganization(ListSpacesForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpacesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListSpacesForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Returns the spaces across all member accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpacesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSpacesForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListSpacesForOrganization">REST API Reference for ListSpacesForOrganization Operation</seealso>
        public virtual Task<ListSpacesForOrganizationResponse> ListSpacesForOrganizationAsync(ListSpacesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpacesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSpacesForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTelemetryFields


        /// <summary>
        /// Lists fields available for telemetry queries.
        /// 
        ///  
        /// <para>
        /// Returns a list of fields included in the specified dataset, granular to telemetry
        /// type. Returned field names reflect the exact stored casing and are case-sensitive
        /// when referenced in query expressions; the query engine does not normalize identifier
        /// case.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryFields service method.</param>
        /// 
        /// <returns>The response from the ListTelemetryFields service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListTelemetryFields">REST API Reference for ListTelemetryFields Operation</seealso>
        public virtual ListTelemetryFieldsResponse ListTelemetryFields(ListTelemetryFieldsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTelemetryFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTelemetryFieldsResponseUnmarshaller.Instance;

            return Invoke<ListTelemetryFieldsResponse>(request, options);
        }


        /// <summary>
        /// Lists fields available for telemetry queries.
        /// 
        ///  
        /// <para>
        /// Returns a list of fields included in the specified dataset, granular to telemetry
        /// type. Returned field names reflect the exact stored casing and are case-sensitive
        /// when referenced in query expressions; the query engine does not normalize identifier
        /// case.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryFields service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTelemetryFields service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListTelemetryFields">REST API Reference for ListTelemetryFields Operation</seealso>
        public virtual Task<ListTelemetryFieldsResponse> ListTelemetryFieldsAsync(ListTelemetryFieldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTelemetryFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTelemetryFieldsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTelemetryFieldsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTelemetryQuerySessions


        /// <summary>
        /// Lists telemetry query sessions.
        /// 
        ///  
        /// <para>
        /// Returns a list of telemetry query sessions owned by the caller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryQuerySessions service method.</param>
        /// 
        /// <returns>The response from the ListTelemetryQuerySessions service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListTelemetryQuerySessions">REST API Reference for ListTelemetryQuerySessions Operation</seealso>
        public virtual ListTelemetryQuerySessionsResponse ListTelemetryQuerySessions(ListTelemetryQuerySessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTelemetryQuerySessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTelemetryQuerySessionsResponseUnmarshaller.Instance;

            return Invoke<ListTelemetryQuerySessionsResponse>(request, options);
        }


        /// <summary>
        /// Lists telemetry query sessions.
        /// 
        ///  
        /// <para>
        /// Returns a list of telemetry query sessions owned by the caller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryQuerySessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTelemetryQuerySessions service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListTelemetryQuerySessions">REST API Reference for ListTelemetryQuerySessions Operation</seealso>
        public virtual Task<ListTelemetryQuerySessionsResponse> ListTelemetryQuerySessionsAsync(ListTelemetryQuerySessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTelemetryQuerySessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTelemetryQuerySessionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTelemetryQuerySessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListViews


        /// <summary>
        /// Lists the views in the caller's account and region.
        /// 
        ///  
        /// <para>
        /// Returns a summary for each view, optionally filtered by view type. View definitions
        /// are not included — use GetView to retrieve them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListViews service method.</param>
        /// 
        /// <returns>The response from the ListViews service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListViews">REST API Reference for ListViews Operation</seealso>
        public virtual ListViewsResponse ListViews(ListViewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListViewsResponseUnmarshaller.Instance;

            return Invoke<ListViewsResponse>(request, options);
        }


        /// <summary>
        /// Lists the views in the caller's account and region.
        /// 
        ///  
        /// <para>
        /// Returns a summary for each view, optionally filtered by view type. View definitions
        /// are not included — use GetView to retrieve them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListViews service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/ListViews">REST API Reference for ListViews Operation</seealso>
        public virtual Task<ListViewsResponse> ListViewsAsync(ListViewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListViewsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListViewsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutIntelligenceConfiguration


        /// <summary>
        /// Creates or updates the intelligence configuration for the calling account. Account
        /// is identified via FAS (caller identity).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntelligenceConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutIntelligenceConfiguration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/PutIntelligenceConfiguration">REST API Reference for PutIntelligenceConfiguration Operation</seealso>
        public virtual PutIntelligenceConfigurationResponse PutIntelligenceConfiguration(PutIntelligenceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutIntelligenceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntelligenceConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutIntelligenceConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates the intelligence configuration for the calling account. Account
        /// is identified via FAS (caller identity).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntelligenceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutIntelligenceConfiguration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/PutIntelligenceConfiguration">REST API Reference for PutIntelligenceConfiguration Operation</seealso>
        public virtual Task<PutIntelligenceConfigurationResponse> PutIntelligenceConfigurationAsync(PutIntelligenceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutIntelligenceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntelligenceConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutIntelligenceConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchPrincipals


        /// <summary>
        /// Searches Identity Center for users and groups in a domain. The domain must be configured
        /// with Identity Center.
        /// 
        ///  
        /// <para>
        /// To grant access to a result, pass its principalId to CreateAccessGrant with a principalType
        /// of IDC_USER for a user or IDC_GROUP for a group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPrincipals service method.</param>
        /// 
        /// <returns>The response from the SearchPrincipals service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/SearchPrincipals">REST API Reference for SearchPrincipals Operation</seealso>
        public virtual SearchPrincipalsResponse SearchPrincipals(SearchPrincipalsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchPrincipalsResponseUnmarshaller.Instance;

            return Invoke<SearchPrincipalsResponse>(request, options);
        }


        /// <summary>
        /// Searches Identity Center for users and groups in a domain. The domain must be configured
        /// with Identity Center.
        /// 
        ///  
        /// <para>
        /// To grant access to a result, pass its principalId to CreateAccessGrant with a principalType
        /// of IDC_USER for a user or IDC_GROUP for a group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPrincipals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchPrincipals service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/SearchPrincipals">REST API Reference for SearchPrincipals Operation</seealso>
        public virtual Task<SearchPrincipalsResponse> SearchPrincipalsAsync(SearchPrincipalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchPrincipalsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchPrincipalsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTelemetryQuery


        /// <summary>
        /// Starts a telemetry query within a session.
        /// 
        ///  
        /// <para>
        /// Submits the provided query string for execution in the specified session. Use GetTelemetryQueryResults
        /// to poll for results and check query status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryQuery service method.</param>
        /// 
        /// <returns>The response from the StartTelemetryQuery service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StartTelemetryQuery">REST API Reference for StartTelemetryQuery Operation</seealso>
        public virtual StartTelemetryQueryResponse StartTelemetryQuery(StartTelemetryQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTelemetryQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryQueryResponseUnmarshaller.Instance;

            return Invoke<StartTelemetryQueryResponse>(request, options);
        }


        /// <summary>
        /// Starts a telemetry query within a session.
        /// 
        ///  
        /// <para>
        /// Submits the provided query string for execution in the specified session. Use GetTelemetryQueryResults
        /// to poll for results and check query status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTelemetryQuery service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StartTelemetryQuery">REST API Reference for StartTelemetryQuery Operation</seealso>
        public virtual Task<StartTelemetryQueryResponse> StartTelemetryQueryAsync(StartTelemetryQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTelemetryQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartTelemetryQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTelemetryQuerySession


        /// <summary>
        /// Starts a new telemetry query session.
        /// 
        ///  
        /// <para>
        /// A session provides a logical grouping for one or more telemetry queries. The returned
        /// session ID is required when starting queries via StartTelemetryQuery.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryQuerySession service method.</param>
        /// 
        /// <returns>The response from the StartTelemetryQuerySession service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StartTelemetryQuerySession">REST API Reference for StartTelemetryQuerySession Operation</seealso>
        public virtual StartTelemetryQuerySessionResponse StartTelemetryQuerySession(StartTelemetryQuerySessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTelemetryQuerySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryQuerySessionResponseUnmarshaller.Instance;

            return Invoke<StartTelemetryQuerySessionResponse>(request, options);
        }


        /// <summary>
        /// Starts a new telemetry query session.
        /// 
        ///  
        /// <para>
        /// A session provides a logical grouping for one or more telemetry queries. The returned
        /// session ID is required when starting queries via StartTelemetryQuery.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryQuerySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTelemetryQuerySession service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StartTelemetryQuerySession">REST API Reference for StartTelemetryQuerySession Operation</seealso>
        public virtual Task<StartTelemetryQuerySessionResponse> StartTelemetryQuerySessionAsync(StartTelemetryQuerySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTelemetryQuerySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryQuerySessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartTelemetryQuerySessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTelemetryQuery


        /// <summary>
        /// Stops a running telemetry query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryQuery service method.</param>
        /// 
        /// <returns>The response from the StopTelemetryQuery service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StopTelemetryQuery">REST API Reference for StopTelemetryQuery Operation</seealso>
        public virtual StopTelemetryQueryResponse StopTelemetryQuery(StopTelemetryQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopTelemetryQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryQueryResponseUnmarshaller.Instance;

            return Invoke<StopTelemetryQueryResponse>(request, options);
        }


        /// <summary>
        /// Stops a running telemetry query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTelemetryQuery service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StopTelemetryQuery">REST API Reference for StopTelemetryQuery Operation</seealso>
        public virtual Task<StopTelemetryQueryResponse> StopTelemetryQueryAsync(StopTelemetryQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopTelemetryQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopTelemetryQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTelemetryQuerySession


        /// <summary>
        /// Stops a telemetry query session.
        /// 
        ///  
        /// <para>
        /// Terminates the specified session. After a session is stopped it cannot be reused.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryQuerySession service method.</param>
        /// 
        /// <returns>The response from the StopTelemetryQuerySession service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StopTelemetryQuerySession">REST API Reference for StopTelemetryQuerySession Operation</seealso>
        public virtual StopTelemetryQuerySessionResponse StopTelemetryQuerySession(StopTelemetryQuerySessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopTelemetryQuerySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryQuerySessionResponseUnmarshaller.Instance;

            return Invoke<StopTelemetryQuerySessionResponse>(request, options);
        }


        /// <summary>
        /// Stops a telemetry query session.
        /// 
        ///  
        /// <para>
        /// Terminates the specified session. After a session is stopped it cannot be reused.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryQuerySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTelemetryQuerySession service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/StopTelemetryQuerySession">REST API Reference for StopTelemetryQuerySession Operation</seealso>
        public virtual Task<StopTelemetryQuerySessionResponse> StopTelemetryQuerySessionAsync(StopTelemetryQuerySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopTelemetryQuerySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryQuerySessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopTelemetryQuerySessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccessProfile


        /// <summary>
        /// Updates the name or description of an access profile.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateAccessProfile">REST API Reference for UpdateAccessProfile Operation</seealso>
        public virtual UpdateAccessProfileResponse UpdateAccessProfile(UpdateAccessProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessProfileResponse>(request, options);
        }


        /// <summary>
        /// Updates the name or description of an access profile.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessProfile service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateAccessProfile">REST API Reference for UpdateAccessProfile Operation</seealso>
        public virtual Task<UpdateAccessProfileResponse> UpdateAccessProfileAsync(UpdateAccessProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAccessProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlert


        /// <summary>
        /// Updates an existing alert.
        /// 
        ///  
        /// <para>
        /// Only non-null fields overwrite existing values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlert service method.</param>
        /// 
        /// <returns>The response from the UpdateAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateAlert">REST API Reference for UpdateAlert Operation</seealso>
        public virtual UpdateAlertResponse UpdateAlert(UpdateAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAlertResponseUnmarshaller.Instance;

            return Invoke<UpdateAlertResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing alert.
        /// 
        ///  
        /// <para>
        /// Only non-null fields overwrite existing values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlert service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateAlert">REST API Reference for UpdateAlert Operation</seealso>
        public virtual Task<UpdateAlertResponse> UpdateAlertAsync(UpdateAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAlertResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAlertResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomain


        /// <summary>
        /// Updates a domain's name or identity provider configuration.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged. Renaming
        /// a domain also changes the endpoint URLs derived from its name.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual UpdateDomainResponse UpdateDomain(UpdateDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainResponse>(request, options);
        }


        /// <summary>
        /// Updates a domain's name or identity provider configuration.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged. Renaming
        /// a domain also changes the endpoint URLs derived from its name.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainForOrganization


        /// <summary>
        /// Updates an organization domain's name or identity provider configuration. Call this
        /// operation in the Region where the domain was created.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged. Renaming
        /// a domain also changes the endpoint URLs derived from its name.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainForOrganization service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateDomainForOrganization">REST API Reference for UpdateDomainForOrganization Operation</seealso>
        public virtual UpdateDomainForOrganizationResponse UpdateDomainForOrganization(UpdateDomainForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainForOrganizationResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Updates an organization domain's name or identity provider configuration. Call this
        /// operation in the Region where the domain was created.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged. Renaming
        /// a domain also changes the endpoint URLs derived from its name.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainForOrganization service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateDomainForOrganization">REST API Reference for UpdateDomainForOrganization Operation</seealso>
        public virtual Task<UpdateDomainForOrganizationResponse> UpdateDomainForOrganizationAsync(UpdateDomainForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDomainForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIntegration


        /// <summary>
        /// Updates an existing integration, identified by its id, ARN, or name. Only the fields
        /// you provide are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing integration, identified by its id, ARN, or name. Only the fields
        /// you provide are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIntegration service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOmniDashboard


        /// <summary>
        /// Updates an existing dashboard within a space.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOmniDashboard service method.</param>
        /// 
        /// <returns>The response from the UpdateOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateOmniDashboard">REST API Reference for UpdateOmniDashboard Operation</seealso>
        public virtual UpdateOmniDashboardResponse UpdateOmniDashboard(UpdateOmniDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOmniDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOmniDashboardResponseUnmarshaller.Instance;

            return Invoke<UpdateOmniDashboardResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing dashboard within a space.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOmniDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOmniDashboard service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateOmniDashboard">REST API Reference for UpdateOmniDashboard Operation</seealso>
        public virtual Task<UpdateOmniDashboardResponse> UpdateOmniDashboardAsync(UpdateOmniDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOmniDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOmniDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateOmniDashboardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSpace


        /// <summary>
        /// Updates a space.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// 
        /// <returns>The response from the UpdateSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        public virtual UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSpaceResponseUnmarshaller.Instance;

            return Invoke<UpdateSpaceResponse>(request, options);
        }


        /// <summary>
        /// Updates a space.
        /// 
        ///  
        /// <para>
        /// Only the provided fields are changed; omitted fields are left unchanged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSpace service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        public virtual Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSpaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateView


        /// <summary>
        /// Updates an existing view's definition and/or description.
        /// 
        ///  
        /// <para>
        /// Only the fields you provide are changed. Managed views cannot be updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateView service method.</param>
        /// 
        /// <returns>The response from the UpdateView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateView">REST API Reference for UpdateView Operation</seealso>
        public virtual UpdateViewResponse UpdateView(UpdateViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateViewResponseUnmarshaller.Instance;

            return Invoke<UpdateViewResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing view's definition and/or description.
        /// 
        ///  
        /// <para>
        /// Only the fields you provide are changed. Managed views cannot be updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateView service method, as returned by CloudWatchOmni.</returns>
        /// <exception cref="Amazon.CloudWatchOmni.Model.AccessDeniedException">
        /// The caller is not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ConflictException">
        /// The operation could not be completed because of a conflict with the current state
        /// of the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ThrottlingException">
        /// The request was throttled due to exceeding the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchOmni.Model.ValidationException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudwatchomni-2025-01-01/UpdateView">REST API Reference for UpdateView Operation</seealso>
        public virtual Task<UpdateViewResponse> UpdateViewAsync(UpdateViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateViewResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateViewResponse>(request, options, cancellationToken);
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