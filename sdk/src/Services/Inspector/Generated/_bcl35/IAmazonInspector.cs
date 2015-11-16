/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Inspector.Model;

namespace Amazon.Inspector
{
    /// <summary>
    /// Interface for accessing Inspector
    ///
    /// Amazon Inspector 
    /// <para>
    /// Amazon Inspector enables you to analyze the behavior of the applications you run in
    /// AWS and to identify potential security issues. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_introduction.html">
    /// Amazon Inspector User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonInspector : IDisposable
    {

        
        #region  AddAttributesToFindings


        /// <summary>
        /// Assigns attributes (key and value pair) to the findings specified by the findings'
        /// ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings service method.</param>
        /// 
        /// <returns>The response from the AddAttributesToFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        AddAttributesToFindingsResponse AddAttributesToFindings(AddAttributesToFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddAttributesToFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddAttributesToFindings
        ///         operation.</returns>
        IAsyncResult BeginAddAttributesToFindings(AddAttributesToFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddAttributesToFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddAttributesToFindings.</param>
        /// 
        /// <returns>Returns a  AddAttributesToFindingsResult from Inspector.</returns>
        AddAttributesToFindingsResponse EndAddAttributesToFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachAssessmentAndRulesPackage


        /// <summary>
        /// Attaches the rules package specified by the rules package ARN to the assessment specified
        /// by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachAssessmentAndRulesPackage service method.</param>
        /// 
        /// <returns>The response from the AttachAssessmentAndRulesPackage service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        AttachAssessmentAndRulesPackageResponse AttachAssessmentAndRulesPackage(AttachAssessmentAndRulesPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachAssessmentAndRulesPackage operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachAssessmentAndRulesPackage
        ///         operation.</returns>
        IAsyncResult BeginAttachAssessmentAndRulesPackage(AttachAssessmentAndRulesPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachAssessmentAndRulesPackage.</param>
        /// 
        /// <returns>Returns a  AttachAssessmentAndRulesPackageResult from Inspector.</returns>
        AttachAssessmentAndRulesPackageResponse EndAttachAssessmentAndRulesPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates a new application using the resource group ARN generated by <a>CreateResourceGroup</a>.
        /// You can create up to 50 applications per AWS account. You can run up to 500 concurrent
        /// agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">
        /// Inspector Applications.</a>
        /// </summary>
        /// <param name="applicationName">The user-defined name identifying the application that you want to create. The name must be unique within the AWS account.</param>
        /// <param name="resourceGroupArn">The ARN specifying the resource group that is used to create the application.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        CreateApplicationResponse CreateApplication(string applicationName, string resourceGroupArn);

        /// <summary>
        /// Creates a new application using the resource group ARN generated by <a>CreateResourceGroup</a>.
        /// You can create up to 50 applications per AWS account. You can run up to 500 concurrent
        /// agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">
        /// Inspector Applications.</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from Inspector.</returns>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAssessment


        /// <summary>
        /// Creates an assessment for the application specified by the application ARN. You can
        /// create up to 500 assessments per AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment service method.</param>
        /// 
        /// <returns>The response from the CreateAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        CreateAssessmentResponse CreateAssessment(CreateAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssessment
        ///         operation.</returns>
        IAsyncResult BeginCreateAssessment(CreateAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssessment.</param>
        /// 
        /// <returns>Returns a  CreateAssessmentResult from Inspector.</returns>
        CreateAssessmentResponse EndCreateAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResourceGroup


        /// <summary>
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Inspector application. The
        /// created resource group is then used to create an Inspector application.
        /// </summary>
        /// <param name="resourceGroupTags">A collection of keys and an array of possible values in JSON format. For example, [{ "key1" : ["Value1","Value2"]},{"Key2": ["Value3"]}]</param>
        /// 
        /// <returns>The response from the CreateResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        CreateResourceGroupResponse CreateResourceGroup(string resourceGroupTags);

        /// <summary>
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Inspector application. The
        /// created resource group is then used to create an Inspector application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup service method.</param>
        /// 
        /// <returns>The response from the CreateResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateResourceGroup(CreateResourceGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceGroup.</param>
        /// 
        /// <returns>Returns a  CreateResourceGroupResult from Inspector.</returns>
        CreateResourceGroupResponse EndCreateResourceGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes the application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">The ARN specifying the application that you want to delete.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.OperationInProgressException">
        /// 
        /// </exception>
        DeleteApplicationResponse DeleteApplication(string applicationArn);

        /// <summary>
        /// Deletes the application specified by the application ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.OperationInProgressException">
        /// 
        /// </exception>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from Inspector.</returns>
        DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAssessment


        /// <summary>
        /// Deletes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment that you want to delete.</param>
        /// 
        /// <returns>The response from the DeleteAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.OperationInProgressException">
        /// 
        /// </exception>
        DeleteAssessmentResponse DeleteAssessment(string assessmentArn);

        /// <summary>
        /// Deletes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.OperationInProgressException">
        /// 
        /// </exception>
        DeleteAssessmentResponse DeleteAssessment(DeleteAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessment
        ///         operation.</returns>
        IAsyncResult BeginDeleteAssessment(DeleteAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessment.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentResult from Inspector.</returns>
        DeleteAssessmentResponse EndDeleteAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRun


        /// <summary>
        /// Deletes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="runArn">The ARN specifying the assessment run that you want to delete.</param>
        /// 
        /// <returns>The response from the DeleteRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DeleteRunResponse DeleteRun(string runArn);

        /// <summary>
        /// Deletes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun service method.</param>
        /// 
        /// <returns>The response from the DeleteRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DeleteRunResponse DeleteRun(DeleteRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRun
        ///         operation.</returns>
        IAsyncResult BeginDeleteRun(DeleteRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRun.</param>
        /// 
        /// <returns>Returns a  DeleteRunResult from Inspector.</returns>
        DeleteRunResponse EndDeleteRun(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplication


        /// <summary>
        /// Describes the application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">The ARN specifying the application that you want to describe.</param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeApplicationResponse DescribeApplication(string applicationArn);

        /// <summary>
        /// Describes the application specified by the application ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplication
        ///         operation.</returns>
        IAsyncResult BeginDescribeApplication(DescribeApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplication.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationResult from Inspector.</returns>
        DescribeApplicationResponse EndDescribeApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAssessment


        /// <summary>
        /// Describes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment that you want to describe.</param>
        /// 
        /// <returns>The response from the DescribeAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeAssessmentResponse DescribeAssessment(string assessmentArn);

        /// <summary>
        /// Describes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessment service method.</param>
        /// 
        /// <returns>The response from the DescribeAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeAssessmentResponse DescribeAssessment(DescribeAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessment operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssessment
        ///         operation.</returns>
        IAsyncResult BeginDescribeAssessment(DescribeAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssessment.</param>
        /// 
        /// <returns>Returns a  DescribeAssessmentResult from Inspector.</returns>
        DescribeAssessmentResponse EndDescribeAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCrossAccountAccessRole


        /// <summary>
        /// Describes the IAM role that enables Inspector to access your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole service method.</param>
        /// 
        /// <returns>The response from the DescribeCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        DescribeCrossAccountAccessRoleResponse DescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCrossAccountAccessRole
        ///         operation.</returns>
        IAsyncResult BeginDescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCrossAccountAccessRole.</param>
        /// 
        /// <returns>Returns a  DescribeCrossAccountAccessRoleResult from Inspector.</returns>
        DescribeCrossAccountAccessRoleResponse EndDescribeCrossAccountAccessRole(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFinding


        /// <summary>
        /// Describes the finding specified by the finding ARN.
        /// </summary>
        /// <param name="findingArn">The ARN specifying the finding that you want to describe.</param>
        /// 
        /// <returns>The response from the DescribeFinding service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeFindingResponse DescribeFinding(string findingArn);

        /// <summary>
        /// Describes the finding specified by the finding ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFinding service method.</param>
        /// 
        /// <returns>The response from the DescribeFinding service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeFindingResponse DescribeFinding(DescribeFindingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFinding operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFinding
        ///         operation.</returns>
        IAsyncResult BeginDescribeFinding(DescribeFindingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFinding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFinding.</param>
        /// 
        /// <returns>Returns a  DescribeFindingResult from Inspector.</returns>
        DescribeFindingResponse EndDescribeFinding(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeResourceGroup


        /// <summary>
        /// Describes the resource group specified by the resource group ARN.
        /// </summary>
        /// <param name="resourceGroupArn">The ARN specifying the resource group that you want to describe.</param>
        /// 
        /// <returns>The response from the DescribeResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeResourceGroupResponse DescribeResourceGroup(string resourceGroupArn);

        /// <summary>
        /// Describes the resource group specified by the resource group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeResourceGroupResponse DescribeResourceGroup(DescribeResourceGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroup operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourceGroup
        ///         operation.</returns>
        IAsyncResult BeginDescribeResourceGroup(DescribeResourceGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourceGroup.</param>
        /// 
        /// <returns>Returns a  DescribeResourceGroupResult from Inspector.</returns>
        DescribeResourceGroupResponse EndDescribeResourceGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRulesPackage


        /// <summary>
        /// Describes the rules package specified by the rules package ARN.
        /// </summary>
        /// <param name="rulesPackageArn">The ARN specifying the rules package that you want to describe.</param>
        /// 
        /// <returns>The response from the DescribeRulesPackage service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeRulesPackageResponse DescribeRulesPackage(string rulesPackageArn);

        /// <summary>
        /// Describes the rules package specified by the rules package ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackage service method.</param>
        /// 
        /// <returns>The response from the DescribeRulesPackage service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeRulesPackageResponse DescribeRulesPackage(DescribeRulesPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackage operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRulesPackage
        ///         operation.</returns>
        IAsyncResult BeginDescribeRulesPackage(DescribeRulesPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRulesPackage.</param>
        /// 
        /// <returns>Returns a  DescribeRulesPackageResult from Inspector.</returns>
        DescribeRulesPackageResponse EndDescribeRulesPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRun


        /// <summary>
        /// Describes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="runArn">The ARN specifying the assessment run that you want to describe.</param>
        /// 
        /// <returns>The response from the DescribeRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeRunResponse DescribeRun(string runArn);

        /// <summary>
        /// Describes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRun service method.</param>
        /// 
        /// <returns>The response from the DescribeRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DescribeRunResponse DescribeRun(DescribeRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRun operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRun
        ///         operation.</returns>
        IAsyncResult BeginDescribeRun(DescribeRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRun.</param>
        /// 
        /// <returns>Returns a  DescribeRunResult from Inspector.</returns>
        DescribeRunResponse EndDescribeRun(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachAssessmentAndRulesPackage


        /// <summary>
        /// Detaches the rules package specified by the rules package ARN from the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment from which you want to detach a rules package.</param>
        /// <param name="rulesPackageArn">The ARN specifying the rules package that you want to detach from the assessment.</param>
        /// 
        /// <returns>The response from the DetachAssessmentAndRulesPackage service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DetachAssessmentAndRulesPackageResponse DetachAssessmentAndRulesPackage(string assessmentArn, string rulesPackageArn);

        /// <summary>
        /// Detaches the rules package specified by the rules package ARN from the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachAssessmentAndRulesPackage service method.</param>
        /// 
        /// <returns>The response from the DetachAssessmentAndRulesPackage service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        DetachAssessmentAndRulesPackageResponse DetachAssessmentAndRulesPackage(DetachAssessmentAndRulesPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachAssessmentAndRulesPackage operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachAssessmentAndRulesPackage
        ///         operation.</returns>
        IAsyncResult BeginDetachAssessmentAndRulesPackage(DetachAssessmentAndRulesPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachAssessmentAndRulesPackage.</param>
        /// 
        /// <returns>Returns a  DetachAssessmentAndRulesPackageResult from Inspector.</returns>
        DetachAssessmentAndRulesPackageResponse EndDetachAssessmentAndRulesPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssessmentTelemetry


        /// <summary>
        /// Returns the metadata about the telemetry (application behavioral data) for the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment the telemetry of which you want to obtain.</param>
        /// 
        /// <returns>The response from the GetAssessmentTelemetry service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        GetAssessmentTelemetryResponse GetAssessmentTelemetry(string assessmentArn);

        /// <summary>
        /// Returns the metadata about the telemetry (application behavioral data) for the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentTelemetry service method.</param>
        /// 
        /// <returns>The response from the GetAssessmentTelemetry service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        GetAssessmentTelemetryResponse GetAssessmentTelemetry(GetAssessmentTelemetryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentTelemetry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentTelemetry operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessmentTelemetry
        ///         operation.</returns>
        IAsyncResult BeginGetAssessmentTelemetry(GetAssessmentTelemetryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessmentTelemetry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessmentTelemetry.</param>
        /// 
        /// <returns>Returns a  GetAssessmentTelemetryResult from Inspector.</returns>
        GetAssessmentTelemetryResponse EndGetAssessmentTelemetry(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists the ARNs of the applications within this AWS account. For more information about
        /// applications, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">Inspector
        /// Applications</a>.
        /// </summary>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        ListApplicationsResponse ListApplications();

        /// <summary>
        /// Lists the ARNs of the applications within this AWS account. For more information about
        /// applications, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">Inspector
        /// Applications</a>.
        /// </summary>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        ListApplicationsResponse ListApplications(ApplicationsFilter filter);

        /// <summary>
        /// Lists the ARNs of the applications within this AWS account. For more information about
        /// applications, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">Inspector
        /// Applications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from Inspector.</returns>
        ListApplicationsResponse EndListApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssessmentAgents


        /// <summary>
        /// Lists the agents of the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment whose agents you want to list.</param>
        /// 
        /// <returns>The response from the ListAssessmentAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListAssessmentAgentsResponse ListAssessmentAgents(string assessmentArn);

        /// <summary>
        /// Lists the agents of the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment whose agents you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// 
        /// <returns>The response from the ListAssessmentAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListAssessmentAgentsResponse ListAssessmentAgents(string assessmentArn, AgentsFilter filter);

        /// <summary>
        /// Lists the agents of the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentAgents service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListAssessmentAgentsResponse ListAssessmentAgents(ListAssessmentAgentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentAgents operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentAgents
        ///         operation.</returns>
        IAsyncResult BeginListAssessmentAgents(ListAssessmentAgentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentAgents.</param>
        /// 
        /// <returns>Returns a  ListAssessmentAgentsResult from Inspector.</returns>
        ListAssessmentAgentsResponse EndListAssessmentAgents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssessments


        /// <summary>
        /// Lists the assessments corresponding to applications specified by the applications'
        /// ARNs.
        /// </summary>
        /// <param name="applicationArns">A list of ARNs specifying the applications the assessments of which you want to list.</param>
        /// 
        /// <returns>The response from the ListAssessments service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListAssessmentsResponse ListAssessments(List<string> applicationArns);

        /// <summary>
        /// Lists the assessments corresponding to applications specified by the applications'
        /// ARNs.
        /// </summary>
        /// <param name="applicationArns">A list of ARNs specifying the applications the assessments of which you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// 
        /// <returns>The response from the ListAssessments service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListAssessmentsResponse ListAssessments(List<string> applicationArns, AssessmentsFilter filter);

        /// <summary>
        /// Lists the assessments corresponding to applications specified by the applications'
        /// ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments service method.</param>
        /// 
        /// <returns>The response from the ListAssessments service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListAssessmentsResponse ListAssessments(ListAssessmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessments
        ///         operation.</returns>
        IAsyncResult BeginListAssessments(ListAssessmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessments.</param>
        /// 
        /// <returns>Returns a  ListAssessmentsResult from Inspector.</returns>
        ListAssessmentsResponse EndListAssessments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttachedAssessments


        /// <summary>
        /// Lists the assessments attached to the rules package specified by the rules package
        /// ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedAssessments service method.</param>
        /// 
        /// <returns>The response from the ListAttachedAssessments service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListAttachedAssessmentsResponse ListAttachedAssessments(ListAttachedAssessmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedAssessments operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedAssessments
        ///         operation.</returns>
        IAsyncResult BeginListAttachedAssessments(ListAttachedAssessmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedAssessments.</param>
        /// 
        /// <returns>Returns a  ListAttachedAssessmentsResult from Inspector.</returns>
        ListAttachedAssessmentsResponse EndListAttachedAssessments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttachedRulesPackages


        /// <summary>
        /// Lists the rules packages attached to the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRulesPackages service method.</param>
        /// 
        /// <returns>The response from the ListAttachedRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListAttachedRulesPackagesResponse ListAttachedRulesPackages(ListAttachedRulesPackagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRulesPackages operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedRulesPackages
        ///         operation.</returns>
        IAsyncResult BeginListAttachedRulesPackages(ListAttachedRulesPackagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedRulesPackages.</param>
        /// 
        /// <returns>Returns a  ListAttachedRulesPackagesResult from Inspector.</returns>
        ListAttachedRulesPackagesResponse EndListAttachedRulesPackages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Lists findings generated by the assessment run specified by the run ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListFindingsResponse ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindings
        ///         operation.</returns>
        IAsyncResult BeginListFindings(ListFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindings.</param>
        /// 
        /// <returns>Returns a  ListFindingsResult from Inspector.</returns>
        ListFindingsResponse EndListFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRulesPackages


        /// <summary>
        /// Lists all available Inspector rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages service method.</param>
        /// 
        /// <returns>The response from the ListRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        ListRulesPackagesResponse ListRulesPackages(ListRulesPackagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRulesPackages
        ///         operation.</returns>
        IAsyncResult BeginListRulesPackages(ListRulesPackagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRulesPackages.</param>
        /// 
        /// <returns>Returns a  ListRulesPackagesResult from Inspector.</returns>
        ListRulesPackagesResponse EndListRulesPackages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRuns


        /// <summary>
        /// Lists the assessment runs associated with the assessments specified by the assessment
        /// ARNs.
        /// </summary>
        /// <param name="assessmentArns">The ARNs specifying the assessments whose runs you want to list.</param>
        /// 
        /// <returns>The response from the ListRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListRunsResponse ListRuns(List<string> assessmentArns);

        /// <summary>
        /// Lists the assessment runs associated with the assessments specified by the assessment
        /// ARNs.
        /// </summary>
        /// <param name="assessmentArns">The ARNs specifying the assessments whose runs you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// 
        /// <returns>The response from the ListRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListRunsResponse ListRuns(List<string> assessmentArns, RunsFilter filter);

        /// <summary>
        /// Lists the assessment runs associated with the assessments specified by the assessment
        /// ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuns service method.</param>
        /// 
        /// <returns>The response from the ListRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListRunsResponse ListRuns(ListRunsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuns
        ///         operation.</returns>
        IAsyncResult BeginListRuns(ListRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuns.</param>
        /// 
        /// <returns>Returns a  ListRunsResult from Inspector.</returns>
        ListRunsResponse EndListRuns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="resourceArn">The ARN specifying the resource whose tags you want to list.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListTagsForResourceResponse ListTagsForResource(string resourceArn);

        /// <summary>
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Inspector.</returns>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  LocalizeText


        /// <summary>
        /// Translates a textual identifier into a user-readable text in a specified locale.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LocalizeText service method.</param>
        /// 
        /// <returns>The response from the LocalizeText service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        LocalizeTextResponse LocalizeText(LocalizeTextRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the LocalizeText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LocalizeText operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLocalizeText
        ///         operation.</returns>
        IAsyncResult BeginLocalizeText(LocalizeTextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  LocalizeText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLocalizeText.</param>
        /// 
        /// <returns>Returns a  LocalizeTextResult from Inspector.</returns>
        LocalizeTextResponse EndLocalizeText(IAsyncResult asyncResult);

        #endregion
        
        #region  PreviewAgentsForResourceGroup


        /// <summary>
        /// Previews the agents installed on the EC2 instances that are included in the application
        /// created with the specified resource group.
        /// </summary>
        /// 
        /// <returns>The response from the PreviewAgentsForResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        PreviewAgentsForResourceGroupResponse PreviewAgentsForResourceGroup();

        /// <summary>
        /// Previews the agents installed on the EC2 instances that are included in the application
        /// created with the specified resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgentsForResourceGroup service method.</param>
        /// 
        /// <returns>The response from the PreviewAgentsForResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        PreviewAgentsForResourceGroupResponse PreviewAgentsForResourceGroup(PreviewAgentsForResourceGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PreviewAgentsForResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgentsForResourceGroup operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPreviewAgentsForResourceGroup
        ///         operation.</returns>
        IAsyncResult BeginPreviewAgentsForResourceGroup(PreviewAgentsForResourceGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PreviewAgentsForResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPreviewAgentsForResourceGroup.</param>
        /// 
        /// <returns>Returns a  PreviewAgentsForResourceGroupResult from Inspector.</returns>
        PreviewAgentsForResourceGroupResponse EndPreviewAgentsForResourceGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterCrossAccountAccessRole


        /// <summary>
        /// Register the role that Inspector uses to list your EC2 instances during the assessment.
        /// </summary>
        /// <param name="roleArn">The ARN of the IAM role that Inspector uses to list your EC2 instances during the assessment.</param>
        /// 
        /// <returns>The response from the RegisterCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(string roleArn);

        /// <summary>
        /// Register the role that Inspector uses to list your EC2 instances during the assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole service method.</param>
        /// 
        /// <returns>The response from the RegisterCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterCrossAccountAccessRole
        ///         operation.</returns>
        IAsyncResult BeginRegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterCrossAccountAccessRole.</param>
        /// 
        /// <returns>Returns a  RegisterCrossAccountAccessRoleResult from Inspector.</returns>
        RegisterCrossAccountAccessRoleResponse EndRegisterCrossAccountAccessRole(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveAttributesFromFindings


        /// <summary>
        /// Removes the entire attribute (key and value pair) from the findings specified by the
        /// finding ARNs where an attribute with the specified key exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings service method.</param>
        /// 
        /// <returns>The response from the RemoveAttributesFromFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        RemoveAttributesFromFindingsResponse RemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAttributesFromFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAttributesFromFindings
        ///         operation.</returns>
        IAsyncResult BeginRemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAttributesFromFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAttributesFromFindings.</param>
        /// 
        /// <returns>Returns a  RemoveAttributesFromFindingsResult from Inspector.</returns>
        RemoveAttributesFromFindingsResponse EndRemoveAttributesFromFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  RunAssessment


        /// <summary>
        /// Starts the analysis of the application’s behavior against selected rule packages for
        /// the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="runName">A name specifying the run of the assessment.</param>
        /// <param name="assessmentArn">The ARN of the assessment that you want to run.</param>
        /// 
        /// <returns>The response from the RunAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        RunAssessmentResponse RunAssessment(string runName, string assessmentArn);

        /// <summary>
        /// Starts the analysis of the application’s behavior against selected rule packages for
        /// the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunAssessment service method.</param>
        /// 
        /// <returns>The response from the RunAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        RunAssessmentResponse RunAssessment(RunAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RunAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunAssessment operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunAssessment
        ///         operation.</returns>
        IAsyncResult BeginRunAssessment(RunAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RunAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunAssessment.</param>
        /// 
        /// <returns>Returns a  RunAssessmentResult from Inspector.</returns>
        RunAssessmentResponse EndRunAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  SetTagsForResource


        /// <summary>
        /// Sets tags (key and value pairs) to the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="resourceArn">The ARN of the assessment that you want to set tags to.</param>
        /// <param name="tags">A collection of key and value pairs that you want to set to an assessment.</param>
        /// 
        /// <returns>The response from the SetTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        SetTagsForResourceResponse SetTagsForResource(string resourceArn, List<Tag> tags);

        /// <summary>
        /// Sets tags (key and value pairs) to the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource service method.</param>
        /// 
        /// <returns>The response from the SetTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        SetTagsForResourceResponse SetTagsForResource(SetTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTagsForResource
        ///         operation.</returns>
        IAsyncResult BeginSetTagsForResource(SetTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTagsForResource.</param>
        /// 
        /// <returns>Returns a  SetTagsForResourceResult from Inspector.</returns>
        SetTagsForResourceResponse EndSetTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDataCollection


        /// <summary>
        /// Starts data collection for the assessment specified by the assessment ARN. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="assessmentArn">The ARN of the assessment for which you want to start the data collection process.</param>
        /// 
        /// <returns>The response from the StartDataCollection service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        StartDataCollectionResponse StartDataCollection(string assessmentArn);

        /// <summary>
        /// Starts data collection for the assessment specified by the assessment ARN. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollection service method.</param>
        /// 
        /// <returns>The response from the StartDataCollection service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        StartDataCollectionResponse StartDataCollection(StartDataCollectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollection operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataCollection
        ///         operation.</returns>
        IAsyncResult BeginStartDataCollection(StartDataCollectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataCollection.</param>
        /// 
        /// <returns>Returns a  StartDataCollectionResult from Inspector.</returns>
        StartDataCollectionResponse EndStartDataCollection(IAsyncResult asyncResult);

        #endregion
        
        #region  StopDataCollection


        /// <summary>
        /// Stop data collection for the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN of the assessment for which you want to stop the data collection process.</param>
        /// 
        /// <returns>The response from the StopDataCollection service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        StopDataCollectionResponse StopDataCollection(string assessmentArn);

        /// <summary>
        /// Stop data collection for the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollection service method.</param>
        /// 
        /// <returns>The response from the StopDataCollection service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        StopDataCollectionResponse StopDataCollection(StopDataCollectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollection operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDataCollection
        ///         operation.</returns>
        IAsyncResult BeginStopDataCollection(StopDataCollectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopDataCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDataCollection.</param>
        /// 
        /// <returns>Returns a  StopDataCollectionResult from Inspector.</returns>
        StopDataCollectionResponse EndStopDataCollection(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">Application ARN that you want to update.</param>
        /// <param name="applicationName">Application name that you want to update.</param>
        /// <param name="resourceGroupArn">The resource group ARN that you want to update.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        UpdateApplicationResponse UpdateApplication(string applicationArn, string applicationName, string resourceGroupArn);

        /// <summary>
        /// Updates application specified by the application ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from Inspector.</returns>
        UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAssessment


        /// <summary>
        /// Updates the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        UpdateAssessmentResponse UpdateAssessment(UpdateAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessment
        ///         operation.</returns>
        IAsyncResult BeginUpdateAssessment(UpdateAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessment.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentResult from Inspector.</returns>
        UpdateAssessmentResponse EndUpdateAssessment(IAsyncResult asyncResult);

        #endregion
        
    }
}