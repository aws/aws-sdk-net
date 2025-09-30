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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Outposts.Model;
using Amazon.Outposts.Model.Internal.MarshallTransformations;
using Amazon.Outposts.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Outposts
{
    /// <summary>
    /// <para>Implementation for accessing Outposts</para>
    ///
    /// Amazon Web Services Outposts is a fully managed service that extends Amazon Web Services
    /// infrastructure, APIs, and tools to customer premises. By providing local access to
    /// Amazon Web Services managed infrastructure, Amazon Web Services Outposts enables customers
    /// to build and run applications on premises using the same programming interfaces as
    /// in Amazon Web Services Regions, while using local compute and storage resources for
    /// lower latency and local data processing needs.
    /// </summary>
    public partial class AmazonOutpostsClient : AmazonServiceClient, IAmazonOutposts
    {
        private static IServiceMetadata serviceMetadata = new AmazonOutpostsMetadata();
        private IOutpostsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOutpostsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OutpostsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonOutpostsClient with the credentials loaded from the application's
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
        public AmazonOutpostsClient()
            : base(new AmazonOutpostsConfig()) { }

        /// <summary>
        /// Constructs AmazonOutpostsClient with the credentials loaded from the application's
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
        public AmazonOutpostsClient(RegionEndpoint region)
            : base(new AmazonOutpostsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOutpostsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOutpostsClient Configuration Object</param>
        public AmazonOutpostsClient(AmazonOutpostsConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOutpostsClient(AWSCredentials credentials)
            : this(credentials, new AmazonOutpostsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOutpostsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOutpostsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Credentials and an
        /// AmazonOutpostsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOutpostsClient Configuration Object</param>
        public AmazonOutpostsClient(AWSCredentials credentials, AmazonOutpostsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOutpostsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOutpostsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOutpostsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOutpostsClient Configuration Object</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOutpostsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOutpostsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOutpostsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOutpostsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOutpostsClient Configuration Object</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOutpostsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOutpostsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOutpostsAuthSchemeHandler());
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


        #region  CancelCapacityTask


        /// <summary>
        /// Cancels the capacity task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCapacityTask service method.</param>
        /// 
        /// <returns>The response from the CancelCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CancelCapacityTask">REST API Reference for CancelCapacityTask Operation</seealso>
        public virtual CancelCapacityTaskResponse CancelCapacityTask(CancelCapacityTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelCapacityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCapacityTaskResponseUnmarshaller.Instance;

            return Invoke<CancelCapacityTaskResponse>(request, options);
        }


        /// <summary>
        /// Cancels the capacity task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCapacityTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CancelCapacityTask">REST API Reference for CancelCapacityTask Operation</seealso>
        public virtual Task<CancelCapacityTaskResponse> CancelCapacityTaskAsync(CancelCapacityTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelCapacityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCapacityTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelCapacityTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelOrder


        /// <summary>
        /// Cancels the specified order for an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelOrder service method.</param>
        /// 
        /// <returns>The response from the CancelOrder service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CancelOrder">REST API Reference for CancelOrder Operation</seealso>
        public virtual CancelOrderResponse CancelOrder(CancelOrderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelOrderResponseUnmarshaller.Instance;

            return Invoke<CancelOrderResponse>(request, options);
        }


        /// <summary>
        /// Cancels the specified order for an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelOrder service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CancelOrder">REST API Reference for CancelOrder Operation</seealso>
        public virtual Task<CancelOrderResponse> CancelOrderAsync(CancelOrderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelOrderResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelOrderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOrder


        /// <summary>
        /// Creates an order for an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrder service method.</param>
        /// 
        /// <returns>The response from the CreateOrder service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOrder">REST API Reference for CreateOrder Operation</seealso>
        public virtual CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrderResponseUnmarshaller.Instance;

            return Invoke<CreateOrderResponse>(request, options);
        }


        /// <summary>
        /// Creates an order for an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOrder service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOrder">REST API Reference for CreateOrder Operation</seealso>
        public virtual Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrderResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOrderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOutpost


        /// <summary>
        /// Creates an Outpost.
        /// 
        ///  
        /// <para>
        /// You can specify either an Availability one or an AZ ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutpost service method.</param>
        /// 
        /// <returns>The response from the CreateOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOutpost">REST API Reference for CreateOutpost Operation</seealso>
        public virtual CreateOutpostResponse CreateOutpost(CreateOutpostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutpostResponseUnmarshaller.Instance;

            return Invoke<CreateOutpostResponse>(request, options);
        }


        /// <summary>
        /// Creates an Outpost.
        /// 
        ///  
        /// <para>
        /// You can specify either an Availability one or an AZ ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutpost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOutpost">REST API Reference for CreateOutpost Operation</seealso>
        public virtual Task<CreateOutpostResponse> CreateOutpostAsync(CreateOutpostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutpostResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOutpostResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSite


        /// <summary>
        /// Creates a site for an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSite service method.</param>
        /// 
        /// <returns>The response from the CreateSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateSite">REST API Reference for CreateSite Operation</seealso>
        public virtual CreateSiteResponse CreateSite(CreateSiteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteResponseUnmarshaller.Instance;

            return Invoke<CreateSiteResponse>(request, options);
        }


        /// <summary>
        /// Creates a site for an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateSite">REST API Reference for CreateSite Operation</seealso>
        public virtual Task<CreateSiteResponse> CreateSiteAsync(CreateSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOutpost


        /// <summary>
        /// Deletes the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutpost service method.</param>
        /// 
        /// <returns>The response from the DeleteOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/DeleteOutpost">REST API Reference for DeleteOutpost Operation</seealso>
        public virtual DeleteOutpostResponse DeleteOutpost(DeleteOutpostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutpostResponseUnmarshaller.Instance;

            return Invoke<DeleteOutpostResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutpost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/DeleteOutpost">REST API Reference for DeleteOutpost Operation</seealso>
        public virtual Task<DeleteOutpostResponse> DeleteOutpostAsync(DeleteOutpostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutpostResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOutpostResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSite


        /// <summary>
        /// Deletes the specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite service method.</param>
        /// 
        /// <returns>The response from the DeleteSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        public virtual DeleteSiteResponse DeleteSite(DeleteSiteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSiteResponseUnmarshaller.Instance;

            return Invoke<DeleteSiteResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        public virtual Task<DeleteSiteResponse> DeleteSiteAsync(DeleteSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSiteResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCapacityTask


        /// <summary>
        /// Gets details of the specified capacity task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCapacityTask service method.</param>
        /// 
        /// <returns>The response from the GetCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetCapacityTask">REST API Reference for GetCapacityTask Operation</seealso>
        public virtual GetCapacityTaskResponse GetCapacityTask(GetCapacityTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCapacityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCapacityTaskResponseUnmarshaller.Instance;

            return Invoke<GetCapacityTaskResponse>(request, options);
        }


        /// <summary>
        /// Gets details of the specified capacity task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCapacityTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetCapacityTask">REST API Reference for GetCapacityTask Operation</seealso>
        public virtual Task<GetCapacityTaskResponse> GetCapacityTaskAsync(GetCapacityTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCapacityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCapacityTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCapacityTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCatalogItem


        /// <summary>
        /// Gets information about the specified catalog item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogItem service method.</param>
        /// 
        /// <returns>The response from the GetCatalogItem service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetCatalogItem">REST API Reference for GetCatalogItem Operation</seealso>
        public virtual GetCatalogItemResponse GetCatalogItem(GetCatalogItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCatalogItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCatalogItemResponseUnmarshaller.Instance;

            return Invoke<GetCatalogItemResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified catalog item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCatalogItem service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetCatalogItem">REST API Reference for GetCatalogItem Operation</seealso>
        public virtual Task<GetCatalogItemResponse> GetCatalogItemAsync(GetCatalogItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCatalogItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCatalogItemResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCatalogItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnection


        /// <summary>
        /// <note> 
        /// <para>
        ///  Amazon Web Services uses this action to install Outpost servers.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Gets information about the specified connection. 
        /// </para>
        ///  
        /// <para>
        ///  Use CloudTrail to monitor this action or Amazon Web Services managed policy for Amazon
        /// Web Services Outposts to secure it. For more information, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/security-iam-awsmanpol.html">
        /// Amazon Web Services managed policies for Amazon Web Services Outposts</a> and <a href="https://docs.aws.amazon.com/outposts/latest/userguide/logging-using-cloudtrail.html">
        /// Logging Amazon Web Services Outposts API calls with Amazon Web Services CloudTrail</a>
        /// in the <i>Amazon Web Services Outposts User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        ///  Amazon Web Services uses this action to install Outpost servers.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Gets information about the specified connection. 
        /// </para>
        ///  
        /// <para>
        ///  Use CloudTrail to monitor this action or Amazon Web Services managed policy for Amazon
        /// Web Services Outposts to secure it. For more information, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/security-iam-awsmanpol.html">
        /// Amazon Web Services managed policies for Amazon Web Services Outposts</a> and <a href="https://docs.aws.amazon.com/outposts/latest/userguide/logging-using-cloudtrail.html">
        /// Logging Amazon Web Services Outposts API calls with Amazon Web Services CloudTrail</a>
        /// in the <i>Amazon Web Services Outposts User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOrder


        /// <summary>
        /// Gets information about the specified order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrder service method.</param>
        /// 
        /// <returns>The response from the GetOrder service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        public virtual GetOrderResponse GetOrder(GetOrderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrderResponseUnmarshaller.Instance;

            return Invoke<GetOrderResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOrder service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        public virtual Task<GetOrderResponse> GetOrderAsync(GetOrderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrderResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOrderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOutpost


        /// <summary>
        /// Gets information about the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpost service method.</param>
        /// 
        /// <returns>The response from the GetOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpost">REST API Reference for GetOutpost Operation</seealso>
        public virtual GetOutpostResponse GetOutpost(GetOutpostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostResponseUnmarshaller.Instance;

            return Invoke<GetOutpostResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpost">REST API Reference for GetOutpost Operation</seealso>
        public virtual Task<GetOutpostResponse> GetOutpostAsync(GetOutpostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOutpostResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOutpostBillingInformation


        /// <summary>
        /// Gets current and historical billing information about the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostBillingInformation service method.</param>
        /// 
        /// <returns>The response from the GetOutpostBillingInformation service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostBillingInformation">REST API Reference for GetOutpostBillingInformation Operation</seealso>
        public virtual GetOutpostBillingInformationResponse GetOutpostBillingInformation(GetOutpostBillingInformationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutpostBillingInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostBillingInformationResponseUnmarshaller.Instance;

            return Invoke<GetOutpostBillingInformationResponse>(request, options);
        }


        /// <summary>
        /// Gets current and historical billing information about the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostBillingInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOutpostBillingInformation service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostBillingInformation">REST API Reference for GetOutpostBillingInformation Operation</seealso>
        public virtual Task<GetOutpostBillingInformationResponse> GetOutpostBillingInformationAsync(GetOutpostBillingInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutpostBillingInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostBillingInformationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOutpostBillingInformationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOutpostInstanceTypes


        /// <summary>
        /// Gets the instance types for the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the GetOutpostInstanceTypes service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostInstanceTypes">REST API Reference for GetOutpostInstanceTypes Operation</seealso>
        public virtual GetOutpostInstanceTypesResponse GetOutpostInstanceTypes(GetOutpostInstanceTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutpostInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostInstanceTypesResponseUnmarshaller.Instance;

            return Invoke<GetOutpostInstanceTypesResponse>(request, options);
        }


        /// <summary>
        /// Gets the instance types for the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostInstanceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOutpostInstanceTypes service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostInstanceTypes">REST API Reference for GetOutpostInstanceTypes Operation</seealso>
        public virtual Task<GetOutpostInstanceTypesResponse> GetOutpostInstanceTypesAsync(GetOutpostInstanceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutpostInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostInstanceTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOutpostInstanceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOutpostSupportedInstanceTypes


        /// <summary>
        /// Gets the instance types that an Outpost can support in <c>InstanceTypeCapacity</c>.
        /// This will generally include instance types that are not currently configured and therefore
        /// cannot be launched with the current Outpost capacity configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostSupportedInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the GetOutpostSupportedInstanceTypes service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostSupportedInstanceTypes">REST API Reference for GetOutpostSupportedInstanceTypes Operation</seealso>
        public virtual GetOutpostSupportedInstanceTypesResponse GetOutpostSupportedInstanceTypes(GetOutpostSupportedInstanceTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutpostSupportedInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostSupportedInstanceTypesResponseUnmarshaller.Instance;

            return Invoke<GetOutpostSupportedInstanceTypesResponse>(request, options);
        }


        /// <summary>
        /// Gets the instance types that an Outpost can support in <c>InstanceTypeCapacity</c>.
        /// This will generally include instance types that are not currently configured and therefore
        /// cannot be launched with the current Outpost capacity configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostSupportedInstanceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOutpostSupportedInstanceTypes service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostSupportedInstanceTypes">REST API Reference for GetOutpostSupportedInstanceTypes Operation</seealso>
        public virtual Task<GetOutpostSupportedInstanceTypesResponse> GetOutpostSupportedInstanceTypesAsync(GetOutpostSupportedInstanceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutpostSupportedInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostSupportedInstanceTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOutpostSupportedInstanceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSite


        /// <summary>
        /// Gets information about the specified Outpost site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSite service method.</param>
        /// 
        /// <returns>The response from the GetSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetSite">REST API Reference for GetSite Operation</seealso>
        public virtual GetSiteResponse GetSite(GetSiteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSiteResponseUnmarshaller.Instance;

            return Invoke<GetSiteResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified Outpost site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetSite">REST API Reference for GetSite Operation</seealso>
        public virtual Task<GetSiteResponse> GetSiteAsync(GetSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSiteResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSiteAddress


        /// <summary>
        /// Gets the site address of the specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSiteAddress service method.</param>
        /// 
        /// <returns>The response from the GetSiteAddress service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetSiteAddress">REST API Reference for GetSiteAddress Operation</seealso>
        public virtual GetSiteAddressResponse GetSiteAddress(GetSiteAddressRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSiteAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSiteAddressResponseUnmarshaller.Instance;

            return Invoke<GetSiteAddressResponse>(request, options);
        }


        /// <summary>
        /// Gets the site address of the specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSiteAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSiteAddress service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetSiteAddress">REST API Reference for GetSiteAddress Operation</seealso>
        public virtual Task<GetSiteAddressResponse> GetSiteAddressAsync(GetSiteAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSiteAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSiteAddressResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSiteAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssetInstances


        /// <summary>
        /// A list of Amazon EC2 instances, belonging to all accounts, running on the specified
        /// Outpost. Does not include Amazon EBS or Amazon S3 instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetInstances service method.</param>
        /// 
        /// <returns>The response from the ListAssetInstances service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListAssetInstances">REST API Reference for ListAssetInstances Operation</seealso>
        public virtual ListAssetInstancesResponse ListAssetInstances(ListAssetInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetInstancesResponseUnmarshaller.Instance;

            return Invoke<ListAssetInstancesResponse>(request, options);
        }


        /// <summary>
        /// A list of Amazon EC2 instances, belonging to all accounts, running on the specified
        /// Outpost. Does not include Amazon EBS or Amazon S3 instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetInstances service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListAssetInstances">REST API Reference for ListAssetInstances Operation</seealso>
        public virtual Task<ListAssetInstancesResponse> ListAssetInstancesAsync(ListAssetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssetInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssets


        /// <summary>
        /// Lists the hardware assets for the specified Outpost.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssets service method.</param>
        /// 
        /// <returns>The response from the ListAssets service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListAssets">REST API Reference for ListAssets Operation</seealso>
        public virtual ListAssetsResponse ListAssets(ListAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetsResponseUnmarshaller.Instance;

            return Invoke<ListAssetsResponse>(request, options);
        }


        /// <summary>
        /// Lists the hardware assets for the specified Outpost.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssets service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListAssets">REST API Reference for ListAssets Operation</seealso>
        public virtual Task<ListAssetsResponse> ListAssetsAsync(ListAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBlockingInstancesForCapacityTask


        /// <summary>
        /// A list of Amazon EC2 instances running on the Outpost and belonging to the account
        /// that initiated the capacity task. Use this list to specify the instances you cannot
        /// stop to free up capacity to run the capacity task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlockingInstancesForCapacityTask service method.</param>
        /// 
        /// <returns>The response from the ListBlockingInstancesForCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListBlockingInstancesForCapacityTask">REST API Reference for ListBlockingInstancesForCapacityTask Operation</seealso>
        public virtual ListBlockingInstancesForCapacityTaskResponse ListBlockingInstancesForCapacityTask(ListBlockingInstancesForCapacityTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBlockingInstancesForCapacityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlockingInstancesForCapacityTaskResponseUnmarshaller.Instance;

            return Invoke<ListBlockingInstancesForCapacityTaskResponse>(request, options);
        }


        /// <summary>
        /// A list of Amazon EC2 instances running on the Outpost and belonging to the account
        /// that initiated the capacity task. Use this list to specify the instances you cannot
        /// stop to free up capacity to run the capacity task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlockingInstancesForCapacityTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBlockingInstancesForCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListBlockingInstancesForCapacityTask">REST API Reference for ListBlockingInstancesForCapacityTask Operation</seealso>
        public virtual Task<ListBlockingInstancesForCapacityTaskResponse> ListBlockingInstancesForCapacityTaskAsync(ListBlockingInstancesForCapacityTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBlockingInstancesForCapacityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlockingInstancesForCapacityTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBlockingInstancesForCapacityTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCapacityTasks


        /// <summary>
        /// Lists the capacity tasks for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCapacityTasks service method.</param>
        /// 
        /// <returns>The response from the ListCapacityTasks service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListCapacityTasks">REST API Reference for ListCapacityTasks Operation</seealso>
        public virtual ListCapacityTasksResponse ListCapacityTasks(ListCapacityTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCapacityTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCapacityTasksResponseUnmarshaller.Instance;

            return Invoke<ListCapacityTasksResponse>(request, options);
        }


        /// <summary>
        /// Lists the capacity tasks for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCapacityTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCapacityTasks service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListCapacityTasks">REST API Reference for ListCapacityTasks Operation</seealso>
        public virtual Task<ListCapacityTasksResponse> ListCapacityTasksAsync(ListCapacityTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCapacityTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCapacityTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCapacityTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCatalogItems


        /// <summary>
        /// Lists the items in the catalog.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCatalogItems service method.</param>
        /// 
        /// <returns>The response from the ListCatalogItems service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListCatalogItems">REST API Reference for ListCatalogItems Operation</seealso>
        public virtual ListCatalogItemsResponse ListCatalogItems(ListCatalogItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCatalogItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCatalogItemsResponseUnmarshaller.Instance;

            return Invoke<ListCatalogItemsResponse>(request, options);
        }


        /// <summary>
        /// Lists the items in the catalog.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCatalogItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCatalogItems service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListCatalogItems">REST API Reference for ListCatalogItems Operation</seealso>
        public virtual Task<ListCatalogItemsResponse> ListCatalogItemsAsync(ListCatalogItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCatalogItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCatalogItemsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCatalogItemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrders


        /// <summary>
        /// Lists the Outpost orders for your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrders service method.</param>
        /// 
        /// <returns>The response from the ListOrders service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        public virtual ListOrdersResponse ListOrders(ListOrdersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrdersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrdersResponseUnmarshaller.Instance;

            return Invoke<ListOrdersResponse>(request, options);
        }


        /// <summary>
        /// Lists the Outpost orders for your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrders service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        public virtual Task<ListOrdersResponse> ListOrdersAsync(ListOrdersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrdersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrdersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOrdersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOutposts


        /// <summary>
        /// Lists the Outposts for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutposts service method.</param>
        /// 
        /// <returns>The response from the ListOutposts service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOutposts">REST API Reference for ListOutposts Operation</seealso>
        public virtual ListOutpostsResponse ListOutposts(ListOutpostsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOutpostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutpostsResponseUnmarshaller.Instance;

            return Invoke<ListOutpostsResponse>(request, options);
        }


        /// <summary>
        /// Lists the Outposts for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutposts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOutposts service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOutposts">REST API Reference for ListOutposts Operation</seealso>
        public virtual Task<ListOutpostsResponse> ListOutpostsAsync(ListOutpostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOutpostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutpostsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOutpostsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSites


        /// <summary>
        /// Lists the Outpost sites for your Amazon Web Services account. Use filters to return
        /// specific results.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSites service method.</param>
        /// 
        /// <returns>The response from the ListSites service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListSites">REST API Reference for ListSites Operation</seealso>
        public virtual ListSitesResponse ListSites(ListSitesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSitesResponseUnmarshaller.Instance;

            return Invoke<ListSitesResponse>(request, options);
        }


        /// <summary>
        /// Lists the Outpost sites for your Amazon Web Services account. Use filters to return
        /// specific results.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSites service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListSites">REST API Reference for ListSites Operation</seealso>
        public virtual Task<ListSitesResponse> ListSitesAsync(ListSitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSitesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSitesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCapacityTask


        /// <summary>
        /// Starts the specified capacity task. You can have one active capacity task for each
        /// order and each Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCapacityTask service method.</param>
        /// 
        /// <returns>The response from the StartCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartCapacityTask">REST API Reference for StartCapacityTask Operation</seealso>
        public virtual StartCapacityTaskResponse StartCapacityTask(StartCapacityTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCapacityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCapacityTaskResponseUnmarshaller.Instance;

            return Invoke<StartCapacityTaskResponse>(request, options);
        }


        /// <summary>
        /// Starts the specified capacity task. You can have one active capacity task for each
        /// order and each Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCapacityTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartCapacityTask">REST API Reference for StartCapacityTask Operation</seealso>
        public virtual Task<StartCapacityTaskResponse> StartCapacityTaskAsync(StartCapacityTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCapacityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCapacityTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartCapacityTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartConnection


        /// <summary>
        /// <note> 
        /// <para>
        ///  Amazon Web Services uses this action to install Outpost servers.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Starts the connection required for Outpost server installation. 
        /// </para>
        ///  
        /// <para>
        ///  Use CloudTrail to monitor this action or Amazon Web Services managed policy for Amazon
        /// Web Services Outposts to secure it. For more information, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/security-iam-awsmanpol.html">
        /// Amazon Web Services managed policies for Amazon Web Services Outposts</a> and <a href="https://docs.aws.amazon.com/outposts/latest/userguide/logging-using-cloudtrail.html">
        /// Logging Amazon Web Services Outposts API calls with Amazon Web Services CloudTrail</a>
        /// in the <i>Amazon Web Services Outposts User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConnection service method.</param>
        /// 
        /// <returns>The response from the StartConnection service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartConnection">REST API Reference for StartConnection Operation</seealso>
        public virtual StartConnectionResponse StartConnection(StartConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConnectionResponseUnmarshaller.Instance;

            return Invoke<StartConnectionResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        ///  Amazon Web Services uses this action to install Outpost servers.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Starts the connection required for Outpost server installation. 
        /// </para>
        ///  
        /// <para>
        ///  Use CloudTrail to monitor this action or Amazon Web Services managed policy for Amazon
        /// Web Services Outposts to secure it. For more information, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/security-iam-awsmanpol.html">
        /// Amazon Web Services managed policies for Amazon Web Services Outposts</a> and <a href="https://docs.aws.amazon.com/outposts/latest/userguide/logging-using-cloudtrail.html">
        /// Logging Amazon Web Services Outposts API calls with Amazon Web Services CloudTrail</a>
        /// in the <i>Amazon Web Services Outposts User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartConnection service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartConnection">REST API Reference for StartConnection Operation</seealso>
        public virtual Task<StartConnectionResponse> StartConnectionAsync(StartConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOutpost


        /// <summary>
        /// Updates an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOutpost service method.</param>
        /// 
        /// <returns>The response from the UpdateOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateOutpost">REST API Reference for UpdateOutpost Operation</seealso>
        public virtual UpdateOutpostResponse UpdateOutpost(UpdateOutpostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOutpostResponseUnmarshaller.Instance;

            return Invoke<UpdateOutpostResponse>(request, options);
        }


        /// <summary>
        /// Updates an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOutpost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateOutpost">REST API Reference for UpdateOutpost Operation</seealso>
        public virtual Task<UpdateOutpostResponse> UpdateOutpostAsync(UpdateOutpostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOutpostResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateOutpostResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSite


        /// <summary>
        /// Updates the specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite service method.</param>
        /// 
        /// <returns>The response from the UpdateSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        public virtual UpdateSiteResponse UpdateSite(UpdateSiteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteResponseUnmarshaller.Instance;

            return Invoke<UpdateSiteResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        public virtual Task<UpdateSiteResponse> UpdateSiteAsync(UpdateSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSiteAddress


        /// <summary>
        /// Updates the address of the specified site.
        /// 
        ///  
        /// <para>
        /// You can't update a site address if there is an order in progress. You must wait for
        /// the order to complete or cancel the order.
        /// </para>
        ///  
        /// <para>
        /// You can update the operating address before you place an order at the site, or after
        /// all Outposts that belong to the site have been deactivated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSiteAddress service method.</param>
        /// 
        /// <returns>The response from the UpdateSiteAddress service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSiteAddress">REST API Reference for UpdateSiteAddress Operation</seealso>
        public virtual UpdateSiteAddressResponse UpdateSiteAddress(UpdateSiteAddressRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSiteAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteAddressResponseUnmarshaller.Instance;

            return Invoke<UpdateSiteAddressResponse>(request, options);
        }


        /// <summary>
        /// Updates the address of the specified site.
        /// 
        ///  
        /// <para>
        /// You can't update a site address if there is an order in progress. You must wait for
        /// the order to complete or cancel the order.
        /// </para>
        ///  
        /// <para>
        /// You can update the operating address before you place an order at the site, or after
        /// all Outposts that belong to the site have been deactivated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSiteAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSiteAddress service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSiteAddress">REST API Reference for UpdateSiteAddress Operation</seealso>
        public virtual Task<UpdateSiteAddressResponse> UpdateSiteAddressAsync(UpdateSiteAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSiteAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteAddressResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSiteAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSiteRackPhysicalProperties


        /// <summary>
        /// Update the physical and logistical details for a rack at a site. For more information
        /// about hardware requirements for racks, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/outposts-requirements.html#checklist">Network
        /// readiness checklist</a> in the Amazon Web Services Outposts User Guide. 
        /// 
        ///  
        /// <para>
        /// To update a rack at a site with an order of <c>IN_PROGRESS</c>, you must wait for
        /// the order to complete or cancel the order.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSiteRackPhysicalProperties service method.</param>
        /// 
        /// <returns>The response from the UpdateSiteRackPhysicalProperties service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSiteRackPhysicalProperties">REST API Reference for UpdateSiteRackPhysicalProperties Operation</seealso>
        public virtual UpdateSiteRackPhysicalPropertiesResponse UpdateSiteRackPhysicalProperties(UpdateSiteRackPhysicalPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSiteRackPhysicalPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteRackPhysicalPropertiesResponseUnmarshaller.Instance;

            return Invoke<UpdateSiteRackPhysicalPropertiesResponse>(request, options);
        }


        /// <summary>
        /// Update the physical and logistical details for a rack at a site. For more information
        /// about hardware requirements for racks, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/outposts-requirements.html#checklist">Network
        /// readiness checklist</a> in the Amazon Web Services Outposts User Guide. 
        /// 
        ///  
        /// <para>
        /// To update a rack at a site with an order of <c>IN_PROGRESS</c>, you must wait for
        /// the order to complete or cancel the order.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSiteRackPhysicalProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSiteRackPhysicalProperties service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSiteRackPhysicalProperties">REST API Reference for UpdateSiteRackPhysicalProperties Operation</seealso>
        public virtual Task<UpdateSiteRackPhysicalPropertiesResponse> UpdateSiteRackPhysicalPropertiesAsync(UpdateSiteRackPhysicalPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSiteRackPhysicalPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteRackPhysicalPropertiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSiteRackPhysicalPropertiesResponse>(request, options, cancellationToken);
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