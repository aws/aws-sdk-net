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
 * Do not modify this file. This file is generated from the aiops-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AIOps.Model;

#pragma warning disable CS1570
namespace Amazon.AIOps
{
    /// <summary>
    /// <para>Interface for accessing AIOps</para>
    ///
    /// The CloudWatch investigations feature is a generative AI-powered assistant that can
    /// help you respond to incidents in your system. It uses generative AI to scan your system's
    /// telemetry and quickly surface suggestions that might be related to your issue. These
    /// suggestions include metrics, logs, deployment events, and root-cause hypotheses. 
    /// 
    ///  
    /// <para>
    /// You can use API actions to create, manage, and delete investigation groups and investigation
    /// group policies. To start and manage investigations, you must use the CloudWatch console.
    /// </para>
    /// </summary>
    public partial interface IAmazonAIOps : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAIOpsPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateInvestigationGroup



        /// <summary>
        /// Creates an <i>investigation group</i> in your account. Creating an investigation group
        /// is a one-time setup task for each Region in your account. It is a necessary task to
        /// be able to perform investigations.
        /// 
        ///  
        /// <para>
        /// Settings in the investigation group help you centrally manage the common properties
        /// of your investigations, such as the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Who can access the investigations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether investigation data is encrypted with a customer managed Key Management Service
        /// key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// How long investigations and their data are retained by default.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Currently, you can have one investigation group in each Region in your account. Each
        /// investigation in a Region is a part of the investigation group in that Region
        /// </para>
        ///  
        /// <para>
        /// To create an investigation group and set up CloudWatch investigations, you must be
        /// signed in to an IAM principal that has either the <c>AIOpsConsoleAdminPolicy</c> or
        /// the <c>AdministratorAccess</c> IAM policy attached, or to an account that has similar
        /// permissions.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can configure CloudWatch alarms to start investigations and add events to investigations.
        /// If you create your investigation group with <c>CreateInvestigationGroup</c> and you
        /// want to enable alarms to do this, you must use <c>PutInvestigationGroupPolicy</c>
        /// to create a resource policy that grants this permission to CloudWatch alarms. 
        /// </para>
        ///  
        /// <para>
        /// For more information about configuring CloudWatch alarms, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html">Using
        /// Amazon CloudWatch alarms</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvestigationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInvestigationGroup service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/CreateInvestigationGroup">REST API Reference for CreateInvestigationGroup Operation</seealso>
        Task<CreateInvestigationGroupResponse> CreateInvestigationGroupAsync(CreateInvestigationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInvestigationGroup



        /// <summary>
        /// Deletes the specified investigation group from your account. You can currently have
        /// one investigation group per Region in your account. After you delete an investigation
        /// group, you can later create a new investigation group in the same Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvestigationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInvestigationGroup service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/DeleteInvestigationGroup">REST API Reference for DeleteInvestigationGroup Operation</seealso>
        Task<DeleteInvestigationGroupResponse> DeleteInvestigationGroupAsync(DeleteInvestigationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInvestigationGroupPolicy



        /// <summary>
        /// Removes the IAM resource policy from being associated with the investigation group
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvestigationGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInvestigationGroupPolicy service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/DeleteInvestigationGroupPolicy">REST API Reference for DeleteInvestigationGroupPolicy Operation</seealso>
        Task<DeleteInvestigationGroupPolicyResponse> DeleteInvestigationGroupPolicyAsync(DeleteInvestigationGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInvestigationGroup



        /// <summary>
        /// Returns the configuration information for the specified investigation group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvestigationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvestigationGroup service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/GetInvestigationGroup">REST API Reference for GetInvestigationGroup Operation</seealso>
        Task<GetInvestigationGroupResponse> GetInvestigationGroupAsync(GetInvestigationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInvestigationGroupPolicy



        /// <summary>
        /// Returns the JSON of the IAM resource policy associated with the specified investigation
        /// group in a string. For example, <c>{\"Version\":\"2012-10-17\",\"Statement\":[{\"Effect\":\"Allow\",\"Principal\":{\"Service\":\"aiops.alarms.cloudwatch.amazonaws.com\"},\"Action\":[\"aiops:CreateInvestigation\",\"aiops:CreateInvestigationEvent\"],\"Resource\":\"*\",\"Condition\":{\"StringEquals\":{\"aws:SourceAccount\":\"111122223333\"},\"ArnLike\":{\"aws:SourceArn\":\"arn:aws:cloudwatch:us-east-1:111122223333:alarm:*\"}}}]}</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvestigationGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvestigationGroupPolicy service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/GetInvestigationGroupPolicy">REST API Reference for GetInvestigationGroupPolicy Operation</seealso>
        Task<GetInvestigationGroupPolicyResponse> GetInvestigationGroupPolicyAsync(GetInvestigationGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInvestigationGroups



        /// <summary>
        /// Returns the ARN and name of each investigation group in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvestigationGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvestigationGroups service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/ListInvestigationGroups">REST API Reference for ListInvestigationGroups Operation</seealso>
        Task<ListInvestigationGroupsResponse> ListInvestigationGroupsAsync(ListInvestigationGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Displays the tags associated with a CloudWatch investigations resource. Currently,
        /// investigation groups support tagging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutInvestigationGroupPolicy



        /// <summary>
        /// Creates an IAM resource policy and assigns it to the specified investigation group.
        /// 
        ///  
        /// <para>
        /// If you create your investigation group with <c>CreateInvestigationGroup</c> and you
        /// want to enable CloudWatch alarms to create investigations and add events to investigations,
        /// you must use this operation to create a policy similar to this example.
        /// </para>
        ///  
        /// <para>
        ///  <c> { "Version": "2008-10-17", "Statement": [ { "Effect": "Allow", "Principal": {
        /// "Service": "aiops.alarms.cloudwatch.amazonaws.com" }, "Action": [ "aiops:CreateInvestigation",
        /// "aiops:CreateInvestigationEvent" ], "Resource": "*", "Condition": { "StringEquals":
        /// { "aws:SourceAccount": "account-id" }, "ArnLike": { "aws:SourceArn": "arn:aws:cloudwatch:region:account-id:alarm:*"
        /// } } } ] } </c> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInvestigationGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutInvestigationGroupPolicy service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/PutInvestigationGroupPolicy">REST API Reference for PutInvestigationGroupPolicy Operation</seealso>
        Task<PutInvestigationGroupPolicyResponse> PutInvestigationGroupPolicyAsync(PutInvestigationGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInvestigationGroup



        /// <summary>
        /// Updates the configuration of the specified investigation group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvestigationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInvestigationGroup service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/UpdateInvestigationGroup">REST API Reference for UpdateInvestigationGroup Operation</seealso>
        Task<UpdateInvestigationGroupResponse> UpdateInvestigationGroupAsync(UpdateInvestigationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAIOpsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAIOpsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAIOpsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAIOpsConfig to create AmazonAIOpsClient");
            }

            return awsCredentials == null ? 
                    new AmazonAIOpsClient(serviceClientConfig) :
                    new AmazonAIOpsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}