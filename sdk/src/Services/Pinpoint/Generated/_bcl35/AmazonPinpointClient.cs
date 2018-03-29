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
            var marshaller = CreateAppRequestMarshaller.Instance;
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppRequest,CreateAppResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateAppRequestMarshaller.Instance;
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAppRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = CreateCampaignRequestMarshaller.Instance;
            var unmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignRequest,CreateCampaignResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateCampaignRequestMarshaller.Instance;
            var unmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCampaignRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = CreateExportJobRequestMarshaller.Instance;
            var unmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateExportJobRequest,CreateExportJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateExportJobRequestMarshaller.Instance;
            var unmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return BeginInvoke<CreateExportJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = CreateImportJobRequestMarshaller.Instance;
            var unmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateImportJobRequest,CreateImportJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateImportJobRequestMarshaller.Instance;
            var unmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return BeginInvoke<CreateImportJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = CreateSegmentRequestMarshaller.Instance;
            var unmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return Invoke<CreateSegmentRequest,CreateSegmentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateSegmentRequestMarshaller.Instance;
            var unmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSegmentRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Delete an ADM channel
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
            var marshaller = DeleteAdmChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteAdmChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteAdmChannelRequest,DeleteAdmChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteAdmChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteAdmChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAdmChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteApnsChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsChannelRequest,DeleteApnsChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApnsChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApnsChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Delete an APNS sandbox channel
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
            var marshaller = DeleteApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsSandboxChannelRequest,DeleteApnsSandboxChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApnsSandboxChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsVoipChannelRequest,DeleteApnsVoipChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsVoipChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApnsVoipChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsVoipSandboxChannelRequest,DeleteApnsVoipSandboxChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApnsVoipSandboxChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteAppRequestMarshaller.Instance;
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppRequest,DeleteAppResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteAppRequestMarshaller.Instance;
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAppRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteBaiduChannelRequest,DeleteBaiduChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteBaiduChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBaiduChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteCampaignRequestMarshaller.Instance;
            var unmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignRequest,DeleteCampaignResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteCampaignRequestMarshaller.Instance;
            var unmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCampaignRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Delete an email channel
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
            var marshaller = DeleteEmailChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteEmailChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailChannelRequest,DeleteEmailChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteEmailChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteEmailChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteEmailChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointRequest,DeleteEndpointResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteEventStreamRequestMarshaller.Instance;
            var unmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteEventStreamRequest,DeleteEventStreamResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteEventStreamRequestMarshaller.Instance;
            var unmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteEventStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteGcmChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteGcmChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteGcmChannelRequest,DeleteGcmChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteGcmChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteGcmChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteGcmChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteSegmentRequestMarshaller.Instance;
            var unmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return Invoke<DeleteSegmentRequest,DeleteSegmentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteSegmentRequestMarshaller.Instance;
            var unmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSegmentRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Delete an SMS channel
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
            var marshaller = DeleteSmsChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteSmsChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteSmsChannelRequest,DeleteSmsChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteSmsChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteSmsChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSmsChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  GetAdmChannel

        /// <summary>
        /// Get an ADM channel
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
            var marshaller = GetAdmChannelRequestMarshaller.Instance;
            var unmarshaller = GetAdmChannelResponseUnmarshaller.Instance;

            return Invoke<GetAdmChannelRequest,GetAdmChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetAdmChannelRequestMarshaller.Instance;
            var unmarshaller = GetAdmChannelResponseUnmarshaller.Instance;

            return BeginInvoke<GetAdmChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetApnsChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsChannelRequest,GetApnsChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetApnsChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsChannelResponseUnmarshaller.Instance;

            return BeginInvoke<GetApnsChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Get an APNS sandbox channel
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
            var marshaller = GetApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsSandboxChannelRequest,GetApnsSandboxChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke<GetApnsSandboxChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsVoipChannelRequest,GetApnsVoipChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsVoipChannelResponseUnmarshaller.Instance;

            return BeginInvoke<GetApnsVoipChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsVoipSandboxChannelRequest,GetApnsVoipSandboxChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = GetApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke<GetApnsVoipSandboxChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetAppRequestMarshaller.Instance;
            var unmarshaller = GetAppResponseUnmarshaller.Instance;

            return Invoke<GetAppRequest,GetAppResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetAppRequestMarshaller.Instance;
            var unmarshaller = GetAppResponseUnmarshaller.Instance;

            return BeginInvoke<GetAppRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetApplicationSettingsRequestMarshaller.Instance;
            var unmarshaller = GetApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<GetApplicationSettingsRequest,GetApplicationSettingsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetApplicationSettingsRequestMarshaller.Instance;
            var unmarshaller = GetApplicationSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<GetApplicationSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetAppsRequestMarshaller.Instance;
            var unmarshaller = GetAppsResponseUnmarshaller.Instance;

            return Invoke<GetAppsRequest,GetAppsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetAppsRequestMarshaller.Instance;
            var unmarshaller = GetAppsResponseUnmarshaller.Instance;

            return BeginInvoke<GetAppsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = GetBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<GetBaiduChannelRequest,GetBaiduChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = GetBaiduChannelResponseUnmarshaller.Instance;

            return BeginInvoke<GetBaiduChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetCampaignRequestMarshaller.Instance;
            var unmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return Invoke<GetCampaignRequest,GetCampaignResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetCampaignRequestMarshaller.Instance;
            var unmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return BeginInvoke<GetCampaignRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetCampaignActivitiesRequestMarshaller.Instance;
            var unmarshaller = GetCampaignActivitiesResponseUnmarshaller.Instance;

            return Invoke<GetCampaignActivitiesRequest,GetCampaignActivitiesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetCampaignActivitiesRequestMarshaller.Instance;
            var unmarshaller = GetCampaignActivitiesResponseUnmarshaller.Instance;

            return BeginInvoke<GetCampaignActivitiesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetCampaignsRequestMarshaller.Instance;
            var unmarshaller = GetCampaignsResponseUnmarshaller.Instance;

            return Invoke<GetCampaignsRequest,GetCampaignsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetCampaignsRequestMarshaller.Instance;
            var unmarshaller = GetCampaignsResponseUnmarshaller.Instance;

            return BeginInvoke<GetCampaignsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetCampaignVersionRequestMarshaller.Instance;
            var unmarshaller = GetCampaignVersionResponseUnmarshaller.Instance;

            return Invoke<GetCampaignVersionRequest,GetCampaignVersionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetCampaignVersionRequestMarshaller.Instance;
            var unmarshaller = GetCampaignVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetCampaignVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetCampaignVersionsRequestMarshaller.Instance;
            var unmarshaller = GetCampaignVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCampaignVersionsRequest,GetCampaignVersionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetCampaignVersionsRequestMarshaller.Instance;
            var unmarshaller = GetCampaignVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetCampaignVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  GetEmailChannel

        /// <summary>
        /// Get an email channel
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
            var marshaller = GetEmailChannelRequestMarshaller.Instance;
            var unmarshaller = GetEmailChannelResponseUnmarshaller.Instance;

            return Invoke<GetEmailChannelRequest,GetEmailChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetEmailChannelRequestMarshaller.Instance;
            var unmarshaller = GetEmailChannelResponseUnmarshaller.Instance;

            return BeginInvoke<GetEmailChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetEndpointRequestMarshaller.Instance;
            var unmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return Invoke<GetEndpointRequest,GetEndpointResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetEndpointRequestMarshaller.Instance;
            var unmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<GetEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetEventStreamRequestMarshaller.Instance;
            var unmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return Invoke<GetEventStreamRequest,GetEventStreamResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetEventStreamRequestMarshaller.Instance;
            var unmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return BeginInvoke<GetEventStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetExportJobRequestMarshaller.Instance;
            var unmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return Invoke<GetExportJobRequest,GetExportJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetExportJobRequestMarshaller.Instance;
            var unmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return BeginInvoke<GetExportJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetExportJobsRequestMarshaller.Instance;
            var unmarshaller = GetExportJobsResponseUnmarshaller.Instance;

            return Invoke<GetExportJobsRequest,GetExportJobsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetExportJobsRequestMarshaller.Instance;
            var unmarshaller = GetExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke<GetExportJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetGcmChannelRequestMarshaller.Instance;
            var unmarshaller = GetGcmChannelResponseUnmarshaller.Instance;

            return Invoke<GetGcmChannelRequest,GetGcmChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetGcmChannelRequestMarshaller.Instance;
            var unmarshaller = GetGcmChannelResponseUnmarshaller.Instance;

            return BeginInvoke<GetGcmChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetImportJobRequestMarshaller.Instance;
            var unmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return Invoke<GetImportJobRequest,GetImportJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetImportJobRequestMarshaller.Instance;
            var unmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke<GetImportJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetImportJobsRequestMarshaller.Instance;
            var unmarshaller = GetImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetImportJobsRequest,GetImportJobsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetImportJobsRequestMarshaller.Instance;
            var unmarshaller = GetImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke<GetImportJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetSegmentRequestMarshaller.Instance;
            var unmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return Invoke<GetSegmentRequest,GetSegmentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSegmentRequestMarshaller.Instance;
            var unmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return BeginInvoke<GetSegmentRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetSegmentExportJobsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentExportJobsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentExportJobsRequest,GetSegmentExportJobsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSegmentExportJobsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke<GetSegmentExportJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetSegmentImportJobsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentImportJobsRequest,GetSegmentImportJobsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSegmentImportJobsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke<GetSegmentImportJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetSegmentsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentsRequest,GetSegmentsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSegmentsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentsResponseUnmarshaller.Instance;

            return BeginInvoke<GetSegmentsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetSegmentVersionRequestMarshaller.Instance;
            var unmarshaller = GetSegmentVersionResponseUnmarshaller.Instance;

            return Invoke<GetSegmentVersionRequest,GetSegmentVersionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSegmentVersionRequestMarshaller.Instance;
            var unmarshaller = GetSegmentVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetSegmentVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = GetSegmentVersionsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentVersionsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentVersionsRequest,GetSegmentVersionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSegmentVersionsRequestMarshaller.Instance;
            var unmarshaller = GetSegmentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetSegmentVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Get an SMS channel
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
            var marshaller = GetSmsChannelRequestMarshaller.Instance;
            var unmarshaller = GetSmsChannelResponseUnmarshaller.Instance;

            return Invoke<GetSmsChannelRequest,GetSmsChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSmsChannelRequestMarshaller.Instance;
            var unmarshaller = GetSmsChannelResponseUnmarshaller.Instance;

            return BeginInvoke<GetSmsChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = PutEventStreamRequestMarshaller.Instance;
            var unmarshaller = PutEventStreamResponseUnmarshaller.Instance;

            return Invoke<PutEventStreamRequest,PutEventStreamResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutEventStreamRequestMarshaller.Instance;
            var unmarshaller = PutEventStreamResponseUnmarshaller.Instance;

            return BeginInvoke<PutEventStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  SendMessages

        /// <summary>
        /// Send a batch of messages
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
            var marshaller = SendMessagesRequestMarshaller.Instance;
            var unmarshaller = SendMessagesResponseUnmarshaller.Instance;

            return Invoke<SendMessagesRequest,SendMessagesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = SendMessagesRequestMarshaller.Instance;
            var unmarshaller = SendMessagesResponseUnmarshaller.Instance;

            return BeginInvoke<SendMessagesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Send a batch of messages to users
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
            var marshaller = SendUsersMessagesRequestMarshaller.Instance;
            var unmarshaller = SendUsersMessagesResponseUnmarshaller.Instance;

            return Invoke<SendUsersMessagesRequest,SendUsersMessagesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = SendUsersMessagesRequestMarshaller.Instance;
            var unmarshaller = SendUsersMessagesResponseUnmarshaller.Instance;

            return BeginInvoke<SendUsersMessagesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  UpdateAdmChannel

        /// <summary>
        /// Update an ADM channel
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
            var marshaller = UpdateAdmChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateAdmChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateAdmChannelRequest,UpdateAdmChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateAdmChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateAdmChannelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAdmChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = UpdateApnsChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsChannelRequest,UpdateApnsChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateApnsChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsChannelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApnsChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Update an APNS sandbox channel
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
            var marshaller = UpdateApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsSandboxChannelRequest,UpdateApnsSandboxChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateApnsSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApnsSandboxChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = UpdateApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsVoipChannelRequest,UpdateApnsVoipChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateApnsVoipChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsVoipChannelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApnsVoipChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = UpdateApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsVoipSandboxChannelRequest,UpdateApnsVoipSandboxChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateApnsVoipSandboxChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApnsVoipSandboxChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationSettingsRequest,UpdateApplicationSettingsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApplicationSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = UpdateBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateBaiduChannelRequest,UpdateBaiduChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateBaiduChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateBaiduChannelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateBaiduChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = UpdateCampaignRequestMarshaller.Instance;
            var unmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignRequest,UpdateCampaignResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateCampaignRequestMarshaller.Instance;
            var unmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateCampaignRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Update an email channel
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
            var marshaller = UpdateEmailChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateEmailChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateEmailChannelRequest,UpdateEmailChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateEmailChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateEmailChannelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateEmailChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Use to update an endpoint.
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
            var marshaller = UpdateEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointRequest,UpdateEndpointResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = UpdateEndpointsBatchRequestMarshaller.Instance;
            var unmarshaller = UpdateEndpointsBatchResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointsBatchRequest,UpdateEndpointsBatchResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateEndpointsBatchRequestMarshaller.Instance;
            var unmarshaller = UpdateEndpointsBatchResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateEndpointsBatchRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = UpdateGcmChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateGcmChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateGcmChannelRequest,UpdateGcmChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateGcmChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateGcmChannelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateGcmChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Use to update a segment.
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
            var marshaller = UpdateSegmentRequestMarshaller.Instance;
            var unmarshaller = UpdateSegmentResponseUnmarshaller.Instance;

            return Invoke<UpdateSegmentRequest,UpdateSegmentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateSegmentRequestMarshaller.Instance;
            var unmarshaller = UpdateSegmentResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSegmentRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Update an SMS channel
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
            var marshaller = UpdateSmsChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateSmsChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateSmsChannelRequest,UpdateSmsChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateSmsChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateSmsChannelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSmsChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
    }
}