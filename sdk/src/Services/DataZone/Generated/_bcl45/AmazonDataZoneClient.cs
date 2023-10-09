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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DataZone.Model;
using Amazon.DataZone.Model.Internal.MarshallTransformations;
using Amazon.DataZone.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DataZone
{
    /// <summary>
    /// Implementation for accessing DataZone
    ///
    /// Amazon DataZone is a data management service that enables you to catalog, discover,
    /// govern, share, and analyze your data. With Amazon DataZone, you can share and access
    /// your data across accounts and supported regions. Amazon DataZone simplifies your experience
    /// across Amazon Web Services services, including, but not limited to, Amazon Redshift,
    /// Amazon Athena, Amazon Web Services Glue, and Amazon Web Services Lake Formation.
    /// </summary>
    public partial class AmazonDataZoneClient : AmazonServiceClient, IAmazonDataZone
    {
        private static IServiceMetadata serviceMetadata = new AmazonDataZoneMetadata();
        private IDataZonePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDataZonePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DataZonePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonDataZoneClient with the credentials loaded from the application's
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
        public AmazonDataZoneClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataZoneConfig()) { }

        /// <summary>
        /// Constructs AmazonDataZoneClient with the credentials loaded from the application's
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
        public AmazonDataZoneClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataZoneConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDataZoneClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(AmazonDataZoneConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataZoneClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataZoneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataZoneClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataZoneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Credentials and an
        /// AmazonDataZoneClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(AWSCredentials credentials, AmazonDataZoneConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataZoneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataZoneConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataZoneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataZoneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataZoneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataZoneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataZoneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataZoneConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDataZoneEndpointResolver());
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


        #region  AcceptPredictions


        /// <summary>
        /// Accepts automatically generated business-friendly metadata for your Amazon DataZone
        /// assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPredictions service method.</param>
        /// 
        /// <returns>The response from the AcceptPredictions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptPredictions">REST API Reference for AcceptPredictions Operation</seealso>
        public virtual AcceptPredictionsResponse AcceptPredictions(AcceptPredictionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPredictionsResponseUnmarshaller.Instance;

            return Invoke<AcceptPredictionsResponse>(request, options);
        }


        /// <summary>
        /// Accepts automatically generated business-friendly metadata for your Amazon DataZone
        /// assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPredictions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptPredictions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptPredictions">REST API Reference for AcceptPredictions Operation</seealso>
        public virtual Task<AcceptPredictionsResponse> AcceptPredictionsAsync(AcceptPredictionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPredictionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptPredictionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AcceptSubscriptionRequest


        /// <summary>
        /// Accepts a subscription request to a specific asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptSubscriptionRequest service method.</param>
        /// 
        /// <returns>The response from the AcceptSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptSubscriptionRequest">REST API Reference for AcceptSubscriptionRequest Operation</seealso>
        public virtual AcceptSubscriptionRequestResponse AcceptSubscriptionRequest(AcceptSubscriptionRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<AcceptSubscriptionRequestResponse>(request, options);
        }


        /// <summary>
        /// Accepts a subscription request to a specific asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptSubscriptionRequest">REST API Reference for AcceptSubscriptionRequest Operation</seealso>
        public virtual Task<AcceptSubscriptionRequestResponse> AcceptSubscriptionRequestAsync(AcceptSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSubscriptionRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptSubscriptionRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelSubscription


        /// <summary>
        /// Cancels the subscription to the specified asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription service method.</param>
        /// 
        /// <returns>The response from the CancelSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        public virtual CancelSubscriptionResponse CancelSubscription(CancelSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CancelSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Cancels the subscription to the specified asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        public virtual Task<CancelSubscriptionResponse> CancelSubscriptionAsync(CancelSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAsset


        /// <summary>
        /// Creates an asset in Amazon DataZone catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// 
        /// <returns>The response from the CreateAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual CreateAssetResponse CreateAsset(CreateAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return Invoke<CreateAssetResponse>(request, options);
        }


        /// <summary>
        /// Creates an asset in Amazon DataZone catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual Task<CreateAssetResponse> CreateAssetAsync(CreateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAssetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAssetRevision


        /// <summary>
        /// Creates a revision of the asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetRevision service method.</param>
        /// 
        /// <returns>The response from the CreateAssetRevision service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetRevision">REST API Reference for CreateAssetRevision Operation</seealso>
        public virtual CreateAssetRevisionResponse CreateAssetRevision(CreateAssetRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetRevisionResponseUnmarshaller.Instance;

            return Invoke<CreateAssetRevisionResponse>(request, options);
        }


        /// <summary>
        /// Creates a revision of the asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssetRevision service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetRevision">REST API Reference for CreateAssetRevision Operation</seealso>
        public virtual Task<CreateAssetRevisionResponse> CreateAssetRevisionAsync(CreateAssetRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAssetRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAssetType


        /// <summary>
        /// Creates a custom asset type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetType service method.</param>
        /// 
        /// <returns>The response from the CreateAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetType">REST API Reference for CreateAssetType Operation</seealso>
        public virtual CreateAssetTypeResponse CreateAssetType(CreateAssetTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetTypeResponseUnmarshaller.Instance;

            return Invoke<CreateAssetTypeResponse>(request, options);
        }


        /// <summary>
        /// Creates a custom asset type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetType">REST API Reference for CreateAssetType Operation</seealso>
        public virtual Task<CreateAssetTypeResponse> CreateAssetTypeAsync(CreateAssetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAssetTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataSource


        /// <summary>
        /// Creates an Amazon DataZone data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }


        /// <summary>
        /// Creates an Amazon DataZone data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates an Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }


        /// <summary>
        /// Creates an Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironment


        /// <summary>
        /// Create an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Create an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironmentProfile


        /// <summary>
        /// Creates an Amazon DataZone environment profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentProfile service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentProfile">REST API Reference for CreateEnvironmentProfile Operation</seealso>
        public virtual CreateEnvironmentProfileResponse CreateEnvironmentProfile(CreateEnvironmentProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentProfileResponse>(request, options);
        }


        /// <summary>
        /// Creates an Amazon DataZone environment profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentProfile">REST API Reference for CreateEnvironmentProfile Operation</seealso>
        public virtual Task<CreateEnvironmentProfileResponse> CreateEnvironmentProfileAsync(CreateEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEnvironmentProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFormType


        /// <summary>
        /// Creates a metadata form type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFormType service method.</param>
        /// 
        /// <returns>The response from the CreateFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateFormType">REST API Reference for CreateFormType Operation</seealso>
        public virtual CreateFormTypeResponse CreateFormType(CreateFormTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFormTypeResponseUnmarshaller.Instance;

            return Invoke<CreateFormTypeResponse>(request, options);
        }


        /// <summary>
        /// Creates a metadata form type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFormType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateFormType">REST API Reference for CreateFormType Operation</seealso>
        public virtual Task<CreateFormTypeResponse> CreateFormTypeAsync(CreateFormTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFormTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFormTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGlossary


        /// <summary>
        /// Creates an Amazon DataZone business glossary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossary service method.</param>
        /// 
        /// <returns>The response from the CreateGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossary">REST API Reference for CreateGlossary Operation</seealso>
        public virtual CreateGlossaryResponse CreateGlossary(CreateGlossaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryResponseUnmarshaller.Instance;

            return Invoke<CreateGlossaryResponse>(request, options);
        }


        /// <summary>
        /// Creates an Amazon DataZone business glossary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossary">REST API Reference for CreateGlossary Operation</seealso>
        public virtual Task<CreateGlossaryResponse> CreateGlossaryAsync(CreateGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGlossaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGlossaryTerm


        /// <summary>
        /// Creates a business glossary term.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossaryTerm service method.</param>
        /// 
        /// <returns>The response from the CreateGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossaryTerm">REST API Reference for CreateGlossaryTerm Operation</seealso>
        public virtual CreateGlossaryTermResponse CreateGlossaryTerm(CreateGlossaryTermRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<CreateGlossaryTermResponse>(request, options);
        }


        /// <summary>
        /// Creates a business glossary term.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossaryTerm">REST API Reference for CreateGlossaryTerm Operation</seealso>
        public virtual Task<CreateGlossaryTermResponse> CreateGlossaryTermAsync(CreateGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryTermResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGlossaryTermResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGroupProfile


        /// <summary>
        /// Creates a group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupProfile service method.</param>
        /// 
        /// <returns>The response from the CreateGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGroupProfile">REST API Reference for CreateGroupProfile Operation</seealso>
        public virtual CreateGroupProfileResponse CreateGroupProfile(CreateGroupProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupProfileResponseUnmarshaller.Instance;

            return Invoke<CreateGroupProfileResponse>(request, options);
        }


        /// <summary>
        /// Creates a group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGroupProfile">REST API Reference for CreateGroupProfile Operation</seealso>
        public virtual Task<CreateGroupProfileResponse> CreateGroupProfileAsync(CreateGroupProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGroupProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateListingChangeSet


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListingChangeSet service method.</param>
        /// 
        /// <returns>The response from the CreateListingChangeSet service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateListingChangeSet">REST API Reference for CreateListingChangeSet Operation</seealso>
        public virtual CreateListingChangeSetResponse CreateListingChangeSet(CreateListingChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateListingChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListingChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateListingChangeSetResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListingChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateListingChangeSet service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateListingChangeSet">REST API Reference for CreateListingChangeSet Operation</seealso>
        public virtual Task<CreateListingChangeSetResponse> CreateListingChangeSetAsync(CreateListingChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateListingChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListingChangeSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateListingChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates an Amazon DataZone project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }


        /// <summary>
        /// Creates an Amazon DataZone project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProjectMembership


        /// <summary>
        /// Creates a project membership in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectMembership service method.</param>
        /// 
        /// <returns>The response from the CreateProjectMembership service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectMembership">REST API Reference for CreateProjectMembership Operation</seealso>
        public virtual CreateProjectMembershipResponse CreateProjectMembership(CreateProjectMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateProjectMembershipResponse>(request, options);
        }


        /// <summary>
        /// Creates a project membership in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProjectMembership service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectMembership">REST API Reference for CreateProjectMembership Operation</seealso>
        public virtual Task<CreateProjectMembershipResponse> CreateProjectMembershipAsync(CreateProjectMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectMembershipResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProjectMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscriptionGrant


        /// <summary>
        /// Creates a subsscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionGrant service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionGrant">REST API Reference for CreateSubscriptionGrant Operation</seealso>
        public virtual CreateSubscriptionGrantResponse CreateSubscriptionGrant(CreateSubscriptionGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionGrantResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionGrantResponse>(request, options);
        }


        /// <summary>
        /// Creates a subsscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionGrant">REST API Reference for CreateSubscriptionGrant Operation</seealso>
        public virtual Task<CreateSubscriptionGrantResponse> CreateSubscriptionGrantAsync(CreateSubscriptionGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionGrantResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSubscriptionGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscriptionRequest


        /// <summary>
        /// Creates a subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionRequest service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionRequest">REST API Reference for CreateSubscriptionRequest Operation</seealso>
        public virtual CreateSubscriptionRequestResponse CreateSubscriptionRequest(CreateSubscriptionRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionRequestResponse>(request, options);
        }


        /// <summary>
        /// Creates a subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionRequest">REST API Reference for CreateSubscriptionRequest Operation</seealso>
        public virtual Task<CreateSubscriptionRequestResponse> CreateSubscriptionRequestAsync(CreateSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSubscriptionRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscriptionTarget


        /// <summary>
        /// Creates a subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionTarget service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionTarget">REST API Reference for CreateSubscriptionTarget Operation</seealso>
        public virtual CreateSubscriptionTargetResponse CreateSubscriptionTarget(CreateSubscriptionTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionTargetResponse>(request, options);
        }


        /// <summary>
        /// Creates a subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionTarget">REST API Reference for CreateSubscriptionTarget Operation</seealso>
        public virtual Task<CreateSubscriptionTargetResponse> CreateSubscriptionTargetAsync(CreateSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSubscriptionTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUserProfile


        /// <summary>
        /// Creates a user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return Invoke<CreateUserProfileResponse>(request, options);
        }


        /// <summary>
        /// Creates a user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAsset


        /// <summary>
        /// Delets an asset in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual DeleteAssetResponse DeleteAsset(DeleteAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetResponse>(request, options);
        }


        /// <summary>
        /// Delets an asset in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAssetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssetType


        /// <summary>
        /// Deletes an asset type in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetType service method.</param>
        /// 
        /// <returns>The response from the DeleteAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetType">REST API Reference for DeleteAssetType Operation</seealso>
        public virtual DeleteAssetTypeResponse DeleteAssetType(DeleteAssetTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetTypeResponse>(request, options);
        }


        /// <summary>
        /// Deletes an asset type in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetType">REST API Reference for DeleteAssetType Operation</seealso>
        public virtual Task<DeleteAssetTypeResponse> DeleteAssetTypeAsync(DeleteAssetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAssetTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataSource


        /// <summary>
        /// Deletes a data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Deletes a Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironment


        /// <summary>
        /// Deletes an environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Deletes an environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironmentBlueprintConfiguration


        /// <summary>
        /// Deletes the blueprint configuration in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentBlueprintConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprintConfiguration">REST API Reference for DeleteEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual DeleteEnvironmentBlueprintConfigurationResponse DeleteEnvironmentBlueprintConfiguration(DeleteEnvironmentBlueprintConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentBlueprintConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the blueprint configuration in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentBlueprintConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprintConfiguration">REST API Reference for DeleteEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual Task<DeleteEnvironmentBlueprintConfigurationResponse> DeleteEnvironmentBlueprintConfigurationAsync(DeleteEnvironmentBlueprintConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEnvironmentBlueprintConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironmentProfile


        /// <summary>
        /// Deletes an environment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentProfile">REST API Reference for DeleteEnvironmentProfile Operation</seealso>
        public virtual DeleteEnvironmentProfileResponse DeleteEnvironmentProfile(DeleteEnvironmentProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentProfileResponse>(request, options);
        }


        /// <summary>
        /// Deletes an environment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentProfile">REST API Reference for DeleteEnvironmentProfile Operation</seealso>
        public virtual Task<DeleteEnvironmentProfileResponse> DeleteEnvironmentProfileAsync(DeleteEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEnvironmentProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFormType


        /// <summary>
        /// Delets and metadata form type in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFormType service method.</param>
        /// 
        /// <returns>The response from the DeleteFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteFormType">REST API Reference for DeleteFormType Operation</seealso>
        public virtual DeleteFormTypeResponse DeleteFormType(DeleteFormTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFormTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteFormTypeResponse>(request, options);
        }


        /// <summary>
        /// Delets and metadata form type in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFormType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteFormType">REST API Reference for DeleteFormType Operation</seealso>
        public virtual Task<DeleteFormTypeResponse> DeleteFormTypeAsync(DeleteFormTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFormTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFormTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGlossary


        /// <summary>
        /// Deletes a business glossary in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossary service method.</param>
        /// 
        /// <returns>The response from the DeleteGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossary">REST API Reference for DeleteGlossary Operation</seealso>
        public virtual DeleteGlossaryResponse DeleteGlossary(DeleteGlossaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryResponseUnmarshaller.Instance;

            return Invoke<DeleteGlossaryResponse>(request, options);
        }


        /// <summary>
        /// Deletes a business glossary in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossary">REST API Reference for DeleteGlossary Operation</seealso>
        public virtual Task<DeleteGlossaryResponse> DeleteGlossaryAsync(DeleteGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteGlossaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGlossaryTerm


        /// <summary>
        /// Deletes a business glossary term in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossaryTerm service method.</param>
        /// 
        /// <returns>The response from the DeleteGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossaryTerm">REST API Reference for DeleteGlossaryTerm Operation</seealso>
        public virtual DeleteGlossaryTermResponse DeleteGlossaryTerm(DeleteGlossaryTermRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<DeleteGlossaryTermResponse>(request, options);
        }


        /// <summary>
        /// Deletes a business glossary term in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossaryTerm">REST API Reference for DeleteGlossaryTerm Operation</seealso>
        public virtual Task<DeleteGlossaryTermResponse> DeleteGlossaryTermAsync(DeleteGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryTermResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteGlossaryTermResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteListing


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListing service method.</param>
        /// 
        /// <returns>The response from the DeleteListing service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteListing">REST API Reference for DeleteListing Operation</seealso>
        public virtual DeleteListingResponse DeleteListing(DeleteListingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListingResponseUnmarshaller.Instance;

            return Invoke<DeleteListingResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteListing service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteListing">REST API Reference for DeleteListing Operation</seealso>
        public virtual Task<DeleteListingResponse> DeleteListingAsync(DeleteListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteListingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes a project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }


        /// <summary>
        /// Deletes a project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProjectMembership


        /// <summary>
        /// Deletes project membership in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteProjectMembership service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectMembership">REST API Reference for DeleteProjectMembership Operation</seealso>
        public virtual DeleteProjectMembershipResponse DeleteProjectMembership(DeleteProjectMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectMembershipResponse>(request, options);
        }


        /// <summary>
        /// Deletes project membership in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProjectMembership service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectMembership">REST API Reference for DeleteProjectMembership Operation</seealso>
        public virtual Task<DeleteProjectMembershipResponse> DeleteProjectMembershipAsync(DeleteProjectMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectMembershipResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProjectMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscriptionGrant


        /// <summary>
        /// Deletes and subscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionGrant">REST API Reference for DeleteSubscriptionGrant Operation</seealso>
        public virtual DeleteSubscriptionGrantResponse DeleteSubscriptionGrant(DeleteSubscriptionGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionGrantResponse>(request, options);
        }


        /// <summary>
        /// Deletes and subscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionGrant">REST API Reference for DeleteSubscriptionGrant Operation</seealso>
        public virtual Task<DeleteSubscriptionGrantResponse> DeleteSubscriptionGrantAsync(DeleteSubscriptionGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionGrantResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSubscriptionGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscriptionRequest


        /// <summary>
        /// Deletes a subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionRequest service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionRequest">REST API Reference for DeleteSubscriptionRequest Operation</seealso>
        public virtual DeleteSubscriptionRequestResponse DeleteSubscriptionRequest(DeleteSubscriptionRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionRequestResponse>(request, options);
        }


        /// <summary>
        /// Deletes a subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionRequest">REST API Reference for DeleteSubscriptionRequest Operation</seealso>
        public virtual Task<DeleteSubscriptionRequestResponse> DeleteSubscriptionRequestAsync(DeleteSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSubscriptionRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscriptionTarget


        /// <summary>
        /// Deletes a subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionTarget">REST API Reference for DeleteSubscriptionTarget Operation</seealso>
        public virtual DeleteSubscriptionTargetResponse DeleteSubscriptionTarget(DeleteSubscriptionTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionTargetResponse>(request, options);
        }


        /// <summary>
        /// Deletes a subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionTarget">REST API Reference for DeleteSubscriptionTarget Operation</seealso>
        public virtual Task<DeleteSubscriptionTargetResponse> DeleteSubscriptionTargetAsync(DeleteSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSubscriptionTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAsset


        /// <summary>
        /// Gets an Amazon DataZone asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsset service method.</param>
        /// 
        /// <returns>The response from the GetAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual GetAssetResponse GetAsset(GetAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetResponseUnmarshaller.Instance;

            return Invoke<GetAssetResponse>(request, options);
        }


        /// <summary>
        /// Gets an Amazon DataZone asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual Task<GetAssetResponse> GetAssetAsync(GetAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAssetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssetType


        /// <summary>
        /// Gets an Amazon DataZone asset type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetType service method.</param>
        /// 
        /// <returns>The response from the GetAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetType">REST API Reference for GetAssetType Operation</seealso>
        public virtual GetAssetTypeResponse GetAssetType(GetAssetTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetTypeResponseUnmarshaller.Instance;

            return Invoke<GetAssetTypeResponse>(request, options);
        }


        /// <summary>
        /// Gets an Amazon DataZone asset type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetType">REST API Reference for GetAssetType Operation</seealso>
        public virtual Task<GetAssetTypeResponse> GetAssetTypeAsync(GetAssetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAssetTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataSource


        /// <summary>
        /// Gets an Amazon DataZone data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }


        /// <summary>
        /// Gets an Amazon DataZone data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataSourceRun


        /// <summary>
        /// Gets an Amazon DataZone data source run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSourceRun service method.</param>
        /// 
        /// <returns>The response from the GetDataSourceRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSourceRun">REST API Reference for GetDataSourceRun Operation</seealso>
        public virtual GetDataSourceRunResponse GetDataSourceRun(GetDataSourceRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceRunResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceRunResponse>(request, options);
        }


        /// <summary>
        /// Gets an Amazon DataZone data source run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSourceRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSourceRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSourceRun">REST API Reference for GetDataSourceRun Operation</seealso>
        public virtual Task<GetDataSourceRunResponse> GetDataSourceRunAsync(GetDataSourceRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDataSourceRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomain


        /// <summary>
        /// Gets an Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual GetDomainResponse GetDomain(GetDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return Invoke<GetDomainResponse>(request, options);
        }


        /// <summary>
        /// Gets an Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnvironment


        /// <summary>
        /// Gets an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Gets an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnvironmentBlueprint


        /// <summary>
        /// Gets an Amazon DataZone blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprint service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprint">REST API Reference for GetEnvironmentBlueprint Operation</seealso>
        public virtual GetEnvironmentBlueprintResponse GetEnvironmentBlueprint(GetEnvironmentBlueprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentBlueprintResponse>(request, options);
        }


        /// <summary>
        /// Gets an Amazon DataZone blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprint">REST API Reference for GetEnvironmentBlueprint Operation</seealso>
        public virtual Task<GetEnvironmentBlueprintResponse> GetEnvironmentBlueprintAsync(GetEnvironmentBlueprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEnvironmentBlueprintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnvironmentBlueprintConfiguration


        /// <summary>
        /// Gets the blueprint configuration in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprintConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprintConfiguration">REST API Reference for GetEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual GetEnvironmentBlueprintConfigurationResponse GetEnvironmentBlueprintConfiguration(GetEnvironmentBlueprintConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentBlueprintConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Gets the blueprint configuration in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprintConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprintConfiguration">REST API Reference for GetEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual Task<GetEnvironmentBlueprintConfigurationResponse> GetEnvironmentBlueprintConfigurationAsync(GetEnvironmentBlueprintConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEnvironmentBlueprintConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnvironmentProfile


        /// <summary>
        /// Gets an evinronment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentProfile service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentProfile">REST API Reference for GetEnvironmentProfile Operation</seealso>
        public virtual GetEnvironmentProfileResponse GetEnvironmentProfile(GetEnvironmentProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentProfileResponse>(request, options);
        }


        /// <summary>
        /// Gets an evinronment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentProfile">REST API Reference for GetEnvironmentProfile Operation</seealso>
        public virtual Task<GetEnvironmentProfileResponse> GetEnvironmentProfileAsync(GetEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEnvironmentProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFormType


        /// <summary>
        /// Gets a metadata form type in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFormType service method.</param>
        /// 
        /// <returns>The response from the GetFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetFormType">REST API Reference for GetFormType Operation</seealso>
        public virtual GetFormTypeResponse GetFormType(GetFormTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFormTypeResponseUnmarshaller.Instance;

            return Invoke<GetFormTypeResponse>(request, options);
        }


        /// <summary>
        /// Gets a metadata form type in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFormType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetFormType">REST API Reference for GetFormType Operation</seealso>
        public virtual Task<GetFormTypeResponse> GetFormTypeAsync(GetFormTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFormTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFormTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGlossary


        /// <summary>
        /// Gets a business glossary in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlossary service method.</param>
        /// 
        /// <returns>The response from the GetGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossary">REST API Reference for GetGlossary Operation</seealso>
        public virtual GetGlossaryResponse GetGlossary(GetGlossaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryResponseUnmarshaller.Instance;

            return Invoke<GetGlossaryResponse>(request, options);
        }


        /// <summary>
        /// Gets a business glossary in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossary">REST API Reference for GetGlossary Operation</seealso>
        public virtual Task<GetGlossaryResponse> GetGlossaryAsync(GetGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGlossaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGlossaryTerm


        /// <summary>
        /// Gets a business glossary term in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlossaryTerm service method.</param>
        /// 
        /// <returns>The response from the GetGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossaryTerm">REST API Reference for GetGlossaryTerm Operation</seealso>
        public virtual GetGlossaryTermResponse GetGlossaryTerm(GetGlossaryTermRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<GetGlossaryTermResponse>(request, options);
        }


        /// <summary>
        /// Gets a business glossary term in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossaryTerm">REST API Reference for GetGlossaryTerm Operation</seealso>
        public virtual Task<GetGlossaryTermResponse> GetGlossaryTermAsync(GetGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryTermResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGlossaryTermResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroupProfile


        /// <summary>
        /// Gets a group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupProfile service method.</param>
        /// 
        /// <returns>The response from the GetGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGroupProfile">REST API Reference for GetGroupProfile Operation</seealso>
        public virtual GetGroupProfileResponse GetGroupProfile(GetGroupProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupProfileResponseUnmarshaller.Instance;

            return Invoke<GetGroupProfileResponse>(request, options);
        }


        /// <summary>
        /// Gets a group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGroupProfile">REST API Reference for GetGroupProfile Operation</seealso>
        public virtual Task<GetGroupProfileResponse> GetGroupProfileAsync(GetGroupProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGroupProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIamPortalLoginUrl


        /// <summary>
        /// Gets the data portal URL for the specified Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIamPortalLoginUrl service method.</param>
        /// 
        /// <returns>The response from the GetIamPortalLoginUrl service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetIamPortalLoginUrl">REST API Reference for GetIamPortalLoginUrl Operation</seealso>
        public virtual GetIamPortalLoginUrlResponse GetIamPortalLoginUrl(GetIamPortalLoginUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIamPortalLoginUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIamPortalLoginUrlResponseUnmarshaller.Instance;

            return Invoke<GetIamPortalLoginUrlResponse>(request, options);
        }


        /// <summary>
        /// Gets the data portal URL for the specified Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIamPortalLoginUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIamPortalLoginUrl service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetIamPortalLoginUrl">REST API Reference for GetIamPortalLoginUrl Operation</seealso>
        public virtual Task<GetIamPortalLoginUrlResponse> GetIamPortalLoginUrlAsync(GetIamPortalLoginUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIamPortalLoginUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIamPortalLoginUrlResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIamPortalLoginUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetListing


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListing service method.</param>
        /// 
        /// <returns>The response from the GetListing service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetListing">REST API Reference for GetListing Operation</seealso>
        public virtual GetListingResponse GetListing(GetListingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListingResponseUnmarshaller.Instance;

            return Invoke<GetListingResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetListing service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetListing">REST API Reference for GetListing Operation</seealso>
        public virtual Task<GetListingResponse> GetListingAsync(GetListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListingResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetListingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProject


        /// <summary>
        /// Gets a project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual GetProjectResponse GetProject(GetProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return Invoke<GetProjectResponse>(request, options);
        }


        /// <summary>
        /// Gets a project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSubscription


        /// <summary>
        /// Gets a subscription in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Gets a subscription in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionGrant


        /// <summary>
        /// Gets the subscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionGrant service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionGrant">REST API Reference for GetSubscriptionGrant Operation</seealso>
        public virtual GetSubscriptionGrantResponse GetSubscriptionGrant(GetSubscriptionGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionGrantResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionGrantResponse>(request, options);
        }


        /// <summary>
        /// Gets the subscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionGrant">REST API Reference for GetSubscriptionGrant Operation</seealso>
        public virtual Task<GetSubscriptionGrantResponse> GetSubscriptionGrantAsync(GetSubscriptionGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionGrantResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSubscriptionGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionRequestDetails


        /// <summary>
        /// Gets the details of the specified subscription request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionRequestDetails service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionRequestDetails service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionRequestDetails">REST API Reference for GetSubscriptionRequestDetails Operation</seealso>
        public virtual GetSubscriptionRequestDetailsResponse GetSubscriptionRequestDetails(GetSubscriptionRequestDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionRequestDetailsResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionRequestDetailsResponse>(request, options);
        }


        /// <summary>
        /// Gets the details of the specified subscription request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionRequestDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionRequestDetails service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionRequestDetails">REST API Reference for GetSubscriptionRequestDetails Operation</seealso>
        public virtual Task<GetSubscriptionRequestDetailsResponse> GetSubscriptionRequestDetailsAsync(GetSubscriptionRequestDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionRequestDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSubscriptionRequestDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionTarget


        /// <summary>
        /// Gets the subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionTarget service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionTarget">REST API Reference for GetSubscriptionTarget Operation</seealso>
        public virtual GetSubscriptionTargetResponse GetSubscriptionTarget(GetSubscriptionTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionTargetResponse>(request, options);
        }


        /// <summary>
        /// Gets the subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionTarget">REST API Reference for GetSubscriptionTarget Operation</seealso>
        public virtual Task<GetSubscriptionTargetResponse> GetSubscriptionTargetAsync(GetSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSubscriptionTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserProfile


        /// <summary>
        /// Gets a user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserProfile service method.</param>
        /// 
        /// <returns>The response from the GetUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetUserProfile">REST API Reference for GetUserProfile Operation</seealso>
        public virtual GetUserProfileResponse GetUserProfile(GetUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserProfileResponseUnmarshaller.Instance;

            return Invoke<GetUserProfileResponse>(request, options);
        }


        /// <summary>
        /// Gets a user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetUserProfile">REST API Reference for GetUserProfile Operation</seealso>
        public virtual Task<GetUserProfileResponse> GetUserProfileAsync(GetUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssetRevisions


        /// <summary>
        /// Lists the revisions for the asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetRevisions service method.</param>
        /// 
        /// <returns>The response from the ListAssetRevisions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetRevisions">REST API Reference for ListAssetRevisions Operation</seealso>
        public virtual ListAssetRevisionsResponse ListAssetRevisions(ListAssetRevisionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListAssetRevisionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the revisions for the asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetRevisions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetRevisions">REST API Reference for ListAssetRevisions Operation</seealso>
        public virtual Task<ListAssetRevisionsResponse> ListAssetRevisionsAsync(ListAssetRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRevisionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssetRevisionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSourceRunActivities


        /// <summary>
        /// Lists data source run activities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRunActivities service method.</param>
        /// 
        /// <returns>The response from the ListDataSourceRunActivities service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRunActivities">REST API Reference for ListDataSourceRunActivities Operation</seealso>
        public virtual ListDataSourceRunActivitiesResponse ListDataSourceRunActivities(ListDataSourceRunActivitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunActivitiesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourceRunActivitiesResponse>(request, options);
        }


        /// <summary>
        /// Lists data source run activities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRunActivities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSourceRunActivities service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRunActivities">REST API Reference for ListDataSourceRunActivities Operation</seealso>
        public virtual Task<ListDataSourceRunActivitiesResponse> ListDataSourceRunActivitiesAsync(ListDataSourceRunActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunActivitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataSourceRunActivitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSourceRuns


        /// <summary>
        /// Lists data source runs in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRuns service method.</param>
        /// 
        /// <returns>The response from the ListDataSourceRuns service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRuns">REST API Reference for ListDataSourceRuns Operation</seealso>
        public virtual ListDataSourceRunsResponse ListDataSourceRuns(ListDataSourceRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunsResponseUnmarshaller.Instance;

            return Invoke<ListDataSourceRunsResponse>(request, options);
        }


        /// <summary>
        /// Lists data source runs in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSourceRuns service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRuns">REST API Reference for ListDataSourceRuns Operation</seealso>
        public virtual Task<ListDataSourceRunsResponse> ListDataSourceRunsAsync(ListDataSourceRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataSourceRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSources


        /// <summary>
        /// Lists data sources in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }


        /// <summary>
        /// Lists data sources in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Lists Amazon DataZone domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }


        /// <summary>
        /// Lists Amazon DataZone domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironmentBlueprintConfigurations


        /// <summary>
        /// Lists blueprint configurations for a Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprintConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentBlueprintConfigurations service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprintConfigurations">REST API Reference for ListEnvironmentBlueprintConfigurations Operation</seealso>
        public virtual ListEnvironmentBlueprintConfigurationsResponse ListEnvironmentBlueprintConfigurations(ListEnvironmentBlueprintConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentBlueprintConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Lists blueprint configurations for a Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprintConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentBlueprintConfigurations service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprintConfigurations">REST API Reference for ListEnvironmentBlueprintConfigurations Operation</seealso>
        public virtual Task<ListEnvironmentBlueprintConfigurationsResponse> ListEnvironmentBlueprintConfigurationsAsync(ListEnvironmentBlueprintConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEnvironmentBlueprintConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironmentBlueprints


        /// <summary>
        /// Lists blueprints in an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprints service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentBlueprints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprints">REST API Reference for ListEnvironmentBlueprints Operation</seealso>
        public virtual ListEnvironmentBlueprintsResponse ListEnvironmentBlueprints(ListEnvironmentBlueprintsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentBlueprintsResponse>(request, options);
        }


        /// <summary>
        /// Lists blueprints in an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentBlueprints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprints">REST API Reference for ListEnvironmentBlueprints Operation</seealso>
        public virtual Task<ListEnvironmentBlueprintsResponse> ListEnvironmentBlueprintsAsync(ListEnvironmentBlueprintsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEnvironmentBlueprintsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironmentProfiles


        /// <summary>
        /// Lists Amazon DataZone environment profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentProfiles service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentProfiles">REST API Reference for ListEnvironmentProfiles Operation</seealso>
        public virtual ListEnvironmentProfilesResponse ListEnvironmentProfiles(ListEnvironmentProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentProfilesResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentProfilesResponse>(request, options);
        }


        /// <summary>
        /// Lists Amazon DataZone environment profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentProfiles">REST API Reference for ListEnvironmentProfiles Operation</seealso>
        public virtual Task<ListEnvironmentProfilesResponse> ListEnvironmentProfilesAsync(ListEnvironmentProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentProfilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEnvironmentProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironments


        /// <summary>
        /// Lists Amazon DataZone environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Lists Amazon DataZone environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotifications


        /// <summary>
        /// Lists all Amazon DataZone notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual ListNotificationsResponse ListNotifications(ListNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationsResponse>(request, options);
        }


        /// <summary>
        /// Lists all Amazon DataZone notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProjectMemberships


        /// <summary>
        /// Lists all members of the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectMemberships service method.</param>
        /// 
        /// <returns>The response from the ListProjectMemberships service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectMemberships">REST API Reference for ListProjectMemberships Operation</seealso>
        public virtual ListProjectMembershipsResponse ListProjectMemberships(ListProjectMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListProjectMembershipsResponse>(request, options);
        }


        /// <summary>
        /// Lists all members of the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjectMemberships service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectMemberships">REST API Reference for ListProjectMemberships Operation</seealso>
        public virtual Task<ListProjectMembershipsResponse> ListProjectMembershipsAsync(ListProjectMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectMembershipsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProjectMembershipsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Lists Amazon DataZone projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }


        /// <summary>
        /// Lists Amazon DataZone projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptionGrants


        /// <summary>
        /// Lists subscription grants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionGrants service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionGrants service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionGrants">REST API Reference for ListSubscriptionGrants Operation</seealso>
        public virtual ListSubscriptionGrantsResponse ListSubscriptionGrants(ListSubscriptionGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionGrantsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionGrantsResponse>(request, options);
        }


        /// <summary>
        /// Lists subscription grants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionGrants service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionGrants">REST API Reference for ListSubscriptionGrants Operation</seealso>
        public virtual Task<ListSubscriptionGrantsResponse> ListSubscriptionGrantsAsync(ListSubscriptionGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionGrantsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSubscriptionGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptionRequests


        /// <summary>
        /// Lists Amazon DataZone subscription requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionRequests service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionRequests service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionRequests">REST API Reference for ListSubscriptionRequests Operation</seealso>
        public virtual ListSubscriptionRequestsResponse ListSubscriptionRequests(ListSubscriptionRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionRequestsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionRequestsResponse>(request, options);
        }


        /// <summary>
        /// Lists Amazon DataZone subscription requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionRequests service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionRequests">REST API Reference for ListSubscriptionRequests Operation</seealso>
        public virtual Task<ListSubscriptionRequestsResponse> ListSubscriptionRequestsAsync(ListSubscriptionRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionRequestsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSubscriptionRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptions


        /// <summary>
        /// Lists subscriptions in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionsResponse>(request, options);
        }


        /// <summary>
        /// Lists subscriptions in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptionTargets


        /// <summary>
        /// Lists subscription targets in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionTargets service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionTargets service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionTargets">REST API Reference for ListSubscriptionTargets Operation</seealso>
        public virtual ListSubscriptionTargetsResponse ListSubscriptionTargets(ListSubscriptionTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionTargetsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionTargetsResponse>(request, options);
        }


        /// <summary>
        /// Lists subscription targets in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionTargets service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionTargets">REST API Reference for ListSubscriptionTargets Operation</seealso>
        public virtual Task<ListSubscriptionTargetsResponse> ListSubscriptionTargetsAsync(ListSubscriptionTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSubscriptionTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for the specified resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists tags for the specified resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEnvironmentBlueprintConfiguration


        /// <summary>
        /// Writes the configuration for the specified environment blueprint in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEnvironmentBlueprintConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PutEnvironmentBlueprintConfiguration">REST API Reference for PutEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual PutEnvironmentBlueprintConfigurationResponse PutEnvironmentBlueprintConfiguration(PutEnvironmentBlueprintConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutEnvironmentBlueprintConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Writes the configuration for the specified environment blueprint in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEnvironmentBlueprintConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PutEnvironmentBlueprintConfiguration">REST API Reference for PutEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual Task<PutEnvironmentBlueprintConfigurationResponse> PutEnvironmentBlueprintConfigurationAsync(PutEnvironmentBlueprintConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutEnvironmentBlueprintConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectPredictions


        /// <summary>
        /// Rejects automatically generated business-friendly metadata for your Amazon DataZone
        /// assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPredictions service method.</param>
        /// 
        /// <returns>The response from the RejectPredictions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectPredictions">REST API Reference for RejectPredictions Operation</seealso>
        public virtual RejectPredictionsResponse RejectPredictions(RejectPredictionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPredictionsResponseUnmarshaller.Instance;

            return Invoke<RejectPredictionsResponse>(request, options);
        }


        /// <summary>
        /// Rejects automatically generated business-friendly metadata for your Amazon DataZone
        /// assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPredictions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectPredictions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectPredictions">REST API Reference for RejectPredictions Operation</seealso>
        public virtual Task<RejectPredictionsResponse> RejectPredictionsAsync(RejectPredictionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPredictionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<RejectPredictionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectSubscriptionRequest


        /// <summary>
        /// Rejects the specified subscription request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSubscriptionRequest service method.</param>
        /// 
        /// <returns>The response from the RejectSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectSubscriptionRequest">REST API Reference for RejectSubscriptionRequest Operation</seealso>
        public virtual RejectSubscriptionRequestResponse RejectSubscriptionRequest(RejectSubscriptionRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<RejectSubscriptionRequestResponse>(request, options);
        }


        /// <summary>
        /// Rejects the specified subscription request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectSubscriptionRequest">REST API Reference for RejectSubscriptionRequest Operation</seealso>
        public virtual Task<RejectSubscriptionRequestResponse> RejectSubscriptionRequestAsync(RejectSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSubscriptionRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<RejectSubscriptionRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeSubscription


        /// <summary>
        /// Revokes a specified subscription in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSubscription service method.</param>
        /// 
        /// <returns>The response from the RevokeSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RevokeSubscription">REST API Reference for RevokeSubscription Operation</seealso>
        public virtual RevokeSubscriptionResponse RevokeSubscription(RevokeSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RevokeSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Revokes a specified subscription in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RevokeSubscription">REST API Reference for RevokeSubscription Operation</seealso>
        public virtual Task<RevokeSubscriptionResponse> RevokeSubscriptionAsync(RevokeSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<RevokeSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Search


        /// <summary>
        /// Searches for assets in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// 
        /// <returns>The response from the Search service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/Search">REST API Reference for Search Operation</seealso>
        public virtual SearchResponse Search(SearchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return Invoke<SearchResponse>(request, options);
        }


        /// <summary>
        /// Searches for assets in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Search service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/Search">REST API Reference for Search Operation</seealso>
        public virtual Task<SearchResponse> SearchAsync(SearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchGroupProfiles


        /// <summary>
        /// Searches group profiles in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroupProfiles service method.</param>
        /// 
        /// <returns>The response from the SearchGroupProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchGroupProfiles">REST API Reference for SearchGroupProfiles Operation</seealso>
        public virtual SearchGroupProfilesResponse SearchGroupProfiles(SearchGroupProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchGroupProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGroupProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchGroupProfilesResponse>(request, options);
        }


        /// <summary>
        /// Searches group profiles in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroupProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchGroupProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchGroupProfiles">REST API Reference for SearchGroupProfiles Operation</seealso>
        public virtual Task<SearchGroupProfilesResponse> SearchGroupProfilesAsync(SearchGroupProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchGroupProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGroupProfilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchGroupProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchListings


        /// <summary>
        /// Searches listings in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchListings service method.</param>
        /// 
        /// <returns>The response from the SearchListings service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchListings">REST API Reference for SearchListings Operation</seealso>
        public virtual SearchListingsResponse SearchListings(SearchListingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchListingsResponseUnmarshaller.Instance;

            return Invoke<SearchListingsResponse>(request, options);
        }


        /// <summary>
        /// Searches listings in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchListings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchListings service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchListings">REST API Reference for SearchListings Operation</seealso>
        public virtual Task<SearchListingsResponse> SearchListingsAsync(SearchListingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchListingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchListingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchTypes


        /// <summary>
        /// Searches for types in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTypes service method.</param>
        /// 
        /// <returns>The response from the SearchTypes service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchTypes">REST API Reference for SearchTypes Operation</seealso>
        public virtual SearchTypesResponse SearchTypes(SearchTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTypesResponseUnmarshaller.Instance;

            return Invoke<SearchTypesResponse>(request, options);
        }


        /// <summary>
        /// Searches for types in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTypes service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchTypes">REST API Reference for SearchTypes Operation</seealso>
        public virtual Task<SearchTypesResponse> SearchTypesAsync(SearchTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchUserProfiles


        /// <summary>
        /// Searches user profiles in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUserProfiles service method.</param>
        /// 
        /// <returns>The response from the SearchUserProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchUserProfiles">REST API Reference for SearchUserProfiles Operation</seealso>
        public virtual SearchUserProfilesResponse SearchUserProfiles(SearchUserProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUserProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchUserProfilesResponse>(request, options);
        }


        /// <summary>
        /// Searches user profiles in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUserProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchUserProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchUserProfiles">REST API Reference for SearchUserProfiles Operation</seealso>
        public virtual Task<SearchUserProfilesResponse> SearchUserProfilesAsync(SearchUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUserProfilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchUserProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDataSourceRun


        /// <summary>
        /// Start the run of the specified data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceRun service method.</param>
        /// 
        /// <returns>The response from the StartDataSourceRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartDataSourceRun">REST API Reference for StartDataSourceRun Operation</seealso>
        public virtual StartDataSourceRunResponse StartDataSourceRun(StartDataSourceRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceRunResponseUnmarshaller.Instance;

            return Invoke<StartDataSourceRunResponse>(request, options);
        }


        /// <summary>
        /// Start the run of the specified data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDataSourceRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartDataSourceRun">REST API Reference for StartDataSourceRun Operation</seealso>
        public virtual Task<StartDataSourceRunResponse> StartDataSourceRunAsync(StartDataSourceRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDataSourceRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Tags a resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untags a resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Untags a resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataSource


        /// <summary>
        /// Updates the specified data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomain


        /// <summary>
        /// Updates a Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual UpdateDomainResponse UpdateDomain(UpdateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainResponse>(request, options);
        }


        /// <summary>
        /// Updates a Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironment


        /// <summary>
        /// Updates the specified environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironmentProfile


        /// <summary>
        /// Updates the specified environment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentProfile">REST API Reference for UpdateEnvironmentProfile Operation</seealso>
        public virtual UpdateEnvironmentProfileResponse UpdateEnvironmentProfile(UpdateEnvironmentProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentProfileResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified environment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentProfile">REST API Reference for UpdateEnvironmentProfile Operation</seealso>
        public virtual Task<UpdateEnvironmentProfileResponse> UpdateEnvironmentProfileAsync(UpdateEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEnvironmentProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGlossary


        /// <summary>
        /// Updates the business glossary in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossary service method.</param>
        /// 
        /// <returns>The response from the UpdateGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossary">REST API Reference for UpdateGlossary Operation</seealso>
        public virtual UpdateGlossaryResponse UpdateGlossary(UpdateGlossaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryResponseUnmarshaller.Instance;

            return Invoke<UpdateGlossaryResponse>(request, options);
        }


        /// <summary>
        /// Updates the business glossary in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossary">REST API Reference for UpdateGlossary Operation</seealso>
        public virtual Task<UpdateGlossaryResponse> UpdateGlossaryAsync(UpdateGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGlossaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGlossaryTerm


        /// <summary>
        /// Updates a business glossary term in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossaryTerm service method.</param>
        /// 
        /// <returns>The response from the UpdateGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossaryTerm">REST API Reference for UpdateGlossaryTerm Operation</seealso>
        public virtual UpdateGlossaryTermResponse UpdateGlossaryTerm(UpdateGlossaryTermRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<UpdateGlossaryTermResponse>(request, options);
        }


        /// <summary>
        /// Updates a business glossary term in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossaryTerm">REST API Reference for UpdateGlossaryTerm Operation</seealso>
        public virtual Task<UpdateGlossaryTermResponse> UpdateGlossaryTermAsync(UpdateGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryTermResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGlossaryTermResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroupProfile


        /// <summary>
        /// Updates the specified group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGroupProfile">REST API Reference for UpdateGroupProfile Operation</seealso>
        public virtual UpdateGroupProfileResponse UpdateGroupProfile(UpdateGroupProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupProfileResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGroupProfile">REST API Reference for UpdateGroupProfile Operation</seealso>
        public virtual Task<UpdateGroupProfileResponse> UpdateGroupProfileAsync(UpdateGroupProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGroupProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Updates the specified project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubscriptionGrantStatus


        /// <summary>
        /// Updates the status of the specified subscription grant status in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionGrantStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionGrantStatus service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionGrantStatus">REST API Reference for UpdateSubscriptionGrantStatus Operation</seealso>
        public virtual UpdateSubscriptionGrantStatusResponse UpdateSubscriptionGrantStatus(UpdateSubscriptionGrantStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionGrantStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionGrantStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionGrantStatusResponse>(request, options);
        }


        /// <summary>
        /// Updates the status of the specified subscription grant status in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionGrantStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionGrantStatus service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionGrantStatus">REST API Reference for UpdateSubscriptionGrantStatus Operation</seealso>
        public virtual Task<UpdateSubscriptionGrantStatusResponse> UpdateSubscriptionGrantStatusAsync(UpdateSubscriptionGrantStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionGrantStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionGrantStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSubscriptionGrantStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubscriptionRequest


        /// <summary>
        /// Updates a specified subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionRequest service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionRequest">REST API Reference for UpdateSubscriptionRequest Operation</seealso>
        public virtual UpdateSubscriptionRequestResponse UpdateSubscriptionRequest(UpdateSubscriptionRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionRequestResponse>(request, options);
        }


        /// <summary>
        /// Updates a specified subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionRequest">REST API Reference for UpdateSubscriptionRequest Operation</seealso>
        public virtual Task<UpdateSubscriptionRequestResponse> UpdateSubscriptionRequestAsync(UpdateSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSubscriptionRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubscriptionTarget


        /// <summary>
        /// Updates the specified subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionTarget service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionTarget">REST API Reference for UpdateSubscriptionTarget Operation</seealso>
        public virtual UpdateSubscriptionTargetResponse UpdateSubscriptionTarget(UpdateSubscriptionTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionTargetResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionTarget">REST API Reference for UpdateSubscriptionTarget Operation</seealso>
        public virtual Task<UpdateSubscriptionTargetResponse> UpdateSubscriptionTargetAsync(UpdateSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSubscriptionTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserProfile


        /// <summary>
        /// Updates the specified user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateUserProfileResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateUserProfileResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonDataZoneEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}