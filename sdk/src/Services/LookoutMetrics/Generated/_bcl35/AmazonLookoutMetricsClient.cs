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
using System.Collections.Generic;
using System.Net;

using Amazon.LookoutMetrics.Model;
using Amazon.LookoutMetrics.Model.Internal.MarshallTransformations;
using Amazon.LookoutMetrics.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLookoutMetricsConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLookoutMetricsConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLookoutMetricsEndpointResolver());
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

        /// <summary>
        /// Activates an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateAnomalyDetector service method.</param>
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
        public virtual ActivateAnomalyDetectorResponse ActivateAnomalyDetector(ActivateAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<ActivateAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ActivateAnomalyDetector">REST API Reference for ActivateAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginActivateAnomalyDetector(ActivateAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  ActivateAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ActivateAnomalyDetector">REST API Reference for ActivateAnomalyDetector Operation</seealso>
        public virtual ActivateAnomalyDetectorResponse EndActivateAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<ActivateAnomalyDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  BackTestAnomalyDetector

        /// <summary>
        /// Runs a backtest for anomaly detection for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BackTestAnomalyDetector service method.</param>
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
        public virtual BackTestAnomalyDetectorResponse BackTestAnomalyDetector(BackTestAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BackTestAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BackTestAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<BackTestAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BackTestAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BackTestAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBackTestAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/BackTestAnomalyDetector">REST API Reference for BackTestAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginBackTestAnomalyDetector(BackTestAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BackTestAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BackTestAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BackTestAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBackTestAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  BackTestAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/BackTestAnomalyDetector">REST API Reference for BackTestAnomalyDetector Operation</seealso>
        public virtual BackTestAnomalyDetectorResponse EndBackTestAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<BackTestAnomalyDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAlert

        /// <summary>
        /// Creates an alert for an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlert service method.</param>
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
        public virtual CreateAlertResponse CreateAlert(CreateAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlertResponseUnmarshaller.Instance;

            return Invoke<CreateAlertResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlert operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlert operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlert
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAlert">REST API Reference for CreateAlert Operation</seealso>
        public virtual IAsyncResult BeginCreateAlert(CreateAlertRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlertResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlert operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlert.</param>
        /// 
        /// <returns>Returns a  CreateAlertResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAlert">REST API Reference for CreateAlert Operation</seealso>
        public virtual CreateAlertResponse EndCreateAlert(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAlertResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAnomalyDetector

        /// <summary>
        /// Creates an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalyDetector service method.</param>
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
        public virtual CreateAnomalyDetectorResponse CreateAnomalyDetector(CreateAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<CreateAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAnomalyDetector">REST API Reference for CreateAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginCreateAnomalyDetector(CreateAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  CreateAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAnomalyDetector">REST API Reference for CreateAnomalyDetector Operation</seealso>
        public virtual CreateAnomalyDetectorResponse EndCreateAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAnomalyDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMetricSet

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMetricSet service method.</param>
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
        public virtual CreateMetricSetResponse CreateMetricSet(CreateMetricSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMetricSetResponseUnmarshaller.Instance;

            return Invoke<CreateMetricSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMetricSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMetricSet operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMetricSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateMetricSet">REST API Reference for CreateMetricSet Operation</seealso>
        public virtual IAsyncResult BeginCreateMetricSet(CreateMetricSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMetricSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMetricSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMetricSet.</param>
        /// 
        /// <returns>Returns a  CreateMetricSetResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateMetricSet">REST API Reference for CreateMetricSet Operation</seealso>
        public virtual CreateMetricSetResponse EndCreateMetricSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMetricSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeactivateAnomalyDetector

        /// <summary>
        /// Deactivates an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateAnomalyDetector service method.</param>
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
        public virtual DeactivateAnomalyDetectorResponse DeactivateAnomalyDetector(DeactivateAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<DeactivateAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeactivateAnomalyDetector">REST API Reference for DeactivateAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginDeactivateAnomalyDetector(DeactivateAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  DeactivateAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeactivateAnomalyDetector">REST API Reference for DeactivateAnomalyDetector Operation</seealso>
        public virtual DeactivateAnomalyDetectorResponse EndDeactivateAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeactivateAnomalyDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAlert

        /// <summary>
        /// Deletes an alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlert service method.</param>
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
        public virtual DeleteAlertResponse DeleteAlert(DeleteAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlertResponseUnmarshaller.Instance;

            return Invoke<DeleteAlertResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlert operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlert operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlert
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAlert">REST API Reference for DeleteAlert Operation</seealso>
        public virtual IAsyncResult BeginDeleteAlert(DeleteAlertRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlertResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlert operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlert.</param>
        /// 
        /// <returns>Returns a  DeleteAlertResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAlert">REST API Reference for DeleteAlert Operation</seealso>
        public virtual DeleteAlertResponse EndDeleteAlert(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAlertResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAnomalyDetector

        /// <summary>
        /// Deletes a detector. Deleting an anomaly detector will delete all of its corresponding
        /// resources including any configured datasets and alerts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyDetector service method.</param>
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
        public virtual DeleteAnomalyDetectorResponse DeleteAnomalyDetector(DeleteAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<DeleteAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAnomalyDetector">REST API Reference for DeleteAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginDeleteAnomalyDetector(DeleteAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  DeleteAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAnomalyDetector">REST API Reference for DeleteAnomalyDetector Operation</seealso>
        public virtual DeleteAnomalyDetectorResponse EndDeleteAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAnomalyDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAlert

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
        public virtual DescribeAlertResponse DescribeAlert(DescribeAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlertResponseUnmarshaller.Instance;

            return Invoke<DescribeAlertResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlert operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlert operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlert
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAlert">REST API Reference for DescribeAlert Operation</seealso>
        public virtual IAsyncResult BeginDescribeAlert(DescribeAlertRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlertResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlert operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlert.</param>
        /// 
        /// <returns>Returns a  DescribeAlertResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAlert">REST API Reference for DescribeAlert Operation</seealso>
        public virtual DescribeAlertResponse EndDescribeAlert(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAlertResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAnomalyDetectionExecutions

        /// <summary>
        /// Returns information about the status of the specified anomaly detection jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetectionExecutions service method.</param>
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
        public virtual DescribeAnomalyDetectionExecutionsResponse DescribeAnomalyDetectionExecutions(DescribeAnomalyDetectionExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyDetectionExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyDetectionExecutionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAnomalyDetectionExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnomalyDetectionExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetectionExecutions operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnomalyDetectionExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetectionExecutions">REST API Reference for DescribeAnomalyDetectionExecutions Operation</seealso>
        public virtual IAsyncResult BeginDescribeAnomalyDetectionExecutions(DescribeAnomalyDetectionExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyDetectionExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyDetectionExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnomalyDetectionExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnomalyDetectionExecutions.</param>
        /// 
        /// <returns>Returns a  DescribeAnomalyDetectionExecutionsResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetectionExecutions">REST API Reference for DescribeAnomalyDetectionExecutions Operation</seealso>
        public virtual DescribeAnomalyDetectionExecutionsResponse EndDescribeAnomalyDetectionExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAnomalyDetectionExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAnomalyDetector

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
        public virtual DescribeAnomalyDetectorResponse DescribeAnomalyDetector(DescribeAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<DescribeAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetector">REST API Reference for DescribeAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginDescribeAnomalyDetector(DescribeAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  DescribeAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetector">REST API Reference for DescribeAnomalyDetector Operation</seealso>
        public virtual DescribeAnomalyDetectorResponse EndDescribeAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAnomalyDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMetricSet

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
        public virtual DescribeMetricSetResponse DescribeMetricSet(DescribeMetricSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricSetResponseUnmarshaller.Instance;

            return Invoke<DescribeMetricSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricSet operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetricSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeMetricSet">REST API Reference for DescribeMetricSet Operation</seealso>
        public virtual IAsyncResult BeginDescribeMetricSet(DescribeMetricSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetricSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetricSet.</param>
        /// 
        /// <returns>Returns a  DescribeMetricSetResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeMetricSet">REST API Reference for DescribeMetricSet Operation</seealso>
        public virtual DescribeMetricSetResponse EndDescribeMetricSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMetricSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectMetricSetConfig

        /// <summary>
        /// Detects an Amazon S3 dataset's file format, interval, and offset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectMetricSetConfig service method.</param>
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
        public virtual DetectMetricSetConfigResponse DetectMetricSetConfig(DetectMetricSetConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectMetricSetConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectMetricSetConfigResponseUnmarshaller.Instance;

            return Invoke<DetectMetricSetConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectMetricSetConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectMetricSetConfig operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectMetricSetConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DetectMetricSetConfig">REST API Reference for DetectMetricSetConfig Operation</seealso>
        public virtual IAsyncResult BeginDetectMetricSetConfig(DetectMetricSetConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectMetricSetConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectMetricSetConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectMetricSetConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectMetricSetConfig.</param>
        /// 
        /// <returns>Returns a  DetectMetricSetConfigResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DetectMetricSetConfig">REST API Reference for DetectMetricSetConfig Operation</seealso>
        public virtual DetectMetricSetConfigResponse EndDetectMetricSetConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectMetricSetConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAnomalyGroup

        /// <summary>
        /// Returns details about a group of anomalous metrics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalyGroup service method.</param>
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
        public virtual GetAnomalyGroupResponse GetAnomalyGroup(GetAnomalyGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnomalyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnomalyGroupResponseUnmarshaller.Instance;

            return Invoke<GetAnomalyGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnomalyGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalyGroup operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnomalyGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetAnomalyGroup">REST API Reference for GetAnomalyGroup Operation</seealso>
        public virtual IAsyncResult BeginGetAnomalyGroup(GetAnomalyGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnomalyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnomalyGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnomalyGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnomalyGroup.</param>
        /// 
        /// <returns>Returns a  GetAnomalyGroupResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetAnomalyGroup">REST API Reference for GetAnomalyGroup Operation</seealso>
        public virtual GetAnomalyGroupResponse EndGetAnomalyGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAnomalyGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataQualityMetrics

        /// <summary>
        /// Returns details about the requested data quality metrics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityMetrics service method.</param>
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
        public virtual GetDataQualityMetricsResponse GetDataQualityMetrics(GetDataQualityMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataQualityMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityMetricsResponseUnmarshaller.Instance;

            return Invoke<GetDataQualityMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataQualityMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityMetrics operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataQualityMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetDataQualityMetrics">REST API Reference for GetDataQualityMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetDataQualityMetrics(GetDataQualityMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataQualityMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataQualityMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataQualityMetrics.</param>
        /// 
        /// <returns>Returns a  GetDataQualityMetricsResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetDataQualityMetrics">REST API Reference for GetDataQualityMetrics Operation</seealso>
        public virtual GetDataQualityMetricsResponse EndGetDataQualityMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataQualityMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFeedback

        /// <summary>
        /// Get feedback for an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeedback service method.</param>
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
        public virtual GetFeedbackResponse GetFeedback(GetFeedbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFeedbackResponseUnmarshaller.Instance;

            return Invoke<GetFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFeedback operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetFeedback">REST API Reference for GetFeedback Operation</seealso>
        public virtual IAsyncResult BeginGetFeedback(GetFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFeedback.</param>
        /// 
        /// <returns>Returns a  GetFeedbackResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetFeedback">REST API Reference for GetFeedback Operation</seealso>
        public virtual GetFeedbackResponse EndGetFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSampleData

        /// <summary>
        /// Returns a selection of sample records from an Amazon S3 datasource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampleData service method.</param>
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
        public virtual GetSampleDataResponse GetSampleData(GetSampleDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSampleDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSampleDataResponseUnmarshaller.Instance;

            return Invoke<GetSampleDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSampleData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSampleData operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSampleData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetSampleData">REST API Reference for GetSampleData Operation</seealso>
        public virtual IAsyncResult BeginGetSampleData(GetSampleDataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSampleDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSampleDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSampleData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSampleData.</param>
        /// 
        /// <returns>Returns a  GetSampleDataResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetSampleData">REST API Reference for GetSampleData Operation</seealso>
        public virtual GetSampleDataResponse EndGetSampleData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSampleDataResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAlerts

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
        public virtual ListAlertsResponse ListAlerts(ListAlertsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlertsResponseUnmarshaller.Instance;

            return Invoke<ListAlertsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlerts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlerts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        public virtual IAsyncResult BeginListAlerts(ListAlertsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlertsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlerts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlerts.</param>
        /// 
        /// <returns>Returns a  ListAlertsResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        public virtual ListAlertsResponse EndListAlerts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAlertsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAnomalyDetectors

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
        public virtual ListAnomalyDetectorsResponse ListAnomalyDetectors(ListAnomalyDetectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyDetectorsResponseUnmarshaller.Instance;

            return Invoke<ListAnomalyDetectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnomalyDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyDetectors operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnomalyDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyDetectors">REST API Reference for ListAnomalyDetectors Operation</seealso>
        public virtual IAsyncResult BeginListAnomalyDetectors(ListAnomalyDetectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyDetectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnomalyDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnomalyDetectors.</param>
        /// 
        /// <returns>Returns a  ListAnomalyDetectorsResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyDetectors">REST API Reference for ListAnomalyDetectors Operation</seealso>
        public virtual ListAnomalyDetectorsResponse EndListAnomalyDetectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAnomalyDetectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAnomalyGroupRelatedMetrics

        /// <summary>
        /// Returns a list of measures that are potential causes or effects of an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupRelatedMetrics service method.</param>
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
        public virtual ListAnomalyGroupRelatedMetricsResponse ListAnomalyGroupRelatedMetrics(ListAnomalyGroupRelatedMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupRelatedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupRelatedMetricsResponseUnmarshaller.Instance;

            return Invoke<ListAnomalyGroupRelatedMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnomalyGroupRelatedMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupRelatedMetrics operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnomalyGroupRelatedMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupRelatedMetrics">REST API Reference for ListAnomalyGroupRelatedMetrics Operation</seealso>
        public virtual IAsyncResult BeginListAnomalyGroupRelatedMetrics(ListAnomalyGroupRelatedMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupRelatedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupRelatedMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnomalyGroupRelatedMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnomalyGroupRelatedMetrics.</param>
        /// 
        /// <returns>Returns a  ListAnomalyGroupRelatedMetricsResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupRelatedMetrics">REST API Reference for ListAnomalyGroupRelatedMetrics Operation</seealso>
        public virtual ListAnomalyGroupRelatedMetricsResponse EndListAnomalyGroupRelatedMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAnomalyGroupRelatedMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAnomalyGroupSummaries

        /// <summary>
        /// Returns a list of anomaly groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupSummaries service method.</param>
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
        public virtual ListAnomalyGroupSummariesResponse ListAnomalyGroupSummaries(ListAnomalyGroupSummariesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupSummariesResponseUnmarshaller.Instance;

            return Invoke<ListAnomalyGroupSummariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnomalyGroupSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupSummaries operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnomalyGroupSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupSummaries">REST API Reference for ListAnomalyGroupSummaries Operation</seealso>
        public virtual IAsyncResult BeginListAnomalyGroupSummaries(ListAnomalyGroupSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnomalyGroupSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnomalyGroupSummaries.</param>
        /// 
        /// <returns>Returns a  ListAnomalyGroupSummariesResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupSummaries">REST API Reference for ListAnomalyGroupSummaries Operation</seealso>
        public virtual ListAnomalyGroupSummariesResponse EndListAnomalyGroupSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAnomalyGroupSummariesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAnomalyGroupTimeSeries

        /// <summary>
        /// Gets a list of anomalous metrics for a measure in an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupTimeSeries service method.</param>
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
        public virtual ListAnomalyGroupTimeSeriesResponse ListAnomalyGroupTimeSeries(ListAnomalyGroupTimeSeriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupTimeSeriesResponseUnmarshaller.Instance;

            return Invoke<ListAnomalyGroupTimeSeriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnomalyGroupTimeSeries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupTimeSeries operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnomalyGroupTimeSeries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupTimeSeries">REST API Reference for ListAnomalyGroupTimeSeries Operation</seealso>
        public virtual IAsyncResult BeginListAnomalyGroupTimeSeries(ListAnomalyGroupTimeSeriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalyGroupTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalyGroupTimeSeriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnomalyGroupTimeSeries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnomalyGroupTimeSeries.</param>
        /// 
        /// <returns>Returns a  ListAnomalyGroupTimeSeriesResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupTimeSeries">REST API Reference for ListAnomalyGroupTimeSeries Operation</seealso>
        public virtual ListAnomalyGroupTimeSeriesResponse EndListAnomalyGroupTimeSeries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAnomalyGroupTimeSeriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMetricSets

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
        public virtual ListMetricSetsResponse ListMetricSets(ListMetricSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetricSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricSetsResponseUnmarshaller.Instance;

            return Invoke<ListMetricSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetricSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetricSets operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetricSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListMetricSets">REST API Reference for ListMetricSets Operation</seealso>
        public virtual IAsyncResult BeginListMetricSets(ListMetricSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetricSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMetricSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetricSets.</param>
        /// 
        /// <returns>Returns a  ListMetricSetsResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListMetricSets">REST API Reference for ListMetricSets Operation</seealso>
        public virtual ListMetricSetsResponse EndListMetricSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMetricSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Gets a list of <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// for a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutFeedback

        /// <summary>
        /// Add feedback for an anomalous metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
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
        public virtual PutFeedbackResponse PutFeedback(PutFeedbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual IAsyncResult BeginPutFeedback(PutFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFeedback.</param>
        /// 
        /// <returns>Returns a  PutFeedbackResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual PutFeedbackResponse EndPutFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<PutFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// to a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// from a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAlert

        /// <summary>
        /// Make changes to an existing alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlert service method.</param>
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
        public virtual UpdateAlertResponse UpdateAlert(UpdateAlertRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAlertResponseUnmarshaller.Instance;

            return Invoke<UpdateAlertResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlert operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlert operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAlert
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateAlert">REST API Reference for UpdateAlert Operation</seealso>
        public virtual IAsyncResult BeginUpdateAlert(UpdateAlertRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAlertResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAlert operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAlert.</param>
        /// 
        /// <returns>Returns a  UpdateAlertResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateAlert">REST API Reference for UpdateAlert Operation</seealso>
        public virtual UpdateAlertResponse EndUpdateAlert(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAlertResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAnomalyDetector

        /// <summary>
        /// Updates a detector. After activation, you can only change a detector's ingestion delay
        /// and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalyDetector service method.</param>
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
        public virtual UpdateAnomalyDetectorResponse UpdateAnomalyDetector(UpdateAnomalyDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<UpdateAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateAnomalyDetector">REST API Reference for UpdateAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginUpdateAnomalyDetector(UpdateAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  UpdateAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateAnomalyDetector">REST API Reference for UpdateAnomalyDetector Operation</seealso>
        public virtual UpdateAnomalyDetectorResponse EndUpdateAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAnomalyDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMetricSet

        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMetricSet service method.</param>
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
        public virtual UpdateMetricSetResponse UpdateMetricSet(UpdateMetricSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMetricSetResponseUnmarshaller.Instance;

            return Invoke<UpdateMetricSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMetricSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMetricSet operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMetricSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateMetricSet">REST API Reference for UpdateMetricSet Operation</seealso>
        public virtual IAsyncResult BeginUpdateMetricSet(UpdateMetricSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMetricSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMetricSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMetricSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMetricSet.</param>
        /// 
        /// <returns>Returns a  UpdateMetricSetResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateMetricSet">REST API Reference for UpdateMetricSet Operation</seealso>
        public virtual UpdateMetricSetResponse EndUpdateMetricSet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMetricSetResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonLookoutMetricsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}