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

using Amazon.MediaPackage.Model;
using Amazon.MediaPackage.Model.Internal.MarshallTransformations;
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
        
        #region Constructors

#if CORECLR
    
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

#endif

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

        internal virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var marshaller = CreateChannelRequestMarshaller.Instance;
            var unmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelRequest,CreateChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateChannelRequestMarshaller.Instance;
            var unmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelRequest,CreateChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateOriginEndpoint

        internal virtual CreateOriginEndpointResponse CreateOriginEndpoint(CreateOriginEndpointRequest request)
        {
            var marshaller = CreateOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateOriginEndpointRequest,CreateOriginEndpointResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateOriginEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOriginEndpointRequest,CreateOriginEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannel

        internal virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var marshaller = DeleteChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelRequest,DeleteChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelRequest,DeleteChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteOriginEndpoint

        internal virtual DeleteOriginEndpointResponse DeleteOriginEndpoint(DeleteOriginEndpointRequest request)
        {
            var marshaller = DeleteOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteOriginEndpointRequest,DeleteOriginEndpointResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteOriginEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOriginEndpointRequest,DeleteOriginEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannel

        internal virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var marshaller = DescribeChannelRequestMarshaller.Instance;
            var unmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelRequest,DescribeChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeChannelRequestMarshaller.Instance;
            var unmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelRequest,DescribeChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOriginEndpoint

        internal virtual DescribeOriginEndpointResponse DescribeOriginEndpoint(DescribeOriginEndpointRequest request)
        {
            var marshaller = DescribeOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = DescribeOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeOriginEndpointRequest,DescribeOriginEndpointResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = DescribeOriginEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOriginEndpointRequest,DescribeOriginEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChannels

        internal virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var marshaller = ListChannelsRequestMarshaller.Instance;
            var unmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsRequest,ListChannelsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListChannelsRequestMarshaller.Instance;
            var unmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelsRequest,ListChannelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOriginEndpoints

        internal virtual ListOriginEndpointsResponse ListOriginEndpoints(ListOriginEndpointsRequest request)
        {
            var marshaller = ListOriginEndpointsRequestMarshaller.Instance;
            var unmarshaller = ListOriginEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListOriginEndpointsRequest,ListOriginEndpointsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListOriginEndpointsRequestMarshaller.Instance;
            var unmarshaller = ListOriginEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOriginEndpointsRequest,ListOriginEndpointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RotateChannelCredentials

        internal virtual RotateChannelCredentialsResponse RotateChannelCredentials(RotateChannelCredentialsRequest request)
        {
            var marshaller = RotateChannelCredentialsRequestMarshaller.Instance;
            var unmarshaller = RotateChannelCredentialsResponseUnmarshaller.Instance;

            return Invoke<RotateChannelCredentialsRequest,RotateChannelCredentialsResponse>(request, marshaller, unmarshaller);
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
        public virtual Task<RotateChannelCredentialsResponse> RotateChannelCredentialsAsync(RotateChannelCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RotateChannelCredentialsRequestMarshaller.Instance;
            var unmarshaller = RotateChannelCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<RotateChannelCredentialsRequest,RotateChannelCredentialsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannel

        internal virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var marshaller = UpdateChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelRequest,UpdateChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelRequest,UpdateChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateOriginEndpoint

        internal virtual UpdateOriginEndpointResponse UpdateOriginEndpoint(UpdateOriginEndpointRequest request)
        {
            var marshaller = UpdateOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateOriginEndpointRequest,UpdateOriginEndpointResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateOriginEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOriginEndpointRequest,UpdateOriginEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}