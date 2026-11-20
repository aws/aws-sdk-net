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
using Amazon.Payments.Model;
using Amazon.Payments.Model.Internal.MarshallTransformations;
using Amazon.Payments.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.Payments
{
    /// <summary>
    /// <para>Implementation for accessing Payments</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Amazon Web Services Payments manages how money moves between you and Amazon Web Services.
    /// It holds the payment instruments you use to pay Amazon Web Services and to receive
    /// money from Amazon Web Services, such as cards and bank accounts. It collects payment
    /// for your Amazon Web Services invoices, applies your payments and credit memos to them,
    /// and returns refunds.
    /// 
    ///  
    /// <para>
    /// A payment instrument is a channel that moves money between you and Amazon Web Services,
    /// and its payment method is the kind of instrument, such as a card or a bank account.
    /// A financial record is an invoice or credit memo. It shows how much of its amount is
    /// outstanding, processing, settled, and canceled as Amazon Web Services applies payments
    /// and credits.
    /// </para>
    ///  
    /// <para>
    /// With the Amazon Web Services Payments API, you can read your financial records and
    /// account balances, and read your payment instruments and their status.
    /// </para>
    ///  
    /// <para>
    /// The Amazon Web Services Payments API provides the following endpoint:
    /// </para>
    ///  
    /// <para>
    ///  <c>https://payments.us-east-1.api.aws</c> 
    /// </para>
    /// </summary>
    public partial class AmazonPaymentsClient : AmazonServiceClient, IAmazonPayments
    {
        private static IServiceMetadata serviceMetadata = new AmazonPaymentsMetadata();
        private IPaymentsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPaymentsPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new PaymentsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonPaymentsClient with the credentials loaded from the application's
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
        public AmazonPaymentsClient() : base(new AmazonPaymentsConfig()) { }

        /// <summary>
        /// Constructs AmazonPaymentsClient with the credentials loaded from the application's
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
        public AmazonPaymentsClient(RegionEndpoint region) : base(new AmazonPaymentsConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonPaymentsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPaymentsClient Configuration Object</param>
        public AmazonPaymentsClient(AmazonPaymentsConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonPaymentsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPaymentsClient(AWSCredentials credentials)
            : this(credentials, new AmazonPaymentsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPaymentsConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentsClient with AWS Credentials and an
        /// AmazonPaymentsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPaymentsClient Configuration Object</param>
        public AmazonPaymentsClient(AWSCredentials credentials, AmazonPaymentsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPaymentsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPaymentsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPaymentsConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPaymentsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPaymentsClient Configuration Object</param>
        public AmazonPaymentsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPaymentsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPaymentsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPaymentsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPaymentsConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPaymentsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPaymentsClient Configuration Object</param>
        public AmazonPaymentsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPaymentsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPaymentsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPaymentsAuthSchemeHandler());
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
        /// Retrieves up to 100 financial records in one request, including the details that are
        /// specific to each record's type. Identify each record by its ID or by its invoice ID.
        /// Results can be partial: each key that you request appears once in the response, either
        /// as a record in <c>financialRecords</c> or as an error in <c>errors</c>. A key that
        /// matches no record on your account is returned in <c>errors</c> and doesn't fail the
        /// request. This operation provides strongly consistent reads.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for both <c>payments:BatchGetFinancialRecord</c> and <c>payments:GetPaymentStatus</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFinancialRecord service method.</param>
        /// <returns>The response from the BatchGetFinancialRecord service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/BatchGetFinancialRecord">REST API Reference for BatchGetFinancialRecord Operation</seealso>
        public virtual BatchGetFinancialRecordResponse BatchGetFinancialRecord(BatchGetFinancialRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetFinancialRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFinancialRecordResponseUnmarshaller.Instance;

            return Invoke<BatchGetFinancialRecordResponse>(request, options);
        }
#else
        internal virtual BatchGetFinancialRecordResponse BatchGetFinancialRecord(BatchGetFinancialRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetFinancialRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFinancialRecordResponseUnmarshaller.Instance;

            return Invoke<BatchGetFinancialRecordResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves up to 100 financial records in one request, including the details that are
        /// specific to each record's type. Identify each record by its ID or by its invoice ID.
        /// Results can be partial: each key that you request appears once in the response, either
        /// as a record in <c>financialRecords</c> or as an error in <c>errors</c>. A key that
        /// matches no record on your account is returned in <c>errors</c> and doesn't fail the
        /// request. This operation provides strongly consistent reads.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for both <c>payments:BatchGetFinancialRecord</c> and <c>payments:GetPaymentStatus</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFinancialRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the BatchGetFinancialRecord service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/BatchGetFinancialRecord">REST API Reference for BatchGetFinancialRecord Operation</seealso>
        public virtual Task<BatchGetFinancialRecordResponse> BatchGetFinancialRecordAsync(BatchGetFinancialRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetFinancialRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFinancialRecordResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetFinancialRecordResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves one balance of your account, selected by balance type, as one amount for
        /// each merchant of record and currency. Each amount is the sum of the outstanding balances
        /// of your invoices or credit memos that have the status <c>OUTSTANDING</c>. Amounts
        /// are never added together across merchants of record or currencies. This operation
        /// is eventually consistent. Results are paginated. Use <c>nextToken</c> to retrieve
        /// more results.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for both <c>payments:GetAccountBalance</c> and <c>payments:GetPaymentStatus</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountBalance service method.</param>
        /// <returns>The response from the GetAccountBalance service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/GetAccountBalance">REST API Reference for GetAccountBalance Operation</seealso>
        public virtual GetAccountBalanceResponse GetAccountBalance(GetAccountBalanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountBalanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountBalanceResponseUnmarshaller.Instance;

            return Invoke<GetAccountBalanceResponse>(request, options);
        }
#else
        internal virtual GetAccountBalanceResponse GetAccountBalance(GetAccountBalanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountBalanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountBalanceResponseUnmarshaller.Instance;

            return Invoke<GetAccountBalanceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves one balance of your account, selected by balance type, as one amount for
        /// each merchant of record and currency. Each amount is the sum of the outstanding balances
        /// of your invoices or credit memos that have the status <c>OUTSTANDING</c>. Amounts
        /// are never added together across merchants of record or currencies. This operation
        /// is eventually consistent. Results are paginated. Use <c>nextToken</c> to retrieve
        /// more results.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for both <c>payments:GetAccountBalance</c> and <c>payments:GetPaymentStatus</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountBalance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAccountBalance service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/GetAccountBalance">REST API Reference for GetAccountBalance Operation</seealso>
        public virtual Task<GetAccountBalanceResponse> GetAccountBalanceAsync(GetAccountBalanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountBalanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountBalanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountBalanceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a single financial record, including the details that are specific to its
        /// type. Specify exactly one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The ID that Amazon Web Services Payments issued for the record, in <c>identifier</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The invoice ID that Amazon Web Services Invoicing issued for an invoice or a credit
        /// memo, in <c>invoiceIdentifier</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify both or neither, the request fails with <c>ValidationException</c>.
        /// If no record on your account matches, the request fails with <c>ResourceNotFoundException</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation provides strongly consistent reads.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for both <c>payments:GetFinancialRecord</c> and <c>payments:GetPaymentStatus</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFinancialRecord service method.</param>
        /// <returns>The response from the GetFinancialRecord service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ResourceNotFoundException">
        /// The requested resource couldn't be found. Verify that the resource ID is correct.
        /// This error is returned only when you're authorized for the resource.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/GetFinancialRecord">REST API Reference for GetFinancialRecord Operation</seealso>
        public virtual GetFinancialRecordResponse GetFinancialRecord(GetFinancialRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFinancialRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFinancialRecordResponseUnmarshaller.Instance;

            return Invoke<GetFinancialRecordResponse>(request, options);
        }
#else
        internal virtual GetFinancialRecordResponse GetFinancialRecord(GetFinancialRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFinancialRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFinancialRecordResponseUnmarshaller.Instance;

            return Invoke<GetFinancialRecordResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves a single financial record, including the details that are specific to its
        /// type. Specify exactly one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The ID that Amazon Web Services Payments issued for the record, in <c>identifier</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The invoice ID that Amazon Web Services Invoicing issued for an invoice or a credit
        /// memo, in <c>invoiceIdentifier</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify both or neither, the request fails with <c>ValidationException</c>.
        /// If no record on your account matches, the request fails with <c>ResourceNotFoundException</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation provides strongly consistent reads.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for both <c>payments:GetFinancialRecord</c> and <c>payments:GetPaymentStatus</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFinancialRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetFinancialRecord service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ResourceNotFoundException">
        /// The requested resource couldn't be found. Verify that the resource ID is correct.
        /// This error is returned only when you're authorized for the resource.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/GetFinancialRecord">REST API Reference for GetFinancialRecord Operation</seealso>
        public virtual Task<GetFinancialRecordResponse> GetFinancialRecordAsync(GetFinancialRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFinancialRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFinancialRecordResponseUnmarshaller.Instance;

            return InvokeAsync<GetFinancialRecordResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a payment instrument on your account, including the details that are specific
        /// to its payment method, such as a card's last four digits. Identify the instrument
        /// by its Amazon Resource Name (ARN) or by its ID. <c>ListPaymentInstruments</c> returns
        /// both.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for <c>payments:GetPaymentInstrument</c>. You can scope this permission
        /// to the instrument's ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPaymentInstrument service method.</param>
        /// <returns>The response from the GetPaymentInstrument service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ResourceNotFoundException">
        /// The requested resource couldn't be found. Verify that the resource ID is correct.
        /// This error is returned only when you're authorized for the resource.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/GetPaymentInstrument">REST API Reference for GetPaymentInstrument Operation</seealso>
        public virtual GetPaymentInstrumentResponse GetPaymentInstrument(GetPaymentInstrumentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPaymentInstrumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPaymentInstrumentResponseUnmarshaller.Instance;

            return Invoke<GetPaymentInstrumentResponse>(request, options);
        }
#else
        internal virtual GetPaymentInstrumentResponse GetPaymentInstrument(GetPaymentInstrumentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPaymentInstrumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPaymentInstrumentResponseUnmarshaller.Instance;

            return Invoke<GetPaymentInstrumentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves a payment instrument on your account, including the details that are specific
        /// to its payment method, such as a card's last four digits. Identify the instrument
        /// by its Amazon Resource Name (ARN) or by its ID. <c>ListPaymentInstruments</c> returns
        /// both.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for <c>payments:GetPaymentInstrument</c>. You can scope this permission
        /// to the instrument's ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPaymentInstrument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPaymentInstrument service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ResourceNotFoundException">
        /// The requested resource couldn't be found. Verify that the resource ID is correct.
        /// This error is returned only when you're authorized for the resource.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/GetPaymentInstrument">REST API Reference for GetPaymentInstrument Operation</seealso>
        public virtual Task<GetPaymentInstrumentResponse> GetPaymentInstrumentAsync(GetPaymentInstrumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPaymentInstrumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPaymentInstrumentResponseUnmarshaller.Instance;

            return InvokeAsync<GetPaymentInstrumentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the financial records on your account, with the newest first by default. A financial
        /// record is an invoice or a credit memo. You must specify at least one record type in
        /// <c>types</c>. You can narrow the results further by settlement status and issue date.
        /// This operation returns summaries. To get the details that are specific to a record's
        /// type, use <c>GetFinancialRecord</c> or <c>BatchGetFinancialRecord</c>. Results are
        /// paginated. Use <c>nextToken</c> to retrieve more results.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for both <c>payments:ListFinancialRecords</c> and <c>payments:GetPaymentStatus</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFinancialRecords service method.</param>
        /// <returns>The response from the ListFinancialRecords service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/ListFinancialRecords">REST API Reference for ListFinancialRecords Operation</seealso>
        public virtual ListFinancialRecordsResponse ListFinancialRecords(ListFinancialRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFinancialRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFinancialRecordsResponseUnmarshaller.Instance;

            return Invoke<ListFinancialRecordsResponse>(request, options);
        }
#else
        internal virtual ListFinancialRecordsResponse ListFinancialRecords(ListFinancialRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFinancialRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFinancialRecordsResponseUnmarshaller.Instance;

            return Invoke<ListFinancialRecordsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the financial records on your account, with the newest first by default. A financial
        /// record is an invoice or a credit memo. You must specify at least one record type in
        /// <c>types</c>. You can narrow the results further by settlement status and issue date.
        /// This operation returns summaries. To get the details that are specific to a record's
        /// type, use <c>GetFinancialRecord</c> or <c>BatchGetFinancialRecord</c>. Results are
        /// paginated. Use <c>nextToken</c> to retrieve more results.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for both <c>payments:ListFinancialRecords</c> and <c>payments:GetPaymentStatus</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFinancialRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListFinancialRecords service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/ListFinancialRecords">REST API Reference for ListFinancialRecords Operation</seealso>
        public virtual Task<ListFinancialRecordsResponse> ListFinancialRecordsAsync(ListFinancialRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFinancialRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFinancialRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFinancialRecordsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the payment instruments on your account. This operation returns summaries. To
        /// get the details that are specific to an instrument's payment method, use <c>GetPaymentInstrument</c>.
        /// Results are paginated. Use <c>nextToken</c> to retrieve more results.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for <c>payments:ListPaymentInstruments</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPaymentInstruments service method.</param>
        /// <returns>The response from the ListPaymentInstruments service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/ListPaymentInstruments">REST API Reference for ListPaymentInstruments Operation</seealso>
        public virtual ListPaymentInstrumentsResponse ListPaymentInstruments(ListPaymentInstrumentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPaymentInstrumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPaymentInstrumentsResponseUnmarshaller.Instance;

            return Invoke<ListPaymentInstrumentsResponse>(request, options);
        }
#else
        internal virtual ListPaymentInstrumentsResponse ListPaymentInstruments(ListPaymentInstrumentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPaymentInstrumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPaymentInstrumentsResponseUnmarshaller.Instance;

            return Invoke<ListPaymentInstrumentsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the payment instruments on your account. This operation returns summaries. To
        /// get the details that are specific to an instrument's payment method, use <c>GetPaymentInstrument</c>.
        /// Results are paginated. Use <c>nextToken</c> to retrieve more results.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have Amazon Web Services Identity and Access Management
        /// (IAM) permission for <c>payments:ListPaymentInstruments</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPaymentInstruments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPaymentInstruments service method, as returned by Payments.</returns>
        /// <exception cref="Amazon.Payments.Model.AccessDeniedException">
        /// The request is denied because you don't have sufficient access to perform this operation.
        /// Verify that you have the required permissions and try again. This error is also returned,
        /// instead of <c>ResourceNotFoundException</c>, when you aren't authorized for the resource,
        /// so the response doesn't reveal whether the resource exists.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of your requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Payments.Model.ValidationException">
        /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
        /// the request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payments-2026-09-23/ListPaymentInstruments">REST API Reference for ListPaymentInstruments Operation</seealso>
        public virtual Task<ListPaymentInstrumentsResponse> ListPaymentInstrumentsAsync(ListPaymentInstrumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPaymentInstrumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPaymentInstrumentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPaymentInstrumentsResponse>(request, options, cancellationToken);
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
