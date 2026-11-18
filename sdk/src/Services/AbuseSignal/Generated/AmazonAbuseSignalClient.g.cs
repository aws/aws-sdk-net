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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Amazon.AbuseSignal.Model;
using Amazon.AbuseSignal.Model.Internal.MarshallTransformations;
using Amazon.AbuseSignal.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.AbuseSignal
{
    /// <summary>
    /// <para>Implementation for accessing AbuseSignal</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Amazon Web Services Abuse Signal 
    /// <para>
    /// Amazon Web Services Abuse Signal API provides programmatic means to report suspected
    /// abuse of Amazon Web Services resources. You can use the API to submit abuse reports
    /// about Amazon Web Services resources and to track the status of your reports. Amazon
    /// Web Services Trust &amp; Safety uses the information that you provide to investigate
    /// and try to resolve the incident that you reported.
    /// </para>
    ///  
    /// <para>
    /// You submit reports in the eXtended Abuse Reporting Format (XARF), an open standard
    /// for structured abuse reporting. For more information, see <a href="https://xarf.org/docs/introduction/">XARF
    /// on the XARF website</a>. Reports can cover a wide range of abuse categories, including
    /// spam, phishing, distributed denial of service (DDoS), malware distribution, and copyright
    /// infringement.
    /// </para>
    ///  
    /// <para>
    /// With the Amazon Web Services Abuse Signal API, you can:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Submit abuse reports</b> – Create structured abuse reports by using the XARF format,
    /// with full support for all XARF v4 report types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Track report status</b> – Monitor the processing status of submitted reports,
    /// from submission through resolution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>List and filter reports</b> – Retrieve the status of all reports, with optional
    /// filtering by correlation ID.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Retry submissions safely</b> – Safely retry report submissions without creating
    /// duplicates by using client tokens.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    ///  <b>Cross-Region data residency:</b> By submitting a report, you instruct Amazon Web
    /// Services to store it in all supported Regions (<c>us-east-1</c>, <c>us-west-2</c>,
    /// and <c>eu-west-2</c>), including across the United States and Europe. If data must
    /// remain in a single Region, do not include it in the report.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AmazonAbuseSignalClient : AmazonServiceClient, IAmazonAbuseSignal
    {
        private static IServiceMetadata serviceMetadata = new AmazonAbuseSignalMetadata();
        private IAbuseSignalPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAbuseSignalPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new AbuseSignalPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonAbuseSignalClient with the credentials loaded from the application's
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
        public AmazonAbuseSignalClient() : base(new AmazonAbuseSignalConfig()) { }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with the credentials loaded from the application's
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
        public AmazonAbuseSignalClient(RegionEndpoint region) : base(new AmazonAbuseSignalConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAbuseSignalClient Configuration Object</param>
        public AmazonAbuseSignalClient(AmazonAbuseSignalConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAbuseSignalClient(AWSCredentials credentials)
            : this(credentials, new AmazonAbuseSignalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAbuseSignalClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAbuseSignalConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with AWS Credentials and an
        /// AmazonAbuseSignalClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAbuseSignalClient Configuration Object</param>
        public AmazonAbuseSignalClient(AWSCredentials credentials, AmazonAbuseSignalConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAbuseSignalClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAbuseSignalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAbuseSignalClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAbuseSignalConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAbuseSignalClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAbuseSignalClient Configuration Object</param>
        public AmazonAbuseSignalClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAbuseSignalConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAbuseSignalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAbuseSignalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAbuseSignalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAbuseSignalConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonAbuseSignalClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAbuseSignalClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAbuseSignalClient Configuration Object</param>
        public AmazonAbuseSignalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAbuseSignalConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAbuseSignalEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAbuseSignalAuthSchemeHandler());
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

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Submits a structured report. Amazon Web Services validates it and returns a report
        /// ID. A successful response confirms that Amazon Web Services received your report.
        /// It doesn't mean that Amazon Web Services has reached an outcome. Use <a>GetAbuseReportStatus</a>
        /// with the report ID to check the report's status and outcome.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent within a time window. If you provide a <c>clientToken</c>,
        /// duplicate requests within 24 hours return the existing report ID. If you omit it,
        /// the service generates a token scoped to 5 minutes.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>Cross-Region data residency:</b> By submitting a report, you instruct Amazon Web
        /// Services to store it in all supported Regions (<c>us-east-1</c>, <c>us-west-2</c>,
        /// and <c>eu-west-2</c>), including across the United States and Europe. If data must
        /// remain in a single Region, do not include it in the report.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAbuseReport service method.</param>
        /// <returns>The response from the CreateAbuseReport service method, as returned by AbuseSignal.</returns>
        /// <exception cref="Amazon.AbuseSignal.Model.AccessDeniedException">
        /// The caller does not have sufficient access to perform this operation. Verify that
        /// the caller has the specific IAM permission for the operation it is calling (for example,
        /// <c>abuse:CreateAbuseReport</c>, <c>abuse:GetAbuseReportStatus</c>, or <c>abuse:ListAbuseReportStatuses</c>).
        /// Grant only the actions each caller requires.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, an idempotency
        /// token was reused with a different payload.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request. This error is retryable;
        /// check the <c>Retry-After</c> header before you retry.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.SubmissionRequirementException">
        /// The report is well-formed and satisfies the XARF schema, but it does not meet one
        /// or more submission requirements (for example, the submission lookback window or <c>source_identifier</c>
        /// restrictions). This error is distinct from <c>ValidationException</c> (HTTP 400),
        /// which indicates that the report is not well-formed. Retrying the same report will
        /// not succeed; the report content must change.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ThrottlingException">
        /// The request was denied due to request throttling. This error is retryable; retry with
        /// exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service, which indicates
        /// that the request is not well-formed. Check <c>fieldList</c> for the specific members
        /// that failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/abuse-signal-2026-01-12/CreateAbuseReport">REST API Reference for CreateAbuseReport Operation</seealso>
        public virtual CreateAbuseReportResponse CreateAbuseReport(CreateAbuseReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAbuseReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAbuseReportResponseUnmarshaller.Instance;

            return Invoke<CreateAbuseReportResponse>(request, options);
        }
#else
        internal virtual CreateAbuseReportResponse CreateAbuseReport(CreateAbuseReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAbuseReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAbuseReportResponseUnmarshaller.Instance;

            return Invoke<CreateAbuseReportResponse>(request, options);
        }
#endif

        /// <summary>
        /// Submits a structured report. Amazon Web Services validates it and returns a report
        /// ID. A successful response confirms that Amazon Web Services received your report.
        /// It doesn't mean that Amazon Web Services has reached an outcome. Use <a>GetAbuseReportStatus</a>
        /// with the report ID to check the report's status and outcome.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent within a time window. If you provide a <c>clientToken</c>,
        /// duplicate requests within 24 hours return the existing report ID. If you omit it,
        /// the service generates a token scoped to 5 minutes.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>Cross-Region data residency:</b> By submitting a report, you instruct Amazon Web
        /// Services to store it in all supported Regions (<c>us-east-1</c>, <c>us-west-2</c>,
        /// and <c>eu-west-2</c>), including across the United States and Europe. If data must
        /// remain in a single Region, do not include it in the report.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAbuseReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAbuseReport service method, as returned by AbuseSignal.</returns>
        /// <exception cref="Amazon.AbuseSignal.Model.AccessDeniedException">
        /// The caller does not have sufficient access to perform this operation. Verify that
        /// the caller has the specific IAM permission for the operation it is calling (for example,
        /// <c>abuse:CreateAbuseReport</c>, <c>abuse:GetAbuseReportStatus</c>, or <c>abuse:ListAbuseReportStatuses</c>).
        /// Grant only the actions each caller requires.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, an idempotency
        /// token was reused with a different payload.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request. This error is retryable;
        /// check the <c>Retry-After</c> header before you retry.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.SubmissionRequirementException">
        /// The report is well-formed and satisfies the XARF schema, but it does not meet one
        /// or more submission requirements (for example, the submission lookback window or <c>source_identifier</c>
        /// restrictions). This error is distinct from <c>ValidationException</c> (HTTP 400),
        /// which indicates that the report is not well-formed. Retrying the same report will
        /// not succeed; the report content must change.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ThrottlingException">
        /// The request was denied due to request throttling. This error is retryable; retry with
        /// exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service, which indicates
        /// that the request is not well-formed. Check <c>fieldList</c> for the specific members
        /// that failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/abuse-signal-2026-01-12/CreateAbuseReport">REST API Reference for CreateAbuseReport Operation</seealso>
        public virtual Task<CreateAbuseReportResponse> CreateAbuseReportAsync(CreateAbuseReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAbuseReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAbuseReportResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAbuseReportResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current processing status of a previously submitted abuse report, including
        /// the status, submission timestamp, and last-update time.
        /// 
        ///  
        /// <para>
        /// You can poll this operation to track the report's status. <c>PROCESSING</c> confirms
        /// that Amazon Web Services received your report and is processing it. <c>COMPLETED</c>
        /// means Amazon Web Services finished resolving the report, and the response includes
        /// a <c>reasonCode</c>. The time to reach <c>COMPLETED</c> may vary and can take up to
        /// several days depending on the scope and complexity of the suspected abuse.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>COMPLETED</c> is the only terminal status. To wait for a report, use the <c>ReportProcessing</c>
        /// waiter, which succeeds when the report reaches <c>PROCESSING</c> or <c>COMPLETED</c>.
        /// If you poll this operation yourself, wait 1–5 seconds between calls.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAbuseReportStatus service method.</param>
        /// <returns>The response from the GetAbuseReportStatus service method, as returned by AbuseSignal.</returns>
        /// <exception cref="Amazon.AbuseSignal.Model.AccessDeniedException">
        /// The caller does not have sufficient access to perform this operation. Verify that
        /// the caller has the specific IAM permission for the operation it is calling (for example,
        /// <c>abuse:CreateAbuseReport</c>, <c>abuse:GetAbuseReportStatus</c>, or <c>abuse:ListAbuseReportStatuses</c>).
        /// Grant only the actions each caller requires.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request. This error is retryable;
        /// check the <c>Retry-After</c> header before you retry.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the <c>reportId</c> is correct.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ThrottlingException">
        /// The request was denied due to request throttling. This error is retryable; retry with
        /// exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service, which indicates
        /// that the request is not well-formed. Check <c>fieldList</c> for the specific members
        /// that failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/abuse-signal-2026-01-12/GetAbuseReportStatus">REST API Reference for GetAbuseReportStatus Operation</seealso>
        public virtual GetAbuseReportStatusResponse GetAbuseReportStatus(GetAbuseReportStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAbuseReportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAbuseReportStatusResponseUnmarshaller.Instance;

            return Invoke<GetAbuseReportStatusResponse>(request, options);
        }
#else
        internal virtual GetAbuseReportStatusResponse GetAbuseReportStatus(GetAbuseReportStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAbuseReportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAbuseReportStatusResponseUnmarshaller.Instance;

            return Invoke<GetAbuseReportStatusResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the current processing status of a previously submitted abuse report, including
        /// the status, submission timestamp, and last-update time.
        /// 
        ///  
        /// <para>
        /// You can poll this operation to track the report's status. <c>PROCESSING</c> confirms
        /// that Amazon Web Services received your report and is processing it. <c>COMPLETED</c>
        /// means Amazon Web Services finished resolving the report, and the response includes
        /// a <c>reasonCode</c>. The time to reach <c>COMPLETED</c> may vary and can take up to
        /// several days depending on the scope and complexity of the suspected abuse.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>COMPLETED</c> is the only terminal status. To wait for a report, use the <c>ReportProcessing</c>
        /// waiter, which succeeds when the report reaches <c>PROCESSING</c> or <c>COMPLETED</c>.
        /// If you poll this operation yourself, wait 1–5 seconds between calls.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAbuseReportStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAbuseReportStatus service method, as returned by AbuseSignal.</returns>
        /// <exception cref="Amazon.AbuseSignal.Model.AccessDeniedException">
        /// The caller does not have sufficient access to perform this operation. Verify that
        /// the caller has the specific IAM permission for the operation it is calling (for example,
        /// <c>abuse:CreateAbuseReport</c>, <c>abuse:GetAbuseReportStatus</c>, or <c>abuse:ListAbuseReportStatuses</c>).
        /// Grant only the actions each caller requires.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request. This error is retryable;
        /// check the <c>Retry-After</c> header before you retry.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the <c>reportId</c> is correct.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ThrottlingException">
        /// The request was denied due to request throttling. This error is retryable; retry with
        /// exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service, which indicates
        /// that the request is not well-formed. Check <c>fieldList</c> for the specific members
        /// that failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/abuse-signal-2026-01-12/GetAbuseReportStatus">REST API Reference for GetAbuseReportStatus Operation</seealso>
        public virtual Task<GetAbuseReportStatusResponse> GetAbuseReportStatusAsync(GetAbuseReportStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAbuseReportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAbuseReportStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetAbuseReportStatusResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists abuse report statuses for the calling account, ordered by submission time, with
        /// optional filtering and pagination.
        /// 
        ///  
        /// <para>
        /// Use the <c>correlationId</c> parameter to filter results by the reporter-provided
        /// correlation ID that was specified during report submission.
        /// </para>
        ///  
        /// <para>
        /// Results are paginated. Use <c>nextToken</c> to retrieve additional results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAbuseReportStatuses service method.</param>
        /// <returns>The response from the ListAbuseReportStatuses service method, as returned by AbuseSignal.</returns>
        /// <exception cref="Amazon.AbuseSignal.Model.AccessDeniedException">
        /// The caller does not have sufficient access to perform this operation. Verify that
        /// the caller has the specific IAM permission for the operation it is calling (for example,
        /// <c>abuse:CreateAbuseReport</c>, <c>abuse:GetAbuseReportStatus</c>, or <c>abuse:ListAbuseReportStatuses</c>).
        /// Grant only the actions each caller requires.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request. This error is retryable;
        /// check the <c>Retry-After</c> header before you retry.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ThrottlingException">
        /// The request was denied due to request throttling. This error is retryable; retry with
        /// exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service, which indicates
        /// that the request is not well-formed. Check <c>fieldList</c> for the specific members
        /// that failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/abuse-signal-2026-01-12/ListAbuseReportStatuses">REST API Reference for ListAbuseReportStatuses Operation</seealso>
        public virtual ListAbuseReportStatusesResponse ListAbuseReportStatuses(ListAbuseReportStatusesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAbuseReportStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAbuseReportStatusesResponseUnmarshaller.Instance;

            return Invoke<ListAbuseReportStatusesResponse>(request, options);
        }
#else
        internal virtual ListAbuseReportStatusesResponse ListAbuseReportStatuses(ListAbuseReportStatusesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAbuseReportStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAbuseReportStatusesResponseUnmarshaller.Instance;

            return Invoke<ListAbuseReportStatusesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists abuse report statuses for the calling account, ordered by submission time, with
        /// optional filtering and pagination.
        /// 
        ///  
        /// <para>
        /// Use the <c>correlationId</c> parameter to filter results by the reporter-provided
        /// correlation ID that was specified during report submission.
        /// </para>
        ///  
        /// <para>
        /// Results are paginated. Use <c>nextToken</c> to retrieve additional results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAbuseReportStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAbuseReportStatuses service method, as returned by AbuseSignal.</returns>
        /// <exception cref="Amazon.AbuseSignal.Model.AccessDeniedException">
        /// The caller does not have sufficient access to perform this operation. Verify that
        /// the caller has the specific IAM permission for the operation it is calling (for example,
        /// <c>abuse:CreateAbuseReport</c>, <c>abuse:GetAbuseReportStatus</c>, or <c>abuse:ListAbuseReportStatuses</c>).
        /// Grant only the actions each caller requires.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request. This error is retryable;
        /// check the <c>Retry-After</c> header before you retry.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ThrottlingException">
        /// The request was denied due to request throttling. This error is retryable; retry with
        /// exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.AbuseSignal.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service, which indicates
        /// that the request is not well-formed. Check <c>fieldList</c> for the specific members
        /// that failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/abuse-signal-2026-01-12/ListAbuseReportStatuses">REST API Reference for ListAbuseReportStatuses Operation</seealso>
        public virtual Task<ListAbuseReportStatusesResponse> ListAbuseReportStatusesAsync(ListAbuseReportStatusesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAbuseReportStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAbuseReportStatusesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAbuseReportStatusesResponse>(request, options, cancellationToken);
        }

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
    }
}
