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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NetworkSecurityManager.Model;

#pragma warning disable CS1570
namespace Amazon.NetworkSecurityManager
{
    /// <summary>
    /// <para>Interface for accessing NetworkSecurityManager</para>
    ///
    /// AWS Network Security Manager helps you centrally configure and deploy network security
    /// protections across your organization. Supported protections include AWS WAF and AWS
    /// Shield Advanced. This centralized approach reduces the overhead of managing protections
    /// individually across accounts and ensures consistent security at scale.
    /// 
    ///  
    /// <para>
    /// You define reusable <i>rules</i> and <i>templates</i>, then combine them into <i>policies</i>.
    /// Next, you select the accounts and resources to protect with <i>scopes</i> and roll
    /// the protections out with <i>deployments</i>. For example, you can define a set of
    /// AWS WAF rules and group them into a policy. Then deploy that policy across all accounts
    /// in your organization with a single deployment.
    /// </para>
    ///  
    /// <para>
    /// This API reference describes the operations and data types for AWS Network Security
    /// Manager.
    /// </para>
    ///  
    /// <para>
    /// For conceptual information, tutorials, and guidance on writing rule configurations,
    /// see the <a href="https://docs.aws.amazon.com/network-security-manager/latest/devguide/what-is.html">AWS
    /// Network Security Manager Developer Guide</a>. For the default quotas that apply to
    /// your account, see <a href="https://docs.aws.amazon.com/network-security-manager/latest/devguide/quotas.html">Quotas</a>.
    /// For the service endpoints available in each Region, see <a href="https://docs.aws.amazon.com/general/latest/gr/network-security-manager.html">AWS
    /// Network Security Manager endpoints and quotas</a> in the <i>AWS General Reference</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonNetworkSecurityManager : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        INetworkSecurityManagerPaginatorFactory Paginators { get; }

        
        #region  CreateDeployment


        /// <summary>
        /// Creates a deployment. A deployment applies one or more policies to the accounts and
        /// resources selected by a scope. Use <c>isPublished</c> to create the deployment in
        /// published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state. The response includes coverage
        /// information and any warnings about the deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);



        /// <summary>
        /// Creates a deployment. A deployment applies one or more policies to the accounts and
        /// resources selected by a scope. Use <c>isPublished</c> to create the deployment in
        /// published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state. The response includes coverage
        /// information and any warnings about the deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDeploymentSnapshot


        /// <summary>
        /// Creates a snapshot of the current published version of the specified deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDeploymentSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateDeploymentSnapshot">REST API Reference for CreateDeploymentSnapshot Operation</seealso>
        CreateDeploymentSnapshotResponse CreateDeploymentSnapshot(CreateDeploymentSnapshotRequest request);



        /// <summary>
        /// Creates a snapshot of the current published version of the specified deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeploymentSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateDeploymentSnapshot">REST API Reference for CreateDeploymentSnapshot Operation</seealso>
        Task<CreateDeploymentSnapshotResponse> CreateDeploymentSnapshotAsync(CreateDeploymentSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Creates a policy. A policy combines templates and rules with enforcement settings
        /// for a firewall type, such as AWS WAF or AWS Shield Advanced. Use <c>isPublished</c>
        /// to create the policy in published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        CreatePolicyResponse CreatePolicy(CreatePolicyRequest request);



        /// <summary>
        /// Creates a policy. A policy combines templates and rules with enforcement settings
        /// for a firewall type, such as AWS WAF or AWS Shield Advanced. Use <c>isPublished</c>
        /// to create the policy in published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePolicySnapshot


        /// <summary>
        /// Creates a snapshot of the current published version of the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicySnapshot service method.</param>
        /// 
        /// <returns>The response from the CreatePolicySnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreatePolicySnapshot">REST API Reference for CreatePolicySnapshot Operation</seealso>
        CreatePolicySnapshotResponse CreatePolicySnapshot(CreatePolicySnapshotRequest request);



        /// <summary>
        /// Creates a snapshot of the current published version of the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicySnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicySnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreatePolicySnapshot">REST API Reference for CreatePolicySnapshot Operation</seealso>
        Task<CreatePolicySnapshotResponse> CreatePolicySnapshotAsync(CreatePolicySnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// Creates a rule. A rule defines a network security configuration to enforce, such as
        /// an AWS WAF rule group or configuration data. Use <c>isPublished</c> to create the
        /// rule in published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse CreateRule(CreateRuleRequest request);



        /// <summary>
        /// Creates a rule. A rule defines a network security configuration to enforce, such as
        /// an AWS WAF rule group or configuration data. Use <c>isPublished</c> to create the
        /// rule in published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateRule">REST API Reference for CreateRule Operation</seealso>
        Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRuleSnapshot


        /// <summary>
        /// Creates a snapshot of the current published version of the specified rule. A snapshot
        /// is an immutable, versioned copy that other resources can reference.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateRuleSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateRuleSnapshot">REST API Reference for CreateRuleSnapshot Operation</seealso>
        CreateRuleSnapshotResponse CreateRuleSnapshot(CreateRuleSnapshotRequest request);



        /// <summary>
        /// Creates a snapshot of the current published version of the specified rule. A snapshot
        /// is an immutable, versioned copy that other resources can reference.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateRuleSnapshot">REST API Reference for CreateRuleSnapshot Operation</seealso>
        Task<CreateRuleSnapshotResponse> CreateRuleSnapshotAsync(CreateRuleSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateScope


        /// <summary>
        /// Creates a scope. A scope selects the accounts and resources that a deployment applies
        /// to. Use <c>isPublished</c> to create the scope in published (<c>ACTIVE</c>) or draft
        /// (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScope service method.</param>
        /// 
        /// <returns>The response from the CreateScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateScope">REST API Reference for CreateScope Operation</seealso>
        CreateScopeResponse CreateScope(CreateScopeRequest request);



        /// <summary>
        /// Creates a scope. A scope selects the accounts and resources that a deployment applies
        /// to. Use <c>isPublished</c> to create the scope in published (<c>ACTIVE</c>) or draft
        /// (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateScope">REST API Reference for CreateScope Operation</seealso>
        Task<CreateScopeResponse> CreateScopeAsync(CreateScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateScopeSnapshot


        /// <summary>
        /// Creates a snapshot of the current published version of the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScopeSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateScopeSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateScopeSnapshot">REST API Reference for CreateScopeSnapshot Operation</seealso>
        CreateScopeSnapshotResponse CreateScopeSnapshot(CreateScopeSnapshotRequest request);



        /// <summary>
        /// Creates a snapshot of the current published version of the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScopeSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScopeSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateScopeSnapshot">REST API Reference for CreateScopeSnapshot Operation</seealso>
        Task<CreateScopeSnapshotResponse> CreateScopeSnapshotAsync(CreateScopeSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTemplate


        /// <summary>
        /// Creates a template. A template groups one or more rules to simplify reuse across policies.
        /// You can also associate rules with a policy directly, without a template. Use <c>isPublished</c>
        /// to create the template in published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        CreateTemplateResponse CreateTemplate(CreateTemplateRequest request);



        /// <summary>
        /// Creates a template. A template groups one or more rules to simplify reuse across policies.
        /// You can also associate rules with a policy directly, without a template. Use <c>isPublished</c>
        /// to create the template in published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTemplateSnapshot


        /// <summary>
        /// Creates a snapshot of the current published version of the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateTemplateSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateTemplateSnapshot">REST API Reference for CreateTemplateSnapshot Operation</seealso>
        CreateTemplateSnapshotResponse CreateTemplateSnapshot(CreateTemplateSnapshotRequest request);



        /// <summary>
        /// Creates a snapshot of the current published version of the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplateSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateTemplateSnapshot">REST API Reference for CreateTemplateSnapshot Operation</seealso>
        Task<CreateTemplateSnapshotResponse> CreateTemplateSnapshotAsync(CreateTemplateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAdminAccount


        /// <summary>
        /// Removes the specified AWS Network Security Manager administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DeleteAdminAccount service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteAdminAccount">REST API Reference for DeleteAdminAccount Operation</seealso>
        DeleteAdminAccountResponse DeleteAdminAccount(DeleteAdminAccountRequest request);



        /// <summary>
        /// Removes the specified AWS Network Security Manager administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAdminAccount service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteAdminAccount">REST API Reference for DeleteAdminAccount Operation</seealso>
        Task<DeleteAdminAccountResponse> DeleteAdminAccountAsync(DeleteAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDeployment


        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request);



        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        Task<DeleteDeploymentResponse> DeleteDeploymentAsync(DeleteDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);



        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Deletes the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);



        /// <summary>
        /// Deletes the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteScope


        /// <summary>
        /// Deletes the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScope service method.</param>
        /// 
        /// <returns>The response from the DeleteScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteScope">REST API Reference for DeleteScope Operation</seealso>
        DeleteScopeResponse DeleteScope(DeleteScopeRequest request);



        /// <summary>
        /// Deletes the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteScope">REST API Reference for DeleteScope Operation</seealso>
        Task<DeleteScopeResponse> DeleteScopeAsync(DeleteScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTemplate


        /// <summary>
        /// Deletes the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request);



        /// <summary>
        /// Deletes the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateRuleConfiguration


        /// <summary>
        /// Generates a rule configuration from a natural-language description. Provide a prompt
        /// along with the rule's firewall type and rule type. The service returns a configuration
        /// that you can use when you create or update a rule. If you also provide an existing
        /// configuration, the service edits that configuration instead of generating a new one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRuleConfiguration service method.</param>
        /// 
        /// <returns>The response from the GenerateRuleConfiguration service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GenerateRuleConfiguration">REST API Reference for GenerateRuleConfiguration Operation</seealso>
        GenerateRuleConfigurationResponse GenerateRuleConfiguration(GenerateRuleConfigurationRequest request);



        /// <summary>
        /// Generates a rule configuration from a natural-language description. Provide a prompt
        /// along with the rule's firewall type and rule type. The service returns a configuration
        /// that you can use when you create or update a rule. If you also provide an existing
        /// configuration, the service edits that configuration instead of generating a new one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRuleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRuleConfiguration service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GenerateRuleConfiguration">REST API Reference for GenerateRuleConfiguration Operation</seealso>
        Task<GenerateRuleConfigurationResponse> GenerateRuleConfigurationAsync(GenerateRuleConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAdminAccount


        /// <summary>
        /// Retrieves the details of the specified AWS Network Security Manager administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdminAccount service method.</param>
        /// 
        /// <returns>The response from the GetAdminAccount service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        GetAdminAccountResponse GetAdminAccount(GetAdminAccountRequest request);



        /// <summary>
        /// Retrieves the details of the specified AWS Network Security Manager administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAdminAccount service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        Task<GetAdminAccountResponse> GetAdminAccountAsync(GetAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeployment


        /// <summary>
        /// Retrieves the details of the specified deployment, including coverage information
        /// and any warnings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        GetDeploymentResponse GetDeployment(GetDeploymentRequest request);



        /// <summary>
        /// Retrieves the details of the specified deployment, including coverage information
        /// and any warnings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Retrieves the details of the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);



        /// <summary>
        /// Retrieves the details of the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRule


        /// <summary>
        /// Retrieves the details of the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetRule">REST API Reference for GetRule Operation</seealso>
        GetRuleResponse GetRule(GetRuleRequest request);



        /// <summary>
        /// Retrieves the details of the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetRule">REST API Reference for GetRule Operation</seealso>
        Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetScope


        /// <summary>
        /// Retrieves the details of the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScope service method.</param>
        /// 
        /// <returns>The response from the GetScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetScope">REST API Reference for GetScope Operation</seealso>
        GetScopeResponse GetScope(GetScopeRequest request);



        /// <summary>
        /// Retrieves the details of the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetScope">REST API Reference for GetScope Operation</seealso>
        Task<GetScopeResponse> GetScopeAsync(GetScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemplate


        /// <summary>
        /// Retrieves the details of the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        GetTemplateResponse GetTemplate(GetTemplateRequest request);



        /// <summary>
        /// Retrieves the details of the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAdminAccounts


        /// <summary>
        /// Lists the AWS Network Security Manager administrator accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdminAccounts service method.</param>
        /// 
        /// <returns>The response from the ListAdminAccounts service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListAdminAccounts">REST API Reference for ListAdminAccounts Operation</seealso>
        ListAdminAccountsResponse ListAdminAccounts(ListAdminAccountsRequest request);



        /// <summary>
        /// Lists the AWS Network Security Manager administrator accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdminAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAdminAccounts service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListAdminAccounts">REST API Reference for ListAdminAccounts Operation</seealso>
        Task<ListAdminAccountsResponse> ListAdminAccountsAsync(ListAdminAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAggregateResourceSynchronizationStatuses


        /// <summary>
        /// Lists the aggregated synchronization statuses of resources across the deployments
        /// in your administrator account. You can filter the results by synchronization status
        /// and page through them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAggregateResourceSynchronizationStatuses service method.</param>
        /// 
        /// <returns>The response from the ListAggregateResourceSynchronizationStatuses service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListAggregateResourceSynchronizationStatuses">REST API Reference for ListAggregateResourceSynchronizationStatuses Operation</seealso>
        ListAggregateResourceSynchronizationStatusesResponse ListAggregateResourceSynchronizationStatuses(ListAggregateResourceSynchronizationStatusesRequest request);



        /// <summary>
        /// Lists the aggregated synchronization statuses of resources across the deployments
        /// in your administrator account. You can filter the results by synchronization status
        /// and page through them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAggregateResourceSynchronizationStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAggregateResourceSynchronizationStatuses service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListAggregateResourceSynchronizationStatuses">REST API Reference for ListAggregateResourceSynchronizationStatuses Operation</seealso>
        Task<ListAggregateResourceSynchronizationStatusesResponse> ListAggregateResourceSynchronizationStatusesAsync(ListAggregateResourceSynchronizationStatusesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDeployments


        /// <summary>
        /// Lists the deployments in the account. You can filter the results by status and page
        /// through them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request);



        /// <summary>
        /// Lists the deployments in the account. You can filter the results by status and page
        /// through them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDeploymentSnapshots


        /// <summary>
        /// Lists the snapshots of the specified deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListDeploymentSnapshots">REST API Reference for ListDeploymentSnapshots Operation</seealso>
        ListDeploymentSnapshotsResponse ListDeploymentSnapshots(ListDeploymentSnapshotsRequest request);



        /// <summary>
        /// Lists the snapshots of the specified deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListDeploymentSnapshots">REST API Reference for ListDeploymentSnapshots Operation</seealso>
        Task<ListDeploymentSnapshotsResponse> ListDeploymentSnapshotsAsync(ListDeploymentSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Lists the policies in the account. You can filter the results by status and page through
        /// them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse ListPolicies(ListPoliciesRequest request);



        /// <summary>
        /// Lists the policies in the account. You can filter the results by status and page through
        /// them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPolicySnapshots


        /// <summary>
        /// Lists the snapshots of the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicySnapshots service method.</param>
        /// 
        /// <returns>The response from the ListPolicySnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListPolicySnapshots">REST API Reference for ListPolicySnapshots Operation</seealso>
        ListPolicySnapshotsResponse ListPolicySnapshots(ListPolicySnapshotsRequest request);



        /// <summary>
        /// Lists the snapshots of the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicySnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicySnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListPolicySnapshots">REST API Reference for ListPolicySnapshots Operation</seealso>
        Task<ListPolicySnapshotsResponse> ListPolicySnapshotsAsync(ListPolicySnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceAssociations


        /// <summary>
        /// Lists the resources associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceAssociations service method.</param>
        /// 
        /// <returns>The response from the ListResourceAssociations service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListResourceAssociations">REST API Reference for ListResourceAssociations Operation</seealso>
        ListResourceAssociationsResponse ListResourceAssociations(ListResourceAssociationsRequest request);



        /// <summary>
        /// Lists the resources associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceAssociations service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListResourceAssociations">REST API Reference for ListResourceAssociations Operation</seealso>
        Task<ListResourceAssociationsResponse> ListResourceAssociationsAsync(ListResourceAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceSynchronizationStatuses


        /// <summary>
        /// Lists the synchronization statuses of the resources covered by the specified deployment.
        /// You can filter the results by synchronization status and page through them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSynchronizationStatuses service method.</param>
        /// 
        /// <returns>The response from the ListResourceSynchronizationStatuses service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListResourceSynchronizationStatuses">REST API Reference for ListResourceSynchronizationStatuses Operation</seealso>
        ListResourceSynchronizationStatusesResponse ListResourceSynchronizationStatuses(ListResourceSynchronizationStatusesRequest request);



        /// <summary>
        /// Lists the synchronization statuses of the resources covered by the specified deployment.
        /// You can filter the results by synchronization status and page through them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSynchronizationStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceSynchronizationStatuses service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListResourceSynchronizationStatuses">REST API Reference for ListResourceSynchronizationStatuses Operation</seealso>
        Task<ListResourceSynchronizationStatusesResponse> ListResourceSynchronizationStatusesAsync(ListResourceSynchronizationStatusesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Lists the rules in the account. You can filter the results by status and page through
        /// them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse ListRules(ListRulesRequest request);



        /// <summary>
        /// Lists the rules in the account. You can filter the results by status and page through
        /// them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListRules">REST API Reference for ListRules Operation</seealso>
        Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRuleSnapshots


        /// <summary>
        /// Lists the snapshots of the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListRuleSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListRuleSnapshots">REST API Reference for ListRuleSnapshots Operation</seealso>
        ListRuleSnapshotsResponse ListRuleSnapshots(ListRuleSnapshotsRequest request);



        /// <summary>
        /// Lists the snapshots of the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListRuleSnapshots">REST API Reference for ListRuleSnapshots Operation</seealso>
        Task<ListRuleSnapshotsResponse> ListRuleSnapshotsAsync(ListRuleSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListScopes


        /// <summary>
        /// Lists the scopes in the account. You can filter the results by status and page through
        /// them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScopes service method.</param>
        /// 
        /// <returns>The response from the ListScopes service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListScopes">REST API Reference for ListScopes Operation</seealso>
        ListScopesResponse ListScopes(ListScopesRequest request);



        /// <summary>
        /// Lists the scopes in the account. You can filter the results by status and page through
        /// them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScopes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScopes service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListScopes">REST API Reference for ListScopes Operation</seealso>
        Task<ListScopesResponse> ListScopesAsync(ListScopesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListScopeSnapshots


        /// <summary>
        /// Lists the snapshots of the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScopeSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListScopeSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListScopeSnapshots">REST API Reference for ListScopeSnapshots Operation</seealso>
        ListScopeSnapshotsResponse ListScopeSnapshots(ListScopeSnapshotsRequest request);



        /// <summary>
        /// Lists the snapshots of the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScopeSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScopeSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListScopeSnapshots">REST API Reference for ListScopeSnapshots Operation</seealso>
        Task<ListScopeSnapshotsResponse> ListScopeSnapshotsAsync(ListScopeSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTemplates


        /// <summary>
        /// Lists the templates in the account. You can filter the results by status and page
        /// through them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse ListTemplates(ListTemplatesRequest request);



        /// <summary>
        /// Lists the templates in the account. You can filter the results by status and page
        /// through them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTemplateSnapshots


        /// <summary>
        /// Lists the snapshots of the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListTemplateSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListTemplateSnapshots">REST API Reference for ListTemplateSnapshots Operation</seealso>
        ListTemplateSnapshotsResponse ListTemplateSnapshots(ListTemplateSnapshotsRequest request);



        /// <summary>
        /// Lists the snapshots of the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListTemplateSnapshots">REST API Reference for ListTemplateSnapshots Operation</seealso>
        Task<ListTemplateSnapshotsResponse> ListTemplateSnapshotsAsync(ListTemplateSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAdminAccount


        /// <summary>
        /// Sets the AWS account that serves as an AWS Network Security Manager administrator
        /// account, and optionally configures the scope of resources that the administrator can
        /// manage.
        /// 
        ///  
        /// <para>
        /// You can't set an administrator account again immediately after you remove it, or while
        /// the service creates its service-linked role. Retry the request after a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAdminAccount service method.</param>
        /// 
        /// <returns>The response from the PutAdminAccount service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/PutAdminAccount">REST API Reference for PutAdminAccount Operation</seealso>
        PutAdminAccountResponse PutAdminAccount(PutAdminAccountRequest request);



        /// <summary>
        /// Sets the AWS account that serves as an AWS Network Security Manager administrator
        /// account, and optionally configures the scope of resources that the administrator can
        /// manage.
        /// 
        ///  
        /// <para>
        /// You can't set an administrator account again immediately after you remove it, or while
        /// the service creates its service-linked role. Retry the request after a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAdminAccount service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/PutAdminAccount">REST API Reference for PutAdminAccount Operation</seealso>
        Task<PutAdminAccountResponse> PutAdminAccountAsync(PutAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites the specified tags on the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or overwrites the specified tags on the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the specified tags from the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDeployment


        /// <summary>
        /// Updates the specified deployment. To prevent conflicting concurrent updates, provide
        /// the current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep
        /// the deployment as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// 
        /// <returns>The response from the UpdateDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request);



        /// <summary>
        /// Updates the specified deployment. To prevent conflicting concurrent updates, provide
        /// the current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep
        /// the deployment as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        Task<UpdateDeploymentResponse> UpdateDeploymentAsync(UpdateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePolicy


        /// <summary>
        /// Updates the specified policy. To prevent conflicting concurrent updates, provide the
        /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
        /// policy as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request);



        /// <summary>
        /// Updates the specified policy. To prevent conflicting concurrent updates, provide the
        /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
        /// policy as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRule


        /// <summary>
        /// Updates the specified rule. To prevent conflicting concurrent updates, provide the
        /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
        /// rule as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        UpdateRuleResponse UpdateRule(UpdateRuleRequest request);



        /// <summary>
        /// Updates the specified rule. To prevent conflicting concurrent updates, provide the
        /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
        /// rule as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateScope


        /// <summary>
        /// Updates the specified scope. To prevent conflicting concurrent updates, provide the
        /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
        /// scope as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScope service method.</param>
        /// 
        /// <returns>The response from the UpdateScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateScope">REST API Reference for UpdateScope Operation</seealso>
        UpdateScopeResponse UpdateScope(UpdateScopeRequest request);



        /// <summary>
        /// Updates the specified scope. To prevent conflicting concurrent updates, provide the
        /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
        /// scope as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateScope">REST API Reference for UpdateScope Operation</seealso>
        Task<UpdateScopeResponse> UpdateScopeAsync(UpdateScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTemplate


        /// <summary>
        /// Updates the specified template. To prevent conflicting concurrent updates, provide
        /// the current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep
        /// the template as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request);



        /// <summary>
        /// Updates the specified template. To prevent conflicting concurrent updates, provide
        /// the current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep
        /// the template as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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