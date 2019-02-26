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
using System.Collections.Generic;
using System.Net;

using Amazon.Pinpoint.Model;
using Amazon.Pinpoint.Model.Internal.MarshallTransformations;
using Amazon.Pinpoint.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Pinpoint
{
    /// <summary>
    /// Implementation for accessing Pinpoint
    ///
    /// Amazon Pinpoint
    /// </summary>
    public partial class AmazonPinpointClient : AmazonServiceClient, IAmazonPinpoint
    {
        private static IServiceMetadata serviceMetadata = new AmazonPinpointMetadata();
        #region Constructors

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


        #region  CreateApp

        /// <summary>
        /// Creates or updates an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        public virtual IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from Pinpoint.</returns>
        public virtual CreateAppResponse EndCreateApp(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCampaign

        /// <summary>
        /// Creates or updates a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCampaign
        ///         operation.</returns>
        public virtual IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from Pinpoint.</returns>
        public virtual CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateExportJob

        /// <summary>
        /// Creates an export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob service method.</param>
        /// 
        /// <returns>The response from the CreateExportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual CreateExportJobResponse CreateExportJob(CreateExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExportJob
        ///         operation.</returns>
        public virtual IAsyncResult BeginCreateExportJob(CreateExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExportJob.</param>
        /// 
        /// <returns>Returns a  CreateExportJobResult from Pinpoint.</returns>
        public virtual CreateExportJobResponse EndCreateExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateImportJob

        /// <summary>
        /// Creates or updates an import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateImportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual CreateImportJobResponse CreateImportJob(CreateImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImportJob
        ///         operation.</returns>
        public virtual IAsyncResult BeginCreateImportJob(CreateImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImportJob.</param>
        /// 
        /// <returns>Returns a  CreateImportJobResult from Pinpoint.</returns>
        public virtual CreateImportJobResponse EndCreateImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSegment

        /// <summary>
        /// Used to create or update a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment service method.</param>
        /// 
        /// <returns>The response from the CreateSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual CreateSegmentResponse CreateSegment(CreateSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return Invoke<CreateSegmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSegment
        ///         operation.</returns>
        public virtual IAsyncResult BeginCreateSegment(CreateSegmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSegment.</param>
        /// 
        /// <returns>Returns a  CreateSegmentResult from Pinpoint.</returns>
        public virtual CreateSegmentResponse EndCreateSegment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSegmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAdmChannel

        /// <summary>
        /// Delete an ADM channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdmChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteAdmChannelResponse DeleteAdmChannel(DeleteAdmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdmChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteAdmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAdmChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteAdmChannel(DeleteAdmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAdmChannel.</param>
        /// 
        /// <returns>Returns a  DeleteAdmChannelResult from Pinpoint.</returns>
        public virtual DeleteAdmChannelResponse EndDeleteAdmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAdmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApnsChannel

        /// <summary>
        /// Deletes the APNs channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteApnsChannelResponse DeleteApnsChannel(DeleteApnsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteApnsChannel(DeleteApnsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsChannelResult from Pinpoint.</returns>
        public virtual DeleteApnsChannelResponse EndDeleteApnsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApnsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApnsSandboxChannel

        /// <summary>
        /// Delete an APNS sandbox channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteApnsSandboxChannelResponse DeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsSandboxChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsSandboxChannelResult from Pinpoint.</returns>
        public virtual DeleteApnsSandboxChannelResponse EndDeleteApnsSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApnsSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApnsVoipChannel

        /// <summary>
        /// Delete an APNS VoIP channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteApnsVoipChannelResponse DeleteApnsVoipChannel(DeleteApnsVoipChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsVoipChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsVoipChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteApnsVoipChannel(DeleteApnsVoipChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsVoipChannelResult from Pinpoint.</returns>
        public virtual DeleteApnsVoipChannelResponse EndDeleteApnsVoipChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApnsVoipChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApnsVoipSandboxChannel

        /// <summary>
        /// Delete an APNS VoIP sandbox channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteApnsVoipSandboxChannelResponse DeleteApnsVoipSandboxChannel(DeleteApnsVoipSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsVoipSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsVoipSandboxChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteApnsVoipSandboxChannel(DeleteApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsVoipSandboxChannelResult from Pinpoint.</returns>
        public virtual DeleteApnsVoipSandboxChannelResponse EndDeleteApnsVoipSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApnsVoipSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApp

        /// <summary>
        /// Deletes an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from Pinpoint.</returns>
        public virtual DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBaiduChannel

        /// <summary>
        /// Delete a BAIDU GCM channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBaiduChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteBaiduChannelResponse DeleteBaiduChannel(DeleteBaiduChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteBaiduChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBaiduChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBaiduChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteBaiduChannel(DeleteBaiduChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBaiduChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBaiduChannel.</param>
        /// 
        /// <returns>Returns a  DeleteBaiduChannelResult from Pinpoint.</returns>
        public virtual DeleteBaiduChannelResponse EndDeleteBaiduChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBaiduChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCampaign

        /// <summary>
        /// Deletes a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaign
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from Pinpoint.</returns>
        public virtual DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEmailChannel

        /// <summary>
        /// Delete an email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteEmailChannelResponse DeleteEmailChannel(DeleteEmailChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteEmailChannel(DeleteEmailChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailChannel.</param>
        /// 
        /// <returns>Returns a  DeleteEmailChannelResult from Pinpoint.</returns>
        public virtual DeleteEmailChannelResponse EndDeleteEmailChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEmailChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEndpoint

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from Pinpoint.</returns>
        public virtual DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventStream

        /// <summary>
        /// Deletes the event stream for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream service method.</param>
        /// 
        /// <returns>The response from the DeleteEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteEventStreamResponse DeleteEventStream(DeleteEventStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteEventStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventStream
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteEventStream(DeleteEventStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventStream.</param>
        /// 
        /// <returns>Returns a  DeleteEventStreamResult from Pinpoint.</returns>
        public virtual DeleteEventStreamResponse EndDeleteEventStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGcmChannel

        /// <summary>
        /// Deletes the GCM channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteGcmChannelResponse DeleteGcmChannel(DeleteGcmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGcmChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteGcmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGcmChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteGcmChannel(DeleteGcmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGcmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGcmChannel.</param>
        /// 
        /// <returns>Returns a  DeleteGcmChannelResult from Pinpoint.</returns>
        public virtual DeleteGcmChannelResponse EndDeleteGcmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGcmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSegment

        /// <summary>
        /// Deletes a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment service method.</param>
        /// 
        /// <returns>The response from the DeleteSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteSegmentResponse DeleteSegment(DeleteSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return Invoke<DeleteSegmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSegment
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteSegment(DeleteSegmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSegment.</param>
        /// 
        /// <returns>Returns a  DeleteSegmentResult from Pinpoint.</returns>
        public virtual DeleteSegmentResponse EndDeleteSegment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSegmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSmsChannel

        /// <summary>
        /// Delete an SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteSmsChannelResponse DeleteSmsChannel(DeleteSmsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSmsChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteSmsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSmsChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteSmsChannel(DeleteSmsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSmsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSmsChannel.</param>
        /// 
        /// <returns>Returns a  DeleteSmsChannelResult from Pinpoint.</returns>
        public virtual DeleteSmsChannelResponse EndDeleteSmsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSmsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserEndpoints

        /// <summary>
        /// Deletes endpoints that are associated with a User ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserEndpoints service method.</param>
        /// 
        /// <returns>The response from the DeleteUserEndpoints service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteUserEndpointsResponse DeleteUserEndpoints(DeleteUserEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserEndpointsResponseUnmarshaller.Instance;

            return Invoke<DeleteUserEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserEndpoints operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserEndpoints
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteUserEndpoints(DeleteUserEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserEndpoints.</param>
        /// 
        /// <returns>Returns a  DeleteUserEndpointsResult from Pinpoint.</returns>
        public virtual DeleteUserEndpointsResponse EndDeleteUserEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceChannel

        /// <summary>
        /// Delete an Voice channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual DeleteVoiceChannelResponse DeleteVoiceChannel(DeleteVoiceChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteVoiceChannel(DeleteVoiceChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceChannel.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceChannelResult from Pinpoint.</returns>
        public virtual DeleteVoiceChannelResponse EndDeleteVoiceChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAdmChannel

        /// <summary>
        /// Get an ADM channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdmChannel service method.</param>
        /// 
        /// <returns>The response from the GetAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetAdmChannelResponse GetAdmChannel(GetAdmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdmChannelResponseUnmarshaller.Instance;

            return Invoke<GetAdmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAdmChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetAdmChannel(GetAdmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAdmChannel.</param>
        /// 
        /// <returns>Returns a  GetAdmChannelResult from Pinpoint.</returns>
        public virtual GetAdmChannelResponse EndGetAdmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAdmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApnsChannel

        /// <summary>
        /// Returns information about the APNs channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetApnsChannelResponse GetApnsChannel(GetApnsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetApnsChannel(GetApnsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsChannelResult from Pinpoint.</returns>
        public virtual GetApnsChannelResponse EndGetApnsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApnsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApnsSandboxChannel

        /// <summary>
        /// Get an APNS sandbox channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetApnsSandboxChannelResponse GetApnsSandboxChannel(GetApnsSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsSandboxChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetApnsSandboxChannel(GetApnsSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsSandboxChannelResult from Pinpoint.</returns>
        public virtual GetApnsSandboxChannelResponse EndGetApnsSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApnsSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApnsVoipChannel

        /// <summary>
        /// Get an APNS VoIP channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetApnsVoipChannelResponse GetApnsVoipChannel(GetApnsVoipChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsVoipChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsVoipChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetApnsVoipChannel(GetApnsVoipChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsVoipChannelResult from Pinpoint.</returns>
        public virtual GetApnsVoipChannelResponse EndGetApnsVoipChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApnsVoipChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApnsVoipSandboxChannel

        /// <summary>
        /// Get an APNS VoIPSandbox channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetApnsVoipSandboxChannelResponse GetApnsVoipSandboxChannel(GetApnsVoipSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsVoipSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsVoipSandboxChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetApnsVoipSandboxChannel(GetApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsVoipSandboxChannelResult from Pinpoint.</returns>
        public virtual GetApnsVoipSandboxChannelResponse EndGetApnsVoipSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApnsVoipSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApp

        /// <summary>
        /// Returns information about an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetAppResponse GetApp(GetAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return Invoke<GetAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApp operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApp
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetApp(GetAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApp.</param>
        /// 
        /// <returns>Returns a  GetAppResult from Pinpoint.</returns>
        public virtual GetAppResponse EndGetApp(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationSettings

        /// <summary>
        /// Used to request the settings for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings service method.</param>
        /// 
        /// <returns>The response from the GetApplicationSettings service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetApplicationSettingsResponse GetApplicationSettings(GetApplicationSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<GetApplicationSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationSettings
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetApplicationSettings(GetApplicationSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationSettings.</param>
        /// 
        /// <returns>Returns a  GetApplicationSettingsResult from Pinpoint.</returns>
        public virtual GetApplicationSettingsResponse EndGetApplicationSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApps

        /// <summary>
        /// Returns information about your apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApps service method.</param>
        /// 
        /// <returns>The response from the GetApps service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetAppsResponse GetApps(GetAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppsResponseUnmarshaller.Instance;

            return Invoke<GetAppsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApps operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApps
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetApps(GetAppsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApps.</param>
        /// 
        /// <returns>Returns a  GetAppsResult from Pinpoint.</returns>
        public virtual GetAppsResponse EndGetApps(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBaiduChannel

        /// <summary>
        /// Get a BAIDU GCM channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBaiduChannel service method.</param>
        /// 
        /// <returns>The response from the GetBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetBaiduChannelResponse GetBaiduChannel(GetBaiduChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<GetBaiduChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBaiduChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBaiduChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetBaiduChannel(GetBaiduChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBaiduChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBaiduChannel.</param>
        /// 
        /// <returns>Returns a  GetBaiduChannelResult from Pinpoint.</returns>
        public virtual GetBaiduChannelResponse EndGetBaiduChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBaiduChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaign

        /// <summary>
        /// Returns information about a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// 
        /// <returns>The response from the GetCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetCampaignResponse GetCampaign(GetCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return Invoke<GetCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaign
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetCampaign(GetCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaign.</param>
        /// 
        /// <returns>Returns a  GetCampaignResult from Pinpoint.</returns>
        public virtual GetCampaignResponse EndGetCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaignActivities

        /// <summary>
        /// Returns information about the activity performed by a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities service method.</param>
        /// 
        /// <returns>The response from the GetCampaignActivities service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetCampaignActivitiesResponse GetCampaignActivities(GetCampaignActivitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignActivitiesResponseUnmarshaller.Instance;

            return Invoke<GetCampaignActivitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignActivities
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetCampaignActivities(GetCampaignActivitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignActivitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignActivities.</param>
        /// 
        /// <returns>Returns a  GetCampaignActivitiesResult from Pinpoint.</returns>
        public virtual GetCampaignActivitiesResponse EndGetCampaignActivities(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignActivitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaigns

        /// <summary>
        /// Returns information about your campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns service method.</param>
        /// 
        /// <returns>The response from the GetCampaigns service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetCampaignsResponse GetCampaigns(GetCampaignsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignsResponseUnmarshaller.Instance;

            return Invoke<GetCampaignsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaigns
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetCampaigns(GetCampaignsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaigns.</param>
        /// 
        /// <returns>Returns a  GetCampaignsResult from Pinpoint.</returns>
        public virtual GetCampaignsResponse EndGetCampaigns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaignVersion

        /// <summary>
        /// Returns information about a specific version of a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion service method.</param>
        /// 
        /// <returns>The response from the GetCampaignVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetCampaignVersionResponse GetCampaignVersion(GetCampaignVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionResponseUnmarshaller.Instance;

            return Invoke<GetCampaignVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignVersion
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetCampaignVersion(GetCampaignVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignVersion.</param>
        /// 
        /// <returns>Returns a  GetCampaignVersionResult from Pinpoint.</returns>
        public virtual GetCampaignVersionResponse EndGetCampaignVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaignVersions

        /// <summary>
        /// Returns information about your campaign versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions service method.</param>
        /// 
        /// <returns>The response from the GetCampaignVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetCampaignVersionsResponse GetCampaignVersions(GetCampaignVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCampaignVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignVersions
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetCampaignVersions(GetCampaignVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignVersions.</param>
        /// 
        /// <returns>Returns a  GetCampaignVersionsResult from Pinpoint.</returns>
        public virtual GetCampaignVersionsResponse EndGetCampaignVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannels

        /// <summary>
        /// Get all channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannels service method.</param>
        /// 
        /// <returns>The response from the GetChannels service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetChannelsResponse GetChannels(GetChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelsResponseUnmarshaller.Instance;

            return Invoke<GetChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannels operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannels
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetChannels(GetChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannels.</param>
        /// 
        /// <returns>Returns a  GetChannelsResult from Pinpoint.</returns>
        public virtual GetChannelsResponse EndGetChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEmailChannel

        /// <summary>
        /// Get an email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel service method.</param>
        /// 
        /// <returns>The response from the GetEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetEmailChannelResponse GetEmailChannel(GetEmailChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailChannelResponseUnmarshaller.Instance;

            return Invoke<GetEmailChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEmailChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetEmailChannel(GetEmailChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailChannel.</param>
        /// 
        /// <returns>Returns a  GetEmailChannelResult from Pinpoint.</returns>
        public virtual GetEmailChannelResponse EndGetEmailChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEmailChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEndpoint

        /// <summary>
        /// Returns information about an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetEndpointResponse GetEndpoint(GetEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return Invoke<GetEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEndpoint
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetEndpoint(GetEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpoint.</param>
        /// 
        /// <returns>Returns a  GetEndpointResult from Pinpoint.</returns>
        public virtual GetEndpointResponse EndGetEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventStream

        /// <summary>
        /// Returns the event stream for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream service method.</param>
        /// 
        /// <returns>The response from the GetEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetEventStreamResponse GetEventStream(GetEventStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return Invoke<GetEventStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventStream
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetEventStream(GetEventStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventStream.</param>
        /// 
        /// <returns>Returns a  GetEventStreamResult from Pinpoint.</returns>
        public virtual GetEventStreamResponse EndGetEventStream(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExportJob

        /// <summary>
        /// Returns information about an export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob service method.</param>
        /// 
        /// <returns>The response from the GetExportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetExportJobResponse GetExportJob(GetExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return Invoke<GetExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExportJob
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetExportJob(GetExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportJob.</param>
        /// 
        /// <returns>Returns a  GetExportJobResult from Pinpoint.</returns>
        public virtual GetExportJobResponse EndGetExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExportJobs

        /// <summary>
        /// Returns information about your export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportJobs service method.</param>
        /// 
        /// <returns>The response from the GetExportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetExportJobsResponse GetExportJobs(GetExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobsResponseUnmarshaller.Instance;

            return Invoke<GetExportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExportJobs
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetExportJobs(GetExportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportJobs.</param>
        /// 
        /// <returns>Returns a  GetExportJobsResult from Pinpoint.</returns>
        public virtual GetExportJobsResponse EndGetExportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGcmChannel

        /// <summary>
        /// Returns information about the GCM channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel service method.</param>
        /// 
        /// <returns>The response from the GetGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetGcmChannelResponse GetGcmChannel(GetGcmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGcmChannelResponseUnmarshaller.Instance;

            return Invoke<GetGcmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGcmChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetGcmChannel(GetGcmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGcmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGcmChannel.</param>
        /// 
        /// <returns>Returns a  GetGcmChannelResult from Pinpoint.</returns>
        public virtual GetGcmChannelResponse EndGetGcmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGcmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImportJob

        /// <summary>
        /// Returns information about an import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// 
        /// <returns>The response from the GetImportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetImportJobResponse GetImportJob(GetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return Invoke<GetImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJob
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetImportJob(GetImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJob.</param>
        /// 
        /// <returns>Returns a  GetImportJobResult from Pinpoint.</returns>
        public virtual GetImportJobResponse EndGetImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImportJobs

        /// <summary>
        /// Returns information about your import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs service method.</param>
        /// 
        /// <returns>The response from the GetImportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetImportJobsResponse GetImportJobs(GetImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJobs
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetImportJobs(GetImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJobs.</param>
        /// 
        /// <returns>Returns a  GetImportJobsResult from Pinpoint.</returns>
        public virtual GetImportJobsResponse EndGetImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegment

        /// <summary>
        /// Returns information about a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegment service method.</param>
        /// 
        /// <returns>The response from the GetSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetSegmentResponse GetSegment(GetSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return Invoke<GetSegmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegment
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetSegment(GetSegmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegment.</param>
        /// 
        /// <returns>Returns a  GetSegmentResult from Pinpoint.</returns>
        public virtual GetSegmentResponse EndGetSegment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegmentExportJobs

        /// <summary>
        /// Returns a list of export jobs for a specific segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentExportJobs service method.</param>
        /// 
        /// <returns>The response from the GetSegmentExportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetSegmentExportJobsResponse GetSegmentExportJobs(GetSegmentExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentExportJobsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentExportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentExportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentExportJobs
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetSegmentExportJobs(GetSegmentExportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentExportJobs.</param>
        /// 
        /// <returns>Returns a  GetSegmentExportJobsResult from Pinpoint.</returns>
        public virtual GetSegmentExportJobsResponse EndGetSegmentExportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentExportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegmentImportJobs

        /// <summary>
        /// Returns a list of import jobs for a specific segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs service method.</param>
        /// 
        /// <returns>The response from the GetSegmentImportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetSegmentImportJobsResponse GetSegmentImportJobs(GetSegmentImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentImportJobs
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetSegmentImportJobs(GetSegmentImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentImportJobs.</param>
        /// 
        /// <returns>Returns a  GetSegmentImportJobsResult from Pinpoint.</returns>
        public virtual GetSegmentImportJobsResponse EndGetSegmentImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegments

        /// <summary>
        /// Used to get information about your segments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegments service method.</param>
        /// 
        /// <returns>The response from the GetSegments service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetSegmentsResponse GetSegments(GetSegmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegments operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegments
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetSegments(GetSegmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegments.</param>
        /// 
        /// <returns>Returns a  GetSegmentsResult from Pinpoint.</returns>
        public virtual GetSegmentsResponse EndGetSegments(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegmentVersion

        /// <summary>
        /// Returns information about a segment version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion service method.</param>
        /// 
        /// <returns>The response from the GetSegmentVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetSegmentVersionResponse GetSegmentVersion(GetSegmentVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionResponseUnmarshaller.Instance;

            return Invoke<GetSegmentVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentVersion
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetSegmentVersion(GetSegmentVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentVersion.</param>
        /// 
        /// <returns>Returns a  GetSegmentVersionResult from Pinpoint.</returns>
        public virtual GetSegmentVersionResponse EndGetSegmentVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegmentVersions

        /// <summary>
        /// Returns information about your segment versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions service method.</param>
        /// 
        /// <returns>The response from the GetSegmentVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetSegmentVersionsResponse GetSegmentVersions(GetSegmentVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentVersions
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetSegmentVersions(GetSegmentVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentVersions.</param>
        /// 
        /// <returns>Returns a  GetSegmentVersionsResult from Pinpoint.</returns>
        public virtual GetSegmentVersionsResponse EndGetSegmentVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSmsChannel

        /// <summary>
        /// Get an SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel service method.</param>
        /// 
        /// <returns>The response from the GetSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetSmsChannelResponse GetSmsChannel(GetSmsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSmsChannelResponseUnmarshaller.Instance;

            return Invoke<GetSmsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSmsChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetSmsChannel(GetSmsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSmsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSmsChannel.</param>
        /// 
        /// <returns>Returns a  GetSmsChannelResult from Pinpoint.</returns>
        public virtual GetSmsChannelResponse EndGetSmsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSmsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserEndpoints

        /// <summary>
        /// Returns information about the endpoints that are associated with a User ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserEndpoints service method.</param>
        /// 
        /// <returns>The response from the GetUserEndpoints service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetUserEndpointsResponse GetUserEndpoints(GetUserEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserEndpointsResponseUnmarshaller.Instance;

            return Invoke<GetUserEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserEndpoints operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserEndpoints
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetUserEndpoints(GetUserEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserEndpoints.</param>
        /// 
        /// <returns>Returns a  GetUserEndpointsResult from Pinpoint.</returns>
        public virtual GetUserEndpointsResponse EndGetUserEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceChannel

        /// <summary>
        /// Get a Voice Channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceChannel service method.</param>
        /// 
        /// <returns>The response from the GetVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual GetVoiceChannelResponse GetVoiceChannel(GetVoiceChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceChannelResponseUnmarshaller.Instance;

            return Invoke<GetVoiceChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetVoiceChannel(GetVoiceChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceChannel.</param>
        /// 
        /// <returns>Returns a  GetVoiceChannelResult from Pinpoint.</returns>
        public virtual GetVoiceChannelResponse EndGetVoiceChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Pinpoint.</returns>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Pinpoint.</returns>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PhoneNumberValidate

        /// <summary>
        /// Returns information about the specified phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PhoneNumberValidate service method.</param>
        /// 
        /// <returns>The response from the PhoneNumberValidate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual PhoneNumberValidateResponse PhoneNumberValidate(PhoneNumberValidateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PhoneNumberValidateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PhoneNumberValidateResponseUnmarshaller.Instance;

            return Invoke<PhoneNumberValidateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PhoneNumberValidate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PhoneNumberValidate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPhoneNumberValidate
        ///         operation.</returns>
        public virtual IAsyncResult BeginPhoneNumberValidate(PhoneNumberValidateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PhoneNumberValidateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PhoneNumberValidateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PhoneNumberValidate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPhoneNumberValidate.</param>
        /// 
        /// <returns>Returns a  PhoneNumberValidateResult from Pinpoint.</returns>
        public virtual PhoneNumberValidateResponse EndPhoneNumberValidate(IAsyncResult asyncResult)
        {
            return EndInvoke<PhoneNumberValidateResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEvents

        /// <summary>
        /// Use to record events for endpoints. This method creates events and creates or updates
        /// the endpoints that those events are associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvents operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEvents
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvents.</param>
        /// 
        /// <returns>Returns a  PutEventsResult from Pinpoint.</returns>
        public virtual PutEventsResponse EndPutEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEventStream

        /// <summary>
        /// Use to create or update the event stream for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream service method.</param>
        /// 
        /// <returns>The response from the PutEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual PutEventStreamResponse PutEventStream(PutEventStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventStreamResponseUnmarshaller.Instance;

            return Invoke<PutEventStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEventStream
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutEventStream(PutEventStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEventStream.</param>
        /// 
        /// <returns>Returns a  PutEventStreamResult from Pinpoint.</returns>
        public virtual PutEventStreamResponse EndPutEventStream(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEventStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveAttributes

        /// <summary>
        /// Used to remove the attributes for an app
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributes service method.</param>
        /// 
        /// <returns>The response from the RemoveAttributes service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual RemoveAttributesResponse RemoveAttributes(RemoveAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesResponseUnmarshaller.Instance;

            return Invoke<RemoveAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributes operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAttributes
        ///         operation.</returns>
        public virtual IAsyncResult BeginRemoveAttributes(RemoveAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAttributes.</param>
        /// 
        /// <returns>Returns a  RemoveAttributesResult from Pinpoint.</returns>
        public virtual RemoveAttributesResponse EndRemoveAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  SendMessages

        /// <summary>
        /// Used to send a direct message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessages service method.</param>
        /// 
        /// <returns>The response from the SendMessages service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual SendMessagesResponse SendMessages(SendMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessagesResponseUnmarshaller.Instance;

            return Invoke<SendMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessages operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendMessages
        ///         operation.</returns>
        public virtual IAsyncResult BeginSendMessages(SendMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessages.</param>
        /// 
        /// <returns>Returns a  SendMessagesResult from Pinpoint.</returns>
        public virtual SendMessagesResponse EndSendMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<SendMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  SendUsersMessages

        /// <summary>
        /// Used to send a message to a list of users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendUsersMessages service method.</param>
        /// 
        /// <returns>The response from the SendUsersMessages service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual SendUsersMessagesResponse SendUsersMessages(SendUsersMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendUsersMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendUsersMessagesResponseUnmarshaller.Instance;

            return Invoke<SendUsersMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendUsersMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendUsersMessages operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendUsersMessages
        ///         operation.</returns>
        public virtual IAsyncResult BeginSendUsersMessages(SendUsersMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendUsersMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendUsersMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendUsersMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendUsersMessages.</param>
        /// 
        /// <returns>Returns a  SendUsersMessagesResult from Pinpoint.</returns>
        public virtual SendUsersMessagesResponse EndSendUsersMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<SendUsersMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Pinpoint.</returns>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Pinpoint.</returns>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Pinpoint.</returns>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Pinpoint.</returns>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAdmChannel

        /// <summary>
        /// Update an ADM channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAdmChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateAdmChannelResponse UpdateAdmChannel(UpdateAdmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAdmChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateAdmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAdmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAdmChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateAdmChannel(UpdateAdmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAdmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAdmChannel.</param>
        /// 
        /// <returns>Returns a  UpdateAdmChannelResult from Pinpoint.</returns>
        public virtual UpdateAdmChannelResponse EndUpdateAdmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAdmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApnsChannel

        /// <summary>
        /// Use to update the APNs channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateApnsChannelResponse UpdateApnsChannel(UpdateApnsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateApnsChannel(UpdateApnsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsChannelResult from Pinpoint.</returns>
        public virtual UpdateApnsChannelResponse EndUpdateApnsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApnsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApnsSandboxChannel

        /// <summary>
        /// Update an APNS sandbox channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateApnsSandboxChannelResponse UpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsSandboxChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsSandboxChannelResult from Pinpoint.</returns>
        public virtual UpdateApnsSandboxChannelResponse EndUpdateApnsSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApnsSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApnsVoipChannel

        /// <summary>
        /// Update an APNS VoIP channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateApnsVoipChannelResponse UpdateApnsVoipChannel(UpdateApnsVoipChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsVoipChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsVoipChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateApnsVoipChannel(UpdateApnsVoipChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsVoipChannelResult from Pinpoint.</returns>
        public virtual UpdateApnsVoipChannelResponse EndUpdateApnsVoipChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApnsVoipChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApnsVoipSandboxChannel

        /// <summary>
        /// Update an APNS VoIP sandbox channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateApnsVoipSandboxChannelResponse UpdateApnsVoipSandboxChannel(UpdateApnsVoipSandboxChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsVoipSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsVoipSandboxChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateApnsVoipSandboxChannel(UpdateApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsVoipSandboxChannelResult from Pinpoint.</returns>
        public virtual UpdateApnsVoipSandboxChannelResponse EndUpdateApnsVoipSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApnsVoipSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplicationSettings

        /// <summary>
        /// Used to update the settings for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationSettings service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateApplicationSettingsResponse UpdateApplicationSettings(UpdateApplicationSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationSettings
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateApplicationSettings(UpdateApplicationSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationSettings.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationSettingsResult from Pinpoint.</returns>
        public virtual UpdateApplicationSettingsResponse EndUpdateApplicationSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBaiduChannel

        /// <summary>
        /// Update a BAIDU GCM channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBaiduChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateBaiduChannelResponse UpdateBaiduChannel(UpdateBaiduChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateBaiduChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBaiduChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBaiduChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateBaiduChannel(UpdateBaiduChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBaiduChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBaiduChannel.</param>
        /// 
        /// <returns>Returns a  UpdateBaiduChannelResult from Pinpoint.</returns>
        public virtual UpdateBaiduChannelResponse EndUpdateBaiduChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBaiduChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaign

        /// <summary>
        /// Use to update a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaign
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateCampaign(UpdateCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaign.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignResult from Pinpoint.</returns>
        public virtual UpdateCampaignResponse EndUpdateCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEmailChannel

        /// <summary>
        /// Update an email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateEmailChannelResponse UpdateEmailChannel(UpdateEmailChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateEmailChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEmailChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateEmailChannel(UpdateEmailChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmailChannel.</param>
        /// 
        /// <returns>Returns a  UpdateEmailChannelResult from Pinpoint.</returns>
        public virtual UpdateEmailChannelResponse EndUpdateEmailChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEmailChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEndpoint

        /// <summary>
        /// Creates or updates an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpoint
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from Pinpoint.</returns>
        public virtual UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEndpointsBatch

        /// <summary>
        /// Use to update a batch of endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointsBatch service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateEndpointsBatchResponse UpdateEndpointsBatch(UpdateEndpointsBatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointsBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointsBatchResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointsBatchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointsBatch
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateEndpointsBatch(UpdateEndpointsBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointsBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointsBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointsBatch.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointsBatchResult from Pinpoint.</returns>
        public virtual UpdateEndpointsBatchResponse EndUpdateEndpointsBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEndpointsBatchResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGcmChannel

        /// <summary>
        /// Use to update the GCM channel for an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateGcmChannelResponse UpdateGcmChannel(UpdateGcmChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGcmChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateGcmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGcmChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateGcmChannel(UpdateGcmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGcmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGcmChannel.</param>
        /// 
        /// <returns>Returns a  UpdateGcmChannelResult from Pinpoint.</returns>
        public virtual UpdateGcmChannelResponse EndUpdateGcmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGcmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSegment

        /// <summary>
        /// Used to update a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment service method.</param>
        /// 
        /// <returns>The response from the UpdateSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateSegmentResponse UpdateSegment(UpdateSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSegmentResponseUnmarshaller.Instance;

            return Invoke<UpdateSegmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSegment
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateSegment(UpdateSegmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSegmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSegment.</param>
        /// 
        /// <returns>Returns a  UpdateSegmentResult from Pinpoint.</returns>
        public virtual UpdateSegmentResponse EndUpdateSegment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSegmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSmsChannel

        /// <summary>
        /// Update an SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateSmsChannelResponse UpdateSmsChannel(UpdateSmsChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSmsChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateSmsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSmsChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateSmsChannel(UpdateSmsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSmsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSmsChannel.</param>
        /// 
        /// <returns>Returns a  UpdateSmsChannelResult from Pinpoint.</returns>
        public virtual UpdateSmsChannelResponse EndUpdateSmsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSmsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVoiceChannel

        /// <summary>
        /// Update an Voice channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Simple message object.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Simple message object.
        /// </exception>
        public virtual UpdateVoiceChannelResponse UpdateVoiceChannel(UpdateVoiceChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceChannel
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateVoiceChannel(UpdateVoiceChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceChannel.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceChannelResult from Pinpoint.</returns>
        public virtual UpdateVoiceChannelResponse EndUpdateVoiceChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVoiceChannelResponse>(asyncResult);
        }

        #endregion
        
    }
}