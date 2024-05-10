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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudWatchRUM.Model;
using Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations;
using Amazon.CloudWatchRUM.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.CloudWatchRUM
{
    /// <summary>
    /// <para>Implementation for accessing CloudWatchRUM</para>
    ///
    /// With Amazon CloudWatch RUM, you can perform real-user monitoring to collect client-side
    /// data about your web application performance from actual user sessions in real time.
    /// The data collected includes page load times, client-side errors, and user behavior.
    /// When you view this data, you can see it all aggregated together and also see breakdowns
    /// by the browsers and devices that your customers use.
    /// 
    ///  
    /// <para>
    /// You can use the collected data to quickly identify and debug client-side performance
    /// issues. CloudWatch RUM helps you visualize anomalies in your application performance
    /// and find relevant debugging data such as error messages, stack traces, and user sessions.
    /// You can also use RUM to understand the range of end-user impact including the number
    /// of users, geolocations, and browsers used.
    /// </para>
    /// </summary>
    public partial class AmazonCloudWatchRUMClient : AmazonServiceClient, IAmazonCloudWatchRUM
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudWatchRUMMetadata();
        private ICloudWatchRUMPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudWatchRUMPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudWatchRUMPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with the credentials loaded from the application's
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
        public AmazonCloudWatchRUMClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchRUMConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with the credentials loaded from the application's
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
        public AmazonCloudWatchRUMClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchRUMConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudWatchRUMClient Configuration Object</param>
        public AmazonCloudWatchRUMClient(AmazonCloudWatchRUMConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudWatchRUMClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudWatchRUMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchRUMClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudWatchRUMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with AWS Credentials and an
        /// AmazonCloudWatchRUMClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchRUMClient Configuration Object</param>
        public AmazonCloudWatchRUMClient(AWSCredentials credentials, AmazonCloudWatchRUMConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudWatchRUMClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchRUMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchRUMClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchRUMConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchRUMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchRUMClient Configuration Object</param>
        public AmazonCloudWatchRUMClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchRUMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudWatchRUMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchRUMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchRUMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchRUMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchRUMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchRUMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchRUMClient Configuration Object</param>
        public AmazonCloudWatchRUMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchRUMConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudWatchRUMEndpointResolver());
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


        #region  BatchCreateRumMetricDefinitions


        /// <summary>
        /// Specifies the extended metrics and custom metrics that you want a CloudWatch RUM app
        /// monitor to send to a destination. Valid destinations include CloudWatch and Evidently.
        /// 
        ///  
        /// <para>
        /// By default, RUM app monitors send some metrics to CloudWatch. These default metrics
        /// are listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-metrics.html">CloudWatch
        /// metrics that you can collect with CloudWatch RUM</a>.
        /// </para>
        ///  
        /// <para>
        /// In addition to these default metrics, you can choose to send extended metrics, custom
        /// metrics, or both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Extended metrics let you send metrics with additional dimensions that aren't included
        /// in the default metrics. You can also send extended metrics to both Evidently and CloudWatch.
        /// The valid dimension names for the additional dimensions for extended metrics are <c>BrowserName</c>,
        /// <c>CountryCode</c>, <c>DeviceType</c>, <c>FileType</c>, <c>OSName</c>, and <c>PageId</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-vended-metrics.html">
        /// Extended metrics that you can send to CloudWatch and CloudWatch Evidently</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Custom metrics are metrics that you define. You can send custom metrics to CloudWatch.
        /// CloudWatch Evidently, or both. With custom metrics, you can use any metric name and
        /// namespace. To derive the metrics, you can use any custom events, built-in events,
        /// custom attributes, or default attributes. 
        /// </para>
        ///  
        /// <para>
        /// You can't send custom metrics to the <c>AWS/RUM</c> namespace. You must send custom
        /// metrics to a custom namespace that you define. The namespace that you use can't start
        /// with <c>AWS/</c>. CloudWatch RUM prepends <c>RUM/CustomMetrics/</c> to the custom
        /// namespace that you define, so the final namespace for your metrics in CloudWatch is
        /// <c>RUM/CustomMetrics/<i>your-custom-namespace</i> </c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The maximum number of metric definitions that you can specify in one <c>BatchCreateRumMetricDefinitions</c>
        /// operation is 200.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of metric definitions that one destination can contain is 2000.
        /// </para>
        ///  
        /// <para>
        /// Extended metrics sent to CloudWatch and RUM custom metrics are charged as CloudWatch
        /// custom metrics. Each combination of additional dimension name and dimension value
        /// counts as a custom metric. For more information, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// You must have already created a destination for the metrics before you send them.
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_PutRumMetricsDestination.html">PutRumMetricsDestination</a>.
        /// </para>
        ///  
        /// <para>
        /// If some metric definitions specified in a <c>BatchCreateRumMetricDefinitions</c> operations
        /// are not valid, those metric definitions fail and return errors, but all valid metric
        /// definitions in the same operation still succeed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateRumMetricDefinitions service method.</param>
        /// 
        /// <returns>The response from the BatchCreateRumMetricDefinitions service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/BatchCreateRumMetricDefinitions">REST API Reference for BatchCreateRumMetricDefinitions Operation</seealso>
        public virtual BatchCreateRumMetricDefinitionsResponse BatchCreateRumMetricDefinitions(BatchCreateRumMetricDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateRumMetricDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateRumMetricDefinitionsResponseUnmarshaller.Instance;

            return Invoke<BatchCreateRumMetricDefinitionsResponse>(request, options);
        }


        /// <summary>
        /// Specifies the extended metrics and custom metrics that you want a CloudWatch RUM app
        /// monitor to send to a destination. Valid destinations include CloudWatch and Evidently.
        /// 
        ///  
        /// <para>
        /// By default, RUM app monitors send some metrics to CloudWatch. These default metrics
        /// are listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-metrics.html">CloudWatch
        /// metrics that you can collect with CloudWatch RUM</a>.
        /// </para>
        ///  
        /// <para>
        /// In addition to these default metrics, you can choose to send extended metrics, custom
        /// metrics, or both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Extended metrics let you send metrics with additional dimensions that aren't included
        /// in the default metrics. You can also send extended metrics to both Evidently and CloudWatch.
        /// The valid dimension names for the additional dimensions for extended metrics are <c>BrowserName</c>,
        /// <c>CountryCode</c>, <c>DeviceType</c>, <c>FileType</c>, <c>OSName</c>, and <c>PageId</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-vended-metrics.html">
        /// Extended metrics that you can send to CloudWatch and CloudWatch Evidently</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Custom metrics are metrics that you define. You can send custom metrics to CloudWatch.
        /// CloudWatch Evidently, or both. With custom metrics, you can use any metric name and
        /// namespace. To derive the metrics, you can use any custom events, built-in events,
        /// custom attributes, or default attributes. 
        /// </para>
        ///  
        /// <para>
        /// You can't send custom metrics to the <c>AWS/RUM</c> namespace. You must send custom
        /// metrics to a custom namespace that you define. The namespace that you use can't start
        /// with <c>AWS/</c>. CloudWatch RUM prepends <c>RUM/CustomMetrics/</c> to the custom
        /// namespace that you define, so the final namespace for your metrics in CloudWatch is
        /// <c>RUM/CustomMetrics/<i>your-custom-namespace</i> </c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The maximum number of metric definitions that you can specify in one <c>BatchCreateRumMetricDefinitions</c>
        /// operation is 200.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of metric definitions that one destination can contain is 2000.
        /// </para>
        ///  
        /// <para>
        /// Extended metrics sent to CloudWatch and RUM custom metrics are charged as CloudWatch
        /// custom metrics. Each combination of additional dimension name and dimension value
        /// counts as a custom metric. For more information, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// You must have already created a destination for the metrics before you send them.
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_PutRumMetricsDestination.html">PutRumMetricsDestination</a>.
        /// </para>
        ///  
        /// <para>
        /// If some metric definitions specified in a <c>BatchCreateRumMetricDefinitions</c> operations
        /// are not valid, those metric definitions fail and return errors, but all valid metric
        /// definitions in the same operation still succeed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateRumMetricDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateRumMetricDefinitions service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/BatchCreateRumMetricDefinitions">REST API Reference for BatchCreateRumMetricDefinitions Operation</seealso>
        public virtual Task<BatchCreateRumMetricDefinitionsResponse> BatchCreateRumMetricDefinitionsAsync(BatchCreateRumMetricDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateRumMetricDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateRumMetricDefinitionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchCreateRumMetricDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteRumMetricDefinitions


        /// <summary>
        /// Removes the specified metrics from being sent to an extended metrics destination.
        /// 
        ///  
        /// <para>
        /// If some metric definition IDs specified in a <c>BatchDeleteRumMetricDefinitions</c>
        /// operations are not valid, those metric definitions fail and return errors, but all
        /// valid metric definition IDs in the same operation are still deleted.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of metric definitions that you can specify in one <c>BatchDeleteRumMetricDefinitions</c>
        /// operation is 200.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteRumMetricDefinitions service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteRumMetricDefinitions service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/BatchDeleteRumMetricDefinitions">REST API Reference for BatchDeleteRumMetricDefinitions Operation</seealso>
        public virtual BatchDeleteRumMetricDefinitionsResponse BatchDeleteRumMetricDefinitions(BatchDeleteRumMetricDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteRumMetricDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteRumMetricDefinitionsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteRumMetricDefinitionsResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified metrics from being sent to an extended metrics destination.
        /// 
        ///  
        /// <para>
        /// If some metric definition IDs specified in a <c>BatchDeleteRumMetricDefinitions</c>
        /// operations are not valid, those metric definitions fail and return errors, but all
        /// valid metric definition IDs in the same operation are still deleted.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of metric definitions that you can specify in one <c>BatchDeleteRumMetricDefinitions</c>
        /// operation is 200.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteRumMetricDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteRumMetricDefinitions service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/BatchDeleteRumMetricDefinitions">REST API Reference for BatchDeleteRumMetricDefinitions Operation</seealso>
        public virtual Task<BatchDeleteRumMetricDefinitionsResponse> BatchDeleteRumMetricDefinitionsAsync(BatchDeleteRumMetricDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteRumMetricDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteRumMetricDefinitionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDeleteRumMetricDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetRumMetricDefinitions


        /// <summary>
        /// Retrieves the list of metrics and dimensions that a RUM app monitor is sending to
        /// a single destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRumMetricDefinitions service method.</param>
        /// 
        /// <returns>The response from the BatchGetRumMetricDefinitions service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/BatchGetRumMetricDefinitions">REST API Reference for BatchGetRumMetricDefinitions Operation</seealso>
        public virtual BatchGetRumMetricDefinitionsResponse BatchGetRumMetricDefinitions(BatchGetRumMetricDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetRumMetricDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRumMetricDefinitionsResponseUnmarshaller.Instance;

            return Invoke<BatchGetRumMetricDefinitionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the list of metrics and dimensions that a RUM app monitor is sending to
        /// a single destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRumMetricDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetRumMetricDefinitions service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/BatchGetRumMetricDefinitions">REST API Reference for BatchGetRumMetricDefinitions Operation</seealso>
        public virtual Task<BatchGetRumMetricDefinitionsResponse> BatchGetRumMetricDefinitionsAsync(BatchGetRumMetricDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetRumMetricDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRumMetricDefinitionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetRumMetricDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAppMonitor


        /// <summary>
        /// Creates a Amazon CloudWatch RUM app monitor, which collects telemetry data from your
        /// application and sends that data to RUM. The data includes performance and reliability
        /// information such as page load time, client-side errors, and user behavior.
        /// 
        ///  
        /// <para>
        /// You use this operation only to create a new app monitor. To update an existing app
        /// monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_UpdateAppMonitor.html">UpdateAppMonitor</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// After you create an app monitor, sign in to the CloudWatch RUM console to get the
        /// JavaScript code snippet to add to your web application. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-find-code-snippet.html">How
        /// do I find a code snippet that I've already generated?</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppMonitor service method.</param>
        /// 
        /// <returns>The response from the CreateAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/CreateAppMonitor">REST API Reference for CreateAppMonitor Operation</seealso>
        public virtual CreateAppMonitorResponse CreateAppMonitor(CreateAppMonitorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppMonitorResponseUnmarshaller.Instance;

            return Invoke<CreateAppMonitorResponse>(request, options);
        }


        /// <summary>
        /// Creates a Amazon CloudWatch RUM app monitor, which collects telemetry data from your
        /// application and sends that data to RUM. The data includes performance and reliability
        /// information such as page load time, client-side errors, and user behavior.
        /// 
        ///  
        /// <para>
        /// You use this operation only to create a new app monitor. To update an existing app
        /// monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_UpdateAppMonitor.html">UpdateAppMonitor</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// After you create an app monitor, sign in to the CloudWatch RUM console to get the
        /// JavaScript code snippet to add to your web application. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-find-code-snippet.html">How
        /// do I find a code snippet that I've already generated?</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/CreateAppMonitor">REST API Reference for CreateAppMonitor Operation</seealso>
        public virtual Task<CreateAppMonitorResponse> CreateAppMonitorAsync(CreateAppMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAppMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppMonitor


        /// <summary>
        /// Deletes an existing app monitor. This immediately stops the collection of data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppMonitor service method.</param>
        /// 
        /// <returns>The response from the DeleteAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/DeleteAppMonitor">REST API Reference for DeleteAppMonitor Operation</seealso>
        public virtual DeleteAppMonitorResponse DeleteAppMonitor(DeleteAppMonitorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppMonitorResponseUnmarshaller.Instance;

            return Invoke<DeleteAppMonitorResponse>(request, options);
        }


        /// <summary>
        /// Deletes an existing app monitor. This immediately stops the collection of data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/DeleteAppMonitor">REST API Reference for DeleteAppMonitor Operation</seealso>
        public virtual Task<DeleteAppMonitorResponse> DeleteAppMonitorAsync(DeleteAppMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAppMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRumMetricsDestination


        /// <summary>
        /// Deletes a destination for CloudWatch RUM extended metrics, so that the specified app
        /// monitor stops sending extended metrics to that destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRumMetricsDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteRumMetricsDestination service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/DeleteRumMetricsDestination">REST API Reference for DeleteRumMetricsDestination Operation</seealso>
        public virtual DeleteRumMetricsDestinationResponse DeleteRumMetricsDestination(DeleteRumMetricsDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRumMetricsDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRumMetricsDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteRumMetricsDestinationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a destination for CloudWatch RUM extended metrics, so that the specified app
        /// monitor stops sending extended metrics to that destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRumMetricsDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRumMetricsDestination service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/DeleteRumMetricsDestination">REST API Reference for DeleteRumMetricsDestination Operation</seealso>
        public virtual Task<DeleteRumMetricsDestinationResponse> DeleteRumMetricsDestinationAsync(DeleteRumMetricsDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRumMetricsDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRumMetricsDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRumMetricsDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAppMonitor


        /// <summary>
        /// Retrieves the complete configuration information for one app monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppMonitor service method.</param>
        /// 
        /// <returns>The response from the GetAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/GetAppMonitor">REST API Reference for GetAppMonitor Operation</seealso>
        public virtual GetAppMonitorResponse GetAppMonitor(GetAppMonitorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppMonitorResponseUnmarshaller.Instance;

            return Invoke<GetAppMonitorResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the complete configuration information for one app monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/GetAppMonitor">REST API Reference for GetAppMonitor Operation</seealso>
        public virtual Task<GetAppMonitorResponse> GetAppMonitorAsync(GetAppMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAppMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAppMonitorData


        /// <summary>
        /// Retrieves the raw performance events that RUM has collected from your web application,
        /// so that you can do your own processing or analysis of this data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppMonitorData service method.</param>
        /// 
        /// <returns>The response from the GetAppMonitorData service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/GetAppMonitorData">REST API Reference for GetAppMonitorData Operation</seealso>
        public virtual GetAppMonitorDataResponse GetAppMonitorData(GetAppMonitorDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppMonitorDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppMonitorDataResponseUnmarshaller.Instance;

            return Invoke<GetAppMonitorDataResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the raw performance events that RUM has collected from your web application,
        /// so that you can do your own processing or analysis of this data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppMonitorData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppMonitorData service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/GetAppMonitorData">REST API Reference for GetAppMonitorData Operation</seealso>
        public virtual Task<GetAppMonitorDataResponse> GetAppMonitorDataAsync(GetAppMonitorDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppMonitorDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppMonitorDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAppMonitorDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppMonitors


        /// <summary>
        /// Returns a list of the Amazon CloudWatch RUM app monitors in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppMonitors service method.</param>
        /// 
        /// <returns>The response from the ListAppMonitors service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListAppMonitors">REST API Reference for ListAppMonitors Operation</seealso>
        public virtual ListAppMonitorsResponse ListAppMonitors(ListAppMonitorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppMonitorsResponseUnmarshaller.Instance;

            return Invoke<ListAppMonitorsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the Amazon CloudWatch RUM app monitors in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppMonitors service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListAppMonitors">REST API Reference for ListAppMonitors Operation</seealso>
        public virtual Task<ListAppMonitorsResponse> ListAppMonitorsAsync(ListAppMonitorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppMonitorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAppMonitorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRumMetricsDestinations


        /// <summary>
        /// Returns a list of destinations that you have created to receive RUM extended metrics,
        /// for the specified app monitor.
        /// 
        ///  
        /// <para>
        /// For more information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_AddRumMetrcs.html">AddRumMetrics</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRumMetricsDestinations service method.</param>
        /// 
        /// <returns>The response from the ListRumMetricsDestinations service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListRumMetricsDestinations">REST API Reference for ListRumMetricsDestinations Operation</seealso>
        public virtual ListRumMetricsDestinationsResponse ListRumMetricsDestinations(ListRumMetricsDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRumMetricsDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRumMetricsDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListRumMetricsDestinationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of destinations that you have created to receive RUM extended metrics,
        /// for the specified app monitor.
        /// 
        ///  
        /// <para>
        /// For more information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_AddRumMetrcs.html">AddRumMetrics</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRumMetricsDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRumMetricsDestinations service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListRumMetricsDestinations">REST API Reference for ListRumMetricsDestinations Operation</seealso>
        public virtual Task<ListRumMetricsDestinationsResponse> ListRumMetricsDestinationsAsync(ListRumMetricsDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRumMetricsDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRumMetricsDestinationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRumMetricsDestinationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with a CloudWatch RUM resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Displays the tags associated with a CloudWatch RUM resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRumEvents


        /// <summary>
        /// Sends telemetry events about your application performance and user behavior to CloudWatch
        /// RUM. The code snippet that RUM generates for you to add to your application includes
        /// <c>PutRumEvents</c> operations to send this data to RUM.
        /// 
        ///  
        /// <para>
        /// Each <c>PutRumEvents</c> operation can send a batch of events from one user session.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRumEvents service method.</param>
        /// 
        /// <returns>The response from the PutRumEvents service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/PutRumEvents">REST API Reference for PutRumEvents Operation</seealso>
        public virtual PutRumEventsResponse PutRumEvents(PutRumEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRumEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRumEventsResponseUnmarshaller.Instance;

            return Invoke<PutRumEventsResponse>(request, options);
        }


        /// <summary>
        /// Sends telemetry events about your application performance and user behavior to CloudWatch
        /// RUM. The code snippet that RUM generates for you to add to your application includes
        /// <c>PutRumEvents</c> operations to send this data to RUM.
        /// 
        ///  
        /// <para>
        /// Each <c>PutRumEvents</c> operation can send a batch of events from one user session.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRumEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRumEvents service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/PutRumEvents">REST API Reference for PutRumEvents Operation</seealso>
        public virtual Task<PutRumEventsResponse> PutRumEventsAsync(PutRumEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRumEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRumEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutRumEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRumMetricsDestination


        /// <summary>
        /// Creates or updates a destination to receive extended metrics from CloudWatch RUM.
        /// You can send extended metrics to CloudWatch or to a CloudWatch Evidently experiment.
        /// 
        ///  
        /// <para>
        /// For more information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_BatchCreateRumMetricDefinitions.html">BatchCreateRumMetricDefinitions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRumMetricsDestination service method.</param>
        /// 
        /// <returns>The response from the PutRumMetricsDestination service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/PutRumMetricsDestination">REST API Reference for PutRumMetricsDestination Operation</seealso>
        public virtual PutRumMetricsDestinationResponse PutRumMetricsDestination(PutRumMetricsDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRumMetricsDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRumMetricsDestinationResponseUnmarshaller.Instance;

            return Invoke<PutRumMetricsDestinationResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates a destination to receive extended metrics from CloudWatch RUM.
        /// You can send extended metrics to CloudWatch or to a CloudWatch Evidently experiment.
        /// 
        ///  
        /// <para>
        /// For more information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_BatchCreateRumMetricDefinitions.html">BatchCreateRumMetricDefinitions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRumMetricsDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRumMetricsDestination service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/PutRumMetricsDestination">REST API Reference for PutRumMetricsDestination Operation</seealso>
        public virtual Task<PutRumMetricsDestinationResponse> PutRumMetricsDestinationAsync(PutRumMetricsDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRumMetricsDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRumMetricsDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutRumMetricsDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch RUM resource.
        /// Currently, the only resources that can be tagged app monitors.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>TagResource</c> action with a resource that already has tags. If
        /// you specify a new tag key for the resource, this tag is appended to the list of tags
        /// associated with the alarm. If you specify a tag key that is already associated with
        /// the resource, the new tag value that you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch RUM resource.
        /// Currently, the only resources that can be tagged app monitors.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>TagResource</c> action with a resource that already has tags. If
        /// you specify a new tag key for the resource, this tag is appended to the list of tags
        /// associated with the alarm. If you specify a tag key that is already associated with
        /// the resource, the new tag value that you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAppMonitor


        /// <summary>
        /// Updates the configuration of an existing app monitor. When you use this operation,
        /// only the parts of the app monitor configuration that you specify in this operation
        /// are changed. For any parameters that you omit, the existing values are kept.
        /// 
        ///  
        /// <para>
        /// You can't use this operation to change the tags of an existing app monitor. To change
        /// the tags of an existing app monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a new app monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_CreateAppMonitor.html">CreateAppMonitor</a>.
        /// </para>
        ///  
        /// <para>
        /// After you update an app monitor, sign in to the CloudWatch RUM console to get the
        /// updated JavaScript code snippet to add to your web application. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-find-code-snippet.html">How
        /// do I find a code snippet that I've already generated?</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppMonitor service method.</param>
        /// 
        /// <returns>The response from the UpdateAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UpdateAppMonitor">REST API Reference for UpdateAppMonitor Operation</seealso>
        public virtual UpdateAppMonitorResponse UpdateAppMonitor(UpdateAppMonitorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppMonitorResponseUnmarshaller.Instance;

            return Invoke<UpdateAppMonitorResponse>(request, options);
        }


        /// <summary>
        /// Updates the configuration of an existing app monitor. When you use this operation,
        /// only the parts of the app monitor configuration that you specify in this operation
        /// are changed. For any parameters that you omit, the existing values are kept.
        /// 
        ///  
        /// <para>
        /// You can't use this operation to change the tags of an existing app monitor. To change
        /// the tags of an existing app monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a new app monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_CreateAppMonitor.html">CreateAppMonitor</a>.
        /// </para>
        ///  
        /// <para>
        /// After you update an app monitor, sign in to the CloudWatch RUM console to get the
        /// updated JavaScript code snippet to add to your web application. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-find-code-snippet.html">How
        /// do I find a code snippet that I've already generated?</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UpdateAppMonitor">REST API Reference for UpdateAppMonitor Operation</seealso>
        public virtual Task<UpdateAppMonitorResponse> UpdateAppMonitorAsync(UpdateAppMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAppMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRumMetricDefinition


        /// <summary>
        /// Modifies one existing metric definition for CloudWatch RUM extended metrics. For more
        /// information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_BatchCreateRumMetricsDefinitions.html">BatchCreateRumMetricsDefinitions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRumMetricDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateRumMetricDefinition service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UpdateRumMetricDefinition">REST API Reference for UpdateRumMetricDefinition Operation</seealso>
        public virtual UpdateRumMetricDefinitionResponse UpdateRumMetricDefinition(UpdateRumMetricDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRumMetricDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRumMetricDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateRumMetricDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Modifies one existing metric definition for CloudWatch RUM extended metrics. For more
        /// information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_BatchCreateRumMetricsDefinitions.html">BatchCreateRumMetricsDefinitions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRumMetricDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRumMetricDefinition service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UpdateRumMetricDefinition">REST API Reference for UpdateRumMetricDefinition Operation</seealso>
        public virtual Task<UpdateRumMetricDefinitionResponse> UpdateRumMetricDefinitionAsync(UpdateRumMetricDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRumMetricDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRumMetricDefinitionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRumMetricDefinitionResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonCloudWatchRUMEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}