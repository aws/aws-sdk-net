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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PartnerCentralBenefits.Model;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralBenefits
{
    /// <summary>
    /// <para>Interface for accessing PartnerCentralBenefits</para>
    ///
    /// AWS Partner Central Benefits Service provides APIs for managing partner benefits,
    /// applications, and allocations within the AWS Partner Network ecosystem.
    /// </summary>
    public partial interface IAmazonPartnerCentralBenefits : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPartnerCentralBenefitsPaginatorFactory Paginators { get; }
#endif
                
        #region  AmendBenefitApplication



        /// <summary>
        /// Modifies an existing benefit application by applying amendments to specific fields
        /// while maintaining revision control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AmendBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AmendBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AmendBenefitApplication">REST API Reference for AmendBenefitApplication Operation</seealso>
        Task<AmendBenefitApplicationResponse> AmendBenefitApplicationAsync(AmendBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateBenefitApplicationResource



        /// <summary>
        /// Links an AWS resource to an existing benefit application for tracking and management
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBenefitApplicationResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateBenefitApplicationResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AssociateBenefitApplicationResource">REST API Reference for AssociateBenefitApplicationResource Operation</seealso>
        Task<AssociateBenefitApplicationResourceResponse> AssociateBenefitApplicationResourceAsync(AssociateBenefitApplicationResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelBenefitApplication



        /// <summary>
        /// Cancels a benefit application that is currently in progress, preventing further processing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CancelBenefitApplication">REST API Reference for CancelBenefitApplication Operation</seealso>
        Task<CancelBenefitApplicationResponse> CancelBenefitApplicationAsync(CancelBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBenefitApplication



        /// <summary>
        /// Creates a new benefit application for a partner to request access to AWS benefits
        /// and programs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CreateBenefitApplication">REST API Reference for CreateBenefitApplication Operation</seealso>
        Task<CreateBenefitApplicationResponse> CreateBenefitApplicationAsync(CreateBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateBenefitApplicationResource



        /// <summary>
        /// Removes the association between an AWS resource and a benefit application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBenefitApplicationResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateBenefitApplicationResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/DisassociateBenefitApplicationResource">REST API Reference for DisassociateBenefitApplicationResource Operation</seealso>
        Task<DisassociateBenefitApplicationResourceResponse> DisassociateBenefitApplicationResourceAsync(DisassociateBenefitApplicationResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBenefit



        /// <summary>
        /// Retrieves detailed information about a specific benefit available in the partner catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBenefit service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefit">REST API Reference for GetBenefit Operation</seealso>
        Task<GetBenefitResponse> GetBenefitAsync(GetBenefitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBenefitAllocation



        /// <summary>
        /// Retrieves detailed information about a specific benefit allocation that has been granted
        /// to a partner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBenefitAllocation service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitAllocation">REST API Reference for GetBenefitAllocation Operation</seealso>
        Task<GetBenefitAllocationResponse> GetBenefitAllocationAsync(GetBenefitAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBenefitApplication



        /// <summary>
        /// Retrieves detailed information about a specific benefit application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitApplication">REST API Reference for GetBenefitApplication Operation</seealso>
        Task<GetBenefitApplicationResponse> GetBenefitApplicationAsync(GetBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBenefitAllocations



        /// <summary>
        /// Retrieves a paginated list of benefit allocations based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitAllocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBenefitAllocations service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitAllocations">REST API Reference for ListBenefitAllocations Operation</seealso>
        Task<ListBenefitAllocationsResponse> ListBenefitAllocationsAsync(ListBenefitAllocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBenefitApplications



        /// <summary>
        /// Retrieves a paginated list of benefit applications based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBenefitApplications service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitApplications">REST API Reference for ListBenefitApplications Operation</seealso>
        Task<ListBenefitApplicationsResponse> ListBenefitApplicationsAsync(ListBenefitApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBenefits



        /// <summary>
        /// Retrieves a paginated list of available benefits based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBenefits service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefits">REST API Reference for ListBenefits Operation</seealso>
        Task<ListBenefitsResponse> ListBenefitsAsync(ListBenefitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Retrieves all tags associated with a specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RecallBenefitApplication



        /// <summary>
        /// Recalls a submitted benefit application, returning it to draft status for further
        /// modifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecallBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecallBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/RecallBenefitApplication">REST API Reference for RecallBenefitApplication Operation</seealso>
        Task<RecallBenefitApplicationResponse> RecallBenefitApplicationAsync(RecallBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SubmitBenefitApplication



        /// <summary>
        /// Submits a benefit application for review and processing by AWS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/SubmitBenefitApplication">REST API Reference for SubmitBenefitApplication Operation</seealso>
        Task<SubmitBenefitApplicationResponse> SubmitBenefitApplicationAsync(SubmitBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or updates tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ServiceQuotaExceededException">
        /// Thrown when the request would exceed the service quotas or limits for the account.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ServiceQuotaExceededException">
        /// Thrown when the request would exceed the service quotas or limits for the account.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBenefitApplication



        /// <summary>
        /// Updates an existing benefit application with new information while maintaining revision
        /// control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UpdateBenefitApplication">REST API Reference for UpdateBenefitApplication Operation</seealso>
        Task<UpdateBenefitApplicationResponse> UpdateBenefitApplicationAsync(UpdateBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonPartnerCentralBenefitsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonPartnerCentralBenefitsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonPartnerCentralBenefitsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonPartnerCentralBenefitsConfig to create AmazonPartnerCentralBenefitsClient");
            }

            return awsCredentials == null ? 
                    new AmazonPartnerCentralBenefitsClient(serviceClientConfig) :
                    new AmazonPartnerCentralBenefitsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}