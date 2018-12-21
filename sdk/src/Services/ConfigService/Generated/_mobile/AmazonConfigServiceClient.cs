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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ConfigService.Model;
using Amazon.ConfigService.Model.Internal.MarshallTransformations;
using Amazon.ConfigService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ConfigService
{
    /// <summary>
    /// Implementation for accessing ConfigService
    ///
    /// AWS Config 
    /// <para>
    /// AWS Config provides a way to keep track of the configurations of all the AWS resources
    /// associated with your AWS account. You can use AWS Config to get the current and historical
    /// configurations of each AWS resource and also to get information about the relationship
    /// between the resources. An AWS resource can be an Amazon Compute Cloud (Amazon EC2)
    /// instance, an Elastic Block Store (EBS) volume, an elastic network Interface (ENI),
    /// or a security group. For a complete list of resources currently supported by AWS Config,
    /// see <a href="http://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
    /// AWS Resources</a>.
    /// </para>
    ///  
    /// <para>
    /// You can access and manage AWS Config through the AWS Management Console, the AWS Command
    /// Line Interface (AWS CLI), the AWS Config API, or the AWS SDKs for AWS Config. This
    /// reference guide contains documentation for the AWS Config API and the AWS CLI commands
    /// that you can use to manage AWS Config. The AWS Config API uses the Signature Version
    /// 4 protocol for signing requests. For more information about how to sign a request
    /// with this protocol, see <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>. For detailed information about AWS Config features
    /// and their associated actions or commands, as well as how to work with AWS Management
    /// Console, see <a href="http://docs.aws.amazon.com/config/latest/developerguide/WhatIsConfig.html">What
    /// Is AWS Config</a> in the <i>AWS Config Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonConfigServiceClient : AmazonServiceClient, IAmazonConfigService
    {
        private static IServiceMetadata serviceMetadata = new AmazonConfigServiceMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonConfigServiceClient with the credentials loaded from the application's
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
        public AmazonConfigServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConfigServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with the credentials loaded from the application's
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
        public AmazonConfigServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConfigServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(AmazonConfigServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConfigServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonConfigServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConfigServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConfigServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Credentials and an
        /// AmazonConfigServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(AWSCredentials credentials, AmazonConfigServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConfigServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConfigServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConfigServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConfigServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConfigServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConfigServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConfigServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConfigServiceConfig clientConfig)
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


        #region  BatchGetAggregateResourceConfig

        internal virtual BatchGetAggregateResourceConfigResponse BatchGetAggregateResourceConfig(BatchGetAggregateResourceConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAggregateResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAggregateResourceConfigResponseUnmarshaller.Instance;

            return Invoke<BatchGetAggregateResourceConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetAggregateResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAggregateResourceConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetAggregateResourceConfig">REST API Reference for BatchGetAggregateResourceConfig Operation</seealso>
        public virtual Task<BatchGetAggregateResourceConfigResponse> BatchGetAggregateResourceConfigAsync(BatchGetAggregateResourceConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAggregateResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAggregateResourceConfigResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetAggregateResourceConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetResourceConfig

        internal virtual BatchGetResourceConfigResponse BatchGetResourceConfig(BatchGetResourceConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetResourceConfigResponseUnmarshaller.Instance;

            return Invoke<BatchGetResourceConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetResourceConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetResourceConfig">REST API Reference for BatchGetResourceConfig Operation</seealso>
        public virtual Task<BatchGetResourceConfigResponse> BatchGetResourceConfigAsync(BatchGetResourceConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetResourceConfigResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetResourceConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAggregationAuthorization

        internal virtual DeleteAggregationAuthorizationResponse DeleteAggregationAuthorization(DeleteAggregationAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAggregationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAggregationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteAggregationAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAggregationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAggregationAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteAggregationAuthorization">REST API Reference for DeleteAggregationAuthorization Operation</seealso>
        public virtual Task<DeleteAggregationAuthorizationResponse> DeleteAggregationAuthorizationAsync(DeleteAggregationAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAggregationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAggregationAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAggregationAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigRule

        internal virtual DeleteConfigRuleResponse DeleteConfigRule(DeleteConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigRuleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigRule">REST API Reference for DeleteConfigRule Operation</seealso>
        public virtual Task<DeleteConfigRuleResponse> DeleteConfigRuleAsync(DeleteConfigRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationAggregator

        internal virtual DeleteConfigurationAggregatorResponse DeleteConfigurationAggregator(DeleteConfigurationAggregatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationAggregatorResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationAggregatorResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationAggregator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationAggregator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationAggregator">REST API Reference for DeleteConfigurationAggregator Operation</seealso>
        public virtual Task<DeleteConfigurationAggregatorResponse> DeleteConfigurationAggregatorAsync(DeleteConfigurationAggregatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationAggregatorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationAggregatorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationRecorder

        internal virtual DeleteConfigurationRecorderResponse DeleteConfigurationRecorder(DeleteConfigurationRecorderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationRecorderResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationRecorder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationRecorder">REST API Reference for DeleteConfigurationRecorder Operation</seealso>
        public virtual Task<DeleteConfigurationRecorderResponse> DeleteConfigurationRecorderAsync(DeleteConfigurationRecorderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationRecorderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationRecorderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeliveryChannel

        internal virtual DeleteDeliveryChannelResponse DeleteDeliveryChannel(DeleteDeliveryChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliveryChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliveryChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteDeliveryChannelResponse>(request, options);
        }


        /// <summary>
        /// Deletes the delivery channel.
        /// 
        ///  
        /// <para>
        /// Before you can delete the delivery channel, you must stop the configuration recorder
        /// by using the <a>StopConfigurationRecorder</a> action.
        /// </para>
        /// </summary>
        /// <param name="deliveryChannelName">The name of the delivery channel to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.LastDeliveryChannelDeleteFailedException">
        /// You cannot delete the delivery channel you specified because the configuration recorder
        /// is running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteDeliveryChannel">REST API Reference for DeleteDeliveryChannel Operation</seealso>
        public virtual Task<DeleteDeliveryChannelResponse> DeleteDeliveryChannelAsync(string deliveryChannelName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteDeliveryChannelRequest();
            request.DeliveryChannelName = deliveryChannelName;
            return DeleteDeliveryChannelAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteDeliveryChannel">REST API Reference for DeleteDeliveryChannel Operation</seealso>
        public virtual Task<DeleteDeliveryChannelResponse> DeleteDeliveryChannelAsync(DeleteDeliveryChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliveryChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliveryChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeliveryChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEvaluationResults

        internal virtual DeleteEvaluationResultsResponse DeleteEvaluationResults(DeleteEvaluationResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEvaluationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEvaluationResultsResponseUnmarshaller.Instance;

            return Invoke<DeleteEvaluationResultsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEvaluationResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluationResults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteEvaluationResults">REST API Reference for DeleteEvaluationResults Operation</seealso>
        public virtual Task<DeleteEvaluationResultsResponse> DeleteEvaluationResultsAsync(DeleteEvaluationResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEvaluationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEvaluationResultsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEvaluationResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePendingAggregationRequest

        internal virtual DeletePendingAggregationRequestResponse DeletePendingAggregationRequest(DeletePendingAggregationRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePendingAggregationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePendingAggregationRequestResponseUnmarshaller.Instance;

            return Invoke<DeletePendingAggregationRequestResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePendingAggregationRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePendingAggregationRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeletePendingAggregationRequest">REST API Reference for DeletePendingAggregationRequest Operation</seealso>
        public virtual Task<DeletePendingAggregationRequestResponse> DeletePendingAggregationRequestAsync(DeletePendingAggregationRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePendingAggregationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePendingAggregationRequestResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePendingAggregationRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRetentionConfiguration

        internal virtual DeleteRetentionConfigurationResponse DeleteRetentionConfiguration(DeleteRetentionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetentionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetentionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteRetentionConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRetentionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRetentionConfiguration">REST API Reference for DeleteRetentionConfiguration Operation</seealso>
        public virtual Task<DeleteRetentionConfigurationResponse> DeleteRetentionConfigurationAsync(DeleteRetentionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetentionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetentionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRetentionConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeliverConfigSnapshot

        internal virtual DeliverConfigSnapshotResponse DeliverConfigSnapshot(DeliverConfigSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeliverConfigSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeliverConfigSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeliverConfigSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Schedules delivery of a configuration snapshot to the Amazon S3 bucket in the specified
        /// delivery channel. After the delivery has started, AWS Config sends the following notifications
        /// using an Amazon SNS topic that you have specified.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Notification of the start of the delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of the completion of the delivery, if the delivery was successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of delivery failure, if the delivery failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="deliveryChannelName">The name of the delivery channel through which the snapshot is delivered.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeliverConfigSnapshot service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoRunningConfigurationRecorderException">
        /// There is no configuration recorder running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeliverConfigSnapshot">REST API Reference for DeliverConfigSnapshot Operation</seealso>
        public virtual Task<DeliverConfigSnapshotResponse> DeliverConfigSnapshotAsync(string deliveryChannelName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeliverConfigSnapshotRequest();
            request.DeliveryChannelName = deliveryChannelName;
            return DeliverConfigSnapshotAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeliverConfigSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeliverConfigSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeliverConfigSnapshot">REST API Reference for DeliverConfigSnapshot Operation</seealso>
        public virtual Task<DeliverConfigSnapshotResponse> DeliverConfigSnapshotAsync(DeliverConfigSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeliverConfigSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeliverConfigSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeliverConfigSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAggregateComplianceByConfigRules

        internal virtual DescribeAggregateComplianceByConfigRulesResponse DescribeAggregateComplianceByConfigRules(DescribeAggregateComplianceByConfigRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregateComplianceByConfigRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregateComplianceByConfigRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeAggregateComplianceByConfigRulesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAggregateComplianceByConfigRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateComplianceByConfigRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregateComplianceByConfigRules">REST API Reference for DescribeAggregateComplianceByConfigRules Operation</seealso>
        public virtual Task<DescribeAggregateComplianceByConfigRulesResponse> DescribeAggregateComplianceByConfigRulesAsync(DescribeAggregateComplianceByConfigRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregateComplianceByConfigRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregateComplianceByConfigRulesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAggregateComplianceByConfigRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAggregationAuthorizations

        internal virtual DescribeAggregationAuthorizationsResponse DescribeAggregationAuthorizations(DescribeAggregationAuthorizationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregationAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregationAuthorizationsResponseUnmarshaller.Instance;

            return Invoke<DescribeAggregationAuthorizationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAggregationAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregationAuthorizations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregationAuthorizations">REST API Reference for DescribeAggregationAuthorizations Operation</seealso>
        public virtual Task<DescribeAggregationAuthorizationsResponse> DescribeAggregationAuthorizationsAsync(DescribeAggregationAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregationAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregationAuthorizationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAggregationAuthorizationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeComplianceByConfigRule

        internal virtual DescribeComplianceByConfigRuleResponse DescribeComplianceByConfigRule(DescribeComplianceByConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComplianceByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComplianceByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeComplianceByConfigRuleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComplianceByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByConfigRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByConfigRule">REST API Reference for DescribeComplianceByConfigRule Operation</seealso>
        public virtual Task<DescribeComplianceByConfigRuleResponse> DescribeComplianceByConfigRuleAsync(DescribeComplianceByConfigRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComplianceByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComplianceByConfigRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeComplianceByConfigRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeComplianceByResource

        internal virtual DescribeComplianceByResourceResponse DescribeComplianceByResource(DescribeComplianceByResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComplianceByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComplianceByResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeComplianceByResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComplianceByResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByResource">REST API Reference for DescribeComplianceByResource Operation</seealso>
        public virtual Task<DescribeComplianceByResourceResponse> DescribeComplianceByResourceAsync(DescribeComplianceByResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComplianceByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComplianceByResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeComplianceByResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigRuleEvaluationStatus

        internal virtual DescribeConfigRuleEvaluationStatusResponse DescribeConfigRuleEvaluationStatus(DescribeConfigRuleEvaluationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigRuleEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigRuleEvaluationStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigRuleEvaluationStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigRuleEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRuleEvaluationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRuleEvaluationStatus">REST API Reference for DescribeConfigRuleEvaluationStatus Operation</seealso>
        public virtual Task<DescribeConfigRuleEvaluationStatusResponse> DescribeConfigRuleEvaluationStatusAsync(DescribeConfigRuleEvaluationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigRuleEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigRuleEvaluationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigRuleEvaluationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigRules

        internal virtual DescribeConfigRulesResponse DescribeConfigRules(DescribeConfigRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigRulesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRules">REST API Reference for DescribeConfigRules Operation</seealso>
        public virtual Task<DescribeConfigRulesResponse> DescribeConfigRulesAsync(DescribeConfigRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigRulesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationAggregators

        internal virtual DescribeConfigurationAggregatorsResponse DescribeConfigurationAggregators(DescribeConfigurationAggregatorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationAggregatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationAggregatorsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationAggregatorsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationAggregators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationAggregators operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregators">REST API Reference for DescribeConfigurationAggregators Operation</seealso>
        public virtual Task<DescribeConfigurationAggregatorsResponse> DescribeConfigurationAggregatorsAsync(DescribeConfigurationAggregatorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationAggregatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationAggregatorsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationAggregatorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationAggregatorSourcesStatus

        internal virtual DescribeConfigurationAggregatorSourcesStatusResponse DescribeConfigurationAggregatorSourcesStatus(DescribeConfigurationAggregatorSourcesStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationAggregatorSourcesStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationAggregatorSourcesStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationAggregatorSourcesStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationAggregatorSourcesStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationAggregatorSourcesStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregatorSourcesStatus">REST API Reference for DescribeConfigurationAggregatorSourcesStatus Operation</seealso>
        public virtual Task<DescribeConfigurationAggregatorSourcesStatusResponse> DescribeConfigurationAggregatorSourcesStatusAsync(DescribeConfigurationAggregatorSourcesStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationAggregatorSourcesStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationAggregatorSourcesStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationAggregatorSourcesStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationRecorders

        internal virtual DescribeConfigurationRecordersResponse DescribeConfigurationRecorders()
        {
            return DescribeConfigurationRecorders(new DescribeConfigurationRecordersRequest());
        }
        internal virtual DescribeConfigurationRecordersResponse DescribeConfigurationRecorders(DescribeConfigurationRecordersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRecordersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRecordersResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRecordersResponse>(request, options);
        }


        /// <summary>
        /// Returns the details for the specified configuration recorders. If the configuration
        /// recorder is not specified, this action returns the details for all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorders service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorders">REST API Reference for DescribeConfigurationRecorders Operation</seealso>
        public virtual Task<DescribeConfigurationRecordersResponse> DescribeConfigurationRecordersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConfigurationRecordersAsync(new DescribeConfigurationRecordersRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRecorders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorders">REST API Reference for DescribeConfigurationRecorders Operation</seealso>
        public virtual Task<DescribeConfigurationRecordersResponse> DescribeConfigurationRecordersAsync(DescribeConfigurationRecordersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRecordersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRecordersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationRecordersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationRecorderStatus

        internal virtual DescribeConfigurationRecorderStatusResponse DescribeConfigurationRecorderStatus()
        {
            return DescribeConfigurationRecorderStatus(new DescribeConfigurationRecorderStatusRequest());
        }
        internal virtual DescribeConfigurationRecorderStatusResponse DescribeConfigurationRecorderStatus(DescribeConfigurationRecorderStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRecorderStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRecorderStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRecorderStatusResponse>(request, options);
        }


        /// <summary>
        /// Returns the current status of the specified configuration recorder. If a configuration
        /// recorder is not specified, this action returns the status of all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorderStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorderStatus">REST API Reference for DescribeConfigurationRecorderStatus Operation</seealso>
        public virtual Task<DescribeConfigurationRecorderStatusResponse> DescribeConfigurationRecorderStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConfigurationRecorderStatusAsync(new DescribeConfigurationRecorderStatusRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRecorderStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorderStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorderStatus">REST API Reference for DescribeConfigurationRecorderStatus Operation</seealso>
        public virtual Task<DescribeConfigurationRecorderStatusResponse> DescribeConfigurationRecorderStatusAsync(DescribeConfigurationRecorderStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRecorderStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRecorderStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationRecorderStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDeliveryChannels

        internal virtual DescribeDeliveryChannelsResponse DescribeDeliveryChannels()
        {
            return DescribeDeliveryChannels(new DescribeDeliveryChannelsRequest());
        }
        internal virtual DescribeDeliveryChannelsResponse DescribeDeliveryChannels(DescribeDeliveryChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveryChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveryChannelsResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliveryChannelsResponse>(request, options);
        }


        /// <summary>
        /// Returns details about the specified delivery channel. If a delivery channel is not
        /// specified, this action returns the details of all delivery channels associated with
        /// the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannels service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannels">REST API Reference for DescribeDeliveryChannels Operation</seealso>
        public virtual Task<DescribeDeliveryChannelsResponse> DescribeDeliveryChannelsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDeliveryChannelsAsync(new DescribeDeliveryChannelsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannels">REST API Reference for DescribeDeliveryChannels Operation</seealso>
        public virtual Task<DescribeDeliveryChannelsResponse> DescribeDeliveryChannelsAsync(DescribeDeliveryChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveryChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveryChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeliveryChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDeliveryChannelStatus

        internal virtual DescribeDeliveryChannelStatusResponse DescribeDeliveryChannelStatus()
        {
            return DescribeDeliveryChannelStatus(new DescribeDeliveryChannelStatusRequest());
        }
        internal virtual DescribeDeliveryChannelStatusResponse DescribeDeliveryChannelStatus(DescribeDeliveryChannelStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveryChannelStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveryChannelStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliveryChannelStatusResponse>(request, options);
        }


        /// <summary>
        /// Returns the current status of the specified delivery channel. If a delivery channel
        /// is not specified, this action returns the current status of all delivery channels
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannelStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannelStatus">REST API Reference for DescribeDeliveryChannelStatus Operation</seealso>
        public virtual Task<DescribeDeliveryChannelStatusResponse> DescribeDeliveryChannelStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDeliveryChannelStatusAsync(new DescribeDeliveryChannelStatusRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryChannelStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannelStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannelStatus">REST API Reference for DescribeDeliveryChannelStatus Operation</seealso>
        public virtual Task<DescribeDeliveryChannelStatusResponse> DescribeDeliveryChannelStatusAsync(DescribeDeliveryChannelStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveryChannelStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveryChannelStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeliveryChannelStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePendingAggregationRequests

        internal virtual DescribePendingAggregationRequestsResponse DescribePendingAggregationRequests(DescribePendingAggregationRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePendingAggregationRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingAggregationRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingAggregationRequestsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePendingAggregationRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingAggregationRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribePendingAggregationRequests">REST API Reference for DescribePendingAggregationRequests Operation</seealso>
        public virtual Task<DescribePendingAggregationRequestsResponse> DescribePendingAggregationRequestsAsync(DescribePendingAggregationRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePendingAggregationRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingAggregationRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePendingAggregationRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRetentionConfigurations

        internal virtual DescribeRetentionConfigurationsResponse DescribeRetentionConfigurations(DescribeRetentionConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRetentionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRetentionConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeRetentionConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRetentionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRetentionConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRetentionConfigurations">REST API Reference for DescribeRetentionConfigurations Operation</seealso>
        public virtual Task<DescribeRetentionConfigurationsResponse> DescribeRetentionConfigurationsAsync(DescribeRetentionConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRetentionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRetentionConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRetentionConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAggregateComplianceDetailsByConfigRule

        internal virtual GetAggregateComplianceDetailsByConfigRuleResponse GetAggregateComplianceDetailsByConfigRule(GetAggregateComplianceDetailsByConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateComplianceDetailsByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateComplianceDetailsByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<GetAggregateComplianceDetailsByConfigRuleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAggregateComplianceDetailsByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateComplianceDetailsByConfigRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateComplianceDetailsByConfigRule">REST API Reference for GetAggregateComplianceDetailsByConfigRule Operation</seealso>
        public virtual Task<GetAggregateComplianceDetailsByConfigRuleResponse> GetAggregateComplianceDetailsByConfigRuleAsync(GetAggregateComplianceDetailsByConfigRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateComplianceDetailsByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateComplianceDetailsByConfigRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetAggregateComplianceDetailsByConfigRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAggregateConfigRuleComplianceSummary

        internal virtual GetAggregateConfigRuleComplianceSummaryResponse GetAggregateConfigRuleComplianceSummary(GetAggregateConfigRuleComplianceSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateConfigRuleComplianceSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateConfigRuleComplianceSummaryResponseUnmarshaller.Instance;

            return Invoke<GetAggregateConfigRuleComplianceSummaryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAggregateConfigRuleComplianceSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateConfigRuleComplianceSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateConfigRuleComplianceSummary">REST API Reference for GetAggregateConfigRuleComplianceSummary Operation</seealso>
        public virtual Task<GetAggregateConfigRuleComplianceSummaryResponse> GetAggregateConfigRuleComplianceSummaryAsync(GetAggregateConfigRuleComplianceSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateConfigRuleComplianceSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateConfigRuleComplianceSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetAggregateConfigRuleComplianceSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAggregateDiscoveredResourceCounts

        internal virtual GetAggregateDiscoveredResourceCountsResponse GetAggregateDiscoveredResourceCounts(GetAggregateDiscoveredResourceCountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateDiscoveredResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateDiscoveredResourceCountsResponseUnmarshaller.Instance;

            return Invoke<GetAggregateDiscoveredResourceCountsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAggregateDiscoveredResourceCounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateDiscoveredResourceCounts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateDiscoveredResourceCounts">REST API Reference for GetAggregateDiscoveredResourceCounts Operation</seealso>
        public virtual Task<GetAggregateDiscoveredResourceCountsResponse> GetAggregateDiscoveredResourceCountsAsync(GetAggregateDiscoveredResourceCountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateDiscoveredResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateDiscoveredResourceCountsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAggregateDiscoveredResourceCountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAggregateResourceConfig

        internal virtual GetAggregateResourceConfigResponse GetAggregateResourceConfig(GetAggregateResourceConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateResourceConfigResponseUnmarshaller.Instance;

            return Invoke<GetAggregateResourceConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAggregateResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateResourceConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateResourceConfig">REST API Reference for GetAggregateResourceConfig Operation</seealso>
        public virtual Task<GetAggregateResourceConfigResponse> GetAggregateResourceConfigAsync(GetAggregateResourceConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateResourceConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetAggregateResourceConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComplianceDetailsByConfigRule

        internal virtual GetComplianceDetailsByConfigRuleResponse GetComplianceDetailsByConfigRule(GetComplianceDetailsByConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailsByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailsByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<GetComplianceDetailsByConfigRuleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceDetailsByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByConfigRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByConfigRule">REST API Reference for GetComplianceDetailsByConfigRule Operation</seealso>
        public virtual Task<GetComplianceDetailsByConfigRuleResponse> GetComplianceDetailsByConfigRuleAsync(GetComplianceDetailsByConfigRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailsByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailsByConfigRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetComplianceDetailsByConfigRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComplianceDetailsByResource

        internal virtual GetComplianceDetailsByResourceResponse GetComplianceDetailsByResource(GetComplianceDetailsByResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailsByResourceResponseUnmarshaller.Instance;

            return Invoke<GetComplianceDetailsByResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceDetailsByResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByResource">REST API Reference for GetComplianceDetailsByResource Operation</seealso>
        public virtual Task<GetComplianceDetailsByResourceResponse> GetComplianceDetailsByResourceAsync(GetComplianceDetailsByResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailsByResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetComplianceDetailsByResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComplianceSummaryByConfigRule

        internal virtual GetComplianceSummaryByConfigRuleResponse GetComplianceSummaryByConfigRule(GetComplianceSummaryByConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceSummaryByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceSummaryByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<GetComplianceSummaryByConfigRuleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceSummaryByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByConfigRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByConfigRule">REST API Reference for GetComplianceSummaryByConfigRule Operation</seealso>
        public virtual Task<GetComplianceSummaryByConfigRuleResponse> GetComplianceSummaryByConfigRuleAsync(GetComplianceSummaryByConfigRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceSummaryByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceSummaryByConfigRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetComplianceSummaryByConfigRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComplianceSummaryByResourceType

        internal virtual GetComplianceSummaryByResourceTypeResponse GetComplianceSummaryByResourceType(GetComplianceSummaryByResourceTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceSummaryByResourceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceSummaryByResourceTypeResponseUnmarshaller.Instance;

            return Invoke<GetComplianceSummaryByResourceTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceSummaryByResourceType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByResourceType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByResourceType">REST API Reference for GetComplianceSummaryByResourceType Operation</seealso>
        public virtual Task<GetComplianceSummaryByResourceTypeResponse> GetComplianceSummaryByResourceTypeAsync(GetComplianceSummaryByResourceTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceSummaryByResourceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceSummaryByResourceTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetComplianceSummaryByResourceTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDiscoveredResourceCounts

        internal virtual GetDiscoveredResourceCountsResponse GetDiscoveredResourceCounts(GetDiscoveredResourceCountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiscoveredResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveredResourceCountsResponseUnmarshaller.Instance;

            return Invoke<GetDiscoveredResourceCountsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDiscoveredResourceCounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredResourceCounts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetDiscoveredResourceCounts">REST API Reference for GetDiscoveredResourceCounts Operation</seealso>
        public virtual Task<GetDiscoveredResourceCountsResponse> GetDiscoveredResourceCountsAsync(GetDiscoveredResourceCountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiscoveredResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveredResourceCountsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDiscoveredResourceCountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceConfigHistory

        internal virtual GetResourceConfigHistoryResponse GetResourceConfigHistory(GetResourceConfigHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceConfigHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceConfigHistoryResponseUnmarshaller.Instance;

            return Invoke<GetResourceConfigHistoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceConfigHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfigHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetResourceConfigHistory">REST API Reference for GetResourceConfigHistory Operation</seealso>
        public virtual Task<GetResourceConfigHistoryResponse> GetResourceConfigHistoryAsync(GetResourceConfigHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceConfigHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceConfigHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceConfigHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAggregateDiscoveredResources

        internal virtual ListAggregateDiscoveredResourcesResponse ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAggregateDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAggregateDiscoveredResourcesResponseUnmarshaller.Instance;

            return Invoke<ListAggregateDiscoveredResourcesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAggregateDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAggregateDiscoveredResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListAggregateDiscoveredResources">REST API Reference for ListAggregateDiscoveredResources Operation</seealso>
        public virtual Task<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResourcesAsync(ListAggregateDiscoveredResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAggregateDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAggregateDiscoveredResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAggregateDiscoveredResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDiscoveredResources

        internal virtual ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveredResourcesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesAsync(ListDiscoveredResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDiscoveredResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAggregationAuthorization

        internal virtual PutAggregationAuthorizationResponse PutAggregationAuthorization(PutAggregationAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAggregationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAggregationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<PutAggregationAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutAggregationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAggregationAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutAggregationAuthorization">REST API Reference for PutAggregationAuthorization Operation</seealso>
        public virtual Task<PutAggregationAuthorizationResponse> PutAggregationAuthorizationAsync(PutAggregationAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAggregationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAggregationAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<PutAggregationAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigRule

        internal virtual PutConfigRuleResponse PutConfigRule(PutConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigRuleResponseUnmarshaller.Instance;

            return Invoke<PutConfigRuleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigRule">REST API Reference for PutConfigRule Operation</seealso>
        public virtual Task<PutConfigRuleResponse> PutConfigRuleAsync(PutConfigRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigRuleResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationAggregator

        internal virtual PutConfigurationAggregatorResponse PutConfigurationAggregator(PutConfigurationAggregatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationAggregatorResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationAggregatorResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationAggregator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationAggregator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationAggregator">REST API Reference for PutConfigurationAggregator Operation</seealso>
        public virtual Task<PutConfigurationAggregatorResponse> PutConfigurationAggregatorAsync(PutConfigurationAggregatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationAggregatorResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationAggregatorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationRecorder

        internal virtual PutConfigurationRecorderResponse PutConfigurationRecorder(PutConfigurationRecorderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationRecorderResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationRecorder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationRecorder">REST API Reference for PutConfigurationRecorder Operation</seealso>
        public virtual Task<PutConfigurationRecorderResponse> PutConfigurationRecorderAsync(PutConfigurationRecorderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationRecorderResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationRecorderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDeliveryChannel

        internal virtual PutDeliveryChannelResponse PutDeliveryChannel(PutDeliveryChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliveryChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliveryChannelResponseUnmarshaller.Instance;

            return Invoke<PutDeliveryChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutDeliveryChannel">REST API Reference for PutDeliveryChannel Operation</seealso>
        public virtual Task<PutDeliveryChannelResponse> PutDeliveryChannelAsync(PutDeliveryChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliveryChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliveryChannelResponseUnmarshaller.Instance;

            return InvokeAsync<PutDeliveryChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEvaluations

        internal virtual PutEvaluationsResponse PutEvaluations(PutEvaluationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEvaluationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEvaluationsResponseUnmarshaller.Instance;

            return Invoke<PutEvaluationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutEvaluations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvaluations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutEvaluations">REST API Reference for PutEvaluations Operation</seealso>
        public virtual Task<PutEvaluationsResponse> PutEvaluationsAsync(PutEvaluationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEvaluationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEvaluationsResponseUnmarshaller.Instance;

            return InvokeAsync<PutEvaluationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRetentionConfiguration

        internal virtual PutRetentionConfigurationResponse PutRetentionConfiguration(PutRetentionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutRetentionConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutRetentionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRetentionConfiguration">REST API Reference for PutRetentionConfiguration Operation</seealso>
        public virtual Task<PutRetentionConfigurationResponse> PutRetentionConfigurationAsync(PutRetentionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutRetentionConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartConfigRulesEvaluation

        internal virtual StartConfigRulesEvaluationResponse StartConfigRulesEvaluation(StartConfigRulesEvaluationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigRulesEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigRulesEvaluationResponseUnmarshaller.Instance;

            return Invoke<StartConfigRulesEvaluationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartConfigRulesEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConfigRulesEvaluation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigRulesEvaluation">REST API Reference for StartConfigRulesEvaluation Operation</seealso>
        public virtual Task<StartConfigRulesEvaluationResponse> StartConfigRulesEvaluationAsync(StartConfigRulesEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigRulesEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigRulesEvaluationResponseUnmarshaller.Instance;

            return InvokeAsync<StartConfigRulesEvaluationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartConfigurationRecorder

        internal virtual StartConfigurationRecorderResponse StartConfigurationRecorder(StartConfigurationRecorderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationRecorderResponse>(request, options);
        }


        /// <summary>
        /// Starts recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// 
        ///  
        /// <para>
        /// You must have created at least one delivery channel to successfully start the configuration
        /// recorder.
        /// </para>
        /// </summary>
        /// <param name="configurationRecorderName">The name of the recorder object that records each configuration change made to the resources.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableDeliveryChannelException">
        /// There is no delivery channel available to record configurations.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigurationRecorder">REST API Reference for StartConfigurationRecorder Operation</seealso>
        public virtual Task<StartConfigurationRecorderResponse> StartConfigurationRecorderAsync(string configurationRecorderName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new StartConfigurationRecorderRequest();
            request.ConfigurationRecorderName = configurationRecorderName;
            return StartConfigurationRecorderAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationRecorder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigurationRecorder">REST API Reference for StartConfigurationRecorder Operation</seealso>
        public virtual Task<StartConfigurationRecorderResponse> StartConfigurationRecorderAsync(StartConfigurationRecorderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationRecorderResponseUnmarshaller.Instance;

            return InvokeAsync<StartConfigurationRecorderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopConfigurationRecorder

        internal virtual StopConfigurationRecorderResponse StopConfigurationRecorder(StopConfigurationRecorderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<StopConfigurationRecorderResponse>(request, options);
        }


        /// <summary>
        /// Stops recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// </summary>
        /// <param name="configurationRecorderName">The name of the recorder object that records each configuration change made to the resources.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StopConfigurationRecorder">REST API Reference for StopConfigurationRecorder Operation</seealso>
        public virtual Task<StopConfigurationRecorderResponse> StopConfigurationRecorderAsync(string configurationRecorderName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new StopConfigurationRecorderRequest();
            request.ConfigurationRecorderName = configurationRecorderName;
            return StopConfigurationRecorderAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopConfigurationRecorder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StopConfigurationRecorder">REST API Reference for StopConfigurationRecorder Operation</seealso>
        public virtual Task<StopConfigurationRecorderResponse> StopConfigurationRecorderAsync(StopConfigurationRecorderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopConfigurationRecorderResponseUnmarshaller.Instance;

            return InvokeAsync<StopConfigurationRecorderResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}