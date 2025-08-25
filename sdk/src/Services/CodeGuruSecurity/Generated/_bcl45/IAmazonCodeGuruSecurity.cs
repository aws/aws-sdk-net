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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeGuruSecurity.Model;

#pragma warning disable CS1570
namespace Amazon.CodeGuruSecurity
{
    /// <summary>
    /// <para>Interface for accessing CodeGuruSecurity</para>
    ///
    /// <note> 
    /// <para>
    /// On November 20, 2025, AWS will discontinue support for Amazon CodeGuru Security. After
    /// November 20, 2025, you will no longer be able to access the /codeguru/security console,
    /// service resources, or documentation. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/security-ug/end-of-support.html">https://docs.aws.amazon.com/codeguru/latest/security-ug/end-of-support.html</a>.
    /// 
    ///  </note> 
    /// <para>
    /// This section provides documentation for the Amazon CodeGuru Security API operations.
    /// CodeGuru Security is a service that uses program analysis and machine learning to
    /// detect security policy violations and vulnerabilities, and recommends ways to address
    /// these security risks.
    /// </para>
    ///  
    /// <para>
    /// By proactively detecting and providing recommendations for addressing security risks,
    /// CodeGuru Security improves the overall security of your application code. For more
    /// information about CodeGuru Security, see the <a href="https://docs.aws.amazon.com/codeguru/latest/security-ug/what-is-codeguru-security.html">Amazon
    /// CodeGuru Security User Guide</a>. 
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeGuruSecurity : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeGuruSecurityPaginatorFactory Paginators { get; }

        
        #region  BatchGetFindings


        /// <summary>
        /// Returns a list of requested findings from standard scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindings service method.</param>
        /// 
        /// <returns>The response from the BatchGetFindings service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/BatchGetFindings">REST API Reference for BatchGetFindings Operation</seealso>
        BatchGetFindingsResponse BatchGetFindings(BatchGetFindingsRequest request);



        /// <summary>
        /// Returns a list of requested findings from standard scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetFindings service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/BatchGetFindings">REST API Reference for BatchGetFindings Operation</seealso>
        Task<BatchGetFindingsResponse> BatchGetFindingsAsync(BatchGetFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateScan


        /// <summary>
        /// Use to create a scan using code uploaded to an Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScan service method.</param>
        /// 
        /// <returns>The response from the CreateScan service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/CreateScan">REST API Reference for CreateScan Operation</seealso>
        CreateScanResponse CreateScan(CreateScanRequest request);



        /// <summary>
        /// Use to create a scan using code uploaded to an Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScan service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/CreateScan">REST API Reference for CreateScan Operation</seealso>
        Task<CreateScanResponse> CreateScanAsync(CreateScanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUploadUrl


        /// <summary>
        /// Generates a pre-signed URL, request headers used to upload a code resource, and code
        /// artifact identifier for the uploaded resource.
        /// 
        ///  
        /// <para>
        /// You can upload your code resource to the URL with the request headers using any HTTP
        /// client.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadUrl service method.</param>
        /// 
        /// <returns>The response from the CreateUploadUrl service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/CreateUploadUrl">REST API Reference for CreateUploadUrl Operation</seealso>
        CreateUploadUrlResponse CreateUploadUrl(CreateUploadUrlRequest request);



        /// <summary>
        /// Generates a pre-signed URL, request headers used to upload a code resource, and code
        /// artifact identifier for the uploaded resource.
        /// 
        ///  
        /// <para>
        /// You can upload your code resource to the URL with the request headers using any HTTP
        /// client.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUploadUrl service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/CreateUploadUrl">REST API Reference for CreateUploadUrl Operation</seealso>
        Task<CreateUploadUrlResponse> CreateUploadUrlAsync(CreateUploadUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAccountConfiguration


        /// <summary>
        /// Use to get the encryption configuration for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAccountConfiguration service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetAccountConfiguration">REST API Reference for GetAccountConfiguration Operation</seealso>
        GetAccountConfigurationResponse GetAccountConfiguration(GetAccountConfigurationRequest request);



        /// <summary>
        /// Use to get the encryption configuration for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountConfiguration service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetAccountConfiguration">REST API Reference for GetAccountConfiguration Operation</seealso>
        Task<GetAccountConfigurationResponse> GetAccountConfigurationAsync(GetAccountConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFindings


        /// <summary>
        /// Returns a list of all findings generated by a particular scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetFindings">REST API Reference for GetFindings Operation</seealso>
        GetFindingsResponse GetFindings(GetFindingsRequest request);



        /// <summary>
        /// Returns a list of all findings generated by a particular scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetFindings">REST API Reference for GetFindings Operation</seealso>
        Task<GetFindingsResponse> GetFindingsAsync(GetFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMetricsSummary


        /// <summary>
        /// Returns a summary of metrics for an account from a specified date, including number
        /// of open findings, the categories with most findings, the scans with most open findings,
        /// and scans with most open critical findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricsSummary service method.</param>
        /// 
        /// <returns>The response from the GetMetricsSummary service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetMetricsSummary">REST API Reference for GetMetricsSummary Operation</seealso>
        GetMetricsSummaryResponse GetMetricsSummary(GetMetricsSummaryRequest request);



        /// <summary>
        /// Returns a summary of metrics for an account from a specified date, including number
        /// of open findings, the categories with most findings, the scans with most open findings,
        /// and scans with most open critical findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricsSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricsSummary service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetMetricsSummary">REST API Reference for GetMetricsSummary Operation</seealso>
        Task<GetMetricsSummaryResponse> GetMetricsSummaryAsync(GetMetricsSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetScan


        /// <summary>
        /// Returns details about a scan, including whether or not a scan has completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScan service method.</param>
        /// 
        /// <returns>The response from the GetScan service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetScan">REST API Reference for GetScan Operation</seealso>
        GetScanResponse GetScan(GetScanRequest request);



        /// <summary>
        /// Returns details about a scan, including whether or not a scan has completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScan service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetScan">REST API Reference for GetScan Operation</seealso>
        Task<GetScanResponse> GetScanAsync(GetScanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFindingsMetrics


        /// <summary>
        /// Returns metrics about all findings in an account within a specified time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsMetrics service method.</param>
        /// 
        /// <returns>The response from the ListFindingsMetrics service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListFindingsMetrics">REST API Reference for ListFindingsMetrics Operation</seealso>
        ListFindingsMetricsResponse ListFindingsMetrics(ListFindingsMetricsRequest request);



        /// <summary>
        /// Returns metrics about all findings in an account within a specified time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindingsMetrics service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListFindingsMetrics">REST API Reference for ListFindingsMetrics Operation</seealso>
        Task<ListFindingsMetricsResponse> ListFindingsMetricsAsync(ListFindingsMetricsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListScans


        /// <summary>
        /// Returns a list of all scans in an account. Does not return <c>EXPRESS</c> scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScans service method.</param>
        /// 
        /// <returns>The response from the ListScans service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListScans">REST API Reference for ListScans Operation</seealso>
        ListScansResponse ListScans(ListScansRequest request);



        /// <summary>
        /// Returns a list of all scans in an account. Does not return <c>EXPRESS</c> scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScans service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListScans">REST API Reference for ListScans Operation</seealso>
        Task<ListScansResponse> ListScansAsync(ListScansRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of all tags associated with a scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns a list of all tags associated with a scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Use to add one or more tags to an existing scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Use to add one or more tags to an existing scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Use to remove one or more tags from an existing scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Use to remove one or more tags from an existing scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAccountConfiguration


        /// <summary>
        /// Use to update the encryption configuration for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountConfiguration service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/UpdateAccountConfiguration">REST API Reference for UpdateAccountConfiguration Operation</seealso>
        UpdateAccountConfigurationResponse UpdateAccountConfiguration(UpdateAccountConfigurationRequest request);



        /// <summary>
        /// Use to update the encryption configuration for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountConfiguration service method, as returned by CodeGuruSecurity.</returns>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruSecurity.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/UpdateAccountConfiguration">REST API Reference for UpdateAccountConfiguration Operation</seealso>
        Task<UpdateAccountConfigurationResponse> UpdateAccountConfigurationAsync(UpdateAccountConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}