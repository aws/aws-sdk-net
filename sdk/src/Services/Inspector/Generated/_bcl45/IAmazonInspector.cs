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
using System.Threading;
using System.Threading.Tasks;
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
    /// AWS and to identify potential security issues. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_introduction.html">
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
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddAttributesToFindingsResponse> AddAttributesToFindingsAsync(AddAttributesToFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the AttachAssessmentAndRulesPackage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AttachAssessmentAndRulesPackageResponse> AttachAssessmentAndRulesPackageAsync(AttachAssessmentAndRulesPackageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new application using the resource group ARN generated by <a>CreateResourceGroup</a>.
        /// You can create up to 50 applications per AWS account. You can run up to 500 concurrent
        /// agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">
        /// Inspector Applications.</a>
        /// </summary>
        /// <param name="applicationName">The user-defined name identifying the application that you want to create. The name must be unique within the AWS account.</param>
        /// <param name="resourceGroupArn">The ARN specifying the resource group that is used to create the application.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateApplicationResponse> CreateApplicationAsync(string applicationName, string resourceGroupArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAssessmentResponse> CreateAssessmentAsync(CreateAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Inspector application. The
        /// created resource group is then used to create an Inspector application.
        /// </summary>
        /// <param name="resourceGroupTags">A collection of keys and an array of possible values in JSON format. For example, [{ "key1" : ["Value1","Value2"]},{"Key2": ["Value3"]}]</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateResourceGroupResponse> CreateResourceGroupAsync(string resourceGroupTags, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">The ARN specifying the application that you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteApplicationResponse> DeleteApplicationAsync(string applicationArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment that you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAssessmentResponse> DeleteAssessmentAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteAssessmentResponse> DeleteAssessmentAsync(DeleteAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="runArn">The ARN specifying the assessment run that you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteRunResponse> DeleteRunAsync(string runArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteRunResponse> DeleteRunAsync(DeleteRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">The ARN specifying the application that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeApplicationResponse> DescribeApplicationAsync(string applicationArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeAssessmentResponse> DescribeAssessmentAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAssessmentResponse> DescribeAssessmentAsync(DescribeAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCrossAccountAccessRoleResponse> DescribeCrossAccountAccessRoleAsync(DescribeCrossAccountAccessRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the finding specified by the finding ARN.
        /// </summary>
        /// <param name="findingArn">The ARN specifying the finding that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeFindingResponse> DescribeFindingAsync(string findingArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFinding operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFindingResponse> DescribeFindingAsync(DescribeFindingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the resource group specified by the resource group ARN.
        /// </summary>
        /// <param name="resourceGroupArn">The ARN specifying the resource group that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeResourceGroupResponse> DescribeResourceGroupAsync(string resourceGroupArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeResourceGroupResponse> DescribeResourceGroupAsync(DescribeResourceGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the rules package specified by the rules package ARN.
        /// </summary>
        /// <param name="rulesPackageArn">The ARN specifying the rules package that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeRulesPackageResponse> DescribeRulesPackageAsync(string rulesPackageArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRulesPackageResponse> DescribeRulesPackageAsync(DescribeRulesPackageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="runArn">The ARN specifying the assessment run that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeRunResponse> DescribeRunAsync(string runArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRunResponse> DescribeRunAsync(DescribeRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Detaches the rules package specified by the rules package ARN from the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment from which you want to detach a rules package.</param>
        /// <param name="rulesPackageArn">The ARN specifying the rules package that you want to detach from the assessment.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DetachAssessmentAndRulesPackageResponse> DetachAssessmentAndRulesPackageAsync(string assessmentArn, string rulesPackageArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DetachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachAssessmentAndRulesPackage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DetachAssessmentAndRulesPackageResponse> DetachAssessmentAndRulesPackageAsync(DetachAssessmentAndRulesPackageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the metadata about the telemetry (application behavioral data) for the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment the telemetry of which you want to obtain.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAssessmentTelemetryResponse> GetAssessmentTelemetryAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentTelemetry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentTelemetry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetAssessmentTelemetryResponse> GetAssessmentTelemetryAsync(GetAssessmentTelemetryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the ARNs of the applications within this AWS account. For more information about
        /// applications, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">Inspector
        /// Applications</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListApplicationsResponse> ListApplicationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Lists the ARNs of the applications within this AWS account. For more information about
        /// applications, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">Inspector
        /// Applications</a>.
        /// </summary>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListApplicationsResponse> ListApplicationsAsync(ApplicationsFilter filter, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the agents of the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment whose agents you want to list.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentAgentsResponse> ListAssessmentAgentsAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Lists the agents of the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment whose agents you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentAgentsResponse> ListAssessmentAgentsAsync(string assessmentArn, AgentsFilter filter, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListAssessmentAgentsResponse> ListAssessmentAgentsAsync(ListAssessmentAgentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the assessments corresponding to applications specified by the applications'
        /// ARNs.
        /// </summary>
        /// <param name="applicationArns">A list of ARNs specifying the applications the assessments of which you want to list.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentsResponse> ListAssessmentsAsync(List<string> applicationArns, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Lists the assessments corresponding to applications specified by the applications'
        /// ARNs.
        /// </summary>
        /// <param name="applicationArns">A list of ARNs specifying the applications the assessments of which you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAssessmentsResponse> ListAssessmentsAsync(List<string> applicationArns, AssessmentsFilter filter, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListAssessmentsResponse> ListAssessmentsAsync(ListAssessmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedAssessments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListAttachedAssessmentsResponse> ListAttachedAssessmentsAsync(ListAttachedAssessmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRulesPackages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListAttachedRulesPackagesResponse> ListAttachedRulesPackagesAsync(ListAttachedRulesPackagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListRulesPackagesResponse> ListRulesPackagesAsync(ListRulesPackagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the assessment runs associated with the assessments specified by the assessment
        /// ARNs.
        /// </summary>
        /// <param name="assessmentArns">The ARNs specifying the assessments whose runs you want to list.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRunsResponse> ListRunsAsync(List<string> assessmentArns, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Lists the assessment runs associated with the assessments specified by the assessment
        /// ARNs.
        /// </summary>
        /// <param name="assessmentArns">The ARNs specifying the assessments whose runs you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRunsResponse> ListRunsAsync(List<string> assessmentArns, RunsFilter filter, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListRunsResponse> ListRunsAsync(ListRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="resourceArn">The ARN specifying the resource whose tags you want to list.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(string resourceArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the LocalizeText operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<LocalizeTextResponse> LocalizeTextAsync(LocalizeTextRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Previews the agents installed on the EC2 instances that are included in the application
        /// created with the specified resource group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PreviewAgentsForResourceGroupResponse> PreviewAgentsForResourceGroupAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the PreviewAgentsForResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgentsForResourceGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PreviewAgentsForResourceGroupResponse> PreviewAgentsForResourceGroupAsync(PreviewAgentsForResourceGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Register the role that Inspector uses to list your EC2 instances during the assessment.
        /// </summary>
        /// <param name="roleArn">The ARN of the IAM role that Inspector uses to list your EC2 instances during the assessment.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RegisterCrossAccountAccessRoleResponse> RegisterCrossAccountAccessRoleAsync(string roleArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterCrossAccountAccessRoleResponse> RegisterCrossAccountAccessRoleAsync(RegisterCrossAccountAccessRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveAttributesFromFindingsResponse> RemoveAttributesFromFindingsAsync(RemoveAttributesFromFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts the analysis of the application’s behavior against selected rule packages for
        /// the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="runName">A name specifying the run of the assessment.</param>
        /// <param name="assessmentArn">The ARN of the assessment that you want to run.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RunAssessmentResponse> RunAssessmentAsync(string runName, string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the RunAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RunAssessmentResponse> RunAssessmentAsync(RunAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Sets tags (key and value pairs) to the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="resourceArn">The ARN of the assessment that you want to set tags to.</param>
        /// <param name="tags">A collection of key and value pairs that you want to set to an assessment.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SetTagsForResourceResponse> SetTagsForResourceAsync(string resourceArn, List<Tag> tags, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the SetTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetTagsForResourceResponse> SetTagsForResourceAsync(SetTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts data collection for the assessment specified by the assessment ARN. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="assessmentArn">The ARN of the assessment for which you want to start the data collection process.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartDataCollectionResponse> StartDataCollectionAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartDataCollectionResponse> StartDataCollectionAsync(StartDataCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Stop data collection for the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN of the assessment for which you want to stop the data collection process.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopDataCollectionResponse> StopDataCollectionAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the StopDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopDataCollectionResponse> StopDataCollectionAsync(StopDataCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">Application ARN that you want to update.</param>
        /// <param name="applicationName">Application name that you want to update.</param>
        /// <param name="resourceGroupArn">The resource group ARN that you want to update.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateApplicationResponse> UpdateApplicationAsync(string applicationArn, string applicationName, string resourceGroupArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateAssessmentResponse> UpdateAssessmentAsync(UpdateAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}