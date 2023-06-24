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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LicenseManager.Model;

namespace Amazon.LicenseManager
{
    /// <summary>
    /// Interface for accessing LicenseManager
    ///
    /// License Manager makes it easier to manage licenses from software vendors across multiple
    /// Amazon Web Services accounts and on-premises servers.
    /// </summary>
    public partial interface IAmazonLicenseManager : IAmazonService, IDisposable
    {


        
        #region  AcceptGrant


        /// <summary>
        /// Accepts the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptGrant service method.</param>
        /// 
        /// <returns>The response from the AcceptGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/AcceptGrant">REST API Reference for AcceptGrant Operation</seealso>
        AcceptGrantResponse AcceptGrant(AcceptGrantRequest request);



        /// <summary>
        /// Accepts the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/AcceptGrant">REST API Reference for AcceptGrant Operation</seealso>
        Task<AcceptGrantResponse> AcceptGrantAsync(AcceptGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CheckInLicense


        /// <summary>
        /// Checks in the specified license. Check in a license when it is no longer in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckInLicense service method.</param>
        /// 
        /// <returns>The response from the CheckInLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckInLicense">REST API Reference for CheckInLicense Operation</seealso>
        CheckInLicenseResponse CheckInLicense(CheckInLicenseRequest request);



        /// <summary>
        /// Checks in the specified license. Check in a license when it is no longer in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckInLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckInLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckInLicense">REST API Reference for CheckInLicense Operation</seealso>
        Task<CheckInLicenseResponse> CheckInLicenseAsync(CheckInLicenseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CheckoutBorrowLicense


        /// <summary>
        /// Checks out the specified license for offline use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckoutBorrowLicense service method.</param>
        /// 
        /// <returns>The response from the CheckoutBorrowLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.EntitlementNotAllowedException">
        /// The entitlement is not allowed.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.NoEntitlementsAllowedException">
        /// There are no entitlements found for this license, or the entitlement maximum count
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.UnsupportedDigitalSignatureMethodException">
        /// The digital signature method is unsupported. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutBorrowLicense">REST API Reference for CheckoutBorrowLicense Operation</seealso>
        CheckoutBorrowLicenseResponse CheckoutBorrowLicense(CheckoutBorrowLicenseRequest request);



        /// <summary>
        /// Checks out the specified license for offline use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckoutBorrowLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckoutBorrowLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.EntitlementNotAllowedException">
        /// The entitlement is not allowed.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.NoEntitlementsAllowedException">
        /// There are no entitlements found for this license, or the entitlement maximum count
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.UnsupportedDigitalSignatureMethodException">
        /// The digital signature method is unsupported. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutBorrowLicense">REST API Reference for CheckoutBorrowLicense Operation</seealso>
        Task<CheckoutBorrowLicenseResponse> CheckoutBorrowLicenseAsync(CheckoutBorrowLicenseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CheckoutLicense


        /// <summary>
        /// Checks out the specified license.
        /// 
        ///  <note> 
        /// <para>
        /// If the account that created the license is the same that is performing the check out,
        /// you must specify the account as the beneficiary.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckoutLicense service method.</param>
        /// 
        /// <returns>The response from the CheckoutLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.NoEntitlementsAllowedException">
        /// There are no entitlements found for this license, or the entitlement maximum count
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.UnsupportedDigitalSignatureMethodException">
        /// The digital signature method is unsupported. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutLicense">REST API Reference for CheckoutLicense Operation</seealso>
        CheckoutLicenseResponse CheckoutLicense(CheckoutLicenseRequest request);



        /// <summary>
        /// Checks out the specified license.
        /// 
        ///  <note> 
        /// <para>
        /// If the account that created the license is the same that is performing the check out,
        /// you must specify the account as the beneficiary.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckoutLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckoutLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.NoEntitlementsAllowedException">
        /// There are no entitlements found for this license, or the entitlement maximum count
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.UnsupportedDigitalSignatureMethodException">
        /// The digital signature method is unsupported. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutLicense">REST API Reference for CheckoutLicense Operation</seealso>
        Task<CheckoutLicenseResponse> CheckoutLicenseAsync(CheckoutLicenseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGrant


        /// <summary>
        /// Creates a grant for the specified license. A grant shares the use of license entitlements
        /// with a specific Amazon Web Services account, an organization, or an organizational
        /// unit (OU). For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
        /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        CreateGrantResponse CreateGrant(CreateGrantRequest request);



        /// <summary>
        /// Creates a grant for the specified license. A grant shares the use of license entitlements
        /// with a specific Amazon Web Services account, an organization, or an organizational
        /// unit (OU). For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
        /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGrantVersion


        /// <summary>
        /// Creates a new version of the specified grant. For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
        /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrantVersion service method.</param>
        /// 
        /// <returns>The response from the CreateGrantVersion service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrantVersion">REST API Reference for CreateGrantVersion Operation</seealso>
        CreateGrantVersionResponse CreateGrantVersion(CreateGrantVersionRequest request);



        /// <summary>
        /// Creates a new version of the specified grant. For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
        /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrantVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGrantVersion service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrantVersion">REST API Reference for CreateGrantVersion Operation</seealso>
        Task<CreateGrantVersionResponse> CreateGrantVersionAsync(CreateGrantVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLicense


        /// <summary>
        /// Creates a license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicense service method.</param>
        /// 
        /// <returns>The response from the CreateLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicense">REST API Reference for CreateLicense Operation</seealso>
        CreateLicenseResponse CreateLicense(CreateLicenseRequest request);



        /// <summary>
        /// Creates a license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicense">REST API Reference for CreateLicense Operation</seealso>
        Task<CreateLicenseResponse> CreateLicenseAsync(CreateLicenseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLicenseConfiguration


        /// <summary>
        /// Creates a license configuration.
        /// 
        ///  
        /// <para>
        /// A license configuration is an abstraction of a customer license agreement that can
        /// be consumed and enforced by License Manager. Components include specifications for
        /// the license type (licensing by instance, socket, CPU, or vCPU), allowed tenancy (shared
        /// tenancy, Dedicated Instance, Dedicated Host, or all of these), license affinity to
        /// host (how long a license must be associated with a host), and the number of licenses
        /// purchased and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        CreateLicenseConfigurationResponse CreateLicenseConfiguration(CreateLicenseConfigurationRequest request);



        /// <summary>
        /// Creates a license configuration.
        /// 
        ///  
        /// <para>
        /// A license configuration is an abstraction of a customer license agreement that can
        /// be consumed and enforced by License Manager. Components include specifications for
        /// the license type (licensing by instance, socket, CPU, or vCPU), allowed tenancy (shared
        /// tenancy, Dedicated Instance, Dedicated Host, or all of these), license affinity to
        /// host (how long a license must be associated with a host), and the number of licenses
        /// purchased and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        Task<CreateLicenseConfigurationResponse> CreateLicenseConfigurationAsync(CreateLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLicenseConversionTaskForResource


        /// <summary>
        /// Creates a new license conversion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConversionTaskForResource service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseConversionTaskForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConversionTaskForResource">REST API Reference for CreateLicenseConversionTaskForResource Operation</seealso>
        CreateLicenseConversionTaskForResourceResponse CreateLicenseConversionTaskForResource(CreateLicenseConversionTaskForResourceRequest request);



        /// <summary>
        /// Creates a new license conversion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConversionTaskForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseConversionTaskForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConversionTaskForResource">REST API Reference for CreateLicenseConversionTaskForResource Operation</seealso>
        Task<CreateLicenseConversionTaskForResourceResponse> CreateLicenseConversionTaskForResourceAsync(CreateLicenseConversionTaskForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLicenseManagerReportGenerator


        /// <summary>
        /// Creates a report generator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseManagerReportGenerator service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseManagerReportGenerator">REST API Reference for CreateLicenseManagerReportGenerator Operation</seealso>
        CreateLicenseManagerReportGeneratorResponse CreateLicenseManagerReportGenerator(CreateLicenseManagerReportGeneratorRequest request);



        /// <summary>
        /// Creates a report generator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseManagerReportGenerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseManagerReportGenerator">REST API Reference for CreateLicenseManagerReportGenerator Operation</seealso>
        Task<CreateLicenseManagerReportGeneratorResponse> CreateLicenseManagerReportGeneratorAsync(CreateLicenseManagerReportGeneratorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLicenseVersion


        /// <summary>
        /// Creates a new version of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseVersion service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseVersion service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseVersion">REST API Reference for CreateLicenseVersion Operation</seealso>
        CreateLicenseVersionResponse CreateLicenseVersion(CreateLicenseVersionRequest request);



        /// <summary>
        /// Creates a new version of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseVersion service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseVersion">REST API Reference for CreateLicenseVersion Operation</seealso>
        Task<CreateLicenseVersionResponse> CreateLicenseVersionAsync(CreateLicenseVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateToken


        /// <summary>
        /// Creates a long-lived token.
        /// 
        ///  
        /// <para>
        /// A refresh token is a JWT token used to get an access token. With an access token,
        /// you can call AssumeRoleWithWebIdentity to get role credentials that you can use to
        /// call License Manager to manage the specified license.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// 
        /// <returns>The response from the CreateToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateToken">REST API Reference for CreateToken Operation</seealso>
        CreateTokenResponse CreateToken(CreateTokenRequest request);



        /// <summary>
        /// Creates a long-lived token.
        /// 
        ///  
        /// <para>
        /// A refresh token is a JWT token used to get an access token. With an access token,
        /// you can call AssumeRoleWithWebIdentity to get role credentials that you can use to
        /// call License Manager to manage the specified license.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateToken">REST API Reference for CreateToken Operation</seealso>
        Task<CreateTokenResponse> CreateTokenAsync(CreateTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGrant


        /// <summary>
        /// Deletes the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteGrant">REST API Reference for DeleteGrant Operation</seealso>
        DeleteGrantResponse DeleteGrant(DeleteGrantRequest request);



        /// <summary>
        /// Deletes the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteGrant">REST API Reference for DeleteGrant Operation</seealso>
        Task<DeleteGrantResponse> DeleteGrantAsync(DeleteGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLicense


        /// <summary>
        /// Deletes the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicense service method.</param>
        /// 
        /// <returns>The response from the DeleteLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicense">REST API Reference for DeleteLicense Operation</seealso>
        DeleteLicenseResponse DeleteLicense(DeleteLicenseRequest request);



        /// <summary>
        /// Deletes the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicense">REST API Reference for DeleteLicense Operation</seealso>
        Task<DeleteLicenseResponse> DeleteLicenseAsync(DeleteLicenseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLicenseConfiguration


        /// <summary>
        /// Deletes the specified license configuration.
        /// 
        ///  
        /// <para>
        /// You cannot delete a license configuration that is in use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        DeleteLicenseConfigurationResponse DeleteLicenseConfiguration(DeleteLicenseConfigurationRequest request);



        /// <summary>
        /// Deletes the specified license configuration.
        /// 
        ///  
        /// <para>
        /// You cannot delete a license configuration that is in use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        Task<DeleteLicenseConfigurationResponse> DeleteLicenseConfigurationAsync(DeleteLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLicenseManagerReportGenerator


        /// <summary>
        /// Deletes the specified report generator.
        /// 
        ///  
        /// <para>
        /// This action deletes the report generator, which stops it from generating future reports.
        /// The action cannot be reversed. It has no effect on the previous reports from this
        /// generator.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseManagerReportGenerator service method.</param>
        /// 
        /// <returns>The response from the DeleteLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseManagerReportGenerator">REST API Reference for DeleteLicenseManagerReportGenerator Operation</seealso>
        DeleteLicenseManagerReportGeneratorResponse DeleteLicenseManagerReportGenerator(DeleteLicenseManagerReportGeneratorRequest request);



        /// <summary>
        /// Deletes the specified report generator.
        /// 
        ///  
        /// <para>
        /// This action deletes the report generator, which stops it from generating future reports.
        /// The action cannot be reversed. It has no effect on the previous reports from this
        /// generator.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseManagerReportGenerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseManagerReportGenerator">REST API Reference for DeleteLicenseManagerReportGenerator Operation</seealso>
        Task<DeleteLicenseManagerReportGeneratorResponse> DeleteLicenseManagerReportGeneratorAsync(DeleteLicenseManagerReportGeneratorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteToken


        /// <summary>
        /// Deletes the specified token. Must be called in the license home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken service method.</param>
        /// 
        /// <returns>The response from the DeleteToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        DeleteTokenResponse DeleteToken(DeleteTokenRequest request);



        /// <summary>
        /// Deletes the specified token. Must be called in the license home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        Task<DeleteTokenResponse> DeleteTokenAsync(DeleteTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExtendLicenseConsumption


        /// <summary>
        /// Extends the expiration date for license consumption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExtendLicenseConsumption service method.</param>
        /// 
        /// <returns>The response from the ExtendLicenseConsumption service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ExtendLicenseConsumption">REST API Reference for ExtendLicenseConsumption Operation</seealso>
        ExtendLicenseConsumptionResponse ExtendLicenseConsumption(ExtendLicenseConsumptionRequest request);



        /// <summary>
        /// Extends the expiration date for license consumption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExtendLicenseConsumption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExtendLicenseConsumption service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ExtendLicenseConsumption">REST API Reference for ExtendLicenseConsumption Operation</seealso>
        Task<ExtendLicenseConsumptionResponse> ExtendLicenseConsumptionAsync(ExtendLicenseConsumptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAccessToken


        /// <summary>
        /// Gets a temporary access token to use with AssumeRoleWithWebIdentity. Access tokens
        /// are valid for one hour.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessToken service method.</param>
        /// 
        /// <returns>The response from the GetAccessToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetAccessToken">REST API Reference for GetAccessToken Operation</seealso>
        GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request);



        /// <summary>
        /// Gets a temporary access token to use with AssumeRoleWithWebIdentity. Access tokens
        /// are valid for one hour.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetAccessToken">REST API Reference for GetAccessToken Operation</seealso>
        Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGrant


        /// <summary>
        /// Gets detailed information about the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGrant service method.</param>
        /// 
        /// <returns>The response from the GetGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetGrant">REST API Reference for GetGrant Operation</seealso>
        GetGrantResponse GetGrant(GetGrantRequest request);



        /// <summary>
        /// Gets detailed information about the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetGrant">REST API Reference for GetGrant Operation</seealso>
        Task<GetGrantResponse> GetGrantAsync(GetGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLicense


        /// <summary>
        /// Gets detailed information about the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicense service method.</param>
        /// 
        /// <returns>The response from the GetLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicense">REST API Reference for GetLicense Operation</seealso>
        GetLicenseResponse GetLicense(GetLicenseRequest request);



        /// <summary>
        /// Gets detailed information about the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicense">REST API Reference for GetLicense Operation</seealso>
        Task<GetLicenseResponse> GetLicenseAsync(GetLicenseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLicenseConfiguration


        /// <summary>
        /// Gets detailed information about the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        GetLicenseConfigurationResponse GetLicenseConfiguration(GetLicenseConfigurationRequest request);



        /// <summary>
        /// Gets detailed information about the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        Task<GetLicenseConfigurationResponse> GetLicenseConfigurationAsync(GetLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLicenseConversionTask


        /// <summary>
        /// Gets information about the specified license type conversion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConversionTask service method.</param>
        /// 
        /// <returns>The response from the GetLicenseConversionTask service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConversionTask">REST API Reference for GetLicenseConversionTask Operation</seealso>
        GetLicenseConversionTaskResponse GetLicenseConversionTask(GetLicenseConversionTaskRequest request);



        /// <summary>
        /// Gets information about the specified license type conversion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConversionTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseConversionTask service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConversionTask">REST API Reference for GetLicenseConversionTask Operation</seealso>
        Task<GetLicenseConversionTaskResponse> GetLicenseConversionTaskAsync(GetLicenseConversionTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLicenseManagerReportGenerator


        /// <summary>
        /// Gets information about the specified report generator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseManagerReportGenerator service method.</param>
        /// 
        /// <returns>The response from the GetLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseManagerReportGenerator">REST API Reference for GetLicenseManagerReportGenerator Operation</seealso>
        GetLicenseManagerReportGeneratorResponse GetLicenseManagerReportGenerator(GetLicenseManagerReportGeneratorRequest request);



        /// <summary>
        /// Gets information about the specified report generator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseManagerReportGenerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseManagerReportGenerator">REST API Reference for GetLicenseManagerReportGenerator Operation</seealso>
        Task<GetLicenseManagerReportGeneratorResponse> GetLicenseManagerReportGeneratorAsync(GetLicenseManagerReportGeneratorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLicenseUsage


        /// <summary>
        /// Gets detailed information about the usage of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseUsage service method.</param>
        /// 
        /// <returns>The response from the GetLicenseUsage service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseUsage">REST API Reference for GetLicenseUsage Operation</seealso>
        GetLicenseUsageResponse GetLicenseUsage(GetLicenseUsageRequest request);



        /// <summary>
        /// Gets detailed information about the usage of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseUsage service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseUsage">REST API Reference for GetLicenseUsage Operation</seealso>
        Task<GetLicenseUsageResponse> GetLicenseUsageAsync(GetLicenseUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServiceSettings


        /// <summary>
        /// Gets the License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request);



        /// <summary>
        /// Gets the License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociationsForLicenseConfiguration


        /// <summary>
        /// Lists the resource associations for the specified license configuration.
        /// 
        ///  
        /// <para>
        /// Resource associations need not consume licenses from a license configuration. For
        /// example, an AMI or a stopped instance might not consume a license (depending on the
        /// license rules).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListAssociationsForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        ListAssociationsForLicenseConfigurationResponse ListAssociationsForLicenseConfiguration(ListAssociationsForLicenseConfigurationRequest request);



        /// <summary>
        /// Lists the resource associations for the specified license configuration.
        /// 
        ///  
        /// <para>
        /// Resource associations need not consume licenses from a license configuration. For
        /// example, an AMI or a stopped instance might not consume a license (depending on the
        /// license rules).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociationsForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        Task<ListAssociationsForLicenseConfigurationResponse> ListAssociationsForLicenseConfigurationAsync(ListAssociationsForLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDistributedGrants


        /// <summary>
        /// Lists the grants distributed for the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributedGrants service method.</param>
        /// 
        /// <returns>The response from the ListDistributedGrants service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListDistributedGrants">REST API Reference for ListDistributedGrants Operation</seealso>
        ListDistributedGrantsResponse ListDistributedGrants(ListDistributedGrantsRequest request);



        /// <summary>
        /// Lists the grants distributed for the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributedGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributedGrants service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListDistributedGrants">REST API Reference for ListDistributedGrants Operation</seealso>
        Task<ListDistributedGrantsResponse> ListDistributedGrantsAsync(ListDistributedGrantsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFailuresForLicenseConfigurationOperations


        /// <summary>
        /// Lists the license configuration operations that failed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailuresForLicenseConfigurationOperations service method.</param>
        /// 
        /// <returns>The response from the ListFailuresForLicenseConfigurationOperations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListFailuresForLicenseConfigurationOperations">REST API Reference for ListFailuresForLicenseConfigurationOperations Operation</seealso>
        ListFailuresForLicenseConfigurationOperationsResponse ListFailuresForLicenseConfigurationOperations(ListFailuresForLicenseConfigurationOperationsRequest request);



        /// <summary>
        /// Lists the license configuration operations that failed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailuresForLicenseConfigurationOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFailuresForLicenseConfigurationOperations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListFailuresForLicenseConfigurationOperations">REST API Reference for ListFailuresForLicenseConfigurationOperations Operation</seealso>
        Task<ListFailuresForLicenseConfigurationOperationsResponse> ListFailuresForLicenseConfigurationOperationsAsync(ListFailuresForLicenseConfigurationOperationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLicenseConfigurations


        /// <summary>
        /// Lists the license configurations for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLicenseConfigurations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        ListLicenseConfigurationsResponse ListLicenseConfigurations(ListLicenseConfigurationsRequest request);



        /// <summary>
        /// Lists the license configurations for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseConfigurations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        Task<ListLicenseConfigurationsResponse> ListLicenseConfigurationsAsync(ListLicenseConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLicenseConversionTasks


        /// <summary>
        /// Lists the license type conversion tasks for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConversionTasks service method.</param>
        /// 
        /// <returns>The response from the ListLicenseConversionTasks service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConversionTasks">REST API Reference for ListLicenseConversionTasks Operation</seealso>
        ListLicenseConversionTasksResponse ListLicenseConversionTasks(ListLicenseConversionTasksRequest request);



        /// <summary>
        /// Lists the license type conversion tasks for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConversionTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseConversionTasks service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConversionTasks">REST API Reference for ListLicenseConversionTasks Operation</seealso>
        Task<ListLicenseConversionTasksResponse> ListLicenseConversionTasksAsync(ListLicenseConversionTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLicenseManagerReportGenerators


        /// <summary>
        /// Lists the report generators for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseManagerReportGenerators service method.</param>
        /// 
        /// <returns>The response from the ListLicenseManagerReportGenerators service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseManagerReportGenerators">REST API Reference for ListLicenseManagerReportGenerators Operation</seealso>
        ListLicenseManagerReportGeneratorsResponse ListLicenseManagerReportGenerators(ListLicenseManagerReportGeneratorsRequest request);



        /// <summary>
        /// Lists the report generators for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseManagerReportGenerators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseManagerReportGenerators service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseManagerReportGenerators">REST API Reference for ListLicenseManagerReportGenerators Operation</seealso>
        Task<ListLicenseManagerReportGeneratorsResponse> ListLicenseManagerReportGeneratorsAsync(ListLicenseManagerReportGeneratorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLicenses


        /// <summary>
        /// Lists the licenses for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenses service method.</param>
        /// 
        /// <returns>The response from the ListLicenses service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenses">REST API Reference for ListLicenses Operation</seealso>
        ListLicensesResponse ListLicenses(ListLicensesRequest request);



        /// <summary>
        /// Lists the licenses for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenses service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenses">REST API Reference for ListLicenses Operation</seealso>
        Task<ListLicensesResponse> ListLicensesAsync(ListLicensesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLicenseSpecificationsForResource


        /// <summary>
        /// Describes the license configurations for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource service method.</param>
        /// 
        /// <returns>The response from the ListLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        ListLicenseSpecificationsForResourceResponse ListLicenseSpecificationsForResource(ListLicenseSpecificationsForResourceRequest request);



        /// <summary>
        /// Describes the license configurations for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        Task<ListLicenseSpecificationsForResourceResponse> ListLicenseSpecificationsForResourceAsync(ListLicenseSpecificationsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLicenseVersions


        /// <summary>
        /// Lists all versions of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseVersions service method.</param>
        /// 
        /// <returns>The response from the ListLicenseVersions service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseVersions">REST API Reference for ListLicenseVersions Operation</seealso>
        ListLicenseVersionsResponse ListLicenseVersions(ListLicenseVersionsRequest request);



        /// <summary>
        /// Lists all versions of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseVersions service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseVersions">REST API Reference for ListLicenseVersions Operation</seealso>
        Task<ListLicenseVersionsResponse> ListLicenseVersionsAsync(ListLicenseVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReceivedGrants


        /// <summary>
        /// Lists grants that are received. Received grants are grants created while specifying
        /// the recipient as this Amazon Web Services account, your organization, or an organizational
        /// unit (OU) to which this member account belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedGrants service method.</param>
        /// 
        /// <returns>The response from the ListReceivedGrants service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrants">REST API Reference for ListReceivedGrants Operation</seealso>
        ListReceivedGrantsResponse ListReceivedGrants(ListReceivedGrantsRequest request);



        /// <summary>
        /// Lists grants that are received. Received grants are grants created while specifying
        /// the recipient as this Amazon Web Services account, your organization, or an organizational
        /// unit (OU) to which this member account belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReceivedGrants service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrants">REST API Reference for ListReceivedGrants Operation</seealso>
        Task<ListReceivedGrantsResponse> ListReceivedGrantsAsync(ListReceivedGrantsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReceivedGrantsForOrganization


        /// <summary>
        /// Lists the grants received for all accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedGrantsForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListReceivedGrantsForOrganization service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrantsForOrganization">REST API Reference for ListReceivedGrantsForOrganization Operation</seealso>
        ListReceivedGrantsForOrganizationResponse ListReceivedGrantsForOrganization(ListReceivedGrantsForOrganizationRequest request);



        /// <summary>
        /// Lists the grants received for all accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedGrantsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReceivedGrantsForOrganization service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrantsForOrganization">REST API Reference for ListReceivedGrantsForOrganization Operation</seealso>
        Task<ListReceivedGrantsForOrganizationResponse> ListReceivedGrantsForOrganizationAsync(ListReceivedGrantsForOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReceivedLicenses


        /// <summary>
        /// Lists received licenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedLicenses service method.</param>
        /// 
        /// <returns>The response from the ListReceivedLicenses service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicenses">REST API Reference for ListReceivedLicenses Operation</seealso>
        ListReceivedLicensesResponse ListReceivedLicenses(ListReceivedLicensesRequest request);



        /// <summary>
        /// Lists received licenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedLicenses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReceivedLicenses service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicenses">REST API Reference for ListReceivedLicenses Operation</seealso>
        Task<ListReceivedLicensesResponse> ListReceivedLicensesAsync(ListReceivedLicensesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReceivedLicensesForOrganization


        /// <summary>
        /// Lists the licenses received for all accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedLicensesForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListReceivedLicensesForOrganization service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicensesForOrganization">REST API Reference for ListReceivedLicensesForOrganization Operation</seealso>
        ListReceivedLicensesForOrganizationResponse ListReceivedLicensesForOrganization(ListReceivedLicensesForOrganizationRequest request);



        /// <summary>
        /// Lists the licenses received for all accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedLicensesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReceivedLicensesForOrganization service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicensesForOrganization">REST API Reference for ListReceivedLicensesForOrganization Operation</seealso>
        Task<ListReceivedLicensesForOrganizationResponse> ListReceivedLicensesForOrganizationAsync(ListReceivedLicensesForOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceInventory


        /// <summary>
        /// Lists resources managed using Systems Manager inventory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory service method.</param>
        /// 
        /// <returns>The response from the ListResourceInventory service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FailedDependencyException">
        /// A dependency required to run the API is missing.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        ListResourceInventoryResponse ListResourceInventory(ListResourceInventoryRequest request);



        /// <summary>
        /// Lists resources managed using Systems Manager inventory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceInventory service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FailedDependencyException">
        /// A dependency required to run the API is missing.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        Task<ListResourceInventoryResponse> ListResourceInventoryAsync(ListResourceInventoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags for the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTokens


        /// <summary>
        /// Lists your tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTokens service method.</param>
        /// 
        /// <returns>The response from the ListTokens service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTokens">REST API Reference for ListTokens Operation</seealso>
        ListTokensResponse ListTokens(ListTokensRequest request);



        /// <summary>
        /// Lists your tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTokens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTokens service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTokens">REST API Reference for ListTokens Operation</seealso>
        Task<ListTokensResponse> ListTokensAsync(ListTokensRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsageForLicenseConfiguration


        /// <summary>
        /// Lists all license usage records for a license configuration, displaying license consumption
        /// details by resource at a selected point in time. Use this action to audit the current
        /// license consumption for any license inventory and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListUsageForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        ListUsageForLicenseConfigurationResponse ListUsageForLicenseConfiguration(ListUsageForLicenseConfigurationRequest request);



        /// <summary>
        /// Lists all license usage records for a license configuration, displaying license consumption
        /// details by resource at a selected point in time. Use this action to audit the current
        /// license consumption for any license inventory and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsageForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        Task<ListUsageForLicenseConfigurationResponse> ListUsageForLicenseConfigurationAsync(ListUsageForLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RejectGrant


        /// <summary>
        /// Rejects the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectGrant service method.</param>
        /// 
        /// <returns>The response from the RejectGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/RejectGrant">REST API Reference for RejectGrant Operation</seealso>
        RejectGrantResponse RejectGrant(RejectGrantRequest request);



        /// <summary>
        /// Rejects the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/RejectGrant">REST API Reference for RejectGrant Operation</seealso>
        Task<RejectGrantResponse> RejectGrantAsync(RejectGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds the specified tags to the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the specified tags from the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLicenseConfiguration


        /// <summary>
        /// Modifies the attributes of an existing license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        UpdateLicenseConfigurationResponse UpdateLicenseConfiguration(UpdateLicenseConfigurationRequest request);



        /// <summary>
        /// Modifies the attributes of an existing license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        Task<UpdateLicenseConfigurationResponse> UpdateLicenseConfigurationAsync(UpdateLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLicenseManagerReportGenerator


        /// <summary>
        /// Updates a report generator.
        /// 
        ///  
        /// <para>
        /// After you make changes to a report generator, it starts generating new reports within
        /// 60 minutes of being updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseManagerReportGenerator service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseManagerReportGenerator">REST API Reference for UpdateLicenseManagerReportGenerator Operation</seealso>
        UpdateLicenseManagerReportGeneratorResponse UpdateLicenseManagerReportGenerator(UpdateLicenseManagerReportGeneratorRequest request);



        /// <summary>
        /// Updates a report generator.
        /// 
        ///  
        /// <para>
        /// After you make changes to a report generator, it starts generating new reports within
        /// 60 minutes of being updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseManagerReportGenerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseManagerReportGenerator">REST API Reference for UpdateLicenseManagerReportGenerator Operation</seealso>
        Task<UpdateLicenseManagerReportGeneratorResponse> UpdateLicenseManagerReportGeneratorAsync(UpdateLicenseManagerReportGeneratorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLicenseSpecificationsForResource


        /// <summary>
        /// Adds or removes the specified license configurations for the specified Amazon Web
        /// Services resource.
        /// 
        ///  
        /// <para>
        /// You can update the license specifications of AMIs, instances, and hosts. You cannot
        /// update the license specifications for launch templates and CloudFormation templates,
        /// as they send license configurations to the operation that creates the resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidResourceStateException">
        /// License Manager cannot allocate a license to a resource because of its state. 
        /// 
        ///  
        /// <para>
        /// For example, you cannot allocate a license to an instance in the process of shutting
        /// down.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.LicenseUsageException">
        /// You do not have enough licenses available to support a new resource launch.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        UpdateLicenseSpecificationsForResourceResponse UpdateLicenseSpecificationsForResource(UpdateLicenseSpecificationsForResourceRequest request);



        /// <summary>
        /// Adds or removes the specified license configurations for the specified Amazon Web
        /// Services resource.
        /// 
        ///  
        /// <para>
        /// You can update the license specifications of AMIs, instances, and hosts. You cannot
        /// update the license specifications for launch templates and CloudFormation templates,
        /// as they send license configurations to the operation that creates the resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidResourceStateException">
        /// License Manager cannot allocate a license to a resource because of its state. 
        /// 
        ///  
        /// <para>
        /// For example, you cannot allocate a license to an instance in the process of shutting
        /// down.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.LicenseUsageException">
        /// You do not have enough licenses available to support a new resource launch.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        Task<UpdateLicenseSpecificationsForResourceResponse> UpdateLicenseSpecificationsForResourceAsync(UpdateLicenseSpecificationsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServiceSettings


        /// <summary>
        /// Updates License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request);



        /// <summary>
        /// Updates License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        Task<UpdateServiceSettingsResponse> UpdateServiceSettingsAsync(UpdateServiceSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}