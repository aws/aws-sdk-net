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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Kinesis.Model;
using Amazon.Kinesis.Model.Internal.MarshallTransformations;
using Amazon.Kinesis.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis
{
    /// <summary>
    /// Implementation for accessing Kinesis
    ///
    /// Amazon Kinesis Data Streams Service API Reference 
    /// <para>
    /// Amazon Kinesis Data Streams is a managed service that scales elastically for real-time
    /// processing of streaming big data.
    /// </para>
    /// </summary>
    public partial class AmazonKinesisClient : AmazonServiceClient, IAmazonKinesis
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        public AmazonKinesisClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisConfig()) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        public AmazonKinesisClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(AmazonKinesisConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisClient(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials and an
        /// AmazonKinesisClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(AWSCredentials credentials, AmazonKinesisConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisConfig clientConfig)
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


        #region  AddTagsToStream

        internal virtual AddTagsToStreamResponse AddTagsToStream(AddTagsToStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToStreamResponseUnmarshaller.Instance;

            return Invoke<AddTagsToStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/AddTagsToStream">REST API Reference for AddTagsToStream Operation</seealso>
        public virtual Task<AddTagsToStreamResponse> AddTagsToStreamAsync(AddTagsToStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToStreamResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStream

        internal virtual CreateStreamResponse CreateStream(CreateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return Invoke<CreateStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DecreaseStreamRetentionPeriod

        internal virtual DecreaseStreamRetentionPeriodResponse DecreaseStreamRetentionPeriod(DecreaseStreamRetentionPeriodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseStreamRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<DecreaseStreamRetentionPeriodResponse>(request, options);
        }


        /// <summary>
        /// Decreases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The minimum value
        /// of a stream's retention period is 24 hours.
        /// 
        ///  
        /// <para>
        /// This operation may result in lost data. For example, if the stream's retention period
        /// is 48 hours and is decreased to 24 hours, any data already in the stream that is older
        /// than 24 hours is inaccessible.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be less than the current retention period.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DecreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        public virtual Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DecreaseStreamRetentionPeriodRequest();
            request.StreamName = streamName;
            request.RetentionPeriodHours = retentionPeriodHours;
            return DecreaseStreamRetentionPeriodAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DecreaseStreamRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecreaseStreamRetentionPeriod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        public virtual Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(DecreaseStreamRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseStreamRetentionPeriodResponseUnmarshaller.Instance;

            return InvokeAsync<DecreaseStreamRetentionPeriodResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStream

        internal virtual DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterStreamConsumer

        internal virtual DeregisterStreamConsumerResponse DeregisterStreamConsumer(DeregisterStreamConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterStreamConsumerResponseUnmarshaller.Instance;

            return Invoke<DeregisterStreamConsumerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterStreamConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterStreamConsumer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeregisterStreamConsumer">REST API Reference for DeregisterStreamConsumer Operation</seealso>
        public virtual Task<DeregisterStreamConsumerResponse> DeregisterStreamConsumerAsync(DeregisterStreamConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterStreamConsumerResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterStreamConsumerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLimits

        internal virtual DescribeLimitsResponse DescribeLimits(DescribeLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeLimitsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeLimits">REST API Reference for DescribeLimits Operation</seealso>
        public virtual Task<DescribeLimitsResponse> DescribeLimitsAsync(DescribeLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStream

        internal virtual DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStreamConsumer

        internal virtual DescribeStreamConsumerResponse DescribeStreamConsumer(DescribeStreamConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamConsumerResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamConsumerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStreamConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamConsumer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamConsumer">REST API Reference for DescribeStreamConsumer Operation</seealso>
        public virtual Task<DescribeStreamConsumerResponse> DescribeStreamConsumerAsync(DescribeStreamConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamConsumerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStreamConsumerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStreamSummary

        internal virtual DescribeStreamSummaryResponse DescribeStreamSummary(DescribeStreamSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamSummaryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStreamSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamSummary">REST API Reference for DescribeStreamSummary Operation</seealso>
        public virtual Task<DescribeStreamSummaryResponse> DescribeStreamSummaryAsync(DescribeStreamSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStreamSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableEnhancedMonitoring

        internal virtual DisableEnhancedMonitoringResponse DisableEnhancedMonitoring(DisableEnhancedMonitoringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableEnhancedMonitoringResponseUnmarshaller.Instance;

            return Invoke<DisableEnhancedMonitoringResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableEnhancedMonitoring operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableEnhancedMonitoring operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DisableEnhancedMonitoring">REST API Reference for DisableEnhancedMonitoring Operation</seealso>
        public virtual Task<DisableEnhancedMonitoringResponse> DisableEnhancedMonitoringAsync(DisableEnhancedMonitoringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableEnhancedMonitoringResponseUnmarshaller.Instance;

            return InvokeAsync<DisableEnhancedMonitoringResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableEnhancedMonitoring

        internal virtual EnableEnhancedMonitoringResponse EnableEnhancedMonitoring(EnableEnhancedMonitoringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableEnhancedMonitoringResponseUnmarshaller.Instance;

            return Invoke<EnableEnhancedMonitoringResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableEnhancedMonitoring operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableEnhancedMonitoring operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/EnableEnhancedMonitoring">REST API Reference for EnableEnhancedMonitoring Operation</seealso>
        public virtual Task<EnableEnhancedMonitoringResponse> EnableEnhancedMonitoringAsync(EnableEnhancedMonitoringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableEnhancedMonitoringResponseUnmarshaller.Instance;

            return InvokeAsync<EnableEnhancedMonitoringResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRecords

        internal virtual GetRecordsResponse GetRecords(GetRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordsResponseUnmarshaller.Instance;

            return Invoke<GetRecordsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecords operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetRecords">REST API Reference for GetRecords Operation</seealso>
        public virtual Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetShardIterator

        internal virtual GetShardIteratorResponse GetShardIterator(GetShardIteratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetShardIteratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShardIteratorResponseUnmarshaller.Instance;

            return Invoke<GetShardIteratorResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetShardIterator">REST API Reference for GetShardIterator Operation</seealso>
        public virtual Task<GetShardIteratorResponse> GetShardIteratorAsync(GetShardIteratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetShardIteratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShardIteratorResponseUnmarshaller.Instance;

            return InvokeAsync<GetShardIteratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IncreaseStreamRetentionPeriod

        internal virtual IncreaseStreamRetentionPeriodResponse IncreaseStreamRetentionPeriod(IncreaseStreamRetentionPeriodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IncreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseStreamRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<IncreaseStreamRetentionPeriodResponse>(request, options);
        }


        /// <summary>
        /// Increases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The maximum value
        /// of a stream's retention period is 168 hours (7 days).
        /// 
        ///  
        /// <para>
        /// If you choose a longer stream retention period, this operation increases the time
        /// period during which records that have not yet expired are accessible. However, it
        /// does not make previous, expired data (older than the stream's previous retention period)
        /// accessible after the operation has been called. For example, if a stream's retention
        /// period is set to 24 hours and is increased to 168 hours, any data that is older than
        /// 24 hours remains inaccessible to consumer applications.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be more than the current retention period.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IncreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        public virtual Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new IncreaseStreamRetentionPeriodRequest();
            request.StreamName = streamName;
            request.RetentionPeriodHours = retentionPeriodHours;
            return IncreaseStreamRetentionPeriodAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the IncreaseStreamRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IncreaseStreamRetentionPeriod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        public virtual Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(IncreaseStreamRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IncreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseStreamRetentionPeriodResponseUnmarshaller.Instance;

            return InvokeAsync<IncreaseStreamRetentionPeriodResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListShards

        internal virtual ListShardsResponse ListShards(ListShardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListShardsResponseUnmarshaller.Instance;

            return Invoke<ListShardsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListShards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListShards operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListShards">REST API Reference for ListShards Operation</seealso>
        public virtual Task<ListShardsResponse> ListShardsAsync(ListShardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListShardsResponseUnmarshaller.Instance;

            return InvokeAsync<ListShardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStreamConsumers

        internal virtual ListStreamConsumersResponse ListStreamConsumers(ListStreamConsumersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamConsumersResponseUnmarshaller.Instance;

            return Invoke<ListStreamConsumersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamConsumers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamConsumers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreamConsumers">REST API Reference for ListStreamConsumers Operation</seealso>
        public virtual Task<ListStreamConsumersResponse> ListStreamConsumersAsync(ListStreamConsumersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamConsumersResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamConsumersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStreams

        internal virtual ListStreamsResponse ListStreams()
        {
            return ListStreams(new ListStreamsRequest());
        }
        internal virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsResponse>(request, options);
        }


        /// <summary>
        /// Lists your Kinesis data streams.
        /// 
        ///  
        /// <para>
        /// The number of streams may be too large to return from a single call to <code>ListStreams</code>.
        /// You can limit the number of returned streams using the <code>Limit</code> parameter.
        /// If you do not specify a value for the <code>Limit</code> parameter, Kinesis Data Streams
        /// uses the default limit, which is currently 10.
        /// </para>
        ///  
        /// <para>
        /// You can detect if there are more streams available to list by using the <code>HasMoreStreams</code>
        /// flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <code>ListStreams</code>
        /// request in the <code>ExclusiveStartStreamName</code> parameter in a subsequent request
        /// to <code>ListStreams</code>. The group of stream names returned by the subsequent
        /// request is then added to the list. You can continue this process until all the stream
        /// names have been collected in the list. 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListStreams</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual Task<ListStreamsResponse> ListStreamsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListStreamsAsync(new ListStreamsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForStream

        internal virtual ListTagsForStreamResponse ListTagsForStream(ListTagsForStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return Invoke<ListTagsForStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        public virtual Task<ListTagsForStreamResponse> ListTagsForStreamAsync(ListTagsForStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MergeShards

        internal virtual MergeShardsResponse MergeShards(MergeShardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergeShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeShardsResponseUnmarshaller.Instance;

            return Invoke<MergeShardsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the MergeShards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeShards operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/MergeShards">REST API Reference for MergeShards Operation</seealso>
        public virtual Task<MergeShardsResponse> MergeShardsAsync(MergeShardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergeShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeShardsResponseUnmarshaller.Instance;

            return InvokeAsync<MergeShardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRecord

        internal virtual PutRecordResponse PutRecord(PutRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordResponseUnmarshaller.Instance;

            return Invoke<PutRecordResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecord operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual Task<PutRecordResponse> PutRecordAsync(PutRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordResponseUnmarshaller.Instance;

            return InvokeAsync<PutRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRecords

        internal virtual PutRecordsResponse PutRecords(PutRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordsResponseUnmarshaller.Instance;

            return Invoke<PutRecordsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecords operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecords">REST API Reference for PutRecords Operation</seealso>
        public virtual Task<PutRecordsResponse> PutRecordsAsync(PutRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<PutRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterStreamConsumer

        internal virtual RegisterStreamConsumerResponse RegisterStreamConsumer(RegisterStreamConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterStreamConsumerResponseUnmarshaller.Instance;

            return Invoke<RegisterStreamConsumerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterStreamConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterStreamConsumer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RegisterStreamConsumer">REST API Reference for RegisterStreamConsumer Operation</seealso>
        public virtual Task<RegisterStreamConsumerResponse> RegisterStreamConsumerAsync(RegisterStreamConsumerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterStreamConsumerResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterStreamConsumerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromStream

        internal virtual RemoveTagsFromStreamResponse RemoveTagsFromStream(RemoveTagsFromStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromStreamResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RemoveTagsFromStream">REST API Reference for RemoveTagsFromStream Operation</seealso>
        public virtual Task<RemoveTagsFromStreamResponse> RemoveTagsFromStreamAsync(RemoveTagsFromStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromStreamResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SplitShard

        internal virtual SplitShardResponse SplitShard(SplitShardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SplitShardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SplitShardResponseUnmarshaller.Instance;

            return Invoke<SplitShardResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SplitShard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SplitShard operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/SplitShard">REST API Reference for SplitShard Operation</seealso>
        public virtual Task<SplitShardResponse> SplitShardAsync(SplitShardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SplitShardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SplitShardResponseUnmarshaller.Instance;

            return InvokeAsync<SplitShardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartStreamEncryption

        internal virtual StartStreamEncryptionResponse StartStreamEncryption(StartStreamEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamEncryptionResponseUnmarshaller.Instance;

            return Invoke<StartStreamEncryptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartStreamEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStreamEncryption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StartStreamEncryption">REST API Reference for StartStreamEncryption Operation</seealso>
        public virtual Task<StartStreamEncryptionResponse> StartStreamEncryptionAsync(StartStreamEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<StartStreamEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopStreamEncryption

        internal virtual StopStreamEncryptionResponse StopStreamEncryption(StopStreamEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamEncryptionResponseUnmarshaller.Instance;

            return Invoke<StopStreamEncryptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopStreamEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStreamEncryption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StopStreamEncryption">REST API Reference for StopStreamEncryption Operation</seealso>
        public virtual Task<StopStreamEncryptionResponse> StopStreamEncryptionAsync(StopStreamEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<StopStreamEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateShardCount

        internal virtual UpdateShardCountResponse UpdateShardCount(UpdateShardCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateShardCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateShardCountResponseUnmarshaller.Instance;

            return Invoke<UpdateShardCountResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateShardCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateShardCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/UpdateShardCount">REST API Reference for UpdateShardCount Operation</seealso>
        public virtual Task<UpdateShardCountResponse> UpdateShardCountAsync(UpdateShardCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateShardCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateShardCountResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateShardCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}