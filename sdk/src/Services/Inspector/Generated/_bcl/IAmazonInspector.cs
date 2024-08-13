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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Inspector.Model;

#pragma warning disable CS1570
namespace Amazon.Inspector
{
    /// <summary>
    /// <para>Interface for accessing Inspector</para>
    ///
    /// Amazon Inspector 
    /// <para>
    /// Amazon Inspector enables you to analyze the behavior of your AWS resources and to
    /// identify potential security issues. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_introduction.html">
    /// Amazon Inspector User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonInspector : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IInspectorPaginatorFactory Paginators { get; }

        
        #region  AddAttributesToFindings


        /// <summary>
        /// Assigns attributes (key and value pairs) to the findings that are specified by the
        /// ARNs of the findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings service method.</param>
        /// 
        /// <returns>The response from the AddAttributesToFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/AddAttributesToFindings">REST API Reference for AddAttributesToFindings Operation</seealso>
        AddAttributesToFindingsResponse AddAttributesToFindings(AddAttributesToFindingsRequest request);



        /// <summary>
        /// Assigns attributes (key and value pairs) to the findings that are specified by the
        /// ARNs of the findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddAttributesToFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/AddAttributesToFindings">REST API Reference for AddAttributesToFindings Operation</seealso>
        Task<AddAttributesToFindingsResponse> AddAttributesToFindingsAsync(AddAttributesToFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAssessmentTarget


        /// <summary>
        /// Creates a new assessment target using the ARN of the resource group that is generated
        /// by <a>CreateResourceGroup</a>. If resourceGroupArn is not specified, all EC2 instances
        /// in the current AWS account and region are included in the assessment target. If the
        /// <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, this action also creates and registers a service-linked
        /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
        /// You can create up to 50 assessment targets per AWS account. You can run up to 500
        /// concurrent agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">
        /// Amazon Inspector Assessment Targets</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTarget service method.</param>
        /// 
        /// <returns>The response from the CreateAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTarget">REST API Reference for CreateAssessmentTarget Operation</seealso>
        CreateAssessmentTargetResponse CreateAssessmentTarget(CreateAssessmentTargetRequest request);



        /// <summary>
        /// Creates a new assessment target using the ARN of the resource group that is generated
        /// by <a>CreateResourceGroup</a>. If resourceGroupArn is not specified, all EC2 instances
        /// in the current AWS account and region are included in the assessment target. If the
        /// <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, this action also creates and registers a service-linked
        /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
        /// You can create up to 50 assessment targets per AWS account. You can run up to 500
        /// concurrent agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">
        /// Amazon Inspector Assessment Targets</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTarget">REST API Reference for CreateAssessmentTarget Operation</seealso>
        Task<CreateAssessmentTargetResponse> CreateAssessmentTargetAsync(CreateAssessmentTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAssessmentTemplate


        /// <summary>
        /// Creates an assessment template for the assessment target that is specified by the
        /// ARN of the assessment target. If the <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, this action also creates and registers a service-linked
        /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateAssessmentTemplate service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTemplate">REST API Reference for CreateAssessmentTemplate Operation</seealso>
        CreateAssessmentTemplateResponse CreateAssessmentTemplate(CreateAssessmentTemplateRequest request);



        /// <summary>
        /// Creates an assessment template for the assessment target that is specified by the
        /// ARN of the assessment target. If the <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, this action also creates and registers a service-linked
        /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssessmentTemplate service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTemplate">REST API Reference for CreateAssessmentTemplate Operation</seealso>
        Task<CreateAssessmentTemplateResponse> CreateAssessmentTemplateAsync(CreateAssessmentTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateExclusionsPreview


        /// <summary>
        /// Starts the generation of an exclusions preview for the specified assessment template.
        /// The exclusions preview lists the potential exclusions (ExclusionPreview) that Inspector
        /// can detect before it runs the assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExclusionsPreview service method.</param>
        /// 
        /// <returns>The response from the CreateExclusionsPreview service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.PreviewGenerationInProgressException">
        /// The request is rejected. The specified assessment template is currently generating
        /// an exclusions preview.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateExclusionsPreview">REST API Reference for CreateExclusionsPreview Operation</seealso>
        CreateExclusionsPreviewResponse CreateExclusionsPreview(CreateExclusionsPreviewRequest request);



        /// <summary>
        /// Starts the generation of an exclusions preview for the specified assessment template.
        /// The exclusions preview lists the potential exclusions (ExclusionPreview) that Inspector
        /// can detect before it runs the assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExclusionsPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExclusionsPreview service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.PreviewGenerationInProgressException">
        /// The request is rejected. The specified assessment template is currently generating
        /// an exclusions preview.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateExclusionsPreview">REST API Reference for CreateExclusionsPreview Operation</seealso>
        Task<CreateExclusionsPreviewResponse> CreateExclusionsPreviewAsync(CreateExclusionsPreviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResourceGroup


        /// <summary>
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Amazon Inspector assessment
        /// target. The created resource group is then used to create an Amazon Inspector assessment
        /// target. For more information, see <a>CreateAssessmentTarget</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup service method.</param>
        /// 
        /// <returns>The response from the CreateResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateResourceGroup">REST API Reference for CreateResourceGroup Operation</seealso>
        CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request);



        /// <summary>
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Amazon Inspector assessment
        /// target. The created resource group is then used to create an Amazon Inspector assessment
        /// target. For more information, see <a>CreateAssessmentTarget</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateResourceGroup">REST API Reference for CreateResourceGroup Operation</seealso>
        Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAssessmentRun


        /// <summary>
        /// Deletes the assessment run that is specified by the ARN of the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentRun service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentRun">REST API Reference for DeleteAssessmentRun Operation</seealso>
        DeleteAssessmentRunResponse DeleteAssessmentRun(DeleteAssessmentRunRequest request);



        /// <summary>
        /// Deletes the assessment run that is specified by the ARN of the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentRun">REST API Reference for DeleteAssessmentRun Operation</seealso>
        Task<DeleteAssessmentRunResponse> DeleteAssessmentRunAsync(DeleteAssessmentRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAssessmentTarget


        /// <summary>
        /// Deletes the assessment target that is specified by the ARN of the assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTarget">REST API Reference for DeleteAssessmentTarget Operation</seealso>
        DeleteAssessmentTargetResponse DeleteAssessmentTarget(DeleteAssessmentTargetRequest request);



        /// <summary>
        /// Deletes the assessment target that is specified by the ARN of the assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTarget">REST API Reference for DeleteAssessmentTarget Operation</seealso>
        Task<DeleteAssessmentTargetResponse> DeleteAssessmentTargetAsync(DeleteAssessmentTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAssessmentTemplate


        /// <summary>
        /// Deletes the assessment template that is specified by the ARN of the assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentTemplate service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTemplate">REST API Reference for DeleteAssessmentTemplate Operation</seealso>
        DeleteAssessmentTemplateResponse DeleteAssessmentTemplate(DeleteAssessmentTemplateRequest request);



        /// <summary>
        /// Deletes the assessment template that is specified by the ARN of the assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssessmentTemplate service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTemplate">REST API Reference for DeleteAssessmentTemplate Operation</seealso>
        Task<DeleteAssessmentTemplateResponse> DeleteAssessmentTemplateAsync(DeleteAssessmentTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAssessmentRuns


        /// <summary>
        /// Describes the assessment runs that are specified by the ARNs of the assessment runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentRuns service method.</param>
        /// 
        /// <returns>The response from the DescribeAssessmentRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentRuns">REST API Reference for DescribeAssessmentRuns Operation</seealso>
        DescribeAssessmentRunsResponse DescribeAssessmentRuns(DescribeAssessmentRunsRequest request);



        /// <summary>
        /// Describes the assessment runs that are specified by the ARNs of the assessment runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssessmentRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentRuns">REST API Reference for DescribeAssessmentRuns Operation</seealso>
        Task<DescribeAssessmentRunsResponse> DescribeAssessmentRunsAsync(DescribeAssessmentRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAssessmentTargets


        /// <summary>
        /// Describes the assessment targets that are specified by the ARNs of the assessment
        /// targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeAssessmentTargets service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTargets">REST API Reference for DescribeAssessmentTargets Operation</seealso>
        DescribeAssessmentTargetsResponse DescribeAssessmentTargets(DescribeAssessmentTargetsRequest request);



        /// <summary>
        /// Describes the assessment targets that are specified by the ARNs of the assessment
        /// targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssessmentTargets service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTargets">REST API Reference for DescribeAssessmentTargets Operation</seealso>
        Task<DescribeAssessmentTargetsResponse> DescribeAssessmentTargetsAsync(DescribeAssessmentTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAssessmentTemplates


        /// <summary>
        /// Describes the assessment templates that are specified by the ARNs of the assessment
        /// templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTemplates service method.</param>
        /// 
        /// <returns>The response from the DescribeAssessmentTemplates service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTemplates">REST API Reference for DescribeAssessmentTemplates Operation</seealso>
        DescribeAssessmentTemplatesResponse DescribeAssessmentTemplates(DescribeAssessmentTemplatesRequest request);



        /// <summary>
        /// Describes the assessment templates that are specified by the ARNs of the assessment
        /// templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssessmentTemplates service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTemplates">REST API Reference for DescribeAssessmentTemplates Operation</seealso>
        Task<DescribeAssessmentTemplatesResponse> DescribeAssessmentTemplatesAsync(DescribeAssessmentTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCrossAccountAccessRole


        /// <summary>
        /// Describes the IAM role that enables Amazon Inspector to access your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole service method.</param>
        /// 
        /// <returns>The response from the DescribeCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeCrossAccountAccessRole">REST API Reference for DescribeCrossAccountAccessRole Operation</seealso>
        DescribeCrossAccountAccessRoleResponse DescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request);



        /// <summary>
        /// Describes the IAM role that enables Amazon Inspector to access your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeCrossAccountAccessRole">REST API Reference for DescribeCrossAccountAccessRole Operation</seealso>
        Task<DescribeCrossAccountAccessRoleResponse> DescribeCrossAccountAccessRoleAsync(DescribeCrossAccountAccessRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeExclusions


        /// <summary>
        /// Describes the exclusions that are specified by the exclusions' ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExclusions service method.</param>
        /// 
        /// <returns>The response from the DescribeExclusions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeExclusions">REST API Reference for DescribeExclusions Operation</seealso>
        DescribeExclusionsResponse DescribeExclusions(DescribeExclusionsRequest request);



        /// <summary>
        /// Describes the exclusions that are specified by the exclusions' ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExclusions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExclusions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeExclusions">REST API Reference for DescribeExclusions Operation</seealso>
        Task<DescribeExclusionsResponse> DescribeExclusionsAsync(DescribeExclusionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFindings


        /// <summary>
        /// Describes the findings that are specified by the ARNs of the findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFindings service method.</param>
        /// 
        /// <returns>The response from the DescribeFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeFindings">REST API Reference for DescribeFindings Operation</seealso>
        DescribeFindingsResponse DescribeFindings(DescribeFindingsRequest request);



        /// <summary>
        /// Describes the findings that are specified by the ARNs of the findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeFindings">REST API Reference for DescribeFindings Operation</seealso>
        Task<DescribeFindingsResponse> DescribeFindingsAsync(DescribeFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeResourceGroups


        /// <summary>
        /// Describes the resource groups that are specified by the ARNs of the resource groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeResourceGroups service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeResourceGroups">REST API Reference for DescribeResourceGroups Operation</seealso>
        DescribeResourceGroupsResponse DescribeResourceGroups(DescribeResourceGroupsRequest request);



        /// <summary>
        /// Describes the resource groups that are specified by the ARNs of the resource groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResourceGroups service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeResourceGroups">REST API Reference for DescribeResourceGroups Operation</seealso>
        Task<DescribeResourceGroupsResponse> DescribeResourceGroupsAsync(DescribeResourceGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRulesPackages


        /// <summary>
        /// Describes the rules packages that are specified by the ARNs of the rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackages service method.</param>
        /// 
        /// <returns>The response from the DescribeRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeRulesPackages">REST API Reference for DescribeRulesPackages Operation</seealso>
        DescribeRulesPackagesResponse DescribeRulesPackages(DescribeRulesPackagesRequest request);



        /// <summary>
        /// Describes the rules packages that are specified by the ARNs of the rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeRulesPackages">REST API Reference for DescribeRulesPackages Operation</seealso>
        Task<DescribeRulesPackagesResponse> DescribeRulesPackagesAsync(DescribeRulesPackagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAssessmentReport


        /// <summary>
        /// Produces an assessment report that includes detailed and comprehensive results of
        /// a specified assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReport service method.</param>
        /// 
        /// <returns>The response from the GetAssessmentReport service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.UnsupportedFeatureException">
        /// Used by the <a>GetAssessmentReport</a> API. The request was rejected because you tried
        /// to generate a report for an assessment run that existed before reporting was supported
        /// in Amazon Inspector. You can only generate reports for assessment runs that took place
        /// or will take place after generating reports in Amazon Inspector became available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetAssessmentReport">REST API Reference for GetAssessmentReport Operation</seealso>
        GetAssessmentReportResponse GetAssessmentReport(GetAssessmentReportRequest request);



        /// <summary>
        /// Produces an assessment report that includes detailed and comprehensive results of
        /// a specified assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssessmentReport service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.UnsupportedFeatureException">
        /// Used by the <a>GetAssessmentReport</a> API. The request was rejected because you tried
        /// to generate a report for an assessment run that existed before reporting was supported
        /// in Amazon Inspector. You can only generate reports for assessment runs that took place
        /// or will take place after generating reports in Amazon Inspector became available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetAssessmentReport">REST API Reference for GetAssessmentReport Operation</seealso>
        Task<GetAssessmentReportResponse> GetAssessmentReportAsync(GetAssessmentReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetExclusionsPreview


        /// <summary>
        /// Retrieves the exclusions preview (a list of ExclusionPreview objects) specified by
        /// the preview token. You can obtain the preview token by running the CreateExclusionsPreview
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExclusionsPreview service method.</param>
        /// 
        /// <returns>The response from the GetExclusionsPreview service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetExclusionsPreview">REST API Reference for GetExclusionsPreview Operation</seealso>
        GetExclusionsPreviewResponse GetExclusionsPreview(GetExclusionsPreviewRequest request);



        /// <summary>
        /// Retrieves the exclusions preview (a list of ExclusionPreview objects) specified by
        /// the preview token. You can obtain the preview token by running the CreateExclusionsPreview
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExclusionsPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExclusionsPreview service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetExclusionsPreview">REST API Reference for GetExclusionsPreview Operation</seealso>
        Task<GetExclusionsPreviewResponse> GetExclusionsPreviewAsync(GetExclusionsPreviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTelemetryMetadata


        /// <summary>
        /// Information about the data that is collected for the specified assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryMetadata service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryMetadata service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetTelemetryMetadata">REST API Reference for GetTelemetryMetadata Operation</seealso>
        GetTelemetryMetadataResponse GetTelemetryMetadata(GetTelemetryMetadataRequest request);



        /// <summary>
        /// Information about the data that is collected for the specified assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTelemetryMetadata service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetTelemetryMetadata">REST API Reference for GetTelemetryMetadata Operation</seealso>
        Task<GetTelemetryMetadataResponse> GetTelemetryMetadataAsync(GetTelemetryMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssessmentRunAgents


        /// <summary>
        /// Lists the agents of the assessment runs that are specified by the ARNs of the assessment
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRunAgents service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentRunAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRunAgents">REST API Reference for ListAssessmentRunAgents Operation</seealso>
        ListAssessmentRunAgentsResponse ListAssessmentRunAgents(ListAssessmentRunAgentsRequest request);



        /// <summary>
        /// Lists the agents of the assessment runs that are specified by the ARNs of the assessment
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRunAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessmentRunAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRunAgents">REST API Reference for ListAssessmentRunAgents Operation</seealso>
        Task<ListAssessmentRunAgentsResponse> ListAssessmentRunAgentsAsync(ListAssessmentRunAgentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssessmentRuns


        /// <summary>
        /// Lists the assessment runs that correspond to the assessment templates that are specified
        /// by the ARNs of the assessment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRuns service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRuns">REST API Reference for ListAssessmentRuns Operation</seealso>
        ListAssessmentRunsResponse ListAssessmentRuns(ListAssessmentRunsRequest request);



        /// <summary>
        /// Lists the assessment runs that correspond to the assessment templates that are specified
        /// by the ARNs of the assessment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessmentRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRuns">REST API Reference for ListAssessmentRuns Operation</seealso>
        Task<ListAssessmentRunsResponse> ListAssessmentRunsAsync(ListAssessmentRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssessmentTargets


        /// <summary>
        /// Lists the ARNs of the assessment targets within this AWS account. For more information
        /// about assessment targets, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">Amazon
        /// Inspector Assessment Targets</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTargets service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentTargets service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTargets">REST API Reference for ListAssessmentTargets Operation</seealso>
        ListAssessmentTargetsResponse ListAssessmentTargets(ListAssessmentTargetsRequest request);



        /// <summary>
        /// Lists the ARNs of the assessment targets within this AWS account. For more information
        /// about assessment targets, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">Amazon
        /// Inspector Assessment Targets</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessmentTargets service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTargets">REST API Reference for ListAssessmentTargets Operation</seealso>
        Task<ListAssessmentTargetsResponse> ListAssessmentTargetsAsync(ListAssessmentTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssessmentTemplates


        /// <summary>
        /// Lists the assessment templates that correspond to the assessment targets that are
        /// specified by the ARNs of the assessment targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTemplates service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentTemplates service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTemplates">REST API Reference for ListAssessmentTemplates Operation</seealso>
        ListAssessmentTemplatesResponse ListAssessmentTemplates(ListAssessmentTemplatesRequest request);



        /// <summary>
        /// Lists the assessment templates that correspond to the assessment targets that are
        /// specified by the ARNs of the assessment targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessmentTemplates service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTemplates">REST API Reference for ListAssessmentTemplates Operation</seealso>
        Task<ListAssessmentTemplatesResponse> ListAssessmentTemplatesAsync(ListAssessmentTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEventSubscriptions


        /// <summary>
        /// Lists all the event subscriptions for the assessment template that is specified by
        /// the ARN of the assessment template. For more information, see <a>SubscribeToEvent</a>
        /// and <a>UnsubscribeFromEvent</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListEventSubscriptions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListEventSubscriptions">REST API Reference for ListEventSubscriptions Operation</seealso>
        ListEventSubscriptionsResponse ListEventSubscriptions(ListEventSubscriptionsRequest request);



        /// <summary>
        /// Lists all the event subscriptions for the assessment template that is specified by
        /// the ARN of the assessment template. For more information, see <a>SubscribeToEvent</a>
        /// and <a>UnsubscribeFromEvent</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventSubscriptions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListEventSubscriptions">REST API Reference for ListEventSubscriptions Operation</seealso>
        Task<ListEventSubscriptionsResponse> ListEventSubscriptionsAsync(ListEventSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExclusions


        /// <summary>
        /// List exclusions that are generated by the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExclusions service method.</param>
        /// 
        /// <returns>The response from the ListExclusions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListExclusions">REST API Reference for ListExclusions Operation</seealso>
        ListExclusionsResponse ListExclusions(ListExclusionsRequest request);



        /// <summary>
        /// List exclusions that are generated by the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExclusions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExclusions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListExclusions">REST API Reference for ListExclusions Operation</seealso>
        Task<ListExclusionsResponse> ListExclusionsAsync(ListExclusionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Lists findings that are generated by the assessment runs that are specified by the
        /// ARNs of the assessment runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse ListFindings(ListFindingsRequest request);



        /// <summary>
        /// Lists findings that are generated by the assessment runs that are specified by the
        /// ARNs of the assessment runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListFindings">REST API Reference for ListFindings Operation</seealso>
        Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRulesPackages


        /// <summary>
        /// Lists all available Amazon Inspector rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages service method.</param>
        /// 
        /// <returns>The response from the ListRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListRulesPackages">REST API Reference for ListRulesPackages Operation</seealso>
        ListRulesPackagesResponse ListRulesPackages(ListRulesPackagesRequest request);



        /// <summary>
        /// Lists all available Amazon Inspector rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListRulesPackages">REST API Reference for ListRulesPackages Operation</seealso>
        Task<ListRulesPackagesResponse> ListRulesPackagesAsync(ListRulesPackagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with an assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists all tags associated with an assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PreviewAgents


        /// <summary>
        /// Previews the agents installed on the EC2 instances that are part of the specified
        /// assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgents service method.</param>
        /// 
        /// <returns>The response from the PreviewAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/PreviewAgents">REST API Reference for PreviewAgents Operation</seealso>
        PreviewAgentsResponse PreviewAgents(PreviewAgentsRequest request);



        /// <summary>
        /// Previews the agents installed on the EC2 instances that are part of the specified
        /// assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PreviewAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/PreviewAgents">REST API Reference for PreviewAgents Operation</seealso>
        Task<PreviewAgentsResponse> PreviewAgentsAsync(PreviewAgentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterCrossAccountAccessRole


        /// <summary>
        /// Registers the IAM role that grants Amazon Inspector access to AWS Services needed
        /// to perform security assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole service method.</param>
        /// 
        /// <returns>The response from the RegisterCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RegisterCrossAccountAccessRole">REST API Reference for RegisterCrossAccountAccessRole Operation</seealso>
        RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request);



        /// <summary>
        /// Registers the IAM role that grants Amazon Inspector access to AWS Services needed
        /// to perform security assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RegisterCrossAccountAccessRole">REST API Reference for RegisterCrossAccountAccessRole Operation</seealso>
        Task<RegisterCrossAccountAccessRoleResponse> RegisterCrossAccountAccessRoleAsync(RegisterCrossAccountAccessRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveAttributesFromFindings


        /// <summary>
        /// Removes entire attributes (key and value pairs) from the findings that are specified
        /// by the ARNs of the findings where an attribute with the specified key exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings service method.</param>
        /// 
        /// <returns>The response from the RemoveAttributesFromFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RemoveAttributesFromFindings">REST API Reference for RemoveAttributesFromFindings Operation</seealso>
        RemoveAttributesFromFindingsResponse RemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request);



        /// <summary>
        /// Removes entire attributes (key and value pairs) from the findings that are specified
        /// by the ARNs of the findings where an attribute with the specified key exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveAttributesFromFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RemoveAttributesFromFindings">REST API Reference for RemoveAttributesFromFindings Operation</seealso>
        Task<RemoveAttributesFromFindingsResponse> RemoveAttributesFromFindingsAsync(RemoveAttributesFromFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetTagsForResource


        /// <summary>
        /// Sets tags (key and value pairs) to the assessment template that is specified by the
        /// ARN of the assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource service method.</param>
        /// 
        /// <returns>The response from the SetTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SetTagsForResource">REST API Reference for SetTagsForResource Operation</seealso>
        SetTagsForResourceResponse SetTagsForResource(SetTagsForResourceRequest request);



        /// <summary>
        /// Sets tags (key and value pairs) to the assessment template that is specified by the
        /// ARN of the assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SetTagsForResource">REST API Reference for SetTagsForResource Operation</seealso>
        Task<SetTagsForResourceResponse> SetTagsForResourceAsync(SetTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartAssessmentRun


        /// <summary>
        /// Starts the assessment run specified by the ARN of the assessment template. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentRun service method.</param>
        /// 
        /// <returns>The response from the StartAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AgentsAlreadyRunningAssessmentException">
        /// You started an assessment run, but one of the instances is already participating in
        /// another assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StartAssessmentRun">REST API Reference for StartAssessmentRun Operation</seealso>
        StartAssessmentRunResponse StartAssessmentRun(StartAssessmentRunRequest request);



        /// <summary>
        /// Starts the assessment run specified by the ARN of the assessment template. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AgentsAlreadyRunningAssessmentException">
        /// You started an assessment run, but one of the instances is already participating in
        /// another assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StartAssessmentRun">REST API Reference for StartAssessmentRun Operation</seealso>
        Task<StartAssessmentRunResponse> StartAssessmentRunAsync(StartAssessmentRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopAssessmentRun


        /// <summary>
        /// Stops the assessment run that is specified by the ARN of the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAssessmentRun service method.</param>
        /// 
        /// <returns>The response from the StopAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StopAssessmentRun">REST API Reference for StopAssessmentRun Operation</seealso>
        StopAssessmentRunResponse StopAssessmentRun(StopAssessmentRunRequest request);



        /// <summary>
        /// Stops the assessment run that is specified by the ARN of the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAssessmentRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StopAssessmentRun">REST API Reference for StopAssessmentRun Operation</seealso>
        Task<StopAssessmentRunResponse> StopAssessmentRunAsync(StopAssessmentRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SubscribeToEvent


        /// <summary>
        /// Enables the process of sending Amazon Simple Notification Service (SNS) notifications
        /// about a specified event to a specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToEvent service method.</param>
        /// 
        /// <returns>The response from the SubscribeToEvent service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SubscribeToEvent">REST API Reference for SubscribeToEvent Operation</seealso>
        SubscribeToEventResponse SubscribeToEvent(SubscribeToEventRequest request);



        /// <summary>
        /// Enables the process of sending Amazon Simple Notification Service (SNS) notifications
        /// about a specified event to a specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubscribeToEvent service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SubscribeToEvent">REST API Reference for SubscribeToEvent Operation</seealso>
        Task<SubscribeToEventResponse> SubscribeToEventAsync(SubscribeToEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UnsubscribeFromEvent


        /// <summary>
        /// Disables the process of sending Amazon Simple Notification Service (SNS) notifications
        /// about a specified event to a specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromEvent service method.</param>
        /// 
        /// <returns>The response from the UnsubscribeFromEvent service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UnsubscribeFromEvent">REST API Reference for UnsubscribeFromEvent Operation</seealso>
        UnsubscribeFromEventResponse UnsubscribeFromEvent(UnsubscribeFromEventRequest request);



        /// <summary>
        /// Disables the process of sending Amazon Simple Notification Service (SNS) notifications
        /// about a specified event to a specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnsubscribeFromEvent service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UnsubscribeFromEvent">REST API Reference for UnsubscribeFromEvent Operation</seealso>
        Task<UnsubscribeFromEventResponse> UnsubscribeFromEventAsync(UnsubscribeFromEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAssessmentTarget


        /// <summary>
        /// Updates the assessment target that is specified by the ARN of the assessment target.
        /// 
        ///  
        /// <para>
        /// If resourceGroupArn is not specified, all EC2 instances in the current AWS account
        /// and region are included in the assessment target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentTarget service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UpdateAssessmentTarget">REST API Reference for UpdateAssessmentTarget Operation</seealso>
        UpdateAssessmentTargetResponse UpdateAssessmentTarget(UpdateAssessmentTargetRequest request);



        /// <summary>
        /// Updates the assessment target that is specified by the ARN of the assessment target.
        /// 
        ///  
        /// <para>
        /// If resourceGroupArn is not specified, all EC2 instances in the current AWS account
        /// and region are included in the assessment target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UpdateAssessmentTarget">REST API Reference for UpdateAssessmentTarget Operation</seealso>
        Task<UpdateAssessmentTargetResponse> UpdateAssessmentTargetAsync(UpdateAssessmentTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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