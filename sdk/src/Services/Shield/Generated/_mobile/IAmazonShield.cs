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
        /// Initiates the asynchronous execution of the AssociateDRTLogBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTLogBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        Task<AssociateDRTLogBucketResponse> AssociateDRTLogBucketAsync(AssociateDRTLogBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateDRTRole


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
        Task<AssociateDRTRoleResponse> AssociateDRTRoleAsync(AssociateDRTRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProtection


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
        Task<CreateProtectionResponse> CreateProtectionAsync(CreateProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSubscription


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
        Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProtection


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
        Task<DeleteProtectionResponse> DeleteProtectionAsync(DeleteProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSubscription


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
        Task<DeleteSubscriptionResponse> DeleteSubscriptionAsync(DeleteSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAttack


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
        Task<DescribeAttackResponse> DescribeAttackAsync(DescribeAttackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDRTAccess


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
        Task<DescribeDRTAccessResponse> DescribeDRTAccessAsync(DescribeDRTAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEmergencyContactSettings


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
        Task<DescribeEmergencyContactSettingsResponse> DescribeEmergencyContactSettingsAsync(DescribeEmergencyContactSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProtection


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
        Task<DescribeProtectionResponse> DescribeProtectionAsync(DescribeProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSubscription


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
        Task<DescribeSubscriptionResponse> DescribeSubscriptionAsync(DescribeSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateDRTLogBucket


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
        Task<DisassociateDRTLogBucketResponse> DisassociateDRTLogBucketAsync(DisassociateDRTLogBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateDRTRole


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
        Task<DisassociateDRTRoleResponse> DisassociateDRTRoleAsync(DisassociateDRTRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSubscriptionState


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
        Task<GetSubscriptionStateResponse> GetSubscriptionStateAsync(GetSubscriptionStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttacks


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
        Task<ListAttacksResponse> ListAttacksAsync(ListAttacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProtections


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
        Task<ListProtectionsResponse> ListProtectionsAsync(ListProtectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEmergencyContactSettings


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
        Task<UpdateEmergencyContactSettingsResponse> UpdateEmergencyContactSettingsAsync(UpdateEmergencyContactSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSubscription


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
        Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}