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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeGuruSecurityPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the BatchGetFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindings operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/BatchGetFindings">REST API Reference for BatchGetFindings Operation</seealso>
        IAsyncResult BeginBatchGetFindings(BatchGetFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetFindings.</param>
        /// 
        /// <returns>Returns a  BatchGetFindingsResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/BatchGetFindings">REST API Reference for BatchGetFindings Operation</seealso>
        BatchGetFindingsResponse EndBatchGetFindings(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateScan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScan operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/CreateScan">REST API Reference for CreateScan Operation</seealso>
        IAsyncResult BeginCreateScan(CreateScanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScan.</param>
        /// 
        /// <returns>Returns a  CreateScanResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/CreateScan">REST API Reference for CreateScan Operation</seealso>
        CreateScanResponse EndCreateScan(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateUploadUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadUrl operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUploadUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/CreateUploadUrl">REST API Reference for CreateUploadUrl Operation</seealso>
        IAsyncResult BeginCreateUploadUrl(CreateUploadUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUploadUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUploadUrl.</param>
        /// 
        /// <returns>Returns a  CreateUploadUrlResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/CreateUploadUrl">REST API Reference for CreateUploadUrl Operation</seealso>
        CreateUploadUrlResponse EndCreateUploadUrl(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountConfiguration operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetAccountConfiguration">REST API Reference for GetAccountConfiguration Operation</seealso>
        IAsyncResult BeginGetAccountConfiguration(GetAccountConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountConfiguration.</param>
        /// 
        /// <returns>Returns a  GetAccountConfigurationResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetAccountConfiguration">REST API Reference for GetAccountConfiguration Operation</seealso>
        GetAccountConfigurationResponse EndGetAccountConfiguration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindings operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetFindings">REST API Reference for GetFindings Operation</seealso>
        IAsyncResult BeginGetFindings(GetFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindings.</param>
        /// 
        /// <returns>Returns a  GetFindingsResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetFindings">REST API Reference for GetFindings Operation</seealso>
        GetFindingsResponse EndGetFindings(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetMetricsSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricsSummary operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetricsSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetMetricsSummary">REST API Reference for GetMetricsSummary Operation</seealso>
        IAsyncResult BeginGetMetricsSummary(GetMetricsSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetricsSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricsSummary.</param>
        /// 
        /// <returns>Returns a  GetMetricsSummaryResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetMetricsSummary">REST API Reference for GetMetricsSummary Operation</seealso>
        GetMetricsSummaryResponse EndGetMetricsSummary(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetScan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetScan operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetScan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetScan">REST API Reference for GetScan Operation</seealso>
        IAsyncResult BeginGetScan(GetScanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetScan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetScan.</param>
        /// 
        /// <returns>Returns a  GetScanResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/GetScan">REST API Reference for GetScan Operation</seealso>
        GetScanResponse EndGetScan(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListFindingsMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsMetrics operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindingsMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListFindingsMetrics">REST API Reference for ListFindingsMetrics Operation</seealso>
        IAsyncResult BeginListFindingsMetrics(ListFindingsMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindingsMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindingsMetrics.</param>
        /// 
        /// <returns>Returns a  ListFindingsMetricsResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListFindingsMetrics">REST API Reference for ListFindingsMetrics Operation</seealso>
        ListFindingsMetricsResponse EndListFindingsMetrics(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListScans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScans operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListScans">REST API Reference for ListScans Operation</seealso>
        IAsyncResult BeginListScans(ListScansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListScans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScans.</param>
        /// 
        /// <returns>Returns a  ListScansResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListScans">REST API Reference for ListScans Operation</seealso>
        ListScansResponse EndListScans(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountConfiguration operation on AmazonCodeGuruSecurityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/UpdateAccountConfiguration">REST API Reference for UpdateAccountConfiguration Operation</seealso>
        IAsyncResult BeginUpdateAccountConfiguration(UpdateAccountConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateAccountConfigurationResult from CodeGuruSecurity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-security-2018-05-10/UpdateAccountConfiguration">REST API Reference for UpdateAccountConfiguration Operation</seealso>
        UpdateAccountConfigurationResponse EndUpdateAccountConfiguration(IAsyncResult asyncResult);

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