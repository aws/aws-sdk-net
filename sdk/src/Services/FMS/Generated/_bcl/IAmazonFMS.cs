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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.FMS.Model;

#pragma warning disable CS1570
namespace Amazon.FMS
{
    /// <summary>
    /// <para>Interface for accessing FMS</para>
    ///
    /// This is the <i>Firewall Manager API Reference</i>. This guide is for developers who
    /// need detailed information about the Firewall Manager API actions, data types, and
    /// errors. For detailed information about Firewall Manager features, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-chapter.html">Firewall
    /// Manager Developer Guide</a>.
    /// 
    ///  
    /// <para>
    /// Some API actions require explicit resource permissions. For information, see the developer
    /// guide topic <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-security_iam_service-with-iam.html#fms-security_iam_service-with-iam-roles-service">Service
    /// roles for Firewall Manager</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonFMS : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IFMSPaginatorFactory Paginators { get; }

        
        #region  AssociateAdminAccount


        /// <summary>
        /// Sets a Firewall Manager default administrator account. The Firewall Manager default
        /// administrator account can manage third-party firewalls and has full administrative
        /// scope that allows administration of all policy types, accounts, organizational units,
        /// and Regions. This account must be a member account of the organization in Organizations
        /// whose resources you want to protect.
        /// 
        ///  
        /// <para>
        /// For information about working with Firewall Manager administrator accounts, see <a
        /// href="https://docs.aws.amazon.com/organizations/latest/userguide/fms-administrators.html">Managing
        /// Firewall Manager administrators</a> in the <i>Firewall Manager Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAdminAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateAdminAccount">REST API Reference for AssociateAdminAccount Operation</seealso>
        AssociateAdminAccountResponse AssociateAdminAccount(AssociateAdminAccountRequest request);



        /// <summary>
        /// Sets a Firewall Manager default administrator account. The Firewall Manager default
        /// administrator account can manage third-party firewalls and has full administrative
        /// scope that allows administration of all policy types, accounts, organizational units,
        /// and Regions. This account must be a member account of the organization in Organizations
        /// whose resources you want to protect.
        /// 
        ///  
        /// <para>
        /// For information about working with Firewall Manager administrator accounts, see <a
        /// href="https://docs.aws.amazon.com/organizations/latest/userguide/fms-administrators.html">Managing
        /// Firewall Manager administrators</a> in the <i>Firewall Manager Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateAdminAccount">REST API Reference for AssociateAdminAccount Operation</seealso>
        Task<AssociateAdminAccountResponse> AssociateAdminAccountAsync(AssociateAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateThirdPartyFirewall


        /// <summary>
        /// Sets the Firewall Manager policy administrator as a tenant administrator of a third-party
        /// firewall service. A tenant is an instance of the third-party firewall service that's
        /// associated with your Amazon Web Services customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateThirdPartyFirewall service method.</param>
        /// 
        /// <returns>The response from the AssociateThirdPartyFirewall service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateThirdPartyFirewall">REST API Reference for AssociateThirdPartyFirewall Operation</seealso>
        AssociateThirdPartyFirewallResponse AssociateThirdPartyFirewall(AssociateThirdPartyFirewallRequest request);



        /// <summary>
        /// Sets the Firewall Manager policy administrator as a tenant administrator of a third-party
        /// firewall service. A tenant is an instance of the third-party firewall service that's
        /// associated with your Amazon Web Services customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateThirdPartyFirewall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateThirdPartyFirewall service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateThirdPartyFirewall">REST API Reference for AssociateThirdPartyFirewall Operation</seealso>
        Task<AssociateThirdPartyFirewallResponse> AssociateThirdPartyFirewallAsync(AssociateThirdPartyFirewallRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchAssociateResource


        /// <summary>
        /// Associate resources to a Firewall Manager resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateResource service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchAssociateResource">REST API Reference for BatchAssociateResource Operation</seealso>
        BatchAssociateResourceResponse BatchAssociateResource(BatchAssociateResourceRequest request);



        /// <summary>
        /// Associate resources to a Firewall Manager resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchAssociateResource">REST API Reference for BatchAssociateResource Operation</seealso>
        Task<BatchAssociateResourceResponse> BatchAssociateResourceAsync(BatchAssociateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDisassociateResource


        /// <summary>
        /// Disassociates resources from a Firewall Manager resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateResource service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchDisassociateResource">REST API Reference for BatchDisassociateResource Operation</seealso>
        BatchDisassociateResourceResponse BatchDisassociateResource(BatchDisassociateResourceRequest request);



        /// <summary>
        /// Disassociates resources from a Firewall Manager resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchDisassociateResource">REST API Reference for BatchDisassociateResource Operation</seealso>
        Task<BatchDisassociateResourceResponse> BatchDisassociateResourceAsync(BatchDisassociateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAppsList


        /// <summary>
        /// Permanently deletes an Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppsList service method.</param>
        /// 
        /// <returns>The response from the DeleteAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteAppsList">REST API Reference for DeleteAppsList Operation</seealso>
        DeleteAppsListResponse DeleteAppsList(DeleteAppsListRequest request);



        /// <summary>
        /// Permanently deletes an Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteAppsList">REST API Reference for DeleteAppsList Operation</seealso>
        Task<DeleteAppsListResponse> DeleteAppsListAsync(DeleteAppsListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNotificationChannel


        /// <summary>
        /// Deletes an Firewall Manager association with the IAM role and the Amazon Simple Notification
        /// Service (SNS) topic that is used to record Firewall Manager SNS logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteNotificationChannel">REST API Reference for DeleteNotificationChannel Operation</seealso>
        DeleteNotificationChannelResponse DeleteNotificationChannel(DeleteNotificationChannelRequest request);



        /// <summary>
        /// Deletes an Firewall Manager association with the IAM role and the Amazon Simple Notification
        /// Service (SNS) topic that is used to record Firewall Manager SNS logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteNotificationChannel">REST API Reference for DeleteNotificationChannel Operation</seealso>
        Task<DeleteNotificationChannelResponse> DeleteNotificationChannelAsync(DeleteNotificationChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Permanently deletes an Firewall Manager policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);



        /// <summary>
        /// Permanently deletes an Firewall Manager policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProtocolsList


        /// <summary>
        /// Permanently deletes an Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtocolsList service method.</param>
        /// 
        /// <returns>The response from the DeleteProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteProtocolsList">REST API Reference for DeleteProtocolsList Operation</seealso>
        DeleteProtocolsListResponse DeleteProtocolsList(DeleteProtocolsListRequest request);



        /// <summary>
        /// Permanently deletes an Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtocolsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteProtocolsList">REST API Reference for DeleteProtocolsList Operation</seealso>
        Task<DeleteProtocolsListResponse> DeleteProtocolsListAsync(DeleteProtocolsListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourceSet


        /// <summary>
        /// Deletes the specified <a>ResourceSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSet service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceSet service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        DeleteResourceSetResponse DeleteResourceSet(DeleteResourceSetRequest request);



        /// <summary>
        /// Deletes the specified <a>ResourceSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourceSet service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        Task<DeleteResourceSetResponse> DeleteResourceSetAsync(DeleteResourceSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateAdminAccount


        /// <summary>
        /// Disassociates an Firewall Manager administrator account. To set a different account
        /// as an Firewall Manager administrator, submit a <a>PutAdminAccount</a> request. To
        /// set an account as a default administrator account, you must submit an <a>AssociateAdminAccount</a>
        /// request.
        /// 
        ///  
        /// <para>
        /// Disassociation of the default administrator account follows the first in, last out
        /// principle. If you are the default administrator, all Firewall Manager administrators
        /// within the organization must first disassociate their accounts before you can disassociate
        /// your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateAdminAccount">REST API Reference for DisassociateAdminAccount Operation</seealso>
        DisassociateAdminAccountResponse DisassociateAdminAccount(DisassociateAdminAccountRequest request);



        /// <summary>
        /// Disassociates an Firewall Manager administrator account. To set a different account
        /// as an Firewall Manager administrator, submit a <a>PutAdminAccount</a> request. To
        /// set an account as a default administrator account, you must submit an <a>AssociateAdminAccount</a>
        /// request.
        /// 
        ///  
        /// <para>
        /// Disassociation of the default administrator account follows the first in, last out
        /// principle. If you are the default administrator, all Firewall Manager administrators
        /// within the organization must first disassociate their accounts before you can disassociate
        /// your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateAdminAccount">REST API Reference for DisassociateAdminAccount Operation</seealso>
        Task<DisassociateAdminAccountResponse> DisassociateAdminAccountAsync(DisassociateAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateThirdPartyFirewall


        /// <summary>
        /// Disassociates a Firewall Manager policy administrator from a third-party firewall
        /// tenant. When you call <c>DisassociateThirdPartyFirewall</c>, the third-party firewall
        /// vendor deletes all of the firewalls that are associated with the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateThirdPartyFirewall service method.</param>
        /// 
        /// <returns>The response from the DisassociateThirdPartyFirewall service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateThirdPartyFirewall">REST API Reference for DisassociateThirdPartyFirewall Operation</seealso>
        DisassociateThirdPartyFirewallResponse DisassociateThirdPartyFirewall(DisassociateThirdPartyFirewallRequest request);



        /// <summary>
        /// Disassociates a Firewall Manager policy administrator from a third-party firewall
        /// tenant. When you call <c>DisassociateThirdPartyFirewall</c>, the third-party firewall
        /// vendor deletes all of the firewalls that are associated with the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateThirdPartyFirewall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateThirdPartyFirewall service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateThirdPartyFirewall">REST API Reference for DisassociateThirdPartyFirewall Operation</seealso>
        Task<DisassociateThirdPartyFirewallResponse> DisassociateThirdPartyFirewallAsync(DisassociateThirdPartyFirewallRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAdminAccount


        /// <summary>
        /// Returns the Organizations account that is associated with Firewall Manager as the
        /// Firewall Manager default administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdminAccount service method.</param>
        /// 
        /// <returns>The response from the GetAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        GetAdminAccountResponse GetAdminAccount(GetAdminAccountRequest request);



        /// <summary>
        /// Returns the Organizations account that is associated with Firewall Manager as the
        /// Firewall Manager default administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        Task<GetAdminAccountResponse> GetAdminAccountAsync(GetAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAdminScope


        /// <summary>
        /// Returns information about the specified account's administrative scope. The administrative
        /// scope defines the resources that an Firewall Manager administrator can manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdminScope service method.</param>
        /// 
        /// <returns>The response from the GetAdminScope service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminScope">REST API Reference for GetAdminScope Operation</seealso>
        GetAdminScopeResponse GetAdminScope(GetAdminScopeRequest request);



        /// <summary>
        /// Returns information about the specified account's administrative scope. The administrative
        /// scope defines the resources that an Firewall Manager administrator can manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdminScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAdminScope service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminScope">REST API Reference for GetAdminScope Operation</seealso>
        Task<GetAdminScopeResponse> GetAdminScopeAsync(GetAdminScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAppsList


        /// <summary>
        /// Returns information about the specified Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppsList service method.</param>
        /// 
        /// <returns>The response from the GetAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAppsList">REST API Reference for GetAppsList Operation</seealso>
        GetAppsListResponse GetAppsList(GetAppsListRequest request);



        /// <summary>
        /// Returns information about the specified Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAppsList">REST API Reference for GetAppsList Operation</seealso>
        Task<GetAppsListResponse> GetAppsListAsync(GetAppsListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetComplianceDetail


        /// <summary>
        /// Returns detailed compliance information about the specified member account. Details
        /// include resources that are in and out of compliance with the specified policy. 
        /// 
        ///  
        /// <para>
        /// The reasons for resources being considered compliant depend on the Firewall Manager
        /// policy type. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetail service method.</param>
        /// 
        /// <returns>The response from the GetComplianceDetail service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetComplianceDetail">REST API Reference for GetComplianceDetail Operation</seealso>
        GetComplianceDetailResponse GetComplianceDetail(GetComplianceDetailRequest request);



        /// <summary>
        /// Returns detailed compliance information about the specified member account. Details
        /// include resources that are in and out of compliance with the specified policy. 
        /// 
        ///  
        /// <para>
        /// The reasons for resources being considered compliant depend on the Firewall Manager
        /// policy type. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComplianceDetail service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetComplianceDetail">REST API Reference for GetComplianceDetail Operation</seealso>
        Task<GetComplianceDetailResponse> GetComplianceDetailAsync(GetComplianceDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNotificationChannel


        /// <summary>
        /// Information about the Amazon Simple Notification Service (SNS) topic that is used
        /// to record Firewall Manager SNS logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the GetNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetNotificationChannel">REST API Reference for GetNotificationChannel Operation</seealso>
        GetNotificationChannelResponse GetNotificationChannel(GetNotificationChannelRequest request);



        /// <summary>
        /// Information about the Amazon Simple Notification Service (SNS) topic that is used
        /// to record Firewall Manager SNS logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetNotificationChannel">REST API Reference for GetNotificationChannel Operation</seealso>
        Task<GetNotificationChannelResponse> GetNotificationChannelAsync(GetNotificationChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Returns information about the specified Firewall Manager policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidTypeException">
        /// The value of the <c>Type</c> parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);



        /// <summary>
        /// Returns information about the specified Firewall Manager policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidTypeException">
        /// The value of the <c>Type</c> parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetProtectionStatus


        /// <summary>
        /// If you created a Shield Advanced policy, returns policy-level attack summary information
        /// in the event of a potential DDoS attack. Other policy types are currently unsupported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectionStatus service method.</param>
        /// 
        /// <returns>The response from the GetProtectionStatus service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtectionStatus">REST API Reference for GetProtectionStatus Operation</seealso>
        GetProtectionStatusResponse GetProtectionStatus(GetProtectionStatusRequest request);



        /// <summary>
        /// If you created a Shield Advanced policy, returns policy-level attack summary information
        /// in the event of a potential DDoS attack. Other policy types are currently unsupported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProtectionStatus service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtectionStatus">REST API Reference for GetProtectionStatus Operation</seealso>
        Task<GetProtectionStatusResponse> GetProtectionStatusAsync(GetProtectionStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetProtocolsList


        /// <summary>
        /// Returns information about the specified Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtocolsList service method.</param>
        /// 
        /// <returns>The response from the GetProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtocolsList">REST API Reference for GetProtocolsList Operation</seealso>
        GetProtocolsListResponse GetProtocolsList(GetProtocolsListRequest request);



        /// <summary>
        /// Returns information about the specified Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtocolsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtocolsList">REST API Reference for GetProtocolsList Operation</seealso>
        Task<GetProtocolsListResponse> GetProtocolsListAsync(GetProtocolsListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourceSet


        /// <summary>
        /// Gets information about a specific resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSet service method.</param>
        /// 
        /// <returns>The response from the GetResourceSet service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        GetResourceSetResponse GetResourceSet(GetResourceSetRequest request);



        /// <summary>
        /// Gets information about a specific resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceSet service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        Task<GetResourceSetResponse> GetResourceSetAsync(GetResourceSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetThirdPartyFirewallAssociationStatus


        /// <summary>
        /// The onboarding status of a Firewall Manager admin account to third-party firewall
        /// vendor tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyFirewallAssociationStatus service method.</param>
        /// 
        /// <returns>The response from the GetThirdPartyFirewallAssociationStatus service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetThirdPartyFirewallAssociationStatus">REST API Reference for GetThirdPartyFirewallAssociationStatus Operation</seealso>
        GetThirdPartyFirewallAssociationStatusResponse GetThirdPartyFirewallAssociationStatus(GetThirdPartyFirewallAssociationStatusRequest request);



        /// <summary>
        /// The onboarding status of a Firewall Manager admin account to third-party firewall
        /// vendor tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyFirewallAssociationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetThirdPartyFirewallAssociationStatus service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetThirdPartyFirewallAssociationStatus">REST API Reference for GetThirdPartyFirewallAssociationStatus Operation</seealso>
        Task<GetThirdPartyFirewallAssociationStatusResponse> GetThirdPartyFirewallAssociationStatusAsync(GetThirdPartyFirewallAssociationStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetViolationDetails


        /// <summary>
        /// Retrieves violations for a resource based on the specified Firewall Manager policy
        /// and Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetViolationDetails service method.</param>
        /// 
        /// <returns>The response from the GetViolationDetails service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetViolationDetails">REST API Reference for GetViolationDetails Operation</seealso>
        GetViolationDetailsResponse GetViolationDetails(GetViolationDetailsRequest request);



        /// <summary>
        /// Retrieves violations for a resource based on the specified Firewall Manager policy
        /// and Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetViolationDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetViolationDetails service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetViolationDetails">REST API Reference for GetViolationDetails Operation</seealso>
        Task<GetViolationDetailsResponse> GetViolationDetailsAsync(GetViolationDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAdminAccountsForOrganization


        /// <summary>
        /// Returns a <c>AdminAccounts</c> object that lists the Firewall Manager administrators
        /// within the organization that are onboarded to Firewall Manager by <a>AssociateAdminAccount</a>.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdminAccountsForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListAdminAccountsForOrganization service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAdminAccountsForOrganization">REST API Reference for ListAdminAccountsForOrganization Operation</seealso>
        ListAdminAccountsForOrganizationResponse ListAdminAccountsForOrganization(ListAdminAccountsForOrganizationRequest request);



        /// <summary>
        /// Returns a <c>AdminAccounts</c> object that lists the Firewall Manager administrators
        /// within the organization that are onboarded to Firewall Manager by <a>AssociateAdminAccount</a>.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdminAccountsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAdminAccountsForOrganization service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAdminAccountsForOrganization">REST API Reference for ListAdminAccountsForOrganization Operation</seealso>
        Task<ListAdminAccountsForOrganizationResponse> ListAdminAccountsForOrganizationAsync(ListAdminAccountsForOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAdminsManagingAccount


        /// <summary>
        /// Lists the accounts that are managing the specified Organizations member account. This
        /// is useful for any member account so that they can view the accounts who are managing
        /// their account. This operation only returns the managing administrators that have the
        /// requested account within their <a>AdminScope</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdminsManagingAccount service method.</param>
        /// 
        /// <returns>The response from the ListAdminsManagingAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAdminsManagingAccount">REST API Reference for ListAdminsManagingAccount Operation</seealso>
        ListAdminsManagingAccountResponse ListAdminsManagingAccount(ListAdminsManagingAccountRequest request);



        /// <summary>
        /// Lists the accounts that are managing the specified Organizations member account. This
        /// is useful for any member account so that they can view the accounts who are managing
        /// their account. This operation only returns the managing administrators that have the
        /// requested account within their <a>AdminScope</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdminsManagingAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAdminsManagingAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAdminsManagingAccount">REST API Reference for ListAdminsManagingAccount Operation</seealso>
        Task<ListAdminsManagingAccountResponse> ListAdminsManagingAccountAsync(ListAdminsManagingAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAppsLists


        /// <summary>
        /// Returns an array of <c>AppsListDataSummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppsLists service method.</param>
        /// 
        /// <returns>The response from the ListAppsLists service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAppsLists">REST API Reference for ListAppsLists Operation</seealso>
        ListAppsListsResponse ListAppsLists(ListAppsListsRequest request);



        /// <summary>
        /// Returns an array of <c>AppsListDataSummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppsLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppsLists service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAppsLists">REST API Reference for ListAppsLists Operation</seealso>
        Task<ListAppsListsResponse> ListAppsListsAsync(ListAppsListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListComplianceStatus


        /// <summary>
        /// Returns an array of <c>PolicyComplianceStatus</c> objects. Use <c>PolicyComplianceStatus</c>
        /// to get a summary of which member accounts are protected by the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceStatus service method.</param>
        /// 
        /// <returns>The response from the ListComplianceStatus service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListComplianceStatus">REST API Reference for ListComplianceStatus Operation</seealso>
        ListComplianceStatusResponse ListComplianceStatus(ListComplianceStatusRequest request);



        /// <summary>
        /// Returns an array of <c>PolicyComplianceStatus</c> objects. Use <c>PolicyComplianceStatus</c>
        /// to get a summary of which member accounts are protected by the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComplianceStatus service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListComplianceStatus">REST API Reference for ListComplianceStatus Operation</seealso>
        Task<ListComplianceStatusResponse> ListComplianceStatusAsync(ListComplianceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDiscoveredResources


        /// <summary>
        /// Returns an array of resources in the organization's accounts that are available to
        /// be associated with a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources service method.</param>
        /// 
        /// <returns>The response from the ListDiscoveredResources service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request);



        /// <summary>
        /// Returns an array of resources in the organization's accounts that are available to
        /// be associated with a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoveredResources service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesAsync(ListDiscoveredResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMemberAccounts


        /// <summary>
        /// Returns a <c>MemberAccounts</c> object that lists the member accounts in the administrator's
        /// Amazon Web Services organization.
        /// 
        ///  
        /// <para>
        /// Either an Firewall Manager administrator or the organization's management account
        /// can make this request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
        /// 
        /// <returns>The response from the ListMemberAccounts service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        ListMemberAccountsResponse ListMemberAccounts(ListMemberAccountsRequest request);



        /// <summary>
        /// Returns a <c>MemberAccounts</c> object that lists the member accounts in the administrator's
        /// Amazon Web Services organization.
        /// 
        ///  
        /// <para>
        /// Either an Firewall Manager administrator or the organization's management account
        /// can make this request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberAccounts service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        Task<ListMemberAccountsResponse> ListMemberAccountsAsync(ListMemberAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Returns an array of <c>PolicySummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse ListPolicies(ListPoliciesRequest request);



        /// <summary>
        /// Returns an array of <c>PolicySummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProtocolsLists


        /// <summary>
        /// Returns an array of <c>ProtocolsListDataSummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtocolsLists service method.</param>
        /// 
        /// <returns>The response from the ListProtocolsLists service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListProtocolsLists">REST API Reference for ListProtocolsLists Operation</seealso>
        ListProtocolsListsResponse ListProtocolsLists(ListProtocolsListsRequest request);



        /// <summary>
        /// Returns an array of <c>ProtocolsListDataSummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtocolsLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtocolsLists service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListProtocolsLists">REST API Reference for ListProtocolsLists Operation</seealso>
        Task<ListProtocolsListsResponse> ListProtocolsListsAsync(ListProtocolsListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceSetResources


        /// <summary>
        /// Returns an array of resources that are currently associated to a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSetResources service method.</param>
        /// 
        /// <returns>The response from the ListResourceSetResources service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSetResources">REST API Reference for ListResourceSetResources Operation</seealso>
        ListResourceSetResourcesResponse ListResourceSetResources(ListResourceSetResourcesRequest request);



        /// <summary>
        /// Returns an array of resources that are currently associated to a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSetResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceSetResources service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSetResources">REST API Reference for ListResourceSetResources Operation</seealso>
        Task<ListResourceSetResourcesResponse> ListResourceSetResourcesAsync(ListResourceSetResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceSets


        /// <summary>
        /// Returns an array of <c>ResourceSetSummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSets service method.</param>
        /// 
        /// <returns>The response from the ListResourceSets service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        ListResourceSetsResponse ListResourceSets(ListResourceSetsRequest request);



        /// <summary>
        /// Returns an array of <c>ResourceSetSummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceSets service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        Task<ListResourceSetsResponse> ListResourceSetsAsync(ListResourceSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves the list of tags for the specified Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Retrieves the list of tags for the specified Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThirdPartyFirewallFirewallPolicies


        /// <summary>
        /// Retrieves a list of all of the third-party firewall policies that are associated with
        /// the third-party firewall administrator's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThirdPartyFirewallFirewallPolicies service method.</param>
        /// 
        /// <returns>The response from the ListThirdPartyFirewallFirewallPolicies service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListThirdPartyFirewallFirewallPolicies">REST API Reference for ListThirdPartyFirewallFirewallPolicies Operation</seealso>
        ListThirdPartyFirewallFirewallPoliciesResponse ListThirdPartyFirewallFirewallPolicies(ListThirdPartyFirewallFirewallPoliciesRequest request);



        /// <summary>
        /// Retrieves a list of all of the third-party firewall policies that are associated with
        /// the third-party firewall administrator's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThirdPartyFirewallFirewallPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThirdPartyFirewallFirewallPolicies service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListThirdPartyFirewallFirewallPolicies">REST API Reference for ListThirdPartyFirewallFirewallPolicies Operation</seealso>
        Task<ListThirdPartyFirewallFirewallPoliciesResponse> ListThirdPartyFirewallFirewallPoliciesAsync(ListThirdPartyFirewallFirewallPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAdminAccount


        /// <summary>
        /// Creates or updates an Firewall Manager administrator account. The account must be
        /// a member of the organization that was onboarded to Firewall Manager by <a>AssociateAdminAccount</a>.
        /// Only the organization's management account can create an Firewall Manager administrator
        /// account. When you create an Firewall Manager administrator account, the service checks
        /// to see if the account is already a delegated administrator within Organizations. If
        /// the account isn't a delegated administrator, Firewall Manager calls Organizations
        /// to delegate the account within Organizations. For more information about administrator
        /// accounts within Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts.html">Managing
        /// the Amazon Web Services Accounts in Your Organization</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAdminAccount service method.</param>
        /// 
        /// <returns>The response from the PutAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAdminAccount">REST API Reference for PutAdminAccount Operation</seealso>
        PutAdminAccountResponse PutAdminAccount(PutAdminAccountRequest request);



        /// <summary>
        /// Creates or updates an Firewall Manager administrator account. The account must be
        /// a member of the organization that was onboarded to Firewall Manager by <a>AssociateAdminAccount</a>.
        /// Only the organization's management account can create an Firewall Manager administrator
        /// account. When you create an Firewall Manager administrator account, the service checks
        /// to see if the account is already a delegated administrator within Organizations. If
        /// the account isn't a delegated administrator, Firewall Manager calls Organizations
        /// to delegate the account within Organizations. For more information about administrator
        /// accounts within Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts.html">Managing
        /// the Amazon Web Services Accounts in Your Organization</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAdminAccount">REST API Reference for PutAdminAccount Operation</seealso>
        Task<PutAdminAccountResponse> PutAdminAccountAsync(PutAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAppsList


        /// <summary>
        /// Creates an Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppsList service method.</param>
        /// 
        /// <returns>The response from the PutAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAppsList">REST API Reference for PutAppsList Operation</seealso>
        PutAppsListResponse PutAppsList(PutAppsListRequest request);



        /// <summary>
        /// Creates an Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAppsList">REST API Reference for PutAppsList Operation</seealso>
        Task<PutAppsListResponse> PutAppsListAsync(PutAppsListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutNotificationChannel


        /// <summary>
        /// Designates the IAM role and Amazon Simple Notification Service (SNS) topic that Firewall
        /// Manager uses to record SNS logs.
        /// 
        ///  
        /// <para>
        /// To perform this action outside of the console, you must first configure the SNS topic's
        /// access policy to allow the <c>SnsRoleName</c> to publish SNS logs. If the <c>SnsRoleName</c>
        /// provided is a role other than the <c>AWSServiceRoleForFMS</c> service-linked role,
        /// this role must have a trust relationship configured to allow the Firewall Manager
        /// service principal <c>fms.amazonaws.com</c> to assume this role. For information about
        /// configuring an SNS access policy, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-security_iam_service-with-iam.html#fms-security_iam_service-with-iam-roles-service">Service
        /// roles for Firewall Manager</a> in the <i>Firewall Manager Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the PutNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutNotificationChannel">REST API Reference for PutNotificationChannel Operation</seealso>
        PutNotificationChannelResponse PutNotificationChannel(PutNotificationChannelRequest request);



        /// <summary>
        /// Designates the IAM role and Amazon Simple Notification Service (SNS) topic that Firewall
        /// Manager uses to record SNS logs.
        /// 
        ///  
        /// <para>
        /// To perform this action outside of the console, you must first configure the SNS topic's
        /// access policy to allow the <c>SnsRoleName</c> to publish SNS logs. If the <c>SnsRoleName</c>
        /// provided is a role other than the <c>AWSServiceRoleForFMS</c> service-linked role,
        /// this role must have a trust relationship configured to allow the Firewall Manager
        /// service principal <c>fms.amazonaws.com</c> to assume this role. For information about
        /// configuring an SNS access policy, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-security_iam_service-with-iam.html#fms-security_iam_service-with-iam-roles-service">Service
        /// roles for Firewall Manager</a> in the <i>Firewall Manager Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutNotificationChannel">REST API Reference for PutNotificationChannel Operation</seealso>
        Task<PutNotificationChannelResponse> PutNotificationChannelAsync(PutNotificationChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutPolicy


        /// <summary>
        /// Creates an Firewall Manager policy.
        /// 
        ///  
        /// <para>
        /// A Firewall Manager policy is specific to the individual policy type. If you want to
        /// enforce multiple policy types across accounts, you can create multiple policies. You
        /// can create more than one policy for each type. 
        /// </para>
        ///  
        /// <para>
        /// If you add a new account to an organization that you created with Organizations, Firewall
        /// Manager automatically applies the policy to the resources in that account that are
        /// within scope of the policy. 
        /// </para>
        ///  
        /// <para>
        /// Firewall Manager provides the following types of policies: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>WAF policy</b> - This policy applies WAF web ACL protections to specified accounts
        /// and resources. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Shield Advanced policy</b> - This policy applies Shield Advanced protection to
        /// specified accounts and resources. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Security Groups policy</b> - This type of policy gives you control over security
        /// groups that are in use throughout your organization in Organizations and lets you
        /// enforce a baseline set of rules across your organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Network ACL policy</b> - This type of policy gives you control over the network
        /// ACLs that are in use throughout your organization in Organizations and lets you enforce
        /// a baseline set of first and last network ACL rules across your organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Network Firewall policy</b> - This policy applies Network Firewall protection
        /// to your organization's VPCs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DNS Firewall policy</b> - This policy applies Amazon Route 53 Resolver DNS Firewall
        /// protections to your organization's VPCs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Third-party firewall policy</b> - This policy applies third-party firewall protections.
        /// Third-party firewalls are available by subscription through the Amazon Web Services
        /// Marketplace console at <a href="http://aws.amazon.com/marketplace">Amazon Web Services
        /// Marketplace</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Palo Alto Networks Cloud NGFW policy</b> - This policy applies Palo Alto Networks
        /// Cloud Next Generation Firewall (NGFW) protections and Palo Alto Networks Cloud NGFW
        /// rulestacks to your organization's VPCs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Fortigate CNF policy</b> - This policy applies Fortigate Cloud Native Firewall
        /// (CNF) protections. Fortigate CNF is a cloud-centered solution that blocks Zero-Day
        /// threats and secures cloud infrastructures with industry-leading advanced threat prevention,
        /// smart web application firewalls (WAF), and API protection.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
        /// 
        /// <returns>The response from the PutPolicy service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidTypeException">
        /// The value of the <c>Type</c> parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        PutPolicyResponse PutPolicy(PutPolicyRequest request);



        /// <summary>
        /// Creates an Firewall Manager policy.
        /// 
        ///  
        /// <para>
        /// A Firewall Manager policy is specific to the individual policy type. If you want to
        /// enforce multiple policy types across accounts, you can create multiple policies. You
        /// can create more than one policy for each type. 
        /// </para>
        ///  
        /// <para>
        /// If you add a new account to an organization that you created with Organizations, Firewall
        /// Manager automatically applies the policy to the resources in that account that are
        /// within scope of the policy. 
        /// </para>
        ///  
        /// <para>
        /// Firewall Manager provides the following types of policies: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>WAF policy</b> - This policy applies WAF web ACL protections to specified accounts
        /// and resources. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Shield Advanced policy</b> - This policy applies Shield Advanced protection to
        /// specified accounts and resources. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Security Groups policy</b> - This type of policy gives you control over security
        /// groups that are in use throughout your organization in Organizations and lets you
        /// enforce a baseline set of rules across your organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Network ACL policy</b> - This type of policy gives you control over the network
        /// ACLs that are in use throughout your organization in Organizations and lets you enforce
        /// a baseline set of first and last network ACL rules across your organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Network Firewall policy</b> - This policy applies Network Firewall protection
        /// to your organization's VPCs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DNS Firewall policy</b> - This policy applies Amazon Route 53 Resolver DNS Firewall
        /// protections to your organization's VPCs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Third-party firewall policy</b> - This policy applies third-party firewall protections.
        /// Third-party firewalls are available by subscription through the Amazon Web Services
        /// Marketplace console at <a href="http://aws.amazon.com/marketplace">Amazon Web Services
        /// Marketplace</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Palo Alto Networks Cloud NGFW policy</b> - This policy applies Palo Alto Networks
        /// Cloud Next Generation Firewall (NGFW) protections and Palo Alto Networks Cloud NGFW
        /// rulestacks to your organization's VPCs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Fortigate CNF policy</b> - This policy applies Fortigate Cloud Native Firewall
        /// (CNF) protections. Fortigate CNF is a cloud-centered solution that blocks Zero-Day
        /// threats and secures cloud infrastructures with industry-leading advanced threat prevention,
        /// smart web application firewalls (WAF), and API protection.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPolicy service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidTypeException">
        /// The value of the <c>Type</c> parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        Task<PutPolicyResponse> PutPolicyAsync(PutPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutProtocolsList


        /// <summary>
        /// Creates an Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProtocolsList service method.</param>
        /// 
        /// <returns>The response from the PutProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutProtocolsList">REST API Reference for PutProtocolsList Operation</seealso>
        PutProtocolsListResponse PutProtocolsList(PutProtocolsListRequest request);



        /// <summary>
        /// Creates an Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProtocolsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutProtocolsList">REST API Reference for PutProtocolsList Operation</seealso>
        Task<PutProtocolsListResponse> PutProtocolsListAsync(PutProtocolsListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourceSet


        /// <summary>
        /// Creates the resource set.
        /// 
        ///  
        /// <para>
        /// An Firewall Manager resource set defines the resources to import into an Firewall
        /// Manager policy from another Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourceSet service method.</param>
        /// 
        /// <returns>The response from the PutResourceSet service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutResourceSet">REST API Reference for PutResourceSet Operation</seealso>
        PutResourceSetResponse PutResourceSet(PutResourceSetRequest request);



        /// <summary>
        /// Creates the resource set.
        /// 
        ///  
        /// <para>
        /// An Firewall Manager resource set defines the resources to import into an Firewall
        /// Manager policy from another Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourceSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourceSet service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutResourceSet">REST API Reference for PutResourceSet Operation</seealso>
        Task<PutResourceSetResponse> PutResourceSetAsync(PutResourceSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds one or more tags to an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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