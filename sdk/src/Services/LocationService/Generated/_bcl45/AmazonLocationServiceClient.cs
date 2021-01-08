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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
    /// Suite of geospatial services including Maps, Places, Tracking, and Geofencing
    /// </summary>
    public partial class AmazonLocationServiceClient : AmazonServiceClient, IAmazonLocationService
    {
        private static IServiceMetadata serviceMetadata = new AmazonLocationServiceMetadata();
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrackerConsumer service method.</param>
        /// 
        /// <returns>The response from the AssociateTrackerConsumer service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Creates an association between a geofence collection and a tracker resource. This
        /// allows the tracker resource to communicate location data to the linked geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrackerConsumer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTrackerConsumer service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/AssociateTrackerConsumer">REST API Reference for AssociateTrackerConsumer Operation</seealso>
        public virtual Task<AssociateTrackerConsumerResponse> AssociateTrackerConsumerAsync(AssociateTrackerConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTrackerConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrackerConsumerResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateTrackerConsumerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteGeofence


        /// <summary>
        /// Deletes a batch of geofences from a geofence collection.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You can't undo this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteGeofence service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Deletes a batch of geofences from a geofence collection.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You can't undo this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteGeofence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchDeleteGeofence">REST API Reference for BatchDeleteGeofence Operation</seealso>
        public virtual Task<BatchDeleteGeofenceResponse> BatchDeleteGeofenceAsync(BatchDeleteGeofenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteGeofenceResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDeleteGeofenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchEvaluateGeofences


        /// <summary>
        /// Used in geofence monitoring. Evaluates device positions against the position of geofences
        /// in a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateGeofences service method.</param>
        /// 
        /// <returns>The response from the BatchEvaluateGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Used in geofence monitoring. Evaluates device positions against the position of geofences
        /// in a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateGeofences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchEvaluateGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchEvaluateGeofences">REST API Reference for BatchEvaluateGeofences Operation</seealso>
        public virtual Task<BatchEvaluateGeofencesResponse> BatchEvaluateGeofencesAsync(BatchEvaluateGeofencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchEvaluateGeofencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEvaluateGeofencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchEvaluateGeofencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetDevicePosition


        /// <summary>
        /// A batch request to retrieve device positions.
        /// 
        ///  <note> 
        /// <para>
        /// The response will return the device positions from the last 24 hours.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevicePosition service method.</param>
        /// 
        /// <returns>The response from the BatchGetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// A batch request to retrieve device positions.
        /// 
        ///  <note> 
        /// <para>
        /// The response will return the device positions from the last 24 hours.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevicePosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchGetDevicePosition">REST API Reference for BatchGetDevicePosition Operation</seealso>
        public virtual Task<BatchGetDevicePositionResponse> BatchGetDevicePositionAsync(BatchGetDevicePositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDevicePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDevicePositionResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetDevicePositionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchPutGeofence


        /// <summary>
        /// A batch request for storing geofences into a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutGeofence service method.</param>
        /// 
        /// <returns>The response from the BatchPutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// A batch request for storing geofences into a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutGeofence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchPutGeofence">REST API Reference for BatchPutGeofence Operation</seealso>
        public virtual Task<BatchPutGeofenceResponse> BatchPutGeofenceAsync(BatchPutGeofenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutGeofenceResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchPutGeofenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchUpdateDevicePosition


        /// <summary>
        /// Uploads a position update for one or more devices to a tracker resource. The data
        /// is used for API queries requesting the device position and position history.
        /// 
        ///  <note> 
        /// <para>
        /// Limitation — Location data is sampled at a fixed rate of 1 position per 30 second
        /// interval, and retained for 1 year before it is deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDevicePosition service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Uploads a position update for one or more devices to a tracker resource. The data
        /// is used for API queries requesting the device position and position history.
        /// 
        ///  <note> 
        /// <para>
        /// Limitation — Location data is sampled at a fixed rate of 1 position per 30 second
        /// interval, and retained for 1 year before it is deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDevicePosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/BatchUpdateDevicePosition">REST API Reference for BatchUpdateDevicePosition Operation</seealso>
        public virtual Task<BatchUpdateDevicePositionResponse> BatchUpdateDevicePositionAsync(BatchUpdateDevicePositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateDevicePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateDevicePositionResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchUpdateDevicePositionResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Creates a geofence collection, which manages and stores geofences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeofenceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateGeofenceCollection">REST API Reference for CreateGeofenceCollection Operation</seealso>
        public virtual Task<CreateGeofenceCollectionResponse> CreateGeofenceCollectionAsync(CreateGeofenceCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGeofenceCollectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGeofenceCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMap


        /// <summary>
        /// Creates a map resource in your AWS account, which provides map tiles of different
        /// styles sourced from global location data providers.
        /// 
        ///  <note> 
        /// <para>
        /// By using Maps, you agree that AWS may transmit your API queries to your selected third
        /// party provider for processing, which may be outside the AWS region you are currently
        /// using. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMap service method.</param>
        /// 
        /// <returns>The response from the CreateMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Creates a map resource in your AWS account, which provides map tiles of different
        /// styles sourced from global location data providers.
        /// 
        ///  <note> 
        /// <para>
        /// By using Maps, you agree that AWS may transmit your API queries to your selected third
        /// party provider for processing, which may be outside the AWS region you are currently
        /// using. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateMap">REST API Reference for CreateMap Operation</seealso>
        public virtual Task<CreateMapResponse> CreateMapAsync(CreateMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMapResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMapResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlaceIndex


        /// <summary>
        /// Creates a Place index resource in your AWS account, which supports Places functions
        /// with geospatial data sourced from your chosen data provider.
        /// 
        ///  <note> 
        /// <para>
        /// By using Places, you agree that AWS may transmit your API queries to your selected
        /// third party provider for processing, which may be outside the AWS region you are currently
        /// using. 
        /// </para>
        ///  
        /// <para>
        /// Because of licensing limitations, you may not use HERE to store results for locations
        /// in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the CreatePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Creates a Place index resource in your AWS account, which supports Places functions
        /// with geospatial data sourced from your chosen data provider.
        /// 
        ///  <note> 
        /// <para>
        /// By using Places, you agree that AWS may transmit your API queries to your selected
        /// third party provider for processing, which may be outside the AWS region you are currently
        /// using. 
        /// </para>
        ///  
        /// <para>
        /// Because of licensing limitations, you may not use HERE to store results for locations
        /// in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlaceIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreatePlaceIndex">REST API Reference for CreatePlaceIndex Operation</seealso>
        public virtual Task<CreatePlaceIndexResponse> CreatePlaceIndexAsync(CreatePlaceIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlaceIndexResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePlaceIndexResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Creates a tracker resource in your AWS account, which lets you retrieve current and
        /// historical location of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTracker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/CreateTracker">REST API Reference for CreateTracker Operation</seealso>
        public virtual Task<CreateTrackerResponse> CreateTrackerAsync(CreateTrackerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrackerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTrackerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGeofenceCollection


        /// <summary>
        /// Deletes a geofence collection from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You can't undo this action. If the geofence
        /// collection is the target of a tracker resource, the devices will no longer be monitored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeofenceCollection service method.</param>
        /// 
        /// <returns>The response from the DeleteGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Deletes a geofence collection from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You can't undo this action. If the geofence
        /// collection is the target of a tracker resource, the devices will no longer be monitored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeofenceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteGeofenceCollection">REST API Reference for DeleteGeofenceCollection Operation</seealso>
        public virtual Task<DeleteGeofenceCollectionResponse> DeleteGeofenceCollectionAsync(DeleteGeofenceCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGeofenceCollectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteGeofenceCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMap


        /// <summary>
        /// Deletes a map resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You cannot undo this action. If the
        /// map is being used in an application, the map may not render.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMap service method.</param>
        /// 
        /// <returns>The response from the DeleteMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Deletes a map resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You cannot undo this action. If the
        /// map is being used in an application, the map may not render.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteMap">REST API Reference for DeleteMap Operation</seealso>
        public virtual Task<DeleteMapResponse> DeleteMapAsync(DeleteMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMapResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMapResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePlaceIndex


        /// <summary>
        /// Deletes a Place index resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You cannot undo this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the DeletePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Deletes a Place index resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You cannot undo this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaceIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeletePlaceIndex">REST API Reference for DeletePlaceIndex Operation</seealso>
        public virtual Task<DeletePlaceIndexResponse> DeletePlaceIndexAsync(DeletePlaceIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaceIndexResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePlaceIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTracker


        /// <summary>
        /// Deletes a tracker resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You can't undo this action. If the tracker
        /// resource is in use, you may encounter an error. Make sure that the target resource
        /// is not a dependency for your applications.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTracker service method.</param>
        /// 
        /// <returns>The response from the DeleteTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Deletes a tracker resource from your AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action deletes the resource permanently. You can't undo this action. If the tracker
        /// resource is in use, you may encounter an error. Make sure that the target resource
        /// is not a dependency for your applications.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTracker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DeleteTracker">REST API Reference for DeleteTracker Operation</seealso>
        public virtual Task<DeleteTrackerResponse> DeleteTrackerAsync(DeleteTrackerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrackerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTrackerResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Retrieves the geofence collection details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeofenceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGeofenceCollection service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeGeofenceCollection">REST API Reference for DescribeGeofenceCollection Operation</seealso>
        public virtual Task<DescribeGeofenceCollectionResponse> DescribeGeofenceCollectionAsync(DescribeGeofenceCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGeofenceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGeofenceCollectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeGeofenceCollectionResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Retrieves the map resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMap service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeMap">REST API Reference for DescribeMap Operation</seealso>
        public virtual Task<DescribeMapResponse> DescribeMapAsync(DescribeMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMapResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMapResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePlaceIndex


        /// <summary>
        /// Retrieves the Place index resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlaceIndex service method.</param>
        /// 
        /// <returns>The response from the DescribePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Retrieves the Place index resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlaceIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlaceIndex service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribePlaceIndex">REST API Reference for DescribePlaceIndex Operation</seealso>
        public virtual Task<DescribePlaceIndexResponse> DescribePlaceIndexAsync(DescribePlaceIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlaceIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlaceIndexResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePlaceIndexResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Retrieves the tracker resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTracker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTracker service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DescribeTracker">REST API Reference for DescribeTracker Operation</seealso>
        public virtual Task<DescribeTrackerResponse> DescribeTrackerAsync(DescribeTrackerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrackerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTrackerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateTrackerConsumer


        /// <summary>
        /// Removes the association bewteen a tracker resource and a geofence collection.
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Removes the association bewteen a tracker resource and a geofence collection.
        /// 
        ///  <note> 
        /// <para>
        /// Once you unlink a tracker resource from a geofence collection, the tracker positions
        /// will no longer be automatically evaluated against geofences.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrackerConsumer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTrackerConsumer service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/DisassociateTrackerConsumer">REST API Reference for DisassociateTrackerConsumer Operation</seealso>
        public virtual Task<DisassociateTrackerConsumerResponse> DisassociateTrackerConsumerAsync(DisassociateTrackerConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTrackerConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrackerConsumerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateTrackerConsumerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevicePosition


        /// <summary>
        /// Retrieves the latest device position.
        /// 
        ///  <note> 
        /// <para>
        /// Limitation — Device positions are deleted after one year.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePosition service method.</param>
        /// 
        /// <returns>The response from the GetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Retrieves the latest device position.
        /// 
        ///  <note> 
        /// <para>
        /// Limitation — Device positions are deleted after one year.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevicePosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePosition">REST API Reference for GetDevicePosition Operation</seealso>
        public virtual Task<GetDevicePositionResponse> GetDevicePositionAsync(GetDevicePositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePositionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDevicePositionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevicePositionHistory


        /// <summary>
        /// Retrieves the device position history from a tracker resource within a specified range
        /// of time.
        /// 
        ///  <note> 
        /// <para>
        /// Limitation — Device positions are deleted after one year.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePositionHistory service method.</param>
        /// 
        /// <returns>The response from the GetDevicePositionHistory service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Retrieves the device position history from a tracker resource within a specified range
        /// of time.
        /// 
        ///  <note> 
        /// <para>
        /// Limitation — Device positions are deleted after one year.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePositionHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevicePositionHistory service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetDevicePositionHistory">REST API Reference for GetDevicePositionHistory Operation</seealso>
        public virtual Task<GetDevicePositionHistoryResponse> GetDevicePositionHistoryAsync(GetDevicePositionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicePositionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicePositionHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDevicePositionHistoryResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Retrieves the geofence details from a geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeofence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetGeofence">REST API Reference for GetGeofence Operation</seealso>
        public virtual Task<GetGeofenceResponse> GetGeofenceAsync(GetGeofenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeofenceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGeofenceResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Retrieves glyphs used to display labels on a map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapGlyphs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMapGlyphs service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapGlyphs">REST API Reference for GetMapGlyphs Operation</seealso>
        public virtual Task<GetMapGlyphsResponse> GetMapGlyphsAsync(GetMapGlyphsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapGlyphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapGlyphsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMapGlyphsResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Retrieves the sprite sheet corresponding to a map resource. The sprite sheet is a
        /// PNG image paired with a JSON document describing the offsets of individual icons that
        /// will be displayed on a rendered map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapSprites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMapSprites service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapSprites">REST API Reference for GetMapSprites Operation</seealso>
        public virtual Task<GetMapSpritesResponse> GetMapSpritesAsync(GetMapSpritesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapSpritesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapSpritesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMapSpritesResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMapStyleDescriptor service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapStyleDescriptor">REST API Reference for GetMapStyleDescriptor Operation</seealso>
        public virtual Task<GetMapStyleDescriptorResponse> GetMapStyleDescriptorAsync(GetMapStyleDescriptorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapStyleDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapStyleDescriptorResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMapStyleDescriptorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMapTile


        /// <summary>
        /// Retrieves a vector data tile from the map resource. Map tiles are used by clients
        /// to render a map. They are addressed using a grid arrangement with an X coordinate,
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Retrieves a vector data tile from the map resource. Map tiles are used by clients
        /// to render a map. They are addressed using a grid arrangement with an X coordinate,
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMapTile service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/GetMapTile">REST API Reference for GetMapTile Operation</seealso>
        public virtual Task<GetMapTileResponse> GetMapTileAsync(GetMapTileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMapTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMapTileResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMapTileResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Lists geofence collections in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeofenceCollections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeofenceCollections service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofenceCollections">REST API Reference for ListGeofenceCollections Operation</seealso>
        public virtual Task<ListGeofenceCollectionsResponse> ListGeofenceCollectionsAsync(ListGeofenceCollectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeofenceCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeofenceCollectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGeofenceCollectionsResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Lists geofences stored in a given geofence collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeofences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeofences service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListGeofences">REST API Reference for ListGeofences Operation</seealso>
        public virtual Task<ListGeofencesResponse> ListGeofencesAsync(ListGeofencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeofencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeofencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGeofencesResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Lists map resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMaps service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListMaps">REST API Reference for ListMaps Operation</seealso>
        public virtual Task<ListMapsResponse> ListMapsAsync(ListMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMapsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMapsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlaceIndexes


        /// <summary>
        /// Lists Place index resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaceIndexes service method.</param>
        /// 
        /// <returns>The response from the ListPlaceIndexes service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Lists Place index resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaceIndexes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlaceIndexes service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListPlaceIndexes">REST API Reference for ListPlaceIndexes Operation</seealso>
        public virtual Task<ListPlaceIndexesResponse> ListPlaceIndexesAsync(ListPlaceIndexesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaceIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaceIndexesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPlaceIndexesResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Lists geofence collections currently associated to the given tracker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrackerConsumers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrackerConsumers service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackerConsumers">REST API Reference for ListTrackerConsumers Operation</seealso>
        public virtual Task<ListTrackerConsumersResponse> ListTrackerConsumersAsync(ListTrackerConsumersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrackerConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrackerConsumersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTrackerConsumersResponse>(request, options, cancellationToken);
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
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Lists tracker resources in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrackers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrackers service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/ListTrackers">REST API Reference for ListTrackers Operation</seealso>
        public virtual Task<ListTrackersResponse> ListTrackersAsync(ListTrackersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrackersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrackersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTrackersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutGeofence


        /// <summary>
        /// Stores a geofence to a given geofence collection, or updates the geometry of an existing
        /// geofence if a geofence ID is included in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGeofence service method.</param>
        /// 
        /// <returns>The response from the PutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Stores a geofence to a given geofence collection, or updates the geometry of an existing
        /// geofence if a geofence ID is included in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGeofence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutGeofence service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ConflictException">
        /// The request was unsuccessful due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/PutGeofence">REST API Reference for PutGeofence Operation</seealso>
        public virtual Task<PutGeofenceResponse> PutGeofenceAsync(PutGeofenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGeofenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGeofenceResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutGeofenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchPlaceIndexForPosition


        /// <summary>
        /// Reverse geocodes a given coordinate and returns a legible address. Allows you to search
        /// for Places or points of interest near a given position.
        /// 
        ///  <note> 
        /// <para>
        /// By using Places, you agree that AWS may transmit your API queries to your selected
        /// third party provider for processing, which may be outside the AWS region you are currently
        /// using. 
        /// </para>
        ///  
        /// <para>
        /// Because of licensing limitations, you may not use HERE to store results for locations
        /// in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForPosition service method.</param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForPosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Reverse geocodes a given coordinate and returns a legible address. Allows you to search
        /// for Places or points of interest near a given position.
        /// 
        ///  <note> 
        /// <para>
        /// By using Places, you agree that AWS may transmit your API queries to your selected
        /// third party provider for processing, which may be outside the AWS region you are currently
        /// using. 
        /// </para>
        ///  
        /// <para>
        /// Because of licensing limitations, you may not use HERE to store results for locations
        /// in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForPosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForPosition service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForPosition">REST API Reference for SearchPlaceIndexForPosition Operation</seealso>
        public virtual Task<SearchPlaceIndexForPositionResponse> SearchPlaceIndexForPositionAsync(SearchPlaceIndexForPositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchPlaceIndexForPositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchPlaceIndexForPositionResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchPlaceIndexForPositionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchPlaceIndexForText


        /// <summary>
        /// Geocodes free-form text, such as an address, name, city, or region to allow you to
        /// search for Places or points of interest. 
        /// 
        ///  
        /// <para>
        /// Includes the option to apply additional parameters to narrow your list of results.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can search for places near a given position using <code>BiasPosition</code>, or
        /// filter results within a bounding box using <code>FilterBBox</code>. Providing both
        /// parameters simultaneously returns an error.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// By using Places, you agree that AWS may transmit your API queries to your selected
        /// third party provider for processing, which may be outside the AWS region you are currently
        /// using. 
        /// </para>
        ///  
        /// <para>
        /// Also, when using HERE as your data provider, you may not (a) use HERE Places for Asset
        /// Management, or (b) select the <code>Storage</code> option for the <code>IntendedUse</code>
        /// parameter when requesting Places in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForText service method.</param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForText service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
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
        /// Geocodes free-form text, such as an address, name, city, or region to allow you to
        /// search for Places or points of interest. 
        /// 
        ///  
        /// <para>
        /// Includes the option to apply additional parameters to narrow your list of results.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can search for places near a given position using <code>BiasPosition</code>, or
        /// filter results within a bounding box using <code>FilterBBox</code>. Providing both
        /// parameters simultaneously returns an error.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// By using Places, you agree that AWS may transmit your API queries to your selected
        /// third party provider for processing, which may be outside the AWS region you are currently
        /// using. 
        /// </para>
        ///  
        /// <para>
        /// Also, when using HERE as your data provider, you may not (a) use HERE Places for Asset
        /// Management, or (b) select the <code>Storage</code> option for the <code>IntendedUse</code>
        /// parameter when requesting Places in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPlaceIndexForText service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchPlaceIndexForText service method, as returned by LocationService.</returns>
        /// <exception cref="Amazon.LocationService.Model.AccessDeniedException">
        /// The request was denied due to insufficient access or permission. Check with an administrator
        /// to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.InternalServerException">
        /// The request has failed to process because of an unknown server error, exception, or
        /// failure.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ResourceNotFoundException">
        /// The resource that you've entered was not found in your AWS account.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LocationService.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/location-2020-11-19/SearchPlaceIndexForText">REST API Reference for SearchPlaceIndexForText Operation</seealso>
        public virtual Task<SearchPlaceIndexForTextResponse> SearchPlaceIndexForTextAsync(SearchPlaceIndexForTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchPlaceIndexForTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchPlaceIndexForTextResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchPlaceIndexForTextResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}