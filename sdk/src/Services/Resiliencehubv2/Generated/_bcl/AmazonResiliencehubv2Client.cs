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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Resiliencehubv2.Model;
using Amazon.Resiliencehubv2.Model.Internal.MarshallTransformations;
using Amazon.Resiliencehubv2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Resiliencehubv2
{
    /// <summary>
    /// <para>Implementation for accessing Resiliencehubv2</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// The next generation of AWS Resilience Hub is the single location in AWS where you
    /// assess and improve the resilience of your critical applications. It helps Site Reliability
    /// Engineers (SREs) and development teams proactively reason about resilience at scale
    /// — identifying failure modes, discovering hidden dependencies, and report on progress
    /// across the enterprise.
    /// </summary>
    public partial class AmazonResiliencehubv2Client : AmazonServiceClient, IAmazonResiliencehubv2
    {
        private static IServiceMetadata serviceMetadata = new AmazonResiliencehubv2Metadata();
        private IResiliencehubv2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IResiliencehubv2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Resiliencehubv2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with the credentials loaded from the application's
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
        public AmazonResiliencehubv2Client()
            : base(new AmazonResiliencehubv2Config()) { }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with the credentials loaded from the application's
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
        public AmazonResiliencehubv2Client(RegionEndpoint region)
            : base(new AmazonResiliencehubv2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonResiliencehubv2Client Configuration Object</param>
        public AmazonResiliencehubv2Client(AmazonResiliencehubv2Config config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonResiliencehubv2Client(AWSCredentials credentials)
            : this(credentials, new AmazonResiliencehubv2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResiliencehubv2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonResiliencehubv2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with AWS Credentials and an
        /// AmazonResiliencehubv2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonResiliencehubv2Client Configuration Object</param>
        public AmazonResiliencehubv2Client(AWSCredentials credentials, AmazonResiliencehubv2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonResiliencehubv2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResiliencehubv2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResiliencehubv2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResiliencehubv2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResiliencehubv2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonResiliencehubv2Client Configuration Object</param>
        public AmazonResiliencehubv2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonResiliencehubv2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonResiliencehubv2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResiliencehubv2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResiliencehubv2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResiliencehubv2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResiliencehubv2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResiliencehubv2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonResiliencehubv2Client Configuration Object</param>
        public AmazonResiliencehubv2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonResiliencehubv2Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonResiliencehubv2EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonResiliencehubv2AuthSchemeHandler());
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


        #region  CreateAssertion


        /// <summary>
        /// Creates a resilience assertion for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssertion service method.</param>
        /// 
        /// <returns>The response from the CreateAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateAssertion">REST API Reference for CreateAssertion Operation</seealso>
        public virtual CreateAssertionResponse CreateAssertion(CreateAssertionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssertionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssertionResponseUnmarshaller.Instance;

            return Invoke<CreateAssertionResponse>(request, options);
        }


        /// <summary>
        /// Creates a resilience assertion for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssertion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateAssertion">REST API Reference for CreateAssertion Operation</seealso>
        public virtual Task<CreateAssertionResponse> CreateAssertionAsync(CreateAssertionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssertionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssertionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAssertionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInputSource


        /// <summary>
        /// Creates an input source for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSource service method.</param>
        /// 
        /// <returns>The response from the CreateInputSource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateInputSource">REST API Reference for CreateInputSource Operation</seealso>
        public virtual CreateInputSourceResponse CreateInputSource(CreateInputSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInputSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputSourceResponseUnmarshaller.Instance;

            return Invoke<CreateInputSourceResponse>(request, options);
        }


        /// <summary>
        /// Creates an input source for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInputSource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateInputSource">REST API Reference for CreateInputSource Operation</seealso>
        public virtual Task<CreateInputSourceResponse> CreateInputSourceAsync(CreateInputSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInputSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInputSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Creates a resilience policy that defines availability and disaster recovery requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyResponse>(request, options);
        }


        /// <summary>
        /// Creates a resilience policy that defines availability and disaster recovery requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReport


        /// <summary>
        /// On-demand report creation. Idempotent — duplicate requests with same clientToken return
        /// existing result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReport service method.</param>
        /// 
        /// <returns>The response from the CreateReport service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateReport">REST API Reference for CreateReport Operation</seealso>
        public virtual CreateReportResponse CreateReport(CreateReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReportResponseUnmarshaller.Instance;

            return Invoke<CreateReportResponse>(request, options);
        }


        /// <summary>
        /// On-demand report creation. Idempotent — duplicate requests with same clientToken return
        /// existing result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReport service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateReport">REST API Reference for CreateReport Operation</seealso>
        public virtual Task<CreateReportResponse> CreateReportAsync(CreateReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Creates a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return Invoke<CreateServiceResponse>(request, options);
        }


        /// <summary>
        /// Creates a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceFunction


        /// <summary>
        /// Creates a service function within a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceFunction service method.</param>
        /// 
        /// <returns>The response from the CreateServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateServiceFunction">REST API Reference for CreateServiceFunction Operation</seealso>
        public virtual CreateServiceFunctionResponse CreateServiceFunction(CreateServiceFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServiceFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateServiceFunctionResponse>(request, options);
        }


        /// <summary>
        /// Creates a service function within a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateServiceFunction">REST API Reference for CreateServiceFunction Operation</seealso>
        public virtual Task<CreateServiceFunctionResponse> CreateServiceFunctionAsync(CreateServiceFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServiceFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceFunctionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceFunctionResources


        /// <summary>
        /// Associates resources with a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceFunctionResources service method.</param>
        /// 
        /// <returns>The response from the CreateServiceFunctionResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateServiceFunctionResources">REST API Reference for CreateServiceFunctionResources Operation</seealso>
        public virtual CreateServiceFunctionResourcesResponse CreateServiceFunctionResources(CreateServiceFunctionResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServiceFunctionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceFunctionResourcesResponseUnmarshaller.Instance;

            return Invoke<CreateServiceFunctionResourcesResponse>(request, options);
        }


        /// <summary>
        /// Associates resources with a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceFunctionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceFunctionResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateServiceFunctionResources">REST API Reference for CreateServiceFunctionResources Operation</seealso>
        public virtual Task<CreateServiceFunctionResourcesResponse> CreateServiceFunctionResourcesAsync(CreateServiceFunctionResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServiceFunctionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceFunctionResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceFunctionResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSystem


        /// <summary>
        /// Creates a system that represents a logical grouping of services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystem service method.</param>
        /// 
        /// <returns>The response from the CreateSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateSystem">REST API Reference for CreateSystem Operation</seealso>
        public virtual CreateSystemResponse CreateSystem(CreateSystemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemResponseUnmarshaller.Instance;

            return Invoke<CreateSystemResponse>(request, options);
        }


        /// <summary>
        /// Creates a system that represents a logical grouping of services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateSystem">REST API Reference for CreateSystem Operation</seealso>
        public virtual Task<CreateSystemResponse> CreateSystemAsync(CreateSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUserJourney


        /// <summary>
        /// Creates a user journey within a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserJourney service method.</param>
        /// 
        /// <returns>The response from the CreateUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateUserJourney">REST API Reference for CreateUserJourney Operation</seealso>
        public virtual CreateUserJourneyResponse CreateUserJourney(CreateUserJourneyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserJourneyResponseUnmarshaller.Instance;

            return Invoke<CreateUserJourneyResponse>(request, options);
        }


        /// <summary>
        /// Creates a user journey within a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateUserJourney">REST API Reference for CreateUserJourney Operation</seealso>
        public virtual Task<CreateUserJourneyResponse> CreateUserJourneyAsync(CreateUserJourneyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserJourneyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateUserJourneyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssertion


        /// <summary>
        /// Deletes a resilience assertion from a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssertion service method.</param>
        /// 
        /// <returns>The response from the DeleteAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteAssertion">REST API Reference for DeleteAssertion Operation</seealso>
        public virtual DeleteAssertionResponse DeleteAssertion(DeleteAssertionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssertionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssertionResponseUnmarshaller.Instance;

            return Invoke<DeleteAssertionResponse>(request, options);
        }


        /// <summary>
        /// Deletes a resilience assertion from a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssertion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteAssertion">REST API Reference for DeleteAssertion Operation</seealso>
        public virtual Task<DeleteAssertionResponse> DeleteAssertionAsync(DeleteAssertionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssertionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssertionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAssertionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInputSource


        /// <summary>
        /// Deletes an input source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSource service method.</param>
        /// 
        /// <returns>The response from the DeleteInputSource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteInputSource">REST API Reference for DeleteInputSource Operation</seealso>
        public virtual DeleteInputSourceResponse DeleteInputSource(DeleteInputSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInputSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteInputSourceResponse>(request, options);
        }


        /// <summary>
        /// Deletes an input source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInputSource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteInputSource">REST API Reference for DeleteInputSource Operation</seealso>
        public virtual Task<DeleteInputSourceResponse> DeleteInputSourceAsync(DeleteInputSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInputSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInputSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes a resilience policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes a resilience policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteService


        /// <summary>
        /// Deletes a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceFunction


        /// <summary>
        /// Deletes a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteServiceFunction">REST API Reference for DeleteServiceFunction Operation</seealso>
        public virtual DeleteServiceFunctionResponse DeleteServiceFunction(DeleteServiceFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceFunctionResponse>(request, options);
        }


        /// <summary>
        /// Deletes a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteServiceFunction">REST API Reference for DeleteServiceFunction Operation</seealso>
        public virtual Task<DeleteServiceFunctionResponse> DeleteServiceFunctionAsync(DeleteServiceFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceFunctionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceFunctionResources


        /// <summary>
        /// Removes resources from a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceFunctionResources service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceFunctionResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteServiceFunctionResources">REST API Reference for DeleteServiceFunctionResources Operation</seealso>
        public virtual DeleteServiceFunctionResourcesResponse DeleteServiceFunctionResources(DeleteServiceFunctionResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceFunctionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceFunctionResourcesResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceFunctionResourcesResponse>(request, options);
        }


        /// <summary>
        /// Removes resources from a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceFunctionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceFunctionResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteServiceFunctionResources">REST API Reference for DeleteServiceFunctionResources Operation</seealso>
        public virtual Task<DeleteServiceFunctionResourcesResponse> DeleteServiceFunctionResourcesAsync(DeleteServiceFunctionResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceFunctionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceFunctionResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceFunctionResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSystem


        /// <summary>
        /// Deletes a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystem service method.</param>
        /// 
        /// <returns>The response from the DeleteSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteSystem">REST API Reference for DeleteSystem Operation</seealso>
        public virtual DeleteSystemResponse DeleteSystem(DeleteSystemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemResponseUnmarshaller.Instance;

            return Invoke<DeleteSystemResponse>(request, options);
        }


        /// <summary>
        /// Deletes a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteSystem">REST API Reference for DeleteSystem Operation</seealso>
        public virtual Task<DeleteSystemResponse> DeleteSystemAsync(DeleteSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserJourney


        /// <summary>
        /// Deletes a user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserJourney service method.</param>
        /// 
        /// <returns>The response from the DeleteUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteUserJourney">REST API Reference for DeleteUserJourney Operation</seealso>
        public virtual DeleteUserJourneyResponse DeleteUserJourney(DeleteUserJourneyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserJourneyResponseUnmarshaller.Instance;

            return Invoke<DeleteUserJourneyResponse>(request, options);
        }


        /// <summary>
        /// Deletes a user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteUserJourney">REST API Reference for DeleteUserJourney Operation</seealso>
        public virtual Task<DeleteUserJourneyResponse> DeleteUserJourneyAsync(DeleteUserJourneyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserJourneyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteUserJourneyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFailureModeFinding


        /// <summary>
        /// Retrieves a finding by findingId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFailureModeFinding service method.</param>
        /// 
        /// <returns>The response from the GetFailureModeFinding service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetFailureModeFinding">REST API Reference for GetFailureModeFinding Operation</seealso>
        public virtual GetFailureModeFindingResponse GetFailureModeFinding(GetFailureModeFindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFailureModeFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFailureModeFindingResponseUnmarshaller.Instance;

            return Invoke<GetFailureModeFindingResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a finding by findingId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFailureModeFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFailureModeFinding service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetFailureModeFinding">REST API Reference for GetFailureModeFinding Operation</seealso>
        public virtual Task<GetFailureModeFindingResponse> GetFailureModeFindingAsync(GetFailureModeFindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFailureModeFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFailureModeFindingResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFailureModeFindingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Retrieves a resilience policy by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a resilience policy by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetService


        /// <summary>
        /// Retrieves a service by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// 
        /// <returns>The response from the GetService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetService">REST API Reference for GetService Operation</seealso>
        public virtual GetServiceResponse GetService(GetServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return Invoke<GetServiceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a service by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetService">REST API Reference for GetService Operation</seealso>
        public virtual Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSystem


        /// <summary>
        /// Retrieves a system by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystem service method.</param>
        /// 
        /// <returns>The response from the GetSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetSystem">REST API Reference for GetSystem Operation</seealso>
        public virtual GetSystemResponse GetSystem(GetSystemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemResponseUnmarshaller.Instance;

            return Invoke<GetSystemResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a system by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetSystem">REST API Reference for GetSystem Operation</seealso>
        public virtual Task<GetSystemResponse> GetSystemAsync(GetSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserJourney


        /// <summary>
        /// Retrieves a user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserJourney service method.</param>
        /// 
        /// <returns>The response from the GetUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetUserJourney">REST API Reference for GetUserJourney Operation</seealso>
        public virtual GetUserJourneyResponse GetUserJourney(GetUserJourneyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserJourneyResponseUnmarshaller.Instance;

            return Invoke<GetUserJourneyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetUserJourney">REST API Reference for GetUserJourney Operation</seealso>
        public virtual Task<GetUserJourneyResponse> GetUserJourneyAsync(GetUserJourneyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserJourneyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUserJourneyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportApp


        /// <summary>
        /// Imports a V1 app into the V2 resource model, creating a service with the same name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApp service method.</param>
        /// 
        /// <returns>The response from the ImportApp service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ImportApp">REST API Reference for ImportApp Operation</seealso>
        public virtual ImportAppResponse ImportApp(ImportAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportAppResponseUnmarshaller.Instance;

            return Invoke<ImportAppResponse>(request, options);
        }


        /// <summary>
        /// Imports a V1 app into the V2 resource model, creating a service with the same name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportApp service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ImportApp">REST API Reference for ImportApp Operation</seealso>
        public virtual Task<ImportAppResponse> ImportAppAsync(ImportAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportAppResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportPolicy


        /// <summary>
        /// Imports a V1 policy into V2, mapping RTO/RPO values from V1 scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportPolicy service method.</param>
        /// 
        /// <returns>The response from the ImportPolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ImportPolicy">REST API Reference for ImportPolicy Operation</seealso>
        public virtual ImportPolicyResponse ImportPolicy(ImportPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportPolicyResponseUnmarshaller.Instance;

            return Invoke<ImportPolicyResponse>(request, options);
        }


        /// <summary>
        /// Imports a V1 policy into V2, mapping RTO/RPO values from V1 scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportPolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ImportPolicy">REST API Reference for ImportPolicy Operation</seealso>
        public virtual Task<ImportPolicyResponse> ImportPolicyAsync(ImportPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssertions


        /// <summary>
        /// Lists resilience assertions for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssertions service method.</param>
        /// 
        /// <returns>The response from the ListAssertions service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListAssertions">REST API Reference for ListAssertions Operation</seealso>
        public virtual ListAssertionsResponse ListAssertions(ListAssertionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssertionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssertionsResponseUnmarshaller.Instance;

            return Invoke<ListAssertionsResponse>(request, options);
        }


        /// <summary>
        /// Lists resilience assertions for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssertions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssertions service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListAssertions">REST API Reference for ListAssertions Operation</seealso>
        public virtual Task<ListAssertionsResponse> ListAssertionsAsync(ListAssertionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssertionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssertionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssertionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDependencies


        /// <summary>
        /// Lists dependencies discovered for services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDependencies service method.</param>
        /// 
        /// <returns>The response from the ListDependencies service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListDependencies">REST API Reference for ListDependencies Operation</seealso>
        public virtual ListDependenciesResponse ListDependencies(ListDependenciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDependenciesResponseUnmarshaller.Instance;

            return Invoke<ListDependenciesResponse>(request, options);
        }


        /// <summary>
        /// Lists dependencies discovered for services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDependencies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDependencies service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListDependencies">REST API Reference for ListDependencies Operation</seealso>
        public virtual Task<ListDependenciesResponse> ListDependenciesAsync(ListDependenciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDependenciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDependenciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFailureModeAssessments


        /// <summary>
        /// Lists failure mode assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailureModeAssessments service method.</param>
        /// 
        /// <returns>The response from the ListFailureModeAssessments service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListFailureModeAssessments">REST API Reference for ListFailureModeAssessments Operation</seealso>
        public virtual ListFailureModeAssessmentsResponse ListFailureModeAssessments(ListFailureModeAssessmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFailureModeAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFailureModeAssessmentsResponseUnmarshaller.Instance;

            return Invoke<ListFailureModeAssessmentsResponse>(request, options);
        }


        /// <summary>
        /// Lists failure mode assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailureModeAssessments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFailureModeAssessments service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListFailureModeAssessments">REST API Reference for ListFailureModeAssessments Operation</seealso>
        public virtual Task<ListFailureModeAssessmentsResponse> ListFailureModeAssessmentsAsync(ListFailureModeAssessmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFailureModeAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFailureModeAssessmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFailureModeAssessmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFailureModeFindings


        /// <summary>
        /// List findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailureModeFindings service method.</param>
        /// 
        /// <returns>The response from the ListFailureModeFindings service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListFailureModeFindings">REST API Reference for ListFailureModeFindings Operation</seealso>
        public virtual ListFailureModeFindingsResponse ListFailureModeFindings(ListFailureModeFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFailureModeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFailureModeFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFailureModeFindingsResponse>(request, options);
        }


        /// <summary>
        /// List findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailureModeFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFailureModeFindings service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListFailureModeFindings">REST API Reference for ListFailureModeFindings Operation</seealso>
        public virtual Task<ListFailureModeFindingsResponse> ListFailureModeFindingsAsync(ListFailureModeFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFailureModeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFailureModeFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFailureModeFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInputSources


        /// <summary>
        /// Lists input sources for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputSources service method.</param>
        /// 
        /// <returns>The response from the ListInputSources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListInputSources">REST API Reference for ListInputSources Operation</seealso>
        public virtual ListInputSourcesResponse ListInputSources(ListInputSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInputSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputSourcesResponseUnmarshaller.Instance;

            return Invoke<ListInputSourcesResponse>(request, options);
        }


        /// <summary>
        /// Lists input sources for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInputSources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListInputSources">REST API Reference for ListInputSources Operation</seealso>
        public virtual Task<ListInputSourcesResponse> ListInputSourcesAsync(ListInputSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInputSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputSourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInputSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Lists resilience policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists resilience policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReports


        /// <summary>
        /// List reports for a service, or all reports owned by the account if serviceArn is not
        /// provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListReports">REST API Reference for ListReports Operation</seealso>
        public virtual ListReportsResponse ListReports(ListReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportsResponseUnmarshaller.Instance;

            return Invoke<ListReportsResponse>(request, options);
        }


        /// <summary>
        /// List reports for a service, or all reports owned by the account if serviceArn is not
        /// provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListReports">REST API Reference for ListReports Operation</seealso>
        public virtual Task<ListReportsResponse> ListReportsAsync(ListReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListReportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResources


        /// <summary>
        /// List resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourcesResponse>(request, options);
        }


        /// <summary>
        /// List resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceEvents


        /// <summary>
        /// Lists events for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceEvents service method.</param>
        /// 
        /// <returns>The response from the ListServiceEvents service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceEvents">REST API Reference for ListServiceEvents Operation</seealso>
        public virtual ListServiceEventsResponse ListServiceEvents(ListServiceEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceEventsResponseUnmarshaller.Instance;

            return Invoke<ListServiceEventsResponse>(request, options);
        }


        /// <summary>
        /// Lists events for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceEvents service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceEvents">REST API Reference for ListServiceEvents Operation</seealso>
        public virtual Task<ListServiceEventsResponse> ListServiceEventsAsync(ListServiceEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceFunctions


        /// <summary>
        /// Lists service functions for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceFunctions service method.</param>
        /// 
        /// <returns>The response from the ListServiceFunctions service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceFunctions">REST API Reference for ListServiceFunctions Operation</seealso>
        public virtual ListServiceFunctionsResponse ListServiceFunctions(ListServiceFunctionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListServiceFunctionsResponse>(request, options);
        }


        /// <summary>
        /// Lists service functions for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceFunctions service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceFunctions">REST API Reference for ListServiceFunctions Operation</seealso>
        public virtual Task<ListServiceFunctionsResponse> ListServiceFunctionsAsync(ListServiceFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceFunctionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceFunctionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Lists services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }


        /// <summary>
        /// Lists services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceTopologyEdges


        /// <summary>
        /// Lists topology edges for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceTopologyEdges service method.</param>
        /// 
        /// <returns>The response from the ListServiceTopologyEdges service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceTopologyEdges">REST API Reference for ListServiceTopologyEdges Operation</seealso>
        public virtual ListServiceTopologyEdgesResponse ListServiceTopologyEdges(ListServiceTopologyEdgesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceTopologyEdgesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceTopologyEdgesResponseUnmarshaller.Instance;

            return Invoke<ListServiceTopologyEdgesResponse>(request, options);
        }


        /// <summary>
        /// Lists topology edges for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceTopologyEdges service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceTopologyEdges service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceTopologyEdges">REST API Reference for ListServiceTopologyEdges Operation</seealso>
        public virtual Task<ListServiceTopologyEdgesResponse> ListServiceTopologyEdgesAsync(ListServiceTopologyEdgesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceTopologyEdgesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceTopologyEdgesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceTopologyEdgesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSystemEvents


        /// <summary>
        /// Lists events for a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystemEvents service method.</param>
        /// 
        /// <returns>The response from the ListSystemEvents service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListSystemEvents">REST API Reference for ListSystemEvents Operation</seealso>
        public virtual ListSystemEventsResponse ListSystemEvents(ListSystemEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemEventsResponseUnmarshaller.Instance;

            return Invoke<ListSystemEventsResponse>(request, options);
        }


        /// <summary>
        /// Lists events for a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystemEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSystemEvents service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListSystemEvents">REST API Reference for ListSystemEvents Operation</seealso>
        public virtual Task<ListSystemEventsResponse> ListSystemEventsAsync(ListSystemEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSystemEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSystems


        /// <summary>
        /// Lists systems.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystems service method.</param>
        /// 
        /// <returns>The response from the ListSystems service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListSystems">REST API Reference for ListSystems Operation</seealso>
        public virtual ListSystemsResponse ListSystems(ListSystemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemsResponseUnmarshaller.Instance;

            return Invoke<ListSystemsResponse>(request, options);
        }


        /// <summary>
        /// Lists systems.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSystems service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListSystems">REST API Reference for ListSystems Operation</seealso>
        public virtual Task<ListSystemsResponse> ListSystemsAsync(ListSystemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSystemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUserJourneys


        /// <summary>
        /// Lists user journeys for a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserJourneys service method.</param>
        /// 
        /// <returns>The response from the ListUserJourneys service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListUserJourneys">REST API Reference for ListUserJourneys Operation</seealso>
        public virtual ListUserJourneysResponse ListUserJourneys(ListUserJourneysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUserJourneysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserJourneysResponseUnmarshaller.Instance;

            return Invoke<ListUserJourneysResponse>(request, options);
        }


        /// <summary>
        /// Lists user journeys for a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserJourneys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserJourneys service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListUserJourneys">REST API Reference for ListUserJourneys Operation</seealso>
        public virtual Task<ListUserJourneysResponse> ListUserJourneysAsync(ListUserJourneysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUserJourneysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserJourneysResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListUserJourneysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFailureModeAssessment


        /// <summary>
        /// Starts a failure mode assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFailureModeAssessment service method.</param>
        /// 
        /// <returns>The response from the StartFailureModeAssessment service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/StartFailureModeAssessment">REST API Reference for StartFailureModeAssessment Operation</seealso>
        public virtual StartFailureModeAssessmentResponse StartFailureModeAssessment(StartFailureModeAssessmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFailureModeAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFailureModeAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartFailureModeAssessmentResponse>(request, options);
        }


        /// <summary>
        /// Starts a failure mode assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFailureModeAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFailureModeAssessment service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/StartFailureModeAssessment">REST API Reference for StartFailureModeAssessment Operation</seealso>
        public virtual Task<StartFailureModeAssessmentResponse> StartFailureModeAssessmentAsync(StartFailureModeAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFailureModeAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFailureModeAssessmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartFailureModeAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssertion


        /// <summary>
        /// Updates a resilience assertion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssertion service method.</param>
        /// 
        /// <returns>The response from the UpdateAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateAssertion">REST API Reference for UpdateAssertion Operation</seealso>
        public virtual UpdateAssertionResponse UpdateAssertion(UpdateAssertionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssertionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssertionResponseUnmarshaller.Instance;

            return Invoke<UpdateAssertionResponse>(request, options);
        }


        /// <summary>
        /// Updates a resilience assertion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssertion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateAssertion">REST API Reference for UpdateAssertion Operation</seealso>
        public virtual Task<UpdateAssertionResponse> UpdateAssertionAsync(UpdateAssertionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssertionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssertionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAssertionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDependency


        /// <summary>
        /// Updates a dependency classification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDependency service method.</param>
        /// 
        /// <returns>The response from the UpdateDependency service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateDependency">REST API Reference for UpdateDependency Operation</seealso>
        public virtual UpdateDependencyResponse UpdateDependency(UpdateDependencyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDependencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDependencyResponseUnmarshaller.Instance;

            return Invoke<UpdateDependencyResponse>(request, options);
        }


        /// <summary>
        /// Updates a dependency classification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDependency service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDependency service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateDependency">REST API Reference for UpdateDependency Operation</seealso>
        public virtual Task<UpdateDependencyResponse> UpdateDependencyAsync(UpdateDependencyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDependencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDependencyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDependencyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFailureModeFinding


        /// <summary>
        /// Updates an existing finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFailureModeFinding service method.</param>
        /// 
        /// <returns>The response from the UpdateFailureModeFinding service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateFailureModeFinding">REST API Reference for UpdateFailureModeFinding Operation</seealso>
        public virtual UpdateFailureModeFindingResponse UpdateFailureModeFinding(UpdateFailureModeFindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFailureModeFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFailureModeFindingResponseUnmarshaller.Instance;

            return Invoke<UpdateFailureModeFindingResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFailureModeFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFailureModeFinding service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateFailureModeFinding">REST API Reference for UpdateFailureModeFinding Operation</seealso>
        public virtual Task<UpdateFailureModeFindingResponse> UpdateFailureModeFindingAsync(UpdateFailureModeFindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFailureModeFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFailureModeFindingResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFailureModeFindingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePolicy


        /// <summary>
        /// Updates an existing resilience policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        public virtual UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdatePolicyResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing resilience policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        public virtual Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Updates an existing service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceFunction


        /// <summary>
        /// Updates a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceFunction service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateServiceFunction">REST API Reference for UpdateServiceFunction Operation</seealso>
        public virtual UpdateServiceFunctionResponse UpdateServiceFunction(UpdateServiceFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceFunctionResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceFunctionResponse>(request, options);
        }


        /// <summary>
        /// Updates a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateServiceFunction">REST API Reference for UpdateServiceFunction Operation</seealso>
        public virtual Task<UpdateServiceFunctionResponse> UpdateServiceFunctionAsync(UpdateServiceFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceFunctionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSystem


        /// <summary>
        /// Updates an existing system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystem service method.</param>
        /// 
        /// <returns>The response from the UpdateSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateSystem">REST API Reference for UpdateSystem Operation</seealso>
        public virtual UpdateSystemResponse UpdateSystem(UpdateSystemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSystemResponseUnmarshaller.Instance;

            return Invoke<UpdateSystemResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateSystem">REST API Reference for UpdateSystem Operation</seealso>
        public virtual Task<UpdateSystemResponse> UpdateSystemAsync(UpdateSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSystemResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserJourney


        /// <summary>
        /// Updates an existing user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserJourney service method.</param>
        /// 
        /// <returns>The response from the UpdateUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateUserJourney">REST API Reference for UpdateUserJourney Operation</seealso>
        public virtual UpdateUserJourneyResponse UpdateUserJourney(UpdateUserJourneyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserJourneyResponseUnmarshaller.Instance;

            return Invoke<UpdateUserJourneyResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateUserJourney">REST API Reference for UpdateUserJourney Operation</seealso>
        public virtual Task<UpdateUserJourneyResponse> UpdateUserJourneyAsync(UpdateUserJourneyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserJourneyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateUserJourneyResponse>(request, options, cancellationToken);
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