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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.CodeGuruProfiler.Model;
using Amazon.CodeGuruProfiler.Model.Internal.MarshallTransformations;
using Amazon.CodeGuruProfiler.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeGuruProfiler
{
    /// <summary>
    /// Implementation for accessing CodeGuruProfiler
    ///
    /// This section provides documentation for the Amazon CodeGuru Profiler API operations.
    /// 
    ///  <pre><code> &lt;p&gt;Amazon CodeGuru Profiler collects runtime performance data from
    /// your live applications, and provides recommendations that can help you fine-tune your
    /// application performance. Using machine learning algorithms, CodeGuru Profiler can
    /// help you find your most expensive lines of code and suggest ways you can improve efficiency
    /// and remove CPU bottlenecks. &lt;/p&gt; &lt;p&gt;Amazon CodeGuru Profiler provides
    /// different visualizations of profiling data to help you identify what code is running
    /// on the CPU, see how much time is consumed, and suggest ways to reduce CPU utilization.
    /// &lt;/p&gt; &lt;note&gt; &lt;p&gt;Amazon CodeGuru Profiler currently supports applications
    /// written in all Java virtual machine (JVM) languages. While CodeGuru Profiler supports
    /// both visualizations and recommendations for applications written in Java, it can also
    /// generate visualizations and a subset of recommendations for applications written in
    /// other JVM languages.&lt;/p&gt; &lt;/note&gt; &lt;p&gt; For more information, see &lt;a
    /// href=&quot;https://docs.aws.amazon.com/codeguru/latest/profiler-ug/what-is-codeguru-profiler.html&quot;&gt;What
    /// is Amazon CodeGuru Profiler&lt;/a&gt; in the &lt;i&gt;Amazon CodeGuru Profiler User
    /// Guide&lt;/i&gt;. &lt;/p&gt; </code></pre>
    /// </summary>
    public partial class AmazonCodeGuruProfilerClient : AmazonServiceClient, IAmazonCodeGuruProfiler
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeGuruProfilerMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with the credentials loaded from the application's
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
        public AmazonCodeGuruProfilerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeGuruProfilerConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with the credentials loaded from the application's
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
        public AmazonCodeGuruProfilerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeGuruProfilerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCodeGuruProfilerClient Configuration Object</param>
        public AmazonCodeGuruProfilerClient(AmazonCodeGuruProfilerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeGuruProfilerClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeGuruProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruProfilerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeGuruProfilerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Credentials and an
        /// AmazonCodeGuruProfilerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeGuruProfilerClient Configuration Object</param>
        public AmazonCodeGuruProfilerClient(AWSCredentials credentials, AmazonCodeGuruProfilerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeGuruProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeGuruProfilerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeGuruProfilerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeGuruProfilerClient Configuration Object</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeGuruProfilerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeGuruProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeGuruProfilerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeGuruProfilerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeGuruProfilerClient Configuration Object</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeGuruProfilerConfig clientConfig)
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


        #region  AddNotificationChannels

        /// <summary>
        /// Add up to 2 anomaly notifications channels for a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddNotificationChannels service method.</param>
        /// 
        /// <returns>The response from the AddNotificationChannels service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/intro.html">Service
        /// Quotas</a> to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/AddNotificationChannels">REST API Reference for AddNotificationChannels Operation</seealso>
        public virtual AddNotificationChannelsResponse AddNotificationChannels(AddNotificationChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddNotificationChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddNotificationChannelsResponseUnmarshaller.Instance;

            return Invoke<AddNotificationChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddNotificationChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddNotificationChannels operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddNotificationChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/AddNotificationChannels">REST API Reference for AddNotificationChannels Operation</seealso>
        public virtual IAsyncResult BeginAddNotificationChannels(AddNotificationChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddNotificationChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddNotificationChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddNotificationChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddNotificationChannels.</param>
        /// 
        /// <returns>Returns a  AddNotificationChannelsResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/AddNotificationChannels">REST API Reference for AddNotificationChannels Operation</seealso>
        public virtual AddNotificationChannelsResponse EndAddNotificationChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<AddNotificationChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetFrameMetricData

        /// <summary>
        /// Returns the time series of values for a requested list of frame metrics from a time
        /// period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFrameMetricData service method.</param>
        /// 
        /// <returns>The response from the BatchGetFrameMetricData service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/BatchGetFrameMetricData">REST API Reference for BatchGetFrameMetricData Operation</seealso>
        public virtual BatchGetFrameMetricDataResponse BatchGetFrameMetricData(BatchGetFrameMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetFrameMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFrameMetricDataResponseUnmarshaller.Instance;

            return Invoke<BatchGetFrameMetricDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetFrameMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFrameMetricData operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetFrameMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/BatchGetFrameMetricData">REST API Reference for BatchGetFrameMetricData Operation</seealso>
        public virtual IAsyncResult BeginBatchGetFrameMetricData(BatchGetFrameMetricDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetFrameMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFrameMetricDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetFrameMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetFrameMetricData.</param>
        /// 
        /// <returns>Returns a  BatchGetFrameMetricDataResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/BatchGetFrameMetricData">REST API Reference for BatchGetFrameMetricData Operation</seealso>
        public virtual BatchGetFrameMetricDataResponse EndBatchGetFrameMetricData(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetFrameMetricDataResponse>(asyncResult);
        }

        #endregion
        
        #region  ConfigureAgent

        /// <summary>
        /// Used by profiler agents to report their current state and to receive remote configuration
        /// updates. For example, <code>ConfigureAgent</code> can be used to tell and agent whether
        /// to profile or not and for how long to return profiling data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAgent service method.</param>
        /// 
        /// <returns>The response from the ConfigureAgent service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ConfigureAgent">REST API Reference for ConfigureAgent Operation</seealso>
        public virtual ConfigureAgentResponse ConfigureAgent(ConfigureAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureAgentResponseUnmarshaller.Instance;

            return Invoke<ConfigureAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAgent operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfigureAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ConfigureAgent">REST API Reference for ConfigureAgent Operation</seealso>
        public virtual IAsyncResult BeginConfigureAgent(ConfigureAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfigureAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureAgent.</param>
        /// 
        /// <returns>Returns a  ConfigureAgentResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ConfigureAgent">REST API Reference for ConfigureAgent Operation</seealso>
        public virtual ConfigureAgentResponse EndConfigureAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfigureAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProfilingGroup

        /// <summary>
        /// Creates a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/intro.html">Service
        /// Quotas</a> to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/CreateProfilingGroup">REST API Reference for CreateProfilingGroup Operation</seealso>
        public virtual CreateProfilingGroupResponse CreateProfilingGroup(CreateProfilingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfilingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateProfilingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfilingGroup operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProfilingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/CreateProfilingGroup">REST API Reference for CreateProfilingGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateProfilingGroup(CreateProfilingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfilingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProfilingGroup.</param>
        /// 
        /// <returns>Returns a  CreateProfilingGroupResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/CreateProfilingGroup">REST API Reference for CreateProfilingGroup Operation</seealso>
        public virtual CreateProfilingGroupResponse EndCreateProfilingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProfilingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProfilingGroup

        /// <summary>
        /// Deletes a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DeleteProfilingGroup">REST API Reference for DeleteProfilingGroup Operation</seealso>
        public virtual DeleteProfilingGroupResponse DeleteProfilingGroup(DeleteProfilingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfilingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteProfilingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfilingGroup operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfilingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DeleteProfilingGroup">REST API Reference for DeleteProfilingGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteProfilingGroup(DeleteProfilingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfilingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfilingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteProfilingGroupResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DeleteProfilingGroup">REST API Reference for DeleteProfilingGroup Operation</seealso>
        public virtual DeleteProfilingGroupResponse EndDeleteProfilingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProfilingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProfilingGroup

        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingGroupDescription.html">
        /// <code>ProfilingGroupDescription</code> </a> object that contains information about
        /// the requested profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DescribeProfilingGroup">REST API Reference for DescribeProfilingGroup Operation</seealso>
        public virtual DescribeProfilingGroupResponse DescribeProfilingGroup(DescribeProfilingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProfilingGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeProfilingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfilingGroup operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProfilingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DescribeProfilingGroup">REST API Reference for DescribeProfilingGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeProfilingGroup(DescribeProfilingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProfilingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProfilingGroup.</param>
        /// 
        /// <returns>Returns a  DescribeProfilingGroupResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DescribeProfilingGroup">REST API Reference for DescribeProfilingGroup Operation</seealso>
        public virtual DescribeProfilingGroupResponse EndDescribeProfilingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProfilingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFindingsReportAccountSummary

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_FindingsReportSummary.html">
        /// <code>FindingsReportSummary</code> </a> objects that contain analysis results for
        /// all profiling groups in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsReportAccountSummary service method.</param>
        /// 
        /// <returns>The response from the GetFindingsReportAccountSummary service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetFindingsReportAccountSummary">REST API Reference for GetFindingsReportAccountSummary Operation</seealso>
        public virtual GetFindingsReportAccountSummaryResponse GetFindingsReportAccountSummary(GetFindingsReportAccountSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsReportAccountSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsReportAccountSummaryResponseUnmarshaller.Instance;

            return Invoke<GetFindingsReportAccountSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingsReportAccountSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsReportAccountSummary operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingsReportAccountSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetFindingsReportAccountSummary">REST API Reference for GetFindingsReportAccountSummary Operation</seealso>
        public virtual IAsyncResult BeginGetFindingsReportAccountSummary(GetFindingsReportAccountSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsReportAccountSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsReportAccountSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingsReportAccountSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingsReportAccountSummary.</param>
        /// 
        /// <returns>Returns a  GetFindingsReportAccountSummaryResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetFindingsReportAccountSummary">REST API Reference for GetFindingsReportAccountSummary Operation</seealso>
        public virtual GetFindingsReportAccountSummaryResponse EndGetFindingsReportAccountSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFindingsReportAccountSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNotificationConfiguration

        /// <summary>
        /// Get the current configuration for anomaly notifications for a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetNotificationConfiguration service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual GetNotificationConfigurationResponse GetNotificationConfiguration(GetNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetNotificationConfiguration(GetNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetNotificationConfigurationResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual GetNotificationConfigurationResponse EndGetNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNotificationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPolicy

        /// <summary>
        /// Returns the JSON-formatted resource-based policy on a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProfile

        /// <summary>
        /// Gets the aggregated profile of a profiling group for a specified time range. Amazon
        /// CodeGuru Profiler collects posted agent profiles for a profiling group into aggregated
        /// profiles. 
        /// 
        ///  <pre><code> &lt;note&gt; &lt;p&gt; Because aggregated profiles expire over time &lt;code&gt;GetProfile&lt;/code&gt;
        /// is not idempotent. &lt;/p&gt; &lt;/note&gt; &lt;p&gt; Specify the time range for the
        /// requested aggregated profile using 1 or 2 of the following parameters: &lt;code&gt;startTime&lt;/code&gt;,
        /// &lt;code&gt;endTime&lt;/code&gt;, &lt;code&gt;period&lt;/code&gt;. The maximum time
        /// range allowed is 7 days. If you specify all 3 parameters, an exception is thrown.
        /// If you specify only &lt;code&gt;period&lt;/code&gt;, the latest aggregated profile
        /// is returned. &lt;/p&gt; &lt;p&gt; Aggregated profiles are available with aggregation
        /// periods of 5 minutes, 1 hour, and 1 day, aligned to UTC. The aggregation period of
        /// an aggregated profile determines how long it is retained. For more information, see
        /// &lt;a href=&quot;https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_AggregatedProfileTime.html&quot;&gt;
        /// &lt;code&gt;AggregatedProfileTime&lt;/code&gt; &lt;/a&gt;. The aggregated profile's
        /// aggregation period determines how long it is retained by CodeGuru Profiler. &lt;/p&gt;
        /// &lt;ul&gt; &lt;li&gt; &lt;p&gt; If the aggregation period is 5 minutes, the aggregated
        /// profile is retained for 15 days. &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; If the
        /// aggregation period is 1 hour, the aggregated profile is retained for 60 days. &lt;/p&gt;
        /// &lt;/li&gt; &lt;li&gt; &lt;p&gt; If the aggregation period is 1 day, the aggregated
        /// profile is retained for 3 years. &lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; &lt;p&gt;There
        /// are two use cases for calling &lt;code&gt;GetProfile&lt;/code&gt;.&lt;/p&gt; &lt;ol&gt;
        /// &lt;li&gt; &lt;p&gt; If you want to return an aggregated profile that already exists,
        /// use &lt;a href=&quot;https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ListProfileTimes.html&quot;&gt;
        /// &lt;code&gt;ListProfileTimes&lt;/code&gt; &lt;/a&gt; to view the time ranges of existing
        /// aggregated profiles. Use them in a &lt;code&gt;GetProfile&lt;/code&gt; request to
        /// return a specific, existing aggregated profile. &lt;/p&gt; &lt;/li&gt; &lt;li&gt;
        /// &lt;p&gt; If you want to return an aggregated profile for a time range that doesn't
        /// align with an existing aggregated profile, then CodeGuru Profiler makes a best effort
        /// to combine existing aggregated profiles from the requested time range and return them
        /// as one aggregated profile. &lt;/p&gt; &lt;p&gt; If aggregated profiles do not exist
        /// for the full time range requested, then aggregated profiles for a smaller time range
        /// are returned. For example, if the requested time range is from 00:00 to 00:20, and
        /// the existing aggregated profiles are from 00:15 and 00:25, then the aggregated profiles
        /// from 00:15 to 00:20 are returned. &lt;/p&gt; &lt;/li&gt; &lt;/ol&gt; </code></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse GetProfile(GetProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return Invoke<GetProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfile operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual IAsyncResult BeginGetProfile(GetProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfile.</param>
        /// 
        /// <returns>Returns a  GetProfileResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse EndGetProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecommendations

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_Recommendation.html">
        /// <code>Recommendation</code> </a> objects that contain recommendations for a profiling
        /// group for a given time period. A list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_Anomaly.html">
        /// <code>Anomaly</code> </a> objects that contains details about anomalies detected in
        /// the profiling group for the same time period is also returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetRecommendations service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        public virtual GetRecommendationsResponse GetRecommendations(GetRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        public virtual IAsyncResult BeginGetRecommendations(GetRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendations.</param>
        /// 
        /// <returns>Returns a  GetRecommendationsResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        public virtual GetRecommendationsResponse EndGetRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFindingsReports

        /// <summary>
        /// List the available reports for a given profiling group and time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsReports service method.</param>
        /// 
        /// <returns>The response from the ListFindingsReports service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListFindingsReports">REST API Reference for ListFindingsReports Operation</seealso>
        public virtual ListFindingsReportsResponse ListFindingsReports(ListFindingsReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsReportsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsReportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindingsReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsReports operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindingsReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListFindingsReports">REST API Reference for ListFindingsReports Operation</seealso>
        public virtual IAsyncResult BeginListFindingsReports(ListFindingsReportsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsReportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindingsReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindingsReports.</param>
        /// 
        /// <returns>Returns a  ListFindingsReportsResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListFindingsReports">REST API Reference for ListFindingsReports Operation</seealso>
        public virtual ListFindingsReportsResponse EndListFindingsReports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFindingsReportsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProfileTimes

        /// <summary>
        /// Lists the start times of the available aggregated profiles of a profiling group for
        /// an aggregation period within the specified time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileTimes service method.</param>
        /// 
        /// <returns>The response from the ListProfileTimes service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfileTimes">REST API Reference for ListProfileTimes Operation</seealso>
        public virtual ListProfileTimesResponse ListProfileTimes(ListProfileTimesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfileTimesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileTimesResponseUnmarshaller.Instance;

            return Invoke<ListProfileTimesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfileTimes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfileTimes operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfileTimes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfileTimes">REST API Reference for ListProfileTimes Operation</seealso>
        public virtual IAsyncResult BeginListProfileTimes(ListProfileTimesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfileTimesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileTimesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfileTimes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfileTimes.</param>
        /// 
        /// <returns>Returns a  ListProfileTimesResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfileTimes">REST API Reference for ListProfileTimes Operation</seealso>
        public virtual ListProfileTimesResponse EndListProfileTimes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProfileTimesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProfilingGroups

        /// <summary>
        /// Returns a list of profiling groups. The profiling groups are returned as <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingGroupDescription.html">
        /// <code>ProfilingGroupDescription</code> </a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfilingGroups service method.</param>
        /// 
        /// <returns>The response from the ListProfilingGroups service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfilingGroups">REST API Reference for ListProfilingGroups Operation</seealso>
        public virtual ListProfilingGroupsResponse ListProfilingGroups(ListProfilingGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfilingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListProfilingGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfilingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfilingGroups operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfilingGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfilingGroups">REST API Reference for ListProfilingGroups Operation</seealso>
        public virtual IAsyncResult BeginListProfilingGroups(ListProfilingGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfilingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilingGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfilingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfilingGroups.</param>
        /// 
        /// <returns>Returns a  ListProfilingGroupsResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfilingGroups">REST API Reference for ListProfilingGroups Operation</seealso>
        public virtual ListProfilingGroupsResponse EndListProfilingGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProfilingGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of the tags that are assigned to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PostAgentProfile

        /// <summary>
        /// Submits profiling data to an aggregated profile of a profiling group. To get an aggregated
        /// profile that is created with this profiling data, use <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_GetProfile.html">
        /// <code>GetProfile</code> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostAgentProfile service method.</param>
        /// 
        /// <returns>The response from the PostAgentProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PostAgentProfile">REST API Reference for PostAgentProfile Operation</seealso>
        public virtual PostAgentProfileResponse PostAgentProfile(PostAgentProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostAgentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostAgentProfileResponseUnmarshaller.Instance;

            return Invoke<PostAgentProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PostAgentProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostAgentProfile operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostAgentProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PostAgentProfile">REST API Reference for PostAgentProfile Operation</seealso>
        public virtual IAsyncResult BeginPostAgentProfile(PostAgentProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostAgentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostAgentProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PostAgentProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostAgentProfile.</param>
        /// 
        /// <returns>Returns a  PostAgentProfileResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PostAgentProfile">REST API Reference for PostAgentProfile Operation</seealso>
        public virtual PostAgentProfileResponse EndPostAgentProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<PostAgentProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPermission

        /// <summary>
        /// Adds permissions to a profiling group's resource-based policy that are provided using
        /// an action group. If a profiling group doesn't have a resource-based policy, one is
        /// created for it using the permissions in the action group and the roles and users in
        /// the <code>principals</code> parameter. 
        /// 
        ///  <pre><code> &lt;p&gt; The one supported action group that can be added is &lt;code&gt;agentPermission&lt;/code&gt;
        /// which grants &lt;code&gt;ConfigureAgent&lt;/code&gt; and &lt;code&gt;PostAgent&lt;/code&gt;
        /// permissions. For more information, see &lt;a href=&quot;https://docs.aws.amazon.com/codeguru/latest/profiler-ug/resource-based-policies.html&quot;&gt;Resource-based
        /// policies in CodeGuru Profiler&lt;/a&gt; in the &lt;i&gt;Amazon CodeGuru Profiler User
        /// Guide&lt;/i&gt;, &lt;a href=&quot;https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html&quot;&gt;
        /// &lt;code&gt;ConfigureAgent&lt;/code&gt; &lt;/a&gt;, and &lt;a href=&quot;https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_PostAgentProfile.html&quot;&gt;
        /// &lt;code&gt;PostAgentProfile&lt;/code&gt; &lt;/a&gt;. &lt;/p&gt; &lt;p&gt; The first
        /// time you call &lt;code&gt;PutPermission&lt;/code&gt; on a profiling group, do not
        /// specify a &lt;code&gt;revisionId&lt;/code&gt; because it doesn't have a resource-based
        /// policy. Subsequent calls must provide a &lt;code&gt;revisionId&lt;/code&gt; to specify
        /// which revision of the resource-based policy to add the permissions to. &lt;/p&gt;
        /// &lt;p&gt; The response contains the profiling group's JSON-formatted resource policy.
        /// &lt;/p&gt; </code></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermission service method.</param>
        /// 
        /// <returns>The response from the PutPermission service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PutPermission">REST API Reference for PutPermission Operation</seealso>
        public virtual PutPermissionResponse PutPermission(PutPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionResponseUnmarshaller.Instance;

            return Invoke<PutPermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPermission operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PutPermission">REST API Reference for PutPermission Operation</seealso>
        public virtual IAsyncResult BeginPutPermission(PutPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPermission.</param>
        /// 
        /// <returns>Returns a  PutPermissionResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PutPermission">REST API Reference for PutPermission Operation</seealso>
        public virtual PutPermissionResponse EndPutPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveNotificationChannel

        /// <summary>
        /// Remove one anomaly notifications channel for a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the RemoveNotificationChannel service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/RemoveNotificationChannel">REST API Reference for RemoveNotificationChannel Operation</seealso>
        public virtual RemoveNotificationChannelResponse RemoveNotificationChannel(RemoveNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<RemoveNotificationChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveNotificationChannel operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveNotificationChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/RemoveNotificationChannel">REST API Reference for RemoveNotificationChannel Operation</seealso>
        public virtual IAsyncResult BeginRemoveNotificationChannel(RemoveNotificationChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveNotificationChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveNotificationChannel.</param>
        /// 
        /// <returns>Returns a  RemoveNotificationChannelResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/RemoveNotificationChannel">REST API Reference for RemoveNotificationChannel Operation</seealso>
        public virtual RemoveNotificationChannelResponse EndRemoveNotificationChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveNotificationChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  RemovePermission

        /// <summary>
        /// Removes permissions from a profiling group's resource-based policy that are provided
        /// using an action group. The one supported action group that can be removed is <code>agentPermission</code>
        /// which grants <code>ConfigureAgent</code> and <code>PostAgent</code> permissions. For
        /// more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-ug/resource-based-policies.html">Resource-based
        /// policies in CodeGuru Profiler</a> in the <i>Amazon CodeGuru Profiler User Guide</i>,
        /// <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
        /// <code>ConfigureAgent</code> </a>, and <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_PostAgentProfile.html">
        /// <code>PostAgentProfile</code> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemovePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual IAsyncResult BeginRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        /// 
        /// <returns>Returns a  RemovePermissionResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<RemovePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  SubmitFeedback

        /// <summary>
        /// Sends feedback to CodeGuru Profiler about whether the anomaly detected by the analysis
        /// is useful or not.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback service method.</param>
        /// 
        /// <returns>The response from the SubmitFeedback service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        public virtual SubmitFeedbackResponse SubmitFeedback(SubmitFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitFeedbackResponseUnmarshaller.Instance;

            return Invoke<SubmitFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SubmitFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubmitFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        public virtual IAsyncResult BeginSubmitFeedback(SubmitFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SubmitFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubmitFeedback.</param>
        /// 
        /// <returns>Returns a  SubmitFeedbackResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        public virtual SubmitFeedbackResponse EndSubmitFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<SubmitFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Use to assign one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Use to remove one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProfilingGroup

        /// <summary>
        /// Updates a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UpdateProfilingGroup">REST API Reference for UpdateProfilingGroup Operation</seealso>
        public virtual UpdateProfilingGroupResponse UpdateProfilingGroup(UpdateProfilingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfilingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateProfilingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfilingGroup operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProfilingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UpdateProfilingGroup">REST API Reference for UpdateProfilingGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateProfilingGroup(UpdateProfilingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfilingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProfilingGroup.</param>
        /// 
        /// <returns>Returns a  UpdateProfilingGroupResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UpdateProfilingGroup">REST API Reference for UpdateProfilingGroup Operation</seealso>
        public virtual UpdateProfilingGroupResponse EndUpdateProfilingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProfilingGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}