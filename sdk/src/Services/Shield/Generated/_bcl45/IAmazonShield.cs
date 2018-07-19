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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Shield.Model;

namespace Amazon.Shield
{
    /// <summary>
    /// Interface for accessing Shield
    ///
    /// AWS Shield Advanced 
    /// <para>
    /// This is the <i>AWS Shield Advanced API Reference</i>. This guide is for developers
    /// who need detailed information about the AWS Shield Advanced API actions, data types,
    /// and errors. For detailed information about AWS WAF and AWS Shield Advanced features
    /// and an overview of how to use the AWS WAF and AWS Shield Advanced APIs, see the <a
    /// href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF and AWS Shield
    /// Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonShield : IAmazonService, IDisposable
    {

        
        #region  AssociateDRTLogBucket


        /// <summary>
        /// Authorizes the DDoS Response team (DRT) to access the specified Amazon S3 bucket containing
        /// your flow logs. You can associate up to 10 Amazon S3 buckets with your subscription.
        /// 
        ///  
        /// <para>
        /// To use the services of the DRT and make an <code>AssociateDRTLogBucket</code> request,
        /// you must be subscribed to the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business
        /// Support plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTLogBucket service method.</param>
        /// 
        /// <returns>The response from the AssociateDRTLogBucket service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the DDoS Response Team, the user submitting
        /// <code>AssociateDRTRole</code> must have the <code>iam:PassRole</code> permission.
        /// This error indicates the user did not have the appropriate permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// 
        ///  
        /// <para>
        ///  <code>Type</code> is the type of limit that would be exceeded.
        /// </para>
        ///  
        /// <para>
        ///  <code>Limit</code> is the threshold that would be exceeded.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.NoAssociatedRoleException">
        /// The ARN of the role that you specifed does not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        AssociateDRTLogBucketResponse AssociateDRTLogBucket(AssociateDRTLogBucketRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDRTLogBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTLogBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        Task<AssociateDRTLogBucketResponse> AssociateDRTLogBucketAsync(AssociateDRTLogBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateDRTRole


        /// <summary>
        /// Authorizes the DDoS Response team (DRT), using the specified role, to access your
        /// AWS account to assist with DDoS attack mitigation during potential attacks. This enables
        /// the DRT to inspect your AWS WAF configuration and create or update AWS WAF rules and
        /// web ACLs.
        /// 
        ///  
        /// <para>
        /// You can associate only one <code>RoleArn</code> with your subscription. If you submit
        /// an <code>AssociateDRTRole</code> request for an account that already has an associated
        /// role, the new <code>RoleArn</code> will replace the existing <code>RoleArn</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Prior to making the <code>AssociateDRTRole</code> request, you must attach the <a
        /// href="https://console.aws.amazon.com/iam/home?#/policies/arn:aws:iam::aws:policy/service-role/AWSShieldDRTAccessPolicy">AWSShieldDRTAccessPolicy</a>
        /// managed policy to the role you will specify in the request. For more information see
        /// <a href=" https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_manage-attach-detach.html">Attaching
        /// and Detaching IAM Policies</a>. The role must also trust the service principal <code>
        /// drt.shield.amazonaws.com</code>. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html">IAM
        /// JSON Policy Elements: Principal</a>.
        /// </para>
        ///  
        /// <para>
        /// The DRT will have access only to your AWS WAF and Shield resources. By submitting
        /// this request, you authorize the DRT to inspect your AWS WAF and Shield configuration
        /// and create and update AWS WAF rules and web ACLs on your behalf. The DRT takes these
        /// actions only if explicitly authorized by you.
        /// </para>
        ///  
        /// <para>
        /// You must have the <code>iam:PassRole</code> permission to make an <code>AssociateDRTRole</code>
        /// request. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>. 
        /// </para>
        ///  
        /// <para>
        /// To use the services of the DRT and make an <code>AssociateDRTRole</code> request,
        /// you must be subscribed to the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business
        /// Support plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTRole service method.</param>
        /// 
        /// <returns>The response from the AssociateDRTRole service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the DDoS Response Team, the user submitting
        /// <code>AssociateDRTRole</code> must have the <code>iam:PassRole</code> permission.
        /// This error indicates the user did not have the appropriate permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTRole">REST API Reference for AssociateDRTRole Operation</seealso>
        AssociateDRTRoleResponse AssociateDRTRole(AssociateDRTRoleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDRTRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTRole">REST API Reference for AssociateDRTRole Operation</seealso>
        Task<AssociateDRTRoleResponse> AssociateDRTRoleAsync(AssociateDRTRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateProtection


        /// <summary>
        /// Enables AWS Shield Advanced for a specific AWS resource. The resource can be an Amazon
        /// CloudFront distribution, Elastic Load Balancing load balancer, Elastic IP Address,
        /// or an Amazon Route 53 hosted zone.
        /// 
        ///  
        /// <para>
        /// You can add protection to only a single resource with each CreateProtection request.
        /// If you want to add protection to multiple resources at once, use the <a href="https://console.aws.amazon.com/waf/">AWS
        /// WAF console</a>. For more information see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/getting-started-ddos.html">Getting
        /// Started with AWS Shield Advanced</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/configure-new-protection.html">Add
        /// AWS Shield Advanced Protection to more AWS Resources</a>.
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
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// 
        ///  
        /// <para>
        ///  <code>Type</code> is the type of limit that would be exceeded.
        /// </para>
        ///  
        /// <para>
        ///  <code>Limit</code> is the threshold that would be exceeded.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtection">REST API Reference for CreateProtection Operation</seealso>
        CreateProtectionResponse CreateProtection(CreateProtectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtection">REST API Reference for CreateProtection Operation</seealso>
        Task<CreateProtectionResponse> CreateProtectionAsync(CreateProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSubscription


        /// <summary>
        /// Activates AWS Shield Advanced for an account.
        /// 
        ///  
        /// <para>
        /// As part of this request you can specify <code>EmergencySettings</code> that automaticaly
        /// grant the DDoS response team (DRT) needed permissions to assist you during a suspected
        /// DDoS attack. For more information see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/authorize-DRT.html">Authorize
        /// the DDoS Response Team to Create Rules and Web ACLs on Your Behalf</a>.
        /// </para>
        ///  
        /// <para>
        /// When you initally create a subscription, your subscription is set to be automatically
        /// renewed at the end of the existing subscription period. You can change this by submitting
        /// an <code>UpdateSubscription</code> request. 
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
        /// Exception indicating the specified resource already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProtection


        /// <summary>
        /// Deletes an AWS Shield Advanced <a>Protection</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtection service method.</param>
        /// 
        /// <returns>The response from the DeleteProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtection">REST API Reference for DeleteProtection Operation</seealso>
        DeleteProtectionResponse DeleteProtection(DeleteProtectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtection">REST API Reference for DeleteProtection Operation</seealso>
        Task<DeleteProtectionResponse> DeleteProtectionAsync(DeleteProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSubscription


        /// <summary>
        /// Removes AWS Shield Advanced from an account. AWS Shield Advanced requires a 1-year
        /// subscription commitment. You cannot delete a subscription prior to the completion
        /// of that commitment.
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
        /// You can change the <code>AutoRenew</code> parameter during the last 30 days of your
        /// subscription. This exception indicates that you are attempting to change <code>AutoRenew</code>
        /// prior to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteSubscription">REST API Reference for DeleteSubscription Operation</seealso>
        [Obsolete("Use UpdateSubscription operation to disable automatic subscription renewal instead.")]
        DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttack">REST API Reference for DescribeAttack Operation</seealso>
        DescribeAttackResponse DescribeAttack(DescribeAttackRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAttack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttack">REST API Reference for DescribeAttack Operation</seealso>
        Task<DescribeAttackResponse> DescribeAttackAsync(DescribeAttackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDRTAccess


        /// <summary>
        /// Returns the current role and list of Amazon S3 log buckets used by the DDoS Response
        /// team (DRT) to access your AWS account while assisting with attack mitigation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDRTAccess service method.</param>
        /// 
        /// <returns>The response from the DescribeDRTAccess service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeDRTAccess">REST API Reference for DescribeDRTAccess Operation</seealso>
        DescribeDRTAccessResponse DescribeDRTAccess(DescribeDRTAccessRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDRTAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDRTAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeDRTAccess">REST API Reference for DescribeDRTAccess Operation</seealso>
        Task<DescribeDRTAccessResponse> DescribeDRTAccessAsync(DescribeDRTAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEmergencyContactSettings


        /// <summary>
        /// Lists the email addresses that the DRT can use to contact you during a suspected attack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmergencyContactSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeEmergencyContactSettings">REST API Reference for DescribeEmergencyContactSettings Operation</seealso>
        DescribeEmergencyContactSettingsResponse DescribeEmergencyContactSettings(DescribeEmergencyContactSettingsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEmergencyContactSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmergencyContactSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtection">REST API Reference for DescribeProtection Operation</seealso>
        DescribeProtectionResponse DescribeProtection(DescribeProtectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtection">REST API Reference for DescribeProtection Operation</seealso>
        Task<DescribeProtectionResponse> DescribeProtectionAsync(DescribeProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSubscription


        /// <summary>
        /// Provides details about the AWS Shield Advanced subscription for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscription service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeSubscription">REST API Reference for DescribeSubscription Operation</seealso>
        DescribeSubscriptionResponse DescribeSubscription(DescribeSubscriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeSubscription">REST API Reference for DescribeSubscription Operation</seealso>
        Task<DescribeSubscriptionResponse> DescribeSubscriptionAsync(DescribeSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateDRTLogBucket


        /// <summary>
        /// Removes the DDoS Response team's (DRT) access to the specified Amazon S3 bucket containing
        /// your flow logs.
        /// 
        ///  
        /// <para>
        /// To make a <code>DisassociateDRTLogBucket</code> request, you must be subscribed to
        /// the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business Support
        /// plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>. However, if you are not subscribed to one of these support plans,
        /// but had been previously and had granted the DRT access to your account, you can submit
        /// a <code>DisassociateDRTLogBucket</code> request to remove this access.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTLogBucket service method.</param>
        /// 
        /// <returns>The response from the DisassociateDRTLogBucket service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the DDoS Response Team, the user submitting
        /// <code>AssociateDRTRole</code> must have the <code>iam:PassRole</code> permission.
        /// This error indicates the user did not have the appropriate permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.NoAssociatedRoleException">
        /// The ARN of the role that you specifed does not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTLogBucket">REST API Reference for DisassociateDRTLogBucket Operation</seealso>
        DisassociateDRTLogBucketResponse DisassociateDRTLogBucket(DisassociateDRTLogBucketRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDRTLogBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTLogBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTLogBucket">REST API Reference for DisassociateDRTLogBucket Operation</seealso>
        Task<DisassociateDRTLogBucketResponse> DisassociateDRTLogBucketAsync(DisassociateDRTLogBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateDRTRole


        /// <summary>
        /// Removes the DDoS Response team's (DRT) access to your AWS account.
        /// 
        ///  
        /// <para>
        /// To make a <code>DisassociateDRTRole</code> request, you must be subscribed to the
        /// <a href="https://aws.amazon.com/premiumsupport/business-support/">Business Support
        /// plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>. However, if you are not subscribed to one of these support plans,
        /// but had been previously and had granted the DRT access to your account, you can submit
        /// a <code>DisassociateDRTRole</code> request to remove this access.
        /// </para>
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
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTRole">REST API Reference for DisassociateDRTRole Operation</seealso>
        DisassociateDRTRoleResponse DisassociateDRTRole(DisassociateDRTRoleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDRTRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTRole">REST API Reference for DisassociateDRTRole Operation</seealso>
        Task<DisassociateDRTRoleResponse> DisassociateDRTRoleAsync(DisassociateDRTRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSubscriptionState


        /// <summary>
        /// Returns the <code>SubscriptionState</code>, either <code>Active</code> or <code>Inactive</code>.
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
        /// Initiates the asynchronous execution of the GetSubscriptionState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListAttacks">REST API Reference for ListAttacks Operation</seealso>
        ListAttacksResponse ListAttacks(ListAttacksRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListAttacks">REST API Reference for ListAttacks Operation</seealso>
        Task<ListAttacksResponse> ListAttacksAsync(ListAttacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProtections


        /// <summary>
        /// Lists all <a>Protection</a> objects for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtections service method.</param>
        /// 
        /// <returns>The response from the ListProtections service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the NextToken specified in the request is invalid. Submit
        /// the request using the NextToken value that was returned in the response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtections">REST API Reference for ListProtections Operation</seealso>
        ListProtectionsResponse ListProtections(ListProtectionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListProtections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtections">REST API Reference for ListProtections Operation</seealso>
        Task<ListProtectionsResponse> ListProtectionsAsync(ListProtectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEmergencyContactSettings


        /// <summary>
        /// Updates the details of the list of email addresses that the DRT can use to contact
        /// you during a suspected attack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmergencyContactSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateEmergencyContactSettings">REST API Reference for UpdateEmergencyContactSettings Operation</seealso>
        UpdateEmergencyContactSettingsResponse UpdateEmergencyContactSettings(UpdateEmergencyContactSettingsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmergencyContactSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmergencyContactSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateEmergencyContactSettings">REST API Reference for UpdateEmergencyContactSettings Operation</seealso>
        Task<UpdateEmergencyContactSettingsResponse> UpdateEmergencyContactSettingsAsync(UpdateEmergencyContactSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSubscription


        /// <summary>
        /// Updates the details of an existing subscription. Only enter values for parameters
        /// you want to change. Empty parameters are not updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// You are trying to update a subscription that has not yet completed the 1-year commitment.
        /// You can change the <code>AutoRenew</code> parameter during the last 30 days of your
        /// subscription. This exception indicates that you are attempting to change <code>AutoRenew</code>
        /// prior to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}