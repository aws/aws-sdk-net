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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.BCMDashboards.Model;
using Amazon.BCMDashboards.Model.Internal.MarshallTransformations;
using Amazon.BCMDashboards.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.BCMDashboards
{
    /// <summary>
    /// <para>Implementation for accessing BCMDashboards</para>
    ///
    /// Amazon Web Services Billing and Cost Management Dashboards is a service that enables
    /// you to create, manage, and share dashboards that combine multiple visualizations of
    /// your Amazon Web Services cost and usage data. You can combine multiple data sources
    /// including Cost Explorer, Savings Plans, and Reserved Instance metrics into unified
    /// dashboards, helping you analyze spending patterns and share cost insights across your
    /// organization.
    /// 
    ///  
    /// <para>
    /// You can use the Amazon Web Services Billing and Cost Management Dashboards API to
    /// programmatically create, manage, and share dashboards. This includes creating custom
    /// dashboards, configuring widgets, managing dashboard permissions, and sharing dashboards
    /// across accounts in your organization.
    /// </para>
    /// </summary>
    public partial class AmazonBCMDashboardsClient : AmazonServiceClient, IAmazonBCMDashboards
    {
        private static IServiceMetadata serviceMetadata = new AmazonBCMDashboardsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IBCMDashboardsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBCMDashboardsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BCMDashboardsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with the credentials loaded from the application's
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
        public AmazonBCMDashboardsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBCMDashboardsConfig()) { }

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with the credentials loaded from the application's
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
        public AmazonBCMDashboardsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBCMDashboardsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBCMDashboardsClient Configuration Object</param>
        public AmazonBCMDashboardsClient(AmazonBCMDashboardsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBCMDashboardsClient(AWSCredentials credentials)
            : this(credentials, new AmazonBCMDashboardsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBCMDashboardsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBCMDashboardsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with AWS Credentials and an
        /// AmazonBCMDashboardsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBCMDashboardsClient Configuration Object</param>
        public AmazonBCMDashboardsClient(AWSCredentials credentials, AmazonBCMDashboardsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBCMDashboardsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBCMDashboardsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBCMDashboardsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBCMDashboardsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBCMDashboardsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBCMDashboardsClient Configuration Object</param>
        public AmazonBCMDashboardsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBCMDashboardsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBCMDashboardsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBCMDashboardsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBCMDashboardsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBCMDashboardsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBCMDashboardsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBCMDashboardsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBCMDashboardsClient Configuration Object</param>
        public AmazonBCMDashboardsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBCMDashboardsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBCMDashboardsEndpointResolver());
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


        #region  CreateDashboard

        /// <summary>
        /// Creates a new dashboard that can contain multiple widgets displaying cost and usage
        /// data. You can add custom widgets or use predefined widgets, arranging them in your
        /// preferred layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ServiceQuotaExceededException">
        /// The request would exceed service quotas. For example, attempting to create more than
        /// 20 widgets in a dashboard or exceeding the maximum number of dashboards per account.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual CreateDashboardResponse CreateDashboard(CreateDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return Invoke<CreateDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard operation on AmazonBCMDashboardsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual IAsyncResult BeginCreateDashboard(CreateDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDashboard.</param>
        /// 
        /// <returns>Returns a  CreateDashboardResult from BCMDashboards.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual CreateDashboardResponse EndCreateDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDashboard

        /// <summary>
        /// Deletes a specified dashboard. This action cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return Invoke<DeleteDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard operation on AmazonBCMDashboardsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual IAsyncResult BeginDeleteDashboard(DeleteDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDashboard.</param>
        /// 
        /// <returns>Returns a  DeleteDashboardResult from BCMDashboards.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual DeleteDashboardResponse EndDeleteDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDashboard

        /// <summary>
        /// Retrieves the configuration and metadata of a specified dashboard, including its widgets
        /// and layout settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard service method.</param>
        /// 
        /// <returns>The response from the GetDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        public virtual GetDashboardResponse GetDashboard(GetDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardResponseUnmarshaller.Instance;

            return Invoke<GetDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard operation on AmazonBCMDashboardsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        public virtual IAsyncResult BeginGetDashboard(GetDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDashboard.</param>
        /// 
        /// <returns>Returns a  GetDashboardResult from BCMDashboards.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        public virtual GetDashboardResponse EndGetDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePolicy

        /// <summary>
        /// Retrieves the resource-based policy attached to a dashboard, showing sharing configurations
        /// and permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonBCMDashboardsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from BCMDashboards.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDashboards

        /// <summary>
        /// Returns a list of all dashboards in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual ListDashboardsResponse ListDashboards(ListDashboardsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards operation on AmazonBCMDashboardsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDashboards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual IAsyncResult BeginListDashboards(ListDashboardsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDashboards.</param>
        /// 
        /// <returns>Returns a  ListDashboardsResult from BCMDashboards.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual ListDashboardsResponse EndListDashboards(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDashboardsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of all tags associated with a specified dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBCMDashboardsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from BCMDashboards.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates tags for a specified dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBCMDashboardsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from BCMDashboards.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes specified tags from a dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBCMDashboardsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from BCMDashboards.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDashboard

        /// <summary>
        /// Updates an existing dashboard's properties, including its name, description, and widget
        /// configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard operation on AmazonBCMDashboardsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual IAsyncResult BeginUpdateDashboard(UpdateDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboard.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardResult from BCMDashboards.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual UpdateDashboardResponse EndUpdateDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDashboardResponse>(asyncResult);
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
            var resolver = new AmazonBCMDashboardsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}