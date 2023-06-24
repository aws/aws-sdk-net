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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Account.Model;

namespace Amazon.Account
{
    /// <summary>
    /// Interface for accessing Account
    ///
    /// Operations for Amazon Web Services Account Management
    /// </summary>
    public partial interface IAmazonAccount : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAccountPaginatorFactory Paginators { get; }
#endif
                
        #region  DeleteAlternateContact



        /// <summary>
        /// Deletes the specified alternate contact from an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlternateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DeleteAlternateContact">REST API Reference for DeleteAlternateContact Operation</seealso>
        Task<DeleteAlternateContactResponse> DeleteAlternateContactAsync(DeleteAlternateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableRegion



        /// <summary>
        /// Disables (opts-out) a particular Region for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableRegion service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ConflictException">
        /// The request could not be processed because of a conflict in the current status of
        /// the resource. For example, this happens if you try to enable a Region that is currently
        /// being disabled (in a status of DISABLING).
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DisableRegion">REST API Reference for DisableRegion Operation</seealso>
        Task<DisableRegionResponse> DisableRegionAsync(DisableRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableRegion



        /// <summary>
        /// Enables (opts-in) a particular Region for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableRegion service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ConflictException">
        /// The request could not be processed because of a conflict in the current status of
        /// the resource. For example, this happens if you try to enable a Region that is currently
        /// being disabled (in a status of DISABLING).
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/EnableRegion">REST API Reference for EnableRegion Operation</seealso>
        Task<EnableRegionResponse> EnableRegionAsync(EnableRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAlternateContact



        /// <summary>
        /// Retrieves the specified alternate contact attached to an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlternateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetAlternateContact">REST API Reference for GetAlternateContact Operation</seealso>
        Task<GetAlternateContactResponse> GetAlternateContactAsync(GetAlternateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetContactInformation



        /// <summary>
        /// Retrieves the primary contact information of an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the primary contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Update
        /// the primary and alternate contact information</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContactInformation service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetContactInformation">REST API Reference for GetContactInformation Operation</seealso>
        Task<GetContactInformationResponse> GetContactInformationAsync(GetContactInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRegionOptStatus



        /// <summary>
        /// Retrieves the opt-in status of a particular Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegionOptStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegionOptStatus service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetRegionOptStatus">REST API Reference for GetRegionOptStatus Operation</seealso>
        Task<GetRegionOptStatusResponse> GetRegionOptStatusAsync(GetRegionOptStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRegions



        /// <summary>
        /// Lists all the Regions for a given account and their respective opt-in statuses. Optionally,
        /// this list can be filtered by the <code>region-opt-status-contains</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegions service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/ListRegions">REST API Reference for ListRegions Operation</seealso>
        Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAlternateContact



        /// <summary>
        /// Modifies the specified alternate contact attached to an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlternateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutAlternateContact">REST API Reference for PutAlternateContact Operation</seealso>
        Task<PutAlternateContactResponse> PutAlternateContactAsync(PutAlternateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutContactInformation



        /// <summary>
        /// Updates the primary contact information of an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the primary contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Update
        /// the primary and alternate contact information</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContactInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutContactInformation service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutContactInformation">REST API Reference for PutContactInformation Operation</seealso>
        Task<PutContactInformationResponse> PutContactInformationAsync(PutContactInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}