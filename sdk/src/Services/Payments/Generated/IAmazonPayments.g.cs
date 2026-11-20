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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Payments.Model;

#pragma warning disable CS1570

namespace Amazon.Payments
{
    /// <summary>
    /// <para>Interface for accessing Payments</para>
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
    public partial interface IAmazonPayments : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPaymentsPaginatorFactory Paginators { get; }

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
        BatchGetFinancialRecordResponse BatchGetFinancialRecord(BatchGetFinancialRecordRequest request);
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
        Task<BatchGetFinancialRecordResponse> BatchGetFinancialRecordAsync(BatchGetFinancialRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetAccountBalanceResponse GetAccountBalance(GetAccountBalanceRequest request);
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
        Task<GetAccountBalanceResponse> GetAccountBalanceAsync(GetAccountBalanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetFinancialRecordResponse GetFinancialRecord(GetFinancialRecordRequest request);
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
        Task<GetFinancialRecordResponse> GetFinancialRecordAsync(GetFinancialRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetPaymentInstrumentResponse GetPaymentInstrument(GetPaymentInstrumentRequest request);
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
        Task<GetPaymentInstrumentResponse> GetPaymentInstrumentAsync(GetPaymentInstrumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListFinancialRecordsResponse ListFinancialRecords(ListFinancialRecordsRequest request);
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
        Task<ListFinancialRecordsResponse> ListFinancialRecordsAsync(ListFinancialRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListPaymentInstrumentsResponse ListPaymentInstruments(ListPaymentInstrumentsRequest request);
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
        Task<ListPaymentInstrumentsResponse> ListPaymentInstrumentsAsync(ListPaymentInstrumentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonPaymentsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonPaymentsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonPaymentsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonPaymentsConfig to create AmazonPaymentsClient");
            }

            return awsCredentials == null ?
                    new AmazonPaymentsClient(serviceClientConfig) :
                    new AmazonPaymentsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
