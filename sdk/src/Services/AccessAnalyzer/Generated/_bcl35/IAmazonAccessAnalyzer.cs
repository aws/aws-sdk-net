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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AccessAnalyzer.Model;

namespace Amazon.AccessAnalyzer
{
    /// <summary>
    /// Interface for accessing AccessAnalyzer
    ///
    /// AWS IAM Access Analyzer helps identify potential resource-access risks by enabling
    /// you to identify any policies that grant access to an external principal. It does this
    /// by using logic-based reasoning to analyze resource-based policies in your AWS environment.
    /// An external principal can be another AWS account, a root user, an IAM user or role,
    /// a federated user, an AWS service, or an anonymous user. This guide describes the AWS
    /// IAM Access Analyzer operations that you can call programmatically. For general information
    /// about Access Analyzer, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/what-is-access-analyzer.html">AWS
    /// IAM Access Analyzer</a> in the <b>IAM User Guide</b>.
    /// 
    ///  
    /// <para>
    /// To start using Access Analyzer, you first need to create an analyzer.
    /// </para>
    /// </summary>
    public partial interface IAmazonAccessAnalyzer : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAccessAnalyzerPaginatorFactory Paginators { get; }
#endif


        
        #region  ApplyArchiveRule


        /// <summary>
        /// Retroactively applies the archive rule to existing findings that meet the archive
        /// rule criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyArchiveRule service method.</param>
        /// 
        /// <returns>The response from the ApplyArchiveRule service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ApplyArchiveRule">REST API Reference for ApplyArchiveRule Operation</seealso>
        ApplyArchiveRuleResponse ApplyArchiveRule(ApplyArchiveRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ApplyArchiveRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyArchiveRule operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplyArchiveRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ApplyArchiveRule">REST API Reference for ApplyArchiveRule Operation</seealso>
        IAsyncResult BeginApplyArchiveRule(ApplyArchiveRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ApplyArchiveRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplyArchiveRule.</param>
        /// 
        /// <returns>Returns a  ApplyArchiveRuleResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ApplyArchiveRule">REST API Reference for ApplyArchiveRule Operation</seealso>
        ApplyArchiveRuleResponse EndApplyArchiveRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAnalyzer


        /// <summary>
        /// Creates an analyzer for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalyzer service method.</param>
        /// 
        /// <returns>The response from the CreateAnalyzer service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ConflictException">
        /// A conflict exception error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ServiceQuotaExceededException">
        /// Service quote met error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateAnalyzer">REST API Reference for CreateAnalyzer Operation</seealso>
        CreateAnalyzerResponse CreateAnalyzer(CreateAnalyzerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAnalyzer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalyzer operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnalyzer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateAnalyzer">REST API Reference for CreateAnalyzer Operation</seealso>
        IAsyncResult BeginCreateAnalyzer(CreateAnalyzerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnalyzer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnalyzer.</param>
        /// 
        /// <returns>Returns a  CreateAnalyzerResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateAnalyzer">REST API Reference for CreateAnalyzer Operation</seealso>
        CreateAnalyzerResponse EndCreateAnalyzer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateArchiveRule


        /// <summary>
        /// Creates an archive rule for the specified analyzer. Archive rules automatically archive
        /// new findings that meet the criteria you define when you create the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArchiveRule service method.</param>
        /// 
        /// <returns>The response from the CreateArchiveRule service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ConflictException">
        /// A conflict exception error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ServiceQuotaExceededException">
        /// Service quote met error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateArchiveRule">REST API Reference for CreateArchiveRule Operation</seealso>
        CreateArchiveRuleResponse CreateArchiveRule(CreateArchiveRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateArchiveRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateArchiveRule operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateArchiveRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateArchiveRule">REST API Reference for CreateArchiveRule Operation</seealso>
        IAsyncResult BeginCreateArchiveRule(CreateArchiveRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateArchiveRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateArchiveRule.</param>
        /// 
        /// <returns>Returns a  CreateArchiveRuleResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateArchiveRule">REST API Reference for CreateArchiveRule Operation</seealso>
        CreateArchiveRuleResponse EndCreateArchiveRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAnalyzer


        /// <summary>
        /// Deletes the specified analyzer. When you delete an analyzer, Access Analyzer is disabled
        /// for the account in the current or specific Region. All findings that were generated
        /// by the analyzer are deleted. You cannot undo this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalyzer service method.</param>
        /// 
        /// <returns>The response from the DeleteAnalyzer service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/DeleteAnalyzer">REST API Reference for DeleteAnalyzer Operation</seealso>
        DeleteAnalyzerResponse DeleteAnalyzer(DeleteAnalyzerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnalyzer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalyzer operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnalyzer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/DeleteAnalyzer">REST API Reference for DeleteAnalyzer Operation</seealso>
        IAsyncResult BeginDeleteAnalyzer(DeleteAnalyzerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnalyzer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnalyzer.</param>
        /// 
        /// <returns>Returns a  DeleteAnalyzerResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/DeleteAnalyzer">REST API Reference for DeleteAnalyzer Operation</seealso>
        DeleteAnalyzerResponse EndDeleteAnalyzer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteArchiveRule


        /// <summary>
        /// Deletes the specified archive rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchiveRule service method.</param>
        /// 
        /// <returns>The response from the DeleteArchiveRule service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/DeleteArchiveRule">REST API Reference for DeleteArchiveRule Operation</seealso>
        DeleteArchiveRuleResponse DeleteArchiveRule(DeleteArchiveRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteArchiveRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchiveRule operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteArchiveRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/DeleteArchiveRule">REST API Reference for DeleteArchiveRule Operation</seealso>
        IAsyncResult BeginDeleteArchiveRule(DeleteArchiveRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteArchiveRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteArchiveRule.</param>
        /// 
        /// <returns>Returns a  DeleteArchiveRuleResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/DeleteArchiveRule">REST API Reference for DeleteArchiveRule Operation</seealso>
        DeleteArchiveRuleResponse EndDeleteArchiveRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAnalyzedResource


        /// <summary>
        /// Retrieves information about a resource that was analyzed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalyzedResource service method.</param>
        /// 
        /// <returns>The response from the GetAnalyzedResource service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAnalyzedResource">REST API Reference for GetAnalyzedResource Operation</seealso>
        GetAnalyzedResourceResponse GetAnalyzedResource(GetAnalyzedResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnalyzedResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnalyzedResource operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnalyzedResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAnalyzedResource">REST API Reference for GetAnalyzedResource Operation</seealso>
        IAsyncResult BeginGetAnalyzedResource(GetAnalyzedResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnalyzedResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnalyzedResource.</param>
        /// 
        /// <returns>Returns a  GetAnalyzedResourceResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAnalyzedResource">REST API Reference for GetAnalyzedResource Operation</seealso>
        GetAnalyzedResourceResponse EndGetAnalyzedResource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAnalyzer


        /// <summary>
        /// Retrieves information about the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalyzer service method.</param>
        /// 
        /// <returns>The response from the GetAnalyzer service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAnalyzer">REST API Reference for GetAnalyzer Operation</seealso>
        GetAnalyzerResponse GetAnalyzer(GetAnalyzerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnalyzer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnalyzer operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnalyzer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAnalyzer">REST API Reference for GetAnalyzer Operation</seealso>
        IAsyncResult BeginGetAnalyzer(GetAnalyzerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnalyzer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnalyzer.</param>
        /// 
        /// <returns>Returns a  GetAnalyzerResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAnalyzer">REST API Reference for GetAnalyzer Operation</seealso>
        GetAnalyzerResponse EndGetAnalyzer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetArchiveRule


        /// <summary>
        /// Retrieves information about an archive rule.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">Access
        /// Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveRule service method.</param>
        /// 
        /// <returns>The response from the GetArchiveRule service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetArchiveRule">REST API Reference for GetArchiveRule Operation</seealso>
        GetArchiveRuleResponse GetArchiveRule(GetArchiveRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveRule operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetArchiveRule">REST API Reference for GetArchiveRule Operation</seealso>
        IAsyncResult BeginGetArchiveRule(GetArchiveRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveRule.</param>
        /// 
        /// <returns>Returns a  GetArchiveRuleResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetArchiveRule">REST API Reference for GetArchiveRule Operation</seealso>
        GetArchiveRuleResponse EndGetArchiveRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFinding


        /// <summary>
        /// Retrieves information about the specified finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFinding service method.</param>
        /// 
        /// <returns>The response from the GetFinding service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFinding">REST API Reference for GetFinding Operation</seealso>
        GetFindingResponse GetFinding(GetFindingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFinding operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFinding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFinding">REST API Reference for GetFinding Operation</seealso>
        IAsyncResult BeginGetFinding(GetFindingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFinding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFinding.</param>
        /// 
        /// <returns>Returns a  GetFindingResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFinding">REST API Reference for GetFinding Operation</seealso>
        GetFindingResponse EndGetFinding(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAnalyzedResources


        /// <summary>
        /// Retrieves a list of resources of the specified type that have been analyzed by the
        /// specified analyzer..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyzedResources service method.</param>
        /// 
        /// <returns>The response from the ListAnalyzedResources service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAnalyzedResources">REST API Reference for ListAnalyzedResources Operation</seealso>
        ListAnalyzedResourcesResponse ListAnalyzedResources(ListAnalyzedResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnalyzedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyzedResources operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnalyzedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAnalyzedResources">REST API Reference for ListAnalyzedResources Operation</seealso>
        IAsyncResult BeginListAnalyzedResources(ListAnalyzedResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnalyzedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnalyzedResources.</param>
        /// 
        /// <returns>Returns a  ListAnalyzedResourcesResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAnalyzedResources">REST API Reference for ListAnalyzedResources Operation</seealso>
        ListAnalyzedResourcesResponse EndListAnalyzedResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAnalyzers


        /// <summary>
        /// Retrieves a list of analyzers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyzers service method.</param>
        /// 
        /// <returns>The response from the ListAnalyzers service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAnalyzers">REST API Reference for ListAnalyzers Operation</seealso>
        ListAnalyzersResponse ListAnalyzers(ListAnalyzersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnalyzers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyzers operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnalyzers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAnalyzers">REST API Reference for ListAnalyzers Operation</seealso>
        IAsyncResult BeginListAnalyzers(ListAnalyzersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnalyzers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnalyzers.</param>
        /// 
        /// <returns>Returns a  ListAnalyzersResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAnalyzers">REST API Reference for ListAnalyzers Operation</seealso>
        ListAnalyzersResponse EndListAnalyzers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListArchiveRules


        /// <summary>
        /// Retrieves a list of archive rules created for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveRules service method.</param>
        /// 
        /// <returns>The response from the ListArchiveRules service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListArchiveRules">REST API Reference for ListArchiveRules Operation</seealso>
        ListArchiveRulesResponse ListArchiveRules(ListArchiveRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListArchiveRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveRules operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArchiveRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListArchiveRules">REST API Reference for ListArchiveRules Operation</seealso>
        IAsyncResult BeginListArchiveRules(ListArchiveRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListArchiveRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArchiveRules.</param>
        /// 
        /// <returns>Returns a  ListArchiveRulesResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListArchiveRules">REST API Reference for ListArchiveRules Operation</seealso>
        ListArchiveRulesResponse EndListArchiveRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Retrieves a list of findings generated by the specified analyzer.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">Access
        /// Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListFindings">REST API Reference for ListFindings Operation</seealso>
        IAsyncResult BeginListFindings(ListFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindings.</param>
        /// 
        /// <returns>Returns a  ListFindingsResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse EndListFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves a list of tags applied to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartResourceScan


        /// <summary>
        /// Immediately starts a scan of the policies applied to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartResourceScan service method.</param>
        /// 
        /// <returns>The response from the StartResourceScan service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/StartResourceScan">REST API Reference for StartResourceScan Operation</seealso>
        StartResourceScanResponse StartResourceScan(StartResourceScanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartResourceScan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartResourceScan operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartResourceScan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/StartResourceScan">REST API Reference for StartResourceScan Operation</seealso>
        IAsyncResult BeginStartResourceScan(StartResourceScanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartResourceScan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartResourceScan.</param>
        /// 
        /// <returns>Returns a  StartResourceScanResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/StartResourceScan">REST API Reference for StartResourceScan Operation</seealso>
        StartResourceScanResponse EndStartResourceScan(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateArchiveRule


        /// <summary>
        /// Updates the criteria and values for the specified archive rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchiveRule service method.</param>
        /// 
        /// <returns>The response from the UpdateArchiveRule service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateArchiveRule">REST API Reference for UpdateArchiveRule Operation</seealso>
        UpdateArchiveRuleResponse UpdateArchiveRule(UpdateArchiveRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateArchiveRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchiveRule operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateArchiveRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateArchiveRule">REST API Reference for UpdateArchiveRule Operation</seealso>
        IAsyncResult BeginUpdateArchiveRule(UpdateArchiveRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateArchiveRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateArchiveRule.</param>
        /// 
        /// <returns>Returns a  UpdateArchiveRuleResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateArchiveRule">REST API Reference for UpdateArchiveRule Operation</seealso>
        UpdateArchiveRuleResponse EndUpdateArchiveRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFindings


        /// <summary>
        /// Updates the status for the specified findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings service method.</param>
        /// 
        /// <returns>The response from the UpdateFindings service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        UpdateFindingsResponse UpdateFindings(UpdateFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        IAsyncResult BeginUpdateFindings(UpdateFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFindings.</param>
        /// 
        /// <returns>Returns a  UpdateFindingsResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        UpdateFindingsResponse EndUpdateFindings(IAsyncResult asyncResult);

        #endregion
        
    }
}