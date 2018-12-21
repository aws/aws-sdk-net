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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaPackage.Model;
using Amazon.MediaPackage.Model.Internal.MarshallTransformations;
using Amazon.MediaPackage.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaPackage
{
    /// <summary>
    /// Implementation for accessing MediaPackage
    ///
    /// AWS Elemental MediaPackage
    /// </summary>
    public partial class AmazonMediaPackageClient : AmazonServiceClient, IAmazonMediaPackage
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaPackageMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaPackageClient with the credentials loaded from the application's
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
        public AmazonMediaPackageClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaPackageConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with the credentials loaded from the application's
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
        public AmazonMediaPackageClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaPackageConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaPackageClient Configuration Object</param>
        public AmazonMediaPackageClient(AmazonMediaPackageConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaPackageClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaPackageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaPackageConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Credentials and an
        /// AmazonMediaPackageClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaPackageClient Configuration Object</param>
        public AmazonMediaPackageClient(AWSCredentials credentials, AmazonMediaPackageConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaPackageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaPackageConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaPackageClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaPackageClient Configuration Object</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaPackageConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaPackageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaPackageConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaPackageClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaPackageClient Configuration Object</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaPackageConfig clientConfig)
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


        #region  CreateChannel


        /// <summary>
        /// Creates a new Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOriginEndpoint


        /// <summary>
        /// Creates a new OriginEndpoint record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        public virtual CreateOriginEndpointResponse CreateOriginEndpoint(CreateOriginEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateOriginEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        public virtual Task<CreateOriginEndpointResponse> CreateOriginEndpointAsync(CreateOriginEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOriginEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOriginEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Deletes an existing Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOriginEndpoint


        /// <summary>
        /// Deletes an existing OriginEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        public virtual DeleteOriginEndpointResponse DeleteOriginEndpoint(DeleteOriginEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteOriginEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        public virtual Task<DeleteOriginEndpointResponse> DeleteOriginEndpointAsync(DeleteOriginEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOriginEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOriginEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannel


        /// <summary>
        /// Gets details about a Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOriginEndpoint


        /// <summary>
        /// Gets details about an existing OriginEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeOriginEndpoint">REST API Reference for DescribeOriginEndpoint Operation</seealso>
        public virtual DescribeOriginEndpointResponse DescribeOriginEndpoint(DescribeOriginEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeOriginEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOriginEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeOriginEndpoint">REST API Reference for DescribeOriginEndpoint Operation</seealso>
        public virtual Task<DescribeOriginEndpointResponse> DescribeOriginEndpointAsync(DescribeOriginEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOriginEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOriginEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Returns a collection of Channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOriginEndpoints


        /// <summary>
        /// Returns a collection of OriginEndpoint records.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListOriginEndpoints service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        public virtual ListOriginEndpointsResponse ListOriginEndpoints(ListOriginEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOriginEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOriginEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListOriginEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOriginEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOriginEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        public virtual Task<ListOriginEndpointsResponse> ListOriginEndpointsAsync(ListOriginEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOriginEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOriginEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOriginEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RotateChannelCredentials


        /// <summary>
        /// Changes the Channel's first IngestEndpoint's username and password. WARNING - This
        /// API is deprecated. Please use RotateIngestEndpointCredentials instead
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateChannelCredentials service method.</param>
        /// 
        /// <returns>The response from the RotateChannelCredentials service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateChannelCredentials">REST API Reference for RotateChannelCredentials Operation</seealso>
        [Obsolete("This API is deprecated. Please use RotateIngestEndpointCredentials instead")]
        public virtual RotateChannelCredentialsResponse RotateChannelCredentials(RotateChannelCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateChannelCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateChannelCredentialsResponseUnmarshaller.Instance;

            return Invoke<RotateChannelCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RotateChannelCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateChannelCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateChannelCredentials">REST API Reference for RotateChannelCredentials Operation</seealso>
        [Obsolete("This API is deprecated. Please use RotateIngestEndpointCredentials instead")]
        public virtual Task<RotateChannelCredentialsResponse> RotateChannelCredentialsAsync(RotateChannelCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateChannelCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateChannelCredentialsResponseUnmarshaller.Instance;
            
            return InvokeAsync<RotateChannelCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RotateIngestEndpointCredentials


        /// <summary>
        /// Rotate the IngestEndpoint's username and password, as specified by the IngestEndpoint's
        /// id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateIngestEndpointCredentials service method.</param>
        /// 
        /// <returns>The response from the RotateIngestEndpointCredentials service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateIngestEndpointCredentials">REST API Reference for RotateIngestEndpointCredentials Operation</seealso>
        public virtual RotateIngestEndpointCredentialsResponse RotateIngestEndpointCredentials(RotateIngestEndpointCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateIngestEndpointCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateIngestEndpointCredentialsResponseUnmarshaller.Instance;

            return Invoke<RotateIngestEndpointCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RotateIngestEndpointCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateIngestEndpointCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateIngestEndpointCredentials">REST API Reference for RotateIngestEndpointCredentials Operation</seealso>
        public virtual Task<RotateIngestEndpointCredentialsResponse> RotateIngestEndpointCredentialsAsync(RotateIngestEndpointCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateIngestEndpointCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateIngestEndpointCredentialsResponseUnmarshaller.Instance;
            
            return InvokeAsync<RotateIngestEndpointCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Updates an existing Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOriginEndpoint


        /// <summary>
        /// Updates an existing OriginEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        public virtual UpdateOriginEndpointResponse UpdateOriginEndpoint(UpdateOriginEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateOriginEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        public virtual Task<UpdateOriginEndpointResponse> UpdateOriginEndpointAsync(UpdateOriginEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOriginEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateOriginEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}