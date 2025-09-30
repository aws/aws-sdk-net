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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.PI.Model;
using Amazon.PI.Model.Internal.MarshallTransformations;
using Amazon.PI.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.PI
{
    /// <summary>
    /// <para>Implementation for accessing PI</para>
    ///
    /// Amazon RDS Performance Insights 
    /// <para>
    /// Amazon RDS Performance Insights enables you to monitor and explore different dimensions
    /// of database load based on data captured from a running DB instance. The guide provides
    /// detailed information about Performance Insights data types, parameters and errors.
    /// </para>
    ///  
    /// <para>
    /// When Performance Insights is enabled, the Amazon RDS Performance Insights API provides
    /// visibility into the performance of your DB instance. Amazon CloudWatch provides the
    /// authoritative source for Amazon Web Services service-vended monitoring metrics. Performance
    /// Insights offers a domain-specific view of DB load.
    /// </para>
    ///  
    /// <para>
    /// DB load is measured as average active sessions. Performance Insights provides the
    /// data to API consumers as a two-dimensional time-series dataset. The time dimension
    /// provides DB load data for each time point in the queried time range. Each time point
    /// decomposes overall load in relation to the requested dimensions, measured at that
    /// time point. Examples include SQL, Wait event, User, and Host.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To learn more about Performance Insights and Amazon Aurora DB instances, go to the
    /// <i> <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_PerfInsights.html">
    /// Amazon Aurora User Guide</a> </i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To learn more about Performance Insights and Amazon RDS DB instances, go to the <i>
    /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">
    /// Amazon RDS User Guide</a> </i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To learn more about Performance Insights and Amazon DocumentDB clusters, go to the
    /// <i> <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/performance-insights.html">
    /// Amazon DocumentDB Developer Guide</a> </i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonPIClient : AmazonServiceClient, IAmazonPI
    {
        private static IServiceMetadata serviceMetadata = new AmazonPIMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IPIPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPIPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PIPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonPIClient with the credentials loaded from the application's
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
        public AmazonPIClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPIConfig()) { }

        /// <summary>
        /// Constructs AmazonPIClient with the credentials loaded from the application's
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
        public AmazonPIClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPIConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPIClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPIClient Configuration Object</param>
        public AmazonPIClient(AmazonPIConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonPIClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPIClient(AWSCredentials credentials)
            : this(credentials, new AmazonPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPIClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPIConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Credentials and an
        /// AmazonPIClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPIClient Configuration Object</param>
        public AmazonPIClient(AWSCredentials credentials, AmazonPIConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPIConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPIClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPIClient Configuration Object</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPIConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPIConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPIClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPIClient Configuration Object</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPIConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPIEndpointResolver());
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


        #region  CreatePerformanceAnalysisReport

        /// <summary>
        /// Creates a new performance analysis report for a specific time period for the DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePerformanceAnalysisReport service method.</param>
        /// 
        /// <returns>The response from the CreatePerformanceAnalysisReport service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/CreatePerformanceAnalysisReport">REST API Reference for CreatePerformanceAnalysisReport Operation</seealso>
        public virtual CreatePerformanceAnalysisReportResponse CreatePerformanceAnalysisReport(CreatePerformanceAnalysisReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePerformanceAnalysisReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePerformanceAnalysisReportResponseUnmarshaller.Instance;

            return Invoke<CreatePerformanceAnalysisReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePerformanceAnalysisReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePerformanceAnalysisReport operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePerformanceAnalysisReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/CreatePerformanceAnalysisReport">REST API Reference for CreatePerformanceAnalysisReport Operation</seealso>
        public virtual IAsyncResult BeginCreatePerformanceAnalysisReport(CreatePerformanceAnalysisReportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePerformanceAnalysisReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePerformanceAnalysisReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePerformanceAnalysisReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePerformanceAnalysisReport.</param>
        /// 
        /// <returns>Returns a  CreatePerformanceAnalysisReportResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/CreatePerformanceAnalysisReport">REST API Reference for CreatePerformanceAnalysisReport Operation</seealso>
        public virtual CreatePerformanceAnalysisReportResponse EndCreatePerformanceAnalysisReport(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePerformanceAnalysisReportResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePerformanceAnalysisReport

        /// <summary>
        /// Deletes a performance analysis report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePerformanceAnalysisReport service method.</param>
        /// 
        /// <returns>The response from the DeletePerformanceAnalysisReport service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/DeletePerformanceAnalysisReport">REST API Reference for DeletePerformanceAnalysisReport Operation</seealso>
        public virtual DeletePerformanceAnalysisReportResponse DeletePerformanceAnalysisReport(DeletePerformanceAnalysisReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePerformanceAnalysisReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePerformanceAnalysisReportResponseUnmarshaller.Instance;

            return Invoke<DeletePerformanceAnalysisReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePerformanceAnalysisReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePerformanceAnalysisReport operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePerformanceAnalysisReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/DeletePerformanceAnalysisReport">REST API Reference for DeletePerformanceAnalysisReport Operation</seealso>
        public virtual IAsyncResult BeginDeletePerformanceAnalysisReport(DeletePerformanceAnalysisReportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePerformanceAnalysisReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePerformanceAnalysisReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePerformanceAnalysisReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePerformanceAnalysisReport.</param>
        /// 
        /// <returns>Returns a  DeletePerformanceAnalysisReportResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/DeletePerformanceAnalysisReport">REST API Reference for DeletePerformanceAnalysisReport Operation</seealso>
        public virtual DeletePerformanceAnalysisReportResponse EndDeletePerformanceAnalysisReport(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePerformanceAnalysisReportResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDimensionKeys

        /// <summary>
        /// For a specific time period, retrieve the top <c>N</c> dimension keys for a metric.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// Each response element returns a maximum of 500 bytes. For larger elements, such as
        /// SQL statements, only the first 500 bytes are returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDimensionKeys service method.</param>
        /// 
        /// <returns>The response from the DescribeDimensionKeys service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/DescribeDimensionKeys">REST API Reference for DescribeDimensionKeys Operation</seealso>
        public virtual DescribeDimensionKeysResponse DescribeDimensionKeys(DescribeDimensionKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDimensionKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDimensionKeysResponseUnmarshaller.Instance;

            return Invoke<DescribeDimensionKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDimensionKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDimensionKeys operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDimensionKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/DescribeDimensionKeys">REST API Reference for DescribeDimensionKeys Operation</seealso>
        public virtual IAsyncResult BeginDescribeDimensionKeys(DescribeDimensionKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDimensionKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDimensionKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDimensionKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDimensionKeys.</param>
        /// 
        /// <returns>Returns a  DescribeDimensionKeysResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/DescribeDimensionKeys">REST API Reference for DescribeDimensionKeys Operation</seealso>
        public virtual DescribeDimensionKeysResponse EndDescribeDimensionKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDimensionKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDimensionKeyDetails

        /// <summary>
        /// Get the attributes of the specified dimension group for a DB instance or data source.
        /// For example, if you specify a SQL ID, <c>GetDimensionKeyDetails</c> retrieves the
        /// full text of the dimension <c>db.sql.statement</c> associated with this ID. This operation
        /// is useful because <c>GetResourceMetrics</c> and <c>DescribeDimensionKeys</c> don't
        /// support retrieval of large SQL statement text, lock snapshots, and execution plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDimensionKeyDetails service method.</param>
        /// 
        /// <returns>The response from the GetDimensionKeyDetails service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetDimensionKeyDetails">REST API Reference for GetDimensionKeyDetails Operation</seealso>
        public virtual GetDimensionKeyDetailsResponse GetDimensionKeyDetails(GetDimensionKeyDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDimensionKeyDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDimensionKeyDetailsResponseUnmarshaller.Instance;

            return Invoke<GetDimensionKeyDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDimensionKeyDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDimensionKeyDetails operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDimensionKeyDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetDimensionKeyDetails">REST API Reference for GetDimensionKeyDetails Operation</seealso>
        public virtual IAsyncResult BeginGetDimensionKeyDetails(GetDimensionKeyDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDimensionKeyDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDimensionKeyDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDimensionKeyDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDimensionKeyDetails.</param>
        /// 
        /// <returns>Returns a  GetDimensionKeyDetailsResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetDimensionKeyDetails">REST API Reference for GetDimensionKeyDetails Operation</seealso>
        public virtual GetDimensionKeyDetailsResponse EndGetDimensionKeyDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDimensionKeyDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPerformanceAnalysisReport

        /// <summary>
        /// Retrieves the report including the report ID, status, time details, and the insights
        /// with recommendations. The report status can be <c>RUNNING</c>, <c>SUCCEEDED</c>, or
        /// <c>FAILED</c>. The insights include the <c>description</c> and <c>recommendation</c>
        /// fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPerformanceAnalysisReport service method.</param>
        /// 
        /// <returns>The response from the GetPerformanceAnalysisReport service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetPerformanceAnalysisReport">REST API Reference for GetPerformanceAnalysisReport Operation</seealso>
        public virtual GetPerformanceAnalysisReportResponse GetPerformanceAnalysisReport(GetPerformanceAnalysisReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPerformanceAnalysisReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPerformanceAnalysisReportResponseUnmarshaller.Instance;

            return Invoke<GetPerformanceAnalysisReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPerformanceAnalysisReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPerformanceAnalysisReport operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPerformanceAnalysisReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetPerformanceAnalysisReport">REST API Reference for GetPerformanceAnalysisReport Operation</seealso>
        public virtual IAsyncResult BeginGetPerformanceAnalysisReport(GetPerformanceAnalysisReportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPerformanceAnalysisReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPerformanceAnalysisReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPerformanceAnalysisReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPerformanceAnalysisReport.</param>
        /// 
        /// <returns>Returns a  GetPerformanceAnalysisReportResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetPerformanceAnalysisReport">REST API Reference for GetPerformanceAnalysisReport Operation</seealso>
        public virtual GetPerformanceAnalysisReportResponse EndGetPerformanceAnalysisReport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPerformanceAnalysisReportResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceMetadata

        /// <summary>
        /// Retrieve the metadata for different features. For example, the metadata might indicate
        /// that a feature is turned on or off on a specific DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceMetadata service method.</param>
        /// 
        /// <returns>The response from the GetResourceMetadata service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetResourceMetadata">REST API Reference for GetResourceMetadata Operation</seealso>
        public virtual GetResourceMetadataResponse GetResourceMetadata(GetResourceMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceMetadataResponseUnmarshaller.Instance;

            return Invoke<GetResourceMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceMetadata operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetResourceMetadata">REST API Reference for GetResourceMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetResourceMetadata(GetResourceMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceMetadata.</param>
        /// 
        /// <returns>Returns a  GetResourceMetadataResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetResourceMetadata">REST API Reference for GetResourceMetadata Operation</seealso>
        public virtual GetResourceMetadataResponse EndGetResourceMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceMetrics

        /// <summary>
        /// Retrieve Performance Insights metrics for a set of data sources over a time period.
        /// You can provide specific dimension groups and dimensions, and provide filtering criteria
        /// for each group. You must specify an aggregate function for each metric.
        /// 
        ///  <note> 
        /// <para>
        /// Each response element returns a maximum of 500 bytes. For larger elements, such as
        /// SQL statements, only the first 500 bytes are returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceMetrics service method.</param>
        /// 
        /// <returns>The response from the GetResourceMetrics service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetResourceMetrics">REST API Reference for GetResourceMetrics Operation</seealso>
        public virtual GetResourceMetricsResponse GetResourceMetrics(GetResourceMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceMetricsResponseUnmarshaller.Instance;

            return Invoke<GetResourceMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceMetrics operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetResourceMetrics">REST API Reference for GetResourceMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetResourceMetrics(GetResourceMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceMetrics.</param>
        /// 
        /// <returns>Returns a  GetResourceMetricsResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetResourceMetrics">REST API Reference for GetResourceMetrics Operation</seealso>
        public virtual GetResourceMetricsResponse EndGetResourceMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAvailableResourceDimensions

        /// <summary>
        /// Retrieve the dimensions that can be queried for each specified metric type on a specified
        /// DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableResourceDimensions service method.</param>
        /// 
        /// <returns>The response from the ListAvailableResourceDimensions service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListAvailableResourceDimensions">REST API Reference for ListAvailableResourceDimensions Operation</seealso>
        public virtual ListAvailableResourceDimensionsResponse ListAvailableResourceDimensions(ListAvailableResourceDimensionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableResourceDimensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableResourceDimensionsResponseUnmarshaller.Instance;

            return Invoke<ListAvailableResourceDimensionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableResourceDimensions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableResourceDimensions operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableResourceDimensions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListAvailableResourceDimensions">REST API Reference for ListAvailableResourceDimensions Operation</seealso>
        public virtual IAsyncResult BeginListAvailableResourceDimensions(ListAvailableResourceDimensionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableResourceDimensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableResourceDimensionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableResourceDimensions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableResourceDimensions.</param>
        /// 
        /// <returns>Returns a  ListAvailableResourceDimensionsResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListAvailableResourceDimensions">REST API Reference for ListAvailableResourceDimensions Operation</seealso>
        public virtual ListAvailableResourceDimensionsResponse EndListAvailableResourceDimensions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAvailableResourceDimensionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAvailableResourceMetrics

        /// <summary>
        /// Retrieve metrics of the specified types that can be queried for a specified DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableResourceMetrics service method.</param>
        /// 
        /// <returns>The response from the ListAvailableResourceMetrics service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListAvailableResourceMetrics">REST API Reference for ListAvailableResourceMetrics Operation</seealso>
        public virtual ListAvailableResourceMetricsResponse ListAvailableResourceMetrics(ListAvailableResourceMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableResourceMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableResourceMetricsResponseUnmarshaller.Instance;

            return Invoke<ListAvailableResourceMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableResourceMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableResourceMetrics operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableResourceMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListAvailableResourceMetrics">REST API Reference for ListAvailableResourceMetrics Operation</seealso>
        public virtual IAsyncResult BeginListAvailableResourceMetrics(ListAvailableResourceMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableResourceMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableResourceMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableResourceMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableResourceMetrics.</param>
        /// 
        /// <returns>Returns a  ListAvailableResourceMetricsResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListAvailableResourceMetrics">REST API Reference for ListAvailableResourceMetrics Operation</seealso>
        public virtual ListAvailableResourceMetricsResponse EndListAvailableResourceMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAvailableResourceMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPerformanceAnalysisReports

        /// <summary>
        /// Lists all the analysis reports created for the DB instance. The reports are sorted
        /// based on the start time of each report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPerformanceAnalysisReports service method.</param>
        /// 
        /// <returns>The response from the ListPerformanceAnalysisReports service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListPerformanceAnalysisReports">REST API Reference for ListPerformanceAnalysisReports Operation</seealso>
        public virtual ListPerformanceAnalysisReportsResponse ListPerformanceAnalysisReports(ListPerformanceAnalysisReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPerformanceAnalysisReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPerformanceAnalysisReportsResponseUnmarshaller.Instance;

            return Invoke<ListPerformanceAnalysisReportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPerformanceAnalysisReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPerformanceAnalysisReports operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPerformanceAnalysisReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListPerformanceAnalysisReports">REST API Reference for ListPerformanceAnalysisReports Operation</seealso>
        public virtual IAsyncResult BeginListPerformanceAnalysisReports(ListPerformanceAnalysisReportsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPerformanceAnalysisReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPerformanceAnalysisReportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPerformanceAnalysisReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPerformanceAnalysisReports.</param>
        /// 
        /// <returns>Returns a  ListPerformanceAnalysisReportsResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListPerformanceAnalysisReports">REST API Reference for ListPerformanceAnalysisReports Operation</seealso>
        public virtual ListPerformanceAnalysisReportsResponse EndListPerformanceAnalysisReports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPerformanceAnalysisReportsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves all the metadata tags associated with Amazon RDS Performance Insights resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds metadata tags to the Amazon RDS Performance Insights resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes the metadata tags from the Amazon RDS Performance Insights resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
            var resolver = new AmazonPIEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}