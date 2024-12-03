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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LicenseManagerUserSubscriptions.Model;

#pragma warning disable CS1570
namespace Amazon.LicenseManagerUserSubscriptions
{
    /// <summary>
    /// <para>Interface for accessing LicenseManagerUserSubscriptions</para>
    ///
    /// With License Manager, you can create user-based subscriptions to utilize licensed
    /// software with a per user subscription fee on Amazon EC2 instances.
    /// </summary>
    public partial interface IAmazonLicenseManagerUserSubscriptions : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILicenseManagerUserSubscriptionsPaginatorFactory Paginators { get; }

        
        #region  AssociateUser


        /// <summary>
        /// Associates the user to an EC2 instance to utilize user-based subscriptions.
        /// 
        ///  <note> 
        /// <para>
        /// Your estimated bill for charges on the number of users and related costs will take
        /// 48 hours to appear for billing periods that haven't closed (marked as <b>Pending</b>
        /// billing status) in Amazon Web Services Billing. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/invoice.html">Viewing
        /// your monthly charges</a> in the <i>Amazon Web Services Billing User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUser service method.</param>
        /// 
        /// <returns>The response from the AssociateUser service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/AssociateUser">REST API Reference for AssociateUser Operation</seealso>
        AssociateUserResponse AssociateUser(AssociateUserRequest request);



        /// <summary>
        /// Associates the user to an EC2 instance to utilize user-based subscriptions.
        /// 
        ///  <note> 
        /// <para>
        /// Your estimated bill for charges on the number of users and related costs will take
        /// 48 hours to appear for billing periods that haven't closed (marked as <b>Pending</b>
        /// billing status) in Amazon Web Services Billing. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/invoice.html">Viewing
        /// your monthly charges</a> in the <i>Amazon Web Services Billing User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateUser service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/AssociateUser">REST API Reference for AssociateUser Operation</seealso>
        Task<AssociateUserResponse> AssociateUserAsync(AssociateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLicenseServerEndpoint


        /// <summary>
        /// Creates a network endpoint for the Remote Desktop Services (RDS) license server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseServerEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseServerEndpoint service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/CreateLicenseServerEndpoint">REST API Reference for CreateLicenseServerEndpoint Operation</seealso>
        CreateLicenseServerEndpointResponse CreateLicenseServerEndpoint(CreateLicenseServerEndpointRequest request);



        /// <summary>
        /// Creates a network endpoint for the Remote Desktop Services (RDS) license server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseServerEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseServerEndpoint service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/CreateLicenseServerEndpoint">REST API Reference for CreateLicenseServerEndpoint Operation</seealso>
        Task<CreateLicenseServerEndpointResponse> CreateLicenseServerEndpointAsync(CreateLicenseServerEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLicenseServerEndpoint


        /// <summary>
        /// Deletes a <c>LicenseServerEndpoint</c> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseServerEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteLicenseServerEndpoint service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DeleteLicenseServerEndpoint">REST API Reference for DeleteLicenseServerEndpoint Operation</seealso>
        DeleteLicenseServerEndpointResponse DeleteLicenseServerEndpoint(DeleteLicenseServerEndpointRequest request);



        /// <summary>
        /// Deletes a <c>LicenseServerEndpoint</c> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseServerEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLicenseServerEndpoint service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DeleteLicenseServerEndpoint">REST API Reference for DeleteLicenseServerEndpoint Operation</seealso>
        Task<DeleteLicenseServerEndpointResponse> DeleteLicenseServerEndpointAsync(DeleteLicenseServerEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterIdentityProvider


        /// <summary>
        /// Deregisters the Active Directory identity provider from License Manager user-based
        /// subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the DeregisterIdentityProvider service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DeregisterIdentityProvider">REST API Reference for DeregisterIdentityProvider Operation</seealso>
        DeregisterIdentityProviderResponse DeregisterIdentityProvider(DeregisterIdentityProviderRequest request);



        /// <summary>
        /// Deregisters the Active Directory identity provider from License Manager user-based
        /// subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterIdentityProvider service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DeregisterIdentityProvider">REST API Reference for DeregisterIdentityProvider Operation</seealso>
        Task<DeregisterIdentityProviderResponse> DeregisterIdentityProviderAsync(DeregisterIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateUser


        /// <summary>
        /// Disassociates the user from an EC2 instance providing user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUser service method.</param>
        /// 
        /// <returns>The response from the DisassociateUser service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DisassociateUser">REST API Reference for DisassociateUser Operation</seealso>
        DisassociateUserResponse DisassociateUser(DisassociateUserRequest request);



        /// <summary>
        /// Disassociates the user from an EC2 instance providing user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateUser service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DisassociateUser">REST API Reference for DisassociateUser Operation</seealso>
        Task<DisassociateUserResponse> DisassociateUserAsync(DisassociateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIdentityProviders


        /// <summary>
        /// Lists the Active Directory identity providers for user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders service method.</param>
        /// 
        /// <returns>The response from the ListIdentityProviders service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request);



        /// <summary>
        /// Lists the Active Directory identity providers for user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentityProviders service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInstances


        /// <summary>
        /// Lists the EC2 instances providing user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListInstances">REST API Reference for ListInstances Operation</seealso>
        ListInstancesResponse ListInstances(ListInstancesRequest request);



        /// <summary>
        /// Lists the EC2 instances providing user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListInstances">REST API Reference for ListInstances Operation</seealso>
        Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLicenseServerEndpoints


        /// <summary>
        /// List the Remote Desktop Services (RDS) License Server endpoints
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseServerEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListLicenseServerEndpoints service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListLicenseServerEndpoints">REST API Reference for ListLicenseServerEndpoints Operation</seealso>
        ListLicenseServerEndpointsResponse ListLicenseServerEndpoints(ListLicenseServerEndpointsRequest request);



        /// <summary>
        /// List the Remote Desktop Services (RDS) License Server endpoints
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseServerEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseServerEndpoints service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListLicenseServerEndpoints">REST API Reference for ListLicenseServerEndpoints Operation</seealso>
        Task<ListLicenseServerEndpointsResponse> ListLicenseServerEndpointsAsync(ListLicenseServerEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProductSubscriptions


        /// <summary>
        /// Lists the user-based subscription products available from an identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListProductSubscriptions service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListProductSubscriptions">REST API Reference for ListProductSubscriptions Operation</seealso>
        ListProductSubscriptionsResponse ListProductSubscriptions(ListProductSubscriptionsRequest request);



        /// <summary>
        /// Lists the user-based subscription products available from an identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProductSubscriptions service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListProductSubscriptions">REST API Reference for ListProductSubscriptions Operation</seealso>
        Task<ListProductSubscriptionsResponse> ListProductSubscriptionsAsync(ListProductSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns the list of tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns the list of tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserAssociations


        /// <summary>
        /// Lists user associations for an identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserAssociations service method.</param>
        /// 
        /// <returns>The response from the ListUserAssociations service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListUserAssociations">REST API Reference for ListUserAssociations Operation</seealso>
        ListUserAssociationsResponse ListUserAssociations(ListUserAssociationsRequest request);



        /// <summary>
        /// Lists user associations for an identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserAssociations service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListUserAssociations">REST API Reference for ListUserAssociations Operation</seealso>
        Task<ListUserAssociationsResponse> ListUserAssociationsAsync(ListUserAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterIdentityProvider


        /// <summary>
        /// Registers an identity provider for user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the RegisterIdentityProvider service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/RegisterIdentityProvider">REST API Reference for RegisterIdentityProvider Operation</seealso>
        RegisterIdentityProviderResponse RegisterIdentityProvider(RegisterIdentityProviderRequest request);



        /// <summary>
        /// Registers an identity provider for user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterIdentityProvider service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/RegisterIdentityProvider">REST API Reference for RegisterIdentityProvider Operation</seealso>
        Task<RegisterIdentityProviderResponse> RegisterIdentityProviderAsync(RegisterIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartProductSubscription


        /// <summary>
        /// Starts a product subscription for a user with the specified identity provider.
        /// 
        ///  <note> 
        /// <para>
        /// Your estimated bill for charges on the number of users and related costs will take
        /// 48 hours to appear for billing periods that haven't closed (marked as <b>Pending</b>
        /// billing status) in Amazon Web Services Billing. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/invoice.html">Viewing
        /// your monthly charges</a> in the <i>Amazon Web Services Billing User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProductSubscription service method.</param>
        /// 
        /// <returns>The response from the StartProductSubscription service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/StartProductSubscription">REST API Reference for StartProductSubscription Operation</seealso>
        StartProductSubscriptionResponse StartProductSubscription(StartProductSubscriptionRequest request);



        /// <summary>
        /// Starts a product subscription for a user with the specified identity provider.
        /// 
        ///  <note> 
        /// <para>
        /// Your estimated bill for charges on the number of users and related costs will take
        /// 48 hours to appear for billing periods that haven't closed (marked as <b>Pending</b>
        /// billing status) in Amazon Web Services Billing. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/invoice.html">Viewing
        /// your monthly charges</a> in the <i>Amazon Web Services Billing User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProductSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartProductSubscription service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/StartProductSubscription">REST API Reference for StartProductSubscription Operation</seealso>
        Task<StartProductSubscriptionResponse> StartProductSubscriptionAsync(StartProductSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopProductSubscription


        /// <summary>
        /// Stops a product subscription for a user with the specified identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopProductSubscription service method.</param>
        /// 
        /// <returns>The response from the StopProductSubscription service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/StopProductSubscription">REST API Reference for StopProductSubscription Operation</seealso>
        StopProductSubscriptionResponse StopProductSubscription(StopProductSubscriptionRequest request);



        /// <summary>
        /// Stops a product subscription for a user with the specified identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopProductSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopProductSubscription service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/StopProductSubscription">REST API Reference for StopProductSubscription Operation</seealso>
        Task<StopProductSubscriptionResponse> StopProductSubscriptionAsync(StopProductSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIdentityProviderSettings


        /// <summary>
        /// Updates additional product configuration settings for the registered identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityProviderSettings service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/UpdateIdentityProviderSettings">REST API Reference for UpdateIdentityProviderSettings Operation</seealso>
        UpdateIdentityProviderSettingsResponse UpdateIdentityProviderSettings(UpdateIdentityProviderSettingsRequest request);



        /// <summary>
        /// Updates additional product configuration settings for the registered identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdentityProviderSettings service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/UpdateIdentityProviderSettings">REST API Reference for UpdateIdentityProviderSettings Operation</seealso>
        Task<UpdateIdentityProviderSettingsResponse> UpdateIdentityProviderSettingsAsync(UpdateIdentityProviderSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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