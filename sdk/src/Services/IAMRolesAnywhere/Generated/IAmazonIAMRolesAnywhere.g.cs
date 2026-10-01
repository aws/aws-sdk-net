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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.IAMRolesAnywhere.Model;

#pragma warning disable CS1570

namespace Amazon.IAMRolesAnywhere
{
    /// <summary>
    /// <para>Interface for accessing IAMRolesAnywhere</para>
    ///
    /// Identity and Access Management Roles Anywhere provides a secure way for your workloads
    /// such as servers, containers, and applications that run outside of Amazon Web Services
    /// to obtain temporary Amazon Web Services credentials. Your workloads can use the same
    /// IAM policies and roles you have for native Amazon Web Services applications to access
    /// Amazon Web Services resources. Using IAM Roles Anywhere eliminates the need to manage
    /// long-term credentials for workloads running outside of Amazon Web Services.
    /// 
    ///  
    /// <para>
    ///  To use IAM Roles Anywhere, your workloads must use X.509 certificates issued by their
    /// certificate authority (CA). You register the CA with IAM Roles Anywhere as a trust
    /// anchor to establish trust between your public key infrastructure (PKI) and IAM Roles
    /// Anywhere. If you don't manage your own PKI system, you can use Private Certificate
    /// Authority to create a CA and then use that to establish trust with IAM Roles Anywhere.
    /// 
    /// </para>
    ///  
    /// <para>
    /// This guide describes the IAM Roles Anywhere operations that you can call programmatically.
    /// For more information about IAM Roles Anywhere, see the <a href="https://docs.aws.amazon.com/rolesanywhere/latest/userguide/introduction.html">IAM
    /// Roles Anywhere User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIAMRolesAnywhere : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIAMRolesAnywherePaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a <i>profile</i>, a list of the roles that Roles Anywhere service is trusted
        /// to assume. You use profiles to intersect permissions with IAM managed policies.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:CreateProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <returns>The response from the CreateProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        CreateProfileResponse CreateProfile(CreateProfileRequest request);
#endif

        /// <summary>
        /// Creates a <i>profile</i>, a list of the roles that Roles Anywhere service is trusted
        /// to assume. You use profiles to intersect permissions with IAM managed policies.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:CreateProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a trust anchor to establish trust between IAM Roles Anywhere and your certificate
        /// authority (CA). You can define a trust anchor as a reference to an Private Certificate
        /// Authority (Private CA) or by uploading a CA certificate. Your Amazon Web Services
        /// workloads can authenticate with the trust anchor using certificates issued by the
        /// CA in exchange for temporary Amazon Web Services credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:CreateTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustAnchor service method.</param>
        /// <returns>The response from the CreateTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateTrustAnchor">REST API Reference for CreateTrustAnchor Operation</seealso>
        CreateTrustAnchorResponse CreateTrustAnchor(CreateTrustAnchorRequest request);
#endif

        /// <summary>
        /// Creates a trust anchor to establish trust between IAM Roles Anywhere and your certificate
        /// authority (CA). You can define a trust anchor as a reference to an Private Certificate
        /// Authority (Private CA) or by uploading a CA certificate. Your Amazon Web Services
        /// workloads can authenticate with the trust anchor using certificates issued by the
        /// CA in exchange for temporary Amazon Web Services credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:CreateTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateTrustAnchor">REST API Reference for CreateTrustAnchor Operation</seealso>
        Task<CreateTrustAnchorResponse> CreateTrustAnchorAsync(CreateTrustAnchorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete an entry from the attribute mapping rules enforced by a given profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributeMapping service method.</param>
        /// <returns>The response from the DeleteAttributeMapping service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteAttributeMapping">REST API Reference for DeleteAttributeMapping Operation</seealso>
        DeleteAttributeMappingResponse DeleteAttributeMapping(DeleteAttributeMappingRequest request);
#endif

        /// <summary>
        /// Delete an entry from the attribute mapping rules enforced by a given profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributeMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAttributeMapping service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteAttributeMapping">REST API Reference for DeleteAttributeMapping Operation</seealso>
        Task<DeleteAttributeMappingResponse> DeleteAttributeMappingAsync(DeleteAttributeMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DeleteCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrl service method.</param>
        /// <returns>The response from the DeleteCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteCrl">REST API Reference for DeleteCrl Operation</seealso>
        DeleteCrlResponse DeleteCrl(DeleteCrlRequest request);
#endif

        /// <summary>
        /// Deletes a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DeleteCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteCrl">REST API Reference for DeleteCrl Operation</seealso>
        Task<DeleteCrlResponse> DeleteCrlAsync(DeleteCrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DeleteProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <returns>The response from the DeleteProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        DeleteProfileResponse DeleteProfile(DeleteProfileRequest request);
#endif

        /// <summary>
        /// Deletes a profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DeleteProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a trust anchor.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DeleteTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustAnchor service method.</param>
        /// <returns>The response from the DeleteTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteTrustAnchor">REST API Reference for DeleteTrustAnchor Operation</seealso>
        DeleteTrustAnchorResponse DeleteTrustAnchor(DeleteTrustAnchorRequest request);
#endif

        /// <summary>
        /// Deletes a trust anchor.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DeleteTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteTrustAnchor">REST API Reference for DeleteTrustAnchor Operation</seealso>
        Task<DeleteTrustAnchorResponse> DeleteTrustAnchorAsync(DeleteTrustAnchorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disables a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DisableCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableCrl service method.</param>
        /// <returns>The response from the DisableCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableCrl">REST API Reference for DisableCrl Operation</seealso>
        DisableCrlResponse DisableCrl(DisableCrlRequest request);
#endif

        /// <summary>
        /// Disables a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DisableCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisableCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableCrl">REST API Reference for DisableCrl Operation</seealso>
        Task<DisableCrlResponse> DisableCrlAsync(DisableCrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disables a profile. When disabled, temporary credential requests with this profile
        /// fail.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DisableProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableProfile service method.</param>
        /// <returns>The response from the DisableProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableProfile">REST API Reference for DisableProfile Operation</seealso>
        DisableProfileResponse DisableProfile(DisableProfileRequest request);
#endif

        /// <summary>
        /// Disables a profile. When disabled, temporary credential requests with this profile
        /// fail.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DisableProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisableProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableProfile">REST API Reference for DisableProfile Operation</seealso>
        Task<DisableProfileResponse> DisableProfileAsync(DisableProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disables a trust anchor. When disabled, temporary credential requests specifying this
        /// trust anchor are unauthorized.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DisableTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTrustAnchor service method.</param>
        /// <returns>The response from the DisableTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableTrustAnchor">REST API Reference for DisableTrustAnchor Operation</seealso>
        DisableTrustAnchorResponse DisableTrustAnchor(DisableTrustAnchorRequest request);
#endif

        /// <summary>
        /// Disables a trust anchor. When disabled, temporary credential requests specifying this
        /// trust anchor are unauthorized.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DisableTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisableTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableTrustAnchor">REST API Reference for DisableTrustAnchor Operation</seealso>
        Task<DisableTrustAnchorResponse> DisableTrustAnchorAsync(DisableTrustAnchorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Enables a certificate revocation list (CRL). When enabled, certificates stored in
        /// the CRL are unauthorized to receive session credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:EnableCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableCrl service method.</param>
        /// <returns>The response from the EnableCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableCrl">REST API Reference for EnableCrl Operation</seealso>
        EnableCrlResponse EnableCrl(EnableCrlRequest request);
#endif

        /// <summary>
        /// Enables a certificate revocation list (CRL). When enabled, certificates stored in
        /// the CRL are unauthorized to receive session credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:EnableCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EnableCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableCrl">REST API Reference for EnableCrl Operation</seealso>
        Task<EnableCrlResponse> EnableCrlAsync(EnableCrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Enables temporary credential requests for a profile. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:EnableProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableProfile service method.</param>
        /// <returns>The response from the EnableProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableProfile">REST API Reference for EnableProfile Operation</seealso>
        EnableProfileResponse EnableProfile(EnableProfileRequest request);
#endif

        /// <summary>
        /// Enables temporary credential requests for a profile. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:EnableProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EnableProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableProfile">REST API Reference for EnableProfile Operation</seealso>
        Task<EnableProfileResponse> EnableProfileAsync(EnableProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Enables a trust anchor. When enabled, certificates in the trust anchor chain are authorized
        /// for trust validation. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:EnableTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTrustAnchor service method.</param>
        /// <returns>The response from the EnableTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableTrustAnchor">REST API Reference for EnableTrustAnchor Operation</seealso>
        EnableTrustAnchorResponse EnableTrustAnchor(EnableTrustAnchorRequest request);
#endif

        /// <summary>
        /// Enables a trust anchor. When enabled, certificates in the trust anchor chain are authorized
        /// for trust validation. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:EnableTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EnableTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableTrustAnchor">REST API Reference for EnableTrustAnchor Operation</seealso>
        Task<EnableTrustAnchorResponse> EnableTrustAnchorAsync(EnableTrustAnchorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrl service method.</param>
        /// <returns>The response from the GetCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetCrl">REST API Reference for GetCrl Operation</seealso>
        GetCrlResponse GetCrl(GetCrlRequest request);
#endif

        /// <summary>
        /// Gets a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetCrl">REST API Reference for GetCrl Operation</seealso>
        Task<GetCrlResponse> GetCrlAsync(GetCrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets a profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <returns>The response from the GetProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        GetProfileResponse GetProfile(GetProfileRequest request);
#endif

        /// <summary>
        /// Gets a profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets a <i>subject</i>, which associates a certificate identity with authentication
        /// attempts. The subject stores auditing information such as the status of the last authentication
        /// attempt, the certificate data used in the attempt, and the last time the associated
        /// identity attempted authentication. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetSubject</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubject service method.</param>
        /// <returns>The response from the GetSubject service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetSubject">REST API Reference for GetSubject Operation</seealso>
        GetSubjectResponse GetSubject(GetSubjectRequest request);
#endif

        /// <summary>
        /// Gets a <i>subject</i>, which associates a certificate identity with authentication
        /// attempts. The subject stores auditing information such as the status of the last authentication
        /// attempt, the certificate data used in the attempt, and the last time the associated
        /// identity attempted authentication. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetSubject</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetSubject service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetSubject">REST API Reference for GetSubject Operation</seealso>
        Task<GetSubjectResponse> GetSubjectAsync(GetSubjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets a trust anchor.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustAnchor service method.</param>
        /// <returns>The response from the GetTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetTrustAnchor">REST API Reference for GetTrustAnchor Operation</seealso>
        GetTrustAnchorResponse GetTrustAnchor(GetTrustAnchorRequest request);
#endif

        /// <summary>
        /// Gets a trust anchor.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetTrustAnchor">REST API Reference for GetTrustAnchor Operation</seealso>
        Task<GetTrustAnchorResponse> GetTrustAnchorAsync(GetTrustAnchorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Imports the certificate revocation list (CRL). A CRL is a list of certificates that
        /// have been revoked by the issuing certificate Authority (CA).In order to be properly
        /// imported, a CRL must be in PEM format. IAM Roles Anywhere validates against the CRL
        /// before issuing credentials. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ImportCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCrl service method.</param>
        /// <returns>The response from the ImportCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ImportCrl">REST API Reference for ImportCrl Operation</seealso>
        ImportCrlResponse ImportCrl(ImportCrlRequest request);
#endif

        /// <summary>
        /// Imports the certificate revocation list (CRL). A CRL is a list of certificates that
        /// have been revoked by the issuing certificate Authority (CA).In order to be properly
        /// imported, a CRL must be in PEM format. IAM Roles Anywhere validates against the CRL
        /// before issuing credentials. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ImportCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ImportCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ImportCrl">REST API Reference for ImportCrl Operation</seealso>
        Task<ImportCrlResponse> ImportCrlAsync(ImportCrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all certificate revocation lists (CRL) in the authenticated account and Amazon
        /// Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListCrls</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrls service method.</param>
        /// <returns>The response from the ListCrls service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListCrls">REST API Reference for ListCrls Operation</seealso>
        ListCrlsResponse ListCrls(ListCrlsRequest request);
#endif

        /// <summary>
        /// Lists all certificate revocation lists (CRL) in the authenticated account and Amazon
        /// Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListCrls</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCrls service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListCrls">REST API Reference for ListCrls Operation</seealso>
        Task<ListCrlsResponse> ListCrlsAsync(ListCrlsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all profiles in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListProfiles</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <returns>The response from the ListProfiles service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        ListProfilesResponse ListProfiles(ListProfilesRequest request);
#endif

        /// <summary>
        /// Lists all profiles in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListProfiles</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProfiles service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the subjects in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListSubjects</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubjects service method.</param>
        /// <returns>The response from the ListSubjects service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListSubjects">REST API Reference for ListSubjects Operation</seealso>
        ListSubjectsResponse ListSubjects(ListSubjectsRequest request);
#endif

        /// <summary>
        /// Lists the subjects in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListSubjects</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSubjects service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListSubjects">REST API Reference for ListSubjects Operation</seealso>
        Task<ListSubjectsResponse> ListSubjectsAsync(ListSubjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags attached to the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListTagsForResource</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Lists the tags attached to the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListTagsForResource</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the trust anchors in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListTrustAnchors</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustAnchors service method.</param>
        /// <returns>The response from the ListTrustAnchors service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTrustAnchors">REST API Reference for ListTrustAnchors Operation</seealso>
        ListTrustAnchorsResponse ListTrustAnchors(ListTrustAnchorsRequest request);
#endif

        /// <summary>
        /// Lists the trust anchors in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListTrustAnchors</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustAnchors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTrustAnchors service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTrustAnchors">REST API Reference for ListTrustAnchors Operation</seealso>
        Task<ListTrustAnchorsResponse> ListTrustAnchorsAsync(ListTrustAnchorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Put an entry in the attribute mapping rules that will be enforced by a given profile.
        /// A mapping specifies a certificate field and one or more specifiers that have contextual
        /// meanings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAttributeMapping service method.</param>
        /// <returns>The response from the PutAttributeMapping service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/PutAttributeMapping">REST API Reference for PutAttributeMapping Operation</seealso>
        PutAttributeMappingResponse PutAttributeMapping(PutAttributeMappingRequest request);
#endif

        /// <summary>
        /// Put an entry in the attribute mapping rules that will be enforced by a given profile.
        /// A mapping specifies a certificate field and one or more specifiers that have contextual
        /// meanings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAttributeMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutAttributeMapping service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/PutAttributeMapping">REST API Reference for PutAttributeMapping Operation</seealso>
        Task<PutAttributeMappingResponse> PutAttributeMappingAsync(PutAttributeMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Attaches a list of <i>notification settings</i> to a trust anchor.
        /// 
        ///  
        /// <para>
        /// A notification setting includes information such as event name, threshold, status
        /// of the notification setting, and the channel to notify.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:PutNotificationSettings</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationSettings service method.</param>
        /// <returns>The response from the PutNotificationSettings service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/PutNotificationSettings">REST API Reference for PutNotificationSettings Operation</seealso>
        PutNotificationSettingsResponse PutNotificationSettings(PutNotificationSettingsRequest request);
#endif

        /// <summary>
        /// Attaches a list of <i>notification settings</i> to a trust anchor.
        /// 
        ///  
        /// <para>
        /// A notification setting includes information such as event name, threshold, status
        /// of the notification setting, and the channel to notify.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:PutNotificationSettings</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutNotificationSettings service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/PutNotificationSettings">REST API Reference for PutNotificationSettings Operation</seealso>
        Task<PutNotificationSettingsResponse> PutNotificationSettingsAsync(PutNotificationSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Resets the <i>custom notification setting</i> to IAM Roles Anywhere default setting.
        /// 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ResetNotificationSettings</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetNotificationSettings service method.</param>
        /// <returns>The response from the ResetNotificationSettings service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ResetNotificationSettings">REST API Reference for ResetNotificationSettings Operation</seealso>
        ResetNotificationSettingsResponse ResetNotificationSettings(ResetNotificationSettingsRequest request);
#endif

        /// <summary>
        /// Resets the <i>custom notification setting</i> to IAM Roles Anywhere default setting.
        /// 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ResetNotificationSettings</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetNotificationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ResetNotificationSettings service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ResetNotificationSettings">REST API Reference for ResetNotificationSettings Operation</seealso>
        Task<ResetNotificationSettingsResponse> ResetNotificationSettingsAsync(ResetNotificationSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Attaches tags to a resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:TagResource</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.TooManyTagsException">
        /// Too many tags.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Attaches tags to a resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:TagResource</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.TooManyTagsException">
        /// Too many tags.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes tags from the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UntagResource</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes tags from the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UntagResource</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the certificate revocation list (CRL). A CRL is a list of certificates that
        /// have been revoked by the issuing certificate authority (CA). IAM Roles Anywhere validates
        /// against the CRL before issuing credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrl service method.</param>
        /// <returns>The response from the UpdateCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateCrl">REST API Reference for UpdateCrl Operation</seealso>
        UpdateCrlResponse UpdateCrl(UpdateCrlRequest request);
#endif

        /// <summary>
        /// Updates the certificate revocation list (CRL). A CRL is a list of certificates that
        /// have been revoked by the issuing certificate authority (CA). IAM Roles Anywhere validates
        /// against the CRL before issuing credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateCrl">REST API Reference for UpdateCrl Operation</seealso>
        Task<UpdateCrlResponse> UpdateCrlAsync(UpdateCrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a <i>profile</i>, a list of the roles that IAM Roles Anywhere service is trusted
        /// to assume. You use profiles to intersect permissions with IAM managed policies.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// <returns>The response from the UpdateProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        UpdateProfileResponse UpdateProfile(UpdateProfileRequest request);
#endif

        /// <summary>
        /// Updates a <i>profile</i>, a list of the roles that IAM Roles Anywhere service is trusted
        /// to assume. You use profiles to intersect permissions with IAM managed policies.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a trust anchor. You establish trust between IAM Roles Anywhere and your certificate
        /// authority (CA) by configuring a trust anchor. You can define a trust anchor as a reference
        /// to an Private Certificate Authority (Private CA) or by uploading a CA certificate.
        /// Your Amazon Web Services workloads can authenticate with the trust anchor using certificates
        /// issued by the CA in exchange for temporary Amazon Web Services credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustAnchor service method.</param>
        /// <returns>The response from the UpdateTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateTrustAnchor">REST API Reference for UpdateTrustAnchor Operation</seealso>
        UpdateTrustAnchorResponse UpdateTrustAnchor(UpdateTrustAnchorRequest request);
#endif

        /// <summary>
        /// Updates a trust anchor. You establish trust between IAM Roles Anywhere and your certificate
        /// authority (CA) by configuring a trust anchor. You can define a trust anchor as a reference
        /// to an Private Certificate Authority (Private CA) or by uploading a CA certificate.
        /// Your Amazon Web Services workloads can authenticate with the trust anchor using certificates
        /// issued by the CA in exchange for temporary Amazon Web Services credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateTrustAnchor">REST API Reference for UpdateTrustAnchor Operation</seealso>
        Task<UpdateTrustAnchorResponse> UpdateTrustAnchorAsync(UpdateTrustAnchorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonIAMRolesAnywhereConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonIAMRolesAnywhereConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonIAMRolesAnywhereConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonIAMRolesAnywhereConfig to create AmazonIAMRolesAnywhereClient");
            }

            return awsCredentials == null ?
                    new AmazonIAMRolesAnywhereClient(serviceClientConfig) :
                    new AmazonIAMRolesAnywhereClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
