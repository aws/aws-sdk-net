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
 * Do not modify this file. This file is generated from the sagemaker-metrics-2022-09-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SageMakerMetrics.Model;
using Amazon.SageMakerMetrics.Model.Internal.MarshallTransformations;
using Amazon.SageMakerMetrics.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SageMakerMetrics
{
    /// <summary>
    /// Implementation for accessing SageMakerMetrics
    ///
    /// Contains all data plane API operations and data types for Amazon SageMaker Metrics.
    /// Use these APIs to put and retrieve (get) features related to your training run.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_metrics_BatchPutMetrics.html">BatchPutMetrics</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonSageMakerMetricsClient : AmazonServiceClient, IAmazonSageMakerMetrics
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerMetricsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with the credentials loaded from the application's
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
        public AmazonSageMakerMetricsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerMetricsConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with the credentials loaded from the application's
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
        public AmazonSageMakerMetricsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerMetricsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSageMakerMetricsClient Configuration Object</param>
        public AmazonSageMakerMetricsClient(AmazonSageMakerMetricsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerMetricsClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerMetricsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerMetricsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerMetricsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with AWS Credentials and an
        /// AmazonSageMakerMetricsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerMetricsClient Configuration Object</param>
        public AmazonSageMakerMetricsClient(AWSCredentials credentials, AmazonSageMakerMetricsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerMetricsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerMetricsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerMetricsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerMetricsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerMetricsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerMetricsClient Configuration Object</param>
        public AmazonSageMakerMetricsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerMetricsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerMetricsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerMetricsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerMetricsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerMetricsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerMetricsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerMetricsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerMetricsClient Configuration Object</param>
        public AmazonSageMakerMetricsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerMetricsConfig clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerMetricsEndpointResolver());
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


        #region  BatchPutMetrics

        internal virtual BatchPutMetricsResponse BatchPutMetrics(BatchPutMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMetricsResponseUnmarshaller.Instance;

            return Invoke<BatchPutMetricsResponse>(request, options);
        }



        /// <summary>
        /// Used to ingest training metrics into SageMaker. These metrics can be visualized in
        /// SageMaker Studio and retrieved with the <code>GetMetrics</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutMetrics service method, as returned by SageMakerMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-metrics-2022-09-30/BatchPutMetrics">REST API Reference for BatchPutMetrics Operation</seealso>
        public virtual Task<BatchPutMetricsResponse> BatchPutMetricsAsync(BatchPutMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchPutMetricsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}