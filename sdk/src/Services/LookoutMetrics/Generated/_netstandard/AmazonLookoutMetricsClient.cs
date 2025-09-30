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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LookoutMetrics.Model;
using Amazon.LookoutMetrics.Model.Internal.MarshallTransformations;
using Amazon.LookoutMetrics.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.LookoutMetrics
{
    /// <summary>
    /// <para>Implementation for accessing LookoutMetrics</para>
    ///
    /// This is the <i>Amazon Lookout for Metrics API Reference</i>. For an introduction to
    /// the service with tutorials for getting started, visit <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev">Amazon
    /// Lookout for Metrics Developer Guide</a>.
    /// </summary>
    public partial class AmazonLookoutMetricsClient : AmazonServiceClient, IAmazonLookoutMetrics
    {
        private static IServiceMetadata serviceMetadata = new AmazonLookoutMetricsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with the credentials loaded from the application's
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
        public AmazonLookoutMetricsClient()
            : base(new AmazonLookoutMetricsConfig()) { }

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with the credentials loaded from the application's
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
        public AmazonLookoutMetricsClient(RegionEndpoint region)
            : base(new AmazonLookoutMetricsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLookoutMetricsClient Configuration Object</param>
        public AmazonLookoutMetricsClient(AmazonLookoutMetricsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLookoutMetricsClient(AWSCredentials credentials)
            : this(credentials, new AmazonLookoutMetricsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutMetricsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLookoutMetricsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with AWS Credentials and an
        /// AmazonLookoutMetricsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLookoutMetricsClient Configuration Object</param>
        public AmazonLookoutMetricsClient(AWSCredentials credentials, AmazonLookoutMetricsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLookoutMetricsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLookoutMetricsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutMetricsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLookoutMetricsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLookoutMetricsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLookoutMetricsClient Configuration Object</param>
        public AmazonLookoutMetricsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLookoutMetricsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLookoutMetricsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLookoutMetricsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutMetricsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLookoutMetricsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutMetricsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLookoutMetricsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLookoutMetricsClient Configuration Object</param>
        public AmazonLookoutMetricsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLookoutMetricsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ILookoutMetricsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILookoutMetricsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LookoutMetricsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLookoutMetricsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLookoutMetricsAuthSchemeHandler());
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


        #region  ActivateAnomalyDetector

        internal virtual ActivateAnomalyDetectorResponse ActivateAnomalyDetector(ActivateAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<ActivateAnomalyDetectorResponse>(request, options);
        }



        /// <summary>
        /// Activates an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ActivateAnomalyDetector">REST API Reference for ActivateAnomalyDetector Operation</seealso>
        public virtual Task<ActivateAnomalyDetectorResponse> ActivateAnomalyDetectorAsync(ActivateAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateAnomalyDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<ActivateAnomalyDetectorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BackTestAnomalyDetector

        internal virtual BackTestAnomalyDetectorResponse BackTestAnomalyDetector(BackTestAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BackTestAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BackTestAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<BackTestAnomalyDetectorResponse>(request, options);
        }



        /// <summary>
        /// Runs a backtest for anomaly detection for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BackTestAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BackTestAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/BackTestAnomalyDetector">REST API Reference for BackTestAnomalyDetector Operation</seealso>
        public virtual Task<BackTestAnomalyDetectorResponse> BackTestAnomalyDetectorAsync(BackTestAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BackTestAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BackTestAnomalyDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<BackTestAnomalyDetectorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAlert

        internal virtual CreateAlertResponse CreateAlert(CreateAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlertResponseUnmarshaller.Instance;

            return Invoke<CreateAlertResponse>(request, options);
        }



        /// <summary>
        /// Creates an alert for an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlert service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ServiceQuotaExceededException">
        /// The request exceeded the service's quotas. Check the service quotas and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAlert">REST API Reference for CreateAlert Operation</seealso>
        public virtual Task<CreateAlertResponse> CreateAlertAsync(CreateAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlertResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAlertResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAnomalyDetector

        internal virtual CreateAnomalyDetectorResponse CreateAnomalyDetector(CreateAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<CreateAnomalyDetectorResponse>(request, options);
        }



        /// <summary>
        /// Creates an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ServiceQuotaExceededException">
        /// The request exceeded the service's quotas. Check the service quotas and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAnomalyDetector">REST API Reference for CreateAnomalyDetector Operation</seealso>
        public virtual Task<CreateAnomalyDetectorResponse> CreateAnomalyDetectorAsync(CreateAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnomalyDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAnomalyDetectorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMetricSet

        internal virtual CreateMetricSetResponse CreateMetricSet(CreateMetricSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMetricSetResponseUnmarshaller.Instance;

            return Invoke<CreateMetricSetResponse>(request, options);
        }



        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMetricSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMetricSet service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ServiceQuotaExceededException">
        /// The request exceeded the service's quotas. Check the service quotas and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateMetricSet">REST API Reference for CreateMetricSet Operation</seealso>
        public virtual Task<CreateMetricSetResponse> CreateMetricSetAsync(CreateMetricSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMetricSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMetricSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeactivateAnomalyDetector

        internal virtual DeactivateAnomalyDetectorResponse DeactivateAnomalyDetector(DeactivateAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<DeactivateAnomalyDetectorResponse>(request, options);
        }



        /// <summary>
        /// Deactivates an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeactivateAnomalyDetector">REST API Reference for DeactivateAnomalyDetector Operation</seealso>
        public virtual Task<DeactivateAnomalyDetectorResponse> DeactivateAnomalyDetectorAsync(DeactivateAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateAnomalyDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivateAnomalyDetectorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAlert

        internal virtual DeleteAlertResponse DeleteAlert(DeleteAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlertResponseUnmarshaller.Instance;

            return Invoke<DeleteAlertResponse>(request, options);
        }



        /// <summary>
        /// Deletes an alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlert service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAlert">REST API Reference for DeleteAlert Operation</seealso>
        public virtual Task<DeleteAlertResponse> DeleteAlertAsync(DeleteAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlertResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAlertResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAnomalyDetector

        internal virtual DeleteAnomalyDetectorResponse DeleteAnomalyDetector(DeleteAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<DeleteAnomalyDetectorResponse>(request, options);
        }



        /// <summary>
        /// Deletes a detector. Deleting an anomaly detector will delete all of its corresponding
        /// resources including any configured datasets and alerts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAnomalyDetector">REST API Reference for DeleteAnomalyDetector Operation</seealso>
        public virtual Task<DeleteAnomalyDetectorResponse> DeleteAnomalyDetectorAsync(DeleteAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnomalyDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnomalyDetectorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAlert

        internal virtual DescribeAlertResponse DescribeAlert(DescribeAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlertResponseUnmarshaller.Instance;

            return Invoke<DescribeAlertResponse>(request, options);
        }



        /// <summary>
        /// Describes an alert.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlert service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAlert">REST API Reference for DescribeAlert Operation</seealso>
        public virtual Task<DescribeAlertResponse> DescribeAlertAsync(DescribeAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlertResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlertResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAnomalyDetectionExecutions

        internal virtual DescribeAnomalyDetectionExecutionsResponse DescribeAnomalyDetectionExecutions(DescribeAnomalyDetectionExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyDetectionExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyDetectionExecutionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAnomalyDetectionExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the status of the specified anomaly detection jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetectionExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnomalyDetectionExecutions service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetectionExecutions">REST API Reference for DescribeAnomalyDetectionExecutions Operation</seealso>
        public virtual Task<DescribeAnomalyDetectionExecutionsResponse> DescribeAnomalyDetectionExecutionsAsync(DescribeAnomalyDetectionExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyDetectionExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyDetectionExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAnomalyDetectionExecutionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAnomalyDetector

        internal virtual DescribeAnomalyDetectorResponse DescribeAnomalyDetector(DescribeAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<DescribeAnomalyDetectorResponse>(request, options);
        }



        /// <summary>
        /// Describes a detector.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetector">REST API Reference for DescribeAnomalyDetector Operation</seealso>
        public virtual Task<DescribeAnomalyDetectorResponse> DescribeAnomalyDetectorAsync(DescribeAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAnomalyDetectorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeMetricSet

        internal virtual DescribeMetricSetResponse DescribeMetricSet(DescribeMetricSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricSetResponseUnmarshaller.Instance;

            return Invoke<DescribeMetricSetResponse>(request, options);
        }



        /// <summary>
        /// Describes a dataset.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetricSet service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeMetricSet">REST API Reference for DescribeMetricSet Operation</seealso>
        public virtual Task<DescribeMetricSetResponse> DescribeMetricSetAsync(DescribeMetricSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMetricSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectMetricSetConfig

        internal virtual DetectMetricSetConfigResponse DetectMetricSetConfig(DetectMetricSetConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectMetricSetConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectMetricSetConfigResponseUnmarshaller.Instance;

            return Invoke<DetectMetricSetConfigResponse>(request, options);
        }



        /// <summary>
        /// Detects an Amazon S3 dataset's file format, interval, and offset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectMetricSetConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectMetricSetConfig service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DetectMetricSetConfig">REST API Reference for DetectMetricSetConfig Operation</seealso>
        public virtual Task<DetectMetricSetConfigResponse> DetectMetricSetConfigAsync(DetectMetricSetConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectMetricSetConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectMetricSetConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DetectMetricSetConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAnomalyGroup

        internal virtual GetAnomalyGroupResponse GetAnomalyGroup(GetAnomalyGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnomalyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnomalyGroupResponseUnmarshaller.Instance;

            return Invoke<GetAnomalyGroupResponse>(request, options);
        }



        /// <summary>
        /// Returns details about a group of anomalous metrics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnomalyGroup service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetAnomalyGroup">REST API Reference for GetAnomalyGroup Operation</seealso>
        public virtual Task<GetAnomalyGroupResponse> GetAnomalyGroupAsync(GetAnomalyGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnomalyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnomalyGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnomalyGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataQualityMetrics

        internal virtual GetDataQualityMetricsResponse GetDataQualityMetrics(GetDataQualityMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataQualityMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityMetricsResponseUnmarshaller.Instance;

            return Invoke<GetDataQualityMetricsResponse>(request, options);
        }



        /// <summary>
        /// Returns details about the requested data quality metrics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataQualityMetrics service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetDataQualityMetrics">REST API Reference for GetDataQualityMetrics Operation</seealso>
        public virtual Task<GetDataQualityMetricsResponse> GetDataQualityMetricsAsync(GetDataQualityMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataQualityMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataQualityMetricsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFeedback

        internal virtual GetFeedbackResponse GetFeedback(GetFeedbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFeedbackResponseUnmarshaller.Instance;

            return Invoke<GetFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Get feedback for an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFeedback service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetFeedback">REST API Reference for GetFeedback Operation</seealso>
        public virtual Task<GetFeedbackResponse> GetFeedbackAsync(GetFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<GetFeedbackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSampleData

        internal virtual GetSampleDataResponse GetSampleData(GetSampleDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSampleDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSampleDataResponseUnmarshaller.Instance;

            return Invoke<GetSampleDataResponse>(request, options);
        }



        /// <summary>
        /// Returns a selection of sample records from an Amazon S3 datasource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampleData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSampleData service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetSampleData">REST API Reference for GetSampleData Operation</seealso>
        public virtual Task<GetSampleDataResponse> GetSampleDataAsync(GetSampleDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSampleDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSampleDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetSampleDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAlerts

        internal virtual ListAlertsResponse ListAlerts(ListAlertsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlertsResponseUnmarshaller.Instance;

            return Invoke<ListAlertsResponse>(request, options);
        }



        /// <summary>
        /// Lists the alerts attached to a detector.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlerts service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        public virtual Task<ListAlertsResponse> ListAlertsAsync(ListAlertsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlertsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAlertsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnomalyDetectors

        internal virtual ListAnomalyDetectorsResponse ListAnomalyDetectors(ListAnomalyDetectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyDetectorsResponseUnmarshaller.Instance;

            return Invoke<ListAnomalyDetectorsResponse>(request, options);
        }



        /// <summary>
        /// Lists the detectors in the current AWS Region.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyDetectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomalyDetectors service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyDetectors">REST API Reference for ListAnomalyDetectors Operation</seealso>
        public virtual Task<ListAnomalyDetectorsResponse> ListAnomalyDetectorsAsync(ListAnomalyDetectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyDetectorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnomalyDetectorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnomalyGroupRelatedMetrics

        internal virtual ListAnomalyGroupRelatedMetricsResponse ListAnomalyGroupRelatedMetrics(ListAnomalyGroupRelatedMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupRelatedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupRelatedMetricsResponseUnmarshaller.Instance;

            return Invoke<ListAnomalyGroupRelatedMetricsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of measures that are potential causes or effects of an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupRelatedMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomalyGroupRelatedMetrics service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupRelatedMetrics">REST API Reference for ListAnomalyGroupRelatedMetrics Operation</seealso>
        public virtual Task<ListAnomalyGroupRelatedMetricsResponse> ListAnomalyGroupRelatedMetricsAsync(ListAnomalyGroupRelatedMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupRelatedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupRelatedMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnomalyGroupRelatedMetricsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnomalyGroupSummaries

        internal virtual ListAnomalyGroupSummariesResponse ListAnomalyGroupSummaries(ListAnomalyGroupSummariesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupSummariesResponseUnmarshaller.Instance;

            return Invoke<ListAnomalyGroupSummariesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of anomaly groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomalyGroupSummaries service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupSummaries">REST API Reference for ListAnomalyGroupSummaries Operation</seealso>
        public virtual Task<ListAnomalyGroupSummariesResponse> ListAnomalyGroupSummariesAsync(ListAnomalyGroupSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnomalyGroupSummariesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnomalyGroupTimeSeries

        internal virtual ListAnomalyGroupTimeSeriesResponse ListAnomalyGroupTimeSeries(ListAnomalyGroupTimeSeriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupTimeSeriesResponseUnmarshaller.Instance;

            return Invoke<ListAnomalyGroupTimeSeriesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of anomalous metrics for a measure in an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupTimeSeries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomalyGroupTimeSeries service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupTimeSeries">REST API Reference for ListAnomalyGroupTimeSeries Operation</seealso>
        public virtual Task<ListAnomalyGroupTimeSeriesResponse> ListAnomalyGroupTimeSeriesAsync(ListAnomalyGroupTimeSeriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupTimeSeriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnomalyGroupTimeSeriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMetricSets

        internal virtual ListMetricSetsResponse ListMetricSets(ListMetricSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetricSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricSetsResponseUnmarshaller.Instance;

            return Invoke<ListMetricSetsResponse>(request, options);
        }



        /// <summary>
        /// Lists the datasets in the current AWS Region.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetricSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMetricSets service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListMetricSets">REST API Reference for ListMetricSets Operation</seealso>
        public virtual Task<ListMetricSetsResponse> ListMetricSetsAsync(ListMetricSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetricSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMetricSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// for a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutFeedback

        internal virtual PutFeedbackResponse PutFeedback(PutFeedbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Add feedback for an anomalous metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFeedback service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual Task<PutFeedbackResponse> PutFeedbackAsync(PutFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<PutFeedbackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// to a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// from a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAlert

        internal virtual UpdateAlertResponse UpdateAlert(UpdateAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAlertResponseUnmarshaller.Instance;

            return Invoke<UpdateAlertResponse>(request, options);
        }



        /// <summary>
        /// Make changes to an existing alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlert service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateAlert">REST API Reference for UpdateAlert Operation</seealso>
        public virtual Task<UpdateAlertResponse> UpdateAlertAsync(UpdateAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAlertResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAlertResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAnomalyDetector

        internal virtual UpdateAnomalyDetectorResponse UpdateAnomalyDetector(UpdateAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<UpdateAnomalyDetectorResponse>(request, options);
        }



        /// <summary>
        /// Updates a detector. After activation, you can only change a detector's ingestion delay
        /// and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateAnomalyDetector">REST API Reference for UpdateAnomalyDetector Operation</seealso>
        public virtual Task<UpdateAnomalyDetectorResponse> UpdateAnomalyDetectorAsync(UpdateAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnomalyDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAnomalyDetectorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMetricSet

        internal virtual UpdateMetricSetResponse UpdateMetricSet(UpdateMetricSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMetricSetResponseUnmarshaller.Instance;

            return Invoke<UpdateMetricSetResponse>(request, options);
        }



        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMetricSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMetricSet service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ServiceQuotaExceededException">
        /// The request exceeded the service's quotas. Check the service quotas and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateMetricSet">REST API Reference for UpdateMetricSet Operation</seealso>
        public virtual Task<UpdateMetricSetResponse> UpdateMetricSetAsync(UpdateMetricSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMetricSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMetricSetResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}