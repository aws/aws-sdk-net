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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BCMDashboards.Model;
using Amazon.BCMDashboards.Model.Internal.MarshallTransformations;
using Amazon.BCMDashboards.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

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
            : base(new AmazonBCMDashboardsConfig()) { }

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
            : base(new AmazonBCMDashboardsConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBCMDashboardsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBCMDashboardsAuthSchemeHandler());
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
        /// The request would exceed a service quota. Review the service quotas for Amazon Web
        /// Services Billing and Cost Management Dashboards and retry your request.
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
        /// Creates a new dashboard that can contain multiple widgets displaying cost and usage
        /// data. You can add custom widgets or use predefined widgets, arranging them in your
        /// preferred layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request would exceed a service quota. Review the service quotas for Amazon Web
        /// Services Billing and Cost Management Dashboards and retry your request.
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
        public virtual Task<CreateDashboardResponse> CreateDashboardAsync(CreateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDashboardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateScheduledReport


        /// <summary>
        /// Creates a new scheduled report for a dashboard. A scheduled report automatically generates
        /// and delivers dashboard snapshots on a recurring schedule. Reports are delivered within
        /// 15 minutes of the scheduled delivery time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledReport service method.</param>
        /// 
        /// <returns>The response from the CreateScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review the service quotas for Amazon Web
        /// Services Billing and Cost Management Dashboards and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/CreateScheduledReport">REST API Reference for CreateScheduledReport Operation</seealso>
        public virtual CreateScheduledReportResponse CreateScheduledReport(CreateScheduledReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScheduledReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledReportResponseUnmarshaller.Instance;

            return Invoke<CreateScheduledReportResponse>(request, options);
        }


        /// <summary>
        /// Creates a new scheduled report for a dashboard. A scheduled report automatically generates
        /// and delivers dashboard snapshots on a recurring schedule. Reports are delivered within
        /// 15 minutes of the scheduled delivery time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review the service quotas for Amazon Web
        /// Services Billing and Cost Management Dashboards and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/CreateScheduledReport">REST API Reference for CreateScheduledReport Operation</seealso>
        public virtual Task<CreateScheduledReportResponse> CreateScheduledReportAsync(CreateScheduledReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScheduledReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateScheduledReportResponse>(request, options, cancellationToken);
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
        /// Deletes a specified dashboard. This action cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDashboardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScheduledReport


        /// <summary>
        /// Deletes a specified scheduled report. This is an irreversible operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledReport service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledReport service method, as returned by BCMDashboards.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/DeleteScheduledReport">REST API Reference for DeleteScheduledReport Operation</seealso>
        public virtual DeleteScheduledReportResponse DeleteScheduledReport(DeleteScheduledReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScheduledReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledReportResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledReportResponse>(request, options);
        }


        /// <summary>
        /// Deletes a specified scheduled report. This is an irreversible operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduledReport service method, as returned by BCMDashboards.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/DeleteScheduledReport">REST API Reference for DeleteScheduledReport Operation</seealso>
        public virtual Task<DeleteScheduledReportResponse> DeleteScheduledReportAsync(DeleteScheduledReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScheduledReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteScheduledReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteScheduledReport


        /// <summary>
        /// Triggers an immediate execution of a scheduled report, outside of its regular schedule.
        /// The scheduled report must be in <c>ENABLED</c> state. Calling this operation on a
        /// <c>DISABLED</c> scheduled report returns a <c>ValidationException</c>.
        /// 
        ///  <note> 
        /// <para>
        /// If a <c>clientToken</c> is provided, the service uses it for idempotency. Requests
        /// with the same client token will not trigger a new execution within the same minute.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteScheduledReport service method.</param>
        /// 
        /// <returns>The response from the ExecuteScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ExecuteScheduledReport">REST API Reference for ExecuteScheduledReport Operation</seealso>
        public virtual ExecuteScheduledReportResponse ExecuteScheduledReport(ExecuteScheduledReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteScheduledReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteScheduledReportResponseUnmarshaller.Instance;

            return Invoke<ExecuteScheduledReportResponse>(request, options);
        }


        /// <summary>
        /// Triggers an immediate execution of a scheduled report, outside of its regular schedule.
        /// The scheduled report must be in <c>ENABLED</c> state. Calling this operation on a
        /// <c>DISABLED</c> scheduled report returns a <c>ValidationException</c>.
        /// 
        ///  <note> 
        /// <para>
        /// If a <c>clientToken</c> is provided, the service uses it for idempotency. Requests
        /// with the same client token will not trigger a new execution within the same minute.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteScheduledReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ExecuteScheduledReport">REST API Reference for ExecuteScheduledReport Operation</seealso>
        public virtual Task<ExecuteScheduledReportResponse> ExecuteScheduledReportAsync(ExecuteScheduledReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteScheduledReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteScheduledReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteScheduledReportResponse>(request, options, cancellationToken);
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
        /// Retrieves the configuration and metadata of a specified dashboard, including its widgets
        /// and layout settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetDashboardResponse> GetDashboardAsync(GetDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDashboardResponse>(request, options, cancellationToken);
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
        /// Retrieves the resource-based policy attached to a dashboard, showing sharing configurations
        /// and permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetScheduledReport


        /// <summary>
        /// Retrieves the configuration and metadata of a specified scheduled report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScheduledReport service method.</param>
        /// 
        /// <returns>The response from the GetScheduledReport service method, as returned by BCMDashboards.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetScheduledReport">REST API Reference for GetScheduledReport Operation</seealso>
        public virtual GetScheduledReportResponse GetScheduledReport(GetScheduledReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScheduledReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScheduledReportResponseUnmarshaller.Instance;

            return Invoke<GetScheduledReportResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the configuration and metadata of a specified scheduled report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScheduledReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScheduledReport service method, as returned by BCMDashboards.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetScheduledReport">REST API Reference for GetScheduledReport Operation</seealso>
        public virtual Task<GetScheduledReportResponse> GetScheduledReportAsync(GetScheduledReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScheduledReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScheduledReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetScheduledReportResponse>(request, options, cancellationToken);
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
        /// Returns a list of all dashboards in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDashboardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListScheduledReports


        /// <summary>
        /// Returns a list of scheduled reports in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledReports service method.</param>
        /// 
        /// <returns>The response from the ListScheduledReports service method, as returned by BCMDashboards.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListScheduledReports">REST API Reference for ListScheduledReports Operation</seealso>
        public virtual ListScheduledReportsResponse ListScheduledReports(ListScheduledReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScheduledReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledReportsResponseUnmarshaller.Instance;

            return Invoke<ListScheduledReportsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of scheduled reports in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScheduledReports service method, as returned by BCMDashboards.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListScheduledReports">REST API Reference for ListScheduledReports Operation</seealso>
        public virtual Task<ListScheduledReportsResponse> ListScheduledReportsAsync(ListScheduledReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScheduledReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledReportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListScheduledReportsResponse>(request, options, cancellationToken);
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
        /// Returns a list of all tags associated with a specified dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Adds or updates tags for a specified dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
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
        /// Removes specified tags from a dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
        /// Updates an existing dashboard's properties, including its name, description, and widget
        /// configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateDashboardResponse> UpdateDashboardAsync(UpdateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDashboardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateScheduledReport


        /// <summary>
        /// Updates an existing scheduled report's properties, including its name, description,
        /// schedule configuration, and widget settings. Only the parameters included in the request
        /// are updated; all other properties remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledReport service method.</param>
        /// 
        /// <returns>The response from the UpdateScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UpdateScheduledReport">REST API Reference for UpdateScheduledReport Operation</seealso>
        public virtual UpdateScheduledReportResponse UpdateScheduledReport(UpdateScheduledReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScheduledReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledReportResponseUnmarshaller.Instance;

            return Invoke<UpdateScheduledReportResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing scheduled report's properties, including its name, description,
        /// schedule configuration, and widget settings. Only the parameters included in the request
        /// are updated; all other properties remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UpdateScheduledReport">REST API Reference for UpdateScheduledReport Operation</seealso>
        public virtual Task<UpdateScheduledReportResponse> UpdateScheduledReportAsync(UpdateScheduledReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScheduledReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateScheduledReportResponse>(request, options, cancellationToken);
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