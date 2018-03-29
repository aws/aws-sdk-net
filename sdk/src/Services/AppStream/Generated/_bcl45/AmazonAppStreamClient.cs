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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.AppStream.Model;
using Amazon.AppStream.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AppStream
{
    /// <summary>
    /// Implementation for accessing AppStream
    ///
    /// Amazon AppStream 2.0 
    /// <para>
    /// You can use Amazon AppStream 2.0 to stream desktop applications to any device running
    /// a web browser, without rewriting them.
    /// </para>
    /// </summary>
    public partial class AmazonAppStreamClient : AmazonServiceClient, IAmazonAppStream
    {
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppStreamConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppStreamConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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

        
        #region  AssociateFleet


        /// <summary>
        /// Associates the specified fleet with the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFleet service method.</param>
        /// 
        /// <returns>The response from the AssociateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
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
        public virtual AssociateFleetResponse AssociateFleet(AssociateFleetRequest request)
        {
            var marshaller = AssociateFleetRequestMarshaller.Instance;
            var unmarshaller = AssociateFleetResponseUnmarshaller.Instance;

            return Invoke<AssociateFleetRequest,AssociateFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateFleet">REST API Reference for AssociateFleet Operation</seealso>
        public virtual Task<AssociateFleetResponse> AssociateFleetAsync(AssociateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateFleetRequestMarshaller.Instance;
            var unmarshaller = AssociateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateFleetRequest,AssociateFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyImage


        /// <summary>
        /// Copies the image within the same region or to a new region within the same AWS account.
        /// Note that any tags you added to the image will not be copied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
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
        public virtual CopyImageResponse CopyImage(CopyImageRequest request)
        {
            var marshaller = CopyImageRequestMarshaller.Instance;
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return Invoke<CopyImageRequest,CopyImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CopyImage">REST API Reference for CopyImage Operation</seealso>
        public virtual Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CopyImageRequestMarshaller.Instance;
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyImageRequest,CopyImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectoryConfig


        /// <summary>
        /// Creates a directory configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the CreateDirectoryConfig service method, as returned by AppStream.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateDirectoryConfig">REST API Reference for CreateDirectoryConfig Operation</seealso>
        public virtual CreateDirectoryConfigResponse CreateDirectoryConfig(CreateDirectoryConfigRequest request)
        {
            var marshaller = CreateDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = CreateDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryConfigRequest,CreateDirectoryConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateDirectoryConfig">REST API Reference for CreateDirectoryConfig Operation</seealso>
        public virtual Task<CreateDirectoryConfigResponse> CreateDirectoryConfigAsync(CreateDirectoryConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = CreateDirectoryConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectoryConfigRequest,CreateDirectoryConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
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
        public virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var marshaller = CreateFleetRequestMarshaller.Instance;
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetRequest,CreateFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFleetRequestMarshaller.Instance;
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetRequest,CreateFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateImageBuilder


        /// <summary>
        /// Creates an image builder.
        /// 
        ///  
        /// <para>
        /// The initial state of the builder is <code>PENDING</code>. When it is ready, the state
        /// is <code>RUNNING</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilder service method.</param>
        /// 
        /// <returns>The response from the CreateImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
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
        public virtual CreateImageBuilderResponse CreateImageBuilder(CreateImageBuilderRequest request)
        {
            var marshaller = CreateImageBuilderRequestMarshaller.Instance;
            var unmarshaller = CreateImageBuilderResponseUnmarshaller.Instance;

            return Invoke<CreateImageBuilderRequest,CreateImageBuilderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilder">REST API Reference for CreateImageBuilder Operation</seealso>
        public virtual Task<CreateImageBuilderResponse> CreateImageBuilderAsync(CreateImageBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateImageBuilderRequestMarshaller.Instance;
            var unmarshaller = CreateImageBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageBuilderRequest,CreateImageBuilderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateImageBuilderStreamingURL


        /// <summary>
        /// Creates a URL to start an image builder streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilderStreamingURL service method.</param>
        /// 
        /// <returns>The response from the CreateImageBuilderStreamingURL service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilderStreamingURL">REST API Reference for CreateImageBuilderStreamingURL Operation</seealso>
        public virtual CreateImageBuilderStreamingURLResponse CreateImageBuilderStreamingURL(CreateImageBuilderStreamingURLRequest request)
        {
            var marshaller = CreateImageBuilderStreamingURLRequestMarshaller.Instance;
            var unmarshaller = CreateImageBuilderStreamingURLResponseUnmarshaller.Instance;

            return Invoke<CreateImageBuilderStreamingURLRequest,CreateImageBuilderStreamingURLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImageBuilderStreamingURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilderStreamingURL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilderStreamingURL">REST API Reference for CreateImageBuilderStreamingURL Operation</seealso>
        public virtual Task<CreateImageBuilderStreamingURLResponse> CreateImageBuilderStreamingURLAsync(CreateImageBuilderStreamingURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateImageBuilderStreamingURLRequestMarshaller.Instance;
            var unmarshaller = CreateImageBuilderStreamingURLResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageBuilderStreamingURLRequest,CreateImageBuilderStreamingURLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStack


        /// <summary>
        /// Creates a stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
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
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var marshaller = CreateStackRequestMarshaller.Instance;
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackRequest,CreateStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateStackRequestMarshaller.Instance;
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackRequest,CreateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStreamingURL


        /// <summary>
        /// Creates a URL to start a streaming session for the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingURL service method.</param>
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
        public virtual CreateStreamingURLResponse CreateStreamingURL(CreateStreamingURLRequest request)
        {
            var marshaller = CreateStreamingURLRequestMarshaller.Instance;
            var unmarshaller = CreateStreamingURLResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingURLRequest,CreateStreamingURLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingURL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStreamingURL">REST API Reference for CreateStreamingURL Operation</seealso>
        public virtual Task<CreateStreamingURLResponse> CreateStreamingURLAsync(CreateStreamingURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateStreamingURLRequestMarshaller.Instance;
            var unmarshaller = CreateStreamingURLResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamingURLRequest,CreateStreamingURLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectoryConfig


        /// <summary>
        /// Deletes the specified directory configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteDirectoryConfig">REST API Reference for DeleteDirectoryConfig Operation</seealso>
        public virtual DeleteDirectoryConfigResponse DeleteDirectoryConfig(DeleteDirectoryConfigRequest request)
        {
            var marshaller = DeleteDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = DeleteDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryConfigRequest,DeleteDirectoryConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteDirectoryConfig">REST API Reference for DeleteDirectoryConfig Operation</seealso>
        public virtual Task<DeleteDirectoryConfigResponse> DeleteDirectoryConfigAsync(DeleteDirectoryConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = DeleteDirectoryConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectoryConfigRequest,DeleteDirectoryConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// Deletes the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
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
        public virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var marshaller = DeleteFleetRequestMarshaller.Instance;
            var unmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetRequest,DeleteFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFleetRequestMarshaller.Instance;
            var unmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetRequest,DeleteFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteImage


        /// <summary>
        /// Deletes the specified image. You cannot delete an image that is currently in use.
        /// After you delete an image, you cannot provision new capacity using the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage service method.</param>
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
        public virtual DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            var marshaller = DeleteImageRequestMarshaller.Instance;
            var unmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return Invoke<DeleteImageRequest,DeleteImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        public virtual Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteImageRequestMarshaller.Instance;
            var unmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImageRequest,DeleteImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteImageBuilder


        /// <summary>
        /// Deletes the specified image builder and releases the capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageBuilder service method.</param>
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
        public virtual DeleteImageBuilderResponse DeleteImageBuilder(DeleteImageBuilderRequest request)
        {
            var marshaller = DeleteImageBuilderRequestMarshaller.Instance;
            var unmarshaller = DeleteImageBuilderResponseUnmarshaller.Instance;

            return Invoke<DeleteImageBuilderRequest,DeleteImageBuilderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageBuilder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImageBuilder">REST API Reference for DeleteImageBuilder Operation</seealso>
        public virtual Task<DeleteImageBuilderResponse> DeleteImageBuilderAsync(DeleteImageBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteImageBuilderRequestMarshaller.Instance;
            var unmarshaller = DeleteImageBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImageBuilderRequest,DeleteImageBuilderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStack


        /// <summary>
        /// Deletes the specified stack. After this operation completes, the environment can no
        /// longer be activated and any reservations made for the stack are released.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var marshaller = DeleteStackRequestMarshaller.Instance;
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackRequest,DeleteStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteStackRequestMarshaller.Instance;
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackRequest,DeleteStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectoryConfigs


        /// <summary>
        /// Describes the specified directory configurations. Note that although the response
        /// syntax in this topic includes the account password, this password is not returned
        /// in the actual response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectoryConfigs service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectoryConfigs service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeDirectoryConfigs">REST API Reference for DescribeDirectoryConfigs Operation</seealso>
        public virtual DescribeDirectoryConfigsResponse DescribeDirectoryConfigs(DescribeDirectoryConfigsRequest request)
        {
            var marshaller = DescribeDirectoryConfigsRequestMarshaller.Instance;
            var unmarshaller = DescribeDirectoryConfigsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectoryConfigsRequest,DescribeDirectoryConfigsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectoryConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectoryConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeDirectoryConfigs">REST API Reference for DescribeDirectoryConfigs Operation</seealso>
        public virtual Task<DescribeDirectoryConfigsResponse> DescribeDirectoryConfigsAsync(DescribeDirectoryConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDirectoryConfigsRequestMarshaller.Instance;
            var unmarshaller = DescribeDirectoryConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectoryConfigsRequest,DescribeDirectoryConfigsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleets


        /// <summary>
        /// Describes the specified fleets or all fleets in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets service method.</param>
        /// 
        /// <returns>The response from the DescribeFleets service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        public virtual DescribeFleetsResponse DescribeFleets(DescribeFleetsRequest request)
        {
            var marshaller = DescribeFleetsRequestMarshaller.Instance;
            var unmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetsRequest,DescribeFleetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        public virtual Task<DescribeFleetsResponse> DescribeFleetsAsync(DescribeFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeFleetsRequestMarshaller.Instance;
            var unmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetsRequest,DescribeFleetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImageBuilders


        /// <summary>
        /// Describes the specified image builders or all image builders in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageBuilders service method.</param>
        /// 
        /// <returns>The response from the DescribeImageBuilders service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImageBuilders">REST API Reference for DescribeImageBuilders Operation</seealso>
        public virtual DescribeImageBuildersResponse DescribeImageBuilders(DescribeImageBuildersRequest request)
        {
            var marshaller = DescribeImageBuildersRequestMarshaller.Instance;
            var unmarshaller = DescribeImageBuildersResponseUnmarshaller.Instance;

            return Invoke<DescribeImageBuildersRequest,DescribeImageBuildersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageBuilders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageBuilders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImageBuilders">REST API Reference for DescribeImageBuilders Operation</seealso>
        public virtual Task<DescribeImageBuildersResponse> DescribeImageBuildersAsync(DescribeImageBuildersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeImageBuildersRequestMarshaller.Instance;
            var unmarshaller = DescribeImageBuildersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageBuildersRequest,DescribeImageBuildersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImages


        /// <summary>
        /// Describes the specified images or all images in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var marshaller = DescribeImagesRequestMarshaller.Instance;
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesRequest,DescribeImagesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeImagesRequestMarshaller.Instance;
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImagesRequest,DescribeImagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSessions


        /// <summary>
        /// Describes the streaming sessions for the specified stack and fleet. If a user ID is
        /// provided, only the streaming sessions for only that user are returned. If an authentication
        /// type is not provided, the default is to authenticate users using a streaming URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeSessions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public virtual DescribeSessionsResponse DescribeSessions(DescribeSessionsRequest request)
        {
            var marshaller = DescribeSessionsRequestMarshaller.Instance;
            var unmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeSessionsRequest,DescribeSessionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public virtual Task<DescribeSessionsResponse> DescribeSessionsAsync(DescribeSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSessionsRequestMarshaller.Instance;
            var unmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSessionsRequest,DescribeSessionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStacks


        /// <summary>
        /// Describes the specified stacks or all stacks in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var marshaller = DescribeStacksRequestMarshaller.Instance;
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeStacksRequestMarshaller.Instance;
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFleet


        /// <summary>
        /// Disassociates the specified fleet from the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFleet service method.</param>
        /// 
        /// <returns>The response from the DisassociateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateFleet">REST API Reference for DisassociateFleet Operation</seealso>
        public virtual DisassociateFleetResponse DisassociateFleet(DisassociateFleetRequest request)
        {
            var marshaller = DisassociateFleetRequestMarshaller.Instance;
            var unmarshaller = DisassociateFleetResponseUnmarshaller.Instance;

            return Invoke<DisassociateFleetRequest,DisassociateFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateFleet">REST API Reference for DisassociateFleet Operation</seealso>
        public virtual Task<DisassociateFleetResponse> DisassociateFleetAsync(DisassociateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateFleetRequestMarshaller.Instance;
            var unmarshaller = DisassociateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFleetRequest,DisassociateFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ExpireSession


        /// <summary>
        /// Stops the specified streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession service method.</param>
        /// 
        /// <returns>The response from the ExpireSession service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public virtual ExpireSessionResponse ExpireSession(ExpireSessionRequest request)
        {
            var marshaller = ExpireSessionRequestMarshaller.Instance;
            var unmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return Invoke<ExpireSessionRequest,ExpireSessionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExpireSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public virtual Task<ExpireSessionResponse> ExpireSessionAsync(ExpireSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ExpireSessionRequestMarshaller.Instance;
            var unmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return InvokeAsync<ExpireSessionRequest,ExpireSessionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssociatedFleets


        /// <summary>
        /// Lists the fleets associated with the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedFleets service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedFleets service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        public virtual ListAssociatedFleetsResponse ListAssociatedFleets(ListAssociatedFleetsRequest request)
        {
            var marshaller = ListAssociatedFleetsRequestMarshaller.Instance;
            var unmarshaller = ListAssociatedFleetsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedFleetsRequest,ListAssociatedFleetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        public virtual Task<ListAssociatedFleetsResponse> ListAssociatedFleetsAsync(ListAssociatedFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAssociatedFleetsRequestMarshaller.Instance;
            var unmarshaller = ListAssociatedFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociatedFleetsRequest,ListAssociatedFleetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssociatedStacks


        /// <summary>
        /// Lists the stacks associated with the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedStacks service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedStacks service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        public virtual ListAssociatedStacksResponse ListAssociatedStacks(ListAssociatedStacksRequest request)
        {
            var marshaller = ListAssociatedStacksRequestMarshaller.Instance;
            var unmarshaller = ListAssociatedStacksResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedStacksRequest,ListAssociatedStacksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        public virtual Task<ListAssociatedStacksResponse> ListAssociatedStacksAsync(ListAssociatedStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAssociatedStacksRequestMarshaller.Instance;
            var unmarshaller = ListAssociatedStacksResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociatedStacksRequest,ListAssociatedStacksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified AppStream 2.0 resource. You can tag AppStream 2.0
        /// image builders, images, fleets, and stacks.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartFleet


        /// <summary>
        /// Starts the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFleet service method.</param>
        /// 
        /// <returns>The response from the StartFleet service method, as returned by AppStream.</returns>
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
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartFleet">REST API Reference for StartFleet Operation</seealso>
        public virtual StartFleetResponse StartFleet(StartFleetRequest request)
        {
            var marshaller = StartFleetRequestMarshaller.Instance;
            var unmarshaller = StartFleetResponseUnmarshaller.Instance;

            return Invoke<StartFleetRequest,StartFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartFleet">REST API Reference for StartFleet Operation</seealso>
        public virtual Task<StartFleetResponse> StartFleetAsync(StartFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartFleetRequestMarshaller.Instance;
            var unmarshaller = StartFleetResponseUnmarshaller.Instance;

            return InvokeAsync<StartFleetRequest,StartFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartImageBuilder


        /// <summary>
        /// Starts the specified image builder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImageBuilder service method.</param>
        /// 
        /// <returns>The response from the StartImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
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
        public virtual StartImageBuilderResponse StartImageBuilder(StartImageBuilderRequest request)
        {
            var marshaller = StartImageBuilderRequestMarshaller.Instance;
            var unmarshaller = StartImageBuilderResponseUnmarshaller.Instance;

            return Invoke<StartImageBuilderRequest,StartImageBuilderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImageBuilder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartImageBuilder">REST API Reference for StartImageBuilder Operation</seealso>
        public virtual Task<StartImageBuilderResponse> StartImageBuilderAsync(StartImageBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartImageBuilderRequestMarshaller.Instance;
            var unmarshaller = StartImageBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<StartImageBuilderRequest,StartImageBuilderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopFleet


        /// <summary>
        /// Stops the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFleet service method.</param>
        /// 
        /// <returns>The response from the StopFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopFleet">REST API Reference for StopFleet Operation</seealso>
        public virtual StopFleetResponse StopFleet(StopFleetRequest request)
        {
            var marshaller = StopFleetRequestMarshaller.Instance;
            var unmarshaller = StopFleetResponseUnmarshaller.Instance;

            return Invoke<StopFleetRequest,StopFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopFleet">REST API Reference for StopFleet Operation</seealso>
        public virtual Task<StopFleetResponse> StopFleetAsync(StopFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopFleetRequestMarshaller.Instance;
            var unmarshaller = StopFleetResponseUnmarshaller.Instance;

            return InvokeAsync<StopFleetRequest,StopFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopImageBuilder


        /// <summary>
        /// Stops the specified image builder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopImageBuilder service method.</param>
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
        public virtual StopImageBuilderResponse StopImageBuilder(StopImageBuilderRequest request)
        {
            var marshaller = StopImageBuilderRequestMarshaller.Instance;
            var unmarshaller = StopImageBuilderResponseUnmarshaller.Instance;

            return Invoke<StopImageBuilderRequest,StopImageBuilderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopImageBuilder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopImageBuilder">REST API Reference for StopImageBuilder Operation</seealso>
        public virtual Task<StopImageBuilderResponse> StopImageBuilderAsync(StopImageBuilderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopImageBuilderRequestMarshaller.Instance;
            var unmarshaller = StopImageBuilderResponseUnmarshaller.Instance;

            return InvokeAsync<StopImageBuilderRequest,StopImageBuilderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource


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
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Disassociates the specified tags from the specified AppStream 2.0 resource.
        /// 
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>ListTagsForResource</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDirectoryConfig


        /// <summary>
        /// Updates the specified directory configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateDirectoryConfig">REST API Reference for UpdateDirectoryConfig Operation</seealso>
        public virtual UpdateDirectoryConfigResponse UpdateDirectoryConfig(UpdateDirectoryConfigRequest request)
        {
            var marshaller = UpdateDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = UpdateDirectoryConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateDirectoryConfigRequest,UpdateDirectoryConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectoryConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateDirectoryConfig">REST API Reference for UpdateDirectoryConfig Operation</seealso>
        public virtual Task<UpdateDirectoryConfigResponse> UpdateDirectoryConfigAsync(UpdateDirectoryConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDirectoryConfigRequestMarshaller.Instance;
            var unmarshaller = UpdateDirectoryConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDirectoryConfigRequest,UpdateDirectoryConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleet


        /// <summary>
        /// Updates the specified fleet.
        /// 
        ///  
        /// <para>
        /// If the fleet is in the <code>STOPPED</code> state, you can update any attribute except
        /// the fleet name. If the fleet is in the <code>RUNNING</code> state, you can update
        /// the <code>DisplayName</code> and <code>ComputeCapacity</code> attributes. If the fleet
        /// is in the <code>STARTING</code> or <code>STOPPING</code> state, you can't update it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
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
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public virtual UpdateFleetResponse UpdateFleet(UpdateFleetRequest request)
        {
            var marshaller = UpdateFleetRequestMarshaller.Instance;
            var unmarshaller = UpdateFleetResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetRequest,UpdateFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public virtual Task<UpdateFleetResponse> UpdateFleetAsync(UpdateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateFleetRequestMarshaller.Instance;
            var unmarshaller = UpdateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetRequest,UpdateFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStack


        /// <summary>
        /// Updates the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
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
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var marshaller = UpdateStackRequestMarshaller.Instance;
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackRequest,UpdateStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateStackRequestMarshaller.Instance;
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackRequest,UpdateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}