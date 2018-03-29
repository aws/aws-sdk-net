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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Pinpoint.Model;
using Amazon.Pinpoint.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Pinpoint
{
    /// <summary>
    /// Implementation for accessing Pinpoint
    ///
    /// 
    /// </summary>
    public partial class AmazonPinpointClient : AmazonServiceClient, IAmazonPinpoint
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonPinpointClient with the credentials loaded from the application's
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
        public AmazonPinpointClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointConfig()) { }

        /// <summary>
        /// Constructs AmazonPinpointClient with the credentials loaded from the application's
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
        public AmazonPinpointClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPinpointClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(AmazonPinpointConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPinpointClient(AWSCredentials credentials)
            : this(credentials, new AmazonPinpointConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPinpointConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Credentials and an
        /// AmazonPinpointClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(AWSCredentials credentials, AmazonPinpointConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPinpointConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPinpointConfig clientConfig)
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

        
        #region  CreateApp

        internal virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var marshaller = CreateAppRequestMarshaller.Instance;
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppRequest,CreateAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAppRequestMarshaller.Instance;
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppRequest,CreateAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCampaign

        internal virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var marshaller = CreateCampaignRequestMarshaller.Instance;
            var unmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignRequest,CreateCampaignResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCampaignRequestMarshaller.Instance;
            var unmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCampaignRequest,CreateCampaignResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateExportJob

        internal virtual CreateExportJobResponse CreateExportJob(CreateExportJobRequest request)
        {
            var marshaller = CreateExportJobRequestMarshaller.Instance;
            var unmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateExportJobRequest,CreateExportJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateExportJobResponse> CreateExportJobAsync(CreateExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateExportJobRequestMarshaller.Instance;
            var unmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExportJobRequest,CreateExportJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateImportJob

        internal virtual CreateImportJobResponse CreateImportJob(CreateImportJobRequest request)
        {
            var marshaller = CreateImportJobRequestMarshaller.Instance;
            var unmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateImportJobRequest,CreateImportJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateImportJobResponse> CreateImportJobAsync(CreateImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateImportJobRequestMarshaller.Instance;
            var unmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImportJobRequest,CreateImportJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSegment

        internal virtual CreateSegmentResponse CreateSegment(CreateSegmentRequest request)
        {
            var marshaller = CreateSegmentRequestMarshaller.Instance;
            var unmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return Invoke<CreateSegmentRequest,CreateSegmentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateSegmentResponse> CreateSegmentAsync(CreateSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSegmentRequestMarshaller.Instance;
            var unmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSegmentRequest,CreateSegmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAdmChannel

        internal virtual DeleteAdmChannelResponse DeleteAdmChannel(DeleteAdmChannelRequest request)
        {
            var marshaller = DeleteAdmChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteAdmChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteAdmChannelRequest,DeleteAdmChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteAdmChannelResponse> DeleteAdmChannelAsync(DeleteAdmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAdmChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteAdmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAdmChannelRequest,DeleteAdmChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApnsChannel

        internal virtual DeleteApnsChannelResponse DeleteApnsChannel(DeleteApnsChannelRequest request)
        {
            var marshaller = DeleteApnsChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsChannelRequest,DeleteApnsChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApnsChannelResponse> DeleteApnsChannelAsync(DeleteApnsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteApnsChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApnsChannelRequest,DeleteApnsChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApnsSandboxChannel

        internal virtual DeleteApnsSandboxChannelResponse DeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request)
        {
            var marshaller = DeleteApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsSandboxChannelRequest,DeleteApnsSandboxChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApnsSandboxChannelResponse> DeleteApnsSandboxChannelAsync(DeleteApnsSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApnsSandboxChannelRequest,DeleteApnsSandboxChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApnsVoipChannel

        internal virtual DeleteApnsVoipChannelResponse DeleteApnsVoipChannel(DeleteApnsVoipChannelRequest request)
        {
            var marshaller = DeleteApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsVoipChannelRequest,DeleteApnsVoipChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApnsVoipChannelResponse> DeleteApnsVoipChannelAsync(DeleteApnsVoipChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsVoipChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApnsVoipChannelRequest,DeleteApnsVoipChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApnsVoipSandboxChannel

        internal virtual DeleteApnsVoipSandboxChannelResponse DeleteApnsVoipSandboxChannel(DeleteApnsVoipSandboxChannelRequest request)
        {
            var marshaller = DeleteApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsVoipSandboxChannelRequest,DeleteApnsVoipSandboxChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApnsVoipSandboxChannelResponse> DeleteApnsVoipSandboxChannelAsync(DeleteApnsVoipSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApnsVoipSandboxChannelRequest,DeleteApnsVoipSandboxChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp

        internal virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var marshaller = DeleteAppRequestMarshaller.Instance;
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppRequest,DeleteAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAppRequestMarshaller.Instance;
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppRequest,DeleteAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBaiduChannel

        internal virtual DeleteBaiduChannelResponse DeleteBaiduChannel(DeleteBaiduChannelRequest request)
        {
            var marshaller = DeleteBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteBaiduChannelRequest,DeleteBaiduChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBaiduChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBaiduChannelResponse> DeleteBaiduChannelAsync(DeleteBaiduChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteBaiduChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBaiduChannelRequest,DeleteBaiduChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCampaign

        internal virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var marshaller = DeleteCampaignRequestMarshaller.Instance;
            var unmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignRequest,DeleteCampaignResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteCampaignResponse> DeleteCampaignAsync(DeleteCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCampaignRequestMarshaller.Instance;
            var unmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCampaignRequest,DeleteCampaignResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEmailChannel

        internal virtual DeleteEmailChannelResponse DeleteEmailChannel(DeleteEmailChannelRequest request)
        {
            var marshaller = DeleteEmailChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteEmailChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailChannelRequest,DeleteEmailChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteEmailChannelResponse> DeleteEmailChannelAsync(DeleteEmailChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteEmailChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteEmailChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEmailChannelRequest,DeleteEmailChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint

        internal virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var marshaller = DeleteEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointRequest,DeleteEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointRequest,DeleteEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventStream

        internal virtual DeleteEventStreamResponse DeleteEventStream(DeleteEventStreamRequest request)
        {
            var marshaller = DeleteEventStreamRequestMarshaller.Instance;
            var unmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteEventStreamRequest,DeleteEventStreamResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteEventStreamResponse> DeleteEventStreamAsync(DeleteEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteEventStreamRequestMarshaller.Instance;
            var unmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventStreamRequest,DeleteEventStreamResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGcmChannel

        internal virtual DeleteGcmChannelResponse DeleteGcmChannel(DeleteGcmChannelRequest request)
        {
            var marshaller = DeleteGcmChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteGcmChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteGcmChannelRequest,DeleteGcmChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteGcmChannelResponse> DeleteGcmChannelAsync(DeleteGcmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteGcmChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteGcmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGcmChannelRequest,DeleteGcmChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSegment

        internal virtual DeleteSegmentResponse DeleteSegment(DeleteSegmentRequest request)
        {
            var marshaller = DeleteSegmentRequestMarshaller.Instance;
            var unmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return Invoke<DeleteSegmentRequest,DeleteSegmentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteSegmentResponse> DeleteSegmentAsync(DeleteSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSegmentRequestMarshaller.Instance;
            var unmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSegmentRequest,DeleteSegmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSmsChannel

        internal virtual DeleteSmsChannelResponse DeleteSmsChannel(DeleteSmsChannelRequest request)
        {
            var marshaller = DeleteSmsChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteSmsChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteSmsChannelRequest,DeleteSmsChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteSmsChannelResponse> DeleteSmsChannelAsync(DeleteSmsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSmsChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteSmsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSmsChannelRequest,DeleteSmsChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAdmChannel

        internal virtual GetAdmChannelResponse GetAdmChannel(GetAdmChannelRequest request)
        {
            var marshaller = GetAdmChannelRequestMarshaller.Instance;
            var unmarshaller = GetAdmChannelResponseUnmarshaller.Instance;

            return Invoke<GetAdmChannelRequest,GetAdmChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAdmChannelResponse> GetAdmChannelAsync(GetAdmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAdmChannelRequestMarshaller.Instance;
            var unmarshaller = GetAdmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetAdmChannelRequest,GetAdmChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApnsChannel

        internal virtual GetApnsChannelResponse GetApnsChannel(GetApnsChannelRequest request)
        {
            var marshaller = GetApnsChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsChannelRequest,GetApnsChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApnsChannelResponse> GetApnsChannelAsync(GetApnsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetApnsChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetApnsChannelRequest,GetApnsChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApnsSandboxChannel

        internal virtual GetApnsSandboxChannelResponse GetApnsSandboxChannel(GetApnsSandboxChannelRequest request)
        {
            var marshaller = GetApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsSandboxChannelRequest,GetApnsSandboxChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApnsSandboxChannelResponse> GetApnsSandboxChannelAsync(GetApnsSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetApnsSandboxChannelRequest,GetApnsSandboxChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApnsVoipChannel

        internal virtual GetApnsVoipChannelResponse GetApnsVoipChannel(GetApnsVoipChannelRequest request)
        {
            var marshaller = GetApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsVoipChannelRequest,GetApnsVoipChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApnsVoipChannelResponse> GetApnsVoipChannelAsync(GetApnsVoipChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsVoipChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetApnsVoipChannelRequest,GetApnsVoipChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApnsVoipSandboxChannel

        internal virtual GetApnsVoipSandboxChannelResponse GetApnsVoipSandboxChannel(GetApnsVoipSandboxChannelRequest request)
        {
            var marshaller = GetApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsVoipSandboxChannelRequest,GetApnsVoipSandboxChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApnsVoipSandboxChannelResponse> GetApnsVoipSandboxChannelAsync(GetApnsVoipSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetApnsVoipSandboxChannelRequest,GetApnsVoipSandboxChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApp

        internal virtual GetAppResponse GetApp(GetAppRequest request)
        {
            var marshaller = GetAppRequestMarshaller.Instance;
            var unmarshaller = GetAppResponseUnmarshaller.Instance;

            return Invoke<GetAppRequest,GetAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAppResponse> GetAppAsync(GetAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAppRequestMarshaller.Instance;
            var unmarshaller = GetAppResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppRequest,GetAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApplicationSettings

        internal virtual GetApplicationSettingsResponse GetApplicationSettings(GetApplicationSettingsRequest request)
        {
            var marshaller = GetApplicationSettingsRequestMarshaller.Instance;
            var unmarshaller = GetApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<GetApplicationSettingsRequest,GetApplicationSettingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApplicationSettingsResponse> GetApplicationSettingsAsync(GetApplicationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetApplicationSettingsRequestMarshaller.Instance;
            var unmarshaller = GetApplicationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationSettingsRequest,GetApplicationSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApps

        internal virtual GetAppsResponse GetApps(GetAppsRequest request)
        {
            var marshaller = GetAppsRequestMarshaller.Instance;
            var unmarshaller = GetAppsResponseUnmarshaller.Instance;

            return Invoke<GetAppsRequest,GetAppsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAppsResponse> GetAppsAsync(GetAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAppsRequestMarshaller.Instance;
            var unmarshaller = GetAppsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppsRequest,GetAppsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBaiduChannel

        internal virtual GetBaiduChannelResponse GetBaiduChannel(GetBaiduChannelRequest request)
        {
            var marshaller = GetBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = GetBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<GetBaiduChannelRequest,GetBaiduChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBaiduChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBaiduChannelResponse> GetBaiduChannelAsync(GetBaiduChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = GetBaiduChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetBaiduChannelRequest,GetBaiduChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCampaign

        internal virtual GetCampaignResponse GetCampaign(GetCampaignRequest request)
        {
            var marshaller = GetCampaignRequestMarshaller.Instance;
            var unmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return Invoke<GetCampaignRequest,GetCampaignResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCampaignResponse> GetCampaignAsync(GetCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCampaignRequestMarshaller.Instance;
            var unmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignRequest,GetCampaignResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCampaignActivities

        internal virtual GetCampaignActivitiesResponse GetCampaignActivities(GetCampaignActivitiesRequest request)
        {
            var marshaller = GetCampaignActivitiesRequestMarshaller.Instance;
            var unmarshaller = GetCampaignActivitiesResponseUnmarshaller.Instance;

            return Invoke<GetCampaignActivitiesRequest,GetCampaignActivitiesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCampaignActivitiesResponse> GetCampaignActivitiesAsync(GetCampaignActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCampaignActivitiesRequestMarshaller.Instance;
            var unmarshaller = GetCampaignActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignActivitiesRequest,GetCampaignActivitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCampaigns

        internal virtual GetCampaignsResponse GetCampaigns(GetCampaignsRequest request)
        {
            var marshaller = GetCampaignsRequestMarshaller.Instance;
            var unmarshaller = GetCampaignsResponseUnmarshaller.Instance;

            return Invoke<GetCampaignsRequest,GetCampaignsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCampaignsResponse> GetCampaignsAsync(GetCampaignsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCampaignsRequestMarshaller.Instance;
            var unmarshaller = GetCampaignsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignsRequest,GetCampaignsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCampaignVersion

        internal virtual GetCampaignVersionResponse GetCampaignVersion(GetCampaignVersionRequest request)
        {
            var marshaller = GetCampaignVersionRequestMarshaller.Instance;
            var unmarshaller = GetCampaignVersionResponseUnmarshaller.Instance;

            return Invoke<GetCampaignVersionRequest,GetCampaignVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCampaignVersionResponse> GetCampaignVersionAsync(GetCampaignVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCampaignVersionRequestMarshaller.Instance;
            var unmarshaller = GetCampaignVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignVersionRequest,GetCampaignVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCampaignVersions

        internal virtual GetCampaignVersionsResponse GetCampaignVersions(GetCampaignVersionsRequest request)
        {
            var marshaller = GetCampaignVersionsRequestMarshaller.Instance;
            var unmarshaller = GetCampaignVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCampaignVersionsRequest,GetCampaignVersionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCampaignVersionsResponse> GetCampaignVersionsAsync(GetCampaignVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCampaignVersionsRequestMarshaller.Instance;
            var unmarshaller = GetCampaignVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignVersionsRequest,GetCampaignVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetEmailChannel

        internal virtual GetEmailChannelResponse GetEmailChannel(GetEmailChannelRequest request)
        {
            var marshaller = GetEmailChannelRequestMarshaller.Instance;
            var unmarshaller = GetEmailChannelResponseUnmarshaller.Instance;

            return Invoke<GetEmailChannelRequest,GetEmailChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetEmailChannelResponse> GetEmailChannelAsync(GetEmailChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetEmailChannelRequestMarshaller.Instance;
            var unmarshaller = GetEmailChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetEmailChannelRequest,GetEmailChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetEndpoint

        internal virtual GetEndpointResponse GetEndpoint(GetEndpointRequest request)
        {
            var marshaller = GetEndpointRequestMarshaller.Instance;
            var unmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return Invoke<GetEndpointRequest,GetEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetEndpointResponse> GetEndpointAsync(GetEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetEndpointRequestMarshaller.Instance;
            var unmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetEndpointRequest,GetEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetEventStream

        internal virtual GetEventStreamResponse GetEventStream(GetEventStreamRequest request)
        {
            var marshaller = GetEventStreamRequestMarshaller.Instance;
            var unmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return Invoke<GetEventStreamRequest,GetEventStreamResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetEventStreamResponse> GetEventStreamAsync(GetEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetEventStreamRequestMarshaller.Instance;
            var unmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventStreamRequest,GetEventStreamResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetExportJob

        internal virtual GetExportJobResponse GetExportJob(GetExportJobRequest request)
        {
            var marshaller = GetExportJobRequestMarshaller.Instance;
            var unmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return Invoke<GetExportJobRequest,GetExportJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetExportJobResponse> GetExportJobAsync(GetExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetExportJobRequestMarshaller.Instance;
            var unmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportJobRequest,GetExportJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetExportJobs

        internal virtual GetExportJobsResponse GetExportJobs(GetExportJobsRequest request)
        {
            var marshaller = GetExportJobsRequestMarshaller.Instance;
            var unmarshaller = GetExportJobsResponseUnmarshaller.Instance;

            return Invoke<GetExportJobsRequest,GetExportJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetExportJobsResponse> GetExportJobsAsync(GetExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetExportJobsRequestMarshaller.Instance;
            var unmarshaller = GetExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportJobsRequest,GetExportJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGcmChannel

        internal virtual GetGcmChannelResponse GetGcmChannel(GetGcmChannelRequest request)
        {
            var marshaller = GetGcmChannelRequestMarshaller.Instance;
            var unmarshaller = GetGcmChannelResponseUnmarshaller.Instance;

            return Invoke<GetGcmChannelRequest,GetGcmChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetGcmChannelResponse> GetGcmChannelAsync(GetGcmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetGcmChannelRequestMarshaller.Instance;
            var unmarshaller = GetGcmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetGcmChannelRequest,GetGcmChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetImportJob

        internal virtual GetImportJobResponse GetImportJob(GetImportJobRequest request)
        {
            var marshaller = GetImportJobRequestMarshaller.Instance;
            var unmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return Invoke<GetImportJobRequest,GetImportJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetImportJobResponse> GetImportJobAsync(GetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetImportJobRequestMarshaller.Instance;
            var unmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportJobRequest,GetImportJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetImportJobs

        internal virtual GetImportJobsResponse GetImportJobs(GetImportJobsRequest request)
        {
            var marshaller = GetImportJobsRequestMarshaller.Instance;
            var unmarshaller = GetImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetImportJobsRequest,GetImportJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetImportJobsResponse> GetImportJobsAsync(GetImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetImportJobsRequestMarshaller.Instance;
            var unmarshaller = GetImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportJobsRequest,GetImportJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSegment

        internal virtual GetSegmentResponse GetSegment(GetSegmentRequest request)
        {
            var marshaller = GetSegmentRequestMarshaller.Instance;
            var unmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return Invoke<GetSegmentRequest,GetSegmentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentResponse> GetSegmentAsync(GetSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSegmentRequestMarshaller.Instance;
            var unmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentRequest,GetSegmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSegmentExportJobs

        internal virtual GetSegmentExportJobsResponse GetSegmentExportJobs(GetSegmentExportJobsRequest request)
        {
            var marshaller = GetSegmentExportJobsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentExportJobsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentExportJobsRequest,GetSegmentExportJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentExportJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentExportJobsResponse> GetSegmentExportJobsAsync(GetSegmentExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSegmentExportJobsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentExportJobsRequest,GetSegmentExportJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSegmentImportJobs

        internal virtual GetSegmentImportJobsResponse GetSegmentImportJobs(GetSegmentImportJobsRequest request)
        {
            var marshaller = GetSegmentImportJobsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentImportJobsRequest,GetSegmentImportJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentImportJobsResponse> GetSegmentImportJobsAsync(GetSegmentImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSegmentImportJobsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentImportJobsRequest,GetSegmentImportJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSegments

        internal virtual GetSegmentsResponse GetSegments(GetSegmentsRequest request)
        {
            var marshaller = GetSegmentsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentsRequest,GetSegmentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentsResponse> GetSegmentsAsync(GetSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSegmentsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentsRequest,GetSegmentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSegmentVersion

        internal virtual GetSegmentVersionResponse GetSegmentVersion(GetSegmentVersionRequest request)
        {
            var marshaller = GetSegmentVersionRequestMarshaller.Instance;
            var unmarshaller = GetSegmentVersionResponseUnmarshaller.Instance;

            return Invoke<GetSegmentVersionRequest,GetSegmentVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentVersionResponse> GetSegmentVersionAsync(GetSegmentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSegmentVersionRequestMarshaller.Instance;
            var unmarshaller = GetSegmentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentVersionRequest,GetSegmentVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSegmentVersions

        internal virtual GetSegmentVersionsResponse GetSegmentVersions(GetSegmentVersionsRequest request)
        {
            var marshaller = GetSegmentVersionsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentVersionsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentVersionsRequest,GetSegmentVersionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSegmentVersionsResponse> GetSegmentVersionsAsync(GetSegmentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSegmentVersionsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentVersionsRequest,GetSegmentVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSmsChannel

        internal virtual GetSmsChannelResponse GetSmsChannel(GetSmsChannelRequest request)
        {
            var marshaller = GetSmsChannelRequestMarshaller.Instance;
            var unmarshaller = GetSmsChannelResponseUnmarshaller.Instance;

            return Invoke<GetSmsChannelRequest,GetSmsChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSmsChannelResponse> GetSmsChannelAsync(GetSmsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSmsChannelRequestMarshaller.Instance;
            var unmarshaller = GetSmsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetSmsChannelRequest,GetSmsChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutEventStream

        internal virtual PutEventStreamResponse PutEventStream(PutEventStreamRequest request)
        {
            var marshaller = PutEventStreamRequestMarshaller.Instance;
            var unmarshaller = PutEventStreamResponseUnmarshaller.Instance;

            return Invoke<PutEventStreamRequest,PutEventStreamResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutEventStreamResponse> PutEventStreamAsync(PutEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutEventStreamRequestMarshaller.Instance;
            var unmarshaller = PutEventStreamResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventStreamRequest,PutEventStreamResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendMessages

        internal virtual SendMessagesResponse SendMessages(SendMessagesRequest request)
        {
            var marshaller = SendMessagesRequestMarshaller.Instance;
            var unmarshaller = SendMessagesResponseUnmarshaller.Instance;

            return Invoke<SendMessagesRequest,SendMessagesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<SendMessagesResponse> SendMessagesAsync(SendMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SendMessagesRequestMarshaller.Instance;
            var unmarshaller = SendMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<SendMessagesRequest,SendMessagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendUsersMessages

        internal virtual SendUsersMessagesResponse SendUsersMessages(SendUsersMessagesRequest request)
        {
            var marshaller = SendUsersMessagesRequestMarshaller.Instance;
            var unmarshaller = SendUsersMessagesResponseUnmarshaller.Instance;

            return Invoke<SendUsersMessagesRequest,SendUsersMessagesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendUsersMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendUsersMessages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<SendUsersMessagesResponse> SendUsersMessagesAsync(SendUsersMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SendUsersMessagesRequestMarshaller.Instance;
            var unmarshaller = SendUsersMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<SendUsersMessagesRequest,SendUsersMessagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAdmChannel

        internal virtual UpdateAdmChannelResponse UpdateAdmChannel(UpdateAdmChannelRequest request)
        {
            var marshaller = UpdateAdmChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateAdmChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateAdmChannelRequest,UpdateAdmChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAdmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateAdmChannelResponse> UpdateAdmChannelAsync(UpdateAdmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAdmChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateAdmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAdmChannelRequest,UpdateAdmChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApnsChannel

        internal virtual UpdateApnsChannelResponse UpdateApnsChannel(UpdateApnsChannelRequest request)
        {
            var marshaller = UpdateApnsChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsChannelRequest,UpdateApnsChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApnsChannelResponse> UpdateApnsChannelAsync(UpdateApnsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateApnsChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApnsChannelRequest,UpdateApnsChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApnsSandboxChannel

        internal virtual UpdateApnsSandboxChannelResponse UpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request)
        {
            var marshaller = UpdateApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsSandboxChannelRequest,UpdateApnsSandboxChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApnsSandboxChannelResponse> UpdateApnsSandboxChannelAsync(UpdateApnsSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApnsSandboxChannelRequest,UpdateApnsSandboxChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApnsVoipChannel

        internal virtual UpdateApnsVoipChannelResponse UpdateApnsVoipChannel(UpdateApnsVoipChannelRequest request)
        {
            var marshaller = UpdateApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsVoipChannelRequest,UpdateApnsVoipChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApnsVoipChannelResponse> UpdateApnsVoipChannelAsync(UpdateApnsVoipChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsVoipChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApnsVoipChannelRequest,UpdateApnsVoipChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApnsVoipSandboxChannel

        internal virtual UpdateApnsVoipSandboxChannelResponse UpdateApnsVoipSandboxChannel(UpdateApnsVoipSandboxChannelRequest request)
        {
            var marshaller = UpdateApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsVoipSandboxChannelRequest,UpdateApnsVoipSandboxChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipSandboxChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApnsVoipSandboxChannelResponse> UpdateApnsVoipSandboxChannelAsync(UpdateApnsVoipSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApnsVoipSandboxChannelRequest,UpdateApnsVoipSandboxChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplicationSettings

        internal virtual UpdateApplicationSettingsResponse UpdateApplicationSettings(UpdateApplicationSettingsRequest request)
        {
            var marshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationSettingsRequest,UpdateApplicationSettingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApplicationSettingsResponse> UpdateApplicationSettingsAsync(UpdateApplicationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationSettingsRequest,UpdateApplicationSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateBaiduChannel

        internal virtual UpdateBaiduChannelResponse UpdateBaiduChannel(UpdateBaiduChannelRequest request)
        {
            var marshaller = UpdateBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateBaiduChannelRequest,UpdateBaiduChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBaiduChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateBaiduChannelResponse> UpdateBaiduChannelAsync(UpdateBaiduChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateBaiduChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBaiduChannelRequest,UpdateBaiduChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCampaign

        internal virtual UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request)
        {
            var marshaller = UpdateCampaignRequestMarshaller.Instance;
            var unmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignRequest,UpdateCampaignResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateCampaignResponse> UpdateCampaignAsync(UpdateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateCampaignRequestMarshaller.Instance;
            var unmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCampaignRequest,UpdateCampaignResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateEmailChannel

        internal virtual UpdateEmailChannelResponse UpdateEmailChannel(UpdateEmailChannelRequest request)
        {
            var marshaller = UpdateEmailChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateEmailChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateEmailChannelRequest,UpdateEmailChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateEmailChannelResponse> UpdateEmailChannelAsync(UpdateEmailChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateEmailChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateEmailChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEmailChannelRequest,UpdateEmailChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpoint

        internal virtual UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request)
        {
            var marshaller = UpdateEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointRequest,UpdateEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointRequest,UpdateEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpointsBatch

        internal virtual UpdateEndpointsBatchResponse UpdateEndpointsBatch(UpdateEndpointsBatchRequest request)
        {
            var marshaller = UpdateEndpointsBatchRequestMarshaller.Instance;
            var unmarshaller = UpdateEndpointsBatchResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointsBatchRequest,UpdateEndpointsBatchResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateEndpointsBatchResponse> UpdateEndpointsBatchAsync(UpdateEndpointsBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateEndpointsBatchRequestMarshaller.Instance;
            var unmarshaller = UpdateEndpointsBatchResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointsBatchRequest,UpdateEndpointsBatchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGcmChannel

        internal virtual UpdateGcmChannelResponse UpdateGcmChannel(UpdateGcmChannelRequest request)
        {
            var marshaller = UpdateGcmChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateGcmChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateGcmChannelRequest,UpdateGcmChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateGcmChannelResponse> UpdateGcmChannelAsync(UpdateGcmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateGcmChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateGcmChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGcmChannelRequest,UpdateGcmChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSegment

        internal virtual UpdateSegmentResponse UpdateSegment(UpdateSegmentRequest request)
        {
            var marshaller = UpdateSegmentRequestMarshaller.Instance;
            var unmarshaller = UpdateSegmentResponseUnmarshaller.Instance;

            return Invoke<UpdateSegmentRequest,UpdateSegmentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateSegmentResponse> UpdateSegmentAsync(UpdateSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSegmentRequestMarshaller.Instance;
            var unmarshaller = UpdateSegmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSegmentRequest,UpdateSegmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSmsChannel

        internal virtual UpdateSmsChannelResponse UpdateSmsChannel(UpdateSmsChannelRequest request)
        {
            var marshaller = UpdateSmsChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateSmsChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateSmsChannelRequest,UpdateSmsChannelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateSmsChannelResponse> UpdateSmsChannelAsync(UpdateSmsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSmsChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateSmsChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSmsChannelRequest,UpdateSmsChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}