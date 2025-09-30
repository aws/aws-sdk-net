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
 * Do not modify this file. This file is generated from the applicationcostprofiler-2020-09-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ApplicationCostProfiler.Model;
using Amazon.ApplicationCostProfiler.Model.Internal.MarshallTransformations;
using Amazon.ApplicationCostProfiler.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ApplicationCostProfiler
{
    /// <summary>
    /// <para>Implementation for accessing ApplicationCostProfiler</para>
    ///
    /// This reference provides descriptions of the AWS Application Cost Profiler API.
    /// 
    ///  
    /// <para>
    /// The AWS Application Cost Profiler API provides programmatic access to view, create,
    /// update, and delete application cost report definitions, as well as to import your
    /// usage data into the Application Cost Profiler service.
    /// </para>
    ///  
    /// <para>
    /// For more information about using this service, see the <a href="https://docs.aws.amazon.com/application-cost-profiler/latest/userguide/introduction.html">AWS
    /// Application Cost Profiler User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonApplicationCostProfilerClient : AmazonServiceClient, IAmazonApplicationCostProfiler
    {
        private static IServiceMetadata serviceMetadata = new AmazonApplicationCostProfilerMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IApplicationCostProfilerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IApplicationCostProfilerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ApplicationCostProfilerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with the credentials loaded from the application's
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
        public AmazonApplicationCostProfilerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationCostProfilerConfig()) { }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with the credentials loaded from the application's
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
        public AmazonApplicationCostProfilerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationCostProfilerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApplicationCostProfilerClient Configuration Object</param>
        public AmazonApplicationCostProfilerClient(AmazonApplicationCostProfilerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApplicationCostProfilerClient(AWSCredentials credentials)
            : this(credentials, new AmazonApplicationCostProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationCostProfilerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApplicationCostProfilerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Credentials and an
        /// AmazonApplicationCostProfilerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApplicationCostProfilerClient Configuration Object</param>
        public AmazonApplicationCostProfilerClient(AWSCredentials credentials, AmazonApplicationCostProfilerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationCostProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationCostProfilerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationCostProfilerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApplicationCostProfilerClient Configuration Object</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApplicationCostProfilerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationCostProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationCostProfilerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationCostProfilerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApplicationCostProfilerClient Configuration Object</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApplicationCostProfilerConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApplicationCostProfilerEndpointResolver());
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


        #region  DeleteReportDefinition

        /// <summary>
        /// Deletes the specified report definition in AWS Application Cost Profiler. This stops
        /// the report from being generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        public virtual DeleteReportDefinitionResponse DeleteReportDefinition(DeleteReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteReportDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReportDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteReportDefinition(DeleteReportDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReportDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteReportDefinitionResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        public virtual DeleteReportDefinitionResponse EndDeleteReportDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReportDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReportDefinition

        /// <summary>
        /// Retrieves the definition of a report already configured in AWS Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportDefinition service method.</param>
        /// 
        /// <returns>The response from the GetReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/GetReportDefinition">REST API Reference for GetReportDefinition Operation</seealso>
        public virtual GetReportDefinitionResponse GetReportDefinition(GetReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetReportDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReportDefinition operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReportDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/GetReportDefinition">REST API Reference for GetReportDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetReportDefinition(GetReportDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReportDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReportDefinition.</param>
        /// 
        /// <returns>Returns a  GetReportDefinitionResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/GetReportDefinition">REST API Reference for GetReportDefinition Operation</seealso>
        public virtual GetReportDefinitionResponse EndGetReportDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReportDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportApplicationUsage

        /// <summary>
        /// Ingests application usage data from Amazon Simple Storage Service (Amazon S3).
        /// 
        ///  
        /// <para>
        /// The data must already exist in the S3 location. As part of the action, AWS Application
        /// Cost Profiler copies the object from your S3 bucket to an S3 bucket owned by Amazon
        /// for processing asynchronously.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApplicationUsage service method.</param>
        /// 
        /// <returns>The response from the ImportApplicationUsage service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ImportApplicationUsage">REST API Reference for ImportApplicationUsage Operation</seealso>
        public virtual ImportApplicationUsageResponse ImportApplicationUsage(ImportApplicationUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApplicationUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApplicationUsageResponseUnmarshaller.Instance;

            return Invoke<ImportApplicationUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportApplicationUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportApplicationUsage operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportApplicationUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ImportApplicationUsage">REST API Reference for ImportApplicationUsage Operation</seealso>
        public virtual IAsyncResult BeginImportApplicationUsage(ImportApplicationUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApplicationUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApplicationUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportApplicationUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportApplicationUsage.</param>
        /// 
        /// <returns>Returns a  ImportApplicationUsageResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ImportApplicationUsage">REST API Reference for ImportApplicationUsage Operation</seealso>
        public virtual ImportApplicationUsageResponse EndImportApplicationUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportApplicationUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReportDefinitions

        /// <summary>
        /// Retrieves a list of all reports and their configurations for your AWS account.
        /// 
        ///  
        /// <para>
        /// The maximum number of reports is one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListReportDefinitions service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ListReportDefinitions">REST API Reference for ListReportDefinitions Operation</seealso>
        public virtual ListReportDefinitionsResponse ListReportDefinitions(ListReportDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListReportDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReportDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReportDefinitions operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReportDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ListReportDefinitions">REST API Reference for ListReportDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListReportDefinitions(ListReportDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReportDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReportDefinitions.</param>
        /// 
        /// <returns>Returns a  ListReportDefinitionsResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ListReportDefinitions">REST API Reference for ListReportDefinitions Operation</seealso>
        public virtual ListReportDefinitionsResponse EndListReportDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReportDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutReportDefinition

        /// <summary>
        /// Creates the report definition for a report in Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition service method.</param>
        /// 
        /// <returns>The response from the PutReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ServiceQuotaExceededException">
        /// Your request exceeds one or more of the service quotas.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        public virtual PutReportDefinitionResponse PutReportDefinition(PutReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<PutReportDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutReportDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        public virtual IAsyncResult BeginPutReportDefinition(PutReportDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutReportDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutReportDefinition.</param>
        /// 
        /// <returns>Returns a  PutReportDefinitionResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        public virtual PutReportDefinitionResponse EndPutReportDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<PutReportDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReportDefinition

        /// <summary>
        /// Updates existing report in AWS Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/UpdateReportDefinition">REST API Reference for UpdateReportDefinition Operation</seealso>
        public virtual UpdateReportDefinitionResponse UpdateReportDefinition(UpdateReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateReportDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportDefinition operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReportDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/UpdateReportDefinition">REST API Reference for UpdateReportDefinition Operation</seealso>
        public virtual IAsyncResult BeginUpdateReportDefinition(UpdateReportDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReportDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReportDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateReportDefinitionResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/UpdateReportDefinition">REST API Reference for UpdateReportDefinition Operation</seealso>
        public virtual UpdateReportDefinitionResponse EndUpdateReportDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReportDefinitionResponse>(asyncResult);
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
            var resolver = new AmazonApplicationCostProfilerEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}