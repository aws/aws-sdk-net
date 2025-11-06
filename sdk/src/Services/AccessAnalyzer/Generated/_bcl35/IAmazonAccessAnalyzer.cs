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

#pragma warning disable CS1570
namespace Amazon.AccessAnalyzer
{
    /// <summary>
    /// <para>Interface for accessing AccessAnalyzer</para>
    ///
    /// Identity and Access Management Access Analyzer helps you to set, verify, and refine
    /// your IAM policies by providing a suite of capabilities. Its features include findings
    /// for external, internal, and unused access, basic and custom policy checks for validating
    /// policies, and policy generation to generate fine-grained policies. To start using
    /// IAM Access Analyzer to identify external, internal, or unused access, you first need
    /// to create an analyzer.
    /// 
    ///  
    /// <para>
    ///  <b>External access analyzers</b> help you identify potential risks of accessing resources
    /// by enabling you to identify any resource policies that grant access to an external
    /// principal. It does this by using logic-based reasoning to analyze resource-based policies
    /// in your Amazon Web Services environment. An external principal can be another Amazon
    /// Web Services account, a root user, an IAM user or role, a federated user, an Amazon
    /// Web Services service, or an anonymous user. You can also use IAM Access Analyzer to
    /// preview public and cross-account access to your resources before deploying permissions
    /// changes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Internal access analyzers</b> help you identify which principals within your organization
    /// or account have access to selected resources. This analysis supports implementing
    /// the principle of least privilege by ensuring that your specified resources can only
    /// be accessed by the intended principals within your organization.
    /// </para>
    ///  
    /// <para>
    ///  <b>Unused access analyzers</b> help you identify potential identity access risks
    /// by enabling you to identify unused IAM roles, unused access keys, unused console passwords,
    /// and IAM principals with unused service and action-level permissions.
    /// </para>
    ///  
    /// <para>
    /// Beyond findings, IAM Access Analyzer provides basic and custom policy checks to validate
    /// IAM policies before deploying permissions changes. You can use policy generation to
    /// refine permissions by attaching a policy generated using access activity logged in
    /// CloudTrail logs. 
    /// </para>
    ///  
    /// <para>
    /// This guide describes the IAM Access Analyzer operations that you can call programmatically.
    /// For general information about IAM Access Analyzer, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/what-is-access-analyzer.html">Using
    /// Identity and Access Management Access Analyzer</a> in the <b>IAM User Guide</b>.
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
        
        #region  CancelPolicyGeneration


        /// <summary>
        /// Cancels the requested policy generation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPolicyGeneration service method.</param>
        /// 
        /// <returns>The response from the CancelPolicyGeneration service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CancelPolicyGeneration">REST API Reference for CancelPolicyGeneration Operation</seealso>
        CancelPolicyGenerationResponse CancelPolicyGeneration(CancelPolicyGenerationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelPolicyGeneration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelPolicyGeneration operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelPolicyGeneration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CancelPolicyGeneration">REST API Reference for CancelPolicyGeneration Operation</seealso>
        IAsyncResult BeginCancelPolicyGeneration(CancelPolicyGenerationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelPolicyGeneration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelPolicyGeneration.</param>
        /// 
        /// <returns>Returns a  CancelPolicyGenerationResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CancelPolicyGeneration">REST API Reference for CancelPolicyGeneration Operation</seealso>
        CancelPolicyGenerationResponse EndCancelPolicyGeneration(IAsyncResult asyncResult);

        #endregion
        
        #region  CheckAccessNotGranted


        /// <summary>
        /// Checks whether the specified access isn't allowed by a policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckAccessNotGranted service method.</param>
        /// 
        /// <returns>The response from the CheckAccessNotGranted service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InvalidParameterException">
        /// The specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.UnprocessableEntityException">
        /// The specified entity could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckAccessNotGranted">REST API Reference for CheckAccessNotGranted Operation</seealso>
        CheckAccessNotGrantedResponse CheckAccessNotGranted(CheckAccessNotGrantedRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckAccessNotGranted operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckAccessNotGranted operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckAccessNotGranted
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckAccessNotGranted">REST API Reference for CheckAccessNotGranted Operation</seealso>
        IAsyncResult BeginCheckAccessNotGranted(CheckAccessNotGrantedRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckAccessNotGranted operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckAccessNotGranted.</param>
        /// 
        /// <returns>Returns a  CheckAccessNotGrantedResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckAccessNotGranted">REST API Reference for CheckAccessNotGranted Operation</seealso>
        CheckAccessNotGrantedResponse EndCheckAccessNotGranted(IAsyncResult asyncResult);

        #endregion
        
        #region  CheckNoNewAccess


        /// <summary>
        /// Checks whether new access is allowed for an updated policy when compared to the existing
        /// policy.
        /// 
        ///  
        /// <para>
        /// You can find examples for reference policies and learn how to set up and run a custom
        /// policy check for new access in the <a href="https://github.com/aws-samples/iam-access-analyzer-custom-policy-check-samples">IAM
        /// Access Analyzer custom policy checks samples</a> repository on GitHub. The reference
        /// policies in this repository are meant to be passed to the <c>existingPolicyDocument</c>
        /// request parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckNoNewAccess service method.</param>
        /// 
        /// <returns>The response from the CheckNoNewAccess service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InvalidParameterException">
        /// The specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.UnprocessableEntityException">
        /// The specified entity could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckNoNewAccess">REST API Reference for CheckNoNewAccess Operation</seealso>
        CheckNoNewAccessResponse CheckNoNewAccess(CheckNoNewAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckNoNewAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckNoNewAccess operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckNoNewAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckNoNewAccess">REST API Reference for CheckNoNewAccess Operation</seealso>
        IAsyncResult BeginCheckNoNewAccess(CheckNoNewAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckNoNewAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckNoNewAccess.</param>
        /// 
        /// <returns>Returns a  CheckNoNewAccessResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckNoNewAccess">REST API Reference for CheckNoNewAccess Operation</seealso>
        CheckNoNewAccessResponse EndCheckNoNewAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  CheckNoPublicAccess


        /// <summary>
        /// Checks whether a resource policy can grant public access to the specified resource
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckNoPublicAccess service method.</param>
        /// 
        /// <returns>The response from the CheckNoPublicAccess service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InvalidParameterException">
        /// The specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.UnprocessableEntityException">
        /// The specified entity could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckNoPublicAccess">REST API Reference for CheckNoPublicAccess Operation</seealso>
        CheckNoPublicAccessResponse CheckNoPublicAccess(CheckNoPublicAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckNoPublicAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckNoPublicAccess operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckNoPublicAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckNoPublicAccess">REST API Reference for CheckNoPublicAccess Operation</seealso>
        IAsyncResult BeginCheckNoPublicAccess(CheckNoPublicAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckNoPublicAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckNoPublicAccess.</param>
        /// 
        /// <returns>Returns a  CheckNoPublicAccessResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckNoPublicAccess">REST API Reference for CheckNoPublicAccess Operation</seealso>
        CheckNoPublicAccessResponse EndCheckNoPublicAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccessPreview


        /// <summary>
        /// Creates an access preview that allows you to preview IAM Access Analyzer findings
        /// for your resource before deploying resource permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPreview service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPreview service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateAccessPreview">REST API Reference for CreateAccessPreview Operation</seealso>
        CreateAccessPreviewResponse CreateAccessPreview(CreateAccessPreviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessPreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPreview operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessPreview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateAccessPreview">REST API Reference for CreateAccessPreview Operation</seealso>
        IAsyncResult BeginCreateAccessPreview(CreateAccessPreviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessPreview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessPreview.</param>
        /// 
        /// <returns>Returns a  CreateAccessPreviewResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateAccessPreview">REST API Reference for CreateAccessPreview Operation</seealso>
        CreateAccessPreviewResponse EndCreateAccessPreview(IAsyncResult asyncResult);

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
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
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
        /// Deletes the specified analyzer. When you delete an analyzer, IAM Access Analyzer is
        /// disabled for the account or organization in the current or specific Region. All findings
        /// that were generated by the analyzer are deleted. You cannot undo this action.
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
        
        #region  GenerateFindingRecommendation


        /// <summary>
        /// Creates a recommendation for an unused permissions finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateFindingRecommendation service method.</param>
        /// 
        /// <returns>The response from the GenerateFindingRecommendation service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GenerateFindingRecommendation">REST API Reference for GenerateFindingRecommendation Operation</seealso>
        GenerateFindingRecommendationResponse GenerateFindingRecommendation(GenerateFindingRecommendationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateFindingRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateFindingRecommendation operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateFindingRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GenerateFindingRecommendation">REST API Reference for GenerateFindingRecommendation Operation</seealso>
        IAsyncResult BeginGenerateFindingRecommendation(GenerateFindingRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateFindingRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateFindingRecommendation.</param>
        /// 
        /// <returns>Returns a  GenerateFindingRecommendationResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GenerateFindingRecommendation">REST API Reference for GenerateFindingRecommendation Operation</seealso>
        GenerateFindingRecommendationResponse EndGenerateFindingRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPreview


        /// <summary>
        /// Retrieves information about an access preview for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPreview service method.</param>
        /// 
        /// <returns>The response from the GetAccessPreview service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAccessPreview">REST API Reference for GetAccessPreview Operation</seealso>
        GetAccessPreviewResponse GetAccessPreview(GetAccessPreviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPreview operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPreview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAccessPreview">REST API Reference for GetAccessPreview Operation</seealso>
        IAsyncResult BeginGetAccessPreview(GetAccessPreviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPreview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPreview.</param>
        /// 
        /// <returns>Returns a  GetAccessPreviewResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAccessPreview">REST API Reference for GetAccessPreview Operation</seealso>
        GetAccessPreviewResponse EndGetAccessPreview(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAnalyzedResource


        /// <summary>
        /// Retrieves information about a resource that was analyzed.
        /// 
        ///  <note> 
        /// <para>
        /// This action is supported only for external access analyzers.
        /// </para>
        ///  </note>
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
        /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
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
        /// Retrieves information about the specified finding. GetFinding and GetFindingV2 both
        /// use <c>access-analyzer:GetFinding</c> in the <c>Action</c> element of an IAM policy
        /// statement. You must have permission to perform the <c>access-analyzer:GetFinding</c>
        /// action.
        /// 
        ///  <note> 
        /// <para>
        /// GetFinding is supported only for external access analyzers. You must use GetFindingV2
        /// for internal and unused access analyzers.
        /// </para>
        ///  </note>
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
        
        #region  GetFindingRecommendation


        /// <summary>
        /// Retrieves information about a finding recommendation for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetFindingRecommendation service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingRecommendation">REST API Reference for GetFindingRecommendation Operation</seealso>
        GetFindingRecommendationResponse GetFindingRecommendation(GetFindingRecommendationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingRecommendation operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingRecommendation">REST API Reference for GetFindingRecommendation Operation</seealso>
        IAsyncResult BeginGetFindingRecommendation(GetFindingRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingRecommendation.</param>
        /// 
        /// <returns>Returns a  GetFindingRecommendationResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingRecommendation">REST API Reference for GetFindingRecommendation Operation</seealso>
        GetFindingRecommendationResponse EndGetFindingRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFindingsStatistics


        /// <summary>
        /// Retrieves a list of aggregated finding statistics for an external access or unused
        /// access analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics service method.</param>
        /// 
        /// <returns>The response from the GetFindingsStatistics service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        GetFindingsStatisticsResponse GetFindingsStatistics(GetFindingsStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingsStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingsStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        IAsyncResult BeginGetFindingsStatistics(GetFindingsStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingsStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingsStatistics.</param>
        /// 
        /// <returns>Returns a  GetFindingsStatisticsResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        GetFindingsStatisticsResponse EndGetFindingsStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFindingV2


        /// <summary>
        /// Retrieves information about the specified finding. GetFinding and GetFindingV2 both
        /// use <c>access-analyzer:GetFinding</c> in the <c>Action</c> element of an IAM policy
        /// statement. You must have permission to perform the <c>access-analyzer:GetFinding</c>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingV2 service method.</param>
        /// 
        /// <returns>The response from the GetFindingV2 service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingV2">REST API Reference for GetFindingV2 Operation</seealso>
        GetFindingV2Response GetFindingV2(GetFindingV2Request request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingV2 operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingV2">REST API Reference for GetFindingV2 Operation</seealso>
        IAsyncResult BeginGetFindingV2(GetFindingV2Request request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingV2.</param>
        /// 
        /// <returns>Returns a  GetFindingV2Result from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingV2">REST API Reference for GetFindingV2 Operation</seealso>
        GetFindingV2Response EndGetFindingV2(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGeneratedPolicy


        /// <summary>
        /// Retrieves the policy that was generated using <c>StartPolicyGeneration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedPolicy service method.</param>
        /// 
        /// <returns>The response from the GetGeneratedPolicy service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetGeneratedPolicy">REST API Reference for GetGeneratedPolicy Operation</seealso>
        GetGeneratedPolicyResponse GetGeneratedPolicy(GetGeneratedPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeneratedPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedPolicy operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGeneratedPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetGeneratedPolicy">REST API Reference for GetGeneratedPolicy Operation</seealso>
        IAsyncResult BeginGetGeneratedPolicy(GetGeneratedPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGeneratedPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGeneratedPolicy.</param>
        /// 
        /// <returns>Returns a  GetGeneratedPolicyResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetGeneratedPolicy">REST API Reference for GetGeneratedPolicy Operation</seealso>
        GetGeneratedPolicyResponse EndGetGeneratedPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessPreviewFindings


        /// <summary>
        /// Retrieves a list of access preview findings generated by the specified access preview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPreviewFindings service method.</param>
        /// 
        /// <returns>The response from the ListAccessPreviewFindings service method, as returned by AccessAnalyzer.</returns>
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
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAccessPreviewFindings">REST API Reference for ListAccessPreviewFindings Operation</seealso>
        ListAccessPreviewFindingsResponse ListAccessPreviewFindings(ListAccessPreviewFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessPreviewFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPreviewFindings operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessPreviewFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAccessPreviewFindings">REST API Reference for ListAccessPreviewFindings Operation</seealso>
        IAsyncResult BeginListAccessPreviewFindings(ListAccessPreviewFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessPreviewFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessPreviewFindings.</param>
        /// 
        /// <returns>Returns a  ListAccessPreviewFindingsResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAccessPreviewFindings">REST API Reference for ListAccessPreviewFindings Operation</seealso>
        ListAccessPreviewFindingsResponse EndListAccessPreviewFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessPreviews


        /// <summary>
        /// Retrieves a list of access previews for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPreviews service method.</param>
        /// 
        /// <returns>The response from the ListAccessPreviews service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAccessPreviews">REST API Reference for ListAccessPreviews Operation</seealso>
        ListAccessPreviewsResponse ListAccessPreviews(ListAccessPreviewsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessPreviews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPreviews operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessPreviews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAccessPreviews">REST API Reference for ListAccessPreviews Operation</seealso>
        IAsyncResult BeginListAccessPreviews(ListAccessPreviewsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessPreviews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessPreviews.</param>
        /// 
        /// <returns>Returns a  ListAccessPreviewsResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAccessPreviews">REST API Reference for ListAccessPreviews Operation</seealso>
        ListAccessPreviewsResponse EndListAccessPreviews(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAnalyzedResources


        /// <summary>
        /// Retrieves a list of resources of the specified type that have been analyzed by the
        /// specified analyzer.
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
        /// Retrieves a list of findings generated by the specified analyzer. ListFindings and
        /// ListFindingsV2 both use <c>access-analyzer:ListFindings</c> in the <c>Action</c> element
        /// of an IAM policy statement. You must have permission to perform the <c>access-analyzer:ListFindings</c>
        /// action.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to retrieve a list of findings, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        ///  <note> 
        /// <para>
        /// ListFindings is supported only for external access analyzers. You must use ListFindingsV2
        /// for internal and unused access analyzers.
        /// </para>
        ///  </note>
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
        
        #region  ListFindingsV2


        /// <summary>
        /// Retrieves a list of findings generated by the specified analyzer. ListFindings and
        /// ListFindingsV2 both use <c>access-analyzer:ListFindings</c> in the <c>Action</c> element
        /// of an IAM policy statement. You must have permission to perform the <c>access-analyzer:ListFindings</c>
        /// action.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to retrieve a list of findings, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsV2 service method.</param>
        /// 
        /// <returns>The response from the ListFindingsV2 service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListFindingsV2">REST API Reference for ListFindingsV2 Operation</seealso>
        ListFindingsV2Response ListFindingsV2(ListFindingsV2Request request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindingsV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsV2 operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindingsV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListFindingsV2">REST API Reference for ListFindingsV2 Operation</seealso>
        IAsyncResult BeginListFindingsV2(ListFindingsV2Request request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindingsV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindingsV2.</param>
        /// 
        /// <returns>Returns a  ListFindingsV2Result from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListFindingsV2">REST API Reference for ListFindingsV2 Operation</seealso>
        ListFindingsV2Response EndListFindingsV2(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicyGenerations


        /// <summary>
        /// Lists all of the policy generations requested in the last seven days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGenerations service method.</param>
        /// 
        /// <returns>The response from the ListPolicyGenerations service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListPolicyGenerations">REST API Reference for ListPolicyGenerations Operation</seealso>
        ListPolicyGenerationsResponse ListPolicyGenerations(ListPolicyGenerationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyGenerations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGenerations operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyGenerations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListPolicyGenerations">REST API Reference for ListPolicyGenerations Operation</seealso>
        IAsyncResult BeginListPolicyGenerations(ListPolicyGenerationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyGenerations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyGenerations.</param>
        /// 
        /// <returns>Returns a  ListPolicyGenerationsResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListPolicyGenerations">REST API Reference for ListPolicyGenerations Operation</seealso>
        ListPolicyGenerationsResponse EndListPolicyGenerations(IAsyncResult asyncResult);

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
        
        #region  StartPolicyGeneration


        /// <summary>
        /// Starts the policy generation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPolicyGeneration service method.</param>
        /// 
        /// <returns>The response from the StartPolicyGeneration service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/StartPolicyGeneration">REST API Reference for StartPolicyGeneration Operation</seealso>
        StartPolicyGenerationResponse StartPolicyGeneration(StartPolicyGenerationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartPolicyGeneration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPolicyGeneration operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPolicyGeneration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/StartPolicyGeneration">REST API Reference for StartPolicyGeneration Operation</seealso>
        IAsyncResult BeginStartPolicyGeneration(StartPolicyGenerationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartPolicyGeneration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPolicyGeneration.</param>
        /// 
        /// <returns>Returns a  StartPolicyGenerationResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/StartPolicyGeneration">REST API Reference for StartPolicyGeneration Operation</seealso>
        StartPolicyGenerationResponse EndStartPolicyGeneration(IAsyncResult asyncResult);

        #endregion
        
        #region  StartResourceScan


        /// <summary>
        /// Immediately starts a scan of the policies applied to the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// This action is supported only for external access analyzers.
        /// </para>
        ///  </note>
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
        
        #region  UpdateAnalyzer


        /// <summary>
        /// Modifies the configuration of an existing analyzer.
        /// 
        ///  <note> 
        /// <para>
        /// This action is not supported for external access analyzers.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalyzer service method.</param>
        /// 
        /// <returns>The response from the UpdateAnalyzer service method, as returned by AccessAnalyzer.</returns>
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
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateAnalyzer">REST API Reference for UpdateAnalyzer Operation</seealso>
        UpdateAnalyzerResponse UpdateAnalyzer(UpdateAnalyzerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnalyzer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalyzer operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnalyzer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateAnalyzer">REST API Reference for UpdateAnalyzer Operation</seealso>
        IAsyncResult BeginUpdateAnalyzer(UpdateAnalyzerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnalyzer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnalyzer.</param>
        /// 
        /// <returns>Returns a  UpdateAnalyzerResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateAnalyzer">REST API Reference for UpdateAnalyzer Operation</seealso>
        UpdateAnalyzerResponse EndUpdateAnalyzer(IAsyncResult asyncResult);

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
        
        #region  ValidatePolicy


        /// <summary>
        /// Requests the validation of a policy and returns a list of findings. The findings help
        /// you identify issues and provide actionable recommendations to resolve the issue and
        /// enable you to author functional policies that meet security best practices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidatePolicy service method.</param>
        /// 
        /// <returns>The response from the ValidatePolicy service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ValidatePolicy">REST API Reference for ValidatePolicy Operation</seealso>
        ValidatePolicyResponse ValidatePolicy(ValidatePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidatePolicy operation on AmazonAccessAnalyzerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidatePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ValidatePolicy">REST API Reference for ValidatePolicy Operation</seealso>
        IAsyncResult BeginValidatePolicy(ValidatePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidatePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidatePolicy.</param>
        /// 
        /// <returns>Returns a  ValidatePolicyResult from AccessAnalyzer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ValidatePolicy">REST API Reference for ValidatePolicy Operation</seealso>
        ValidatePolicyResponse EndValidatePolicy(IAsyncResult asyncResult);

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