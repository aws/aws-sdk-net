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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Shield.Model;

#pragma warning disable CS1570
namespace Amazon.Shield
{
    /// <summary>
    /// <para>Interface for accessing Shield</para>
    ///
    /// Shield Advanced 
    /// <para>
    /// This is the <i>Shield Advanced API Reference</i>. This guide is for developers who
    /// need detailed information about the Shield Advanced API actions, data types, and errors.
    /// For detailed information about WAF and Shield Advanced features and an overview of
    /// how to use the WAF and Shield Advanced APIs, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">WAF
    /// and Shield Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonShield : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IShieldPaginatorFactory Paginators { get; }

        
        #region  AssociateDRTLogBucket


        /// <summary>
        /// Authorizes the Shield Response Team (SRT) to access the specified Amazon S3 bucket
        /// containing log data such as Application Load Balancer access logs, CloudFront logs,
        /// or logs from third party sources. You can associate up to 10 Amazon S3 buckets with
        /// your subscription.
        /// 
        ///  
        /// <para>
        /// To use the services of the SRT and make an <c>AssociateDRTLogBucket</c> request, you
        /// must be subscribed to the <a href="http://aws.amazon.com/premiumsupport/business-support/">Business
        /// Support plan</a> or the <a href="http://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTLogBucket service method.</param>
        /// 
        /// <returns>The response from the AssociateDRTLogBucket service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the Shield Response Team (SRT) the user
        /// submitting the request must have the <c>iam:PassRole</c> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an Amazon Web Services Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.NoAssociatedRoleException">
        /// The ARN of the role that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        AssociateDRTLogBucketResponse AssociateDRTLogBucket(AssociateDRTLogBucketRequest request);



        /// <summary>
        /// Authorizes the Shield Response Team (SRT) to access the specified Amazon S3 bucket
        /// containing log data such as Application Load Balancer access logs, CloudFront logs,
        /// or logs from third party sources. You can associate up to 10 Amazon S3 buckets with
        /// your subscription.
        /// 
        ///  
        /// <para>
        /// To use the services of the SRT and make an <c>AssociateDRTLogBucket</c> request, you
        /// must be subscribed to the <a href="http://aws.amazon.com/premiumsupport/business-support/">Business
        /// Support plan</a> or the <a href="http://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTLogBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDRTLogBucket service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the Shield Response Team (SRT) the user
        /// submitting the request must have the <c>iam:PassRole</c> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an Amazon Web Services Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.NoAssociatedRoleException">
        /// The ARN of the role that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        Task<AssociateDRTLogBucketResponse> AssociateDRTLogBucketAsync(AssociateDRTLogBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateDRTRole


        /// <summary>
        /// Authorizes the Shield Response Team (SRT) using the specified role, to access your
        /// Amazon Web Services account to assist with DDoS attack mitigation during potential
        /// attacks. This enables the SRT to inspect your WAF configuration and create or update
        /// WAF rules and web ACLs.
        /// 
        ///  
        /// <para>
        /// You can associate only one <c>RoleArn</c> with your subscription. If you submit an
        /// <c>AssociateDRTRole</c> request for an account that already has an associated role,
        /// the new <c>RoleArn</c> will replace the existing <c>RoleArn</c>. 
        /// </para>
        ///  
        /// <para>
        /// Prior to making the <c>AssociateDRTRole</c> request, you must attach the <c>AWSShieldDRTAccessPolicy</c>
        /// managed policy to the role that you'll specify in the request. You can access this
        /// policy in the IAM console at <a href="https://console.aws.amazon.com/iam/home?#/policies/arn:aws:iam::aws:policy/service-role/AWSShieldDRTAccessPolicy">AWSShieldDRTAccessPolicy</a>.
        /// For more information see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_manage-attach-detach.html">Adding
        /// and removing IAM identity permissions</a>. The role must also trust the service principal
        /// <c>drt.shield.amazonaws.com</c>. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html">IAM
        /// JSON policy elements: Principal</a>.
        /// </para>
        ///  
        /// <para>
        /// The SRT will have access only to your WAF and Shield resources. By submitting this
        /// request, you authorize the SRT to inspect your WAF and Shield configuration and create
        /// and update WAF rules and web ACLs on your behalf. The SRT takes these actions only
        /// if explicitly authorized by you.
        /// </para>
        ///  
        /// <para>
        /// You must have the <c>iam:PassRole</c> permission to make an <c>AssociateDRTRole</c>
        /// request. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a user permissions to pass a role to an Amazon Web Services service</a>. 
        /// </para>
        ///  
        /// <para>
        /// To use the services of the SRT and make an <c>AssociateDRTRole</c> request, you must
        /// be subscribed to the <a href="http://aws.amazon.com/premiumsupport/business-support/">Business
        /// Support plan</a> or the <a href="http://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTRole service method.</param>
        /// 
        /// <returns>The response from the AssociateDRTRole service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the Shield Response Team (SRT) the user
        /// submitting the request must have the <c>iam:PassRole</c> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an Amazon Web Services Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTRole">REST API Reference for AssociateDRTRole Operation</seealso>
        AssociateDRTRoleResponse AssociateDRTRole(AssociateDRTRoleRequest request);



        /// <summary>
        /// Authorizes the Shield Response Team (SRT) using the specified role, to access your
        /// Amazon Web Services account to assist with DDoS attack mitigation during potential
        /// attacks. This enables the SRT to inspect your WAF configuration and create or update
        /// WAF rules and web ACLs.
        /// 
        ///  
        /// <para>
        /// You can associate only one <c>RoleArn</c> with your subscription. If you submit an
        /// <c>AssociateDRTRole</c> request for an account that already has an associated role,
        /// the new <c>RoleArn</c> will replace the existing <c>RoleArn</c>. 
        /// </para>
        ///  
        /// <para>
        /// Prior to making the <c>AssociateDRTRole</c> request, you must attach the <c>AWSShieldDRTAccessPolicy</c>
        /// managed policy to the role that you'll specify in the request. You can access this
        /// policy in the IAM console at <a href="https://console.aws.amazon.com/iam/home?#/policies/arn:aws:iam::aws:policy/service-role/AWSShieldDRTAccessPolicy">AWSShieldDRTAccessPolicy</a>.
        /// For more information see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_manage-attach-detach.html">Adding
        /// and removing IAM identity permissions</a>. The role must also trust the service principal
        /// <c>drt.shield.amazonaws.com</c>. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html">IAM
        /// JSON policy elements: Principal</a>.
        /// </para>
        ///  
        /// <para>
        /// The SRT will have access only to your WAF and Shield resources. By submitting this
        /// request, you authorize the SRT to inspect your WAF and Shield configuration and create
        /// and update WAF rules and web ACLs on your behalf. The SRT takes these actions only
        /// if explicitly authorized by you.
        /// </para>
        ///  
        /// <para>
        /// You must have the <c>iam:PassRole</c> permission to make an <c>AssociateDRTRole</c>
        /// request. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a user permissions to pass a role to an Amazon Web Services service</a>. 
        /// </para>
        ///  
        /// <para>
        /// To use the services of the SRT and make an <c>AssociateDRTRole</c> request, you must
        /// be subscribed to the <a href="http://aws.amazon.com/premiumsupport/business-support/">Business
        /// Support plan</a> or the <a href="http://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDRTRole service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the Shield Response Team (SRT) the user
        /// submitting the request must have the <c>iam:PassRole</c> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an Amazon Web Services Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTRole">REST API Reference for AssociateDRTRole Operation</seealso>
        Task<AssociateDRTRoleResponse> AssociateDRTRoleAsync(AssociateDRTRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateHealthCheck


        /// <summary>
        /// Adds health-based detection to the Shield Advanced protection for a resource. Shield
        /// Advanced health-based detection uses the health of your Amazon Web Services resource
        /// to improve responsiveness and accuracy in attack detection and response. 
        /// 
        ///  
        /// <para>
        /// You define the health check in Route 53 and then associate it with your Shield Advanced
        /// protection. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-overview.html#ddos-advanced-health-check-option">Shield
        /// Advanced Health-Based Detection</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the AssociateHealthCheck service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateHealthCheck">REST API Reference for AssociateHealthCheck Operation</seealso>
        AssociateHealthCheckResponse AssociateHealthCheck(AssociateHealthCheckRequest request);



        /// <summary>
        /// Adds health-based detection to the Shield Advanced protection for a resource. Shield
        /// Advanced health-based detection uses the health of your Amazon Web Services resource
        /// to improve responsiveness and accuracy in attack detection and response. 
        /// 
        ///  
        /// <para>
        /// You define the health check in Route 53 and then associate it with your Shield Advanced
        /// protection. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-overview.html#ddos-advanced-health-check-option">Shield
        /// Advanced Health-Based Detection</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHealthCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateHealthCheck service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateHealthCheck">REST API Reference for AssociateHealthCheck Operation</seealso>
        Task<AssociateHealthCheckResponse> AssociateHealthCheckAsync(AssociateHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateProactiveEngagementDetails


        /// <summary>
        /// Initializes proactive engagement and sets the list of contacts for the Shield Response
        /// Team (SRT) to use. You must provide at least one phone number in the emergency contact
        /// list. 
        /// 
        ///  
        /// <para>
        /// After you have initialized proactive engagement using this call, to disable or enable
        /// proactive engagement, use the calls <c>DisableProactiveEngagement</c> and <c>EnableProactiveEngagement</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This call defines the list of email addresses and phone numbers that the SRT can use
        /// to contact you for escalations to the SRT and to initiate proactive customer support.
        /// </para>
        ///  
        /// <para>
        /// The contacts that you provide in the request replace any contacts that were already
        /// defined. If you already have contacts defined and want to use them, retrieve the list
        /// using <c>DescribeEmergencyContactSettings</c> and then provide it to this call. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProactiveEngagementDetails service method.</param>
        /// 
        /// <returns>The response from the AssociateProactiveEngagementDetails service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateProactiveEngagementDetails">REST API Reference for AssociateProactiveEngagementDetails Operation</seealso>
        AssociateProactiveEngagementDetailsResponse AssociateProactiveEngagementDetails(AssociateProactiveEngagementDetailsRequest request);



        /// <summary>
        /// Initializes proactive engagement and sets the list of contacts for the Shield Response
        /// Team (SRT) to use. You must provide at least one phone number in the emergency contact
        /// list. 
        /// 
        ///  
        /// <para>
        /// After you have initialized proactive engagement using this call, to disable or enable
        /// proactive engagement, use the calls <c>DisableProactiveEngagement</c> and <c>EnableProactiveEngagement</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This call defines the list of email addresses and phone numbers that the SRT can use
        /// to contact you for escalations to the SRT and to initiate proactive customer support.
        /// </para>
        ///  
        /// <para>
        /// The contacts that you provide in the request replace any contacts that were already
        /// defined. If you already have contacts defined and want to use them, retrieve the list
        /// using <c>DescribeEmergencyContactSettings</c> and then provide it to this call. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProactiveEngagementDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateProactiveEngagementDetails service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateProactiveEngagementDetails">REST API Reference for AssociateProactiveEngagementDetails Operation</seealso>
        Task<AssociateProactiveEngagementDetailsResponse> AssociateProactiveEngagementDetailsAsync(AssociateProactiveEngagementDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateProtection


        /// <summary>
        /// Enables Shield Advanced for a specific Amazon Web Services resource. The resource
        /// can be an Amazon CloudFront distribution, Amazon Route 53 hosted zone, Global Accelerator
        /// standard accelerator, Elastic IP Address, Application Load Balancer, or a Classic
        /// Load Balancer. You can protect Amazon EC2 instances and Network Load Balancers by
        /// association with protected Amazon EC2 Elastic IP addresses.
        /// 
        ///  
        /// <para>
        /// You can add protection to only a single resource with each <c>CreateProtection</c>
        /// request. You can add protection to multiple resources at once through the Shield Advanced
        /// console at <a href="https://console.aws.amazon.com/wafv2/shieldv2#/">https://console.aws.amazon.com/wafv2/shieldv2#/</a>.
        /// For more information see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/getting-started-ddos.html">Getting
        /// Started with Shield Advanced</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/configure-new-protection.html">Adding
        /// Shield Advanced protection to Amazon Web Services resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtection service method.</param>
        /// 
        /// <returns>The response from the CreateProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtection">REST API Reference for CreateProtection Operation</seealso>
        CreateProtectionResponse CreateProtection(CreateProtectionRequest request);



        /// <summary>
        /// Enables Shield Advanced for a specific Amazon Web Services resource. The resource
        /// can be an Amazon CloudFront distribution, Amazon Route 53 hosted zone, Global Accelerator
        /// standard accelerator, Elastic IP Address, Application Load Balancer, or a Classic
        /// Load Balancer. You can protect Amazon EC2 instances and Network Load Balancers by
        /// association with protected Amazon EC2 Elastic IP addresses.
        /// 
        ///  
        /// <para>
        /// You can add protection to only a single resource with each <c>CreateProtection</c>
        /// request. You can add protection to multiple resources at once through the Shield Advanced
        /// console at <a href="https://console.aws.amazon.com/wafv2/shieldv2#/">https://console.aws.amazon.com/wafv2/shieldv2#/</a>.
        /// For more information see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/getting-started-ddos.html">Getting
        /// Started with Shield Advanced</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/configure-new-protection.html">Adding
        /// Shield Advanced protection to Amazon Web Services resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtection">REST API Reference for CreateProtection Operation</seealso>
        Task<CreateProtectionResponse> CreateProtectionAsync(CreateProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateProtectionGroup


        /// <summary>
        /// Creates a grouping of protected resources so they can be handled as a collective.
        /// This resource grouping improves the accuracy of detection and reduces false positives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtectionGroup service method.</param>
        /// 
        /// <returns>The response from the CreateProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtectionGroup">REST API Reference for CreateProtectionGroup Operation</seealso>
        CreateProtectionGroupResponse CreateProtectionGroup(CreateProtectionGroupRequest request);



        /// <summary>
        /// Creates a grouping of protected resources so they can be handled as a collective.
        /// This resource grouping improves the accuracy of detection and reduces false positives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtectionGroup">REST API Reference for CreateProtectionGroup Operation</seealso>
        Task<CreateProtectionGroupResponse> CreateProtectionGroupAsync(CreateProtectionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSubscription


        /// <summary>
        /// Activates Shield Advanced for an account.
        /// 
        ///  <note> 
        /// <para>
        /// For accounts that are members of an Organizations organization, Shield Advanced subscriptions
        /// are billed against the organization's payer account, regardless of whether the payer
        /// account itself is subscribed. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When you initially create a subscription, your subscription is set to be automatically
        /// renewed at the end of the existing subscription period. You can change this by submitting
        /// an <c>UpdateSubscription</c> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request);



        /// <summary>
        /// Activates Shield Advanced for an account.
        /// 
        ///  <note> 
        /// <para>
        /// For accounts that are members of an Organizations organization, Shield Advanced subscriptions
        /// are billed against the organization's payer account, regardless of whether the payer
        /// account itself is subscribed. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When you initially create a subscription, your subscription is set to be automatically
        /// renewed at the end of the existing subscription period. You can change this by submitting
        /// an <c>UpdateSubscription</c> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProtection


        /// <summary>
        /// Deletes an Shield Advanced <a>Protection</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtection service method.</param>
        /// 
        /// <returns>The response from the DeleteProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtection">REST API Reference for DeleteProtection Operation</seealso>
        DeleteProtectionResponse DeleteProtection(DeleteProtectionRequest request);



        /// <summary>
        /// Deletes an Shield Advanced <a>Protection</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtection">REST API Reference for DeleteProtection Operation</seealso>
        Task<DeleteProtectionResponse> DeleteProtectionAsync(DeleteProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProtectionGroup


        /// <summary>
        /// Removes the specified protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtectionGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtectionGroup">REST API Reference for DeleteProtectionGroup Operation</seealso>
        DeleteProtectionGroupResponse DeleteProtectionGroup(DeleteProtectionGroupRequest request);



        /// <summary>
        /// Removes the specified protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtectionGroup">REST API Reference for DeleteProtectionGroup Operation</seealso>
        Task<DeleteProtectionGroupResponse> DeleteProtectionGroupAsync(DeleteProtectionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSubscription


        /// <summary>
        /// Removes Shield Advanced from an account. Shield Advanced requires a 1-year subscription
        /// commitment. You cannot delete a subscription prior to the completion of that commitment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// You are trying to update a subscription that has not yet completed the 1-year commitment.
        /// You can change the <c>AutoRenew</c> parameter during the last 30 days of your subscription.
        /// This exception indicates that you are attempting to change <c>AutoRenew</c> prior
        /// to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteSubscription">REST API Reference for DeleteSubscription Operation</seealso>
        [Obsolete("Use UpdateSubscription operation to disable automatic subscription renewal instead.")]
        DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionRequest request);



        /// <summary>
        /// Removes Shield Advanced from an account. Shield Advanced requires a 1-year subscription
        /// commitment. You cannot delete a subscription prior to the completion of that commitment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// You are trying to update a subscription that has not yet completed the 1-year commitment.
        /// You can change the <c>AutoRenew</c> parameter during the last 30 days of your subscription.
        /// This exception indicates that you are attempting to change <c>AutoRenew</c> prior
        /// to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteSubscription">REST API Reference for DeleteSubscription Operation</seealso>
        [Obsolete("Use UpdateSubscription operation to disable automatic subscription renewal instead.")]
        Task<DeleteSubscriptionResponse> DeleteSubscriptionAsync(DeleteSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAttack


        /// <summary>
        /// Describes the details of a DDoS attack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttack service method.</param>
        /// 
        /// <returns>The response from the DescribeAttack service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedException">
        /// Exception that indicates the specified <c>AttackId</c> does not exist, or the requester
        /// does not have the appropriate permissions to access the <c>AttackId</c>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttack">REST API Reference for DescribeAttack Operation</seealso>
        DescribeAttackResponse DescribeAttack(DescribeAttackRequest request);



        /// <summary>
        /// Describes the details of a DDoS attack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAttack service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedException">
        /// Exception that indicates the specified <c>AttackId</c> does not exist, or the requester
        /// does not have the appropriate permissions to access the <c>AttackId</c>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttack">REST API Reference for DescribeAttack Operation</seealso>
        Task<DescribeAttackResponse> DescribeAttackAsync(DescribeAttackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAttackStatistics


        /// <summary>
        /// Provides information about the number and type of attacks Shield has detected in the
        /// last year for all resources that belong to your account, regardless of whether you've
        /// defined Shield protections for them. This operation is available to Shield customers
        /// as well as to Shield Advanced customers.
        /// 
        ///  
        /// <para>
        /// The operation returns data for the time range of midnight UTC, one year ago, to midnight
        /// UTC, today. For example, if the current time is <c>2020-10-26 15:39:32 PDT</c>, equal
        /// to <c>2020-10-26 22:39:32 UTC</c>, then the time range for the attack data returned
        /// is from <c>2019-10-26 00:00:00 UTC</c> to <c>2020-10-26 00:00:00 UTC</c>. 
        /// </para>
        ///  
        /// <para>
        /// The time range indicates the period covered by the attack statistics data items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttackStatistics service method.</param>
        /// 
        /// <returns>The response from the DescribeAttackStatistics service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttackStatistics">REST API Reference for DescribeAttackStatistics Operation</seealso>
        DescribeAttackStatisticsResponse DescribeAttackStatistics(DescribeAttackStatisticsRequest request);



        /// <summary>
        /// Provides information about the number and type of attacks Shield has detected in the
        /// last year for all resources that belong to your account, regardless of whether you've
        /// defined Shield protections for them. This operation is available to Shield customers
        /// as well as to Shield Advanced customers.
        /// 
        ///  
        /// <para>
        /// The operation returns data for the time range of midnight UTC, one year ago, to midnight
        /// UTC, today. For example, if the current time is <c>2020-10-26 15:39:32 PDT</c>, equal
        /// to <c>2020-10-26 22:39:32 UTC</c>, then the time range for the attack data returned
        /// is from <c>2019-10-26 00:00:00 UTC</c> to <c>2020-10-26 00:00:00 UTC</c>. 
        /// </para>
        ///  
        /// <para>
        /// The time range indicates the period covered by the attack statistics data items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttackStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAttackStatistics service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttackStatistics">REST API Reference for DescribeAttackStatistics Operation</seealso>
        Task<DescribeAttackStatisticsResponse> DescribeAttackStatisticsAsync(DescribeAttackStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDRTAccess


        /// <summary>
        /// Returns the current role and list of Amazon S3 log buckets used by the Shield Response
        /// Team (SRT) to access your Amazon Web Services account while assisting with attack
        /// mitigation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDRTAccess service method.</param>
        /// 
        /// <returns>The response from the DescribeDRTAccess service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeDRTAccess">REST API Reference for DescribeDRTAccess Operation</seealso>
        DescribeDRTAccessResponse DescribeDRTAccess(DescribeDRTAccessRequest request);



        /// <summary>
        /// Returns the current role and list of Amazon S3 log buckets used by the Shield Response
        /// Team (SRT) to access your Amazon Web Services account while assisting with attack
        /// mitigation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDRTAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDRTAccess service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeDRTAccess">REST API Reference for DescribeDRTAccess Operation</seealso>
        Task<DescribeDRTAccessResponse> DescribeDRTAccessAsync(DescribeDRTAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEmergencyContactSettings


        /// <summary>
        /// A list of email addresses and phone numbers that the Shield Response Team (SRT) can
        /// use to contact you if you have proactive engagement enabled, for escalations to the
        /// SRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmergencyContactSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeEmergencyContactSettings">REST API Reference for DescribeEmergencyContactSettings Operation</seealso>
        DescribeEmergencyContactSettingsResponse DescribeEmergencyContactSettings(DescribeEmergencyContactSettingsRequest request);



        /// <summary>
        /// A list of email addresses and phone numbers that the Shield Response Team (SRT) can
        /// use to contact you if you have proactive engagement enabled, for escalations to the
        /// SRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmergencyContactSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeEmergencyContactSettings">REST API Reference for DescribeEmergencyContactSettings Operation</seealso>
        Task<DescribeEmergencyContactSettingsResponse> DescribeEmergencyContactSettingsAsync(DescribeEmergencyContactSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeProtection


        /// <summary>
        /// Lists the details of a <a>Protection</a> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtection service method.</param>
        /// 
        /// <returns>The response from the DescribeProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtection">REST API Reference for DescribeProtection Operation</seealso>
        DescribeProtectionResponse DescribeProtection(DescribeProtectionRequest request);



        /// <summary>
        /// Lists the details of a <a>Protection</a> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtection">REST API Reference for DescribeProtection Operation</seealso>
        Task<DescribeProtectionResponse> DescribeProtectionAsync(DescribeProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeProtectionGroup


        /// <summary>
        /// Returns the specification for the specified protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectionGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtectionGroup">REST API Reference for DescribeProtectionGroup Operation</seealso>
        DescribeProtectionGroupResponse DescribeProtectionGroup(DescribeProtectionGroupRequest request);



        /// <summary>
        /// Returns the specification for the specified protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtectionGroup">REST API Reference for DescribeProtectionGroup Operation</seealso>
        Task<DescribeProtectionGroupResponse> DescribeProtectionGroupAsync(DescribeProtectionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSubscription


        /// <summary>
        /// Provides details about the Shield Advanced subscription for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscription service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeSubscription">REST API Reference for DescribeSubscription Operation</seealso>
        DescribeSubscriptionResponse DescribeSubscription(DescribeSubscriptionRequest request);



        /// <summary>
        /// Provides details about the Shield Advanced subscription for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeSubscription">REST API Reference for DescribeSubscription Operation</seealso>
        Task<DescribeSubscriptionResponse> DescribeSubscriptionAsync(DescribeSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableApplicationLayerAutomaticResponse


        /// <summary>
        /// Disable the Shield Advanced automatic application layer DDoS mitigation feature for
        /// the protected resource. This stops Shield Advanced from creating, verifying, and applying
        /// WAF rules for attacks that it detects for the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableApplicationLayerAutomaticResponse service method.</param>
        /// 
        /// <returns>The response from the DisableApplicationLayerAutomaticResponse service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisableApplicationLayerAutomaticResponse">REST API Reference for DisableApplicationLayerAutomaticResponse Operation</seealso>
        DisableApplicationLayerAutomaticResponseResponse DisableApplicationLayerAutomaticResponse(DisableApplicationLayerAutomaticResponseRequest request);



        /// <summary>
        /// Disable the Shield Advanced automatic application layer DDoS mitigation feature for
        /// the protected resource. This stops Shield Advanced from creating, verifying, and applying
        /// WAF rules for attacks that it detects for the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableApplicationLayerAutomaticResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableApplicationLayerAutomaticResponse service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisableApplicationLayerAutomaticResponse">REST API Reference for DisableApplicationLayerAutomaticResponse Operation</seealso>
        Task<DisableApplicationLayerAutomaticResponseResponse> DisableApplicationLayerAutomaticResponseAsync(DisableApplicationLayerAutomaticResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableProactiveEngagement


        /// <summary>
        /// Removes authorization from the Shield Response Team (SRT) to notify contacts about
        /// escalations to the SRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableProactiveEngagement service method.</param>
        /// 
        /// <returns>The response from the DisableProactiveEngagement service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisableProactiveEngagement">REST API Reference for DisableProactiveEngagement Operation</seealso>
        DisableProactiveEngagementResponse DisableProactiveEngagement(DisableProactiveEngagementRequest request);



        /// <summary>
        /// Removes authorization from the Shield Response Team (SRT) to notify contacts about
        /// escalations to the SRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableProactiveEngagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableProactiveEngagement service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisableProactiveEngagement">REST API Reference for DisableProactiveEngagement Operation</seealso>
        Task<DisableProactiveEngagementResponse> DisableProactiveEngagementAsync(DisableProactiveEngagementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateDRTLogBucket


        /// <summary>
        /// Removes the Shield Response Team's (SRT) access to the specified Amazon S3 bucket
        /// containing the logs that you shared previously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTLogBucket service method.</param>
        /// 
        /// <returns>The response from the DisassociateDRTLogBucket service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the Shield Response Team (SRT) the user
        /// submitting the request must have the <c>iam:PassRole</c> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an Amazon Web Services Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.NoAssociatedRoleException">
        /// The ARN of the role that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTLogBucket">REST API Reference for DisassociateDRTLogBucket Operation</seealso>
        DisassociateDRTLogBucketResponse DisassociateDRTLogBucket(DisassociateDRTLogBucketRequest request);



        /// <summary>
        /// Removes the Shield Response Team's (SRT) access to the specified Amazon S3 bucket
        /// containing the logs that you shared previously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTLogBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDRTLogBucket service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the Shield Response Team (SRT) the user
        /// submitting the request must have the <c>iam:PassRole</c> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an Amazon Web Services Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.NoAssociatedRoleException">
        /// The ARN of the role that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTLogBucket">REST API Reference for DisassociateDRTLogBucket Operation</seealso>
        Task<DisassociateDRTLogBucketResponse> DisassociateDRTLogBucketAsync(DisassociateDRTLogBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateDRTRole


        /// <summary>
        /// Removes the Shield Response Team's (SRT) access to your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTRole service method.</param>
        /// 
        /// <returns>The response from the DisassociateDRTRole service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTRole">REST API Reference for DisassociateDRTRole Operation</seealso>
        DisassociateDRTRoleResponse DisassociateDRTRole(DisassociateDRTRoleRequest request);



        /// <summary>
        /// Removes the Shield Response Team's (SRT) access to your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDRTRole service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTRole">REST API Reference for DisassociateDRTRole Operation</seealso>
        Task<DisassociateDRTRoleResponse> DisassociateDRTRoleAsync(DisassociateDRTRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateHealthCheck


        /// <summary>
        /// Removes health-based detection from the Shield Advanced protection for a resource.
        /// Shield Advanced health-based detection uses the health of your Amazon Web Services
        /// resource to improve responsiveness and accuracy in attack detection and response.
        /// 
        /// 
        ///  
        /// <para>
        /// You define the health check in Route 53 and then associate or disassociate it with
        /// your Shield Advanced protection. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-overview.html#ddos-advanced-health-check-option">Shield
        /// Advanced Health-Based Detection</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the DisassociateHealthCheck service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateHealthCheck">REST API Reference for DisassociateHealthCheck Operation</seealso>
        DisassociateHealthCheckResponse DisassociateHealthCheck(DisassociateHealthCheckRequest request);



        /// <summary>
        /// Removes health-based detection from the Shield Advanced protection for a resource.
        /// Shield Advanced health-based detection uses the health of your Amazon Web Services
        /// resource to improve responsiveness and accuracy in attack detection and response.
        /// 
        /// 
        ///  
        /// <para>
        /// You define the health check in Route 53 and then associate or disassociate it with
        /// your Shield Advanced protection. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-overview.html#ddos-advanced-health-check-option">Shield
        /// Advanced Health-Based Detection</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateHealthCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateHealthCheck service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateHealthCheck">REST API Reference for DisassociateHealthCheck Operation</seealso>
        Task<DisassociateHealthCheckResponse> DisassociateHealthCheckAsync(DisassociateHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableApplicationLayerAutomaticResponse


        /// <summary>
        /// Enable the Shield Advanced automatic application layer DDoS mitigation for the protected
        /// resource. 
        /// 
        ///  <note> 
        /// <para>
        /// This feature is available for Amazon CloudFront distributions and Application Load
        /// Balancers only.
        /// </para>
        ///  </note> 
        /// <para>
        /// This causes Shield Advanced to create, verify, and apply WAF rules for DDoS attacks
        /// that it detects for the resource. Shield Advanced applies the rules in a Shield rule
        /// group inside the web ACL that you've associated with the resource. For information
        /// about how automatic mitigation works and the requirements for using it, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-advanced-automatic-app-layer-response.html">Shield
        /// Advanced automatic application layer DDoS mitigation</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't use this action to make changes to automatic mitigation settings when it's already
        /// enabled for a resource. Instead, use <a>UpdateApplicationLayerAutomaticResponse</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this feature, you must associate a web ACL with the protected resource. The
        /// web ACL must be created using the latest version of WAF (v2). You can associate the
        /// web ACL through the Shield Advanced console at <a href="https://console.aws.amazon.com/wafv2/shieldv2#/">https://console.aws.amazon.com/wafv2/shieldv2#/</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/getting-started-ddos.html">Getting
        /// Started with Shield Advanced</a>. You can also associate the web ACL to the resource
        /// through the WAF console or the WAF API, but you must manage Shield Advanced automatic
        /// mitigation through Shield Advanced. For information about WAF, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">WAF
        /// Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableApplicationLayerAutomaticResponse service method.</param>
        /// 
        /// <returns>The response from the EnableApplicationLayerAutomaticResponse service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/EnableApplicationLayerAutomaticResponse">REST API Reference for EnableApplicationLayerAutomaticResponse Operation</seealso>
        EnableApplicationLayerAutomaticResponseResponse EnableApplicationLayerAutomaticResponse(EnableApplicationLayerAutomaticResponseRequest request);



        /// <summary>
        /// Enable the Shield Advanced automatic application layer DDoS mitigation for the protected
        /// resource. 
        /// 
        ///  <note> 
        /// <para>
        /// This feature is available for Amazon CloudFront distributions and Application Load
        /// Balancers only.
        /// </para>
        ///  </note> 
        /// <para>
        /// This causes Shield Advanced to create, verify, and apply WAF rules for DDoS attacks
        /// that it detects for the resource. Shield Advanced applies the rules in a Shield rule
        /// group inside the web ACL that you've associated with the resource. For information
        /// about how automatic mitigation works and the requirements for using it, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-advanced-automatic-app-layer-response.html">Shield
        /// Advanced automatic application layer DDoS mitigation</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't use this action to make changes to automatic mitigation settings when it's already
        /// enabled for a resource. Instead, use <a>UpdateApplicationLayerAutomaticResponse</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this feature, you must associate a web ACL with the protected resource. The
        /// web ACL must be created using the latest version of WAF (v2). You can associate the
        /// web ACL through the Shield Advanced console at <a href="https://console.aws.amazon.com/wafv2/shieldv2#/">https://console.aws.amazon.com/wafv2/shieldv2#/</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/getting-started-ddos.html">Getting
        /// Started with Shield Advanced</a>. You can also associate the web ACL to the resource
        /// through the WAF console or the WAF API, but you must manage Shield Advanced automatic
        /// mitigation through Shield Advanced. For information about WAF, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">WAF
        /// Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableApplicationLayerAutomaticResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableApplicationLayerAutomaticResponse service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/EnableApplicationLayerAutomaticResponse">REST API Reference for EnableApplicationLayerAutomaticResponse Operation</seealso>
        Task<EnableApplicationLayerAutomaticResponseResponse> EnableApplicationLayerAutomaticResponseAsync(EnableApplicationLayerAutomaticResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableProactiveEngagement


        /// <summary>
        /// Authorizes the Shield Response Team (SRT) to use email and phone to notify contacts
        /// about escalations to the SRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableProactiveEngagement service method.</param>
        /// 
        /// <returns>The response from the EnableProactiveEngagement service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/EnableProactiveEngagement">REST API Reference for EnableProactiveEngagement Operation</seealso>
        EnableProactiveEngagementResponse EnableProactiveEngagement(EnableProactiveEngagementRequest request);



        /// <summary>
        /// Authorizes the Shield Response Team (SRT) to use email and phone to notify contacts
        /// about escalations to the SRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableProactiveEngagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableProactiveEngagement service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/EnableProactiveEngagement">REST API Reference for EnableProactiveEngagement Operation</seealso>
        Task<EnableProactiveEngagementResponse> EnableProactiveEngagementAsync(EnableProactiveEngagementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSubscriptionState


        /// <summary>
        /// Returns the <c>SubscriptionState</c>, either <c>Active</c> or <c>Inactive</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionState service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionState service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/GetSubscriptionState">REST API Reference for GetSubscriptionState Operation</seealso>
        GetSubscriptionStateResponse GetSubscriptionState(GetSubscriptionStateRequest request);



        /// <summary>
        /// Returns the <c>SubscriptionState</c>, either <c>Active</c> or <c>Inactive</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionState service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/GetSubscriptionState">REST API Reference for GetSubscriptionState Operation</seealso>
        Task<GetSubscriptionStateResponse> GetSubscriptionStateAsync(GetSubscriptionStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAttacks


        /// <summary>
        /// Returns all ongoing DDoS attacks or all DDoS attacks during a specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttacks service method.</param>
        /// 
        /// <returns>The response from the ListAttacks service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListAttacks">REST API Reference for ListAttacks Operation</seealso>
        ListAttacksResponse ListAttacks(ListAttacksRequest request);



        /// <summary>
        /// Returns all ongoing DDoS attacks or all DDoS attacks during a specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttacks service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListAttacks">REST API Reference for ListAttacks Operation</seealso>
        Task<ListAttacksResponse> ListAttacksAsync(ListAttacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProtectionGroups


        /// <summary>
        /// Retrieves <a>ProtectionGroup</a> objects for the account. You can retrieve all protection
        /// groups or you can provide filtering criteria and retrieve just the subset of protection
        /// groups that match the criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectionGroups service method.</param>
        /// 
        /// <returns>The response from the ListProtectionGroups service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the <c>NextToken</c> specified in the request is invalid.
        /// Submit the request using the <c>NextToken</c> value that was returned in the prior
        /// response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtectionGroups">REST API Reference for ListProtectionGroups Operation</seealso>
        ListProtectionGroupsResponse ListProtectionGroups(ListProtectionGroupsRequest request);



        /// <summary>
        /// Retrieves <a>ProtectionGroup</a> objects for the account. You can retrieve all protection
        /// groups or you can provide filtering criteria and retrieve just the subset of protection
        /// groups that match the criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectionGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtectionGroups service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the <c>NextToken</c> specified in the request is invalid.
        /// Submit the request using the <c>NextToken</c> value that was returned in the prior
        /// response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtectionGroups">REST API Reference for ListProtectionGroups Operation</seealso>
        Task<ListProtectionGroupsResponse> ListProtectionGroupsAsync(ListProtectionGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProtections


        /// <summary>
        /// Retrieves <a>Protection</a> objects for the account. You can retrieve all protections
        /// or you can provide filtering criteria and retrieve just the subset of protections
        /// that match the criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtections service method.</param>
        /// 
        /// <returns>The response from the ListProtections service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the <c>NextToken</c> specified in the request is invalid.
        /// Submit the request using the <c>NextToken</c> value that was returned in the prior
        /// response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtections">REST API Reference for ListProtections Operation</seealso>
        ListProtectionsResponse ListProtections(ListProtectionsRequest request);



        /// <summary>
        /// Retrieves <a>Protection</a> objects for the account. You can retrieve all protections
        /// or you can provide filtering criteria and retrieve just the subset of protections
        /// that match the criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtections service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the <c>NextToken</c> specified in the request is invalid.
        /// Submit the request using the <c>NextToken</c> value that was returned in the prior
        /// response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtections">REST API Reference for ListProtections Operation</seealso>
        Task<ListProtectionsResponse> ListProtectionsAsync(ListProtectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourcesInProtectionGroup


        /// <summary>
        /// Retrieves the resources that are included in the protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesInProtectionGroup service method.</param>
        /// 
        /// <returns>The response from the ListResourcesInProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the <c>NextToken</c> specified in the request is invalid.
        /// Submit the request using the <c>NextToken</c> value that was returned in the prior
        /// response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListResourcesInProtectionGroup">REST API Reference for ListResourcesInProtectionGroup Operation</seealso>
        ListResourcesInProtectionGroupResponse ListResourcesInProtectionGroup(ListResourcesInProtectionGroupRequest request);



        /// <summary>
        /// Retrieves the resources that are included in the protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesInProtectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcesInProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the <c>NextToken</c> specified in the request is invalid.
        /// Submit the request using the <c>NextToken</c> value that was returned in the prior
        /// response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListResourcesInProtectionGroup">REST API Reference for ListResourcesInProtectionGroup Operation</seealso>
        Task<ListResourcesInProtectionGroupResponse> ListResourcesInProtectionGroupAsync(ListResourcesInProtectionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets information about Amazon Web Services tags for a specified Amazon Resource Name
        /// (ARN) in Shield.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Gets information about Amazon Web Services tags for a specified Amazon Resource Name
        /// (ARN) in Shield.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for a resource in Shield.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or updates tags for a resource in Shield.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource in Shield.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a resource in Shield.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApplicationLayerAutomaticResponse


        /// <summary>
        /// Updates an existing Shield Advanced automatic application layer DDoS mitigation configuration
        /// for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationLayerAutomaticResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationLayerAutomaticResponse service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateApplicationLayerAutomaticResponse">REST API Reference for UpdateApplicationLayerAutomaticResponse Operation</seealso>
        UpdateApplicationLayerAutomaticResponseResponse UpdateApplicationLayerAutomaticResponse(UpdateApplicationLayerAutomaticResponseRequest request);



        /// <summary>
        /// Updates an existing Shield Advanced automatic application layer DDoS mitigation configuration
        /// for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationLayerAutomaticResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplicationLayerAutomaticResponse service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateApplicationLayerAutomaticResponse">REST API Reference for UpdateApplicationLayerAutomaticResponse Operation</seealso>
        Task<UpdateApplicationLayerAutomaticResponseResponse> UpdateApplicationLayerAutomaticResponseAsync(UpdateApplicationLayerAutomaticResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEmergencyContactSettings


        /// <summary>
        /// Updates the details of the list of email addresses and phone numbers that the Shield
        /// Response Team (SRT) can use to contact you if you have proactive engagement enabled,
        /// for escalations to the SRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmergencyContactSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateEmergencyContactSettings">REST API Reference for UpdateEmergencyContactSettings Operation</seealso>
        UpdateEmergencyContactSettingsResponse UpdateEmergencyContactSettings(UpdateEmergencyContactSettingsRequest request);



        /// <summary>
        /// Updates the details of the list of email addresses and phone numbers that the Shield
        /// Response Team (SRT) can use to contact you if you have proactive engagement enabled,
        /// for escalations to the SRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmergencyContactSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateEmergencyContactSettings">REST API Reference for UpdateEmergencyContactSettings Operation</seealso>
        Task<UpdateEmergencyContactSettingsResponse> UpdateEmergencyContactSettingsAsync(UpdateEmergencyContactSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateProtectionGroup


        /// <summary>
        /// Updates an existing protection group. A protection group is a grouping of protected
        /// resources so they can be handled as a collective. This resource grouping improves
        /// the accuracy of detection and reduces false positives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectionGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateProtectionGroup">REST API Reference for UpdateProtectionGroup Operation</seealso>
        UpdateProtectionGroupResponse UpdateProtectionGroup(UpdateProtectionGroupRequest request);



        /// <summary>
        /// Updates an existing protection group. A protection group is a grouping of protected
        /// resources so they can be handled as a collective. This resource grouping improves
        /// the accuracy of detection and reduces false positives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateProtectionGroup">REST API Reference for UpdateProtectionGroup Operation</seealso>
        Task<UpdateProtectionGroupResponse> UpdateProtectionGroupAsync(UpdateProtectionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSubscription


        /// <summary>
        /// Updates the details of an existing subscription. Only enter values for parameters
        /// you want to change. Empty parameters are not updated.
        /// 
        ///  <note> 
        /// <para>
        /// For accounts that are members of an Organizations organization, Shield Advanced subscriptions
        /// are billed against the organization's payer account, regardless of whether the payer
        /// account itself is subscribed. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// You are trying to update a subscription that has not yet completed the 1-year commitment.
        /// You can change the <c>AutoRenew</c> parameter during the last 30 days of your subscription.
        /// This exception indicates that you are attempting to change <c>AutoRenew</c> prior
        /// to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request);



        /// <summary>
        /// Updates the details of an existing subscription. Only enter values for parameters
        /// you want to change. Empty parameters are not updated.
        /// 
        ///  <note> 
        /// <para>
        /// For accounts that are members of an Organizations organization, Shield Advanced subscriptions
        /// are billed against the organization's payer account, regardless of whether the payer
        /// account itself is subscribed. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// You are trying to update a subscription that has not yet completed the 1-year commitment.
        /// You can change the <c>AutoRenew</c> parameter during the last 30 days of your subscription.
        /// This exception indicates that you are attempting to change <c>AutoRenew</c> prior
        /// to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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