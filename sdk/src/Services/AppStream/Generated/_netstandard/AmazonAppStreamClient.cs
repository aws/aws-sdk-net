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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AppStream.Model;
using Amazon.AppStream.Model.Internal.MarshallTransformations;
using Amazon.AppStream.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AppStream
{
    /// <summary>
    /// <para>Implementation for accessing AppStream</para>
    ///
    /// Amazon AppStream 2.0 
    /// <para>
    /// This is the <i>Amazon AppStream 2.0 API Reference</i>. This documentation provides
    /// descriptions and syntax for each of the actions and data types in AppStream 2.0. AppStream
    /// 2.0 is a fully managed, secure application streaming service that lets you stream
    /// desktop applications to users without rewriting applications. AppStream 2.0 manages
    /// the AWS resources that are required to host and run your applications, scales automatically,
    /// and provides access to your users on demand. 
    /// </para>
    ///  <note> 
    /// <para>
    /// You can call the AppStream 2.0 API operations by using an interface VPC endpoint (interface
    /// endpoint). For more information, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/access-api-cli-through-interface-vpc-endpoint.html">Access
    /// AppStream 2.0 API Operations and CLI Commands Through an Interface VPC Endpoint</a>
    /// in the <i>Amazon AppStream 2.0 Administration Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// To learn more about AppStream 2.0, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/appstream2">Amazon AppStream 2.0 product page</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/documentation/appstream2">Amazon AppStream 2.0 documentation</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonAppStreamClient : AmazonServiceClient, IAmazonAppStream
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppStreamMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppStreamClient with the credentials loaded from the application's
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
        public AmazonAppStreamClient()
            : base(new AmazonAppStreamConfig()) { }

        /// <summary>
        /// Constructs AmazonAppStreamClient with the credentials loaded from the application's
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
        public AmazonAppStreamClient(RegionEndpoint region)
            : base(new AmazonAppStreamConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppStreamClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppStreamClient Configuration Object</param>
        public AmazonAppStreamClient(AmazonAppStreamConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppStreamClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppStreamConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppStreamClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppStreamConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Credentials and an
        /// AmazonAppStreamClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppStreamClient Configuration Object</param>
        public AmazonAppStreamClient(AWSCredentials credentials, AmazonAppStreamConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppStreamConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppStreamConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppStreamClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppStreamClient Configuration Object</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppStreamConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppStreamConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppStreamConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppStreamClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppStreamClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppStreamClient Configuration Object</param>
        public AmazonAppStreamClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppStreamConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAppStreamPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAppStreamPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AppStreamPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppStreamEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppStreamAuthSchemeHandler());
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


        #region  AssociateAppBlockBuilderAppBlock

        internal virtual AssociateAppBlockBuilderAppBlockResponse AssociateAppBlockBuilderAppBlock(AssociateAppBlockBuilderAppBlockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAppBlockBuilderAppBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAppBlockBuilderAppBlockResponseUnmarshaller.Instance;

            return Invoke<AssociateAppBlockBuilderAppBlockResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified app block builder with the specified app block.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAppBlockBuilderAppBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAppBlockBuilderAppBlock service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateAppBlockBuilderAppBlock">REST API Reference for AssociateAppBlockBuilderAppBlock Operation</seealso>
        public virtual Task<AssociateAppBlockBuilderAppBlockResponse> AssociateAppBlockBuilderAppBlockAsync(AssociateAppBlockBuilderAppBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAppBlockBuilderAppBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAppBlockBuilderAppBlockResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAppBlockBuilderAppBlockResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateApplicationFleet

        internal virtual AssociateApplicationFleetResponse AssociateApplicationFleet(AssociateApplicationFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateApplicationFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApplicationFleetResponseUnmarshaller.Instance;

            return Invoke<AssociateApplicationFleetResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified application with the specified fleet. This is only supported
        /// for Elastic fleets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplicationFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateApplicationFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateApplicationFleet">REST API Reference for AssociateApplicationFleet Operation</seealso>
        public virtual Task<AssociateApplicationFleetResponse> AssociateApplicationFleetAsync(AssociateApplicationFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateApplicationFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApplicationFleetResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateApplicationFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateApplicationToEntitlement

        internal virtual AssociateApplicationToEntitlementResponse AssociateApplicationToEntitlement(AssociateApplicationToEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateApplicationToEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApplicationToEntitlementResponseUnmarshaller.Instance;

            return Invoke<AssociateApplicationToEntitlementResponse>(request, options);
        }



        /// <summary>
        /// Associates an application to entitle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplicationToEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateApplicationToEntitlement service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.EntitlementNotFoundException">
        /// The entitlement can't be found.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateApplicationToEntitlement">REST API Reference for AssociateApplicationToEntitlement Operation</seealso>
        public virtual Task<AssociateApplicationToEntitlementResponse> AssociateApplicationToEntitlementAsync(AssociateApplicationToEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateApplicationToEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApplicationToEntitlementResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateApplicationToEntitlementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateFleet

        internal virtual AssociateFleetResponse AssociateFleet(AssociateFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFleetResponseUnmarshaller.Instance;

            return Invoke<AssociateFleetResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified fleet with the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image can't be updated because it's not compatible for updates.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateFleet">REST API Reference for AssociateFleet Operation</seealso>
        public virtual Task<AssociateFleetResponse> AssociateFleetAsync(AssociateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchAssociateUserStack

        internal virtual BatchAssociateUserStackResponse BatchAssociateUserStack(BatchAssociateUserStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateUserStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateUserStackResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateUserStackResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified users with the specified stacks. Users in a user pool cannot
        /// be assigned to stacks with fleets that are joined to an Active Directory domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateUserStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateUserStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchAssociateUserStack">REST API Reference for BatchAssociateUserStack Operation</seealso>
        public virtual Task<BatchAssociateUserStackResponse> BatchAssociateUserStackAsync(BatchAssociateUserStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateUserStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateUserStackResponseUnmarshaller.Instance;

            return InvokeAsync<BatchAssociateUserStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDisassociateUserStack

        internal virtual BatchDisassociateUserStackResponse BatchDisassociateUserStack(BatchDisassociateUserStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateUserStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateUserStackResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateUserStackResponse>(request, options);
        }



        /// <summary>
        /// Disassociates the specified users from the specified stacks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateUserStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateUserStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchDisassociateUserStack">REST API Reference for BatchDisassociateUserStack Operation</seealso>
        public virtual Task<BatchDisassociateUserStackResponse> BatchDisassociateUserStackAsync(BatchDisassociateUserStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateUserStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateUserStackResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDisassociateUserStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CopyImage

        internal virtual CopyImageResponse CopyImage(CopyImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyImageResponseUnmarshaller.Instance;

            return Invoke<CopyImageResponse>(request, options);
        }



        /// <summary>
        /// Copies the image within the same region or to a new region within the same AWS account.
        /// Note that any tags you added to the image will not be copied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image can't be updated because it's not compatible for updates.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CopyImage">REST API Reference for CopyImage Operation</seealso>
        public virtual Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyImageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAppBlock

        internal virtual CreateAppBlockResponse CreateAppBlock(CreateAppBlockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppBlockResponseUnmarshaller.Instance;

            return Invoke<CreateAppBlockResponse>(request, options);
        }



        /// <summary>
        /// Creates an app block.
        /// 
        ///  
        /// <para>
        /// App blocks are an Amazon AppStream 2.0 resource that stores the details about the
        /// virtual hard disk in an S3 bucket. It also stores the setup script with details about
        /// how to mount the virtual hard disk. The virtual hard disk includes the application
        /// binaries and other files necessary to launch your applications. Multiple applications
        /// can be assigned to a single app block.
        /// </para>
        ///  
        /// <para>
        /// This is only supported for Elastic fleets.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppBlock service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateAppBlock">REST API Reference for CreateAppBlock Operation</seealso>
        public virtual Task<CreateAppBlockResponse> CreateAppBlockAsync(CreateAppBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppBlockResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppBlockResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAppBlockBuilder

        internal virtual CreateAppBlockBuilderResponse CreateAppBlockBuilder(CreateAppBlockBuilderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppBlockBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppBlockBuilderResponseUnmarshaller.Instance;

            return Invoke<CreateAppBlockBuilderResponse>(request, options);
        }



        /// <summary>
        /// Creates an app block builder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppBlockBuilder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppBlockBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateAppBlockBuilder">REST API Reference for CreateAppBlockBuilder Operation</seealso>
        public virtual Task<CreateAppBlockBuilderResponse> CreateAppBlockBuilderAsync(CreateAppBlockBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppBlockBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppBlockBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppBlockBuilderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAppBlockBuilderStreamingURL

        internal virtual CreateAppBlockBuilderStreamingURLResponse CreateAppBlockBuilderStreamingURL(CreateAppBlockBuilderStreamingURLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppBlockBuilderStreamingURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppBlockBuilderStreamingURLResponseUnmarshaller.Instance;

            return Invoke<CreateAppBlockBuilderStreamingURLResponse>(request, options);
        }



        /// <summary>
        /// Creates a URL to start a create app block builder streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppBlockBuilderStreamingURL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppBlockBuilderStreamingURL service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateAppBlockBuilderStreamingURL">REST API Reference for CreateAppBlockBuilderStreamingURL Operation</seealso>
        public virtual Task<CreateAppBlockBuilderStreamingURLResponse> CreateAppBlockBuilderStreamingURLAsync(CreateAppBlockBuilderStreamingURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppBlockBuilderStreamingURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppBlockBuilderStreamingURLResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppBlockBuilderStreamingURLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates an application.
        /// 
        ///  
        /// <para>
        /// Applications are an Amazon AppStream 2.0 resource that stores the details about how
        /// to launch applications on Elastic fleet streaming instances. An application consists
        /// of the launch details, icon, and display name. Applications are associated with an
        /// app block that contains the application binaries and other files. The applications
        /// assigned to an Elastic fleet are the applications users can launch. 
        /// </para>
        ///  
        /// <para>
        /// This is only supported for Elastic fleets.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDirectoryConfig

        internal virtual CreateDirectoryConfigResponse CreateDirectoryConfig(CreateDirectoryConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryConfigResponse>(request, options);
        }



        /// <summary>
        /// Creates a Directory Config object in AppStream 2.0. This object includes the configuration
        /// information required to join fleets and image builders to Microsoft Active Directory
        /// domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateDirectoryConfig">REST API Reference for CreateDirectoryConfig Operation</seealso>
        public virtual Task<CreateDirectoryConfigResponse> CreateDirectoryConfigAsync(CreateDirectoryConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectoryConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEntitlement

        internal virtual CreateEntitlementResponse CreateEntitlement(CreateEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntitlementResponseUnmarshaller.Instance;

            return Invoke<CreateEntitlementResponse>(request, options);
        }



        /// <summary>
        /// Creates a new entitlement. Entitlements control access to specific applications within
        /// a stack, based on user attributes. Entitlements apply to SAML 2.0 federated user identities.
        /// Amazon AppStream 2.0 user pool and streaming URL users are entitled to all applications
        /// in a stack. Entitlements don't apply to the desktop stream view application, or to
        /// applications managed by a dynamic app provider using the Dynamic Application Framework.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEntitlement service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.EntitlementAlreadyExistsException">
        /// The entitlement already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateEntitlement">REST API Reference for CreateEntitlement Operation</seealso>
        public virtual Task<CreateEntitlementResponse> CreateEntitlementAsync(CreateEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntitlementResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEntitlementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFleet

        internal virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }



        /// <summary>
        /// Creates a fleet. A fleet consists of streaming instances that your users access for
        /// their applications and desktops.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image can't be updated because it's not compatible for updates.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateImageBuilder

        internal virtual CreateImageBuilderResponse CreateImageBuilder(CreateImageBuilderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageBuilderResponseUnmarshaller.Instance;

            return Invoke<CreateImageBuilderResponse>(request, options);
        }



        /// <summary>
        /// Creates an image builder. An image builder is a virtual machine that is used to create
        /// an image.
        /// 
        ///  
        /// <para>
        /// The initial state of the builder is <c>PENDING</c>. When it is ready, the state is
        /// <c>RUNNING</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image can't be updated because it's not compatible for updates.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilder">REST API Reference for CreateImageBuilder Operation</seealso>
        public virtual Task<CreateImageBuilderResponse> CreateImageBuilderAsync(CreateImageBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageBuilderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateImageBuilderStreamingURL

        internal virtual CreateImageBuilderStreamingURLResponse CreateImageBuilderStreamingURL(CreateImageBuilderStreamingURLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImageBuilderStreamingURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageBuilderStreamingURLResponseUnmarshaller.Instance;

            return Invoke<CreateImageBuilderStreamingURLResponse>(request, options);
        }



        /// <summary>
        /// Creates a URL to start an image builder streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilderStreamingURL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateImageBuilderStreamingURL service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilderStreamingURL">REST API Reference for CreateImageBuilderStreamingURL Operation</seealso>
        public virtual Task<CreateImageBuilderStreamingURLResponse> CreateImageBuilderStreamingURLAsync(CreateImageBuilderStreamingURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImageBuilderStreamingURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageBuilderStreamingURLResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageBuilderStreamingURLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStack

        internal virtual CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackResponse>(request, options);
        }



        /// <summary>
        /// Creates a stack to start streaming applications to users. A stack consists of an associated
        /// fleet, user access policies, and storage configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStreamingURL

        internal virtual CreateStreamingURLResponse CreateStreamingURL(CreateStreamingURLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamingURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingURLResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingURLResponse>(request, options);
        }



        /// <summary>
        /// Creates a temporary URL to start an AppStream 2.0 streaming session for the specified
        /// user. A streaming URL enables application streaming to be tested without user setup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingURL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStreamingURL service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStreamingURL">REST API Reference for CreateStreamingURL Operation</seealso>
        public virtual Task<CreateStreamingURLResponse> CreateStreamingURLAsync(CreateStreamingURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamingURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingURLResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamingURLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateThemeForStack

        internal virtual CreateThemeForStackResponse CreateThemeForStack(CreateThemeForStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateThemeForStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThemeForStackResponseUnmarshaller.Instance;

            return Invoke<CreateThemeForStackResponse>(request, options);
        }



        /// <summary>
        /// Creates custom branding that customizes the appearance of the streaming application
        /// catalog page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThemeForStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateThemeForStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateThemeForStack">REST API Reference for CreateThemeForStack Operation</seealso>
        public virtual Task<CreateThemeForStackResponse> CreateThemeForStackAsync(CreateThemeForStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateThemeForStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThemeForStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThemeForStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUpdatedImage

        internal virtual CreateUpdatedImageResponse CreateUpdatedImage(CreateUpdatedImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUpdatedImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUpdatedImageResponseUnmarshaller.Instance;

            return Invoke<CreateUpdatedImageResponse>(request, options);
        }



        /// <summary>
        /// Creates a new image with the latest Windows operating system updates, driver updates,
        /// and AppStream 2.0 agent software.
        /// 
        ///  
        /// <para>
        /// For more information, see the "Update an Image by Using Managed AppStream 2.0 Image
        /// Updates" section in <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/administer-images.html">Administer
        /// Your AppStream 2.0 Images</a>, in the <i>Amazon AppStream 2.0 Administration Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUpdatedImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUpdatedImage service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image can't be updated because it's not compatible for updates.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUpdatedImage">REST API Reference for CreateUpdatedImage Operation</seealso>
        public virtual Task<CreateUpdatedImageResponse> CreateUpdatedImageAsync(CreateUpdatedImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUpdatedImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUpdatedImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUpdatedImageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUsageReportSubscription

        internal virtual CreateUsageReportSubscriptionResponse CreateUsageReportSubscription(CreateUsageReportSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUsageReportSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageReportSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateUsageReportSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Creates a usage report subscription. Usage reports are generated daily.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageReportSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUsageReportSubscription service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUsageReportSubscription">REST API Reference for CreateUsageReportSubscription Operation</seealso>
        public virtual Task<CreateUsageReportSubscriptionResponse> CreateUsageReportSubscriptionAsync(CreateUsageReportSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUsageReportSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageReportSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUsageReportSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }



        /// <summary>
        /// Creates a new user in the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAppBlock

        internal virtual DeleteAppBlockResponse DeleteAppBlock(DeleteAppBlockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppBlockResponseUnmarshaller.Instance;

            return Invoke<DeleteAppBlockResponse>(request, options);
        }



        /// <summary>
        /// Deletes an app block.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppBlock service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteAppBlock">REST API Reference for DeleteAppBlock Operation</seealso>
        public virtual Task<DeleteAppBlockResponse> DeleteAppBlockAsync(DeleteAppBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppBlockResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAppBlockBuilder

        internal virtual DeleteAppBlockBuilderResponse DeleteAppBlockBuilder(DeleteAppBlockBuilderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppBlockBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppBlockBuilderResponseUnmarshaller.Instance;

            return Invoke<DeleteAppBlockBuilderResponse>(request, options);
        }



        /// <summary>
        /// Deletes an app block builder.
        /// 
        ///  
        /// <para>
        /// An app block builder can only be deleted when it has no association with an app block.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppBlockBuilder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppBlockBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteAppBlockBuilder">REST API Reference for DeleteAppBlockBuilder Operation</seealso>
        public virtual Task<DeleteAppBlockBuilderResponse> DeleteAppBlockBuilderAsync(DeleteAppBlockBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppBlockBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppBlockBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppBlockBuilderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDirectoryConfig

        internal virtual DeleteDirectoryConfigResponse DeleteDirectoryConfig(DeleteDirectoryConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryConfigResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified Directory Config object from AppStream 2.0. This object includes
        /// the information required to join streaming instances to an Active Directory domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteDirectoryConfig">REST API Reference for DeleteDirectoryConfig Operation</seealso>
        public virtual Task<DeleteDirectoryConfigResponse> DeleteDirectoryConfigAsync(DeleteDirectoryConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectoryConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEntitlement

        internal virtual DeleteEntitlementResponse DeleteEntitlement(DeleteEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntitlementResponseUnmarshaller.Instance;

            return Invoke<DeleteEntitlementResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified entitlement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEntitlement service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.EntitlementNotFoundException">
        /// The entitlement can't be found.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteEntitlement">REST API Reference for DeleteEntitlement Operation</seealso>
        public virtual Task<DeleteEntitlementResponse> DeleteEntitlementAsync(DeleteEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntitlementResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEntitlementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFleet

        internal virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteImage

        internal virtual DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return Invoke<DeleteImageResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified image. You cannot delete an image when it is in use. After you
        /// delete an image, you cannot provision new capacity using the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImage service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        public virtual Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteImageBuilder

        internal virtual DeleteImageBuilderResponse DeleteImageBuilder(DeleteImageBuilderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageBuilderResponseUnmarshaller.Instance;

            return Invoke<DeleteImageBuilderResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified image builder and releases the capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageBuilder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImageBuilder">REST API Reference for DeleteImageBuilder Operation</seealso>
        public virtual Task<DeleteImageBuilderResponse> DeleteImageBuilderAsync(DeleteImageBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImageBuilderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteImagePermissions

        internal virtual DeleteImagePermissionsResponse DeleteImagePermissions(DeleteImagePermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImagePermissionsResponseUnmarshaller.Instance;

            return Invoke<DeleteImagePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Deletes permissions for the specified private image. After you delete permissions
        /// for an image, AWS accounts to which you previously granted these permissions can no
        /// longer use the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImagePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImagePermissions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImagePermissions">REST API Reference for DeleteImagePermissions Operation</seealso>
        public virtual Task<DeleteImagePermissionsResponse> DeleteImagePermissionsAsync(DeleteImagePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImagePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImagePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteStack

        internal virtual DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified stack. After the stack is deleted, the application streaming
        /// environment provided by the stack is no longer available to users. Also, any reservations
        /// made for application streaming sessions for the stack are released.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteThemeForStack

        internal virtual DeleteThemeForStackResponse DeleteThemeForStack(DeleteThemeForStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteThemeForStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThemeForStackResponseUnmarshaller.Instance;

            return Invoke<DeleteThemeForStackResponse>(request, options);
        }



        /// <summary>
        /// Deletes custom branding that customizes the appearance of the streaming application
        /// catalog page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThemeForStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteThemeForStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteThemeForStack">REST API Reference for DeleteThemeForStack Operation</seealso>
        public virtual Task<DeleteThemeForStackResponse> DeleteThemeForStackAsync(DeleteThemeForStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteThemeForStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThemeForStackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteThemeForStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUsageReportSubscription

        internal virtual DeleteUsageReportSubscriptionResponse DeleteUsageReportSubscription(DeleteUsageReportSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUsageReportSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageReportSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteUsageReportSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Disables usage report generation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageReportSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUsageReportSubscription service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUsageReportSubscription">REST API Reference for DeleteUsageReportSubscription Operation</seealso>
        public virtual Task<DeleteUsageReportSubscriptionResponse> DeleteUsageReportSubscriptionAsync(DeleteUsageReportSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUsageReportSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageReportSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUsageReportSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }



        /// <summary>
        /// Deletes a user from the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAppBlockBuilderAppBlockAssociations

        internal virtual DescribeAppBlockBuilderAppBlockAssociationsResponse DescribeAppBlockBuilderAppBlockAssociations(DescribeAppBlockBuilderAppBlockAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAppBlockBuilderAppBlockAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppBlockBuilderAppBlockAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeAppBlockBuilderAppBlockAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more app block builder associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppBlockBuilderAppBlockAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppBlockBuilderAppBlockAssociations service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeAppBlockBuilderAppBlockAssociations">REST API Reference for DescribeAppBlockBuilderAppBlockAssociations Operation</seealso>
        public virtual Task<DescribeAppBlockBuilderAppBlockAssociationsResponse> DescribeAppBlockBuilderAppBlockAssociationsAsync(DescribeAppBlockBuilderAppBlockAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAppBlockBuilderAppBlockAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppBlockBuilderAppBlockAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppBlockBuilderAppBlockAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAppBlockBuilders

        internal virtual DescribeAppBlockBuildersResponse DescribeAppBlockBuilders(DescribeAppBlockBuildersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAppBlockBuildersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppBlockBuildersResponseUnmarshaller.Instance;

            return Invoke<DescribeAppBlockBuildersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more app block builders.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppBlockBuilders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppBlockBuilders service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeAppBlockBuilders">REST API Reference for DescribeAppBlockBuilders Operation</seealso>
        public virtual Task<DescribeAppBlockBuildersResponse> DescribeAppBlockBuildersAsync(DescribeAppBlockBuildersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAppBlockBuildersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppBlockBuildersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppBlockBuildersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAppBlocks

        internal virtual DescribeAppBlocksResponse DescribeAppBlocks(DescribeAppBlocksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAppBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppBlocksResponseUnmarshaller.Instance;

            return Invoke<DescribeAppBlocksResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more app blocks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppBlocks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppBlocks service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeAppBlocks">REST API Reference for DescribeAppBlocks Operation</seealso>
        public virtual Task<DescribeAppBlocksResponse> DescribeAppBlocksAsync(DescribeAppBlocksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAppBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppBlocksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppBlocksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeApplicationFleetAssociations

        internal virtual DescribeApplicationFleetAssociationsResponse DescribeApplicationFleetAssociations(DescribeApplicationFleetAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationFleetAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationFleetAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationFleetAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more application fleet associations. Either
        /// ApplicationArn or FleetName must be specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationFleetAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationFleetAssociations service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeApplicationFleetAssociations">REST API Reference for DescribeApplicationFleetAssociations Operation</seealso>
        public virtual Task<DescribeApplicationFleetAssociationsResponse> DescribeApplicationFleetAssociationsAsync(DescribeApplicationFleetAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationFleetAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationFleetAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationFleetAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeApplications

        internal virtual DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDirectoryConfigs

        internal virtual DescribeDirectoryConfigsResponse DescribeDirectoryConfigs(DescribeDirectoryConfigsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDirectoryConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoryConfigsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectoryConfigsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more specified Directory Config objects for
        /// AppStream 2.0, if the names for these objects are provided. Otherwise, all Directory
        /// Config objects in the account are described. These objects include the configuration
        /// information required to join fleets and image builders to Microsoft Active Directory
        /// domains. 
        /// 
        ///  
        /// <para>
        /// Although the response syntax in this topic includes the account password, this password
        /// is not returned in the actual response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectoryConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectoryConfigs service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeDirectoryConfigs">REST API Reference for DescribeDirectoryConfigs Operation</seealso>
        public virtual Task<DescribeDirectoryConfigsResponse> DescribeDirectoryConfigsAsync(DescribeDirectoryConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDirectoryConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoryConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectoryConfigsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEntitlements

        internal virtual DescribeEntitlementsResponse DescribeEntitlements(DescribeEntitlementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitlementsResponseUnmarshaller.Instance;

            return Invoke<DescribeEntitlementsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one of more entitlements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntitlements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEntitlements service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.EntitlementNotFoundException">
        /// The entitlement can't be found.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeEntitlements">REST API Reference for DescribeEntitlements Operation</seealso>
        public virtual Task<DescribeEntitlementsResponse> DescribeEntitlementsAsync(DescribeEntitlementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitlementsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEntitlementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleets

        internal virtual DescribeFleetsResponse DescribeFleets(DescribeFleetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more specified fleets, if the fleet names are
        /// provided. Otherwise, all fleets in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleets service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        public virtual Task<DescribeFleetsResponse> DescribeFleetsAsync(DescribeFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeImageBuilders

        internal virtual DescribeImageBuildersResponse DescribeImageBuilders(DescribeImageBuildersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImageBuildersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageBuildersResponseUnmarshaller.Instance;

            return Invoke<DescribeImageBuildersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more specified image builders, if the image
        /// builder names are provided. Otherwise, all image builders in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageBuilders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImageBuilders service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImageBuilders">REST API Reference for DescribeImageBuilders Operation</seealso>
        public virtual Task<DescribeImageBuildersResponse> DescribeImageBuildersAsync(DescribeImageBuildersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImageBuildersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageBuildersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageBuildersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeImagePermissions

        internal virtual DescribeImagePermissionsResponse DescribeImagePermissions(DescribeImagePermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeImagePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes the permissions for shared AWS account IDs on a private
        /// image that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImagePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImagePermissions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImagePermissions">REST API Reference for DescribeImagePermissions Operation</seealso>
        public virtual Task<DescribeImagePermissionsResponse> DescribeImagePermissionsAsync(DescribeImagePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImagePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeImages

        internal virtual DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more specified images, if the image names or
        /// image ARNs are provided. Otherwise, all images in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImagesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSessions

        internal virtual DescribeSessionsResponse DescribeSessions(DescribeSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeSessionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes the streaming sessions for a specified stack and fleet.
        /// If a UserId is provided for the stack and fleet, only streaming sessions for that
        /// user are described. If an authentication type is not provided, the default is to authenticate
        /// users using a streaming URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSessions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public virtual Task<DescribeSessionsResponse> DescribeSessionsAsync(DescribeSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSessionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStacks

        internal virtual DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more specified stacks, if the stack names are
        /// provided. Otherwise, all stacks in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStacksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeThemeForStack

        internal virtual DescribeThemeForStackResponse DescribeThemeForStack(DescribeThemeForStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeThemeForStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThemeForStackResponseUnmarshaller.Instance;

            return Invoke<DescribeThemeForStackResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes the theme for a specified stack. A theme is custom
        /// branding that customizes the appearance of the streaming application catalog page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThemeForStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeThemeForStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeThemeForStack">REST API Reference for DescribeThemeForStack Operation</seealso>
        public virtual Task<DescribeThemeForStackResponse> DescribeThemeForStackAsync(DescribeThemeForStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeThemeForStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThemeForStackResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeThemeForStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeUsageReportSubscriptions

        internal virtual DescribeUsageReportSubscriptionsResponse DescribeUsageReportSubscriptions(DescribeUsageReportSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUsageReportSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsageReportSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeUsageReportSubscriptionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more usage report subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsageReportSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUsageReportSubscriptions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsageReportSubscriptions">REST API Reference for DescribeUsageReportSubscriptions Operation</seealso>
        public virtual Task<DescribeUsageReportSubscriptionsResponse> DescribeUsageReportSubscriptionsAsync(DescribeUsageReportSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUsageReportSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsageReportSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUsageReportSubscriptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeUsers

        internal virtual DescribeUsersResponse DescribeUsers(DescribeUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return Invoke<DescribeUsersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more specified users in the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUsers service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        public virtual Task<DescribeUsersResponse> DescribeUsersAsync(DescribeUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUsersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeUserStackAssociations

        internal virtual DescribeUserStackAssociationsResponse DescribeUserStackAssociations(DescribeUserStackAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUserStackAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserStackAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeUserStackAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes the UserStackAssociation objects. You must specify
        /// either or both of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The stack name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user name (email address of the user associated with the stack) and the authentication
        /// type for the user
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserStackAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserStackAssociations service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUserStackAssociations">REST API Reference for DescribeUserStackAssociations Operation</seealso>
        public virtual Task<DescribeUserStackAssociationsResponse> DescribeUserStackAssociationsAsync(DescribeUserStackAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUserStackAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserStackAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserStackAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableUser

        internal virtual DisableUserResponse DisableUser(DisableUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableUserResponseUnmarshaller.Instance;

            return Invoke<DisableUserResponse>(request, options);
        }



        /// <summary>
        /// Disables the specified user in the user pool. Users can't sign in to AppStream 2.0
        /// until they are re-enabled. This action does not delete the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisableUser">REST API Reference for DisableUser Operation</seealso>
        public virtual Task<DisableUserResponse> DisableUserAsync(DisableUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableUserResponseUnmarshaller.Instance;

            return InvokeAsync<DisableUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateAppBlockBuilderAppBlock

        internal virtual DisassociateAppBlockBuilderAppBlockResponse DisassociateAppBlockBuilderAppBlock(DisassociateAppBlockBuilderAppBlockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAppBlockBuilderAppBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAppBlockBuilderAppBlockResponseUnmarshaller.Instance;

            return Invoke<DisassociateAppBlockBuilderAppBlockResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a specified app block builder from a specified app block.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAppBlockBuilderAppBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAppBlockBuilderAppBlock service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateAppBlockBuilderAppBlock">REST API Reference for DisassociateAppBlockBuilderAppBlock Operation</seealso>
        public virtual Task<DisassociateAppBlockBuilderAppBlockResponse> DisassociateAppBlockBuilderAppBlockAsync(DisassociateAppBlockBuilderAppBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAppBlockBuilderAppBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAppBlockBuilderAppBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAppBlockBuilderAppBlockResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateApplicationFleet

        internal virtual DisassociateApplicationFleetResponse DisassociateApplicationFleet(DisassociateApplicationFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateApplicationFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApplicationFleetResponseUnmarshaller.Instance;

            return Invoke<DisassociateApplicationFleetResponse>(request, options);
        }



        /// <summary>
        /// Disassociates the specified application from the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplicationFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateApplicationFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateApplicationFleet">REST API Reference for DisassociateApplicationFleet Operation</seealso>
        public virtual Task<DisassociateApplicationFleetResponse> DisassociateApplicationFleetAsync(DisassociateApplicationFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateApplicationFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApplicationFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateApplicationFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateApplicationFromEntitlement

        internal virtual DisassociateApplicationFromEntitlementResponse DisassociateApplicationFromEntitlement(DisassociateApplicationFromEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateApplicationFromEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApplicationFromEntitlementResponseUnmarshaller.Instance;

            return Invoke<DisassociateApplicationFromEntitlementResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified application from the specified entitlement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplicationFromEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateApplicationFromEntitlement service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.EntitlementNotFoundException">
        /// The entitlement can't be found.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateApplicationFromEntitlement">REST API Reference for DisassociateApplicationFromEntitlement Operation</seealso>
        public virtual Task<DisassociateApplicationFromEntitlementResponse> DisassociateApplicationFromEntitlementAsync(DisassociateApplicationFromEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateApplicationFromEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApplicationFromEntitlementResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateApplicationFromEntitlementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateFleet

        internal virtual DisassociateFleetResponse DisassociateFleet(DisassociateFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFleetResponseUnmarshaller.Instance;

            return Invoke<DisassociateFleetResponse>(request, options);
        }



        /// <summary>
        /// Disassociates the specified fleet from the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateFleet">REST API Reference for DisassociateFleet Operation</seealso>
        public virtual Task<DisassociateFleetResponse> DisassociateFleetAsync(DisassociateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableUser

        internal virtual EnableUserResponse EnableUser(EnableUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableUserResponseUnmarshaller.Instance;

            return Invoke<EnableUserResponse>(request, options);
        }



        /// <summary>
        /// Enables a user in the user pool. After being enabled, users can sign in to AppStream
        /// 2.0 and open applications from the stacks to which they are assigned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/EnableUser">REST API Reference for EnableUser Operation</seealso>
        public virtual Task<EnableUserResponse> EnableUserAsync(EnableUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableUserResponseUnmarshaller.Instance;

            return InvokeAsync<EnableUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExpireSession

        internal virtual ExpireSessionResponse ExpireSession(ExpireSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExpireSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return Invoke<ExpireSessionResponse>(request, options);
        }



        /// <summary>
        /// Immediately stops the specified streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExpireSession service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public virtual Task<ExpireSessionResponse> ExpireSessionAsync(ExpireSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExpireSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return InvokeAsync<ExpireSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssociatedFleets

        internal virtual ListAssociatedFleetsResponse ListAssociatedFleets(ListAssociatedFleetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedFleetsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedFleetsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the name of the fleet that is associated with the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedFleets service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        public virtual Task<ListAssociatedFleetsResponse> ListAssociatedFleetsAsync(ListAssociatedFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociatedFleetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssociatedStacks

        internal virtual ListAssociatedStacksResponse ListAssociatedStacks(ListAssociatedStacksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedStacksResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedStacksResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the name of the stack with which the specified fleet is associated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedStacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedStacks service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        public virtual Task<ListAssociatedStacksResponse> ListAssociatedStacksAsync(ListAssociatedStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedStacksResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociatedStacksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEntitledApplications

        internal virtual ListEntitledApplicationsResponse ListEntitledApplications(ListEntitledApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntitledApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitledApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListEntitledApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of entitled applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitledApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntitledApplications service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.EntitlementNotFoundException">
        /// The entitlement can't be found.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListEntitledApplications">REST API Reference for ListEntitledApplications Operation</seealso>
        public virtual Task<ListEntitledApplicationsResponse> ListEntitledApplicationsAsync(ListEntitledApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntitledApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitledApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntitledApplicationsResponse>(request, options, cancellationToken);
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
        /// Retrieves a list of all tags for the specified AppStream 2.0 resource. You can tag
        /// AppStream 2.0 image builders, images, fleets, and stacks.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartAppBlockBuilder

        internal virtual StartAppBlockBuilderResponse StartAppBlockBuilder(StartAppBlockBuilderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAppBlockBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppBlockBuilderResponseUnmarshaller.Instance;

            return Invoke<StartAppBlockBuilderResponse>(request, options);
        }



        /// <summary>
        /// Starts an app block builder.
        /// 
        ///  
        /// <para>
        /// An app block builder can only be started when it's associated with an app block.
        /// </para>
        ///  
        /// <para>
        /// Starting an app block builder starts a new instance, which is equivalent to an elastic
        /// fleet instance with application builder assistance functionality.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAppBlockBuilder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAppBlockBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartAppBlockBuilder">REST API Reference for StartAppBlockBuilder Operation</seealso>
        public virtual Task<StartAppBlockBuilderResponse> StartAppBlockBuilderAsync(StartAppBlockBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAppBlockBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppBlockBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<StartAppBlockBuilderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartFleet

        internal virtual StartFleetResponse StartFleet(StartFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetResponseUnmarshaller.Instance;

            return Invoke<StartFleetResponse>(request, options);
        }



        /// <summary>
        /// Starts the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartFleet">REST API Reference for StartFleet Operation</seealso>
        public virtual Task<StartFleetResponse> StartFleetAsync(StartFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetResponseUnmarshaller.Instance;

            return InvokeAsync<StartFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartImageBuilder

        internal virtual StartImageBuilderResponse StartImageBuilder(StartImageBuilderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImageBuilderResponseUnmarshaller.Instance;

            return Invoke<StartImageBuilderResponse>(request, options);
        }



        /// <summary>
        /// Starts the specified image builder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImageBuilder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image can't be updated because it's not compatible for updates.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartImageBuilder">REST API Reference for StartImageBuilder Operation</seealso>
        public virtual Task<StartImageBuilderResponse> StartImageBuilderAsync(StartImageBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImageBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<StartImageBuilderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopAppBlockBuilder

        internal virtual StopAppBlockBuilderResponse StopAppBlockBuilder(StopAppBlockBuilderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAppBlockBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAppBlockBuilderResponseUnmarshaller.Instance;

            return Invoke<StopAppBlockBuilderResponse>(request, options);
        }



        /// <summary>
        /// Stops an app block builder.
        /// 
        ///  
        /// <para>
        /// Stopping an app block builder terminates the instance, and the instance state is not
        /// persisted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAppBlockBuilder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopAppBlockBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopAppBlockBuilder">REST API Reference for StopAppBlockBuilder Operation</seealso>
        public virtual Task<StopAppBlockBuilderResponse> StopAppBlockBuilderAsync(StopAppBlockBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAppBlockBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAppBlockBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<StopAppBlockBuilderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopFleet

        internal virtual StopFleetResponse StopFleet(StopFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetResponseUnmarshaller.Instance;

            return Invoke<StopFleetResponse>(request, options);
        }



        /// <summary>
        /// Stops the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopFleet">REST API Reference for StopFleet Operation</seealso>
        public virtual Task<StopFleetResponse> StopFleetAsync(StopFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetResponseUnmarshaller.Instance;

            return InvokeAsync<StopFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopImageBuilder

        internal virtual StopImageBuilderResponse StopImageBuilder(StopImageBuilderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopImageBuilderResponseUnmarshaller.Instance;

            return Invoke<StopImageBuilderResponse>(request, options);
        }



        /// <summary>
        /// Stops the specified image builder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopImageBuilder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopImageBuilder">REST API Reference for StopImageBuilder Operation</seealso>
        public virtual Task<StopImageBuilderResponse> StopImageBuilderAsync(StopImageBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopImageBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopImageBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<StopImageBuilderResponse>(request, options, cancellationToken);
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
        /// Adds or overwrites one or more tags for the specified AppStream 2.0 resource. You
        /// can tag AppStream 2.0 image builders, images, fleets, and stacks.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a resource already has a tag
        /// with the same key, this operation updates its value.
        /// </para>
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>ListTagsForResource</a>. To disassociate
        /// tags from your resources, use <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Disassociates one or more specified tags from the specified AppStream 2.0 resource.
        /// 
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>ListTagsForResource</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAppBlockBuilder

        internal virtual UpdateAppBlockBuilderResponse UpdateAppBlockBuilder(UpdateAppBlockBuilderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAppBlockBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppBlockBuilderResponseUnmarshaller.Instance;

            return Invoke<UpdateAppBlockBuilderResponse>(request, options);
        }



        /// <summary>
        /// Updates an app block builder.
        /// 
        ///  
        /// <para>
        /// If the app block builder is in the <c>STARTING</c> or <c>STOPPING</c> state, you can't
        /// update it. If the app block builder is in the <c>RUNNING</c> state, you can only update
        /// the DisplayName and Description. If the app block builder is in the <c>STOPPED</c>
        /// state, you can update any attribute except the Name.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppBlockBuilder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppBlockBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateAppBlockBuilder">REST API Reference for UpdateAppBlockBuilder Operation</seealso>
        public virtual Task<UpdateAppBlockBuilderResponse> UpdateAppBlockBuilderAsync(UpdateAppBlockBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAppBlockBuilderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppBlockBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAppBlockBuilderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDirectoryConfig

        internal virtual UpdateDirectoryConfigResponse UpdateDirectoryConfig(UpdateDirectoryConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateDirectoryConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified Directory Config object in AppStream 2.0. This object includes
        /// the configuration information required to join fleets and image builders to Microsoft
        /// Active Directory domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectoryConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image can't be updated because it's not compatible for updates.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateDirectoryConfig">REST API Reference for UpdateDirectoryConfig Operation</seealso>
        public virtual Task<UpdateDirectoryConfigResponse> UpdateDirectoryConfigAsync(UpdateDirectoryConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDirectoryConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDirectoryConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDirectoryConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEntitlement

        internal virtual UpdateEntitlementResponse UpdateEntitlement(UpdateEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEntitlementResponseUnmarshaller.Instance;

            return Invoke<UpdateEntitlementResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified entitlement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEntitlement service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.EntitlementNotFoundException">
        /// The entitlement can't be found.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateEntitlement">REST API Reference for UpdateEntitlement Operation</seealso>
        public virtual Task<UpdateEntitlementResponse> UpdateEntitlementAsync(UpdateEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEntitlementResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEntitlementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFleet

        internal virtual UpdateFleetResponse UpdateFleet(UpdateFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified fleet.
        /// 
        ///  
        /// <para>
        /// If the fleet is in the <c>STOPPED</c> state, you can update any attribute except the
        /// fleet name.
        /// </para>
        ///  
        /// <para>
        /// If the fleet is in the <c>RUNNING</c> state, you can update the following based on
        /// the fleet type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Always-On and On-Demand fleet types
        /// </para>
        ///  
        /// <para>
        /// You can update the <c>DisplayName</c>, <c>ComputeCapacity</c>, <c>ImageARN</c>, <c>ImageName</c>,
        /// <c>IdleDisconnectTimeoutInSeconds</c>, and <c>DisconnectTimeoutInSeconds</c> attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Elastic fleet type
        /// </para>
        ///  
        /// <para>
        /// You can update the <c>DisplayName</c>, <c>IdleDisconnectTimeoutInSeconds</c>, <c>DisconnectTimeoutInSeconds</c>,
        /// <c>MaxConcurrentSessions</c>, <c>SessionScriptS3Location</c> and <c>UsbDeviceFilterStrings</c>
        /// attributes.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the fleet is in the <c>STARTING</c> or <c>STOPPED</c> state, you can't update it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image can't be updated because it's not compatible for updates.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.RequestLimitExceededException">
        /// AppStream 2.0 can’t process the request right now because the Describe calls from
        /// your AWS account are being throttled by Amazon EC2. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public virtual Task<UpdateFleetResponse> UpdateFleetAsync(UpdateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateImagePermissions

        internal virtual UpdateImagePermissionsResponse UpdateImagePermissions(UpdateImagePermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImagePermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateImagePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates permissions for the specified private image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImagePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateImagePermissions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateImagePermissions">REST API Reference for UpdateImagePermissions Operation</seealso>
        public virtual Task<UpdateImagePermissionsResponse> UpdateImagePermissionsAsync(UpdateImagePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImagePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateImagePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateStack

        internal virtual UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified fields for the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image can't be updated because it's not compatible for updates.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateThemeForStack

        internal virtual UpdateThemeForStackResponse UpdateThemeForStack(UpdateThemeForStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateThemeForStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemeForStackResponseUnmarshaller.Instance;

            return Invoke<UpdateThemeForStackResponse>(request, options);
        }



        /// <summary>
        /// Updates custom branding that customizes the appearance of the streaming application
        /// catalog page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThemeForStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThemeForStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateThemeForStack">REST API Reference for UpdateThemeForStack Operation</seealso>
        public virtual Task<UpdateThemeForStackResponse> UpdateThemeForStackAsync(UpdateThemeForStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateThemeForStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemeForStackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThemeForStackResponse>(request, options, cancellationToken);
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