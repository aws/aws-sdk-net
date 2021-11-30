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
using System.Collections.Generic;
using System.Net;

using Amazon.CloudWatchRUM.Model;
using Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations;
using Amazon.CloudWatchRUM.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatchRUM
{
    /// <summary>
    /// Implementation for accessing CloudWatchRUM
    ///
    /// With Amazon CloudWatch RUM, you can perform real-user monitoring to collect client-side
    /// data about your web application performance from actual user sessions in real time.
    /// The data collected includes page load times, client-side errors, and user behavior.
    /// When you view this data, you can see it all aggregated together and also see breakdowns
    /// by the browsers and devices that your customers use.
    /// 
    ///  <pre><code> &lt;p&gt;You can use the collected data to quickly identify and debug
    /// client-side performance issues. CloudWatch RUM helps you visualize anomalies in your
    /// application performance and find relevant debugging data such as error messages, stack
    /// traces, and user sessions. You can also use RUM to understand the range of end-user
    /// impact including the number of users, geolocations, and browsers used.&lt;/p&gt; </code></pre>
    /// </summary>
    public partial class AmazonCloudWatchRUMClient : AmazonServiceClient, IAmazonCloudWatchRUM
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudWatchRUMMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// Initiates the asynchronous execution of the CreateAppMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppMonitor operation on AmazonCloudWatchRUMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/CreateAppMonitor">REST API Reference for CreateAppMonitor Operation</seealso>
        public virtual IAsyncResult BeginCreateAppMonitor(CreateAppMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppMonitor.</param>
        /// 
        /// <returns>Returns a  CreateAppMonitorResult from CloudWatchRUM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/CreateAppMonitor">REST API Reference for CreateAppMonitor Operation</seealso>
        public virtual CreateAppMonitorResponse EndCreateAppMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppMonitorResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteAppMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppMonitor operation on AmazonCloudWatchRUMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/DeleteAppMonitor">REST API Reference for DeleteAppMonitor Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppMonitor(DeleteAppMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppMonitor.</param>
        /// 
        /// <returns>Returns a  DeleteAppMonitorResult from CloudWatchRUM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/DeleteAppMonitor">REST API Reference for DeleteAppMonitor Operation</seealso>
        public virtual DeleteAppMonitorResponse EndDeleteAppMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppMonitorResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetAppMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppMonitor operation on AmazonCloudWatchRUMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/GetAppMonitor">REST API Reference for GetAppMonitor Operation</seealso>
        public virtual IAsyncResult BeginGetAppMonitor(GetAppMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppMonitor.</param>
        /// 
        /// <returns>Returns a  GetAppMonitorResult from CloudWatchRUM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/GetAppMonitor">REST API Reference for GetAppMonitor Operation</seealso>
        public virtual GetAppMonitorResponse EndGetAppMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppMonitorResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetAppMonitorData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppMonitorData operation on AmazonCloudWatchRUMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppMonitorData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/GetAppMonitorData">REST API Reference for GetAppMonitorData Operation</seealso>
        public virtual IAsyncResult BeginGetAppMonitorData(GetAppMonitorDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppMonitorDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppMonitorDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppMonitorData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppMonitorData.</param>
        /// 
        /// <returns>Returns a  GetAppMonitorDataResult from CloudWatchRUM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/GetAppMonitorData">REST API Reference for GetAppMonitorData Operation</seealso>
        public virtual GetAppMonitorDataResponse EndGetAppMonitorData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppMonitorDataResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListAppMonitors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppMonitors operation on AmazonCloudWatchRUMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppMonitors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListAppMonitors">REST API Reference for ListAppMonitors Operation</seealso>
        public virtual IAsyncResult BeginListAppMonitors(ListAppMonitorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppMonitorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppMonitors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppMonitors.</param>
        /// 
        /// <returns>Returns a  ListAppMonitorsResult from CloudWatchRUM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListAppMonitors">REST API Reference for ListAppMonitors Operation</seealso>
        public virtual ListAppMonitorsResponse EndListAppMonitors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppMonitorsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCloudWatchRUMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from CloudWatchRUM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRumEvents

        /// <summary>
        /// Sends telemetry events about your application performance and user behavior to CloudWatch
        /// RUM. The code snippet that RUM generates for you to add to your application includes
        /// <code>PutRumEvents</code> operations to send this data to RUM.
        /// 
        ///  
        /// <para>
        /// Each <code>PutRumEvents</code> operation can send a batch of events from one user
        /// session.
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
        /// Initiates the asynchronous execution of the PutRumEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRumEvents operation on AmazonCloudWatchRUMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRumEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/PutRumEvents">REST API Reference for PutRumEvents Operation</seealso>
        public virtual IAsyncResult BeginPutRumEvents(PutRumEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRumEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRumEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRumEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRumEvents.</param>
        /// 
        /// <returns>Returns a  PutRumEventsResult from CloudWatchRUM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/PutRumEvents">REST API Reference for PutRumEvents Operation</seealso>
        public virtual PutRumEventsResponse EndPutRumEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRumEventsResponse>(asyncResult);
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
        /// You can use the <code>TagResource</code> action with a resource that already has tags.
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the alarm. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCloudWatchRUMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from CloudWatchRUM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCloudWatchRUMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from CloudWatchRUM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateAppMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppMonitor operation on AmazonCloudWatchRUMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UpdateAppMonitor">REST API Reference for UpdateAppMonitor Operation</seealso>
        public virtual IAsyncResult BeginUpdateAppMonitor(UpdateAppMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppMonitor.</param>
        /// 
        /// <returns>Returns a  UpdateAppMonitorResult from CloudWatchRUM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UpdateAppMonitor">REST API Reference for UpdateAppMonitor Operation</seealso>
        public virtual UpdateAppMonitorResponse EndUpdateAppMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAppMonitorResponse>(asyncResult);
        }

        #endregion
        
    }
}