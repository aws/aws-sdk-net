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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.LocationService.Model;
using Amazon.LocationService.Model.Internal.MarshallTransformations;
using Amazon.LocationService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.LocationService
{
    /// <summary>
    /// Implementation for accessing LocationService
    ///
    /// "Suite of geospatial services including Maps, Places, Routes, Tracking, and Geofencing"
    /// </summary>
    public partial class AmazonLocationServiceClient : AmazonServiceClient, IAmazonLocationService
    {
        private static IServiceMetadata serviceMetadata = new AmazonLocationServiceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ILocationServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILocationServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LocationServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonLocationServiceClient with the credentials loaded from the application's
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
        public AmazonLocationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLocationServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with the credentials loaded from the application's
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
        public AmazonLocationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLocationServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLocationServiceClient Configuration Object</param>
        public AmazonLocationServiceClient(AmazonLocationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLocationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonLocationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLocationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLocationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with AWS Credentials and an
        /// AmazonLocationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLocationServiceClient Configuration Object</param>
        public AmazonLocationServiceClient(AWSCredentials credentials, AmazonLocationServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLocationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLocationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLocationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLocationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLocationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLocationServiceClient Configuration Object</param>
        public AmazonLocationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLocationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLocationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLocationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLocationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLocationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLocationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLocationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLocationServiceClient Configuration Object</param>
        public AmazonLocationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLocationServiceConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLocationServiceEndpointResolver());
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


        #region  AssociateTrackerConsumer

        /// <summary>
        /// Creates an association between a geofence collection and a tracker resource. This
        /// allows the tracker resource to communicate location data to the linked geofence collection.
        /// 
        /// 
        ///  
        /// <para>
        /// You can associate up to five geofence collections to each tracker resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently not supported — Cross-account configurations, such as creating associations
        /// between a tracker resource in one account and a geofence collection in another account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrackerConsumer service method.</param>
        /// 
        /// <returns>The response from the AssociateTrackerConsumer service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/AssociateTrackerConsumer">REST API Reference for AssociateTrackerConsumer Operation</seealso>
        public virtual AssociateTrackerConsumerResponse AssociateTrackerConsumer(AssociateTrackerConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTrackerConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrackerConsumerResponseUnmarshaller.Instance;

            return Invoke<AssociateTrackerConsumerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTrackerConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrackerConsumer operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTrackerConsumer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/AssociateTrackerConsumer">REST API Reference for AssociateTrackerConsumer Operation</seealso>
        public virtual IAsyncResult BeginAssociateTrackerConsumer(AssociateTrackerConsumerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTrackerConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrackerConsumerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTrackerConsumer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTrackerConsumer.</param>
        /// 
        /// <returns>Returns a  AssociateTrackerConsumerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/AssociateTrackerConsumer">REST API Reference for AssociateTrackerConsumer Operation</seealso>
        public virtual AssociateTrackerConsumerResponse EndAssociateTrackerConsumer(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateTrackerConsumerResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteDevicePositionHistory

        /// <summary>
        /// Deletes the position history of one or more devices from a tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDevicePositionHistory service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteDevicePositionHistory service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteDevicePositionHistory">REST API Reference for BatchDeleteDevicePositionHistory Operation</seealso>
        public virtual BatchDeleteDevicePositionHistoryResponse BatchDeleteDevicePositionHistory(BatchDeleteDevicePositionHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDevicePositionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDevicePositionHistoryResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteDevicePositionHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteDevicePositionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDevicePositionHistory operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteDevicePositionHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteDevicePositionHistory">REST API Reference for BatchDeleteDevicePositionHistory Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteDevicePositionHistory(BatchDeleteDevicePositionHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDevicePositionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDevicePositionHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteDevicePositionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteDevicePositionHistory.</param>
        /// 
        /// <returns>Returns a  BatchDeleteDevicePositionHistoryResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteDevicePositionHistory">REST API Reference for BatchDeleteDevicePositionHistory Operation</seealso>
        public virtual BatchDeleteDevicePositionHistoryResponse EndBatchDeleteDevicePositionHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteDevicePositionHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteGeofence

        /// <summary>
        /// Deletes a batch of geofences from a geofence collection.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteGeofence service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteGeofence">REST API Reference for BatchDeleteGeofence Operation</seealso>
        public virtual BatchDeleteGeofenceResponse BatchDeleteGeofence(BatchDeleteGeofenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteGeofenceResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteGeofenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteGeofence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteGeofence operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteGeofence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteGeofence">REST API Reference for BatchDeleteGeofence Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteGeofence(BatchDeleteGeofenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteGeofenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteGeofence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteGeofence.</param>
        /// 
        /// <returns>Returns a  BatchDeleteGeofenceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteGeofence">REST API Reference for BatchDeleteGeofence Operation</seealso>
        public virtual BatchDeleteGeofenceResponse EndBatchDeleteGeofence(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteGeofenceResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchEvaluateGeofences

        /// <summary>
        /// Evaluates device positions against the geofence geometries from a given geofence collection.
        /// 
        ///  
        /// <para>
        /// This operation always returns an empty response because geofences are asynchronously
        /// evaluated. The evaluation determines if the device has entered or exited a geofenced
        /// area, and then publishes one of the following events to Amazon EventBridge:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENTER</code> if Amazon Location determines that the tracked device has entered
        /// a geofenced area.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EXIT</code> if Amazon Location determines that the tracked device has exited
        /// a geofenced area.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The last geofence that a device was observed within is tracked for 30 days after the
        /// most recent device position update.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Geofence evaluation uses the given device position. It does not account for the optional
        /// <code>Accuracy</code> of a <code>DevicePositionUpdate</code>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// The <code>DeviceID</code> is used as a string to represent the device. You do not
        /// need to have a <code>Tracker</code> associated with the <code>DeviceID</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateGeofences service method.</param>
        /// 
        /// <returns>The response from the BatchEvaluateGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchEvaluateGeofences">REST API Reference for BatchEvaluateGeofences Operation</seealso>
        public virtual BatchEvaluateGeofencesResponse BatchEvaluateGeofences(BatchEvaluateGeofencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchEvaluateGeofencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEvaluateGeofencesResponseUnmarshaller.Instance;

            return Invoke<BatchEvaluateGeofencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchEvaluateGeofences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateGeofences operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchEvaluateGeofences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchEvaluateGeofences">REST API Reference for BatchEvaluateGeofences Operation</seealso>
        public virtual IAsyncResult BeginBatchEvaluateGeofences(BatchEvaluateGeofencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchEvaluateGeofencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEvaluateGeofencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchEvaluateGeofences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchEvaluateGeofences.</param>
        /// 
        /// <returns>Returns a  BatchEvaluateGeofencesResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchEvaluateGeofences">REST API Reference for BatchEvaluateGeofences Operation</seealso>
        public virtual BatchEvaluateGeofencesResponse EndBatchEvaluateGeofences(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchEvaluateGeofencesResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetDevicePosition

        /// <summary>
        /// Lists the latest device positions for requested devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevicePosition service method.</param>
        /// 
        /// <returns>The response from the BatchGetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchGetDevicePosition">REST API Reference for BatchGetDevicePosition Operation</seealso>
        public virtual BatchGetDevicePositionResponse BatchGetDevicePosition(BatchGetDevicePositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDevicePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDevicePositionResponseUnmarshaller.Instance;

            return Invoke<BatchGetDevicePositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevicePosition operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetDevicePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchGetDevicePosition">REST API Reference for BatchGetDevicePosition Operation</seealso>
        public virtual IAsyncResult BeginBatchGetDevicePosition(BatchGetDevicePositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDevicePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDevicePositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetDevicePosition.</param>
        /// 
        /// <returns>Returns a  BatchGetDevicePositionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchGetDevicePosition">REST API Reference for BatchGetDevicePosition Operation</seealso>
        public virtual BatchGetDevicePositionResponse EndBatchGetDevicePosition(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetDevicePositionResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchPutGeofence

        /// <summary>
        /// A batch request for storing geofence geometries into a given geofence collection,
        /// or updates the geometry of an existing geofence if a geofence ID is included in the
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutGeofence service method.</param>
        /// 
        /// <returns>The response from the BatchPutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchPutGeofence">REST API Reference for BatchPutGeofence Operation</seealso>
        public virtual BatchPutGeofenceResponse BatchPutGeofence(BatchPutGeofenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutGeofenceResponseUnmarshaller.Instance;

            return Invoke<BatchPutGeofenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutGeofence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutGeofence operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutGeofence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchPutGeofence">REST API Reference for BatchPutGeofence Operation</seealso>
        public virtual IAsyncResult BeginBatchPutGeofence(BatchPutGeofenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutGeofenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutGeofence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutGeofence.</param>
        /// 
        /// <returns>Returns a  BatchPutGeofenceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchPutGeofence">REST API Reference for BatchPutGeofence Operation</seealso>
        public virtual BatchPutGeofenceResponse EndBatchPutGeofence(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchPutGeofenceResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateDevicePosition

        /// <summary>
        /// Uploads position update data for one or more devices to a tracker resource. Amazon
        /// Location uses the data when it reports the last known device position and position
        /// history. Amazon Location retains location data for 30 days.
        /// 
        ///  <note> 
        /// <para>
        /// Position updates are handled based on the <code>PositionFiltering</code> property
        /// of the tracker. When <code>PositionFiltering</code> is set to <code>TimeBased</code>,
        /// updates are evaluated against linked geofence collections, and location data is stored
        /// at a maximum of one position per 30 second interval. If your update frequency is more
        /// often than every 30 seconds, only one update per 30 seconds is stored for each unique
        /// device ID.
        /// </para>
        ///  
        /// <para>
        /// When <code>PositionFiltering</code> is set to <code>DistanceBased</code> filtering,
        /// location data is stored and evaluated against linked geofence collections only if
        /// the device has moved more than 30 m (98.4 ft).
        /// </para>
        ///  
        /// <para>
        /// When <code>PositionFiltering</code> is set to <code>AccuracyBased</code> filtering,
        /// location data is stored and evaluated against linked geofence collections only if
        /// the device has moved more than the measured accuracy. For example, if two consecutive
        /// updates from a device have a horizontal accuracy of 5 m and 10 m, the second update
        /// is neither stored or evaluated if the device has moved less than 15 m. If <code>PositionFiltering</code>
        /// is set to <code>AccuracyBased</code> filtering, Amazon Location uses the default value
        /// <code>{ "Horizontal": 0}</code> when accuracy is not provided on a <code>DevicePositionUpdate</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDevicePosition service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchUpdateDevicePosition">REST API Reference for BatchUpdateDevicePosition Operation</seealso>
        public virtual BatchUpdateDevicePositionResponse BatchUpdateDevicePosition(BatchUpdateDevicePositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateDevicePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateDevicePositionResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateDevicePositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDevicePosition operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateDevicePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchUpdateDevicePosition">REST API Reference for BatchUpdateDevicePosition Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateDevicePosition(BatchUpdateDevicePositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateDevicePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateDevicePositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateDevicePosition.</param>
        /// 
        /// <returns>Returns a  BatchUpdateDevicePositionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchUpdateDevicePosition">REST API Reference for BatchUpdateDevicePosition Operation</seealso>
        public virtual BatchUpdateDevicePositionResponse EndBatchUpdateDevicePosition(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateDevicePositionResponse>(asyncResult);
        }

        #endregion
        
        #region  CalculateRoute

        /// <summary>
        /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route.html">Calculates
        /// a route</a> given the following required parameters: <code>DeparturePosition</code>
        /// and <code>DestinationPosition</code>. Requires that you first <a href="https://docs.aws.amazon.com/location-routes/latest/APIReference/API_CreateRouteCalculator.html">create
        /// a route calculator resource</a>.
        /// 
        ///  
        /// <para>
        /// By default, a request that doesn't specify a departure time uses the best time of
        /// day to travel with the best traffic conditions when calculating the route.
        /// </para>
        ///  
        /// <para>
        /// Additional options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/departure-time.html">Specifying
        /// a departure time</a> using either <code>DepartureTime</code> or <code>DepartNow</code>.
        /// This calculates a route based on predictive traffic data at the given time. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't specify both <code>DepartureTime</code> and <code>DepartNow</code> in a
        /// single request. Specifying both parameters returns a validation error.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/travel-mode.html">Specifying
        /// a travel mode</a> using TravelMode sets the transportation mode used to calculate
        /// the routes. This also lets you specify additional route preferences in <code>CarModeOptions</code>
        /// if traveling by <code>Car</code>, or <code>TruckModeOptions</code> if traveling by
        /// <code>Truck</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <code>walking</code> for the travel mode and your data provider is
        /// Esri, the start and destination must be within 40km.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateRoute service method.</param>
        /// 
        /// <returns>The response from the CalculateRoute service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CalculateRoute">REST API Reference for CalculateRoute Operation</seealso>
        public virtual CalculateRouteResponse CalculateRoute(CalculateRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CalculateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CalculateRouteResponseUnmarshaller.Instance;

            return Invoke<CalculateRouteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CalculateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CalculateRoute operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCalculateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CalculateRoute">REST API Reference for CalculateRoute Operation</seealso>
        public virtual IAsyncResult BeginCalculateRoute(CalculateRouteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CalculateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CalculateRouteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CalculateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCalculateRoute.</param>
        /// 
        /// <returns>Returns a  CalculateRouteResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CalculateRoute">REST API Reference for CalculateRoute Operation</seealso>
        public virtual CalculateRouteResponse EndCalculateRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<CalculateRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  CalculateRouteMatrix

        /// <summary>
        /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route-matrix.html">
        /// Calculates a route matrix</a> given the following required parameters: <code>DeparturePositions</code>
        /// and <code>DestinationPositions</code>. <code>CalculateRouteMatrix</code> calculates
        /// routes and returns the travel time and travel distance from each departure position
        /// to each destination position in the request. For example, given departure positions
        /// A and B, and destination positions X and Y, <code>CalculateRouteMatrix</code> will
        /// return time and distance for routes from A to X, A to Y, B to X, and B to Y (in that
        /// order). The number of results returned (and routes calculated) will be the number
        /// of <code>DeparturePositions</code> times the number of <code>DestinationPositions</code>.
        /// 
        ///  <note> 
        /// <para>
        /// Your account is charged for each route calculated, not the number of requests.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requires that you first <a href="https://docs.aws.amazon.com/location-routes/latest/APIReference/API_CreateRouteCalculator.html">create
        /// a route calculator resource</a>.
        /// </para>
        ///  
        /// <para>
        /// By default, a request that doesn't specify a departure time uses the best time of
        /// day to travel with the best traffic conditions when calculating routes.
        /// </para>
        ///  
        /// <para>
        /// Additional options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/departure-time.html">
        /// Specifying a departure time</a> using either <code>DepartureTime</code> or <code>DepartNow</code>.
        /// This calculates routes based on predictive traffic data at the given time. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't specify both <code>DepartureTime</code> and <code>DepartNow</code> in a
        /// single request. Specifying both parameters returns a validation error.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/travel-mode.html">Specifying
        /// a travel mode</a> using TravelMode sets the transportation mode used to calculate
        /// the routes. This also lets you specify additional route preferences in <code>CarModeOptions</code>
        /// if traveling by <code>Car</code>, or <code>TruckModeOptions</code> if traveling by
        /// <code>Truck</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateRouteMatrix service method.</param>
        /// 
        /// <returns>The response from the CalculateRouteMatrix service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CalculateRouteMatrix">REST API Reference for CalculateRouteMatrix Operation</seealso>
        public virtual CalculateRouteMatrixResponse CalculateRouteMatrix(CalculateRouteMatrixRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CalculateRouteMatrixRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CalculateRouteMatrixResponseUnmarshaller.Instance;

            return Invoke<CalculateRouteMatrixResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CalculateRouteMatrix operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CalculateRouteMatrix operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCalculateRouteMatrix
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CalculateRouteMatrix">REST API Reference for CalculateRouteMatrix Operation</seealso>
        public virtual IAsyncResult BeginCalculateRouteMatrix(CalculateRouteMatrixRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CalculateRouteMatrixRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CalculateRouteMatrixResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CalculateRouteMatrix operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCalculateRouteMatrix.</param>
        /// 
        /// <returns>Returns a  CalculateRouteMatrixResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CalculateRouteMatrix">REST API Reference for CalculateRouteMatrix Operation</seealso>
        public virtual CalculateRouteMatrixResponse EndCalculateRouteMatrix(IAsyncResult asyncResult)
        {
            return EndInvoke<CalculateRouteMatrixResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGeofenceCollection

        /// <summary>
        /// Creates a geofence collection, which manages and stores geofences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the CreateGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateGeofenceCollection">REST API Reference for CreateGeofenceCollection Operation</seealso>
        public virtual CreateGeofenceCollectionResponse CreateGeofenceCollection(CreateGeofenceCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGeofenceCollectionResponseUnmarshaller.Instance;

            return Invoke<CreateGeofenceCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGeofenceCollection operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGeofenceCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateGeofenceCollection">REST API Reference for CreateGeofenceCollection Operation</seealso>
        public virtual IAsyncResult BeginCreateGeofenceCollection(CreateGeofenceCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGeofenceCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGeofenceCollection.</param>
        /// 
        /// <returns>Returns a  CreateGeofenceCollectionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateGeofenceCollection">REST API Reference for CreateGeofenceCollection Operation</seealso>
        public virtual CreateGeofenceCollectionResponse EndCreateGeofenceCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGeofenceCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMap

        /// <summary>
        /// Creates a map resource in your AWS account, which provides map tiles of different
        /// styles sourced from global location data providers.
        /// 
        ///  <note> 
        /// <para>
        /// If your application is tracking or routing assets you use in your business, such as
        /// delivery vehicles or employees, you must not use Esri as your geolocation provider.
        /// See section 82 of the <a href="http://aws.amazon.com/service-terms">AWS service terms</a>
        /// for more details.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMap service method.</param>
        /// 
        /// <returns>The response from the CreateMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateMap">REST API Reference for CreateMap Operation</seealso>
        public virtual CreateMapResponse CreateMap(CreateMapRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMapResponseUnmarshaller.Instance;

            return Invoke<CreateMapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMap operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateMap">REST API Reference for CreateMap Operation</seealso>
        public virtual IAsyncResult BeginCreateMap(CreateMapRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMap.</param>
        /// 
        /// <returns>Returns a  CreateMapResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateMap">REST API Reference for CreateMap Operation</seealso>
        public virtual CreateMapResponse EndCreateMap(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMapResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePlaceIndex

        /// <summary>
        /// Creates a place index resource in your AWS account. Use a place index resource to
        /// geocode addresses and other text queries by using the <code>SearchPlaceIndexForText</code>
        /// operation, and reverse geocode coordinates by using the <code>SearchPlaceIndexForPosition</code>
        /// operation, and enable autosuggestions by using the <code>SearchPlaceIndexForSuggestions</code>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// If your application is tracking or routing assets you use in your business, such as
        /// delivery vehicles or employees, you must not use Esri as your geolocation provider.
        /// See section 82 of the <a href="http://aws.amazon.com/service-terms">AWS service terms</a>
        /// for more details.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the CreatePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreatePlaceIndex">REST API Reference for CreatePlaceIndex Operation</seealso>
        public virtual CreatePlaceIndexResponse CreatePlaceIndex(CreatePlaceIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlaceIndexResponseUnmarshaller.Instance;

            return Invoke<CreatePlaceIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlaceIndex operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlaceIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreatePlaceIndex">REST API Reference for CreatePlaceIndex Operation</seealso>
        public virtual IAsyncResult BeginCreatePlaceIndex(CreatePlaceIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlaceIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlaceIndex.</param>
        /// 
        /// <returns>Returns a  CreatePlaceIndexResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreatePlaceIndex">REST API Reference for CreatePlaceIndex Operation</seealso>
        public virtual CreatePlaceIndexResponse EndCreatePlaceIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePlaceIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRouteCalculator

        /// <summary>
        /// Creates a route calculator resource in your AWS account.
        /// 
        ///  
        /// <para>
        /// You can send requests to a route calculator resource to estimate travel time, distance,
        /// and get directions. A route calculator sources traffic and road network data from
        /// your chosen data provider.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your application is tracking or routing assets you use in your business, such as
        /// delivery vehicles or employees, you must not use Esri as your geolocation provider.
        /// See section 82 of the <a href="http://aws.amazon.com/service-terms">AWS service terms</a>
        /// for more details.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteCalculator service method.</param>
        /// 
        /// <returns>The response from the CreateRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ServiceQuotaExceededException">
        /// The operation was denied because the request would exceed the maximum <a href="https://docs.aws.amazon.com/location/latest/developerguide/location-quotas.html">quota</a>
        /// set for Amazon Location Service.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateRouteCalculator">REST API Reference for CreateRouteCalculator Operation</seealso>
        public virtual CreateRouteCalculatorResponse CreateRouteCalculator(CreateRouteCalculatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteCalculatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteCalculatorResponseUnmarshaller.Instance;

            return Invoke<CreateRouteCalculatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteCalculator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteCalculator operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRouteCalculator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateRouteCalculator">REST API Reference for CreateRouteCalculator Operation</seealso>
        public virtual IAsyncResult BeginCreateRouteCalculator(CreateRouteCalculatorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteCalculatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteCalculatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRouteCalculator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouteCalculator.</param>
        /// 
        /// <returns>Returns a  CreateRouteCalculatorResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateRouteCalculator">REST API Reference for CreateRouteCalculator Operation</seealso>
        public virtual CreateRouteCalculatorResponse EndCreateRouteCalculator(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRouteCalculatorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTracker

        /// <summary>
        /// Creates a tracker resource in your AWS account, which lets you retrieve current and
        /// historical location of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTracker service method.</param>
        /// 
        /// <returns>The response from the CreateTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateTracker">REST API Reference for CreateTracker Operation</seealso>
        public virtual CreateTrackerResponse CreateTracker(CreateTrackerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrackerResponseUnmarshaller.Instance;

            return Invoke<CreateTrackerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTracker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTracker operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTracker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateTracker">REST API Reference for CreateTracker Operation</seealso>
        public virtual IAsyncResult BeginCreateTracker(CreateTrackerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrackerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTracker.</param>
        /// 
        /// <returns>Returns a  CreateTrackerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateTracker">REST API Reference for CreateTracker Operation</seealso>
        public virtual CreateTrackerResponse EndCreateTracker(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrackerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGeofenceCollection

        /// <summary>
        /// Deletes a geofence collection from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently. If the geofence collection is the
        /// target of a tracker resource, the devices will no longer be monitored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the DeleteGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteGeofenceCollection">REST API Reference for DeleteGeofenceCollection Operation</seealso>
        public virtual DeleteGeofenceCollectionResponse DeleteGeofenceCollection(DeleteGeofenceCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGeofenceCollectionResponseUnmarshaller.Instance;

            return Invoke<DeleteGeofenceCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeofenceCollection operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGeofenceCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteGeofenceCollection">REST API Reference for DeleteGeofenceCollection Operation</seealso>
        public virtual IAsyncResult BeginDeleteGeofenceCollection(DeleteGeofenceCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGeofenceCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGeofenceCollection.</param>
        /// 
        /// <returns>Returns a  DeleteGeofenceCollectionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteGeofenceCollection">REST API Reference for DeleteGeofenceCollection Operation</seealso>
        public virtual DeleteGeofenceCollectionResponse EndDeleteGeofenceCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGeofenceCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMap

        /// <summary>
        /// Deletes a map resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently. If the map is being used in an application,
        /// the map may not render.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMap service method.</param>
        /// 
        /// <returns>The response from the DeleteMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteMap">REST API Reference for DeleteMap Operation</seealso>
        public virtual DeleteMapResponse DeleteMap(DeleteMapRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMapResponseUnmarshaller.Instance;

            return Invoke<DeleteMapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMap operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteMap">REST API Reference for DeleteMap Operation</seealso>
        public virtual IAsyncResult BeginDeleteMap(DeleteMapRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMap.</param>
        /// 
        /// <returns>Returns a  DeleteMapResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteMap">REST API Reference for DeleteMap Operation</seealso>
        public virtual DeleteMapResponse EndDeleteMap(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMapResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePlaceIndex

        /// <summary>
        /// Deletes a place index resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the DeletePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeletePlaceIndex">REST API Reference for DeletePlaceIndex Operation</seealso>
        public virtual DeletePlaceIndexResponse DeletePlaceIndex(DeletePlaceIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaceIndexResponseUnmarshaller.Instance;

            return Invoke<DeletePlaceIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaceIndex operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlaceIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeletePlaceIndex">REST API Reference for DeletePlaceIndex Operation</seealso>
        public virtual IAsyncResult BeginDeletePlaceIndex(DeletePlaceIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaceIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlaceIndex.</param>
        /// 
        /// <returns>Returns a  DeletePlaceIndexResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeletePlaceIndex">REST API Reference for DeletePlaceIndex Operation</seealso>
        public virtual DeletePlaceIndexResponse EndDeletePlaceIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePlaceIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRouteCalculator

        /// <summary>
        /// Deletes a route calculator resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteCalculator service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteRouteCalculator">REST API Reference for DeleteRouteCalculator Operation</seealso>
        public virtual DeleteRouteCalculatorResponse DeleteRouteCalculator(DeleteRouteCalculatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteCalculatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteCalculatorResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteCalculatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteCalculator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteCalculator operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouteCalculator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteRouteCalculator">REST API Reference for DeleteRouteCalculator Operation</seealso>
        public virtual IAsyncResult BeginDeleteRouteCalculator(DeleteRouteCalculatorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteCalculatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteCalculatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteCalculator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteCalculator.</param>
        /// 
        /// <returns>Returns a  DeleteRouteCalculatorResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteRouteCalculator">REST API Reference for DeleteRouteCalculator Operation</seealso>
        public virtual DeleteRouteCalculatorResponse EndDeleteRouteCalculator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouteCalculatorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTracker

        /// <summary>
        /// Deletes a tracker resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the resource permanently. If the tracker resource is in use,
        /// you may encounter an error. Make sure that the target resource isn't a dependency
        /// for your applications.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTracker service method.</param>
        /// 
        /// <returns>The response from the DeleteTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteTracker">REST API Reference for DeleteTracker Operation</seealso>
        public virtual DeleteTrackerResponse DeleteTracker(DeleteTrackerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrackerResponseUnmarshaller.Instance;

            return Invoke<DeleteTrackerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTracker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTracker operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTracker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteTracker">REST API Reference for DeleteTracker Operation</seealso>
        public virtual IAsyncResult BeginDeleteTracker(DeleteTrackerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrackerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTracker.</param>
        /// 
        /// <returns>Returns a  DeleteTrackerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteTracker">REST API Reference for DeleteTracker Operation</seealso>
        public virtual DeleteTrackerResponse EndDeleteTracker(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTrackerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGeofenceCollection

        /// <summary>
        /// Retrieves the geofence collection details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the DescribeGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeGeofenceCollection">REST API Reference for DescribeGeofenceCollection Operation</seealso>
        public virtual DescribeGeofenceCollectionResponse DescribeGeofenceCollection(DescribeGeofenceCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGeofenceCollectionResponseUnmarshaller.Instance;

            return Invoke<DescribeGeofenceCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeofenceCollection operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGeofenceCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeGeofenceCollection">REST API Reference for DescribeGeofenceCollection Operation</seealso>
        public virtual IAsyncResult BeginDescribeGeofenceCollection(DescribeGeofenceCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGeofenceCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGeofenceCollection.</param>
        /// 
        /// <returns>Returns a  DescribeGeofenceCollectionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeGeofenceCollection">REST API Reference for DescribeGeofenceCollection Operation</seealso>
        public virtual DescribeGeofenceCollectionResponse EndDescribeGeofenceCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGeofenceCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMap

        /// <summary>
        /// Retrieves the map resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMap service method.</param>
        /// 
        /// <returns>The response from the DescribeMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeMap">REST API Reference for DescribeMap Operation</seealso>
        public virtual DescribeMapResponse DescribeMap(DescribeMapRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMapResponseUnmarshaller.Instance;

            return Invoke<DescribeMapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMap operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeMap">REST API Reference for DescribeMap Operation</seealso>
        public virtual IAsyncResult BeginDescribeMap(DescribeMapRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMap.</param>
        /// 
        /// <returns>Returns a  DescribeMapResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeMap">REST API Reference for DescribeMap Operation</seealso>
        public virtual DescribeMapResponse EndDescribeMap(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMapResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePlaceIndex

        /// <summary>
        /// Retrieves the place index resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the DescribePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribePlaceIndex">REST API Reference for DescribePlaceIndex Operation</seealso>
        public virtual DescribePlaceIndexResponse DescribePlaceIndex(DescribePlaceIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlaceIndexResponseUnmarshaller.Instance;

            return Invoke<DescribePlaceIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlaceIndex operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePlaceIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribePlaceIndex">REST API Reference for DescribePlaceIndex Operation</seealso>
        public virtual IAsyncResult BeginDescribePlaceIndex(DescribePlaceIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlaceIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlaceIndex.</param>
        /// 
        /// <returns>Returns a  DescribePlaceIndexResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribePlaceIndex">REST API Reference for DescribePlaceIndex Operation</seealso>
        public virtual DescribePlaceIndexResponse EndDescribePlaceIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePlaceIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRouteCalculator

        /// <summary>
        /// Retrieves the route calculator resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteCalculator service method.</param>
        /// 
        /// <returns>The response from the DescribeRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeRouteCalculator">REST API Reference for DescribeRouteCalculator Operation</seealso>
        public virtual DescribeRouteCalculatorResponse DescribeRouteCalculator(DescribeRouteCalculatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRouteCalculatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRouteCalculatorResponseUnmarshaller.Instance;

            return Invoke<DescribeRouteCalculatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouteCalculator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteCalculator operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRouteCalculator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeRouteCalculator">REST API Reference for DescribeRouteCalculator Operation</seealso>
        public virtual IAsyncResult BeginDescribeRouteCalculator(DescribeRouteCalculatorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRouteCalculatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRouteCalculatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRouteCalculator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRouteCalculator.</param>
        /// 
        /// <returns>Returns a  DescribeRouteCalculatorResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeRouteCalculator">REST API Reference for DescribeRouteCalculator Operation</seealso>
        public virtual DescribeRouteCalculatorResponse EndDescribeRouteCalculator(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRouteCalculatorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTracker

        /// <summary>
        /// Retrieves the tracker resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTracker service method.</param>
        /// 
        /// <returns>The response from the DescribeTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeTracker">REST API Reference for DescribeTracker Operation</seealso>
        public virtual DescribeTrackerResponse DescribeTracker(DescribeTrackerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrackerResponseUnmarshaller.Instance;

            return Invoke<DescribeTrackerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTracker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTracker operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTracker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeTracker">REST API Reference for DescribeTracker Operation</seealso>
        public virtual IAsyncResult BeginDescribeTracker(DescribeTrackerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrackerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTracker.</param>
        /// 
        /// <returns>Returns a  DescribeTrackerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeTracker">REST API Reference for DescribeTracker Operation</seealso>
        public virtual DescribeTrackerResponse EndDescribeTracker(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTrackerResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateTrackerConsumer

        /// <summary>
        /// Removes the association between a tracker resource and a geofence collection.
        /// 
        ///  <note> 
        /// <para>
        /// Once you unlink a tracker resource from a geofence collection, the tracker positions
        /// will no longer be automatically evaluated against geofences.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrackerConsumer service method.</param>
        /// 
        /// <returns>The response from the DisassociateTrackerConsumer service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DisassociateTrackerConsumer">REST API Reference for DisassociateTrackerConsumer Operation</seealso>
        public virtual DisassociateTrackerConsumerResponse DisassociateTrackerConsumer(DisassociateTrackerConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTrackerConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrackerConsumerResponseUnmarshaller.Instance;

            return Invoke<DisassociateTrackerConsumerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTrackerConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrackerConsumer operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTrackerConsumer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DisassociateTrackerConsumer">REST API Reference for DisassociateTrackerConsumer Operation</seealso>
        public virtual IAsyncResult BeginDisassociateTrackerConsumer(DisassociateTrackerConsumerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTrackerConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrackerConsumerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTrackerConsumer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTrackerConsumer.</param>
        /// 
        /// <returns>Returns a  DisassociateTrackerConsumerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DisassociateTrackerConsumer">REST API Reference for DisassociateTrackerConsumer Operation</seealso>
        public virtual DisassociateTrackerConsumerResponse EndDisassociateTrackerConsumer(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateTrackerConsumerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevicePosition

        /// <summary>
        /// Retrieves a device's most recent position according to its sample time.
        /// 
        ///  <note> 
        /// <para>
        /// Device positions are deleted after 30 days.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePosition service method.</param>
        /// 
        /// <returns>The response from the GetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePosition">REST API Reference for GetDevicePosition Operation</seealso>
        public virtual GetDevicePositionResponse GetDevicePosition(GetDevicePositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePositionResponseUnmarshaller.Instance;

            return Invoke<GetDevicePositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePosition operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePosition">REST API Reference for GetDevicePosition Operation</seealso>
        public virtual IAsyncResult BeginGetDevicePosition(GetDevicePositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicePosition.</param>
        /// 
        /// <returns>Returns a  GetDevicePositionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePosition">REST API Reference for GetDevicePosition Operation</seealso>
        public virtual GetDevicePositionResponse EndGetDevicePosition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevicePositionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevicePositionHistory

        /// <summary>
        /// Retrieves the device position history from a tracker resource within a specified range
        /// of time.
        /// 
        ///  <note> 
        /// <para>
        /// Device positions are deleted after 30 days.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePositionHistory service method.</param>
        /// 
        /// <returns>The response from the GetDevicePositionHistory service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePositionHistory">REST API Reference for GetDevicePositionHistory Operation</seealso>
        public virtual GetDevicePositionHistoryResponse GetDevicePositionHistory(GetDevicePositionHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicePositionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePositionHistoryResponseUnmarshaller.Instance;

            return Invoke<GetDevicePositionHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePositionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePositionHistory operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicePositionHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePositionHistory">REST API Reference for GetDevicePositionHistory Operation</seealso>
        public virtual IAsyncResult BeginGetDevicePositionHistory(GetDevicePositionHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicePositionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePositionHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicePositionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicePositionHistory.</param>
        /// 
        /// <returns>Returns a  GetDevicePositionHistoryResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePositionHistory">REST API Reference for GetDevicePositionHistory Operation</seealso>
        public virtual GetDevicePositionHistoryResponse EndGetDevicePositionHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevicePositionHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGeofence

        /// <summary>
        /// Retrieves the geofence details from a geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeofence service method.</param>
        /// 
        /// <returns>The response from the GetGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetGeofence">REST API Reference for GetGeofence Operation</seealso>
        public virtual GetGeofenceResponse GetGeofence(GetGeofenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeofenceResponseUnmarshaller.Instance;

            return Invoke<GetGeofenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeofence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeofence operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGeofence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetGeofence">REST API Reference for GetGeofence Operation</seealso>
        public virtual IAsyncResult BeginGetGeofence(GetGeofenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeofenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGeofence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGeofence.</param>
        /// 
        /// <returns>Returns a  GetGeofenceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetGeofence">REST API Reference for GetGeofence Operation</seealso>
        public virtual GetGeofenceResponse EndGetGeofence(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGeofenceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMapGlyphs

        /// <summary>
        /// Retrieves glyphs used to display labels on a map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapGlyphs service method.</param>
        /// 
        /// <returns>The response from the GetMapGlyphs service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapGlyphs">REST API Reference for GetMapGlyphs Operation</seealso>
        public virtual GetMapGlyphsResponse GetMapGlyphs(GetMapGlyphsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapGlyphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapGlyphsResponseUnmarshaller.Instance;

            return Invoke<GetMapGlyphsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMapGlyphs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapGlyphs operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMapGlyphs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapGlyphs">REST API Reference for GetMapGlyphs Operation</seealso>
        public virtual IAsyncResult BeginGetMapGlyphs(GetMapGlyphsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapGlyphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapGlyphsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMapGlyphs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMapGlyphs.</param>
        /// 
        /// <returns>Returns a  GetMapGlyphsResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapGlyphs">REST API Reference for GetMapGlyphs Operation</seealso>
        public virtual GetMapGlyphsResponse EndGetMapGlyphs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMapGlyphsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMapSprites

        /// <summary>
        /// Retrieves the sprite sheet corresponding to a map resource. The sprite sheet is a
        /// PNG image paired with a JSON document describing the offsets of individual icons that
        /// will be displayed on a rendered map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapSprites service method.</param>
        /// 
        /// <returns>The response from the GetMapSprites service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapSprites">REST API Reference for GetMapSprites Operation</seealso>
        public virtual GetMapSpritesResponse GetMapSprites(GetMapSpritesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapSpritesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapSpritesResponseUnmarshaller.Instance;

            return Invoke<GetMapSpritesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMapSprites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapSprites operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMapSprites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapSprites">REST API Reference for GetMapSprites Operation</seealso>
        public virtual IAsyncResult BeginGetMapSprites(GetMapSpritesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapSpritesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapSpritesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMapSprites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMapSprites.</param>
        /// 
        /// <returns>Returns a  GetMapSpritesResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapSprites">REST API Reference for GetMapSprites Operation</seealso>
        public virtual GetMapSpritesResponse EndGetMapSprites(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMapSpritesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMapStyleDescriptor

        /// <summary>
        /// Retrieves the map style descriptor from a map resource. 
        /// 
        ///  
        /// <para>
        /// The style descriptor contains speciﬁcations on how features render on a map. For example,
        /// what data to display, what order to display the data in, and the style for the data.
        /// Style descriptors follow the Mapbox Style Specification.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapStyleDescriptor service method.</param>
        /// 
        /// <returns>The response from the GetMapStyleDescriptor service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapStyleDescriptor">REST API Reference for GetMapStyleDescriptor Operation</seealso>
        public virtual GetMapStyleDescriptorResponse GetMapStyleDescriptor(GetMapStyleDescriptorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapStyleDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapStyleDescriptorResponseUnmarshaller.Instance;

            return Invoke<GetMapStyleDescriptorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMapStyleDescriptor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapStyleDescriptor operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMapStyleDescriptor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapStyleDescriptor">REST API Reference for GetMapStyleDescriptor Operation</seealso>
        public virtual IAsyncResult BeginGetMapStyleDescriptor(GetMapStyleDescriptorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapStyleDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapStyleDescriptorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMapStyleDescriptor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMapStyleDescriptor.</param>
        /// 
        /// <returns>Returns a  GetMapStyleDescriptorResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapStyleDescriptor">REST API Reference for GetMapStyleDescriptor Operation</seealso>
        public virtual GetMapStyleDescriptorResponse EndGetMapStyleDescriptor(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMapStyleDescriptorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMapTile

        /// <summary>
        /// Retrieves a vector data tile from the map resource. Map tiles are used by clients
        /// to render a map. they're addressed using a grid arrangement with an X coordinate,
        /// Y coordinate, and Z (zoom) level. 
        /// 
        ///  
        /// <para>
        /// The origin (0, 0) is the top left of the map. Increasing the zoom level by 1 doubles
        /// both the X and Y dimensions, so a tile containing data for the entire world at (0/0/0)
        /// will be split into 4 tiles at zoom 1 (1/0/0, 1/0/1, 1/1/0, 1/1/1).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapTile service method.</param>
        /// 
        /// <returns>The response from the GetMapTile service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapTile">REST API Reference for GetMapTile Operation</seealso>
        public virtual GetMapTileResponse GetMapTile(GetMapTileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapTileResponseUnmarshaller.Instance;

            return Invoke<GetMapTileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMapTile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapTile operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMapTile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapTile">REST API Reference for GetMapTile Operation</seealso>
        public virtual IAsyncResult BeginGetMapTile(GetMapTileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapTileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMapTile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMapTile.</param>
        /// 
        /// <returns>Returns a  GetMapTileResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapTile">REST API Reference for GetMapTile Operation</seealso>
        public virtual GetMapTileResponse EndGetMapTile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMapTileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlace

        /// <summary>
        /// Finds a place by its unique ID. A <code>PlaceId</code> is returned by other search
        /// operations.
        /// 
        ///  <note> 
        /// <para>
        /// A PlaceId is valid only if all of the following are the same in the original search
        /// request and the call to <code>GetPlace</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Customer AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Region
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data provider specified in the place index resource
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlace service method.</param>
        /// 
        /// <returns>The response from the GetPlace service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetPlace">REST API Reference for GetPlace Operation</seealso>
        public virtual GetPlaceResponse GetPlace(GetPlaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaceResponseUnmarshaller.Instance;

            return Invoke<GetPlaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlace operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetPlace">REST API Reference for GetPlace Operation</seealso>
        public virtual IAsyncResult BeginGetPlace(GetPlaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlace.</param>
        /// 
        /// <returns>Returns a  GetPlaceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetPlace">REST API Reference for GetPlace Operation</seealso>
        public virtual GetPlaceResponse EndGetPlace(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlaceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevicePositions

        /// <summary>
        /// A batch request to retrieve all device positions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePositions service method.</param>
        /// 
        /// <returns>The response from the ListDevicePositions service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListDevicePositions">REST API Reference for ListDevicePositions Operation</seealso>
        public virtual ListDevicePositionsResponse ListDevicePositions(ListDevicePositionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicePositionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicePositionsResponseUnmarshaller.Instance;

            return Invoke<ListDevicePositionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicePositions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePositions operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevicePositions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListDevicePositions">REST API Reference for ListDevicePositions Operation</seealso>
        public virtual IAsyncResult BeginListDevicePositions(ListDevicePositionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicePositionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicePositionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevicePositions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevicePositions.</param>
        /// 
        /// <returns>Returns a  ListDevicePositionsResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListDevicePositions">REST API Reference for ListDevicePositions Operation</seealso>
        public virtual ListDevicePositionsResponse EndListDevicePositions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicePositionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGeofenceCollections

        /// <summary>
        /// Lists geofence collections in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeofenceCollections service method.</param>
        /// 
        /// <returns>The response from the ListGeofenceCollections service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofenceCollections">REST API Reference for ListGeofenceCollections Operation</seealso>
        public virtual ListGeofenceCollectionsResponse ListGeofenceCollections(ListGeofenceCollectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeofenceCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeofenceCollectionsResponseUnmarshaller.Instance;

            return Invoke<ListGeofenceCollectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeofenceCollections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeofenceCollections operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGeofenceCollections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofenceCollections">REST API Reference for ListGeofenceCollections Operation</seealso>
        public virtual IAsyncResult BeginListGeofenceCollections(ListGeofenceCollectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeofenceCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeofenceCollectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGeofenceCollections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGeofenceCollections.</param>
        /// 
        /// <returns>Returns a  ListGeofenceCollectionsResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofenceCollections">REST API Reference for ListGeofenceCollections Operation</seealso>
        public virtual ListGeofenceCollectionsResponse EndListGeofenceCollections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGeofenceCollectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGeofences

        /// <summary>
        /// Lists geofences stored in a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeofences service method.</param>
        /// 
        /// <returns>The response from the ListGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofences">REST API Reference for ListGeofences Operation</seealso>
        public virtual ListGeofencesResponse ListGeofences(ListGeofencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeofencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeofencesResponseUnmarshaller.Instance;

            return Invoke<ListGeofencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeofences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeofences operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGeofences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofences">REST API Reference for ListGeofences Operation</seealso>
        public virtual IAsyncResult BeginListGeofences(ListGeofencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeofencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeofencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGeofences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGeofences.</param>
        /// 
        /// <returns>Returns a  ListGeofencesResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofences">REST API Reference for ListGeofences Operation</seealso>
        public virtual ListGeofencesResponse EndListGeofences(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGeofencesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMaps

        /// <summary>
        /// Lists map resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMaps service method.</param>
        /// 
        /// <returns>The response from the ListMaps service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListMaps">REST API Reference for ListMaps Operation</seealso>
        public virtual ListMapsResponse ListMaps(ListMapsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMapsResponseUnmarshaller.Instance;

            return Invoke<ListMapsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMaps operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListMaps">REST API Reference for ListMaps Operation</seealso>
        public virtual IAsyncResult BeginListMaps(ListMapsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMapsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMaps.</param>
        /// 
        /// <returns>Returns a  ListMapsResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListMaps">REST API Reference for ListMaps Operation</seealso>
        public virtual ListMapsResponse EndListMaps(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMapsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPlaceIndexes

        /// <summary>
        /// Lists place index resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaceIndexes service method.</param>
        /// 
        /// <returns>The response from the ListPlaceIndexes service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListPlaceIndexes">REST API Reference for ListPlaceIndexes Operation</seealso>
        public virtual ListPlaceIndexesResponse ListPlaceIndexes(ListPlaceIndexesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaceIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaceIndexesResponseUnmarshaller.Instance;

            return Invoke<ListPlaceIndexesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlaceIndexes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlaceIndexes operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlaceIndexes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListPlaceIndexes">REST API Reference for ListPlaceIndexes Operation</seealso>
        public virtual IAsyncResult BeginListPlaceIndexes(ListPlaceIndexesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaceIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaceIndexesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlaceIndexes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlaceIndexes.</param>
        /// 
        /// <returns>Returns a  ListPlaceIndexesResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListPlaceIndexes">REST API Reference for ListPlaceIndexes Operation</seealso>
        public virtual ListPlaceIndexesResponse EndListPlaceIndexes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPlaceIndexesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRouteCalculators

        /// <summary>
        /// Lists route calculator resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRouteCalculators service method.</param>
        /// 
        /// <returns>The response from the ListRouteCalculators service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListRouteCalculators">REST API Reference for ListRouteCalculators Operation</seealso>
        public virtual ListRouteCalculatorsResponse ListRouteCalculators(ListRouteCalculatorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRouteCalculatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRouteCalculatorsResponseUnmarshaller.Instance;

            return Invoke<ListRouteCalculatorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRouteCalculators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRouteCalculators operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRouteCalculators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListRouteCalculators">REST API Reference for ListRouteCalculators Operation</seealso>
        public virtual IAsyncResult BeginListRouteCalculators(ListRouteCalculatorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRouteCalculatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRouteCalculatorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRouteCalculators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRouteCalculators.</param>
        /// 
        /// <returns>Returns a  ListRouteCalculatorsResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListRouteCalculators">REST API Reference for ListRouteCalculators Operation</seealso>
        public virtual ListRouteCalculatorsResponse EndListRouteCalculators(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRouteCalculatorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of tags that are applied to the specified Amazon Location resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrackerConsumers

        /// <summary>
        /// Lists geofence collections currently associated to the given tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrackerConsumers service method.</param>
        /// 
        /// <returns>The response from the ListTrackerConsumers service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackerConsumers">REST API Reference for ListTrackerConsumers Operation</seealso>
        public virtual ListTrackerConsumersResponse ListTrackerConsumers(ListTrackerConsumersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrackerConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrackerConsumersResponseUnmarshaller.Instance;

            return Invoke<ListTrackerConsumersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrackerConsumers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrackerConsumers operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrackerConsumers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackerConsumers">REST API Reference for ListTrackerConsumers Operation</seealso>
        public virtual IAsyncResult BeginListTrackerConsumers(ListTrackerConsumersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrackerConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrackerConsumersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrackerConsumers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrackerConsumers.</param>
        /// 
        /// <returns>Returns a  ListTrackerConsumersResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackerConsumers">REST API Reference for ListTrackerConsumers Operation</seealso>
        public virtual ListTrackerConsumersResponse EndListTrackerConsumers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrackerConsumersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrackers

        /// <summary>
        /// Lists tracker resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrackers service method.</param>
        /// 
        /// <returns>The response from the ListTrackers service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackers">REST API Reference for ListTrackers Operation</seealso>
        public virtual ListTrackersResponse ListTrackers(ListTrackersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrackersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrackersResponseUnmarshaller.Instance;

            return Invoke<ListTrackersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrackers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrackers operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrackers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackers">REST API Reference for ListTrackers Operation</seealso>
        public virtual IAsyncResult BeginListTrackers(ListTrackersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrackersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrackersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrackers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrackers.</param>
        /// 
        /// <returns>Returns a  ListTrackersResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackers">REST API Reference for ListTrackers Operation</seealso>
        public virtual ListTrackersResponse EndListTrackers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrackersResponse>(asyncResult);
        }

        #endregion
        
        #region  PutGeofence

        /// <summary>
        /// Stores a geofence geometry in a given geofence collection, or updates the geometry
        /// of an existing geofence if a geofence ID is included in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGeofence service method.</param>
        /// 
        /// <returns>The response from the PutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/PutGeofence">REST API Reference for PutGeofence Operation</seealso>
        public virtual PutGeofenceResponse PutGeofence(PutGeofenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGeofenceResponseUnmarshaller.Instance;

            return Invoke<PutGeofenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutGeofence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGeofence operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGeofence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/PutGeofence">REST API Reference for PutGeofence Operation</seealso>
        public virtual IAsyncResult BeginPutGeofence(PutGeofenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGeofenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutGeofence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGeofence.</param>
        /// 
        /// <returns>Returns a  PutGeofenceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/PutGeofence">REST API Reference for PutGeofence Operation</seealso>
        public virtual PutGeofenceResponse EndPutGeofence(IAsyncResult asyncResult)
        {
            return EndInvoke<PutGeofenceResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchPlaceIndexForPosition

        /// <summary>
        /// Reverse geocodes a given coordinate and returns a legible address. Allows you to search
        /// for Places or points of interest near a given position.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForPosition service method.</param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForPosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForPosition">REST API Reference for SearchPlaceIndexForPosition Operation</seealso>
        public virtual SearchPlaceIndexForPositionResponse SearchPlaceIndexForPosition(SearchPlaceIndexForPositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchPlaceIndexForPositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchPlaceIndexForPositionResponseUnmarshaller.Instance;

            return Invoke<SearchPlaceIndexForPositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchPlaceIndexForPosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForPosition operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchPlaceIndexForPosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForPosition">REST API Reference for SearchPlaceIndexForPosition Operation</seealso>
        public virtual IAsyncResult BeginSearchPlaceIndexForPosition(SearchPlaceIndexForPositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchPlaceIndexForPositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchPlaceIndexForPositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchPlaceIndexForPosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchPlaceIndexForPosition.</param>
        /// 
        /// <returns>Returns a  SearchPlaceIndexForPositionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForPosition">REST API Reference for SearchPlaceIndexForPosition Operation</seealso>
        public virtual SearchPlaceIndexForPositionResponse EndSearchPlaceIndexForPosition(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchPlaceIndexForPositionResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchPlaceIndexForSuggestions

        /// <summary>
        /// Generates suggestions for addresses and points of interest based on partial or misspelled
        /// free-form text. This operation is also known as autocomplete, autosuggest, or fuzzy
        /// matching.
        /// 
        ///  
        /// <para>
        /// Optional parameters let you narrow your search results by bounding box or country,
        /// or bias your search toward a specific position on the globe.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can search for suggested place names near a specified position by using <code>BiasPosition</code>,
        /// or filter results within a bounding box by using <code>FilterBBox</code>. These parameters
        /// are mutually exclusive; using both <code>BiasPosition</code> and <code>FilterBBox</code>
        /// in the same command returns an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForSuggestions service method.</param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForSuggestions service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForSuggestions">REST API Reference for SearchPlaceIndexForSuggestions Operation</seealso>
        public virtual SearchPlaceIndexForSuggestionsResponse SearchPlaceIndexForSuggestions(SearchPlaceIndexForSuggestionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchPlaceIndexForSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchPlaceIndexForSuggestionsResponseUnmarshaller.Instance;

            return Invoke<SearchPlaceIndexForSuggestionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchPlaceIndexForSuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForSuggestions operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchPlaceIndexForSuggestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForSuggestions">REST API Reference for SearchPlaceIndexForSuggestions Operation</seealso>
        public virtual IAsyncResult BeginSearchPlaceIndexForSuggestions(SearchPlaceIndexForSuggestionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchPlaceIndexForSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchPlaceIndexForSuggestionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchPlaceIndexForSuggestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchPlaceIndexForSuggestions.</param>
        /// 
        /// <returns>Returns a  SearchPlaceIndexForSuggestionsResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForSuggestions">REST API Reference for SearchPlaceIndexForSuggestions Operation</seealso>
        public virtual SearchPlaceIndexForSuggestionsResponse EndSearchPlaceIndexForSuggestions(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchPlaceIndexForSuggestionsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchPlaceIndexForText

        /// <summary>
        /// Geocodes free-form text, such as an address, name, city, or region to allow you to
        /// search for Places or points of interest. 
        /// 
        ///  
        /// <para>
        /// Optional parameters let you narrow your search results by bounding box or country,
        /// or bias your search toward a specific position on the globe.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can search for places near a given position using <code>BiasPosition</code>, or
        /// filter results within a bounding box using <code>FilterBBox</code>. Providing both
        /// parameters simultaneously returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Search results are returned in order of highest to lowest relevance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForText service method.</param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForText service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForText">REST API Reference for SearchPlaceIndexForText Operation</seealso>
        public virtual SearchPlaceIndexForTextResponse SearchPlaceIndexForText(SearchPlaceIndexForTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchPlaceIndexForTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchPlaceIndexForTextResponseUnmarshaller.Instance;

            return Invoke<SearchPlaceIndexForTextResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchPlaceIndexForText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForText operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchPlaceIndexForText
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForText">REST API Reference for SearchPlaceIndexForText Operation</seealso>
        public virtual IAsyncResult BeginSearchPlaceIndexForText(SearchPlaceIndexForTextRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchPlaceIndexForTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchPlaceIndexForTextResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchPlaceIndexForText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchPlaceIndexForText.</param>
        /// 
        /// <returns>Returns a  SearchPlaceIndexForTextResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForText">REST API Reference for SearchPlaceIndexForText Operation</seealso>
        public virtual SearchPlaceIndexForTextResponse EndSearchPlaceIndexForText(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchPlaceIndexForTextResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Amazon Location Service
        /// resource.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> operation with an Amazon Location Service
        /// resource that already has tags. If you specify a new tag key for the resource, this
        /// tag is appended to the tags already associated with the resource. If you specify a
        /// tag key that's already associated with the resource, the new tag value that you specify
        /// replaces the previous value for that tag. 
        /// </para>
        ///  
        /// <para>
        /// You can associate up to 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from the specified Amazon Location resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGeofenceCollection

        /// <summary>
        /// Updates the specified properties of a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the UpdateGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateGeofenceCollection">REST API Reference for UpdateGeofenceCollection Operation</seealso>
        public virtual UpdateGeofenceCollectionResponse UpdateGeofenceCollection(UpdateGeofenceCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGeofenceCollectionResponseUnmarshaller.Instance;

            return Invoke<UpdateGeofenceCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeofenceCollection operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGeofenceCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateGeofenceCollection">REST API Reference for UpdateGeofenceCollection Operation</seealso>
        public virtual IAsyncResult BeginUpdateGeofenceCollection(UpdateGeofenceCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGeofenceCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGeofenceCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGeofenceCollection.</param>
        /// 
        /// <returns>Returns a  UpdateGeofenceCollectionResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateGeofenceCollection">REST API Reference for UpdateGeofenceCollection Operation</seealso>
        public virtual UpdateGeofenceCollectionResponse EndUpdateGeofenceCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGeofenceCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMap

        /// <summary>
        /// Updates the specified properties of a given map resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMap service method.</param>
        /// 
        /// <returns>The response from the UpdateMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateMap">REST API Reference for UpdateMap Operation</seealso>
        public virtual UpdateMapResponse UpdateMap(UpdateMapRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMapResponseUnmarshaller.Instance;

            return Invoke<UpdateMapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMap operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateMap">REST API Reference for UpdateMap Operation</seealso>
        public virtual IAsyncResult BeginUpdateMap(UpdateMapRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMap.</param>
        /// 
        /// <returns>Returns a  UpdateMapResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateMap">REST API Reference for UpdateMap Operation</seealso>
        public virtual UpdateMapResponse EndUpdateMap(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMapResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePlaceIndex

        /// <summary>
        /// Updates the specified properties of a given place index resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the UpdatePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdatePlaceIndex">REST API Reference for UpdatePlaceIndex Operation</seealso>
        public virtual UpdatePlaceIndexResponse UpdatePlaceIndex(UpdatePlaceIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlaceIndexResponseUnmarshaller.Instance;

            return Invoke<UpdatePlaceIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlaceIndex operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePlaceIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdatePlaceIndex">REST API Reference for UpdatePlaceIndex Operation</seealso>
        public virtual IAsyncResult BeginUpdatePlaceIndex(UpdatePlaceIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlaceIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePlaceIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePlaceIndex.</param>
        /// 
        /// <returns>Returns a  UpdatePlaceIndexResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdatePlaceIndex">REST API Reference for UpdatePlaceIndex Operation</seealso>
        public virtual UpdatePlaceIndexResponse EndUpdatePlaceIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePlaceIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRouteCalculator

        /// <summary>
        /// Updates the specified properties for a given route calculator resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteCalculator service method.</param>
        /// 
        /// <returns>The response from the UpdateRouteCalculator service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateRouteCalculator">REST API Reference for UpdateRouteCalculator Operation</seealso>
        public virtual UpdateRouteCalculatorResponse UpdateRouteCalculator(UpdateRouteCalculatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRouteCalculatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteCalculatorResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteCalculatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRouteCalculator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteCalculator operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRouteCalculator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateRouteCalculator">REST API Reference for UpdateRouteCalculator Operation</seealso>
        public virtual IAsyncResult BeginUpdateRouteCalculator(UpdateRouteCalculatorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRouteCalculatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteCalculatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRouteCalculator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRouteCalculator.</param>
        /// 
        /// <returns>Returns a  UpdateRouteCalculatorResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateRouteCalculator">REST API Reference for UpdateRouteCalculator Operation</seealso>
        public virtual UpdateRouteCalculatorResponse EndUpdateRouteCalculator(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRouteCalculatorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTracker

        /// <summary>
        /// Updates the specified properties of a given tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTracker service method.</param>
        /// 
        /// <returns>The response from the UpdateTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateTracker">REST API Reference for UpdateTracker Operation</seealso>
        public virtual UpdateTrackerResponse UpdateTracker(UpdateTrackerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrackerResponseUnmarshaller.Instance;

            return Invoke<UpdateTrackerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTracker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTracker operation on AmazonLocationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTracker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateTracker">REST API Reference for UpdateTracker Operation</seealso>
        public virtual IAsyncResult BeginUpdateTracker(UpdateTrackerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrackerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTracker.</param>
        /// 
        /// <returns>Returns a  UpdateTrackerResult from LocationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/UpdateTracker">REST API Reference for UpdateTracker Operation</seealso>
        public virtual UpdateTrackerResponse EndUpdateTracker(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTrackerResponse>(asyncResult);
        }

        #endregion
        
    }
}